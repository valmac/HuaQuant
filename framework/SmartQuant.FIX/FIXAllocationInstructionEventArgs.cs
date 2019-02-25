using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200000A RID: 10
	public class FIXAllocationInstructionEventArgs : EventArgs
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000304 RID: 772 RVA: 0x000054E6 File Offset: 0x000044E6
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000054EE File Offset: 0x000044EE
		public FIXAllocationInstruction AllocationInstruction
		{
			get
			{
				return this.fAllocationInstruction;
			}
			set
			{
				this.fAllocationInstruction = value;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000054F7 File Offset: 0x000044F7
		public FIXAllocationInstructionEventArgs(FIXAllocationInstruction AllocationInstruction)
		{
			this.fAllocationInstruction = AllocationInstruction;
		}

		// Token: 0x04000022 RID: 34
		private FIXAllocationInstruction fAllocationInstruction;
	}
}
