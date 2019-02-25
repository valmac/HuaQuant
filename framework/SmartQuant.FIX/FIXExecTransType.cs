using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000059 RID: 89
	public class FIXExecTransType : FIXCharField
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x0001350C File Offset: 0x0001250C
		public FIXExecTransType(char value) : base(20, value)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00013518 File Offset: 0x00012518
		public static ExecTransType FromFIX(char value)
		{
			switch (value)
			{
			case '0':
				return ExecTransType.New;
			case '1':
				return ExecTransType.Cancel;
			case '2':
				return ExecTransType.Correct;
			case '3':
				return ExecTransType.Status;
			default:
				throw new ArgumentException(string.Format("Unknown exec trans type - {0}", value));
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00013560 File Offset: 0x00012560
		public static char ToFIX(ExecTransType value)
		{
			switch (value)
			{
			case ExecTransType.New:
				return '0';
			case ExecTransType.Cancel:
				return '1';
			case ExecTransType.Correct:
				return '2';
			case ExecTransType.Status:
				return '3';
			default:
				throw new ArgumentException(string.Format("Unknown exec trans type - {0}", value));
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000135A8 File Offset: 0x000125A8
		public static string ToString(char c)
		{
			switch (c)
			{
			case '0':
				return "New";
			case '1':
				return "Cancel";
			case '2':
				return "Correct";
			case '3':
				return "Status";
			default:
				return "Unknown";
			}
		}

		// Token: 0x0400020C RID: 524
		public const char New = '0';

		// Token: 0x0400020D RID: 525
		public const char Cancel = '1';

		// Token: 0x0400020E RID: 526
		public const char Correct = '2';

		// Token: 0x0400020F RID: 527
		public const char Status = '3';
	}
}
