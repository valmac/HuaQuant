using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200012F RID: 303
	public class FIXPositionMaintenanceRequestEventArgs : EventArgs
	{
		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x0003C761 File Offset: 0x0003B761
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x0003C769 File Offset: 0x0003B769
		public FIXPositionMaintenanceRequest PositionMaintenanceRequest
		{
			get
			{
				return this.fPositionMaintenanceRequest;
			}
			set
			{
				this.fPositionMaintenanceRequest = value;
			}
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0003C772 File Offset: 0x0003B772
		public FIXPositionMaintenanceRequestEventArgs(FIXPositionMaintenanceRequest PositionMaintenanceRequest)
		{
			this.fPositionMaintenanceRequest = PositionMaintenanceRequest;
		}

		// Token: 0x04000527 RID: 1319
		private FIXPositionMaintenanceRequest fPositionMaintenanceRequest;
	}
}
