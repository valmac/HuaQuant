using System;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Execution
{
	// Token: 0x02000010 RID: 16
	public class TrailingStopOrder : SingleOrder
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00003F83 File Offset: 0x00002F83
		public TrailingStopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double delta)
		{
			base.OrdType = OrdType.TrailingStop;
			base.Provider = provider;
			base.Portfolio = portfolio;
			base.Instrument = instrument;
			base.Side = side;
			base.OrderQty = qty;
			base.StopPx = delta;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003FC0 File Offset: 0x00002FC0
		public TrailingStopOrder(Instrument instrument, Side side, double qty, double delta) : this(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, delta)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003FD7 File Offset: 0x00002FD7
		private TrailingStopOrder()
		{
		}
	}
}
