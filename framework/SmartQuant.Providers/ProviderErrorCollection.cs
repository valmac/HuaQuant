using System;
using System.Collections;

namespace SmartQuant.Providers
{
	// Token: 0x0200002B RID: 43
	public class ProviderErrorCollection : ICollection, IEnumerable
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000355F File Offset: 0x0000255F
		internal ProviderErrorCollection()
		{
			this.errors = new ArrayList();
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003572 File Offset: 0x00002572
		public bool IsSynchronized
		{
			get
			{
				return this.errors.IsSynchronized;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000357F File Offset: 0x0000257F
		public int Count
		{
			get
			{
				return this.errors.Count;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000358C File Offset: 0x0000258C
		public void CopyTo(Array array, int index)
		{
			this.errors.CopyTo(array, index);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000359B File Offset: 0x0000259B
		public object SyncRoot
		{
			get
			{
				return this.errors.SyncRoot;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000035A8 File Offset: 0x000025A8
		public IEnumerator GetEnumerator()
		{
			return this.errors.GetEnumerator();
		}

		// Token: 0x17000037 RID: 55
		public ProviderError this[int index]
		{
			get
			{
				return this.errors[index] as ProviderError;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000035C8 File Offset: 0x000025C8
		internal void Add(ProviderError error)
		{
			this.errors.Add(error);
		}

		// Token: 0x04000058 RID: 88
		private ArrayList errors;
	}
}
