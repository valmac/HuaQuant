using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x02000042 RID: 66
	public class LargestLosingRoundTrip : RoundTripsTesterItem
	{
		// Token: 0x06000221 RID: 545 RVA: 0x0000CAB4 File Offset: 0x0000BAB4
		public LargestLosingRoundTrip(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000CAC0 File Offset: 0x0000BAC0
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			double num;
			if (this.series.Count == 0)
			{
				num = double.MaxValue;
			}
			else
			{
				num = this.series.Last;
			}
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				num = Math.Min(num, this.parentRoundTripList[i].RoundTripResultWithoutCost);
				this.series.Add(this.parentRoundTripList[i].ExitDateTime, num);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000CB34 File Offset: 0x0000BB34
		protected override double GetValue(int lastIndex)
		{
			double num = double.MaxValue;
			for (int i = 0; i <= lastIndex; i++)
			{
				num = Math.Min(num, this.parentRoundTripList[i].RoundTripResultWithoutCost);
			}
			return num;
		}
	}
}
