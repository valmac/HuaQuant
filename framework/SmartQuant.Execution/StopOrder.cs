using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x0200000B RID: 11
	public class StopOrder : SingleOrder
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00002E94 File Offset: 0x00001E94
		public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx, string text)
		{
			base.OrdType = OrdType.Stop;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = stopPx;
			base.Text = text;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002EE3 File Offset: 0x00001EE3
		public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx)
		{
			base.OrdType = OrdType.Stop;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = stopPx;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002F20 File Offset: 0x00001F20
		public StopOrder(Instrument instrument, Side side, double qty, double stopPx, string text)
		{
			base.OrdType = OrdType.Stop;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = stopPx;
			base.Text = text;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002F78 File Offset: 0x00001F78
		public StopOrder(Instrument instrument, Side side, double qty, double stopPx)
		{
			base.OrdType = OrdType.Stop;
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = stopPx;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002FC8 File Offset: 0x00001FC8
		public StopOrder(string symbol, Side side, double qty, double stopPx, string text)
		{
			base.OrdType = OrdType.Stop;
			base.Instrument = InstrumentManager.Instruments[symbol];
			if (base.Instrument == null)
			{
				throw new ArgumentException("Can not send order. Instrument with symbol " + symbol + " does not exist in the framework.");
			}
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = stopPx;
			base.Text = text;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003048 File Offset: 0x00002048
		public StopOrder(string symbol, Side side, double qty, double stopPx)
		{
			base.OrdType = OrdType.Stop;
			base.Instrument = InstrumentManager.Instruments[symbol];
			if (base.Instrument == null)
			{
				throw new ArgumentException("Can not send order. Instrument with symbol " + symbol + " does not exist in the framework.");
			}
			base.Provider = ProviderManager.DefaultExecutionProvider;
			base.Portfolio = PortfolioManager.DefaultPortfolio;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = stopPx;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000030BD File Offset: 0x000020BD
		private StopOrder()
		{
		}
	}
}
