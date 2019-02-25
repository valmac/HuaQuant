using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000051 RID: 81
	public class LosingRoundTripsTotalPnL : RoundTripsTesterItem
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0000E43F File Offset: 0x0000D43F
		public LosingRoundTripsTotalPnL(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000E44C File Offset: 0x0000D44C
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
					num += roundTripResultWithoutCost;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000E4D4 File Offset: 0x0000D4D4
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = 0; i <= lastIndex; i++)
			{
				double roundTripResultWithoutCost = this.parentRoundTripList[i].RoundTripResultWithoutCost;
				if (roundTripResultWithoutCost < 0.0)
				{
					num += roundTripResultWithoutCost;
				}
			}
			return num;
		}
	}
}
