using System;
using System.Collections;

namespace SmartQuant.DataCenterLib
{
	// Token: 0x02000009 RID: 9
	public class ConnectorCollection : ICollection, IEnumerable
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000020D1 File Offset: 0x000010D1
		public ConnectorCollection()
		{
			this.collection = new SortedList();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020E4 File Offset: 0x000010E4
		public bool IsSynchronized
		{
			get
			{
				return this.collection.IsSynchronized;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020F1 File Offset: 0x000010F1
		public int Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020FE File Offset: 0x000010FE
		public void CopyTo(Array array, int index)
		{
			this.collection.CopyTo(array, index);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000210D File Offset: 0x0000110D
		public object SyncRoot
		{
			get
			{
				return this.collection.SyncRoot;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000211A File Offset: 0x0000111A
		public IEnumerator GetEnumerator()
		{
			return this.collection.Values.GetEnumerator();
		}

		// Token: 0x1700000B RID: 11
		public IConnector this[string name]
		{
			get
			{
				return this.collection[name] as IConnector;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000213F File Offset: 0x0000113F
		public void Add(IConnector connector)
		{
			this.collection.Add(connector.Name, connector);
		}

		// Token: 0x0400000A RID: 10
		private SortedList collection;
	}
}
