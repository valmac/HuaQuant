using System;
using SmartQuant.FIX;
using SmartQuant.FIXData;

namespace SmartQuant.Providers
{
	// Token: 0x02000043 RID: 67
	public class FundamentalEventArgs : IntradayEventArgs
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00004C32 File Offset: 0x00003C32
		public FundamentalEventArgs(Fundamental fundamental, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.fundamental = fundamental;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00004C43 File Offset: 0x00003C43
		public Fundamental Fundamental
		{
			get
			{
				return this.fundamental;
			}
		}

		// Token: 0x0400009A RID: 154
		private Fundamental fundamental;
	}
}
