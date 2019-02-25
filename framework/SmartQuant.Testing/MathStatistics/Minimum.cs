using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.MathStatistics
{
	// Token: 0x0200000C RID: 12
	public class Minimum : SeriesTesterItem
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00003120 File Offset: 0x00002120
		public Minimum(string name, SeriesTesterItem parentSeriesItem) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000314F File Offset: 0x0000214F
		public Minimum(string name) : base(name)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003168 File Offset: 0x00002168
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(lastIndex);
				if (this.series.Contains(dateTime))
				{
					if (this.series.Count == 1)
					{
						this.min = this.parentSeries[dateTime];
					}
					else
					{
						this.min = Math.Min(this.parentSeries[dateTime], this.series[this.series.Count - 2]);
					}
					this.series.Add(dateTime, this.min);
				}
				for (int i = firstIndex; i <= lastIndex; i++)
				{
					DateTime dateTime2 = this.parentSeries.GetDateTime(i);
					this.min = Math.Min(this.parentSeries[dateTime2], this.min);
					this.series.Add(dateTime2, this.min);
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003244 File Offset: 0x00002244
		protected override double GetValue(DateTime date)
		{
			double num = double.MaxValue;
			int index = this.parentSeries.GetIndex(date);
			for (int i = 0; i <= index; i++)
			{
				num = Math.Min(this.parentSeries[i], num);
			}
			return num;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003288 File Offset: 0x00002288
		public override void Reset()
		{
			this.min = double.MaxValue;
			base.Reset();
		}

		// Token: 0x04000017 RID: 23
		private double min = double.MaxValue;
	}
}
