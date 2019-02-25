using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000D1 RID: 209
	public class OrderCancelRejectEventArgs : EventArgs
	{
		// Token: 0x060029E6 RID: 10726 RVA: 0x0002C9B1 File Offset: 0x0002B9B1
		public OrderCancelRejectEventArgs(OrderCancelReject reject)
		{
			this.reject = reject;
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0002C9C0 File Offset: 0x0002B9C0
		public OrderCancelReject OrderCancelReject
		{
			get
			{
				return this.reject;
			}
		}

		// Token: 0x040003C3 RID: 963
		private OrderCancelReject reject;
	}
}
