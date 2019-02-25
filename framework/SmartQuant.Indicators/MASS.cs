using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class MASS : Indicator
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000699E File Offset: 0x0000599E
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000069A6 File Offset: 0x000059A6
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000069B5 File Offset: 0x000059B5
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000069BD File Offset: 0x000059BD
		[IndicatorParameter(1)]
		[Description("")]
		[Category("Parameters")]
		public int Order
		{
			get
			{
				return this.fOrder;
			}
			set
			{
				this.fOrder = value;
				this.Init();
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000069CC File Offset: 0x000059CC
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"MASS (",
				this.fLength,
				", ",
				this.fOrder,
				")"
			});
			this.fTitle = "Mass Index";
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
			this.fEMA = new EMA(this.fHL_array, this.fOrder);
			this.fEMA_ema = new EMA(this.fEMA, this.fOrder);
			this.fEMA.DrawEnabled = false;
			this.fEMA_ema.DrawEnabled = false;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006B03 File Offset: 0x00005B03
		public MASS()
		{
			this.Init();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006B21 File Offset: 0x00005B21
		public MASS(TimeSeries input, int length, int order) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006B4E File Offset: 0x00005B4E
		public MASS(TimeSeries input, int length, int order, Color color) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006B83 File Offset: 0x00005B83
		public MASS(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006BC0 File Offset: 0x00005BC0
		protected override void Calculate(int index)
		{
			double num = 0.0;
			if (index >= this.fLength - 1 + this.fInput.FirstIndex)
			{
				for (int i = index; i > index - this.fLength; i--)
				{
					num += this.fEMA[i] / this.fEMA_ema[i];
				}
				this.Add(this.fInput.GetDateTime(index), num);
				return;
			}
			this.Add(this.fInput.GetDateTime(index), double.NaN);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006C4C File Offset: 0x00005C4C
		public static double Value(TimeSeries input, int index, int length, int order)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				DoubleSeries doubleSeries = new DoubleSeries();
				double num = 0.0;
				for (int i = 0; i <= index; i++)
				{
					doubleSeries.Add(input.GetDateTime(i), input[i, BarData.High] - input[i, BarData.Low]);
				}
				EMA ema = new EMA(doubleSeries, order, BarData.Close);
				EMA ema2 = new EMA(ema, order, BarData.Close);
				for (int j = index; j > index - length; j--)
				{
					num += ema[j] / ema2[j];
				}
				return num;
			}
			return double.NaN;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006CEC File Offset: 0x00005CEC
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

		// Token: 0x0400003C RID: 60
		protected int fLength = 14;

		// Token: 0x0400003D RID: 61
		protected int fOrder = 10;

		// Token: 0x0400003E RID: 62
		protected EMA fEMA;

		// Token: 0x0400003F RID: 63
		protected EMA fEMA_ema;

		// Token: 0x04000040 RID: 64
		protected DoubleSeries fHL_array;
	}
}
