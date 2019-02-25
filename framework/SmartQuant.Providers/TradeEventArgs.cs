using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class TradeEventArgs : IntradayEventArgs
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00004AEA File Offset: 0x00003AEA
		public TradeEventArgs(Trade trade, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.trade = trade;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00004AFB File Offset: 0x00003AFB
		public Trade Trade
		{
			get
			{
				return this.trade;
			}
		}

		// Token: 0x04000097 RID: 151
		private Trade trade;
	}
}
