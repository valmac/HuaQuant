using System;

namespace SmartQuant
{
	// Token: 0x02000028 RID: 40
	[Flags]
	internal enum ASM_CMP_FLAGS
	{
		// Token: 0x0400009B RID: 155
		NAME = 1,
		// Token: 0x0400009C RID: 156
		MAJOR_VERSION = 2,
		// Token: 0x0400009D RID: 157
		MINOR_VERSION = 4,
		// Token: 0x0400009E RID: 158
		BUILD_NUMBER = 8,
		// Token: 0x0400009F RID: 159
		REVISION_NUMBER = 16,
		// Token: 0x040000A0 RID: 160
		PUBLIC_KEY_TOKEN = 32,
		// Token: 0x040000A1 RID: 161
		CULTURE = 64,
		// Token: 0x040000A2 RID: 162
		CUSTOM = 128,
		// Token: 0x040000A3 RID: 163
		ALL = 255,
		// Token: 0x040000A4 RID: 164
		DEFAULT = 256
	}
}
