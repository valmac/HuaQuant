using System;
using System.Collections;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x02000045 RID: 69
	public class TradeArrayList : ICollection, IEnumerable
	{
		// Token: 0x06000379 RID: 889 RVA: 0x0000B7E4 File Offset: 0x0000A7E4
		public TradeArrayList()
		{
			this.list = new Hashtable();
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000B7F7 File Offset: 0x0000A7F7
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000B804 File Offset: 0x0000A804
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000B811 File Offset: 0x0000A811
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000B820 File Offset: 0x0000A820
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000B82D File Offset: 0x0000A82D
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000B83C File Offset: 0x0000A83C
		public void Clear(bool dataOnly)
		{
            if (dataOnly)
            {
                IEnumerator enumerator = this.list.Values.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    object obj = enumerator.Current;
                    TradeArray tradeArray = (TradeArray)obj;
                    tradeArray.Clear();
                }
                return;

            }
			this.list.Clear();
		}

		// Token: 0x170000D0 RID: 208
		public TradeArray this[Instrument instrument]
		{
			get
			{
				TradeArray tradeArray = this.list[instrument] as TradeArray;
				if (tradeArray == null)
				{
					tradeArray = new TradeArray();
					this.list.Add(instrument, tradeArray);
				}
				return tradeArray;
			}
		}

		// Token: 0x040000FE RID: 254
		private Hashtable list;
	}
}
