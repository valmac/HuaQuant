using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E7 RID: 231
	public class MarketDataRequestRejectEventArgs : EventArgs
	{
		// Token: 0x06002E47 RID: 11847 RVA: 0x0003101F File Offset: 0x0003001F
		public MarketDataRequestRejectEventArgs(MarketDataRequestReject reject)
		{
			this.reject = reject;
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x0003102E File Offset: 0x0003002E
		public MarketDataRequestReject MarketDataRequestReject
		{
			get
			{
				return this.reject;
			}
		}

		// Token: 0x040003E9 RID: 1001
		private MarketDataRequestReject reject;
	}
}
