using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public class FO : Indicator
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000A956 File Offset: 0x00009956
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000A95E File Offset: 0x0000995E
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000A96D File Offset: 0x0000996D
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000A975 File Offset: 0x00009975
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000A984 File Offset: 0x00009984
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0000A98C File Offset: 0x0000998C
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

		// Token: 0x06000230 RID: 560 RVA: 0x0000A99C File Offset: 0x0000999C
		protected override void Init()
		{
			this.fName = "FO (" + this.fLength + ")";
			this.fTitle = "Forecast Oscillator";
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
					"FO (",
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

		// Token: 0x06000231 RID: 561 RVA: 0x0000AA67 File Offset: 0x00009A67
		public FO()
		{
			this.Init();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000AA7D File Offset: 0x00009A7D
		public FO(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000AAA2 File Offset: 0x00009AA2
		public FO(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000AACF File Offset: 0x00009ACF
		public FO(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000AB04 File Offset: 0x00009B04
		public FO(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000AB22 File Offset: 0x00009B22
		public FO(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000AB48 File Offset: 0x00009B48
		protected override void Calculate(int index)
		{
			double data = FO.Value(this.fInput, index, this.fLength, this.fOption, this.distanceMode);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000AB88 File Offset: 0x00009B88
		public static double Value(TimeSeries input, int index, int length, BarData option, RegressionDistanceMode distanceMode)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = input[index, option];
				double num2 = LRI.Value(input, index, length, option, distanceMode);
				return 100.0 * (num - num2) / num2;
			}
			return double.NaN;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000ABD2 File Offset: 0x00009BD2
		public static double Value(DoubleSeries input, int index, int length, RegressionDistanceMode distanceMode)
		{
			return FO.Value(input, index, length, BarData.Close, distanceMode);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000ABDE File Offset: 0x00009BDE
		public static double Value(DoubleSeries input, int index, int length)
		{
			return FO.Value(input, index, length, BarData.Close, RegressionDistanceMode.Time);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000ABEC File Offset: 0x00009BEC
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

		// Token: 0x04000067 RID: 103
		protected int fLength = 14;

		// Token: 0x04000068 RID: 104
		protected BarData fOption;

		// Token: 0x04000069 RID: 105
		protected RegressionDistanceMode distanceMode;
	}
}
