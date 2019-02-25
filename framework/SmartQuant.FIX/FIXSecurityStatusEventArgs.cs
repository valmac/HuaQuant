using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200015D RID: 349
	public class FIXSecurityStatusEventArgs : EventArgs
	{
		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x060040F0 RID: 16624 RVA: 0x00047086 File Offset: 0x00046086
		// (set) Token: 0x060040F1 RID: 16625 RVA: 0x0004708E File Offset: 0x0004608E
		public FIXSecurityStatus SecurityStatus
		{
			get
			{
				return this.fSecurityStatus;
			}
			set
			{
				this.fSecurityStatus = value;
			}
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00047097 File Offset: 0x00046097
		public FIXSecurityStatusEventArgs(FIXSecurityStatus SecurityStatus)
		{
			this.fSecurityStatus = SecurityStatus;
		}

		// Token: 0x04000994 RID: 2452
		private FIXSecurityStatus fSecurityStatus;
	}
}
