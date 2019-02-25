using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000189 RID: 393
	public class FIXMarketDataSnapshotEventArgs : EventArgs
	{
		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06004A69 RID: 19049 RVA: 0x00052545 File Offset: 0x00051545
		// (set) Token: 0x06004A6A RID: 19050 RVA: 0x0005254D File Offset: 0x0005154D
		public FIXMarketDataSnapshot MarketDataSnapshotFullRefresh
		{
			get
			{
				return this.fMarketDataSnapshotFullRefresh;
			}
			set
			{
				this.fMarketDataSnapshotFullRefresh = value;
			}
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00052556 File Offset: 0x00051556
		public FIXMarketDataSnapshotEventArgs(FIXMarketDataSnapshot MarketDataSnapshotFullRefresh)
		{
			this.fMarketDataSnapshotFullRefresh = MarketDataSnapshotFullRefresh;
		}

		// Token: 0x04000DB7 RID: 3511
		private FIXMarketDataSnapshot fMarketDataSnapshotFullRefresh;
	}
}
