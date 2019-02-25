using System;
using System.Collections;

namespace SmartQuant.Trading
{
	// Token: 0x0200007E RID: 126
	public class TriggerList : ICollection, IEnumerable
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00012BDA File Offset: 0x00011BDA
		public TriggerList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00012BED File Offset: 0x00011BED
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00012BFA File Offset: 0x00011BFA
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00012C07 File Offset: 0x00011C07
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00012C16 File Offset: 0x00011C16
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00012C23 File Offset: 0x00011C23
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00012C30 File Offset: 0x00011C30
		public void Add(Trigger trigger)
		{
			this.list.Add(trigger);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00012C3F File Offset: 0x00011C3F
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x0400018F RID: 399
		private ArrayList list;
	}
}
