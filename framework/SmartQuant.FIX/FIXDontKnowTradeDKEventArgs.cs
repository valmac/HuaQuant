using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200009A RID: 154
	public class FIXDontKnowTradeDKEventArgs : EventArgs
	{
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x00022DA5 File Offset: 0x00021DA5
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00022DAD File Offset: 0x00021DAD
		public FIXDontKnowTradeDK DontKnowTradeDK
		{
			get
			{
				return this.fDontKnowTradeDK;
			}
			set
			{
				this.fDontKnowTradeDK = value;
			}
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00022DB6 File Offset: 0x00021DB6
		public FIXDontKnowTradeDKEventArgs(FIXDontKnowTradeDK DontKnowTradeDK)
		{
			this.fDontKnowTradeDK = DontKnowTradeDK;
		}

		// Token: 0x04000307 RID: 775
		private FIXDontKnowTradeDK fDontKnowTradeDK;
	}
}
