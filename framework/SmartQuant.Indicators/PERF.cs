using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class PERF : Indicator
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000E631 File Offset: 0x0000D631
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000E639 File Offset: 0x0000D639
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000E648 File Offset: 0x0000D648
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0000E650 File Offset: 0x0000D650
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(0)]
		public double K
		{
			get
			{
				return this.fK;
			}
			set
			{
				this.fK = value;
				this.Init();
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000E660 File Offset: 0x0000D660
		protected override void Init()
		{
			this.fName = "PERF (" + this.fK + ")";
			this.fTitle = "Performance Indicator";
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
					"PERF (",
					this.fK,
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

		// Token: 0x06000325 RID: 805 RVA: 0x0000E72B File Offset: 0x0000D72B
		public PERF()
		{
			this.Init();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000E748 File Offset: 0x0000D748
		public PERF(TimeSeries input, double k, BarData option) : base(input)
		{
			this.fOption = option;
			this.fK = k;
			this.Init();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000E774 File Offset: 0x0000D774
		public PERF(TimeSeries input, double k, BarData option, Color color) : base(input)
		{
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000E7A8 File Offset: 0x0000D7A8
		public PERF(TimeSeries input, double k, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000E7E4 File Offset: 0x0000D7E4
		public PERF(TimeSeries input, double k) : base(input)
		{
			this.fK = k;
			this.Init();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000E809 File Offset: 0x0000D809
		public PERF(TimeSeries input, double k, Color color) : base(input)
		{
			this.fK = k;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000E838 File Offset: 0x0000D838
		protected override void Calculate(int index)
		{
			double data = PERF.Value(this.fInput, index, this.fK, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000E874 File Offset: 0x0000D874
		public static double Value(TimeSeries input, int index, double k, BarData option)
		{
			if (index >= input.FirstIndex)
			{
				double num = input[index, option];
				return 100.0 * (num - k) / k;
			}
			return double.NaN;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000E8AE File Offset: 0x0000D8AE
		public static double Value(DoubleSeries input, int index, double k)
		{
			return PERF.Value(input, index, k, BarData.Close);
		}

		// Token: 0x040000A0 RID: 160
		protected double fK = 14.0;

		// Token: 0x040000A1 RID: 161
		protected BarData fOption;
	}
}
