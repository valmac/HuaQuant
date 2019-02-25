using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000FE RID: 254
	public class FIXPositionQtyEventArgs : EventArgs
	{
		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x0003169D File Offset: 0x0003069D
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x000316A5 File Offset: 0x000306A5
		public FIXPositionQty PositionQty
		{
			get
			{
				return this.fPositionQty;
			}
			set
			{
				this.fPositionQty = value;
			}
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000316AE File Offset: 0x000306AE
		public FIXPositionQtyEventArgs(FIXPositionQty PositionQty)
		{
			this.fPositionQty = PositionQty;
		}

		// Token: 0x0400041C RID: 1052
		private FIXPositionQty fPositionQty;
	}
}
