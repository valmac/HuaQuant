using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000181 RID: 385
	public class FIXOrderMassCancelRequestEventArgs : EventArgs
	{
		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x0004F144 File Offset: 0x0004E144
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x0004F14C File Offset: 0x0004E14C
		public FIXOrderMassCancelRequest OrderMassCancelRequest
		{
			get
			{
				return this.fOrderMassCancelRequest;
			}
			set
			{
				this.fOrderMassCancelRequest = value;
			}
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x0004F155 File Offset: 0x0004E155
		public FIXOrderMassCancelRequestEventArgs(FIXOrderMassCancelRequest OrderMassCancelRequest)
		{
			this.fOrderMassCancelRequest = OrderMassCancelRequest;
		}

		// Token: 0x04000D9D RID: 3485
		private FIXOrderMassCancelRequest fOrderMassCancelRequest;
	}
}
