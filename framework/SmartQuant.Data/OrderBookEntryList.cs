using System;
using System.Collections;

namespace SmartQuant.Data
{
	// Token: 0x02000024 RID: 36
	public class OrderBookEntryList : ICollection, IEnumerable
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00004A4C File Offset: 0x00003A4C
		internal OrderBookEntryList()
		{
			this.list = ArrayList.Synchronized(new ArrayList());
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00004A64 File Offset: 0x00003A64
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00004A71 File Offset: 0x00003A71
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004A7E File Offset: 0x00003A7E
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00004A8D File Offset: 0x00003A8D
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004A9A File Offset: 0x00003A9A
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004AA7 File Offset: 0x00003AA7
		internal void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x17000068 RID: 104
		public OrderBookEntry this[int index]
		{
			get
			{
				return this.list[index] as OrderBookEntry;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004AC7 File Offset: 0x00003AC7
		internal void Insert(int index, OrderBookEntry entry)
		{
			this.list.Insert(index, entry);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004AD6 File Offset: 0x00003AD6
		internal void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		// Token: 0x04000071 RID: 113
		private ArrayList list;
	}
}
