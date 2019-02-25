using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200007C RID: 124
	public class FIXOrderCancelReplaceRequestEventArgs : EventArgs
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00019AB9 File Offset: 0x00018AB9
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00019AC1 File Offset: 0x00018AC1
		public FIXOrderCancelReplaceRequest OrderCancelReplaceRequest
		{
			get
			{
				return this.fOrderCancelReplaceRequest;
			}
			set
			{
				this.fOrderCancelReplaceRequest = value;
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00019ACA File Offset: 0x00018ACA
		public FIXOrderCancelReplaceRequestEventArgs(FIXOrderCancelReplaceRequest OrderCancelReplaceRequest)
		{
			this.fOrderCancelReplaceRequest = OrderCancelReplaceRequest;
		}

		// Token: 0x04000299 RID: 665
		private FIXOrderCancelReplaceRequest fOrderCancelReplaceRequest;
	}
}
