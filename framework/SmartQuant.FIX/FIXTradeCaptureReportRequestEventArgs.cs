using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000061 RID: 97
	public class FIXTradeCaptureReportRequestEventArgs : EventArgs
	{
		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00013DD6 File Offset: 0x00012DD6
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x00013DDE File Offset: 0x00012DDE
		public FIXTradeCaptureReportRequest TradeCaptureReportRequest
		{
			get
			{
				return this.fTradeCaptureReportRequest;
			}
			set
			{
				this.fTradeCaptureReportRequest = value;
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00013DE7 File Offset: 0x00012DE7
		public FIXTradeCaptureReportRequestEventArgs(FIXTradeCaptureReportRequest TradeCaptureReportRequest)
		{
			this.fTradeCaptureReportRequest = TradeCaptureReportRequest;
		}

		// Token: 0x04000249 RID: 585
		private FIXTradeCaptureReportRequest fTradeCaptureReportRequest;
	}
}
