using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000023 RID: 35
	[Serializable]
	public class VWAP : Indicator
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00009699 File Offset: 0x00008699
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x000096A1 File Offset: 0x000086A1
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000096B0 File Offset: 0x000086B0
		// (set) Token: 0x060001DA RID: 474 RVA: 0x000096B8 File Offset: 0x000086B8
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

		// Token: 0x060001DB RID: 475 RVA: 0x000096C8 File Offset: 0x000086C8
		protected override void Init()
		{
			this.fName = "VWAP (" + this.fLength + ")";
			this.fTitle = "Volume Weighted Average Price";
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
					"VWAP (",
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

		// Token: 0x060001DC RID: 476 RVA: 0x0000979A File Offset: 0x0000879A
		public VWAP()
		{
			this.Init();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000097B0 File Offset: 0x000087B0
		public VWAP(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000097D5 File Offset: 0x000087D5
		public VWAP(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00009802 File Offset: 0x00008802
		public VWAP(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00009837 File Offset: 0x00008837
		public VWAP(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00009855 File Offset: 0x00008855
		public VWAP(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000987C File Offset: 0x0000887C
		protected override void Calculate(int index)
		{
			double data = VWAP.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000098B8 File Offset: 0x000088B8
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = 0.0;
				double num2 = 0.0;
				for (int i = index; i >= index - length + 1; i--)
				{
					num += input[i, option] * input[i, BarData.Volume];
					num2 += input[i, BarData.Volume];
				}
				return num / num2;
			}
			return double.NaN;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00009924 File Offset: 0x00008924
		public static double Value(DoubleSeries input, int index, int length)
		{
			return VWAP.Value(input, index, length, BarData.Close);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00009930 File Offset: 0x00008930
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

		// Token: 0x04000059 RID: 89
		protected int fLength = 14;

		// Token: 0x0400005A RID: 90
		protected BarData fOption;
	}
}
