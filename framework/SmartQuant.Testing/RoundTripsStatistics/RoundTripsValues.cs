using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200000E RID: 14
	public class RoundTripsValues : RoundTripsTesterItem
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003377 File Offset: 0x00002377
		public RoundTripsValues(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003384 File Offset: 0x00002384
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			double data;
			if (this.series.Count == 0)
			{
				data = 0.0;
			}
			else
			{
				data = this.series.Last;
			}
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, data);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000033FC File Offset: 0x000023FC
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
