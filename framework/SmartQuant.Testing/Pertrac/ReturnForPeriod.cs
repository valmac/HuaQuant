using System;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x02000044 RID: 68
	public class ReturnForPeriod : SeriesTesterItem
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000CE7E File Offset: 0x0000BE7E
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000CE86 File Offset: 0x0000BE86
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000CE8F File Offset: 0x0000BE8F
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000CE97 File Offset: 0x0000BE97
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

		// Token: 0x0600022D RID: 557 RVA: 0x0000CEA0 File Offset: 0x0000BEA0
		public ReturnForPeriod(string name, SeriesTesterItem parentSeriesItem, TimeIntervalSize intervalSize, TimeIntervalSize periodLength) : base(name, parentSeriesItem, name + " - " + parentSeriesItem.Series.Title)
		{
			this.intervalSize = intervalSize;
			this.periodLength = periodLength;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000CECF File Offset: 0x0000BECF
		public ReturnForPeriod(string name) : base(name)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000CED8 File Offset: 0x0000BED8
		public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize)
		{
			return this.AddInterval(dateTime, intervalSize, 1);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000CEE3 File Offset: 0x0000BEE3
		public DateTime SubtractInterval(DateTime dateTime, TimeIntervalSize intervalSize)
		{
			return this.AddInterval(dateTime, intervalSize, -1);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000CEF0 File Offset: 0x0000BEF0
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
			return dateTime.AddTicks(((long)intervalSize * multiplier));
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000D0CC File Offset: 0x0000C0CC
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
						this.series.Add(dateTime3, (num / num2 - 1.0) * 100.0);
						dateTime3 = this.AddInterval(dateTime3, this.IntervalSize);
					}
				}
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000D20C File Offset: 0x0000C20C
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
			if (dateTime2 >= this.parentSeries.FirstDateTime)
			{
				double num = this.parentSeries[dateTime, EIndexOption.Prev];
				double num2 = this.parentSeries[dateTime2, EIndexOption.Prev];
				return (num / num2 - 1.0) * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x040000DD RID: 221
		protected TimeIntervalSize intervalSize;

		// Token: 0x040000DE RID: 222
		protected TimeIntervalSize periodLength;
	}
}
