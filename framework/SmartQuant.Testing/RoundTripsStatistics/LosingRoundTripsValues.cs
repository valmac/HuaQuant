using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200002D RID: 45
	public class LosingRoundTripsValues : RoundTripsTesterItem
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00006C73 File Offset: 0x00005C73
		public LosingRoundTripsValues(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006C80 File Offset: 0x00005C80
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			DateTime exitDateTime = this.parentRoundTripList[lastIndex].ExitDateTime;
			int num2 = lastIndex;
			while (num2 != -1 && exitDateTime == this.parentRoundTripList[num2].ExitDateTime)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[num2].RoundTripResultWithoutCost;
				if (roundTripResultWithoutCost < 0.0)
				{
					num += roundTripResultWithoutCost;
				}
				num2--;
			}
			return num;
		}
	}
}
