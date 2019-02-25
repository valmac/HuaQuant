using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000059 RID: 89
	public class ConsecutiveLosers : RoundTripsTesterItem
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0000E92C File Offset: 0x0000D92C
		public ConsecutiveLosers(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000E938 File Offset: 0x0000D938
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
				if (roundTripResultWithoutCost > 0.0)
				{
					num = 0.0;
				}
				if (roundTripResultWithoutCost < 0.0)
				{
					num += 1.0;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000E9E0 File Offset: 0x0000D9E0
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = lastIndex; i >= 0; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				if (roundTripResultWithoutCost < 0.0)
				{
					num += 1.0;
				}
				if (roundTripResultWithoutCost > 0.0)
				{
					return num;
				}
			}
			return num;
		}
	}
}
