using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000056 RID: 86
	public class ConsecutiveWinners : RoundTripsTesterItem
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0000E5A6 File Offset: 0x0000D5A6
		public ConsecutiveWinners(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000E5B0 File Offset: 0x0000D5B0
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
				if (roundTripResultWithoutCost < 0.0)
				{
					num = 0.0;
				}
				if (roundTripResultWithoutCost > 0.0)
				{
					num += 1.0;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000E658 File Offset: 0x0000D658
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = 0; i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				if (roundTripResultWithoutCost > 0.0)
				{
					num += 1.0;
				}
				if (roundTripResultWithoutCost < 0.0)
				{
					return num;
				}
			}
			return num;
		}
	}
}
