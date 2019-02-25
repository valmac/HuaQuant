using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E4 RID: 228
	public class FIXAdvertisementEventArgs : EventArgs
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x00030314 File Offset: 0x0002F314
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x0003031C File Offset: 0x0002F31C
		public FIXAdvertisement Advertisement
		{
			get
			{
				return this.fAdvertisement;
			}
			set
			{
				this.fAdvertisement = value;
			}
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00030325 File Offset: 0x0002F325
		public FIXAdvertisementEventArgs(FIXAdvertisement Advertisement)
		{
			this.fAdvertisement = Advertisement;
		}

		// Token: 0x040003E2 RID: 994
		private FIXAdvertisement fAdvertisement;
	}
}
