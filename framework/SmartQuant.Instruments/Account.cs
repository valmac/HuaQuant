using System;

namespace SmartQuant.Instruments
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class Account
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000316 RID: 790 RVA: 0x0000AA03 File Offset: 0x00009A03
		// (remove) Token: 0x06000317 RID: 791 RVA: 0x0000AA1C File Offset: 0x00009A1C
		public event EventHandler AccountChanged;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000318 RID: 792 RVA: 0x0000AA35 File Offset: 0x00009A35
		// (remove) Token: 0x06000319 RID: 793 RVA: 0x0000AA4E File Offset: 0x00009A4E
		public event AccountTransactionEventHandler TransactionAdded;

		// Token: 0x0600031A RID: 794 RVA: 0x0000AA67 File Offset: 0x00009A67
		public Account(string name, string description, Currency currency)
		{
			this.name = name;
			this.description = description;
			this.currency = currency;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000AA9A File Offset: 0x00009A9A
		public Account(string name, string description) : this(name, description, CurrencyManager.DefaultCurrency)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000AAA9 File Offset: 0x00009AA9
		public Account(string name) : this(name, "")
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000AAB7 File Offset: 0x00009AB7
		public Account(string name, Currency currency) : this(name, "", currency)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000AAC6 File Offset: 0x00009AC6
		public Account(Currency currency) : this("", currency)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000AAD4 File Offset: 0x00009AD4
		public Account() : this(CurrencyManager.DefaultCurrency)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000AAE1 File Offset: 0x00009AE1
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000AAE9 File Offset: 0x00009AE9
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000AAF2 File Offset: 0x00009AF2
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0000AAFA File Offset: 0x00009AFA
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000AB03 File Offset: 0x00009B03
		public AccountTransactionList Transactions
		{
			get
			{
				return this.transactions;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000AB0B File Offset: 0x00009B0B
		public AccountPositionList Positions
		{
			get
			{
				return this.positions;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000AB13 File Offset: 0x00009B13
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000AB1B File Offset: 0x00009B1B
		public Currency Currency
		{
			get
			{
				return this.currency;
			}
			set
			{
				this.currency = value;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000AB24 File Offset: 0x00009B24
		public double GetValue()
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				AccountPosition accountPosition = (AccountPosition)obj;
				num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.currency);
			}
			return num;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000AB9C File Offset: 0x00009B9C
		public double GetValue(DateTime dateTime)
		{
			Account account = new Account(this.currency);
			foreach (object obj in this.transactions)
			{
				AccountTransaction accountTransaction = (AccountTransaction)obj;
				if (accountTransaction.DateTime <= dateTime)
				{
					account.Add(accountTransaction);
				}
			}
			double num = 0.0;
			foreach (object obj2 in account.Positions)
			{
				AccountPosition accountPosition = (AccountPosition)obj2;
				num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.currency, dateTime);
			}
			return num;
		}

		// Token: 0x170000C4 RID: 196
		public double this[Currency currency]
		{
			get
			{
				AccountPosition accountPosition = this.positions[currency];
				if (accountPosition != null)
				{
					return accountPosition.Value;
				}
				return 0.0;
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000ACB1 File Offset: 0x00009CB1
		public void Clear()
		{
			this.transactions.Clear();
			this.positions.Clear();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000ACCC File Offset: 0x00009CCC
		public void Add(AccountTransaction transaction)
		{
			AccountPosition accountPosition = this.positions[transaction.Currency];
			if (accountPosition == null)
			{
				accountPosition = new AccountPosition(transaction.Currency);
				this.positions.Add(accountPosition);
			}
			this.transactions.Add(transaction);
			this.EmitTransactionAdded(transaction);
			accountPosition.fValue += transaction.Value;
			this.EmitAccountChanged();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000AD32 File Offset: 0x00009D32
		public void Add(Transaction transaction)
		{
			this.Add(new AccountTransaction(transaction));
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000AD40 File Offset: 0x00009D40
		public void Add(double val, Currency currency, DateTime dateTime, string text)
		{
			this.Add(new AccountTransaction(val, currency, dateTime, text));
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000AD52 File Offset: 0x00009D52
		public void Add(double val, Currency currency, DateTime dateTime)
		{
			this.Add(new AccountTransaction(val, currency, dateTime));
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000AD62 File Offset: 0x00009D62
		public void Add(double val, Currency currency, string text)
		{
			this.Add(val, currency, Clock.Now, text);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000AD72 File Offset: 0x00009D72
		public void Add(double val, Currency currency)
		{
			this.Add(val, currency, Clock.Now);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000AD81 File Offset: 0x00009D81
		public void Add(double val, DateTime dateTime)
		{
			this.Add(val, this.currency, dateTime);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000AD91 File Offset: 0x00009D91
		public void Add(double val)
		{
			this.Add(val, this.currency, Clock.Now);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000ADA5 File Offset: 0x00009DA5
		public void Deposit(double val, Currency currency, DateTime dateTime, string text)
		{
			this.Add(val, currency, dateTime, text);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000ADB2 File Offset: 0x00009DB2
		public void Deposit(double val, Currency currency, DateTime dateTime)
		{
			this.Add(val, currency, dateTime);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000ADBD File Offset: 0x00009DBD
		public void Deposit(double val, Currency currency)
		{
			this.Deposit(val, currency, Clock.Now);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000ADCC File Offset: 0x00009DCC
		public void Deposit(double val)
		{
			this.Deposit(val, this.currency, Clock.Now);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000ADE0 File Offset: 0x00009DE0
		public void Deposit(double val, DateTime dateTime)
		{
			this.Deposit(val, this.currency, dateTime);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000ADF0 File Offset: 0x00009DF0
		public void Deposit(double val, string text)
		{
			this.Deposit(val, this.currency, Clock.Now, text);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000AE05 File Offset: 0x00009E05
		public void Deposit(double val, DateTime dateTime, string text)
		{
			this.Deposit(val, this.currency, dateTime, text);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000AE16 File Offset: 0x00009E16
		public void Withdraw(double val, Currency currency, DateTime dateTime, string text)
		{
			this.Add(-Math.Abs(val), currency, dateTime, text);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000AE29 File Offset: 0x00009E29
		public void Withdraw(double val, Currency currency, DateTime dateTime)
		{
			this.Add(-Math.Abs(val), currency, dateTime);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000AE3A File Offset: 0x00009E3A
		public void Withdraw(double val, Currency currency)
		{
			this.Withdraw(val, currency, Clock.Now);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000AE49 File Offset: 0x00009E49
		public void Withdraw(double val)
		{
			this.Withdraw(val, this.currency, Clock.Now);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000AE5D File Offset: 0x00009E5D
		public void Withdraw(double val, DateTime dateTime)
		{
			this.Withdraw(val, this.currency, dateTime);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000AE6D File Offset: 0x00009E6D
		public void Withdraw(double val, string text)
		{
			this.Withdraw(val, this.currency, Clock.Now, text);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000AE82 File Offset: 0x00009E82
		public void Withdraw(double val, DateTime dateTime, string text)
		{
			this.Withdraw(val, this.currency, dateTime, text);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000AE93 File Offset: 0x00009E93
		private void EmitAccountChanged()
		{
			if (this.AccountChanged != null)
			{
				this.AccountChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000AEAE File Offset: 0x00009EAE
		private void EmitTransactionAdded(AccountTransaction transaction)
		{
			if (this.TransactionAdded != null)
			{
				this.TransactionAdded(this, new AccountTransactionEventArgs(transaction));
			}
		}

		// Token: 0x040000E9 RID: 233
		private string name;

		// Token: 0x040000EA RID: 234
		private string description;

		// Token: 0x040000EB RID: 235
		private Currency currency;

		// Token: 0x040000EC RID: 236
		private AccountTransactionList transactions = new AccountTransactionList();

		// Token: 0x040000ED RID: 237
		private AccountPositionList positions = new AccountPositionList();
	}
}
