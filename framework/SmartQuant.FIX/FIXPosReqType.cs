using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000EB RID: 235
	public class FIXPosReqType : FIXIntField
	{
		// Token: 0x06002E5B RID: 11867 RVA: 0x00031162 File Offset: 0x00030162
		public FIXPosReqType(int value) : base(724, value)
		{
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00031170 File Offset: 0x00030170
		public static PosReqType FromFIX(int value)
		{
			switch (value)
			{
			case 0:
				return PosReqType.Positions;
			case 1:
				return PosReqType.Trades;
			case 2:
				return PosReqType.Exercises;
			case 3:
				return PosReqType.Assignments;
			default:
				throw new ArgumentException(string.Format("Unknown position request type - {0}", value));
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000311B4 File Offset: 0x000301B4
		public static int ToFIX(PosReqType value)
		{
			switch (value)
			{
			case PosReqType.Positions:
				return 0;
			case PosReqType.Trades:
				return 1;
			case PosReqType.Exercises:
				return 2;
			case PosReqType.Assignments:
				return 3;
			default:
				throw new ArgumentException(string.Format("Unknown position request type - {0}", value));
			}
		}

		// Token: 0x040003EA RID: 1002
		public const int Positions = 0;

		// Token: 0x040003EB RID: 1003
		public const int Trades = 1;

		// Token: 0x040003EC RID: 1004
		public const int Exercises = 2;

		// Token: 0x040003ED RID: 1005
		public const int Assignments = 3;
	}
}
