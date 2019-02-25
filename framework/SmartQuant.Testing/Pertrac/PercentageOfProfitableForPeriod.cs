using System;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000026 RID: 38
	public class PercentageOfProfitableForPeriod : SeriesTesterItem
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00006467 File Offset: 0x00005467
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000646F File Offset: 0x0000546F
		public TimeIntervalSize IntervalSize
		{
			get
			{
				return this.intervalSize;
			}
			set
			{
				this.intervalSize = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006478 File Offset: 0x00005478
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00006480 File Offset: 0x00005480
		public TimeIntervalSize PeriodLength
		{
			get
			{
				return this.periodLength;
			}
			set
			{
				this.periodLength = value;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006489 File Offset: 0x00005489
		public PercentageOfProfitableForPeriod(string name, SeriesTesterItem parentSeriesItem, TimeIntervalSize intervalSize, TimeIntervalSize periodLength) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
			this.intervalSize = intervalSize;
			this.periodLength = periodLength;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000064B8 File Offset: 0x000054B8
		public PercentageOfProfitableForPeriod(string name) : base(name)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000064C1 File Offset: 0x000054C1
		public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize)
		{
			return this.AddInterval(dateTime, intervalSize, 1);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000064CC File Offset: 0x000054CC
		public DateTime SubtractInterval(DateTime dateTime, TimeIntervalSize intervalSize)
		{
			return this.AddInterval(dateTime, intervalSize, -1);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000064D8 File Offset: 0x000054D8
		public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize, int multiplier)
		{
			if (intervalSize <= TimeIntervalSize.month9)
			{
				if (intervalSize <= TimeIntervalSize.month3)
				{
					if (intervalSize == TimeIntervalSize.month1)
					{
						return dateTime.AddMonths(multiplier);
					}
					if (intervalSize == TimeIntervalSize.month2)
					{
						return dateTime.AddMonths(2 * multiplier);
					}
					if (intervalSize == TimeIntervalSize.month3)
					{
						return dateTime.AddMonths(3 * multiplier);
					}
				}
				else
				{
					if (intervalSize == TimeIntervalSize.month4)
					{
						return dateTime.AddMonths(4 * multiplier);
					}
					if (intervalSize == TimeIntervalSize.month6)
					{
						return dateTime.AddMonths(6 * multiplier);
					}
					if (intervalSize == TimeIntervalSize.month9)
					{
						return dateTime.AddMonths(9 * multiplier);
					}
				}
			}
			else if (intervalSize <= TimeIntervalSize.year3)
			{
				if (intervalSize == TimeIntervalSize.year1)
				{
					return dateTime.AddYears(multiplier);
				}
				if (intervalSize == TimeIntervalSize.year2)
				{
					return dateTime.AddYears(2 * multiplier);
				}
				if (intervalSize == TimeIntervalSize.year3)
				{
					return dateTime.AddYears(3 * multiplier);
				}
			}
			else if (intervalSize <= TimeIntervalSize.year5)
			{
				if (intervalSize == TimeIntervalSize.year4)
				{
					return dateTime.AddYears(4 * multiplier);
				}
				if (intervalSize == TimeIntervalSize.year5)
				{
					return dateTime.AddYears(5 * multiplier);
				}
			}
			else
			{
				if (intervalSize == TimeIntervalSize.year10)
				{
					return dateTime.AddYears(10 * multiplier);
				}
				if (intervalSize == TimeIntervalSize.year20)
				{
					return dateTime.AddYears(20 * multiplier);
				}
			}
			return dateTime.AddTicks((long)intervalSize * multiplier);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000066B4 File Offset: 0x000056B4
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			if (firstIndex <= lastIndex)
			{
				DateTime dateTime = this.parentSeries.GetDateTime(lastIndex);
				DateTime dateTime2 = DateTime.MinValue;
				if (this.series.Count == 0)
				{
					if (this.AddInterval(this.parentSeries.FirstDateTime, this.periodLength) <= this.parentSeries.LastDateTime)
					{
						dateTime2 = this.AddInterval(this.parentSeries.FirstDateTime, this.periodLength);
					}
				}
				else
				{
					dateTime2 = this.AddInterval(this.series.LastDateTime, this.intervalSize);
				}
				if (dateTime2 != DateTime.MinValue)
				{
					DateTime dateTime3 = dateTime2;
					while (dateTime3 <= dateTime)
					{
						DateTime dateTime4;
						if (dateTime3 == dateTime2)
						{
							dateTime4 = this.parentSeries.FirstDateTime;
						}
						else
						{
							dateTime4 = this.SubtractInterval(dateTime3, this.periodLength);
						}
						double num = this.parentSeries[dateTime3, EIndexOption.Prev];
						double num2 = this.parentSeries[dateTime4, EIndexOption.Prev];
						double data;
						if (num >= num2)
						{
							data = 1.0;
						}
						else
						{
							data = 0.0;
						}
						this.series.Add(dateTime3, data);
						dateTime3 = this.AddInterval(dateTime3, this.IntervalSize);
					}
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006804 File Offset: 0x00005804
		protected override double GetValue(DateTime date)
		{
			if (this.parentSeries.Count <= 1)
			{
				return double.NaN;
			}
			DateTime dateTime = this.AddInterval(this.parentSeries.FirstDateTime, this.periodLength);
			this.parentSeries.GetIndex(date);
			while (dateTime < date)
			{
				dateTime = this.AddInterval(dateTime, this.intervalSize);
			}
			dateTime = this.SubtractInterval(dateTime, this.intervalSize);
			DateTime dateTime2 = this.SubtractInterval(dateTime, this.periodLength);
			if (!(dateTime2 >= this.parentSeries.FirstDateTime))
			{
				return double.NaN;
			}
			double num = this.parentSeries[dateTime, EIndexOption.Prev];
			double num2 = this.parentSeries[dateTime2, EIndexOption.Prev];
			if (num >= num2)
			{
				return 1.0;
			}
			return 0.0;
		}

		// Token: 0x04000047 RID: 71
		protected TimeIntervalSize intervalSize;

		// Token: 0x04000048 RID: 72
		protected TimeIntervalSize periodLength;
	}
}
