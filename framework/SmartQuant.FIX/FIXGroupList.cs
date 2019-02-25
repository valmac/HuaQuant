using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200000E RID: 14
	public class FIXGroupList : IList, ICollection, IEnumerable
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00007167 File Offset: 0x00006167
		public bool IsReadOnly
		{
			get
			{
				return this.fList.IsReadOnly;
			}
		}

		// Token: 0x17000225 RID: 549
		object IList.this[int index]
		{
			get
			{
				return this.fList[index];
			}
			set
			{
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00007184 File Offset: 0x00006184
		public void RemoveAt(int index)
		{
			this.Remove(this[index]);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00007193 File Offset: 0x00006193
		void IList.Insert(int index, object value)
		{
			this.Insert(index, value as FIXGroup);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000071A2 File Offset: 0x000061A2
		void IList.Remove(object value)
		{
			this.Remove(value as FIXGroup);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000071B0 File Offset: 0x000061B0
		bool IList.Contains(object value)
		{
			return this.Contains(value as FIXGroup);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000071BE File Offset: 0x000061BE
		public virtual void Clear()
		{
			this.fList.Clear();
			this.fId.Clear();
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000071D6 File Offset: 0x000061D6
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as FIXGroup);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000071E4 File Offset: 0x000061E4
		int IList.Add(object value)
		{
			return this.Add(value as FIXGroup);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000071F2 File Offset: 0x000061F2
		public bool IsFixedSize
		{
			get
			{
				return this.fList.IsFixedSize;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000071FF File Offset: 0x000061FF
		public bool IsSynchronized
		{
			get
			{
				return this.fList.IsSynchronized;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000720C File Offset: 0x0000620C
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00007219 File Offset: 0x00006219
		public void CopyTo(Array array, int index)
		{
			this.fList.CopyTo(array, index);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00007228 File Offset: 0x00006228
		public object SyncRoot
		{
			get
			{
				return this.fList.SyncRoot;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00007235 File Offset: 0x00006235
		public virtual IEnumerator GetEnumerator()
		{
			return this.fList.GetEnumerator();
		}

		// Token: 0x1700022A RID: 554
		public FIXGroup this[int index]
		{
			get
			{
				return this.fList[index] as FIXGroup;
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00007255 File Offset: 0x00006255
		public FIXGroup GetById(int id)
		{
			return this.fId[id] as FIXGroup;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00007270 File Offset: 0x00006270
		public int Add(FIXGroup group)
		{
			if (group.Id != -1)
			{
				if (this.fId.ContainsKey(group.Id))
				{
					throw new ApplicationException("Can not add group with Id that is already present in this list : " + group.Id);
				}
				this.fId.Add(group.Id, group);
			}
			return this.fList.Add(group);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000072DC File Offset: 0x000062DC
		public void Remove(FIXGroup group)
		{
			this.fList.Remove(group);
			this.fId.Remove(group.Id);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00007300 File Offset: 0x00006300
		public void RegisterById(FIXGroup group)
		{
			if (this.fId.ContainsKey(group.Id))
			{
				throw new ApplicationException("Can not add group with Id that is already present in this list : " + group.Id);
			}
			this.fId.Add(group.Id, group);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00007357 File Offset: 0x00006357
		public bool Contains(FIXGroup group)
		{
			return this.fList.Contains(group);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00007365 File Offset: 0x00006365
		public bool Contains(int groupId)
		{
			return this.fId.ContainsKey(groupId);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00007378 File Offset: 0x00006378
		public int IndexOf(FIXGroup group)
		{
			return this.fList.IndexOf(group);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00007388 File Offset: 0x00006388
		public void Insert(int index, FIXGroup group)
		{
			if (this.Contains(group))
			{
				throw new ApplicationException("Can not insert group with Id that is already present in this list : " + group.Id);
			}
			this.fList.Insert(index, group);
			this.fId.Add(group.Id, group);
		}

		// Token: 0x04000031 RID: 49
		protected ArrayList fList = new ArrayList();

		// Token: 0x04000032 RID: 50
		protected Hashtable fId = new Hashtable();
	}
}
