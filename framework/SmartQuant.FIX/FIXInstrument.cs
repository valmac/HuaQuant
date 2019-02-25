using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.FIX.Design;

namespace SmartQuant.FIX
{
	// Token: 0x0200004B RID: 75
	public class FIXInstrument : FIXGroup, IFIXInstrument
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00011FD0 File Offset: 0x00010FD0
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00011FDA File Offset: 0x00010FDA
		[ReadOnly(true)]
		[Category("Appearance")]
		[Description("Ticker symbol. Common, human understood representation of the security. SecurityID (48) value can be specified if no symbol exists (e.g. non-exchange traded Collective Investment Vehicles)")]
		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringValue(55);
			}
			set
			{
				this.SetStringValue(55, value);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00011FE5 File Offset: 0x00010FE5
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00011FEF File Offset: 0x00010FEF
		[Category("Appearance")]
		[FIXField("65", EFieldOption.Optional)]
		[Description("Additional information about the security (e.g. preferred, warrants, etc.). Note also see SecurityType (167)")]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringValue(65);
			}
			set
			{
				this.SetStringValue(65, value);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00011FFA File Offset: 0x00010FFA
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00012004 File Offset: 0x00011004
		[FIXField("48", EFieldOption.Optional)]
		[Category("Appearance")]
		[Description("Security identifier value of SecurityIDSource (22) type (e.g. CUSIP, SEDOL, ISIN, etc).  Requires SecurityIDSource.")]
		public string SecurityID
		{
			get
			{
				return this.GetStringValue(48);
			}
			set
			{
				this.SetStringValue(48, value);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0001200F File Offset: 0x0001100F
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00012019 File Offset: 0x00011019
		[FIXField("22", EFieldOption.Optional)]
		[Category("Appearance")]
		[Description("Identifies class or source of the SecurityID (48) value.  Required if SecurityID is specified.")]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringValue(22);
			}
			set
			{
				this.AddStringField(22, value);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00012024 File Offset: 0x00011024
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00012031 File Offset: 0x00011031
		[FIXField("454", EFieldOption.Optional)]
		[Browsable(false)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntValue(454);
			}
			set
			{
				this.SetIntValue(454, value);
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0001203F File Offset: 0x0001103F
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00012058 File Offset: 0x00011058
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(string source)
		{
			foreach (object obj in this.fSecurityAltIDGroup)
			{
				FIXSecurityAltIDGroup fixsecurityAltIDGroup = (FIXSecurityAltIDGroup)obj;
				if (fixsecurityAltIDGroup.SecurityAltIDSource == source)
				{
					return fixsecurityAltIDGroup;
				}
			}
			return null;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000120C0 File Offset: 0x000110C0
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.fGroups.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000120E9 File Offset: 0x000110E9
		[Category("Appearance")]
		[Editor(typeof(FIXSecurityAltIDGroupListEditor), typeof(UITypeEditor))]
		[Description("")]
		public FIXSecurityAltIDGroupList SecurityAltIDGroup
		{
			get
			{
				return this.fSecurityAltIDGroup;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000120F1 File Offset: 0x000110F1
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x000120FE File Offset: 0x000110FE
		[Category("Appearance")]
		[Description("Indicates the type of product the security is associated with. See also the CFICode (461) and SecurityType (167) fields.")]
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntValue(460);
			}
			set
			{
				this.SetIntValue(460, value);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0001210C File Offset: 0x0001110C
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00012119 File Offset: 0x00011119
		[FIXField("461", EFieldOption.Optional)]
		[Description("Indicates the type of security using  ISO 10962 standard, Classification of Financial Instruments (CFI code) values.  ISO 10962 is maintained by ANNA (Association of National Numbering Agencies) acting as Registration Authority. See also the Product (460) and SecurityType (167) fields. It is recommended that CFICode be used instead of SecurityType (167) for non-Fixed Income instruments.")]
		[Category("Appearance")]
		public string CFICode
		{
			get
			{
				return this.GetStringValue(461);
			}
			set
			{
				this.AddStringField(461, value);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00012127 File Offset: 0x00011127
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00012134 File Offset: 0x00011134
		[Description("Indicates type of security.")]
		[FIXField("167", EFieldOption.Optional)]
		[Category("Appearance")]
		public string SecurityType
		{
			get
			{
				return this.GetStringValue(167);
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00012142 File Offset: 0x00011142
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0001214F File Offset: 0x0001114F
		[Category("Appearance")]
		[FIXField("762", EFieldOption.Optional)]
		[Description("Sub-type qualification/identification of the SecurityType (e.g. for SecurityType=REPO).")]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringValue(762);
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0001215D File Offset: 0x0001115D
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0001216A File Offset: 0x0001116A
		[Category("Derivative")]
		[FIXField("200", EFieldOption.Optional)]
		[Description("Can be used with standardized derivatives vs. the MaturityDate (541) field. Month and Year of the maturity (used for standardized futures and options).")]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringValue(200);
			}
			set
			{
				this.AddStringField(200, value);
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00012178 File Offset: 0x00011178
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00012185 File Offset: 0x00011185
		[FIXField("205", EFieldOption.Optional)]
		[Category("Derivative")]
		[Description("Day of month used in conjunction with MaturityMonthYear to specify the maturity date for SecurityType=FUT or SecurityType=OPT.")]
		public string MaturityDay
		{
			get
			{
				return this.GetStringValue(205);
			}
			set
			{
				this.SetStringValue(205, value);
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00012193 File Offset: 0x00011193
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x000121A0 File Offset: 0x000111A0
		[Description("Date of maturity.")]
		[Category("Derivative")]
		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeValue(541);
			}
			set
			{
				this.SetDateTimeValue(541, value);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000121AE File Offset: 0x000111AE
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x000121BB File Offset: 0x000111BB
		[Category("Fixed income")]
		[Description("Date interest is to be paid.  Used in identifying Corporate Bond issues.")]
		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeValue(224);
			}
			set
			{
				this.SetDateTimeValue(224, value);
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000121C9 File Offset: 0x000111C9
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x000121D6 File Offset: 0x000111D6
		[Description("The date on which a bond or stock offering is issued. It may or may not be the same as the effective date (Dated Date) or the date on which interest begins to accrue (Interest Accrual Date)")]
		[FIXField("225", EFieldOption.Optional)]
		[Category("Issue")]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeValue(225);
			}
			set
			{
				this.SetDateTimeValue(225, value);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000121E4 File Offset: 0x000111E4
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x000121F1 File Offset: 0x000111F1
		[Description("Identifies the collateral used in the transaction.")]
		[Category("Repo")]
		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntValue(239);
			}
			set
			{
				this.SetIntValue(239, value);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000121FF File Offset: 0x000111FF
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x0001220C File Offset: 0x0001120C
		[FIXField("226", EFieldOption.Optional)]
		[Description("Number of business days before repurchase of a repo.")]
		[Category("Repo")]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntValue(226);
			}
			set
			{
				this.SetIntValue(226, value);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0001221A File Offset: 0x0001121A
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00012227 File Offset: 0x00011227
		[Category("Repo")]
		[FIXField("227", EFieldOption.Optional)]
		[Description("Percent of par at which a Repo will be repaid. Represented as a percent, e.g. .9525 represents 95-1/4 percent of par.")]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleValue(227);
			}
			set
			{
				this.SetDoubleValue(227, value);
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00012235 File Offset: 0x00011235
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00012242 File Offset: 0x00011242
		[FIXField("228", EFieldOption.Optional)]
		[Category("Derivative")]
		[Description("Contract Value Factor by which price must be adjusted to determine the true nominal value of one futures/options contract. (Qty * Price) * Factor = Nominal Value")]
		public double Factor
		{
			get
			{
				return this.GetDoubleValue(228);
			}
			set
			{
				this.SetDoubleValue(228, value);
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00012250 File Offset: 0x00011250
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0001225D File Offset: 0x0001125D
		[Category("Issue")]
		[FIXField("255", EFieldOption.Optional)]
		[Description("An evaluation of a company's ability to repay obligations or its likelihood of not defaulting. These evaluation are provided by Credit Rating Agencies, i.e. S&P, Moody's.")]
		public string CreditRating
		{
			get
			{
				return this.GetStringValue(255);
			}
			set
			{
				this.AddStringField(255, value);
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0001226B File Offset: 0x0001126B
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00012278 File Offset: 0x00011278
		[FIXField("543", EFieldOption.Optional)]
		[Category("Issue")]
		[Description("The location at which records of ownership are maintained for this instrument, and at which ownership changes must be recorded.")]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringValue(543);
			}
			set
			{
				this.AddStringField(543, value);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00012286 File Offset: 0x00011286
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x00012293 File Offset: 0x00011293
		[Description("ISO Country code of instrument issue (e.g. the country portion typically used in ISIN).  Can be used in conjunction with non-ISIN SecurityID (48) (e.g. CUSIP for Municipal Bonds without ISIN) to provide uniqueness.")]
		[Category("Issue")]
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringValue(470);
			}
			set
			{
				this.AddStringField(470, value);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000122A1 File Offset: 0x000112A1
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000122AE File Offset: 0x000112AE
		[Category("Issue")]
		[Description("A two-character state or province abbreviation.")]
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringValue(471);
			}
			set
			{
				this.AddStringField(471, value);
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x000122BC File Offset: 0x000112BC
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000122C9 File Offset: 0x000112C9
		[FIXField("472", EFieldOption.Optional)]
		[Description("Identifies the locale. For Municipal Security Issuers other than state or province.")]
		[Category("Issue")]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringValue(472);
			}
			set
			{
				this.AddStringField(472, value);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x000122D7 File Offset: 0x000112D7
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x000122E4 File Offset: 0x000112E4
		[FIXField("240", EFieldOption.Optional)]
		[Description("Return of investor's principal in a security. Bond redemption can occur before maturity date.")]
		[Category("Fixed income")]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeValue(240);
			}
			set
			{
				this.SetDateTimeValue(240, value);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x000122F2 File Offset: 0x000112F2
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x000122FF File Offset: 0x000112FF
		[Description("Strike Price for an Option.")]
		[FIXField("202", EFieldOption.Optional)]
		[Category("Derivative")]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleValue(202);
			}
			set
			{
				this.SetDoubleValue(202, value);
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0001230D File Offset: 0x0001130D
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x0001231A File Offset: 0x0001131A
		[Category("Derivative")]
		[Description("Currency in which the StrikePrice is denominated.")]
		[FIXField("947", EFieldOption.Optional)]
		public string StrikeCurrency
		{
			get
			{
				return this.GetStringValue(947);
			}
			set
			{
				this.SetStringValue(947, value);
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00012328 File Offset: 0x00011328
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x00012335 File Offset: 0x00011335
		[Category("Derivative")]
		[FIXField("206", EFieldOption.Optional)]
		[Description("Can be used for SecurityType (167) =OPT to identify a particular security.")]
		public char OptAttribute
		{
			get
			{
				return this.GetCharValue(206);
			}
			set
			{
				this.SetCharValue(206, value);
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00012343 File Offset: 0x00011343
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x00012350 File Offset: 0x00011350
		[FIXField("201", EFieldOption.Optional)]
		[Category("Derivative")]
		[Description("Indicates whether an Option is for a put or call.")]
		public int PutOrCall
		{
			get
			{
				return this.GetIntValue(201);
			}
			set
			{
				this.SetIntValue(201, value);
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0001235E File Offset: 0x0001135E
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x0001236B File Offset: 0x0001136B
		[FIXField("231", EFieldOption.Optional)]
		[Category("Derivative")]
		[Description("Specifies the ratio or multiply factor to convert from 'nominal' units (e.g. contracts) to total units (e.g. shares) (e.g. 1.0, 100, 1000, etc). Applicable For Fixed Income, Convertible Bonds, Derivatives, etc.")]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleValue(231);
			}
			set
			{
				this.SetDoubleValue(231, value);
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00012379 File Offset: 0x00011379
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00012386 File Offset: 0x00011386
		[Category("Fixed income")]
		[Description("The rate of interest that, when multiplied by the principal, par value, or face value of a bond, provides the currency amount of the periodic interest payment.  The coupon is always cited, along with maturity, in any quotation of a bond's price.")]
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleValue(223);
			}
			set
			{
				this.SetDoubleValue(223, value);
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00012394 File Offset: 0x00011394
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x000123A1 File Offset: 0x000113A1
		[Description("Market used to help identify a security.")]
		[Category("Appearance")]
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringValue(207);
			}
			set
			{
				this.AddStringField(207, value);
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000123AF File Offset: 0x000113AF
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x000123B9 File Offset: 0x000113B9
		[FIXField("106", EFieldOption.Optional)]
		[Description("Name of security issuer (e.g. International Business Machines, GNMA).")]
		[Category("Issue")]
		public string Issuer
		{
			get
			{
				return this.GetStringValue(106);
			}
			set
			{
				this.AddStringField(106, value);
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x000123C4 File Offset: 0x000113C4
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x000123D1 File Offset: 0x000113D1
		[Browsable(false)]
		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntValue(348);
			}
			set
			{
				this.SetIntValue(348, value);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x000123DF File Offset: 0x000113DF
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000123EC File Offset: 0x000113EC
		[FIXField("349", EFieldOption.Optional)]
		[Browsable(false)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringValue(349);
			}
			set
			{
				this.AddStringField(349, value);
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x000123FA File Offset: 0x000113FA
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00012404 File Offset: 0x00011404
		[Description("Security description.")]
		[FIXField("107", EFieldOption.Optional)]
		[Category("Appearance")]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringValue(107);
			}
			set
			{
				this.AddStringField(107, value);
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0001240F File Offset: 0x0001140F
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x0001241C File Offset: 0x0001141C
		[Browsable(false)]
		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntValue(350);
			}
			set
			{
				this.SetIntValue(350, value);
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0001242A File Offset: 0x0001142A
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00012437 File Offset: 0x00011437
		[Browsable(false)]
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringValue(351);
			}
			set
			{
				this.AddStringField(351, value);
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00012445 File Offset: 0x00011445
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00012452 File Offset: 0x00011452
		[FIXField("691", EFieldOption.Optional)]
		[Category("Fixed income")]
		[Description("For Fixed Income, identifies MBS/ABS pool.")]
		public string Pool
		{
			get
			{
				return this.GetStringValue(691);
			}
			set
			{
				this.AddStringField(691, value);
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00012460 File Offset: 0x00011460
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x0001246D File Offset: 0x0001146D
		[Category("Fixed income")]
		[FIXField("667", EFieldOption.Optional)]
		[Description("Specifies when the contract (i.e. MBS/TBA) will settle.")]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringValue(667);
			}
			set
			{
				this.AddStringField(667, value);
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0001247B File Offset: 0x0001147B
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00012488 File Offset: 0x00011488
		[Description("The program under which a commercial paper is issued")]
		[FIXField("875", EFieldOption.Optional)]
		[Category("Issue")]
		public int CPProgram
		{
			get
			{
				return this.GetIntValue(875);
			}
			set
			{
				this.SetIntValue(875, value);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00012496 File Offset: 0x00011496
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x000124A3 File Offset: 0x000114A3
		[Category("Issue")]
		[Description("The registration type of a commercial paper issuance")]
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringValue(876);
			}
			set
			{
				this.AddStringField(876, value);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x000124B1 File Offset: 0x000114B1
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x000124BE File Offset: 0x000114BE
		[FIXField("864", EFieldOption.Optional)]
		[Browsable(false)]
		public int NoEvents
		{
			get
			{
				return this.GetIntValue(864);
			}
			set
			{
				this.SetIntValue(864, value);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000124CC File Offset: 0x000114CC
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000124EA File Offset: 0x000114EA
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00012507 File Offset: 0x00011507
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00012514 File Offset: 0x00011514
		[FIXField("873", EFieldOption.Optional)]
		[Description("The effective date of a new securities issue determined by its underwriters. Often but not always the same as the Issue Date and the Interest Accrual Date")]
		[Category("Issue")]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeValue(873);
			}
			set
			{
				this.SetDateTimeValue(873, value);
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00012522 File Offset: 0x00011522
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x0001252F File Offset: 0x0001152F
		[FIXField("874", EFieldOption.Optional)]
		[Description("The start date used for calculating accrued interest on debt instruments which are being sold between interest payment dates. Often but not always the same as the Issue Date and the Dated Date")]
		[Category("Fixed income")]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeValue(874);
			}
			set
			{
				this.SetDateTimeValue(874, value);
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0001253D File Offset: 0x0001153D
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x0001254A File Offset: 0x0001154A
		[Description("Tick size")]
		[Category("Trade")]
		public double TickSize
		{
			get
			{
				return this.GetDoubleValue(10400);
			}
			set
			{
				this.SetDoubleValue(10400, value);
			}
		}

		// Token: 0x04000183 RID: 387
		protected FIXSecurityAltIDGroupList fSecurityAltIDGroup = new FIXSecurityAltIDGroupList();

		// Token: 0x04000184 RID: 388
		private ArrayList fEventsGroup = new ArrayList();
	}
}
