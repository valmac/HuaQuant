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
    // Token: 0x02000048 RID: 72
    public class ATSStrategy : StrategyBase
    {
        // Token: 0x060002E8 RID: 744 RVA: 0x0000BB0C File Offset: 0x0000AB0C
        public ATSStrategy(string name, string description) : base(name, description)
        {
            this.ATSCrossComponent = (StrategyComponentManager.GetComponent("{E70A6417-E7FA-4ec1-BC16-B03DE53C6E85}", this) as ATSCrossComponent);
            this.ATSComponent = (StrategyComponentManager.GetComponent("{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}", this) as ATSComponent);
            this.atsComponents = new Dictionary<Instrument, ATSComponent>();
            this.componentTypeList.Add(ComponentType.ATSComponent);
            this.componentTypeList.Add(ComponentType.ATSCrossComponent);
        }

        // Token: 0x17000098 RID: 152
        // (get) Token: 0x060002E9 RID: 745 RVA: 0x0000BB78 File Offset: 0x0000AB78
        [Browsable(false)]
        public ATSMetaStrategy ATSMetaStrategy
        {
            get
            {
                return base.MetaStrategyBase as ATSMetaStrategy;
            }
        }

        // Token: 0x17000099 RID: 153
        // (get) Token: 0x060002EA RID: 746 RVA: 0x0000BB85 File Offset: 0x0000AB85
        // (set) Token: 0x060002EB RID: 747 RVA: 0x0000BB90 File Offset: 0x0000AB90
        [TypeConverter(typeof(ComponentTypeConverter))]
        [Editor(typeof(ATSComponentTypeEditor), typeof(UITypeEditor))]
        [Category("Components")]
        public ATSComponent ATSComponent
        {
            get
            {
                return this.atsComponent;
            }
            set
            {
                if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
                {
                    throw new InvalidOperationException("MetaStrategy is not in design mode");
                }
                if (this.atsComponent != null)
                {
                    this.atsComponent.Disconnect();
                    this.atsComponent.StrategyBase = null;
                }
                this.atsComponent = value;
                if (this.atsComponent != null)
                {
                    this.atsComponent.StrategyBase = this;
                    this.atsComponent.Connect();
                }
                base.EmitComponentChanged(ComponentType.ATSComponent);
            }
        }

        // Token: 0x1700009A RID: 154
        // (get) Token: 0x060002EC RID: 748 RVA: 0x0000BC1A File Offset: 0x0000AC1A
        // (set) Token: 0x060002ED RID: 749 RVA: 0x0000BC40 File Offset: 0x0000AC40
        [TypeConverter(typeof(ComponentTypeConverter))]
        [Category("Components")]
        [Editor(typeof(ATSCrossComponentTypeEditor), typeof(UITypeEditor))]
        public ATSCrossComponent ATSCrossComponent
        {
            get
            {
                if (this.metaStrategyBase == null || !this.metaStrategyBase.IsRunning)
                {
                    return this.atsCrossComponent;
                }
                return this.atsRuntimeCrossComponent;
            }
            set
            {
                if (this.metaStrategyBase != null && (this.metaStrategyBase.IsRunning || !this.metaStrategyBase.DesignMode))
                {
                    throw new InvalidOperationException("MetaStrategy is not in design mode");
                }
                if (this.atsCrossComponent != null)
                {
                    this.atsCrossComponent.Disconnect();
                    this.atsCrossComponent.StrategyBase = null;
                }
                this.atsCrossComponent = value;
                if (this.atsCrossComponent != null)
                {
                    this.atsCrossComponent.StrategyBase = this;
                    this.atsCrossComponent.Connect();
                }
                base.EmitComponentChanged(ComponentType.ATSCrossComponent);
            }
        }

        // Token: 0x060002EE RID: 750 RVA: 0x0000BCCC File Offset: 0x0000ACCC
        protected override void OnInit()
        {
            this.atsComponents.Clear();
            this.atsRuntimeCrossComponent = (Activator.CreateInstance(this.atsCrossComponent.GetType()) as ATSCrossComponent);
            this.atsRuntimeCrossComponent.StrategyBase = this;
            base.SetProxyProperties(this.atsRuntimeCrossComponent, this.atsCrossComponent);
            this.atsRuntimeCrossComponent.Init();
            foreach (object obj in this.marketManager.Instruments)
            {
                Instrument instrument = (Instrument)obj;
                this.activeInstruments.Add(instrument);
                ATSComponent atscomponent = Activator.CreateInstance(this.atsComponent.GetType()) as ATSComponent;
                atscomponent.StrategyBase = this;
                atscomponent.Instrument = instrument;
                base.SetProxyProperties(atscomponent, this.atsComponent);
                atscomponent.Init();
                this.atsComponents.Add(instrument, atscomponent);
            }
        }

        // Token: 0x060002EF RID: 751 RVA: 0x0000BDC4 File Offset: 0x0000ADC4
        protected override void OnStrategyStop()
        {
            this.atsRuntimeCrossComponent.OnStrategyStop();
            foreach (ATSComponent atscomponent in this.atsComponents.Values)
            {
                atscomponent.OnStrategyStop();
            }
        }

        // Token: 0x060002F0 RID: 752 RVA: 0x0000BE28 File Offset: 0x0000AE28
        internal void AddStop(ATSStop stop)
        {
            this.stops.Add(stop);
            this.activeStops[stop.Instrument].Add(stop);
            stop.StatusChanged += this.stop_StatusChanged;
            base.EmitStopAdded(stop);
        }

        // Token: 0x060002F1 RID: 753 RVA: 0x0000BE68 File Offset: 0x0000AE68
        private void stop_StatusChanged(StopEventArgs args)
        {
            ATSStop atsstop = args.Stop as ATSStop;
            if (atsstop.Status != StopStatus.Active)
            {
                this.activeStops[atsstop.Instrument].Remove(atsstop);
            }
            this.OnStopStatusChanged(atsstop);
            if (atsstop.Status == StopStatus.Executed)
            {
                this.OnStopExecuted(atsstop);
            }
            if (atsstop.Status == StopStatus.Canceled)
            {
                this.OnStopCanceled(atsstop);
            }
            base.EmitStopStatusChanged(atsstop);
        }

        // Token: 0x060002F2 RID: 754 RVA: 0x0000BECF File Offset: 0x0000AECF
        internal void OnStopStatusChanged(ATSStop stop)
        {
            this.atsRuntimeCrossComponent.OnStopStatusChanged(stop);
            this.atsComponents[stop.Instrument].OnStopStatusChanged(stop);
        }

        // Token: 0x060002F3 RID: 755 RVA: 0x0000BEF4 File Offset: 0x0000AEF4
        internal void OnStopCanceled(ATSStop stop)
        {
            this.atsRuntimeCrossComponent.OnStopCanceled(stop);
            this.atsComponents[stop.Instrument].OnStopCanceled(stop);
        }

        // Token: 0x060002F4 RID: 756 RVA: 0x0000BF19 File Offset: 0x0000AF19
        internal void OnStopExecuted(ATSStop stop)
        {
            this.atsRuntimeCrossComponent.OnStopExecuted(stop);
            this.atsComponents[stop.Instrument].OnStopExecuted(stop);
        }

        // Token: 0x060002F5 RID: 757 RVA: 0x0000BF40 File Offset: 0x0000AF40
        protected override void OnNewTrade(Instrument instrument, Trade trade)
        {
            foreach (object obj in new ArrayList(this.activeStops[instrument]))
            {
                ATSStop atsstop = (ATSStop)obj;
                if (atsstop.Connected)
                {
                    atsstop.OnNewTrade(trade);
                }
            }
            this.marketManager.OnTrade(instrument, trade);
            this.atsRuntimeCrossComponent.OnTrade(instrument, trade);
            this.atsComponents[instrument].OnTrade(trade);
        }

        // Token: 0x060002F6 RID: 758 RVA: 0x0000BFD8 File Offset: 0x0000AFD8
        protected override void OnNewQuote(Instrument instrument, Quote quote)
        {
            foreach (object obj in new ArrayList(this.activeStops[instrument]))
            {
                ATSStop atsstop = (ATSStop)obj;
                if (atsstop.Connected)
                {
                    atsstop.OnNewQuote(quote);
                }
            }
            this.marketManager.OnQuote(instrument, quote);
            this.atsRuntimeCrossComponent.OnQuote(instrument, quote);
            this.atsComponents[instrument].OnQuote(quote);
        }

        // Token: 0x060002F7 RID: 759 RVA: 0x0000C070 File Offset: 0x0000B070
        protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
        {
            this.marketManager.OnMarketDepth(instrument, marketDepth);
            this.atsRuntimeCrossComponent.OnMarketDepth(instrument, marketDepth);
            this.atsComponents[instrument].OnMarketDepth(marketDepth);
        }

        // Token: 0x060002F8 RID: 760 RVA: 0x0000C09E File Offset: 0x0000B09E
        protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
        {
            this.marketManager.OnFundamental(instrument, fundamental);
            this.atsRuntimeCrossComponent.OnFundamental(instrument, fundamental);
            this.atsComponents[instrument].OnFundamental(fundamental);
        }

        // Token: 0x060002F9 RID: 761 RVA: 0x0000C0CC File Offset: 0x0000B0CC
        protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
        {
            this.marketManager.OnCorporateAction(instrument, corporateAction);
            this.atsRuntimeCrossComponent.OnCorporateAction(instrument, corporateAction);
            this.atsComponents[instrument].OnCorporateAction(corporateAction);
        }

        // Token: 0x060002FA RID: 762 RVA: 0x0000C0FC File Offset: 0x0000B0FC
        protected override void OnNewBarOpen(Instrument instrument, Bar bar)
        {
            foreach (object obj in new ArrayList(this.activeStops[instrument]))
            {
                ATSStop atsstop = (ATSStop)obj;
                if (atsstop.Connected)
                {
                    atsstop.OnNewBarOpen(bar);
                }
            }
            this.marketManager.OnBarOpen(instrument, bar);
            this.atsRuntimeCrossComponent.OnBarOpen(instrument, bar);
            this.atsComponents[instrument].OnBarOpen(bar);
        }

        // Token: 0x060002FB RID: 763 RVA: 0x0000C194 File Offset: 0x0000B194
        protected override void OnNewBar(Instrument instrument, Bar bar)
        {
            foreach (object obj in new ArrayList(this.activeStops[instrument]))
            {
                ATSStop atsstop = (ATSStop)obj;
                if (atsstop.Connected)
                {
                    atsstop.OnNewBar(bar);
                }
            }
            this.marketManager.OnBar(instrument, bar);
            this.atsRuntimeCrossComponent.OnBar(instrument, bar);
            this.atsComponents[instrument].OnBar(bar);
        }

        // Token: 0x060002FC RID: 764 RVA: 0x0000C22C File Offset: 0x0000B22C
        protected override void OnNewBarSlice(long barSize)
        {
            this.marketManager.OnBarSlice(barSize);
            this.atsRuntimeCrossComponent.OnBarSlice(barSize);
        }

        // Token: 0x060002FD RID: 765 RVA: 0x0000C246 File Offset: 0x0000B246
        protected override void OnProviderConnected(IProvider provider)
        {
            this.marketManager.OnProviderConnected(provider);
            this.atsRuntimeCrossComponent.OnProviderConnected(provider);
        }

        // Token: 0x060002FE RID: 766 RVA: 0x0000C260 File Offset: 0x0000B260
        protected override void OnProviderDisconnected(IProvider provider)
        {
            this.marketManager.OnProviderDisconnected(provider);
            this.atsRuntimeCrossComponent.OnProviderDisconnected(provider);
        }

        // Token: 0x060002FF RID: 767 RVA: 0x0000C27A File Offset: 0x0000B27A
        protected override void OnProviderError(IProvider provider, int id, int code, string message)
        {
            this.marketManager.OnProviderError(provider, id, code, message);
            this.atsRuntimeCrossComponent.OnProviderError(provider, id, code, message);
        }

        // Token: 0x06000300 RID: 768 RVA: 0x0000C29C File Offset: 0x0000B29C
        protected override void OnPositionOpened(Position position)
        {
            this.atsRuntimeCrossComponent.OnPositionOpened(position);
            this.atsComponents[position.Instrument].OnPositionOpened();
        }

        // Token: 0x06000301 RID: 769 RVA: 0x0000C2C0 File Offset: 0x0000B2C0
        protected override void OnPositionChanged(Position position)
        {
            this.atsRuntimeCrossComponent.OnPositionChanged(position);
            this.atsComponents[position.Instrument].OnPositionChanged();
        }

        // Token: 0x06000302 RID: 770 RVA: 0x0000C2E4 File Offset: 0x0000B2E4
        protected override void OnPositionClosed(Position position)
        {
            Instrument instrument = position.Instrument;
            foreach (object obj in new ArrayList(this.activeStops[instrument]))
            {
                ATSStop atsstop = (ATSStop)obj;
                if ((atsstop.Type == StopType.Time && atsstop.Status == StopStatus.Active) || atsstop.Connected)
                {
                    atsstop.OnPositionClosed(position);
                }
            }
            this.atsRuntimeCrossComponent.OnPositionClosed(position);
            this.atsComponents[instrument].OnPositionClosed();
        }

        // Token: 0x06000303 RID: 771 RVA: 0x0000C388 File Offset: 0x0000B388
        protected override void OnPortfolioValueChanged(Position position)
        {
            this.atsRuntimeCrossComponent.OnPositionValueChanged(position);
            this.atsComponents[position.Instrument].OnPositionValueChanged();
        }

        // Token: 0x06000304 RID: 772 RVA: 0x0000C3AC File Offset: 0x0000B3AC
        internal void RegisterOrder(SingleOrder order)
        {
            order.Strategy = base.Name;
            order.StrategyComponent = ComponentType.ATSComponent.ToString();
            base.MetaStrategyBase.RegisterOrder(this, order);
        }

        // Token: 0x06000305 RID: 773 RVA: 0x0000C3DC File Offset: 0x0000B3DC
        protected override void OnNewOrder(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnNewOrder(order);
            this.atsComponents[order.Instrument].OnNewOrder(order);
        }

        // Token: 0x06000306 RID: 774 RVA: 0x0000C401 File Offset: 0x0000B401
        protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
        {
            this.atsRuntimeCrossComponent.OnExecutionReport(order, report);
            this.atsComponents[order.Instrument].OnExecutionReport(order, report);
        }

        // Token: 0x06000307 RID: 775 RVA: 0x0000C428 File Offset: 0x0000B428
        protected override void OnOrderPartiallyFilled(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnOrderPartiallyFilled(order);
            this.atsComponents[order.Instrument].OnOrderPartiallyFilled(order);
        }

        // Token: 0x06000308 RID: 776 RVA: 0x0000C44D File Offset: 0x0000B44D
        protected override void OnOrderStatusChanged(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnOrderStatusChanged(order);
            this.atsComponents[order.Instrument].OnOrderStatusChanged(order);
        }

        // Token: 0x06000309 RID: 777 RVA: 0x0000C472 File Offset: 0x0000B472
        protected override void OnOrderFilled(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnOrderFilled(order);
            this.atsComponents[order.Instrument].OnOrderFilled(order);
        }

        // Token: 0x0600030A RID: 778 RVA: 0x0000C497 File Offset: 0x0000B497
        protected override void OnOrderCancelled(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnOrderCancelled(order);
            this.atsComponents[order.Instrument].OnOrderCancelled(order);
        }

        // Token: 0x0600030B RID: 779 RVA: 0x0000C4BC File Offset: 0x0000B4BC
        protected override void OnOrderRejected(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnOrderRejected(order);
            this.atsComponents[order.Instrument].OnOrderRejected(order);
        }

        // Token: 0x0600030C RID: 780 RVA: 0x0000C4E1 File Offset: 0x0000B4E1
        protected override void OnOrderDone(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.OnOrderDone(order);
            this.atsComponents[order.Instrument].OnOrderDone(order);
        }

        // Token: 0x0600030D RID: 781 RVA: 0x0000C506 File Offset: 0x0000B506
        protected override void OnNewClientOrder(SingleOrder order)
        {
            this.atsRuntimeCrossComponent.SetClientOrder(order);
        }

        // Token: 0x0600030E RID: 782 RVA: 0x0000C514 File Offset: 0x0000B514
        public override void ClosePosition(Instrument instrument, double price, ComponentType component, string text)
        {
        }

        // Token: 0x0600030F RID: 783 RVA: 0x0000C518 File Offset: 0x0000B518
        public override IComponentBase GetComponent(ComponentType type)
        {
            if (type <= ComponentType.ReportManager)
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
                if (type == ComponentType.ATSComponent)
                {
                    return this.ATSComponent;
                }
                if (type == ComponentType.ATSCrossComponent)
                {
                    return this.ATSCrossComponent;
                }
            }
            throw new InvalidOperationException("Invalid strategy1 component type");
        }

        // Token: 0x06000310 RID: 784 RVA: 0x0000C578 File Offset: 0x0000B578
        public override void SetComponent(ComponentType type, IComponentBase component)
        {
            if (type <= ComponentType.ReportManager)
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
                if (type == ComponentType.ATSComponent)
                {
                    this.ATSComponent = (component as ATSComponent);
                    return;
                }
                if (type == ComponentType.ATSCrossComponent)
                {
                    this.ATSCrossComponent = (component as ATSCrossComponent);
                    return;
                }
            }
            throw new InvalidOperationException("Invalid strategy1 component type");
        }

        // Token: 0x040000F9 RID: 249
        private ATSComponent atsComponent;

        // Token: 0x040000FA RID: 250
        private ATSCrossComponent atsCrossComponent;

        // Token: 0x040000FB RID: 251
        private ATSCrossComponent atsRuntimeCrossComponent;

        // Token: 0x040000FC RID: 252
        private Dictionary<Instrument, ATSComponent> atsComponents;
        /*--------------------
         * 增加下以功能
         _____________________*/
        public void RunTimeAddInstrument(Instrument inst)
        {
            this.activeInstruments.Add(inst);
            ATSComponent atscomponent = Activator.CreateInstance(this.atsComponent.GetType()) as ATSComponent;
            atscomponent.StrategyBase = this;
            atscomponent.Instrument = inst;
            base.SetProxyProperties(atscomponent, this.atsComponent);
            atscomponent.Init();
            this.atsComponents.Add(inst, atscomponent);
            this.marketManager.AddInstrument(inst, this.marketDataProvider, this.executionProvider);
            this.metaStrategyBase.RunTimeAddInstrument(inst, this, this.marketDataProvider, this.executionProvider);
        }
        public void RunTimeRemoveInstrument(Instrument inst)
        {
            this.metaStrategyBase.RunTimeRemoveInstrument(inst, this, this.marketDataProvider);
            this.marketManager.RemoveInstrument(inst);
            this.atsComponents.Remove(inst);
            this.activeInstruments.Remove(inst);
        }
    }
}
