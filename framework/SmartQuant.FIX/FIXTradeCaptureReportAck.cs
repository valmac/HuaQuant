using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000005 RID: 5
	public class FIXTradeCaptureReportAck : FIXMessage
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002594 File Offset: 0x00001594
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000025A6 File Offset: 0x000015A6
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000025B4 File Offset: 0x000015B4
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000025C3 File Offset: 0x000015C3
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000025CE File Offset: 0x000015CE
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000025DD File Offset: 0x000015DD
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000025E8 File Offset: 0x000015E8
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000025F7 File Offset: 0x000015F7
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002602 File Offset: 0x00001602
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002611 File Offset: 0x00001611
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000261C File Offset: 0x0000161C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000262B File Offset: 0x0000162B
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002636 File Offset: 0x00001636
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002648 File Offset: 0x00001648
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002656 File Offset: 0x00001656
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002665 File Offset: 0x00001665
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002670 File Offset: 0x00001670
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000267F File Offset: 0x0000167F
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000268A File Offset: 0x0000168A
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002699 File Offset: 0x00001699
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000026A4 File Offset: 0x000016A4
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000026B3 File Offset: 0x000016B3
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000026BE File Offset: 0x000016BE
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000026D0 File Offset: 0x000016D0
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000026DE File Offset: 0x000016DE
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000026ED File Offset: 0x000016ED
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000026F8 File Offset: 0x000016F8
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002706 File Offset: 0x00001706
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002710 File Offset: 0x00001710
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000271F File Offset: 0x0000171F
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

		// Token: 0x0600004F RID: 79 RVA: 0x0000272A File Offset: 0x0000172A
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000273D File Offset: 0x0000173D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000274C File Offset: 0x0000174C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000275E File Offset: 0x0000175E
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000276C File Offset: 0x0000176C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000277E File Offset: 0x0000177E
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000278C File Offset: 0x0000178C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000279B File Offset: 0x0000179B
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000027A6 File Offset: 0x000017A6
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000027B5 File Offset: 0x000017B5
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000027C0 File Offset: 0x000017C0
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000027CF File Offset: 0x000017CF
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000027DA File Offset: 0x000017DA
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000027E9 File Offset: 0x000017E9
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000027F4 File Offset: 0x000017F4
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002806 File Offset: 0x00001806
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002814 File Offset: 0x00001814
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002826 File Offset: 0x00001826
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002834 File Offset: 0x00001834
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002846 File Offset: 0x00001846
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002854 File Offset: 0x00001854
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002866 File Offset: 0x00001866
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002874 File Offset: 0x00001874
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002886 File Offset: 0x00001886
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

		// Token: 0x06000067 RID: 103 RVA: 0x00002894 File Offset: 0x00001894
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000028B2 File Offset: 0x000018B2
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000028CF File Offset: 0x000018CF
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000028E1 File Offset: 0x000018E1
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000028EF File Offset: 0x000018EF
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002901 File Offset: 0x00001901
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000290F File Offset: 0x0000190F
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002921 File Offset: 0x00001921
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000292F File Offset: 0x0000192F
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002941 File Offset: 0x00001941
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000294F File Offset: 0x0000194F
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002961 File Offset: 0x00001961
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000296F File Offset: 0x0000196F
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002981 File Offset: 0x00001981
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000298F File Offset: 0x0000198F
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000029A1 File Offset: 0x000019A1
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000029AF File Offset: 0x000019AF
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000029C1 File Offset: 0x000019C1
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000029CF File Offset: 0x000019CF
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000029E1 File Offset: 0x000019E1
		[FIXField("150", EFieldOption.Required)]
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000029EF File Offset: 0x000019EF
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002A01 File Offset: 0x00001A01
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002A0F File Offset: 0x00001A0F
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002A21 File Offset: 0x00001A21
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002A2F File Offset: 0x00001A2F
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002A41 File Offset: 0x00001A41
		[FIXField("939", EFieldOption.Optional)]
		public int TrdRptStatus
		{
			get
			{
				return this.GetIntField(939).Value;
			}
			set
			{
				this.AddIntField(939, value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002A4F File Offset: 0x00001A4F
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002A61 File Offset: 0x00001A61
		[FIXField("751", EFieldOption.Optional)]
		public int TradeReportRejectReason
		{
			get
			{
				return this.GetIntField(751).Value;
			}
			set
			{
				this.AddIntField(751, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002A6F File Offset: 0x00001A6F
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002A81 File Offset: 0x00001A81
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002A8F File Offset: 0x00001A8F
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002AA1 File Offset: 0x00001AA1
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002AAF File Offset: 0x00001AAF
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002AC1 File Offset: 0x00001AC1
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002ACF File Offset: 0x00001ACF
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002AE1 File Offset: 0x00001AE1
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002AEF File Offset: 0x00001AEF
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002AFE File Offset: 0x00001AFE
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002B09 File Offset: 0x00001B09
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002B1B File Offset: 0x00001B1B
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002B29 File Offset: 0x00001B29
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002B38 File Offset: 0x00001B38
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002B43 File Offset: 0x00001B43
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002B52 File Offset: 0x00001B52
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002B5D File Offset: 0x00001B5D
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002B6C File Offset: 0x00001B6C
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002B77 File Offset: 0x00001B77
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002B86 File Offset: 0x00001B86
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002B91 File Offset: 0x00001B91
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002BA3 File Offset: 0x00001BA3
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

		// Token: 0x06000099 RID: 153 RVA: 0x00002BB1 File Offset: 0x00001BB1
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002BCF File Offset: 0x00001BCF
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002BEC File Offset: 0x00001BEC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002BFE File Offset: 0x00001BFE
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002C0C File Offset: 0x00001C0C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002C1E File Offset: 0x00001C1E
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002C2C File Offset: 0x00001C2C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002C3E File Offset: 0x00001C3E
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002C4C File Offset: 0x00001C4C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002C5E File Offset: 0x00001C5E
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002C6C File Offset: 0x00001C6C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002C7E File Offset: 0x00001C7E
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002C8C File Offset: 0x00001C8C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002C9E File Offset: 0x00001C9E
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002CAC File Offset: 0x00001CAC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002CBE File Offset: 0x00001CBE
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002CCC File Offset: 0x00001CCC
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002CDE File Offset: 0x00001CDE
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002CEC File Offset: 0x00001CEC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002CFE File Offset: 0x00001CFE
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002D0C File Offset: 0x00001D0C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002D1E File Offset: 0x00001D1E
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002D2C File Offset: 0x00001D2C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002D3E File Offset: 0x00001D3E
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002D4C File Offset: 0x00001D4C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002D5E File Offset: 0x00001D5E
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002D6C File Offset: 0x00001D6C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002D7E File Offset: 0x00001D7E
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002D8C File Offset: 0x00001D8C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002D9E File Offset: 0x00001D9E
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002DAC File Offset: 0x00001DAC
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002DBE File Offset: 0x00001DBE
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002DCC File Offset: 0x00001DCC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002DDE File Offset: 0x00001DDE
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002DEC File Offset: 0x00001DEC
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002DFE File Offset: 0x00001DFE
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

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002E0C File Offset: 0x00001E0C
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002E1E File Offset: 0x00001E1E
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002E2C File Offset: 0x00001E2C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002E3E File Offset: 0x00001E3E
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002E4C File Offset: 0x00001E4C
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002E5E File Offset: 0x00001E5E
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002E6C File Offset: 0x00001E6C
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002E7E File Offset: 0x00001E7E
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002E8C File Offset: 0x00001E8C
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002E9E File Offset: 0x00001E9E
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002EAC File Offset: 0x00001EAC
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002EBE File Offset: 0x00001EBE
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002ECC File Offset: 0x00001ECC
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002EDE File Offset: 0x00001EDE
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002EEC File Offset: 0x00001EEC
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002EFB File Offset: 0x00001EFB
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002F06 File Offset: 0x00001F06
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002F18 File Offset: 0x00001F18
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002F26 File Offset: 0x00001F26
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002F38 File Offset: 0x00001F38
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002F46 File Offset: 0x00001F46
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002F55 File Offset: 0x00001F55
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002F60 File Offset: 0x00001F60
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002F72 File Offset: 0x00001F72
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002F80 File Offset: 0x00001F80
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002F92 File Offset: 0x00001F92
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002FA0 File Offset: 0x00001FA0
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002FB2 File Offset: 0x00001FB2
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002FC0 File Offset: 0x00001FC0
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002FD2 File Offset: 0x00001FD2
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002FE0 File Offset: 0x00001FE0
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002FF2 File Offset: 0x00001FF2
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003000 File Offset: 0x00002000
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00003012 File Offset: 0x00002012
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003020 File Offset: 0x00002020
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00003032 File Offset: 0x00002032
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

		// Token: 0x060000E1 RID: 225 RVA: 0x00003040 File Offset: 0x00002040
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000305E File Offset: 0x0000205E
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000307B File Offset: 0x0000207B
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000308D File Offset: 0x0000208D
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000309B File Offset: 0x0000209B
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000030AD File Offset: 0x000020AD
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000030BB File Offset: 0x000020BB
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000030CA File Offset: 0x000020CA
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000030D5 File Offset: 0x000020D5
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000030E7 File Offset: 0x000020E7
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

		// Token: 0x060000EB RID: 235 RVA: 0x000030F5 File Offset: 0x000020F5
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003113 File Offset: 0x00002113
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00003130 File Offset: 0x00002130
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00003142 File Offset: 0x00002142
		[FIXField("725", EFieldOption.Optional)]
		public int ResponseTransportType
		{
			get
			{
				return this.GetIntField(725).Value;
			}
			set
			{
				this.AddIntField(725, value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00003150 File Offset: 0x00002150
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00003162 File Offset: 0x00002162
		[FIXField("726", EFieldOption.Optional)]
		public string ResponseDestination
		{
			get
			{
				return this.GetStringField(726).Value;
			}
			set
			{
				this.AddStringField(726, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00003170 File Offset: 0x00002170
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000317F File Offset: 0x0000217F
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000318A File Offset: 0x0000218A
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000319C File Offset: 0x0000219C
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000031AA File Offset: 0x000021AA
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000031BC File Offset: 0x000021BC
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000031CA File Offset: 0x000021CA
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000031DC File Offset: 0x000021DC
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

		// Token: 0x060000F9 RID: 249 RVA: 0x000031EA File Offset: 0x000021EA
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003208 File Offset: 0x00002208
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003225 File Offset: 0x00002225
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00003237 File Offset: 0x00002237
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003245 File Offset: 0x00002245
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00003257 File Offset: 0x00002257
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003265 File Offset: 0x00002265
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00003277 File Offset: 0x00002277
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00003285 File Offset: 0x00002285
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00003297 File Offset: 0x00002297
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000032A5 File Offset: 0x000022A5
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000032B3 File Offset: 0x000022B3
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000032BD File Offset: 0x000022BD
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000032CF File Offset: 0x000022CF
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000032DD File Offset: 0x000022DD
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000032EF File Offset: 0x000022EF
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000032FD File Offset: 0x000022FD
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000330C File Offset: 0x0000230C
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00003317 File Offset: 0x00002317
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00003329 File Offset: 0x00002329
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00003337 File Offset: 0x00002337
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00003346 File Offset: 0x00002346
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

		// Token: 0x0600010F RID: 271 RVA: 0x00003351 File Offset: 0x00002351
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000336F File Offset: 0x0000236F
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000338C File Offset: 0x0000238C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000339B File Offset: 0x0000239B
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000033A6 File Offset: 0x000023A6
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000033B5 File Offset: 0x000023B5
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000033C0 File Offset: 0x000023C0
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000033CF File Offset: 0x000023CF
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

		// Token: 0x06000117 RID: 279 RVA: 0x000033DC File Offset: 0x000023DC
		public FIXTradeCaptureReportAck()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000343C File Offset: 0x0000243C
		public FIXTradeCaptureReportAck(string TradeReportID, char ExecType)
		{
			this.TradeReportID = TradeReportID;
			this.ExecType = ExecType;
		}

		// Token: 0x04000005 RID: 5
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000006 RID: 6
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000007 RID: 7
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000008 RID: 8
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000009 RID: 9
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x0400000A RID: 10
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x0400000B RID: 11
		private ArrayList fAllocsGroup = new ArrayList();
	}
}
