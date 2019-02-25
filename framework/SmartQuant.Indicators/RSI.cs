using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class RSI : Indicator
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000D7EE File Offset: 0x0000C7EE
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0000D7F6 File Offset: 0x0000C7F6
		[Description("")]
		[IndicatorParameter(1)]
		[Category("Parameters")]
		public BarData Option
		{
			get
			{
				return this.fOption;
			}
			set
			{
				this.fOption = value;
				this.Init();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000D805 File Offset: 0x0000C805
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000D80D File Offset: 0x0000C80D
		[Description("")]
		[IndicatorParameter(0)]
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000D81C File Offset: 0x0000C81C
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000D824 File Offset: 0x0000C824
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(2)]
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

		// Token: 0x06000309 RID: 777 RVA: 0x0000D834 File Offset: 0x0000C834
		protected override void Init()
		{
			this.fName = "RSI (" + this.fLength + ")";
			this.fTitle = "Relative Strength Index";
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (this.fInput is BarSeries)
			{
				this.fName = string.Concat(new object[]
				{
					"RSI (",
					this.fLength,
					", ",
					this.fOption,
					")"
				});
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
			this.fUp = new DoubleSeries();
			this.fDown = new DoubleSeries();
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000D915 File Offset: 0x0000C915
		public RSI()
		{
			this.Init();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000D92B File Offset: 0x0000C92B
		public RSI(TimeSeries input, int length, BarData option, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000D958 File Offset: 0x0000C958
		public RSI(TimeSeries input, int length, BarData option, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000D98D File Offset: 0x0000C98D
		public RSI(TimeSeries input, int length, BarData option, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000D9CA File Offset: 0x0000C9CA
		public RSI(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000D9EF File Offset: 0x0000C9EF
		public RSI(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000DA14 File Offset: 0x0000CA14
		public RSI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000DA32 File Offset: 0x0000CA32
		public RSI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000DA58 File Offset: 0x0000CA58
		protected override void Calculate(int index)
		{
			double num = 0.0;
			double num2 = 0.0;
			double data = double.NaN;
			if (index >= this.fLength + this.fInput.FirstIndex)
			{
				if (this.fStyle == EIndicatorStyle.QuantStudio)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						double num3 = this.fInput[index - this.fLength, this.fOption];
						for (int i = index - this.fLength + 1; i <= index; i++)
						{
							double num4 = this.fInput[i, this.fOption];
							if (num4 > num3)
							{
								num += num4 - num3;
							}
							else
							{
								num2 += num3 - num4;
							}
							num3 = num4;
						}
					}
					else
					{
						num = this.fUp[index - 1] * (double)this.fLength;
						num2 = this.fDown[index - 1] * (double)this.fLength;
						double num4 = this.fInput[index, this.fOption];
						double num3 = this.fInput[index - 1, this.fOption];
						if (num4 > num3)
						{
							num += num4 - num3;
						}
						else
						{
							num2 += num3 - num4;
						}
						num4 = this.fInput[index - this.fLength, this.fOption];
						num3 = this.fInput[index - this.fLength - 1, this.fOption];
						if (num4 > num3)
						{
							num -= num4 - num3;
						}
						else
						{
							num2 -= num3 - num4;
						}
					}
				}
				else if (index == this.fLength + this.fInput.FirstIndex)
				{
					double num3 = this.fInput[index - this.fLength, this.fOption];
					for (int j = index - this.fLength + 1; j <= index; j++)
					{
						double num4 = this.fInput[j, this.fOption];
						if (num4 > num3)
						{
							num += num4 - num3;
						}
						else
						{
							num2 += num3 - num4;
						}
						num3 = num4;
					}
				}
				else
				{
					num = this.fUp[index - 1] * (double)(this.fLength - 1);
					num2 = this.fDown[index - 1] * (double)(this.fLength - 1);
					double num4 = this.fInput[index, this.fOption];
					double num3 = this.fInput[index - 1, this.fOption];
					if (num4 > num3)
					{
						num += num4 - num3;
					}
					else
					{
						num2 += num3 - num4;
					}
				}
				data = 100.0 - 100.0 / (1.0 + num / num2);
				num /= (double)this.fLength;
				num2 /= (double)this.fLength;
			}
			this.Add(this.fInput.GetDateTime(index), data);
			this.fUp.Add(this.fInput.GetDateTime(index), num);
			this.fDown.Add(this.fInput.GetDateTime(index), num2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000DD44 File Offset: 0x0000CD44
		public static double Value(TimeSeries input, int index, int length, BarData option, EIndicatorStyle style)
		{
			double num = 0.0;
			double num2 = 0.0;
			if (index >= length + input.FirstIndex)
			{
				if (style == EIndicatorStyle.QuantStudio)
				{
					double num3 = input[index - length, option];
					for (int i = index - length + 1; i <= index; i++)
					{
						double num4 = input[i, option];
						if (num4 > num3)
						{
							num += num4 - num3;
						}
						else
						{
							num2 += num3 - num4;
						}
						num3 = num4;
					}
				}
				else
				{
					double num3 = input[input.FirstIndex, option];
					for (int j = 1 + input.FirstIndex; j <= length + input.FirstIndex; j++)
					{
						double num4 = input[j, option];
						if (num4 > num3)
						{
							num += num4 - num3;
						}
						else
						{
							num2 += num3 - num4;
						}
						num3 = num4;
					}
					num /= (double)length;
					num2 /= (double)length;
					num3 = input[length + input.FirstIndex, option];
					for (int k = length + 1 + input.FirstIndex; k <= index; k++)
					{
						num *= (double)(length - 1);
						num2 *= (double)(length - 1);
						double num4 = input[k, option];
						if (num4 > num3)
						{
							num += num4 - num3;
						}
						else
						{
							num2 += num3 - num4;
						}
						num3 = num4;
						num /= (double)length;
						num2 /= (double)length;
					}
				}
				return 100.0 - 100.0 / (1.0 + num / num2);
			}
			return double.NaN;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000DEAB File Offset: 0x0000CEAB
		public static double Value(DoubleSeries input, int index, int length, EIndicatorStyle style)
		{
			return RSI.Value(input, index, length, BarData.Close, style);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000DEB7 File Offset: 0x0000CEB7
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			return RSI.Value(input, index, length, option, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000DEC4 File Offset: 0x0000CEC4
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

		// Token: 0x04000090 RID: 144
		protected EIndicatorStyle fStyle;

		// Token: 0x04000091 RID: 145
		protected int fLength = 14;

		// Token: 0x04000092 RID: 146
		protected BarData fOption;

		// Token: 0x04000093 RID: 147
		protected DoubleSeries fUp;

		// Token: 0x04000094 RID: 148
		protected DoubleSeries fDown;
	}
}
