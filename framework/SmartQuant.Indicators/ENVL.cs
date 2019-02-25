using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000037 RID: 55
	[Serializable]
	public class ENVL : Indicator
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000C799 File Offset: 0x0000B799
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000C7A1 File Offset: 0x0000B7A1
		[IndicatorParameter(2)]
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000C7B0 File Offset: 0x0000B7B0
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000C7B8 File Offset: 0x0000B7B8
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000C7C7 File Offset: 0x0000B7C7
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000C7CF File Offset: 0x0000B7CF
		[IndicatorParameter(1)]
		[Description("")]
		[Category("Parameters")]
		public new double Shift
		{
			get
			{
				return this.fShift;
			}
			set
			{
				this.fShift = value;
				this.Init();
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000C7E0 File Offset: 0x0000B7E0
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"ENVL (",
				this.fLength,
				", ",
				this.fShift,
				")"
			});
			this.fTitle = "Envelope Lower";
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
					"ENVL (",
					this.fLength,
					", ",
					this.fShift,
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

		// Token: 0x060002C1 RID: 705 RVA: 0x0000C8EF File Offset: 0x0000B8EF
		public ENVL()
		{
			this.Init();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000C914 File Offset: 0x0000B914
		public ENVL(TimeSeries input, int length, double shift, BarData option) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000C950 File Offset: 0x0000B950
		public ENVL(TimeSeries input, int length, double shift, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000C9A0 File Offset: 0x0000B9A0
		public ENVL(TimeSeries input, int length, double shift, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000C9F7 File Offset: 0x0000B9F7
		public ENVL(TimeSeries input, int length, double shift) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.Init();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000CA2B File Offset: 0x0000BA2B
		public ENVL(TimeSeries input, int length, double shift, Color color) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000CA68 File Offset: 0x0000BA68
		protected override void Calculate(int index)
		{
			double data = ENVL.Value(this.fInput, index, this.fLength, this.fShift, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000CAA8 File Offset: 0x0000BAA8
		public static double Value(TimeSeries input, int index, int length, double shift, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = SMA.Value(input, index, length, option);
				return num - num * (shift / 100.0);
			}
			return double.NaN;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000CAF2 File Offset: 0x0000BAF2
		public static double Value(DoubleSeries input, int index, int length, double shift)
		{
			return ENVL.Value(input, index, length, shift, BarData.Close);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000CB00 File Offset: 0x0000BB00
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

		// Token: 0x04000086 RID: 134
		protected int fLength = 14;

		// Token: 0x04000087 RID: 135
		protected double fShift = 20.0;

		// Token: 0x04000088 RID: 136
		protected BarData fOption;
	}
}
