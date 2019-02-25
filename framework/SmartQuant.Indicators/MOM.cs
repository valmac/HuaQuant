using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public class MOM : Indicator
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000BBDD File Offset: 0x0000ABDD
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000BBE5 File Offset: 0x0000ABE5
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000BBF4 File Offset: 0x0000ABF4
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000BBFC File Offset: 0x0000ABFC
		[Description("")]
		[Category("Parameters")]
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

		// Token: 0x06000288 RID: 648 RVA: 0x0000BC0C File Offset: 0x0000AC0C
		protected override void Init()
		{
			this.fName = "MOM (" + this.fLength + ")";
			this.fTitle = "Momentum Oscillator";
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
					"MOM (",
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

		// Token: 0x06000289 RID: 649 RVA: 0x0000BCD7 File Offset: 0x0000ACD7
		public MOM()
		{
			this.Init();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000BCED File Offset: 0x0000ACED
		public MOM(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000BD12 File Offset: 0x0000AD12
		public MOM(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000BD3F File Offset: 0x0000AD3F
		public MOM(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000BD74 File Offset: 0x0000AD74
		public MOM(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000BD92 File Offset: 0x0000AD92
		public MOM(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000BDB8 File Offset: 0x0000ADB8
		protected override void Calculate(int index)
		{
			double data = MOM.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000BDF4 File Offset: 0x0000ADF4
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				return input[index, option] - input[index - length + 1, option];
			}
			return double.NaN;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000BE39 File Offset: 0x0000AE39
		public static double Value(DoubleSeries input, int index, int length)
		{
			return MOM.Value(input, index, length);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000BE44 File Offset: 0x0000AE44
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

		// Token: 0x04000075 RID: 117
		protected int fLength = 14;

		// Token: 0x04000076 RID: 118
		protected BarData fOption;
	}
}
