using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000035 RID: 53
	[Serializable]
	public class VCH : Indicator
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000C15C File Offset: 0x0000B15C
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000C164 File Offset: 0x0000B164
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000C173 File Offset: 0x0000B173
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000C17B File Offset: 0x0000B17B
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x060002A3 RID: 675 RVA: 0x0000C18C File Offset: 0x0000B18C
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"VCH (",
				this.fLength1,
				" ,",
				this.fLength2,
				" )"
			});
			this.fTitle = "Chaikin Volatility";
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
			this.fHL_array = new DoubleSeries();
			for (int i = 0; i < this.fInput.Count; i++)
			{
				this.fHL_array.Add(this.fInput.GetDateTime(i), this.fInput[i, BarData.High] - this.fInput[i, BarData.Low]);
			}
			this.fEMA = new EMA(this.fHL_array, this.fLength1);
			this.fEMA.DrawEnabled = false;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000C2A0 File Offset: 0x0000B2A0
		public VCH()
		{
			this.Init();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000C2BE File Offset: 0x0000B2BE
		public VCH(TimeSeries input, int length1, int length2) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000C2EB File Offset: 0x0000B2EB
		public VCH(TimeSeries input, int length1, int length2, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000C320 File Offset: 0x0000B320
		public VCH(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000C360 File Offset: 0x0000B360
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= this.fLength2 - 1 + this.fInput.FirstIndex)
			{
				data = (this.fEMA[index] - this.fEMA[index - this.fLength2 + 1]) / this.fEMA[index - this.fLength2 + 1] * 100.0;
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000C3E4 File Offset: 0x0000B3E4
		public static double Value(TimeSeries input, int index, int length1, int length2)
		{
			if (index >= length2 - 1 + input.FirstIndex)
			{
				DoubleSeries doubleSeries = new DoubleSeries();
				for (int i = 0; i <= index; i++)
				{
					doubleSeries.Add(input.GetDateTime(i), input[i, BarData.High] - input[i, BarData.Low]);
				}
				EMA ema = new EMA(doubleSeries, length1, BarData.Close);
				return (ema[index] - ema[index - length2 + 1]) / ema[index - length2 + 1] * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000C46C File Offset: 0x0000B46C
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			int index = this.fInput.GetIndex(EventArgs.DateTime);
			if (index != -1)
			{
				this.fHL_array.Add(this.fInput.GetDateTime(index), this.fInput[index, BarData.High] - this.fInput[index, BarData.Low]);
				if (this.fMonitored)
				{
					for (int i = index; i <= this.fInput.Count - 1; i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x04000080 RID: 128
		protected int fLength1 = 14;

		// Token: 0x04000081 RID: 129
		protected int fLength2 = 10;

		// Token: 0x04000082 RID: 130
		protected EMA fEMA;

		// Token: 0x04000083 RID: 131
		protected DoubleSeries fHL_array;
	}
}
