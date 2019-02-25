using System;
using System.Collections;

namespace SmartQuant.Simulation
{
	// Token: 0x0200000A RID: 10
	public class IntervalList : IList, ICollection, IEnumerable
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000276B File Offset: 0x0000176B
		public IntervalList()
		{
			this.intervals = new ArrayList();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000277E File Offset: 0x0000177E
		public bool IsReadOnly
		{
			get
			{
				return this.intervals.IsReadOnly;
			}
		}

		// Token: 0x1700000C RID: 12
		object IList.this[int index]
		{
			get
			{
				return this.intervals[index];
			}
			set
			{
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000279B File Offset: 0x0000179B
		public void RemoveAt(int index)
		{
			this.intervals.RemoveAt(index);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000027A9 File Offset: 0x000017A9
		void IList.Insert(int index, object value)
		{
			this.intervals.Insert(index, value);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000027B8 File Offset: 0x000017B8
		void IList.Remove(object value)
		{
			this.intervals.Remove(value);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000027C6 File Offset: 0x000017C6
		bool IList.Contains(object value)
		{
			return this.intervals.Contains(value);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000027D4 File Offset: 0x000017D4
		public void Clear()
		{
			this.intervals.Clear();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000027E1 File Offset: 0x000017E1
		int IList.IndexOf(object value)
		{
			return this.intervals.IndexOf(value);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000027EF File Offset: 0x000017EF
		int IList.Add(object value)
		{
			return this.intervals.Add(value);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000027FD File Offset: 0x000017FD
		public bool IsFixedSize
		{
			get
			{
				return this.intervals.IsFixedSize;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000280A File Offset: 0x0000180A
		public bool IsSynchronized
		{
			get
			{
				return this.intervals.IsSynchronized;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002817 File Offset: 0x00001817
		public int Count
		{
			get
			{
				return this.intervals.Count;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002824 File Offset: 0x00001824
		public void CopyTo(Array array, int index)
		{
			this.intervals.CopyTo(array, index);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002833 File Offset: 0x00001833
		public object SyncRoot
		{
			get
			{
				return this.intervals.SyncRoot;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002840 File Offset: 0x00001840
		public IEnumerator GetEnumerator()
		{
			return this.intervals.GetEnumerator();
		}

		// Token: 0x17000011 RID: 17
		public Interval this[int index]
		{
			get
			{
				return this.intervals[index] as Interval;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002860 File Offset: 0x00001860
		public void Remove(Interval interval)
		{
			this.intervals.Remove(interval);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000286E File Offset: 0x0000186E
		public bool Contains(Interval interval)
		{
			return this.intervals.Contains(interval);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000287C File Offset: 0x0000187C
		public int IndexOf(Interval interval)
		{
			return this.intervals.IndexOf(interval);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000288A File Offset: 0x0000188A
		public int Add(Interval interval)
		{
			return this.intervals.Add(interval);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002898 File Offset: 0x00001898
		public int Add(DateTime begin, DateTime end)
		{
			return this.Add(new Interval(begin, end));
		}

		// Token: 0x04000019 RID: 25
		private ArrayList intervals;
	}
}
