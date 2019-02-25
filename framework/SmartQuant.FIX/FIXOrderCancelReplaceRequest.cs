using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200007D RID: 125
	public class FIXOrderCancelReplaceRequest : FIXMessage
	{
		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00019AD9 File Offset: 0x00018AD9
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x00019AE6 File Offset: 0x00018AE6
		[FIXField("144", EFieldOption.Optional)]
		public string OnBehalfOfLocationID
		{
			get
			{
				return this.GetStringValue(144);
			}
			set
			{
				this.SetStringValue(144, value);
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00019AF4 File Offset: 0x00018AF4
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x00019AFE File Offset: 0x00018AFE
		[FIXField("9", EFieldOption.Required)]
		public int BodyLength
		{
			get
			{
				return this.GetIntValue(9);
			}
			set
			{
				this.SetIntValue(9, value);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00019B09 File Offset: 0x00018B09
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x00019B13 File Offset: 0x00018B13
		[FIXField("35", EFieldOption.Required)]
		public string MsgType
		{
			get
			{
				return this.GetStringValue(35);
			}
			set
			{
				this.SetStringValue(35, value);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00019B1E File Offset: 0x00018B1E
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x00019B28 File Offset: 0x00018B28
		[FIXField("49", EFieldOption.Required)]
		public string SenderCompID
		{
			get
			{
				return this.GetStringValue(49);
			}
			set
			{
				this.SetStringValue(49, value);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00019B33 File Offset: 0x00018B33
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00019B3D File Offset: 0x00018B3D
		[FIXField("56", EFieldOption.Required)]
		public string TargetCompID
		{
			get
			{
				return this.GetStringValue(56);
			}
			set
			{
				this.SetStringValue(56, value);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00019B48 File Offset: 0x00018B48
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00019B52 File Offset: 0x00018B52
		[FIXField("115", EFieldOption.Optional)]
		public string OnBehalfOfCompID
		{
			get
			{
				return this.GetStringValue(115);
			}
			set
			{
				this.SetStringValue(115, value);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00019B5D File Offset: 0x00018B5D
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00019B6A File Offset: 0x00018B6A
		[FIXField("128", EFieldOption.Optional)]
		public string DeliverToCompID
		{
			get
			{
				return this.GetStringValue(128);
			}
			set
			{
				this.SetStringValue(128, value);
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00019B78 File Offset: 0x00018B78
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x00019B82 File Offset: 0x00018B82
		[FIXField("90", EFieldOption.Optional)]
		public int SecureDataLen
		{
			get
			{
				return this.GetIntValue(90);
			}
			set
			{
				this.SetIntValue(90, value);
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00019B8D File Offset: 0x00018B8D
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00019B97 File Offset: 0x00018B97
		[FIXField("91", EFieldOption.Optional)]
		public string SecureData
		{
			get
			{
				return this.GetStringValue(91);
			}
			set
			{
				this.SetStringValue(91, value);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00019BA2 File Offset: 0x00018BA2
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00019BAC File Offset: 0x00018BAC
		[FIXField("34", EFieldOption.Required)]
		public int MsgSeqNum
		{
			get
			{
				return this.GetIntValue(34);
			}
			set
			{
				this.SetIntValue(34, value);
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x00019BB7 File Offset: 0x00018BB7
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00019BC1 File Offset: 0x00018BC1
		[FIXField("50", EFieldOption.Optional)]
		public string SenderSubID
		{
			get
			{
				return this.GetStringValue(50);
			}
			set
			{
				this.SetStringValue(50, value);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00019BCC File Offset: 0x00018BCC
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00019BD9 File Offset: 0x00018BD9
		[FIXField("142", EFieldOption.Optional)]
		public string SenderLocationID
		{
			get
			{
				return this.GetStringValue(142);
			}
			set
			{
				this.SetStringValue(142, value);
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00019BE7 File Offset: 0x00018BE7
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00019BF1 File Offset: 0x00018BF1
		[FIXField("57", EFieldOption.Optional)]
		public string TargetSubID
		{
			get
			{
				return this.GetStringValue(57);
			}
			set
			{
				this.SetStringValue(57, value);
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00019BFC File Offset: 0x00018BFC
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x00019C05 File Offset: 0x00018C05
		[FIXField("8", EFieldOption.Required)]
		public string BeginString
		{
			get
			{
				return this.GetStringValue(8);
			}
			set
			{
				this.SetStringValue(8, value);
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00019C0F File Offset: 0x00018C0F
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00019C19 File Offset: 0x00018C19
		[FIXField("116", EFieldOption.Optional)]
		public string OnBehalfOfSubID
		{
			get
			{
				return this.GetStringValue(116);
			}
			set
			{
				this.SetStringValue(116, value);
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00019C24 File Offset: 0x00018C24
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00019C37 File Offset: 0x00018C37
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00019C46 File Offset: 0x00018C46
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x00019C53 File Offset: 0x00018C53
		[FIXField("129", EFieldOption.Optional)]
		public string DeliverToSubID
		{
			get
			{
				return this.GetStringValue(129);
			}
			set
			{
				this.SetStringValue(129, value);
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00019C61 File Offset: 0x00018C61
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x00019C6E File Offset: 0x00018C6E
		[FIXField("145", EFieldOption.Optional)]
		public string DeliverToLocationID
		{
			get
			{
				return this.GetStringValue(145);
			}
			set
			{
				this.SetStringValue(145, value);
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00019C7C File Offset: 0x00018C7C
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x00019C86 File Offset: 0x00018C86
		[FIXField("43", EFieldOption.Optional)]
		public bool PossDupFlag
		{
			get
			{
				return this.GetBoolValue(43);
			}
			set
			{
				this.SetBoolValue(43, value);
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00019C91 File Offset: 0x00018C91
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00019C9B File Offset: 0x00018C9B
		[FIXField("97", EFieldOption.Optional)]
		public bool PossResend
		{
			get
			{
				return this.GetBoolValue(97);
			}
			set
			{
				this.SetBoolValue(97, value);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00019CA6 File Offset: 0x00018CA6
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00019CB0 File Offset: 0x00018CB0
		[FIXField("52", EFieldOption.Optional)]
		public DateTime SendingTime
		{
			get
			{
				return this.GetDateTimeValue(52);
			}
			set
			{
				this.SetDateTimeValue(52, value);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00019CBB File Offset: 0x00018CBB
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00019CC5 File Offset: 0x00018CC5
		[FIXField("122", EFieldOption.Optional)]
		public DateTime OrigSendingTime
		{
			get
			{
				return this.GetDateTimeValue(122);
			}
			set
			{
				this.SetDateTimeValue(122, value);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00019CD0 File Offset: 0x00018CD0
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00019CDD File Offset: 0x00018CDD
		[FIXField("212", EFieldOption.Optional)]
		public int XmlDataLen
		{
			get
			{
				return this.GetIntValue(212);
			}
			set
			{
				this.SetIntValue(212, value);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00019CEB File Offset: 0x00018CEB
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00019CF8 File Offset: 0x00018CF8
		[FIXField("213", EFieldOption.Optional)]
		public string XmlData
		{
			get
			{
				return this.GetStringValue(213);
			}
			set
			{
				this.SetStringValue(213, value);
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00019D06 File Offset: 0x00018D06
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x00019D13 File Offset: 0x00018D13
		[FIXField("347", EFieldOption.Optional)]
		public string MessageEncoding
		{
			get
			{
				return this.GetStringValue(347);
			}
			set
			{
				this.SetStringValue(347, value);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00019D21 File Offset: 0x00018D21
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00019D2E File Offset: 0x00018D2E
		[FIXField("369", EFieldOption.Optional)]
		public int LastMsgSeqNumProcessed
		{
			get
			{
				return this.GetIntValue(369);
			}
			set
			{
				this.SetIntValue(369, value);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00019D3C File Offset: 0x00018D3C
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00019D49 File Offset: 0x00018D49
		[FIXField("627", EFieldOption.Optional)]
		public int NoHops
		{
			get
			{
				return this.GetIntValue(627);
			}
			set
			{
				this.SetIntValue(627, value);
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00019D57 File Offset: 0x00018D57
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00019D75 File Offset: 0x00018D75
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00019D92 File Offset: 0x00018D92
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00019D9F File Offset: 0x00018D9F
		[FIXField("143", EFieldOption.Optional)]
		public string TargetLocationID
		{
			get
			{
				return this.GetStringValue(143);
			}
			set
			{
				this.SetStringValue(143, value);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00019DAD File Offset: 0x00018DAD
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x00019DB7 File Offset: 0x00018DB7
		[FIXField("37", EFieldOption.Optional)]
		public string OrderID
		{
			get
			{
				return this.GetStringValue(37);
			}
			set
			{
				this.SetStringValue(37, value);
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x00019DC2 File Offset: 0x00018DC2
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x00019DCF File Offset: 0x00018DCF
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntValue(453);
			}
			set
			{
				this.SetIntValue(453, value);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00019DDD File Offset: 0x00018DDD
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00019DFB File Offset: 0x00018DFB
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00019E18 File Offset: 0x00018E18
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x00019E25 File Offset: 0x00018E25
		[FIXField("229", EFieldOption.Optional)]
		public DateTime TradeOriginationDate
		{
			get
			{
				return this.GetDateTimeValue(229);
			}
			set
			{
				this.SetDateTimeValue(229, value);
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00019E33 File Offset: 0x00018E33
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x00019E3D File Offset: 0x00018E3D
		[FIXField("75", EFieldOption.Optional)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeValue(75);
			}
			set
			{
				this.SetDateTimeValue(75, value);
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x00019E48 File Offset: 0x00018E48
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x00019E52 File Offset: 0x00018E52
		[FIXField("41", EFieldOption.Required)]
		public string OrigClOrdID
		{
			get
			{
				return this.GetStringValue(41);
			}
			set
			{
				this.SetStringValue(41, value);
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00019E5D File Offset: 0x00018E5D
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x00019E67 File Offset: 0x00018E67
		[FIXField("11", EFieldOption.Required)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringValue(11);
			}
			set
			{
				this.SetStringValue(11, value);
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x00019E72 File Offset: 0x00018E72
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x00019E7F File Offset: 0x00018E7F
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringValue(526);
			}
			set
			{
				this.SetStringValue(526, value);
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00019E8D File Offset: 0x00018E8D
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x00019E9A File Offset: 0x00018E9A
		[FIXField("583", EFieldOption.Optional)]
		public string ClOrdLinkID
		{
			get
			{
				return this.GetStringValue(583);
			}
			set
			{
				this.SetStringValue(583, value);
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x00019EA8 File Offset: 0x00018EA8
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x00019EB2 File Offset: 0x00018EB2
		[FIXField("66", EFieldOption.Optional)]
		public string ListID
		{
			get
			{
				return this.GetStringValue(66);
			}
			set
			{
				this.SetStringValue(66, value);
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x00019EBD File Offset: 0x00018EBD
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x00019ECA File Offset: 0x00018ECA
		[FIXField("586", EFieldOption.Optional)]
		public DateTime OrigOrdModTime
		{
			get
			{
				return this.GetDateTimeValue(586);
			}
			set
			{
				this.SetDateTimeValue(586, value);
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x00019ED8 File Offset: 0x00018ED8
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x00019EE1 File Offset: 0x00018EE1
		[FIXField("1", EFieldOption.Optional)]
		public string Account
		{
			get
			{
				return this.GetStringValue(1);
			}
			set
			{
				this.SetStringValue(1, value);
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x00019EEB File Offset: 0x00018EEB
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x00019EF8 File Offset: 0x00018EF8
		[FIXField("660", EFieldOption.Optional)]
		public int AcctIDSource
		{
			get
			{
				return this.GetIntValue(660);
			}
			set
			{
				this.SetIntValue(660, value);
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00019F06 File Offset: 0x00018F06
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x00019F13 File Offset: 0x00018F13
		[FIXField("581", EFieldOption.Optional)]
		public int AccountType
		{
			get
			{
				return this.GetIntValue(581);
			}
			set
			{
				this.SetIntValue(581, value);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x00019F21 File Offset: 0x00018F21
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x00019F2E File Offset: 0x00018F2E
		[FIXField("589", EFieldOption.Optional)]
		public char DayBookingInst
		{
			get
			{
				return this.GetCharValue(589);
			}
			set
			{
				this.SetCharValue(589, value);
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x00019F3C File Offset: 0x00018F3C
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x00019F49 File Offset: 0x00018F49
		[FIXField("590", EFieldOption.Optional)]
		public char BookingUnit
		{
			get
			{
				return this.GetCharValue(590);
			}
			set
			{
				this.SetCharValue(590, value);
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x00019F57 File Offset: 0x00018F57
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x00019F64 File Offset: 0x00018F64
		[FIXField("591", EFieldOption.Optional)]
		public char PreallocMethod
		{
			get
			{
				return this.GetCharValue(591);
			}
			set
			{
				this.SetCharValue(591, value);
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00019F72 File Offset: 0x00018F72
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x00019F7C File Offset: 0x00018F7C
		[FIXField("70", EFieldOption.Optional)]
		public string AllocID
		{
			get
			{
				return this.GetStringValue(70);
			}
			set
			{
				this.SetStringValue(70, value);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00019F87 File Offset: 0x00018F87
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x00019F91 File Offset: 0x00018F91
		[FIXField("78", EFieldOption.Optional)]
		public int NoAllocs
		{
			get
			{
				return this.GetIntValue(78);
			}
			set
			{
				this.SetIntValue(78, value);
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00019F9C File Offset: 0x00018F9C
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00019FBA File Offset: 0x00018FBA
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00019FD7 File Offset: 0x00018FD7
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00019FE1 File Offset: 0x00018FE1
		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharValue(63);
			}
			set
			{
				this.SetCharValue(63, value);
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00019FEC File Offset: 0x00018FEC
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00019FF6 File Offset: 0x00018FF6
		[FIXField("64", EFieldOption.Optional)]
		public DateTime SettlDate
		{
			get
			{
				return this.GetDateTimeValue(64);
			}
			set
			{
				this.SetDateTimeValue(64, value);
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0001A001 File Offset: 0x00019001
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0001A00E File Offset: 0x0001900E
		[FIXField("544", EFieldOption.Optional)]
		public char CashMargin
		{
			get
			{
				return this.GetCharValue(544);
			}
			set
			{
				this.SetCharValue(544, value);
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0001A01C File Offset: 0x0001901C
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0001A029 File Offset: 0x00019029
		[FIXField("635", EFieldOption.Optional)]
		public string ClearingFeeIndicator
		{
			get
			{
				return this.GetStringValue(635);
			}
			set
			{
				this.SetStringValue(635, value);
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0001A037 File Offset: 0x00019037
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x0001A041 File Offset: 0x00019041
		[FIXField("21", EFieldOption.Optional)]
		public char HandlInst
		{
			get
			{
				return this.GetCharValue(21);
			}
			set
			{
				this.SetCharValue(21, value);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0001A04C File Offset: 0x0001904C
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0001A056 File Offset: 0x00019056
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringValue(18);
			}
			set
			{
				this.SetStringValue(18, value);
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0001A061 File Offset: 0x00019061
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0001A06B File Offset: 0x0001906B
		[FIXField("110", EFieldOption.Optional)]
		public double MinQty
		{
			get
			{
				return this.GetDoubleValue(110);
			}
			set
			{
				this.AddDoubleField(110, value);
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0001A076 File Offset: 0x00019076
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x0001A080 File Offset: 0x00019080
		[FIXField("111", EFieldOption.Optional)]
		public double MaxFloor
		{
			get
			{
				return this.GetDoubleValue(111);
			}
			set
			{
				this.AddDoubleField(111, value);
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0001A08B File Offset: 0x0001908B
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x0001A095 File Offset: 0x00019095
		[FIXField("100", EFieldOption.Optional)]
		public string ExDestination
		{
			get
			{
				return this.GetStringValue(100);
			}
			set
			{
				this.SetStringValue(100, value);
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x0001A0A0 File Offset: 0x000190A0
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0001A0AD File Offset: 0x000190AD
		[FIXField("386", EFieldOption.Optional)]
		public int NoTradingSessions
		{
			get
			{
				return this.GetIntValue(386);
			}
			set
			{
				this.SetIntValue(386, value);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0001A0BB File Offset: 0x000190BB
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0001A0D9 File Offset: 0x000190D9
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0001A0F6 File Offset: 0x000190F6
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0001A100 File Offset: 0x00019100
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

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0001A10B File Offset: 0x0001910B
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0001A115 File Offset: 0x00019115
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

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0001A120 File Offset: 0x00019120
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0001A12A File Offset: 0x0001912A
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

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0001A135 File Offset: 0x00019135
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0001A13F File Offset: 0x0001913F
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

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0001A14A File Offset: 0x0001914A
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0001A157 File Offset: 0x00019157
		[FIXField("454", EFieldOption.Optional)]
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

		// Token: 0x0600178E RID: 6030 RVA: 0x0001A165 File Offset: 0x00019165
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0001A183 File Offset: 0x00019183
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0001A1A0 File Offset: 0x000191A0
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0001A1AD File Offset: 0x000191AD
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

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0001A1BB File Offset: 0x000191BB
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x0001A1C8 File Offset: 0x000191C8
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

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x0001A1D6 File Offset: 0x000191D6
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x0001A1E3 File Offset: 0x000191E3
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

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0001A1F1 File Offset: 0x000191F1
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0001A1FE File Offset: 0x000191FE
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

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0001A20C File Offset: 0x0001920C
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0001A219 File Offset: 0x00019219
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

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0001A227 File Offset: 0x00019227
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0001A234 File Offset: 0x00019234
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

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0001A242 File Offset: 0x00019242
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0001A24F File Offset: 0x0001924F
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

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0001A25D File Offset: 0x0001925D
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0001A26A File Offset: 0x0001926A
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

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0001A278 File Offset: 0x00019278
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x0001A285 File Offset: 0x00019285
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

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x0001A293 File Offset: 0x00019293
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x0001A2A0 File Offset: 0x000192A0
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

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0001A2AE File Offset: 0x000192AE
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x0001A2BB File Offset: 0x000192BB
		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleValue(227);
			}
			set
			{
				this.AddDoubleField(227, value);
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0001A2C9 File Offset: 0x000192C9
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x0001A2D6 File Offset: 0x000192D6
		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleValue(228);
			}
			set
			{
				this.AddDoubleField(228, value);
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0001A2E4 File Offset: 0x000192E4
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0001A2F1 File Offset: 0x000192F1
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

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0001A2FF File Offset: 0x000192FF
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x0001A30C File Offset: 0x0001930C
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0001A31A File Offset: 0x0001931A
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0001A327 File Offset: 0x00019327
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0001A335 File Offset: 0x00019335
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x0001A342 File Offset: 0x00019342
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

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0001A350 File Offset: 0x00019350
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0001A35D File Offset: 0x0001935D
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

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0001A36B File Offset: 0x0001936B
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0001A378 File Offset: 0x00019378
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

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0001A386 File Offset: 0x00019386
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0001A393 File Offset: 0x00019393
		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleValue(202);
			}
			set
			{
				this.AddDoubleField(202, value);
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0001A3A1 File Offset: 0x000193A1
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0001A3AE File Offset: 0x000193AE
		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleValue(947);
			}
			set
			{
				this.AddDoubleField(947, value);
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0001A3BC File Offset: 0x000193BC
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0001A3C9 File Offset: 0x000193C9
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

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0001A3D7 File Offset: 0x000193D7
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0001A3E4 File Offset: 0x000193E4
		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleValue(231);
			}
			set
			{
				this.AddDoubleField(231, value);
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0001A3F2 File Offset: 0x000193F2
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0001A3FF File Offset: 0x000193FF
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleValue(223);
			}
			set
			{
				this.AddDoubleField(223, value);
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0001A40D File Offset: 0x0001940D
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0001A41A File Offset: 0x0001941A
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

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0001A428 File Offset: 0x00019428
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0001A432 File Offset: 0x00019432
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

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0001A43D File Offset: 0x0001943D
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0001A44A File Offset: 0x0001944A
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

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0001A458 File Offset: 0x00019458
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0001A465 File Offset: 0x00019465
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

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0001A473 File Offset: 0x00019473
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0001A47D File Offset: 0x0001947D
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0001A488 File Offset: 0x00019488
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0001A495 File Offset: 0x00019495
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

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0001A4A3 File Offset: 0x000194A3
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0001A4B0 File Offset: 0x000194B0
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

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0001A4BE File Offset: 0x000194BE
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0001A4CB File Offset: 0x000194CB
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0001A4D9 File Offset: 0x000194D9
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0001A4E6 File Offset: 0x000194E6
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

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0001A4F4 File Offset: 0x000194F4
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0001A501 File Offset: 0x00019501
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

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0001A50F File Offset: 0x0001950F
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0001A51C File Offset: 0x0001951C
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

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0001A52A File Offset: 0x0001952A
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0001A537 File Offset: 0x00019537
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

		// Token: 0x060017D6 RID: 6102 RVA: 0x0001A545 File Offset: 0x00019545
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0001A563 File Offset: 0x00019563
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0001A580 File Offset: 0x00019580
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0001A58D File Offset: 0x0001958D
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

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0001A59B File Offset: 0x0001959B
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0001A5A8 File Offset: 0x000195A8
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

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0001A5B6 File Offset: 0x000195B6
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0001A5C3 File Offset: 0x000195C3
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

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0001A5D1 File Offset: 0x000195D1
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0001A5DE File Offset: 0x000195DE
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0001A5EC File Offset: 0x000195EC
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x0001A5F9 File Offset: 0x000195F9
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

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0001A607 File Offset: 0x00019607
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x0001A614 File Offset: 0x00019614
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleValue(918);
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0001A622 File Offset: 0x00019622
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x0001A62F File Offset: 0x0001962F
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

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0001A63D File Offset: 0x0001963D
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0001A64A File Offset: 0x0001964A
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

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0001A658 File Offset: 0x00019658
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0001A665 File Offset: 0x00019665
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0001A673 File Offset: 0x00019673
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x0001A680 File Offset: 0x00019680
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0001A68E File Offset: 0x0001968E
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x0001A69B File Offset: 0x0001969B
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleValue(898);
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0001A6A9 File Offset: 0x000196A9
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x0001A6B6 File Offset: 0x000196B6
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

		// Token: 0x060017F0 RID: 6128 RVA: 0x0001A6C4 File Offset: 0x000196C4
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0001A6E2 File Offset: 0x000196E2
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0001A6FF File Offset: 0x000196FF
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0001A709 File Offset: 0x00019709
		[FIXField("54", EFieldOption.Required)]
		public char Side
		{
			get
			{
				return this.GetCharValue(54);
			}
			set
			{
				this.SetCharValue(54, value);
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0001A714 File Offset: 0x00019714
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0001A71E File Offset: 0x0001971E
		[FIXField("60", EFieldOption.Required)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeValue(60);
			}
			set
			{
				this.SetDateTimeValue(60, value);
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0001A729 File Offset: 0x00019729
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0001A736 File Offset: 0x00019736
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntValue(854);
			}
			set
			{
				this.SetIntValue(854, value);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0001A744 File Offset: 0x00019744
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0001A74E File Offset: 0x0001974E
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleValue(38);
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x0001A759 File Offset: 0x00019759
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0001A766 File Offset: 0x00019766
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleValue(152);
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x0001A774 File Offset: 0x00019774
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x0001A781 File Offset: 0x00019781
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleValue(516);
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x0001A78F File Offset: 0x0001978F
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x0001A79C File Offset: 0x0001979C
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharValue(468);
			}
			set
			{
				this.SetCharValue(468, value);
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0001A7AA File Offset: 0x000197AA
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x0001A7B7 File Offset: 0x000197B7
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleValue(469);
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0001A7C5 File Offset: 0x000197C5
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x0001A7CF File Offset: 0x000197CF
		[FIXField("40", EFieldOption.Required)]
		public char OrdType
		{
			get
			{
				return this.GetCharValue(40);
			}
			set
			{
				this.SetCharValue(40, value);
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0001A7DA File Offset: 0x000197DA
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x0001A7E7 File Offset: 0x000197E7
		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntValue(423);
			}
			set
			{
				this.SetIntValue(423, value);
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0001A7F5 File Offset: 0x000197F5
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x0001A7FF File Offset: 0x000197FF
		[FIXField("44", EFieldOption.Optional)]
		public double Price
		{
			get
			{
				return this.GetDoubleValue(44);
			}
			set
			{
				this.AddDoubleField(44, value);
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0001A80A File Offset: 0x0001980A
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x0001A814 File Offset: 0x00019814
		[FIXField("99", EFieldOption.Optional)]
		public double StopPx
		{
			get
			{
				return this.GetDoubleValue(99);
			}
			set
			{
				this.AddDoubleField(99, value);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0001A81F File Offset: 0x0001981F
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x0001A82C File Offset: 0x0001982C
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleValue(218);
			}
			set
			{
				this.AddDoubleField(218, value);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0001A83A File Offset: 0x0001983A
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0001A847 File Offset: 0x00019847
		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleValue(220);
			}
			set
			{
				this.AddDoubleField(220, value);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0001A855 File Offset: 0x00019855
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x0001A862 File Offset: 0x00019862
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

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x0001A870 File Offset: 0x00019870
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x0001A87D File Offset: 0x0001987D
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

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x0001A88B File Offset: 0x0001988B
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x0001A898 File Offset: 0x00019898
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleValue(662);
			}
			set
			{
				this.AddDoubleField(662, value);
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x0001A8A6 File Offset: 0x000198A6
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x0001A8B3 File Offset: 0x000198B3
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0001A8C1 File Offset: 0x000198C1
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x0001A8CE File Offset: 0x000198CE
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

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0001A8DC File Offset: 0x000198DC
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0001A8E9 File Offset: 0x000198E9
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

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0001A8F7 File Offset: 0x000198F7
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x0001A904 File Offset: 0x00019904
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

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0001A912 File Offset: 0x00019912
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x0001A91F File Offset: 0x0001991F
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleValue(236);
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0001A92D File Offset: 0x0001992D
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0001A93A File Offset: 0x0001993A
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

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0001A948 File Offset: 0x00019948
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x0001A955 File Offset: 0x00019955
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

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x0001A963 File Offset: 0x00019963
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x0001A970 File Offset: 0x00019970
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleValue(697);
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x0001A97E File Offset: 0x0001997E
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0001A98B File Offset: 0x0001998B
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

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0001A999 File Offset: 0x00019999
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0001A9A6 File Offset: 0x000199A6
		[FIXField("211", EFieldOption.Optional)]
		public double PegOffsetValue
		{
			get
			{
				return this.GetDoubleValue(211);
			}
			set
			{
				this.AddDoubleField(211, value);
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x0001A9B4 File Offset: 0x000199B4
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0001A9C1 File Offset: 0x000199C1
		[FIXField("835", EFieldOption.Optional)]
		public int PegMoveType
		{
			get
			{
				return this.GetIntValue(835);
			}
			set
			{
				this.SetIntValue(835, value);
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0001A9CF File Offset: 0x000199CF
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0001A9DC File Offset: 0x000199DC
		[FIXField("836", EFieldOption.Optional)]
		public int PegOffsetType
		{
			get
			{
				return this.GetIntValue(836);
			}
			set
			{
				this.SetIntValue(836, value);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0001A9EA File Offset: 0x000199EA
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0001A9F7 File Offset: 0x000199F7
		[FIXField("837", EFieldOption.Optional)]
		public int PegLimitType
		{
			get
			{
				return this.GetIntValue(837);
			}
			set
			{
				this.SetIntValue(837, value);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x0001AA05 File Offset: 0x00019A05
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x0001AA12 File Offset: 0x00019A12
		[FIXField("838", EFieldOption.Optional)]
		public int PegRoundDirection
		{
			get
			{
				return this.GetIntValue(838);
			}
			set
			{
				this.SetIntValue(838, value);
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0001AA20 File Offset: 0x00019A20
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x0001AA2D File Offset: 0x00019A2D
		[FIXField("840", EFieldOption.Optional)]
		public int PegScope
		{
			get
			{
				return this.GetIntValue(840);
			}
			set
			{
				this.SetIntValue(840, value);
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0001AA3B File Offset: 0x00019A3B
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x0001AA48 File Offset: 0x00019A48
		[FIXField("388", EFieldOption.Optional)]
		public char DiscretionInst
		{
			get
			{
				return this.GetCharValue(388);
			}
			set
			{
				this.SetCharValue(388, value);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0001AA56 File Offset: 0x00019A56
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0001AA63 File Offset: 0x00019A63
		[FIXField("389", EFieldOption.Optional)]
		public double DiscretionOffsetValue
		{
			get
			{
				return this.GetDoubleValue(389);
			}
			set
			{
				this.AddDoubleField(389, value);
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0001AA71 File Offset: 0x00019A71
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0001AA7E File Offset: 0x00019A7E
		[FIXField("841", EFieldOption.Optional)]
		public int DiscretionMoveType
		{
			get
			{
				return this.GetIntValue(841);
			}
			set
			{
				this.SetIntValue(841, value);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0001AA8C File Offset: 0x00019A8C
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x0001AA99 File Offset: 0x00019A99
		[FIXField("842", EFieldOption.Optional)]
		public int DiscretionOffsetType
		{
			get
			{
				return this.GetIntValue(842);
			}
			set
			{
				this.SetIntValue(842, value);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x0001AAA7 File Offset: 0x00019AA7
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x0001AAB4 File Offset: 0x00019AB4
		[FIXField("843", EFieldOption.Optional)]
		public int DiscretionLimitType
		{
			get
			{
				return this.GetIntValue(843);
			}
			set
			{
				this.SetIntValue(843, value);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0001AAC2 File Offset: 0x00019AC2
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0001AACF File Offset: 0x00019ACF
		[FIXField("844", EFieldOption.Optional)]
		public int DiscretionRoundDirection
		{
			get
			{
				return this.GetIntValue(844);
			}
			set
			{
				this.SetIntValue(844, value);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0001AADD File Offset: 0x00019ADD
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0001AAEA File Offset: 0x00019AEA
		[FIXField("846", EFieldOption.Optional)]
		public int DiscretionScope
		{
			get
			{
				return this.GetIntValue(846);
			}
			set
			{
				this.SetIntValue(846, value);
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x0001AAF8 File Offset: 0x00019AF8
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x0001AB05 File Offset: 0x00019B05
		[FIXField("847", EFieldOption.Optional)]
		public int TargetStrategy
		{
			get
			{
				return this.GetIntValue(847);
			}
			set
			{
				this.SetIntValue(847, value);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x0001AB13 File Offset: 0x00019B13
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x0001AB20 File Offset: 0x00019B20
		[FIXField("848", EFieldOption.Optional)]
		public string TargetStrategyParameters
		{
			get
			{
				return this.GetStringValue(848);
			}
			set
			{
				this.SetStringValue(848, value);
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0001AB2E File Offset: 0x00019B2E
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0001AB3B File Offset: 0x00019B3B
		[FIXField("849", EFieldOption.Optional)]
		public double ParticipationRate
		{
			get
			{
				return this.GetDoubleValue(849);
			}
			set
			{
				this.AddDoubleField(849, value);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0001AB49 File Offset: 0x00019B49
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0001AB56 File Offset: 0x00019B56
		[FIXField("376", EFieldOption.Optional)]
		public string ComplianceID
		{
			get
			{
				return this.GetStringValue(376);
			}
			set
			{
				this.SetStringValue(376, value);
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x0001AB64 File Offset: 0x00019B64
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x0001AB71 File Offset: 0x00019B71
		[FIXField("377", EFieldOption.Optional)]
		public bool SolicitedFlag
		{
			get
			{
				return this.GetBoolValue(377);
			}
			set
			{
				this.SetBoolValue(377, value);
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0001AB7F File Offset: 0x00019B7F
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x0001AB89 File Offset: 0x00019B89
		[FIXField("15", EFieldOption.Optional)]
		public double Currency
		{
			get
			{
				return this.GetDoubleValue(15);
			}
			set
			{
				this.AddDoubleField(15, value);
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x0001AB94 File Offset: 0x00019B94
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0001AB9E File Offset: 0x00019B9E
		[FIXField("59", EFieldOption.Optional)]
		public char TimeInForce
		{
			get
			{
				return this.GetCharValue(59);
			}
			set
			{
				this.SetCharValue(59, value);
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x0001ABA9 File Offset: 0x00019BA9
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0001ABB6 File Offset: 0x00019BB6
		[FIXField("168", EFieldOption.Optional)]
		public DateTime EffectiveTime
		{
			get
			{
				return this.GetDateTimeValue(168);
			}
			set
			{
				this.SetDateTimeValue(168, value);
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0001ABC4 File Offset: 0x00019BC4
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x0001ABD1 File Offset: 0x00019BD1
		[FIXField("432", EFieldOption.Optional)]
		public DateTime ExpireDate
		{
			get
			{
				return this.GetDateTimeValue(432);
			}
			set
			{
				this.SetDateTimeValue(432, value);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0001ABDF File Offset: 0x00019BDF
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0001ABE9 File Offset: 0x00019BE9
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeValue(126);
			}
			set
			{
				this.SetDateTimeValue(126, value);
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0001ABF4 File Offset: 0x00019BF4
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0001AC01 File Offset: 0x00019C01
		[FIXField("427", EFieldOption.Optional)]
		public int GTBookingInst
		{
			get
			{
				return this.GetIntValue(427);
			}
			set
			{
				this.SetIntValue(427, value);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0001AC0F File Offset: 0x00019C0F
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0001AC19 File Offset: 0x00019C19
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleValue(12);
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0001AC24 File Offset: 0x00019C24
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0001AC2E File Offset: 0x00019C2E
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharValue(13);
			}
			set
			{
				this.SetCharValue(13, value);
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x0001AC39 File Offset: 0x00019C39
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0001AC46 File Offset: 0x00019C46
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleValue(479);
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0001AC54 File Offset: 0x00019C54
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x0001AC61 File Offset: 0x00019C61
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharValue(497);
			}
			set
			{
				this.SetCharValue(497, value);
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0001AC6F File Offset: 0x00019C6F
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x0001AC7C File Offset: 0x00019C7C
		[FIXField("528", EFieldOption.Optional)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharValue(528);
			}
			set
			{
				this.SetCharValue(528, value);
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x0001AC8A File Offset: 0x00019C8A
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x0001AC97 File Offset: 0x00019C97
		[FIXField("529", EFieldOption.Optional)]
		public string OrderRestrictions
		{
			get
			{
				return this.GetStringValue(529);
			}
			set
			{
				this.SetStringValue(529, value);
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x0001ACA5 File Offset: 0x00019CA5
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x0001ACB2 File Offset: 0x00019CB2
		[FIXField("582", EFieldOption.Optional)]
		public int CustOrderCapacity
		{
			get
			{
				return this.GetIntValue(582);
			}
			set
			{
				this.SetIntValue(582, value);
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0001ACC0 File Offset: 0x00019CC0
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x0001ACCA File Offset: 0x00019CCA
		[FIXField("121", EFieldOption.Optional)]
		public bool ForexReq
		{
			get
			{
				return this.GetBoolValue(121);
			}
			set
			{
				this.SetBoolValue(121, value);
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x0001ACD5 File Offset: 0x00019CD5
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x0001ACDF File Offset: 0x00019CDF
		[FIXField("120", EFieldOption.Optional)]
		public double SettlCurrency
		{
			get
			{
				return this.GetDoubleValue(120);
			}
			set
			{
				this.AddDoubleField(120, value);
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x0001ACEA File Offset: 0x00019CEA
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x0001ACF7 File Offset: 0x00019CF7
		[FIXField("775", EFieldOption.Optional)]
		public int BookingType
		{
			get
			{
				return this.GetIntValue(775);
			}
			set
			{
				this.SetIntValue(775, value);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x0001AD05 File Offset: 0x00019D05
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x0001AD0F File Offset: 0x00019D0F
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

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x0001AD1A File Offset: 0x00019D1A
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x0001AD27 File Offset: 0x00019D27
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

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0001AD35 File Offset: 0x00019D35
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0001AD42 File Offset: 0x00019D42
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

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0001AD50 File Offset: 0x00019D50
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0001AD5D File Offset: 0x00019D5D
		[FIXField("193", EFieldOption.Optional)]
		public DateTime SettlDate2
		{
			get
			{
				return this.GetDateTimeValue(193);
			}
			set
			{
				this.SetDateTimeValue(193, value);
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x0001AD6B File Offset: 0x00019D6B
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0001AD78 File Offset: 0x00019D78
		[FIXField("192", EFieldOption.Optional)]
		public double OrderQty2
		{
			get
			{
				return this.GetDoubleValue(192);
			}
			set
			{
				this.AddDoubleField(192, value);
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0001AD86 File Offset: 0x00019D86
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0001AD93 File Offset: 0x00019D93
		[FIXField("640", EFieldOption.Optional)]
		public double Price2
		{
			get
			{
				return this.GetDoubleValue(640);
			}
			set
			{
				this.AddDoubleField(640, value);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x0001ADA1 File Offset: 0x00019DA1
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0001ADAB File Offset: 0x00019DAB
		[FIXField("77", EFieldOption.Optional)]
		public char PositionEffect
		{
			get
			{
				return this.GetCharValue(77);
			}
			set
			{
				this.SetCharValue(77, value);
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0001ADB6 File Offset: 0x00019DB6
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0001ADC3 File Offset: 0x00019DC3
		[FIXField("203", EFieldOption.Optional)]
		public int CoveredOrUncovered
		{
			get
			{
				return this.GetIntValue(203);
			}
			set
			{
				this.SetIntValue(203, value);
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0001ADD1 File Offset: 0x00019DD1
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0001ADDE File Offset: 0x00019DDE
		[FIXField("210", EFieldOption.Optional)]
		public double MaxShow
		{
			get
			{
				return this.GetDoubleValue(210);
			}
			set
			{
				this.AddDoubleField(210, value);
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0001ADEC File Offset: 0x00019DEC
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0001ADF6 File Offset: 0x00019DF6
		[FIXField("114", EFieldOption.Optional)]
		public bool LocateReqd
		{
			get
			{
				return this.GetBoolValue(114);
			}
			set
			{
				this.SetBoolValue(114, value);
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0001AE01 File Offset: 0x00019E01
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0001AE0E File Offset: 0x00019E0E
		[FIXField("480", EFieldOption.Optional)]
		public char CancellationRights
		{
			get
			{
				return this.GetCharValue(480);
			}
			set
			{
				this.SetCharValue(480, value);
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0001AE1C File Offset: 0x00019E1C
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0001AE29 File Offset: 0x00019E29
		[FIXField("481", EFieldOption.Optional)]
		public char MoneyLaunderingStatus
		{
			get
			{
				return this.GetCharValue(481);
			}
			set
			{
				this.SetCharValue(481, value);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0001AE37 File Offset: 0x00019E37
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0001AE44 File Offset: 0x00019E44
		[FIXField("513", EFieldOption.Optional)]
		public string RegistID
		{
			get
			{
				return this.GetStringValue(513);
			}
			set
			{
				this.SetStringValue(513, value);
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0001AE52 File Offset: 0x00019E52
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0001AE5F File Offset: 0x00019E5F
		[FIXField("494", EFieldOption.Optional)]
		public string Designation
		{
			get
			{
				return this.GetStringValue(494);
			}
			set
			{
				this.SetStringValue(494, value);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x0001AE6D File Offset: 0x00019E6D
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x0001AE77 File Offset: 0x00019E77
		[FIXField("47", EFieldOption.Optional)]
		public char Rule80A
		{
			get
			{
				return this.GetCharValue(47);
			}
			set
			{
				this.SetCharValue(47, value);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x0001AE82 File Offset: 0x00019E82
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0001AE8F File Offset: 0x00019E8F
		[FIXField("204", EFieldOption.Optional)]
		public int CustomerOrFirm
		{
			get
			{
				return this.GetIntValue(204);
			}
			set
			{
				this.SetIntValue(204, value);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x0001AE9D File Offset: 0x00019E9D
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0001AEA7 File Offset: 0x00019EA7
		[FIXField("10", EFieldOption.Required)]
		public string CheckSum
		{
			get
			{
				return this.GetStringValue(10);
			}
			set
			{
				this.SetStringValue(10, value);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0001AEB2 File Offset: 0x00019EB2
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0001AEBC File Offset: 0x00019EBC
		[FIXField("89", EFieldOption.Optional)]
		public string Signature
		{
			get
			{
				return this.GetStringValue(89);
			}
			set
			{
				this.SetStringValue(89, value);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0001AEC7 File Offset: 0x00019EC7
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x0001AED1 File Offset: 0x00019ED1
		[FIXField("93", EFieldOption.Optional)]
		public int SignatureLength
		{
			get
			{
				return this.GetIntValue(93);
			}
			set
			{
				this.SetIntValue(93, value);
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0001AEDC File Offset: 0x00019EDC
		public FIXOrderCancelReplaceRequest()
		{
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0001AF48 File Offset: 0x00019F48
		public FIXOrderCancelReplaceRequest(string OrigClOrdID, string ClOrdID, char Side, DateTime TransactTime, char OrdType)
		{
			this.OrigClOrdID = OrigClOrdID;
			this.ClOrdID = ClOrdID;
			this.Side = Side;
			this.TransactTime = TransactTime;
			this.OrdType = OrdType;
		}

		// Token: 0x0400029A RID: 666
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400029B RID: 667
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400029C RID: 668
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400029D RID: 669
		private ArrayList fAllocsGroup = new ArrayList();

		// Token: 0x0400029E RID: 670
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x0400029F RID: 671
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040002A0 RID: 672
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040002A1 RID: 673
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
