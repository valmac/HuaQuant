using System;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000013 RID: 19
	public class PortfolioStop : IStop
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00005129 File Offset: 0x00004129
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00005131 File Offset: 0x00004131
		public StopFillMode FillMode
		{
			get
			{
				return this.fillMode;
			}
			set
			{
				this.fillMode = value;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000513C File Offset: 0x0000413C
		public PortfolioStop(StrategyBase strategy, double level, StopType type, StopMode mode, bool stopStrategy)
		{
			this.strategy = strategy;
			this.portfolio = strategy.Portfolio;
			this.level = level;
			this.type = type;
			this.mode = mode;
			this.stopStrategy = stopStrategy;
			this.currValue = this.portfolio.GetValue();
			this.trailValue = this.currValue;
			this.stopValue = this.GetStopValue();
			this.creationTime = Clock.Now;
			this.completionTime = DateTime.MinValue;
			this.Connect();
			this.fillValue = this.currValue;
			this.trailValue = this.currValue;
			this.CheckStop();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000051F8 File Offset: 0x000041F8
		public PortfolioStop(StrategyBase strategy, DateTime time, bool stopStrategy)
		{
			this.strategy = strategy;
			this.portfolio = strategy.Portfolio;
			this.stopStrategy = stopStrategy;
			this.type = StopType.Time;
			this.creationTime = Clock.Now;
			this.completionTime = time;
			this.stopValue = this.portfolio.GetValue();
			if (this.completionTime > this.creationTime)
			{
				Clock.AddReminder(new ReminderEventHandler(this.OnClock), this.completionTime, null);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005290 File Offset: 0x00004290
		private double GetStopValue()
		{
			this.initValue = this.trailValue;
			switch (this.mode)
			{
			case StopMode.Absolute:
				return this.trailValue - Math.Abs(this.level);
			case StopMode.Percent:
				return this.trailValue - Math.Abs(this.trailValue * this.level);
			default:
				throw new ArgumentException("Unknown stop mode : " + this.mode);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005307 File Offset: 0x00004307
		private void Connect()
		{
			this.portfolio.ValueChanged += this.portfolio_ValueChanged;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005320 File Offset: 0x00004320
		public void Disconnect()
		{
			this.portfolio.ValueChanged -= this.portfolio_ValueChanged;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005339 File Offset: 0x00004339
		private void portfolio_ValueChanged(object sender, PositionEventArgs args)
		{
			this.currValue = this.portfolio.GetValue();
			this.fillValue = this.portfolio.GetValue();
			this.trailValue = this.portfolio.GetValue();
			this.CheckStop();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005374 File Offset: 0x00004374
		private void CheckStop()
		{
			if (this.currValue == 0.0)
			{
				return;
			}
			lock (this)
			{
				if (this.currValue <= this.stopValue)
				{
					this.strategy.ClosePortfolio();
					if (this.stopStrategy)
					{
						this.strategy.IsActive = false;
					}
					this.Disconnect();
					this.Complete(StopStatus.Executed);
				}
				else if (this.type == StopType.Trailing && this.currValue > this.initValue)
				{
					this.stopValue = this.GetStopValue();
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005414 File Offset: 0x00004414
		private void Complete(StopStatus status)
		{
			this.status = status;
			this.completionTime = Clock.Now;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005428 File Offset: 0x00004428
		private void OnClock(ReminderEventArgs args)
		{
			if (args.SignalTime > Clock.Now)
			{
				return;
			}
			this.stopValue = this.portfolio.GetValue();
			this.strategy.ClosePortfolio();
			if (this.stopStrategy)
			{
				this.strategy.IsActive = false;
			}
			this.Complete(StopStatus.Executed);
		}

		// Token: 0x04000049 RID: 73
		private StrategyBase strategy;

		// Token: 0x0400004A RID: 74
		private Portfolio portfolio;

		// Token: 0x0400004B RID: 75
		private StopType type = StopType.Trailing;

		// Token: 0x0400004C RID: 76
		private StopMode mode = StopMode.Percent;

		// Token: 0x0400004D RID: 77
		private StopStatus status;

		// Token: 0x0400004E RID: 78
		private DateTime creationTime;

		// Token: 0x0400004F RID: 79
		private DateTime completionTime;

		// Token: 0x04000050 RID: 80
		private double level;

		// Token: 0x04000051 RID: 81
		private double initValue;

		// Token: 0x04000052 RID: 82
		private double currValue;

		// Token: 0x04000053 RID: 83
		private double stopValue;

		// Token: 0x04000054 RID: 84
		private double fillValue;

		// Token: 0x04000055 RID: 85
		private double trailValue;

		// Token: 0x04000056 RID: 86
		private StopFillMode fillMode = StopFillMode.Stop;

		// Token: 0x04000057 RID: 87
		private bool stopStrategy;
	}
}
