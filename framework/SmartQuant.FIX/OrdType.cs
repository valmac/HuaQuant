using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000EC RID: 236
	public enum OrdType
	{
		// Token: 0x040003EF RID: 1007
		Undefined,
		// Token: 0x040003F0 RID: 1008
		Market,
		// Token: 0x040003F1 RID: 1009
		Limit,
		// Token: 0x040003F2 RID: 1010
		Stop,
		// Token: 0x040003F3 RID: 1011
		StopLimit,
		// Token: 0x040003F4 RID: 1012
		MarketOnClose,
		// Token: 0x040003F5 RID: 1013
		WithOrWithout,
		// Token: 0x040003F6 RID: 1014
		LimitOrBetter,
		// Token: 0x040003F7 RID: 1015
		LimitWithOrWithout,
		// Token: 0x040003F8 RID: 1016
		OnBasis,
		// Token: 0x040003F9 RID: 1017
		OnClose,
		// Token: 0x040003FA RID: 1018
		LimitOnClose,
		// Token: 0x040003FB RID: 1019
		ForexMarket,
		// Token: 0x040003FC RID: 1020
		PreviouslyQuoted,
		// Token: 0x040003FD RID: 1021
		PreviouslyIndicated,
		// Token: 0x040003FE RID: 1022
		ForexLimit,
		// Token: 0x040003FF RID: 1023
		ForexSwap,
		// Token: 0x04000400 RID: 1024
		ForexPreviouslyQuoted,
		// Token: 0x04000401 RID: 1025
		Funari,
		// Token: 0x04000402 RID: 1026
		MIT,
		// Token: 0x04000403 RID: 1027
		MarketWithLeftoverAsLimit,
		// Token: 0x04000404 RID: 1028
		PreviousFundValuationPoint,
		// Token: 0x04000405 RID: 1029
		NextFundValuationPoint,
		// Token: 0x04000406 RID: 1030
		Pegged,
		// Token: 0x04000407 RID: 1031
		TrailingStop
	}
}
