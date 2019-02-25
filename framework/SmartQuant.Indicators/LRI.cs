using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class LRI : Indicator
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005780 File Offset: 0x00004780
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00005788 File Offset: 0x00004788
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(1)]
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005797 File Offset: 0x00004797
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000579F File Offset: 0x0000479F
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(0)]
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000057AE File Offset: 0x000047AE
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000057B6 File Offset: 0x000047B6
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(2)]
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

		// Token: 0x060000EA RID: 234 RVA: 0x000057C8 File Offset: 0x000047C8
		protected override void Init()
		{
			this.fName = "LRI (" + this.fLength + ")";
			this.fTitle = "Linear Regression Indicator";
			this.fType = EIndicatorType.Price;
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
					"LRI (",
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

		// Token: 0x060000EB RID: 235 RVA: 0x0000589A File Offset: 0x0000489A
		public LRI()
		{
			this.Init();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000058B0 File Offset: 0x000048B0
		public LRI(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000058D5 File Offset: 0x000048D5
		public LRI(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005902 File Offset: 0x00004902
		public LRI(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005937 File Offset: 0x00004937
		public LRI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005955 File Offset: 0x00004955
		public LRI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000597C File Offset: 0x0000497C
		protected override void Calculate(int index)
		{
			double data = LRI.Value(this.fInput, index, this.fLength, this.fOption, this.distanceMode);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000059BC File Offset: 0x000049BC
		public static double Value(TimeSeries input, int index, int length, BarData option, RegressionDistanceMode distanceMode)
		{
			if (index >= length - 1)
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				double num6;
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
					num6 = (double)input.GetDateTime(index).Subtract(input.GetDateTime(index - length + 1)).Ticks / num5;
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
					num6 = (double)(length - 1);
				}
				double num7 = ((double)length * num2 - num * num3) / ((double)length * num4 - Math.Pow(num, 2.0));
				double num8 = (num3 - num7 * num) / (double)length;
				return num7 * num6 + num8;
			}
			return double.NaN;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005BEA File Offset: 0x00004BEA
		public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
		{
			return LRI.Value(input, index, length, BarData.Close, distanceMode);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005BF6 File Offset: 0x00004BF6
		public static double Value(DoubleSeries input, int index, int length)
		{
			return LRI.Value(input, index, length, BarData.Close, RegressionDistanceMode.Time);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005C04 File Offset: 0x00004C04
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

		// Token: 0x04000027 RID: 39
		protected int fLength = 14;

		// Token: 0x04000028 RID: 40
		protected BarData fOption;

		// Token: 0x04000029 RID: 41
		private RegressionDistanceMode distanceMode;
	}
}
