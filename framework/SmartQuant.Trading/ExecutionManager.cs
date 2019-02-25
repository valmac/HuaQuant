using System;
using System.Collections;
using SmartQuant.Execution;
using SmartQuant.FIX;

namespace SmartQuant.Trading
{
	// Token: 0x0200005D RID: 93
	[StrategyComponent("{D106D35A-E1E4-4e86-8869-846289E98232}", ComponentType.ExecutionManager, Name = "Default_ExecutionManager", Description = "")]
	public class ExecutionManager : MetaStrategyComponent
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x0000EB78 File Offset: 0x0000DB78
		public ExecutionManager()
		{
			this.orders = new Hashtable();
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000EB8B File Offset: 0x0000DB8B
		public override void Init()
		{
			this.orders.Clear();
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000EB98 File Offset: 0x0000DB98
		public virtual SingleOrder Execute(Signal signal)
		{
			SingleOrder singleOrder = new SingleOrder();
			singleOrder.Instrument = signal.Instrument;
			singleOrder.Strategy = signal.Strategy.Name;
			singleOrder.StrategyComponent = signal.Sender.ToString();
			singleOrder.StrategyFill = signal.StrategyFill;
			singleOrder.StrategyPrice = signal.StrategyPrice;
			singleOrder.ForceMarketOrder = signal.ForceMarketOrder;
			if (signal.ForceFillOnBarMode)
			{
				singleOrder.FillOnBarMode = (int)signal.FillOnBarMode;
			}
			switch (signal.Side)
			{
			case SignalSide.Buy:
				singleOrder.Side = Side.Buy;
				break;
			case SignalSide.BuyCover:
				singleOrder.Side = Side.Buy;
				break;
			case SignalSide.Sell:
				singleOrder.Side = Side.Sell;
				break;
			case SignalSide.SellShort:
				singleOrder.Side = Side.SellShort;
				break;
			default:
				throw new NotSupportedException();
			}
			switch (signal.Type)
			{
			case SignalType.Market:
				singleOrder.OrdType = OrdType.Market;
				break;
			case SignalType.Limit:
				singleOrder.OrdType = OrdType.Limit;
				singleOrder.Price = signal.LimitPrice;
				break;
			case SignalType.Stop:
				singleOrder.OrdType = OrdType.Stop;
				singleOrder.StopPx = signal.StopPrice;
				break;
			case SignalType.StopLimit:
				singleOrder.OrdType = OrdType.StopLimit;
				singleOrder.StopPx = signal.StopPrice;
				singleOrder.Price = signal.LimitPrice;
				break;
			case SignalType.TrailingStop:
				singleOrder.OrdType = OrdType.TrailingStop;
				singleOrder.StopPx = signal.StopPrice;
				break;
			default:
				throw new NotSupportedException();
			}
			singleOrder.OrderQty = signal.Qty;
			singleOrder.TimeInForce = signal.TimeInForce;
			singleOrder.Text = signal.Text;
			base.MetaStrategyBase.RegisterOrder(signal.Strategy, singleOrder);
			singleOrder.Send();
			return singleOrder;
		}

		// Token: 0x0400012A RID: 298
		public const string GUID = "{D106D35A-E1E4-4e86-8869-846289E98232}";

		// Token: 0x0400012B RID: 299
		protected Hashtable orders;
	}
}
