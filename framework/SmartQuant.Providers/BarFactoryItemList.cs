using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Data;
using SmartQuant.Providers.Design;

namespace SmartQuant.Providers
{
	// Token: 0x0200004C RID: 76
	[Editor(typeof(BarFactoryItemListEditor), typeof(UITypeEditor))]
	public class BarFactoryItemList : IList, ICollection, IEnumerable
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0000521D File Offset: 0x0000421D
		public BarFactoryItemList()
		{
			this.items = new ArrayList();
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00005230 File Offset: 0x00004230
		public bool IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		// Token: 0x17000074 RID: 116
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000524D File Offset: 0x0000424D
		public void RemoveAt(int index)
		{
			this.items.RemoveAt(index);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000525B File Offset: 0x0000425B
		public void Insert(int index, object value)
		{
			this.items.Insert(index, value);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000526A File Offset: 0x0000426A
		public void Remove(object value)
		{
			this.items.Remove(value);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005278 File Offset: 0x00004278
		public bool Contains(object value)
		{
			return this.items.Contains(value);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005286 File Offset: 0x00004286
		public void Clear()
		{
			this.items.Clear();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005293 File Offset: 0x00004293
		public int IndexOf(object value)
		{
			return this.items.IndexOf(value);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000052A1 File Offset: 0x000042A1
		int IList.Add(object value)
		{
			return this.Add(value as BarFactoryItem);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000052AF File Offset: 0x000042AF
		public bool IsFixedSize
		{
			get
			{
				return this.items.IsFixedSize;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000052BC File Offset: 0x000042BC
		public bool IsSynchronized
		{
			get
			{
				return this.items.IsSynchronized;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000052C9 File Offset: 0x000042C9
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000052D6 File Offset: 0x000042D6
		public void CopyTo(Array array, int index)
		{
			this.items.CopyTo(array, index);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000052E5 File Offset: 0x000042E5
		public object SyncRoot
		{
			get
			{
				return this.items.SyncRoot;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000052F2 File Offset: 0x000042F2
		public IEnumerator GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000052FF File Offset: 0x000042FF
		public int Add(BarFactoryItem item)
		{
			this.items.Add(item);
			this.items.Sort();
			return this.items.IndexOf(item);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00005325 File Offset: 0x00004325
		public int Add(BarType barType, long barSize, bool enabled)
		{
			return this.Add(new BarFactoryItem(barType, barSize, enabled));
		}

		// Token: 0x17000079 RID: 121
		public BarFactoryItem this[int index]
		{
			get
			{
				return this.items[index] as BarFactoryItem;
			}
		}

		// Token: 0x040000B4 RID: 180
		private ArrayList items;
	}
}
