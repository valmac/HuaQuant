using System;
using System.Collections;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x0200001D RID: 29
	public class TesterItemList : ICollection, IEnumerable
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000B1 RID: 177 RVA: 0x00004F13 File Offset: 0x00003F13
		// (remove) Token: 0x060000B2 RID: 178 RVA: 0x00004F2C File Offset: 0x00003F2C
		public event EventHandler ComponentListChanged;

		// Token: 0x060000B3 RID: 179 RVA: 0x00004F45 File Offset: 0x00003F45
		public TesterItemList()
		{
			this.list = new SortedList();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004F58 File Offset: 0x00003F58
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00004F60 File Offset: 0x00003F60
		public bool ActivateItemOnRequest
		{
			get
			{
				return this.activateItemOnRequest;
			}
			set
			{
				this.activateItemOnRequest = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004F69 File Offset: 0x00003F69
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004F76 File Offset: 0x00003F76
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004F83 File Offset: 0x00003F83
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004F92 File Offset: 0x00003F92
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004F9F File Offset: 0x00003F9F
		public IEnumerator GetEnumerator()
		{
			return this.list.Values.GetEnumerator();
		}

		// Token: 0x1700001A RID: 26
		public TesterItem this[string name]
		{
			get
			{
				TesterItem testerItem = this.list[name] as TesterItem;
				if (this.activateItemOnRequest && testerItem is SeriesTesterItem)
				{
					(testerItem as SeriesTesterItem).Enabled = true;
				}
				return testerItem;
			}
		}

		// Token: 0x1700001B RID: 27
		public TesterItem this[int index]
		{
			get
			{
				TesterItem testerItem = this.list.GetByIndex(index) as TesterItem;
				if (this.activateItemOnRequest && testerItem is SeriesTesterItem)
				{
					(testerItem as SeriesTesterItem).Enabled = true;
				}
				return testerItem;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000502C File Offset: 0x0000402C
		internal void Add(TesterItem item)
		{
			this.list.Remove(item.Name);
			this.list.Add(item.Name, item);
			item.ComponentNameChanged += this.item_ComponentNameChanged;
			this.EmitComponentListChanged();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000506C File Offset: 0x0000406C
		internal void Remove(string name)
		{
			if (this.list.Contains(name))
			{
				TesterItem testerItem = this.list[name] as TesterItem;
				this.list.Remove(name);
				testerItem.ComponentNameChanged -= this.item_ComponentNameChanged;
				this.EmitComponentListChanged();
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000050C0 File Offset: 0x000040C0
		internal void Clear()
		{
			foreach (object obj in this.list)
			{
				TesterItem testerItem = (TesterItem)obj;
				this.Remove(testerItem.Name);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005120 File Offset: 0x00004120
		public bool Contains(string name)
		{
			return this.list.ContainsKey(name);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000512E File Offset: 0x0000412E
		private void item_ComponentNameChanged(TesterItem component, ComponentNameEventArgs args)
		{
			this.list.Remove(args.OldName);
			this.list.Add(args.NewName, component);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005153 File Offset: 0x00004153
		private void EmitComponentListChanged()
		{
			if (this.ComponentListChanged != null)
			{
				this.ComponentListChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0400002F RID: 47
		private SortedList list;

		// Token: 0x04000030 RID: 48
		private bool activateItemOnRequest;
	}
}
