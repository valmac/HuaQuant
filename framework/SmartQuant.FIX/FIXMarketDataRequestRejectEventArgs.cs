using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000050 RID: 80
	public class FIXMarketDataRequestRejectEventArgs : EventArgs
	{
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0001272C File Offset: 0x0001172C
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00012734 File Offset: 0x00011734
		public FIXMarketDataRequestReject MarketDataRequestReject
		{
			get
			{
				return this.fMarketDataRequestReject;
			}
			set
			{
				this.fMarketDataRequestReject = value;
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0001273D File Offset: 0x0001173D
		public FIXMarketDataRequestRejectEventArgs(FIXMarketDataRequestReject MarketDataRequestReject)
		{
			this.fMarketDataRequestReject = MarketDataRequestReject;
		}

		// Token: 0x04000188 RID: 392
		private FIXMarketDataRequestReject fMarketDataRequestReject;
	}
}
