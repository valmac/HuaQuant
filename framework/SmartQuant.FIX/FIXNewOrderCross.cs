using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000186 RID: 390
	public class FIXNewOrderCross : FIXMessage
	{
		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x00051146 File Offset: 0x00050146
		// (set) Token: 0x06004938 RID: 18744 RVA: 0x00051158 File Offset: 0x00050158
		[FIXField("144", EFieldOption.Optional)]
		public string OnBehalfOfLocationID
		{
			get
			{
				return this.GetStringField(144).Value;
			}
			set
			{
				this.AddStringField(144, value);
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x00051166 File Offset: 0x00050166
		// (set) Token: 0x0600493A RID: 18746 RVA: 0x00051175 File Offset: 0x00050175
		[FIXField("9", EFieldOption.Required)]
		public int BodyLength
		{
			get
			{
				return this.GetIntField(9).Value;
			}
			set
			{
				this.AddIntField(9, value);
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x00051180 File Offset: 0x00050180
		// (set) Token: 0x0600493C RID: 18748 RVA: 0x0005118F File Offset: 0x0005018F
		[FIXField("35", EFieldOption.Required)]
		public string MsgType
		{
			get
			{
				return this.GetStringField(35).Value;
			}
			set
			{
				this.AddStringField(35, value);
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x0005119A File Offset: 0x0005019A
		// (set) Token: 0x0600493E RID: 18750 RVA: 0x000511A9 File Offset: 0x000501A9
		[FIXField("49", EFieldOption.Required)]
		public string SenderCompID
		{
			get
			{
				return this.GetStringField(49).Value;
			}
			set
			{
				this.AddStringField(49, value);
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x000511B4 File Offset: 0x000501B4
		// (set) Token: 0x06004940 RID: 18752 RVA: 0x000511C3 File Offset: 0x000501C3
		[FIXField("56", EFieldOption.Required)]
		public string TargetCompID
		{
			get
			{
				return this.GetStringField(56).Value;
			}
			set
			{
				this.AddStringField(56, value);
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x000511CE File Offset: 0x000501CE
		// (set) Token: 0x06004942 RID: 18754 RVA: 0x000511DD File Offset: 0x000501DD
		[FIXField("115", EFieldOption.Optional)]
		public string OnBehalfOfCompID
		{
			get
			{
				return this.GetStringField(115).Value;
			}
			set
			{
				this.AddStringField(115, value);
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x000511E8 File Offset: 0x000501E8
		// (set) Token: 0x06004944 RID: 18756 RVA: 0x000511FA File Offset: 0x000501FA
		[FIXField("128", EFieldOption.Optional)]
		public string DeliverToCompID
		{
			get
			{
				return this.GetStringField(128).Value;
			}
			set
			{
				this.AddStringField(128, value);
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x00051208 File Offset: 0x00050208
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x00051217 File Offset: 0x00050217
		[FIXField("90", EFieldOption.Optional)]
		public int SecureDataLen
		{
			get
			{
				return this.GetIntField(90).Value;
			}
			set
			{
				this.AddIntField(90, value);
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x00051222 File Offset: 0x00050222
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x00051231 File Offset: 0x00050231
		[FIXField("91", EFieldOption.Optional)]
		public string SecureData
		{
			get
			{
				return this.GetStringField(91).Value;
			}
			set
			{
				this.AddStringField(91, value);
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x0005123C File Offset: 0x0005023C
		// (set) Token: 0x0600494A RID: 18762 RVA: 0x0005124B File Offset: 0x0005024B
		[FIXField("34", EFieldOption.Required)]
		public int MsgSeqNum
		{
			get
			{
				return this.GetIntField(34).Value;
			}
			set
			{
				this.AddIntField(34, value);
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00051256 File Offset: 0x00050256
		// (set) Token: 0x0600494C RID: 18764 RVA: 0x00051265 File Offset: 0x00050265
		[FIXField("50", EFieldOption.Optional)]
		public string SenderSubID
		{
			get
			{
				return this.GetStringField(50).Value;
			}
			set
			{
				this.AddStringField(50, value);
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x00051270 File Offset: 0x00050270
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x00051282 File Offset: 0x00050282
		[FIXField("142", EFieldOption.Optional)]
		public string SenderLocationID
		{
			get
			{
				return this.GetStringField(142).Value;
			}
			set
			{
				this.AddStringField(142, value);
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x00051290 File Offset: 0x00050290
		// (set) Token: 0x06004950 RID: 18768 RVA: 0x0005129F File Offset: 0x0005029F
		[FIXField("57", EFieldOption.Optional)]
		public string TargetSubID
		{
			get
			{
				return this.GetStringField(57).Value;
			}
			set
			{
				this.AddStringField(57, value);
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x000512AA File Offset: 0x000502AA
		// (set) Token: 0x06004952 RID: 18770 RVA: 0x000512B8 File Offset: 0x000502B8
		[FIXField("8", EFieldOption.Required)]
		public string BeginString
		{
			get
			{
				return this.GetStringField(8).Value;
			}
			set
			{
				this.AddStringField(8, value);
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x000512C2 File Offset: 0x000502C2
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x000512D1 File Offset: 0x000502D1
		[FIXField("116", EFieldOption.Optional)]
		public string OnBehalfOfSubID
		{
			get
			{
				return this.GetStringField(116).Value;
			}
			set
			{
				this.AddStringField(116, value);
			}
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x000512DC File Offset: 0x000502DC
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x000512EF File Offset: 0x000502EF
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x000512FE File Offset: 0x000502FE
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x00051310 File Offset: 0x00050310
		[FIXField("129", EFieldOption.Optional)]
		public string DeliverToSubID
		{
			get
			{
				return this.GetStringField(129).Value;
			}
			set
			{
				this.AddStringField(129, value);
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x0005131E File Offset: 0x0005031E
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x00051330 File Offset: 0x00050330
		[FIXField("145", EFieldOption.Optional)]
		public string DeliverToLocationID
		{
			get
			{
				return this.GetStringField(145).Value;
			}
			set
			{
				this.AddStringField(145, value);
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x0005133E File Offset: 0x0005033E
		// (set) Token: 0x0600495C RID: 18780 RVA: 0x0005134D File Offset: 0x0005034D
		[FIXField("43", EFieldOption.Optional)]
		public bool PossDupFlag
		{
			get
			{
				return this.GetBoolField(43).Value;
			}
			set
			{
				this.AddBoolField(43, value);
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x00051358 File Offset: 0x00050358
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x00051367 File Offset: 0x00050367
		[FIXField("97", EFieldOption.Optional)]
		public bool PossResend
		{
			get
			{
				return this.GetBoolField(97).Value;
			}
			set
			{
				this.AddBoolField(97, value);
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00051372 File Offset: 0x00050372
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x00051381 File Offset: 0x00050381
		[FIXField("52", EFieldOption.Optional)]
		public DateTime SendingTime
		{
			get
			{
				return this.GetDateTimeField(52).Value;
			}
			set
			{
				this.AddDateTimeField(52, value);
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x0005138C File Offset: 0x0005038C
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x0005139B File Offset: 0x0005039B
		[FIXField("122", EFieldOption.Optional)]
		public DateTime OrigSendingTime
		{
			get
			{
				return this.GetDateTimeField(122).Value;
			}
			set
			{
				this.AddDateTimeField(122, value);
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x000513A6 File Offset: 0x000503A6
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x000513B8 File Offset: 0x000503B8
		[FIXField("212", EFieldOption.Optional)]
		public int XmlDataLen
		{
			get
			{
				return this.GetIntField(212).Value;
			}
			set
			{
				this.AddIntField(212, value);
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x000513C6 File Offset: 0x000503C6
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x000513D8 File Offset: 0x000503D8
		[FIXField("213", EFieldOption.Optional)]
		public string XmlData
		{
			get
			{
				return this.GetStringField(213).Value;
			}
			set
			{
				this.AddStringField(213, value);
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x000513E6 File Offset: 0x000503E6
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x000513F8 File Offset: 0x000503F8
		[FIXField("347", EFieldOption.Optional)]
		public string MessageEncoding
		{
			get
			{
				return this.GetStringField(347).Value;
			}
			set
			{
				this.AddStringField(347, value);
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x00051406 File Offset: 0x00050406
		// (set) Token: 0x0600496A RID: 18794 RVA: 0x00051418 File Offset: 0x00050418
		[FIXField("369", EFieldOption.Optional)]
		public int LastMsgSeqNumProcessed
		{
			get
			{
				return this.GetIntField(369).Value;
			}
			set
			{
				this.AddIntField(369, value);
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x00051426 File Offset: 0x00050426
		// (set) Token: 0x0600496C RID: 18796 RVA: 0x00051438 File Offset: 0x00050438
		[FIXField("627", EFieldOption.Optional)]
		public int NoHops
		{
			get
			{
				return this.GetIntField(627).Value;
			}
			set
			{
				this.AddIntField(627, value);
			}
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00051446 File Offset: 0x00050446
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00051464 File Offset: 0x00050464
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x00051481 File Offset: 0x00050481
		// (set) Token: 0x06004970 RID: 18800 RVA: 0x00051493 File Offset: 0x00050493
		[FIXField("143", EFieldOption.Optional)]
		public string TargetLocationID
		{
			get
			{
				return this.GetStringField(143).Value;
			}
			set
			{
				this.AddStringField(143, value);
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x000514A1 File Offset: 0x000504A1
		// (set) Token: 0x06004972 RID: 18802 RVA: 0x000514B3 File Offset: 0x000504B3
		[FIXField("548", EFieldOption.Required)]
		public string CrossID
		{
			get
			{
				return this.GetStringField(548).Value;
			}
			set
			{
				this.AddStringField(548, value);
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x000514C1 File Offset: 0x000504C1
		// (set) Token: 0x06004974 RID: 18804 RVA: 0x000514D3 File Offset: 0x000504D3
		[FIXField("549", EFieldOption.Required)]
		public int CrossType
		{
			get
			{
				return this.GetIntField(549).Value;
			}
			set
			{
				this.AddIntField(549, value);
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x000514E1 File Offset: 0x000504E1
		// (set) Token: 0x06004976 RID: 18806 RVA: 0x000514F3 File Offset: 0x000504F3
		[FIXField("550", EFieldOption.Required)]
		public int CrossPrioritization
		{
			get
			{
				return this.GetIntField(550).Value;
			}
			set
			{
				this.AddIntField(550, value);
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x00051501 File Offset: 0x00050501
		// (set) Token: 0x06004978 RID: 18808 RVA: 0x00051513 File Offset: 0x00050513
		[FIXField("552", EFieldOption.Required)]
		public int NoSides
		{
			get
			{
				return this.GetIntField(552).Value;
			}
			set
			{
				this.AddIntField(552, value);
			}
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00051521 File Offset: 0x00050521
		public FIXSidesGroup GetSidesGroup(int i)
		{
			if (i < this.NoSides)
			{
				return (FIXSidesGroup)this.fSidesGroup[i];
			}
			return null;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0005153F File Offset: 0x0005053F
		public void AddGroup(FIXSidesGroup group)
		{
			this.fSidesGroup.Add(group);
			this.NoSides++;
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x0005155C File Offset: 0x0005055C
		// (set) Token: 0x0600497C RID: 18812 RVA: 0x0005156B File Offset: 0x0005056B
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

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x00051576 File Offset: 0x00050576
		// (set) Token: 0x0600497E RID: 18814 RVA: 0x00051585 File Offset: 0x00050585
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

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x00051590 File Offset: 0x00050590
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x0005159F File Offset: 0x0005059F
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

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x000515AA File Offset: 0x000505AA
		// (set) Token: 0x06004982 RID: 18818 RVA: 0x000515B9 File Offset: 0x000505B9
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

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x000515C4 File Offset: 0x000505C4
		// (set) Token: 0x06004984 RID: 18820 RVA: 0x000515D6 File Offset: 0x000505D6
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

		// Token: 0x06004985 RID: 18821 RVA: 0x000515E4 File Offset: 0x000505E4
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00051602 File Offset: 0x00050602
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06004987 RID: 18823 RVA: 0x0005161F File Offset: 0x0005061F
		// (set) Token: 0x06004988 RID: 18824 RVA: 0x00051631 File Offset: 0x00050631
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

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x0005163F File Offset: 0x0005063F
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x00051651 File Offset: 0x00050651
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

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x0005165F File Offset: 0x0005065F
		// (set) Token: 0x0600498C RID: 18828 RVA: 0x00051671 File Offset: 0x00050671
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

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x0005167F File Offset: 0x0005067F
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x00051691 File Offset: 0x00050691
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

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x0005169F File Offset: 0x0005069F
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x000516B1 File Offset: 0x000506B1
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

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x000516BF File Offset: 0x000506BF
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x000516D1 File Offset: 0x000506D1
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

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x000516DF File Offset: 0x000506DF
		// (set) Token: 0x06004994 RID: 18836 RVA: 0x000516F1 File Offset: 0x000506F1
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

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x000516FF File Offset: 0x000506FF
		// (set) Token: 0x06004996 RID: 18838 RVA: 0x00051711 File Offset: 0x00050711
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

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x0005171F File Offset: 0x0005071F
		// (set) Token: 0x06004998 RID: 18840 RVA: 0x00051731 File Offset: 0x00050731
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

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x0005173F File Offset: 0x0005073F
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x00051751 File Offset: 0x00050751
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

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x0005175F File Offset: 0x0005075F
		// (set) Token: 0x0600499C RID: 18844 RVA: 0x00051771 File Offset: 0x00050771
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

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x0005177F File Offset: 0x0005077F
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x00051791 File Offset: 0x00050791
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

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x0005179F File Offset: 0x0005079F
		// (set) Token: 0x060049A0 RID: 18848 RVA: 0x000517B1 File Offset: 0x000507B1
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

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x000517BF File Offset: 0x000507BF
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x000517D1 File Offset: 0x000507D1
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

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x000517DF File Offset: 0x000507DF
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x000517F1 File Offset: 0x000507F1
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

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000517FF File Offset: 0x000507FF
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x00051811 File Offset: 0x00050811
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

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x0005181F File Offset: 0x0005081F
		// (set) Token: 0x060049A8 RID: 18856 RVA: 0x00051831 File Offset: 0x00050831
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

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x0005183F File Offset: 0x0005083F
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x00051851 File Offset: 0x00050851
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

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x0005185F File Offset: 0x0005085F
		// (set) Token: 0x060049AC RID: 18860 RVA: 0x00051871 File Offset: 0x00050871
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

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x0005187F File Offset: 0x0005087F
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x00051891 File Offset: 0x00050891
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

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x0005189F File Offset: 0x0005089F
		// (set) Token: 0x060049B0 RID: 18864 RVA: 0x000518B1 File Offset: 0x000508B1
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

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x060049B1 RID: 18865 RVA: 0x000518BF File Offset: 0x000508BF
		// (set) Token: 0x060049B2 RID: 18866 RVA: 0x000518D1 File Offset: 0x000508D1
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

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x000518DF File Offset: 0x000508DF
		// (set) Token: 0x060049B4 RID: 18868 RVA: 0x000518F1 File Offset: 0x000508F1
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

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x000518FF File Offset: 0x000508FF
		// (set) Token: 0x060049B6 RID: 18870 RVA: 0x00051911 File Offset: 0x00050911
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

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x0005191F File Offset: 0x0005091F
		// (set) Token: 0x060049B8 RID: 18872 RVA: 0x0005192E File Offset: 0x0005092E
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

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x00051939 File Offset: 0x00050939
		// (set) Token: 0x060049BA RID: 18874 RVA: 0x0005194B File Offset: 0x0005094B
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

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x00051959 File Offset: 0x00050959
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x0005196B File Offset: 0x0005096B
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

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x00051979 File Offset: 0x00050979
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x00051988 File Offset: 0x00050988
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

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x00051993 File Offset: 0x00050993
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x000519A5 File Offset: 0x000509A5
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

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x000519B3 File Offset: 0x000509B3
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x000519C5 File Offset: 0x000509C5
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

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x000519D3 File Offset: 0x000509D3
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x000519E5 File Offset: 0x000509E5
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

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x000519F3 File Offset: 0x000509F3
		// (set) Token: 0x060049C6 RID: 18886 RVA: 0x00051A05 File Offset: 0x00050A05
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

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x00051A13 File Offset: 0x00050A13
		// (set) Token: 0x060049C8 RID: 18888 RVA: 0x00051A25 File Offset: 0x00050A25
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

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x060049C9 RID: 18889 RVA: 0x00051A33 File Offset: 0x00050A33
		// (set) Token: 0x060049CA RID: 18890 RVA: 0x00051A45 File Offset: 0x00050A45
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

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x060049CB RID: 18891 RVA: 0x00051A53 File Offset: 0x00050A53
		// (set) Token: 0x060049CC RID: 18892 RVA: 0x00051A65 File Offset: 0x00050A65
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

		// Token: 0x060049CD RID: 18893 RVA: 0x00051A73 File Offset: 0x00050A73
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00051A91 File Offset: 0x00050A91
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x00051AAE File Offset: 0x00050AAE
		// (set) Token: 0x060049D0 RID: 18896 RVA: 0x00051AC0 File Offset: 0x00050AC0
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

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x00051ACE File Offset: 0x00050ACE
		// (set) Token: 0x060049D2 RID: 18898 RVA: 0x00051AE0 File Offset: 0x00050AE0
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

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x060049D3 RID: 18899 RVA: 0x00051AEE File Offset: 0x00050AEE
		// (set) Token: 0x060049D4 RID: 18900 RVA: 0x00051B00 File Offset: 0x00050B00
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

		// Token: 0x060049D5 RID: 18901 RVA: 0x00051B0E File Offset: 0x00050B0E
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00051B2C File Offset: 0x00050B2C
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x060049D7 RID: 18903 RVA: 0x00051B49 File Offset: 0x00050B49
		// (set) Token: 0x060049D8 RID: 18904 RVA: 0x00051B5B File Offset: 0x00050B5B
		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntField(555).Value;
			}
			set
			{
				this.AddIntField(555, value);
			}
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00051B69 File Offset: 0x00050B69
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00051B87 File Offset: 0x00050B87
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x060049DB RID: 18907 RVA: 0x00051BA4 File Offset: 0x00050BA4
		// (set) Token: 0x060049DC RID: 18908 RVA: 0x00051BB3 File Offset: 0x00050BB3
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

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x060049DD RID: 18909 RVA: 0x00051BBE File Offset: 0x00050BBE
		// (set) Token: 0x060049DE RID: 18910 RVA: 0x00051BCD File Offset: 0x00050BCD
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

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x060049DF RID: 18911 RVA: 0x00051BD8 File Offset: 0x00050BD8
		// (set) Token: 0x060049E0 RID: 18912 RVA: 0x00051BE7 File Offset: 0x00050BE7
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

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x00051BF2 File Offset: 0x00050BF2
		// (set) Token: 0x060049E2 RID: 18914 RVA: 0x00051C01 File Offset: 0x00050C01
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

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x00051C0C File Offset: 0x00050C0C
		// (set) Token: 0x060049E4 RID: 18916 RVA: 0x00051C1B File Offset: 0x00050C1B
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

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x060049E5 RID: 18917 RVA: 0x00051C26 File Offset: 0x00050C26
		// (set) Token: 0x060049E6 RID: 18918 RVA: 0x00051C35 File Offset: 0x00050C35
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

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x00051C40 File Offset: 0x00050C40
		// (set) Token: 0x060049E8 RID: 18920 RVA: 0x00051C4F File Offset: 0x00050C4F
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

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x00051C5A File Offset: 0x00050C5A
		// (set) Token: 0x060049EA RID: 18922 RVA: 0x00051C6C File Offset: 0x00050C6C
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

		// Token: 0x060049EB RID: 18923 RVA: 0x00051C7A File Offset: 0x00050C7A
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00051C98 File Offset: 0x00050C98
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x060049ED RID: 18925 RVA: 0x00051CB5 File Offset: 0x00050CB5
		// (set) Token: 0x060049EE RID: 18926 RVA: 0x00051CC4 File Offset: 0x00050CC4
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

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x00051CCF File Offset: 0x00050CCF
		// (set) Token: 0x060049F0 RID: 18928 RVA: 0x00051CE1 File Offset: 0x00050CE1
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

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x00051CEF File Offset: 0x00050CEF
		// (set) Token: 0x060049F2 RID: 18930 RVA: 0x00051CFE File Offset: 0x00050CFE
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

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x00051D09 File Offset: 0x00050D09
		// (set) Token: 0x060049F4 RID: 18932 RVA: 0x00051D18 File Offset: 0x00050D18
		[FIXField("60", EFieldOption.Required)]
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

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x00051D23 File Offset: 0x00050D23
		// (set) Token: 0x060049F6 RID: 18934 RVA: 0x00051D35 File Offset: 0x00050D35
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

		// Token: 0x060049F7 RID: 18935 RVA: 0x00051D43 File Offset: 0x00050D43
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00051D61 File Offset: 0x00050D61
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x00051D7E File Offset: 0x00050D7E
		// (set) Token: 0x060049FA RID: 18938 RVA: 0x00051D8D File Offset: 0x00050D8D
		[FIXField("40", EFieldOption.Required)]
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

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x00051D98 File Offset: 0x00050D98
		// (set) Token: 0x060049FC RID: 18940 RVA: 0x00051DAA File Offset: 0x00050DAA
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

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x00051DB8 File Offset: 0x00050DB8
		// (set) Token: 0x060049FE RID: 18942 RVA: 0x00051DC7 File Offset: 0x00050DC7
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

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x00051DD2 File Offset: 0x00050DD2
		// (set) Token: 0x06004A00 RID: 18944 RVA: 0x00051DE1 File Offset: 0x00050DE1
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

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x00051DEC File Offset: 0x00050DEC
		// (set) Token: 0x06004A02 RID: 18946 RVA: 0x00051DFE File Offset: 0x00050DFE
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

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x00051E0C File Offset: 0x00050E0C
		// (set) Token: 0x06004A04 RID: 18948 RVA: 0x00051E1E File Offset: 0x00050E1E
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

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06004A05 RID: 18949 RVA: 0x00051E2C File Offset: 0x00050E2C
		// (set) Token: 0x06004A06 RID: 18950 RVA: 0x00051E3E File Offset: 0x00050E3E
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

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x00051E4C File Offset: 0x00050E4C
		// (set) Token: 0x06004A08 RID: 18952 RVA: 0x00051E5E File Offset: 0x00050E5E
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

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x00051E6C File Offset: 0x00050E6C
		// (set) Token: 0x06004A0A RID: 18954 RVA: 0x00051E7E File Offset: 0x00050E7E
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

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x00051E8C File Offset: 0x00050E8C
		// (set) Token: 0x06004A0C RID: 18956 RVA: 0x00051E9E File Offset: 0x00050E9E
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

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x00051EAC File Offset: 0x00050EAC
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x00051EBE File Offset: 0x00050EBE
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

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x00051ECC File Offset: 0x00050ECC
		// (set) Token: 0x06004A10 RID: 18960 RVA: 0x00051EDE File Offset: 0x00050EDE
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

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x00051EEC File Offset: 0x00050EEC
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x00051EFE File Offset: 0x00050EFE
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

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x00051F0C File Offset: 0x00050F0C
		// (set) Token: 0x06004A14 RID: 18964 RVA: 0x00051F1E File Offset: 0x00050F1E
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

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x00051F2C File Offset: 0x00050F2C
		// (set) Token: 0x06004A16 RID: 18966 RVA: 0x00051F3E File Offset: 0x00050F3E
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

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x00051F4C File Offset: 0x00050F4C
		// (set) Token: 0x06004A18 RID: 18968 RVA: 0x00051F5E File Offset: 0x00050F5E
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

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x00051F6C File Offset: 0x00050F6C
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x00051F7E File Offset: 0x00050F7E
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

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00051F8C File Offset: 0x00050F8C
		// (set) Token: 0x06004A1C RID: 18972 RVA: 0x00051F9E File Offset: 0x00050F9E
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

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x00051FAC File Offset: 0x00050FAC
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x00051FBB File Offset: 0x00050FBB
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

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x00051FC6 File Offset: 0x00050FC6
		// (set) Token: 0x06004A20 RID: 18976 RVA: 0x00051FD8 File Offset: 0x00050FD8
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

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x00051FE6 File Offset: 0x00050FE6
		// (set) Token: 0x06004A22 RID: 18978 RVA: 0x00051FF5 File Offset: 0x00050FF5
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

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06004A23 RID: 18979 RVA: 0x00052000 File Offset: 0x00051000
		// (set) Token: 0x06004A24 RID: 18980 RVA: 0x0005200F File Offset: 0x0005100F
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

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x0005201A File Offset: 0x0005101A
		// (set) Token: 0x06004A26 RID: 18982 RVA: 0x00052029 File Offset: 0x00051029
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

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x00052034 File Offset: 0x00051034
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x00052046 File Offset: 0x00051046
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

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00052054 File Offset: 0x00051054
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x00052066 File Offset: 0x00051066
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

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00052074 File Offset: 0x00051074
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00052083 File Offset: 0x00051083
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

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x0005208E File Offset: 0x0005108E
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x000520A0 File Offset: 0x000510A0
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

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x000520AE File Offset: 0x000510AE
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x000520C0 File Offset: 0x000510C0
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

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x000520CE File Offset: 0x000510CE
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x000520E0 File Offset: 0x000510E0
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

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x000520EE File Offset: 0x000510EE
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x00052100 File Offset: 0x00051100
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

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x0005210E File Offset: 0x0005110E
		// (set) Token: 0x06004A36 RID: 18998 RVA: 0x00052120 File Offset: 0x00051120
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

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x0005212E File Offset: 0x0005112E
		// (set) Token: 0x06004A38 RID: 19000 RVA: 0x00052140 File Offset: 0x00051140
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

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x0005214E File Offset: 0x0005114E
		// (set) Token: 0x06004A3A RID: 19002 RVA: 0x00052160 File Offset: 0x00051160
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

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x0005216E File Offset: 0x0005116E
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x00052180 File Offset: 0x00051180
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

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x0005218E File Offset: 0x0005118E
		// (set) Token: 0x06004A3E RID: 19006 RVA: 0x000521A0 File Offset: 0x000511A0
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

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x000521AE File Offset: 0x000511AE
		// (set) Token: 0x06004A40 RID: 19008 RVA: 0x000521C0 File Offset: 0x000511C0
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

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x000521CE File Offset: 0x000511CE
		// (set) Token: 0x06004A42 RID: 19010 RVA: 0x000521E0 File Offset: 0x000511E0
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

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x000521EE File Offset: 0x000511EE
		// (set) Token: 0x06004A44 RID: 19012 RVA: 0x00052200 File Offset: 0x00051200
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

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06004A45 RID: 19013 RVA: 0x0005220E File Offset: 0x0005120E
		// (set) Token: 0x06004A46 RID: 19014 RVA: 0x00052220 File Offset: 0x00051220
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

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06004A47 RID: 19015 RVA: 0x0005222E File Offset: 0x0005122E
		// (set) Token: 0x06004A48 RID: 19016 RVA: 0x00052240 File Offset: 0x00051240
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

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06004A49 RID: 19017 RVA: 0x0005224E File Offset: 0x0005124E
		// (set) Token: 0x06004A4A RID: 19018 RVA: 0x00052260 File Offset: 0x00051260
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

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06004A4B RID: 19019 RVA: 0x0005226E File Offset: 0x0005126E
		// (set) Token: 0x06004A4C RID: 19020 RVA: 0x00052280 File Offset: 0x00051280
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

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06004A4D RID: 19021 RVA: 0x0005228E File Offset: 0x0005128E
		// (set) Token: 0x06004A4E RID: 19022 RVA: 0x000522A0 File Offset: 0x000512A0
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

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x000522AE File Offset: 0x000512AE
		// (set) Token: 0x06004A50 RID: 19024 RVA: 0x000522C0 File Offset: 0x000512C0
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

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x000522CE File Offset: 0x000512CE
		// (set) Token: 0x06004A52 RID: 19026 RVA: 0x000522E0 File Offset: 0x000512E0
		[FIXField("480", EFieldOption.Optional)]
		public char CancellationRights
		{
			get
			{
				return this.GetCharField(480).Value;
			}
			set
			{
				this.AddCharField(480, value);
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06004A53 RID: 19027 RVA: 0x000522EE File Offset: 0x000512EE
		// (set) Token: 0x06004A54 RID: 19028 RVA: 0x00052300 File Offset: 0x00051300
		[FIXField("481", EFieldOption.Optional)]
		public char MoneyLaunderingStatus
		{
			get
			{
				return this.GetCharField(481).Value;
			}
			set
			{
				this.AddCharField(481, value);
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x0005230E File Offset: 0x0005130E
		// (set) Token: 0x06004A56 RID: 19030 RVA: 0x00052320 File Offset: 0x00051320
		[FIXField("513", EFieldOption.Optional)]
		public string RegistID
		{
			get
			{
				return this.GetStringField(513).Value;
			}
			set
			{
				this.AddStringField(513, value);
			}
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x0005232E File Offset: 0x0005132E
		// (set) Token: 0x06004A58 RID: 19032 RVA: 0x00052340 File Offset: 0x00051340
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

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06004A59 RID: 19033 RVA: 0x0005234E File Offset: 0x0005134E
		// (set) Token: 0x06004A5A RID: 19034 RVA: 0x0005235D File Offset: 0x0005135D
		[FIXField("10", EFieldOption.Required)]
		public string CheckSum
		{
			get
			{
				return this.GetStringField(10).Value;
			}
			set
			{
				this.AddStringField(10, value);
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x00052368 File Offset: 0x00051368
		// (set) Token: 0x06004A5C RID: 19036 RVA: 0x00052377 File Offset: 0x00051377
		[FIXField("89", EFieldOption.Optional)]
		public string Signature
		{
			get
			{
				return this.GetStringField(89).Value;
			}
			set
			{
				this.AddStringField(89, value);
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06004A5D RID: 19037 RVA: 0x00052382 File Offset: 0x00051382
		// (set) Token: 0x06004A5E RID: 19038 RVA: 0x00052391 File Offset: 0x00051391
		[FIXField("93", EFieldOption.Optional)]
		public int SignatureLength
		{
			get
			{
				return this.GetIntField(93).Value;
			}
			set
			{
				this.AddIntField(93, value);
			}
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0005239C File Offset: 0x0005139C
		public FIXNewOrderCross()
		{
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00052414 File Offset: 0x00051414
		public FIXNewOrderCross(string CrossID, int CrossType, int CrossPrioritization, int NoSides, DateTime TransactTime, char OrdType)
		{
			this.CrossID = CrossID;
			this.CrossType = CrossType;
			this.CrossPrioritization = CrossPrioritization;
			this.NoSides = NoSides;
			this.TransactTime = TransactTime;
			this.OrdType = OrdType;
		}

		// Token: 0x04000DAC RID: 3500
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000DAD RID: 3501
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000DAE RID: 3502
		private ArrayList fSidesGroup = new ArrayList();

		// Token: 0x04000DAF RID: 3503
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000DB0 RID: 3504
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000DB1 RID: 3505
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000DB2 RID: 3506
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000DB3 RID: 3507
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x04000DB4 RID: 3508
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
