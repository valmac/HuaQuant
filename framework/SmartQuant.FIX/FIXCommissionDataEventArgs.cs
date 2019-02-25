using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200009C RID: 156
	public class FIXCommissionDataEventArgs : EventArgs
	{
		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00023A32 File Offset: 0x00022A32
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x00023A3A File Offset: 0x00022A3A
		public FIXCommissionData CommissionData
		{
			get
			{
				return this.fCommissionData;
			}
			set
			{
				this.fCommissionData = value;
			}
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00023A43 File Offset: 0x00022A43
		public FIXCommissionDataEventArgs(FIXCommissionData CommissionData)
		{
			this.fCommissionData = CommissionData;
		}

		// Token: 0x0400030E RID: 782
		private FIXCommissionData fCommissionData;
	}
}
