using System;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000018 RID: 24
	public class SimpleDailySeries : SeriesTesterItem
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00004878 File Offset: 0x00003878
		public SimpleDailySeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Daily - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004897 File Offset: 0x00003897
		public SimpleDailySeries(string name) : base(name)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000048A0 File Offset: 0x000038A0
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(firstIndex);
				DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
				DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
				while (dateTime3 <= dateTime2)
				{
					this.series.Add(dateTime3, this.parentSeries[dateTime3.AddDays(1.0).AddTicks(-1L), EIndexOption.Prev]);
					dateTime3 = dateTime3.AddDays(1.0);
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004938 File Offset: 0x00003938
		protected override double GetValue(DateTime date)
		{
			DateTime dateTime = new DateTime(date.Year, date.Month, date.Day).AddDays(1.0);
			return this.parentSeries[dateTime, EIndexOption.Prev];
		}
	}
}
