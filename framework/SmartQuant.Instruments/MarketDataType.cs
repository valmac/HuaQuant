using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000027 RID: 39
	public enum MarketDataType : byte
	{
		// Token: 0x040000A2 RID: 162
		None,
		// Token: 0x040000A3 RID: 163
		Trade,
		// Token: 0x040000A4 RID: 164
		Quote,
		// Token: 0x040000A5 RID: 165
		MarketDepth = 4,
		// Token: 0x040000A6 RID: 166
		All = 255
	}
}
