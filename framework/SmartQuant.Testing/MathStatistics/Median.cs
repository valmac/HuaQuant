using System;
using System.Collections;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.MathStatistics
{
	// Token: 0x02000037 RID: 55
	public class Median : SeriesTesterItem
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00007251 File Offset: 0x00006251
		public Median(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000728B File Offset: 0x0000628B
		public Median(string name) : base(name)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000072B0 File Offset: 0x000062B0
		private void InsertValue(double val)
		{
			int num = 0;
			while (num < this.sortedSeries.Count && (double)this.sortedSeries[num] < val)
			{
				num++;
			}
			this.sortedSeries.Insert(num, val);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000072FC File Offset: 0x000062FC
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(lastIndex);
				if (this.series.Contains(dateTime))
				{
					this.sortedSeries.Remove(this.lastInsertedValue);
				}
				for (int i = firstIndex; i <= lastIndex; i++)
				{
					DateTime dateTime2 = this.parentSeries.GetDateTime(i);
					this.InsertValue(this.parentSeries[i]);
					double data;
					if (this.sortedSeries.Count % 2 == 0)
					{
						data = ((double)this.sortedSeries[this.sortedSeries.Count / 2 - 1] + (double)this.sortedSeries[this.sortedSeries.Count / 2]) / 2.0;
					}
					else
					{
						data = (double)this.sortedSeries[this.sortedSeries.Count / 2];
					}
					this.series.Add(dateTime2, data);
				}
				this.lastInsertedValue = this.parentSeries[lastIndex];
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007408 File Offset: 0x00006408
		protected override double GetValue(DateTime date)
		{
			ArrayList arrayList = new ArrayList();
			int index = this.parentSeries.GetIndex(date);
			for (int i = 0; i <= index; i++)
			{
				int num = 0;
				while (num < arrayList.Count && (double)arrayList[num] < this.parentSeries[i])
				{
					num++;
				}
				arrayList.Insert(num, this.parentSeries[i]);
			}
			double result;
			if (arrayList.Count % 2 == 0)
			{
				result = ((double)arrayList[arrayList.Count / 2 - 1] + (double)arrayList[arrayList.Count / 2]) / 2.0;
			}
			else
			{
				result = (double)arrayList[arrayList.Count / 2];
			}
			return result;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000074DC File Offset: 0x000064DC
		public override void Reset()
		{
			base.Reset();
			this.sortedSeries = new ArrayList();
			this.lastInsertedValue = double.NaN;
		}

		// Token: 0x04000077 RID: 119
		protected ArrayList sortedSeries = new ArrayList();

		// Token: 0x04000078 RID: 120
		protected double lastInsertedValue = double.NaN;
	}
}
