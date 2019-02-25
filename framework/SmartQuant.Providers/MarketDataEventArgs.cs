using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class MarketDataEventArgs : IntradayEventArgs
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002141 File Offset: 0x00001141
		public MarketDataEventArgs(IMarketData data, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.data = data;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002152 File Offset: 0x00001152
		public IMarketData MarketData
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x04000026 RID: 38
		private IMarketData data;
	}
}
