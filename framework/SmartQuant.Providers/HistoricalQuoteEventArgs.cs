using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x0200003A RID: 58
	public class HistoricalQuoteEventArgs : HistoricalDataEventArgs
	{
		// Token: 0x0600015F RID: 351 RVA: 0x000049FA File Offset: 0x000039FA
		public HistoricalQuoteEventArgs(Quote quote, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base(requestId, instrument, provider, dataLength)
		{
			this.quote = quote;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00004A0F File Offset: 0x00003A0F
		public Quote Quote
		{
			get
			{
				return this.quote;
			}
		}

		// Token: 0x04000093 RID: 147
		private Quote quote;
	}
}
