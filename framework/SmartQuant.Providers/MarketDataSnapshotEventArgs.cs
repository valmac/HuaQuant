using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000041 RID: 65
	public class MarketDataSnapshotEventArgs : EventArgs
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00004C1B File Offset: 0x00003C1B
		public MarketDataSnapshotEventArgs(FIXMarketDataSnapshot snapshot)
		{
			this.snapshot = snapshot;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00004C2A File Offset: 0x00003C2A
		public FIXMarketDataSnapshot Snapshot
		{
			get
			{
				return this.snapshot;
			}
		}

		// Token: 0x04000099 RID: 153
		private FIXMarketDataSnapshot snapshot;
	}
}
