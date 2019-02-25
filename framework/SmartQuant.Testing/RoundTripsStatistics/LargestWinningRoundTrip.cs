using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000041 RID: 65
	public class LargestWinningRoundTrip : RoundTripsTesterItem
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0000C9F8 File Offset: 0x0000B9F8
		public LargestWinningRoundTrip(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000CA04 File Offset: 0x0000BA04
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			double num;
			if (this.series.Count == 0)
			{
				num = double.MinValue;
			}
			else
			{
				num = this.series.Last;
			}
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				num = Math.Max(num, this.parentRoundTripList[i].RoundTripResultWithoutCost);
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000CA78 File Offset: 0x0000BA78
		protected override double GetValue(int lastIndex)
		{
			double num = double.MinValue;
			for (int i = 0; i <= lastIndex; i++)
			{
				num = Math.Max(num, this.parentRoundTripList[i].RoundTripResultWithoutCost);
			}
			return num;
		}
	}
}
