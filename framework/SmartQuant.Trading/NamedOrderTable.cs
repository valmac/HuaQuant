using System;
using System.Collections;
using SmartQuant.Execution;

namespace SmartQuant.Trading
{
	// Token: 0x02000064 RID: 100
	public class NamedOrderTable : ICollection, IEnumerable
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000EFF2 File Offset: 0x0000DFF2
		internal NamedOrderTable()
		{
			this.orders = new Hashtable();
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000F005 File Offset: 0x0000E005
		public bool IsSynchronized
		{
			get
			{
				return this.orders.IsSynchronized;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000F012 File Offset: 0x0000E012
		public int Count
		{
			get
			{
				return this.orders.Count;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000F01F File Offset: 0x0000E01F
		public void CopyTo(Array array, int index)
		{
			this.orders.CopyTo(array, index);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000F02E File Offset: 0x0000E02E
		public object SyncRoot
		{
			get
			{
				return this.orders.SyncRoot;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000F03B File Offset: 0x0000E03B
		public IEnumerator GetEnumerator()
		{
			return this.orders.Values.GetEnumerator();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000F04D File Offset: 0x0000E04D
		internal void Add(string name, SingleOrder order)
		{
			this.orders[name] = order;
		}

		// Token: 0x170000CB RID: 203
		public SingleOrder this[string name]
		{
			get
			{
				return this.orders[name] as SingleOrder;
			}
		}

		// Token: 0x0400013C RID: 316
		private Hashtable orders;
	}
}
