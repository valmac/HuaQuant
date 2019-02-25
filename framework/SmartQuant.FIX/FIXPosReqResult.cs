using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000109 RID: 265
	public class FIXPosReqResult : FIXIntField
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x000344D8 File Offset: 0x000334D8
		public FIXPosReqResult(int value) : base(728, value)
		{
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x000344E8 File Offset: 0x000334E8
		public static int ToFIX(PosReqResult value)
		{
			switch (value)
			{
			case PosReqResult.ValidRequest:
				return 0;
			case PosReqResult.InvalidOrUnsupportedRequest:
				return 1;
			case PosReqResult.NoPositionsFound:
				return 2;
			case PosReqResult.NotAuthorized:
				return 3;
			case PosReqResult.RequestForPositionNotSupported:
				return 4;
			case PosReqResult.Other:
				return 99;
			default:
				throw new ArgumentException(string.Format("Unknown position request result - {0}", value));
			}
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0003453C File Offset: 0x0003353C
		public static PosReqResult FromFIX(int value)
		{
			switch (value)
			{
			case 0:
				return PosReqResult.ValidRequest;
			case 1:
				return PosReqResult.InvalidOrUnsupportedRequest;
			case 2:
				return PosReqResult.NoPositionsFound;
			case 3:
				return PosReqResult.NotAuthorized;
			case 4:
				return PosReqResult.RequestForPositionNotSupported;
			default:
				if (value != 99)
				{
					throw new ArgumentException(string.Format("Unknown position request result - {0}", value));
				}
				return PosReqResult.Other;
			}
		}

		// Token: 0x0400043A RID: 1082
		public const int ValidRequest = 0;

		// Token: 0x0400043B RID: 1083
		public const int InvalidOrUnsupportedRequest = 1;

		// Token: 0x0400043C RID: 1084
		public const int NoPositionsFound = 2;

		// Token: 0x0400043D RID: 1085
		public const int NotAuthorized = 3;

		// Token: 0x0400043E RID: 1086
		public const int RequestForPositionNotSupported = 4;

		// Token: 0x0400043F RID: 1087
		public const int Other = 99;
	}
}
