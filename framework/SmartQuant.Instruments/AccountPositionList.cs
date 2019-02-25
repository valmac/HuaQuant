using System;
using System.Collections;

namespace SmartQuant.Instruments
{
	// Token: 0x0200000C RID: 12
	public class AccountPositionList : IEnumerable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002474 File Offset: 0x00001474
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002494 File Offset: 0x00001494
		public void Add(AccountPosition position)
		{
			if (this.fList.Contains(position.Currency.Code))
			{
				throw new ApplicationException("Can not add account position for currency that is already present in the list : " + position.Currency);
			}
			this.fList.Add(position.Currency.Code, position);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024E6 File Offset: 0x000014E6
		public void Remove(AccountPosition position)
		{
			this.fList.Remove(position.Currency.Code);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024FE File Offset: 0x000014FE
		public void RemoveAt(int index)
		{
			this.fList.RemoveAt(index);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000250C File Offset: 0x0000150C
		public void Clear()
		{
			this.fList.Clear();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002519 File Offset: 0x00001519
		public bool Contains(Currency currency)
		{
			return this.fList.Contains(currency.Code);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000252C File Offset: 0x0000152C
		public bool Contains(AccountPosition position)
		{
			return this.fList.ContainsValue(position);
		}

		// Token: 0x1700000A RID: 10
		public AccountPosition this[int index]
		{
			get
			{
				return this.fList.GetByIndex(index) as AccountPosition;
			}
		}

		// Token: 0x1700000B RID: 11
		public AccountPosition this[Currency currency]
		{
			get
			{
				return this.fList[currency.Code] as AccountPosition;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002565 File Offset: 0x00001565
		public IEnumerator GetEnumerator()
		{
			return this.fList.Values.GetEnumerator();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002578 File Offset: 0x00001578
		public override string ToString()
		{
			string text = "";
			foreach (object obj in this.fList.Values)
			{
				AccountPosition accountPosition = (AccountPosition)obj;
				text = text + accountPosition.ToString() + Environment.NewLine;
			}
			return text;
		}

		// Token: 0x04000008 RID: 8
		private SortedList fList = new SortedList();
	}
}
