using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000172 RID: 370
	public class FIXEmail : FIXMessage
	{
		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06004505 RID: 17669 RVA: 0x0004CA73 File Offset: 0x0004BA73
		// (set) Token: 0x06004506 RID: 17670 RVA: 0x0004CA85 File Offset: 0x0004BA85
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

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x0004CA93 File Offset: 0x0004BA93
		// (set) Token: 0x06004508 RID: 17672 RVA: 0x0004CAA2 File Offset: 0x0004BAA2
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

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x0004CAAD File Offset: 0x0004BAAD
		// (set) Token: 0x0600450A RID: 17674 RVA: 0x0004CABC File Offset: 0x0004BABC
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

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x0004CAC7 File Offset: 0x0004BAC7
		// (set) Token: 0x0600450C RID: 17676 RVA: 0x0004CAD6 File Offset: 0x0004BAD6
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

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x0004CAE1 File Offset: 0x0004BAE1
		// (set) Token: 0x0600450E RID: 17678 RVA: 0x0004CAF0 File Offset: 0x0004BAF0
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

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x0004CAFB File Offset: 0x0004BAFB
		// (set) Token: 0x06004510 RID: 17680 RVA: 0x0004CB0A File Offset: 0x0004BB0A
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

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x0004CB15 File Offset: 0x0004BB15
		// (set) Token: 0x06004512 RID: 17682 RVA: 0x0004CB27 File Offset: 0x0004BB27
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

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x0004CB35 File Offset: 0x0004BB35
		// (set) Token: 0x06004514 RID: 17684 RVA: 0x0004CB44 File Offset: 0x0004BB44
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

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x0004CB4F File Offset: 0x0004BB4F
		// (set) Token: 0x06004516 RID: 17686 RVA: 0x0004CB5E File Offset: 0x0004BB5E
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

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x0004CB69 File Offset: 0x0004BB69
		// (set) Token: 0x06004518 RID: 17688 RVA: 0x0004CB78 File Offset: 0x0004BB78
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

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06004519 RID: 17689 RVA: 0x0004CB83 File Offset: 0x0004BB83
		// (set) Token: 0x0600451A RID: 17690 RVA: 0x0004CB92 File Offset: 0x0004BB92
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

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x0004CB9D File Offset: 0x0004BB9D
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x0004CBAF File Offset: 0x0004BBAF
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

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x0004CBBD File Offset: 0x0004BBBD
		// (set) Token: 0x0600451E RID: 17694 RVA: 0x0004CBCC File Offset: 0x0004BBCC
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

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x0004CBD7 File Offset: 0x0004BBD7
		// (set) Token: 0x06004520 RID: 17696 RVA: 0x0004CBE5 File Offset: 0x0004BBE5
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

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x0004CBEF File Offset: 0x0004BBEF
		// (set) Token: 0x06004522 RID: 17698 RVA: 0x0004CBFE File Offset: 0x0004BBFE
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

		// Token: 0x06004523 RID: 17699 RVA: 0x0004CC09 File Offset: 0x0004BC09
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x0004CC1C File Offset: 0x0004BC1C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x0004CC2B File Offset: 0x0004BC2B
		// (set) Token: 0x06004526 RID: 17702 RVA: 0x0004CC3D File Offset: 0x0004BC3D
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

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x0004CC4B File Offset: 0x0004BC4B
		// (set) Token: 0x06004528 RID: 17704 RVA: 0x0004CC5D File Offset: 0x0004BC5D
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

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x0004CC6B File Offset: 0x0004BC6B
		// (set) Token: 0x0600452A RID: 17706 RVA: 0x0004CC7A File Offset: 0x0004BC7A
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

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x0600452B RID: 17707 RVA: 0x0004CC85 File Offset: 0x0004BC85
		// (set) Token: 0x0600452C RID: 17708 RVA: 0x0004CC94 File Offset: 0x0004BC94
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

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x0004CC9F File Offset: 0x0004BC9F
		// (set) Token: 0x0600452E RID: 17710 RVA: 0x0004CCAE File Offset: 0x0004BCAE
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

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x0004CCB9 File Offset: 0x0004BCB9
		// (set) Token: 0x06004530 RID: 17712 RVA: 0x0004CCC8 File Offset: 0x0004BCC8
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

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x0004CCD3 File Offset: 0x0004BCD3
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x0004CCE5 File Offset: 0x0004BCE5
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

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x0004CCF3 File Offset: 0x0004BCF3
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x0004CD05 File Offset: 0x0004BD05
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

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x0004CD13 File Offset: 0x0004BD13
		// (set) Token: 0x06004536 RID: 17718 RVA: 0x0004CD25 File Offset: 0x0004BD25
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

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x0004CD33 File Offset: 0x0004BD33
		// (set) Token: 0x06004538 RID: 17720 RVA: 0x0004CD45 File Offset: 0x0004BD45
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

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x0004CD53 File Offset: 0x0004BD53
		// (set) Token: 0x0600453A RID: 17722 RVA: 0x0004CD65 File Offset: 0x0004BD65
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

		// Token: 0x0600453B RID: 17723 RVA: 0x0004CD73 File Offset: 0x0004BD73
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x0004CD91 File Offset: 0x0004BD91
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x0004CDAE File Offset: 0x0004BDAE
		// (set) Token: 0x0600453E RID: 17726 RVA: 0x0004CDC0 File Offset: 0x0004BDC0
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

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x0004CDCE File Offset: 0x0004BDCE
		// (set) Token: 0x06004540 RID: 17728 RVA: 0x0004CDE0 File Offset: 0x0004BDE0
		[FIXField("164", EFieldOption.Required)]
		public string EmailThreadID
		{
			get
			{
				return this.GetStringField(164).Value;
			}
			set
			{
				this.AddStringField(164, value);
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x0004CDEE File Offset: 0x0004BDEE
		// (set) Token: 0x06004542 RID: 17730 RVA: 0x0004CDFD File Offset: 0x0004BDFD
		[FIXField("94", EFieldOption.Required)]
		public char EmailType
		{
			get
			{
				return this.GetCharField(94).Value;
			}
			set
			{
				this.AddCharField(94, value);
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x0004CE08 File Offset: 0x0004BE08
		// (set) Token: 0x06004544 RID: 17732 RVA: 0x0004CE17 File Offset: 0x0004BE17
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

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x0004CE22 File Offset: 0x0004BE22
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x0004CE34 File Offset: 0x0004BE34
		[FIXField("147", EFieldOption.Required)]
		public string Subject
		{
			get
			{
				return this.GetStringField(147).Value;
			}
			set
			{
				this.AddStringField(147, value);
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x0004CE42 File Offset: 0x0004BE42
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x0004CE54 File Offset: 0x0004BE54
		[FIXField("356", EFieldOption.Optional)]
		public int EncodedSubjectLen
		{
			get
			{
				return this.GetIntField(356).Value;
			}
			set
			{
				this.AddIntField(356, value);
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x0004CE62 File Offset: 0x0004BE62
		// (set) Token: 0x0600454A RID: 17738 RVA: 0x0004CE74 File Offset: 0x0004BE74
		[FIXField("357", EFieldOption.Optional)]
		public string EncodedSubject
		{
			get
			{
				return this.GetStringField(357).Value;
			}
			set
			{
				this.AddStringField(357, value);
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x0004CE82 File Offset: 0x0004BE82
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x0004CE94 File Offset: 0x0004BE94
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

		// Token: 0x0600454D RID: 17741 RVA: 0x0004CEA2 File Offset: 0x0004BEA2
		public FIXRoutingIDsGroup GetRoutingIDsGroup(int i)
		{
			if (i < this.NoRoutingIDs)
			{
				return (FIXRoutingIDsGroup)this.fRoutingIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x0004CEC0 File Offset: 0x0004BEC0
		public void AddGroup(FIXRoutingIDsGroup group)
		{
			this.fRoutingIDsGroup.Add(group);
			this.NoRoutingIDs++;
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x0004CEDD File Offset: 0x0004BEDD
		// (set) Token: 0x06004550 RID: 17744 RVA: 0x0004CEEF File Offset: 0x0004BEEF
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

		// Token: 0x06004551 RID: 17745 RVA: 0x0004CEFD File Offset: 0x0004BEFD
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x0004CF1B File Offset: 0x0004BF1B
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06004553 RID: 17747 RVA: 0x0004CF38 File Offset: 0x0004BF38
		// (set) Token: 0x06004554 RID: 17748 RVA: 0x0004CF4A File Offset: 0x0004BF4A
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

		// Token: 0x06004555 RID: 17749 RVA: 0x0004CF58 File Offset: 0x0004BF58
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x0004CF76 File Offset: 0x0004BF76
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x0004CF93 File Offset: 0x0004BF93
		// (set) Token: 0x06004558 RID: 17752 RVA: 0x0004CFA5 File Offset: 0x0004BFA5
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

		// Token: 0x06004559 RID: 17753 RVA: 0x0004CFB3 File Offset: 0x0004BFB3
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x0004CFD1 File Offset: 0x0004BFD1
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x0600455B RID: 17755 RVA: 0x0004CFEE File Offset: 0x0004BFEE
		// (set) Token: 0x0600455C RID: 17756 RVA: 0x0004CFFD File Offset: 0x0004BFFD
		[FIXField("37", EFieldOption.Optional)]
		public string OrderID
		{
			get
			{
				return this.GetStringField(37).Value;
			}
			set
			{
				this.AddStringField(37, value);
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x0004D008 File Offset: 0x0004C008
		// (set) Token: 0x0600455E RID: 17758 RVA: 0x0004D017 File Offset: 0x0004C017
		[FIXField("11", EFieldOption.Optional)]
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

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x0004D022 File Offset: 0x0004C022
		// (set) Token: 0x06004560 RID: 17760 RVA: 0x0004D031 File Offset: 0x0004C031
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

		// Token: 0x06004561 RID: 17761 RVA: 0x0004D03C File Offset: 0x0004C03C
		public FIXLinesOfTextGroup GetLinesOfTextGroup(int i)
		{
			if (i < this.NoLinesOfText)
			{
				return (FIXLinesOfTextGroup)this.fLinesOfTextGroup[i];
			}
			return null;
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x0004D05A File Offset: 0x0004C05A
		public void AddGroup(FIXLinesOfTextGroup group)
		{
			this.fLinesOfTextGroup.Add(group);
			this.NoLinesOfText++;
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x0004D077 File Offset: 0x0004C077
		// (set) Token: 0x06004564 RID: 17764 RVA: 0x0004D086 File Offset: 0x0004C086
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

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x0004D091 File Offset: 0x0004C091
		// (set) Token: 0x06004566 RID: 17766 RVA: 0x0004D0A0 File Offset: 0x0004C0A0
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06004567 RID: 17767 RVA: 0x0004D0AB File Offset: 0x0004C0AB
		// (set) Token: 0x06004568 RID: 17768 RVA: 0x0004D0BA File Offset: 0x0004C0BA
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

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x0004D0C5 File Offset: 0x0004C0C5
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x0004D0D4 File Offset: 0x0004C0D4
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

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x0004D0DF File Offset: 0x0004C0DF
		// (set) Token: 0x0600456C RID: 17772 RVA: 0x0004D0EE File Offset: 0x0004C0EE
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

		// Token: 0x0600456D RID: 17773 RVA: 0x0004D0FC File Offset: 0x0004C0FC
		public FIXEmail()
		{
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x0004D15C File Offset: 0x0004C15C
		public FIXEmail(string EmailThreadID, char EmailType, string Subject, int NoLinesOfText)
		{
			this.EmailThreadID = EmailThreadID;
			this.EmailType = EmailType;
			this.Subject = Subject;
			this.NoLinesOfText = NoLinesOfText;
		}

		// Token: 0x04000D73 RID: 3443
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000D74 RID: 3444
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000D75 RID: 3445
		private ArrayList fRoutingIDsGroup = new ArrayList();

		// Token: 0x04000D76 RID: 3446
		private ArrayList fRelatedSymGroup = new ArrayList();

		// Token: 0x04000D77 RID: 3447
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000D78 RID: 3448
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000D79 RID: 3449
		private ArrayList fLinesOfTextGroup = new ArrayList();
	}
}
