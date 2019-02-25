using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class DPO : Indicator
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005C5D File Offset: 0x00004C5D
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00005C65 File Offset: 0x00004C65
		[IndicatorParameter(1)]
		[Description("")]
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005C74 File Offset: 0x00004C74
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00005C7C File Offset: 0x00004C7C
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

		// Token: 0x060000FA RID: 250 RVA: 0x00005C8C File Offset: 0x00004C8C
		protected override void Init()
		{
			this.fName = "DPO (" + this.fLength + ")";
			this.fTitle = "Detrended Price Oscillator";
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
					"DPO (",
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

		// Token: 0x060000FB RID: 251 RVA: 0x00005D57 File Offset: 0x00004D57
		public DPO()
		{
			this.Init();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005D6D File Offset: 0x00004D6D
		public DPO(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005D92 File Offset: 0x00004D92
		public DPO(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005DBF File Offset: 0x00004DBF
		public DPO(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005DF4 File Offset: 0x00004DF4
		public DPO(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005E12 File Offset: 0x00004E12
		public DPO(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005E38 File Offset: 0x00004E38
		protected override void Calculate(int index)
		{
			double data = DPO.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005E74 File Offset: 0x00004E74
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length / 2 + length - 1 + input.FirstIndex)
			{
				double num = input[index, option];
				double num2 = 0.0;
				for (int i = index - length / 2; i > index - length - length / 2; i--)
				{
					num2 += input[i, option];
				}
				num2 /= (double)length;
				return num - num2;
			}
			return double.NaN;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005EDA File Offset: 0x00004EDA
		public static double Value(DoubleSeries input, int index, int length, BarData option)
		{
			return DPO.Value(input, index, length, BarData.Close);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005EE8 File Offset: 0x00004EE8
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength + this.fLength / 2); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400002A RID: 42
		protected int fLength = 14;

		// Token: 0x0400002B RID: 43
		protected BarData fOption;
	}
}
