using System;
using System.Collections;
using System.Collections.Generic;

namespace SmartQuant.Providers
{
	// Token: 0x02000046 RID: 70
	public class BrokerAccountList : ICollection, IEnumerable
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00004E34 File Offset: 0x00003E34
		internal BrokerAccountList()
		{
			this.accounts = new SortedList<string, BrokerAccount>();
			this.list = new List<BrokerAccount>();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00004E52 File Offset: 0x00003E52
		public void CopyTo(Array array, int index)
		{
			this.list.ToArray().CopyTo(array, index);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00004E66 File Offset: 0x00003E66
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00004E73 File Offset: 0x00003E73
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00004E76 File Offset: 0x00003E76
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00004E79 File Offset: 0x00003E79
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x17000064 RID: 100
		public BrokerAccount this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		// Token: 0x17000065 RID: 101
		public BrokerAccount this[string name]
		{
			get
			{
				return this.accounts[name];
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004EA7 File Offset: 0x00003EA7
		public void Add(BrokerAccount account)
		{
			this.accounts.Add(account.Name, account);
			this.list.Add(account);
		}

		// Token: 0x040000A6 RID: 166
		private SortedList<string, BrokerAccount> accounts;

		// Token: 0x040000A7 RID: 167
		private List<BrokerAccount> list;
	}
}
