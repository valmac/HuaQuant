using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200017B RID: 379
	public class FIXSecurityListRequestEventArgs : EventArgs
	{
		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x0004D3D5 File Offset: 0x0004C3D5
		// (set) Token: 0x0600458D RID: 17805 RVA: 0x0004D3DD File Offset: 0x0004C3DD
		public FIXSecurityListRequest SecurityListRequest
		{
			get
			{
				return this.fSecurityListRequest;
			}
			set
			{
				this.fSecurityListRequest = value;
			}
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0004D3E6 File Offset: 0x0004C3E6
		public FIXSecurityListRequestEventArgs(FIXSecurityListRequest SecurityListRequest)
		{
			this.fSecurityListRequest = SecurityListRequest;
		}

		// Token: 0x04000D88 RID: 3464
		private FIXSecurityListRequest fSecurityListRequest;
	}
}
