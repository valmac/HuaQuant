using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000175 RID: 373
	public class FIXHandlInst : FIXCharField
	{
		// Token: 0x0600457A RID: 17786 RVA: 0x0004D271 File Offset: 0x0004C271
		public FIXHandlInst(char val) : base(21, val)
		{
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x0004D27C File Offset: 0x0004C27C
		public static string ToString(char c)
		{
			switch (c)
			{
			case '1':
				return "AutomatedExecutionOrderPrivate";
			case '2':
				return "AutomatedExecutionOrderPublic";
			case '3':
				return "ManualOrderBestExecution";
			default:
				return "Unknown";
			}
		}

		// Token: 0x04000D7A RID: 3450
		public const char AutomatedExecutionOrderPrivate = '1';

		// Token: 0x04000D7B RID: 3451
		public const char AutomatedExecutionOrderPublic = '2';

		// Token: 0x04000D7C RID: 3452
		public const char ManualOrderBestExecution = '3';
	}
}
