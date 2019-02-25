using System;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.MathStatistics
{
	// Token: 0x02000029 RID: 41
	public class Return : SeriesTesterItem
	{
		// Token: 0x06000104 RID: 260 RVA: 0x000068D6 File Offset: 0x000058D6
		public Return(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, "Return - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000068F5 File Offset: 0x000058F5
		public Return(string name) : base(name)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006900 File Offset: 0x00005900
		protected override double GetValue(DateTime date)
		{
			int index = this.parentSeries.GetIndex(date, EIndexOption.Prev);
			if (index > 0)
			{
				return (this.parentSeries[index] / this.parentSeries[index - 1] - 1.0) * 100.0;
			}
			return 0.0;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006958 File Offset: 0x00005958
		public override void Reset()
		{
			base.Reset();
		}
	}
}
