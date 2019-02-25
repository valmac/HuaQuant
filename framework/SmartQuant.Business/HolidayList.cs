using System;
using System.Collections;

namespace SmartQuant.Business
{
	// Token: 0x02000003 RID: 3
	public class HolidayList : IEnumerable
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000022EB File Offset: 0x000012EB
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002318 File Offset: 0x00001318
		public void Add(Holiday holiday)
		{
			if (this.fList.Contains(holiday.Date))
			{
				throw new ApplicationException("Can not add holiday that is already present in the list : " + holiday.Date);
			}
			this.fList.Add(holiday.Date, holiday);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000236F File Offset: 0x0000136F
		public void Remove(Holiday holiday)
		{
			this.fList.Remove(holiday.Date);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002387 File Offset: 0x00001387
		public void RemoveAt(int index)
		{
			this.Remove(this[index]);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002396 File Offset: 0x00001396
		public void Clear()
		{
			this.fList.Clear();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023A3 File Offset: 0x000013A3
		public bool Contains(DateTime date)
		{
			return this.fList.Contains(date);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000023B6 File Offset: 0x000013B6
		public bool Contains(Holiday holiday)
		{
			return this.fList.ContainsValue(holiday);
		}

		// Token: 0x17000005 RID: 5
		public Holiday this[int index]
		{
			get
			{
				return this.fList.GetByIndex(index) as Holiday;
			}
		}

		// Token: 0x17000006 RID: 6
		public Holiday this[DateTime date]
		{
			get
			{
				return this.fList[date] as Holiday;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000023EF File Offset: 0x000013EF
		public IEnumerator GetEnumerator()
		{
			return this.fList.Values.GetEnumerator();
		}

		// Token: 0x04000004 RID: 4
		private SortedList fList = new SortedList();

		// Token: 0x04000005 RID: 5
		private Hashtable fId = new Hashtable();
	}
}
