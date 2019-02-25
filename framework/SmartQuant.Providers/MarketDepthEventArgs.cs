using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000014 RID: 20
	public class MarketDepthEventArgs : IntradayEventArgs
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000239C File Offset: 0x0000139C
		public MarketDepthEventArgs(MarketDepth marketDepth, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.marketDepth = marketDepth;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000023AD File Offset: 0x000013AD
		public MarketDepth MarketDepth
		{
			get
			{
				return this.marketDepth;
			}
		}

		// Token: 0x0400002E RID: 46
		private MarketDepth marketDepth;
	}
}
