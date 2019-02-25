using System;
using System.Collections.Generic;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Providers;

namespace SmartQuant.Trading
{
	// Token: 0x02000007 RID: 7
	internal class OrderProcessor
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00004D3E File Offset: 0x00003D3E
		public OrderProcessor(MetaStrategyBase metaStrategyBase)
		{
			this.metaStrategyBase = metaStrategyBase;
			this.providers = new List<IExecutionProvider>();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004D58 File Offset: 0x00003D58
		public void Init()
		{
			this.providers.Clear();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004D65 File Offset: 0x00003D65
		public void Add(IExecutionProvider provider)
		{
			if (!this.providers.Contains(provider))
			{
				this.providers.Add(provider);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004D84 File Offset: 0x00003D84
		public void Online()
		{
			OrderManager.NewOrder += this.OrderManager_NewOrder;
			OrderManager.ExecutionReport += this.OrderManager_ExecutionReport;
			OrderManager.OrderStatusChanged += this.OrderManager_OrderStatusChanged;
			OrderManager.OrderDone += this.OrderManager_OrderDone;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004DD8 File Offset: 0x00003DD8
		public void Offline()
		{
			OrderManager.NewOrder -= this.OrderManager_NewOrder;
			OrderManager.ExecutionReport -= this.OrderManager_ExecutionReport;
			OrderManager.OrderStatusChanged -= this.OrderManager_OrderStatusChanged;
			OrderManager.OrderDone -= this.OrderManager_OrderDone;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004E29 File Offset: 0x00003E29
		private void OrderManager_NewOrder(OrderEventArgs args)
		{
			this.metaStrategyBase.SetNewOrder(args);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004E37 File Offset: 0x00003E37
		private void OrderManager_ExecutionReport(object sender, ExecutionReportEventArgs args)
		{
			this.metaStrategyBase.SetExecutionReport(args);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004E45 File Offset: 0x00003E45
		private void OrderManager_OrderStatusChanged(OrderEventArgs args)
		{
			this.metaStrategyBase.SetOrderStatusChanged(args);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004E53 File Offset: 0x00003E53
		private void OrderManager_OrderDone(OrderEventArgs args)
		{
			this.metaStrategyBase.SetOrderDone(args);
		}

		// Token: 0x04000040 RID: 64
		private MetaStrategyBase metaStrategyBase;

		// Token: 0x04000041 RID: 65
		private List<IExecutionProvider> providers;
	}
}
