using System;
using System.Collections;

namespace SmartQuant.Providers
{
	// Token: 0x0200001F RID: 31
	public class ProviderList : ICollection, IEnumerable
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x000030CA File Offset: 0x000020CA
		public ProviderList()
		{
			this.fList = new SortedList();
			this.fId = new SortedList();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000030E8 File Offset: 0x000020E8
		public bool IsSynchronized
		{
			get
			{
				return this.fList.IsSynchronized;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000030F5 File Offset: 0x000020F5
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003102 File Offset: 0x00002102
		public void CopyTo(Array array, int index)
		{
			this.fList.CopyTo(array, index);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003111 File Offset: 0x00002111
		public object SyncRoot
		{
			get
			{
				return this.fList.SyncRoot;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000311E File Offset: 0x0000211E
		public IEnumerator GetEnumerator()
		{
			return this.fList.Values.GetEnumerator();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003130 File Offset: 0x00002130
		internal void Add(IProvider provider)
		{
			if (this.fList.ContainsKey(provider.Name))
			{
				throw new ArgumentException("Can not add provider with name that is already present in the list : " + provider.Name);
			}
			if (this.fId.Contains(provider.Id))
			{
				throw new ArgumentException("Can not add provider with id that is already present in the list : " + provider.Id);
			}
			this.fList.Add(provider.Name, provider);
			this.fId.Add(provider.Id, provider);
		}

		// Token: 0x17000029 RID: 41
		public IProvider this[string name]
		{
			get
			{
				return this.fList[name] as IProvider;
			}
		}

		// Token: 0x1700002A RID: 42
		public IProvider this[byte id]
		{
			get
			{
				return this.fId[id] as IProvider;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000031ED File Offset: 0x000021ED
		public bool Contains(string name)
		{
			return this.fList.ContainsKey(name);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000031FB File Offset: 0x000021FB
		public bool Contains(byte id)
		{
			return this.fId.ContainsKey(id);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000320E File Offset: 0x0000220E
		public bool Contains(IProvider provider)
		{
			return this.fList.ContainsValue(provider);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000321C File Offset: 0x0000221C
		public static implicit operator IProvider[](ProviderList list)
		{
			return new ArrayList(list.fList.Values).ToArray(typeof(IProvider)) as IProvider[];
		}

		// Token: 0x0400004F RID: 79
		private SortedList fList;

		// Token: 0x04000050 RID: 80
		private SortedList fId;
	}
}
