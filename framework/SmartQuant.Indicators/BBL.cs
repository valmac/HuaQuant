using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	public class BBL : Indicator
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000AC45 File Offset: 0x00009C45
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000AC4D File Offset: 0x00009C4D
		[Description("")]
		[IndicatorParameter(2)]
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000AC5C File Offset: 0x00009C5C
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000AC64 File Offset: 0x00009C64
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0000AC73 File Offset: 0x00009C73
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0000AC7B File Offset: 0x00009C7B
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(1)]
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

		// Token: 0x06000242 RID: 578 RVA: 0x0000AC8C File Offset: 0x00009C8C
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"BBL (",
				this.fLength,
				" ,",
				this.fK,
				")"
			});
			this.fTitle = "Bollinger Band Lower";
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
					"BBL (",
					this.fLength,
					", ",
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

		// Token: 0x06000243 RID: 579 RVA: 0x0000AD9B File Offset: 0x00009D9B
		public BBL()
		{
			this.Init();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000ADC0 File Offset: 0x00009DC0
		public BBL(TimeSeries input, int length, double k, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000ADFC File Offset: 0x00009DFC
		public BBL(TimeSeries input, int length, double k, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000AE4C File Offset: 0x00009E4C
		public BBL(TimeSeries input, int length, double k, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000AEA3 File Offset: 0x00009EA3
		public BBL(TimeSeries input, int length, double k) : base(input)
		{
			this.fLength = length;
			this.fK = k;
			this.Init();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000AED7 File Offset: 0x00009ED7
		public BBL(TimeSeries input, int length, double k, Color color) : base(input)
		{
			this.fLength = length;
			this.fK = k;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000AF14 File Offset: 0x00009F14
		protected override void Calculate(int index)
		{
			double data = BBL.Value(this.fInput, index, this.fLength, this.fK, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000AF54 File Offset: 0x00009F54
		public static double Value(TimeSeries input, int index, int length, double k, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				return SMA.Value(input, index, length, option) - k * SMD.Value(input, index, length, option);
			}
			return double.NaN;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000AF91 File Offset: 0x00009F91
		public static double Value(DoubleSeries input, int index, int length, double k)
		{
			return BBL.Value(input, index, length, k, BarData.Close);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000AFA0 File Offset: 0x00009FA0
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

		// Token: 0x0400006A RID: 106
		protected int fLength = 14;

		// Token: 0x0400006B RID: 107
		protected double fK = 3.0;

		// Token: 0x0400006C RID: 108
		protected BarData fOption;
	}
}
