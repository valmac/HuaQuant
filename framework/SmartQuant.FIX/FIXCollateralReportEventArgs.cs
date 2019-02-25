using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000135 RID: 309
	public class FIXCollateralReportEventArgs : EventArgs
	{
		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x0003DC34 File Offset: 0x0003CC34
		// (set) Token: 0x06003AA8 RID: 15016 RVA: 0x0003DC3C File Offset: 0x0003CC3C
		public FIXCollateralReport CollateralReport
		{
			get
			{
				return this.fCollateralReport;
			}
			set
			{
				this.fCollateralReport = value;
			}
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x0003DC45 File Offset: 0x0003CC45
		public FIXCollateralReportEventArgs(FIXCollateralReport CollateralReport)
		{
			this.fCollateralReport = CollateralReport;
		}

		// Token: 0x04000537 RID: 1335
		private FIXCollateralReport fCollateralReport;
	}
}
