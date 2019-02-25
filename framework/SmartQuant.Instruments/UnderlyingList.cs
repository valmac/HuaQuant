using System;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x0200002E RID: 46
	public class UnderlyingList : FIXGroupList
	{
		// Token: 0x170000A7 RID: 167
		public new Underlying this[int index]
		{
			get
			{
				return this.fList[index] as Underlying;
			}
		}
	}
}
