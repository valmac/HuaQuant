using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000074 RID: 116
	public class FIXCommType : FIXCharField
	{
		// Token: 0x06001483 RID: 5251 RVA: 0x000170C4 File Offset: 0x000160C4
		public FIXCommType(char val) : base(13, val)
		{
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000170D0 File Offset: 0x000160D0
		public static char ToFIX(CommType value)
		{
			switch (value)
			{
			case CommType.PerShare:
				return '1';
			case CommType.Percent:
				return '2';
			case CommType.Absolute:
				return '3';
			case CommType.PctWaivedCshDisc:
				return '4';
			case CommType.PctWaivedEnUnits:
				return '5';
			case CommType.PerBond:
				return '6';
			default:
				throw new ArgumentException(string.Format("Unknown commission type - {0}", value));
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00017128 File Offset: 0x00016128
		public static CommType FromFIX(char value)
		{
			switch (value)
			{
			case '1':
				return CommType.PerShare;
			case '2':
				return CommType.Percent;
			case '3':
				return CommType.Absolute;
			case '4':
				return CommType.PctWaivedCshDisc;
			case '5':
				return CommType.PctWaivedEnUnits;
			case '6':
				return CommType.PerBond;
			default:
				return CommType.Absolute;
			}
		}

		// Token: 0x0400027B RID: 635
		public const char PerShare = '1';

		// Token: 0x0400027C RID: 636
		public const char Percent = '2';

		// Token: 0x0400027D RID: 637
		public const char Absolute = '3';

		// Token: 0x0400027E RID: 638
		public const char PctWaivedCshDisc = '4';

		// Token: 0x0400027F RID: 639
		public const char PctWaivedEnUnits = '5';

		// Token: 0x04000280 RID: 640
		public const char PerBond = '6';
	}
}
