using System;
using System.Collections;
using SmartQuant.FIXData;

namespace SmartQuant.Instruments
{
	// Token: 0x02000018 RID: 24
	public class FundamentalArrayList : ICollection, IEnumerable
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00004C83 File Offset: 0x00003C83
		public FundamentalArrayList()
		{
			this.list = new Hashtable();
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00004C96 File Offset: 0x00003C96
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00004CA3 File Offset: 0x00003CA3
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004CB0 File Offset: 0x00003CB0
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00004CBF File Offset: 0x00003CBF
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00004CCC File Offset: 0x00003CCC
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004CDC File Offset: 0x00003CDC
		public void Clear(bool dataOnly)
		{
            if (dataOnly)
            {
                IEnumerator enumerator = this.list.Values.GetEnumerator();


                while (enumerator.MoveNext())
                {
                    object obj = enumerator.Current;
                    FundamentalArray fundamentalArray = (FundamentalArray)obj;
                    fundamentalArray.Clear();
                }
                return;

            }
			this.list.Clear();
		}

		// Token: 0x17000046 RID: 70
		public FundamentalArray this[Instrument instrument]
		{
			get
			{
				FundamentalArray fundamentalArray = this.list[instrument] as FundamentalArray;
				if (fundamentalArray == null)
				{
					fundamentalArray = new FundamentalArray();
					this.list.Add(instrument, fundamentalArray);
				}
				return fundamentalArray;
			}
		}

		// Token: 0x0400003F RID: 63
		private Hashtable list;
	}
}
