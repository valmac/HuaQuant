using System;
using System.Collections;

namespace SmartQuant.Data
{
	// Token: 0x02000009 RID: 9
	public class DataArray : IEnumerable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000039 RID: 57 RVA: 0x000028DA File Offset: 0x000018DA
		// (remove) Token: 0x0600003A RID: 58 RVA: 0x000028F3 File Offset: 0x000018F3
		public event EventHandler Cleared;

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000290C File Offset: 0x0000190C
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002943 File Offset: 0x00001943
		public void Add(IDataObject obj)
		{
			this.fList.Add(obj);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002952 File Offset: 0x00001952
		public void Insert(int index, IDataObject obj)
		{
			this.fList.Insert(index, obj);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002961 File Offset: 0x00001961
		public void Remove(IDataObject obj)
		{
			this.fList.Remove(obj);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000296F File Offset: 0x0000196F
		public void RemoveAt(int index)
		{
			this.fList.RemoveAt(index);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000297D File Offset: 0x0000197D
		public void Clear()
		{
			this.fList.Clear();
			this.EmitCleared();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002990 File Offset: 0x00001990
		public bool Contains(IDataObject obj)
		{
			return this.fList.Contains(obj);
		}

		// Token: 0x17000012 RID: 18
		public IDataObject this[int index]
		{
			get
			{
				return this.fList[index] as IDataObject;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000029B1 File Offset: 0x000019B1
		public IEnumerator GetEnumerator()
		{
			return this.fList.GetEnumerator();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000029BE File Offset: 0x000019BE
		public DateTime FirstDateTime
		{
			get
			{
				if (this.Count != 0)
				{
					return this[0].DateTime;
				}
				return new DateTime(0L);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000029DC File Offset: 0x000019DC
		public DateTime LastDateTime
		{
			get
			{
				if (this.Count != 0)
				{
					return this[this.Count - 1].DateTime;
				}
				return new DateTime(0L);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002A04 File Offset: 0x00001A04
		public int GetIndex(DateTime datetime)
		{
			if (this.Count == 0)
			{
				return -1;
			}
			DateTime dateTime = this[0].DateTime;
			DateTime dateTime2 = this[this.Count - 1].DateTime;
			if (dateTime > datetime || dateTime2 < datetime)
			{
				return -1;
			}
			return this.GetIndex(datetime, 0, this.Count - 1);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002A60 File Offset: 0x00001A60
		public int GetIndex(DateTime datetime, int index1, int index2)
		{
			long ticks = this[index1].DateTime.Ticks;
			long ticks2 = this[index2].DateTime.Ticks;
			long ticks3 = datetime.Ticks;
			int num;
			if (ticks2 != ticks)
			{
				num = (int)((long)index1 + (long)(index2 - index1) * ((ticks3 - ticks) / (ticks2 - ticks)));
			}
			else
			{
				num = (index1 + index2) / 2;
			}
			IDataObject dataObject = this[num];
			if (dataObject.DateTime == datetime)
			{
				return num;
			}
			if (index2 - num < this.fStopRecurant || num - index1 < this.fStopRecurant)
			{
				for (int i = index2; i >= index1; i--)
				{
					dataObject = this[i];
					if (dataObject.DateTime < datetime)
					{
						return i;
					}
				}
				return -1;
			}
			int num2 = (int)((double)(index2 - index1) / this.fDivisor);
			int num3 = Math.Max(index1, num - num2);
			dataObject = this[num3];
			if (dataObject.DateTime > datetime)
			{
				return this.GetIndex(datetime, index1, num3);
			}
			int num4 = Math.Min(index2, num + num2);
			dataObject = this[num4];
			if (dataObject.DateTime < datetime)
			{
				return this.GetIndex(datetime, num4, index2);
			}
			return this.GetIndex(datetime, num3, num4);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B95 File Offset: 0x00001B95
		private void EmitCleared()
		{
			if (this.Cleared != null)
			{
				this.Cleared(this, EventArgs.Empty);
			}
		}

		// Token: 0x04000010 RID: 16
		protected int fStopRecurant = 25;

		// Token: 0x04000011 RID: 17
		protected double fDivisor = 10.0;

		// Token: 0x04000012 RID: 18
		protected ArrayList fList = new ArrayList();
	}
}
