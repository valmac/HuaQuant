using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000128 RID: 296
	public class FIXRFQRequestEventArgs : EventArgs
	{
		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x0003A68F File Offset: 0x0003968F
		// (set) Token: 0x06003770 RID: 14192 RVA: 0x0003A697 File Offset: 0x00039697
		public FIXRFQRequest RFQRequest
		{
			get
			{
				return this.fRFQRequest;
			}
			set
			{
				this.fRFQRequest = value;
			}
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x0003A6A0 File Offset: 0x000396A0
		public FIXRFQRequestEventArgs(FIXRFQRequest RFQRequest)
		{
			this.fRFQRequest = RFQRequest;
		}

		// Token: 0x04000512 RID: 1298
		private FIXRFQRequest fRFQRequest;
	}
}
