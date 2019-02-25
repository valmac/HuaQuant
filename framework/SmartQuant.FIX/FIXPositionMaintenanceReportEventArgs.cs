using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200017D RID: 381
	public class FIXPositionMaintenanceReportEventArgs : EventArgs
	{
		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x0004E186 File Offset: 0x0004D186
		// (set) Token: 0x0600465E RID: 18014 RVA: 0x0004E18E File Offset: 0x0004D18E
		public FIXPositionMaintenanceReport PositionMaintenanceReport
		{
			get
			{
				return this.fPositionMaintenanceReport;
			}
			set
			{
				this.fPositionMaintenanceReport = value;
			}
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x0004E197 File Offset: 0x0004D197
		public FIXPositionMaintenanceReportEventArgs(FIXPositionMaintenanceReport PositionMaintenanceReport)
		{
			this.fPositionMaintenanceReport = PositionMaintenanceReport;
		}

		// Token: 0x04000D90 RID: 3472
		private FIXPositionMaintenanceReport fPositionMaintenanceReport;
	}
}
