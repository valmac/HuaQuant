using System;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x0200001B RID: 27
	public class LossStandardDeviation : SeriesTesterItem
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00004B0A File Offset: 0x00003B0A
		public LossStandardDeviation(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "LossStandardDeviation - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004B29 File Offset: 0x00003B29
		public LossStandardDeviation(string name) : base(name)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004B34 File Offset: 0x00003B34
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)) && this.parentSeries[i] < 0.0)
				{
					this.mean = (this.mean * this.n + this.parentSeries[i]) / (this.n += 1.0);
					double num = 0.0;
					for (int j = 0; j <= i; j++)
					{
						if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)) && this.parentSeries[j] < 0.0)
						{
							num += (this.parentSeries[j] - this.mean) * (this.parentSeries[j] - this.mean);
						}
					}
					this.series.Add(this.parentSeries.GetDateTime(i), Math.Sqrt(num / (this.n - 1.0)));
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004C58 File Offset: 0x00003C58
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date);
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i <= index; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)) && this.parentSeries[i] < 0.0)
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
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)) && this.parentSeries[j] < 0.0)
				{
					num3 += (this.parentSeries[j] - num) * (this.parentSeries[j] - num);
					num2 += 1.0;
				}
			}
			return Math.Sqrt(num3 / (num2 - 1.0));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004D6F File Offset: 0x00003D6F
		public override void Reset()
		{
			this.mean = 0.0;
			this.n = 0.0;
			base.Reset();
		}

		// Token: 0x0400002C RID: 44
		protected double mean;

		// Token: 0x0400002D RID: 45
		protected double n;
	}
}
