using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000A5 RID: 165
	public class FIXOrderStatusRequestEventArgs : EventArgs
	{
		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00024CA6 File Offset: 0x00023CA6
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x00024CAE File Offset: 0x00023CAE
		public FIXOrderStatusRequest OrderStatusRequest
		{
			get
			{
				return this.fOrderStatusRequest;
			}
			set
			{
				this.fOrderStatusRequest = value;
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00024CB7 File Offset: 0x00023CB7
		public FIXOrderStatusRequestEventArgs(FIXOrderStatusRequest OrderStatusRequest)
		{
			this.fOrderStatusRequest = OrderStatusRequest;
		}

		// Token: 0x04000340 RID: 832
		private FIXOrderStatusRequest fOrderStatusRequest;
	}
}
