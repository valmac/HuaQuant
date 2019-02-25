using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000047 RID: 71
	public class RoundTripsDuration : RoundTripsTesterItem
	{
		// Token: 0x0600023A RID: 570 RVA: 0x0000D505 File Offset: 0x0000C505
		public RoundTripsDuration(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000D510 File Offset: 0x0000C510
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			int num = 0;
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				DateTime entryDateTime = this.parentRoundTripList[i].EntryDateTime;
				DateTime exitDateTime = this.parentRoundTripList[i].ExitDateTime;
				long num2 = exitDateTime.Ticks - entryDateTime.Ticks;
				if ((num2 + 1L) % 864000000000L == 0L)
				{
					num2 += 1L;
				}
				if (this.series.Contains(exitDateTime))
				{
					this.series.Add(exitDateTime.AddTicks((long)num), (double)num2);
					num++;
				}
				else
				{
					num = 0;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, (double)num2);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000D5D0 File Offset: 0x0000C5D0
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			if (lastIndex >= 0)
			{
				num = (double)(this.parentRoundTripList[lastIndex].ExitDateTime.Ticks - this.parentRoundTripList[lastIndex].EntryDateTime.Ticks);
			}
			if ((num + 1.0) % 864000000000.0 == 0.0)
			{
				num += 1.0;
			}
			return num;
		}
	}
}
