using System;
using System.Collections;

namespace SmartQuant.Charting
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class PadList : IList, ICollection, IEnumerable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000248F File Offset: 0x0000148F
		public bool IsReadOnly
		{
			get
			{
				return this.list.IsReadOnly;
			}
		}

		// Token: 0x1700000E RID: 14
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024A7 File Offset: 0x000014A7
		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024B5 File Offset: 0x000014B5
		void IList.Insert(int index, object value)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000024B7 File Offset: 0x000014B7
		void IList.Remove(object value)
		{
			this.Remove(value as Pad);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000024C5 File Offset: 0x000014C5
		bool IList.Contains(object value)
		{
			return this.list.Contains(value);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000024D3 File Offset: 0x000014D3
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000024E0 File Offset: 0x000014E0
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as Pad);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024EE File Offset: 0x000014EE
		int IList.Add(object value)
		{
			return this.Add(value as Pad);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000024FC File Offset: 0x000014FC
		public bool IsFixedSize
		{
			get
			{
				return this.list.IsFixedSize;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002509 File Offset: 0x00001509
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002516 File Offset: 0x00001516
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002523 File Offset: 0x00001523
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002532 File Offset: 0x00001532
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000253F File Offset: 0x0000153F
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000254C File Offset: 0x0000154C
		public int Add(Pad pad)
		{
			return this.list.Add(pad);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000255A File Offset: 0x0000155A
		public void Remove(Pad pad)
		{
			this.list.Remove(pad);
		}

		// Token: 0x17000013 RID: 19
		public Pad this[int index]
		{
			get
			{
				return this.list[index] as Pad;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000257B File Offset: 0x0000157B
		public int IndexOf(Pad pad)
		{
			return this.list.IndexOf(pad);
		}

		// Token: 0x04000012 RID: 18
		private ArrayList list = new ArrayList();
	}
}
