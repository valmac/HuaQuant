using System;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000013 RID: 19
	public class StandardDeviation : SeriesTesterItem
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00003AF7 File Offset: 0x00002AF7
		public StandardDeviation(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "StandardDeviation - " + parentSeriesItem.Series.Title)
		{
			this.FillSeries = true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003B1D File Offset: 0x00002B1D
		public StandardDeviation(string name) : base(name)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003B28 File Offset: 0x00002B28
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)))
				{
					double num = this.mean;
					double num2 = (this.mean * this.n + this.parentSeries[i]) / (this.n + 1.0);
					double num3 = this.parentSeries[i];
					if (this.series.Count == 0)
					{
						this.stdDev = 0.0;
					}
					else
					{
						this.stdDev = this.stdDev + (num3 - num2) * (num3 - num2) + this.n * (num2 * num2 - num * num - 2.0 * (num2 - num) * num);
					}
					this.n += 1.0;
					this.mean = num2;
					this.series.Add(this.parentSeries.GetDateTime(i), Math.Sqrt(this.stdDev / (this.n - 1.0)));
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003C40 File Offset: 0x00002C40
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date);
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i <= index; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)))
				{
					num += this.parentSeries[i];
					num2 += 1.0;
				}
			}
			num /= num2;
			double num3 = 0.0;
			for (int j = 0; j <= index; j++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)))
				{
					num3 += (this.parentSeries[j] - num) * (this.parentSeries[j] - num);
				}
			}
			return Math.Sqrt(num3 / (num2 - 1.0));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003D12 File Offset: 0x00002D12
		public override void Reset()
		{
			this.mean = 0.0;
			this.n = 0.0;
			this.stdDev = 0.0;
			base.Reset();
		}

		// Token: 0x0400001C RID: 28
		protected double mean;

		// Token: 0x0400001D RID: 29
		protected double n;

		// Token: 0x0400001E RID: 30
		private double stdDev;
	}
}
