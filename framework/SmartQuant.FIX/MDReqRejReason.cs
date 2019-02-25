using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000BB RID: 187
	public enum MDReqRejReason
	{
		// Token: 0x04000385 RID: 901
		UnknownSymbol,
		// Token: 0x04000386 RID: 902
		DuplicateMDReqID,
		// Token: 0x04000387 RID: 903
		InsufficientBandwidth,
		// Token: 0x04000388 RID: 904
		InsufficientPermissions,
		// Token: 0x04000389 RID: 905
		UnsupportedSubscriptionRequestType,
		// Token: 0x0400038A RID: 906
		UnsupportedMarketDepth,
		// Token: 0x0400038B RID: 907
		UnsupportedMDUpdateType,
		// Token: 0x0400038C RID: 908
		UnsupportedAggregatedBook,
		// Token: 0x0400038D RID: 909
		UnsupportedMDEntryType,
		// Token: 0x0400038E RID: 910
		UnsupportedTradingSessionID,
		// Token: 0x0400038F RID: 911
		UnsupportedScope,
		// Token: 0x04000390 RID: 912
		UnsupportedOpenCloseSettleFlag,
		// Token: 0x04000391 RID: 913
		UnsupportedMDImplicitDelete
	}
}
