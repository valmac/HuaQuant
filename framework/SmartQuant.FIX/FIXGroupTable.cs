using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000B7 RID: 183
	public class FIXGroupTable : IEnumerable
	{
		// Token: 0x060025F9 RID: 9721 RVA: 0x00028970 File Offset: 0x00027970
		public void Add(FIXGroup group)
		{
			ArrayList arrayList = this[group.Tag];
			if (arrayList == null)
			{
				arrayList = new ArrayList();
				this.fTable.Add(group.Tag, arrayList);
			}
			arrayList.Add(group);
		}

		// Token: 0x17001127 RID: 4391
		public ArrayList this[int tag]
		{
			get
			{
				return this.fTable[tag] as ArrayList;
			}
		}

		// Token: 0x17001128 RID: 4392
		public ArrayList this[FIXGroup group]
		{
			get
			{
				return this.fTable[group.Tag] as ArrayList;
			}
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000289E7 File Offset: 0x000279E7
		public IEnumerator GetEnumerator()
		{
			return this.fTable.Values.GetEnumerator();
		}

		// Token: 0x04000366 RID: 870
		private Hashtable fTable = new Hashtable();
	}
}
