using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000111 RID: 273
	public class FIXSecurityListEventArgs : EventArgs
	{
		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x00036337 File Offset: 0x00035337
		// (set) Token: 0x0600334E RID: 13134 RVA: 0x0003633F File Offset: 0x0003533F
		public FIXSecurityList SecurityList
		{
			get
			{
				return this.fSecurityList;
			}
			set
			{
				this.fSecurityList = value;
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00036348 File Offset: 0x00035348
		public FIXSecurityListEventArgs(FIXSecurityList SecurityList)
		{
			this.fSecurityList = SecurityList;
		}

		// Token: 0x040004ED RID: 1261
		private FIXSecurityList fSecurityList;
	}
}
