using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class MarketFI : Indicator
	{
		// Token: 0x06000093 RID: 147 RVA: 0x000044CC File Offset: 0x000034CC
		protected override void Init()
		{
			this.fName = "MarketFI";
			this.fTitle = "Market Force Index";
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
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000452E File Offset: 0x0000352E
		public MarketFI()
		{
			this.Init();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000453C File Offset: 0x0000353C
		public MarketFI(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000454B File Offset: 0x0000354B
		public MarketFI(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004561 File Offset: 0x00003561
		public MarketFI(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004580 File Offset: 0x00003580
		protected override void Calculate(int index)
		{
			double data = MarketFI.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000045B0 File Offset: 0x000035B0
		public static double Value(TimeSeries input, int index)
		{
			if (index >= input.FirstIndex)
			{
				double num = input[index, BarData.High];
				double num2 = input[index, BarData.Low];
				double num3 = input[index, BarData.Volume];
				double result;
				if (num3 != 0.0)
				{
					result = (num - num2) / num3 * 1000.0;
				}
				else
				{
					result = 0.0;
				}
				return result;
			}
			return double.NaN;
		}
	}
}
