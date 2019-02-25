using System;
using System.Collections;

namespace SmartQuant.Trading
{
	// Token: 0x02000068 RID: 104
	public class SignalList : ICollection, IEnumerable
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0000FF8D File Offset: 0x0000EF8D
		public SignalList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000FFA0 File Offset: 0x0000EFA0
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000FFAD File Offset: 0x0000EFAD
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000FFBA File Offset: 0x0000EFBA
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000FFC9 File Offset: 0x0000EFC9
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000FFD6 File Offset: 0x0000EFD6
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x170000E4 RID: 228
		public Signal this[int index]
		{
			get
			{
				return this.list[index] as Signal;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000FFF6 File Offset: 0x0000EFF6
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00010003 File Offset: 0x0000F003
		public void Add(Signal signal)
		{
			this.list.Add(signal);
		}

		// Token: 0x0400015A RID: 346
		private ArrayList list;
	}
}
