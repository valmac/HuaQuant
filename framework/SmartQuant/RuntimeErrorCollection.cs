using System;
using System.Collections;

namespace SmartQuant
{
	// Token: 0x0200001F RID: 31
	public class RuntimeErrorCollection : ReadOnlyCollectionBase
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0000436C File Offset: 0x0000336C
		internal RuntimeErrorCollection()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004374 File Offset: 0x00003374
		internal void Add(RuntimeError error)
		{
			base.InnerList.Add(error);
		}
	}
}
