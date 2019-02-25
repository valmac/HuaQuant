using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000086 RID: 134
	public class FIXAssignmentReportEventArgs : EventArgs
	{
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0001BCB5 File Offset: 0x0001ACB5
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0001BCBD File Offset: 0x0001ACBD
		public FIXAssignmentReport AssignmentReport
		{
			get
			{
				return this.fAssignmentReport;
			}
			set
			{
				this.fAssignmentReport = value;
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0001BCC6 File Offset: 0x0001ACC6
		public FIXAssignmentReportEventArgs(FIXAssignmentReport AssignmentReport)
		{
			this.fAssignmentReport = AssignmentReport;
		}

		// Token: 0x040002AB RID: 683
		private FIXAssignmentReport fAssignmentReport;
	}
}
