using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000013 RID: 19
	public interface IExecutionProvider : IProvider
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000069 RID: 105
		// (remove) Token: 0x0600006A RID: 106
		event ExecutionReportEventHandler ExecutionReport;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600006B RID: 107
		// (remove) Token: 0x0600006C RID: 108
		event OrderCancelRejectEventHandler OrderCancelReject;

		// Token: 0x0600006D RID: 109
		void SendNewOrderSingle(NewOrderSingle order);

		// Token: 0x0600006E RID: 110
		void SendOrderCancelRequest(FIXOrderCancelRequest request);

		// Token: 0x0600006F RID: 111
		void SendOrderCancelReplaceRequest(FIXOrderCancelReplaceRequest request);

		// Token: 0x06000070 RID: 112
		void SendOrderStatusRequest(FIXOrderStatusRequest request);

		// Token: 0x06000071 RID: 113
		BrokerInfo GetBrokerInfo();
	}
}
