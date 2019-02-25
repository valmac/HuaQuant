using System;
using SmartQuant.FIX;

namespace SmartQuant.Simulation
{
	// Token: 0x02000007 RID: 7
	public class CustomCommissionProvider : CommissionProvider
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000026F1 File Offset: 0x000016F1
		public CustomCommissionProvider()
		{
			this.fCommType = CommType.PerShare;
			this.fCommission = 100.0;
		}
	}
}
