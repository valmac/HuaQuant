using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000006 RID: 6
	public class FIXSecurityDefinitionRequestEventArgs : EventArgs
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000034AA File Offset: 0x000024AA
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000034B2 File Offset: 0x000024B2
		public FIXSecurityDefinitionRequest SecurityDefinitionRequest
		{
			get
			{
				return this.fSecurityDefinitionRequest;
			}
			set
			{
				this.fSecurityDefinitionRequest = value;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000034BB File Offset: 0x000024BB
		public FIXSecurityDefinitionRequestEventArgs(FIXSecurityDefinitionRequest SecurityDefinitionRequest)
		{
			this.fSecurityDefinitionRequest = SecurityDefinitionRequest;
		}

		// Token: 0x0400000C RID: 12
		private FIXSecurityDefinitionRequest fSecurityDefinitionRequest;
	}
}
