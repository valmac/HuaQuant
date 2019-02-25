using System;

namespace SmartQuant.Data
{
	// Token: 0x02000006 RID: 6
	public class BarMaker
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002379 File Offset: 0x00001379
		private BarMaker()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002384 File Offset: 0x00001384
		public static void MakeBars(IDataSeries tradeSeries, IDataSeries barSeries, BarType barType, long barSize)
		{
			switch (barType)
			{
			case BarType.Time:
			{
				Bar bar = null;
				foreach (object obj in tradeSeries)
				{
					Trade trade = (Trade)obj;
					if (bar == null || bar.EndTime <= trade.DateTime)
					{
						if (bar != null)
						{
							barSeries.Add(bar.DateTime, bar);
						}
						DateTime barDateTime = BarMaker.GetBarDateTime(trade.DateTime, barSize);
						bar = new Bar(BarType.Time, barSize, barDateTime, barDateTime.AddSeconds((double)barSize), trade.Price, trade.Price, trade.Price, trade.Price, (long)trade.Size, 0L);
					}
					else
					{
						if (trade.Price > bar.High)
						{
							bar.High = trade.Price;
						}
						if (trade.Price < bar.Low)
						{
							bar.Low = trade.Price;
						}
						bar.Close = trade.Price;
						bar.Volume += (long)trade.Size;
					}
				}
				if (bar != null)
				{
					barSeries.Add(bar.DateTime, bar);
				}
				barSeries.Flush();
				return;
			}
			case BarType.Tick:
			{
				Bar bar2 = null;
				int num = 0;
				foreach (object obj2 in tradeSeries)
				{
					Trade trade2 = (Trade)obj2;
					if (bar2 == null)
					{
						bar2 = new Bar(BarType.Tick, barSize, trade2.DateTime, trade2.DateTime, trade2.Price, trade2.Price, trade2.Price, trade2.Price, (long)trade2.Size, 0L);
						num = 1;
					}
					else
					{
						bar2.EndTime = trade2.DateTime;
						if (trade2.Price > bar2.High)
						{
							bar2.High = trade2.Price;
						}
						if (trade2.Price < bar2.Low)
						{
							bar2.Low = trade2.Price;
						}
						bar2.Close = trade2.Price;
						bar2.Volume += (long)trade2.Size;
						num++;
					}
					if ((long)num == barSize)
					{
						barSeries.Add(bar2.DateTime, bar2);
						bar2 = null;
					}
				}
				if (bar2 != null)
				{
					barSeries.Add(bar2.DateTime, bar2);
				}
				barSeries.Flush();
				return;
			}
			case BarType.Volume:
			{
				Bar bar3 = null;
				foreach (object obj3 in tradeSeries)
				{
					Trade trade3 = (Trade)obj3;
					if (bar3 == null)
					{
						bar3 = new Bar(BarType.Volume, barSize, trade3.DateTime, trade3.DateTime, trade3.Price, trade3.Price, trade3.Price, trade3.Price, (long)trade3.Size, 0L);
					}
					else
					{
						bar3.EndTime = trade3.DateTime;
						if (trade3.Price > bar3.High)
						{
							bar3.High = trade3.Price;
						}
						if (trade3.Price < bar3.Low)
						{
							bar3.Low = trade3.Price;
						}
						bar3.Close = trade3.Price;
						bar3.Volume += (long)trade3.Size;
					}
					if (bar3.Volume >= barSize)
					{
						barSeries.Add(bar3.DateTime, bar3);
						bar3 = null;
					}
				}
				if (bar3 != null)
				{
					barSeries.Add(bar3.DateTime, bar3);
				}
				barSeries.Flush();
				return;
			}
			default:
				throw new NotImplementedException("Cannot make bars with type - " + barType.ToString());
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000274C File Offset: 0x0000174C
		private static DateTime GetBarDateTime(DateTime tradeDateTime, long barSize)
		{
			long num = (long)tradeDateTime.TimeOfDay.TotalSeconds / barSize * barSize;
			return tradeDateTime.Date.AddSeconds((double)num);
		}
	}
}
