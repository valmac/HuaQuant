using System;
using SmartQuant.Testing.RoundTrips;

namespace SmartQuant.Testing.RoundTripsStatistics
{
	// Token: 0x0200004B RID: 75
	public class TotalRoundTripsEfficiency : RoundTripsTesterItem
	{
		// Token: 0x0600024B RID: 587 RVA: 0x0000DDAC File Offset: 0x0000CDAC
		public TotalRoundTripsEfficiency(RoundTripList parentRoundTripList, string title) : base(parentRoundTripList, title)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000DDB8 File Offset: 0x0000CDB8
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			int num = 0;
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				double totalEfficiency = this.parentRoundTripList[i].TotalEfficiency;
				if (!double.IsNaN(totalEfficiency))
				{
					if (this.series.Contains(this.parentRoundTripList[i].ExitDateTime))
					{
						this.series.Add(this.parentRoundTripList[i].ExitDateTime.AddTicks((long)num), totalEfficiency);
						num++;
					}
					else
					{
						num = 0;
					}
					this.series.Add(this.parentRoundTripList[i].ExitDateTime, totalEfficiency);
				}
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000DE60 File Offset: 0x0000CE60
		protected override double GetValue(int lastIndex)
		{
			if (lastIndex < 0)
			{
				return double.NaN;
			}
			return this.parentRoundTripList[lastIndex].TotalEfficiency;
		}
	}
}
