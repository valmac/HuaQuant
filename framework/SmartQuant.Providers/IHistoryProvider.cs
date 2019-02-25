using System;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000048 RID: 72
	public interface IHistoryProvider : IProvider
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A9 RID: 425
		bool TradeSupported { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001AA RID: 426
		bool QuoteSupported { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001AB RID: 427
		bool BarSupported { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001AC RID: 428
		bool DailySupported { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001AD RID: 429
		bool MarketDepthSupported { get; }

		// Token: 0x060001AE RID: 430
		Daily[] GetDailyHistory(IFIXInstrument instrument, DateTime datetime1, DateTime datetime2, bool dividendAndSplitAdjusted);

		// Token: 0x060001AF RID: 431
		Bar[] GetBarHistory(IFIXInstrument instrument, DateTime datetime1, DateTime datetime2, int barSize);

		// Token: 0x060001B0 RID: 432
		Trade[] GetTradeHistory(IFIXInstrument instrument, DateTime datetime1, DateTime datetime2);

		// Token: 0x060001B1 RID: 433
		Quote[] GetQuoteHistory(IFIXInstrument instrument, DateTime datetime1, DateTime datetime2);

		// Token: 0x060001B2 RID: 434
		MarketDepth[] GetMarketDepthHistory(IFIXInstrument instrument, DateTime datetime1, DateTime datetime2);
	}
}
