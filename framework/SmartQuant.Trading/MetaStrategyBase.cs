using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Threading;
using SmartQuant.Charting;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Optimization;
using SmartQuant.Providers;
using SmartQuant.Series;
using SmartQuant.Services;
using SmartQuant.Simulation;
using SmartQuant.Testing;
using SmartQuant.Trading.Design;

namespace SmartQuant.Trading
{
	// Token: 0x0200002F RID: 47
	public abstract class MetaStrategyBase : IOptimizable
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060001DB RID: 475 RVA: 0x00006BFF File Offset: 0x00005BFF
		// (remove) Token: 0x060001DC RID: 476 RVA: 0x00006C18 File Offset: 0x00005C18
		public event EventHandler Changed;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001DD RID: 477 RVA: 0x00006C31 File Offset: 0x00005C31
		// (remove) Token: 0x060001DE RID: 478 RVA: 0x00006C4A File Offset: 0x00005C4A
		public event ComponentTypeEventHandler ComponentChanged;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060001DF RID: 479 RVA: 0x00006C63 File Offset: 0x00005C63
		// (remove) Token: 0x060001E0 RID: 480 RVA: 0x00006C7C File Offset: 0x00005C7C
		public event EventHandler Started;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060001E1 RID: 481 RVA: 0x00006C95 File Offset: 0x00005C95
		// (remove) Token: 0x060001E2 RID: 482 RVA: 0x00006CAE File Offset: 0x00005CAE
		public event EventHandler Stopped;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060001E3 RID: 483 RVA: 0x00006CC7 File Offset: 0x00005CC7
		// (remove) Token: 0x060001E4 RID: 484 RVA: 0x00006CE0 File Offset: 0x00005CE0
		public event EventHandler Paused;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060001E5 RID: 485 RVA: 0x00006CF9 File Offset: 0x00005CF9
		// (remove) Token: 0x060001E6 RID: 486 RVA: 0x00006D12 File Offset: 0x00005D12
		public event EventHandler DesignModeChanged;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060001E7 RID: 487 RVA: 0x00006D2B File Offset: 0x00005D2B
		// (remove) Token: 0x060001E8 RID: 488 RVA: 0x00006D44 File Offset: 0x00005D44
		public event MetaStrategyErrorEventHandler Error;

