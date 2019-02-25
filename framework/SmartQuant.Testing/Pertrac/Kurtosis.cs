using System;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000011 RID: 17
	public class Kurtosis : SeriesTesterItem
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00003691 File Offset: 0x00002691
		public Kurtosis(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Kurtosis - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000036B0 File Offset: 0x000026B0
		public Kurtosis(string name) : base(name)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000036BC File Offset: 0x000026BC
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(i)))
				{
					this.mean = (this.mean * this.n + this.parentSeries[i]) / (this.n += 1.0);
					double num = 0.0;
					double num2 = 0.0;
					for (int j = 0; j <= i; j++)
					{
						if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)))
						{
							num += Math.Pow(this.parentSeries[j] - this.mean, 2.0);
							num2 += Math.Pow(this.parentSeries[j] - this.mean, 4.0);
						}
					}
					num = Math.Sqrt(num / (this.n - 1.0));
					this.series.Add(this.parentSeries.GetDateTime(i), this.n * (this.n - 1.0) / ((this.n - 1.0) * (this.n - 2.0) * (this.n - 3.0)) * num2 / Math.Pow(num, 4.0) - 3.0 * (this.n - 1.0) * (this.n - 1.0) / ((this.n - 2.0) * (this.n - 3.0)));
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003884 File Offset: 0x00002884
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
			num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			for (int j = 0; j <= index; j++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)))
				{
					num3 += Math.Pow(this.parentSeries[j] - num, 2.0);
					num4 += Math.Pow(this.parentSeries[j] - num, 4.0);
					num2 += 1.0;
				}
			}
			num3 = Math.Sqrt(num3 / (num2 - 1.0));
			if (num2 > 3.0)
			{
				return num2 * (num2 - 1.0) / ((num2 - 1.0) * (num2 - 2.0) * (num2 - 3.0)) * num4 / Math.Pow(num3, 4.0) - 3.0 * (num2 - 1.0) * (num2 - 1.0) / ((num2 - 2.0) * (num2 - 3.0));
			}
			return double.NaN;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003A31 File Offset: 0x00002A31
		public override void Reset()
		{
			this.mean = 0.0;
			this.n = 0.0;
			base.Reset();
		}

		// Token: 0x04000019 RID: 25
		protected double mean;

		// Token: 0x0400001A RID: 26
		protected double n;
	}
}
