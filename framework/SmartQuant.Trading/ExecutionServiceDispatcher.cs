using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using SmartQuant.FIX;
using SmartQuant.Services;

namespace SmartQuant.Trading
{
	// Token: 0x02000069 RID: 105
	internal class ExecutionServiceDispatcher
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00010012 File Offset: 0x0000F012
		public ExecutionServiceDispatcher(MetaStrategyBase metaStrategyBase)
		{
			this.metaStrategyBase = metaStrategyBase;
			this.services = new ListDictionary();
			this.orderServicePairs = new Dictionary<string, OrderServicePair>();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00010037 File Offset: 0x0000F037
		public void Init()
		{
			this.services.Clear();
			this.orderServicePairs.Clear();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001004F File Offset: 0x0000F04F
		public void Add(IExecutionService service)
		{
			if (!this.services.Contains(service))
			{
				this.services.Add(service, null);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001006C File Offset: 0x0000F06C
		public void Online()
		{
			ServiceManager.NewOrderSingle += this.ServiceManager_NewOrderSingle;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001007F File Offset: 0x0000F07F
		public void Offline()
		{
			ServiceManager.NewOrderSingle -= this.ServiceManager_NewOrderSingle;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00010094 File Offset: 0x0000F094
		private void ServiceManager_NewOrderSingle(object sender, NewOrderSingleEventArgs args)
		{
			if (this.services.Contains(args.Service))
			{
				this.orderServicePairs.Add(args.Order.ClOrdID, new OrderServicePair(args.Order, args.Service));
				this.metaStrategyBase.SetNewClientOrder(args);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000100E8 File Offset: 0x0000F0E8
		public void SendExecutionReport(FIXExecutionReport report)
		{
			OrderServicePair orderServicePair = this.orderServicePairs[report.ClOrdID];
			orderServicePair.Service.Send(report);
		}

		// Token: 0x0400015B RID: 347
		private MetaStrategyBase metaStrategyBase;

		// Token: 0x0400015C RID: 348
		private ListDictionary services;

		// Token: 0x0400015D RID: 349
		private Dictionary<string, OrderServicePair> orderServicePairs;
	}
}
