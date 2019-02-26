using System;
using SmartQuant.FIX;

namespace SmartQuant.Services
{
	// Token: 0x02000008 RID: 8
	public class LogonEventArgs : MarketServiceEventArgs
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000020AD File Offset: 0x000010AD
		public LogonEventArgs(IMarketService service, FIXLogon logon) : base(service)
		{
			this.logon = logon;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020BD File Offset: 0x000010BD
		public FIXLogon Logon
		{
			get
			{
				return this.logon;
			}
		}

		// Token: 0x04000005 RID: 5
		private FIXLogon logon;
	}
}
