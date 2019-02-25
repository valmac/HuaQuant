using System;

namespace SmartQuant.Series
{
	// Token: 0x0200000C RID: 12
	public class IndicatorParameterAttribute : Attribute
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x000077F2 File Offset: 0x000067F2
		public IndicatorParameterAttribute(int Number)
		{
			this.fNumber = Number;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00007801 File Offset: 0x00006801
		public int Number
		{
			get
			{
				return this.fNumber;
			}
		}

		// Token: 0x0400002B RID: 43
		private int fNumber;
	}
}
