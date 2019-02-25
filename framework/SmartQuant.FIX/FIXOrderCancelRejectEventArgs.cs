using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000C3 RID: 195
	public class FIXOrderCancelRejectEventArgs : EventArgs
	{
		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x00029655 File Offset: 0x00028655
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x0002965D File Offset: 0x0002865D
		public FIXOrderCancelReject OrderCancelReject
		{
			get
			{
				return this.fOrderCancelReject;
			}
			set
			{
				this.fOrderCancelReject = value;
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00029666 File Offset: 0x00028666
		public FIXOrderCancelRejectEventArgs(FIXOrderCancelReject OrderCancelReject)
		{
			this.fOrderCancelReject = OrderCancelReject;
		}

		// Token: 0x040003A0 RID: 928
		private FIXOrderCancelReject fOrderCancelReject;
	}
}
