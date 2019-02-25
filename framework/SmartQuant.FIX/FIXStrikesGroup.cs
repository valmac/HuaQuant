using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200011B RID: 283
	public class FIXStrikesGroup : FIXGroup
	{
		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x00038B9F File Offset: 0x00037B9F
		// (set) Token: 0x060035C2 RID: 13762 RVA: 0x00038BAE File Offset: 0x00037BAE
		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringField(55).Value;
			}
			set
			{
				this.AddStringField(55, value);
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x00038BB9 File Offset: 0x00037BB9
		// (set) Token: 0x060035C4 RID: 13764 RVA: 0x00038BC8 File Offset: 0x00037BC8
		[FIXField("65", EFieldOption.Optional)]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringField(65).Value;
			}
			set
			{
				this.AddStringField(65, value);
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x00038BD3 File Offset: 0x00037BD3
		// (set) Token: 0x060035C6 RID: 13766 RVA: 0x00038BE2 File Offset: 0x00037BE2
		[FIXField("48", EFieldOption.Optional)]
		public string SecurityID
		{
			get
			{
				return this.GetStringField(48).Value;
			}
			set
			{
				this.AddStringField(48, value);
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x00038BED File Offset: 0x00037BED
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x00038BFC File Offset: 0x00037BFC
		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringField(22).Value;
			}
			set
			{
				this.AddStringField(22, value);
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x00038C07 File Offset: 0x00037C07
		// (set) Token: 0x060035CA RID: 13770 RVA: 0x00038C19 File Offset: 0x00037C19
		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntField(454).Value;
			}
			set
			{
				this.AddIntField(454, value);
			}
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00038C27 File Offset: 0x00037C27
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00038C45 File Offset: 0x00037C45
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x00038C62 File Offset: 0x00037C62
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x00038C74 File Offset: 0x00037C74
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntField(460).Value;
			}
			set
			{
				this.AddIntField(460, value);
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00038C82 File Offset: 0x00037C82
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x00038C94 File Offset: 0x00037C94
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringField(461).Value;
			}
			set
			{
				this.AddStringField(461, value);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x00038CA2 File Offset: 0x00037CA2
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x00038CB4 File Offset: 0x00037CB4
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringField(167).Value;
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x00038CC2 File Offset: 0x00037CC2
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x00038CD4 File Offset: 0x00037CD4
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringField(762).Value;
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x00038CE2 File Offset: 0x00037CE2
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x00038CF4 File Offset: 0x00037CF4
		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringField(200).Value;
			}
			set
			{
				this.AddStringField(200, value);
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x00038D02 File Offset: 0x00037D02
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x00038D14 File Offset: 0x00037D14
		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeField(541).Value;
			}
			set
			{
				this.AddDateTimeField(541, value);
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x00038D22 File Offset: 0x00037D22
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x00038D34 File Offset: 0x00037D34
		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(224).Value;
			}
			set
			{
				this.AddDateTimeField(224, value);
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x00038D42 File Offset: 0x00037D42
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x00038D54 File Offset: 0x00037D54
		[FIXField("225", EFieldOption.Optional)]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeField(225).Value;
			}
			set
			{
				this.AddDateTimeField(225, value);
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x00038D62 File Offset: 0x00037D62
		// (set) Token: 0x060035DE RID: 13790 RVA: 0x00038D74 File Offset: 0x00037D74
		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(239).Value;
			}
			set
			{
				this.AddIntField(239, value);
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x00038D82 File Offset: 0x00037D82
		// (set) Token: 0x060035E0 RID: 13792 RVA: 0x00038D94 File Offset: 0x00037D94
		[FIXField("226", EFieldOption.Optional)]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntField(226).Value;
			}
			set
			{
				this.AddIntField(226, value);
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x00038DA2 File Offset: 0x00037DA2
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x00038DB4 File Offset: 0x00037DB4
		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleField(227).Value;
			}
			set
			{
				this.AddDoubleField(227, value);
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x00038DC2 File Offset: 0x00037DC2
		// (set) Token: 0x060035E4 RID: 13796 RVA: 0x00038DD4 File Offset: 0x00037DD4
		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleField(228).Value;
			}
			set
			{
				this.AddDoubleField(228, value);
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x00038DE2 File Offset: 0x00037DE2
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x00038DF4 File Offset: 0x00037DF4
		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringField(255).Value;
			}
			set
			{
				this.AddStringField(255, value);
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x00038E02 File Offset: 0x00037E02
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x00038E14 File Offset: 0x00037E14
		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringField(543).Value;
			}
			set
			{
				this.AddStringField(543, value);
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x00038E22 File Offset: 0x00037E22
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x00038E34 File Offset: 0x00037E34
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringField(470).Value;
			}
			set
			{
				this.AddStringField(470, value);
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x00038E42 File Offset: 0x00037E42
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x00038E54 File Offset: 0x00037E54
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(471).Value;
			}
			set
			{
				this.AddStringField(471, value);
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x00038E62 File Offset: 0x00037E62
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x00038E74 File Offset: 0x00037E74
		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringField(472).Value;
			}
			set
			{
				this.AddStringField(472, value);
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x00038E82 File Offset: 0x00037E82
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x00038E94 File Offset: 0x00037E94
		[FIXField("240", EFieldOption.Optional)]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeField(240).Value;
			}
			set
			{
				this.AddDateTimeField(240, value);
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x00038EA2 File Offset: 0x00037EA2
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x00038EB4 File Offset: 0x00037EB4
		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleField(202).Value;
			}
			set
			{
				this.AddDoubleField(202, value);
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x00038EC2 File Offset: 0x00037EC2
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x00038ED4 File Offset: 0x00037ED4
		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleField(947).Value;
			}
			set
			{
				this.AddDoubleField(947, value);
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x00038EE2 File Offset: 0x00037EE2
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x00038EF4 File Offset: 0x00037EF4
		[FIXField("206", EFieldOption.Optional)]
		public char OptAttribute
		{
			get
			{
				return this.GetCharField(206).Value;
			}
			set
			{
				this.AddCharField(206, value);
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x00038F02 File Offset: 0x00037F02
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x00038F14 File Offset: 0x00037F14
		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleField(231).Value;
			}
			set
			{
				this.AddDoubleField(231, value);
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x00038F22 File Offset: 0x00037F22
		// (set) Token: 0x060035FA RID: 13818 RVA: 0x00038F34 File Offset: 0x00037F34
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleField(223).Value;
			}
			set
			{
				this.AddDoubleField(223, value);
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x00038F42 File Offset: 0x00037F42
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x00038F54 File Offset: 0x00037F54
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringField(207).Value;
			}
			set
			{
				this.AddStringField(207, value);
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x00038F62 File Offset: 0x00037F62
		// (set) Token: 0x060035FE RID: 13822 RVA: 0x00038F71 File Offset: 0x00037F71
		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringField(106).Value;
			}
			set
			{
				this.AddStringField(106, value);
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x00038F7C File Offset: 0x00037F7C
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x00038F8E File Offset: 0x00037F8E
		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntField(348).Value;
			}
			set
			{
				this.AddIntField(348, value);
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x00038F9C File Offset: 0x00037F9C
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x00038FAE File Offset: 0x00037FAE
		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringField(349).Value;
			}
			set
			{
				this.AddStringField(349, value);
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x00038FBC File Offset: 0x00037FBC
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x00038FCB File Offset: 0x00037FCB
		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringField(107).Value;
			}
			set
			{
				this.AddStringField(107, value);
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x00038FD6 File Offset: 0x00037FD6
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x00038FE8 File Offset: 0x00037FE8
		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntField(350).Value;
			}
			set
			{
				this.AddIntField(350, value);
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x00038FF6 File Offset: 0x00037FF6
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x00039008 File Offset: 0x00038008
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringField(351).Value;
			}
			set
			{
				this.AddStringField(351, value);
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x00039016 File Offset: 0x00038016
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x00039028 File Offset: 0x00038028
		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringField(691).Value;
			}
			set
			{
				this.AddStringField(691, value);
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x00039036 File Offset: 0x00038036
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x00039048 File Offset: 0x00038048
		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringField(667).Value;
			}
			set
			{
				this.AddStringField(667, value);
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x00039056 File Offset: 0x00038056
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x00039068 File Offset: 0x00038068
		[FIXField("875", EFieldOption.Optional)]
		public int CPProgram
		{
			get
			{
				return this.GetIntField(875).Value;
			}
			set
			{
				this.AddIntField(875, value);
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x00039076 File Offset: 0x00038076
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x00039088 File Offset: 0x00038088
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringField(876).Value;
			}
			set
			{
				this.AddStringField(876, value);
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x00039096 File Offset: 0x00038096
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x000390A8 File Offset: 0x000380A8
		[FIXField("864", EFieldOption.Optional)]
		public int NoEvents
		{
			get
			{
				return this.GetIntField(864).Value;
			}
			set
			{
				this.AddIntField(864, value);
			}
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x000390B6 File Offset: 0x000380B6
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x000390D4 File Offset: 0x000380D4
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x000390F1 File Offset: 0x000380F1
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x00039103 File Offset: 0x00038103
		[FIXField("873", EFieldOption.Optional)]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeField(873).Value;
			}
			set
			{
				this.AddDateTimeField(873, value);
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x00039111 File Offset: 0x00038111
		// (set) Token: 0x06003618 RID: 13848 RVA: 0x00039123 File Offset: 0x00038123
		[FIXField("874", EFieldOption.Optional)]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeField(874).Value;
			}
			set
			{
				this.AddDateTimeField(874, value);
			}
		}

		// Token: 0x04000505 RID: 1285
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000506 RID: 1286
		private ArrayList fEventsGroup = new ArrayList();
	}
}
