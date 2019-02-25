using System;
using System.ComponentModel;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x02000022 RID: 34
	public class Performance
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000237 RID: 567 RVA: 0x0000799C File Offset: 0x0000699C
		// (remove) Token: 0x06000238 RID: 568 RVA: 0x000079B5 File Offset: 0x000069B5
		public event EventHandler EquityChanged;

		// Token: 0x06000239 RID: 569 RVA: 0x000079D0 File Offset: 0x000069D0
		public Performance(Portfolio portfolio)
		{
			this.fPortfolio = portfolio;
			this.fPortfolio.ValueChanged += this.OnValueChanged;
			this.fPortfolio.Cleared += this.OnPortfolioCleared;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00007A6F File Offset: 0x00006A6F
		[Browsable(false)]
		public Portfolio Portfolio
		{
			get
			{
				return this.fPortfolio;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007A77 File Offset: 0x00006A77
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00007A7F File Offset: 0x00006A7F
		public bool Enabled
		{
			get
			{
				return this.fEnabled;
			}
			set
			{
				this.fEnabled = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00007A88 File Offset: 0x00006A88
		[Browsable(false)]
		public DoubleSeries EquitySeries
		{
			get
			{
				return this.fEquitySeries;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00007A90 File Offset: 0x00006A90
		[Browsable(false)]
		public DoubleSeries CoreEquitySeries
		{
			get
			{
				return this.fCoreEquitySeries;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00007A98 File Offset: 0x00006A98
		[Browsable(false)]
		public DoubleSeries PnLSeries
		{
			get
			{
				return this.fPnLSeries;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00007AA0 File Offset: 0x00006AA0
		[Browsable(false)]
		public DoubleSeries DrawdownSeries
		{
			get
			{
				return this.fDrawdownSeries;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00007AA8 File Offset: 0x00006AA8
		[Browsable(false)]
		public DoubleSeries DrawdownPercentSeries
		{
			get
			{
				return this.fDrawdownPercentSeries;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00007AB0 File Offset: 0x00006AB0
		[Browsable(false)]
		public double Equity
		{
			get
			{
				return this.fEquity;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00007AB8 File Offset: 0x00006AB8
		[Browsable(false)]
		public double CoreEquity
		{
			get
			{
				return this.fCoreEquity;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00007AC0 File Offset: 0x00006AC0
		[Browsable(false)]
		public double PnL
		{
			get
			{
				return this.fPnL;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007AC8 File Offset: 0x00006AC8
		[Browsable(false)]
		public double HighEquity
		{
			get
			{
				return this.fHighEquity;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00007AD0 File Offset: 0x00006AD0
		[Browsable(false)]
		public double LowEquity
		{
			get
			{
				return this.fLowEquity;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00007AD8 File Offset: 0x00006AD8
		[Browsable(false)]
		public double Drawdown
		{
			get
			{
				return this.fDrawdown;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00007AE0 File Offset: 0x00006AE0
		[Browsable(false)]
		public double DrawdownPercent
		{
			get
			{
				return this.fDrawdownPercent;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00007AE8 File Offset: 0x00006AE8
		[Browsable(false)]
		public double CurrentDrawdown
		{
			get
			{
				return this.fCurrentDrawdown;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00007AF0 File Offset: 0x00006AF0
		[Browsable(false)]
		public double CurrentRunUp
		{
			get
			{
				return this.fCurrentRunUp;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00007AF8 File Offset: 0x00006AF8
		private void Clear()
		{
			this.fEquitySeries.Clear();
			this.fCoreEquitySeries.Clear();
			this.fPnLSeries.Clear();
			this.fDrawdownSeries.Clear();
			this.fDrawdownPercentSeries.Clear();
			this.fEquity = 0.0;
			this.fCoreEquity = 0.0;
			this.fLowEquity = 0.0;
			this.fHighEquity = 0.0;
			this.fPnL = 0.0;
			this.fDrawdown = 0.0;
			this.fDrawdownPercent = 0.0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007BA8 File Offset: 0x00006BA8
		private void OnValueChanged(object sender, PositionEventArgs e)
		{
			if (!this.fEnabled)
			{
				return;
			}
			DateTime now = Clock.Now;
			this.updateEquity(now);
			this.updatePnL(now);
			this.updateDrawdown(now);
			if (this.EquityChanged != null)
			{
				this.EquityChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00007BF2 File Offset: 0x00006BF2
		private void OnPortfolioCleared(object sender, EventArgs e)
		{
			this.Clear();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00007BFC File Offset: 0x00006BFC
		private void updateEquity(DateTime now)
		{
			this.fCoreEquity = this.fPortfolio.GetCoreEquity();
			this.fEquity = this.fPortfolio.GetTotalEquity();
			this.fCoreEquitySeries[now] = this.fCoreEquity;
			this.fEquitySeries[now] = this.fEquity;
			if (this.fEquitySeries.Count == 1)
			{
				this.fLowEquity = this.fEquity;
				this.fHighEquity = this.fEquity;
				return;
			}
			if (this.fEquity > this.fHighEquity)
			{
				this.fHighEquity = this.fEquity;
				this.fLowEquity = this.fEquity;
				this.fCurrentDrawdown = 0.0;
			}
			if (this.fEquity < this.fLowEquity)
			{
				this.fLowEquity = this.fEquity;
				this.fCurrentRunUp = 0.0;
			}
			if (this.fEquity > this.fLowEquity && this.fEquity < this.fHighEquity)
			{
				this.fCurrentDrawdown = 1.0 - this.fEquity / this.fHighEquity;
				this.fCurrentRunUp = this.fEquity / this.fLowEquity - 1.0;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007D2C File Offset: 0x00006D2C
		private void updatePnL(DateTime now)
		{
			if (this.fEquitySeries.Count >= 2)
			{
				int lastIndex = this.fEquitySeries.LastIndex;
				int index = lastIndex - 1;
				this.fPnL = this.fEquitySeries[lastIndex] - this.fEquitySeries[index];
				this.fPnLSeries[now] = this.fPnL;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007D88 File Offset: 0x00006D88
		private void updateDrawdown(DateTime now)
		{
			if (this.fEquitySeries.Count >= 2)
			{
				this.fDrawdown = this.fEquity - this.fHighEquity;
				this.fDrawdownSeries[now] = this.fDrawdown;
				if (this.fHighEquity != 0.0)
				{
					this.fDrawdownPercent = Math.Abs(this.fDrawdown / this.fHighEquity);
					this.fDrawdownPercentSeries[now] = this.fDrawdownPercent;
				}
			}
		}

		// Token: 0x0400008E RID: 142
		private Portfolio fPortfolio;

		// Token: 0x0400008F RID: 143
		private bool fEnabled = true;

		// Token: 0x04000090 RID: 144
		private DoubleSeries fEquitySeries = new DoubleSeries("Equity");

		// Token: 0x04000091 RID: 145
		private DoubleSeries fCoreEquitySeries = new DoubleSeries("Core Equity");

		// Token: 0x04000092 RID: 146
		private DoubleSeries fPnLSeries = new DoubleSeries("PnL");

		// Token: 0x04000093 RID: 147
		private DoubleSeries fDrawdownSeries = new DoubleSeries("Drawdown");

		// Token: 0x04000094 RID: 148
		private DoubleSeries fDrawdownPercentSeries = new DoubleSeries("Drawdown");

		// Token: 0x04000095 RID: 149
		private double fEquity;

		// Token: 0x04000096 RID: 150
		private double fCoreEquity;

		// Token: 0x04000097 RID: 151
		private double fLowEquity;

		// Token: 0x04000098 RID: 152
		private double fHighEquity;

		// Token: 0x04000099 RID: 153
		private double fPnL;

		// Token: 0x0400009A RID: 154
		private double fDrawdown;

		// Token: 0x0400009B RID: 155
		private double fDrawdownPercent;

		// Token: 0x0400009C RID: 156
		private double fCurrentDrawdown;

		// Token: 0x0400009D RID: 157
		private double fCurrentRunUp;
	}
}
