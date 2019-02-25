using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x0200004E RID: 78
	public class GainDays : SeriesTesterItem
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000E16D File Offset: 0x0000D16D
		public GainDays(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Gain Days - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000E18C File Offset: 0x0000D18C
		public GainDays(string name) : base(name)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000E198 File Offset: 0x0000D198
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(i);
				if (this.series.Count == 0)
				{
					if (this.parentSeries[dateTime] > 0.0)
					{
						this.series.Add(dateTime, 1.0);
					}
					else
					{
						this.series.Add(dateTime, 0.0);
					}
				}
				else if (this.parentSeries[dateTime] > 0.0)
				{
					this.series.Add(dateTime, this.series.Last + 1.0);
				}
				else
				{
					this.series.Add(dateTime, this.series.Last);
				}
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000E268 File Offset: 0x0000D268
		protected override double GetValue(DateTime date)
		{
			double num = 0.0;
			int index = this.parentSeries.GetIndex(date);
			for (int i = 0; i <= index; i++)
			{
				if (this.parentSeries[i] > 0.0)
				{
					num += 1.0;
				}
			}
			return num;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000E2BC File Offset: 0x0000D2BC
		public override string ValueToSrting()
		{
			return ((int)this.LastValue).ToString();
		}
	}
}
