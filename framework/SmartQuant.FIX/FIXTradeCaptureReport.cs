using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200010E RID: 270
	public class FIXTradeCaptureReport : FIXMessage
	{
		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x000349B3 File Offset: 0x000339B3
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x000349C5 File Offset: 0x000339C5
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

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000349D3 File Offset: 0x000339D3
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x000349E2 File Offset: 0x000339E2
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

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x000349ED File Offset: 0x000339ED
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x000349FC File Offset: 0x000339FC
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

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x00034A07 File Offset: 0x00033A07
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x00034A16 File Offset: 0x00033A16
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

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x00034A21 File Offset: 0x00033A21
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x00034A30 File Offset: 0x00033A30
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

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x00034A3B File Offset: 0x00033A3B
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x00034A4A File Offset: 0x00033A4A
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

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x00034A55 File Offset: 0x00033A55
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x00034A67 File Offset: 0x00033A67
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

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x00034A75 File Offset: 0x00033A75
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x00034A84 File Offset: 0x00033A84
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

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x00034A8F File Offset: 0x00033A8F
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x00034A9E File Offset: 0x00033A9E
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

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x00034AA9 File Offset: 0x00033AA9
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00034AB8 File Offset: 0x00033AB8
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

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x00034AC3 File Offset: 0x00033AC3
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00034AD2 File Offset: 0x00033AD2
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

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x00034ADD File Offset: 0x00033ADD
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x00034AEF File Offset: 0x00033AEF
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

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x00034AFD File Offset: 0x00033AFD
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00034B0C File Offset: 0x00033B0C
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

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x00034B17 File Offset: 0x00033B17
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x00034B25 File Offset: 0x00033B25
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

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x00034B2F File Offset: 0x00033B2F
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x00034B3E File Offset: 0x00033B3E
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

		// Token: 0x060031DE RID: 12766 RVA: 0x00034B49 File Offset: 0x00033B49
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00034B5C File Offset: 0x00033B5C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x00034B6B File Offset: 0x00033B6B
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00034B7D File Offset: 0x00033B7D
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

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x00034B8B File Offset: 0x00033B8B
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00034B9D File Offset: 0x00033B9D
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

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x00034BAB File Offset: 0x00033BAB
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x00034BBA File Offset: 0x00033BBA
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

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x00034BC5 File Offset: 0x00033BC5
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x00034BD4 File Offset: 0x00033BD4
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

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x00034BDF File Offset: 0x00033BDF
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x00034BEE File Offset: 0x00033BEE
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

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x00034BF9 File Offset: 0x00033BF9
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x00034C08 File Offset: 0x00033C08
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

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x00034C13 File Offset: 0x00033C13
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x00034C25 File Offset: 0x00033C25
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

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x00034C33 File Offset: 0x00033C33
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x00034C45 File Offset: 0x00033C45
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

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x00034C53 File Offset: 0x00033C53
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x00034C65 File Offset: 0x00033C65
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

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x00034C73 File Offset: 0x00033C73
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x00034C85 File Offset: 0x00033C85
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

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x00034C93 File Offset: 0x00033C93
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x00034CA5 File Offset: 0x00033CA5
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

		// Token: 0x060031F6 RID: 12790 RVA: 0x00034CB3 File Offset: 0x00033CB3
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00034CD1 File Offset: 0x00033CD1
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x00034CEE File Offset: 0x00033CEE
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x00034D00 File Offset: 0x00033D00
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

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x00034D0E File Offset: 0x00033D0E
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x00034D20 File Offset: 0x00033D20
		[FIXField("571", EFieldOption.Required)]
		public string TradeReportID
		{
			get
			{
				return this.GetStringField(571).Value;
			}
			set
			{
				this.AddStringField(571, value);
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x00034D2E File Offset: 0x00033D2E
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x00034D40 File Offset: 0x00033D40
		[FIXField("487", EFieldOption.Optional)]
		public int TradeReportTransType
		{
			get
			{
				return this.GetIntField(487).Value;
			}
			set
			{
				this.AddIntField(487, value);
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x00034D4E File Offset: 0x00033D4E
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x00034D60 File Offset: 0x00033D60
		[FIXField("856", EFieldOption.Optional)]
		public int TradeReportType
		{
			get
			{
				return this.GetIntField(856).Value;
			}
			set
			{
				this.AddIntField(856, value);
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x00034D6E File Offset: 0x00033D6E
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x00034D80 File Offset: 0x00033D80
		[FIXField("568", EFieldOption.Optional)]
		public string TradeRequestID
		{
			get
			{
				return this.GetStringField(568).Value;
			}
			set
			{
				this.AddStringField(568, value);
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x00034D8E File Offset: 0x00033D8E
		// (set) Token: 0x06003203 RID: 12803 RVA: 0x00034DA0 File Offset: 0x00033DA0
		[FIXField("828", EFieldOption.Optional)]
		public int TrdType
		{
			get
			{
				return this.GetIntField(828).Value;
			}
			set
			{
				this.AddIntField(828, value);
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x00034DAE File Offset: 0x00033DAE
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x00034DC0 File Offset: 0x00033DC0
		[FIXField("829", EFieldOption.Optional)]
		public int TrdSubType
		{
			get
			{
				return this.GetIntField(829).Value;
			}
			set
			{
				this.AddIntField(829, value);
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x00034DCE File Offset: 0x00033DCE
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x00034DE0 File Offset: 0x00033DE0
		[FIXField("855", EFieldOption.Optional)]
		public int SecondaryTrdType
		{
			get
			{
				return this.GetIntField(855).Value;
			}
			set
			{
				this.AddIntField(855, value);
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x00034DEE File Offset: 0x00033DEE
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x00034E00 File Offset: 0x00033E00
		[FIXField("830", EFieldOption.Optional)]
		public string TransferReason
		{
			get
			{
				return this.GetStringField(830).Value;
			}
			set
			{
				this.AddStringField(830, value);
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x00034E0E File Offset: 0x00033E0E
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x00034E20 File Offset: 0x00033E20
		[FIXField("150", EFieldOption.Optional)]
		public char ExecType
		{
			get
			{
				return this.GetCharField(150).Value;
			}
			set
			{
				this.AddCharField(150, value);
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x00034E2E File Offset: 0x00033E2E
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00034E40 File Offset: 0x00033E40
		[FIXField("748", EFieldOption.Optional)]
		public int TotNumTradeReports
		{
			get
			{
				return this.GetIntField(748).Value;
			}
			set
			{
				this.AddIntField(748, value);
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x00034E4E File Offset: 0x00033E4E
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x00034E60 File Offset: 0x00033E60
		[FIXField("912", EFieldOption.Optional)]
		public bool LastRptRequested
		{
			get
			{
				return this.GetBoolField(912).Value;
			}
			set
			{
				this.AddBoolField(912, value);
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x00034E6E File Offset: 0x00033E6E
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x00034E80 File Offset: 0x00033E80
		[FIXField("325", EFieldOption.Optional)]
		public bool UnsolicitedIndicator
		{
			get
			{
				return this.GetBoolField(325).Value;
			}
			set
			{
				this.AddBoolField(325, value);
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x00034E8E File Offset: 0x00033E8E
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x00034EA0 File Offset: 0x00033EA0
		[FIXField("263", EFieldOption.Optional)]
		public char SubscriptionRequestType
		{
			get
			{
				return this.GetCharField(263).Value;
			}
			set
			{
				this.AddCharField(263, value);
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x00034EAE File Offset: 0x00033EAE
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x00034EC0 File Offset: 0x00033EC0
		[FIXField("572", EFieldOption.Optional)]
		public string TradeReportRefID
		{
			get
			{
				return this.GetStringField(572).Value;
			}
			set
			{
				this.AddStringField(572, value);
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x00034ECE File Offset: 0x00033ECE
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x00034EE0 File Offset: 0x00033EE0
		[FIXField("881", EFieldOption.Optional)]
		public string SecondaryTradeReportRefID
		{
			get
			{
				return this.GetStringField(881).Value;
			}
			set
			{
				this.AddStringField(881, value);
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x00034EEE File Offset: 0x00033EEE
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x00034F00 File Offset: 0x00033F00
		[FIXField("818", EFieldOption.Optional)]
		public string SecondaryTradeReportID
		{
			get
			{
				return this.GetStringField(818).Value;
			}
			set
			{
				this.AddStringField(818, value);
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x00034F0E File Offset: 0x00033F0E
		// (set) Token: 0x0600321B RID: 12827 RVA: 0x00034F20 File Offset: 0x00033F20
		[FIXField("820", EFieldOption.Optional)]
		public string TradeLinkID
		{
			get
			{
				return this.GetStringField(820).Value;
			}
			set
			{
				this.AddStringField(820, value);
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x00034F2E File Offset: 0x00033F2E
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x00034F40 File Offset: 0x00033F40
		[FIXField("880", EFieldOption.Optional)]
		public string TrdMatchID
		{
			get
			{
				return this.GetStringField(880).Value;
			}
			set
			{
				this.AddStringField(880, value);
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x00034F4E File Offset: 0x00033F4E
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x00034F5D File Offset: 0x00033F5D
		[FIXField("17", EFieldOption.Optional)]
		public string ExecID
		{
			get
			{
				return this.GetStringField(17).Value;
			}
			set
			{
				this.AddStringField(17, value);
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x00034F68 File Offset: 0x00033F68
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x00034F77 File Offset: 0x00033F77
		[FIXField("39", EFieldOption.Optional)]
		public char OrdStatus
		{
			get
			{
				return this.GetCharField(39).Value;
			}
			set
			{
				this.AddCharField(39, value);
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x00034F82 File Offset: 0x00033F82
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x00034F94 File Offset: 0x00033F94
		[FIXField("527", EFieldOption.Optional)]
		public string SecondaryExecID
		{
			get
			{
				return this.GetStringField(527).Value;
			}
			set
			{
				this.AddStringField(527, value);
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x00034FA2 File Offset: 0x00033FA2
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x00034FB4 File Offset: 0x00033FB4
		[FIXField("378", EFieldOption.Optional)]
		public int ExecRestatementReason
		{
			get
			{
				return this.GetIntField(378).Value;
			}
			set
			{
				this.AddIntField(378, value);
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x00034FC2 File Offset: 0x00033FC2
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x00034FD4 File Offset: 0x00033FD4
		[FIXField("570", EFieldOption.Required)]
		public bool PreviouslyReported
		{
			get
			{
				return this.GetBoolField(570).Value;
			}
			set
			{
				this.AddBoolField(570, value);
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x00034FE2 File Offset: 0x00033FE2
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x00034FF4 File Offset: 0x00033FF4
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x00035002 File Offset: 0x00034002
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x00035011 File Offset: 0x00034011
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

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x0003501C File Offset: 0x0003401C
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x0003502B File Offset: 0x0003402B
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

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x00035036 File Offset: 0x00034036
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x00035045 File Offset: 0x00034045
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

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x00035050 File Offset: 0x00034050
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x0003505F File Offset: 0x0003405F
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

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x0003506A File Offset: 0x0003406A
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x0003507C File Offset: 0x0003407C
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

		// Token: 0x06003234 RID: 12852 RVA: 0x0003508A File Offset: 0x0003408A
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x000350A8 File Offset: 0x000340A8
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000350C5 File Offset: 0x000340C5
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x000350D7 File Offset: 0x000340D7
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

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x000350E5 File Offset: 0x000340E5
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x000350F7 File Offset: 0x000340F7
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

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x00035105 File Offset: 0x00034105
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x00035117 File Offset: 0x00034117
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

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x00035125 File Offset: 0x00034125
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x00035137 File Offset: 0x00034137
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

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x00035145 File Offset: 0x00034145
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x00035157 File Offset: 0x00034157
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

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x00035165 File Offset: 0x00034165
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x00035177 File Offset: 0x00034177
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x00035185 File Offset: 0x00034185
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x00035197 File Offset: 0x00034197
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000351A5 File Offset: 0x000341A5
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x000351B7 File Offset: 0x000341B7
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

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000351C5 File Offset: 0x000341C5
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x000351D7 File Offset: 0x000341D7
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

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x000351E5 File Offset: 0x000341E5
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x000351F7 File Offset: 0x000341F7
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

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x00035205 File Offset: 0x00034205
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x00035217 File Offset: 0x00034217
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

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x00035225 File Offset: 0x00034225
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x00035237 File Offset: 0x00034237
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

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x00035245 File Offset: 0x00034245
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x00035257 File Offset: 0x00034257
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

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x00035265 File Offset: 0x00034265
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x00035277 File Offset: 0x00034277
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

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x00035285 File Offset: 0x00034285
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x00035297 File Offset: 0x00034297
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

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x000352A5 File Offset: 0x000342A5
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x000352B7 File Offset: 0x000342B7
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

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000352C5 File Offset: 0x000342C5
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x000352D7 File Offset: 0x000342D7
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

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000352E5 File Offset: 0x000342E5
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x000352F7 File Offset: 0x000342F7
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

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x00035305 File Offset: 0x00034305
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x00035317 File Offset: 0x00034317
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

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x00035325 File Offset: 0x00034325
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x00035337 File Offset: 0x00034337
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

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x00035345 File Offset: 0x00034345
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x00035357 File Offset: 0x00034357
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

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x00035365 File Offset: 0x00034365
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x00035377 File Offset: 0x00034377
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x00035385 File Offset: 0x00034385
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x00035397 File Offset: 0x00034397
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

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x000353A5 File Offset: 0x000343A5
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x000353B7 File Offset: 0x000343B7
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

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x000353C5 File Offset: 0x000343C5
		// (set) Token: 0x06003267 RID: 12903 RVA: 0x000353D4 File Offset: 0x000343D4
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

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06003268 RID: 12904 RVA: 0x000353DF File Offset: 0x000343DF
		// (set) Token: 0x06003269 RID: 12905 RVA: 0x000353F1 File Offset: 0x000343F1
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

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x000353FF File Offset: 0x000343FF
		// (set) Token: 0x0600326B RID: 12907 RVA: 0x00035411 File Offset: 0x00034411
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

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x0600326C RID: 12908 RVA: 0x0003541F File Offset: 0x0003441F
		// (set) Token: 0x0600326D RID: 12909 RVA: 0x0003542E File Offset: 0x0003442E
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

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x00035439 File Offset: 0x00034439
		// (set) Token: 0x0600326F RID: 12911 RVA: 0x0003544B File Offset: 0x0003444B
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

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x00035459 File Offset: 0x00034459
		// (set) Token: 0x06003271 RID: 12913 RVA: 0x0003546B File Offset: 0x0003446B
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

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x00035479 File Offset: 0x00034479
		// (set) Token: 0x06003273 RID: 12915 RVA: 0x0003548B File Offset: 0x0003448B
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

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x00035499 File Offset: 0x00034499
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x000354AB File Offset: 0x000344AB
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

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x000354B9 File Offset: 0x000344B9
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x000354CB File Offset: 0x000344CB
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

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000354D9 File Offset: 0x000344D9
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x000354EB File Offset: 0x000344EB
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

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000354F9 File Offset: 0x000344F9
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x0003550B File Offset: 0x0003450B
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

		// Token: 0x0600327C RID: 12924 RVA: 0x00035519 File Offset: 0x00034519
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00035537 File Offset: 0x00034537
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x00035554 File Offset: 0x00034554
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x00035566 File Offset: 0x00034566
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

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x00035574 File Offset: 0x00034574
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x00035586 File Offset: 0x00034586
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

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x00035594 File Offset: 0x00034594
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x000355A6 File Offset: 0x000345A6
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringField(913).Value;
			}
			set
			{
				this.AddStringField(913, value);
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x000355B4 File Offset: 0x000345B4
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x000355C6 File Offset: 0x000345C6
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringField(914).Value;
			}
			set
			{
				this.AddStringField(914, value);
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x000355D4 File Offset: 0x000345D4
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x000355E6 File Offset: 0x000345E6
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeField(915).Value;
			}
			set
			{
				this.AddDateTimeField(915, value);
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x000355F4 File Offset: 0x000345F4
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x00035606 File Offset: 0x00034606
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleField(918).Value;
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x00035614 File Offset: 0x00034614
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x00035626 File Offset: 0x00034626
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntField(788).Value;
			}
			set
			{
				this.AddIntField(788, value);
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x00035634 File Offset: 0x00034634
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x00035646 File Offset: 0x00034646
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeField(916).Value;
			}
			set
			{
				this.AddDateTimeField(916, value);
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x00035654 File Offset: 0x00034654
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x00035666 File Offset: 0x00034666
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeField(917).Value;
			}
			set
			{
				this.AddDateTimeField(917, value);
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x00035674 File Offset: 0x00034674
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x00035686 File Offset: 0x00034686
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntField(919).Value;
			}
			set
			{
				this.AddIntField(919, value);
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x00035694 File Offset: 0x00034694
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x000356A6 File Offset: 0x000346A6
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleField(898).Value;
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x000356B4 File Offset: 0x000346B4
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x000356C3 File Offset: 0x000346C3
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

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x000356CE File Offset: 0x000346CE
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x000356E0 File Offset: 0x000346E0
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

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x000356EE File Offset: 0x000346EE
		// (set) Token: 0x06003299 RID: 12953 RVA: 0x00035700 File Offset: 0x00034700
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

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x0003570E File Offset: 0x0003470E
		// (set) Token: 0x0600329B RID: 12955 RVA: 0x00035720 File Offset: 0x00034720
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

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x0003572E File Offset: 0x0003472E
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x00035740 File Offset: 0x00034740
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

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x0003574E File Offset: 0x0003474E
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x00035760 File Offset: 0x00034760
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

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x0003576E File Offset: 0x0003476E
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x00035780 File Offset: 0x00034780
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

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x0003578E File Offset: 0x0003478E
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x000357A0 File Offset: 0x000347A0
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

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000357AE File Offset: 0x000347AE
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x000357C0 File Offset: 0x000347C0
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

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x000357CE File Offset: 0x000347CE
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x000357E0 File Offset: 0x000347E0
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

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000357EE File Offset: 0x000347EE
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x00035800 File Offset: 0x00034800
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

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x0003580E File Offset: 0x0003480E
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x00035820 File Offset: 0x00034820
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

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x0003582E File Offset: 0x0003482E
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x00035840 File Offset: 0x00034840
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

		// Token: 0x060032AE RID: 12974 RVA: 0x0003584E File Offset: 0x0003484E
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x0003586C File Offset: 0x0003486C
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x00035889 File Offset: 0x00034889
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x0003589B File Offset: 0x0003489B
		[FIXField("822", EFieldOption.Optional)]
		public string UnderlyingTradingSessionID
		{
			get
			{
				return this.GetStringField(822).Value;
			}
			set
			{
				this.AddStringField(822, value);
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000358A9 File Offset: 0x000348A9
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x000358BB File Offset: 0x000348BB
		[FIXField("823", EFieldOption.Optional)]
		public string UnderlyingTradingSessionSubID
		{
			get
			{
				return this.GetStringField(823).Value;
			}
			set
			{
				this.AddStringField(823, value);
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000358C9 File Offset: 0x000348C9
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x000358D8 File Offset: 0x000348D8
		[FIXField("32", EFieldOption.Required)]
		public double LastQty
		{
			get
			{
				return this.GetDoubleField(32).Value;
			}
			set
			{
				this.AddDoubleField(32, value);
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000358E3 File Offset: 0x000348E3
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x000358F2 File Offset: 0x000348F2
		[FIXField("31", EFieldOption.Required)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleField(31).Value;
			}
			set
			{
				this.AddDoubleField(31, value);
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000358FD File Offset: 0x000348FD
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x0003590F File Offset: 0x0003490F
		[FIXField("669", EFieldOption.Optional)]
		public double LastParPx
		{
			get
			{
				return this.GetDoubleField(669).Value;
			}
			set
			{
				this.AddDoubleField(669, value);
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x0003591D File Offset: 0x0003491D
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x0003592F File Offset: 0x0003492F
		[FIXField("194", EFieldOption.Optional)]
		public double LastSpotRate
		{
			get
			{
				return this.GetDoubleField(194).Value;
			}
			set
			{
				this.AddDoubleField(194, value);
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x0003593D File Offset: 0x0003493D
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x0003594F File Offset: 0x0003494F
		[FIXField("195", EFieldOption.Optional)]
		public double LastForwardPoints
		{
			get
			{
				return this.GetDoubleField(195).Value;
			}
			set
			{
				this.AddDoubleField(195, value);
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x0003595D File Offset: 0x0003495D
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x0003596C File Offset: 0x0003496C
		[FIXField("30", EFieldOption.Optional)]
		public string LastMkt
		{
			get
			{
				return this.GetStringField(30).Value;
			}
			set
			{
				this.AddStringField(30, value);
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x00035977 File Offset: 0x00034977
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x00035986 File Offset: 0x00034986
		[FIXField("75", EFieldOption.Required)]
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

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x00035991 File Offset: 0x00034991
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x000359A3 File Offset: 0x000349A3
		[FIXField("715", EFieldOption.Optional)]
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

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x000359B1 File Offset: 0x000349B1
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x000359BF File Offset: 0x000349BF
		[FIXField("6", EFieldOption.Optional)]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleField(6).Value;
			}
			set
			{
				this.AddDoubleField(6, value);
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x000359C9 File Offset: 0x000349C9
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x000359DB File Offset: 0x000349DB
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

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x000359E9 File Offset: 0x000349E9
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x000359FB File Offset: 0x000349FB
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

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x00035A09 File Offset: 0x00034A09
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00035A1B File Offset: 0x00034A1B
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

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x00035A29 File Offset: 0x00034A29
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x00035A3B File Offset: 0x00034A3B
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

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x00035A49 File Offset: 0x00034A49
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x00035A5B File Offset: 0x00034A5B
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

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x00035A69 File Offset: 0x00034A69
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x00035A7B File Offset: 0x00034A7B
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

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x00035A89 File Offset: 0x00034A89
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x00035A9B File Offset: 0x00034A9B
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

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x00035AA9 File Offset: 0x00034AA9
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x00035ABB File Offset: 0x00034ABB
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

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x00035AC9 File Offset: 0x00034AC9
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x00035ADB File Offset: 0x00034ADB
		[FIXField("819", EFieldOption.Optional)]
		public int AvgPxIndicator
		{
			get
			{
				return this.GetIntField(819).Value;
			}
			set
			{
				this.AddIntField(819, value);
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00035AE9 File Offset: 0x00034AE9
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00035AFB File Offset: 0x00034AFB
		[FIXField("753", EFieldOption.Optional)]
		public int NoPosAmt
		{
			get
			{
				return this.GetIntField(753).Value;
			}
			set
			{
				this.AddIntField(753, value);
			}
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00035B09 File Offset: 0x00034B09
		public FIXPosAmtGroup GetPosAmtGroup(int i)
		{
			if (i < this.NoPosAmt)
			{
				return (FIXPosAmtGroup)this.fPosAmtGroup[i];
			}
			return null;
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00035B27 File Offset: 0x00034B27
		public void AddGroup(FIXPosAmtGroup group)
		{
			this.fPosAmtGroup.Add(group);
			this.NoPosAmt++;
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x00035B44 File Offset: 0x00034B44
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x00035B56 File Offset: 0x00034B56
		[FIXField("442", EFieldOption.Optional)]
		public char MultiLegReportingType
		{
			get
			{
				return this.GetCharField(442).Value;
			}
			set
			{
				this.AddCharField(442, value);
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x00035B64 File Offset: 0x00034B64
		// (set) Token: 0x060032DF RID: 13023 RVA: 0x00035B76 File Offset: 0x00034B76
		[FIXField("824", EFieldOption.Optional)]
		public string TradeLegRefID
		{
			get
			{
				return this.GetStringField(824).Value;
			}
			set
			{
				this.AddStringField(824, value);
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x00035B84 File Offset: 0x00034B84
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x00035B96 File Offset: 0x00034B96
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

		// Token: 0x060032E2 RID: 13026 RVA: 0x00035BA4 File Offset: 0x00034BA4
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00035BC2 File Offset: 0x00034BC2
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x00035BDF File Offset: 0x00034BDF
		// (set) Token: 0x060032E5 RID: 13029 RVA: 0x00035BEE File Offset: 0x00034BEE
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

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x00035BF9 File Offset: 0x00034BF9
		// (set) Token: 0x060032E7 RID: 13031 RVA: 0x00035C0B File Offset: 0x00034C0B
		[FIXField("768", EFieldOption.Optional)]
		public int NoTrdRegTimestamps
		{
			get
			{
				return this.GetIntField(768).Value;
			}
			set
			{
				this.AddIntField(768, value);
			}
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x00035C19 File Offset: 0x00034C19
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x00035C37 File Offset: 0x00034C37
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x00035C54 File Offset: 0x00034C54
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x00035C63 File Offset: 0x00034C63
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x00035C6E File Offset: 0x00034C6E
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x00035C7D File Offset: 0x00034C7D
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

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x00035C88 File Offset: 0x00034C88
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x00035C9A File Offset: 0x00034C9A
		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharField(573).Value;
			}
			set
			{
				this.AddCharField(573, value);
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00035CA8 File Offset: 0x00034CA8
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00035CBA File Offset: 0x00034CBA
		[FIXField("574", EFieldOption.Optional)]
		public string MatchType
		{
			get
			{
				return this.GetStringField(574).Value;
			}
			set
			{
				this.AddStringField(574, value);
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00035CC8 File Offset: 0x00034CC8
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x00035CDA File Offset: 0x00034CDA
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

		// Token: 0x060032F4 RID: 13044 RVA: 0x00035CE8 File Offset: 0x00034CE8
		public FIXSidesGroup GetSidesGroup(int i)
		{
			if (i < this.NoSides)
			{
				return (FIXSidesGroup)this.fSidesGroup[i];
			}
			return null;
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00035D06 File Offset: 0x00034D06
		public void AddGroup(FIXSidesGroup group)
		{
			this.fSidesGroup.Add(group);
			this.NoSides++;
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00035D23 File Offset: 0x00034D23
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x00035D35 File Offset: 0x00034D35
		[FIXField("797", EFieldOption.Optional)]
		public bool CopyMsgIndicator
		{
			get
			{
				return this.GetBoolField(797).Value;
			}
			set
			{
				this.AddBoolField(797, value);
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x00035D43 File Offset: 0x00034D43
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x00035D55 File Offset: 0x00034D55
		[FIXField("852", EFieldOption.Optional)]
		public bool PublishTrdIndicator
		{
			get
			{
				return this.GetBoolField(852).Value;
			}
			set
			{
				this.AddBoolField(852, value);
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x00035D63 File Offset: 0x00034D63
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x00035D75 File Offset: 0x00034D75
		[FIXField("853", EFieldOption.Optional)]
		public int ShortSaleReason
		{
			get
			{
				return this.GetIntField(853).Value;
			}
			set
			{
				this.AddIntField(853, value);
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00035D83 File Offset: 0x00034D83
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x00035D92 File Offset: 0x00034D92
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

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x00035D9D File Offset: 0x00034D9D
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x00035DAC File Offset: 0x00034DAC
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

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00035DB7 File Offset: 0x00034DB7
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00035DC6 File Offset: 0x00034DC6
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

		// Token: 0x06003302 RID: 13058 RVA: 0x00035DD4 File Offset: 0x00034DD4
		public FIXTradeCaptureReport()
		{
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00035E4C File Offset: 0x00034E4C
		public FIXTradeCaptureReport(string TradeReportID, bool PreviouslyReported, double LastQty, double LastPx, DateTime TradeDate, DateTime TransactTime, int NoSides)
		{
			this.TradeReportID = TradeReportID;
			this.PreviouslyReported = PreviouslyReported;
			this.LastQty = LastQty;
			this.LastPx = LastPx;
			this.TradeDate = TradeDate;
			this.TransactTime = TransactTime;
			this.NoSides = NoSides;
		}

		// Token: 0x040004E1 RID: 1249
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040004E2 RID: 1250
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040004E3 RID: 1251
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040004E4 RID: 1252
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040004E5 RID: 1253
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040004E6 RID: 1254
		private ArrayList fPosAmtGroup = new ArrayList();

		// Token: 0x040004E7 RID: 1255
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040004E8 RID: 1256
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x040004E9 RID: 1257
		private ArrayList fSidesGroup = new ArrayList();
	}
}
