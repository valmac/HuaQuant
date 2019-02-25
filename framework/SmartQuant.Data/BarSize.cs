using System;

namespace SmartQuant.Data
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class BarSize
	{
		// Token: 0x04000040 RID: 64
		public const long Second = 1L;

		// Token: 0x04000041 RID: 65
		public const long Minute = 60L;

		// Token: 0x04000042 RID: 66
		public const long Hour = 3600L;

		// Token: 0x04000043 RID: 67
		public const long Day = 86400L;

		// Token: 0x04000044 RID: 68
		public const long Week = 604800L;

		// Token: 0x04000045 RID: 69
		public const long Month = 2592000L;

		// Token: 0x04000046 RID: 70
		public const long Year = 31536000L;
	}
}
