using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000098 RID: 152
	public class FIXExecutionReportEventArgs : EventArgs
	{
		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00021122 File Offset: 0x00020122
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0002112A File Offset: 0x0002012A
		public FIXExecutionReport ExecutionReport
		{
			get
			{
				return this.fExecutionReport;
			}
			set
			{
				this.fExecutionReport = value;
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00021133 File Offset: 0x00020133
		public FIXExecutionReportEventArgs(FIXExecutionReport ExecutionReport)
		{
			this.fExecutionReport = ExecutionReport;
		}

		// Token: 0x040002FB RID: 763
		private FIXExecutionReport fExecutionReport;
	}
}
