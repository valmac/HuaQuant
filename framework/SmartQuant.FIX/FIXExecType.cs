using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000073 RID: 115
	public class FIXExecType : FIXCharField
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x00016E30 File Offset: 0x00015E30
		public FIXExecType(char val) : base(150, val)
		{
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00016E40 File Offset: 0x00015E40
		public static string ToString(char c)
		{
			switch (c)
			{
			case '0':
				return "New";
			case '1':
				return "PartialFill";
			case '2':
				return "Fill";
			case '3':
				return "DoneForDay";
			case '4':
				return "Cancelled";
			case '5':
				return "Replace";
			case '6':
				return "PendingCancel";
			case '7':
				return "Stopped";
			case '8':
				return "Rejected";
			case '9':
				return "Suspended";
			case 'A':
				return "PendingNew";
			case 'B':
				return "Calculated";
			case 'C':
				return "Expired";
			case 'D':
				return "Restarted";
			case 'E':
				return "PendingReplace";
			case 'F':
				return "Trade";
			case 'G':
				return "TradeCorrect";
			case 'H':
				return "TradeCancel";
			case 'I':
				return "OrderStatus";
			}
			return null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00016F38 File Offset: 0x00015F38
		public static ExecType FromFIX(char execType)
		{
			if (execType != '\0')
			{
				switch (execType)
				{
				case '0':
					return ExecType.New;
				case '1':
					return ExecType.PartialFill;
				case '2':
					return ExecType.Fill;
				case '3':
					return ExecType.DoneForDay;
				case '4':
					return ExecType.Cancelled;
				case '5':
					return ExecType.Replace;
				case '6':
					return ExecType.PendingCancel;
				case '7':
					return ExecType.Stopped;
				case '8':
					return ExecType.Rejected;
				case '9':
					return ExecType.Suspended;
				case 'A':
					return ExecType.PendingNew;
				case 'B':
					return ExecType.Calculated;
				case 'C':
					return ExecType.Expired;
				case 'D':
					return ExecType.Restarted;
				case 'E':
					return ExecType.PendingReplace;
				case 'F':
					return ExecType.Trade;
				case 'G':
					return ExecType.TradeCorrect;
				case 'H':
					return ExecType.TradeCancel;
				case 'I':
					return ExecType.OrderStatus;
				}
				throw new ArgumentException("Unknown execution type - " + execType);
			}
			return ExecType.Undefined;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0001700C File Offset: 0x0001600C
		public static char ToFIX(ExecType execType)
		{
			switch (execType)
			{
			case ExecType.New:
				return '0';
			case ExecType.PartialFill:
				return '1';
			case ExecType.Fill:
				return '2';
			case ExecType.DoneForDay:
				return '3';
			case ExecType.Cancelled:
				return '4';
			case ExecType.Replace:
				return '5';
			case ExecType.PendingCancel:
				return '6';
			case ExecType.Stopped:
				return '7';
			case ExecType.Rejected:
				return '8';
			case ExecType.Suspended:
				return '9';
			case ExecType.PendingNew:
				return 'A';
			case ExecType.Calculated:
				return 'B';
			case ExecType.Expired:
				return 'C';
			case ExecType.Restarted:
				return 'D';
			case ExecType.PendingReplace:
				return 'E';
			case ExecType.Trade:
				return 'F';
			case ExecType.TradeCorrect:
				return 'G';
			case ExecType.TradeCancel:
				return 'H';
			case ExecType.OrderStatus:
				return 'I';
			default:
				throw new ArgumentException("Unknown execution type - " + execType.ToString());
			}
		}

		// Token: 0x04000268 RID: 616
		public const char New = '0';

		// Token: 0x04000269 RID: 617
		public const char PartialFill = '1';

		// Token: 0x0400026A RID: 618
		public const char Fill = '2';

		// Token: 0x0400026B RID: 619
		public const char DoneForDay = '3';

		// Token: 0x0400026C RID: 620
		public const char Cancelled = '4';

		// Token: 0x0400026D RID: 621
		public const char Replace = '5';

		// Token: 0x0400026E RID: 622
		public const char PendingCancel = '6';

		// Token: 0x0400026F RID: 623
		public const char Stopped = '7';

		// Token: 0x04000270 RID: 624
		public const char Rejected = '8';

		// Token: 0x04000271 RID: 625
		public const char Suspended = '9';

		// Token: 0x04000272 RID: 626
		public const char PendingNew = 'A';

		// Token: 0x04000273 RID: 627
		public const char Calculated = 'B';

		// Token: 0x04000274 RID: 628
		public const char Expired = 'C';

		// Token: 0x04000275 RID: 629
		public const char Restarted = 'D';

		// Token: 0x04000276 RID: 630
		public const char PendingReplace = 'E';

		// Token: 0x04000277 RID: 631
		public const char Trade = 'F';

		// Token: 0x04000278 RID: 632
		public const char TradeCorrect = 'G';

		// Token: 0x04000279 RID: 633
		public const char TradeCancel = 'H';

		// Token: 0x0400027A RID: 634
		public const char OrderStatus = 'I';
	}
}
