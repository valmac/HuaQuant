using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200008A RID: 138
	public class FIXOrdType : FIXCharField
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x0001D5A7 File Offset: 0x0001C5A7
		public FIXOrdType(char val) : base(40, val)
		{
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0001D5B4 File Offset: 0x0001C5B4
		public new static char Value(string Name)
		{
			if (Name == "Market")
			{
				return '1';
			}
			if (Name == "Limit")
			{
				return '2';
			}
			if (Name == "Stop")
			{
				return '3';
			}
			if (Name == "StopLimit")
			{
				return '4';
			}
			if (Name == "MarketOnClose")
			{
				return '5';
			}
			if (Name == "WithOrWithout")
			{
				return '6';
			}
			if (Name == "LimitOrBetter")
			{
				return '7';
			}
			if (Name == "LimitWithOrWithout")
			{
				return '8';
			}
			if (Name == "OnBasis")
			{
				return '9';
			}
			if (Name == "OnClose")
			{
				return 'A';
			}
			if (Name == "LimitOnClose")
			{
				return 'B';
			}
			if (Name == "ForexMarket")
			{
				return 'C';
			}
			if (Name == "PreviouslyQuoted")
			{
				return 'D';
			}
			if (Name == "PreviouslyIndicated")
			{
				return 'E';
			}
			if (Name == "ForexLimit")
			{
				return 'F';
			}
			if (Name == "ForexSwap")
			{
				return 'G';
			}
			if (Name == "ForexPreviouslyQuoted")
			{
				return 'H';
			}
			if (Name == "Funari")
			{
				return 'I';
			}
			if (Name == "MIT")
			{
				return 'J';
			}
			if (Name == "MarketWithLeftoverAsLimit")
			{
				return 'K';
			}
			if (Name == "PreviousFundValuationPoint")
			{
				return 'L';
			}
			if (Name == "NextFundValuationPoint")
			{
				return 'M';
			}
			if (Name == "Pegged")
			{
				return 'P';
			}
			return '\0';
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0001D734 File Offset: 0x0001C734
		public static string ToString(char c)
		{
			switch (c)
			{
			case '1':
				return "Market";
			case '2':
				return "Limit";
			case '3':
				return "Stop";
			case '4':
				return "StopLimit";
			case '5':
				return "MarketOnClose";
			case '6':
				return "WithOrWithout";
			case '7':
				return "LimitOrBetter";
			case '8':
				return "LimitWithOrWithout";
			case '9':
				return "OnBasis";
			case 'A':
				return "OnClose";
			case 'B':
				return "LimitOnClose";
			case 'C':
				return "ForexMarket";
			case 'D':
				return "PreviouslyQuoted";
			case 'E':
				return "PreviouslyIndicated";
			case 'F':
				return "ForexLimit";
			case 'G':
				return "ForexSwap";
			case 'H':
				return "ForexPreviouslyQuoted";
			case 'I':
				return "Funari";
			case 'J':
				return "MIT";
			case 'K':
				return "MarketWithLeftoverAsLimit";
			case 'L':
				return "PreviousFundValuationPoint";
			case 'M':
				return "NextFundValuationPoint";
			case 'P':
				return "Pegged";
			}
			return "Unknown";
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0001D860 File Offset: 0x0001C860
		public static OrdType FromFIX(char ordType)
		{
			switch (ordType)
			{
			case '1':
				return OrdType.Market;
			case '2':
				return OrdType.Limit;
			case '3':
				return OrdType.Stop;
			case '4':
				return OrdType.StopLimit;
			case '5':
				return OrdType.MarketOnClose;
			case '6':
				return OrdType.WithOrWithout;
			case '7':
				return OrdType.LimitOrBetter;
			case '8':
				return OrdType.LimitWithOrWithout;
			case '9':
				return OrdType.OnBasis;
			case 'A':
				return OrdType.OnClose;
			case 'B':
				return OrdType.LimitOnClose;
			case 'C':
				return OrdType.ForexMarket;
			case 'D':
				return OrdType.PreviouslyQuoted;
			case 'E':
				return OrdType.PreviouslyIndicated;
			case 'F':
				return OrdType.ForexLimit;
			case 'G':
				return OrdType.ForexSwap;
			case 'H':
				return OrdType.ForexPreviouslyQuoted;
			case 'I':
				return OrdType.Funari;
			case 'J':
				return OrdType.MIT;
			case 'K':
				return OrdType.MarketWithLeftoverAsLimit;
			case 'L':
				return OrdType.PreviousFundValuationPoint;
			case 'M':
				return OrdType.NextFundValuationPoint;
			case 'P':
				return OrdType.Pegged;
			case 'T':
				return OrdType.TrailingStop;
			}
			throw new ArgumentException("Unknown order type - " + ordType);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0001D960 File Offset: 0x0001C960
		public static char ToFIX(OrdType ordType)
		{
			switch (ordType)
			{
			case OrdType.Market:
				return '1';
			case OrdType.Limit:
				return '2';
			case OrdType.Stop:
				return '3';
			case OrdType.StopLimit:
				return '4';
			case OrdType.MarketOnClose:
				return '5';
			case OrdType.WithOrWithout:
				return '6';
			case OrdType.LimitOrBetter:
				return '7';
			case OrdType.LimitWithOrWithout:
				return '8';
			case OrdType.OnBasis:
				return '9';
			case OrdType.OnClose:
				return 'A';
			case OrdType.LimitOnClose:
				return 'B';
			case OrdType.ForexMarket:
				return 'C';
			case OrdType.PreviouslyQuoted:
				return 'D';
			case OrdType.PreviouslyIndicated:
				return 'E';
			case OrdType.ForexLimit:
				return 'F';
			case OrdType.ForexSwap:
				return 'G';
			case OrdType.ForexPreviouslyQuoted:
				return 'H';
			case OrdType.Funari:
				return 'I';
			case OrdType.MIT:
				return 'J';
			case OrdType.MarketWithLeftoverAsLimit:
				return 'K';
			case OrdType.PreviousFundValuationPoint:
				return 'L';
			case OrdType.NextFundValuationPoint:
				return 'M';
			case OrdType.Pegged:
				return 'P';
			case OrdType.TrailingStop:
				return 'T';
			default:
				throw new Exception("Unknown order type - " + ordType.ToString());
			}
		}

		// Token: 0x040002BA RID: 698
		public const char Market = '1';

		// Token: 0x040002BB RID: 699
		public const char Limit = '2';

		// Token: 0x040002BC RID: 700
		public const char Stop = '3';

		// Token: 0x040002BD RID: 701
		public const char StopLimit = '4';

		// Token: 0x040002BE RID: 702
		public const char MarketOnClose = '5';

		// Token: 0x040002BF RID: 703
		public const char WithOrWithout = '6';

		// Token: 0x040002C0 RID: 704
		public const char LimitOrBetter = '7';

		// Token: 0x040002C1 RID: 705
		public const char LimitWithOrWithout = '8';

		// Token: 0x040002C2 RID: 706
		public const char OnBasis = '9';

		// Token: 0x040002C3 RID: 707
		public const char OnClose = 'A';

		// Token: 0x040002C4 RID: 708
		public const char LimitOnClose = 'B';

		// Token: 0x040002C5 RID: 709
		public const char ForexMarket = 'C';

		// Token: 0x040002C6 RID: 710
		public const char PreviouslyQuoted = 'D';

		// Token: 0x040002C7 RID: 711
		public const char PreviouslyIndicated = 'E';

		// Token: 0x040002C8 RID: 712
		public const char ForexLimit = 'F';

		// Token: 0x040002C9 RID: 713
		public const char ForexSwap = 'G';

		// Token: 0x040002CA RID: 714
		public const char ForexPreviouslyQuoted = 'H';

		// Token: 0x040002CB RID: 715
		public const char Funari = 'I';

		// Token: 0x040002CC RID: 716
		public const char MIT = 'J';

		// Token: 0x040002CD RID: 717
		public const char MarketWithLeftoverAsLimit = 'K';

		// Token: 0x040002CE RID: 718
		public const char PreviousFundValuationPoint = 'L';

		// Token: 0x040002CF RID: 719
		public const char NextFundValuationPoint = 'M';

		// Token: 0x040002D0 RID: 720
		public const char Pegged = 'P';

		// Token: 0x040002D1 RID: 721
		public const char TrailingStop = 'T';
	}
}
