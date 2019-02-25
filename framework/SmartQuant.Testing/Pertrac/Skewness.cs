using System;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000043 RID: 67
	public class Skewness : SeriesTesterItem
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000CB70 File Offset: 0x0000BB70
		public Skewness(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Skewness - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000CB8F File Offset: 0x0000BB8F
		public Skewness(string name) : base(name)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000CB98 File Offset: 0x0000BB98
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
							num2 += Math.Pow(this.parentSeries[j] - this.mean, 3.0);
						}
					}
					num = Math.Sqrt(num / (this.n - 1.0));
					if (this.n > 2.0)
					{
						this.series.Add(this.parentSeries.GetDateTime(i), this.n / ((this.n - 1.0) * (this.n - 2.0)) * num2 / Math.Pow(num, 3.0));
					}
				}
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000CD00 File Offset: 0x0000BD00
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
					num4 += Math.Pow(this.parentSeries[j] - num, 3.0);
					num2 += 1.0;
				}
			}
			num3 = Math.Sqrt(num3 / (num2 - 1.0));
			if (num2 > 2.0)
			{
				return num2 / ((num2 - 1.0) * (num2 - 2.0)) * num4 / Math.Pow(num3, 3.0);
			}
			return double.NaN;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000CE58 File Offset: 0x0000BE58
		public override void Reset()
		{
			this.mean = 0.0;
			this.n = 0.0;
			base.Reset();
		}

		// Token: 0x040000DB RID: 219
		protected double mean;

		// Token: 0x040000DC RID: 220
		protected double n;
	}
}
