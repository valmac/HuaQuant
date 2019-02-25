using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000179 RID: 377
	public class FIXSettlPartiesEventArgs : EventArgs
	{
		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x0004D347 File Offset: 0x0004C347
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x0004D34F File Offset: 0x0004C34F
		public FIXSettlParties SettlParties
		{
			get
			{
				return this.fSettlParties;
			}
			set
			{
				this.fSettlParties = value;
			}
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x0004D358 File Offset: 0x0004C358
		public FIXSettlPartiesEventArgs(FIXSettlParties SettlParties)
		{
			this.fSettlParties = SettlParties;
		}

		// Token: 0x04000D86 RID: 3462
		private FIXSettlParties fSettlParties;
	}
}
