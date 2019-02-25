using System;
using System.Collections;
using SmartQuant.Data;

namespace SmartQuant.DataCenterLib
{
	// Token: 0x02000008 RID: 8
	public interface IDataCenterConnection
	{
		// Token: 0x06000011 RID: 17
		void Close();

		// Token: 0x06000012 RID: 18
		Daily[] GetDailyArray(string symbol, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000013 RID: 19
		Bar[] GetBarArray(string symbol, DateTime datetime1, DateTime datetime2, int barSize);

		// Token: 0x06000014 RID: 20
		Trade[] GetTradeArray(string symbol, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000015 RID: 21
		Quote[] GetQuoteArray(string symbol, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000016 RID: 22
		MarketDepth[] GetMarketDepthArray(string symbol, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000017 RID: 23
		DataSeriesInfo[] GetDataSeriesInfo();

		// Token: 0x06000018 RID: 24
		IDataSeriesEnumerator GetEnumerator(string series, DateTime datetime1, DateTime datetime2);

		// Token: 0x06000019 RID: 25
		ArrayList GetSecurityDefinitionList(string symbol, string securityType, string securityExchange);
	}
}
