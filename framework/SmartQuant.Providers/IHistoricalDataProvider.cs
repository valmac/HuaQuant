using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000053 RID: 83
	public interface IHistoricalDataProvider : IProvider
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001ED RID: 493
		HistoricalDataType DataType { get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001EE RID: 494
		HistoricalDataRange DataRange { get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001EF RID: 495
		int[] BarSizes { get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001F0 RID: 496
		int MaxConcurrentRequests { get; }

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060001F1 RID: 497
		// (remove) Token: 0x060001F2 RID: 498
		event HistoricalTradeEventHandler NewHistoricalTrade;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x060001F3 RID: 499
		// (remove) Token: 0x060001F4 RID: 500
		event HistoricalQuoteEventHandler NewHistoricalQuote;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x060001F5 RID: 501
		// (remove) Token: 0x060001F6 RID: 502
		event HistoricalBarEventHandler NewHistoricalBar;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060001F7 RID: 503
		// (remove) Token: 0x060001F8 RID: 504
		event HistoricalMarketDepthEventHandler NewHistoricalMarketDepth;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060001F9 RID: 505
		// (remove) Token: 0x060001FA RID: 506
		event HistoricalDataEventHandler HistoricalDataRequestCompleted;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060001FB RID: 507
		// (remove) Token: 0x060001FC RID: 508
		event HistoricalDataEventHandler HistoricalDataRequestCancelled;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060001FD RID: 509
		// (remove) Token: 0x060001FE RID: 510
		event HistoricalDataErrorEventHandler HistoricalDataRequestError;

		// Token: 0x060001FF RID: 511
		void SendHistoricalDataRequest(HistoricalDataRequest request);

		// Token: 0x06000200 RID: 512
		void CancelHistoricalDataRequest(string requestId);
	}
}
