using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200003F RID: 63
	public class BrokerInfo
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00004B03 File Offset: 0x00003B03
		public BrokerInfo()
		{
			this.accounts = new BrokerAccountList();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00004B16 File Offset: 0x00003B16
		public BrokerAccountList Accounts
		{
			get
			{
				return this.accounts;
			}
		}

		// Token: 0x04000098 RID: 152
		private BrokerAccountList accounts;
	}
}
