using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000126 RID: 294
	public class FIXSecurityTypeRequestEventArgs : EventArgs
	{
		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x0003A169 File Offset: 0x00039169
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x0003A171 File Offset: 0x00039171
		public FIXSecurityTypeRequest SecurityTypeRequest
		{
			get
			{
				return this.fSecurityTypeRequest;
			}
			set
			{
				this.fSecurityTypeRequest = value;
			}
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x0003A17A File Offset: 0x0003917A
		public FIXSecurityTypeRequestEventArgs(FIXSecurityTypeRequest SecurityTypeRequest)
		{
			this.fSecurityTypeRequest = SecurityTypeRequest;
		}

		// Token: 0x0400050F RID: 1295
		private FIXSecurityTypeRequest fSecurityTypeRequest;
	}
}
