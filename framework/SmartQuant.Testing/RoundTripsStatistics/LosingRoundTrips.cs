using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000058 RID: 88
	public class LosingRoundTrips : RoundTripsTesterItem
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000E843 File Offset: 0x0000D843
		public LosingRoundTrips(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000E850 File Offset: 0x0000D850
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
				if (this.parentRoundTripList[i].RoundTripResultWithoutCost < 0.0)
				{
					num += 1.0;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000E8E0 File Offset: 0x0000D8E0
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = 0; i <= lastIndex; i++)
			{
				if (this.parentRoundTripList[i].RoundTripResultWithoutCost < 0.0)
				{
					num += 1.0;
				}
			}
			return num;
		}
	}
}
