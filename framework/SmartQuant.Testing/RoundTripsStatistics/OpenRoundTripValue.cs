using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000033 RID: 51
	public class OpenRoundTripValue : RoundTripsTesterItem
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00006F43 File Offset: 0x00005F43
		public OpenRoundTripValue(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006F50 File Offset: 0x00005F50
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
				if (i >= this.parentRoundTripList.CountOfClosedRoundTrips())
				{
					double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
					num += roundTripResultWithoutCost;
					this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006FDC File Offset: 0x00005FDC
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = this.parentRoundTripList.CountOfClosedRoundTrips(); i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				num += roundTripResultWithoutCost;
			}
			return num;
		}
	}
}
