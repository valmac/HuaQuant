using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200014D RID: 333
	public class FIXMarketDataRequestEventArgs : EventArgs
	{
		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x00045627 File Offset: 0x00044627
		// (set) Token: 0x06003FAA RID: 16298 RVA: 0x0004562F File Offset: 0x0004462F
		public FIXMarketDataRequest MarketDataRequest
		{
			get
			{
				return this.fMarketDataRequest;
			}
			set
			{
				this.fMarketDataRequest = value;
			}
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00045638 File Offset: 0x00044638
		public FIXMarketDataRequestEventArgs(FIXMarketDataRequest MarketDataRequest)
		{
			this.fMarketDataRequest = MarketDataRequest;
		}

		// Token: 0x04000956 RID: 2390
		private FIXMarketDataRequest fMarketDataRequest;
	}
}
