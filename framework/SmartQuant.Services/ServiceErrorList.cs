using System;
using System.Collections;

namespace SmartQuant.Services
{
	// Token: 0x02000016 RID: 22
	public class ServiceErrorList : ICollection, IEnumerable
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002B90 File Offset: 0x00001B90
		internal ServiceErrorList()
		{
			this.list = new ArrayList();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002BA3 File Offset: 0x00001BA3
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002BB2 File Offset: 0x00001BB2
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002BBF File Offset: 0x00001BBF
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002BCC File Offset: 0x00001BCC
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002BD9 File Offset: 0x00001BD9
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002BE6 File Offset: 0x00001BE6
		internal void Add(ServiceError error)
		{
			this.list.Add(error);
		}

		// Token: 0x0400001B RID: 27
		private ArrayList list;
	}
}
