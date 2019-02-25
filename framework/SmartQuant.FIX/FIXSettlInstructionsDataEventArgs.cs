using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000124 RID: 292
	public class FIXSettlInstructionsDataEventArgs : EventArgs
	{
		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x0003A061 File Offset: 0x00039061
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x0003A069 File Offset: 0x00039069
		public FIXSettlInstructionsData SettlInstructionsData
		{
			get
			{
				return this.fSettlInstructionsData;
			}
			set
			{
				this.fSettlInstructionsData = value;
			}
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x0003A072 File Offset: 0x00039072
		public FIXSettlInstructionsDataEventArgs(FIXSettlInstructionsData SettlInstructionsData)
		{
			this.fSettlInstructionsData = SettlInstructionsData;
		}

		// Token: 0x0400050D RID: 1293
		private FIXSettlInstructionsData fSettlInstructionsData;
	}
}
