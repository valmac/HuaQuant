using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000002 RID: 2
	public class FIXTradeCaptureReportAckEventArgs : EventArgs
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00001058
		public FIXTradeCaptureReportAck TradeCaptureReportAck
		{
			get
			{
				return this.fTradeCaptureReportAck;
			}
			set
			{
				this.fTradeCaptureReportAck = value;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00001061
		public FIXTradeCaptureReportAckEventArgs(FIXTradeCaptureReportAck TradeCaptureReportAck)
		{
			this.fTradeCaptureReportAck = TradeCaptureReportAck;
		}

		// Token: 0x04000001 RID: 1
		private FIXTradeCaptureReportAck fTradeCaptureReportAck;
	}
}
