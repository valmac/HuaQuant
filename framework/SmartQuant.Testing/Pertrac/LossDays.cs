using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000007 RID: 7
	public class LossDays : SeriesTesterItem
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002B50 File Offset: 0x00001B50
		public LossDays(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Loss Days - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002B6F File Offset: 0x00001B6F
		public LossDays(string name) : base(name)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002B78 File Offset: 0x00001B78
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(i);
				if (this.series.Count == 0)
				{
					if (this.parentSeries[dateTime] < 0.0)
					{
						this.series.Add(dateTime, 1.0);
					}
					else
					{
						this.series.Add(dateTime, 0.0);
					}
				}
				else if (this.parentSeries[dateTime] < 0.0)
				{
					this.series.Add(dateTime, this.series.Last + 1.0);
				}
				else
				{
					this.series.Add(dateTime, this.series.Last);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002C48 File Offset: 0x00001C48
		protected override double GetValue(DateTime date)
		{
			double num = 0.0;
			int index = this.parentSeries.GetIndex(date);
			for (int i = 0; i <= index; i++)
			{
				if (this.parentSeries[i] < 0.0)
				{
					num += 1.0;
				}
			}
			return num;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002C9C File Offset: 0x00001C9C
		public override string ValueToSrting()
		{
			return ((int)this.LastValue).ToString();
		}
	}
}
