using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000057 RID: 87
	public class LosingRoundTripsDuration : RoundTripsTesterItem
	{
		// Token: 0x06000273 RID: 627 RVA: 0x0000E6B4 File Offset: 0x0000D6B4
		public LosingRoundTripsDuration(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000E6C0 File Offset: 0x0000D6C0
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			int num = 0;
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				if (this.parentRoundTripList[i].RoundTripResultWithCost < 0.0)
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

		// Token: 0x06000275 RID: 629 RVA: 0x0000E7A0 File Offset: 0x0000D7A0
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = lastIndex; i >= 0; i--)
			{
				if (this.parentRoundTripList[i].RoundTripResultWithCost < 0.0)
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
