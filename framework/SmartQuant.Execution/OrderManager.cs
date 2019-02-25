using System;
using System.Collections;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Services;

namespace SmartQuant.Execution
{
	// Token: 0x0200000C RID: 12
	public class OrderManager
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000095 RID: 149 RVA: 0x000030C5 File Offset: 0x000020C5
		// (remove) Token: 0x06000096 RID: 150 RVA: 0x000030DC File Offset: 0x000020DC
		public static event ExecutionReportEventHandler ExecutionReport;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000097 RID: 151 RVA: 0x000030F3 File Offset: 0x000020F3
		// (remove) Token: 0x06000098 RID: 152 RVA: 0x0000310A File Offset: 0x0000210A
		public static event OrderCancelRejectEventHandler OrderCancelReject;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000099 RID: 153 RVA: 0x00003121 File Offset: 0x00002121
		// (remove) Token: 0x0600009A RID: 154 RVA: 0x00003138 File Offset: 0x00002138
		public static event OrderEventHandler OrderStatusChanged;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600009B RID: 155 RVA: 0x0000314F File Offset: 0x0000214F
		// (remove) Token: 0x0600009C RID: 156 RVA: 0x00003166 File Offset: 0x00002166
		public static event ProviderErrorEventHandler Error;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600009D RID: 157 RVA: 0x0000317D File Offset: 0x0000217D
		// (remove) Token: 0x0600009E RID: 158 RVA: 0x00003194 File Offset: 0x00002194
		public static event OrderEventHandler NewOrder;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600009F RID: 159 RVA: 0x000031AB File Offset: 0x000021AB
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x000031C2 File Offset: 0x000021C2
		public static event OrderEventHandler OrderDone;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000A1 RID: 161 RVA: 0x000031D9 File Offset: 0x000021D9
		// (remove) Token: 0x060000A2 RID: 162 RVA: 0x000031F0 File Offset: 0x000021F0
		public static event EventHandler OrderListUpdated;

