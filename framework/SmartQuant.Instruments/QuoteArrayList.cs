using System;
using System.Collections;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x0200000F RID: 15
	public class QuoteArrayList : ICollection, IEnumerable
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002854 File Offset: 0x00001854
		public QuoteArrayList()
		{
			this.list = new Hashtable();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002867 File Offset: 0x00001867
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002874 File Offset: 0x00001874
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002881 File Offset: 0x00001881
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002890 File Offset: 0x00001890
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000289D File Offset: 0x0000189D
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000028AC File Offset: 0x000018AC
		public void Clear(bool dataOnly)
		{
            if (dataOnly)
            {
                IEnumerator enumerator = this.list.Values.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    object obj = enumerator.Current;
                    QuoteArray quoteArray = (QuoteArray)obj;
                    quoteArray.Clear();
                }
                return;

            }
			this.list.Clear();
		}

		// Token: 0x17000013 RID: 19
		public QuoteArray this[Instrument instrument]
		{
			get
			{
				QuoteArray quoteArray = this.list[instrument] as QuoteArray;
				if (quoteArray == null)
				{
					quoteArray = new QuoteArray();
					this.list.Add(instrument, quoteArray);
				}
				return quoteArray;
			}
		}

		// Token: 0x0400000C RID: 12
		private Hashtable list;
	}
}
