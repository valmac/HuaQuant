using System;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.Instruments;
using SmartQuant.Series;

namespace SmartQuant.Trading
{
	// Token: 0x02000021 RID: 33
	public class ATSStop : StopBase
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000161 RID: 353 RVA: 0x00005DFB File Offset: 0x00004DFB
		// (remove) Token: 0x06000162 RID: 354 RVA: 0x00005E14 File Offset: 0x00004E14
		public event StopEventHandler StatusChanged;

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00005E2D File Offset: 0x00004E2D
		[Browsable(false)]
		public DoubleSeries Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00005E35 File Offset: 0x00004E35
		[Browsable(false)]
		public PositionSide Side
		{
			get
			{
				return this.fSide;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005E3D File Offset: 0x00004E3D
		[Browsable(false)]
		public override Instrument Instrument
		{
			get
			{
				return this.fInstrument;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00005E45 File Offset: 0x00004E45
		[Browsable(false)]
		public double FillPrice
		{
			get
			{
				return this.fFillPrice;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00005E4D File Offset: 0x00004E4D
		[Browsable(false)]
		public double StopPrice
		{
			get
			{
				return this.fStopPrice;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00005E55 File Offset: 0x00004E55
		[Browsable(false)]
		public bool Connected
		{
			get
			{
				return this.connected;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00005E5D File Offset: 0x00004E5D
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00005E65 File Offset: 0x00004E65
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

		// Token: 0x0600016B RID: 363 RVA: 0x00005E70 File Offset: 0x00004E70
		public ATSStop(Position position, double level, StopType type, StopMode mode)
		{
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
			this.series = new DoubleSeries();
			if (this.fType == StopType.Trailing)
			{
				this.series.Add(this.fCreationTime, this.GetStopPrice());
			}
			this.Connect();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005F34 File Offset: 0x00004F34
		public ATSStop(Position position, DateTime time)
		{
			this.fPosition = position;
			this.fInstrument = position.Instrument;
			this.fQty = position.Qty;
			this.fSide = position.Side;
			this.fType = StopType.Time;
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = time;
			this.fStopPrice = this.fInstrument.Price();
			this.series = new DoubleSeries();
			if (this.fType == StopType.Trailing)
			{
				this.series.Add(this.fCreationTime, this.GetStopPrice());
			}
			if (this.fCompletionTime > this.fCreationTime)
			{
				Clock.AddReminder(new ReminderEventHandler(this.OnClock), this.fCompletionTime, null);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005FF2 File Offset: 0x00004FF2
		public void Cancel()
		{
			if (this.fStatus != StopStatus.Active)
			{
				return;
			}
			if (this.fType == StopType.Time)
			{
				Clock.RemoveReminder(new ReminderEventHandler(this.OnClock));
			}
			else
			{
				this.Disconnect();
			}
			this.Complete(StopStatus.Canceled);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00006028 File Offset: 0x00005028
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

		// Token: 0x0600016F RID: 367 RVA: 0x00006142 File Offset: 0x00005142
		private void Connect()
		{
			this.connected = true;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000614B File Offset: 0x0000514B
		public override void Disconnect()
		{
			if (base.Type == StopType.Time)
			{
				Clock.RemoveReminder(new ReminderEventHandler(this.OnClock), this.fCompletionTime);
				return;
			}
			this.connected = false;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00006178 File Offset: 0x00005178
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

		// Token: 0x06000172 RID: 370 RVA: 0x00006254 File Offset: 0x00005254
		public void OnPositionClosed(Position position)
		{
			if (position == this.fPosition)
			{
				this.Disconnect();
				this.Complete(StopStatus.Canceled);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000626C File Offset: 0x0000526C
		public void OnNewBar(Bar bar)
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
			if (this.fType == StopType.Trailing)
			{
				this.series.Add(bar.DateTime, this.fStopPrice);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006384 File Offset: 0x00005384
		public void OnNewBarOpen(Bar bar)
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

		// Token: 0x06000175 RID: 373 RVA: 0x000063F4 File Offset: 0x000053F4
		public void OnNewTrade(Trade trade)
		{
			if (this.fTraceOnTrade)
			{
				this.fCurrPrice = trade.Price;
				this.fFillPrice = trade.Price;
				this.fTrailPrice = trade.Price;
				this.CheckStop();
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006428 File Offset: 0x00005428
		public void OnNewQuote(Quote quote)
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

		// Token: 0x06000177 RID: 375 RVA: 0x0000648C File Offset: 0x0000548C
		private void Complete(StopStatus status)
		{
			this.fStatus = status;
			this.fCompletionTime = Clock.Now;
			if (this.fType == StopType.Trailing)
			{
				this.series.Add(this.fCompletionTime, this.fStopPrice);
			}
			this.EmitStatusChanged();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000064C6 File Offset: 0x000054C6
		private void OnClock(ReminderEventArgs args)
		{
			this.fStopPrice = this.fInstrument.Price();
			this.Complete(StopStatus.Executed);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000064E0 File Offset: 0x000054E0
		private void EmitStatusChanged()
		{
			if (this.StatusChanged != null)
			{
				this.StatusChanged(new StopEventArgs(this));
			}
		}

		// Token: 0x04000082 RID: 130
		private bool connected;

		// Token: 0x04000083 RID: 131
		private DoubleSeries series;
	}
}
