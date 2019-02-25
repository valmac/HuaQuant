using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200010D RID: 269
	public class FIXTradeCaptureReportEventArgs : EventArgs
	{
		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x00034993 File Offset: 0x00033993
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x0003499B File Offset: 0x0003399B
		public FIXTradeCaptureReport TradeCaptureReport
		{
			get
			{
				return this.fTradeCaptureReport;
			}
			set
			{
				this.fTradeCaptureReport = value;
			}
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000349A4 File Offset: 0x000339A4
		public FIXTradeCaptureReportEventArgs(FIXTradeCaptureReport TradeCaptureReport)
		{
			this.fTradeCaptureReport = TradeCaptureReport;
		}

		// Token: 0x040004E0 RID: 1248
		private FIXTradeCaptureReport fTradeCaptureReport;
	}
}
