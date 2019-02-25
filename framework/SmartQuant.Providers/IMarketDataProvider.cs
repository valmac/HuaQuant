using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000012 RID: 18
	public interface IMarketDataProvider : IProvider
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600004E RID: 78
		// (remove) Token: 0x0600004F RID: 79
		event MarketDataRequestRejectEventHandler MarketDataRequestReject;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000050 RID: 80
		// (remove) Token: 0x06000051 RID: 81
		event MarketDataSnapshotEventHandler MarketDataSnapshot;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000052 RID: 82
		// (remove) Token: 0x06000053 RID: 83
		event MarketDataEventHandler NewMarketData;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000054 RID: 84
		// (remove) Token: 0x06000055 RID: 85
		event QuoteEventHandler NewQuote;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000056 RID: 86
		// (remove) Token: 0x06000057 RID: 87
		event TradeEventHandler NewTrade;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000058 RID: 88
		// (remove) Token: 0x06000059 RID: 89
		event BarEventHandler NewBar;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600005A RID: 90
		// (remove) Token: 0x0600005B RID: 91
		event BarEventHandler NewBarOpen;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600005C RID: 92
		// (remove) Token: 0x0600005D RID: 93
		event BarSliceEventHandler NewBarSlice;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600005E RID: 94
		// (remove) Token: 0x0600005F RID: 95
		event BarEventHandler NewMarketBar;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000060 RID: 96
		// (remove) Token: 0x06000061 RID: 97
		event MarketDepthEventHandler NewMarketDepth;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000062 RID: 98
		// (remove) Token: 0x06000063 RID: 99
		event FundamentalEventHandler NewFundamental;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000064 RID: 100
		// (remove) Token: 0x06000065 RID: 101
		event CorporateActionEventHandler NewCorporateAction;

		// Token: 0x06000066 RID: 102
		void SendMarketDataRequest(FIXMarketDataRequest request);

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000067 RID: 103
		// (set) Token: 0x06000068 RID: 104
		IBarFactory BarFactory { get; set; }
	}
}
