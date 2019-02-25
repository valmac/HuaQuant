using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200004C RID: 76
	public class FIXStipulationsEventArgs : EventArgs
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00012576 File Offset: 0x00011576
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x0001257E File Offset: 0x0001157E
		public FIXStipulations Stipulations
		{
			get
			{
				return this.fStipulations;
			}
			set
			{
				this.fStipulations = value;
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00012587 File Offset: 0x00011587
		public FIXStipulationsEventArgs(FIXStipulations Stipulations)
		{
			this.fStipulations = Stipulations;
		}

		// Token: 0x04000185 RID: 389
		private FIXStipulations fStipulations;
	}
}
