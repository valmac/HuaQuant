using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000018 RID: 24
	public class FIXCorporateActionType : FIXIntField
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00007859 File Offset: 0x00006859
		public FIXCorporateActionType(int val) : base(10200, val)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00007868 File Offset: 0x00006868
		public static string ToString(int val)
		{
			switch (val)
			{
			case 1:
				return "CashDividend";
			case 2:
				return "StockDividend";
			case 3:
				return "Split";
			case 4:
				return "RightsIssue";
			case 5:
				return "Merger";
			case 6:
				return "Acquisition";
			case 7:
				return "SpinOff";
			default:
				return "Unknown";
			}
		}

		// Token: 0x0400003B RID: 59
		public const int CashDividend = 1;

		// Token: 0x0400003C RID: 60
		public const int StockDividend = 2;

		// Token: 0x0400003D RID: 61
		public const int Split = 3;

		// Token: 0x0400003E RID: 62
		public const int RightsIssue = 4;

		// Token: 0x0400003F RID: 63
		public const int Merger = 5;

		// Token: 0x04000040 RID: 64
		public const int Acquisition = 6;

		// Token: 0x04000041 RID: 65
		public const int SpinOff = 7;
	}
}
