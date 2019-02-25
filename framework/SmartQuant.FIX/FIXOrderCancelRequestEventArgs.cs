using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000183 RID: 387
	public class FIXOrderCancelRequestEventArgs : EventArgs
	{
		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x000502C2 File Offset: 0x0004F2C2
		// (set) Token: 0x06004854 RID: 18516 RVA: 0x000502CA File Offset: 0x0004F2CA
		public FIXOrderCancelRequest OrderCancelRequest
		{
			get
			{
				return this.fOrderCancelRequest;
			}
			set
			{
				this.fOrderCancelRequest = value;
			}
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x000502D3 File Offset: 0x0004F2D3
		public FIXOrderCancelRequestEventArgs(FIXOrderCancelRequest OrderCancelRequest)
		{
			this.fOrderCancelRequest = OrderCancelRequest;
		}

		// Token: 0x04000DA4 RID: 3492
		private FIXOrderCancelRequest fOrderCancelRequest;
	}
}
