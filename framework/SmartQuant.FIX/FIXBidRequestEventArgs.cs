using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000B3 RID: 179
	public class FIXBidRequestEventArgs : EventArgs
	{
		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000280AA File Offset: 0x000270AA
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x000280B2 File Offset: 0x000270B2
		public FIXBidRequest BidRequest
		{
			get
			{
				return this.fBidRequest;
			}
			set
			{
				this.fBidRequest = value;
			}
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000280BB File Offset: 0x000270BB
		public FIXBidRequestEventArgs(FIXBidRequest BidRequest)
		{
			this.fBidRequest = BidRequest;
		}

		// Token: 0x04000361 RID: 865
		private FIXBidRequest fBidRequest;
	}
}
