using System;
using System.ComponentModel;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000010 RID: 16
	public class SotrinoRatio : SeriesTesterItem
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000352C File Offset: 0x0000252C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00003534 File Offset: 0x00002534
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

		// Token: 0x06000074 RID: 116 RVA: 0x00003543 File Offset: 0x00002543
		public SotrinoRatio(string name, SeriesTesterItem parentSeriesItem, double riskFreeRate) : base(name, parentSeriesItem, "SotrinoRatio - " + parentSeriesItem.Series.Title)
		{
			this.riskFreeRate = riskFreeRate;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003569 File Offset: 0x00002569
		public SotrinoRatio(string name) : base(name)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003574 File Offset: 0x00002574
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date);
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i <= index; i++)
			{
				if (this.parentSeries[i] < 0.0)
				{
					num += this.parentSeries[i];
					num2 += 1.0;
				}
			}
			num /= num2;
			double num3 = 0.0;
			for (int j = 0; j <= index; j++)
			{
				if (this.parentSeries[j] < 0.0)
				{
					num3 += (this.parentSeries[j] - num) * (this.parentSeries[j] - num);
				}
			}
			num3 = Math.Sqrt(num3 / (num2 - 1.0));
			return (num - (Math.Pow(this.riskFreeRate / 100.0 + 1.0, 0.004) - 1.0) * 100.0) / num3;
		}

		// Token: 0x04000018 RID: 24
		protected double riskFreeRate;
	}
}
