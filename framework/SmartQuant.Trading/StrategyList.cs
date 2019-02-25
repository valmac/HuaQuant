using System;
using System.Collections;

namespace SmartQuant.Trading
{
	// Token: 0x0200004B RID: 75
	public class StrategyList : ICollection, IEnumerable
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0000C671 File Offset: 0x0000B671
		internal StrategyList()
		{
			this.list = new SortedList();
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000C684 File Offset: 0x0000B684
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000C691 File Offset: 0x0000B691
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000C6A0 File Offset: 0x0000B6A0
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000C6AD File Offset: 0x0000B6AD
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000C6BA File Offset: 0x0000B6BA
		public IEnumerator GetEnumerator()
		{
			return this.list.Values.GetEnumerator();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000C6CC File Offset: 0x0000B6CC
		internal void Add(StrategyBase strategy)
		{
			if (this.list.Contains(strategy.Name))
			{
				throw new ApplicationException("Can not add Strategy that is already present in the list : " + strategy.Name);
			}
			this.list.Add(strategy.Name, strategy);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000C709 File Offset: 0x0000B709
		internal void Remove(StrategyBase strategy)
		{
			this.list.Remove(strategy.Name);
		}

		// Token: 0x170000A0 RID: 160
		public StrategyBase this[string name]
		{
			get
			{
				return this.list[name] as StrategyBase;
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000C72F File Offset: 0x0000B72F
		public bool Contains(string name)
		{
			return this.list.ContainsKey(name);
		}

		// Token: 0x040000FF RID: 255
		private SortedList list;
	}
}
