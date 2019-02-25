using System;
using System.Collections;

namespace SmartQuant.Instruments
{
	// Token: 0x02000038 RID: 56
	public class PortfolioList : IEnumerable
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000A5CC File Offset: 0x000095CC
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000A5D9 File Offset: 0x000095D9
		internal PortfolioList()
		{
			this.list = new SortedList();
			this.ids = new Hashtable();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A5F8 File Offset: 0x000095F8
		internal void Add(Portfolio portfolio)
		{
			if (this.list.Contains(portfolio.Name))
			{
				throw new ApplicationException("Can not add portfolio that is already present in the list : " + portfolio.Name);
			}
			this.list.Add(portfolio.Name, portfolio);
			if (portfolio.Id != -1)
			{
				if (this.ids.Contains(portfolio.Id))
				{
					throw new ApplicationException("Can not add portfolio that is already present in the list : " + portfolio.Id);
				}
				this.ids.Add(portfolio.Id, portfolio);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000A693 File Offset: 0x00009693
		internal void Remove(Portfolio portfolio)
		{
			this.list.Remove(portfolio.Name);
			this.ids.Remove(portfolio.Id);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000A6BC File Offset: 0x000096BC
		public Portfolio GetById(int id)
		{
			return this.ids[id] as Portfolio;
		}

		// Token: 0x170000BB RID: 187
		public Portfolio this[string name]
		{
			get
			{
				return this.list[name] as Portfolio;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000A6E7 File Offset: 0x000096E7
		public bool Contains(string name)
		{
			return this.list.ContainsKey(name);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000A6F8 File Offset: 0x000096F8
		public void Rename(string oldName, string newName)
		{
			Portfolio portfolio = this[oldName];
			portfolio.Name = newName;
			this.list.Remove(oldName);
			this.list.Add(newName, portfolio);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000A72D File Offset: 0x0000972D
		public IEnumerator GetEnumerator()
		{
			return this.list.Values.GetEnumerator();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000A73F File Offset: 0x0000973F
		public static implicit operator Portfolio[](PortfolioList list)
		{
			return new ArrayList(list.list.Values).ToArray(typeof(Portfolio)) as Portfolio[];
		}

		// Token: 0x040000CA RID: 202
		private SortedList list;

		// Token: 0x040000CB RID: 203
		private Hashtable ids;
	}
}
