using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Trading.Design;

namespace SmartQuant.Trading
{
	// Token: 0x02000003 RID: 3
	public class Strategy : StrategyBase
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000036D4 File Offset: 0x000026D4
		public Strategy(string name, string description) : base(name, description)
		{
			this.CrossExit = (StrategyComponentManager.GetComponent("{D779BA8E-C0CA-44cf-8745-99105365882F}", this) as CrossExit);
			this.CrossEntry = (StrategyComponentManager.GetComponent("{664274F3-FDE1-46da-A84F-556E4A0EB170}", this) as CrossEntry);
			this.Entry = (StrategyComponentManager.GetComponent("{94FAFF9D-5281-4c67-A599-B893F1F58B38}", this) as Entry);
			this.Exit = (StrategyComponentManager.GetComponent("{6FEE0044-0FD2-418d-94E6-400834BEE5D3}", this) as Exit);
			this.MoneyManager = (StrategyComponentManager.GetComponent("{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}", this) as MoneyManager);
			this.RiskManager = (StrategyComponentManager.GetComponent("{BE0176A8-3BBD-407c-814A-D5A3E3437899}", this) as RiskManager);
			this.ExposureManager = (StrategyComponentManager.GetComponent("{0449D7E3-2016-47f6-9B80-C787B3E0F18F}", this) as ExposureManager);
			this.entries = new Dictionary<Instrument, Entry>();
			this.exits = new Dictionary<Instrument, Exit>();
			this.moneyManagers = new Dictionary<Instrument, MoneyManager>();
			this.riskManagers = new Dictionary<Instrument, RiskManager>();
			this.componentTypeList.Add(ComponentType.Entry);
			this.componentTypeList.Add(ComponentType.Exit);
			this.componentTypeList.Add(ComponentType.CrossEntry);
			this.componentTypeList.Add(ComponentType.CrossExit);
			this.componentTypeList.Add(ComponentType.RiskManager);
			this.componentTypeList.Add(ComponentType.MoneyManager);
			this.componentTypeList.Add(ComponentType.ExposureManager);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000380D File Offset: 0x0000280D
		public Strategy(string name) : this(name, "")
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000381B File Offset: 0x0000281B
		[Browsable(false)]
		public MetaStrategy MetaStrategy
		{
			get
			{
				return base.MetaStrategyBase as MetaStrategy;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003828 File Offset: 0x00002828
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000384C File Offset: 0x0000284C
		[Category("Components")]
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Editor(typeof(CrossEntryTypeEditor), typeof(UITypeEditor))]
		public CrossEntry CrossEntry
		{
			get
			{
				if (this.metaStrategyBase == null || !this.metaStrategyBase.IsRunning)
				{
					return this.crossEntry;
				}
				return this.runtimeCrossEntry;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.crossEntry != null)
				{
					this.crossEntry.Disconnect();
					this.crossEntry.StrategyBase = null;
				}
				this.crossEntry = value;
				if (this.crossEntry != null)
				{
					this.crossEntry.StrategyBase = this;
					this.crossEntry.Connect();
				}
				base.EmitComponentChanged(ComponentType.CrossEntry);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000038D6 File Offset: 0x000028D6
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000038FC File Offset: 0x000028FC
		[Category("Components")]
		[Editor(typeof(CrossExitTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ComponentTypeConverter))]
		public CrossExit CrossExit
		{
			get
			{
				if (this.metaStrategyBase == null || !this.metaStrategyBase.IsRunning)
				{
					return this.crossExit;
				}
				return this.runtimeCrossExit;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.crossExit != null)
				{
					this.crossExit.Disconnect();
					this.crossExit.StrategyBase = null;
				}
				this.crossExit = value;
				if (this.crossExit != null)
				{
					this.crossExit.StrategyBase = this;
					this.crossExit.Connect();
				}
				base.EmitComponentChanged(ComponentType.CrossExit);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003986 File Offset: 0x00002986
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00003990 File Offset: 0x00002990
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Category("Components")]
		[Editor(typeof(EntryTypeEditor), typeof(UITypeEditor))]
		public Entry Entry
		{
			get
			{
				return this.entry;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.entry != null)
				{
					this.entry.Disconnect();
					this.entry.StrategyBase = null;
				}
				this.entry = value;
				if (this.entry != null)
				{
					this.entry.StrategyBase = this;
					this.entry.Connect();
				}
				base.EmitComponentChanged(ComponentType.Entry);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003A16 File Offset: 0x00002A16
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00003A20 File Offset: 0x00002A20
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Category("Components")]
		[Editor(typeof(ExitTypeEditor), typeof(UITypeEditor))]
		public Exit Exit
		{
			get
			{
				return this.exit;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.exit != null)
				{
					this.exit.Disconnect();
					this.exit.StrategyBase = null;
				}
				this.exit = value;
				if (this.exit != null)
				{
					this.exit.StrategyBase = this;
					this.exit.Connect();
				}
				base.EmitComponentChanged(ComponentType.Exit);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003AA6 File Offset: 0x00002AA6
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00003AB0 File Offset: 0x00002AB0
		[Editor(typeof(MoneyManagerTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Category("Components")]
		public MoneyManager MoneyManager
		{
			get
			{
				return this.moneyManager;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.moneyManager != null)
				{
					this.moneyManager.Disconnect();
					this.moneyManager.StrategyBase = null;
				}
				this.moneyManager = value;
				if (this.moneyManager != null)
				{
					this.moneyManager.StrategyBase = this;
					this.moneyManager.Connect();
				}
				base.EmitComponentChanged(ComponentType.MoneyManager);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003B37 File Offset: 0x00002B37
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00003B40 File Offset: 0x00002B40
		[Editor(typeof(RiskManagerTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Category("Components")]
		public RiskManager RiskManager
		{
			get
			{
				return this.riskManager;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.riskManager != null)
				{
					this.riskManager.Disconnect();
					this.riskManager.StrategyBase = null;
				}
				this.riskManager = value;
				if (this.riskManager != null)
				{
					this.riskManager.StrategyBase = this;
					this.riskManager.Connect();
				}
				base.EmitComponentChanged(ComponentType.RiskManager);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003BC7 File Offset: 0x00002BC7
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00003BD0 File Offset: 0x00002BD0
		[Editor(typeof(ExposureManagerTypeEditor), typeof(UITypeEditor))]
		[Category("Components")]
		[TypeConverter(typeof(ComponentTypeConverter))]
		public ExposureManager ExposureManager
		{
			get
			{
				return this.exposureManager;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.exposureManager != null)
				{
					this.exposureManager.Disconnect();
					this.exposureManager.StrategyBase = null;
				}
				this.exposureManager = value;
				if (this.exposureManager != null)
				{
					this.exposureManager.StrategyBase = this;
					this.exposureManager.Connect();
				}
				base.EmitComponentChanged(ComponentType.ExposureManager);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003C56 File Offset: 0x00002C56
		internal Dictionary<Instrument, Entry> Entries
		{
			get
			{
				return this.entries;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003C5E File Offset: 0x00002C5E
		internal Dictionary<Instrument, Exit> Exits
		{
			get
			{
				return this.exits;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003C66 File Offset: 0x00002C66
		internal Dictionary<Instrument, MoneyManager> MoneyManagers
		{
			get
			{
				return this.moneyManagers;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003C6E File Offset: 0x00002C6E
		internal Dictionary<Instrument, RiskManager> RiskManagers
		{
			get
			{
				return this.riskManagers;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003C78 File Offset: 0x00002C78
		protected override void OnInit()
		{
			this.entries.Clear();
			this.exits.Clear();
			this.moneyManagers.Clear();
			this.riskManagers.Clear();
			this.runtimeCrossEntry = (Activator.CreateInstance(this.crossEntry.GetType()) as CrossEntry);
			this.runtimeCrossExit = (Activator.CreateInstance(this.crossExit.GetType()) as CrossExit);
			this.runtimeCrossEntry.StrategyBase = this;
			this.runtimeCrossExit.StrategyBase = this;
			base.SetProxyProperties(this.runtimeCrossEntry, this.crossEntry);
			base.SetProxyProperties(this.runtimeCrossExit, this.crossExit);
			this.runtimeCrossEntry.Init();
			this.runtimeCrossExit.Init();
			this.exposureManager.Init();
			foreach (object obj in this.marketManager.Instruments)
			{
				Instrument instrument = (Instrument)obj;
				this.activeInstruments.Add(instrument);
				Entry entry = Activator.CreateInstance(this.entry.GetType()) as Entry;
				Exit exit = Activator.CreateInstance(this.exit.GetType()) as Exit;
				MoneyManager moneyManager = Activator.CreateInstance(this.moneyManager.GetType()) as MoneyManager;
				RiskManager riskManager = Activator.CreateInstance(this.riskManager.GetType()) as RiskManager;
				entry.StrategyBase = this;
				exit.StrategyBase = this;
				moneyManager.StrategyBase = this;
				riskManager.StrategyBase = this;
				entry.Instrument = instrument;
				exit.Instrument = instrument;
				moneyManager.Instrument = instrument;
				riskManager.Instrument = instrument;
				base.SetProxyProperties(entry, this.entry);
				base.SetProxyProperties(exit, this.exit);
				base.SetProxyProperties(moneyManager, this.moneyManager);
				base.SetProxyProperties(riskManager, this.riskManager);
				entry.Init();
				exit.Init();
				moneyManager.Init();
				riskManager.Init();
				this.entries.Add(instrument, entry);
				this.exits.Add(instrument, exit);
				this.moneyManagers.Add(instrument, moneyManager);
				this.riskManagers.Add(instrument, riskManager);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003ECC File Offset: 0x00002ECC
		protected override void OnStrategyStop()
		{
			this.runtimeCrossEntry.OnStrategyStop();
			this.runtimeCrossExit.OnStrategyStop();
			foreach (Entry entry in this.entries.Values)
			{
				entry.OnStrategyStop();
			}
			foreach (Exit exit in this.exits.Values)
			{
				exit.OnStrategyStop();
			}
			foreach (MoneyManager moneyManager in this.moneyManagers.Values)
			{
				moneyManager.OnStrategyStop();
			}
			foreach (RiskManager riskManager in this.riskManagers.Values)
			{
				riskManager.OnStrategyStop();
			}
			this.exposureManager.OnStrategyStop();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000401C File Offset: 0x0000301C
		internal SingleOrder EmitSignal(Signal signal)
		{
			signal.Strategy = this;
			MoneyManager moneyManager = this.moneyManagers[signal.Instrument];
			double positionSize = moneyManager.GetPositionSize(signal);
			if (positionSize > 0.0)
			{
				signal.Qty = positionSize;
				RiskManager riskManager = this.riskManagers[signal.Instrument];
				if (!riskManager.Validate(signal))
				{
					signal.Status = SignalStatus.Rejected;
					signal.Rejecter = ComponentType.RiskManager;
				}
				if (!this.exposureManager.Validate(signal))
				{
					signal.Status = SignalStatus.Rejected;
					signal.Rejecter = ComponentType.ExposureManager;
				}
			}
			else
			{
				signal.Status = SignalStatus.Rejected;
				signal.Rejecter = ComponentType.MoneyManager;
			}
			return this.MetaStrategy.EmitSignal(signal);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000040C0 File Offset: 0x000030C0
		protected override void OnNewTrade(Instrument instrument, Trade trade)
		{
			foreach (object obj in new ArrayList(this.activeStops[instrument]))
			{
				Stop stop = (Stop)obj;
				if (stop.Connected)
				{
					stop.OnNewTrade(trade);
				}
			}
			this.runtimeCrossExit.OnTrade(instrument, trade);
			this.runtimeCrossEntry.OnTrade(instrument, trade);
			this.marketManager.OnTrade(instrument, trade);
			this.exits[instrument].OnTrade(trade);
			this.entries[instrument].OnTrade(trade);
			this.moneyManagers[instrument].OnTrade(trade);
			this.riskManagers[instrument].OnTrade(trade);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000419C File Offset: 0x0000319C
		protected override void OnNewQuote(Instrument instrument, Quote quote)
		{
			foreach (object obj in new ArrayList(this.activeStops[instrument]))
			{
				Stop stop = (Stop)obj;
				if (stop.Connected)
				{
					stop.OnNewQuote(quote);
				}
			}
			this.runtimeCrossExit.OnQuote(instrument, quote);
			this.runtimeCrossEntry.OnQuote(instrument, quote);
			this.marketManager.OnQuote(instrument, quote);
			this.exits[instrument].OnQuote(quote);
			this.entries[instrument].OnQuote(quote);
			this.moneyManagers[instrument].OnQuote(quote);
			this.riskManagers[instrument].OnQuote(quote);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004278 File Offset: 0x00003278
		protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
			this.runtimeCrossExit.OnMarketDepth(instrument, marketDepth);
			this.runtimeCrossEntry.OnMarketDepth(instrument, marketDepth);
			this.marketManager.OnMarketDepth(instrument, marketDepth);
			this.exits[instrument].OnMarketDepth(marketDepth);
			this.entries[instrument].OnMarketDepth(marketDepth);
			this.moneyManagers[instrument].OnMarketDepth(marketDepth);
			this.riskManagers[instrument].OnMarketDepth(marketDepth);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000042F4 File Offset: 0x000032F4
		protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
		{
			this.runtimeCrossExit.OnFundamental(instrument, fundamental);
			this.runtimeCrossEntry.OnFundamental(instrument, fundamental);
			this.exits[instrument].OnFundamental(fundamental);
			this.entries[instrument].OnFundamental(fundamental);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004334 File Offset: 0x00003334
		protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
			this.runtimeCrossExit.OnCorporateAction(instrument, corporateAction);
			this.runtimeCrossEntry.OnCorporateAction(instrument, corporateAction);
			this.marketManager.OnCorporateAction(instrument, corporateAction);
			this.exposureManager.OnCorporateAction(instrument, corporateAction);
			this.exits[instrument].OnCorporateAction(corporateAction);
			this.entries[instrument].OnCorporateAction(corporateAction);
			this.moneyManagers[instrument].OnCorporateAction(corporateAction);
			this.riskManagers[instrument].OnCorporateAction(corporateAction);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000043C0 File Offset: 0x000033C0
		protected override void OnNewBarOpen(Instrument instrument, Bar bar)
		{
			foreach (object obj in new ArrayList(this.activeStops[instrument]))
			{
				Stop stop = (Stop)obj;
				if (stop.Connected)
				{
					stop.OnNewBarOpen(bar);
				}
			}
			this.runtimeCrossExit.OnBarOpen(instrument, bar);
			this.runtimeCrossEntry.OnBarOpen(instrument, bar);
			this.marketManager.OnBarOpen(instrument, bar);
			this.exits[instrument].OnBarOpen(bar);
			this.entries[instrument].OnBarOpen(bar);
			this.moneyManagers[instrument].OnBarOpen(bar);
			this.riskManagers[instrument].OnBarOpen(bar);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000449C File Offset: 0x0000349C
		protected override void OnNewBar(Instrument instrument, Bar bar)
		{
			foreach (object obj in new ArrayList(this.activeStops[instrument]))
			{
				Stop stop = (Stop)obj;
				if (stop.Connected)
				{
					stop.OnNewBar(bar);
				}
			}
			this.runtimeCrossExit.OnBar(instrument, bar);
			this.runtimeCrossEntry.OnBar(instrument, bar);
			this.marketManager.OnBar(instrument, bar);
			this.exits[instrument].OnBar(bar);
			this.entries[instrument].OnBar(bar);
			this.moneyManagers[instrument].OnBar(bar);
			this.riskManagers[instrument].OnBar(bar);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004578 File Offset: 0x00003578
		protected override void OnNewBarSlice(long barSize)
		{
			this.runtimeCrossExit.OnBarSlice(barSize);
			this.runtimeCrossEntry.OnBarSlice(barSize);
			this.marketManager.OnBarSlice(barSize);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000459E File Offset: 0x0000359E
		protected override void OnProviderConnected(IProvider provider)
		{
			this.runtimeCrossExit.OnProviderConnected(provider);
			this.runtimeCrossEntry.OnProviderConnected(provider);
			this.marketManager.OnProviderConnected(provider);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000045C4 File Offset: 0x000035C4
		protected override void OnProviderDisconnected(IProvider provider)
		{
			this.runtimeCrossExit.OnProviderDisconnected(provider);
			this.runtimeCrossEntry.OnProviderDisconnected(provider);
			this.marketManager.OnProviderDisconnected(provider);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000045EA File Offset: 0x000035EA
		protected override void OnProviderError(IProvider provider, int id, int code, string message)
		{
			this.runtimeCrossExit.OnProviderError(provider, id, code, message);
			this.runtimeCrossEntry.OnProviderError(provider, id, code, message);
			this.marketManager.OnProviderError(provider, id, code, message);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000461C File Offset: 0x0000361C
		protected override void OnPositionOpened(Position position)
		{
			this.runtimeCrossExit.OnPositionOpened(position);
			this.runtimeCrossEntry.OnPositionOpened(position);
			this.exposureManager.OnPositionOpened(position);
			Instrument instrument = position.Instrument;
			this.exits[instrument].OnPositionOpened();
			this.entries[instrument].OnPositionOpened();
			this.moneyManagers[instrument].OnPositionOpened();
			this.riskManagers[instrument].OnPositionOpened();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004698 File Offset: 0x00003698
		protected override void OnPositionChanged(Position position)
		{
			this.runtimeCrossExit.OnPositionChanged(position);
			this.runtimeCrossEntry.OnPositionChanged(position);
			this.exposureManager.OnPositionChanged(position);
			Instrument instrument = position.Instrument;
			this.exits[instrument].OnPositionChanged();
			this.entries[instrument].OnPositionChanged();
			this.moneyManagers[instrument].OnPositionChanged();
			this.riskManagers[instrument].OnPositionChanged();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004714 File Offset: 0x00003714
		protected override void OnPositionClosed(Position position)
		{
			foreach (object obj in new ArrayList(this.activeStops[position.Instrument]))
			{
				Stop stop = (Stop)obj;
				if ((stop.Type == StopType.Time && stop.Status == StopStatus.Active) || stop.Connected)
				{
					stop.OnPositionClosed(position);
				}
			}
			this.runtimeCrossExit.OnPositionClosed(position);
			this.runtimeCrossEntry.OnPositionClosed(position);
			this.exposureManager.OnPositionClosed(position);
			Instrument instrument = position.Instrument;
			this.exits[instrument].OnPositionClosed();
			this.entries[instrument].OnPositionClosed();
			this.moneyManagers[instrument].OnPositionClosed();
			this.riskManagers[instrument].OnPositionClosed();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004808 File Offset: 0x00003808
		protected override void OnPortfolioValueChanged(Position position)
		{
			this.MetaStrategy.MetaRiskManager.OnStrategyPortfolioValueChanged(this);
			if (!this.isActive)
			{
				return;
			}
			this.runtimeCrossExit.OnPortfolioValueChanged(position);
			this.runtimeCrossEntry.OnPortfolioValueChanged(position);
			this.exposureManager.OnPortfolioValueChanged(position);
			Instrument instrument = position.Instrument;
			this.exits[instrument].OnPositionValueChanged();
			this.entries[instrument].OnPositionValueChanged();
			this.moneyManagers[instrument].OnPositionValueChanged();
			this.riskManagers[instrument].OnPositionValueChanged();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000048A0 File Offset: 0x000038A0
		public override void ClosePosition(Instrument instrument, double price, ComponentType component, string text)
		{
			Position position = this.portfolio.Positions[instrument];
			if (position != null)
			{
				switch (position.Side)
				{
				case PositionSide.Long:
					this.EmitSignal(new Signal(Clock.Now, component, SignalType.Market, SignalSide.Sell, position.Qty, price, instrument, text));
					return;
				case PositionSide.Short:
					this.EmitSignal(new Signal(Clock.Now, component, SignalType.Market, SignalSide.BuyCover, position.Qty, price, instrument, text));
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004918 File Offset: 0x00003918
		protected override void OnNewOrder(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnNewOrder(order);
			this.runtimeCrossExit.OnNewOrder(order);
			this.entries[instrument].OnNewOrder(order);
			this.exits[instrument].OnNewOrder(order);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004968 File Offset: 0x00003968
		protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnExecutionReport(order, report);
			this.runtimeCrossExit.OnExecutionReport(order, report);
			this.entries[instrument].OnExecutionReport(order, report);
			this.exits[instrument].OnExecutionReport(order, report);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000049BC File Offset: 0x000039BC
		protected override void OnOrderPartiallyFilled(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnOrderPartiallyFilled(order);
			this.runtimeCrossExit.OnOrderPartiallyFilled(order);
			this.entries[instrument].OnOrderPartiallyFilled(order);
			this.exits[instrument].OnOrderPartiallyFilled(order);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004A0C File Offset: 0x00003A0C
		protected override void OnOrderStatusChanged(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnOrderStatusChanged(order);
			this.runtimeCrossExit.OnOrderStatusChanged(order);
			this.entries[instrument].OnOrderStatusChanged(order);
			this.exits[instrument].OnOrderStatusChanged(order);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004A5C File Offset: 0x00003A5C
		protected override void OnOrderFilled(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnOrderFilled(order);
			this.runtimeCrossExit.OnOrderFilled(order);
			this.entries[instrument].OnOrderFilled(order);
			this.exits[instrument].OnOrderFilled(order);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004AAC File Offset: 0x00003AAC
		protected override void OnOrderCancelled(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnOrderCancelled(order);
			this.runtimeCrossExit.OnOrderCancelled(order);
			this.entries[instrument].OnOrderCancelled(order);
			this.exits[instrument].OnOrderCancelled(order);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004AFC File Offset: 0x00003AFC
		protected override void OnOrderRejected(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnOrderRejected(order);
			this.runtimeCrossExit.OnOrderRejected(order);
			this.entries[instrument].OnOrderRejected(order);
			this.exits[instrument].OnOrderRejected(order);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004B4C File Offset: 0x00003B4C
		protected override void OnOrderDone(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			this.runtimeCrossEntry.OnOrderDone(order);
			this.runtimeCrossExit.OnOrderDone(order);
			this.entries[instrument].OnOrderDone(order);
			this.exits[instrument].OnOrderDone(order);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004B9C File Offset: 0x00003B9C
		public override IComponentBase GetComponent(ComponentType type)
		{
			if (type <= ComponentType.RiskManager)
			{
				if (type <= ComponentType.ExposureManager)
				{
					switch (type)
					{
					case ComponentType.Entry:
						return this.Entry;
					case (ComponentType)3:
						break;
					case ComponentType.Exit:
						return this.Exit;
					default:
						if (type == ComponentType.ExposureManager)
						{
							return this.ExposureManager;
						}
						break;
					}
				}
				else
				{
					if (type == ComponentType.MoneyManager)
					{
						return this.MoneyManager;
					}
					if (type == ComponentType.RiskManager)
					{
						return this.RiskManager;
					}
				}
			}
			else if (type <= ComponentType.ReportManager)
			{
				if (type == ComponentType.MarketManager)
				{
					return base.MarketManager;
				}
				if (type == ComponentType.ReportManager)
				{
					return base.ReportManager;
				}
			}
			else
			{
				if (type == ComponentType.CrossEntry)
				{
					return this.CrossEntry;
				}
				if (type == ComponentType.CrossExit)
				{
					return this.CrossExit;
				}
			}
			throw new InvalidOperationException("Invalid strategy1 component type");
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004C4C File Offset: 0x00003C4C
		public override void SetComponent(ComponentType type, IComponentBase component)
		{
			if (type <= ComponentType.RiskManager)
			{
				if (type <= ComponentType.ExposureManager)
				{
					switch (type)
					{
					case ComponentType.Entry:
						this.Entry = (component as Entry);
						return;
					case (ComponentType)3:
						break;
					case ComponentType.Exit:
						this.Exit = (component as Exit);
						return;
					default:
						if (type == ComponentType.ExposureManager)
						{
							this.ExposureManager = (component as ExposureManager);
							return;
						}
						break;
					}
				}
				else
				{
					if (type == ComponentType.MoneyManager)
					{
						this.MoneyManager = (component as MoneyManager);
						return;
					}
					if (type == ComponentType.RiskManager)
					{
						this.RiskManager = (component as RiskManager);
						return;
					}
				}
			}
			else if (type <= ComponentType.ReportManager)
			{
				if (type == ComponentType.MarketManager)
				{
					base.MarketManager = (component as MarketManager);
					return;
				}
				if (type == ComponentType.ReportManager)
				{
					base.ReportManager = (component as ReportManager);
					return;
				}
			}
			else
			{
				if (type == ComponentType.CrossEntry)
				{
					this.CrossEntry = (component as CrossEntry);
					return;
				}
				if (type == ComponentType.CrossExit)
				{
					this.CrossExit = (component as CrossExit);
					return;
				}
			}
			throw new InvalidOperationException("Invalid strategy1 component type");
		}

		// Token: 0x04000027 RID: 39
		private CrossEntry crossEntry;

		// Token: 0x04000028 RID: 40
		private CrossExit crossExit;

		// Token: 0x04000029 RID: 41
		private CrossEntry runtimeCrossEntry;

		// Token: 0x0400002A RID: 42
		private CrossExit runtimeCrossExit;

		// Token: 0x0400002B RID: 43
		private Entry entry;

		// Token: 0x0400002C RID: 44
		private Exit exit;

		// Token: 0x0400002D RID: 45
		private MoneyManager moneyManager;

		// Token: 0x0400002E RID: 46
		private RiskManager riskManager;

		// Token: 0x0400002F RID: 47
		private ExposureManager exposureManager;

		// Token: 0x04000030 RID: 48
		private Dictionary<Instrument, Entry> entries;

		// Token: 0x04000031 RID: 49
		private Dictionary<Instrument, Exit> exits;

		// Token: 0x04000032 RID: 50
		private Dictionary<Instrument, MoneyManager> moneyManagers;

		// Token: 0x04000033 RID: 51
		private Dictionary<Instrument, RiskManager> riskManagers;
	}
}
