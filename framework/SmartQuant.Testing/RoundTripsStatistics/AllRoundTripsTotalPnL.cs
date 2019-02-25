using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200002E RID: 46
	public class AllRoundTripsTotalPnL : RoundTripsTesterItem
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00006CF1 File Offset: 0x00005CF1
		public AllRoundTripsTotalPnL(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006CFC File Offset: 0x00005CFC
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			double num;
			if (this.series.Count == 0)
			{
				num = 0.0;
			}
			else
			{
				num = this.series.Last;
			}
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				num += roundTripResultWithoutCost;
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006D78 File Offset: 0x00005D78
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = 0; i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				num += roundTripResultWithoutCost;
			}
			return num;
		}
	}
}
