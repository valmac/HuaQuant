using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000015 RID: 21
	public class HistoricalDataEventArgs : EventArgs
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000023B5 File Offset: 0x000013B5
		public HistoricalDataEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
		{
			this.requestId = requestId;
			this.instrument = instrument;
			this.provider = provider;
			this.dataLength = dataLength;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000023DA File Offset: 0x000013DA
		public string RequestId
		{
			get
			{
				return this.requestId;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000023E2 File Offset: 0x000013E2
		public IFIXInstrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000023EA File Offset: 0x000013EA
		public IHistoricalDataProvider Provider
		{
			get
			{
				return this.provider;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000023F2 File Offset: 0x000013F2
		public int DataLength
		{
			get
			{
				return this.dataLength;
			}
		}

		// Token: 0x0400002F RID: 47
		private string requestId;

		// Token: 0x04000030 RID: 48
		private IFIXInstrument instrument;

		// Token: 0x04000031 RID: 49
		private IHistoricalDataProvider provider;

		// Token: 0x04000032 RID: 50
		private int dataLength;
	}
}
