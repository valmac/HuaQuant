using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000055 RID: 85
	public class FIXSettlmntType : FIXCharField
	{
		// Token: 0x060010FA RID: 4346 RVA: 0x00013240 File Offset: 0x00012240
		public FIXSettlmntType(char val) : base(63, val)
		{
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0001324C File Offset: 0x0001224C
		public new static char Value(string Name)
		{
			if (Name == "Regular")
			{
				return '0';
			}
			if (Name == "Cash")
			{
				return '1';
			}
			if (Name == "NextDay")
			{
				return '2';
			}
			if (Name == "Tplus1" || Name == "T+1")
			{
				return 'A';
			}
			if (Name == "Tplus2" || Name == "T+2")
			{
				return '3';
			}
			if (Name == "Tplus3" || Name == "T+3")
			{
				return '4';
			}
			if (Name == "Tplus4" || Name == "T+4")
			{
				return '5';
			}
			if (Name == "Tplus5" || Name == "T+5")
			{
				return '9';
			}
			if (Name == "Future")
			{
				return '6';
			}
			if (Name == "WhenAndIfIssued")
			{
				return '7';
			}
			if (Name == "SellersOption")
			{
				return '8';
			}
			return '\0';
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0001334C File Offset: 0x0001234C
		public static string ToString(char c)
		{
			switch (c)
			{
			case '0':
				return "Regular";
			case '1':
				return "Cash";
			case '2':
				return "NextDay";
			case '3':
				return "T+2";
			case '4':
				return "T+3";
			case '5':
				return "T+4";
			case '6':
				return "Future";
			case '7':
				return "WhenAndIfIssued";
			case '8':
				return "SellersOption";
			case '9':
				return "T+5";
			case 'A':
				return "T+1";
			}
			return "Unknown";
		}

		// Token: 0x04000193 RID: 403
		public const char Regular = '0';

		// Token: 0x04000194 RID: 404
		public const char Cash = '1';

		// Token: 0x04000195 RID: 405
		public const char NextDay = '2';

		// Token: 0x04000196 RID: 406
		public const char Tplus2 = '3';

		// Token: 0x04000197 RID: 407
		public const char Tplus3 = '4';

		// Token: 0x04000198 RID: 408
		public const char Tplus4 = '5';

		// Token: 0x04000199 RID: 409
		public const char Future = '6';

		// Token: 0x0400019A RID: 410
		public const char WhenAndIfIssued = '7';

		// Token: 0x0400019B RID: 411
		public const char SellersOption = '8';

		// Token: 0x0400019C RID: 412
		public const char Tplus5 = '9';

		// Token: 0x0400019D RID: 413
		public const char Tplus1 = 'A';
	}
}
