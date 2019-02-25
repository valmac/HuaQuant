using System;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000005 RID: 5
	public class SimpleMonthlySeries : SeriesTesterItem
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002839 File Offset: 0x00001839
		public SimpleMonthlySeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Monthly - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002858 File Offset: 0x00001858
		public SimpleMonthlySeries(string name) : base(name)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002864 File Offset: 0x00001864
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(firstIndex);
				DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
				DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, 1);
				while (dateTime3 <= dateTime2)
				{
					this.series.Add(dateTime3, this.parentSeries[dateTime3.AddMonths(1).AddTicks(-1L), EIndexOption.Prev]);
					dateTime3 = dateTime3.AddMonths(1);
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000028E4 File Offset: 0x000018E4
		protected override double GetValue(DateTime date)
		{
			DateTime dateTime = new DateTime(date.Year, date.Month, 1).AddMonths(1);
			return this.parentSeries[dateTime, EIndexOption.Prev];
		}
	}
}
