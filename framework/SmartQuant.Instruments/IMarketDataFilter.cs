using System;
using SmartQuant.Data;
using SmartQuant.Providers;

namespace SmartQuant.Instruments
{
	// Token: 0x02000025 RID: 37
	public interface IMarketDataFilter
	{
		// Token: 0x06000256 RID: 598
		Trade Filter(Trade trade, Instrument instrument, IMarketDataProvider provider);

		// Token: 0x06000257 RID: 599
		Quote Filter(Quote quote, Instrument instrument, IMarketDataProvider provider);
	}
}
