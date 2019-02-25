using System;
using System.Collections;
using SmartQuant.FIXData;

namespace SmartQuant.Instruments
{
	// Token: 0x0200004C RID: 76
	public class CorporateActionArrayList : ICollection, IEnumerable
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0000C71F File Offset: 0x0000B71F
		public CorporateActionArrayList()
		{
			this.list = new Hashtable();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000C732 File Offset: 0x0000B732
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000C73F File Offset: 0x0000B73F
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000C74C File Offset: 0x0000B74C
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000C75B File Offset: 0x0000B75B
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C768 File Offset: 0x0000B768
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C778 File Offset: 0x0000B778
		public void Clear(bool dataOnly)
		{
            if (dataOnly)
            {
                IEnumerator enumerator = this.list.Values.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    object obj = enumerator.Current;
                    CorporateActionArray corporateActionArray = (CorporateActionArray)obj;
                    corporateActionArray.Clear();
                }
                return;

            }
			this.list.Clear();
		}

		// Token: 0x170000D7 RID: 215
		public CorporateActionArray this[Instrument instrument]
		{
			get
			{
				CorporateActionArray corporateActionArray = this.list[instrument] as CorporateActionArray;
				if (corporateActionArray == null)
				{
					corporateActionArray = new CorporateActionArray();
					this.list.Add(instrument, corporateActionArray);
				}
				return corporateActionArray;
			}
		}

		// Token: 0x0400010A RID: 266
		private Hashtable list;
	}
}
