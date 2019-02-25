using System;
using System.Collections;
using System.IO;
using SmartQuant.Data;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments.Xml;
using SmartQuant.Providers;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x0200001A RID: 26
	public class DataManager
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00004D90 File Offset: 0x00003D90
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00004D97 File Offset: 0x00003D97
		public static int BarArrayLength
		{
			get
			{
				return DataManager.fBarArrayLength;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value", value, "The value must be equal or greater than -1.");
				}
				DataManager.fBarArrayLength = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00004DBE File Offset: 0x00003DBE
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00004DC5 File Offset: 0x00003DC5
		public static int QuoteArrayLength
		{
			get
			{
				return DataManager.fQuoteArrayLength;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value", value, "The value must be equal or greater than -1.");
				}
				DataManager.fQuoteArrayLength = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00004DEC File Offset: 0x00003DEC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00004DF3 File Offset: 0x00003DF3
		public static int TradeArrayLength
		{
			get
			{
				return DataManager.fTradeArrayLength;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value", value, "The value must be equal or greater than -1.");
				}
				DataManager.fTradeArrayLength = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00004E1A File Offset: 0x00003E1A
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00004E21 File Offset: 0x00003E21
		public static int FundamentalArrayLength
		{
			get
			{
				return DataManager.fFundamentalArrayLength;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value", value, "The value must be equal or greater than -1.");
				}
				DataManager.fFundamentalArrayLength = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00004E48 File Offset: 0x00003E48
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00004E4F File Offset: 0x00003E4F
		public static int CorporateActionArrayLength
		{
			get
			{
				return DataManager.fCorporateActionArrayLength;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value", value, "The value must be equal or greater than -1.");
				}
				DataManager.fCorporateActionArrayLength = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00004E76 File Offset: 0x00003E76
		public static void ClearDataArrays()
		{
			DataManager.fBars.Clear();
			DataManager.fTradeArrays.Clear(true);
			DataManager.fQuoteArrays.Clear(true);
			DataManager.fFundamentalArrays.Clear(true);
			DataManager.fCorporateActionArrays.Clear(true);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00004EAE File Offset: 0x00003EAE
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00004EB5 File Offset: 0x00003EB5
		public static BarType DefaultBarType
		{
			get
			{
				return DataManager.defaultBarType;
			}
			set
			{
				DataManager.defaultBarType = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00004EC2 File Offset: 0x00003EC2
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00004EC9 File Offset: 0x00003EC9
		public static long DefaultBarSize
		{
			get
			{
				return DataManager.defaultBarSize;
			}
			set
			{
				if (value <= 0L)
				{
					throw new ArgumentOutOfRangeException("value", value, "The value must be greater than 0.");
				}
				DataManager.defaultBarSize = value;
				DataManager.SaveSettings();
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00004EF1 File Offset: 0x00003EF1
		public static BarSeriesList Bars
		{
			get
			{
				return DataManager.fBars;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00004EF8 File Offset: 0x00003EF8
		public static TradeArrayList Trades
		{
			get
			{
				return DataManager.fTradeArrays;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00004EFF File Offset: 0x00003EFF
		public static QuoteArrayList Quotes
		{
			get
			{
				return DataManager.fQuoteArrays;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00004F06 File Offset: 0x00003F06
		public static FundamentalArrayList Fundamentals
		{
			get
			{
				return DataManager.fFundamentalArrays;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00004F0D File Offset: 0x00003F0D
		public static CorporateActionArrayList CorporateActions
		{
			get
			{
				return DataManager.fCorporateActionArrays;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00004F14 File Offset: 0x00003F14
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00004F1B File Offset: 0x00003F1B
		public static IMarketDataFilter Filter
		{
			get
			{
				return DataManager.fFilter;
			}
			set
			{
				DataManager.fFilter = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00004F23 File Offset: 0x00003F23
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00004F2A File Offset: 0x00003F2A
		public static IDataServer Server
		{
			get
			{
				return DataManager.fServer;
			}
			set
			{
				DataManager.fServer = value;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004F34 File Offset: 0x00003F34
		static DataManager()
		{
			DataManager.Init();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004FA0 File Offset: 0x00003FA0
		public static void Init()
		{
			if (!DataManager.fIsInitialized)
			{
				if (Trace.IsLevelEnabled(TraceLevel.Info))
				{
					Trace.WriteLine("Initializing DataManager...");
				}
				ProviderManager.NewQuote += DataManager.OnNewQuote;
				ProviderManager.NewTrade += DataManager.OnNewTrade;
				ProviderManager.NewBar += DataManager.OnNewBar;
				ProviderManager.NewBarOpen += DataManager.OnNewBarOpen;
				ProviderManager.NewMarketDepth += DataManager.OnNewMarketDepth;
				ProviderManager.NewFundamental += DataManager.OnNewFundamental;
				ProviderManager.NewCorporateAction += DataManager.OnNewCorporateAction;
				ProviderManager.MarketDataRequestReject += DataManager.OnMarketDataRequestReject;
				ProviderManager.Connected += DataManager.OnProviderConnected;
				DataManager.fBarArrayLength = -1;
				DataManager.fTradeArrayLength = -1;
				DataManager.fQuoteArrayLength = -1;
				DataManager.fFundamentalArrayLength = -1;
				DataManager.fCorporateActionArrayLength = -1;
				DataManager.defaultBarType = BarType.Time;
				DataManager.defaultBarSize = 60L;
				DataManager.LoadSettings();
				DataManager.fIsInitialized = true;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000509D File Offset: 0x0000409D
		public static void Add(string series, Trade trade)
		{
			DataManager.fServer.Add(series, trade);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000050AB File Offset: 0x000040AB
		public static void Add(string series, Quote quote)
		{
			DataManager.fServer.Add(series, quote);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000050B9 File Offset: 0x000040B9
		public static void Add(string series, Bar bar)
		{
			DataManager.fServer.Update(series, bar);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000050C7 File Offset: 0x000040C7
		public static void Add(string series, MarketDepth marketDepth)
		{
			DataManager.fServer.Add(series, marketDepth);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000050D5 File Offset: 0x000040D5
		public static void Add(string series, Fundamental fundamental)
		{
			DataManager.fServer.Add(series, fundamental);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000050E3 File Offset: 0x000040E3
		public static void Add(string series, CorporateAction corporateAction)
		{
			DataManager.fServer.Add(series, corporateAction);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000050F1 File Offset: 0x000040F1
		public static void Add(Instrument instrument, string suffix, Trade trade)
		{
			DataManager.Add(instrument.Symbol + '.' + suffix, trade);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000510C File Offset: 0x0000410C
		public static void Add(Instrument instrument, string suffix, Quote quote)
		{
			DataManager.Add(instrument.Symbol + '.' + suffix, quote);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005127 File Offset: 0x00004127
		public static void Add(Instrument instrument, string suffix, Bar bar)
		{
			DataManager.Add(instrument.Symbol + '.' + suffix, bar);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005142 File Offset: 0x00004142
		public static void Add(Instrument instrument, string suffix, MarketDepth marketDepth)
		{
			DataManager.Add(instrument.Symbol + '.' + suffix, marketDepth);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000515D File Offset: 0x0000415D
		public static void Add(Instrument instrument, string suffix, Fundamental fundamental)
		{
			DataManager.Add(instrument.Symbol + '.' + suffix, fundamental);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005178 File Offset: 0x00004178
		public static void Add(Instrument instrument, string suffix, CorporateAction corporateAction)
		{
			DataManager.Add(instrument.Symbol + '.' + suffix, corporateAction);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005193 File Offset: 0x00004193
		public static void Add(Instrument instrument, Trade trade)
		{
			DataManager.Add(instrument, "Trade", trade);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000051A1 File Offset: 0x000041A1
		public static void Add(Instrument instrument, Quote quote)
		{
			DataManager.Add(instrument, "Quote", quote);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000051B0 File Offset: 0x000041B0
		public static void Add(Instrument instrument, Bar bar)
		{
			string suffix = string.Concat(new object[]
			{
				"Bar",
				'.',
				bar.BarType.ToString(),
				'.',
				bar.Size.ToString()
			});
			DataManager.Add(instrument, suffix, bar);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005213 File Offset: 0x00004213
		public static void Add(Instrument instrument, Daily daily)
		{
			DataManager.Add(instrument, "Daily", daily);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005221 File Offset: 0x00004221
		public static void Add(Instrument instrument, MarketDepth marketDepth)
		{
			DataManager.Add(instrument, "Depth", marketDepth);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000522F File Offset: 0x0000422F
		public static void Add(Instrument instrument, Fundamental fundamental)
		{
			DataManager.Add(instrument, "Fund", fundamental);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000523D File Offset: 0x0000423D
		public static void Add(Instrument instrument, CorporateAction corporateAction)
		{
			DataManager.Add(instrument, "Corp", corporateAction);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000524B File Offset: 0x0000424B
		public static TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.fServer.GetTradeArray(series, datetime1, datetime2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000525A File Offset: 0x0000425A
		public static TradeArray GetTradeArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetTradeArray(instrument.Symbol + '.' + suffix, datetime1, datetime2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005276 File Offset: 0x00004276
		public static TradeArray GetTradeArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetTradeArray(instrument, "Trade", datetime1, datetime2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005285 File Offset: 0x00004285
		public static QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.fServer.GetQuoteArray(series, datetime1, datetime2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005294 File Offset: 0x00004294
		public static QuoteArray GetQuoteArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetQuoteArray(instrument.Symbol + '.' + suffix, datetime1, datetime2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000052B0 File Offset: 0x000042B0
		public static QuoteArray GetQuoteArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetQuoteArray(instrument, "Quote", datetime1, datetime2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000052BF File Offset: 0x000042BF
		public static MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.fServer.GetMarketDepthArray(series, datetime1, datetime2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000052CE File Offset: 0x000042CE
		public static MarketDepthArray GetMarketDepthArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetMarketDepthArray(instrument.Symbol + '.' + suffix, datetime1, datetime2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000052EA File Offset: 0x000042EA
		public static MarketDepthArray GetMarketDepthArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetMarketDepthArray(instrument, "Depth", datetime1, datetime2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000052F9 File Offset: 0x000042F9
		public static BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.fServer.GetBarSeries(series, datetime1, datetime2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005308 File Offset: 0x00004308
		public static BarSeries GetBarSeries(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetBarSeries(instrument.Symbol + '.' + suffix, datetime1, datetime2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005324 File Offset: 0x00004324
		public static BarSeries GetBarSeries(Instrument instrument, DateTime datetime1, DateTime datetime2, BarType barType, long barSize)
		{
			string suffix = string.Format("{0}{1}{2}{3}{4}", new object[]
			{
				"Bar",
				'.',
				barType,
				'.',
				barSize
			});
			return DataManager.GetBarSeries(instrument, suffix, datetime1, datetime2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000537C File Offset: 0x0000437C
		public static BarSeries GetBarSeries(Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetBarSeries(instrument, datetime1, datetime2, DataManager.defaultBarType, DataManager.defaultBarSize);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005390 File Offset: 0x00004390
		public static DailySeries GetDailySeries(Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			string series = instrument.Symbol + '.' + "Daily";
			DailySeries dailySeries = DataManager.fServer.GetDailySeries(series, datetime1, datetime2);
			dailySeries.Name = instrument.Symbol;
			return dailySeries;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000053D0 File Offset: 0x000043D0
		public static DailySeries GetDailySeries(Instrument instrument)
		{
			return DataManager.GetDailySeries(instrument, DateTime.MinValue, DateTime.MaxValue);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000053E2 File Offset: 0x000043E2
		public static IDataSeries GetDataSeries(Instrument instrument, string suffix)
		{
			return DataManager.fServer.GetDataSeries(instrument.Symbol + '.' + suffix);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005401 File Offset: 0x00004401
		public static IDataSeries AddDataSeries(Instrument instrument, string suffix)
		{
			return DataManager.fServer.AddDataSeries(instrument.Symbol + '.' + suffix);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005420 File Offset: 0x00004420
		public static void DeleteDataSeries(string series)
		{
			DataManager.fServer.Delete(series);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000542D File Offset: 0x0000442D
		public static void ClearDataSeries(string series)
		{
			DataManager.fServer.Clear(series);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000543C File Offset: 0x0000443C
		public static IDataSeries GetDataSeries(Instrument instrument, DataManager.EDataSeries series)
		{
			string arg;
			switch (series)
			{
			case DataManager.EDataSeries.Daily:
				arg = "Daily";
				break;
			case DataManager.EDataSeries.Trade:
				arg = "Trade";
				break;
			case DataManager.EDataSeries.Quote:
				arg = "Quote";
				break;
			case DataManager.EDataSeries.Bar:
				arg = "Bar";
				break;
			case DataManager.EDataSeries.MarketDepth:
				arg = "Depth";
				break;
			case DataManager.EDataSeries.Fundamental:
				arg = "Fund";
				break;
			case DataManager.EDataSeries.CorporateAction:
				arg = "Corp";
				break;
			default:
				throw new ArgumentException("Unknown data series type : " + series.ToString());
			}
			return DataManager.fServer.GetDataSeries(instrument.Symbol + '.' + arg);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000054E4 File Offset: 0x000044E4
		public static DataSeriesList GetDataSeries(Instrument instrument)
		{
			DataSeriesList dataSeriesList = new DataSeriesList();
			foreach (object obj in DataManager.fServer.GetDataSeries())
			{
				IDataSeries dataSeries = (IDataSeries)obj;
				if (dataSeries.Name.StartsWith(instrument.Symbol + '.'))
				{
					dataSeriesList.Add(dataSeries);
				}
			}
			return dataSeriesList;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005568 File Offset: 0x00004568
		public static void Close()
		{
			DataManager.fServer.Close();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005574 File Offset: 0x00004574
		public static void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
		{
			DataManager.SendMarketDataRequest(provider, instrument, mdType, '1', suffix);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005581 File Offset: 0x00004581
		public static void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
		{
			DataManager.RequestMarketData(provider, instrument, mdType, '.' + "*");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000559C File Offset: 0x0000459C
		public static void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
		{
			DataManager.SendMarketDataRequest(provider, instrument, mdType, '2', suffix);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000055A9 File Offset: 0x000045A9
		public static void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
		{
			DataManager.CancelMarketData(provider, instrument, mdType, '.' + "*");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000055C4 File Offset: 0x000045C4
		public static bool IsSubscribed(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
		{
			Hashtable hashtable = DataManager.fRequests[provider] as Hashtable;
			if (hashtable == null)
			{
				return false;
			}
			Hashtable hashtable2 = hashtable[instrument] as Hashtable;
			return hashtable2 != null && hashtable2.ContainsKey(mdType);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005605 File Offset: 0x00004605
		private static void SendMarketDataRequest(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, char subscriptionRequestType, string seriesSuffix)
		{
			if ((byte)(mdType & MarketDataType.Trade) == 1)
			{
				DataManager.SendMarketDataSingleRequest(provider, instrument, MarketDataType.Trade, subscriptionRequestType, seriesSuffix);
			}
			if ((byte)(mdType & MarketDataType.Quote) == 2)
			{
				DataManager.SendMarketDataSingleRequest(provider, instrument, MarketDataType.Quote, subscriptionRequestType, seriesSuffix);
			}
			if ((byte)(mdType & MarketDataType.MarketDepth) == 4)
			{
				DataManager.SendMarketDataSingleRequest(provider, instrument, MarketDataType.MarketDepth, subscriptionRequestType, seriesSuffix);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00005640 File Offset: 0x00004640
		private static void SendMarketDataSingleRequest(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, char subscriptionRequestType, string seriesSuffix)
		{
			FIXMarketDataRequest fixmarketDataRequest = new FIXMarketDataRequest();
			fixmarketDataRequest.MDReqID = DataManager.GetNextMDReqID();
			fixmarketDataRequest.SubscriptionRequestType = subscriptionRequestType;
			switch (mdType)
			{
			case MarketDataType.Trade:
				fixmarketDataRequest.AddGroup(new FIXMDEntryTypesGroup('2'));
				break;
			case MarketDataType.Quote:
				fixmarketDataRequest.AddGroup(new FIXMDEntryTypesGroup('0'));
				fixmarketDataRequest.AddGroup(new FIXMDEntryTypesGroup('1'));
				fixmarketDataRequest.MarketDepth = 1;
				break;
			case MarketDataType.MarketDepth:
				fixmarketDataRequest.AddGroup(new FIXMDEntryTypesGroup('0'));
				fixmarketDataRequest.AddGroup(new FIXMDEntryTypesGroup('1'));
				fixmarketDataRequest.MarketDepth = 0;
				break;
			}
			if (!instrument.ContainsField(15))
			{
				instrument.Currency = Framework.Configuration.DefaultCurrency;
			}
			FIXRelatedSymGroup fixrelatedSymGroup = new FIXRelatedSymGroup();
			fixmarketDataRequest.AddGroup(fixrelatedSymGroup);
			fixrelatedSymGroup.Symbol = instrument.Symbol;
			fixrelatedSymGroup.SecurityType = instrument.SecurityType;
			fixrelatedSymGroup.SecurityExchange = instrument.SecurityExchange;
			fixrelatedSymGroup.Currency = instrument.Currency;
			fixrelatedSymGroup.SecurityID = instrument.SecurityID;
			fixrelatedSymGroup.SecurityIDSource = instrument.SecurityIDSource;
			fixrelatedSymGroup.MaturityDate = instrument.MaturityDate;
			fixrelatedSymGroup.MaturityMonthYear = instrument.MaturityMonthYear;
			fixrelatedSymGroup.StrikePrice = instrument.StrikePrice;
			fixrelatedSymGroup.PutOrCall = (int)instrument.PutOrCall;
			foreach (object obj in instrument.SecurityAltIDGroup)
			{
				FIXSecurityAltIDGroup group = (FIXSecurityAltIDGroup)obj;
				fixrelatedSymGroup.AddGroup(group);
			}
			fixrelatedSymGroup.SetStringValue(10001, seriesSuffix);
			if (provider == ProviderManager.MarketDataSimulator)
			{
				provider.SendMarketDataRequest(fixmarketDataRequest);
				return;
			}
			switch (subscriptionRequestType)
			{
			case '1':
			{
				Hashtable hashtable = DataManager.fRequests[provider] as Hashtable;
				if (hashtable == null)
				{
					hashtable = new Hashtable();
					DataManager.fRequests.Add(provider, hashtable);
				}
				Hashtable hashtable2 = hashtable[instrument] as Hashtable;
				if (hashtable2 == null)
				{
					hashtable2 = new Hashtable();
					hashtable.Add(instrument, hashtable2);
				}
				RequestRecord requestRecord = hashtable2[mdType] as RequestRecord;
				if (requestRecord == null)
				{
					requestRecord = new RequestRecord(fixmarketDataRequest);
					hashtable2.Add(mdType, requestRecord);
					provider.SendMarketDataRequest(fixmarketDataRequest);
				}
				requestRecord.Count++;
				return;
			}
			case '2':
			{
				Hashtable hashtable3 = DataManager.fRequests[provider] as Hashtable;
				if (hashtable3 == null)
				{
					DataManager.LogUnsubscribeWarning(provider, instrument, mdType, "There are no requests for the provider.");
					return;
				}
				Hashtable hashtable4 = hashtable3[instrument] as Hashtable;
				if (hashtable4 == null)
				{
					DataManager.LogUnsubscribeWarning(provider, instrument, mdType, "There are no requests for the instrument.");
					return;
				}
				RequestRecord requestRecord2 = hashtable4[mdType] as RequestRecord;
				if (requestRecord2 == null)
				{
					DataManager.LogUnsubscribeWarning(provider, instrument, mdType, "Request type not found.");
					return;
				}
				requestRecord2.Count--;
				if (requestRecord2.Count == 0)
				{
					hashtable4.Remove(mdType);
					if (hashtable4.Count == 0)
					{
						hashtable3.Remove(instrument);
						if (hashtable3.Count == 0)
						{
							DataManager.fRequests.Remove(provider);
						}
					}
					provider.SendMarketDataRequest(fixmarketDataRequest);
				}
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005948 File Offset: 0x00004948
		private static void LogUnsubscribeWarning(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string message)
		{
			if (Trace.IsLevelEnabled(TraceLevel.Warning))
			{
				Trace.WriteLine(string.Concat(new string[]
				{
					"DataManager <MARKET_DATA_UNSUBSCRIBE>:",
					Environment.NewLine,
					"Provider: ",
					provider.Name,
					Environment.NewLine,
					"Instrument: ",
					instrument.Symbol,
					Environment.NewLine,
					"MarketDataType: ",
					mdType.ToString(),
					Environment.NewLine,
					"Message: ",
					message
				}));
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000059E7 File Offset: 0x000049E7
		private static string GetNextMDReqID()
		{
			return string.Format("{0:yyMMddHHmmss} {1}", Clock.Now, DataManager.fMDReqID++);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005A10 File Offset: 0x00004A10
		private static void OnNewQuote(object sender, QuoteEventArgs args)
		{
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			Quote quote = args.Quote;
			if (DataManager.fFilter != null)
			{
				quote = DataManager.fFilter.Filter(quote, instrument, args.Provider);
			}
			if (quote == null)
			{
				return;
			}
			if (instrument != null)
			{
				QuoteArray quoteArray = DataManager.fQuoteArrays[instrument];
				quoteArray.Add(quote);
				if (DataManager.fQuoteArrayLength != -1 && quoteArray.Count > DataManager.fQuoteArrayLength)
				{
					quoteArray.RemoveAt(0);
				}
				instrument.SetNewQuote(new QuoteEventArgs(quote, instrument, args.Provider));
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005AB8 File Offset: 0x00004AB8
		private static void OnNewTrade(object sender, TradeEventArgs args)
		{
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			Trade trade = args.Trade;
			if (DataManager.fFilter != null)
			{
				trade = DataManager.fFilter.Filter(trade, instrument, args.Provider);
			}
			if (trade == null)
			{
				return;
			}
			if (instrument != null)
			{
				TradeArray tradeArray = DataManager.fTradeArrays[instrument];
				tradeArray.Add(trade);
				if (DataManager.fTradeArrayLength != -1 && tradeArray.Count > DataManager.fTradeArrayLength)
				{
					tradeArray.RemoveAt(0);
				}
				instrument.SetNewTrade(new TradeEventArgs(trade, instrument, args.Provider));
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005B60 File Offset: 0x00004B60
		private static void OnNewBar(object sender, BarEventArgs args)
		{
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine("<DataManager.OnNewBar> " + args);
			}
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			if (instrument != null)
			{
				DataManager.fBars.AddBar(instrument, args.Bar);
				BarSeries barSeries = DataManager.fBars[instrument, args.Bar.BarType, args.Bar.Size];
				if (DataManager.fBarArrayLength != -1 && barSeries.Count > DataManager.fBarArrayLength)
				{
					barSeries.Remove(0);
				}
				instrument.SetNewBar(args);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005C14 File Offset: 0x00004C14
		private static void OnNewBarOpen(object sender, BarEventArgs args)
		{
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine("<DataManager.OnNewBarOpen> " + args);
			}
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			if (instrument != null)
			{
				instrument.SetNewBarOpen(args);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005C78 File Offset: 0x00004C78
		private static void OnNewMarketDepth(object sender, MarketDepthEventArgs args)
		{
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			if (instrument != null)
			{
				instrument.SetNewMarketDepth(args);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005CC0 File Offset: 0x00004CC0
		private static void OnNewFundamental(object sender, FundamentalEventArgs args)
		{
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			if (instrument != null)
			{
				FundamentalArray fundamentalArray = DataManager.fFundamentalArrays[instrument];
				fundamentalArray.Add(args.Fundamental);
				if (DataManager.fFundamentalArrayLength != -1 && fundamentalArray.Count > DataManager.fFundamentalArrayLength)
				{
					fundamentalArray.RemoveAt(0);
				}
				instrument.SetNewFundamental(args);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005D3C File Offset: 0x00004D3C
		private static void OnNewCorporateAction(object sender, CorporateActionEventArgs args)
		{
			Instrument instrument = args.Instrument as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Instrument.Symbol, args.Provider.Name];
			}
			if (instrument != null)
			{
				CorporateActionArray corporateActionArray = DataManager.fCorporateActionArrays[instrument];
				corporateActionArray.Add(args.CorporateAction);
				if (DataManager.fCorporateActionArrayLength != -1 && corporateActionArray.Count > DataManager.fCorporateActionArrayLength)
				{
					corporateActionArray.RemoveAt(0);
				}
				instrument.SetNewCorporateAction(args);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005DB7 File Offset: 0x00004DB7
		private static void OnMarketDataRequestReject(object sender, MarketDataRequestRejectEventArgs args)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005DBC File Offset: 0x00004DBC
		private static void OnProviderConnected(ProviderEventArgs args)
		{
			IMarketDataProvider marketDataProvider = args.Provider as IMarketDataProvider;
			if (marketDataProvider == null || marketDataProvider == ProviderManager.MarketDataSimulator)
			{
				return;
			}
			Hashtable hashtable = DataManager.fRequests[marketDataProvider] as Hashtable;
			if (hashtable != null)
			{
				foreach (object obj in hashtable.Values)
				{
					Hashtable hashtable2 = (Hashtable)obj;
					foreach (object obj2 in hashtable2.Values)
					{
						RequestRecord requestRecord = (RequestRecord)obj2;
						marketDataProvider.SendMarketDataRequest(requestRecord.Request);
					}
				}
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00005E98 File Offset: 0x00004E98
		public static BarSeries GetHistoricalBars(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2, long barSize)
		{
			ArrayList historicalData = DataManager.GetHistoricalData(provider, instrument, DataManager.EDataSeries.Bar, datetime1, datetime2, barSize);
			BarSeries barSeries = new BarSeries();
			foreach (object obj in historicalData)
			{
				Bar bar = (Bar)obj;
				barSeries.Add(bar);
			}
			return barSeries;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005F04 File Offset: 0x00004F04
		public static BarSeries GetHistoricalBars(string providerName, string symbol, DateTime datetime1, DateTime datetime2, long barSize)
		{
			return DataManager.GetHistoricalBars(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2, barSize);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005F28 File Offset: 0x00004F28
		public static DailySeries GetHistoricalDailies(IHistoricalDataProvider provider, Instrument instrument, DateTime date1, DateTime date2)
		{
			ArrayList historicalData = DataManager.GetHistoricalData(provider, instrument, DataManager.EDataSeries.Daily, date1, date2, -1L);
			DailySeries dailySeries = new DailySeries();
			foreach (object obj in historicalData)
			{
				Daily bar = (Daily)obj;
				dailySeries.Add(bar);
			}
			return dailySeries;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005F94 File Offset: 0x00004F94
		public static DailySeries GetHistoricalDailies(string providerName, string symbol, DateTime date1, DateTime date2)
		{
			return DataManager.GetHistoricalDailies(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], date1, date2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005FB4 File Offset: 0x00004FB4
		public static TradeArray GetHistoricalTrades(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			ArrayList historicalData = DataManager.GetHistoricalData(provider, instrument, DataManager.EDataSeries.Trade, datetime1, datetime2, -1L);
			TradeArray tradeArray = new TradeArray();
			foreach (object obj in historicalData)
			{
				Trade obj2 = (Trade)obj;
				tradeArray.Add(obj2);
			}
			return tradeArray;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006020 File Offset: 0x00005020
		public static TradeArray GetHistoricalTrades(string providerName, string symbol, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetHistoricalTrades(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006040 File Offset: 0x00005040
		public static QuoteArray GetHistoricalQuotes(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2)
		{
			ArrayList historicalData = DataManager.GetHistoricalData(provider, instrument, DataManager.EDataSeries.Quote, datetime1, datetime2, -1L);
			QuoteArray quoteArray = new QuoteArray();
			foreach (object obj in historicalData)
			{
				Quote obj2 = (Quote)obj;
				quoteArray.Add(obj2);
			}
			return quoteArray;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000060AC File Offset: 0x000050AC
		public static QuoteArray GetHistoricalQuotes(string providerName, string symbol, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetHistoricalQuotes(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000060CC File Offset: 0x000050CC
		private static ArrayList GetHistoricalData(IHistoricalDataProvider provider, Instrument instrument, DataManager.EDataSeries dataSeries, DateTime beginDate, DateTime endDate, long barSize)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			if (instrument == null)
			{
				throw new ArgumentNullException("instrument");
			}
			if (!provider.IsConnected)
			{
				provider.Connect(10000);
				if (!provider.IsConnected)
				{
					throw new InvalidOperationException("Cannot connect to provider.");
				}
			}
			HistoricalDataRequest historicalDataRequest = new HistoricalDataRequest();
			historicalDataRequest.Instrument = instrument;
			switch (dataSeries)
			{
			case DataManager.EDataSeries.Daily:
				historicalDataRequest.DataType = HistoricalDataType.Daily;
				break;
			case DataManager.EDataSeries.Trade:
				historicalDataRequest.DataType = HistoricalDataType.Trade;
				break;
			case DataManager.EDataSeries.Quote:
				historicalDataRequest.DataType = HistoricalDataType.Quote;
				break;
			case DataManager.EDataSeries.Bar:
				historicalDataRequest.DataType = HistoricalDataType.Bar;
				historicalDataRequest.BarSize = barSize;
				break;
			}
			historicalDataRequest.BeginDate = beginDate;
			historicalDataRequest.EndDate = endDate;
			return new HistoricalDataDownloader(provider, historicalDataRequest).GetObjects();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006188 File Offset: 0x00005188
		private static void LoadSettings()
		{
			FileInfo fileInfo = new FileInfo(Framework.Installation.IniDir.FullName + "\\DataManager.config.xml");
			if (fileInfo.Exists)
			{
				try
				{
					DataManagerXmlDocument dataManagerXmlDocument = new DataManagerXmlDocument();
					dataManagerXmlDocument.Load(fileInfo.FullName);
					DataManager.defaultBarType = dataManagerXmlDocument.DefaultBar.Type;
					DataManager.defaultBarSize = dataManagerXmlDocument.DefaultBar.Size;
					DataArrayListXmlNode dataArrayList = dataManagerXmlDocument.DataArrayList;
					DataManager.fBarArrayLength = dataArrayList[typeof(BarArray)].Length;
					DataManager.fTradeArrayLength = dataArrayList[typeof(TradeArray)].Length;
					DataManager.fQuoteArrayLength = dataArrayList[typeof(QuoteArray)].Length;
					DataManager.fFundamentalArrayLength = dataArrayList[typeof(FundamentalArray)].Length;
					DataManager.fCorporateActionArrayLength = dataArrayList[typeof(CorporateActionArray)].Length;
					return;
				}
				catch (Exception ex)
				{
					if (Trace.IsLevelEnabled(TraceLevel.Error))
					{
						Trace.WriteLine(ex.ToString());
					}
					return;
				}
			}
			DataManager.SaveSettings();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000062AC File Offset: 0x000052AC
		private static void SaveSettings()
		{
			DataManagerXmlDocument dataManagerXmlDocument = new DataManagerXmlDocument();
			dataManagerXmlDocument.DefaultBar.Type = DataManager.defaultBarType;
			dataManagerXmlDocument.DefaultBar.Size = DataManager.defaultBarSize;
			DataArrayListXmlNode dataArrayList = dataManagerXmlDocument.DataArrayList;
			dataArrayList[typeof(BarArray)].Length = DataManager.fBarArrayLength;
			dataArrayList[typeof(TradeArray)].Length = DataManager.fTradeArrayLength;
			dataArrayList[typeof(QuoteArray)].Length = DataManager.fQuoteArrayLength;
			dataArrayList[typeof(FundamentalArray)].Length = DataManager.fFundamentalArrayLength;
			dataArrayList[typeof(CorporateActionArray)].Length = DataManager.fCorporateActionArrayLength;
			dataManagerXmlDocument.Save(Framework.Installation.IniDir.FullName + "\\DataManager.config.xml");
		}

		// Token: 0x04000040 RID: 64
		public const string SUFFIX_TRADE = "Trade";

		// Token: 0x04000041 RID: 65
		public const string SUFFIX_QUOTE = "Quote";

		// Token: 0x04000042 RID: 66
		public const string SUFFIX_BAR = "Bar";

		// Token: 0x04000043 RID: 67
		public const string SUFFIX_DAILY = "Daily";

		// Token: 0x04000044 RID: 68
		public const string SUFFIX_MARKET_DEPTH = "Depth";

		// Token: 0x04000045 RID: 69
		public const string SUFFIX_FUNDAMENTAL = "Fund";

		// Token: 0x04000046 RID: 70
		public const string SUFFIX_CORPORATE_ACTION = "Corp";

		// Token: 0x04000047 RID: 71
		private const BarType DEFAULT_BAR_TYPE = BarType.Time;

		// Token: 0x04000048 RID: 72
		private const long DEFAULT_BAR_SIZE = 60L;

		// Token: 0x04000049 RID: 73
		private const int DEFAULT_BAR_ARRAY_LENGTH = -1;

		// Token: 0x0400004A RID: 74
		private const int DEFAULT_QUOTE_ARRAY_LENGTH = -1;

		// Token: 0x0400004B RID: 75
		private const int DEFAULT_TRADE_ARRAY_LENGTH = -1;

		// Token: 0x0400004C RID: 76
		private const int DEFAULT_FUNDAMENTAL_ARRAY_LENGTH = -1;

		// Token: 0x0400004D RID: 77
		private const int DEFAULT_CORPORATE_ACTION_ARRAY_LENGTH = -1;

		// Token: 0x0400004E RID: 78
		public const char MARKET_DATA_SUBSCRIBE = '1';

		// Token: 0x0400004F RID: 79
		public const char MARKET_DATA_UNSUBSCRIBE = '2';

		// Token: 0x04000050 RID: 80
		public const char SERIES_SEPARATOR = '.';

		// Token: 0x04000051 RID: 81
		private const string CONFIG_FILE_NAME = "DataManager.config.xml";

		// Token: 0x04000052 RID: 82
		private static bool fIsInitialized = false;

		// Token: 0x04000053 RID: 83
		private static IDataServer fServer = new FileDataServer();

		// Token: 0x04000054 RID: 84
		private static BarType defaultBarType;

		// Token: 0x04000055 RID: 85
		private static long defaultBarSize;

		// Token: 0x04000056 RID: 86
		private static BarSeriesList fBars = new BarSeriesList();

		// Token: 0x04000057 RID: 87
		private static QuoteArrayList fQuoteArrays = new QuoteArrayList();

		// Token: 0x04000058 RID: 88
		private static TradeArrayList fTradeArrays = new TradeArrayList();

		// Token: 0x04000059 RID: 89
		private static FundamentalArrayList fFundamentalArrays = new FundamentalArrayList();

		// Token: 0x0400005A RID: 90
		private static CorporateActionArrayList fCorporateActionArrays = new CorporateActionArrayList();

		// Token: 0x0400005B RID: 91
		private static int fBarArrayLength;

		// Token: 0x0400005C RID: 92
		private static int fQuoteArrayLength;

		// Token: 0x0400005D RID: 93
		private static int fTradeArrayLength;

		// Token: 0x0400005E RID: 94
		private static int fFundamentalArrayLength;

		// Token: 0x0400005F RID: 95
		private static int fCorporateActionArrayLength;

		// Token: 0x04000060 RID: 96
		private static Hashtable fRequests = new Hashtable();

		// Token: 0x04000061 RID: 97
		private static IMarketDataFilter fFilter = null;

		// Token: 0x04000062 RID: 98
		private static int fMDReqID = 0;

		// Token: 0x0200001B RID: 27
		public enum EDataSeries
		{
			// Token: 0x04000064 RID: 100
			Daily,
			// Token: 0x04000065 RID: 101
			Trade,
			// Token: 0x04000066 RID: 102
			Quote,
			// Token: 0x04000067 RID: 103
			Bar,
			// Token: 0x04000068 RID: 104
			MarketDepth,
			// Token: 0x04000069 RID: 105
			Fundamental,
			// Token: 0x0400006A RID: 106
			CorporateAction
		}
	}
}
