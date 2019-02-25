using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000DE RID: 222
	public class FIXLogoutEventArgs : EventArgs
	{
		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x0002E513 File Offset: 0x0002D513
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0002E51B File Offset: 0x0002D51B
		public FIXLogout Logout
		{
			get
			{
				return this.fLogout;
			}
			set
			{
				this.fLogout = value;
			}
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0002E524 File Offset: 0x0002D524
		public FIXLogoutEventArgs(FIXLogout Logout)
		{
			this.fLogout = Logout;
		}

		// Token: 0x040003D1 RID: 977
		private FIXLogout fLogout;
	}
}
