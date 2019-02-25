using System;

namespace SmartQuant.Series
{
	// Token: 0x02000014 RID: 20
	public enum ETickBase
	{
		// Token: 0x04000049 RID: 73
		Ignore = -1,
		// Token: 0x0400004A RID: 74
		Second = 1,
		// Token: 0x0400004B RID: 75
		Minute = 60,
		// Token: 0x0400004C RID: 76
		FiveMinute = 300,
		// Token: 0x0400004D RID: 77
		FifteenMinute = 900,
		// Token: 0x0400004E RID: 78
		ThirtyMinute = 1800,
		// Token: 0x0400004F RID: 79
		Hour = 3600,
		// Token: 0x04000050 RID: 80
		FourHour = 14400,
		// Token: 0x04000051 RID: 81
		Day = 86400,
		// Token: 0x04000052 RID: 82
		Week = 604800,
		// Token: 0x04000053 RID: 83
		Month = 2419200,
		// Token: 0x04000054 RID: 84
		Year = 29030400
	}
}
