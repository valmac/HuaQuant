using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000105 RID: 261
	public class ExecutionReportEventArgs : EventArgs
	{
		// Token: 0x0600319B RID: 12699 RVA: 0x0003436C File Offset: 0x0003336C
		public ExecutionReportEventArgs(ExecutionReport report)
		{
			this.report = report;
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x0003437B File Offset: 0x0003337B
		public ExecutionReport ExecutionReport
		{
			get
			{
				return this.report;
			}
		}

		// Token: 0x04000439 RID: 1081
		private ExecutionReport report;
	}
}
