using System;
using SmartQuant.Data;

namespace SmartQuant.FIXData
{
	// Token: 0x02000002 RID: 2
	public class FundamentalArray : DataArray
	{
		// Token: 0x17000001 RID: 1
		public new Fundamental this[int index]
		{
			get
			{
				return base[index] as Fundamental;
			}
		}
	}
}
