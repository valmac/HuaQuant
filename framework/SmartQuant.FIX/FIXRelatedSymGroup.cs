using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000088 RID: 136
	public class FIXRelatedSymGroup : FIXGroup, IFIXInstrument
	{
		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x0001CBA7 File Offset: 0x0001BBA7
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0001CBB1 File Offset: 0x0001BBB1
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0001CBBC File Offset: 0x0001BBBC
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0001CBC6 File Offset: 0x0001BBC6
		[FIXField("65", EFieldOption.Optional)]
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0001CBD1 File Offset: 0x0001BBD1
		// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0001CBDB File Offset: 0x0001BBDB
		[FIXField("48", EFieldOption.Optional)]
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

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0001CBE6 File Offset: 0x0001BBE6
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0001CBF0 File Offset: 0x0001BBF0
		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringValue(22);
			}
			set
			{
				this.SetStringValue(22, value);
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x0001CBFB File Offset: 0x0001BBFB
		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.fSecurityAltIDGroup.Count;
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0001CC08 File Offset: 0x0001BC08
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0001CC21 File Offset: 0x0001BC21
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.fGroups.Add(group);
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x0001CC3C File Offset: 0x0001BC3C
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0001CC44 File Offset: 0x0001BC44
		public FIXSecurityAltIDGroupList SecurityAltIDGroup
		{
			get
			{
				return this.fSecurityAltIDGroup;
			}
			set
			{
				this.fSecurityAltIDGroup = value;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0001CC4D File Offset: 0x0001BC4D
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0001CC5A File Offset: 0x0001BC5A
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

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0001CC68 File Offset: 0x0001BC68
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0001CC75 File Offset: 0x0001BC75
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringValue(461);
			}
			set
			{
				this.SetStringValue(461, value);
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0001CC83 File Offset: 0x0001BC83
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0001CC90 File Offset: 0x0001BC90
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringValue(167);
			}
			set
			{
				this.SetStringValue(167, value);
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0001CC9E File Offset: 0x0001BC9E
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0001CCAB File Offset: 0x0001BCAB
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringValue(762);
			}
			set
			{
				this.SetStringValue(762, value);
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0001CCB9 File Offset: 0x0001BCB9
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0001CCC6 File Offset: 0x0001BCC6
		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringValue(200);
			}
			set
			{
				this.SetStringValue(200, value);
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0001CCD4 File Offset: 0x0001BCD4
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0001CCE1 File Offset: 0x0001BCE1
		[FIXField("205", EFieldOption.Optional)]
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

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0001CCEF File Offset: 0x0001BCEF
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0001CCFC File Offset: 0x0001BCFC
		[FIXField("201", EFieldOption.Optional)]
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

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0001CD0A File Offset: 0x0001BD0A
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0001CD17 File Offset: 0x0001BD17
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

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0001CD25 File Offset: 0x0001BD25
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0001CD32 File Offset: 0x0001BD32
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0001CD40 File Offset: 0x0001BD40
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0001CD4D File Offset: 0x0001BD4D
		[FIXField("225", EFieldOption.Optional)]
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0001CD5B File Offset: 0x0001BD5B
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0001CD68 File Offset: 0x0001BD68
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0001CD76 File Offset: 0x0001BD76
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0001CD83 File Offset: 0x0001BD83
		[FIXField("226", EFieldOption.Optional)]
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0001CD91 File Offset: 0x0001BD91
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0001CD9E File Offset: 0x0001BD9E
		[FIXField("227", EFieldOption.Optional)]
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0001CDAC File Offset: 0x0001BDAC
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0001CDB9 File Offset: 0x0001BDB9
		[FIXField("228", EFieldOption.Optional)]
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0001CDC7 File Offset: 0x0001BDC7
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0001CDD4 File Offset: 0x0001BDD4
		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringValue(255);
			}
			set
			{
				this.SetStringValue(255, value);
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0001CDE2 File Offset: 0x0001BDE2
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0001CDEF File Offset: 0x0001BDEF
		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringValue(543);
			}
			set
			{
				this.SetStringValue(543, value);
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0001CDFD File Offset: 0x0001BDFD
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0001CE0A File Offset: 0x0001BE0A
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringValue(470);
			}
			set
			{
				this.SetStringValue(470, value);
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0001CE18 File Offset: 0x0001BE18
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0001CE25 File Offset: 0x0001BE25
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringValue(471);
			}
			set
			{
				this.SetStringValue(471, value);
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0001CE33 File Offset: 0x0001BE33
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0001CE40 File Offset: 0x0001BE40
		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringValue(472);
			}
			set
			{
				this.SetStringValue(472, value);
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0001CE4E File Offset: 0x0001BE4E
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0001CE5B File Offset: 0x0001BE5B
		[FIXField("240", EFieldOption.Optional)]
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0001CE69 File Offset: 0x0001BE69
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0001CE76 File Offset: 0x0001BE76
		[FIXField("202", EFieldOption.Optional)]
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0001CE84 File Offset: 0x0001BE84
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0001CE91 File Offset: 0x0001BE91
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

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0001CE9F File Offset: 0x0001BE9F
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0001CEAC File Offset: 0x0001BEAC
		[FIXField("206", EFieldOption.Optional)]
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

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0001CEBA File Offset: 0x0001BEBA
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0001CEC7 File Offset: 0x0001BEC7
		[FIXField("231", EFieldOption.Optional)]
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

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0001CED5 File Offset: 0x0001BED5
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0001CEE2 File Offset: 0x0001BEE2
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

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0001CEF0 File Offset: 0x0001BEF0
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0001CEFD File Offset: 0x0001BEFD
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringValue(207);
			}
			set
			{
				this.SetStringValue(207, value);
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0001CF0B File Offset: 0x0001BF0B
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0001CF15 File Offset: 0x0001BF15
		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringValue(106);
			}
			set
			{
				this.SetStringValue(106, value);
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0001CF20 File Offset: 0x0001BF20
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x0001CF2D File Offset: 0x0001BF2D
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

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0001CF3B File Offset: 0x0001BF3B
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x0001CF48 File Offset: 0x0001BF48
		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringValue(349);
			}
			set
			{
				this.SetStringValue(349, value);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0001CF56 File Offset: 0x0001BF56
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0001CF60 File Offset: 0x0001BF60
		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringValue(107);
			}
			set
			{
				this.SetStringValue(107, value);
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0001CF6B File Offset: 0x0001BF6B
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0001CF78 File Offset: 0x0001BF78
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

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0001CF86 File Offset: 0x0001BF86
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x0001CF93 File Offset: 0x0001BF93
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringValue(351);
			}
			set
			{
				this.SetStringValue(351, value);
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0001CFA1 File Offset: 0x0001BFA1
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0001CFAE File Offset: 0x0001BFAE
		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringValue(691);
			}
			set
			{
				this.SetStringValue(691, value);
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0001CFBC File Offset: 0x0001BFBC
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0001CFC9 File Offset: 0x0001BFC9
		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringValue(667);
			}
			set
			{
				this.SetStringValue(667, value);
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0001CFD7 File Offset: 0x0001BFD7
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0001CFE4 File Offset: 0x0001BFE4
		[FIXField("875", EFieldOption.Optional)]
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0001CFF2 File Offset: 0x0001BFF2
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0001CFFF File Offset: 0x0001BFFF
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringValue(876);
			}
			set
			{
				this.SetStringValue(876, value);
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0001D00D File Offset: 0x0001C00D
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0001D01A File Offset: 0x0001C01A
		[FIXField("864", EFieldOption.Optional)]
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

		// Token: 0x06001A9C RID: 6812 RVA: 0x0001D028 File Offset: 0x0001C028
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0001D046 File Offset: 0x0001C046
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0001D063 File Offset: 0x0001C063
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0001D070 File Offset: 0x0001C070
		[FIXField("873", EFieldOption.Optional)]
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

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0001D07E File Offset: 0x0001C07E
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0001D08B File Offset: 0x0001C08B
		[FIXField("874", EFieldOption.Optional)]
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

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0001D099 File Offset: 0x0001C099
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0001D0A6 File Offset: 0x0001C0A6
		[FIXField("668", EFieldOption.Optional)]
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

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0001D0B4 File Offset: 0x0001C0B4
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0001D0C1 File Offset: 0x0001C0C1
		[FIXField("869", EFieldOption.Optional)]
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0001D0CF File Offset: 0x0001C0CF
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0001D0DC File Offset: 0x0001C0DC
		[FIXField("870", EFieldOption.Optional)]
		public int NoInstrAttrib
		{
			get
			{
				return this.GetIntValue(870);
			}
			set
			{
				this.SetIntValue(870, value);
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0001D0EA File Offset: 0x0001C0EA
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0001D108 File Offset: 0x0001C108
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0001D125 File Offset: 0x0001C125
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0001D132 File Offset: 0x0001C132
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringValue(913);
			}
			set
			{
				this.SetStringValue(913, value);
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0001D140 File Offset: 0x0001C140
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0001D14D File Offset: 0x0001C14D
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringValue(914);
			}
			set
			{
				this.SetStringValue(914, value);
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0001D15B File Offset: 0x0001C15B
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0001D168 File Offset: 0x0001C168
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeValue(915);
			}
			set
			{
				this.SetDateTimeValue(915, value);
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0001D176 File Offset: 0x0001C176
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0001D183 File Offset: 0x0001C183
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleValue(918);
			}
			set
			{
				this.SetDoubleValue(918, value);
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0001D191 File Offset: 0x0001C191
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0001D19E File Offset: 0x0001C19E
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntValue(788);
			}
			set
			{
				this.SetIntValue(788, value);
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0001D1AC File Offset: 0x0001C1AC
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0001D1B9 File Offset: 0x0001C1B9
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeValue(916);
			}
			set
			{
				this.SetDateTimeValue(916, value);
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0001D1C7 File Offset: 0x0001C1C7
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0001D1D4 File Offset: 0x0001C1D4
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeValue(917);
			}
			set
			{
				this.SetDateTimeValue(917, value);
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0001D1E2 File Offset: 0x0001C1E2
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0001D1EF File Offset: 0x0001C1EF
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntValue(919);
			}
			set
			{
				this.SetIntValue(919, value);
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0001D1FD File Offset: 0x0001C1FD
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0001D20A File Offset: 0x0001C20A
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleValue(898);
			}
			set
			{
				this.SetDoubleValue(898, value);
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0001D218 File Offset: 0x0001C218
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0001D225 File Offset: 0x0001C225
		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntValue(711);
			}
			set
			{
				this.SetIntValue(711, value);
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0001D233 File Offset: 0x0001C233
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0001D23D File Offset: 0x0001C23D
		[FIXField("15", EFieldOption.Optional)]
		public string Currency
		{
			get
			{
				return this.GetStringValue(15);
			}
			set
			{
				this.SetStringValue(15, value);
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0001D248 File Offset: 0x0001C248
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0001D255 File Offset: 0x0001C255
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntValue(232);
			}
			set
			{
				this.SetIntValue(232, value);
			}
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0001D263 File Offset: 0x0001C263
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0001D281 File Offset: 0x0001C281
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0001D29E File Offset: 0x0001C29E
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0001D2AB File Offset: 0x0001C2AB
		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntValue(555);
			}
			set
			{
				this.SetIntValue(555, value);
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0001D2B9 File Offset: 0x0001C2B9
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0001D2D7 File Offset: 0x0001C2D7
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0001D2F4 File Offset: 0x0001C2F4
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0001D301 File Offset: 0x0001C301
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleValue(218);
			}
			set
			{
				this.SetDoubleValue(218, value);
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0001D30F File Offset: 0x0001C30F
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0001D31C File Offset: 0x0001C31C
		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleValue(220);
			}
			set
			{
				this.SetDoubleValue(220, value);
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0001D32A File Offset: 0x0001C32A
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0001D337 File Offset: 0x0001C337
		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringValue(221);
			}
			set
			{
				this.SetStringValue(221, value);
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0001D345 File Offset: 0x0001C345
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0001D352 File Offset: 0x0001C352
		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringValue(222);
			}
			set
			{
				this.SetStringValue(222, value);
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0001D360 File Offset: 0x0001C360
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0001D36D File Offset: 0x0001C36D
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleValue(662);
			}
			set
			{
				this.SetDoubleValue(662, value);
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0001D37B File Offset: 0x0001C37B
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0001D388 File Offset: 0x0001C388
		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntValue(663);
			}
			set
			{
				this.SetIntValue(663, value);
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0001D396 File Offset: 0x0001C396
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0001D3A3 File Offset: 0x0001C3A3
		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringValue(699);
			}
			set
			{
				this.SetStringValue(699, value);
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0001D3B1 File Offset: 0x0001C3B1
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0001D3BE File Offset: 0x0001C3BE
		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringValue(761);
			}
			set
			{
				this.SetStringValue(761, value);
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0001D3CC File Offset: 0x0001C3CC
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0001D3D9 File Offset: 0x0001C3D9
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringValue(235);
			}
			set
			{
				this.SetStringValue(235, value);
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0001D3E7 File Offset: 0x0001C3E7
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0001D3F4 File Offset: 0x0001C3F4
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleValue(236);
			}
			set
			{
				this.SetDoubleValue(236, value);
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0001D402 File Offset: 0x0001C402
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0001D40F File Offset: 0x0001C40F
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeValue(701);
			}
			set
			{
				this.SetDateTimeValue(701, value);
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0001D41D File Offset: 0x0001C41D
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0001D42A File Offset: 0x0001C42A
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeValue(696);
			}
			set
			{
				this.SetDateTimeValue(696, value);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0001D438 File Offset: 0x0001C438
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0001D445 File Offset: 0x0001C445
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleValue(697);
			}
			set
			{
				this.SetDoubleValue(697, value);
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0001D453 File Offset: 0x0001C453
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0001D460 File Offset: 0x0001C460
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntValue(698);
			}
			set
			{
				this.SetIntValue(698, value);
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0001D46E File Offset: 0x0001C46E
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0001D47B File Offset: 0x0001C47B
		[FIXField("561", EFieldOption.Optional)]
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0001D489 File Offset: 0x0001C489
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0001D496 File Offset: 0x0001C496
		[FIXField("562", EFieldOption.Optional)]
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

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0001D4A4 File Offset: 0x0001C4A4
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0001D4B1 File Offset: 0x0001C4B1
		[FIXField("336", EFieldOption.Optional)]
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

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x0001D4BF File Offset: 0x0001C4BF
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x0001D4CC File Offset: 0x0001C4CC
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

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0001D4DA File Offset: 0x0001C4DA
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0001D4E7 File Offset: 0x0001C4E7
		[FIXField("827", EFieldOption.Optional)]
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0001D4F5 File Offset: 0x0001C4F5
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0001D4FF File Offset: 0x0001C4FF
		[FIXField("58", EFieldOption.Optional)]
		public string Text
		{
			get
			{
				return this.GetStringValue(58);
			}
			set
			{
				this.SetStringValue(58, value);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0001D50A File Offset: 0x0001C50A
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0001D517 File Offset: 0x0001C517
		[FIXField("354", EFieldOption.Optional)]
		public int EncodedTextLen
		{
			get
			{
				return this.GetIntValue(354);
			}
			set
			{
				this.SetIntValue(354, value);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x0001D525 File Offset: 0x0001C525
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0001D532 File Offset: 0x0001C532
		[FIXField("355", EFieldOption.Optional)]
		public string EncodedText
		{
			get
			{
				return this.GetStringValue(355);
			}
			set
			{
				this.SetStringValue(355, value);
			}
		}

		// Token: 0x040002B5 RID: 693
		protected FIXSecurityAltIDGroupList fSecurityAltIDGroup = new FIXSecurityAltIDGroupList();

		// Token: 0x040002B6 RID: 694
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040002B7 RID: 695
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x040002B8 RID: 696
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x040002B9 RID: 697
		private ArrayList fLegsGroup = new ArrayList();
	}
}
