using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000130 RID: 304
	public class FIXPositionMaintenanceRequest : FIXMessage
	{
		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x0003C781 File Offset: 0x0003B781
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x0003C793 File Offset: 0x0003B793
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

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x0003C7A1 File Offset: 0x0003B7A1
		// (set) Token: 0x06003973 RID: 14707 RVA: 0x0003C7B0 File Offset: 0x0003B7B0
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

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x0003C7BB File Offset: 0x0003B7BB
		// (set) Token: 0x06003975 RID: 14709 RVA: 0x0003C7CA File Offset: 0x0003B7CA
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

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x0003C7D5 File Offset: 0x0003B7D5
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x0003C7E4 File Offset: 0x0003B7E4
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

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x0003C7EF File Offset: 0x0003B7EF
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x0003C7FE File Offset: 0x0003B7FE
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

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x0003C809 File Offset: 0x0003B809
		// (set) Token: 0x0600397B RID: 14715 RVA: 0x0003C818 File Offset: 0x0003B818
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

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x0003C823 File Offset: 0x0003B823
		// (set) Token: 0x0600397D RID: 14717 RVA: 0x0003C835 File Offset: 0x0003B835
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

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x0003C843 File Offset: 0x0003B843
		// (set) Token: 0x0600397F RID: 14719 RVA: 0x0003C852 File Offset: 0x0003B852
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

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x0003C85D File Offset: 0x0003B85D
		// (set) Token: 0x06003981 RID: 14721 RVA: 0x0003C86C File Offset: 0x0003B86C
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

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06003982 RID: 14722 RVA: 0x0003C877 File Offset: 0x0003B877
		// (set) Token: 0x06003983 RID: 14723 RVA: 0x0003C886 File Offset: 0x0003B886
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

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x0003C891 File Offset: 0x0003B891
		// (set) Token: 0x06003985 RID: 14725 RVA: 0x0003C8A0 File Offset: 0x0003B8A0
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

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06003986 RID: 14726 RVA: 0x0003C8AB File Offset: 0x0003B8AB
		// (set) Token: 0x06003987 RID: 14727 RVA: 0x0003C8BD File Offset: 0x0003B8BD
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

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x0003C8CB File Offset: 0x0003B8CB
		// (set) Token: 0x06003989 RID: 14729 RVA: 0x0003C8DA File Offset: 0x0003B8DA
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

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x0003C8E5 File Offset: 0x0003B8E5
		// (set) Token: 0x0600398B RID: 14731 RVA: 0x0003C8F3 File Offset: 0x0003B8F3
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x0003C8FD File Offset: 0x0003B8FD
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x0003C90C File Offset: 0x0003B90C
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

		// Token: 0x0600398E RID: 14734 RVA: 0x0003C917 File Offset: 0x0003B917
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x0003C92A File Offset: 0x0003B92A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x0003C939 File Offset: 0x0003B939
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x0003C94B File Offset: 0x0003B94B
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

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x0003C959 File Offset: 0x0003B959
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x0003C96B File Offset: 0x0003B96B
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

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x0003C979 File Offset: 0x0003B979
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x0003C988 File Offset: 0x0003B988
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

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x0003C993 File Offset: 0x0003B993
		// (set) Token: 0x06003997 RID: 14743 RVA: 0x0003C9A2 File Offset: 0x0003B9A2
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

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x0003C9AD File Offset: 0x0003B9AD
		// (set) Token: 0x06003999 RID: 14745 RVA: 0x0003C9BC File Offset: 0x0003B9BC
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

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x0003C9C7 File Offset: 0x0003B9C7
		// (set) Token: 0x0600399B RID: 14747 RVA: 0x0003C9D6 File Offset: 0x0003B9D6
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

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0003C9E1 File Offset: 0x0003B9E1
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x0003C9F3 File Offset: 0x0003B9F3
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

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x0003CA01 File Offset: 0x0003BA01
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x0003CA13 File Offset: 0x0003BA13
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

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x0003CA21 File Offset: 0x0003BA21
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x0003CA33 File Offset: 0x0003BA33
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

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x060039A2 RID: 14754 RVA: 0x0003CA41 File Offset: 0x0003BA41
		// (set) Token: 0x060039A3 RID: 14755 RVA: 0x0003CA53 File Offset: 0x0003BA53
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

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x0003CA61 File Offset: 0x0003BA61
		// (set) Token: 0x060039A5 RID: 14757 RVA: 0x0003CA73 File Offset: 0x0003BA73
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

		// Token: 0x060039A6 RID: 14758 RVA: 0x0003CA81 File Offset: 0x0003BA81
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0003CA9F File Offset: 0x0003BA9F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0003CABC File Offset: 0x0003BABC
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x0003CACE File Offset: 0x0003BACE
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

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x0003CADC File Offset: 0x0003BADC
		// (set) Token: 0x060039AB RID: 14763 RVA: 0x0003CAEE File Offset: 0x0003BAEE
		[FIXField("710", EFieldOption.Required)]
		public string PosReqID
		{
			get
			{
				return this.GetStringField(710).Value;
			}
			set
			{
				this.AddStringField(710, value);
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x0003CAFC File Offset: 0x0003BAFC
		// (set) Token: 0x060039AD RID: 14765 RVA: 0x0003CB0E File Offset: 0x0003BB0E
		[FIXField("709", EFieldOption.Required)]
		public int PosTransType
		{
			get
			{
				return this.GetIntField(709).Value;
			}
			set
			{
				this.AddIntField(709, value);
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x0003CB1C File Offset: 0x0003BB1C
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x0003CB2E File Offset: 0x0003BB2E
		[FIXField("712", EFieldOption.Required)]
		public int PosMaintAction
		{
			get
			{
				return this.GetIntField(712).Value;
			}
			set
			{
				this.AddIntField(712, value);
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x0003CB3C File Offset: 0x0003BB3C
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x0003CB4E File Offset: 0x0003BB4E
		[FIXField("713", EFieldOption.Optional)]
		public string OrigPosReqRefID
		{
			get
			{
				return this.GetStringField(713).Value;
			}
			set
			{
				this.AddStringField(713, value);
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x0003CB5C File Offset: 0x0003BB5C
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x0003CB6E File Offset: 0x0003BB6E
		[FIXField("714", EFieldOption.Optional)]
		public string PosMaintRptRefID
		{
			get
			{
				return this.GetStringField(714).Value;
			}
			set
			{
				this.AddStringField(714, value);
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x0003CB7C File Offset: 0x0003BB7C
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x0003CB8E File Offset: 0x0003BB8E
		[FIXField("715", EFieldOption.Required)]
		public DateTime ClearingBusinessDate
		{
			get
			{
				return this.GetDateTimeField(715).Value;
			}
			set
			{
				this.AddDateTimeField(715, value);
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x0003CB9C File Offset: 0x0003BB9C
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x0003CBAE File Offset: 0x0003BBAE
		[FIXField("716", EFieldOption.Optional)]
		public string SettlSessID
		{
			get
			{
				return this.GetStringField(716).Value;
			}
			set
			{
				this.AddStringField(716, value);
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x0003CBBC File Offset: 0x0003BBBC
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x0003CBCE File Offset: 0x0003BBCE
		[FIXField("717", EFieldOption.Optional)]
		public string SettlSessSubID
		{
			get
			{
				return this.GetStringField(717).Value;
			}
			set
			{
				this.AddStringField(717, value);
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x0003CBDC File Offset: 0x0003BBDC
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x0003CBEE File Offset: 0x0003BBEE
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

		// Token: 0x060039BC RID: 14780 RVA: 0x0003CBFC File Offset: 0x0003BBFC
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x0003CC1A File Offset: 0x0003BC1A
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x0003CC37 File Offset: 0x0003BC37
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x0003CC45 File Offset: 0x0003BC45
		[FIXField("1", EFieldOption.Required)]
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

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x0003CC4F File Offset: 0x0003BC4F
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x0003CC61 File Offset: 0x0003BC61
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

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x0003CC6F File Offset: 0x0003BC6F
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x0003CC81 File Offset: 0x0003BC81
		[FIXField("581", EFieldOption.Required)]
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

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x0003CC8F File Offset: 0x0003BC8F
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x0003CC9E File Offset: 0x0003BC9E
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

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x0003CCA9 File Offset: 0x0003BCA9
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x0003CCB8 File Offset: 0x0003BCB8
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

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0003CCC3 File Offset: 0x0003BCC3
		// (set) Token: 0x060039C9 RID: 14793 RVA: 0x0003CCD2 File Offset: 0x0003BCD2
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

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x0003CCDD File Offset: 0x0003BCDD
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x0003CCEC File Offset: 0x0003BCEC
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

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x0003CCF7 File Offset: 0x0003BCF7
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x0003CD09 File Offset: 0x0003BD09
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

		// Token: 0x060039CE RID: 14798 RVA: 0x0003CD17 File Offset: 0x0003BD17
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x0003CD35 File Offset: 0x0003BD35
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0003CD52 File Offset: 0x0003BD52
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x0003CD64 File Offset: 0x0003BD64
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

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0003CD72 File Offset: 0x0003BD72
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x0003CD84 File Offset: 0x0003BD84
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

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x0003CD92 File Offset: 0x0003BD92
		// (set) Token: 0x060039D5 RID: 14805 RVA: 0x0003CDA4 File Offset: 0x0003BDA4
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

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060039D6 RID: 14806 RVA: 0x0003CDB2 File Offset: 0x0003BDB2
		// (set) Token: 0x060039D7 RID: 14807 RVA: 0x0003CDC4 File Offset: 0x0003BDC4
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

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x0003CDD2 File Offset: 0x0003BDD2
		// (set) Token: 0x060039D9 RID: 14809 RVA: 0x0003CDE4 File Offset: 0x0003BDE4
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

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x0003CDF2 File Offset: 0x0003BDF2
		// (set) Token: 0x060039DB RID: 14811 RVA: 0x0003CE04 File Offset: 0x0003BE04
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

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x0003CE12 File Offset: 0x0003BE12
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x0003CE24 File Offset: 0x0003BE24
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

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x0003CE32 File Offset: 0x0003BE32
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x0003CE44 File Offset: 0x0003BE44
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

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0003CE52 File Offset: 0x0003BE52
		// (set) Token: 0x060039E1 RID: 14817 RVA: 0x0003CE64 File Offset: 0x0003BE64
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

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x0003CE72 File Offset: 0x0003BE72
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x0003CE84 File Offset: 0x0003BE84
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

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x0003CE92 File Offset: 0x0003BE92
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x0003CEA4 File Offset: 0x0003BEA4
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

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0003CEB2 File Offset: 0x0003BEB2
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x0003CEC4 File Offset: 0x0003BEC4
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

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x0003CED2 File Offset: 0x0003BED2
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x0003CEE4 File Offset: 0x0003BEE4
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

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x0003CEF2 File Offset: 0x0003BEF2
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x0003CF04 File Offset: 0x0003BF04
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

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x0003CF12 File Offset: 0x0003BF12
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x0003CF24 File Offset: 0x0003BF24
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

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x0003CF32 File Offset: 0x0003BF32
		// (set) Token: 0x060039EF RID: 14831 RVA: 0x0003CF44 File Offset: 0x0003BF44
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

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x0003CF52 File Offset: 0x0003BF52
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x0003CF64 File Offset: 0x0003BF64
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

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060039F2 RID: 14834 RVA: 0x0003CF72 File Offset: 0x0003BF72
		// (set) Token: 0x060039F3 RID: 14835 RVA: 0x0003CF84 File Offset: 0x0003BF84
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

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060039F4 RID: 14836 RVA: 0x0003CF92 File Offset: 0x0003BF92
		// (set) Token: 0x060039F5 RID: 14837 RVA: 0x0003CFA4 File Offset: 0x0003BFA4
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

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060039F6 RID: 14838 RVA: 0x0003CFB2 File Offset: 0x0003BFB2
		// (set) Token: 0x060039F7 RID: 14839 RVA: 0x0003CFC4 File Offset: 0x0003BFC4
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

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060039F8 RID: 14840 RVA: 0x0003CFD2 File Offset: 0x0003BFD2
		// (set) Token: 0x060039F9 RID: 14841 RVA: 0x0003CFE4 File Offset: 0x0003BFE4
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

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060039FA RID: 14842 RVA: 0x0003CFF2 File Offset: 0x0003BFF2
		// (set) Token: 0x060039FB RID: 14843 RVA: 0x0003D004 File Offset: 0x0003C004
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

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x0003D012 File Offset: 0x0003C012
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x0003D024 File Offset: 0x0003C024
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

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x0003D032 File Offset: 0x0003C032
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x0003D044 File Offset: 0x0003C044
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

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x0003D052 File Offset: 0x0003C052
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x0003D061 File Offset: 0x0003C061
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

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06003A02 RID: 14850 RVA: 0x0003D06C File Offset: 0x0003C06C
		// (set) Token: 0x06003A03 RID: 14851 RVA: 0x0003D07E File Offset: 0x0003C07E
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

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06003A04 RID: 14852 RVA: 0x0003D08C File Offset: 0x0003C08C
		// (set) Token: 0x06003A05 RID: 14853 RVA: 0x0003D09E File Offset: 0x0003C09E
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

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x0003D0AC File Offset: 0x0003C0AC
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x0003D0BB File Offset: 0x0003C0BB
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

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x0003D0C6 File Offset: 0x0003C0C6
		// (set) Token: 0x06003A09 RID: 14857 RVA: 0x0003D0D8 File Offset: 0x0003C0D8
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

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x0003D0E6 File Offset: 0x0003C0E6
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x0003D0F8 File Offset: 0x0003C0F8
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

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x0003D106 File Offset: 0x0003C106
		// (set) Token: 0x06003A0D RID: 14861 RVA: 0x0003D118 File Offset: 0x0003C118
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

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x0003D126 File Offset: 0x0003C126
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x0003D138 File Offset: 0x0003C138
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

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x0003D146 File Offset: 0x0003C146
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x0003D158 File Offset: 0x0003C158
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

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x0003D166 File Offset: 0x0003C166
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x0003D178 File Offset: 0x0003C178
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

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x0003D186 File Offset: 0x0003C186
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x0003D198 File Offset: 0x0003C198
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

		// Token: 0x06003A16 RID: 14870 RVA: 0x0003D1A6 File Offset: 0x0003C1A6
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x0003D1C4 File Offset: 0x0003C1C4
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x0003D1E1 File Offset: 0x0003C1E1
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x0003D1F3 File Offset: 0x0003C1F3
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

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x0003D201 File Offset: 0x0003C201
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x0003D213 File Offset: 0x0003C213
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

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x0003D221 File Offset: 0x0003C221
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x0003D230 File Offset: 0x0003C230
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

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x0003D23B File Offset: 0x0003C23B
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x0003D24D File Offset: 0x0003C24D
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

		// Token: 0x06003A20 RID: 14880 RVA: 0x0003D25B File Offset: 0x0003C25B
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x0003D279 File Offset: 0x0003C279
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x0003D296 File Offset: 0x0003C296
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x0003D2A8 File Offset: 0x0003C2A8
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

		// Token: 0x06003A24 RID: 14884 RVA: 0x0003D2B6 File Offset: 0x0003C2B6
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x0003D2D4 File Offset: 0x0003C2D4
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x0003D2F1 File Offset: 0x0003C2F1
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x0003D303 File Offset: 0x0003C303
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

		// Token: 0x06003A28 RID: 14888 RVA: 0x0003D311 File Offset: 0x0003C311
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x0003D32F File Offset: 0x0003C32F
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x0003D34C File Offset: 0x0003C34C
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x0003D35B File Offset: 0x0003C35B
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

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x0003D366 File Offset: 0x0003C366
		// (set) Token: 0x06003A2D RID: 14893 RVA: 0x0003D378 File Offset: 0x0003C378
		[FIXField("702", EFieldOption.Optional)]
		public int NoPositions
		{
			get
			{
				return this.GetIntField(702).Value;
			}
			set
			{
				this.AddIntField(702, value);
			}
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x0003D386 File Offset: 0x0003C386
		public FIXPositionsGroup GetPositionsGroup(int i)
		{
			if (i < this.NoPositions)
			{
				return (FIXPositionsGroup)this.fPositionsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x0003D3A4 File Offset: 0x0003C3A4
		public void AddGroup(FIXPositionsGroup group)
		{
			this.fPositionsGroup.Add(group);
			this.NoPositions++;
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x0003D3C1 File Offset: 0x0003C3C1
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x0003D3D3 File Offset: 0x0003C3D3
		[FIXField("718", EFieldOption.Optional)]
		public int AdjustmentType
		{
			get
			{
				return this.GetIntField(718).Value;
			}
			set
			{
				this.AddIntField(718, value);
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x0003D3E1 File Offset: 0x0003C3E1
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x0003D3F3 File Offset: 0x0003C3F3
		[FIXField("719", EFieldOption.Optional)]
		public bool ContraryInstructionIndicator
		{
			get
			{
				return this.GetBoolField(719).Value;
			}
			set
			{
				this.AddBoolField(719, value);
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x0003D401 File Offset: 0x0003C401
		// (set) Token: 0x06003A35 RID: 14901 RVA: 0x0003D413 File Offset: 0x0003C413
		[FIXField("720", EFieldOption.Optional)]
		public bool PriorSpreadIndicator
		{
			get
			{
				return this.GetBoolField(720).Value;
			}
			set
			{
				this.AddBoolField(720, value);
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x0003D421 File Offset: 0x0003C421
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x0003D433 File Offset: 0x0003C433
		[FIXField("834", EFieldOption.Optional)]
		public double ThresholdAmount
		{
			get
			{
				return this.GetDoubleField(834).Value;
			}
			set
			{
				this.AddDoubleField(834, value);
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x0003D441 File Offset: 0x0003C441
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x0003D450 File Offset: 0x0003C450
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

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x0003D45B File Offset: 0x0003C45B
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x0003D46D File Offset: 0x0003C46D
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

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x0003D47B File Offset: 0x0003C47B
		// (set) Token: 0x06003A3D RID: 14909 RVA: 0x0003D48D File Offset: 0x0003C48D
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

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x0003D49B File Offset: 0x0003C49B
		// (set) Token: 0x06003A3F RID: 14911 RVA: 0x0003D4AA File Offset: 0x0003C4AA
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

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x0003D4B5 File Offset: 0x0003C4B5
		// (set) Token: 0x06003A41 RID: 14913 RVA: 0x0003D4C4 File Offset: 0x0003C4C4
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

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x0003D4CF File Offset: 0x0003C4CF
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x0003D4DE File Offset: 0x0003C4DE
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

		// Token: 0x06003A44 RID: 14916 RVA: 0x0003D4EC File Offset: 0x0003C4EC
		public FIXPositionMaintenanceRequest()
		{
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x0003D564 File Offset: 0x0003C564
		public FIXPositionMaintenanceRequest(string PosReqID, int PosTransType, int PosMaintAction, DateTime ClearingBusinessDate, string Account, int AccountType, DateTime TransactTime)
		{
			this.PosReqID = PosReqID;
			this.PosTransType = PosTransType;
			this.PosMaintAction = PosMaintAction;
			this.ClearingBusinessDate = ClearingBusinessDate;
			this.Account = Account;
			this.AccountType = AccountType;
			this.TransactTime = TransactTime;
		}

		// Token: 0x04000528 RID: 1320
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000529 RID: 1321
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400052A RID: 1322
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400052B RID: 1323
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400052C RID: 1324
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400052D RID: 1325
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x0400052E RID: 1326
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400052F RID: 1327
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x04000530 RID: 1328
		private ArrayList fPositionsGroup = new ArrayList();
	}
}
