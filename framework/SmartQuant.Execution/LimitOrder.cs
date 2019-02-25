using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000006 RID: 6
	public class LimitOrder : SingleOrder
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000291C File Offset: 0x0000191C
		public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, string text)
		{
			base.OrdType = OrdType.Limit;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.Text = text;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000296B File Offset: 0x0000196B
		public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price)
		{
			base.OrdType = OrdType.Limit;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000029A8 File Offset: 0x000019A8
		public LimitOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			base.OrdType = OrdType.Limit;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
			base.Text = text;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002A00 File Offset: 0x00001A00
		public LimitOrder(Instrument instrument, Side side, double qty, double price)
		{
			base.OrdType = OrdType.Limit;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Price = price;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002A50 File Offset: 0x00001A50
		public LimitOrder(string symbol, Side side, double qty, double price, string text)
		{
			base.OrdType = OrdType.Limit;
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
			base.Text = text;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002AD0 File Offset: 0x00001AD0
		public LimitOrder(string symbol, Side side, double qty, double price)
		{
			base.OrdType = OrdType.Limit;
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
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002B45 File Offset: 0x00001B45
		private LimitOrder()
		{
		}
	}
}
