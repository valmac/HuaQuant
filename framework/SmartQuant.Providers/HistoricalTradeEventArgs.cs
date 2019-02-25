using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000016 RID: 22
	public class HistoricalTradeEventArgs : HistoricalDataEventArgs
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000023FA File Offset: 0x000013FA
		public HistoricalTradeEventArgs(Trade trade, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base(requestId, instrument, provider, dataLength)
		{
			this.trade = trade;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000240F File Offset: 0x0000140F
		public Trade Trade
		{
			get
			{
				return this.trade;
			}
		}

		// Token: 0x04000033 RID: 51
		private Trade trade;
	}
}
