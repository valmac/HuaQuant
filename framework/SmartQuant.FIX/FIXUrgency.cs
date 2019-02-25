using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000054 RID: 84
	public class FIXUrgency : FIXCharField
	{
		// Token: 0x060010F9 RID: 4345 RVA: 0x00013235 File Offset: 0x00012235
		public FIXUrgency(char val) : base(61, val)
		{
		}

		// Token: 0x04000190 RID: 400
		public const char Normal = '0';

		// Token: 0x04000191 RID: 401
		public const char Flash = '1';

		// Token: 0x04000192 RID: 402
		public const char Background = '2';
	}
}
