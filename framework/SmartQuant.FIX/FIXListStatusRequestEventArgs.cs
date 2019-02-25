using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200016F RID: 367
	public class FIXListStatusRequestEventArgs : EventArgs
	{
		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x0004C5D3 File Offset: 0x0004B5D3
		// (set) Token: 0x060044B6 RID: 17590 RVA: 0x0004C5DB File Offset: 0x0004B5DB
		public FIXListStatusRequest ListStatusRequest
		{
			get
			{
				return this.fListStatusRequest;
			}
			set
			{
				this.fListStatusRequest = value;
			}
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x0004C5E4 File Offset: 0x0004B5E4
		public FIXListStatusRequestEventArgs(FIXListStatusRequest ListStatusRequest)
		{
			this.fListStatusRequest = ListStatusRequest;
		}

		// Token: 0x04000D6F RID: 3439
		private FIXListStatusRequest fListStatusRequest;
	}
}
