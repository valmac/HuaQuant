using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200007E RID: 126
	public class FIXLogonEventArgs : EventArgs
	{
		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0001AFD8 File Offset: 0x00019FD8
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0001AFE0 File Offset: 0x00019FE0
		public FIXLogon Logon
		{
			get
			{
				return this.fLogon;
			}
			set
			{
				this.fLogon = value;
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0001AFE9 File Offset: 0x00019FE9
		public FIXLogonEventArgs(FIXLogon Logon)
		{
			this.fLogon = Logon;
		}

		// Token: 0x040002A2 RID: 674
		private FIXLogon fLogon;
	}
}
