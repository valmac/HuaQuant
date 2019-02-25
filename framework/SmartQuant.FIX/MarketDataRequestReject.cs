using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000164 RID: 356
	public class MarketDataRequestReject : FIXMarketDataRequestReject
	{
		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x0004988F File Offset: 0x0004888F
		// (set) Token: 0x06004365 RID: 17253 RVA: 0x0004989C File Offset: 0x0004889C
		public new MDReqRejReason MDReqRejReason
		{
			get
			{
				return FIXMDReqRejReason.FromFIX(base.MDReqRejReason);
			}
			set
			{
				base.MDReqRejReason = FIXMDReqRejReason.ToFIX(value);
			}
		}
	}
}
