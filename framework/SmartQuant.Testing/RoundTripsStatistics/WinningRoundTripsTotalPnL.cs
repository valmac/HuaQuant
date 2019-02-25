using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200001F RID: 31
	public class WinningRoundTripsTotalPnL : RoundTripsTesterItem
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x000051B9 File Offset: 0x000041B9
		public WinningRoundTripsTotalPnL(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000051C4 File Offset: 0x000041C4
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
					num += roundTripResultWithoutCost;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000524C File Offset: 0x0000424C
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = 0; i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				if (roundTripResultWithoutCost > 0.0)
				{
					num += roundTripResultWithoutCost;
				}
			}
			return num;
		}
	}
}
