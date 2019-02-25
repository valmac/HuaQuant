using System;
using System.Collections;

namespace SmartQuant.Data
{
	// Token: 0x02000008 RID: 8
	public class DataSeriesList : IList, ICollection, IEnumerable
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002787 File Offset: 0x00001787
		public DataSeriesList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000279A File Offset: 0x0000179A
		public bool IsReadOnly
		{
			get
			{
				return this.list.IsReadOnly;
			}
		}

		// Token: 0x1700000B RID: 11
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (value as IDataSeries);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000027BF File Offset: 0x000017BF
		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000027CD File Offset: 0x000017CD
		void IList.Insert(int index, object value)
		{
			this.Insert(index, value as IDataSeries);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027DC File Offset: 0x000017DC
		void IList.Remove(object value)
		{
			this.Remove(value as IDataSeries);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027EA File Offset: 0x000017EA
		bool IList.Contains(object value)
		{
			return this.Contains(value as IDataSeries);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027F8 File Offset: 0x000017F8
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002805 File Offset: 0x00001805
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as IDataSeries);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002813 File Offset: 0x00001813
		int IList.Add(object value)
		{
			return this.Add(value as IDataSeries);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002821 File Offset: 0x00001821
		public bool IsFixedSize
		{
			get
			{
				return this.list.IsFixedSize;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000282E File Offset: 0x0000182E
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000283B File Offset: 0x0000183B
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002848 File Offset: 0x00001848
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002857 File Offset: 0x00001857
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002864 File Offset: 0x00001864
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x17000010 RID: 16
		public IDataSeries this[int index]
		{
			get
			{
				return this.list[index] as IDataSeries;
			}
			set
			{
				this.list[index] = value;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002893 File Offset: 0x00001893
		public void Insert(int index, IDataSeries series)
		{
			this.list.Insert(index, series);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000028A2 File Offset: 0x000018A2
		public void Remove(IDataSeries series)
		{
			this.list.Remove(series);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000028B0 File Offset: 0x000018B0
		public bool Contains(IDataSeries series)
		{
			return this.list.Contains(series);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000028BE File Offset: 0x000018BE
		public int IndexOf(IDataSeries series)
		{
			return this.list.IndexOf(series);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000028CC File Offset: 0x000018CC
		public int Add(IDataSeries series)
		{
			return this.list.Add(series);
		}

		// Token: 0x0400000E RID: 14
		private ArrayList list;
	}
}
