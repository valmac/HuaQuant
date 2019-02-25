using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000097 RID: 151
	public class FIXNews : FIXMessage
	{
		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00020A02 File Offset: 0x0001FA02
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x00020A14 File Offset: 0x0001FA14
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

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00020A22 File Offset: 0x0001FA22
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00020A31 File Offset: 0x0001FA31
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

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00020A3C File Offset: 0x0001FA3C
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00020A4B File Offset: 0x0001FA4B
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

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00020A56 File Offset: 0x0001FA56
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00020A65 File Offset: 0x0001FA65
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

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x00020A70 File Offset: 0x0001FA70
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00020A7F File Offset: 0x0001FA7F
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

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00020A8A File Offset: 0x0001FA8A
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00020A99 File Offset: 0x0001FA99
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

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00020AA4 File Offset: 0x0001FAA4
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00020AB6 File Offset: 0x0001FAB6
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

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00020AC4 File Offset: 0x0001FAC4
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x00020AD3 File Offset: 0x0001FAD3
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

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00020ADE File Offset: 0x0001FADE
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x00020AED File Offset: 0x0001FAED
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

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00020AF8 File Offset: 0x0001FAF8
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x00020B07 File Offset: 0x0001FB07
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

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00020B12 File Offset: 0x0001FB12
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00020B21 File Offset: 0x0001FB21
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

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00020B2C File Offset: 0x0001FB2C
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00020B3E File Offset: 0x0001FB3E
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

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00020B4C File Offset: 0x0001FB4C
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00020B5B File Offset: 0x0001FB5B
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

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00020B66 File Offset: 0x0001FB66
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00020B74 File Offset: 0x0001FB74
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

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00020B7E File Offset: 0x0001FB7E
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00020B8D File Offset: 0x0001FB8D
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

		// Token: 0x06001E1E RID: 7710 RVA: 0x00020B98 File Offset: 0x0001FB98
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00020BAB File Offset: 0x0001FBAB
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00020BBA File Offset: 0x0001FBBA
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00020BCC File Offset: 0x0001FBCC
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

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00020BDA File Offset: 0x0001FBDA
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00020BEC File Offset: 0x0001FBEC
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

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00020BFA File Offset: 0x0001FBFA
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00020C09 File Offset: 0x0001FC09
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

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00020C14 File Offset: 0x0001FC14
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00020C23 File Offset: 0x0001FC23
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

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00020C2E File Offset: 0x0001FC2E
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00020C3D File Offset: 0x0001FC3D
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

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00020C48 File Offset: 0x0001FC48
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00020C57 File Offset: 0x0001FC57
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

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00020C62 File Offset: 0x0001FC62
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00020C74 File Offset: 0x0001FC74
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

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00020C82 File Offset: 0x0001FC82
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00020C94 File Offset: 0x0001FC94
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

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00020CA2 File Offset: 0x0001FCA2
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00020CB4 File Offset: 0x0001FCB4
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

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00020CC2 File Offset: 0x0001FCC2
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00020CD4 File Offset: 0x0001FCD4
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

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00020CE2 File Offset: 0x0001FCE2
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00020CF4 File Offset: 0x0001FCF4
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

		// Token: 0x06001E36 RID: 7734 RVA: 0x00020D02 File Offset: 0x0001FD02
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00020D20 File Offset: 0x0001FD20
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00020D3D File Offset: 0x0001FD3D
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x00020D4F File Offset: 0x0001FD4F
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

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00020D5D File Offset: 0x0001FD5D
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x00020D6C File Offset: 0x0001FD6C
		[FIXField("42", EFieldOption.Optional)]
		public DateTime OrigTime
		{
			get
			{
				return this.GetDateTimeField(42).Value;
			}
			set
			{
				this.AddDateTimeField(42, value);
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00020D77 File Offset: 0x0001FD77
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x00020D86 File Offset: 0x0001FD86
		[FIXField("61", EFieldOption.Optional)]
		public char Urgency
		{
			get
			{
				return this.GetCharField(61).Value;
			}
			set
			{
				this.AddCharField(61, value);
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00020D91 File Offset: 0x0001FD91
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x00020DA3 File Offset: 0x0001FDA3
		[FIXField("148", EFieldOption.Required)]
		public virtual string Headline
		{
			get
			{
				return this.GetStringField(148).Value;
			}
			set
			{
				this.AddStringField(148, value);
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00020DB1 File Offset: 0x0001FDB1
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00020DC3 File Offset: 0x0001FDC3
		[FIXField("358", EFieldOption.Optional)]
		public int EncodedHeadlineLen
		{
			get
			{
				return this.GetIntField(358).Value;
			}
			set
			{
				this.AddIntField(358, value);
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00020DD1 File Offset: 0x0001FDD1
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x00020DE3 File Offset: 0x0001FDE3
		[FIXField("359", EFieldOption.Optional)]
		public string EncodedHeadline
		{
			get
			{
				return this.GetStringField(359).Value;
			}
			set
			{
				this.AddStringField(359, value);
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00020DF1 File Offset: 0x0001FDF1
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x00020E03 File Offset: 0x0001FE03
		[FIXField("215", EFieldOption.Optional)]
		public int NoRoutingIDs
		{
			get
			{
				return this.GetIntField(215).Value;
			}
			set
			{
				this.AddIntField(215, value);
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00020E11 File Offset: 0x0001FE11
		public FIXRoutingIDsGroup GetRoutingIDsGroup(int i)
		{
			if (i < this.NoRoutingIDs)
			{
				return (FIXRoutingIDsGroup)this.fRoutingIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00020E2F File Offset: 0x0001FE2F
		public void AddGroup(FIXRoutingIDsGroup group)
		{
			this.fRoutingIDsGroup.Add(group);
			this.NoRoutingIDs++;
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00020E4C File Offset: 0x0001FE4C
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00020E5E File Offset: 0x0001FE5E
		[FIXField("146", EFieldOption.Optional)]
		public int NoRelatedSym
		{
			get
			{
				return this.GetIntField(146).Value;
			}
			set
			{
				this.AddIntField(146, value);
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00020E6C File Offset: 0x0001FE6C
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00020E8A File Offset: 0x0001FE8A
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00020EA7 File Offset: 0x0001FEA7
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00020EB9 File Offset: 0x0001FEB9
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

		// Token: 0x06001E4E RID: 7758 RVA: 0x00020EC7 File Offset: 0x0001FEC7
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00020EE5 File Offset: 0x0001FEE5
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00020F02 File Offset: 0x0001FF02
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00020F14 File Offset: 0x0001FF14
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

		// Token: 0x06001E52 RID: 7762 RVA: 0x00020F22 File Offset: 0x0001FF22
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00020F40 File Offset: 0x0001FF40
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00020F5D File Offset: 0x0001FF5D
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x00020F6C File Offset: 0x0001FF6C
		[FIXField("33", EFieldOption.Required)]
		public int NoLinesOfText
		{
			get
			{
				return this.GetIntField(33).Value;
			}
			set
			{
				this.AddIntField(33, value);
			}
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00020F77 File Offset: 0x0001FF77
		public FIXLinesOfTextGroup GetLinesOfTextGroup(int i)
		{
			if (i < this.NoLinesOfText)
			{
				return (FIXLinesOfTextGroup)this.fLinesOfTextGroup[i];
			}
			return null;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00020F95 File Offset: 0x0001FF95
		public void AddGroup(FIXLinesOfTextGroup group)
		{
			this.fLinesOfTextGroup.Add(group);
			this.NoLinesOfText++;
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00020FB2 File Offset: 0x0001FFB2
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00020FC4 File Offset: 0x0001FFC4
		[FIXField("149", EFieldOption.Optional)]
		public string URLLink
		{
			get
			{
				return this.GetStringField(149).Value;
			}
			set
			{
				this.AddStringField(149, value);
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00020FD2 File Offset: 0x0001FFD2
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00020FE1 File Offset: 0x0001FFE1
		[FIXField("95", EFieldOption.Optional)]
		public int RawDataLength
		{
			get
			{
				return this.GetIntField(95).Value;
			}
			set
			{
				this.AddIntField(95, value);
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00020FEC File Offset: 0x0001FFEC
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00020FFB File Offset: 0x0001FFFB
		[FIXField("96", EFieldOption.Optional)]
		public string RawData
		{
			get
			{
				return this.GetStringField(96).Value;
			}
			set
			{
				this.AddStringField(96, value);
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00021006 File Offset: 0x00020006
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00021015 File Offset: 0x00020015
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

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00021020 File Offset: 0x00020020
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0002102F File Offset: 0x0002002F
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

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0002103A File Offset: 0x0002003A
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00021049 File Offset: 0x00020049
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

		// Token: 0x06001E64 RID: 7780 RVA: 0x00021054 File Offset: 0x00020054
		public FIXNews()
		{
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000210B4 File Offset: 0x000200B4
		public FIXNews(string Headline, int NoLinesOfText)
		{
			this.Headline = Headline;
			this.NoLinesOfText = NoLinesOfText;
		}

		// Token: 0x040002F4 RID: 756
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002F5 RID: 757
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002F6 RID: 758
		private ArrayList fRoutingIDsGroup = new ArrayList();

		// Token: 0x040002F7 RID: 759
		private ArrayList fRelatedSymGroup = new ArrayList();

		// Token: 0x040002F8 RID: 760
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040002F9 RID: 761
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040002FA RID: 762
		private ArrayList fLinesOfTextGroup = new ArrayList();
	}
}
