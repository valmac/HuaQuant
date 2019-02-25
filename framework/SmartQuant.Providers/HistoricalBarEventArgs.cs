using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000033 RID: 51
	public class HistoricalBarEventArgs : HistoricalDataEventArgs
	{
		// Token: 0x0600014A RID: 330 RVA: 0x000048A4 File Offset: 0x000038A4
		public HistoricalBarEventArgs(Bar bar, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base(requestId, instrument, provider, dataLength)
		{
			this.bar = bar;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000048B9 File Offset: 0x000038B9
		public Bar Bar
		{
			get
			{
				return this.bar;
			}
		}

		// Token: 0x0400007E RID: 126
		private Bar bar;
	}
}
