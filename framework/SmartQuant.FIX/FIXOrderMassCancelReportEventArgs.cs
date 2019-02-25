using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200016B RID: 363
	public class FIXOrderMassCancelReportEventArgs : EventArgs
	{
		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x0004B2C2 File Offset: 0x0004A2C2
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x0004B2CA File Offset: 0x0004A2CA
		public FIXOrderMassCancelReport OrderMassCancelReport
		{
			get
			{
				return this.fOrderMassCancelReport;
			}
			set
			{
				this.fOrderMassCancelReport = value;
			}
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0004B2D3 File Offset: 0x0004A2D3
		public FIXOrderMassCancelReportEventArgs(FIXOrderMassCancelReport OrderMassCancelReport)
		{
			this.fOrderMassCancelReport = OrderMassCancelReport;
		}

		// Token: 0x04000D65 RID: 3429
		private FIXOrderMassCancelReport fOrderMassCancelReport;
	}
}
