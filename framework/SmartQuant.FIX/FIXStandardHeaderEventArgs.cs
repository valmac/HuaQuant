using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000DA RID: 218
	public class FIXStandardHeaderEventArgs : EventArgs
	{
		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x0002DBDE File Offset: 0x0002CBDE
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x0002DBE6 File Offset: 0x0002CBE6
		public FIXStandardHeader StandardHeader
		{
			get
			{
				return this.fStandardHeader;
			}
			set
			{
				this.fStandardHeader = value;
			}
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x0002DBEF File Offset: 0x0002CBEF
		public FIXStandardHeaderEventArgs(FIXStandardHeader StandardHeader)
		{
			this.fStandardHeader = StandardHeader;
		}

		// Token: 0x040003CA RID: 970
		private FIXStandardHeader fStandardHeader;
	}
}
