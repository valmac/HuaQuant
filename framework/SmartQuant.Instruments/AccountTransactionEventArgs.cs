using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000042 RID: 66
	public class AccountTransactionEventArgs : EventArgs
	{
		// Token: 0x0600036C RID: 876 RVA: 0x0000B5ED File Offset: 0x0000A5ED
		public AccountTransactionEventArgs(AccountTransaction transaction)
		{
			this.transaction = transaction;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000B5FC File Offset: 0x0000A5FC
		public AccountTransaction Transaction
		{
			get
			{
				return this.transaction;
			}
		}

		// Token: 0x040000F7 RID: 247
		private AccountTransaction transaction;
	}
}
