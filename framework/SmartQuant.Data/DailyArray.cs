using System;

namespace SmartQuant.Data
{
	// Token: 0x02000011 RID: 17
	public class DailyArray : BarArray
	{
		// Token: 0x1700001E RID: 30
		public new Daily this[int index]
		{
			get
			{
				return base[index] as Daily;
			}
		}
	}
}
