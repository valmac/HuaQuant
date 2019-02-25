using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000094 RID: 148
	public class FIXOrderMassStatusRequestEventArgs : EventArgs
	{
		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x0001F854 File Offset: 0x0001E854
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0001F85C File Offset: 0x0001E85C
		public FIXOrderMassStatusRequest OrderMassStatusRequest
		{
			get
			{
				return this.fOrderMassStatusRequest;
			}
			set
			{
				this.fOrderMassStatusRequest = value;
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0001F865 File Offset: 0x0001E865
		public FIXOrderMassStatusRequestEventArgs(FIXOrderMassStatusRequest OrderMassStatusRequest)
		{
			this.fOrderMassStatusRequest = OrderMassStatusRequest;
		}

		// Token: 0x040002EB RID: 747
		private FIXOrderMassStatusRequest fOrderMassStatusRequest;
	}
}
