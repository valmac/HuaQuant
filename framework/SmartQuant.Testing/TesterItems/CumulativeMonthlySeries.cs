using System;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000019 RID: 25
	public class CumulativeMonthlySeries : SeriesTesterItem
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000498A File Offset: 0x0000398A
		public CumulativeMonthlySeries(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Monthly - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000049A9 File Offset: 0x000039A9
		public CumulativeMonthlySeries(string name) : base(name)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000049B4 File Offset: 0x000039B4
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				double num = 0.0;
				DateTime dateTime = this.parentSeries.GetDateTime(firstIndex);
				DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
				if (this.series.Contains(dateTime2))
				{
					num = this.series[dateTime2];
				}
				for (int i = firstIndex; i <= lastIndex; i++)
				{
					dateTime = this.parentSeries.GetDateTime(i);
					if (dateTime > dateTime2.AddMonths(1).AddTicks(-1L))
					{
						dateTime2 = dateTime2.AddMonths(1);
						num = 0.0;
					}
					num += this.parentSeries[dateTime];
					this.series.Add(dateTime2, num);
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004A74 File Offset: 0x00003A74
		protected override double GetValue(DateTime date)
		{
			double num = 0.0;
			DateTime dateTime = new DateTime(date.Year, date.Month, 1);
			DateTime dateTime2 = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddTicks(-1L);
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
