using System;
using SmartQuant.FIX;

namespace SmartQuant.Services
{
	// Token: 0x0200000A RID: 10
	public interface IMarketService : IService
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000019 RID: 25
		// (remove) Token: 0x0600001A RID: 26
		event FIXLogonEventHandler Logon;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600001B RID: 27
		// (remove) Token: 0x0600001C RID: 28
		event FIXLogoutEventHandler Logout;

		// Token: 0x0600001D RID: 29
		void Send(FIXLogon message);

		// Token: 0x0600001E RID: 30
		void Send(FIXLogout message);
	}
}
