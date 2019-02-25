using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.MathStatistics
{
	// Token: 0x0200001C RID: 28
	public class Maximum : SeriesTesterItem
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00004D95 File Offset: 0x00003D95
		public Maximum(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004DC4 File Offset: 0x00003DC4
		public Maximum(string name) : base(name)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004DDC File Offset: 0x00003DDC
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(lastIndex);
				if (this.series.Contains(dateTime))
				{
					if (this.series.Count == 1)
					{
						this.max = this.parentSeries[dateTime];
					}
					else
					{
						this.max = Math.Max(this.parentSeries[dateTime], this.series[this.series.Count - 2]);
					}
					this.series.Add(dateTime, this.max);
				}
				for (int i = firstIndex; i <= lastIndex; i++)
				{
					DateTime dateTime2 = this.parentSeries.GetDateTime(i);
					this.max = Math.Max(this.parentSeries[dateTime2], this.max);
					this.series.Add(dateTime2, this.max);
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004EB8 File Offset: 0x00003EB8
		protected override double GetValue(DateTime date)
		{
			double num = double.MinValue;
			int index = this.parentSeries.GetIndex(date);
			for (int i = 0; i <= index; i++)
			{
				num = Math.Max(this.parentSeries[i], num);
			}
			return num;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004EFC File Offset: 0x00003EFC
		public override void Reset()
		{
			this.max = double.MinValue;
			base.Reset();
		}

		// Token: 0x0400002E RID: 46
		private double max = double.MinValue;
	}
}
