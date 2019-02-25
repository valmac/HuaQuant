using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200014B RID: 331
	public class FIXPartiesEventArgs : EventArgs
	{
		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x00045599 File Offset: 0x00044599
		// (set) Token: 0x06003FA2 RID: 16290 RVA: 0x000455A1 File Offset: 0x000445A1
		public FIXParties Parties
		{
			get
			{
				return this.fParties;
			}
			set
			{
				this.fParties = value;
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x000455AA File Offset: 0x000445AA
		public FIXPartiesEventArgs(FIXParties Parties)
		{
			this.fParties = Parties;
		}

		// Token: 0x04000954 RID: 2388
		private FIXParties fParties;
	}
}
