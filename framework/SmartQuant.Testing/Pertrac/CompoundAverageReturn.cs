using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000004 RID: 4
	public class CompoundAverageReturn : SeriesTesterItem
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002790 File Offset: 0x00001790
		public CompoundAverageReturn(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000027B0 File Offset: 0x000017B0
		public CompoundAverageReturn(string name) : base(name)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000027BC File Offset: 0x000017BC
		protected override double GetValue(DateTime date)
		{
			double num = 1.0;
			int index = this.parentSeries.GetIndex(date);
			int num2 = 0;
			for (int i = 0; i <= index; i++)
			{
				if (this.parentSeries[i] != 0.0)
				{
					num *= this.parentSeries[i];
					num2++;
				}
			}
			return Math.Pow(Math.Abs(num), 1.0 / (double)num2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002831 File Offset: 0x00001831
		public override void Reset()
		{
			base.Reset();
		}
	}
}
