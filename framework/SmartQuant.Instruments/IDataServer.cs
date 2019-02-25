using System;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x02000020 RID: 32
	public interface IDataServer
	{
		// Token: 0x06000219 RID: 537
		void Add(string series, IDataObject obj);

		// Token: 0x0600021A RID: 538
		void Remove(string series, DateTime dateTime);

		// Token: 0x0600021B RID: 539
		void Update(string series, IDataObject obj);

		// Token: 0x0600021C RID: 540
		TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2);

		// Token: 0x0600021D RID: 541
		QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2);

		// Token: 0x0600021E RID: 542
		BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2);

		// Token: 0x0600021F RID: 543
		DailySeries GetDailySeries(string series, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000220 RID: 544
		MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000221 RID: 545
		IDataSeries AddDataSeries(string series);

		// Token: 0x06000222 RID: 546
		IDataSeries GetDataSeries(string series);

		// Token: 0x06000223 RID: 547
		DataSeriesList GetDataSeries();

		// Token: 0x06000224 RID: 548
		void Delete(string series);

		// Token: 0x06000225 RID: 549
		void Clear(string series);

		// Token: 0x06000226 RID: 550
		void Rename(string oldSeries, string newSeries);

		// Token: 0x06000227 RID: 551
		void Flush();

		// Token: 0x06000228 RID: 552
		void Close();
	}
}
