using System;
using System.Collections;

namespace SmartQuant.Instruments
{
	// Token: 0x0200001C RID: 28
	public class CurrencyList : IEnumerable
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000638F File Offset: 0x0000538F
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000063AF File Offset: 0x000053AF
		public void Add(Currency currency)
		{
			if (this.fList.Contains(currency.Code))
			{
				throw new ApplicationException("Can not add currency that is already present in the list : " + currency.Code);
			}
			this.fList.Add(currency.Code, currency);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000063EC File Offset: 0x000053EC
		public void Remove(Currency currency)
		{
			this.fList.Remove(currency.Code);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000063FF File Offset: 0x000053FF
		public void RemoveAt(int index)
		{
			this.Remove(this[index]);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000640E File Offset: 0x0000540E
		public void Clear()
		{
			this.fList.Clear();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000641B File Offset: 0x0000541B
		public bool Contains(string code)
		{
			return this.fList.Contains(code);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006429 File Offset: 0x00005429
		public bool Contains(Currency currency)
		{
			return this.fList.ContainsValue(currency);
		}

		// Token: 0x17000056 RID: 86
		public Currency this[int index]
		{
			get
			{
				return this.fList.GetByIndex(index) as Currency;
			}
		}

		// Token: 0x17000057 RID: 87
		public Currency this[string code]
		{
			get
			{
				return this.fList[code] as Currency;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000645D File Offset: 0x0000545D
		public IEnumerator GetEnumerator()
		{
			return this.fList.Values.GetEnumerator();
		}

		// Token: 0x0400006B RID: 107
		private SortedList fList = new SortedList();
	}
}
