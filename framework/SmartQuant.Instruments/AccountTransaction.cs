using System;
using System.ComponentModel;

namespace SmartQuant.Instruments
{
	// Token: 0x0200001D RID: 29
	public class AccountTransaction
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000646F File Offset: 0x0000546F
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00006477 File Offset: 0x00005477
		internal int Id
		{
			get
			{
				return this.fId;
			}
			set
			{
				this.fId = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00006480 File Offset: 0x00005480
		public AccountAction Action
		{
			get
			{
				if (this.fValue < 0.0)
				{
					return AccountAction.Withdraw;
				}
				return AccountAction.Deposit;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00006496 File Offset: 0x00005496
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000649E File Offset: 0x0000549E
		[ReadOnly(true)]
		public double Value
		{
			get
			{
				return this.fValue;
			}
			set
			{
				this.fValue = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000064A7 File Offset: 0x000054A7
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000064AF File Offset: 0x000054AF
		public Currency Currency
		{
			get
			{
				return this.fCurrency;
			}
			set
			{
				this.fCurrency = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000064B8 File Offset: 0x000054B8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000064C0 File Offset: 0x000054C0
		[ReadOnly(true)]
		public DateTime DateTime
		{
			get
			{
				return this.fDateTime;
			}
			set
			{
				this.fDateTime = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000064C9 File Offset: 0x000054C9
		[Browsable(false)]
		public Transaction Transaction
		{
			get
			{
				return this.fTransaction;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000064D1 File Offset: 0x000054D1
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x000064D9 File Offset: 0x000054D9
		public string Text
		{
			get
			{
				return this.fText;
			}
			set
			{
				this.fText = value;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000064E2 File Offset: 0x000054E2
		public AccountTransaction()
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000064F1 File Offset: 0x000054F1
		public AccountTransaction(double val, Currency currency, DateTime dateTime, string text)
		{
			this.fValue = val;
			this.fCurrency = currency;
			this.fDateTime = dateTime;
			this.fText = text;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000651D File Offset: 0x0000551D
		public AccountTransaction(double val, Currency currency, DateTime dateTime)
		{
			this.fValue = val;
			this.fCurrency = currency;
			this.fDateTime = dateTime;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00006541 File Offset: 0x00005541
		public AccountTransaction(double val, Currency currency, string text)
		{
			this.fValue = val;
			this.fCurrency = currency;
			this.fDateTime = Clock.Now;
			this.fText = text;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006570 File Offset: 0x00005570
		public AccountTransaction(double val, Currency currency)
		{
			this.fValue = val;
			this.fCurrency = currency;
			this.fDateTime = Clock.Now;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006598 File Offset: 0x00005598
		public AccountTransaction(Transaction transaction)
		{
			this.fValue = transaction.CashFlow;
			this.fCurrency = transaction.Currency;
			this.fDateTime = transaction.DateTime;
			this.fText = transaction.Text;
			this.fTransaction = transaction;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000065EC File Offset: 0x000055EC
		public string ActionToString()
		{
			switch (this.Action)
			{
			case AccountAction.Withdraw:
				return "Withdraw";
			case AccountAction.Deposit:
				return "Deposit";
			default:
				return "Undefined";
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006624 File Offset: 0x00005624
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.fDateTime,
				" ",
				this.ActionToString(),
				" ",
				Math.Abs(this.fValue),
				" ",
				this.fCurrency.Code,
				" "
			});
		}

		// Token: 0x0400006C RID: 108
		internal int fId = -1;

		// Token: 0x0400006D RID: 109
		internal DateTime fDateTime;

		// Token: 0x0400006E RID: 110
		internal Currency fCurrency;

		// Token: 0x0400006F RID: 111
		internal double fValue;

		// Token: 0x04000070 RID: 112
		internal Transaction fTransaction;

		// Token: 0x04000071 RID: 113
		internal string fText;
	}
}
