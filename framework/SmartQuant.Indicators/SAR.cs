using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class SAR : Indicator
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000063BD File Offset: 0x000053BD
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000063C5 File Offset: 0x000053C5
		[Category("Parameters")]
		[IndicatorParameter(1)]
		[Description("The maximum possible value of the Acceleration Factor")]
		public double UpperBound
		{
			get
			{
				return this.upperBound;
			}
			set
			{
				this.upperBound = value;
				this.Init();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000063D4 File Offset: 0x000053D4
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000063DC File Offset: 0x000053DC
		[Description("Step that is used to increment the Acceleration Factor")]
		[Category("Parameters")]
		[IndicatorParameter(2)]
		public double Step
		{
			get
			{
				return this.step;
			}
			set
			{
				this.step = value;
				this.Init();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000063EB File Offset: 0x000053EB
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000063F3 File Offset: 0x000053F3
		[Description("Initial value of the Acceleration Factor")]
		[IndicatorParameter(3)]
		[Category("Parameters")]
		public double InitialAcc
		{
			get
			{
				return this.initialAcc;
			}
			set
			{
				this.initialAcc = value;
				this.Init();
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006404 File Offset: 0x00005404
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"SAR (",
				this.upperBound,
				", ",
				this.step,
				", ",
				this.initialAcc,
				")"
			});
			this.fTitle = "Parabolic SAR";
			this.fType = EIndicatorType.Price;
			this.Clear();
			this.ResetSAR();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000064C8 File Offset: 0x000054C8
		private void ResetSAR()
		{
			this.lastSAR = 0.0;
			this.sar = 0.0;
			this.sip = 0.0;
			this.acc = 0.0;
			this.diff = 0.0;
			this.prevLow = 0.0;
			this.prevHigh = 0.0;
			this.minClose = double.MaxValue;
			this.barsCount = 0;
			this.isLong = false;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000655B File Offset: 0x0000555B
		public SAR()
		{
			this.Init();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006598 File Offset: 0x00005598
		public SAR(TimeSeries input, double upperBound, double step, double initialAcc) : base(input)
		{
			this.upperBound = upperBound;
			this.step = step;
			this.initialAcc = initialAcc;
			this.Init();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000065F5 File Offset: 0x000055F5
		public SAR(TimeSeries input, double upperBound, double step, double initialAcc, Color color) : this(input, upperBound, step, initialAcc)
		{
			base.Color = color;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000660C File Offset: 0x0000560C
		protected override void Calculate(int index)
		{
			Bar bar = base.Input[index] as Bar;
			if (this.barsCount > 20)
			{
				this.lastSAR = this.sar;
				if (this.isLong)
				{
					if (bar.High > this.sip)
					{
						this.sip = bar.High;
						if (this.acc < this.upperBound)
						{
							this.acc += this.step;
						}
					}
					if (bar.Low < this.sar)
					{
						this.isLong = false;
					}
					if (this.isLong)
					{
						this.diff = this.sip - this.sar;
						this.sar += this.diff * this.acc;
						if (this.sar > bar.Low || this.sar > this.prevLow)
						{
							if (bar.Low < this.prevLow)
							{
								this.sar = bar.Low;
							}
							else
							{
								this.sar = this.prevLow;
							}
						}
						if (this.sar < this.lastSAR)
						{
							this.sar = this.lastSAR;
						}
						this.Add(bar.DateTime, this.sar);
					}
					else
					{
						this.sar = this.sip;
						this.acc = this.initialAcc;
						this.Add(bar.DateTime, this.sar);
					}
				}
				else
				{
					if (this.prevLow < this.sip)
					{
						this.sip = this.prevLow;
						if (this.acc < this.upperBound)
						{
							this.acc += this.step;
						}
					}
					if (bar.High > this.sar)
					{
						this.isLong = true;
					}
					if (!this.isLong)
					{
						this.diff = this.sar - this.sip;
						this.sar -= this.diff * this.acc;
						if (this.sar < bar.High || this.sar < this.prevHigh)
						{
							if (bar.High > this.prevHigh)
							{
								this.sar = bar.High;
							}
							else
							{
								this.sar = this.prevHigh;
							}
						}
						if (this.sar > this.lastSAR)
						{
							this.sar = this.lastSAR;
						}
						this.Add(bar.DateTime, this.sar);
					}
					else
					{
						this.sar = this.sip;
						this.acc = this.initialAcc;
						this.Add(bar.DateTime, this.sar);
					}
				}
			}
			else if (this.barsCount == 20)
			{
				this.isLong = true;
				this.sip = this.minClose;
				this.sar = this.sip;
			}
			else
			{
				this.minClose = Math.Min(this.minClose, bar.Close);
			}
			this.barsCount++;
			this.prevHigh = bar.High;
			this.prevLow = bar.Low;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006909 File Offset: 0x00005909
		public static double Value(BarSeries input, int index, double upperBound, double step, double initialAcc)
		{
			if (index >= input.FirstIndex)
			{
				return new SAR(input, upperBound, step, initialAcc)[index];
			}
			return double.NaN;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006930 File Offset: 0x00005930
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					if (index == this.fInput.Count - 1)
					{
						this.Calculate(index);
						return;
					}
					this.ResetSAR();
					this.Clear();
					for (int i = 0; i <= this.fInput.Count - 1; i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400002F RID: 47
		private double upperBound = 0.2;

		// Token: 0x04000030 RID: 48
		private double step = 0.001;

		// Token: 0x04000031 RID: 49
		private double initialAcc = 0.02;

		// Token: 0x04000032 RID: 50
		private double lastSAR;

		// Token: 0x04000033 RID: 51
		private double sar;

		// Token: 0x04000034 RID: 52
		private double sip;

		// Token: 0x04000035 RID: 53
		private double acc;

		// Token: 0x04000036 RID: 54
		private double diff;

		// Token: 0x04000037 RID: 55
		private double prevLow;

		// Token: 0x04000038 RID: 56
		private double prevHigh;

		// Token: 0x04000039 RID: 57
		private double minClose;

		// Token: 0x0400003A RID: 58
		private int barsCount;

		// Token: 0x0400003B RID: 59
		private bool isLong;
	}
}
