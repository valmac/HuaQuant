using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	public class TRIX : Indicator
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000A3F1 File Offset: 0x000093F1
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000A3F9 File Offset: 0x000093F9
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000A408 File Offset: 0x00009408
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000A410 File Offset: 0x00009410
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x06000216 RID: 534 RVA: 0x0000A420 File Offset: 0x00009420
		protected override void Init()
		{
			this.fName = "TRIX (" + this.fLength + " )";
			this.fTitle = "TRIX Index";
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
					"TRIX (",
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
			base.Disconnect();
			this.fEMA = new EMA(this.fInput, this.fLength, this.fOption);
			this.Connect();
			this.fEMA_2 = new EMA(this.fEMA, this.fLength, this.fOption);
			this.fEMA_3 = new EMA(this.fEMA_2, this.fLength, this.fOption);
			this.fEMA.DrawEnabled = false;
			this.fEMA_2.DrawEnabled = false;
			this.fEMA_3.DrawEnabled = false;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000A572 File Offset: 0x00009572
		public TRIX()
		{
			this.Init();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000A588 File Offset: 0x00009588
		public TRIX(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000A5AD File Offset: 0x000095AD
		public TRIX(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000A5DA File Offset: 0x000095DA
		public TRIX(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000A60F File Offset: 0x0000960F
		public TRIX(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000A62D File Offset: 0x0000962D
		public TRIX(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000A654 File Offset: 0x00009654
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= 1 + this.fInput.FirstIndex)
			{
				data = (this.fEMA_3[index] - this.fEMA_3[index - 1]) / this.fEMA_3[index - 1] * 100.0;
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000A6C4 File Offset: 0x000096C4
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= 1 + input.FirstIndex)
			{
				DoubleSeries doubleSeries = new DoubleSeries();
				for (int i = input.FirstIndex; i <= index; i++)
				{
					doubleSeries.Add(input.GetDateTime(i), input[i, option]);
				}
				EMA input2 = new EMA(doubleSeries, length, option);
				EMA input3 = new EMA(input2, length, option);
				EMA ema = new EMA(input3, length, option);
				return (ema[index - input.FirstIndex] - ema[index - 1 - input.FirstIndex]) / ema[index - 1 - input.FirstIndex] * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000A772 File Offset: 0x00009772
		public static double Value(DoubleSeries input, int index, int length)
		{
			return TRIX.Value(input, index, length, BarData.Close);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000A780 File Offset: 0x00009780
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= this.fInput.Count - 1; i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000A7CA File Offset: 0x000097CA
		public override void Detach()
		{
			this.fEMA.Detach();
			base.Detach();
		}

		// Token: 0x04000062 RID: 98
		protected EMA fEMA;

		// Token: 0x04000063 RID: 99
		protected EMA fEMA_2;

		// Token: 0x04000064 RID: 100
		protected EMA fEMA_3;

		// Token: 0x04000065 RID: 101
		protected int fLength = 14;

		// Token: 0x04000066 RID: 102
		protected BarData fOption;
	}
}
