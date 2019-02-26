using System;
using SmartQuant.FIX;

namespace SmartQuant.Services
{
	// Token: 0x0200000D RID: 13
	public class LogoutEventArgs : MarketServiceEventArgs
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002165 File Offset: 0x00001165
		public LogoutEventArgs(IMarketService service, FIXLogout logout) : base(service)
		{
			this.logout = logout;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002175 File Offset: 0x00001175
		public FIXLogout Logout
		{
			get
			{
				return this.logout;
			}
		}

		// Token: 0x04000007 RID: 7
		private FIXLogout logout;
	}
}
