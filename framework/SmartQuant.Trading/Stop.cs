using System;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000071 RID: 113
	public class Stop : StopBase
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00010C06 File Offset: 0x0000FC06
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00010C0E File Offset: 0x0000FC0E
		public StopFillMode FillMode
		{
			get
			{
				return this.fFillMode;
			}
			set
			{
				this.fFillMode = value;
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00010C18 File Offset: 0x0000FC18
		public Stop(StrategyBase strategy, Position position, double level, StopType type, StopMode mode)
		{
			this.fStrategy = strategy;
			this.fPosition = position;
			this.fInstrument = position.Instrument;
			this.fQty = position.Qty;
			this.fSide = position.Side;
			this.fLevel = level;
			this.fType = type;
			this.fMode = mode;
			this.fCurrPrice = this.fInstrument.Price();
			this.fTrailPrice = this.fCurrPrice;
			this.fStopPrice = this.GetStopPrice();
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = DateTime.MinValue;
			this.fStrategy.AddStop(this);
			this.Connect();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00010CC8 File Offset: 0x0000FCC8
		public Stop(StrategyBase strategy, Position position, DateTime time)
		{
			this.fStrategy = strategy;
			this.fPosition = position;
			this.fInstrument = position.Instrument;
			this.fQty = position.Qty;
			this.fSide = position.Side;
			this.fType = StopType.Time;
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = time;
			this.fStopPrice = this.fInstrument.Price();
			if (this.fCompletionTime > this.fCreationTime)
			{
				Clock.AddReminder(new ReminderEventHandler(this.OnClock), this.fCompletionTime, null);
				this.fStrategy.AddStop(this);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00010D6E File Offset: 0x0000FD6E
		public Stop(StrategyBase strategy, double level, StopType type, StopMode mode) : this(strategy, null, level, type, mode)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00010D7C File Offset: 0x0000FD7C
		[Browsable(false)]
		public override Instrument Instrument
		{
			get
			{
				return this.fInstrument;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00010D84 File Offset: 0x0000FD84
		[Browsable(false)]
		public bool Connected
		{
			get
			{
				return this.connected;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00010D8C File Offset: 0x0000FD8C
		private double GetStopPrice()
		{
			this.fInitPrice = this.fTrailPrice;
			switch (this.fMode)
			{
			case StopMode.Absolute:
				switch (this.fSide)
				{
				case PositionSide.Long:
					return this.fTrailPrice - Math.Abs(this.fLevel);
				case PositionSide.Short:
					return this.fTrailPrice + Math.Abs(this.fLevel);
				default:
					throw new ArgumentException("Unknown position side : " + this.fPosition.Side);
				}
				break;
			case StopMode.Percent:
				switch (this.fPosition.Side)
				{
				case PositionSide.Long:
					return this.fTrailPrice - Math.Abs(this.fTrailPrice * this.fLevel);
				case PositionSide.Short:
					return this.fTrailPrice + Math.Abs(this.fTrailPrice * this.fLevel);
				default:
					throw new ArgumentException("Unknown position side : " + this.fPosition.Side);
				}
				break;
			default:
				throw new ArgumentException("Unknown stop mode : " + this.fMode);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00010EA6 File Offset: 0x0000FEA6
		public void Cancel()
		{
			if (this.fStatus != StopStatus.Active)
			{
				return;
			}
			this.Disconnect();
			this.Complete(StopStatus.Canceled);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00010EBE File Offset: 0x0000FEBE
		private void Connect()
		{
			this.connected = true;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00010EC7 File Offset: 0x0000FEC7
		public override void Disconnect()
		{
			if (base.Type == StopType.Time)
			{
				Clock.RemoveReminder(new ReminderEventHandler(this.OnClock), this.fCompletionTime);
				return;
			}
			this.connected = false;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00010EF4 File Offset: 0x0000FEF4
		private void CheckStop()
		{
			if (this.fCurrPrice == 0.0)
			{
				return;
			}
			lock (this)
			{
				switch (this.fSide)
				{
				case PositionSide.Long:
					if (this.fCurrPrice <= this.fStopPrice)
					{
						this.fStrategy.ClosePosition(this.fInstrument, this.fFillPrice, ComponentType.Stop, "PositionStop");
						this.Disconnect();
						this.Complete(StopStatus.Executed);
					}
					else if (this.fType == StopType.Trailing && this.fTrailPrice > this.fInitPrice)
					{
						this.fStopPrice = this.GetStopPrice();
					}
					break;
				case PositionSide.Short:
					if (this.fCurrPrice >= this.fStopPrice)
					{
						this.fStrategy.ClosePosition(this.fInstrument, this.fFillPrice, ComponentType.Stop, "PositionStop");
						this.Disconnect();
						this.Complete(StopStatus.Executed);
					}
					else if (this.fType == StopType.Trailing && this.fTrailPrice < this.fInitPrice)
					{
						this.fStopPrice = this.GetStopPrice();
					}
					break;
				}
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00011018 File Offset: 0x00010018
		internal void OnPositionClosed(Position position)
		{
			if (position == this.fPosition)
			{
				this.Disconnect();
				this.Complete(StopStatus.Canceled);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00011030 File Offset: 0x00010030
		internal void OnNewBar(Bar bar)
		{
			if (this.fTraceOnBar && (this.fFilterBarSize < 0L || (this.fFilterBarSize == bar.Size && this.fFilterBarType == BarType.Time)))
			{
				this.fTrailPrice = bar.Close;
				switch (this.fSide)
				{
				case PositionSide.Long:
					this.fCurrPrice = bar.Low;
					this.fFillPrice = bar.Low;
					if (this.fTrailOnHighLow)
					{
						this.fTrailPrice = bar.High;
					}
					break;
				case PositionSide.Short:
					this.fCurrPrice = bar.High;
					this.fFillPrice = bar.High;
					if (this.fTrailOnHighLow)
					{
						this.fTrailPrice = bar.Low;
					}
					break;
				}
				switch (this.fFillMode)
				{
				case StopFillMode.Close:
					this.fFillPrice = bar.Close;
					break;
				case StopFillMode.Stop:
					this.fFillPrice = this.fStopPrice;
					break;
				}
				this.CheckStop();
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00011128 File Offset: 0x00010128
		internal void OnNewBarOpen(Bar bar)
		{
			if (this.fTraceOnBar && this.fTraceOnBarOpen && (this.fFilterBarSize < 0L || (this.fFilterBarSize == bar.Size && this.fFilterBarType == BarType.Time)))
			{
				this.fCurrPrice = bar.Open;
				this.fFillPrice = bar.Open;
				if (this.fTrailOnOpen)
				{
					this.fTrailPrice = bar.Open;
				}
				this.CheckStop();
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00011198 File Offset: 0x00010198
		internal void OnNewTrade(Trade trade)
		{
			if (this.fTraceOnTrade)
			{
				this.fCurrPrice = trade.Price;
				this.fFillPrice = trade.Price;
				this.fTrailPrice = trade.Price;
				this.CheckStop();
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000111CC File Offset: 0x000101CC
		internal void OnNewQuote(Quote quote)
		{
			if (this.fTraceOnQuote)
			{
				switch (this.fSide)
				{
				case PositionSide.Long:
					this.fCurrPrice = quote.Ask;
					break;
				case PositionSide.Short:
					this.fCurrPrice = quote.Bid;
					break;
				}
				this.fFillPrice = this.fCurrPrice;
				this.fTrailPrice = this.fCurrPrice;
				this.CheckStop();
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00011230 File Offset: 0x00010230
		private void Complete(StopStatus status)
		{
			this.fStatus = status;
			this.fCompletionTime = Clock.Now;
			this.fStrategy.EmitStopStatusChanged(this);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00011250 File Offset: 0x00010250
		private void OnClock(ReminderEventArgs args)
		{
			this.fStopPrice = this.fInstrument.Price();
			this.Complete(StopStatus.Executed);
			this.fStrategy.ClosePosition(this.fInstrument, this.fStopPrice, ComponentType.Stop, "PositionStop");
		}

		// Token: 0x04000165 RID: 357
		private StrategyBase fStrategy;

		// Token: 0x04000166 RID: 358
		private bool connected;
	}
}
