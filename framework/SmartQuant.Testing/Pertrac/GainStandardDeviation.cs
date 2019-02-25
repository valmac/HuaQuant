using System;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x0200004D RID: 77
	public class GainStandardDeviation : SeriesTesterItem
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0000DEE3 File Offset: 0x0000CEE3
		public GainStandardDeviation(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "GainStandardDeviation - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000DF02 File Offset: 0x0000CF02
		public GainStandardDeviation(string name) : base(name)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000DF0C File Offset: 0x0000CF0C
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)) && this.parentSeries[i] > 0.0)
				{
					this.mean = (this.mean * this.n + this.parentSeries[i]) / (this.n += 1.0);
					double num = 0.0;
					for (int j = 0; j <= i; j++)
					{
						if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)) && this.parentSeries[j] > 0.0)
						{
							num += (this.parentSeries[j] - this.mean) * (this.parentSeries[j] - this.mean);
						}
					}
					this.series.Add(this.parentSeries.GetDateTime(i), Math.Sqrt(num / (this.n - 1.0)));
				}
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000E030 File Offset: 0x0000D030
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date);
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i <= index; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)) && this.parentSeries[i] > 0.0)
				{
					num += this.parentSeries[i];
					num2 += 1.0;
				}
			}
			num /= num2;
			num2 = 0.0;
			double num3 = 0.0;
			for (int j = 0; j <= index; j++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)) && this.parentSeries[j] > 0.0)
				{
					num3 += (this.parentSeries[j] - num) * (this.parentSeries[j] - num);
					num2 += 1.0;
				}
			}
			return Math.Sqrt(num3 / (num2 - 1.0));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000E147 File Offset: 0x0000D147
		public override void Reset()
		{
			this.mean = 0.0;
			this.n = 0.0;
			base.Reset();
		}

		// Token: 0x040000E7 RID: 231
		protected double mean;

		// Token: 0x040000E8 RID: 232
		protected double n;
	}
}
