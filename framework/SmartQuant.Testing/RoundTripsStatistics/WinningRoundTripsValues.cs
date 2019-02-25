using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000046 RID: 70
	public class WinningRoundTripsValues : RoundTripsTesterItem
	{
		// Token: 0x06000238 RID: 568 RVA: 0x0000D48A File Offset: 0x0000C48A
		public WinningRoundTripsValues(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000D494 File Offset: 0x0000C494
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			DateTime exitDateTime = this.parentRoundTripList[lastIndex].ExitDateTime;
			int num2 = lastIndex;
			while (num2 != -1 && exitDateTime == this.parentRoundTripList[num2].ExitDateTime)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[num2].RoundTripResultWithoutCost;
				if (roundTripResultWithoutCost > 0.0)
				{
					num += roundTripResultWithoutCost;
				}
				num2--;
			}
			return num;
		}
	}
}
