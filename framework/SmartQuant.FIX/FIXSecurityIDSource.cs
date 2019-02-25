using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000B9 RID: 185
	public class FIXSecurityIDSource : FIXCharField
	{
		// Token: 0x06002604 RID: 9732 RVA: 0x00028A61 File Offset: 0x00027A61
		public FIXSecurityIDSource(char val) : base(22, val)
		{
		}

		// Token: 0x04000367 RID: 871
		public const char CUSIP = '1';

		// Token: 0x04000368 RID: 872
		public const char SEDOL = '2';

		// Token: 0x04000369 RID: 873
		public const char QUICK = '3';

		// Token: 0x0400036A RID: 874
		public const char ISIN = '4';

		// Token: 0x0400036B RID: 875
		public const char RIC = '5';

		// Token: 0x0400036C RID: 876
		public const char ISOCurrencyCode = '6';

		// Token: 0x0400036D RID: 877
		public const char ISOCountryCode = '7';

		// Token: 0x0400036E RID: 878
		public const char ExchangeSymbol = '8';

		// Token: 0x0400036F RID: 879
		public const char CTA = '9';

		// Token: 0x04000370 RID: 880
		public const char BloomberSymbol = 'A';

		// Token: 0x04000371 RID: 881
		public const char Wertpapier = 'B';

		// Token: 0x04000372 RID: 882
		public const char Dutch = 'C';

		// Token: 0x04000373 RID: 883
		public const char Valoren = 'D';

		// Token: 0x04000374 RID: 884
		public const char Sicovam = 'E';

		// Token: 0x04000375 RID: 885
		public const char Belgian = 'F';

		// Token: 0x04000376 RID: 886
		public const char Common = 'G';
	}
}
