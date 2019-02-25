using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000A0 RID: 160
	public class FIXMDEntryType : FIXCharField
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x00024577 File Offset: 0x00023577
		public FIXMDEntryType(char val) : base(269, val)
		{
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00024588 File Offset: 0x00023588
		public static string ToString(char c)
		{
			switch (c)
			{
			case '0':
				return "Bid";
			case '1':
				return "Offer";
			case '2':
				return "Trade";
			case '3':
				return "Index";
			case '4':
				return "Open";
			case '5':
				return "Close";
			case '6':
				return "Settlement";
			case '7':
				return "High";
			case '8':
				return "Low";
			case '9':
				return "VWAP";
			case 'A':
				return "Imbalance";
			}
			throw new ArgumentException("Unknown field value: " + c);
		}

		// Token: 0x04000322 RID: 802
		public const char Bid = '0';

		// Token: 0x04000323 RID: 803
		public const char Offer = '1';

		// Token: 0x04000324 RID: 804
		public const char Trade = '2';

		// Token: 0x04000325 RID: 805
		public const char Index = '3';

		// Token: 0x04000326 RID: 806
		public const char Open = '4';

		// Token: 0x04000327 RID: 807
		public const char Close = '5';

		// Token: 0x04000328 RID: 808
		public const char Settlement = '6';

		// Token: 0x04000329 RID: 809
		public const char High = '7';

		// Token: 0x0400032A RID: 810
		public const char Low = '8';

		// Token: 0x0400032B RID: 811
		public const char VWAP = '9';

		// Token: 0x0400032C RID: 812
		public const char Imbalance = 'A';
	}
}
