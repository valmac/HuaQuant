using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200005D RID: 93
	public class FIXYieldDataEventArgs : EventArgs
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0001367A File Offset: 0x0001267A
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00013682 File Offset: 0x00012682
		public FIXYieldData YieldData
		{
			get
			{
				return this.fYieldData;
			}
			set
			{
				this.fYieldData = value;
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0001368B File Offset: 0x0001268B
		public FIXYieldDataEventArgs(FIXYieldData YieldData)
		{
			this.fYieldData = YieldData;
		}

		// Token: 0x04000245 RID: 581
		private FIXYieldData fYieldData;
	}
}