		// Token: 0x060001E9 RID: 489 RVA: 0x00006D60 File Offset: 0x00005D60
		protected MetaStrategyBase(string name)
		{
			this.name = name;
			this.strategies = new StrategyList();
			this.SimulationManager = (StrategyComponentManager.GetComponent("{872476E5-3774-4687-828F-34978288A6E0}", this) as SimulationManager);
			this.OptimizationManager = (StrategyComponentManager.GetComponent("{A4D510F9-13DB-4b4c-9557-BC6A48A25D0B}", this) as OptimizationManager);
			this.ReportManager = (StrategyComponentManager.GetComponent("{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}", this) as ReportManager);
			this.MetaMoneyManager = (StrategyComponentManager.GetComponent("{FED5076A-C710-4d3a-B134-3D9D32B8B248}", this) as MetaMoneyManager);
			this.portfolio = PortfolioManager.Portfolios[name];
			if (this.portfolio == null)
			{
				this.portfolio = new Portfolio(name);
			}
			this.resetPortfolio = true;
			this.tester = new LiveTester(this.portfolio);
			this.tester.FollowChanges = true;
			this.optimizer = new BruteForce(this);
			this.optimizer.BestObjectiveReceived += this.optimizer_BestObjectiveReceived;
			this.optimizerType = EOptimizerType.BruteForce;
			this.providerDispatcher = new ProviderDispatcher(this);
			this.marketDataDispatcher = new MarketDataDispatcher(this);
			this.orderProcessor = new OrderProcessor(this);
			this.serviceDispatcher = new ServiceDispatcher(this);
			this.executionServiceDispatcher = new ExecutionServiceDispatcher(this);
			this.providerDispatcherTable = new Dictionary<IProvider, List<StrategyBase>>();
			this.marketDataTable = new Dictionary<IMarketDataProvider, Dictionary<Instrument, List<StrategyBase>>>();
			this.orders = new Dictionary<SingleOrder, StrategyBase>();
			this.serviceDispatcherTable = new Dictionary<IService, List<StrategyBase>>();
			this.executionServiceDispatcherTable = new Dictionary<IExecutionService, List<StrategyBase>>();
			this.maxConnectionTime = 10;
			this.simulator = (ProviderManager.MarketDataSimulator as SimulationDataProvider).Simulator;
			this.simulator.StateChanged += this.OnSimulatorStateChanged;
			this.isRunning = false;
			this.isOptimizing = false;
			this.optimizationParemeters = new ArrayList();
			this.drawingPrimitives = new Hashtable();
			this.portfolioStopList = new StopList();
			this.portfolios = new Dictionary<Instrument, Portfolio>();
			this.testers = new Dictionary<Instrument, LiveTester>();
			this.executionServicesEnabled = false;
			this.componentTypeList = new List<ComponentType>();
			this.componentTypeList.Add(ComponentType.SimulationManager);
			this.componentTypeList.Add(ComponentType.MetaMoneyManager);
			this.componentTypeList.Add(ComponentType.OptimizationManager);
			this.componentTypeList.Add(ComponentType.ReportManager);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00006F8E File Offset: 0x00005F8E
		[Browsable(false)]
		public Dictionary<Instrument, LiveTester> Testers
		{
			get
			{
				return this.testers;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00006F96 File Offset: 0x00005F96
		[Browsable(false)]
		public Dictionary<Instrument, Portfolio> Portfolios
		{
			get
			{
				return this.portfolios;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00006F9E File Offset: 0x00005F9E
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00006FA8 File Offset: 0x00005FA8
		[Editor(typeof(ReportManagerTypeEditor), typeof(UITypeEditor))]
		[Category("Components")]
		[TypeConverter(typeof(ComponentTypeConverter))]
		public ReportManager ReportManager
		{
			get
			{
				return this.reportManager;
			}
			set
			{
				if (!this.DesignMode)
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00007000 File Offset: 0x00006000
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00007008 File Offset: 0x00006008
		[Category("Components")]
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Editor(typeof(SimulationManagerTypeEditor), typeof(UITypeEditor))]
		public SimulationManager SimulationManager
		{
			get
			{
				return this.simulationManager;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.simulationManager != null)
				{
					this.simulationManager.Disconnect();
				}
				this.simulationManager = value;
				if (this.simulationManager != null)
				{
					this.simulationManager.Connect();
				}
				this.EmitComponentChanged(ComponentType.SimulationManager);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00007060 File Offset: 0x00006060
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00007068 File Offset: 0x00006068
		[Editor(typeof(OptimizationManagerTypeEditor), typeof(UITypeEditor))]
		[Category("Components")]
		[TypeConverter(typeof(ComponentTypeConverter))]
		public OptimizationManager OptimizationManager
		{
			get
			{
				return this.optimizationManager;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.optimizationManager != null)
				{
					this.optimizationManager.Disconnect();
					this.optimizationManager.MetaStrategyBase = null;
				}
				this.optimizationManager = value;
				if (this.optimizationManager != null)
				{
					this.optimizationManager.MetaStrategyBase = this;
					this.optimizationManager.Connect();
				}
				this.EmitComponentChanged(ComponentType.OptimizationManager);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000070D8 File Offset: 0x000060D8
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x000070E0 File Offset: 0x000060E0
		[Category("Components")]
		[Editor(typeof(MetaMoneyManagerTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ComponentTypeConverter))]
		public MetaMoneyManager MetaMoneyManager
		{
			get
			{
				return this.metaMoneyManager;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.metaMoneyManager != null)
				{
					this.metaMoneyManager.Disconnect();
					this.metaMoneyManager.MetaStrategyBase = null;
				}
				this.metaMoneyManager = value;
				if (this.metaMoneyManager != null)
				{
					this.metaMoneyManager.MetaStrategyBase = this;
					this.metaMoneyManager.Connect();
				}
				this.EmitComponentChanged(ComponentType.MetaMoneyManager);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00007150 File Offset: 0x00006150
		[Category("Naming")]
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00007158 File Offset: 0x00006158
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00007160 File Offset: 0x00006160
		[DefaultValue(10)]
		[Description("Maximum connection time to providers in seconds.")]
		public int MaxConnectionTime
		{
			get
			{
				return this.maxConnectionTime;
			}
			set
			{
				if (value < 1 || value > 60)
				{
					throw new ArgumentOutOfRangeException("MaxConnectionTime", "The value must be in range 1..60");
				}
				this.maxConnectionTime = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00007182 File Offset: 0x00006182
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000718A File Offset: 0x0000618A
		[DefaultValue(MetaStrategyMode.Simulation)]
		public MetaStrategyMode MetaStrategyMode
		{
			get
			{
				return this.metaStrategyMode;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.metaStrategyMode = value;
				this.EmitChanged();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000071AC File Offset: 0x000061AC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000071B4 File Offset: 0x000061B4
		[Editor(typeof(PortfolioTypeEditor), typeof(UITypeEditor))]
		[Category("Portfolio")]
		public Portfolio Portfolio
		{
			get
			{
				return this.portfolio;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.portfolio = value;
				this.EmitChanged();
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000071D6 File Offset: 0x000061D6
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000071DE File Offset: 0x000061DE
		[Category("Data Persistent")]
		[DefaultValue(true)]
		[Description("Gets or sets a value indicating whether the portfolio will be cleared when metastrategy start in LIVE mode.")]
		public bool ResetPortfolio
		{
			get
			{
				return this.resetPortfolio;
			}
			set
			{
				this.resetPortfolio = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000071E7 File Offset: 0x000061E7
		// (set) Token: 0x060001FE RID: 510 RVA: 0x000071EF File Offset: 0x000061EF
		[DefaultValue(false)]
		[Category("Data Persistent")]
		[Description("Gets or sets a value indicating whether orders will be saved in LIVE mode.")]
		public bool SaveOrders
		{
			get
			{
				return this.saveOrders;
			}
			set
			{
				this.saveOrders = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000071F8 File Offset: 0x000061F8
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00007200 File Offset: 0x00006200
		[Description("Enable or disable gathering statistics for each instrument")]
		[DefaultValue(false)]
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00007209 File Offset: 0x00006209
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00007211 File Offset: 0x00006211
		[DefaultValue(false)]
		public bool ExecutionServicesEnabled
		{
			get
			{
				return this.executionServicesEnabled;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				this.executionServicesEnabled = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000722D File Offset: 0x0000622D
		[Browsable(false)]
		public LiveTester Tester
		{
			get
			{
				return this.tester;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00007235 File Offset: 0x00006235
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00007240 File Offset: 0x00006240
		[Browsable(false)]
		public Optimizer Optimizer
		{
			get
			{
				return this.optimizer;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.optimizer != value)
				{
					if (this.optimizer != null)
					{
						this.optimizer.BestObjectiveReceived -= this.optimizer_BestObjectiveReceived;
					}
					this.optimizer = value;
					this.optimizer.BestObjectiveReceived += this.optimizer_BestObjectiveReceived;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000072A6 File Offset: 0x000062A6
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000072B0 File Offset: 0x000062B0
		[DefaultValue(EOptimizerType.BruteForce)]
		public EOptimizerType OptimizerType
		{
			get
			{
				return this.optimizerType;
			}
			set
			{
				if (!this.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (value != this.optimizerType)
				{
					if (this.optimizer != null)
					{
						this.optimizer.BestObjectiveReceived -= this.optimizer_BestObjectiveReceived;
					}
					this.optimizerType = value;
					switch (this.optimizerType)
					{
					case EOptimizerType.SimulatedAnnealing:
						this.optimizer = new SimulatedAnnealing(this);
						break;
					case EOptimizerType.BruteForce:
						this.optimizer = new BruteForce(this);
						break;
					}
					this.optimizer.BestObjectiveReceived += this.optimizer_BestObjectiveReceived;
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00007349 File Offset: 0x00006349
		[Browsable(false)]
		public StrategyList Strategies
		{
			get
			{
				return this.strategies;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00007351 File Offset: 0x00006351
		[Browsable(false)]
		public BarSeriesList Bars
		{
			get
			{
				return DataManager.Bars;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00007358 File Offset: 0x00006358
		[Browsable(false)]
		public bool DesignMode
		{
			get
			{
				return !this.isRunning && !this.isOptimizing;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000736D File Offset: 0x0000636D
		[Browsable(false)]
		internal bool IsRunning
		{
			get
			{
				return this.isRunning;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00007375 File Offset: 0x00006375
		[Browsable(false)]
		internal bool IsOptimizing
		{
			get
			{
				return this.isOptimizing;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000737D File Offset: 0x0000637D
		[Browsable(false)]
		public Hashtable DrawingPrimitives
		{
			get
			{
				return this.drawingPrimitives;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00007385 File Offset: 0x00006385
		[Browsable(false)]
		public List<ComponentType> ComponentTypeList
		{
			get
			{
				return this.componentTypeList;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000738D File Offset: 0x0000638D
		public void Add(StrategyBase strategy)
		{
			if (!this.DesignMode)
			{
				throw new InvalidOperationException("MetaStrategy is not in design mode");
			}
			this.strategies.Add(strategy);
			strategy.MetaStrategyBase = this;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000073B5 File Offset: 0x000063B5
		public void Remove(StrategyBase strategy)
		{
			if (!this.DesignMode)
			{
				throw new InvalidOperationException("MetaStrategy is not in design mode");
			}
			this.strategies.Remove(strategy);
			strategy.MetaStrategyBase = null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000073E0 File Offset: 0x000063E0
		public void Close()
		{
			this.simulator.StateChanged -= this.OnSimulatorStateChanged;
			foreach (object obj in this.strategies)
			{
				StrategyBase strategyBase = (StrategyBase)obj;
				strategyBase.Close();
			}
			StrategyComponentManager.ClearComponentCache(this);
			this.Portfolio = null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000745C File Offset: 0x0000645C
		internal void AddPortfolioStop(PortfolioStop stop)
		{
			this.portfolioStopList.Add(stop);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000746C File Offset: 0x0000646C
		internal void DisconnectAllPortfolioStops()
		{
			foreach (object obj in this.portfolioStopList)
			{
				PortfolioStop portfolioStop = (PortfolioStop)obj;
				portfolioStop.Disconnect();
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000074C4 File Offset: 0x000064C4
		public void StopOptimization()
		{
			this.optimizer.Stop();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000074D1 File Offset: 0x000064D1
		protected virtual void OnInit()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000074D3 File Offset: 0x000064D3
		protected virtual void OnMoneyAllocation()
		{
			this.metaMoneyManager.Allocate();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000074E0 File Offset: 0x000064E0
		public void Start(bool doStep)
		{
			DataManager.ClearDataArrays();
			this.drawingPrimitives.Clear();
			this.providerDispatcherTable.Clear();
			this.marketDataTable.Clear();
			this.orders.Clear();
			this.providerDispatcher.Init();
			this.marketDataDispatcher.Init();
			this.orderProcessor.Init();
			this.serviceDispatcherTable.Clear();
			this.executionServiceDispatcherTable.Clear();
			this.serviceDispatcher.Init();
			this.executionServiceDispatcher.Init();
			if (this.metaStrategyMode == MetaStrategyMode.Simulation)
			{
				this.simulationManager.Requests.Clear();
				this.simulationManager.Init();
				Clock.ClockMode = ClockMode.Simulation;
				Clock.SetDateTime(this.simulationManager.EntryDate);
				foreach (object obj in this.simulationManager.StaticRequests)
				{
					string request = (string)obj;
					this.simulationManager.SendMarketDataRequest(request);
				}
				this.simulator.Intervals.Clear();
				this.simulator.Intervals.Add(this.simulationManager.EntryDate, this.simulationManager.ExitDate);
				this.simulator.SimulationMode = this.simulationManager.Mode;
				this.simulator.SpeedMultiplier = this.simulationManager.SpeedMultiplier;
				this.simulator.Step = this.simulationManager.Step;
				OrderManager.RemoveOrders(11104, MetaStrategyBase.FIX_MODES[this.metaStrategyMode]);
				OrderManager.OCA.Clear();
				OrderManager.SellSide.RemoveOrders(11104, MetaStrategyBase.FIX_MODES[this.metaStrategyMode]);
			}
			if (this.metaStrategyMode == MetaStrategyMode.Simulation || (this.metaStrategyMode == MetaStrategyMode.Live && this.resetPortfolio))
			{
				this.portfolio.Clear();
				this.portfolios.Clear();
				this.testers.Clear();
				this.tester.FriendlyTesters.Clear();
			}
			this.tester.Disconnect();
			this.tester.Connect();
			this.tester.Reset();
			bool flag = this.portfolio.Account.Transactions.Count == 0;
			if (flag)
			{
				this.portfolio.Account.Deposit(this.simulationManager.Cash, this.simulationManager.Currency, Clock.Now, "Initial Cash Allocation");
			}
			this.portfolio.TransactionAdded += this.portfolio_TransactionAdded;
			this.portfolio.PositionOpened += this.portfolio_PositionOpened;
			this.portfolio.PositionChanged += this.portfolio_PositionChanged;
			this.portfolio.PositionClosed += this.portfolio_PositionClosed;
			this.portfolio.ValueChanged += this.portfolio_ValueChanged;
			this.portfolio.Monitored = true;
			this.optimizationManager.Init();
			if (!this.isOptimizing)
			{
				this.reportManager.Tester = this.tester;
				this.reportManager.Init();
			}
			this.metaMoneyManager.Init();
			this.OnInit();
			foreach (object obj2 in this.strategies)
			{
				StrategyBase strategyBase = (StrategyBase)obj2;
				if (strategyBase.IsEnabled)
				{
					strategyBase.Init();
				}
			}
			if (flag)
			{
				this.OnMoneyAllocation();
			}
			if (this.statisticsPerInstrumentEnabled)
			{
				foreach (LiveTester liveTester in this.testers.Values)
				{
					liveTester.Connect();
					liveTester.Reset();
				}
				foreach (object obj3 in this.strategies)
				{
					StrategyBase strategyBase2 = (StrategyBase)obj3;
					if (strategyBase2.IsEnabled)
					{
						foreach (object obj4 in strategyBase2.MarketManager.Instruments)
						{
							Instrument instrument = (Instrument)obj4;
							if (!this.portfolios.ContainsKey(instrument))
							{
								Portfolio portfolio = new Portfolio();
								portfolio.Name = string.Format("{0} [{1}]", this.name, instrument.Symbol);
								LiveTester liveTester2 = new LiveTester(portfolio);
								liveTester2.FollowChanges = true;
								this.portfolios.Add(instrument, portfolio);
								this.testers.Add(instrument, liveTester2);
								this.tester.FriendlyTesters.Add(instrument, liveTester2);
								portfolio.Account.Deposit(this.portfolio.GetAccountValue(), this.portfolio.Account.Currency, Clock.Now, "Initial Cash Allocation");
							}
						}
					}
				}
			}
			foreach (object obj5 in this.strategies)
			{
				StrategyBase strategyBase3 = (StrategyBase)obj5;
				if (strategyBase3.IsEnabled)
				{
					switch (this.metaStrategyMode)
					{
					case MetaStrategyMode.Simulation:
						goto IL_5CD;
					case MetaStrategyMode.Live:
						using (Dictionary<Instrument, IExecutionProvider>.ValueCollection.Enumerator enumerator7 = strategyBase3.MarketManager.ExecutionProviderTable.Values.GetEnumerator())
						{
							while (enumerator7.MoveNext())
							{
								IExecutionProvider provider = enumerator7.Current;
								this.RegisterStrategy(provider, strategyBase3);
								this.orderProcessor.Add(provider);
								this.providerDispatcher.Add(provider);
							}
							break;
						}
						goto IL_5CD;
					}
					IL_617:
					foreach (KeyValuePair<Instrument, IMarketDataProvider> keyValuePair in strategyBase3.MarketManager.MarketDataProviderTable)
					{
						Instrument key = keyValuePair.Key;
						switch (this.metaStrategyMode)
						{
						case MetaStrategyMode.Simulation:
							foreach (object obj6 in this.simulationManager.Requests)
							{
								string seriesSuffix = (string)obj6;
								this.marketDataDispatcher.Add(ProviderManager.MarketDataSimulator, key, seriesSuffix);
							}
							this.RegisterStrategy(ProviderManager.MarketDataSimulator, key, strategyBase3);
							break;
						case MetaStrategyMode.Live:
						{
							IMarketDataProvider value = keyValuePair.Value;
							this.marketDataDispatcher.Add(value, key, null);
							this.providerDispatcher.Add(value);
							this.RegisterStrategy(value, strategyBase3);
							this.RegisterStrategy(value, key, strategyBase3);
							break;
						}
						}
					}
					continue;
					IL_5CD:
					this.orderProcessor.Add(ProviderManager.ExecutionSimulator);
					this.providerDispatcher.Add(ProviderManager.MarketDataSimulator);
					this.providerDispatcher.Add(ProviderManager.ExecutionSimulator);
					this.RegisterStrategy(ProviderManager.MarketDataSimulator, strategyBase3);
					this.RegisterStrategy(ProviderManager.ExecutionSimulator, strategyBase3);
					goto IL_617;
				}
			}
			this.providerDispatcher.Online(this.maxConnectionTime * 1000);
			this.marketDataDispatcher.Online();
			this.orderProcessor.Online();
			if (this.executionServicesEnabled)
			{
				foreach (object obj7 in this.strategies)
				{
					StrategyBase strategyBase4 = (StrategyBase)obj7;
					switch (this.metaStrategyMode)
					{
					case MetaStrategyMode.Simulation:
						this.RegisterStrategy(ServiceManager.ExecutionSimulator, strategyBase4);
						break;
					case MetaStrategyMode.Live:
						if (strategyBase4.ExecutionService != null)
						{
							this.RegisterStrategy(strategyBase4.ExecutionService, strategyBase4);
						}
						break;
					}
				}
				this.serviceDispatcher.Online();
				this.executionServiceDispatcher.Online();
			}
			this.isRunning = true;
			switch (this.metaStrategyMode)
			{
			case MetaStrategyMode.Simulation:
				if (doStep)
				{
					this.simulator.DoStep(false);
					while (this.isRunning)
					{
						Thread.Sleep(1);
					}
					return;
				}
				this.simulator.Start(true);
				return;
			case MetaStrategyMode.Live:
				this.EmitStarted();
				while (this.isRunning)
				{
					Thread.Sleep(1);
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00007E50 File Offset: 0x00006E50
		public void Continue()
		{
			if (this.metaStrategyMode == MetaStrategyMode.Simulation)
			{
				this.simulator.Continue();
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00007E65 File Offset: 0x00006E65
		public void DoStep()
		{
			if (this.metaStrategyMode == MetaStrategyMode.Simulation)
			{
				this.simulator.DoStep(false);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00007E7B File Offset: 0x00006E7B
		public void Stop()
		{
			if (this.metaStrategyMode == MetaStrategyMode.Simulation)
			{
				this.simulator.Stop(false);
				return;
			}
			this.MetaStrategyStop();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00007E98 File Offset: 0x00006E98
		protected virtual void OnMetaStrategyStop()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00007E9C File Offset: 0x00006E9C
		private void MetaStrategyStop()
		{
			if (this.DesignMode)
			{
				return;
			}
			this.isRunning = false;
			this.providerDispatcher.Offline();
			this.marketDataDispatcher.Offline();
			this.orderProcessor.Offline();
			if (this.executionServicesEnabled)
			{
				this.serviceDispatcher.Offline();
				this.executionServiceDispatcher.Offline();
			}
			this.metaMoneyManager.OnStrategyStop();
			this.OnMetaStrategyStop();
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
			this.tester.Disconnect();
			foreach (LiveTester liveTester in this.testers.Values)
			{
				liveTester.Disconnect();
			}
			this.DisconnectAllPortfolioStops();
			foreach (object obj in this.strategies)
			{
				StrategyBase strategyBase = (StrategyBase)obj;
				if (strategyBase.IsEnabled)
				{
					strategyBase.StrategyStop();
				}
			}
			this.simulationManager.OnStrategyStop();
			this.optimizationManager.OnStrategyStop();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00008098 File Offset: 0x00007098
		public void Pause()
		{
			if (this.metaStrategyMode == MetaStrategyMode.Simulation)
			{
				this.simulator.Pause();
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000080B0 File Offset: 0x000070B0
		private void OnSimulatorStateChanged(object sender, EventArgs e)
		{
			if (this.isRunning && this.metaStrategyMode == MetaStrategyMode.Simulation)
			{
				switch (this.simulator.CurrentState)
				{
				case SimulatorState.Stopped:
					this.MetaStrategyStop();
					this.EmitStopped();
					break;
				case SimulatorState.Running:
					this.EmitStarted();
					return;
				case SimulatorState.Paused:
					this.EmitPaused();
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00008106 File Offset: 0x00007106
		protected void EmitChanged()
		{
			if (this.Changed != null)
			{
				this.Changed(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008121 File Offset: 0x00007121
		protected void EmitComponentChanged(ComponentType componentType)
		{
			if (this.ComponentChanged != null)
			{
				this.ComponentChanged(this, new ComponentTypeEventArgs(componentType));
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000813D File Offset: 0x0000713D
		private void EmitStarted()
		{
			if (this.Started != null)
			{
				this.Started(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008158 File Offset: 0x00007158
		private void EmitStopped()
		{
			if (this.Stopped != null)
			{
				this.Stopped(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00008173 File Offset: 0x00007173
		private void EmitPaused()
		{
			if (this.Paused != null)
			{
				this.Paused(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000818E File Offset: 0x0000718E
		private void EmitDesignModeChanged()
		{
			if (this.DesignModeChanged != null)
			{
				this.DesignModeChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000081A9 File Offset: 0x000071A9
		internal void PrepareTester()
		{
			this.tester.SaveSettings();
			this.tester.DisableComponents();
			this.tester.FollowChanges = true;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000081CD File Offset: 0x000071CD
		internal void RestoreTester()
		{
			this.tester.RestoreSettings();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000081DC File Offset: 0x000071DC
		public void Optimize()
		{
			if (this.isRunning)
			{
				throw new InvalidOperationException("MetaStrategy is not in design mode");
			}
			try
			{
				this.isOptimizing = true;
				this.PrepareTester();
				foreach (object obj in this.strategies)
				{
					StrategyBase strategyBase = (StrategyBase)obj;
					if (strategyBase.IsEnabled)
					{
						strategyBase.PrepareTester();
					}
				}
				this.optimizer.Clear();
				this.optimizer.Optimize();
			}
			finally
			{
				this.RestoreTester();
				foreach (object obj2 in this.strategies)
				{
					StrategyBase strategyBase2 = (StrategyBase)obj2;
					if (strategyBase2.IsEnabled)
					{
						strategyBase2.RestoreTester();
					}
				}
				this.isOptimizing = false;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000082E4 File Offset: 0x000072E4
		internal void DrawPrimitive(Instrument instrument, IDrawable primitive, int padNumber)
		{
			if (!this.drawingPrimitives.ContainsKey(instrument))
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(primitive);
				SortedList sortedList = new SortedList();
				sortedList.Add(padNumber, arrayList);
				this.drawingPrimitives.Add(instrument, sortedList);
				return;
			}
			SortedList sortedList2 = this.drawingPrimitives[instrument] as SortedList;
			if (!sortedList2.ContainsKey(padNumber))
			{
				ArrayList arrayList2 = new ArrayList();
				arrayList2.Add(primitive);
				sortedList2.Add(padNumber, arrayList2);
				return;
			}
			ArrayList arrayList3 = sortedList2[padNumber] as ArrayList;
			bool flag = true;
			if (primitive is TimeSeries)
			{
				for (int i = 0; i < arrayList3.Count; i++)
				{
					if (arrayList3[i] is TimeSeries && (primitive as TimeSeries).Name == (arrayList3[i] as TimeSeries).Name && (primitive as TimeSeries).Name != "")
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				arrayList3.Add(primitive);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000083FC File Offset: 0x000073FC
		internal void EmitError(Exception exception)
		{
			if (Trace.IsLevelEnabled(TraceLevel.Error))
			{
				Trace.WriteLine(exception.ToString());
			}
			MetaStrategyErrorEventArgs metaStrategyErrorEventArgs = new MetaStrategyErrorEventArgs(exception);
			if (this.Error != null)
			{
				this.Error(metaStrategyErrorEventArgs);
			}
			if (!metaStrategyErrorEventArgs.Ignore)
			{
				this.Stop();
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008449 File Offset: 0x00007449
		protected virtual void OnTransactionAdded(Transaction transaction)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000844B File Offset: 0x0000744B
		protected virtual void OnPositionOpened(Position position)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000844D File Offset: 0x0000744D
		protected virtual void OnPositionChanged(Position position)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000844F File Offset: 0x0000744F
		protected virtual void OnPositionClosed(Position position)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008451 File Offset: 0x00007451
		protected virtual void OnPortfolioValueChanged(Position position)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00008454 File Offset: 0x00007454
		private void portfolio_TransactionAdded(object sender, TransactionEventArgs args)
		{
			try
			{
				Transaction transaction = args.Transaction;
				if (this.statisticsPerInstrumentEnabled)
				{
					this.portfolios[transaction.Instrument].Add(transaction);
				}
				this.strategies[transaction.Strategy].SetTransactionAdded(transaction);
				this.OnTransactionAdded(transaction);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000084C4 File Offset: 0x000074C4
		private void portfolio_PositionOpened(object sender, PositionEventArgs args)
		{
			try
			{
				Position position = args.Position;
				this.metaMoneyManager.OnPositionOpened(position);
				this.OnPositionOpened(position);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00008508 File Offset: 0x00007508
		private void portfolio_PositionChanged(object sender, PositionEventArgs args)
		{
			try
			{
				Position position = args.Position;
				this.metaMoneyManager.OnPositionChanged(position);
				this.OnPositionChanged(position);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000854C File Offset: 0x0000754C
		private void portfolio_PositionClosed(object sender, PositionEventArgs args)
		{
			try
			{
				Position position = args.Position;
				this.metaMoneyManager.OnPositionClosed(position);
				this.OnPositionClosed(position);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00008590 File Offset: 0x00007590
		private void portfolio_ValueChanged(object sender, PositionEventArgs args)
		{
			try
			{
				Position position = args.Position;
				this.metaMoneyManager.OnPortfolioValueChanged(position.Portfolio);
				this.metaMoneyManager.OnPositionValueChanged(position);
				this.OnPortfolioValueChanged(position);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000085E4 File Offset: 0x000075E4
		protected virtual void OnNewBarOpen(Instrument instrument, Bar bar)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000085E6 File Offset: 0x000075E6
		protected virtual void OnNewBar(Instrument instrument, Bar bar)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000085E8 File Offset: 0x000075E8
		protected virtual void OnNewBarSlice(long barSize)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000085EA File Offset: 0x000075EA
		protected virtual void OnNewTrade(Instrument instrument, Trade trade)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000085EC File Offset: 0x000075EC
		protected virtual void OnNewQuote(Instrument instrument, Quote quote)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000085EE File Offset: 0x000075EE
		protected virtual void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000085F0 File Offset: 0x000075F0
		protected virtual void OnNewFundamental(Instrument instrument, Fundamental fundamental)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000085F2 File Offset: 0x000075F2
		protected virtual void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000085F4 File Offset: 0x000075F4
		internal void SetNewBarOpen(BarEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				Bar bar = args.Bar;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewBarOpen(instrument, bar);
				}
				this.metaMoneyManager.OnBarOpen(instrument, bar);
				this.OnNewBarOpen(instrument, bar);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00008690 File Offset: 0x00007690
		internal void SetNewBar(BarEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				Bar bar = args.Bar;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewBar(instrument, bar);
				}
				this.metaMoneyManager.OnBar(instrument, bar);
				this.OnNewBar(instrument, bar);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000872C File Offset: 0x0000772C
		internal void SetNewBarSlice(BarSliceEventArgs args)
		{
			try
			{
				long barSize = args.BarSize;
				foreach (object obj in this.strategies)
				{
					StrategyBase strategyBase = (StrategyBase)obj;
					if (strategyBase.IsEnabled)
					{
						strategyBase.SetNewBarSlice(barSize);
					}
				}
				this.OnNewBarSlice(barSize);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000087B8 File Offset: 0x000077B8
		internal void SetNewTrade(TradeEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				Trade trade = args.Trade;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewTrade(instrument, trade);
				}
				this.metaMoneyManager.OnTrade(instrument, trade);
				this.OnNewTrade(instrument, trade);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00008854 File Offset: 0x00007854
		internal void SetNewQuote(QuoteEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				Quote quote = args.Quote;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewQuote(instrument, quote);
				}
				this.metaMoneyManager.OnQuote(instrument, quote);
				this.OnNewQuote(instrument, quote);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000088F0 File Offset: 0x000078F0
		internal void SetNewMarketDepth(MarketDepthEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				MarketDepth marketDepth = args.MarketDepth;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewMarketDepth(instrument, marketDepth);
				}
				this.metaMoneyManager.OnMarketDepth(instrument, marketDepth);
				this.OnNewMarketDepth(instrument, marketDepth);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000898C File Offset: 0x0000798C
		internal void SetNewFundamental(FundamentalEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				Fundamental fundamental = args.Fundamental;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewFundamental(instrument, fundamental);
				}
				this.metaMoneyManager.OnFundamental(instrument, fundamental);
				this.OnNewFundamental(instrument, fundamental);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00008A28 File Offset: 0x00007A28
		internal void SetNewCorporateAction(CorporateActionEventArgs args)
		{
			try
			{
				Instrument instrument = args.Instrument as Instrument;
				CorporateAction corporateAction = args.CorporateAction;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(args.Provider, instrument))
				{
					strategyBase.SetNewCorporateAction(instrument, corporateAction);
				}
				this.metaMoneyManager.OnCorporateAction(instrument, corporateAction);
				this.OnNewCorporateAction(instrument, corporateAction);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008AC4 File Offset: 0x00007AC4
		private void RegisterStrategy(IMarketDataProvider provider, Instrument instrument, StrategyBase strategy)
		{
			Dictionary<Instrument, List<StrategyBase>> dictionary = null;
			if (!this.marketDataTable.TryGetValue(provider, out dictionary))
			{
				dictionary = new Dictionary<Instrument, List<StrategyBase>>();
				this.marketDataTable.Add(provider, dictionary);
			}
			List<StrategyBase> list = null;
			if (!dictionary.TryGetValue(instrument, out list))
			{
				list = new List<StrategyBase>();
				dictionary.Add(instrument, list);
			}
			if (!list.Contains(strategy))
			{
				list.Add(strategy);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008B24 File Offset: 0x00007B24
		private List<StrategyBase> GetAffectedStrategies(IMarketDataProvider provider, Instrument instrument)
		{
			Dictionary<Instrument, List<StrategyBase>> dictionary = null;
			List<StrategyBase> result = null;
			if (this.marketDataTable.TryGetValue(provider, out dictionary))
			{
				if (!dictionary.TryGetValue(instrument, out result))
				{
					result = new List<StrategyBase>();
				}
			}
			else
			{
				result = new List<StrategyBase>();
			}
			return result;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008B5F File Offset: 0x00007B5F
		protected virtual void OnNewOrder(SingleOrder order)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008B61 File Offset: 0x00007B61
		protected virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00008B63 File Offset: 0x00007B63
		protected virtual void OnOrderPartiallyFilled(SingleOrder order)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00008B65 File Offset: 0x00007B65
		protected virtual void OnOrderStatusChanged(SingleOrder order)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00008B67 File Offset: 0x00007B67
		protected virtual void OnOrderFilled(SingleOrder order)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00008B69 File Offset: 0x00007B69
		protected virtual void OnOrderCancelled(SingleOrder order)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00008B6B File Offset: 0x00007B6B
		protected virtual void OnOrderRejected(SingleOrder order)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00008B6D File Offset: 0x00007B6D
		protected virtual void OnOrderDone(SingleOrder order)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00008B70 File Offset: 0x00007B70
		internal void SetNewOrder(OrderEventArgs args)
		{
			try
			{
				SingleOrder order = args.Order;
				StrategyBase strategyBase = null;
				if (this.orders.TryGetValue(order, out strategyBase))
				{
					strategyBase.SetNewOrder(order);
					this.OnNewOrder(order);
				}
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00008BC0 File Offset: 0x00007BC0
		internal void SetExecutionReport(ExecutionReportEventArgs args)
		{
			try
			{
				ExecutionReport executionReport = args.ExecutionReport;
				OrdStatus ordStatus = executionReport.OrdStatus;
				switch (ordStatus)
				{
				case OrdStatus.Cancelled:
				case OrdStatus.PendingCancel:
					break;
				case OrdStatus.Replaced:
					goto IL_49;
				default:
					if (ordStatus != OrdStatus.PendingReplace)
					{
						goto IL_49;
					}
					break;
				}
				SingleOrder singleOrder = OrderManager.Orders.All[executionReport.OrigClOrdID] as SingleOrder;
				goto IL_64;
				IL_49:
				singleOrder = (OrderManager.Orders.All[executionReport.ClOrdID] as SingleOrder);
				IL_64:
				if (singleOrder != null)
				{
					StrategyBase strategyBase = null;
					if (this.orders.TryGetValue(singleOrder, out strategyBase))
					{
						strategyBase.SetExecutionReport(singleOrder, executionReport);
						this.OnExecutionReport(singleOrder, executionReport);
						if (singleOrder.OrdStatus == OrdStatus.PartiallyFilled)
						{
							strategyBase.SetOrderPartiallyFilled(singleOrder);
							this.OnOrderPartiallyFilled(singleOrder);
						}
					}
				}
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00008C8C File Offset: 0x00007C8C
		internal void SetOrderStatusChanged(OrderEventArgs args)
		{
			try
			{
				SingleOrder order = args.Order;
				StrategyBase strategyBase = null;
				if (this.orders.TryGetValue(order, out strategyBase))
				{
					strategyBase.SetOrderStatusChanged(order);
					this.OnOrderStatusChanged(order);
				}
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00008CDC File Offset: 0x00007CDC
		internal void SetOrderDone(OrderEventArgs args)
		{
			try
			{
				SingleOrder order = args.Order;
				StrategyBase strategyBase = null;
				if (this.orders.TryGetValue(order, out strategyBase))
				{
					strategyBase.SetOrderDone(order);
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
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00008D68 File Offset: 0x00007D68
		protected virtual void OnProviderConnected(IProvider provider)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00008D6A File Offset: 0x00007D6A
		protected virtual void OnProviderDisconnected(IProvider provider)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00008D6C File Offset: 0x00007D6C
		protected virtual void OnProviderError(IProvider provider, int id, int code, string message)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00008D70 File Offset: 0x00007D70
		internal void SetProviderConnected(ProviderEventArgs args)
		{
			try
			{
				IProvider provider = args.Provider;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(provider))
				{
					strategyBase.SetProviderConnected(provider);
				}
				this.metaMoneyManager.OnProviderConnected(provider);
				this.OnProviderConnected(provider);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00008DF8 File Offset: 0x00007DF8
		internal void SetProviderDisconnected(ProviderEventArgs args)
		{
			try
			{
				IProvider provider = args.Provider;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(provider))
				{
					strategyBase.SetProviderDisconnected(provider);
				}
				this.metaMoneyManager.OnProviderDisconnected(provider);
				this.OnProviderDisconnected(provider);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00008E80 File Offset: 0x00007E80
		internal void SetProviderError(ProviderErrorEventArgs args)
		{
			try
			{
				IProvider provider = args.Error.Provider;
				int id = args.Error.Id;
				int code = args.Error.Code;
				string message = args.Error.Message;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(provider))
				{
					strategyBase.SetProviderError(provider, id, code, message);
				}
				this.metaMoneyManager.OnProviderError(provider, id, code, message);
				this.OnProviderError(provider, id, code, message);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00008F40 File Offset: 0x00007F40
		private void RegisterStrategy(IProvider provider, StrategyBase strategy)
		{
			List<StrategyBase> list = null;
			if (!this.providerDispatcherTable.TryGetValue(provider, out list))
			{
				list = new List<StrategyBase>();
				this.providerDispatcherTable.Add(provider, list);
			}
			if (!list.Contains(strategy))
			{
				list.Add(strategy);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00008F82 File Offset: 0x00007F82
		private List<StrategyBase> GetAffectedStrategies(IProvider provider)
		{
			return this.providerDispatcherTable[provider];
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00008F90 File Offset: 0x00007F90
		protected virtual void OnServiceStatusChanged(IService service)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00008F92 File Offset: 0x00007F92
		protected virtual void OnServiceError(IService service, ServiceErrorType errorType, string text)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00008F94 File Offset: 0x00007F94
		internal void SetServiceStatusChanged(ServiceEventArgs args)
		{
			try
			{
				IService service = args.Service;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(service))
				{
					strategyBase.SetServiceStatusChanged(service);
				}
				this.OnServiceStatusChanged(service);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00009010 File Offset: 0x00008010
		internal void SetServiceError(ServiceErrorEventArgs args)
		{
			try
			{
				IService service = args.Error.Service;
				ServiceErrorType errorType = args.Error.ErrorType;
				string text = args.Error.Text;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(service))
				{
					strategyBase.SetServiceError(service, errorType, text);
				}
				this.OnServiceError(service, errorType, text);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000090B0 File Offset: 0x000080B0
		private void RegisterStrategy(IService service, StrategyBase strategy)
		{
			List<StrategyBase> list;
			if (!this.serviceDispatcherTable.TryGetValue(service, out list))
			{
				list = new List<StrategyBase>();
				this.serviceDispatcherTable.Add(service, list);
			}
			if (!list.Contains(strategy))
			{
				list.Add(strategy);
			}
			this.serviceDispatcher.Add(service);
			if (service is IExecutionService)
			{
				IExecutionService executionService = service as IExecutionService;
				if (!this.executionServiceDispatcherTable.TryGetValue(executionService, out list))
				{
					list = new List<StrategyBase>();
					this.executionServiceDispatcherTable.Add(executionService, list);
				}
				if (!list.Contains(strategy))
				{
					list.Add(strategy);
				}
				this.executionServiceDispatcher.Add(executionService);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000914A File Offset: 0x0000814A
		private List<StrategyBase> GetAffectedStrategies(IService service)
		{
			return this.serviceDispatcherTable[service];
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009158 File Offset: 0x00008158
		protected virtual void OnNewClientOrder(SingleOrder order)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000915C File Offset: 0x0000815C
		internal void SetNewClientOrder(NewOrderSingleEventArgs args)
		{
			try
			{
				SingleOrder singleOrder = args.Order as SingleOrder;
				singleOrder.StrategyMode = MetaStrategyBase.FIX_MODES[this.metaStrategyMode];
				IExecutionService service = args.Service;
				foreach (StrategyBase strategyBase in this.GetAffectedStrategies(service))
				{
					strategyBase.SetNewClientOrder(singleOrder);
				}
				this.OnNewClientOrder(singleOrder);
			}
			catch (Exception exception)
			{
				this.EmitError(exception);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000091FC File Offset: 0x000081FC
		private List<StrategyBase> GetAffectedStrategies(IExecutionService service)
		{
			return this.executionServiceDispatcherTable[service];
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000920C File Offset: 0x0000820C
		internal void RegisterOrder(StrategyBase strategy, SingleOrder order)
		{
			order.Portfolio = this.portfolio;
			switch (this.metaStrategyMode)
			{
			case MetaStrategyMode.Simulation:
				order.Provider = ProviderManager.ExecutionSimulator;
				break;
			case MetaStrategyMode.Live:
				order.Provider = strategy.MarketManager.ExecutionProviderTable[order.Instrument];
				if (this.saveOrders)
				{
					order.Persistent = true;
				}
				break;
			}
			order.StrategyMode = MetaStrategyBase.FIX_MODES[this.metaStrategyMode];
			this.orders.Add(order, strategy);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009298 File Offset: 0x00008298
		internal void SendExecutionReport(StrategyBase strategy, ExecutionReport report)
		{
			IExecutionService service = null;
			switch (this.metaStrategyMode)
			{
			case MetaStrategyMode.Simulation:
				service = ServiceManager.ExecutionSimulator;
				break;
			case MetaStrategyMode.Live:
				service = strategy.ExecutionService;
				break;
			}
			OrderManager.SellSide.SendExecutionReport(service, report);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000092D9 File Offset: 0x000082D9
		private void optimizer_BestObjectiveReceived(object sender, EventArgs e)
		{
			this.RestoreTester();
			this.isOptimizing = false;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000092E8 File Offset: 0x000082E8
		public virtual ArrayList GetOptimizationParameters()
		{
			this.optimizationParemeters.Clear();
			int num = 0;
			foreach (ComponentType componentType in this.componentTypeList)
			{
				IComponentBase component = this.GetComponent(componentType);
				string str = componentType + ".";
				foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
				{
					foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
					{
						if (attribute.GetType() == typeof(OptimizationParameterAttribute))
						{
							this.optimizationParemeters.Add(str + propertyInfo.Name);
							num++;
						}
					}
				}
			}
			foreach (object obj in this.strategies)
			{
				StrategyBase strategyBase = (StrategyBase)obj;
				if (strategyBase.IsEnabled)
				{
					foreach (ComponentType componentType2 in strategyBase.ComponentTypeList)
					{
						IComponentBase component = strategyBase.GetComponent(componentType2);
						string str2 = componentType2 + ".";
						foreach (PropertyInfo propertyInfo2 in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
						{
							foreach (Attribute attribute2 in propertyInfo2.GetCustomAttributes(false))
							{
								if (attribute2.GetType() == typeof(OptimizationParameterAttribute))
								{
									this.optimizationParemeters.Add(str2 + propertyInfo2.Name);
									num++;
								}
							}
						}
					}
				}
			}
			return this.optimizationParemeters;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009554 File Offset: 0x00008554
		public double Objective()
		{
			this.Start(false);
			return -this.optimizationManager.Objective();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000956C File Offset: 0x0000856C
		public virtual void Init(ParamSet paramSet)
		{
			int num = 0;
			foreach (ComponentType componentType in this.componentTypeList)
			{
				IComponentBase component = this.GetComponent(componentType);
				string str = componentType + ".";
				foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
				{
					if (this.optimizationParemeters.Contains(str + propertyInfo.Name))
					{
						foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
						{
							if (attribute.GetType() == typeof(OptimizationParameterAttribute))
							{
								OptimizationParameterAttribute optimizationParameterAttribute = attribute as OptimizationParameterAttribute;
								paramSet.SetParamName(num, str + propertyInfo.Name);
								paramSet.SetParam(num, optimizationParameterAttribute.LowerBound + (optimizationParameterAttribute.UpperBound - optimizationParameterAttribute.LowerBound) / 2.0);
								paramSet.SetLowerBound(num, optimizationParameterAttribute.LowerBound);
								paramSet.SetUpperBound(num, optimizationParameterAttribute.UpperBound);
								paramSet.SetSteps(num, optimizationParameterAttribute.Step);
								if (propertyInfo.PropertyType == typeof(int))
								{
									paramSet.SetParamType(num, EParamType.Int);
								}
								else
								{
									paramSet.SetParamType(num, EParamType.Float);
								}
								num++;
							}
						}
					}
				}
			}
			foreach (object obj in this.strategies)
			{
				StrategyBase strategyBase = (StrategyBase)obj;
				if (strategyBase.IsEnabled)
				{
					foreach (ComponentType componentType2 in strategyBase.ComponentTypeList)
					{
						IComponentBase component = strategyBase.GetComponent(componentType2);
						string str2 = componentType2 + ".";
						foreach (PropertyInfo propertyInfo2 in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
						{
							if (this.optimizationParemeters.Contains(str2 + propertyInfo2.Name))
							{
								foreach (Attribute attribute2 in propertyInfo2.GetCustomAttributes(false))
								{
									if (attribute2.GetType() == typeof(OptimizationParameterAttribute))
									{
										OptimizationParameterAttribute optimizationParameterAttribute2 = attribute2 as OptimizationParameterAttribute;
										paramSet.SetParamName(num, str2 + propertyInfo2.Name);
										paramSet.SetParam(num, optimizationParameterAttribute2.LowerBound + (optimizationParameterAttribute2.UpperBound - optimizationParameterAttribute2.LowerBound) / 2.0);
										paramSet.SetLowerBound(num, optimizationParameterAttribute2.LowerBound);
										paramSet.SetUpperBound(num, optimizationParameterAttribute2.UpperBound);
										paramSet.SetSteps(num, optimizationParameterAttribute2.Step);
										if (propertyInfo2.PropertyType == typeof(int))
										{
											paramSet.SetParamType(num, EParamType.Int);
										}
										else
										{
											paramSet.SetParamType(num, EParamType.Float);
										}
										num++;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00009914 File Offset: 0x00008914
		public virtual void Update(ParamSet paramSet)
		{
			int num = 0;
			foreach (ComponentType componentType in this.componentTypeList)
			{
				IComponentBase component = this.GetComponent(componentType);
				string str = componentType + ".";
				foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
				{
					if (this.optimizationParemeters.Contains(str + propertyInfo.Name))
					{
						foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
						{
							if (attribute.GetType() == typeof(OptimizationParameterAttribute))
							{
								if (propertyInfo.PropertyType == typeof(int))
								{
									propertyInfo.SetValue(component, (int)paramSet.GetParam(num), null);
								}
								if (propertyInfo.PropertyType == typeof(double))
								{
									propertyInfo.SetValue(component, paramSet.GetParam(num), null);
								}
								num++;
							}
						}
					}
				}
			}
			foreach (object obj in this.strategies)
			{
				StrategyBase strategyBase = (StrategyBase)obj;
				if (strategyBase.IsEnabled)
				{
					foreach (ComponentType componentType2 in strategyBase.ComponentTypeList)
					{
						IComponentBase component = strategyBase.GetComponent(componentType2);
						string str2 = componentType2 + ".";
						foreach (PropertyInfo propertyInfo2 in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
						{
							if (this.optimizationParemeters.Contains(str2 + propertyInfo2.Name))
							{
								foreach (Attribute attribute2 in propertyInfo2.GetCustomAttributes(false))
								{
									if (attribute2.GetType() == typeof(OptimizationParameterAttribute))
									{
										if (propertyInfo2.PropertyType == typeof(int))
										{
											propertyInfo2.SetValue(component, (int)paramSet.GetParam(num), null);
										}
										if (propertyInfo2.PropertyType == typeof(double))
										{
											propertyInfo2.SetValue(component, paramSet.GetParam(num), null);
										}
										num++;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00009C2C File Offset: 0x00008C2C
		public void OnStep()
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00009C2E File Offset: 0x00008C2E
		public void OnCircle()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00009C30 File Offset: 0x00008C30
		public virtual IComponentBase GetComponent(ComponentType type)
		{
			if (type <= ComponentType.SimulationManager)
			{
				if (type == ComponentType.OptimizationManager)
				{
					return this.OptimizationManager;
				}
				if (type == ComponentType.SimulationManager)
				{
					return this.SimulationManager;
				}
			}
			else
			{
				if (type == ComponentType.MetaMoneyManager)
				{
					return this.MetaMoneyManager;
				}
				if (type == ComponentType.ReportManager)
				{
					return this.ReportManager;
				}
			}
			throw new InvalidOperationException("Invalid metastrategy component type");
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00009C94 File Offset: 0x00008C94
		public virtual void SetComponent(ComponentType type, IComponentBase component)
		{
			if (type <= ComponentType.SimulationManager)
			{
				if (type == ComponentType.OptimizationManager)
				{
					this.OptimizationManager = (component as OptimizationManager);
					return;
				}
				if (type == ComponentType.SimulationManager)
				{
					this.SimulationManager = (component as SimulationManager);
					return;
				}
			}
			else
			{
				if (type == ComponentType.MetaMoneyManager)
				{
					this.MetaMoneyManager = (component as MetaMoneyManager);
					return;
				}
				if (type == ComponentType.ReportManager)
				{
					this.ReportManager = (component as ReportManager);
					return;
				}
			}
			throw new InvalidOperationException("Invalid metastrategy component type");
		}

		// Token: 0x0400009A RID: 154
		protected const string CATEGORY_NAMING = "Naming";

		// Token: 0x0400009B RID: 155
		protected const string CATEGORY_COMPONENTS = "Components";

		// Token: 0x0400009C RID: 156
		protected const string CATEGORY_PORTFOLIO = "Portfolio";

		// Token: 0x0400009D RID: 157
		protected const string CATEGORY_DATA_PERSISTENT = "Data Persistent";

		// Token: 0x0400009E RID: 158
		public static readonly MetaStrategyBase.FIXModes FIX_MODES = new MetaStrategyBase.FIXModes();

		// Token: 0x0400009F RID: 159
		protected string name;

		// Token: 0x040000A0 RID: 160
		protected MetaStrategyMode metaStrategyMode;

		// Token: 0x040000A1 RID: 161
		protected SimulationManager simulationManager;

		// Token: 0x040000A2 RID: 162
		protected ReportManager reportManager;

		// Token: 0x040000A3 RID: 163
		protected OptimizationManager optimizationManager;

		// Token: 0x040000A4 RID: 164
		protected MetaMoneyManager metaMoneyManager;

		// Token: 0x040000A5 RID: 165
		protected StrategyList strategies;

		// Token: 0x040000A6 RID: 166
		protected Portfolio portfolio;

		// Token: 0x040000A7 RID: 167
		protected LiveTester tester;

		// Token: 0x040000A8 RID: 168
		protected Optimizer optimizer;

		// Token: 0x040000A9 RID: 169
		protected EOptimizerType optimizerType;

		// Token: 0x040000AA RID: 170
		protected Simulator simulator;

		// Token: 0x040000AB RID: 171
		protected bool isRunning;

		// Token: 0x040000AC RID: 172
		protected bool isOptimizing;

		// Token: 0x040000AD RID: 173
		protected ArrayList optimizationParemeters;

		// Token: 0x040000AE RID: 174
		protected Hashtable drawingPrimitives;

		// Token: 0x040000AF RID: 175
		protected StopList portfolioStopList;

		// Token: 0x040000B0 RID: 176
		protected List<ComponentType> componentTypeList;

		// Token: 0x040000B1 RID: 177
		protected bool resetPortfolio;

		// Token: 0x040000B2 RID: 178
		protected bool saveOrders;

		// Token: 0x040000B3 RID: 179
		protected Dictionary<Instrument, Portfolio> portfolios;

		// Token: 0x040000B4 RID: 180
		protected Dictionary<Instrument, LiveTester> testers;

		// Token: 0x040000B5 RID: 181
		protected bool statisticsPerInstrumentEnabled;

		// Token: 0x040000B6 RID: 182
		protected bool executionServicesEnabled;

		// Token: 0x040000B7 RID: 183
		private ProviderDispatcher providerDispatcher;

		// Token: 0x040000B8 RID: 184
		private MarketDataDispatcher marketDataDispatcher;

		// Token: 0x040000B9 RID: 185
		private OrderProcessor orderProcessor;

		// Token: 0x040000BA RID: 186
		private ServiceDispatcher serviceDispatcher;

		// Token: 0x040000BB RID: 187
		private ExecutionServiceDispatcher executionServiceDispatcher;

		// Token: 0x040000BC RID: 188
		private Dictionary<IProvider, List<StrategyBase>> providerDispatcherTable;

		// Token: 0x040000BD RID: 189
		private Dictionary<IMarketDataProvider, Dictionary<Instrument, List<StrategyBase>>> marketDataTable;

		// Token: 0x040000BE RID: 190
		private Dictionary<SingleOrder, StrategyBase> orders;

		// Token: 0x040000BF RID: 191
		private Dictionary<IService, List<StrategyBase>> serviceDispatcherTable;

		// Token: 0x040000C0 RID: 192
		private Dictionary<IExecutionService, List<StrategyBase>> executionServiceDispatcherTable;

		// Token: 0x040000C1 RID: 193
		private int maxConnectionTime;

		// Token: 0x02000030 RID: 48
		public class FIXModes
		{
			// Token: 0x0600026F RID: 623 RVA: 0x00009D1C File Offset: 0x00008D1C
			internal FIXModes()
			{
				this.modes = new Hashtable();
				this.modes.Add(MetaStrategyMode.Simulation, 'S');
				this.modes.Add(MetaStrategyMode.Live, 'L');
			}

			// Token: 0x1700008C RID: 140
			public char this[MetaStrategyMode mode]
			{
				get
				{
					return (char)this.modes[mode];
				}
			}

			// Token: 0x040000C9 RID: 201
			private Hashtable modes;
		}
	}
}
