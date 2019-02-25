using System;
using System.Collections;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x02000045 RID: 69
	public class RuleItemList : ICollection, IEnumerable
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0000B968 File Offset: 0x0000A968
		public RuleItemList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000B97B File Offset: 0x0000A97B
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000B988 File Offset: 0x0000A988
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B995 File Offset: 0x0000A995
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000B9A4 File Offset: 0x0000A9A4
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000B9B1 File Offset: 0x0000A9B1
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000B9BE File Offset: 0x0000A9BE
		public void Add(RuleItem item)
		{
			this.list.Add(item);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000B9CD File Offset: 0x0000A9CD
		public void Remove(RuleItem item)
		{
			this.list.Remove(item);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000B9DB File Offset: 0x0000A9DB
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x17000096 RID: 150
		public RuleItem this[int index]
		{
			get
			{
				return this.list[index] as RuleItem;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000B9FC File Offset: 0x0000A9FC
		public void Execute()
		{
			foreach (object obj in this.list)
			{
				RuleItem ruleItem = (RuleItem)obj;
				ruleItem.Execute();
			}
		}

		// Token: 0x040000F8 RID: 248
		private ArrayList list;
	}
}
