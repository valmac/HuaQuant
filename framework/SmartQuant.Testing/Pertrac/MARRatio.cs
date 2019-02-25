using System;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x0200002F RID: 47
	public class MARRatio : SeriesTesterItem
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00006DBC File Offset: 0x00005DBC
		public MARRatio(string name, SeriesTesterItem parentSeriesItem, SeriesTesterItem maxDrawDownSeriesItem) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
			this.maxDrawDown = maxDrawDownSeriesItem;
			this.maxDrawDown.FillSeries = true;
			this.parentList.Add(this.maxDrawDown);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006E0C File Offset: 0x00005E0C
		public MARRatio(string name) : base(name)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006E18 File Offset: 0x00005E18
		protected override double GetValue(DateTime date)
		{
			double num = double.NaN;
			int index = this.parentSeries.GetIndex(date);
			if (this.maxDrawDown.Series.Count == 0 || date < this.maxDrawDown.Series.FirstDateTime)
			{
				return num;
			}
			num = 1.0;
			int num2 = 0;
			for (int i = 0; i <= index; i++)
			{
				if (this.parentSeries[i] != 0.0)
				{
					num *= this.parentSeries[i];
					num2++;
				}
			}
			num = Math.Pow(Math.Abs(num), 1.0 / (double)num2);
			return num / -this.maxDrawDown.Series[date, EIndexOption.Prev];
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006ED9 File Offset: 0x00005ED9
		public override void Reset()
		{
			base.Reset();
		}

		// Token: 0x04000070 RID: 112
		protected SeriesTesterItem maxDrawDown;
	}
}
