using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200009F RID: 159
	public class FIXMDReqRejReason : FIXCharField
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x0002443F File Offset: 0x0002343F
		public FIXMDReqRejReason(char value) : base(281, value)
		{
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00024450 File Offset: 0x00023450
		public static MDReqRejReason FromFIX(char value)
		{
			switch (value)
			{
			case '0':
				return MDReqRejReason.UnknownSymbol;
			case '1':
				return MDReqRejReason.DuplicateMDReqID;
			case '2':
				return MDReqRejReason.InsufficientBandwidth;
			case '3':
				return MDReqRejReason.InsufficientPermissions;
			case '4':
				return MDReqRejReason.UnsupportedSubscriptionRequestType;
			case '5':
				return MDReqRejReason.UnsupportedMarketDepth;
			case '6':
				return MDReqRejReason.UnsupportedMDUpdateType;
			case '7':
				return MDReqRejReason.UnsupportedAggregatedBook;
			case '8':
				return MDReqRejReason.UnsupportedMDEntryType;
			case '9':
				return MDReqRejReason.UnsupportedTradingSessionID;
			case 'A':
				return MDReqRejReason.UnsupportedScope;
			case 'B':
				return MDReqRejReason.UnsupportedOpenCloseSettleFlag;
			case 'C':
				return MDReqRejReason.UnsupportedMDImplicitDelete;
			}
			throw new ArgumentException(string.Format("Unknown reason - {0}", value));
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000244F0 File Offset: 0x000234F0
		public static char ToFIX(MDReqRejReason reason)
		{
			switch (reason)
			{
			case MDReqRejReason.UnknownSymbol:
				return '0';
			case MDReqRejReason.DuplicateMDReqID:
				return '1';
			case MDReqRejReason.InsufficientBandwidth:
				return '2';
			case MDReqRejReason.InsufficientPermissions:
				return '3';
			case MDReqRejReason.UnsupportedSubscriptionRequestType:
				return '4';
			case MDReqRejReason.UnsupportedMarketDepth:
				return '5';
			case MDReqRejReason.UnsupportedMDUpdateType:
				return '6';
			case MDReqRejReason.UnsupportedAggregatedBook:
				return '7';
			case MDReqRejReason.UnsupportedMDEntryType:
				return '8';
			case MDReqRejReason.UnsupportedTradingSessionID:
				return '9';
			case MDReqRejReason.UnsupportedScope:
				return 'A';
			case MDReqRejReason.UnsupportedOpenCloseSettleFlag:
				return 'B';
			case MDReqRejReason.UnsupportedMDImplicitDelete:
				return 'C';
			default:
				throw new ArgumentException(string.Format("Unknown reason - {0}", reason));
			}
		}

		// Token: 0x04000315 RID: 789
		public const char UnknownSymbol = '0';

		// Token: 0x04000316 RID: 790
		public const char DuplicateMDReqID = '1';

		// Token: 0x04000317 RID: 791
		public const char InsufficientBandwidth = '2';

		// Token: 0x04000318 RID: 792
		public const char InsufficientPermissions = '3';

		// Token: 0x04000319 RID: 793
		public const char UnsupportedSubscriptionRequestType = '4';

		// Token: 0x0400031A RID: 794
		public const char UnsupportedMarketDepth = '5';

		// Token: 0x0400031B RID: 795
		public const char UnsupportedMDUpdateType = '6';

		// Token: 0x0400031C RID: 796
		public const char UnsupportedAggregatedBook = '7';

		// Token: 0x0400031D RID: 797
		public const char UnsupportedMDEntryType = '8';

		// Token: 0x0400031E RID: 798
		public const char UnsupportedTradingSessionID = '9';

		// Token: 0x0400031F RID: 799
		public const char UnsupportedScope = 'A';

		// Token: 0x04000320 RID: 800
		public const char UnsupportedOpenCloseSettleFlag = 'B';

		// Token: 0x04000321 RID: 801
		public const char UnsupportedMDImplicitDelete = 'C';
	}
}
