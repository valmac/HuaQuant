using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class SMV : Indicator
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000B721 File Offset: 0x0000A721
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000B729 File Offset: 0x0000A729
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000B738 File Offset: 0x0000A738
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000B740 File Offset: 0x0000A740
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

		// Token: 0x06000270 RID: 624 RVA: 0x0000B750 File Offset: 0x0000A750
		protected override void Init()
		{
			this.fName = "SMV (" + this.fLength + ")";
			this.fTitle = "Simple Moving Variance";
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
					"SMV (",
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

		// Token: 0x06000271 RID: 625 RVA: 0x0000B81B File Offset: 0x0000A81B
		public SMV()
		{
			this.Init();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B831 File Offset: 0x0000A831
		public SMV(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000B856 File Offset: 0x0000A856
		public SMV(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000B883 File Offset: 0x0000A883
		public SMV(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000B8B8 File Offset: 0x0000A8B8
		public SMV(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B8D8 File Offset: 0x0000A8D8
		protected override void Calculate(int index)
		{
			double data = SMV.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000B914 File Offset: 0x0000A914
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = 0.0;
				double num2 = SMA.Value(input, index, length, option);
				for (int i = index; i > index - length; i--)
				{
					num += (num2 - input[i, option]) * (num2 - input[i, option]);
				}
				return num / (double)length;
			}
			return double.NaN;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000B976 File Offset: 0x0000A976
		public static double Value(DoubleSeries input, int index, int length)
		{
			return SMV.Value(input, index, length, BarData.Close);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000B984 File Offset: 0x0000A984
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

		// Token: 0x04000072 RID: 114
		protected int fLength = 14;

		// Token: 0x04000073 RID: 115
		protected BarData fOption;
	}
}
