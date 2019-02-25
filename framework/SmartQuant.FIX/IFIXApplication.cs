using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000FB RID: 251
	public interface IFIXApplication
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06002E8F RID: 11919
		// (remove) Token: 0x06002E90 RID: 11920
		event FIXLogonEventHandler Logon;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06002E91 RID: 11921
		// (remove) Token: 0x06002E92 RID: 11922
		event FIXLogoutEventHandler Logout;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06002E93 RID: 11923
		// (remove) Token: 0x06002E94 RID: 11924
		event FIXMarketDataRequestEventHandler MarketDataRequest;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06002E95 RID: 11925
		// (remove) Token: 0x06002E96 RID: 11926
		event FIXMarketDataSnapshotEventHandler MarketDataSnapshot;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06002E97 RID: 11927
		// (remove) Token: 0x06002E98 RID: 11928
		event FIXMarketDataIncrementalRefreshEventHandler MarketDataIncrementalRefresh;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06002E99 RID: 11929
		// (remove) Token: 0x06002E9A RID: 11930
		event FIXMarketDataRequestRejectEventHandler MarketDataRequestReject;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06002E9B RID: 11931
		// (remove) Token: 0x06002E9C RID: 11932
		event FIXNewOrderSingleEventHandler NewOrderSingle;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06002E9D RID: 11933
		// (remove) Token: 0x06002E9E RID: 11934
		event FIXExecutionReportEventHandler ExecutionReport;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06002E9F RID: 11935
		// (remove) Token: 0x06002EA0 RID: 11936
		event FIXSecurityDefinitionRequestEventHandler SecurityDefinitionRequest;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06002EA1 RID: 11937
		// (remove) Token: 0x06002EA2 RID: 11938
		event FIXRequestForPositionsEventHandler RequestForPositions;

		// Token: 0x06002EA3 RID: 11939
		void Send(FIXLogon logon);

		// Token: 0x06002EA4 RID: 11940
		void Send(FIXLogout logout);

		// Token: 0x06002EA5 RID: 11941
		void Send(FIXMarketDataRequest request);

		// Token: 0x06002EA6 RID: 11942
		void Send(FIXMarketDataSnapshot snapshot);

		// Token: 0x06002EA7 RID: 11943
		void Send(FIXMarketDataIncrementalRefresh refresh);

		// Token: 0x06002EA8 RID: 11944
		void Send(FIXMarketDataRequestReject reject);

		// Token: 0x06002EA9 RID: 11945
		void Send(FIXNewOrderSingle order);

		// Token: 0x06002EAA RID: 11946
		void Send(FIXExecutionReport report);

		// Token: 0x06002EAB RID: 11947
		void Send(FIXOrderCancelRequest cancel);

		// Token: 0x06002EAC RID: 11948
		void Send(FIXOrderCancelReplaceRequest replace);

		// Token: 0x06002EAD RID: 11949
		void Send(FIXSecurityDefinitionRequest request);

		// Token: 0x06002EAE RID: 11950
		void Send(FIXRequestForPositions request);
	}
}
