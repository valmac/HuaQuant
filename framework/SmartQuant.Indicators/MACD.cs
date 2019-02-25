using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class MACD : Indicator
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000536A File Offset: 0x0000436A
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00005372 File Offset: 0x00004372
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005381 File Offset: 0x00004381
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00005389 File Offset: 0x00004389
		[Category("Parameters")]
		[IndicatorParameter(0)]
		[Description("")]
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005398 File Offset: 0x00004398
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000053A0 File Offset: 0x000043A0
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

		// Token: 0x060000D8 RID: 216 RVA: 0x000053B0 File Offset: 0x000043B0
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"MACD (",
				this.fLength1,
				", ",
				this.fLength2,
				")"
			});
			this.fTitle = "Moving Average Convergence Divergence";
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
					"MACD (",
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
			base.Disconnect();
			this.fEMA1 = new EMA(this.fInput, this.fLength1, this.fOption);
			this.fEMA2 = new EMA(this.fInput, this.fLength2, this.fOption);
			this.Connect();
			this.fEMA1.DrawEnabled = false;
			this.fEMA2.DrawEnabled = false;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005516 File Offset: 0x00004516
		public MACD()
		{
			this.Init();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005534 File Offset: 0x00004534
		public MACD(TimeSeries input, int length1, int length2, BarData option) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005569 File Offset: 0x00004569
		public MACD(TimeSeries input, int length1, int length2, BarData option, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000055A8 File Offset: 0x000045A8
		public MACD(TimeSeries input, int length1, int length2, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000055F8 File Offset: 0x000045F8
		public MACD(TimeSeries input, int length1, int length2) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005625 File Offset: 0x00004625
		public MACD(TimeSeries input, int length1, int length2, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000565C File Offset: 0x0000465C
		protected override void Calculate(int index)
		{
			if (index >= this.fInput.FirstIndex)
			{
				double num = this.fEMA1[index];
				double num2 = this.fEMA2[index];
				double data = num - num2;
				this.Add(this.fInput.GetDateTime(index), data);
				return;
			}
			this.Add(this.fInput.GetDateTime(index), double.NaN);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000056C4 File Offset: 0x000046C4
		public static double Value(TimeSeries input, int index, int length1, int length2, BarData option)
		{
			if (index >= input.FirstIndex)
			{
				double num = EMA.Value(input, index, length1, option);
				double num2 = EMA.Value(input, index, length2, option);
				return num - num2;
			}
			return double.NaN;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005709 File Offset: 0x00004709
		public static double Value(DoubleSeries input, int index, int length1, int length2)
		{
			return MACD.Value(input, index, length1, length2, BarData.Close);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005718 File Offset: 0x00004718
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

		// Token: 0x060000E3 RID: 227 RVA: 0x00005762 File Offset: 0x00004762
		public override void Detach()
		{
			this.fEMA1.Detach();
			this.fEMA2.Detach();
			base.Detach();
		}

		// Token: 0x04000022 RID: 34
		protected int fLength1 = 14;

		// Token: 0x04000023 RID: 35
		protected int fLength2 = 10;

		// Token: 0x04000024 RID: 36
		protected BarData fOption;

		// Token: 0x04000025 RID: 37
		protected EMA fEMA1;

		// Token: 0x04000026 RID: 38
		protected EMA fEMA2;
	}
}
