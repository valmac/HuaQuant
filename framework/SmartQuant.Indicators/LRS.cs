using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	public class LRS : Indicator
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00009F72 File Offset: 0x00008F72
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00009F7A File Offset: 0x00008F7A
		[IndicatorParameter(1)]
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00009F89 File Offset: 0x00008F89
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00009F91 File Offset: 0x00008F91
		[Category("Parameters")]
		[IndicatorParameter(0)]
		[Description("")]
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00009FA0 File Offset: 0x00008FA0
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00009FA8 File Offset: 0x00008FA8
		[IndicatorParameter(2)]
		[Description("")]
		[Category("Parameters")]
		public RegressionDistanceMode DistanceMode
		{
			get
			{
				return this.distanceMode;
			}
			set
			{
				this.distanceMode = value;
				this.Init();
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00009FB8 File Offset: 0x00008FB8
		protected override void Init()
		{
			this.fName = "LRS (" + this.fLength + ")";
			this.fTitle = "Linear Regression Slope";
			this.fType = EIndicatorType.Oscillator;
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
					"LRS (",
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
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A08A File Offset: 0x0000908A
		public LRS()
		{
			this.Init();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000A0A0 File Offset: 0x000090A0
		public LRS(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000A0C5 File Offset: 0x000090C5
		public LRS(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000A0F2 File Offset: 0x000090F2
		public LRS(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000A127 File Offset: 0x00009127
		public LRS(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A145 File Offset: 0x00009145
		public LRS(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000A16C File Offset: 0x0000916C
		protected override void Calculate(int index)
		{
			double data = LRS.Value(this.fInput, index, this.fLength, this.fOption, this.distanceMode);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000A1AC File Offset: 0x000091AC
		public static double Value(TimeSeries input, int index, int length, BarData option, RegressionDistanceMode distanceMode)
		{
			if (index >= length - 1)
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				if (distanceMode == RegressionDistanceMode.Time)
				{
					double num5 = (double)input.GetDateTime(index).Subtract(input.GetDateTime(index - 1)).Ticks;
					for (int i = index; i > index - length; i--)
					{
						num += (double)input.GetDateTime(i).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
						num2 += (double)input.GetDateTime(i).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5 * input[i, option];
						num3 += input[i, option];
						num4 += (double)input.GetDateTime(i).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5 * (double)input.GetDateTime(i).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
					}
				}
				else
				{
					for (int j = index; j > index - length; j--)
					{
						num += (double)(j - index + length - 1);
						num2 += (double)(j - index + length - 1) * input[j, option];
						num3 += input[j, option];
						num4 += (double)((j - index + length - 1) * (j - index + length - 1));
					}
				}
				return ((double)length * num2 - num * num3) / ((double)length * num4 - Math.Pow(num, 2.0));
			}
			return double.NaN;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000A37F File Offset: 0x0000937F
		public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
		{
			return LRS.Value(input, index, length, BarData.Close, distanceMode);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000A38B File Offset: 0x0000938B
		public static double Value(DoubleSeries input, int index, int length)
		{
			return LRS.Value(input, index, length, BarData.Close, RegressionDistanceMode.Time);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000A398 File Offset: 0x00009398
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400005F RID: 95
		protected int fLength = 14;

		// Token: 0x04000060 RID: 96
		protected BarData fOption;

		// Token: 0x04000061 RID: 97
		private RegressionDistanceMode distanceMode;
	}
}
