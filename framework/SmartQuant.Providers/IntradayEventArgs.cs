using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000007 RID: 7
	public class IntradayEventArgs : EventArgs
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000211B File Offset: 0x0000111B
		protected IntradayEventArgs(IFIXInstrument instrument, IMarketDataProvider provider)
		{
			this.instrument = instrument;
			this.provider = provider;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002131 File Offset: 0x00001131
		public IFIXInstrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002139 File Offset: 0x00001139
		public IMarketDataProvider Provider
		{
			get
			{
				return this.provider;
			}
		}

		// Token: 0x04000024 RID: 36
		protected IFIXInstrument instrument;

		// Token: 0x04000025 RID: 37
		protected IMarketDataProvider provider;
	}
}
