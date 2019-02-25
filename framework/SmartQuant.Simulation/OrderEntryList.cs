using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Simulation.Design;

namespace SmartQuant.Simulation
{
	// Token: 0x02000019 RID: 25
	[Editor(typeof(OrderEntryListEditor), typeof(UITypeEditor))]
	public class OrderEntryList : ICollection, IEnumerable
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00005972 File Offset: 0x00004972
		internal OrderEntryList()
		{
			this.entries = new SortedList<DateTime, List<OrderEntry>>();
			this.list = new List<OrderEntry>();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005990 File Offset: 0x00004990
		public void CopyTo(Array array, int index)
		{
			this.list.ToArray().CopyTo(array, index);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000059A4 File Offset: 0x000049A4
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000059B1 File Offset: 0x000049B1
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000059B4 File Offset: 0x000049B4
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000059B7 File Offset: 0x000049B7
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000059C9 File Offset: 0x000049C9
		public void Clear()
		{
			this.entries.Clear();
			this.SynchronizeList();
		}

		// Token: 0x1700002E RID: 46
		public OrderEntry[] this[DateTime datetime]
		{
			get
			{
				List<OrderEntry> list;
				if (this.entries.TryGetValue(datetime, out list))
				{
					return list.ToArray();
				}
				return new OrderEntry[0];
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005A06 File Offset: 0x00004A06
		public OrderEntry[] GetByIndex(int index)
		{
			return this[this.entries.Keys[0]];
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005A20 File Offset: 0x00004A20
		public void Add(OrderEntry entry)
		{
			List<OrderEntry> list;
			if (!this.entries.TryGetValue(entry.DateTime, out list))
			{
				list = new List<OrderEntry>();
				this.entries.Add(entry.DateTime, list);
			}
			list.Add(entry);
			this.SynchronizeList();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005A68 File Offset: 0x00004A68
		private void SynchronizeList()
		{
			this.list.Clear();
			foreach (List<OrderEntry> list in this.entries.Values)
			{
				foreach (OrderEntry item in list)
				{
					this.list.Add(item);
				}
			}
		}

		// Token: 0x04000075 RID: 117
		private SortedList<DateTime, List<OrderEntry>> entries;

		// Token: 0x04000076 RID: 118
		private List<OrderEntry> list;
	}
}
