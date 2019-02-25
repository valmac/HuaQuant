using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000044 RID: 68
	public class FIXCxlRejReason : FIXIntField
	{
		// Token: 0x06000F5B RID: 3931 RVA: 0x00011E45 File Offset: 0x00010E45
		public FIXCxlRejReason(int value) : base(102, value)
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00011E50 File Offset: 0x00010E50
		public static CxlRejReason FromFIX(int value)
		{
			switch (value)
			{
			case 0:
				return CxlRejReason.TooLateToCancel;
			case 1:
				return CxlRejReason.UnknownOrder;
			case 2:
				return CxlRejReason.BrokerOption;
			case 3:
				return CxlRejReason.AlreadyPending;
			default:
				throw new ArgumentException(string.Format("Unknown reason - {0}", value));
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00011E94 File Offset: 0x00010E94
		public static int ToFIX(CxlRejReason reason)
		{
			switch (reason)
			{
			case CxlRejReason.TooLateToCancel:
				return 0;
			case CxlRejReason.UnknownOrder:
				return 1;
			case CxlRejReason.BrokerOption:
				return 2;
			case CxlRejReason.AlreadyPending:
				return 3;
			default:
				throw new ArgumentException(string.Format("Unknown reason - {0}", reason));
			}
		}

		// Token: 0x040000D3 RID: 211
		public const int TooLateToCancel = 0;

		// Token: 0x040000D4 RID: 212
		public const int UnknownOrder = 1;

		// Token: 0x040000D5 RID: 213
		public const int BrokerOption = 2;

		// Token: 0x040000D6 RID: 214
		public const int AlreadyPending = 3;
	}
}
