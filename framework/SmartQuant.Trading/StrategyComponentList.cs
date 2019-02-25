using System;
using System.Collections;
using System.IO;

namespace SmartQuant.Trading
{
	// Token: 0x02000059 RID: 89
	public class StrategyComponentList : ICollection, IEnumerable
	{
		// Token: 0x0600038D RID: 909 RVA: 0x0000E837 File Offset: 0x0000D837
		public StrategyComponentList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000E84A File Offset: 0x0000D84A
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000E857 File Offset: 0x0000D857
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000E864 File Offset: 0x0000D864
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000E873 File Offset: 0x0000D873
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000E880 File Offset: 0x0000D880
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000E890 File Offset: 0x0000D890
		public ComponentRecord FindRecord(Guid guid)
		{
			foreach (object obj in this.list)
			{
				ComponentRecord componentRecord = (ComponentRecord)obj;
				if (componentRecord.GUID == guid)
				{
					return componentRecord;
				}
			}
			return null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000E8F8 File Offset: 0x0000D8F8
		public ComponentRecord[] FindRecords(FileInfo file)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.list)
			{
				ComponentRecord componentRecord = (ComponentRecord)obj;
				if (!componentRecord.BuiltIn && componentRecord.File.FullName.ToLower() == file.FullName.ToLower())
				{
					arrayList.Add(componentRecord);
				}
			}
			return arrayList.ToArray(typeof(ComponentRecord)) as ComponentRecord[];
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E998 File Offset: 0x0000D998
		internal void Add(ComponentRecord record)
		{
			this.list.Add(record);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000E9A7 File Offset: 0x0000D9A7
		internal void Remove(ComponentRecord record)
		{
			this.list.Remove(record);
		}

		// Token: 0x04000127 RID: 295
		private ArrayList list;
	}
}
