using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000004 RID: 4
	public class StopLimitOrder : SingleOrder
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002698 File Offset: 0x00001698
		public StopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, double stopPx, string text)
		{
			base.OrdType = OrdType.StopLimit;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.StopPx = stopPx;
			base.Text = text;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000026F0 File Offset: 0x000016F0
		public StopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, double stopPx)
		{
			base.OrdType = OrdType.StopLimit;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.StopPx = stopPx;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002740 File Offset: 0x00001740
		public StopLimitOrder(Instrument instrument, Side side, double qty, double price, double stopPx, string text)
		{
			base.OrdType = OrdType.StopLimit;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.StopPx = stopPx;
			base.Text = text;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000027A0 File Offset: 0x000017A0
		public StopLimitOrder(Instrument instrument, Side side, double qty, double price, double stopPx)
		{
			base.OrdType = OrdType.StopLimit;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.StopPx = stopPx;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000027F8 File Offset: 0x000017F8
		public StopLimitOrder(string symbol, Side side, double qty, double price, double stopPx, string text)
		{
			base.OrdType = OrdType.StopLimit;
			base.Instrument = InstrumentManager.Instruments[symbol];
			if (base.Instrument == null)
			{
				throw new ArgumentException("Can not send order. Instrument with symbol " + symbol + " does not exist in the framework.");
			}
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.StopPx = stopPx;
			base.Text = text;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002880 File Offset: 0x00001880
		public StopLimitOrder(string symbol, Side side, double qty, double price, double stopPx)
		{
			base.OrdType = OrdType.StopLimit;
			base.Instrument = InstrumentManager.Instruments[symbol];
			if (base.Instrument == null)
			{
				throw new ArgumentException("Can not send order. Instrument with symbol " + symbol + " does not exist in the framework.");
			}
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.StopPx = stopPx;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000028FD File Offset: 0x000018FD
		private StopLimitOrder()
		{
		}
	}
}
