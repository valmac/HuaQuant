using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class OSC : Indicator
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008A17 File Offset: 0x00007A17
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00008A1F File Offset: 0x00007A1F
		[Category("Parameters")]
		[IndicatorParameter(2)]
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00008A2E File Offset: 0x00007A2E
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00008A36 File Offset: 0x00007A36
		[Description("")]
		[IndicatorParameter(0)]
		[Category("Parameters")]
		public int Length1
		{
			get
			{
				return this.fLength1;
			}
			set
			{
				this.fLength1 = value;
				this.Init();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00008A45 File Offset: 0x00007A45
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00008A4D File Offset: 0x00007A4D
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(1)]
		public int Length2
		{
			get
			{
				return this.fLength2;
			}
			set
			{
				this.fLength2 = value;
				this.Init();
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00008A5C File Offset: 0x00007A5C
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"OSC (",
				this.fLength1,
				", ",
				this.fLength2,
				")"
			});
			this.fTitle = "Oscillator";
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
					"OSC (",
					this.fLength1,
					", ",
					this.fLength2,
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

		// Token: 0x060001A9 RID: 425 RVA: 0x00008B64 File Offset: 0x00007B64
		public OSC()
		{
			this.Init();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008B82 File Offset: 0x00007B82
		public OSC(TimeSeries input, int length1, int length2, BarData option) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00008BB7 File Offset: 0x00007BB7
		public OSC(TimeSeries input, int length1, int length2, BarData option, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00008BF4 File Offset: 0x00007BF4
		public OSC(TimeSeries input, int length1, int length2, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00008C44 File Offset: 0x00007C44
		public OSC(TimeSeries input, int length1, int length2) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008C71 File Offset: 0x00007C71
		public OSC(TimeSeries input, int length1, int length2, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008CA8 File Offset: 0x00007CA8
		protected override void Calculate(int index)
		{
			double data = OSC.Value(this.fInput, index, this.fLength1, this.fLength2, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00008CE8 File Offset: 0x00007CE8
		public static double Value(TimeSeries input, int index, int length1, int length2, BarData option)
		{
			if (index >= length1 - 1 + input.FirstIndex && index >= length2 - 1 + input.FirstIndex)
			{
				double num = SMA.Value(input, index, length1, option);
				double num2 = SMA.Value(input, index, length2, option);
				return num - num2;
			}
			return double.NaN;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00008D3E File Offset: 0x00007D3E
		public static double Value(DoubleSeries input, int index, int length1, int length2)
		{
			return OSC.Value(input, index, length1, length2, BarData.Close);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00008D4C File Offset: 0x00007D4C
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fLength1, this.fLength2) - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x04000052 RID: 82
		protected int fLength1 = 14;

		// Token: 0x04000053 RID: 83
		protected int fLength2 = 20;

		// Token: 0x04000054 RID: 84
		protected BarData fOption;
	}
}
