using System;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000046 RID: 70
	public class LegList : FIXGroupList
	{
		// Token: 0x170000D1 RID: 209
		public new Leg this[int index]
		{
			get
			{
				return this.fList[index] as Leg;
			}
		}
	}
}
