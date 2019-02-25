using System;

namespace SmartQuant.Data
{
	// Token: 0x02000010 RID: 16
	public class BarArray : DataArray
	{
		// Token: 0x1700001D RID: 29
		public new Bar this[int index]
		{
			get
			{
				return this.fList[index] as Bar;
			}
		}
	}
}
