using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000056 RID: 86
	public class FIXSessionRejectReason : FIXIntField
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x000133F5 File Offset: 0x000123F5
		public FIXSessionRejectReason(int value) : base(373, value)
		{
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00013404 File Offset: 0x00012404
		public static SessionRejectReason FromFIX(int value)
		{
			switch (value)
			{
			case 0:
				return SessionRejectReason.InvalidTagNumber;
			case 1:
				return SessionRejectReason.RequiredTagMissing;
			case 2:
				return SessionRejectReason.TagNotDefined;
			case 3:
				return SessionRejectReason.UndefinedTag;
			case 4:
				return SessionRejectReason.TagSpecifiedWithoutAValue;
			case 5:
				return SessionRejectReason.ValueIsIncorrect;
			case 6:
				return SessionRejectReason.IncorrectDataFormat;
			case 7:
				return SessionRejectReason.DecryptionProblem;
			case 8:
				return SessionRejectReason.SignatureProblem;
			case 9:
				return SessionRejectReason.CompIDProblem;
			case 10:
				return SessionRejectReason.SendingTimeAccuracyProblem;
			case 11:
				return SessionRejectReason.InvalidMsgType;
			default:
				throw new ArgumentException(string.Format("Unknown session reject reason - {0}", value));
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0001347C File Offset: 0x0001247C
		public static int ToFIX(SessionRejectReason value)
		{
			switch (value)
			{
			case SessionRejectReason.InvalidTagNumber:
				return 0;
			case SessionRejectReason.RequiredTagMissing:
				return 1;
			case SessionRejectReason.TagNotDefined:
				return 2;
			case SessionRejectReason.UndefinedTag:
				return 3;
			case SessionRejectReason.TagSpecifiedWithoutAValue:
				return 4;
			case SessionRejectReason.ValueIsIncorrect:
				return 5;
			case SessionRejectReason.IncorrectDataFormat:
				return 6;
			case SessionRejectReason.DecryptionProblem:
				return 7;
			case SessionRejectReason.SignatureProblem:
				return 8;
			case SessionRejectReason.CompIDProblem:
				return 9;
			case SessionRejectReason.SendingTimeAccuracyProblem:
				return 10;
			case SessionRejectReason.InvalidMsgType:
				return 11;
			default:
				throw new ArgumentException(string.Format("Unknown session reject reason - {0}", value));
			}
		}

		// Token: 0x0400019E RID: 414
		public const int InvalidTagNumber = 0;

		// Token: 0x0400019F RID: 415
		public const int RequiredTagMissing = 1;

		// Token: 0x040001A0 RID: 416
		public const int TagNotDefined = 2;

		// Token: 0x040001A1 RID: 417
		public const int UndefinedTag = 3;

		// Token: 0x040001A2 RID: 418
		public const int TagSpecifiedWithoutAValue = 4;

		// Token: 0x040001A3 RID: 419
		public const int ValueIsIncorrect = 5;

		// Token: 0x040001A4 RID: 420
		public const int IncorrectDataFormat = 6;

		// Token: 0x040001A5 RID: 421
		public const int DecryptionProblem = 7;

		// Token: 0x040001A6 RID: 422
		public const int SignatureProblem = 8;

		// Token: 0x040001A7 RID: 423
		public const int CompIDProblem = 9;

		// Token: 0x040001A8 RID: 424
		public const int SendingTimeAccuracyProblem = 10;

		// Token: 0x040001A9 RID: 425
		public const int InvalidMsgType = 11;
	}
}
