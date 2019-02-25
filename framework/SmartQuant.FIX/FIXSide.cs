using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000155 RID: 341
	public class FIXSide : FIXCharField
	{
		// Token: 0x0600402A RID: 16426 RVA: 0x00045F37 File Offset: 0x00044F37
		public FIXSide(char val) : base(54, val)
		{
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00045F44 File Offset: 0x00044F44
		public new static char Value(string Name)
		{
			if (Name == "Buy")
			{
				return '1';
			}
			if (Name == "Sell")
			{
				return '2';
			}
			if (Name == "BuyMinus")
			{
				return '3';
			}
			if (Name == "SellPlus")
			{
				return '4';
			}
			if (Name == "SellShort")
			{
				return '5';
			}
			if (Name == "SellShortExempt")
			{
				return '6';
			}
			if (Name == "Undisclosed")
			{
				return '7';
			}
			if (Name == "Cross")
			{
				return '8';
			}
			if (Name == "CrossShort")
			{
				return '9';
			}
			if (Name == "CrossShortExempt")
			{
				return 'A';
			}
			if (Name == "AsDefined")
			{
				return 'B';
			}
			if (Name == "Opposite")
			{
				return 'C';
			}
			return '\0';
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00046014 File Offset: 0x00045014
		public static string ToString(char c)
		{
			switch (c)
			{
			case '1':
				return "Buy";
			case '2':
				return "Sell";
			case '3':
				return "BuyMinus";
			case '4':
				return "SellPlus";
			case '5':
				return "SellShort";
			case '6':
				return "SellShortExempt";
			case '7':
				return "Undisclosed";
			case '8':
				return "Cross";
			case '9':
				return "CrossShort";
			case 'A':
				return "CrossShortExempt";
			case 'B':
				return "AsDefined";
			case 'C':
				return "Opposite";
			}
			return "Unknown";
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x000460C8 File Offset: 0x000450C8
		public static Side FromFIX(char side)
		{
			switch (side)
			{
			case '1':
				return Side.Buy;
			case '2':
				return Side.Sell;
			case '3':
				return Side.BuyMinus;
			case '4':
				return Side.SellPlus;
			case '5':
				return Side.SellShort;
			case '6':
				return Side.SellShortExempt;
			case '7':
				return Side.Undisclosed;
			case '8':
				return Side.Cross;
			case '9':
				return Side.CrossShort;
			case 'A':
				return Side.CrossShortExempt;
			case 'B':
				return Side.AsDefined;
			case 'C':
				return Side.Opposite;
			}
			throw new Exception("Unknown side - " + side);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00046160 File Offset: 0x00045160
		public static char ToFIX(Side side)
		{
			switch (side)
			{
			case Side.Buy:
				return '1';
			case Side.Sell:
				return '2';
			case Side.BuyMinus:
				return '3';
			case Side.SellPlus:
				return '4';
			case Side.SellShort:
				return '5';
			case Side.SellShortExempt:
				return '6';
			case Side.Undisclosed:
				return '7';
			case Side.Cross:
				return '8';
			case Side.CrossShort:
				return '9';
			case Side.CrossShortExempt:
				return 'A';
			case Side.AsDefined:
				return 'B';
			case Side.Opposite:
				return 'C';
			default:
				throw new Exception("Unknown side - " + side.ToString());
			}
		}

		// Token: 0x04000964 RID: 2404
		public const char Buy = '1';

		// Token: 0x04000965 RID: 2405
		public const char Sell = '2';

		// Token: 0x04000966 RID: 2406
		public const char BuyMinus = '3';

		// Token: 0x04000967 RID: 2407
		public const char SellPlus = '4';

		// Token: 0x04000968 RID: 2408
		public const char SellShort = '5';

		// Token: 0x04000969 RID: 2409
		public const char SellShortExempt = '6';

		// Token: 0x0400096A RID: 2410
		public const char Undisclosed = '7';

		// Token: 0x0400096B RID: 2411
		public const char Cross = '8';

		// Token: 0x0400096C RID: 2412
		public const char CrossShort = '9';

		// Token: 0x0400096D RID: 2413
		public const char CrossShortExempt = 'A';

		// Token: 0x0400096E RID: 2414
		public const char AsDefined = 'B';

		// Token: 0x0400096F RID: 2415
		public const char Opposite = 'C';
	}
}
