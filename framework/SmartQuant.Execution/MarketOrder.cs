using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000013 RID: 19
	public class MarketOrder : SingleOrder
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0000473C File Offset: 0x0000373C
		public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, string text)
		{
			base.OrdType = OrdType.Market;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Text = text;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004778 File Offset: 0x00003778
		public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty)
		{
			base.OrdType = OrdType.Market;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000047AC File Offset: 0x000037AC
		public MarketOrder(Instrument instrument, Side side, double qty, string text)
		{
			base.OrdType = OrdType.Market;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.Text = text;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000047F9 File Offset: 0x000037F9
		public MarketOrder(Instrument instrument, Side side, double qty)
		{
			base.OrdType = OrdType.Market;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004834 File Offset: 0x00003834
		public MarketOrder(string symbol, Side side, double qty, string text)
		{
			base.OrdType = OrdType.Market;
			base.Instrument = InstrumentManager.Instruments[symbol];
			if (base.Instrument == null)
			{
				throw new ArgumentException("Can not send order. Instrument with symbol " + symbol + " does not exist in the framework.");
			}
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Side = side;
			base.OrderQty = qty;
			base.Text = text;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000048AC File Offset: 0x000038AC
		public MarketOrder(string symbol, Side side, double qty)
		{
			base.OrdType = OrdType.Market;
			base.Instrument = InstrumentManager.Instruments[symbol];
			if (base.Instrument == null)
			{
				throw new ArgumentException("Can not send order. Instrument with symbol " + symbol + " does not exist in the framework.");
			}
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Side = side;
			base.OrderQty = qty;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004919 File Offset: 0x00003919
		private MarketOrder()
		{
		}
	}
}
