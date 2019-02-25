using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	public class QuoteEventArgs : IntradayEventArgs
	{
		// Token: 0x06000201 RID: 513 RVA: 0x000055EB File Offset: 0x000045EB
		public QuoteEventArgs(Quote quote, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.quote = quote;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000055FC File Offset: 0x000045FC
		public Quote Quote
		{
			get
			{
				return this.quote;
			}
		}

		// Token: 0x040000BE RID: 190
		private Quote quote;
	}
}
