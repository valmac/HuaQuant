using System;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.MathStatistics
{
	// Token: 0x02000038 RID: 56
	public class Division : SeriesTesterItem
	{
		// Token: 0x0600013B RID: 315 RVA: 0x000074FE File Offset: 0x000064FE
		public Division(string name, SeriesTesterItem numeratorSeriesItem, SeriesTesterItem denominatorSeriesItem, SeriesTesterItem signalSeriesItem) : this(name, numeratorSeriesItem, denominatorSeriesItem, signalSeriesItem, 1.0)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007514 File Offset: 0x00006514
		public Division(string name, SeriesTesterItem numeratorSeriesItem, SeriesTesterItem denominatorSeriesItem, SeriesTesterItem signalSeriesItem, double multiplier) : base(name, signalSeriesItem, name)
		{
			this.numeratorSeriesItem = numeratorSeriesItem;
			this.denominatorSeriesItem = denominatorSeriesItem;
			this.parentList.Add(numeratorSeriesItem);
			this.parentList.Add(denominatorSeriesItem);
			this.multiplier = multiplier;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00007550 File Offset: 0x00006550
		protected override double GetValue(DateTime date)
		{
			double num = double.NaN;
			if (this.numeratorSeriesItem.Series.Count > 0 && this.denominatorSeriesItem.Series.Count > 0)
			{
				if (this.numeratorSeriesItem.Series.FirstDateTime <= date && this.denominatorSeriesItem.Series.FirstDateTime <= date)
				{
					double num2 = this.numeratorSeriesItem.Series[date, EIndexOption.Prev];
					double num3 = this.denominatorSeriesItem.Series[date, EIndexOption.Prev];
					if (num3 != 0.0)
					{
						num = num2 / num3;
					}
				}
				return num * this.multiplier;
			}
			return this.numeratorSeriesItem.LastValue / this.denominatorSeriesItem.LastValue;
		}

		// Token: 0x04000079 RID: 121
		private SeriesTesterItem numeratorSeriesItem;

		// Token: 0x0400007A RID: 122
		private SeriesTesterItem denominatorSeriesItem;

		// Token: 0x0400007B RID: 123
		private double multiplier;
	}
}
