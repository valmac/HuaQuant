using System;
using System.ComponentModel;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000020 RID: 32
	public class SharpeRatio : SeriesTesterItem
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000529C File Offset: 0x0000429C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000052A4 File Offset: 0x000042A4
		[Category("Parameters")]
		public double RiskFreeRate
		{
			get
			{
				return this.riskFreeRate;
			}
			set
			{
				this.riskFreeRate = value;
				base.EmitPropertyChanged();
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000052B3 File Offset: 0x000042B3
		public SharpeRatio(string name, SeriesTesterItem parentSeriesItem, double riskFreeRate) : base(name, parentSeriesItem, "StandardDeviation - " + parentSeriesItem.Series.Title)
		{
			this.riskFreeRate = riskFreeRate;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000052D9 File Offset: 0x000042D9
		public SharpeRatio(string name) : base(name)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000052E4 File Offset: 0x000042E4
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
			for (int j = 0; j <= index; j++)
			{
				if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(j)))
				{
					num3 += (this.parentSeries[j] - num) * (this.parentSeries[j] - num);
					num2 += 1.0;
				}
			}
			num3 = Math.Sqrt(num3 / (num2 - 1.0));
			return (num - (Math.Pow(this.riskFreeRate / 100.0 + 1.0, 0.004) - 1.0) * 100.0) / num3;
		}

		// Token: 0x04000033 RID: 51
		protected double riskFreeRate;
	}
}
