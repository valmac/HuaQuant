using System;
using SmartQuant.FIX;

namespace SmartQuant.Services
{
	// Token: 0x0200001A RID: 26
	public interface IExecutionService : IMarketService, IService
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000082 RID: 130
		// (remove) Token: 0x06000083 RID: 131
		event FIXNewOrderSingleEventHandler NewOrderSingle;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000084 RID: 132
		// (remove) Token: 0x06000085 RID: 133
		event FIXOrderCancelRequestEventHandler OrderCancelRequest;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000086 RID: 134
		// (remove) Token: 0x06000087 RID: 135
		event FIXOrderCancelReplaceRequestEventHandler OrderCancelReplaceRequest;

		// Token: 0x06000088 RID: 136
		void Send(FIXExecutionReport message);

		// Token: 0x06000089 RID: 137
		void Send(FIXOrderCancelReject message);
	}
}
