using System;
using System.Collections.Generic;
using System.ComponentModel;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace SmartQuant.Trading
{
	// Token: 0x0200002D RID: 45
	[StrategyComponent("{849E4CFE-C19E-4d1e-899D-0BB26DB12AAD}", ComponentType.MarketManager, Name = "Default_MarketManager", Description = "")]
	public class MarketManager : StrategyBaseMultiComponent
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00006958 File Offset: 0x00005958
		public MarketManager()
		{
			this.marketDataProviderTable = new Dictionary<Instrument, IMarketDataProvider>();
			this.executionProviderTable = new Dictionary<Instrument, IExecutionProvider>();
			this.instruments = new InstrumentList();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00006981 File Offset: 0x00005981
		[Browsable(false)]
		public InstrumentList Instruments
		{
			get
			{
				return this.instruments;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00006989 File Offset: 0x00005989
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00006991 File Offset: 0x00005991
		[Browsable(false)]
		internal IMarketDataProvider StrategyMarketDataProvider
		{
			get
			{
				return this.strategyMarketDataProvider;
			}
			set
			{
				this.strategyMarketDataProvider = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000699A File Offset: 0x0000599A
		// (set) Token: 0x060001CA RID: 458 RVA: 0x000069A2 File Offset: 0x000059A2
		[Browsable(false)]
		internal IExecutionProvider StrategyExecutionProvider
		{
			get
			{
				return this.strategyExecutionProvider;
			}
			set
			{
				this.strategyExecutionProvider = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000069AB File Offset: 0x000059AB
		[Browsable(false)]
		internal Dictionary<Instrument, IMarketDataProvider> MarketDataProviderTable
		{
			get
			{
				return this.marketDataProviderTable;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000069B3 File Offset: 0x000059B3
		[Browsable(false)]
		internal Dictionary<Instrument, IExecutionProvider> ExecutionProviderTable
		{
			get
			{
				return this.executionProviderTable;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000069BC File Offset: 0x000059BC
		public void AddInstrument(Instrument instrument, IMarketDataProvider marketDataProvider, IExecutionProvider executionProvider)
		{
			if (!this.instruments.Contains(instrument))
			{
				this.instruments.Add(instrument);
			}
			if (marketDataProvider != null)
			{
				this.marketDataProviderTable[instrument] = marketDataProvider;
			}
			else
			{
				this.marketDataProviderTable[instrument] = this.strategyMarketDataProvider;
			}
			if (executionProvider != null)
			{
				this.executionProviderTable[instrument] = executionProvider;
				return;
			}
			this.executionProviderTable[instrument] = this.strategyExecutionProvider;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006A2C File Offset: 0x00005A2C
		public void AddInstrument(Instrument instrument, string marketDataProviderName, string executionProviderName)
		{
			IMarketDataProvider marketDataProvider = ProviderManager.MarketDataProviders[marketDataProviderName];
			IExecutionProvider executionProvider = ProviderManager.ExecutionProviders[executionProviderName];
			if (marketDataProvider == null && marketDataProviderName != "")
			{
				throw new InvalidOperationException("Specified Market Data Provider for " + instrument.Symbol + " does not exist");
			}
			if (executionProvider == null && executionProviderName != "")
			{
				throw new InvalidOperationException("Specified Execution Provider for " + instrument.Symbol + " does not exist");
			}
			this.AddInstrument(instrument, marketDataProvider, executionProvider);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006AB0 File Offset: 0x00005AB0
		public void AddInstrument(string symbol, string marketDataProviderName, string executionProviderName)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument != null)
			{
				this.AddInstrument(instrument, marketDataProviderName, executionProviderName);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006AD5 File Offset: 0x00005AD5
		public void AddInstrument(Instrument instrument)
		{
			this.AddInstrument(instrument, this.strategyMarketDataProvider, this.strategyExecutionProvider);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00006AEC File Offset: 0x00005AEC
		public void AddInstrument(string symbol)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument != null)
			{
				this.AddInstrument(instrument);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006B0F File Offset: 0x00005B0F
		public void RemoveInstrument(Instrument instrument)
		{
			this.instruments.Remove(instrument);
			this.marketDataProviderTable.Remove(instrument);
			this.executionProviderTable.Remove(instrument);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00006B38 File Offset: 0x00005B38
		public void RemoveInstrument(string symbol)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument != null)
			{
				this.RemoveInstrument(instrument);
			}
		}

		// Token: 0x04000092 RID: 146
		public const string GUID = "{849E4CFE-C19E-4d1e-899D-0BB26DB12AAD}";

		// Token: 0x04000093 RID: 147
		private Dictionary<Instrument, IMarketDataProvider> marketDataProviderTable;

		// Token: 0x04000094 RID: 148
		private Dictionary<Instrument, IExecutionProvider> executionProviderTable;

		// Token: 0x04000095 RID: 149
		private InstrumentList instruments;

		// Token: 0x04000096 RID: 150
		protected IMarketDataProvider strategyMarketDataProvider;

		// Token: 0x04000097 RID: 151
		protected IExecutionProvider strategyExecutionProvider;
	}
}
