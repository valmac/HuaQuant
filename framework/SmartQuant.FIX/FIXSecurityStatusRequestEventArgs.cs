using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200015B RID: 347
	public class FIXSecurityStatusRequestEventArgs : EventArgs
	{
		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x00046470 File Offset: 0x00045470
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x00046478 File Offset: 0x00045478
		public FIXSecurityStatusRequest SecurityStatusRequest
		{
			get
			{
				return this.fSecurityStatusRequest;
			}
			set
			{
				this.fSecurityStatusRequest = value;
			}
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00046481 File Offset: 0x00045481
		public FIXSecurityStatusRequestEventArgs(FIXSecurityStatusRequest SecurityStatusRequest)
		{
			this.fSecurityStatusRequest = SecurityStatusRequest;
		}

		// Token: 0x0400098C RID: 2444
		private FIXSecurityStatusRequest fSecurityStatusRequest;
	}
}
