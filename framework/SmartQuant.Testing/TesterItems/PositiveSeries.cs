using System;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000009 RID: 9
	public class PositiveSeries : SeriesTesterItem
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002D04 File Offset: 0x00001D04
		public PositiveSeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Positive - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002D23 File Offset: 0x00001D23
		public PositiveSeries(string name) : base(name)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002D2C File Offset: 0x00001D2C
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (this.parentSeries[i] > 0.0)
				{
					this.series.Add(this.parentSeries.GetDateTime(i), this.parentSeries[i]);
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002D80 File Offset: 0x00001D80
		protected override double GetValue(DateTime date)
		{
			double num = double.NaN;
			int num2 = this.parentSeries.GetIndex(date);
			while (double.IsNaN(num) && num2 > -1)
			{
				if (this.parentSeries[num2] > 0.0)
				{
					num = this.parentSeries[num2];
				}
				num2--;
			}
			return num;
		}
	}
}
