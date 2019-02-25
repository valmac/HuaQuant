using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200000F RID: 15
	public class FIXSecurityAltIDGroupList : FIXGroupList
	{
		// Token: 0x1700022B RID: 555
		public new FIXSecurityAltIDGroup this[int index]
		{
			get
			{
				return this.fList[index] as FIXSecurityAltIDGroup;
			}
		}
	}
}
