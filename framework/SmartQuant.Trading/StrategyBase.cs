using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Series;
using SmartQuant.Services;
using SmartQuant.Testing;
using SmartQuant.Trading.Design;

namespace SmartQuant.Trading
{
	// Token: 0x02000002 RID: 2
	public abstract class StrategyBase
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (remove) Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00001069
		public event EventHandler ProviderChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000003 RID: 3 RVA: 0x00002082 File Offset: 0x00001082
		// (remove) Token: 0x06000004 RID: 4 RVA: 0x0000209B File Offset: 0x0000109B
		public event EventHandler PortfolioChanged;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000005 RID: 5 RVA: 0x000020B4 File Offset: 0x000010B4
		// (remove) Token: 0x06000006 RID: 6 RVA: 0x000020CD File Offset: 0x000010CD
		public event EventHandler EnabledChanged;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000007 RID: 7 RVA: 0x000020E6 File Offset: 0x000010E6
		// (remove) Token: 0x06000008 RID: 8 RVA: 0x000020FF File Offset: 0x000010FF
		public event ComponentTypeEventHandler ComponentChanged;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000009 RID: 9 RVA: 0x00002118 File Offset: 0x00001118
		// (remove) Token: 0x0600000A RID: 10 RVA: 0x00002131 File Offset: 0x00001131
		public event StopEventHandler StopAdded;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600000B RID: 11 RVA: 0x0000214A File Offset: 0x0000114A
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x00002163 File Offset: 0x00001163
		public event StopEventHandler StopStatusChanged;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600000D RID: 13 RVA: 0x0000217C File Offset: 0x0000117C
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x00002195 File Offset: 0x00001195
		public event EventHandler StopListCleared;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600000F RID: 15 RVA: 0x000021AE File Offset: 0x000011AE
		// (remove) Token: 0x06000010 RID: 16 RVA: 0x000021C7 File Offset: 0x000011C7
		public event TriggerEventHandler TriggerAdded;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000011 RID: 17 RVA: 0x000021E0 File Offset: 0x000011E0
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x000021F9 File Offset: 0x000011F9
		public event TriggerEventHandler TriggerStatusChanged;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000013 RID: 19 RVA: 0x00002212 File Offset: 0x00001212
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x0000222B File Offset: 0x0000122B
		public event EventHandler TriggerListCleared;

