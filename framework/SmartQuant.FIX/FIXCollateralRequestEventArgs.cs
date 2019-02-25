using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000025 RID: 37
	public class FIXCollateralRequestEventArgs : EventArgs
	{
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0000AA7B File Offset: 0x00009A7B
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0000AA83 File Offset: 0x00009A83
		public FIXCollateralRequest CollateralRequest
		{
			get
			{
				return this.fCollateralRequest;
			}
			set
			{
				this.fCollateralRequest = value;
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0000AA8C File Offset: 0x00009A8C
		public FIXCollateralRequestEventArgs(FIXCollateralRequest CollateralRequest)
		{
			this.fCollateralRequest = CollateralRequest;
		}

		// Token: 0x04000060 RID: 96
		private FIXCollateralRequest fCollateralRequest;
	}
}
