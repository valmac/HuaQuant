using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000066 RID: 102
	public class FIXNewOrderList : FIXMessage
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00014F7D File Offset: 0x00013F7D
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x00014F8F File Offset: 0x00013F8F
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

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00014F9D File Offset: 0x00013F9D
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x00014FAC File Offset: 0x00013FAC
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00014FB7 File Offset: 0x00013FB7
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x00014FC6 File Offset: 0x00013FC6
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00014FD1 File Offset: 0x00013FD1
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x00014FE0 File Offset: 0x00013FE0
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00014FEB File Offset: 0x00013FEB
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x00014FFA File Offset: 0x00013FFA
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

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00015005 File Offset: 0x00014005
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x00015014 File Offset: 0x00014014
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0001501F File Offset: 0x0001401F
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x00015031 File Offset: 0x00014031
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0001503F File Offset: 0x0001403F
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0001504E File Offset: 0x0001404E
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00015059 File Offset: 0x00014059
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00015068 File Offset: 0x00014068
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

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00015073 File Offset: 0x00014073
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00015082 File Offset: 0x00014082
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

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0001508D File Offset: 0x0001408D
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0001509C File Offset: 0x0001409C
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

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000150A7 File Offset: 0x000140A7
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x000150B9 File Offset: 0x000140B9
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

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000150C7 File Offset: 0x000140C7
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x000150D6 File Offset: 0x000140D6
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

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x000150E1 File Offset: 0x000140E1
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x000150EF File Offset: 0x000140EF
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000150F9 File Offset: 0x000140F9
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x00015108 File Offset: 0x00014108
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

		// Token: 0x060012B0 RID: 4784 RVA: 0x00015113 File Offset: 0x00014113
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00015126 File Offset: 0x00014126
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00015135 File Offset: 0x00014135
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x00015147 File Offset: 0x00014147
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

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00015155 File Offset: 0x00014155
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x00015167 File Offset: 0x00014167
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

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00015175 File Offset: 0x00014175
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00015184 File Offset: 0x00014184
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0001518F File Offset: 0x0001418F
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0001519E File Offset: 0x0001419E
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000151A9 File Offset: 0x000141A9
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x000151B8 File Offset: 0x000141B8
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000151C3 File Offset: 0x000141C3
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x000151D2 File Offset: 0x000141D2
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

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000151DD File Offset: 0x000141DD
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x000151EF File Offset: 0x000141EF
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

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000151FD File Offset: 0x000141FD
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x0001520F File Offset: 0x0001420F
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

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0001521D File Offset: 0x0001421D
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x0001522F File Offset: 0x0001422F
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

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0001523D File Offset: 0x0001423D
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x0001524F File Offset: 0x0001424F
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

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0001525D File Offset: 0x0001425D
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x0001526F File Offset: 0x0001426F
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

		// Token: 0x060012C8 RID: 4808 RVA: 0x0001527D File Offset: 0x0001427D
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0001529B File Offset: 0x0001429B
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x000152B8 File Offset: 0x000142B8
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x000152CA File Offset: 0x000142CA
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x000152D8 File Offset: 0x000142D8
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x000152E7 File Offset: 0x000142E7
		[FIXField("66", EFieldOption.Required)]
		public string ListID
		{
			get
			{
				return this.GetStringField(66).Value;
			}
			set
			{
				this.AddStringField(66, value);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000152F2 File Offset: 0x000142F2
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x00015304 File Offset: 0x00014304
		[FIXField("390", EFieldOption.Optional)]
		public string BidID
		{
			get
			{
				return this.GetStringField(390).Value;
			}
			set
			{
				this.AddStringField(390, value);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00015312 File Offset: 0x00014312
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x00015324 File Offset: 0x00014324
		[FIXField("391", EFieldOption.Optional)]
		public string ClientBidID
		{
			get
			{
				return this.GetStringField(391).Value;
			}
			set
			{
				this.AddStringField(391, value);
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00015332 File Offset: 0x00014332
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x00015344 File Offset: 0x00014344
		[FIXField("414", EFieldOption.Optional)]
		public int ProgRptReqs
		{
			get
			{
				return this.GetIntField(414).Value;
			}
			set
			{
				this.AddIntField(414, value);
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00015352 File Offset: 0x00014352
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x00015364 File Offset: 0x00014364
		[FIXField("394", EFieldOption.Required)]
		public int BidType
		{
			get
			{
				return this.GetIntField(394).Value;
			}
			set
			{
				this.AddIntField(394, value);
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00015372 File Offset: 0x00014372
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00015384 File Offset: 0x00014384
		[FIXField("415", EFieldOption.Optional)]
		public int ProgPeriodInterval
		{
			get
			{
				return this.GetIntField(415).Value;
			}
			set
			{
				this.AddIntField(415, value);
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00015392 File Offset: 0x00014392
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x000153A4 File Offset: 0x000143A4
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

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000153B2 File Offset: 0x000143B2
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x000153C4 File Offset: 0x000143C4
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x000153D2 File Offset: 0x000143D2
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x000153E4 File Offset: 0x000143E4
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x000153F2 File Offset: 0x000143F2
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x00015404 File Offset: 0x00014404
		[FIXField("433", EFieldOption.Optional)]
		public char ListExecInstType
		{
			get
			{
				return this.GetCharField(433).Value;
			}
			set
			{
				this.AddCharField(433, value);
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00015412 File Offset: 0x00014412
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00015421 File Offset: 0x00014421
		[FIXField("69", EFieldOption.Optional)]
		public string ListExecInst
		{
			get
			{
				return this.GetStringField(69).Value;
			}
			set
			{
				this.AddStringField(69, value);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0001542C File Offset: 0x0001442C
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x0001543E File Offset: 0x0001443E
		[FIXField("352", EFieldOption.Optional)]
		public int EncodedListExecInstLen
		{
			get
			{
				return this.GetIntField(352).Value;
			}
			set
			{
				this.AddIntField(352, value);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0001544C File Offset: 0x0001444C
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x0001545E File Offset: 0x0001445E
		[FIXField("353", EFieldOption.Optional)]
		public string EncodedListExecInst
		{
			get
			{
				return this.GetStringField(353).Value;
			}
			set
			{
				this.AddStringField(353, value);
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0001546C File Offset: 0x0001446C
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x0001547E File Offset: 0x0001447E
		[FIXField("765", EFieldOption.Optional)]
		public double AllowableOneSidednessPct
		{
			get
			{
				return this.GetDoubleField(765).Value;
			}
			set
			{
				this.AddDoubleField(765, value);
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0001548C File Offset: 0x0001448C
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x0001549E File Offset: 0x0001449E
		[FIXField("766", EFieldOption.Optional)]
		public double AllowableOneSidednessValue
		{
			get
			{
				return this.GetDoubleField(766).Value;
			}
			set
			{
				this.AddDoubleField(766, value);
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000154AC File Offset: 0x000144AC
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x000154BE File Offset: 0x000144BE
		[FIXField("767", EFieldOption.Optional)]
		public double AllowableOneSidednessCurr
		{
			get
			{
				return this.GetDoubleField(767).Value;
			}
			set
			{
				this.AddDoubleField(767, value);
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000154CC File Offset: 0x000144CC
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x000154DB File Offset: 0x000144DB
		[FIXField("68", EFieldOption.Required)]
		public int TotNoOrders
		{
			get
			{
				return this.GetIntField(68).Value;
			}
			set
			{
				this.AddIntField(68, value);
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000154E6 File Offset: 0x000144E6
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x000154F8 File Offset: 0x000144F8
		[FIXField("893", EFieldOption.Optional)]
		public bool LastFragment
		{
			get
			{
				return this.GetBoolField(893).Value;
			}
			set
			{
				this.AddBoolField(893, value);
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00015506 File Offset: 0x00014506
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00015515 File Offset: 0x00014515
		[FIXField("73", EFieldOption.Required)]
		public int NoOrders
		{
			get
			{
				return this.GetIntField(73).Value;
			}
			set
			{
				this.AddIntField(73, value);
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00015520 File Offset: 0x00014520
		public FIXOrdersGroup GetOrdersGroup(int i)
		{
			if (i < this.NoOrders)
			{
				return (FIXOrdersGroup)this.fOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0001553E File Offset: 0x0001453E
		public void AddGroup(FIXOrdersGroup group)
		{
			this.fOrdersGroup.Add(group);
			this.NoOrders++;
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0001555B File Offset: 0x0001455B
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x0001556A File Offset: 0x0001456A
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

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00015575 File Offset: 0x00014575
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x00015584 File Offset: 0x00014584
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

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0001558F File Offset: 0x0001458F
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0001559E File Offset: 0x0001459E
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

		// Token: 0x060012FA RID: 4858 RVA: 0x000155A9 File Offset: 0x000145A9
		public FIXNewOrderList()
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000155D4 File Offset: 0x000145D4
		public FIXNewOrderList(string ListID, int BidType, int TotNoOrders, int NoOrders)
		{
			this.ListID = ListID;
			this.BidType = BidType;
			this.TotNoOrders = TotNoOrders;
			this.NoOrders = NoOrders;
		}

		// Token: 0x04000255 RID: 597
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000256 RID: 598
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000257 RID: 599
		private ArrayList fOrdersGroup = new ArrayList();
	}
}
