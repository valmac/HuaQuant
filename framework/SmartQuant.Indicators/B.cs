using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public class B : Indicator
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000AFF9 File Offset: 0x00009FF9
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000B001 File Offset: 0x0000A001
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000B010 File Offset: 0x0000A010
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000B018 File Offset: 0x0000A018
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000B027 File Offset: 0x0000A027
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000B02F File Offset: 0x0000A02F
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

		// Token: 0x06000253 RID: 595 RVA: 0x0000B040 File Offset: 0x0000A040
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"B (",
				this.fLength,
				" ,",
				this.fK,
				")"
			});
			this.fTitle = "% Bollinger Bands";
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
					"B (",
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

		// Token: 0x06000254 RID: 596 RVA: 0x0000B14F File Offset: 0x0000A14F
		public B()
		{
			this.Init();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000B174 File Offset: 0x0000A174
		public B(TimeSeries input, int length, double k, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000B1B0 File Offset: 0x0000A1B0
		public B(TimeSeries input, int length, double k, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000B200 File Offset: 0x0000A200
		public B(TimeSeries input, int length, double k, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000B257 File Offset: 0x0000A257
		public B(TimeSeries input, int length, double k) : base(input)
		{
			this.fLength = length;
			this.fK = k;
			this.Init();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000B28B File Offset: 0x0000A28B
		public B(TimeSeries input, int length, double k, Color color) : base(input)
		{
			this.fLength = length;
			this.fK = k;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000B2C8 File Offset: 0x0000A2C8
		protected override void Calculate(int index)
		{
			double data = B.Value(this.fInput, index, this.fLength, this.fK, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000B308 File Offset: 0x0000A308
		public static double Value(TimeSeries input, int index, int length, double k, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = BBL.Value(input, index, length, k, option);
				double num2 = BBU.Value(input, index, length, k, option);
				return (input[index, option] - num) / (num2 - num);
			}
			return double.NaN;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000B355 File Offset: 0x0000A355
		public static double Value(DoubleSeries input, int index, int length, double k)
		{
			return B.Value(input, index, length, k, BarData.Close);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000B364 File Offset: 0x0000A364
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

		// Token: 0x0400006D RID: 109
		protected int fLength = 14;

		// Token: 0x0400006E RID: 110
		protected double fK = 3.0;

		// Token: 0x0400006F RID: 111
		protected BarData fOption;
	}
}
