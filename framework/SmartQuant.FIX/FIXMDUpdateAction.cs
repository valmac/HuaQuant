using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000193 RID: 403
	public class FIXMDUpdateAction : FIXCharField
	{
		// Token: 0x06004B95 RID: 19349 RVA: 0x00053965 File Offset: 0x00052965
		public FIXMDUpdateAction(char val) : base(279, val)
		{
		}

		// Token: 0x04000DC8 RID: 3528
		public const char New = '0';

		// Token: 0x04000DC9 RID: 3529
		public const char Change = '1';

		// Token: 0x04000DCA RID: 3530
		public const char Delete = '2';
	}
}
