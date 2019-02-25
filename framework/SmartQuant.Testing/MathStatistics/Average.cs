using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.MathStatistics
{
	// Token: 0x0200002A RID: 42
	public class Average : SeriesTesterItem
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00006960 File Offset: 0x00005960
		public Average(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006980 File Offset: 0x00005980
		public Average(string name) : base(name)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000698C File Offset: 0x0000598C
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(lastIndex);
				if (this.series.Contains(dateTime))
				{
					if (this.series.Count == 1)
					{
						this.series.Add(dateTime, this.parentSeries[dateTime]);
						return;
					}
					this.series.Add(dateTime, (this.series[this.series.Count - 2] * (double)(this.series.Count - 1) + this.parentSeries[dateTime]) / (double)this.series.Count);
					return;
				}
				else
				{
					for (int i = firstIndex; i <= lastIndex; i++)
					{
						DateTime dateTime2 = this.parentSeries.GetDateTime(i);
						if (this.series.Count == 0)
						{
							this.series.Add(dateTime2, this.parentSeries[dateTime2]);
						}
						else
						{
							this.series.Add(dateTime2, ((double)this.series.Count * this.series.Last + this.parentSeries[dateTime2]) / (double)(this.series.Count + 1));
						}
					}
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006AB0 File Offset: 0x00005AB0
		protected override double GetValue(DateTime date)
		{
			double num = 0.0;
			int index = this.parentSeries.GetIndex(date);
			int num2 = 0;
			for (int i = 0; i <= index; i++)
			{
				this.parentSeries.GetDateTime(i);
				num += this.parentSeries[i];
				num2++;
			}
			return num / (double)num2;
		}
	}
}
