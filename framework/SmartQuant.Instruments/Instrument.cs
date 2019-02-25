using System;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Data;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments.Design;
using SmartQuant.Providers;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x02000011 RID: 17
	public class Instrument : FIXInstrument
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002AD6 File Offset: 0x00001AD6
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002AE3 File Offset: 0x00001AE3
		[Description("Indicates whether an Option is for a put or call.")]
		[Category("Derivative")]
		public new PutOrCall PutOrCall
		{
			get
			{
				return FIXPutOrCall.FromFIX(base.PutOrCall);
			}
			set
			{
				base.PutOrCall = FIXPutOrCall.ToFIX(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002AF1 File Offset: 0x00001AF1
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002AF9 File Offset: 0x00001AF9
		[Browsable(false)]
		public Exchange Exchange
		{
			get
			{
				return this.fExchange;
			}
			set
			{
				this.fExchange = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002B02 File Offset: 0x00001B02
		[Editor(typeof(LegListEditor), typeof(UITypeEditor))]
		[Category("Attributes")]
		[Description("List of instrument legs")]
		public LegList Legs
		{
			get
			{
				return this.fLegs;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002B0A File Offset: 0x00001B0A
		[Category("Attributes")]
		[Editor(typeof(UnderlyingListEditor), typeof(UITypeEditor))]
		[Description("List of instrument underlyings")]
		public UnderlyingList Underlyings
		{
			get
			{
				return this.fUnderlyings;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002B12 File Offset: 0x00001B12
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002B1A File Offset: 0x00001B1A
		[Browsable(false)]
		public IPricer Pricer
		{
			get
			{
				return this.fPricer;
			}
			set
			{
				this.fPricer = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002B23 File Offset: 0x00001B23
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002B30 File Offset: 0x00001B30
		[FIXField("668", EFieldOption.Optional)]
		[Category("Trade")]
		[Description("Identifies the form of delivery")]
		public int DeliveryForm
		{
			get
			{
				return this.GetIntValue(668);
			}
			set
			{
				this.SetIntValue(668, value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002B3E File Offset: 0x00001B3E
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002B4B File Offset: 0x00001B4B
		[Category("Trade")]
		[FIXField("869", EFieldOption.Optional)]
		[Description("Percent at risk due to lowest possible call.")]
		public double PctAtRisk
		{
			get
			{
				return this.GetDoubleValue(869);
			}
			set
			{
				this.SetDoubleValue(869, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002B59 File Offset: 0x00001B59
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002B63 File Offset: 0x00001B63
		[Description("Identifies currency used for price. Absence of this field is interpreted as the default for the security.  It is recommended that systems provide the currency value whenever possible.")]
		[FIXField("15", EFieldOption.Optional)]
		[Category("Appearance")]
		public string Currency
		{
			get
			{
				return this.GetStringValue(15);
			}
			set
			{
				this.SetStringValue(15, value);
				this.fCurrency = CurrencyManager.Currencies[value];
				if (this.fCurrency == null)
				{
					this.fCurrency = CurrencyManager.DefaultCurrency;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002B92 File Offset: 0x00001B92
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002B9F File Offset: 0x00001B9F
		[Description("Identifier for Trading Session. Can be used to represent a specific market trading session (e.g. PRE-OPEN, CROSS_2, AFTER-HOURS, TOSTNET1, TOSTNET2, etc).")]
		[FIXField("336", EFieldOption.Optional)]
		[Category("Trade")]
		public string TradingSessionID
		{
			get
			{
				return this.GetStringValue(336);
			}
			set
			{
				this.SetStringValue(336, value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002BAD File Offset: 0x00001BAD
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002BBA File Offset: 0x00001BBA
		[Description("Optional market assigned sub identifier for a trading session. Usage is determined by market or counterparties. Used by US based futures markets to identify exchange specific execution time bracket codes as required by US market regulations.")]
		[Category("Trade")]
		[FIXField("625", EFieldOption.Optional)]
		public string TradingSessionSubID
		{
			get
			{
				return this.GetStringValue(625);
			}
			set
			{
				this.SetStringValue(625, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002BC8 File Offset: 0x00001BC8
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002BD5 File Offset: 0x00001BD5
		[FIXField("827", EFieldOption.Optional)]
		[Description("Part of trading cycle when an instrument expires. Field is applicable for derivatives.")]
		[Category("Trade")]
		public int ExpirationCycle
		{
			get
			{
				return this.GetIntValue(827);
			}
			set
			{
				this.SetIntValue(827, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002BE3 File Offset: 0x00001BE3
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002BF0 File Offset: 0x00001BF0
		[Category("Trade")]
		[FIXField("561", EFieldOption.Optional)]
		[Description("The trading lot size of a security")]
		public double RoundLot
		{
			get
			{
				return this.GetDoubleValue(561);
			}
			set
			{
				this.SetDoubleValue(561, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002BFE File Offset: 0x00001BFE
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002C0B File Offset: 0x00001C0B
		[FIXField("562", EFieldOption.Optional)]
		[Category("Trade")]
		[Description("The minimum trading volume for a security")]
		public double MinTradeVol
		{
			get
			{
				return this.GetDoubleValue(562);
			}
			set
			{
				this.SetDoubleValue(562, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002C19 File Offset: 0x00001C19
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002C26 File Offset: 0x00001C26
		[Description("Industry code")]
		[FIXField("10100", EFieldOption.Optional)]
		[Category("Industry")]
		public string IndustryCode
		{
			get
			{
				return this.GetStringValue(10100);
			}
			set
			{
				this.SetStringValue(10100, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002C34 File Offset: 0x00001C34
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002C41 File Offset: 0x00001C41
		[FIXField("10101", EFieldOption.Optional)]
		[Category("Industry")]
		[Description("Industry sector")]
		public string IndustrySector
		{
			get
			{
				return this.GetStringValue(10101);
			}
			set
			{
				this.SetStringValue(10101, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002C4F File Offset: 0x00001C4F
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002C5C File Offset: 0x00001C5C
		[Description("Industry group")]
		[Category("Industry")]
		[FIXField("10102", EFieldOption.Optional)]
		public string IndustryGroup
		{
			get
			{
				return this.GetStringValue(10102);
			}
			set
			{
				this.SetStringValue(10102, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002C6A File Offset: 0x00001C6A
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002C77 File Offset: 0x00001C77
		[Description("Industry sub group")]
		[Category("Industry")]
		[FIXField("10103", EFieldOption.Optional)]
		public string IndustrySubGroup
		{
			get
			{
				return this.GetStringValue(10103);
			}
			set
			{
				this.SetStringValue(10103, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002C85 File Offset: 0x00001C85
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002C92 File Offset: 0x00001C92
		[DefaultValue("F2")]
		[Category("Price format")]
		[Description("Price display")]
		[FIXField("10103", EFieldOption.Optional)]
		public string PriceDisplay
		{
			get
			{
				return this.GetStringValue(11105);
			}
			set
			{
				this.SetStringValue(11105, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002CA0 File Offset: 0x00001CA0
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002CAD File Offset: 0x00001CAD
		[Category("Margin")]
		[Description("Initial margin")]
		[FIXField("10600", EFieldOption.Optional)]
		public double Margin
		{
			get
			{
				return this.GetDoubleValue(10600);
			}
			set
			{
				this.SetDoubleValue(10600, value);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002CBC File Offset: 0x00001CBC
		protected Instrument()
		{
			this.PriceDisplay = "F2";
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002D48 File Offset: 0x00001D48
		public Instrument(string symbol) : this(symbol, "CS")
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002D58 File Offset: 0x00001D58
		public Instrument(string symbol, string securityType)
		{
			base.Symbol = symbol;
			base.SecurityType = securityType;
			if (securityType == "FOR")
			{
				this.PriceDisplay = "F4";
			}
			else
			{
				this.PriceDisplay = "F2";
			}
			InstrumentManager.Add(this);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002E12 File Offset: 0x00001E12
		public Currency GetCurrency()
		{
			if (this.fCurrency != null)
			{
				return this.fCurrency;
			}
			this.fCurrency = CurrencyManager.Currencies[this.Currency];
			if (this.fCurrency == null)
			{
				this.fCurrency = CurrencyManager.DefaultCurrency;
			}
			return this.fCurrency;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002E54 File Offset: 0x00001E54
		public string GetSymbol(string source)
		{
			if (base.SecurityIDSource == source)
			{
				return base.SecurityID;
			}
			foreach (object obj in this.fSecurityAltIDGroup)
			{
				FIXSecurityAltIDGroup fixsecurityAltIDGroup = (FIXSecurityAltIDGroup)obj;
				if (fixsecurityAltIDGroup.SecurityAltIDSource == source && fixsecurityAltIDGroup.SecurityAltID != "")
				{
					return fixsecurityAltIDGroup.SecurityAltID;
				}
			}
			return base.Symbol;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002EEC File Offset: 0x00001EEC
		public void AddSymbol(string symbol, string source)
		{
			base.AddGroup(new FIXSecurityAltIDGroup
			{
				SecurityAltID = symbol,
				SecurityAltIDSource = source
			});
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002F14 File Offset: 0x00001F14
		public void AddSymbol(string symbol, string securityExchange, string source)
		{
			base.AddGroup(new FIXSecurityAltIDGroup
			{
				SecurityAltExchange = securityExchange,
				SecurityAltID = symbol,
				SecurityAltIDSource = source
			});
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002F44 File Offset: 0x00001F44
		public string GetSecurityExchange(string source)
		{
			foreach (object obj in this.fSecurityAltIDGroup)
			{
				FIXSecurityAltIDGroup fixsecurityAltIDGroup = (FIXSecurityAltIDGroup)obj;
				if (fixsecurityAltIDGroup.SecurityAltIDSource == source && fixsecurityAltIDGroup.SecurityAltExchange != "")
				{
					return fixsecurityAltIDGroup.SecurityAltExchange;
				}
			}
			return base.SecurityExchange;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002FC8 File Offset: 0x00001FC8
		public void Save()
		{
			InstrumentManager.Save(this);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002FD0 File Offset: 0x00001FD0
		public virtual double Price()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Price(this);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002FF1 File Offset: 0x00001FF1
		public virtual double Price(DateTime datetime)
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Price(this, datetime);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003013 File Offset: 0x00002013
		public virtual double Volatility()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer");
			}
			return this.fPricer.Volatility(this);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003034 File Offset: 0x00002034
		public double Delta()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Delta(this);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003055 File Offset: 0x00002055
		public double Delta(DateTime datetime)
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Delta(this, datetime);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003077 File Offset: 0x00002077
		public double Gamma()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Gamma(this);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003098 File Offset: 0x00002098
		public double Gamma(DateTime datetime)
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Gamma(this, datetime);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000030BA File Offset: 0x000020BA
		public double Theta()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Theta(this);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000030DB File Offset: 0x000020DB
		public double Theta(DateTime datetime)
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Theta(this, datetime);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000030FD File Offset: 0x000020FD
		public double Rho()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Rho(this);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000311E File Offset: 0x0000211E
		public double Rho(DateTime datetime)
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Rho(this, datetime);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003140 File Offset: 0x00002140
		public double Vega()
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Vega(this);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003161 File Offset: 0x00002161
		public double Vega(DateTime datetime)
		{
			if (this.fPricer == null)
			{
				throw new ApplicationException("Null reference to pricer!");
			}
			return this.fPricer.Vega(this, datetime);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600009B RID: 155 RVA: 0x00003183 File Offset: 0x00002183
		// (remove) Token: 0x0600009C RID: 156 RVA: 0x0000319C File Offset: 0x0000219C
		public event QuoteEventHandler NewQuote;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600009D RID: 157 RVA: 0x000031B5 File Offset: 0x000021B5
		// (remove) Token: 0x0600009E RID: 158 RVA: 0x000031CE File Offset: 0x000021CE
		public event TradeEventHandler NewTrade;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600009F RID: 159 RVA: 0x000031E7 File Offset: 0x000021E7
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x00003200 File Offset: 0x00002200
		public event BarEventHandler NewBar;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000A1 RID: 161 RVA: 0x00003219 File Offset: 0x00002219
		// (remove) Token: 0x060000A2 RID: 162 RVA: 0x00003232 File Offset: 0x00002232
		public event BarEventHandler NewBarOpen;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000A3 RID: 163 RVA: 0x0000324B File Offset: 0x0000224B
		// (remove) Token: 0x060000A4 RID: 164 RVA: 0x00003264 File Offset: 0x00002264
		public event MarketDepthEventHandler NewMarketDepth;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000A5 RID: 165 RVA: 0x0000327D File Offset: 0x0000227D
		// (remove) Token: 0x060000A6 RID: 166 RVA: 0x00003296 File Offset: 0x00002296
		public event FundamentalEventHandler NewFundamental;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000A7 RID: 167 RVA: 0x000032AF File Offset: 0x000022AF
		// (remove) Token: 0x060000A8 RID: 168 RVA: 0x000032C8 File Offset: 0x000022C8
		public event CorporateActionEventHandler NewCorporateAction;

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000032E1 File Offset: 0x000022E1
		[Browsable(false)]
		public Quote Quote
		{
			get
			{
				return this.fQuote;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000032E9 File Offset: 0x000022E9
		[Browsable(false)]
		public Trade Trade
		{
			get
			{
				return this.fTrade;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000032F1 File Offset: 0x000022F1
		[Browsable(false)]
		public Bar Bar
		{
			get
			{
				return this.fBar;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000032F9 File Offset: 0x000022F9
		[Browsable(false)]
		public MarketDepth MarketDepth
		{
			get
			{
				return this.fMarketDepth;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003301 File Offset: 0x00002301
		[Browsable(false)]
		public Fundamental Fundamental
		{
			get
			{
				return this.fFundamental;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003309 File Offset: 0x00002309
		[Browsable(false)]
		public CorporateAction CorporateAction
		{
			get
			{
				return this.fCorporateAction;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003311 File Offset: 0x00002311
		[Browsable(false)]
		public OrderBook OrderBook
		{
			get
			{
				return this.fOrderBook;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003319 File Offset: 0x00002319
		[Browsable(false)]
		public double Change
		{
			get
			{
				return this.fChange;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003321 File Offset: 0x00002321
		[Browsable(false)]
		public QuoteArray Quotes
		{
			get
			{
				return DataManager.Quotes[this];
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000332E File Offset: 0x0000232E
		[Browsable(false)]
		public TradeArray Trades
		{
			get
			{
				return DataManager.Trades[this];
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000333B File Offset: 0x0000233B
		[Browsable(false)]
		public BarSeries Bars
		{
			get
			{
				return DataManager.Bars[this];
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003348 File Offset: 0x00002348
		public void Reset()
		{
			this.fBar = new Bar();
			this.fQuote = new Quote();
			this.fTrade = new Trade();
			this.fMarketDepth = new MarketDepth();
			this.fFundamental = new Fundamental();
			this.fCorporateAction = new CorporateAction();
			this.fChange = 0.0;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000033A6 File Offset: 0x000023A6
		internal void SetNewQuote(QuoteEventArgs args)
		{
			this.fQuote = args.Quote;
			if (this.NewQuote != null)
			{
				this.NewQuote(this, args);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000033CC File Offset: 0x000023CC
		internal void SetNewTrade(TradeEventArgs args)
		{
			if (this.fTrade.Price != 0.0 && this.fTrade.Price != args.Trade.Price)
			{
				this.fChange = args.Trade.Price - this.fTrade.Price;
			}
			this.fTrade = args.Trade;
			if (this.NewTrade != null)
			{
				this.NewTrade(this, args);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003448 File Offset: 0x00002448
		internal void SetNewBar(BarEventArgs args)
		{
			this.fBar = args.Bar;
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Concat(new object[]
				{
					"<Instrument.SetNewBar> ",
					base.Symbol,
					" ",
					this.fBar
				}));
			}
			if (this.NewBar != null)
			{
				this.NewBar(this, args);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000034B8 File Offset: 0x000024B8
		internal void SetNewBarOpen(BarEventArgs args)
		{
			this.fBar = args.Bar;
			if (Trace.IsLevelEnabled(TraceLevel.Verbose))
			{
				Trace.WriteLine(string.Concat(new object[]
				{
					"<Instrument.SetNewBarOpen> ",
					base.Symbol,
					" ",
					this.fBar
				}));
			}
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(this, args);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003526 File Offset: 0x00002526
		internal void SetNewMarketDepth(MarketDepthEventArgs args)
		{
			this.fMarketDepth = args.MarketDepth;
			if (this.NewMarketDepth != null)
			{
				this.NewMarketDepth(this, args);
			}
			this.fOrderBook.Add(args.MarketDepth);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000355A File Offset: 0x0000255A
		internal void SetNewFundamental(FundamentalEventArgs args)
		{
			this.fFundamental = args.Fundamental;
			if (this.NewFundamental != null)
			{
				this.NewFundamental(this, args);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000357D File Offset: 0x0000257D
		internal void SetNewCorporateAction(CorporateActionEventArgs args)
		{
			this.fCorporateAction = args.CorporateAction;
			if (this.NewCorporateAction != null)
			{
				this.NewCorporateAction(this, args);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000035A0 File Offset: 0x000025A0
		public void Add(string series, Trade trade)
		{
			DataManager.Add(this, series, trade);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000035AA File Offset: 0x000025AA
		public void Add(Trade trade)
		{
			DataManager.Add(this, trade);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000035B3 File Offset: 0x000025B3
		public void Add(string series, Quote quote)
		{
			DataManager.Add(this, series, quote);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000035BD File Offset: 0x000025BD
		public void Add(Quote quote)
		{
			DataManager.Add(this, quote);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000035C6 File Offset: 0x000025C6
		public void Add(string series, Bar bar)
		{
			DataManager.Add(this, series, bar);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000035D0 File Offset: 0x000025D0
		public void Add(Bar bar)
		{
			DataManager.Add(this, bar);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000035D9 File Offset: 0x000025D9
		public void Add(Daily daily)
		{
			DataManager.Add(this, daily);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000035E2 File Offset: 0x000025E2
		public void Add(string series, MarketDepth marketDepth)
		{
			DataManager.Add(this, series, marketDepth);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000035EC File Offset: 0x000025EC
		public void Add(MarketDepth marketDepth)
		{
			DataManager.Add(this, marketDepth);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000035F5 File Offset: 0x000025F5
		public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetTradeArray(this, series, datetime1, datetime2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003600 File Offset: 0x00002600
		public TradeArray GetTradeArray(DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetTradeArray(this, datetime1, datetime2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000360A File Offset: 0x0000260A
		public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetQuoteArray(this, series, datetime1, datetime2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003615 File Offset: 0x00002615
		public QuoteArray GetQuoteArray(DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetQuoteArray(this, datetime1, datetime2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000361F File Offset: 0x0000261F
		public MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetMarketDepthArray(this, series, datetime1, datetime2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000362A File Offset: 0x0000262A
		public MarketDepthArray GetMarketDepthArray(DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetMarketDepthArray(this, datetime1, datetime2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003634 File Offset: 0x00002634
		public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetBarSeries(this, series, datetime1, datetime2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000363F File Offset: 0x0000263F
		public BarSeries GetBarSeries(DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetBarSeries(this, datetime1, datetime2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003649 File Offset: 0x00002649
		public BarSeries GetBarSeries(DateTime datetime1, DateTime datetime2, BarType barType, long barSize)
		{
			return DataManager.GetBarSeries(this, datetime1, datetime2, barType, barSize);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003656 File Offset: 0x00002656
		public DailySeries GetDailySeries(DateTime datetime1, DateTime datetime2)
		{
			return DataManager.GetDailySeries(this, datetime1, datetime2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003660 File Offset: 0x00002660
		public DailySeries GetDailySeries()
		{
			return DataManager.GetDailySeries(this);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003668 File Offset: 0x00002668
		public IDataSeries GetDataSeries(string series)
		{
			return DataManager.GetDataSeries(this, series);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003671 File Offset: 0x00002671
		public IDataSeries GetDataSeries(DataManager.EDataSeries series)
		{
			return DataManager.GetDataSeries(this, series);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000367A File Offset: 0x0000267A
		public IDataSeries AddDataSeries(string series)
		{
			return DataManager.AddDataSeries(this, series);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003683 File Offset: 0x00002683
		public DataSeriesList GetDataSeries()
		{
			return DataManager.GetDataSeries(this);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000368B File Offset: 0x0000268B
		public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
		{
			DataManager.RequestMarketData(provider, this, mdType, seriesSuffix);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003696 File Offset: 0x00002696
		public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType)
		{
			this.RequestMarketData(provider, mdType, ".*");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000036A5 File Offset: 0x000026A5
		public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
		{
			DataManager.CancelMarketData(provider, this, mdType, seriesSuffix);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000036B0 File Offset: 0x000026B0
		public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType)
		{
			this.CancelMarketData(provider, mdType, ".*");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000036BF File Offset: 0x000026BF
		public bool IsSubscribed(IMarketDataProvider provider, MarketDataType mdType)
		{
			return DataManager.IsSubscribed(provider, this, mdType);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000036C9 File Offset: 0x000026C9
		public override string ToString()
		{
			return base.Symbol;
		}

		// Token: 0x04000012 RID: 18
		private const string DEFAULT_PRICE_DISPLAY = "F2";

		// Token: 0x04000013 RID: 19
		private Currency fCurrency;

		// Token: 0x04000014 RID: 20
		private Exchange fExchange;

		// Token: 0x04000015 RID: 21
		private LegList fLegs = new LegList();

		// Token: 0x04000016 RID: 22
		private UnderlyingList fUnderlyings = new UnderlyingList();

		// Token: 0x04000017 RID: 23
		private IPricer fPricer = new Pricer();

		// Token: 0x0400001F RID: 31
		private Quote fQuote = new Quote();

		// Token: 0x04000020 RID: 32
		private Trade fTrade = new Trade();

		// Token: 0x04000021 RID: 33
		private Bar fBar = new Bar();

		// Token: 0x04000022 RID: 34
		private MarketDepth fMarketDepth = new MarketDepth();

		// Token: 0x04000023 RID: 35
		private Fundamental fFundamental = new Fundamental();

		// Token: 0x04000024 RID: 36
		private CorporateAction fCorporateAction = new CorporateAction();

		// Token: 0x04000025 RID: 37
		private OrderBook fOrderBook = new OrderBook();

		// Token: 0x04000026 RID: 38
		private double fChange;
	}
}
