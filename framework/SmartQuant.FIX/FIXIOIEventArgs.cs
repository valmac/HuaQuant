using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000115 RID: 277
	public class FIXIOIEventArgs : EventArgs
	{
		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x00036E15 File Offset: 0x00035E15
		// (set) Token: 0x060033FC RID: 13308 RVA: 0x00036E1D File Offset: 0x00035E1D
		public FIXIOI IOI
		{
			get
			{
				return this.fIOI;
			}
			set
			{
				this.fIOI = value;
			}
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00036E26 File Offset: 0x00035E26
		public FIXIOIEventArgs(FIXIOI IOI)
		{
			this.fIOI = IOI;
		}

		// Token: 0x040004F5 RID: 1269
		private FIXIOI fIOI;
	}
}