		// Token: 0x060000A3 RID: 163 RVA: 0x00003207 File Offset: 0x00002207
		static OrderManager()
		{
			OrderManager.Init();
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003242 File Offset: 0x00002242
		public static IOrderServer Server
		{
			get
			{
				return OrderManager.fServer;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003249 File Offset: 0x00002249
		public static Hashtable OCA
		{
			get
			{
				return OrderManager.fOCA;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003250 File Offset: 0x00002250
		public static void Reset()
		{
			OrderManager.fOrders.Clear();
			OrderManager.fOCA.Clear();
			OrderManager.sellSide.Reset();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003270 File Offset: 0x00002270
		public static void Init()
		{
			if (!OrderManager.fIsInitialized)
			{
				ProviderManager.ExecutionReport += OrderManager.ProviderManager_ExecutionReport;
				ProviderManager.OrderCancelReject += OrderManager.ProviderManager_OrderCancelReject;
				ProviderManager.Error += OrderManager.ProviderManager_Error;
				OrderManager.fServer.Open();
				foreach (object obj in OrderManager.fServer.Load())
				{
					IOrder order = (IOrder)obj;
					if (order.Instrument != null && order.Provider != null && order.Portfolio != null)
					{
						OrderManager.fOrders.Add(order as SingleOrder);
					}
				}
				OrderManager.fIsInitialized = true;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000333C File Offset: 0x0000233C
		public static OrderListTable Orders
		{
			get
			{
				return OrderManager.fOrders;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003343 File Offset: 0x00002343
		public static OrderManager.SellSideService SellSide
		{
			get
			{
				return OrderManager.sellSide;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000334C File Offset: 0x0000234C
		internal static string GetNextClOrdId()
		{
			string result = Clock.Now.ToString("yyMMddHHmmss ") + OrderManager.fClOrdID;
			OrderManager.fClOrdID++;
			return result;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003388 File Offset: 0x00002388
		internal static void Send(SingleOrder order)
		{
			if (order.Provider == null)
			{
				throw new ApplicationException("Can not send single order. Execution provider is not set for this order.");
			}
			if (!order.Provider.IsConnected)
			{
				throw new ApplicationException("Can not send single order. Execution provider is not connected. (" + order.Provider.Name + ")");
			}
			if (order.Persistent)
			{
				OrderManager.fServer.AddOrder(order);
			}
			OrderManager.fOrders.Add(order);
			OrderManager.EmitNewOrder(order);
			if (order.OCAGroup != "" && order.Provider.Id != 4 && OrderManager.fOCA.Contains(order.OCAGroup))
			{
				OrderManager.ProviderManager_ExecutionReport(null, new ExecutionReportEventArgs(new ExecutionReport
				{
					TransactTime = Clock.Now,
					ClOrdID = order.ClOrdID,
					OrigClOrdID = order.ClOrdID,
					ExecType = ExecType.Rejected,
					OrdStatus = OrdStatus.Rejected,
					Symbol = order.Symbol,
					Side = order.Side,
					OrdType = order.OrdType,
					Currency = order.Currency,
					Text = "OCA group " + order.OCAGroup + " was already filled"
				}));
				return;
			}
			order.Provider.SendNewOrderSingle(order);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000034D4 File Offset: 0x000024D4
		internal static void Cancel(SingleOrder order)
		{
			if (order.Provider != null)
			{
				FIXOrderCancelRequest fixorderCancelRequest = new FIXOrderCancelRequest();
				fixorderCancelRequest.OrigClOrdID = order.ClOrdID;
				fixorderCancelRequest.ClOrdID = OrderManager.GetNextClOrdId();
				fixorderCancelRequest.OrderID = order.OrderID;
				fixorderCancelRequest.Side = (char)order.Side;
				fixorderCancelRequest.TransactTime = Clock.Now;
				fixorderCancelRequest.Symbol = order.Symbol;
				fixorderCancelRequest.SecurityType = order.SecurityType;
				fixorderCancelRequest.SecurityID = order.SecurityID;
				fixorderCancelRequest.SecurityExchange = order.SecurityExchange;
				fixorderCancelRequest.Account = order.Account;
				fixorderCancelRequest.OrderQty = order.OrderQty;
				order.Provider.SendOrderCancelRequest(fixorderCancelRequest);
				return;
			}
			throw new ApplicationException("Can not cancel single order. Execution provider is not set for this order.");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000358C File Offset: 0x0000258C
		internal static void Replace(SingleOrder order)
		{
			if (order.Provider != null)
			{
				FIXOrderCancelReplaceRequest fixorderCancelReplaceRequest = new FIXOrderCancelReplaceRequest();
				fixorderCancelReplaceRequest.ClOrdID = OrderManager.GetNextClOrdId();
				fixorderCancelReplaceRequest.OrigClOrdID = order.ClOrdID;
				fixorderCancelReplaceRequest.OrderID = order.OrderID;
				fixorderCancelReplaceRequest.Side = (char)order.Side;
				if (order.ReplaceOrder.ContainsField(40))
				{
					fixorderCancelReplaceRequest.OrdType = (char)order.ReplaceOrder.OrdType;
				}
				else
				{
					fixorderCancelReplaceRequest.OrdType = (char)order.OrdType;
				}
				if (order.ReplaceOrder.ContainsField(59))
				{
					fixorderCancelReplaceRequest.TimeInForce = (char)order.ReplaceOrder.TimeInForce;
				}
				else
				{
					fixorderCancelReplaceRequest.TimeInForce = (char)order.TimeInForce;
				}
				if (order.ReplaceOrder.ContainsField(44))
				{
					fixorderCancelReplaceRequest.Price = order.ReplaceOrder.Price;
				}
				else
				{
					fixorderCancelReplaceRequest.Price = order.Price;
				}
				if (order.ReplaceOrder.ContainsField(99))
				{
					fixorderCancelReplaceRequest.StopPx = order.ReplaceOrder.StopPx;
				}
				else
				{
					fixorderCancelReplaceRequest.StopPx = order.StopPx;
				}
				if (order.ReplaceOrder.ContainsField(38))
				{
					fixorderCancelReplaceRequest.OrderQty = order.ReplaceOrder.OrderQty;
				}
				else
				{
					fixorderCancelReplaceRequest.OrderQty = order.OrderQty;
				}
				fixorderCancelReplaceRequest.TransactTime = Clock.Now;
				fixorderCancelReplaceRequest.Account = order.Account;
				fixorderCancelReplaceRequest.HandlInst = order.HandlInst;
				fixorderCancelReplaceRequest.Symbol = order.Symbol;
				fixorderCancelReplaceRequest.SecurityType = order.SecurityType;
				fixorderCancelReplaceRequest.SecurityExchange = order.SecurityExchange;
				fixorderCancelReplaceRequest.SecurityID = order.SecurityID;
				order.Provider.SendOrderCancelReplaceRequest(fixorderCancelReplaceRequest);
				return;
			}
			throw new ApplicationException("Cannot replace single order. Execution provider is not set for this order.");
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000372C File Offset: 0x0000272C
		public static void RemoveOrders(int tag, object value)
		{
			int count = OrderManager.fOrders.Count;
			int i = 0;
			while (i < OrderManager.fOrders.Count)
			{
				SingleOrder singleOrder = OrderManager.fOrders.All[i] as SingleOrder;
				object value2 = singleOrder.GetValue(tag);
				if (value2 != null && value2.ToString() == value.ToString())
				{
					if (singleOrder.OrdStatus != OrdStatus.Cancelled && singleOrder.OrdStatus != OrdStatus.PendingCancel && singleOrder.OrdStatus != OrdStatus.Filled)
					{
						singleOrder.Cancel();
					}
					OrderManager.fOrders.Remove(singleOrder);
					if (singleOrder.Persistent)
					{
						OrderManager.fServer.Remove(singleOrder);
					}
				}
				else
				{
					i++;
				}
			}
			if (count != OrderManager.fOrders.Count && OrderManager.OrderListUpdated != null)
			{
				OrderManager.OrderListUpdated(typeof(OrderManager), EventArgs.Empty);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003800 File Offset: 0x00002800
		public static OrderList GetOCAGroup(string name)
		{
			OrderList orderList = new OrderList();
			if (name != "")
			{
				foreach (object obj in OrderManager.Orders.All)
				{
					SingleOrder singleOrder = (SingleOrder)obj;
					if (!singleOrder.IsDone && singleOrder.OCAGroup == name)
					{
						orderList.Add(singleOrder);
					}
				}
			}
			return orderList;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003888 File Offset: 0x00002888
		private static void ProviderManager_ExecutionReport(object sender, ExecutionReportEventArgs args)
		{
			ExecutionReport executionReport = args.ExecutionReport;
			SingleOrder singleOrder;
			if (executionReport.ExecType == ExecType.PendingCancel || executionReport.ExecType == ExecType.Cancelled || executionReport.ExecType == ExecType.PendingReplace || executionReport.ExecType == ExecType.Replace)
			{
				singleOrder = (OrderManager.fOrders.All[executionReport.OrigClOrdID] as SingleOrder);
				if (executionReport.ExecType == ExecType.Replace)
				{
					OrderManager.fOrders.Remove(singleOrder);
					singleOrder.ClOrdID = executionReport.ClOrdID;
					singleOrder.OrdType = executionReport.OrdType;
					singleOrder.Price = executionReport.Price;
					singleOrder.StopPx = executionReport.StopPx;
					singleOrder.OrderQty = executionReport.OrderQty;
					singleOrder.TimeInForce = executionReport.TimeInForce;
					OrderManager.fOrders.Add(singleOrder);
				}
			}
			else
			{
				singleOrder = (OrderManager.fOrders.All[executionReport.ClOrdID] as SingleOrder);
			}
			if (singleOrder == null)
			{
				throw new ApplicationException(string.Concat(new string[]
				{
					"Unknown order - ExecutionReport ExecType = ",
					executionReport.ExecType.ToString(),
					" ClOrdId = ",
					executionReport.ClOrdID,
					" OrigClOrdId = ",
					executionReport.OrigClOrdID
				}));
			}
			if (singleOrder.Provider == null)
			{
				throw new ApplicationException("Order provider is not set");
			}
			OrdStatus ordStatus = singleOrder.OrdStatus;
			singleOrder.Add(executionReport);
			if (singleOrder.Persistent)
			{
				OrderManager.fServer.AddReport(singleOrder, executionReport);
			}
			if (OrderManager.ExecutionReport != null)
			{
				OrderManager.ExecutionReport(sender, args);
			}
			if (ordStatus != singleOrder.OrdStatus)
			{
				OrderManager.fOrders.Update(singleOrder);
				singleOrder.EmitStatusChanged();
				OrderManager.EmitOrderStatusChanged(singleOrder);
				if (singleOrder.OrdStatus == OrdStatus.Filled || singleOrder.OrdStatus == OrdStatus.Cancelled || singleOrder.OrdStatus == OrdStatus.Rejected)
				{
					if (singleOrder.CumQty > 0.0 && singleOrder.Portfolio != null)
					{
						Transaction transaction = new Transaction();
						transaction.DateTime = executionReport.TransactTime;
						transaction.ClOrdID = singleOrder.ClOrdID;
						transaction.Instrument = singleOrder.Instrument;
						transaction.Side = singleOrder.Side;
						transaction.Price = singleOrder.AvgPx;
						transaction.Qty = singleOrder.CumQty;
						transaction.Strategy = singleOrder.Strategy;
						transaction.Text = singleOrder.Text;
						Currency currency = CurrencyManager.Currencies[singleOrder.Currency];
						if (currency == null)
						{
							currency = CurrencyManager.Currencies[singleOrder.Instrument.Currency];
						}
						if (currency == null)
						{
							currency = CurrencyManager.DefaultCurrency;
						}
						transaction.Currency = currency;
						if (executionReport.ContainsField(13))
						{
							transaction.TransactionCost.Set(executionReport.CommType, executionReport.Commission);
						}
						singleOrder.Portfolio.Add(transaction);
					}
					OrderManager.EmitOrderDone(singleOrder);
				}
			}
			if (singleOrder.OCAGroup != "" && singleOrder.Provider.Id != 4 && (singleOrder.OrdStatus == OrdStatus.Filled || singleOrder.OrdStatus == OrdStatus.Cancelled) && !OrderManager.fOCA.Contains(singleOrder.OCAGroup))
			{
				OrderManager.fOCA.Add(singleOrder.OCAGroup, singleOrder.OCAGroup);
				foreach (object obj in OrderManager.GetOCAGroup(singleOrder.OCAGroup))
				{
					SingleOrder singleOrder2 = (SingleOrder)obj;
					if (singleOrder2 != singleOrder)
					{
						singleOrder2.Cancel();
					}
				}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003C00 File Offset: 0x00002C00
		private static void ProviderManager_OrderCancelReject(object sender, OrderCancelRejectEventArgs args)
		{
			SingleOrder singleOrder = OrderManager.fOrders.All[args.OrderCancelReject.OrigClOrdID] as SingleOrder;
			OrdStatus ordStatus = singleOrder.OrdStatus;
			singleOrder.Add(args.OrderCancelReject);
			if (OrderManager.OrderCancelReject != null)
			{
				OrderManager.OrderCancelReject(sender, args);
			}
			if (ordStatus != singleOrder.OrdStatus)
			{
				OrderManager.fOrders.Update(singleOrder);
				singleOrder.EmitStatusChanged();
				OrderManager.EmitOrderStatusChanged(singleOrder);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003C73 File Offset: 0x00002C73
		private static void ProviderManager_Error(ProviderErrorEventArgs args)
		{
			if (OrderManager.Error != null)
			{
				OrderManager.Error(args);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003C87 File Offset: 0x00002C87
		private static void EmitNewOrder(SingleOrder order)
		{
			if (OrderManager.NewOrder != null)
			{
				OrderManager.NewOrder(new OrderEventArgs(order));
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003CA0 File Offset: 0x00002CA0
		private static void EmitOrderStatusChanged(SingleOrder order)
		{
			if (OrderManager.OrderStatusChanged != null)
			{
				OrderManager.OrderStatusChanged(new OrderEventArgs(order));
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003CB9 File Offset: 0x00002CB9
		private static void EmitOrderDone(SingleOrder order)
		{
			if (OrderManager.OrderDone != null)
			{
				OrderManager.OrderDone(new OrderEventArgs(order));
			}
		}

		// Token: 0x04000017 RID: 23
		private static bool fIsInitialized = false;

		// Token: 0x04000018 RID: 24
		private static int fClOrdID = 0;

		// Token: 0x04000019 RID: 25
		private static OrderListTable fOrders = new OrderListTable();

		// Token: 0x0400001A RID: 26
		private static IOrderServer fServer = new OrderOleDbServer();

		// Token: 0x0400001B RID: 27
		private static Hashtable fOCA = new Hashtable();

		// Token: 0x0400001C RID: 28
		private static OrderManager.SellSideService sellSide = new OrderManager.SellSideService();

		// Token: 0x0200000D RID: 13
		public class SellSideService
		{
			// Token: 0x1400000D RID: 13
			// (add) Token: 0x060000B7 RID: 183 RVA: 0x00003CDA File Offset: 0x00002CDA
			// (remove) Token: 0x060000B8 RID: 184 RVA: 0x00003CF3 File Offset: 0x00002CF3
			public event OrderEventHandler NewOrder;

			// Token: 0x1400000E RID: 14
			// (add) Token: 0x060000B9 RID: 185 RVA: 0x00003D0C File Offset: 0x00002D0C
			// (remove) Token: 0x060000BA RID: 186 RVA: 0x00003D25 File Offset: 0x00002D25
			public event ExecutionReportEventHandler ExecutionReport;

			// Token: 0x1400000F RID: 15
			// (add) Token: 0x060000BB RID: 187 RVA: 0x00003D3E File Offset: 0x00002D3E
			// (remove) Token: 0x060000BC RID: 188 RVA: 0x00003D57 File Offset: 0x00002D57
			public event EventHandler OrderListUpdated;

			// Token: 0x060000BD RID: 189 RVA: 0x00003D70 File Offset: 0x00002D70
			internal SellSideService()
			{
				this.orders = new SellSideOrderList();
				this.nextOrderID = 1;
				ServiceManager.NewOrderSingle += this.ServiceManager_NewOrderSingle;
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00003D9C File Offset: 0x00002D9C
			public string GetNextOrderID()
			{
				return string.Format("{0:yyyyMMddHHmmss} {1}", DateTime.Now, this.nextOrderID++);
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00003DD3 File Offset: 0x00002DD3
			public SellSideOrderList Orders
			{
				get
				{
					return this.orders;
				}
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00003DDC File Offset: 0x00002DDC
			public void SendExecutionReport(IExecutionService service, ExecutionReport report)
			{
				SingleOrder singleOrder = this.orders[report.OrderID];
				singleOrder.Add(report);
				service.Send(report);
				this.EmitExecutionReport(report);
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00003E10 File Offset: 0x00002E10
			public void RemoveOrders(int tag, object value)
			{
				int count = this.orders.Count;
				for (int i = 0; i < this.orders.Count; i++)
				{
					SingleOrder singleOrder = this.orders[i];
					if (singleOrder.ContainsField(tag))
					{
						object value2 = singleOrder.GetValue(tag);
						if (value2 != null && value2.ToString() == value.ToString())
						{
							this.orders.RemoveAt(i);
							continue;
						}
					}
				}
				if (count > this.orders.Count)
				{
					this.EmitOrderListUpdated();
				}
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00003E95 File Offset: 0x00002E95
			internal void Reset()
			{
				this.orders.Clear();
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00003EA4 File Offset: 0x00002EA4
			private void ServiceManager_NewOrderSingle(object sender, NewOrderSingleEventArgs args)
			{
				SingleOrder singleOrder = args.Order as SingleOrder;
				if (singleOrder.OrderID == string.Empty)
				{
					singleOrder.OrderID = this.GetNextOrderID();
				}
				this.orders.Add(singleOrder);
				this.EmitNewOrder(singleOrder);
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00003EEE File Offset: 0x00002EEE
			private void EmitNewOrder(SingleOrder order)
			{
				if (this.NewOrder != null)
				{
					this.NewOrder(new OrderEventArgs(order));
				}
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x00003F09 File Offset: 0x00002F09
			private void EmitExecutionReport(ExecutionReport report)
			{
				if (this.ExecutionReport != null)
				{
					this.ExecutionReport(this, new ExecutionReportEventArgs(report));
				}
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00003F25 File Offset: 0x00002F25
			private void EmitOrderListUpdated()
			{
				if (this.OrderListUpdated != null)
				{
					this.OrderListUpdated(typeof(OrderManager.SellSideService), EventArgs.Empty);
				}
			}

			// Token: 0x04000024 RID: 36
			private SellSideOrderList orders;

			// Token: 0x04000025 RID: 37
			private int nextOrderID;
		}
	}
}
