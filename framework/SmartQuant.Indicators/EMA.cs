using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	public class EMA : Indicator
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000CB59 File Offset: 0x0000BB59
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0000CB61 File Offset: 0x0000BB61
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000CB70 File Offset: 0x0000BB70
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000CB78 File Offset: 0x0000BB78
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

		// Token: 0x060002CF RID: 719 RVA: 0x0000CB88 File Offset: 0x0000BB88
		protected override void Init()
		{
			this.fName = "EMA (" + this.fLength + ")";
			this.fTitle = "Exponential Moving Average";
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
					"EMA (",
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

		// Token: 0x060002D0 RID: 720 RVA: 0x0000CC5A File Offset: 0x0000BC5A
		public EMA()
		{
			this.Init();
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000CC70 File Offset: 0x0000BC70
		public EMA(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000CC95 File Offset: 0x0000BC95
		public EMA(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000CCC2 File Offset: 0x0000BCC2
		public EMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000CCF7 File Offset: 0x0000BCF7
		public EMA(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000CD15 File Offset: 0x0000BD15
		public EMA(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000CD3C File Offset: 0x0000BD3C
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= this.fInput.FirstIndex + 1)
			{
				double num = 2.0 / (double)(this.fLength + 1);
				double num2 = base[index - 1];
				data = num2 + num * (this.fInput[index, this.fOption] - num2);
			}
			if (index == this.fInput.FirstIndex)
			{
				data = this.fInput[this.fInput.FirstIndex, this.fOption];
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000CDD8 File Offset: 0x0000BDD8
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= input.FirstIndex + 1)
			{
				double num = 2.0 / (double)(length + 1);
				double num2 = EMA.Value(input, index - 1, length, option);
				return num2 + num * (input[index, option] - num2);
			}
			if (index == input.FirstIndex)
			{
				return input[input.FirstIndex, option];
			}
			return double.NaN;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000CE3C File Offset: 0x0000BE3C
		public static double Value(DoubleSeries input, int index, int length)
		{
			return EMA.Value(input, index, length, BarData.Close);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000CE48 File Offset: 0x0000BE48
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
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

		// Token: 0x04000089 RID: 137
		protected int fLength = 14;

		// Token: 0x0400008A RID: 138
		protected BarData fOption;
	}
}