		// Token: 0x06000015 RID: 21 RVA: 0x00002244 File Offset: 0x00001244
		protected StrategyBase(string name, string description)
		{
			this.metaStrategyBase = null;
			this.name = name;
			this.description = description;
			this.isEnabled = true;
			this.isActive = true;
			this.ReportManager = (StrategyComponentManager.GetComponent("{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}", this) as ReportManager);
			this.MarketManager = (StrategyComponentManager.GetComponent("{849E4CFE-C19E-4d1e-899D-0BB26DB12AAD}", this) as MarketManager);
			this.portfolio = PortfolioManager.Portfolios[name];
			if (this.portfolio == null)
			{
				this.portfolio = new Portfolio(name);
			}
			this.tester = new LiveTester(this.portfolio);
			this.stops = new StopList();
			this.triggers = new TriggerList();
			this.marketDataProvider = null;
			this.executionProvider = null;
			this.newsProvider = null;
			this.executionService = null;
			this.orders = new OrderTable();
			this.global = new Hashtable();
			this.activeInstruments = new InstrumentList();
			this.barSliceManager = new BarSliceManager();
			this.componentTypeList = new List<ComponentType>();
			this.componentTypeList.Add(ComponentType.MarketManager);
			this.componentTypeList.Add(ComponentType.ReportManager);
			this.activeStops = new Dictionary<Instrument, List<StopBase>>();
			this.portfolios = new Dictionary<Instrument, Portfolio>();
			this.testers = new Dictionary<Instrument, LiveTester>();
			this.statisticsPerInstrumentEnabled = false;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000238A File Offset: 0x0000138A
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002394 File Offset: 0x00001394
		[Category("Components")]
		[Editor(typeof(ReportManagerTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ComponentTypeConverter))]
		public ReportManager ReportManager
		{
			get
			{
				return this.reportManager;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.reportManager != null)
				{
					this.reportManager.Disconnect();
				}
				this.reportManager = value;
				if (this.reportManager != null)
				{
					this.reportManager.Connect();
				}
				this.EmitComponentChanged(ComponentType.ReportManager);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002406 File Offset: 0x00001406
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002410 File Offset: 0x00001410
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Editor(typeof(MarketManagerTypeEditor), typeof(UITypeEditor))]
		[Category("Components")]
		public MarketManager MarketManager
		{
			get
			{
				return this.marketManager;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.marketManager != null)
				{
					this.marketManager.Disconnect();
					this.marketManager.StrategyBase = null;
				}
				this.marketManager = value;
				if (this.marketManager != null)
				{
					this.marketManager.StrategyBase = this;
					this.marketManager.Connect();
				}
				this.EmitComponentChanged(ComponentType.MarketManager);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002497 File Offset: 0x00001497
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000249F File Offset: 0x0000149F
		[Browsable(false)]
		public MetaStrategyBase MetaStrategyBase
		{
			get
			{
				return this.metaStrategyBase;
			}
			internal set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.metaStrategyBase = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000024D5 File Offset: 0x000014D5
		[Category("Naming")]
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000024DD File Offset: 0x000014DD
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000024E5 File Offset: 0x000014E5
		[Category("Naming")]
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.description = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000251B File Offset: 0x0000151B
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002523 File Offset: 0x00001523
		[DefaultValue(true)]
		public bool IsEnabled
		{
			get
			{
				return this.isEnabled;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.isEnabled = value;
				this.EmitEnabledChanged();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000255F File Offset: 0x0000155F
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002567 File Offset: 0x00001567
		[DefaultValue(true)]
		public bool IsActive
		{
			get
			{
				return this.isActive;
			}
			set
			{
				this.isActive = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002570 File Offset: 0x00001570
		public Hashtable Global
		{
			get
			{
				return this.global;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002578 File Offset: 0x00001578
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002580 File Offset: 0x00001580
		[DefaultValue(false)]
		[Description("Enable or disable gathering statistics for each instrument")]
		public bool StatisticsPerInstrumentEnabled
		{
			get
			{
				return this.statisticsPerInstrumentEnabled;
			}
			set
			{
				this.statisticsPerInstrumentEnabled = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002589 File Offset: 0x00001589
		[Browsable(false)]
		public List<ComponentType> ComponentTypeList
		{
			get
			{
				return this.componentTypeList;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002591 File Offset: 0x00001591
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002599 File Offset: 0x00001599
		[Category("Providers")]
		[Editor(typeof(ExecutionProviderTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ProviderTypeConverter))]
		[DefaultValue(null)]
		public IExecutionProvider ExecutionProvider
		{
			get
			{
				return this.executionProvider;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.executionProvider = value;
				this.EmitProviderChanged();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000025D5 File Offset: 0x000015D5
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000025DD File Offset: 0x000015DD
		[DefaultValue(null)]
		[Editor(typeof(MarketDataProviderTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ProviderTypeConverter))]
		[Category("Providers")]
		public IMarketDataProvider MarketDataProvider
		{
			get
			{
				return this.marketDataProvider;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.marketDataProvider = value;
				this.EmitProviderChanged();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002619 File Offset: 0x00001619
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002621 File Offset: 0x00001621
		[Category("Providers")]
		[DefaultValue(null)]
		public INewsProvider NewsProvider
		{
			get
			{
				return this.newsProvider;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.newsProvider = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002657 File Offset: 0x00001657
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000265F File Offset: 0x0000165F
		[Category("Services")]
		[DefaultValue(null)]
		[TypeConverter(typeof(ServiceTypeConverter))]
		[Editor(typeof(ExecutionServiceTypeEditor), typeof(UITypeEditor))]
		public IExecutionService ExecutionService
		{
			get
			{
				return this.executionService;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.executionService = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002695 File Offset: 0x00001695
		[Browsable(false)]
		public LiveTester Tester
		{
			get
			{
				return this.tester;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000269D File Offset: 0x0000169D
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000026A5 File Offset: 0x000016A5
		[Editor(typeof(PortfolioTypeEditor), typeof(UITypeEditor))]
		public Portfolio Portfolio
		{
			get
			{
				return this.portfolio;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.portfolio = value;
				this.EmitPortfolioChanged();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000026E1 File Offset: 0x000016E1
		[Browsable(false)]
		public StopList Stops
		{
			get
			{
				return this.stops;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000026E9 File Offset: 0x000016E9
		[Browsable(false)]
		public TriggerList Triggers
		{
			get
			{
				return this.triggers;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000026F1 File Offset: 0x000016F1
		[Browsable(false)]
		public BarSeriesList Bars
		{
			get
			{
				return this.metaStrategyBase.Bars;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000026FE File Offset: 0x000016FE
		[Browsable(false)]
		public OrderTable Orders
		{
			get
			{
				return this.orders;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002706 File Offset: 0x00001706
		protected virtual void OnInit()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002708 File Offset: 0x00001708
		protected virtual void OnStrategyStop()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000270C File Offset: 0x0000170C
		internal void Init()
		{
			this.isActive = true;
			this.global.Clear();
			this.stops.Clear();
			this.activeStops.Clear();
			if (this.StopListCleared != null)
			{
				this.StopListCleared(this, EventArgs.Empty);
			}
			this.triggers.Clear();
			if (this.TriggerListCleared != null)
			{
				this.TriggerListCleared(this, EventArgs.Empty);
			}
			this.activeInstruments.Clear();
			if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Simulation || (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live && this.metaStrategyBase.ResetPortfolio))
			{
				this.portfolio.Clear();
				this.portfolios.Clear();
				this.testers.Clear();
				this.tester.FriendlyTesters.Clear();
			}
			this.portfolio.TransactionAdded += this.portfolio_TransactionAdded;
			this.portfolio.PositionOpened += this.portfolio_PositionOpened;
			this.portfolio.PositionChanged += this.portfolio_PositionChanged;
			this.portfolio.PositionClosed += this.portfolio_PositionClosed;
			this.portfolio.ValueChanged += this.portfolio_ValueChanged;
			this.portfolio.Monitored = true;
			this.orders.Clear();
			this.marketManager.Instruments.Clear();
			this.marketManager.MarketDataProviderTable.Clear();
			if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live)
			{
				this.marketManager.StrategyMarketDataProvider = this.marketDataProvider;
				this.marketManager.StrategyExecutionProvider = this.executionProvider;
			}
			this.marketManager.Init();
			this.tester.Disconnect();
			this.tester.Connect();
			this.tester.Reset();
			if (this.statisticsPerInstrumentEnabled)
			{
				foreach (LiveTester liveTester in this.testers.Values)
				{
					liveTester.Connect();
					liveTester.Reset();
				}
			}
			foreach (object obj in this.marketManager.Instruments)
			{
				Instrument instrument = (Instrument)obj;
				instrument.Reset();
				BarSeries barSeries = this.Bars[instrument];
				this.activeStops[instrument] = new List<StopBase>();
				if (this.statisticsPerInstrumentEnabled && !this.portfolios.ContainsKey(instrument))
				{
					Portfolio portfolio = new Portfolio();
					portfolio.Name = string.Format("{0} [{1}]", this.name, instrument.Symbol);
					if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live && !this.metaStrategyBase.ResetPortfolio)
					{
						portfolio.Account.Deposit(this.portfolio.GetAccountValue(), this.portfolio.Account.Currency, Clock.Now, "Initial Cash Allocation");
					}
					LiveTester liveTester2 = new LiveTester(portfolio);
					liveTester2.FollowChanges = true;
					this.portfolios.Add(instrument, portfolio);
					this.testers.Add(instrument, liveTester2);
					this.tester.FriendlyTesters.Add(instrument, liveTester2);
				}
			}
			this.barSliceManager.InstrumentsCount = this.marketManager.Instruments.Count;
			this.barSliceManager.Reset();
			this.OnInit();
			this.reportManager.Tester = this.tester;
			if (!this.MetaStrategyBase.IsOptimizing)
			{
				this.reportManager.Init();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002AE8 File Offset: 0x00001AE8
		internal void StrategyStop()
		{
			this.OnStrategyStop();
			this.marketManager.OnStrategyStop();
			this.portfolio.TransactionAdded -= this.portfolio_TransactionAdded;
			this.portfolio.PositionOpened -= this.portfolio_PositionOpened;
			this.portfolio.PositionChanged -= this.portfolio_PositionChanged;
			this.portfolio.PositionClosed -= this.portfolio_PositionClosed;
			this.portfolio.ValueChanged -= this.portfolio_ValueChanged;
			this.portfolio.Monitored = false;
			foreach (Portfolio portfolio in this.portfolios.Values)
			{
				portfolio.Monitored = false;
			}
			this.DisconnectAllStops();
			this.DisconnectAllTriggers();
			this.DisconnectTester();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002BE4 File Offset: 0x00001BE4
		protected void SetProxyProperties(object obj, object proxy)
		{
			foreach (PropertyInfo propertyInfo in proxy.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				bool flag = false;
				foreach (Attribute attribute in propertyInfo.GetCustomAttributes(true))
				{
					if (attribute.GetType() == typeof(BrowsableAttribute) && !(attribute as BrowsableAttribute).Browsable)
					{
						flag = true;
					}
				}
				if (!flag && propertyInfo.CanRead && propertyInfo.CanWrite)
				{
					obj.GetType().GetProperty(propertyInfo.Name).SetValue(obj, propertyInfo.GetValue(proxy, null), null);
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C99 File Offset: 0x00001C99
		internal virtual void AddStop(StopBase stop)
		{
			this.stops.Add(stop);
			this.activeStops[stop.Instrument].Add(stop);
			if (this.StopAdded != null)
			{
				this.StopAdded(new StopEventArgs(stop));
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002CD7 File Offset: 0x00001CD7
		internal void EmitStopStatusChanged(StopBase stop)
		{
			if (stop.Status != StopStatus.Active)
			{
				this.activeStops[stop.Instrument].Remove(stop);
			}
			if (this.StopStatusChanged != null)
			{
				this.StopStatusChanged(new StopEventArgs(stop));
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002D14 File Offset: 0x00001D14
		private void DisconnectAllStops()
		{
			foreach (object obj in this.stops)
			{
				StopBase stopBase = (StopBase)obj;
				stopBase.Disconnect();
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002D6C File Offset: 0x00001D6C
		internal void AddTrigger(Trigger trigger)
		{
			this.triggers.Add(trigger);
			if (this.TriggerAdded != null)
			{
				this.TriggerAdded(new TriggerEventArgs(trigger));
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D93 File Offset: 0x00001D93
		internal void EmitTriggerStatusChanged(Trigger trigger)
		{
			if (this.TriggerStatusChanged != null)
			{
				this.TriggerStatusChanged(new TriggerEventArgs(trigger));
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002DB0 File Offset: 0x00001DB0
		private void DisconnectAllTriggers()
		{
			foreach (object obj in this.triggers)
			{
				Trigger trigger = (Trigger)obj;
				trigger.Disconnect();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002E08 File Offset: 0x00001E08
		private void DisconnectTester()
		{
			if (this.statisticsPerInstrumentEnabled)
			{
				foreach (LiveTester liveTester in this.testers.Values)
				{
					liveTester.Disconnect();
				}
			}
			this.tester.Disconnect();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002E74 File Offset: 0x00001E74
		internal void Close()
		{
			StrategyComponentManager.ClearComponentCache(this);
			this.metaStrategyBase = null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002E83 File Offset: 0x00001E83
		internal void PrepareTester()
		{
			this.tester.SaveSettings();
			this.tester.DisableComponents();
			this.tester.FollowChanges = true;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002EA7 File Offset: 0x00001EA7
		internal void RestoreTester()
		{
			this.tester.RestoreSettings();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002EB4 File Offset: 0x00001EB4
		internal void Deposit(double val, Currency currency, DateTime datetime, string text)
		{
			this.portfolio.Account.Deposit(val, currency, datetime, text);
			foreach (Portfolio portfolio in this.portfolios.Values)
			{
				portfolio.Account.Deposit(val, currency, datetime, text);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002F2C File Offset: 0x00001F2C
		internal void Withdraw(double val, Currency currency, DateTime datetime, string text)
		{
			this.portfolio.Account.Withdraw(val, currency, datetime, text);
			foreach (Portfolio portfolio in this.portfolios.Values)
			{
				portfolio.Account.Withdraw(val, currency, datetime, text);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002FA4 File Offset: 0x00001FA4
		public void AddInstrument(Instrument instrument)
		{
			if (!this.activeInstruments.Contains(instrument))
			{
				this.activeInstruments.Add(instrument);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002FC0 File Offset: 0x00001FC0
		public void AddInstrument(string symbol)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument != null)
			{
				this.AddInstrument(instrument);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002FE3 File Offset: 0x00001FE3
		public void RemoveInstrument(Instrument instrument)
		{
			if (this.activeInstruments.Contains(instrument))
			{
				this.activeInstruments.Remove(instrument);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003000 File Offset: 0x00002000
		public void RemoveInstrument(string symbol)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument != null)
			{
				this.RemoveInstrument(instrument);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003023 File Offset: 0x00002023
		public bool IsInstrumentActive(Instrument instrument)
		{
			return this.activeInstruments.Contains(instrument);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003031 File Offset: 0x00002031
		protected void EmitProviderChanged()
		{
			if (this.ProviderChanged != null)
			{
				this.ProviderChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000304C File Offset: 0x0000204C
		protected void EmitPortfolioChanged()
		{
			if (this.PortfolioChanged != null)
			{
				this.PortfolioChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003067 File Offset: 0x00002067
		protected void EmitEnabledChanged()
		{
			if (this.EnabledChanged != null)
			{
				this.EnabledChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003082 File Offset: 0x00002082
		protected void EmitComponentChanged(ComponentType componentType)
		{
			if (this.ComponentChanged != null)
			{
				this.ComponentChanged(this, new ComponentTypeEventArgs(componentType));
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000309E File Offset: 0x0000209E
		protected void EmitStopAdded(StopBase stop)
		{
			if (this.StopAdded != null)
			{
				this.StopAdded(new StopEventArgs(stop));
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000030B9 File Offset: 0x000020B9
		protected virtual void OnProviderConnected(IProvider provider)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000030BB File Offset: 0x000020BB
		protected virtual void OnProviderDisconnected(IProvider provider)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000030BD File Offset: 0x000020BD
		protected virtual void OnProviderError(IProvider provider, int id, int code, string message)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000030BF File Offset: 0x000020BF
		internal void SetProviderConnected(IProvider provider)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetProviderConnected> {0} {1}", this.name, provider.Name));
			}
			this.OnProviderConnected(provider);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000030F8 File Offset: 0x000020F8
		internal void SetProviderDisconnected(IProvider provider)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetProviderDisconnected> {0} {1}", this.name, provider.Name));
			}
			this.OnProviderDisconnected(provider);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003134 File Offset: 0x00002134
		internal void SetProviderError(IProvider provider, int id, int code, string message)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<SetProviderError> {0} {1} {2} {3} {4}", new object[]
				{
					this.name,
					provider.Name,
					id,
					code,
					message
				}));
			}
			this.OnProviderError(provider, id, code, message);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000031A1 File Offset: 0x000021A1
		protected virtual void OnServiceStatusChanged(IService service)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000031A3 File Offset: 0x000021A3
		protected virtual void OnServiceError(IService service, ServiceErrorType errorType, string text)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000031A5 File Offset: 0x000021A5
		internal void SetServiceStatusChanged(IService service)
		{
			if (!this.isActive)
			{
				return;
			}
			this.OnServiceStatusChanged(service);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000031B7 File Offset: 0x000021B7
		internal void SetServiceError(IService service, ServiceErrorType errorType, string text)
		{
			if (!this.isActive)
			{
				return;
			}
			this.OnServiceError(service, errorType, text);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000031CB File Offset: 0x000021CB
		protected virtual void OnNewClientOrder(SingleOrder order)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000031CD File Offset: 0x000021CD
		internal void SetNewClientOrder(SingleOrder order)
		{
			if (!this.isActive)
			{
				return;
			}
			this.OnNewClientOrder(order);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000031DF File Offset: 0x000021DF
		internal void SendExecutionReport(ExecutionReport report)
		{
			this.MetaStrategyBase.SendExecutionReport(this, report);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000031EE File Offset: 0x000021EE
		protected virtual void OnNewTrade(Instrument instrument, Trade trade)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000031F0 File Offset: 0x000021F0
		protected virtual void OnNewQuote(Instrument instrument, Quote quote)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000031F2 File Offset: 0x000021F2
		protected virtual void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000031F4 File Offset: 0x000021F4
		protected virtual void OnNewFundamental(Instrument instrument, Fundamental fundamental)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000031F6 File Offset: 0x000021F6
		protected virtual void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000031F8 File Offset: 0x000021F8
		protected virtual void OnNewBarOpen(Instrument instrument, Bar bar)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000031FA File Offset: 0x000021FA
		protected virtual void OnNewBar(Instrument instrument, Bar bar)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000031FC File Offset: 0x000021FC
		protected virtual void OnNewBarSlice(long barSize)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000031FE File Offset: 0x000021FE
		internal void SetNewTrade(Instrument instrument, Trade trade)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewTrade> {0} {1} {2}", this.Name, instrument.Symbol, trade));
			}
			this.OnNewTrade(instrument, trade);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003239 File Offset: 0x00002239
		internal void SetNewQuote(Instrument instrument, Quote quote)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewQuote> {0} {1} {2}", this.Name, instrument.Symbol, quote));
			}
			this.OnNewQuote(instrument, quote);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003274 File Offset: 0x00002274
		internal void SetNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewMarketDepth> {0} {1} {2}", this.Name, instrument.Symbol, marketDepth));
			}
			this.OnNewMarketDepth(instrument, marketDepth);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000032AF File Offset: 0x000022AF
		internal void SetNewFundamental(Instrument instrument, Fundamental fundamental)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewFundamental> {0} {1} {2}", this.Name, instrument.Symbol, fundamental));
			}
			this.OnNewFundamental(instrument, fundamental);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000032EA File Offset: 0x000022EA
		internal void SetNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewCorporateAction> {0} {1} {2}", this.Name, instrument.Symbol, corporateAction));
			}
			this.OnNewCorporateAction(instrument, corporateAction);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003325 File Offset: 0x00002325
		internal void SetNewBarOpen(Instrument instrument, Bar bar)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewBarOpen> {0} {1} {2}", this.Name, instrument.Symbol, bar));
			}
			this.OnNewBarOpen(instrument, bar);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003360 File Offset: 0x00002360
		internal void SetNewBar(Instrument instrument, Bar bar)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewBar> {0} {1} {2}", this.Name, instrument.Symbol, bar));
			}
			if (bar.BarType == BarType.Time)
			{
				this.barSliceManager.AddBar(instrument, bar);
				return;
			}
			this.OnNewBar(instrument, bar);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000033C0 File Offset: 0x000023C0
		internal void SetNewBarSlice(long barSize)
		{
			if (!this.isActive)
			{
				return;
			}
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Format("<Strategy.SetNewBarSlice> {0} {1}", this.Name, barSize));
			}
			BarSlice slice = this.barSliceManager.GetSlice(barSize);
			if (slice != null)
			{
				foreach (KeyValuePair<Instrument, Bar> keyValuePair in slice.Table)
				{
					this.OnNewBar(keyValuePair.Key, keyValuePair.Value);
				}
				this.OnNewBarSlice(barSize);
				slice.Reset();
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003470 File Offset: 0x00002470
		protected virtual void OnNewOrder(SingleOrder order)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003472 File Offset: 0x00002472
		protected virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003474 File Offset: 0x00002474
		protected virtual void OnOrderPartiallyFilled(SingleOrder order)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003476 File Offset: 0x00002476
		protected virtual void OnOrderStatusChanged(SingleOrder order)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003478 File Offset: 0x00002478
		protected virtual void OnOrderFilled(SingleOrder order)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000347A File Offset: 0x0000247A
		protected virtual void OnOrderCancelled(SingleOrder order)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000347C File Offset: 0x0000247C
		protected virtual void OnOrderRejected(SingleOrder order)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000347E File Offset: 0x0000247E
		protected virtual void OnOrderDone(SingleOrder order)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003480 File Offset: 0x00002480
		internal void SetNewOrder(SingleOrder order)
		{
			Instrument instrument = order.Instrument;
			if (order.Text != "")
			{
				this.orders.Add(instrument, order.Text, order);
			}
			this.OnNewOrder(order);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000034C0 File Offset: 0x000024C0
		internal void SetExecutionReport(SingleOrder order, ExecutionReport report)
		{
			this.OnExecutionReport(order, report);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000034CA File Offset: 0x000024CA
		internal void SetOrderPartiallyFilled(SingleOrder order)
		{
			this.OnOrderPartiallyFilled(order);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000034D3 File Offset: 0x000024D3
		internal void SetOrderStatusChanged(SingleOrder order)
		{
			this.OnOrderStatusChanged(order);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000034DC File Offset: 0x000024DC
		internal void SetOrderDone(SingleOrder order)
		{
			OrdStatus ordStatus = order.OrdStatus;
			switch (ordStatus)
			{
			case OrdStatus.Filled:
				this.OnOrderFilled(order);
				break;
			case OrdStatus.DoneForDay:
				break;
			case OrdStatus.Cancelled:
				this.OnOrderCancelled(order);
				break;
			default:
				if (ordStatus == OrdStatus.Rejected)
				{
					this.OnOrderRejected(order);
				}
				break;
			}
			this.OnOrderDone(order);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000352B File Offset: 0x0000252B
		protected virtual void OnTransactionAdded(Transaction transaction)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000352D File Offset: 0x0000252D
		protected virtual void OnPositionOpened(Position position)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000352F File Offset: 0x0000252F
		protected virtual void OnPositionClosed(Position position)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003531 File Offset: 0x00002531
		protected virtual void OnPositionChanged(Position position)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003533 File Offset: 0x00002533
		protected virtual void OnPortfolioValueChanged(Position position)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003535 File Offset: 0x00002535
		internal void SetTransactionAdded(Transaction transaction)
		{
			if (!this.isActive)
			{
				return;
			}
			this.portfolio.Add(transaction);
			if (this.statisticsPerInstrumentEnabled)
			{
				this.portfolios[transaction.Instrument].Add(transaction);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000356B File Offset: 0x0000256B
		private void portfolio_TransactionAdded(object sender, TransactionEventArgs args)
		{
			this.OnTransactionAdded(args.Transaction);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003579 File Offset: 0x00002579
		private void portfolio_PositionOpened(object sender, PositionEventArgs args)
		{
			this.OnPositionOpened(args.Position);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003587 File Offset: 0x00002587
		private void portfolio_PositionChanged(object sender, PositionEventArgs args)
		{
			this.OnPositionChanged(args.Position);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003595 File Offset: 0x00002595
		private void portfolio_PositionClosed(object sender, PositionEventArgs args)
		{
			this.OnPositionClosed(args.Position);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000035A4 File Offset: 0x000025A4
		private void portfolio_ValueChanged(object sender, PositionEventArgs args)
		{
			if (!this.isActive)
			{
				return;
			}
			try
			{
				this.OnPortfolioValueChanged(args.Position);
			}
			catch (Exception exception)
			{
				this.metaStrategyBase.EmitError(exception);
			}
		}

		// Token: 0x06000086 RID: 134
		public abstract void ClosePosition(Instrument instrument, double price, ComponentType component, string text);

		// Token: 0x06000087 RID: 135 RVA: 0x000035E8 File Offset: 0x000025E8
		public void ClosePosition(Instrument instrument, string text)
		{
			this.ClosePosition(instrument, 0.0, ComponentType.RiskManager, text);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000035FD File Offset: 0x000025FD
		public void ClosePosition(Instrument instrument)
		{
			this.ClosePosition(instrument, "");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000360C File Offset: 0x0000260C
		public void ClosePortfolio(string text)
		{
			PositionList positionList = new PositionList();
			foreach (object obj in this.portfolio.Positions)
			{
				Position position = (Position)obj;
				positionList.Add(position);
			}
			foreach (object obj2 in positionList)
			{
				Position position2 = (Position)obj2;
				this.ClosePosition(position2.Instrument, text);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000036C4 File Offset: 0x000026C4
		public void ClosePortfolio()
		{
			this.ClosePortfolio("");
		}

		// Token: 0x0600008B RID: 139
		public abstract IComponentBase GetComponent(ComponentType type);

		// Token: 0x0600008C RID: 140
		public abstract void SetComponent(ComponentType type, IComponentBase component);

		// Token: 0x04000001 RID: 1
		protected const string CATEGORY_COMPONENTS = "Components";

		// Token: 0x04000002 RID: 2
		protected const string CATEGORY_PROVIDERS = "Providers";

		// Token: 0x04000003 RID: 3
		protected const string CATEGORY_NAMING = "Naming";

		// Token: 0x04000004 RID: 4
		protected const string CATEGORY_SERVICES = "Services";

		// Token: 0x04000005 RID: 5
		protected MetaStrategyBase metaStrategyBase;

		// Token: 0x04000006 RID: 6
		protected string name;

		// Token: 0x04000007 RID: 7
		protected string description;

		// Token: 0x04000008 RID: 8
		protected ReportManager reportManager;

		// Token: 0x04000009 RID: 9
		protected MarketManager marketManager;

		// Token: 0x0400000A RID: 10
		protected bool isEnabled;

		// Token: 0x0400000B RID: 11
		protected bool isActive;

		// Token: 0x0400000C RID: 12
		protected Portfolio portfolio;

		// Token: 0x0400000D RID: 13
		protected LiveTester tester;

		// Token: 0x0400000E RID: 14
		protected StopList stops;

		// Token: 0x0400000F RID: 15
		protected TriggerList triggers;

		// Token: 0x04000010 RID: 16
		protected IMarketDataProvider marketDataProvider;

		// Token: 0x04000011 RID: 17
		protected IExecutionProvider executionProvider;

		// Token: 0x04000012 RID: 18
		protected INewsProvider newsProvider;

		// Token: 0x04000013 RID: 19
		protected IExecutionService executionService;

		// Token: 0x04000014 RID: 20
		protected OrderTable orders;

		// Token: 0x04000015 RID: 21
		protected Hashtable global;

		// Token: 0x04000016 RID: 22
		protected InstrumentList activeInstruments;

		// Token: 0x04000017 RID: 23
		protected BarSliceManager barSliceManager;

		// Token: 0x04000018 RID: 24
		protected List<ComponentType> componentTypeList;

		// Token: 0x04000019 RID: 25
		protected Dictionary<Instrument, List<StopBase>> activeStops;

		// Token: 0x0400001A RID: 26
		protected Dictionary<Instrument, Portfolio> portfolios;

		// Token: 0x0400001B RID: 27
		protected Dictionary<Instrument, LiveTester> testers;

		// Token: 0x0400001C RID: 28
		protected bool statisticsPerInstrumentEnabled;
	}
}
