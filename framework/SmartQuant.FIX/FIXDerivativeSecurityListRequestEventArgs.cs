using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200006B RID: 107
	public class FIXDerivativeSecurityListRequestEventArgs : EventArgs
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00015C61 File Offset: 0x00014C61
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00015C69 File Offset: 0x00014C69
		public FIXDerivativeSecurityListRequest DerivativeSecurityListRequest
		{
			get
			{
				return this.fDerivativeSecurityListRequest;
			}
			set
			{
				this.fDerivativeSecurityListRequest = value;
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00015C72 File Offset: 0x00014C72
		public FIXDerivativeSecurityListRequestEventArgs(FIXDerivativeSecurityListRequest DerivativeSecurityListRequest)
		{
			this.fDerivativeSecurityListRequest = DerivativeSecurityListRequest;
		}

		// Token: 0x0400025C RID: 604
		private FIXDerivativeSecurityListRequest fDerivativeSecurityListRequest;
	}
}
