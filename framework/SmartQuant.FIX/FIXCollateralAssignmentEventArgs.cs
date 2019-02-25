using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000100 RID: 256
	public class FIXCollateralAssignmentEventArgs : EventArgs
	{
		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x0003172B File Offset: 0x0003072B
		// (set) Token: 0x06002F05 RID: 12037 RVA: 0x00031733 File Offset: 0x00030733
		public FIXCollateralAssignment CollateralAssignment
		{
			get
			{
				return this.fCollateralAssignment;
			}
			set
			{
				this.fCollateralAssignment = value;
			}
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x0003173C File Offset: 0x0003073C
		public FIXCollateralAssignmentEventArgs(FIXCollateralAssignment CollateralAssignment)
		{
			this.fCollateralAssignment = CollateralAssignment;
		}

		// Token: 0x0400041E RID: 1054
		private FIXCollateralAssignment fCollateralAssignment;
	}
}
