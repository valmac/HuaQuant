using System;
using System.Collections;

namespace SmartQuant.Instruments
{
	// Token: 0x0200000B RID: 11
	public class AccountTransactionList : ICollection, IEnumerable
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000023B0 File Offset: 0x000013B0
		public AccountTransactionList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000023C3 File Offset: 0x000013C3
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000023D0 File Offset: 0x000013D0
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000023DD File Offset: 0x000013DD
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000023EC File Offset: 0x000013EC
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023F9 File Offset: 0x000013F9
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002406 File Offset: 0x00001406
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002414 File Offset: 0x00001414
		public void Add(AccountTransaction transaction)
		{
			int i;
			for (i = this.list.Count; i > 0; i--)
			{
				AccountTransaction accountTransaction = this[i - 1];
				if (transaction.DateTime >= accountTransaction.DateTime)
				{
					break;
				}
			}
			this.list.Insert(i, transaction);
		}

		// Token: 0x17000008 RID: 8
		public AccountTransaction this[int index]
		{
			get
			{
				return this.list[index] as AccountTransaction;
			}
		}

		// Token: 0x04000007 RID: 7
		private ArrayList list;
	}
}
