using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x0200003C RID: 60
	public class HistoricalDataErrorEventArgs : HistoricalDataEventArgs
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00004AA9 File Offset: 0x00003AA9
		public HistoricalDataErrorEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength, string message) : base(requestId, instrument, provider, dataLength)
		{
			this.message = message;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00004ABE File Offset: 0x00003ABE
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x04000096 RID: 150
		private string message;
	}
}
