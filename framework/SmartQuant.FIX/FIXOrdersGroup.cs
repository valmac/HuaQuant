using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200013E RID: 318
	public class FIXOrdersGroup : FIXGroup
	{
		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x000409A0 File Offset: 0x0003F9A0
		// (set) Token: 0x06003D4E RID: 15694 RVA: 0x000409AF File Offset: 0x0003F9AF
		[FIXField("11", EFieldOption.Required)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringField(11).Value;
			}
			set
			{
				this.AddStringField(11, value);
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x000409BA File Offset: 0x0003F9BA
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x000409CC File Offset: 0x0003F9CC
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringField(526).Value;
			}
			set
			{
				this.AddStringField(526, value);
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x000409DA File Offset: 0x0003F9DA
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x000409E9 File Offset: 0x0003F9E9
		[FIXField("67", EFieldOption.Required)]
		public int ListSeqNo
		{
			get
			{
				return this.GetIntField(67).Value;
			}
			set
			{
				this.AddIntField(67, value);
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x000409F4 File Offset: 0x0003F9F4
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x00040A06 File Offset: 0x0003FA06
		[FIXField("583", EFieldOption.Optional)]
		public string ClOrdLinkID
		{
			get
			{
				return this.GetStringField(583).Value;
			}
			set
			{
				this.AddStringField(583, value);
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x00040A14 File Offset: 0x0003FA14
		// (set) Token: 0x06003D56 RID: 15702 RVA: 0x00040A26 File Offset: 0x0003FA26
		[FIXField("160", EFieldOption.Optional)]
		public char SettlInstMode
		{
			get
			{
				return this.GetCharField(160).Value;
			}
			set
			{
				this.AddCharField(160, value);
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x00040A34 File Offset: 0x0003FA34
		// (set) Token: 0x06003D58 RID: 15704 RVA: 0x00040A46 File Offset: 0x0003FA46
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntField(453).Value;
			}
			set
			{
				this.AddIntField(453, value);
			}
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00040A54 File Offset: 0x0003FA54
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00040A72 File Offset: 0x0003FA72
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00040A8F File Offset: 0x0003FA8F
		// (set) Token: 0x06003D5C RID: 15708 RVA: 0x00040AA1 File Offset: 0x0003FAA1
		[FIXField("229", EFieldOption.Optional)]
		public DateTime TradeOriginationDate
		{
			get
			{
				return this.GetDateTimeField(229).Value;
			}
			set
			{
				this.AddDateTimeField(229, value);
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x00040AAF File Offset: 0x0003FAAF
		// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00040ABE File Offset: 0x0003FABE
		[FIXField("75", EFieldOption.Optional)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeField(75).Value;
			}
			set
			{
				this.AddDateTimeField(75, value);
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00040AC9 File Offset: 0x0003FAC9
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00040AD7 File Offset: 0x0003FAD7
		[FIXField("1", EFieldOption.Optional)]
		public string Account
		{
			get
			{
				return this.GetStringField(1).Value;
			}
			set
			{
				this.AddStringField(1, value);
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x00040AE1 File Offset: 0x0003FAE1
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00040AF3 File Offset: 0x0003FAF3
		[FIXField("660", EFieldOption.Optional)]
		public int AcctIDSource
		{
			get
			{
				return this.GetIntField(660).Value;
			}
			set
			{
				this.AddIntField(660, value);
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00040B01 File Offset: 0x0003FB01
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00040B13 File Offset: 0x0003FB13
		[FIXField("581", EFieldOption.Optional)]
		public int AccountType
		{
			get
			{
				return this.GetIntField(581).Value;
			}
			set
			{
				this.AddIntField(581, value);
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00040B21 File Offset: 0x0003FB21
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00040B33 File Offset: 0x0003FB33
		[FIXField("589", EFieldOption.Optional)]
		public char DayBookingInst
		{
			get
			{
				return this.GetCharField(589).Value;
			}
			set
			{
				this.AddCharField(589, value);
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x00040B41 File Offset: 0x0003FB41
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x00040B53 File Offset: 0x0003FB53
		[FIXField("590", EFieldOption.Optional)]
		public char BookingUnit
		{
			get
			{
				return this.GetCharField(590).Value;
			}
			set
			{
				this.AddCharField(590, value);
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x00040B61 File Offset: 0x0003FB61
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x00040B70 File Offset: 0x0003FB70
		[FIXField("70", EFieldOption.Optional)]
		public string AllocID
		{
			get
			{
				return this.GetStringField(70).Value;
			}
			set
			{
				this.AddStringField(70, value);
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00040B7B File Offset: 0x0003FB7B
		// (set) Token: 0x06003D6C RID: 15724 RVA: 0x00040B8D File Offset: 0x0003FB8D
		[FIXField("591", EFieldOption.Optional)]
		public char PreallocMethod
		{
			get
			{
				return this.GetCharField(591).Value;
			}
			set
			{
				this.AddCharField(591, value);
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06003D6D RID: 15725 RVA: 0x00040B9B File Offset: 0x0003FB9B
		// (set) Token: 0x06003D6E RID: 15726 RVA: 0x00040BAA File Offset: 0x0003FBAA
		[FIXField("78", EFieldOption.Optional)]
		public int NoAllocs
		{
			get
			{
				return this.GetIntField(78).Value;
			}
			set
			{
				this.AddIntField(78, value);
			}
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00040BB5 File Offset: 0x0003FBB5
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00040BD3 File Offset: 0x0003FBD3
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x00040BF0 File Offset: 0x0003FBF0
		// (set) Token: 0x06003D72 RID: 15730 RVA: 0x00040BFF File Offset: 0x0003FBFF
		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharField(63).Value;
			}
			set
			{
				this.AddCharField(63, value);
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06003D73 RID: 15731 RVA: 0x00040C0A File Offset: 0x0003FC0A
		// (set) Token: 0x06003D74 RID: 15732 RVA: 0x00040C19 File Offset: 0x0003FC19
		[FIXField("64", EFieldOption.Optional)]
		public DateTime SettlDate
		{
			get
			{
				return this.GetDateTimeField(64).Value;
			}
			set
			{
				this.AddDateTimeField(64, value);
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x00040C24 File Offset: 0x0003FC24
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x00040C36 File Offset: 0x0003FC36
		[FIXField("544", EFieldOption.Optional)]
		public char CashMargin
		{
			get
			{
				return this.GetCharField(544).Value;
			}
			set
			{
				this.AddCharField(544, value);
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x00040C44 File Offset: 0x0003FC44
		// (set) Token: 0x06003D78 RID: 15736 RVA: 0x00040C56 File Offset: 0x0003FC56
		[FIXField("635", EFieldOption.Optional)]
		public string ClearingFeeIndicator
		{
			get
			{
				return this.GetStringField(635).Value;
			}
			set
			{
				this.AddStringField(635, value);
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00040C64 File Offset: 0x0003FC64
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x00040C73 File Offset: 0x0003FC73
		[FIXField("21", EFieldOption.Optional)]
		public char HandlInst
		{
			get
			{
				return this.GetCharField(21).Value;
			}
			set
			{
				this.AddCharField(21, value);
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x00040C7E File Offset: 0x0003FC7E
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x00040C8D File Offset: 0x0003FC8D
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringField(18).Value;
			}
			set
			{
				this.AddStringField(18, value);
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x00040C98 File Offset: 0x0003FC98
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x00040CA7 File Offset: 0x0003FCA7
		[FIXField("110", EFieldOption.Optional)]
		public double MinQty
		{
			get
			{
				return this.GetDoubleField(110).Value;
			}
			set
			{
				this.AddDoubleField(110, value);
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x00040CB2 File Offset: 0x0003FCB2
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x00040CC1 File Offset: 0x0003FCC1
		[FIXField("111", EFieldOption.Optional)]
		public double MaxFloor
		{
			get
			{
				return this.GetDoubleField(111).Value;
			}
			set
			{
				this.AddDoubleField(111, value);
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00040CCC File Offset: 0x0003FCCC
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x00040CDB File Offset: 0x0003FCDB
		[FIXField("100", EFieldOption.Optional)]
		public string ExDestination
		{
			get
			{
				return this.GetStringField(100).Value;
			}
			set
			{
				this.AddStringField(100, value);
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00040CE6 File Offset: 0x0003FCE6
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x00040CF8 File Offset: 0x0003FCF8
		[FIXField("386", EFieldOption.Optional)]
		public int NoTradingSessions
		{
			get
			{
				return this.GetIntField(386).Value;
			}
			set
			{
				this.AddIntField(386, value);
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00040D06 File Offset: 0x0003FD06
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00040D24 File Offset: 0x0003FD24
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00040D41 File Offset: 0x0003FD41
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00040D50 File Offset: 0x0003FD50
		[FIXField("81", EFieldOption.Optional)]
		public char ProcessCode
		{
			get
			{
				return this.GetCharField(81).Value;
			}
			set
			{
				this.AddCharField(81, value);
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x00040D5B File Offset: 0x0003FD5B
		// (set) Token: 0x06003D8A RID: 15754 RVA: 0x00040D6A File Offset: 0x0003FD6A
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

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x00040D75 File Offset: 0x0003FD75
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x00040D84 File Offset: 0x0003FD84
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

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x00040D8F File Offset: 0x0003FD8F
		// (set) Token: 0x06003D8E RID: 15758 RVA: 0x00040D9E File Offset: 0x0003FD9E
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

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x00040DA9 File Offset: 0x0003FDA9
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x00040DB8 File Offset: 0x0003FDB8
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

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x00040DC3 File Offset: 0x0003FDC3
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x00040DD5 File Offset: 0x0003FDD5
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

		// Token: 0x06003D93 RID: 15763 RVA: 0x00040DE3 File Offset: 0x0003FDE3
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00040E01 File Offset: 0x0003FE01
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00040E1E File Offset: 0x0003FE1E
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00040E30 File Offset: 0x0003FE30
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

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x00040E3E File Offset: 0x0003FE3E
		// (set) Token: 0x06003D98 RID: 15768 RVA: 0x00040E50 File Offset: 0x0003FE50
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

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06003D99 RID: 15769 RVA: 0x00040E5E File Offset: 0x0003FE5E
		// (set) Token: 0x06003D9A RID: 15770 RVA: 0x00040E70 File Offset: 0x0003FE70
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

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x00040E7E File Offset: 0x0003FE7E
		// (set) Token: 0x06003D9C RID: 15772 RVA: 0x00040E90 File Offset: 0x0003FE90
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

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x00040E9E File Offset: 0x0003FE9E
		// (set) Token: 0x06003D9E RID: 15774 RVA: 0x00040EB0 File Offset: 0x0003FEB0
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

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x00040EBE File Offset: 0x0003FEBE
		// (set) Token: 0x06003DA0 RID: 15776 RVA: 0x00040ED0 File Offset: 0x0003FED0
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

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x00040EDE File Offset: 0x0003FEDE
		// (set) Token: 0x06003DA2 RID: 15778 RVA: 0x00040EF0 File Offset: 0x0003FEF0
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

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x00040EFE File Offset: 0x0003FEFE
		// (set) Token: 0x06003DA4 RID: 15780 RVA: 0x00040F10 File Offset: 0x0003FF10
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

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x00040F1E File Offset: 0x0003FF1E
		// (set) Token: 0x06003DA6 RID: 15782 RVA: 0x00040F30 File Offset: 0x0003FF30
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x00040F3E File Offset: 0x0003FF3E
		// (set) Token: 0x06003DA8 RID: 15784 RVA: 0x00040F50 File Offset: 0x0003FF50
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

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x00040F5E File Offset: 0x0003FF5E
		// (set) Token: 0x06003DAA RID: 15786 RVA: 0x00040F70 File Offset: 0x0003FF70
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00040F7E File Offset: 0x0003FF7E
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x00040F90 File Offset: 0x0003FF90
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

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00040F9E File Offset: 0x0003FF9E
		// (set) Token: 0x06003DAE RID: 15790 RVA: 0x00040FB0 File Offset: 0x0003FFB0
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

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x00040FBE File Offset: 0x0003FFBE
		// (set) Token: 0x06003DB0 RID: 15792 RVA: 0x00040FD0 File Offset: 0x0003FFD0
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

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x00040FDE File Offset: 0x0003FFDE
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x00040FF0 File Offset: 0x0003FFF0
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

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x00040FFE File Offset: 0x0003FFFE
		// (set) Token: 0x06003DB4 RID: 15796 RVA: 0x00041010 File Offset: 0x00040010
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

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x0004101E File Offset: 0x0004001E
		// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x00041030 File Offset: 0x00040030
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

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x0004103E File Offset: 0x0004003E
		// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x00041050 File Offset: 0x00040050
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

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x0004105E File Offset: 0x0004005E
		// (set) Token: 0x06003DBA RID: 15802 RVA: 0x00041070 File Offset: 0x00040070
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

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x0004107E File Offset: 0x0004007E
		// (set) Token: 0x06003DBC RID: 15804 RVA: 0x00041090 File Offset: 0x00040090
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

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x0004109E File Offset: 0x0004009E
		// (set) Token: 0x06003DBE RID: 15806 RVA: 0x000410B0 File Offset: 0x000400B0
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

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x000410BE File Offset: 0x000400BE
		// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x000410D0 File Offset: 0x000400D0
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

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x000410DE File Offset: 0x000400DE
		// (set) Token: 0x06003DC2 RID: 15810 RVA: 0x000410F0 File Offset: 0x000400F0
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

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x000410FE File Offset: 0x000400FE
		// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x00041110 File Offset: 0x00040110
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

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x0004111E File Offset: 0x0004011E
		// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x0004112D File Offset: 0x0004012D
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

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x00041138 File Offset: 0x00040138
		// (set) Token: 0x06003DC8 RID: 15816 RVA: 0x0004114A File Offset: 0x0004014A
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

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x00041158 File Offset: 0x00040158
		// (set) Token: 0x06003DCA RID: 15818 RVA: 0x0004116A File Offset: 0x0004016A
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

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06003DCB RID: 15819 RVA: 0x00041178 File Offset: 0x00040178
		// (set) Token: 0x06003DCC RID: 15820 RVA: 0x00041187 File Offset: 0x00040187
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

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x00041192 File Offset: 0x00040192
		// (set) Token: 0x06003DCE RID: 15822 RVA: 0x000411A4 File Offset: 0x000401A4
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

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x000411B2 File Offset: 0x000401B2
		// (set) Token: 0x06003DD0 RID: 15824 RVA: 0x000411C4 File Offset: 0x000401C4
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

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x000411D2 File Offset: 0x000401D2
		// (set) Token: 0x06003DD2 RID: 15826 RVA: 0x000411E4 File Offset: 0x000401E4
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

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x000411F2 File Offset: 0x000401F2
		// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x00041204 File Offset: 0x00040204
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

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x00041212 File Offset: 0x00040212
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x00041224 File Offset: 0x00040224
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

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x00041232 File Offset: 0x00040232
		// (set) Token: 0x06003DD8 RID: 15832 RVA: 0x00041244 File Offset: 0x00040244
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

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x00041252 File Offset: 0x00040252
		// (set) Token: 0x06003DDA RID: 15834 RVA: 0x00041264 File Offset: 0x00040264
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

		// Token: 0x06003DDB RID: 15835 RVA: 0x00041272 File Offset: 0x00040272
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00041290 File Offset: 0x00040290
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x000412AD File Offset: 0x000402AD
		// (set) Token: 0x06003DDE RID: 15838 RVA: 0x000412BF File Offset: 0x000402BF
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

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06003DDF RID: 15839 RVA: 0x000412CD File Offset: 0x000402CD
		// (set) Token: 0x06003DE0 RID: 15840 RVA: 0x000412DF File Offset: 0x000402DF
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

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x000412ED File Offset: 0x000402ED
		// (set) Token: 0x06003DE2 RID: 15842 RVA: 0x000412FF File Offset: 0x000402FF
		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntField(711).Value;
			}
			set
			{
				this.AddIntField(711, value);
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x0004130D File Offset: 0x0004030D
		// (set) Token: 0x06003DE4 RID: 15844 RVA: 0x0004131F File Offset: 0x0004031F
		[FIXField("140", EFieldOption.Optional)]
		public double PrevClosePx
		{
			get
			{
				return this.GetDoubleField(140).Value;
			}
			set
			{
				this.AddDoubleField(140, value);
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x0004132D File Offset: 0x0004032D
		// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x0004133C File Offset: 0x0004033C
		[FIXField("54", EFieldOption.Required)]
		public char Side
		{
			get
			{
				return this.GetCharField(54).Value;
			}
			set
			{
				this.AddCharField(54, value);
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06003DE7 RID: 15847 RVA: 0x00041347 File Offset: 0x00040347
		// (set) Token: 0x06003DE8 RID: 15848 RVA: 0x00041359 File Offset: 0x00040359
		[FIXField("401", EFieldOption.Optional)]
		public int SideValueInd
		{
			get
			{
				return this.GetIntField(401).Value;
			}
			set
			{
				this.AddIntField(401, value);
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06003DE9 RID: 15849 RVA: 0x00041367 File Offset: 0x00040367
		// (set) Token: 0x06003DEA RID: 15850 RVA: 0x00041376 File Offset: 0x00040376
		[FIXField("114", EFieldOption.Optional)]
		public bool LocateReqd
		{
			get
			{
				return this.GetBoolField(114).Value;
			}
			set
			{
				this.AddBoolField(114, value);
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x00041381 File Offset: 0x00040381
		// (set) Token: 0x06003DEC RID: 15852 RVA: 0x00041390 File Offset: 0x00040390
		[FIXField("60", EFieldOption.Optional)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeField(60).Value;
			}
			set
			{
				this.AddDateTimeField(60, value);
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06003DED RID: 15853 RVA: 0x0004139B File Offset: 0x0004039B
		// (set) Token: 0x06003DEE RID: 15854 RVA: 0x000413AD File Offset: 0x000403AD
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntField(232).Value;
			}
			set
			{
				this.AddIntField(232, value);
			}
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000413BB File Offset: 0x000403BB
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x000413D9 File Offset: 0x000403D9
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x000413F6 File Offset: 0x000403F6
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x00041408 File Offset: 0x00040408
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntField(854).Value;
			}
			set
			{
				this.AddIntField(854, value);
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00041416 File Offset: 0x00040416
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x00041425 File Offset: 0x00040425
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleField(38).Value;
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x00041430 File Offset: 0x00040430
		// (set) Token: 0x06003DF6 RID: 15862 RVA: 0x00041442 File Offset: 0x00040442
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleField(152).Value;
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x00041450 File Offset: 0x00040450
		// (set) Token: 0x06003DF8 RID: 15864 RVA: 0x00041462 File Offset: 0x00040462
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleField(516).Value;
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x00041470 File Offset: 0x00040470
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x00041482 File Offset: 0x00040482
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharField(468).Value;
			}
			set
			{
				this.AddCharField(468, value);
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x00041490 File Offset: 0x00040490
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x000414A2 File Offset: 0x000404A2
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleField(469).Value;
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x000414B0 File Offset: 0x000404B0
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x000414BF File Offset: 0x000404BF
		[FIXField("40", EFieldOption.Optional)]
		public char OrdType
		{
			get
			{
				return this.GetCharField(40).Value;
			}
			set
			{
				this.AddCharField(40, value);
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06003DFF RID: 15871 RVA: 0x000414CA File Offset: 0x000404CA
		// (set) Token: 0x06003E00 RID: 15872 RVA: 0x000414DC File Offset: 0x000404DC
		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntField(423).Value;
			}
			set
			{
				this.AddIntField(423, value);
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x000414EA File Offset: 0x000404EA
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x000414F9 File Offset: 0x000404F9
		[FIXField("44", EFieldOption.Optional)]
		public double Price
		{
			get
			{
				return this.GetDoubleField(44).Value;
			}
			set
			{
				this.AddDoubleField(44, value);
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x00041504 File Offset: 0x00040504
		// (set) Token: 0x06003E04 RID: 15876 RVA: 0x00041513 File Offset: 0x00040513
		[FIXField("99", EFieldOption.Optional)]
		public double StopPx
		{
			get
			{
				return this.GetDoubleField(99).Value;
			}
			set
			{
				this.AddDoubleField(99, value);
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x0004151E File Offset: 0x0004051E
		// (set) Token: 0x06003E06 RID: 15878 RVA: 0x00041530 File Offset: 0x00040530
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleField(218).Value;
			}
			set
			{
				this.AddDoubleField(218, value);
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06003E07 RID: 15879 RVA: 0x0004153E File Offset: 0x0004053E
		// (set) Token: 0x06003E08 RID: 15880 RVA: 0x00041550 File Offset: 0x00040550
		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleField(220).Value;
			}
			set
			{
				this.AddDoubleField(220, value);
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06003E09 RID: 15881 RVA: 0x0004155E File Offset: 0x0004055E
		// (set) Token: 0x06003E0A RID: 15882 RVA: 0x00041570 File Offset: 0x00040570
		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringField(221).Value;
			}
			set
			{
				this.AddStringField(221, value);
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06003E0B RID: 15883 RVA: 0x0004157E File Offset: 0x0004057E
		// (set) Token: 0x06003E0C RID: 15884 RVA: 0x00041590 File Offset: 0x00040590
		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringField(222).Value;
			}
			set
			{
				this.AddStringField(222, value);
			}
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06003E0D RID: 15885 RVA: 0x0004159E File Offset: 0x0004059E
		// (set) Token: 0x06003E0E RID: 15886 RVA: 0x000415B0 File Offset: 0x000405B0
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleField(662).Value;
			}
			set
			{
				this.AddDoubleField(662, value);
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x000415BE File Offset: 0x000405BE
		// (set) Token: 0x06003E10 RID: 15888 RVA: 0x000415D0 File Offset: 0x000405D0
		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntField(663).Value;
			}
			set
			{
				this.AddIntField(663, value);
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x000415DE File Offset: 0x000405DE
		// (set) Token: 0x06003E12 RID: 15890 RVA: 0x000415F0 File Offset: 0x000405F0
		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringField(699).Value;
			}
			set
			{
				this.AddStringField(699, value);
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x000415FE File Offset: 0x000405FE
		// (set) Token: 0x06003E14 RID: 15892 RVA: 0x00041610 File Offset: 0x00040610
		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringField(761).Value;
			}
			set
			{
				this.AddStringField(761, value);
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x0004161E File Offset: 0x0004061E
		// (set) Token: 0x06003E16 RID: 15894 RVA: 0x00041630 File Offset: 0x00040630
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringField(235).Value;
			}
			set
			{
				this.AddStringField(235, value);
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x0004163E File Offset: 0x0004063E
		// (set) Token: 0x06003E18 RID: 15896 RVA: 0x00041650 File Offset: 0x00040650
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleField(236).Value;
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06003E19 RID: 15897 RVA: 0x0004165E File Offset: 0x0004065E
		// (set) Token: 0x06003E1A RID: 15898 RVA: 0x00041670 File Offset: 0x00040670
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeField(701).Value;
			}
			set
			{
				this.AddDateTimeField(701, value);
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x0004167E File Offset: 0x0004067E
		// (set) Token: 0x06003E1C RID: 15900 RVA: 0x00041690 File Offset: 0x00040690
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(696).Value;
			}
			set
			{
				this.AddDateTimeField(696, value);
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06003E1D RID: 15901 RVA: 0x0004169E File Offset: 0x0004069E
		// (set) Token: 0x06003E1E RID: 15902 RVA: 0x000416B0 File Offset: 0x000406B0
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleField(697).Value;
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x000416BE File Offset: 0x000406BE
		// (set) Token: 0x06003E20 RID: 15904 RVA: 0x000416D0 File Offset: 0x000406D0
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntField(698).Value;
			}
			set
			{
				this.AddIntField(698, value);
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x000416DE File Offset: 0x000406DE
		// (set) Token: 0x06003E22 RID: 15906 RVA: 0x000416ED File Offset: 0x000406ED
		[FIXField("15", EFieldOption.Optional)]
		public double Currency
		{
			get
			{
				return this.GetDoubleField(15).Value;
			}
			set
			{
				this.AddDoubleField(15, value);
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x000416F8 File Offset: 0x000406F8
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x0004170A File Offset: 0x0004070A
		[FIXField("376", EFieldOption.Optional)]
		public string ComplianceID
		{
			get
			{
				return this.GetStringField(376).Value;
			}
			set
			{
				this.AddStringField(376, value);
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x00041718 File Offset: 0x00040718
		// (set) Token: 0x06003E26 RID: 15910 RVA: 0x0004172A File Offset: 0x0004072A
		[FIXField("377", EFieldOption.Optional)]
		public bool SolicitedFlag
		{
			get
			{
				return this.GetBoolField(377).Value;
			}
			set
			{
				this.AddBoolField(377, value);
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06003E27 RID: 15911 RVA: 0x00041738 File Offset: 0x00040738
		// (set) Token: 0x06003E28 RID: 15912 RVA: 0x00041747 File Offset: 0x00040747
		[FIXField("23", EFieldOption.Optional)]
		public string IOIID
		{
			get
			{
				return this.GetStringField(23).Value;
			}
			set
			{
				this.AddStringField(23, value);
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x00041752 File Offset: 0x00040752
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x00041761 File Offset: 0x00040761
		[FIXField("117", EFieldOption.Optional)]
		public string QuoteID
		{
			get
			{
				return this.GetStringField(117).Value;
			}
			set
			{
				this.AddStringField(117, value);
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x0004176C File Offset: 0x0004076C
		// (set) Token: 0x06003E2C RID: 15916 RVA: 0x0004177B File Offset: 0x0004077B
		[FIXField("59", EFieldOption.Optional)]
		public char TimeInForce
		{
			get
			{
				return this.GetCharField(59).Value;
			}
			set
			{
				this.AddCharField(59, value);
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x00041786 File Offset: 0x00040786
		// (set) Token: 0x06003E2E RID: 15918 RVA: 0x00041798 File Offset: 0x00040798
		[FIXField("168", EFieldOption.Optional)]
		public DateTime EffectiveTime
		{
			get
			{
				return this.GetDateTimeField(168).Value;
			}
			set
			{
				this.AddDateTimeField(168, value);
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x000417A6 File Offset: 0x000407A6
		// (set) Token: 0x06003E30 RID: 15920 RVA: 0x000417B8 File Offset: 0x000407B8
		[FIXField("432", EFieldOption.Optional)]
		public DateTime ExpireDate
		{
			get
			{
				return this.GetDateTimeField(432).Value;
			}
			set
			{
				this.AddDateTimeField(432, value);
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x000417C6 File Offset: 0x000407C6
		// (set) Token: 0x06003E32 RID: 15922 RVA: 0x000417D5 File Offset: 0x000407D5
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeField(126).Value;
			}
			set
			{
				this.AddDateTimeField(126, value);
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06003E33 RID: 15923 RVA: 0x000417E0 File Offset: 0x000407E0
		// (set) Token: 0x06003E34 RID: 15924 RVA: 0x000417F2 File Offset: 0x000407F2
		[FIXField("427", EFieldOption.Optional)]
		public int GTBookingInst
		{
			get
			{
				return this.GetIntField(427).Value;
			}
			set
			{
				this.AddIntField(427, value);
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06003E35 RID: 15925 RVA: 0x00041800 File Offset: 0x00040800
		// (set) Token: 0x06003E36 RID: 15926 RVA: 0x0004180F File Offset: 0x0004080F
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleField(12).Value;
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06003E37 RID: 15927 RVA: 0x0004181A File Offset: 0x0004081A
		// (set) Token: 0x06003E38 RID: 15928 RVA: 0x00041829 File Offset: 0x00040829
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharField(13).Value;
			}
			set
			{
				this.AddCharField(13, value);
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x00041834 File Offset: 0x00040834
		// (set) Token: 0x06003E3A RID: 15930 RVA: 0x00041846 File Offset: 0x00040846
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleField(479).Value;
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06003E3B RID: 15931 RVA: 0x00041854 File Offset: 0x00040854
		// (set) Token: 0x06003E3C RID: 15932 RVA: 0x00041866 File Offset: 0x00040866
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharField(497).Value;
			}
			set
			{
				this.AddCharField(497, value);
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06003E3D RID: 15933 RVA: 0x00041874 File Offset: 0x00040874
		// (set) Token: 0x06003E3E RID: 15934 RVA: 0x00041886 File Offset: 0x00040886
		[FIXField("528", EFieldOption.Optional)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharField(528).Value;
			}
			set
			{
				this.AddCharField(528, value);
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x00041894 File Offset: 0x00040894
		// (set) Token: 0x06003E40 RID: 15936 RVA: 0x000418A6 File Offset: 0x000408A6
		[FIXField("529", EFieldOption.Optional)]
		public string OrderRestrictions
		{
			get
			{
				return this.GetStringField(529).Value;
			}
			set
			{
				this.AddStringField(529, value);
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06003E41 RID: 15937 RVA: 0x000418B4 File Offset: 0x000408B4
		// (set) Token: 0x06003E42 RID: 15938 RVA: 0x000418C6 File Offset: 0x000408C6
		[FIXField("582", EFieldOption.Optional)]
		public int CustOrderCapacity
		{
			get
			{
				return this.GetIntField(582).Value;
			}
			set
			{
				this.AddIntField(582, value);
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06003E43 RID: 15939 RVA: 0x000418D4 File Offset: 0x000408D4
		// (set) Token: 0x06003E44 RID: 15940 RVA: 0x000418E3 File Offset: 0x000408E3
		[FIXField("121", EFieldOption.Optional)]
		public bool ForexReq
		{
			get
			{
				return this.GetBoolField(121).Value;
			}
			set
			{
				this.AddBoolField(121, value);
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x000418EE File Offset: 0x000408EE
		// (set) Token: 0x06003E46 RID: 15942 RVA: 0x000418FD File Offset: 0x000408FD
		[FIXField("120", EFieldOption.Optional)]
		public double SettlCurrency
		{
			get
			{
				return this.GetDoubleField(120).Value;
			}
			set
			{
				this.AddDoubleField(120, value);
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x00041908 File Offset: 0x00040908
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x0004191A File Offset: 0x0004091A
		[FIXField("775", EFieldOption.Optional)]
		public int BookingType
		{
			get
			{
				return this.GetIntField(775).Value;
			}
			set
			{
				this.AddIntField(775, value);
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x00041928 File Offset: 0x00040928
		// (set) Token: 0x06003E4A RID: 15946 RVA: 0x00041937 File Offset: 0x00040937
		[FIXField("58", EFieldOption.Optional)]
		public string Text
		{
			get
			{
				return this.GetStringField(58).Value;
			}
			set
			{
				this.AddStringField(58, value);
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x00041942 File Offset: 0x00040942
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00041954 File Offset: 0x00040954
		[FIXField("354", EFieldOption.Optional)]
		public int EncodedTextLen
		{
			get
			{
				return this.GetIntField(354).Value;
			}
			set
			{
				this.AddIntField(354, value);
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x00041962 File Offset: 0x00040962
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x00041974 File Offset: 0x00040974
		[FIXField("355", EFieldOption.Optional)]
		public string EncodedText
		{
			get
			{
				return this.GetStringField(355).Value;
			}
			set
			{
				this.AddStringField(355, value);
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x00041982 File Offset: 0x00040982
		// (set) Token: 0x06003E50 RID: 15952 RVA: 0x00041994 File Offset: 0x00040994
		[FIXField("193", EFieldOption.Optional)]
		public DateTime SettlDate2
		{
			get
			{
				return this.GetDateTimeField(193).Value;
			}
			set
			{
				this.AddDateTimeField(193, value);
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x000419A2 File Offset: 0x000409A2
		// (set) Token: 0x06003E52 RID: 15954 RVA: 0x000419B4 File Offset: 0x000409B4
		[FIXField("192", EFieldOption.Optional)]
		public double OrderQty2
		{
			get
			{
				return this.GetDoubleField(192).Value;
			}
			set
			{
				this.AddDoubleField(192, value);
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06003E53 RID: 15955 RVA: 0x000419C2 File Offset: 0x000409C2
		// (set) Token: 0x06003E54 RID: 15956 RVA: 0x000419D4 File Offset: 0x000409D4
		[FIXField("640", EFieldOption.Optional)]
		public double Price2
		{
			get
			{
				return this.GetDoubleField(640).Value;
			}
			set
			{
				this.AddDoubleField(640, value);
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06003E55 RID: 15957 RVA: 0x000419E2 File Offset: 0x000409E2
		// (set) Token: 0x06003E56 RID: 15958 RVA: 0x000419F1 File Offset: 0x000409F1
		[FIXField("77", EFieldOption.Optional)]
		public char PositionEffect
		{
			get
			{
				return this.GetCharField(77).Value;
			}
			set
			{
				this.AddCharField(77, value);
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x000419FC File Offset: 0x000409FC
		// (set) Token: 0x06003E58 RID: 15960 RVA: 0x00041A0E File Offset: 0x00040A0E
		[FIXField("203", EFieldOption.Optional)]
		public int CoveredOrUncovered
		{
			get
			{
				return this.GetIntField(203).Value;
			}
			set
			{
				this.AddIntField(203, value);
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x00041A1C File Offset: 0x00040A1C
		// (set) Token: 0x06003E5A RID: 15962 RVA: 0x00041A2E File Offset: 0x00040A2E
		[FIXField("210", EFieldOption.Optional)]
		public double MaxShow
		{
			get
			{
				return this.GetDoubleField(210).Value;
			}
			set
			{
				this.AddDoubleField(210, value);
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06003E5B RID: 15963 RVA: 0x00041A3C File Offset: 0x00040A3C
		// (set) Token: 0x06003E5C RID: 15964 RVA: 0x00041A4E File Offset: 0x00040A4E
		[FIXField("211", EFieldOption.Optional)]
		public double PegOffsetValue
		{
			get
			{
				return this.GetDoubleField(211).Value;
			}
			set
			{
				this.AddDoubleField(211, value);
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x00041A5C File Offset: 0x00040A5C
		// (set) Token: 0x06003E5E RID: 15966 RVA: 0x00041A6E File Offset: 0x00040A6E
		[FIXField("835", EFieldOption.Optional)]
		public int PegMoveType
		{
			get
			{
				return this.GetIntField(835).Value;
			}
			set
			{
				this.AddIntField(835, value);
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06003E5F RID: 15967 RVA: 0x00041A7C File Offset: 0x00040A7C
		// (set) Token: 0x06003E60 RID: 15968 RVA: 0x00041A8E File Offset: 0x00040A8E
		[FIXField("836", EFieldOption.Optional)]
		public int PegOffsetType
		{
			get
			{
				return this.GetIntField(836).Value;
			}
			set
			{
				this.AddIntField(836, value);
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06003E61 RID: 15969 RVA: 0x00041A9C File Offset: 0x00040A9C
		// (set) Token: 0x06003E62 RID: 15970 RVA: 0x00041AAE File Offset: 0x00040AAE
		[FIXField("837", EFieldOption.Optional)]
		public int PegLimitType
		{
			get
			{
				return this.GetIntField(837).Value;
			}
			set
			{
				this.AddIntField(837, value);
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x00041ABC File Offset: 0x00040ABC
		// (set) Token: 0x06003E64 RID: 15972 RVA: 0x00041ACE File Offset: 0x00040ACE
		[FIXField("838", EFieldOption.Optional)]
		public int PegRoundDirection
		{
			get
			{
				return this.GetIntField(838).Value;
			}
			set
			{
				this.AddIntField(838, value);
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06003E65 RID: 15973 RVA: 0x00041ADC File Offset: 0x00040ADC
		// (set) Token: 0x06003E66 RID: 15974 RVA: 0x00041AEE File Offset: 0x00040AEE
		[FIXField("840", EFieldOption.Optional)]
		public int PegScope
		{
			get
			{
				return this.GetIntField(840).Value;
			}
			set
			{
				this.AddIntField(840, value);
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x00041AFC File Offset: 0x00040AFC
		// (set) Token: 0x06003E68 RID: 15976 RVA: 0x00041B0E File Offset: 0x00040B0E
		[FIXField("388", EFieldOption.Optional)]
		public char DiscretionInst
		{
			get
			{
				return this.GetCharField(388).Value;
			}
			set
			{
				this.AddCharField(388, value);
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x00041B1C File Offset: 0x00040B1C
		// (set) Token: 0x06003E6A RID: 15978 RVA: 0x00041B2E File Offset: 0x00040B2E
		[FIXField("389", EFieldOption.Optional)]
		public double DiscretionOffsetValue
		{
			get
			{
				return this.GetDoubleField(389).Value;
			}
			set
			{
				this.AddDoubleField(389, value);
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x00041B3C File Offset: 0x00040B3C
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x00041B4E File Offset: 0x00040B4E
		[FIXField("841", EFieldOption.Optional)]
		public int DiscretionMoveType
		{
			get
			{
				return this.GetIntField(841).Value;
			}
			set
			{
				this.AddIntField(841, value);
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x00041B5C File Offset: 0x00040B5C
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x00041B6E File Offset: 0x00040B6E
		[FIXField("842", EFieldOption.Optional)]
		public int DiscretionOffsetType
		{
			get
			{
				return this.GetIntField(842).Value;
			}
			set
			{
				this.AddIntField(842, value);
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x00041B7C File Offset: 0x00040B7C
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x00041B8E File Offset: 0x00040B8E
		[FIXField("843", EFieldOption.Optional)]
		public int DiscretionLimitType
		{
			get
			{
				return this.GetIntField(843).Value;
			}
			set
			{
				this.AddIntField(843, value);
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x00041B9C File Offset: 0x00040B9C
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x00041BAE File Offset: 0x00040BAE
		[FIXField("844", EFieldOption.Optional)]
		public int DiscretionRoundDirection
		{
			get
			{
				return this.GetIntField(844).Value;
			}
			set
			{
				this.AddIntField(844, value);
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x00041BBC File Offset: 0x00040BBC
		// (set) Token: 0x06003E74 RID: 15988 RVA: 0x00041BCE File Offset: 0x00040BCE
		[FIXField("846", EFieldOption.Optional)]
		public int DiscretionScope
		{
			get
			{
				return this.GetIntField(846).Value;
			}
			set
			{
				this.AddIntField(846, value);
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x00041BDC File Offset: 0x00040BDC
		// (set) Token: 0x06003E76 RID: 15990 RVA: 0x00041BEE File Offset: 0x00040BEE
		[FIXField("847", EFieldOption.Optional)]
		public int TargetStrategy
		{
			get
			{
				return this.GetIntField(847).Value;
			}
			set
			{
				this.AddIntField(847, value);
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06003E77 RID: 15991 RVA: 0x00041BFC File Offset: 0x00040BFC
		// (set) Token: 0x06003E78 RID: 15992 RVA: 0x00041C0E File Offset: 0x00040C0E
		[FIXField("848", EFieldOption.Optional)]
		public string TargetStrategyParameters
		{
			get
			{
				return this.GetStringField(848).Value;
			}
			set
			{
				this.AddStringField(848, value);
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06003E79 RID: 15993 RVA: 0x00041C1C File Offset: 0x00040C1C
		// (set) Token: 0x06003E7A RID: 15994 RVA: 0x00041C2E File Offset: 0x00040C2E
		[FIXField("849", EFieldOption.Optional)]
		public double ParticipationRate
		{
			get
			{
				return this.GetDoubleField(849).Value;
			}
			set
			{
				this.AddDoubleField(849, value);
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06003E7B RID: 15995 RVA: 0x00041C3C File Offset: 0x00040C3C
		// (set) Token: 0x06003E7C RID: 15996 RVA: 0x00041C4E File Offset: 0x00040C4E
		[FIXField("494", EFieldOption.Optional)]
		public string Designation
		{
			get
			{
				return this.GetStringField(494).Value;
			}
			set
			{
				this.AddStringField(494, value);
			}
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00041C5C File Offset: 0x00040C5C
		public FIXOrdersGroup()
		{
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00041CB4 File Offset: 0x00040CB4
		public FIXOrdersGroup(string ClOrdID, int ListSeqNo, char Side)
		{
			this.ClOrdID = ClOrdID;
			this.ListSeqNo = ListSeqNo;
			this.Side = Side;
		}

		// Token: 0x04000553 RID: 1363
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000554 RID: 1364
		private ArrayList fAllocsGroup = new ArrayList();

		// Token: 0x04000555 RID: 1365
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x04000556 RID: 1366
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000557 RID: 1367
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000558 RID: 1368
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
