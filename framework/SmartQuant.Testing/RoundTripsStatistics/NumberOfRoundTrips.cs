using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200004C RID: 76
	public class NumberOfRoundTrips : RoundTripsTesterItem
	{
		// Token: 0x0600024E RID: 590 RVA: 0x0000DE98 File Offset: 0x0000CE98
		public NumberOfRoundTrips(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000DEA4 File Offset: 0x0000CEA4
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, (double)(i + 1));
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000DEDD File Offset: 0x0000CEDD
		protected override double GetValue(int lastIndex)
		{
			return (double)(lastIndex + 1);
		}
	}
}
