using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200000F RID: 15
	public class RoundTripsExitEfficiency : RoundTripsTesterItem
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00003440 File Offset: 0x00002440
		public RoundTripsExitEfficiency(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000344C File Offset: 0x0000244C
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			int num = 0;
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				double exitEfficiency = this.parentRoundTripList[i].ExitEfficiency;
				if (!double.IsNaN(exitEfficiency))
				{
					if (this.series.Contains(this.parentRoundTripList[i].ExitDateTime))
					{
						this.series.Add(this.parentRoundTripList[i].ExitDateTime.AddTicks((long)num), exitEfficiency);
						num++;
					}
					else
					{
						num = 0;
					}
					this.series.Add(this.parentRoundTripList[i].ExitDateTime, exitEfficiency);
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000034F4 File Offset: 0x000024F4
		protected override double GetValue(int lastIndex)
		{
			if (lastIndex < 0)
			{
				return double.NaN;
			}
			return this.parentRoundTripList[lastIndex].ExitEfficiency;
		}
	}
}
