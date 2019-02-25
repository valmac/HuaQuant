using System;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x0200000D RID: 13
	public class NegativeSeries : SeriesTesterItem
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000329F File Offset: 0x0000229F
		public NegativeSeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Negative - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000032BE File Offset: 0x000022BE
		public NegativeSeries(string name) : base(name)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000032C8 File Offset: 0x000022C8
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (this.parentSeries[i] < 0.0)
				{
					this.series.Add(this.parentSeries.GetDateTime(i), this.parentSeries[i]);
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000331C File Offset: 0x0000231C
		protected override double GetValue(DateTime date)
		{
			double num = double.NaN;
			int num2 = this.parentSeries.GetIndex(date);
			while (double.IsNaN(num) && num2 > -1)
			{
				if (this.parentSeries[num2] < 0.0)
				{
					num = this.parentSeries[num2];
				}
				num2--;
			}
			return num;
		}
	}
}
