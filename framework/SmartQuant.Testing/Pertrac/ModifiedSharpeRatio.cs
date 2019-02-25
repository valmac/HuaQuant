using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000036 RID: 54
	public class ModifiedSharpeRatio : SeriesTesterItem
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00007178 File Offset: 0x00006178
		public ModifiedSharpeRatio(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "StandardDeviation - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00007197 File Offset: 0x00006197
		public ModifiedSharpeRatio(string name) : base(name)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000071A0 File Offset: 0x000061A0
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date);
			double num = 0.0;
			for (int i = 0; i <= index; i++)
			{
				num += this.parentSeries[i];
			}
			num /= (double)(index + 1);
			double num2 = 0.0;
			for (int j = 0; j < this.parentSeries.Count; j++)
			{
				num2 += (this.parentSeries[j] - num) * (this.parentSeries[j] - num);
			}
			num2 = Math.Sqrt(num2 / (double)index);
			return 12.0 * num / Math.Pow(num2, 0.0);
		}
	}
}
