using System;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x0200003A RID: 58
	public class SimpleAnnualSeries : SeriesTesterItem
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000B35F File Offset: 0x0000A35F
		public SimpleAnnualSeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Annual - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000B37E File Offset: 0x0000A37E
		public SimpleAnnualSeries(string name) : base(name)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000B388 File Offset: 0x0000A388
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(firstIndex);
				DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
				DateTime dateTime3 = new DateTime(dateTime.Year, 1, 1);
				while (dateTime3 <= dateTime2)
				{
					this.series.Add(dateTime3, this.parentSeries[dateTime3.AddYears(1).AddTicks(-1L), EIndexOption.Prev]);
					dateTime3 = dateTime3.AddYears(1);
				}
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000B404 File Offset: 0x0000A404
		protected override double GetValue(DateTime date)
		{
			DateTime dateTime = new DateTime(date.Year, 1, 1).AddYears(1);
			return this.parentSeries[dateTime, EIndexOption.Prev];
		}
	}
}
