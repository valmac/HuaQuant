using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000038 RID: 56
	public class FIXAllocationReportAckEventArgs : EventArgs
	{
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00010704 File Offset: 0x0000F704
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0001070C File Offset: 0x0000F70C
		public FIXAllocationReportAck AllocationReportAck
		{
			get
			{
				return this.fAllocationReportAck;
			}
			set
			{
				this.fAllocationReportAck = value;
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00010715 File Offset: 0x0000F715
		public FIXAllocationReportAckEventArgs(FIXAllocationReportAck AllocationReportAck)
		{
			this.fAllocationReportAck = AllocationReportAck;
		}

		// Token: 0x040000AA RID: 170
		private FIXAllocationReportAck fAllocationReportAck;
	}
}
