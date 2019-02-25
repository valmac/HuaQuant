using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000C9 RID: 201
	public class FIXHeartbeat : FIXMessage
	{
		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x00029C3E File Offset: 0x00028C3E
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x00029C50 File Offset: 0x00028C50
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

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x00029C5E File Offset: 0x00028C5E
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x00029C6D File Offset: 0x00028C6D
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

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x00029C78 File Offset: 0x00028C78
		// (set) Token: 0x06002731 RID: 10033 RVA: 0x00029C87 File Offset: 0x00028C87
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

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x00029C92 File Offset: 0x00028C92
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x00029CA1 File Offset: 0x00028CA1
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x00029CAC File Offset: 0x00028CAC
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00029CBB File Offset: 0x00028CBB
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x00029CC6 File Offset: 0x00028CC6
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x00029CD5 File Offset: 0x00028CD5
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

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x00029CE0 File Offset: 0x00028CE0
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x00029CF2 File Offset: 0x00028CF2
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

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x00029D00 File Offset: 0x00028D00
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x00029D0F File Offset: 0x00028D0F
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

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x00029D1A File Offset: 0x00028D1A
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x00029D29 File Offset: 0x00028D29
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

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x00029D34 File Offset: 0x00028D34
		// (set) Token: 0x0600273F RID: 10047 RVA: 0x00029D43 File Offset: 0x00028D43
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

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x00029D4E File Offset: 0x00028D4E
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x00029D5D File Offset: 0x00028D5D
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

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x00029D68 File Offset: 0x00028D68
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x00029D7A File Offset: 0x00028D7A
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

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x00029D88 File Offset: 0x00028D88
		// (set) Token: 0x06002745 RID: 10053 RVA: 0x00029D97 File Offset: 0x00028D97
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

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x00029DA2 File Offset: 0x00028DA2
		// (set) Token: 0x06002747 RID: 10055 RVA: 0x00029DB0 File Offset: 0x00028DB0
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

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x00029DBA File Offset: 0x00028DBA
		// (set) Token: 0x06002749 RID: 10057 RVA: 0x00029DC9 File Offset: 0x00028DC9
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

		// Token: 0x0600274A RID: 10058 RVA: 0x00029DD4 File Offset: 0x00028DD4
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00029DE7 File Offset: 0x00028DE7
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x00029DF6 File Offset: 0x00028DF6
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x00029E08 File Offset: 0x00028E08
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

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x00029E16 File Offset: 0x00028E16
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x00029E28 File Offset: 0x00028E28
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

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x00029E36 File Offset: 0x00028E36
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x00029E45 File Offset: 0x00028E45
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

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x00029E50 File Offset: 0x00028E50
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00029E5F File Offset: 0x00028E5F
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x00029E6A File Offset: 0x00028E6A
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x00029E79 File Offset: 0x00028E79
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x00029E84 File Offset: 0x00028E84
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x00029E93 File Offset: 0x00028E93
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

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x00029E9E File Offset: 0x00028E9E
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x00029EB0 File Offset: 0x00028EB0
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

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x00029EBE File Offset: 0x00028EBE
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x00029ED0 File Offset: 0x00028ED0
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

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x00029EDE File Offset: 0x00028EDE
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x00029EF0 File Offset: 0x00028EF0
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

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x00029EFE File Offset: 0x00028EFE
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x00029F10 File Offset: 0x00028F10
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

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x00029F1E File Offset: 0x00028F1E
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x00029F30 File Offset: 0x00028F30
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

		// Token: 0x06002762 RID: 10082 RVA: 0x00029F3E File Offset: 0x00028F3E
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00029F5C File Offset: 0x00028F5C
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x00029F79 File Offset: 0x00028F79
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x00029F8B File Offset: 0x00028F8B
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

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x00029F99 File Offset: 0x00028F99
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00029FA8 File Offset: 0x00028FA8
		[FIXField("112", EFieldOption.Optional)]
		public string TestReqID
		{
			get
			{
				return this.GetStringField(112).Value;
			}
			set
			{
				this.AddStringField(112, value);
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00029FB3 File Offset: 0x00028FB3
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00029FC2 File Offset: 0x00028FC2
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

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x00029FCD File Offset: 0x00028FCD
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x00029FDC File Offset: 0x00028FDC
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x00029FE7 File Offset: 0x00028FE7
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x00029FF6 File Offset: 0x00028FF6
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

		// Token: 0x040003A7 RID: 935
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003A8 RID: 936
		private ArrayList fHopsGroup = new ArrayList();
	}
}
