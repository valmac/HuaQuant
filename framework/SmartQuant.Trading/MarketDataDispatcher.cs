using System;
using System.Collections.Generic;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Trading
{
	// Token: 0x02000086 RID: 134
	internal class MarketDataDispatcher
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x000135F4 File Offset: 0x000125F4
		public MarketDataDispatcher(MetaStrategyBase metaStrategyBase)
		{
			this.metaStrategyBase = metaStrategyBase;
			this.requests = new Dictionary<IMarketDataProvider, Dictionary<Instrument, List<string>>>();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001360E File Offset: 0x0001260E
		public void Init()
		{
			this.requests.Clear();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001361C File Offset: 0x0001261C
		public void Add(IMarketDataProvider provider, Instrument instrument, string seriesSuffix)
		{
			Dictionary<Instrument, List<string>> dictionary = null;
			if (!this.requests.TryGetValue(provider, out dictionary))
			{
				dictionary = new Dictionary<Instrument, List<string>>();
				this.requests.Add(provider, dictionary);
			}
			List<string> list = null;
			if (!dictionary.TryGetValue(instrument, out list))
			{
				list = new List<string>();
				dictionary.Add(instrument, list);
			}
			if (!list.Contains(seriesSuffix))
			{
				list.Add(seriesSuffix);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001367C File Offset: 0x0001267C
		public void Online()
		{
			foreach (KeyValuePair<IMarketDataProvider, Dictionary<Instrument, List<string>>> keyValuePair in this.requests)
			{
				IMarketDataProvider key = keyValuePair.Key;
				foreach (KeyValuePair<Instrument, List<string>> keyValuePair2 in keyValuePair.Value)
				{
					Instrument key2 = keyValuePair2.Key;
					foreach (string text in keyValuePair2.Value)
					{
						if (text == null)
						{
							key2.RequestMarketData(key, (MarketDataType)3);
						}
						else
						{
							key2.RequestMarketData(key, (MarketDataType)3, text);
						}
					}
				}
			}
			ProviderManager.NewBar += this.OnNewBar;
			ProviderManager.NewBarOpen += this.OnNewBarOpen;
			ProviderManager.NewTrade += this.OnNewTrade;
			ProviderManager.NewQuote += this.OnNewQuote;
			ProviderManager.NewMarketDepth += this.OnNewMarketDepth;
			ProviderManager.NewFundamental += this.OnNewFundamental;
			ProviderManager.NewCorporateAction += this.OnNewCorporateAction;
			ProviderManager.NewBarSlice += this.OnNewBarSlice;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000137FC File Offset: 0x000127FC
		public void Offline()
		{
			ProviderManager.NewBar -= this.OnNewBar;
			ProviderManager.NewBarOpen -= this.OnNewBarOpen;
			ProviderManager.NewTrade -= this.OnNewTrade;
			ProviderManager.NewQuote -= this.OnNewQuote;
			ProviderManager.NewMarketDepth -= this.OnNewMarketDepth;
			ProviderManager.NewFundamental -= this.OnNewFundamental;
			ProviderManager.NewCorporateAction -= this.OnNewCorporateAction;
			ProviderManager.NewBarSlice -= this.OnNewBarSlice;
			foreach (KeyValuePair<IMarketDataProvider, Dictionary<Instrument, List<string>>> keyValuePair in this.requests)
			{
				IMarketDataProvider key = keyValuePair.Key;
				if (key.BarFactory != null)
				{
					key.BarFactory.Reset();
				}
				foreach (KeyValuePair<Instrument, List<string>> keyValuePair2 in keyValuePair.Value)
				{
					Instrument key2 = keyValuePair2.Key;
					foreach (string text in keyValuePair2.Value)
					{
						if (text == null)
						{
							key2.CancelMarketData(key, (MarketDataType)3);
						}
						else
						{
							key2.CancelMarketData(key, (MarketDataType)3, text);
						}
					}
				}
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00013990 File Offset: 0x00012990
		private void OnNewBarOpen(object sender, BarEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewBarOpen(args);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000139B2 File Offset: 0x000129B2
		private void OnNewBar(object sender, BarEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewBar(args);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000139D4 File Offset: 0x000129D4
		private void OnNewBarSlice(object sender, BarSliceEventArgs args)
		{
			if (this.HandleMarketData(args.Provider))
			{
				this.metaStrategyBase.SetNewBarSlice(args);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000139F0 File Offset: 0x000129F0
		private void OnNewTrade(object sender, TradeEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewTrade(args);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00013A12 File Offset: 0x00012A12
		private void OnNewQuote(object sender, QuoteEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewQuote(args);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00013A34 File Offset: 0x00012A34
		private void OnNewMarketDepth(object sender, MarketDepthEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewMarketDepth(args);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00013A56 File Offset: 0x00012A56
		private void OnNewFundamental(object sender, FundamentalEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewFundamental(args);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00013A78 File Offset: 0x00012A78
		private void OnNewCorporateAction(object sender, CorporateActionEventArgs args)
		{
			if (this.HandleMarketData(args.Provider, args.Instrument))
			{
				this.metaStrategyBase.SetNewCorporateAction(args);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00013A9C File Offset: 0x00012A9C
		private bool HandleMarketData(IMarketDataProvider provider, IFIXInstrument instrument)
		{
			Dictionary<Instrument, List<string>> dictionary = null;
			return this.requests.TryGetValue(provider, out dictionary) && dictionary.ContainsKey(instrument as Instrument);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00013AC9 File Offset: 0x00012AC9
		private bool HandleMarketData(IMarketDataProvider provider)
		{
			return this.requests.ContainsKey(provider);
		}

		// Token: 0x040001A1 RID: 417
		private MetaStrategyBase metaStrategyBase;

		// Token: 0x040001A2 RID: 418
		private Dictionary<IMarketDataProvider, Dictionary<Instrument, List<string>>> requests;
	}
}
