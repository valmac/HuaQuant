using System;
using System.Collections;

namespace SmartQuant.Testing.Components
{
	// Token: 0x0200003F RID: 63
	public class TesterComponentRecordList : ICollection, IEnumerable
	{
		// Token: 0x06000212 RID: 530 RVA: 0x0000C880 File Offset: 0x0000B880
		public TesterComponentRecordList()
		{
			this.list = new Hashtable();
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000C893 File Offset: 0x0000B893
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000C8A0 File Offset: 0x0000B8A0
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000C8AD File Offset: 0x0000B8AD
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000C8BC File Offset: 0x0000B8BC
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000C8C9 File Offset: 0x0000B8C9
		public IEnumerator GetEnumerator()
		{
			return this.list.Values.GetEnumerator();
		}

		// Token: 0x17000064 RID: 100
		public TesterComponentRecord this[string name]
		{
			get
			{
				return this.list[name] as TesterComponentRecord;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000C8EE File Offset: 0x0000B8EE
		internal void Add(TesterComponentRecord record)
		{
			this.list.Add(record.Name, record);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000C902 File Offset: 0x0000B902
		internal void Remove(string name)
		{
			this.list.Remove(name);
		}

		// Token: 0x040000DA RID: 218
		private Hashtable list;
	}
}
