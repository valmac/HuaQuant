using System;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x0200002C RID: 44
	public class CumulativeAnnualSeries : SeriesTesterItem
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00006B0E File Offset: 0x00005B0E
		public CumulativeAnnualSeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Annual - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006B2D File Offset: 0x00005B2D
		public CumulativeAnnualSeries(string name) : base(name)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006B38 File Offset: 0x00005B38
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				double num = 0.0;
				DateTime dateTime = new DateTime(this.parentSeries.GetDateTime(firstIndex).Year, 1, 1);
				if (this.series.Contains(dateTime))
				{
					num = this.series[dateTime];
				}
				for (int i = firstIndex; i <= lastIndex; i++)
				{
					DateTime dateTime2 = this.parentSeries.GetDateTime(i);
					if (dateTime2 > dateTime.AddYears(1).AddTicks(-2L))
					{
						dateTime = dateTime.AddYears(1);
						num = 0.0;
					}
					num += this.parentSeries[dateTime2];
					this.series.Add(dateTime, num);
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006BF4 File Offset: 0x00005BF4
		protected override double GetValue(DateTime date)
		{
			double num = 0.0;
			DateTime dateTime = new DateTime(date.Year, 1, 1);
			DateTime dateTime2 = new DateTime(date.Year, 1, 1).AddYears(1);
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
