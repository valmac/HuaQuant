using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000144 RID: 324
	public class NYSEIndustrySector : FIXStringField
	{
		// Token: 0x06003EEE RID: 16110 RVA: 0x00044A9A File Offset: 0x00043A9A
		public NYSEIndustrySector(string val) : base(10101, val)
		{
		}

		// Token: 0x0400093B RID: 2363
		public const string Industrials = "100";

		// Token: 0x0400093C RID: 2364
		public const string Transportation = "200";

		// Token: 0x0400093D RID: 2365
		public const string Utilities = "300";

		// Token: 0x0400093E RID: 2366
		public const string FinanceRealEstate = "400";
	}
}
