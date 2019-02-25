using System;
using System.Collections;

namespace SmartQuant.Trading
{
	// Token: 0x02000085 RID: 133
	public class StopList : ICollection, IEnumerable
	{
		// Token: 0x060005FC RID: 1532 RVA: 0x0001352E File Offset: 0x0001252E
		public StopList()
		{
			this.fList = new ArrayList();
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00013541 File Offset: 0x00012541
		public bool IsSynchronized
		{
			get
			{
				return this.fList.IsSynchronized;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001354E File Offset: 0x0001254E
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001355B File Offset: 0x0001255B
		public void CopyTo(Array array, int index)
		{
			this.fList.CopyTo(array, index);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001356A File Offset: 0x0001256A
		public object SyncRoot
		{
			get
			{
				return this.fList.SyncRoot;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00013577 File Offset: 0x00012577
		public IEnumerator GetEnumerator()
		{
			return this.fList.GetEnumerator();
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00013584 File Offset: 0x00012584
		public void Add(IStop stop)
		{
			this.Add(stop, true);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001358E File Offset: 0x0001258E
		public void Add(IStop stop, bool sort)
		{
			this.fList.Add(stop);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001359D File Offset: 0x0001259D
		public void Remove(IStop stop)
		{
			this.fList.Remove(stop);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000135AB File Offset: 0x000125AB
		public void RemoveAt(int index)
		{
			this.fList.RemoveAt(index);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000135B9 File Offset: 0x000125B9
		public void Clear()
		{
			this.fList.Clear();
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000135C6 File Offset: 0x000125C6
		public bool Contains(IStop stop)
		{
			return this.fList.Contains(stop);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000135D4 File Offset: 0x000125D4
		public void Sort()
		{
			this.fList.Sort();
		}

		// Token: 0x17000117 RID: 279
		public IStop this[int index]
		{
			get
			{
				return this.fList[index] as IStop;
			}
		}

		// Token: 0x040001A0 RID: 416
		private ArrayList fList;
	}
}
