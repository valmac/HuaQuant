using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public class WMA : Indicator
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B3BD File Offset: 0x0000A3BD
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000B3C5 File Offset: 0x0000A3C5
		[Category("Parameters")]
		[IndicatorParameter(0)]
		[Description("Length of Weighted Moving Average")]
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000B3D4 File Offset: 0x0000A3D4
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000B3DC File Offset: 0x0000A3DC
		[Description("Which type of data to average")]
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

		// Token: 0x06000262 RID: 610 RVA: 0x0000B3EC File Offset: 0x0000A3EC
		protected override void Init()
		{
			this.fName = "WMA (" + this.fLength + ")";
			this.fTitle = "Weighted Moving Average";
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
					"WMA (",
					this.Length,
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

		// Token: 0x06000263 RID: 611 RVA: 0x0000B4BE File Offset: 0x0000A4BE
		public WMA()
		{
			this.Init();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000B4D4 File Offset: 0x0000A4D4
		public WMA(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000B4F9 File Offset: 0x0000A4F9
		public WMA(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000B526 File Offset: 0x0000A526
		public WMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000B55B File Offset: 0x0000A55B
		public WMA(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000B57C File Offset: 0x0000A57C
		protected override void Calculate(int index)
		{
			if (index < this.Length - 1 + base.Input.FirstIndex)
			{
				this.Add(this.fInput.GetDateTime(index), double.NaN);
				return;
			}
			double num = 0.0;
			for (int num2 = 1; num2 != this.Length + 1; num2++)
			{
				num += (double)num2;
			}
			double num3 = 0.0;
			int num4 = index;
			int num5 = this.Length;
			while (index - (this.Length - 1) <= num4)
			{
				num3 += base.Input[num4, this.fOption] * (double)num5;
				num4--;
				num5--;
			}
			num3 /= num;
			this.Add(this.fInput.GetDateTime(index), num3);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000B640 File Offset: 0x0000A640
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			double num = 0.0;
			if (index < length - 1 + input.FirstIndex)
			{
				num = double.NaN;
			}
			else
			{
				double num2 = 0.0;
				for (int num3 = 1; num3 != length + 1; num3++)
				{
					num2 += (double)num3;
				}
				int num4 = index;
				int num5 = length;
				while (index - (length - 1) <= num4)
				{
					num += input[num4, option] * (double)num5;
					num4--;
					num5--;
				}
				num /= num2;
			}
			return num;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000B6BA File Offset: 0x0000A6BA
		public static double Value(DoubleSeries input, int index, int length)
		{
			return WMA.Value(input, index, length, BarData.Close);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000B6C8 File Offset: 0x0000A6C8
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

		// Token: 0x04000070 RID: 112
		protected int fLength = 14;

		// Token: 0x04000071 RID: 113
		protected BarData fOption;
	}
}
