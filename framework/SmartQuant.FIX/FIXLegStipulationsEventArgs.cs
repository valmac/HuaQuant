using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000067 RID: 103
	public class FIXLegStipulationsEventArgs : EventArgs
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00015625 File Offset: 0x00014625
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x0001562D File Offset: 0x0001462D
		public FIXLegStipulations LegStipulations
		{
			get
			{
				return this.fLegStipulations;
			}
			set
			{
				this.fLegStipulations = value;
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00015636 File Offset: 0x00014636
		public FIXLegStipulationsEventArgs(FIXLegStipulations LegStipulations)
		{
			this.fLegStipulations = LegStipulations;
		}

		// Token: 0x04000258 RID: 600
		private FIXLegStipulations fLegStipulations;
	}
}
