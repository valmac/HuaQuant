using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Text.RegularExpressions;
using SmartQuant.Data;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Simulation.Design;

namespace SmartQuant.Simulation
{
	// Token: 0x02000027 RID: 39
	public class SimulationDataProvider : IMarketDataProvider, IProvider
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00007A42 File Offset: 0x00006A42
		public SimulationDataProvider() : this("Simulator(market data)", 100)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007A54 File Offset: 0x00006A54
		public SimulationDataProvider(string name, int id)
		{
			this.simulator = new Simulator();
			this.simulator.Error += this.OnError;
			this.simulator.NewObject += this.OnNewObject;
			this.simulator.LeaveInterval += this.OnLeaveInterval;
			this.isConnected = false;
			this.status = ProviderStatus.Unknown;
			this.BarFactory = new BarFactory(false);
			this.seriesTable = new Hashtable();
			this.slices = new Dictionary<long, int>();
			ProviderManager.Add(this);
			ProviderManager.MarketDataSimulator = this;
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000140 RID: 320 RVA: 0x00007AF3 File Offset: 0x00006AF3
		// (remove) Token: 0x06000141 RID: 321 RVA: 0x00007B0C File Offset: 0x00006B0C
		public event MarketDataRequestRejectEventHandler MarketDataRequestReject;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000142 RID: 322 RVA: 0x00007B25 File Offset: 0x00006B25
		// (remove) Token: 0x06000143 RID: 323 RVA: 0x00007B3E File Offset: 0x00006B3E
		public event MarketDataEventHandler NewMarketData;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000144 RID: 324 RVA: 0x00007B57 File Offset: 0x00006B57
		// (remove) Token: 0x06000145 RID: 325 RVA: 0x00007B70 File Offset: 0x00006B70
		public event BarEventHandler NewBar;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000146 RID: 326 RVA: 0x00007B89 File Offset: 0x00006B89
		// (remove) Token: 0x06000147 RID: 327 RVA: 0x00007BA2 File Offset: 0x00006BA2
		public event BarEventHandler NewBarOpen;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000148 RID: 328 RVA: 0x00007BBB File Offset: 0x00006BBB
		// (remove) Token: 0x06000149 RID: 329 RVA: 0x00007BD4 File Offset: 0x00006BD4
		public event BarSliceEventHandler NewBarSlice;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600014A RID: 330 RVA: 0x00007BED File Offset: 0x00006BED
		// (remove) Token: 0x0600014B RID: 331 RVA: 0x00007C06 File Offset: 0x00006C06
		public event QuoteEventHandler NewQuote;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600014C RID: 332 RVA: 0x00007C1F File Offset: 0x00006C1F
		// (remove) Token: 0x0600014D RID: 333 RVA: 0x00007C38 File Offset: 0x00006C38
		public event TradeEventHandler NewTrade;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600014E RID: 334 RVA: 0x00007C51 File Offset: 0x00006C51
		// (remove) Token: 0x0600014F RID: 335 RVA: 0x00007C6A File Offset: 0x00006C6A
		public event MarketDepthEventHandler NewMarketDepth;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000150 RID: 336 RVA: 0x00007C83 File Offset: 0x00006C83
		// (remove) Token: 0x06000151 RID: 337 RVA: 0x00007C9C File Offset: 0x00006C9C
		public event FundamentalEventHandler NewFundamental;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000152 RID: 338 RVA: 0x00007CB5 File Offset: 0x00006CB5
		// (remove) Token: 0x06000153 RID: 339 RVA: 0x00007CCE File Offset: 0x00006CCE
		public event CorporateActionEventHandler NewCorporateAction;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000154 RID: 340 RVA: 0x00007CE7 File Offset: 0x00006CE7
		// (remove) Token: 0x06000155 RID: 341 RVA: 0x00007D00 File Offset: 0x00006D00
		public event MarketDataSnapshotEventHandler MarketDataSnapshot;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000156 RID: 342 RVA: 0x00007D19 File Offset: 0x00006D19
		// (remove) Token: 0x06000157 RID: 343 RVA: 0x00007D32 File Offset: 0x00006D32
		public event BarEventHandler NewMarketBar;

		// Token: 0x06000158 RID: 344 RVA: 0x00007D4C File Offset: 0x00006D4C
		public void SendMarketDataRequest(FIXMarketDataRequest request)
		{
			bool subscribe = request.SubscriptionRequestType == '1';
			for (int i = 0; i < request.NoRelatedSym; i++)
			{
				Instrument instrument = InstrumentManager.Instruments[request.GetRelatedSymGroup(i).Symbol];
				string stringValue = request.GetRelatedSymGroup(i).GetStringValue(10001);
				this.AddSimulatedSeries(instrument, stringValue, subscribe);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00007DA7 File Offset: 0x00006DA7
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00007DB0 File Offset: 0x00006DB0
		public IBarFactory BarFactory
		{
			get
			{
				return this.factory;
			}
			set
			{
				if (this.factory != null)
				{
					this.factory.NewBar -= this.OnNewBar;
					this.factory.NewBarOpen -= this.OnNewBarOpen;
					this.factory.NewBarSlice -= this.OnNewBarSlice;
				}
				this.factory = value;
				if (this.factory != null)
				{
					this.factory.NewBar += this.OnNewBar;
					this.factory.NewBarOpen += this.OnNewBarOpen;
					this.factory.NewBarSlice += this.OnNewBarSlice;
				}
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600015B RID: 347 RVA: 0x00007E5E File Offset: 0x00006E5E
		// (remove) Token: 0x0600015C RID: 348 RVA: 0x00007E77 File Offset: 0x00006E77
		public event EventHandler Connected;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600015D RID: 349 RVA: 0x00007E90 File Offset: 0x00006E90
		// (remove) Token: 0x0600015E RID: 350 RVA: 0x00007EA9 File Offset: 0x00006EA9
		public event EventHandler Disconnected;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600015F RID: 351 RVA: 0x00007EC2 File Offset: 0x00006EC2
		// (remove) Token: 0x06000160 RID: 352 RVA: 0x00007EDB File Offset: 0x00006EDB
		public event ProviderErrorEventHandler Error;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000161 RID: 353 RVA: 0x00007EF4 File Offset: 0x00006EF4
		// (remove) Token: 0x06000162 RID: 354 RVA: 0x00007F0D File Offset: 0x00006F0D
		public event EventHandler StatusChanged;

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00007F26 File Offset: 0x00006F26
		[Category("Information")]
		public string Name
		{
			get
			{
				return "Simulator(market data)";
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00007F2D File Offset: 0x00006F2D
		[Category("Information")]
		public string Title
		{
			get
			{
				return "Simulation data provider";
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00007F34 File Offset: 0x00006F34
		[Category("Information")]
		public byte Id
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00007F37 File Offset: 0x00006F37
		[Category("Information")]
		public string URL
		{
			get
			{
				return "www.smartquant.com";
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00007F3E File Offset: 0x00006F3E
		[Category("Status")]
		public bool IsConnected
		{
			get
			{
				return this.isConnected;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00007F46 File Offset: 0x00006F46
		[Category("Status")]
		public ProviderStatus Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00007F50 File Offset: 0x00006F50
		public void Connect()
		{
			lock (this)
			{
				if (!this.isConnected)
				{
					this.ChangeStatus(ProviderStatus.Connecting);
					this.isConnected = true;
					this.ChangeStatus(ProviderStatus.Connected);
					this.EmitConnectedEvent();
					this.ChangeStatus(ProviderStatus.LoggingIn);
					this.ChangeStatus(ProviderStatus.LoggedIn);
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007FB0 File Offset: 0x00006FB0
		public void Connect(int timeout)
		{
			this.Connect();
			ProviderManager.WaitConnected(this, timeout);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007FC0 File Offset: 0x00006FC0
		public void Disconnect()
		{
			lock (this)
			{
				if (this.isConnected)
				{
					this.simulator.Stop();
					this.isConnected = false;
					this.ChangeStatus(ProviderStatus.Disconnected);
					this.EmitDisconnectedEvent();
				}
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008018 File Offset: 0x00007018
		public void Shutdown()
		{
			this.Disconnect();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008020 File Offset: 0x00007020
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00008028 File Offset: 0x00007028
		[Editor(typeof(SimulatorTypeEditor), typeof(UITypeEditor))]
		public Simulator Simulator
		{
			get
			{
				return this.simulator;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008030 File Offset: 0x00007030
		private void EmitConnectedEvent()
		{
			if (this.Connected != null)
			{
				this.Connected(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000804B File Offset: 0x0000704B
		private void EmitDisconnectedEvent()
		{
			if (this.Disconnected != null)
			{
				this.Disconnected(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008066 File Offset: 0x00007066
		private void ChangeStatus(ProviderStatus status)
		{
			this.status = status;
			this.EmitStatusChangedEvent();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008075 File Offset: 0x00007075
		private void EmitStatusChangedEvent()
		{
			if (this.StatusChanged != null)
			{
				this.StatusChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008090 File Offset: 0x00007090
		private void OnError(ExceptionEventArgs args)
		{
			if (this.Error != null)
			{
				this.Error(new ProviderErrorEventArgs(new ProviderError(Clock.Now, this, -1, -1, args.Exception.ToString())));
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000080C4 File Offset: 0x000070C4
		private void OnNewObject(SeriesObjectEventArgs args)
		{
			Instrument instrument = this.seriesTable[args.Series] as Instrument;
			if (instrument == null)
			{
				instrument = InstrumentManager.Instruments[args.Series.Name.Substring(0, args.Series.Name.IndexOf('.'))];
			}
			IDataObject @object = args.Object;
			if (@object is Bar)
			{
				Bar bar = @object as Bar;
				if (bar.IsComplete)
				{
					this.EmitNewBarEvent(instrument, bar);
					if (bar.BarType == BarType.Time)
					{
						Dictionary<long, int> dictionary;
						long size;
						(dictionary = this.slices)[size = bar.Size] = dictionary[size] - 1;
						if (this.slices[bar.Size] == 0)
						{
							this.EmitNewBarSlice(bar.Size);
							return;
						}
					}
				}
				else
				{
					this.EmitNewBarOpenEvent(instrument, bar);
					if (bar.BarType == BarType.Time)
					{
						if (!this.slices.ContainsKey(bar.Size))
						{
							this.slices[bar.Size] = 0;
						}
						Dictionary<long, int> dictionary2;
						long size2;
						(dictionary2 = this.slices)[size2 = bar.Size] = dictionary2[size2] + 1;
					}
				}
				return;
			}
			if (@object is Trade)
			{
				this.EmitNewTradeEvent(instrument, @object as Trade);
				return;
			}
			if (@object is Quote)
			{
				this.EmitNewQuoteEvent(instrument, @object as Quote);
				return;
			}
			if (@object is MarketDepth)
			{
				this.EmitNewMarketDepth(instrument, @object as MarketDepth);
				return;
			}
			if (@object is Fundamental)
			{
				this.EmitNewFundamental(instrument, @object as Fundamental);
				return;
			}
			if (@object is CorporateAction)
			{
				this.EmitNewCorporateAction(instrument, @object as CorporateAction);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008254 File Offset: 0x00007254
		private void OnLeaveInterval(IntervalEventArgs args)
		{
			this.slices.Clear();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008261 File Offset: 0x00007261
		private void EmitNewBarSlice(long barSize)
		{
			if (this.NewBarSlice != null)
			{
				this.NewBarSlice(this, new BarSliceEventArgs(barSize, this));
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000827E File Offset: 0x0000727E
		private void EmitNewBarEvent(IFIXInstrument instrument, Bar bar)
		{
			if (this.NewBar != null)
			{
				this.NewBar(this, new BarEventArgs(bar, instrument, this));
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000829C File Offset: 0x0000729C
		private void EmitNewBarOpenEvent(IFIXInstrument instrument, Bar bar)
		{
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(this, new BarEventArgs(bar, instrument, this));
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000082BA File Offset: 0x000072BA
		private void EmitNewTradeEvent(IFIXInstrument instrument, Trade trade)
		{
			if (this.NewTrade != null)
			{
				this.NewTrade(this, new TradeEventArgs(trade, instrument, this));
			}
			if (this.factory != null)
			{
				this.factory.OnNewTrade(instrument, trade);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000082ED File Offset: 0x000072ED
		private void EmitNewQuoteEvent(IFIXInstrument instrument, Quote quote)
		{
			if (this.NewQuote != null)
			{
				this.NewQuote(this, new QuoteEventArgs(quote, instrument, this));
			}
			if (this.factory != null)
			{
				this.factory.OnNewQuote(instrument, quote);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008320 File Offset: 0x00007320
		private void EmitNewMarketDepth(IFIXInstrument instrument, MarketDepth marketDepth)
		{
			if (this.NewMarketDepth != null)
			{
				this.NewMarketDepth(this, new MarketDepthEventArgs(marketDepth, instrument, this));
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000833E File Offset: 0x0000733E
		private void EmitNewFundamental(IFIXInstrument instrument, Fundamental fundamental)
		{
			if (this.NewFundamental != null)
			{
				this.NewFundamental(this, new FundamentalEventArgs(fundamental, instrument, this));
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000835C File Offset: 0x0000735C
		private void EmitNewCorporateAction(IFIXInstrument instrument, CorporateAction corporateAction)
		{
			if (this.NewCorporateAction != null)
			{
				this.NewCorporateAction(this, new CorporateActionEventArgs(corporateAction, instrument, this));
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000837C File Offset: 0x0000737C
		private void AddSimulatedSeries(Instrument instrument, string seriesSuffix, bool subscribe)
		{
			DataSeriesList dataSeries = instrument.GetDataSeries();
			new Regex(seriesSuffix);
			foreach (object obj in dataSeries)
			{
				IDataSeries dataSeries2 = (IDataSeries)obj;
				if (dataSeries2.Name.Substring(instrument.Symbol.Length + 1) == seriesSuffix)
				{
					if (subscribe)
					{
						if (!this.simulator.InputSeries.Contains(dataSeries2))
						{
							this.simulator.InputSeries.Add(dataSeries2);
							if (!this.seriesTable.Contains(dataSeries2))
							{
								this.seriesTable.Add(dataSeries2, instrument);
							}
						}
					}
					else
					{
						this.simulator.InputSeries.Remove(dataSeries2);
						this.seriesTable.Remove(dataSeries2);
					}
				}
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008460 File Offset: 0x00007460
		private void OnNewBar(object sender, BarEventArgs args)
		{
			if (this.NewBar != null)
			{
				this.NewBar(this, new BarEventArgs(args.Bar, args.Instrument, this));
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008488 File Offset: 0x00007488
		private void OnNewBarOpen(object sender, BarEventArgs args)
		{
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(this, new BarEventArgs(args.Bar, args.Instrument, this));
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000084B0 File Offset: 0x000074B0
		private void OnNewBarSlice(object sender, BarSliceEventArgs args)
		{
			if (this.NewBarSlice != null)
			{
				this.NewBarSlice(this, new BarSliceEventArgs(args.BarSize, this));
			}
		}

		// Token: 0x040000B0 RID: 176
		private const string PROVIDER_NAME = "Simulator(market data)";

		// Token: 0x040000B1 RID: 177
		private const string PROVIDER_TITLE = "Simulation data provider";

		// Token: 0x040000B2 RID: 178
		private const string PROVIDER_URL = "www.smartquant.com";

		// Token: 0x040000B3 RID: 179
		private const byte PROVIDER_ID = 1;

		// Token: 0x040000B4 RID: 180
		private const string CATEGORY_INFO = "Information";

		// Token: 0x040000B5 RID: 181
		private const string CATEGORY_STATUS = "Status";

		// Token: 0x040000B6 RID: 182
		private Simulator simulator;

		// Token: 0x040000B7 RID: 183
		private bool isConnected;

		// Token: 0x040000B8 RID: 184
		private ProviderStatus status;

		// Token: 0x040000B9 RID: 185
		private IBarFactory factory;

		// Token: 0x040000BA RID: 186
		private Hashtable seriesTable;

		// Token: 0x040000BB RID: 187
		private Dictionary<long, int> slices;
	}
}
