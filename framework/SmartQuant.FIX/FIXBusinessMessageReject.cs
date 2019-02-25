using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000CF RID: 207
	public class FIXBusinessMessageReject : FIXMessage
	{
		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x0002C4EA File Offset: 0x0002B4EA
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x0002C4FC File Offset: 0x0002B4FC
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

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0002C50A File Offset: 0x0002B50A
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x0002C519 File Offset: 0x0002B519
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

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x0002C524 File Offset: 0x0002B524
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x0002C533 File Offset: 0x0002B533
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

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x0002C53E File Offset: 0x0002B53E
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x0002C54D File Offset: 0x0002B54D
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

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x0002C558 File Offset: 0x0002B558
		// (set) Token: 0x0600299B RID: 10651 RVA: 0x0002C567 File Offset: 0x0002B567
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

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x0002C572 File Offset: 0x0002B572
		// (set) Token: 0x0600299D RID: 10653 RVA: 0x0002C581 File Offset: 0x0002B581
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

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x0002C58C File Offset: 0x0002B58C
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x0002C59E File Offset: 0x0002B59E
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

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x0002C5AC File Offset: 0x0002B5AC
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x0002C5BB File Offset: 0x0002B5BB
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

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x0002C5C6 File Offset: 0x0002B5C6
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x0002C5D5 File Offset: 0x0002B5D5
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

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0002C5E0 File Offset: 0x0002B5E0
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x0002C5EF File Offset: 0x0002B5EF
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

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x0002C5FA File Offset: 0x0002B5FA
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x0002C609 File Offset: 0x0002B609
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

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0002C614 File Offset: 0x0002B614
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x0002C626 File Offset: 0x0002B626
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

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x0002C634 File Offset: 0x0002B634
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0002C643 File Offset: 0x0002B643
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

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0002C64E File Offset: 0x0002B64E
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x0002C65C File Offset: 0x0002B65C
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

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0002C666 File Offset: 0x0002B666
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x0002C675 File Offset: 0x0002B675
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

		// Token: 0x060029B0 RID: 10672 RVA: 0x0002C680 File Offset: 0x0002B680
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0002C693 File Offset: 0x0002B693
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x0002C6A2 File Offset: 0x0002B6A2
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x0002C6B4 File Offset: 0x0002B6B4
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

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x0002C6C2 File Offset: 0x0002B6C2
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x0002C6D4 File Offset: 0x0002B6D4
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

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x0002C6E2 File Offset: 0x0002B6E2
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x0002C6F1 File Offset: 0x0002B6F1
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

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x0002C6FC File Offset: 0x0002B6FC
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x0002C70B File Offset: 0x0002B70B
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

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x0002C716 File Offset: 0x0002B716
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x0002C725 File Offset: 0x0002B725
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

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0002C730 File Offset: 0x0002B730
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x0002C73F File Offset: 0x0002B73F
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

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x0002C74A File Offset: 0x0002B74A
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x0002C75C File Offset: 0x0002B75C
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

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0002C76A File Offset: 0x0002B76A
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x0002C77C File Offset: 0x0002B77C
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

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0002C78A File Offset: 0x0002B78A
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x0002C79C File Offset: 0x0002B79C
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

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0002C7AA File Offset: 0x0002B7AA
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x0002C7BC File Offset: 0x0002B7BC
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

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x0002C7CA File Offset: 0x0002B7CA
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x0002C7DC File Offset: 0x0002B7DC
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

		// Token: 0x060029C8 RID: 10696 RVA: 0x0002C7EA File Offset: 0x0002B7EA
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0002C808 File Offset: 0x0002B808
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x0002C825 File Offset: 0x0002B825
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x0002C837 File Offset: 0x0002B837
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x0002C845 File Offset: 0x0002B845
		// (set) Token: 0x060029CD RID: 10701 RVA: 0x0002C854 File Offset: 0x0002B854
		[FIXField("45", EFieldOption.Optional)]
		public int RefSeqNum
		{
			get
			{
				return this.GetIntField(45).Value;
			}
			set
			{
				this.AddIntField(45, value);
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x0002C85F File Offset: 0x0002B85F
		// (set) Token: 0x060029CF RID: 10703 RVA: 0x0002C871 File Offset: 0x0002B871
		[FIXField("372", EFieldOption.Required)]
		public string RefMsgType
		{
			get
			{
				return this.GetStringField(372).Value;
			}
			set
			{
				this.AddStringField(372, value);
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x0002C87F File Offset: 0x0002B87F
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x0002C891 File Offset: 0x0002B891
		[FIXField("379", EFieldOption.Optional)]
		public string BusinessRejectRefID
		{
			get
			{
				return this.GetStringField(379).Value;
			}
			set
			{
				this.AddStringField(379, value);
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x0002C89F File Offset: 0x0002B89F
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x0002C8B1 File Offset: 0x0002B8B1
		[FIXField("380", EFieldOption.Required)]
		public int BusinessRejectReason
		{
			get
			{
				return this.GetIntField(380).Value;
			}
			set
			{
				this.AddIntField(380, value);
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x0002C8BF File Offset: 0x0002B8BF
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x0002C8CE File Offset: 0x0002B8CE
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

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x0002C8D9 File Offset: 0x0002B8D9
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x0002C8EB File Offset: 0x0002B8EB
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

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x0002C8F9 File Offset: 0x0002B8F9
		// (set) Token: 0x060029D9 RID: 10713 RVA: 0x0002C90B File Offset: 0x0002B90B
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x0002C919 File Offset: 0x0002B919
		// (set) Token: 0x060029DB RID: 10715 RVA: 0x0002C928 File Offset: 0x0002B928
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

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x0002C933 File Offset: 0x0002B933
		// (set) Token: 0x060029DD RID: 10717 RVA: 0x0002C942 File Offset: 0x0002B942
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x0002C94D File Offset: 0x0002B94D
		// (set) Token: 0x060029DF RID: 10719 RVA: 0x0002C95C File Offset: 0x0002B95C
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

		// Token: 0x060029E0 RID: 10720 RVA: 0x0002C967 File Offset: 0x0002B967
		public FIXBusinessMessageReject()
		{
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x0002C985 File Offset: 0x0002B985
		public FIXBusinessMessageReject(string RefMsgType, int BusinessRejectReason)
		{
			this.RefMsgType = RefMsgType;
			this.BusinessRejectReason = BusinessRejectReason;
		}

		// Token: 0x040003C1 RID: 961
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003C2 RID: 962
		private ArrayList fHopsGroup = new ArrayList();
	}
}
