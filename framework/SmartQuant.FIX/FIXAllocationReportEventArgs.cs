using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000102 RID: 258
	public class FIXAllocationReportEventArgs : EventArgs
	{
		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x00032BCF File Offset: 0x00031BCF
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x00032BD7 File Offset: 0x00031BD7
		public FIXAllocationReport AllocationReport
		{
			get
			{
				return this.fAllocationReport;
			}
			set
			{
				this.fAllocationReport = value;
			}
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00032BE0 File Offset: 0x00031BE0
		public FIXAllocationReportEventArgs(FIXAllocationReport AllocationReport)
		{
			this.fAllocationReport = AllocationReport;
		}

		// Token: 0x0400042C RID: 1068
		private FIXAllocationReport fAllocationReport;
	}
}
