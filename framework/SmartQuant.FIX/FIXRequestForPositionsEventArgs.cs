using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200012A RID: 298
	public class FIXRequestForPositionsEventArgs : EventArgs
	{
		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0003AB53 File Offset: 0x00039B53
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x0003AB5B File Offset: 0x00039B5B
		public FIXRequestForPositions RequestForPositions
		{
			get
			{
				return this.fRequestForPositions;
			}
			set
			{
				this.fRequestForPositions = value;
			}
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x0003AB64 File Offset: 0x00039B64
		public FIXRequestForPositionsEventArgs(FIXRequestForPositions RequestForPositions)
		{
			this.fRequestForPositions = RequestForPositions;
		}

		// Token: 0x04000516 RID: 1302
		private FIXRequestForPositions fRequestForPositions;
	}
}
