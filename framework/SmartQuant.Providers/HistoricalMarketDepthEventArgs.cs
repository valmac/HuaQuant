using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000029 RID: 41
	public class HistoricalMarketDepthEventArgs : HistoricalDataEventArgs
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00003542 File Offset: 0x00002542
		public HistoricalMarketDepthEventArgs(MarketDepth marketDepth, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base(requestId, instrument, provider, dataLength)
		{
			this.marketDepth = marketDepth;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003557 File Offset: 0x00002557
		public MarketDepth MarketDepth
		{
			get
			{
				return this.marketDepth;
			}
		}

		// Token: 0x04000057 RID: 87
		private MarketDepth marketDepth;
	}
}
