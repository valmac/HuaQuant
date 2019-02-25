using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000029 RID: 41
	public class FIXAllocationInstructionAckEventArgs : EventArgs
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0000C285 File Offset: 0x0000B285
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0000C28D File Offset: 0x0000B28D
		public FIXAllocationInstructionAck AllocationInstructionAck
		{
			get
			{
				return this.fAllocationInstructionAck;
			}
			set
			{
				this.fAllocationInstructionAck = value;
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0000C296 File Offset: 0x0000B296
		public FIXAllocationInstructionAckEventArgs(FIXAllocationInstructionAck AllocationInstructionAck)
		{
			this.fAllocationInstructionAck = AllocationInstructionAck;
		}

		// Token: 0x04000071 RID: 113
		private FIXAllocationInstructionAck fAllocationInstructionAck;
	}
}
