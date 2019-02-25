using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000177 RID: 375
	public class FIXUnderlyingStipulationsEventArgs : EventArgs
	{
		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x0004D2B9 File Offset: 0x0004C2B9
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x0004D2C1 File Offset: 0x0004C2C1
		public FIXUnderlyingStipulations UnderlyingStipulations
		{
			get
			{
				return this.fUnderlyingStipulations;
			}
			set
			{
				this.fUnderlyingStipulations = value;
			}
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x0004D2CA File Offset: 0x0004C2CA
		public FIXUnderlyingStipulationsEventArgs(FIXUnderlyingStipulations UnderlyingStipulations)
		{
			this.fUnderlyingStipulations = UnderlyingStipulations;
		}

		// Token: 0x04000D84 RID: 3460
		private FIXUnderlyingStipulations fUnderlyingStipulations;
	}
}
