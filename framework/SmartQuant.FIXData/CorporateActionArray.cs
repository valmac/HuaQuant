using System;
using SmartQuant.Data;

namespace SmartQuant.FIXData
{
	// Token: 0x02000005 RID: 5
	public class CorporateActionArray : DataArray
	{
		// Token: 0x1700000A RID: 10
		public new CorporateAction this[int index]
		{
			get
			{
				return base[index] as CorporateAction;
			}
		}
	}
}
