using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000082 RID: 130
	public class FIXFinancingDetailsEventArgs : EventArgs
	{
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x0001BA65 File Offset: 0x0001AA65
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x0001BA6D File Offset: 0x0001AA6D
		public FIXFinancingDetails FinancingDetails
		{
			get
			{
				return this.fFinancingDetails;
			}
			set
			{
				this.fFinancingDetails = value;
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0001BA76 File Offset: 0x0001AA76
		public FIXFinancingDetailsEventArgs(FIXFinancingDetails FinancingDetails)
		{
			this.fFinancingDetails = FinancingDetails;
		}

		// Token: 0x040002A9 RID: 681
		private FIXFinancingDetails fFinancingDetails;
	}
}
