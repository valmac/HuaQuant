using System;
using System.Collections;
using SmartQuant.Execution;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000063 RID: 99
	public class OrderTable : ICollection, IEnumerable
	{
		// Token: 0x060003BD RID: 957 RVA: 0x0000EE37 File Offset: 0x0000DE37
		public OrderTable()
		{
			this.orders = new Hashtable();
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000EE4A File Offset: 0x0000DE4A
		public bool IsSynchronized
		{
			get
			{
				return this.orders.IsSynchronized;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000EE57 File Offset: 0x0000DE57
		public int Count
		{
			get
			{
				return this.orders.Count;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000EE64 File Offset: 0x0000DE64
		public void CopyTo(Array array, int index)
		{
			this.orders.CopyTo(array, index);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000EE73 File Offset: 0x0000DE73
		public object SyncRoot
		{
			get
			{
				return this.orders.SyncRoot;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000EE80 File Offset: 0x0000DE80
		public IEnumerator GetEnumerator()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.orders)
			{
				foreach (object obj2 in ((IEnumerable)((DictionaryEntry)obj).Value))
				{
					arrayList.Add(((DictionaryEntry)obj2).Value);
				}
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000EF40 File Offset: 0x0000DF40
		public void Add(Instrument instrument, string name, SingleOrder order)
		{
			NamedOrderTable namedOrderTable;
			if (this.orders.ContainsKey(instrument))
			{
				namedOrderTable = (this.orders[instrument] as NamedOrderTable);
			}
			else
			{
				namedOrderTable = new NamedOrderTable();
				this.orders.Add(instrument, namedOrderTable);
			}
			namedOrderTable.Add(name, order);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000EF8A File Offset: 0x0000DF8A
		public void Clear()
		{
			this.orders.Clear();
		}

		// Token: 0x170000C6 RID: 198
		public NamedOrderTable this[Instrument instrument]
		{
			get
			{
				if (!this.orders.ContainsKey(instrument))
				{
					this.orders.Add(instrument, new NamedOrderTable());
				}
				return this.orders[instrument] as NamedOrderTable;
			}
		}

		// Token: 0x170000C7 RID: 199
		public SingleOrder this[Instrument instrument, string name]
		{
			get
			{
				NamedOrderTable namedOrderTable = this.orders[instrument] as NamedOrderTable;
				return namedOrderTable[name];
			}
		}

		// Token: 0x0400013B RID: 315
		private Hashtable orders;
	}
}
