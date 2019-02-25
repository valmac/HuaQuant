using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class SMD : Indicator
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000C4E8 File Offset: 0x0000B4E8
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000C4F0 File Offset: 0x0000B4F0
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000C4FF File Offset: 0x0000B4FF
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000C507 File Offset: 0x0000B507
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

		// Token: 0x060002AF RID: 687 RVA: 0x0000C518 File Offset: 0x0000B518
		protected override void Init()
		{
			this.fName = "SMD (" + this.fLength + ")";
			this.fTitle = "Simple Moving Deviation";
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
					"SMD (",
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

		// Token: 0x060002B0 RID: 688 RVA: 0x0000C5E3 File Offset: 0x0000B5E3
		public SMD()
		{
			this.Init();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000C5F9 File Offset: 0x0000B5F9
		public SMD(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000C61E File Offset: 0x0000B61E
		public SMD(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000C64B File Offset: 0x0000B64B
		public SMD(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000C680 File Offset: 0x0000B680
		public SMD(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000C69E File Offset: 0x0000B69E
		public SMD(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000C6C4 File Offset: 0x0000B6C4
		protected override void Calculate(int index)
		{
			double data = SMD.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000C700 File Offset: 0x0000B700
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				return Math.Sqrt(SMV.Value(input, index, length, option));
			}
			return double.NaN;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000C734 File Offset: 0x0000B734
		public static double Value(DoubleSeries input, int index, int length)
		{
			return SMD.Value(input, index, length, BarData.Close);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000C740 File Offset: 0x0000B740
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

		// Token: 0x04000084 RID: 132
		protected int fLength = 14;

		// Token: 0x04000085 RID: 133
		protected BarData fOption;
	}
}
