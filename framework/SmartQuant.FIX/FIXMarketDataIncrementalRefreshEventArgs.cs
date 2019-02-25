using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000AF RID: 175
	public class FIXMarketDataIncrementalRefreshEventArgs : EventArgs
	{
		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x00027B05 File Offset: 0x00026B05
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x00027B0D File Offset: 0x00026B0D
		public FIXMarketDataIncrementalRefresh MarketDataIncrementalRefresh
		{
			get
			{
				return this.fMarketDataIncrementalRefresh;
			}
			set
			{
				this.fMarketDataIncrementalRefresh = value;
			}
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00027B16 File Offset: 0x00026B16
		public FIXMarketDataIncrementalRefreshEventArgs(FIXMarketDataIncrementalRefresh MarketDataIncrementalRefresh)
		{
			this.fMarketDataIncrementalRefresh = MarketDataIncrementalRefresh;
		}

		// Token: 0x0400035C RID: 860
		private FIXMarketDataIncrementalRefresh fMarketDataIncrementalRefresh;
	}
}
