using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000032 RID: 50
	[Flags]
	public enum HistoricalDataType : byte
	{
		// Token: 0x04000079 RID: 121
		Trade = 1,
		// Token: 0x0400007A RID: 122
		Quote = 2,
		// Token: 0x0400007B RID: 123
		Bar = 4,
		// Token: 0x0400007C RID: 124
		Daily = 8,
		// Token: 0x0400007D RID: 125
		MarketDepth = 16
	}
}
