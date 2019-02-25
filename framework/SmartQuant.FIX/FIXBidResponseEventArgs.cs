using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000027 RID: 39
	public class FIXBidResponseEventArgs : EventArgs
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0000BDC8 File Offset: 0x0000ADC8
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0000BDD0 File Offset: 0x0000ADD0
		public FIXBidResponse BidResponse
		{
			get
			{
				return this.fBidResponse;
			}
			set
			{
				this.fBidResponse = value;
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0000BDD9 File Offset: 0x0000ADD9
		public FIXBidResponseEventArgs(FIXBidResponse BidResponse)
		{
			this.fBidResponse = BidResponse;
		}

		// Token: 0x0400006D RID: 109
		private FIXBidResponse fBidResponse;
	}
}
