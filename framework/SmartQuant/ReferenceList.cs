using System;
using System.Collections;

namespace SmartQuant
{
	// Token: 0x02000018 RID: 24
	public class ReferenceList : ReadOnlyCollectionBase
	{
		// Token: 0x060000AF RID: 175 RVA: 0x000040D9 File Offset: 0x000030D9
		internal ReferenceList()
		{
		}

		// Token: 0x17000041 RID: 65
		public Reference this[int index]
		{
			get
			{
				return base.InnerList[index] as Reference;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000040F4 File Offset: 0x000030F4
		internal void Add(Reference reference)
		{
			base.InnerList.Add(reference);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004103 File Offset: 0x00003103
		internal void Remove(Reference reference)
		{
			base.InnerList.Remove(reference);
		}
	}
}
