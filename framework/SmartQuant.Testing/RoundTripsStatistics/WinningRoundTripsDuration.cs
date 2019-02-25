using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000023 RID: 35
	public class WinningRoundTripsDuration : RoundTripsTesterItem
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00005982 File Offset: 0x00004982
		public WinningRoundTripsDuration(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000598C File Offset: 0x0000498C
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			int num = 0;
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (this.parentRoundTripList[i].RoundTripResultWithCost > 0.0)
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
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005A6C File Offset: 0x00004A6C
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = lastIndex; i >= 0; i--)
			{
				if (this.parentRoundTripList[i].RoundTripResultWithCost > 0.0)
				{
					num = (double)(this.parentRoundTripList[i].ExitDateTime.Ticks - this.parentRoundTripList[i].EntryDateTime.Ticks);
					break;
				}
			}
			if ((num + 1.0) % 864000000000.0 == 0.0)
			{
				num += 1.0;
			}
			return num;
		}
	}
}
