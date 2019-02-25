using System;
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
	// Token: 0x02000080 RID: 128
	public class MetaStrategy : MetaStrategyBase
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060005C0 RID: 1472 RVA: 0x00012C4C File Offset: 0x00011C4C
		// (remove) Token: 0x060005C1 RID: 1473 RVA: 0x00012C65 File Offset: 0x00011C65
		public event SignalEventHandler SignalAdded;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060005C2 RID: 1474 RVA: 0x00012C7E File Offset: 0x00011C7E
		// (remove) Token: 0x060005C3 RID: 1475 RVA: 0x00012C97 File Offset: 0x00011C97
		public event EventHandler SignalListCleared;

		// Token: 0x060005C4 RID: 1476 RVA: 0x00012CB0 File Offset: 0x00011CB0
		public MetaStrategy(string name) : base(name)
		{
			this.MetaExposureManager = (StrategyComponentManager.GetComponent("{2DBD0B38-8399-4d0b-9FAA-7C29FC1462BC}", this) as MetaExposureManager);
			this.ExecutionManager = (StrategyComponentManager.GetComponent("{D106D35A-E1E4-4e86-8869-846289E98232}", this) as ExecutionManager);
			this.MetaRiskManager = (StrategyComponentManager.GetComponent("{521B9C4F-01AE-4488-B4A5-104027D06BB8}", this) as MetaRiskManager);
			this.signals = new SignalList();
			this.componentTypeList.Add(ComponentType.MetaRiskManager);
			this.componentTypeList.Add(ComponentType.MetaExposureManager);
			this.componentTypeList.Add(ComponentType.ExecutionManager);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00012D41 File Offset: 0x00011D41
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00012D4C File Offset: 0x00011D4C
		[Editor(typeof(MetaExposureManagerTypeEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Category("Components")]
		public MetaExposureManager MetaExposureManager
		{
			get
			{
				return this.metaExposureManager;
			}
			set
			{
				if (!base.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.metaExposureManager != null)
				{
					this.metaExposureManager.Disconnect();
					this.metaExposureManager.MetaStrategyBase = null;
				}
				this.metaExposureManager = value;
				if (this.metaExposureManager != null)
				{
					this.metaExposureManager.MetaStrategyBase = this;
					this.metaExposureManager.Connect();
				}
				base.EmitComponentChanged(ComponentType.MetaExposureManager);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00012DBC File Offset: 0x00011DBC
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00012DC4 File Offset: 0x00011DC4
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Editor(typeof(MetaRiskManagerTypeEditor), typeof(UITypeEditor))]
		[Category("Components")]
		public MetaRiskManager MetaRiskManager
		{
			get
			{
				return this.metaRiskManager;
			}
			set
			{
				if (!base.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.metaRiskManager != null)
				{
					this.metaRiskManager.Disconnect();
					this.metaRiskManager.MetaStrategyBase = null;
				}
				this.metaRiskManager = value;
				if (this.metaRiskManager != null)
				{
					this.metaRiskManager.MetaStrategyBase = this;
					this.metaRiskManager.Connect();
				}
				base.EmitComponentChanged(ComponentType.MetaRiskManager);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00012E34 File Offset: 0x00011E34
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00012E3C File Offset: 0x00011E3C
		[TypeConverter(typeof(ComponentTypeConverter))]
		[Category("Components")]
		[Editor(typeof(ExecutionManagerTypeEditor), typeof(UITypeEditor))]
		public ExecutionManager ExecutionManager
		{
			get
			{
				return this.executionManager;
			}
			set
			{
				if (!base.DesignMode)
				{
					throw new InvalidOperationException("MetaStrategy is not in design mode");
				}
				if (this.executionManager != null)
				{
					this.executionManager.Disconnect();
					this.executionManager.MetaStrategyBase = null;
				}
				this.executionManager = value;
				if (this.executionManager != null)
				{
					this.executionManager.MetaStrategyBase = this;
					this.executionManager.Connect();
				}
				base.EmitComponentChanged(ComponentType.ExecutionManager);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00012EAC File Offset: 0x00011EAC
		[Browsable(false)]
		public SignalList Signals
		{
			get
			{
				return this.signals;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00012EB4 File Offset: 0x00011EB4
		protected override void OnInit()
		{
			this.signals.Clear();
			if (this.SignalListCleared != null)
			{
				this.SignalListCleared(this, EventArgs.Empty);
			}
			this.executionManager.Init();
			this.optimizationManager.Init();
			this.metaExposureManager.Init();
			this.metaRiskManager.Init();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00012F11 File Offset: 0x00011F11
		protected override void OnMetaStrategyStop()
		{
			this.metaExposureManager.OnStrategyStop();
			this.metaRiskManager.OnStrategyStop();
			this.executionManager.OnStrategyStop();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00012F34 File Offset: 0x00011F34
		internal SingleOrder EmitSignal(Signal signal)
		{
			bool flag = false;
			if (signal.Status == SignalStatus.New)
			{
				if (this.metaExposureManager.Validate(signal))
				{
					signal.Status = SignalStatus.Accepted;
					flag = true;
				}
				else
				{
					signal.Status = SignalStatus.Rejected;
					signal.Rejecter = ComponentType.MetaExposureManager;
				}
			}
			this.signals.Add(signal);
			if (this.SignalAdded != null)
			{
				this.SignalAdded(new SignalEventArgs(signal));
			}
			if (flag)
			{
				return this.executionManager.Execute(signal);
			}
			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00012FAC File Offset: 0x00011FAC
		protected override void OnPositionOpened(Position position)
		{
			this.metaRiskManager.OnPositionOpened(position);
			this.metaExposureManager.OnPositionOpened(position);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00012FC6 File Offset: 0x00011FC6
		protected override void OnPositionChanged(Position position)
		{
			this.metaRiskManager.OnPositionChanged(position);
			this.metaExposureManager.OnPositionChanged(position);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00012FE0 File Offset: 0x00011FE0
		protected override void OnPositionClosed(Position position)
		{
			this.metaRiskManager.OnPositionClosed(position);
			this.metaExposureManager.OnPositionClosed(position);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00012FFA File Offset: 0x00011FFA
		protected override void OnPortfolioValueChanged(Position position)
		{
			this.metaRiskManager.OnPortfolioValueChanged(this.portfolio);
			this.metaExposureManager.OnPortfolioValueChanged(this.portfolio);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001301E File Offset: 0x0001201E
		protected override void OnNewBarOpen(Instrument instrument, Bar bar)
		{
			this.metaRiskManager.OnBarOpen(instrument, bar);
			this.metaExposureManager.OnBarOpen(instrument, bar);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0001303A File Offset: 0x0001203A
		protected override void OnNewBar(Instrument instrument, Bar bar)
		{
			this.metaRiskManager.OnBar(instrument, bar);
			this.metaExposureManager.OnBar(instrument, bar);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00013056 File Offset: 0x00012056
		protected override void OnNewTrade(Instrument instrument, Trade trade)
		{
			this.metaRiskManager.OnTrade(instrument, trade);
			this.metaExposureManager.OnTrade(instrument, trade);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00013072 File Offset: 0x00012072
		protected override void OnNewQuote(Instrument instrument, Quote quote)
		{
			this.metaRiskManager.OnQuote(instrument, quote);
			this.metaExposureManager.OnQuote(instrument, quote);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001308E File Offset: 0x0001208E
		protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
			this.metaRiskManager.OnMarketDepth(instrument, marketDepth);
			this.metaExposureManager.OnMarketDepth(instrument, marketDepth);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000130AA File Offset: 0x000120AA
		protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
		{
			this.metaRiskManager.OnFundamental(instrument, fundamental);
			this.metaExposureManager.OnFundamental(instrument, fundamental);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000130C6 File Offset: 0x000120C6
		protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
			this.metaRiskManager.OnCorporateAction(instrument, corporateAction);
			this.metaExposureManager.OnCorporateAction(instrument, corporateAction);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000130E2 File Offset: 0x000120E2
		protected override void OnNewOrder(SingleOrder order)
		{
			this.executionManager.OnNewOrder(order);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000130F0 File Offset: 0x000120F0
		protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
			this.executionManager.OnExecutionReport(order, report);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000130FF File Offset: 0x000120FF
		protected override void OnOrderPartiallyFilled(SingleOrder order)
		{
			this.executionManager.OnOrderPartiallyFilled(order);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001310D File Offset: 0x0001210D
		protected override void OnOrderStatusChanged(SingleOrder order)
		{
			this.executionManager.OnOrderStatusChanged(order);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001311B File Offset: 0x0001211B
		protected override void OnOrderFilled(SingleOrder order)
		{
			this.executionManager.OnOrderFilled(order);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00013129 File Offset: 0x00012129
		protected override void OnOrderCancelled(SingleOrder order)
		{
			this.executionManager.OnOrderCancelled(order);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00013137 File Offset: 0x00012137
		protected override void OnOrderRejected(SingleOrder order)
		{
			this.executionManager.OnOrderRejected(order);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00013145 File Offset: 0x00012145
		protected override void OnOrderDone(SingleOrder order)
		{
			this.executionManager.OnOrderDone(order);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00013153 File Offset: 0x00012153
		protected override void OnProviderConnected(IProvider provider)
		{
			this.metaRiskManager.OnProviderConnected(provider);
			this.metaExposureManager.OnProviderConnected(provider);
			this.executionManager.OnProviderConnected(provider);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00013179 File Offset: 0x00012179
		protected override void OnProviderDisconnected(IProvider provider)
		{
			this.metaRiskManager.OnProviderDisconnected(provider);
			this.metaExposureManager.OnProviderDisconnected(provider);
			this.executionManager.OnProviderDisconnected(provider);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001319F File Offset: 0x0001219F
		protected override void OnProviderError(IProvider provider, int id, int code, string message)
		{
			this.metaRiskManager.OnProviderError(provider, id, code, message);
			this.metaExposureManager.OnProviderError(provider, id, code, message);
			this.executionManager.OnProviderError(provider, id, code, message);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000131D4 File Offset: 0x000121D4
		public override IComponentBase GetComponent(ComponentType type)
		{
			if (type == ComponentType.MetaExposureManager)
			{
				return this.MetaExposureManager;
			}
			if (type == ComponentType.ExecutionManager)
			{
				return this.ExecutionManager;
			}
			if (type != ComponentType.MetaRiskManager)
			{
				return base.GetComponent(type);
			}
			return this.MetaRiskManager;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001321C File Offset: 0x0001221C
		public override void SetComponent(ComponentType type, IComponentBase component)
		{
			if (type == ComponentType.MetaExposureManager)
			{
				this.MetaExposureManager = (component as MetaExposureManager);
				return;
			}
			if (type == ComponentType.ExecutionManager)
			{
				this.ExecutionManager = (component as ExecutionManager);
				return;
			}
			if (type != ComponentType.MetaRiskManager)
			{
				base.SetComponent(type, component);
				return;
			}
			this.MetaRiskManager = (component as MetaRiskManager);
		}

		// Token: 0x04000190 RID: 400
		private MetaExposureManager metaExposureManager;

		// Token: 0x04000191 RID: 401
		private MetaRiskManager metaRiskManager;

		// Token: 0x04000192 RID: 402
		private ExecutionManager executionManager;

		// Token: 0x04000193 RID: 403
		private SignalList signals;
	}
}
