using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000156 RID: 342
	public class FIXOrdStatus : FIXCharField
	{
		// Token: 0x0600402F RID: 16431 RVA: 0x000461E7 File Offset: 0x000451E7
		public FIXOrdStatus(char val) : base(39, val)
		{
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x000461F4 File Offset: 0x000451F4
		public static string ToString(char c)
		{
			switch (c)
			{
			case '0':
				return "New";
			case '1':
				return "PartiallyFilled";
			case '2':
				return "Filled";
			case '3':
				return "DoneForDay";
			case '4':
				return "Cancelled";
			case '5':
				return "Replaced";
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
				return "AcceptedForBidding";
			case 'E':
				return "PendingReplace";
			}
			return "Unknown";
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x000462C8 File Offset: 0x000452C8
		public static OrdStatus FromFIX(char ordStatus)
		{
			if (ordStatus != '\0')
			{
				switch (ordStatus)
				{
				case '0':
					return OrdStatus.New;
				case '1':
					return OrdStatus.PartiallyFilled;
				case '2':
					return OrdStatus.Filled;
				case '3':
					return OrdStatus.DoneForDay;
				case '4':
					return OrdStatus.Cancelled;
				case '5':
					return OrdStatus.Replaced;
				case '6':
					return OrdStatus.PendingCancel;
				case '7':
					return OrdStatus.Stopped;
				case '8':
					return OrdStatus.Rejected;
				case '9':
					return OrdStatus.Suspended;
				case 'A':
					return OrdStatus.PendingNew;
				case 'B':
					return OrdStatus.Calculated;
				case 'C':
					return OrdStatus.Expired;
				case 'D':
					return OrdStatus.AcceptedForBidding;
				case 'E':
					return OrdStatus.PendingReplace;
				}
				throw new ArgumentException("Unknown status - " + ordStatus);
			}
			return OrdStatus.Undefined;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00046380 File Offset: 0x00045380
		public static char ToFIX(OrdStatus ordStatus)
		{
			switch (ordStatus)
			{
			case OrdStatus.Undefined:
				return '\0';
			case OrdStatus.New:
				return '0';
			case OrdStatus.PartiallyFilled:
				return '1';
			case OrdStatus.Filled:
				return '2';
			case OrdStatus.DoneForDay:
				return '3';
			case OrdStatus.Cancelled:
				return '4';
			case OrdStatus.Replaced:
				return '5';
			case OrdStatus.PendingCancel:
				return '6';
			case OrdStatus.Stopped:
				return '7';
			case OrdStatus.Rejected:
				return '8';
			case OrdStatus.Suspended:
				return '9';
			case OrdStatus.PendingNew:
				return 'A';
			case OrdStatus.Calculated:
				return 'B';
			case OrdStatus.Expired:
				return 'C';
			case OrdStatus.AcceptedForBidding:
				return 'D';
			case OrdStatus.PendingReplace:
				return 'E';
			default:
				throw new ArgumentException("Unknown status - " + ordStatus.ToString());
			}
		}

		// Token: 0x04000970 RID: 2416
		public const char New = '0';

		// Token: 0x04000971 RID: 2417
		public const char PartiallyFilled = '1';

		// Token: 0x04000972 RID: 2418
		public const char Filled = '2';

		// Token: 0x04000973 RID: 2419
		public const char DoneForDay = '3';

		// Token: 0x04000974 RID: 2420
		public const char Cancelled = '4';

		// Token: 0x04000975 RID: 2421
		public const char Replaced = '5';

		// Token: 0x04000976 RID: 2422
		public const char PendingCancel = '6';

		// Token: 0x04000977 RID: 2423
		public const char Stopped = '7';

		// Token: 0x04000978 RID: 2424
		public const char Rejected = '8';

		// Token: 0x04000979 RID: 2425
		public const char Suspended = '9';

		// Token: 0x0400097A RID: 2426
		public const char PendingNew = 'A';

		// Token: 0x0400097B RID: 2427
		public const char Calculated = 'B';

		// Token: 0x0400097C RID: 2428
		public const char Expired = 'C';

		// Token: 0x0400097D RID: 2429
		public const char AcceptedForBidding = 'D';

		// Token: 0x0400097E RID: 2430
		public const char PendingReplace = 'E';
	}
}
