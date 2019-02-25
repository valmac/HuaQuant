using System;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Simulation;
using SmartQuant.Trading.Design;

namespace SmartQuant.Trading
{
	// Token: 0x02000066 RID: 102
	[StrategyComponent("{872476E5-3774-4687-828F-34978288A6E0}", ComponentType.SimulationManager, Name = "Default_SimulationManager", Description = "")]
	public class SimulationManager : ComponentBase
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0000F0CA File Offset: 0x0000E0CA
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0000F0DB File Offset: 0x0000E0DB
		[Description("Commission")]
		[Category("Execution - Commission & Slippage")]
		public ICommissionProvider CommissionProvider
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).CommissionProvider;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).CommissionProvider = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000F0ED File Offset: 0x0000E0ED
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000F0FE File Offset: 0x0000E0FE
		[Description("Slippage")]
		[Category("Execution - Commission & Slippage")]
		public ISlippageProvider SlippageProvider
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).SlippageProvider;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).SlippageProvider = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000F110 File Offset: 0x0000E110
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000F121 File Offset: 0x0000E121
		[Category("Execution - Fill Data")]
		[DefaultValue(true)]
		public bool FillOnQuote
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuote;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuote = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000F133 File Offset: 0x0000E133
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000F144 File Offset: 0x0000E144
		[Category("Execution - Fill Data")]
		[DefaultValue(true)]
		public bool FillOnTrade
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTrade;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTrade = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000F156 File Offset: 0x0000E156
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000F167 File Offset: 0x0000E167
		[Category("Execution - Fill Data")]
		[DefaultValue(true)]
		public bool FillOnBar
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBar;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBar = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000F179 File Offset: 0x0000E179
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000F18A File Offset: 0x0000E18A
		[DefaultValue(FillOnTradeMode.LastTrade)]
		[Category("Execution - Fill Mode")]
		public FillOnTradeMode FillOnTradeMode
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTradeMode;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTradeMode = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000F19C File Offset: 0x0000E19C
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0000F1AD File Offset: 0x0000E1AD
		[DefaultValue(FillOnQuoteMode.LastQuote)]
		[Category("Execution - Fill Mode")]
		public FillOnQuoteMode FillOnQuoteMode
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuoteMode;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuoteMode = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000F1BF File Offset: 0x0000E1BF
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0000F1D0 File Offset: 0x0000E1D0
		[DefaultValue(FillOnBarMode.LastBarClose)]
		[Category("Execution - Fill Mode")]
		public FillOnBarMode FillOnBarMode
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBarMode;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBarMode = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000F1E2 File Offset: 0x0000E1E2
		[Browsable(false)]
		public RequestList Requests
		{
			get
			{
				return this.requests;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000F1EA File Offset: 0x0000E1EA
		[Category("Feed Simulator")]
		[Editor(typeof(RequestListEditor), typeof(UITypeEditor))]
		public RequestList StaticRequests
		{
			get
			{
				return this.staticRequests;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000F1F2 File Offset: 0x0000E1F2
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0000F1FA File Offset: 0x0000E1FA
		[DefaultValue(SimulationMode.MaxSpeed)]
		[Category("Feed Simulator")]
		public SimulationMode Mode
		{
			get
			{
				return this.fMode;
			}
			set
			{
				this.fMode = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000F203 File Offset: 0x0000E203
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0000F20B File Offset: 0x0000E20B
		[DefaultValue(1.0)]
		[Category("Feed Simulator")]
		public double SpeedMultiplier
		{
			get
			{
				return this.fSpeedMultiplier;
			}
			set
			{
				this.fSpeedMultiplier = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000F214 File Offset: 0x0000E214
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000F21C File Offset: 0x0000E21C
		[DefaultValue(86400)]
		[Description("Step size in seconds")]
		[Category("Feed Simulator")]
		public int Step
		{
			get
			{
				return this.fStep;
			}
			set
			{
				this.fStep = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000F225 File Offset: 0x0000E225
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000F22D File Offset: 0x0000E22D
		[Category("Feed Simulator")]
		[DefaultValue(typeof(DateTime), "01/01/1970")]
		public DateTime EntryDate
		{
			get
			{
				return this.fEntryDate;
			}
			set
			{
				this.fEntryDate = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000F236 File Offset: 0x0000E236
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0000F23E File Offset: 0x0000E23E
		[Category("Feed Simulator")]
		public DateTime ExitDate
		{
			get
			{
				return this.fExitDate;
			}
			set
			{
				this.fExitDate = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000F247 File Offset: 0x0000E247
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000F24F File Offset: 0x0000E24F
		[DefaultValue(10000.0)]
		[Category("Account")]
		public double Cash
		{
			get
			{
				return this.fCash;
			}
			set
			{
				this.fCash = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000F258 File Offset: 0x0000E258
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0000F260 File Offset: 0x0000E260
		[Category("Account")]
		public Currency Currency
		{
			get
			{
				return this.fCurrency;
			}
			set
			{
				this.fCurrency = value;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000F26C File Offset: 0x0000E26C
		public SimulationManager()
		{
			this.requests = new RequestList();
			this.staticRequests = new RequestList();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000F2ED File Offset: 0x0000E2ED
		public override void Init()
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000F2EF File Offset: 0x0000E2EF
		public void SendMarketDataRequest(string request)
		{
			if (!this.requests.Contains(request))
			{
				this.requests.Add(request);
			}
		}

		// Token: 0x04000141 RID: 321
		public const string GUID = "{872476E5-3774-4687-828F-34978288A6E0}";

		// Token: 0x04000142 RID: 322
		public const string CATEGORY_SIMULATOR = "Feed Simulator";

		// Token: 0x04000143 RID: 323
		public const string CATEGORY_ACCOUNT = "Account";

		// Token: 0x04000144 RID: 324
		private const string CATEGORY_FILL_DATA = "Execution - Fill Data";

		// Token: 0x04000145 RID: 325
		private const string CATEGORY_FILL_MODE = "Execution - Fill Mode";

		// Token: 0x04000146 RID: 326
		private const SimulationMode DEFAULT_SIMULATION_MODE = SimulationMode.MaxSpeed;

		// Token: 0x04000147 RID: 327
		private const double DEFAULT_SPEED_MULTIPLIER = 1.0;

		// Token: 0x04000148 RID: 328
		private const int DEFAULT_STEP_SIZE = 86400;

		// Token: 0x04000149 RID: 329
		private const double DEFAULT_CASH = 10000.0;

		// Token: 0x0400014A RID: 330
		private const bool DEFAULT_FILL_ON_BAR = true;

		// Token: 0x0400014B RID: 331
		private const bool DEFAULT_FILL_ON_QUOTE = true;

		// Token: 0x0400014C RID: 332
		private const bool DEFAULT_FILL_ON_TRADE = true;

		// Token: 0x0400014D RID: 333
		private const FillOnBarMode DEFAULT_FILL_ON_BAR_MODE = FillOnBarMode.LastBarClose;

		// Token: 0x0400014E RID: 334
		private const FillOnTradeMode DEFAULT_FILL_ON_TRADE_MODE = FillOnTradeMode.LastTrade;

		// Token: 0x0400014F RID: 335
		private const FillOnQuoteMode DEFAULT_FILL_ON_QUOTE_MODE = FillOnQuoteMode.LastQuote;

		// Token: 0x04000150 RID: 336
		private SimulationMode fMode = SimulationMode.MaxSpeed;

		// Token: 0x04000151 RID: 337
		private double fSpeedMultiplier = 1.0;

		// Token: 0x04000152 RID: 338
		private int fStep = 86400;

		// Token: 0x04000153 RID: 339
		private DateTime fEntryDate = new DateTime(1970, 1, 1);

		// Token: 0x04000154 RID: 340
		private DateTime fExitDate = DateTime.Today;

		// Token: 0x04000155 RID: 341
		private double fCash = 10000.0;

		// Token: 0x04000156 RID: 342
		private Currency fCurrency = CurrencyManager.DefaultCurrency;

		// Token: 0x04000157 RID: 343
		private RequestList requests;

		// Token: 0x04000158 RID: 344
		private RequestList staticRequests;
	}
}
