using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000023 RID: 35
	public class FIXMultilegOrderCancelReplaceEventArgs : EventArgs
	{
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00009443 File Offset: 0x00008443
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x0000944B File Offset: 0x0000844B
		public FIXMultilegOrderCancelReplace MultilegOrderCancelReplace
		{
			get
			{
				return this.fMultilegOrderCancelReplace;
			}
			set
			{
				this.fMultilegOrderCancelReplace = value;
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00009454 File Offset: 0x00008454
		public FIXMultilegOrderCancelReplaceEventArgs(FIXMultilegOrderCancelReplace MultilegOrderCancelReplace)
		{
			this.fMultilegOrderCancelReplace = MultilegOrderCancelReplace;
		}

		// Token: 0x04000056 RID: 86
		private FIXMultilegOrderCancelReplace fMultilegOrderCancelReplace;
	}
}
