using System;
using System.Collections.Generic;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000057 RID: 87
	[StrategyComponent("{E70A6417-E7FA-4ec1-BC16-B03DE53C6E85}", ComponentType.ATSCrossComponent, Name = "Default_ATSCrossComponent", Description = "")]
	public class ATSCrossComponent : ATSStrategyMultiComponent
	{
		// Token: 0x06000356 RID: 854 RVA: 0x0000D0F9 File Offset: 0x0000C0F9
		public ATSCrossComponent()
		{
			this.clientOrders = new Dictionary<SingleOrder, List<ExecutionReport>>();
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000D10C File Offset: 0x0000C10C
		public virtual void OnStopStatusChanged(ATSStop stop)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000D10E File Offset: 0x0000C10E
		public virtual void OnStopCanceled(ATSStop stop)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000D110 File Offset: 0x0000C110
		public virtual void OnStopExecuted(ATSStop stop)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000D112 File Offset: 0x0000C112
		public sealed override void OnNewOrder(SingleOrder order)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000D114 File Offset: 0x0000C114
		public ATSStop SetStop(Position position, double level, StopType type, StopMode mode)
		{
			ATSStop atsstop = new ATSStop(position, level, type, mode);
			base.Strategy.AddStop(atsstop);
			return atsstop;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000D13C File Offset: 0x0000C13C
		public ATSStop SetStop(Position position, DateTime dateTime)
		{
			ATSStop atsstop = new ATSStop(position, dateTime);
			base.Strategy.AddStop(atsstop);
			return atsstop;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000D160 File Offset: 0x0000C160
		public MarketOrder MarketOrder(Instrument instrument, Side side, double qty)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
			base.Strategy.RegisterOrder(marketOrder);
			return marketOrder;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000D184 File Offset: 0x0000C184
		public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
			base.Strategy.RegisterOrder(limitOrder);
			return limitOrder;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000D1AC File Offset: 0x0000C1AC
		public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
			base.Strategy.RegisterOrder(stopOrder);
			return stopOrder;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000D1D4 File Offset: 0x0000C1D4
		public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
			base.Strategy.RegisterOrder(stopLimitOrder);
			return stopLimitOrder;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000D1FC File Offset: 0x0000C1FC
		public TrailingStopOrder TrailingStopOrder(Instrument instrument, Side side, double qty, double delta)
		{
			TrailingStopOrder trailingStopOrder = new TrailingStopOrder(instrument, side, qty, delta);
			base.Strategy.RegisterOrder(trailingStopOrder);
			return trailingStopOrder;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000D221 File Offset: 0x0000C221
		internal void SetClientOrder(SingleOrder order)
		{
			this.clientOrders.Add(order, new List<ExecutionReport>());
			this.OnClientOrder(order);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000D23B File Offset: 0x0000C23B
		public virtual void OnClientOrder(SingleOrder order)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000D240 File Offset: 0x0000C240
		public void AcceptClientOrder(SingleOrder order)
		{
			ExecutionReport executionReport = this.CreateExecutionReport(order);
			executionReport.AvgPx = 0.0;
			executionReport.CumQty = 0.0;
			executionReport.LeavesQty = order.OrderQty;
			executionReport.ExecType = ExecType.New;
			executionReport.OrdStatus = OrdStatus.New;
			base.Strategy.SendExecutionReport(executionReport);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000D29C File Offset: 0x0000C29C
		public void CancelClientOrder(SingleOrder order)
		{
			ExecutionReport executionReport = this.CreateExecutionReport(order);
			executionReport.OrigClOrdID = order.ClOrdID;
			executionReport.AvgPx = order.AvgPx;
			executionReport.CumQty = order.CumQty;
			executionReport.LeavesQty = order.LeavesQty;
			executionReport.ExecType = ExecType.Cancelled;
			executionReport.OrdStatus = OrdStatus.Cancelled;
			base.Strategy.SendExecutionReport(executionReport);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000D2FC File Offset: 0x0000C2FC
		public void RejectClientOrder(SingleOrder order, string text)
		{
			ExecutionReport executionReport = this.CreateExecutionReport(order);
			executionReport.AvgPx = 0.0;
			executionReport.CumQty = 0.0;
			executionReport.LeavesQty = order.OrderQty;
			executionReport.Text = text;
			executionReport.ExecType = ExecType.Rejected;
			executionReport.OrdStatus = OrdStatus.Rejected;
			base.Strategy.SendExecutionReport(executionReport);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000D35E File Offset: 0x0000C35E
		public void RejectClientOrder(SingleOrder order)
		{
			this.RejectClientOrder(order, string.Empty);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000D36C File Offset: 0x0000C36C
		public void FillClientOrder(SingleOrder order, double price)
		{
			ExecutionReport executionReport = this.CreateExecutionReport(order);
			executionReport.LastPx = price;
			executionReport.LastQty = order.OrderQty;
			executionReport.AvgPx = price;
			executionReport.CumQty = order.OrderQty;
			executionReport.LeavesQty = 0.0;
			executionReport.ExecType = ExecType.Fill;
			executionReport.OrdStatus = OrdStatus.Filled;
			base.Strategy.SendExecutionReport(executionReport);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000D3D0 File Offset: 0x0000C3D0
		public void PartialFillClientOrder(SingleOrder order, double price, double qty)
		{
			List<ExecutionReport> list = this.clientOrders[order];
			ExecutionReport executionReport = list[list.Count - 1];
			ExecutionReport executionReport2 = this.CreateExecutionReport(order);
			executionReport2.LastPx = price;
			executionReport2.LastQty = qty;
			executionReport2.AvgPx = (executionReport.AvgPx * executionReport.CumQty + price * qty) / (executionReport.CumQty + qty);
			executionReport2.CumQty = executionReport.CumQty + qty;
			executionReport2.LeavesQty = executionReport.LeavesQty - qty;
			if (executionReport2.LeavesQty == 0.0)
			{
				executionReport2.ExecType = ExecType.Fill;
				executionReport2.OrdStatus = OrdStatus.Filled;
			}
			else
			{
				executionReport2.ExecType = ExecType.PartialFill;
				executionReport2.OrdStatus = OrdStatus.PartiallyFilled;
			}
			base.Strategy.SendExecutionReport(executionReport2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000D488 File Offset: 0x0000C488
		private ExecutionReport CreateExecutionReport(SingleOrder order)
		{
			ExecutionReport executionReport = new ExecutionReport();
			executionReport.TransactTime = Clock.Now;
			executionReport.ExecID = DateTime.Now.ToString();
			executionReport.ClOrdID = order.ClOrdID;
			executionReport.OrderID = order.OrderID;
			executionReport.ExecTransType = ExecTransType.New;
			executionReport.Symbol = order.Symbol;
			executionReport.SecurityType = order.SecurityType;
			executionReport.SecurityExchange = order.SecurityExchange;
			executionReport.Currency = order.Currency;
			executionReport.TimeInForce = order.TimeInForce;
			executionReport.Side = order.Side;
			executionReport.OrdType = order.OrdType;
			executionReport.Price = order.Price;
			executionReport.StopPx = order.StopPx;
			executionReport.OrderQty = order.OrderQty;
			this.clientOrders[order].Add(executionReport);
			return executionReport;
		}

		// Token: 0x0400011B RID: 283
		public const string GUID = "{E70A6417-E7FA-4ec1-BC16-B03DE53C6E85}";

		// Token: 0x0400011C RID: 284
		private Dictionary<SingleOrder, List<ExecutionReport>> clientOrders;
	}
}
