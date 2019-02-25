using System;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000045 RID: 69
	public class CumulativeDailySeries : SeriesTesterItem
	{
		// Token: 0x06000234 RID: 564 RVA: 0x0000D2DE File Offset: 0x0000C2DE
		public CumulativeDailySeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Daily - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000D2FD File Offset: 0x0000C2FD
		public CumulativeDailySeries(string name) : base(name)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000D308 File Offset: 0x0000C308
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				double num = 0.0;
				DateTime dateTime = this.parentSeries.GetDateTime(firstIndex);
				DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
				if (this.series.Contains(dateTime2))
				{
					num = this.series[dateTime2];
				}
				for (int i = firstIndex; i <= lastIndex; i++)
				{
					dateTime = this.parentSeries.GetDateTime(i);
					if (dateTime > dateTime2.AddDays(1.0).AddTicks(-1L))
					{
						dateTime2 = dateTime2.AddDays(1.0);
						num = 0.0;
					}
					num += this.parentSeries[dateTime];
					this.series.Add(dateTime2, num);
				}
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000D3E0 File Offset: 0x0000C3E0
		protected override double GetValue(DateTime date)
		{
			double num = 0.0;
			DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);
			DateTime dateTime2 = new DateTime(date.Year, date.Month, date.Day).AddDays(1.0).AddTicks(-1L);
			int index = this.parentSeries.GetIndex(dateTime, EIndexOption.Next);
			int index2 = this.parentSeries.GetIndex(dateTime2, EIndexOption.Prev);
			for (int i = index; i <= index2; i++)
			{
				num += this.parentSeries[i];
			}
			return num;
		}
	}
}
