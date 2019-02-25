using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000040 RID: 64
	public class WinningRoundTrips : RoundTripsTesterItem
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0000C910 File Offset: 0x0000B910
		public WinningRoundTrips(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000C91C File Offset: 0x0000B91C
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
				if (this.parentRoundTripList[i].RoundTripResultWithoutCost > 0.0)
				{
					num += 1.0;
				}
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000C9AC File Offset: 0x0000B9AC
		protected override double GetValue(int lastIndex)
		{
			double num = 0.0;
			for (int i = 0; i <= lastIndex; i++)
			{
				if (this.parentRoundTripList[i].RoundTripResultWithoutCost > 0.0)
				{
					num += 1.0;
				}
			}
			return num;
		}
	}
}
