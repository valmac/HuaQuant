using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class MDI : Indicator
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00007A72 File Offset: 0x00006A72
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00007A7A File Offset: 0x00006A7A
		[IndicatorParameter(0)]
		[Description("")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return this.fLength;
			}
			set
			{
				this.fLength = value;
				this.Init();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00007A89 File Offset: 0x00006A89
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00007A91 File Offset: 0x00006A91
		[Description("")]
		[IndicatorParameter(1)]
		[Category("Parameters")]
		public EIndicatorStyle Style
		{
			get
			{
				return this.fStyle;
			}
			set
			{
				this.fStyle = value;
				this.Init();
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00007AA0 File Offset: 0x00006AA0
		protected override void Init()
		{
			this.fName = "MDI (" + this.fLength + ")";
			this.fTitle = "Minus Directional Indicator";
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
			this.fMDM = new DoubleSeries();
			this.fTR = new DoubleSeries();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007B2D File Offset: 0x00006B2D
		public MDI()
		{
			this.Init();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007B43 File Offset: 0x00006B43
		public MDI(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007B68 File Offset: 0x00006B68
		public MDI(TimeSeries input, int length, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00007B95 File Offset: 0x00006B95
		public MDI(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007BCA File Offset: 0x00006BCA
		public MDI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007BE8 File Offset: 0x00006BE8
		public MDI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007C10 File Offset: 0x00006C10
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (this.fStyle == EIndicatorStyle.QuantStudio)
			{
				double num = 0.0;
				double num2 = 0.0;
				if (index >= this.fLength + this.fInput.FirstIndex)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						for (int i = index; i >= index - this.fLength + 1; i--)
						{
							num2 += TR.Value(this.fInput, i);
							num += MDM.Value(this.fInput, i);
						}
					}
					else
					{
						num = this.fMDM[index - 1] - MDM.Value(this.fInput, index - this.fLength) + MDM.Value(this.fInput, index);
						num2 = this.fTR[index - 1] - TR.Value(this.fInput, index - this.fLength) + TR.Value(this.fInput, index);
					}
					if (num2 != 0.0)
					{
						data = num / num2 * 100.0;
					}
				}
				this.fMDM.Add(this.fInput.GetDateTime(index), num);
				this.fTR.Add(this.fInput.GetDateTime(index), num2);
			}
			else
			{
				double num3 = 0.0;
				double num4 = 0.0;
				if (index >= this.fLength + this.fInput.FirstIndex)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						for (int j = index; j >= index - this.fLength + 1; j--)
						{
							num4 += TR.Value(this.fInput, j);
							num3 += MDM.Value(this.fInput, j);
						}
					}
					else
					{
						num3 = this.fMDM[index - 1] - this.fMDM[index - 1] / (double)this.fLength + MDM.Value(this.fInput, index);
						num4 = this.fTR[index - 1] - this.fTR[index - 1] / (double)this.fLength + TR.Value(this.fInput, index);
					}
					if (num4 != 0.0)
					{
						data = num3 / num4 * 100.0;
					}
				}
				this.fMDM.Add(this.fInput.GetDateTime(index), num3);
				this.fTR.Add(this.fInput.GetDateTime(index), num4);
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007EA4 File Offset: 0x00006EA4
		public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
		{
			if (style == EIndicatorStyle.QuantStudio)
			{
				double num = 0.0;
				double num2 = 0.0;
				if (index >= length + input.FirstIndex)
				{
					for (int i = index; i > index - length; i--)
					{
						num2 += TR.Value(input, i);
						num += MDM.Value(input, i);
					}
					return num / num2 * 100.0;
				}
				return double.NaN;
			}
			else
			{
				double num3 = 0.0;
				double num4 = 0.0;
				if (index >= length + input.FirstIndex)
				{
					for (int j = length + input.FirstIndex; j >= input.FirstIndex + 1; j--)
					{
						num4 += TR.Value(input, j);
						num3 += MDM.Value(input, j);
					}
					for (int k = length + 1 + input.FirstIndex; k <= index; k++)
					{
						num3 = num3 - num3 / (double)length + MDM.Value(input, k);
						num4 = num4 - num4 / (double)length + TR.Value(input, k);
					}
					return num3 / num4 * 100.0;
				}
				return double.NaN;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007FDC File Offset: 0x00006FDC
		public static double Value(TimeSeries input, int index, int length)
		{
			return MDI.Value(input, index, length, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007FE8 File Offset: 0x00006FE8
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					if (this.fStyle == EIndicatorStyle.QuantStudio)
					{
						for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength); i++)
						{
							this.Calculate(i);
						}
						return;
					}
					for (int j = index; j <= this.fInput.Count - 1; j++)
					{
						this.Calculate(j);
					}
				}
			}
		}

		// Token: 0x04000046 RID: 70
		protected EIndicatorStyle fStyle;

		// Token: 0x04000047 RID: 71
		protected int fLength = 14;

		// Token: 0x04000048 RID: 72
		protected DoubleSeries fMDM;

		// Token: 0x04000049 RID: 73
		protected DoubleSeries fTR;
	}
}
