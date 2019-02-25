using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200000B RID: 11
	public class RoundTripsEntryEfficiency : RoundTripsTesterItem
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003035 File Offset: 0x00002035
		public RoundTripsEntryEfficiency(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003040 File Offset: 0x00002040
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			int num = 0;
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				double entryEfficiency = this.parentRoundTripList[i].EntryEfficiency;
				if (!double.IsNaN(entryEfficiency))
				{
					if (this.series.Contains(this.parentRoundTripList[i].ExitDateTime))
					{
						this.series.Add(this.parentRoundTripList[i].ExitDateTime.AddTicks((long)num), entryEfficiency);
						num++;
					}
					else
					{
						num = 0;
					}
					this.series.Add(this.parentRoundTripList[i].ExitDateTime, entryEfficiency);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000030E8 File Offset: 0x000020E8
		protected override double GetValue(int lastIndex)
		{
			if (lastIndex < 0)
			{
				return double.NaN;
			}
			return this.parentRoundTripList[lastIndex].EntryEfficiency;
		}
	}
}
