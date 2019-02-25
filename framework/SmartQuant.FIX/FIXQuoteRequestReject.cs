using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000DD RID: 221
	public class FIXQuoteRequestReject : FIXMessage
	{
		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x0002DFEE File Offset: 0x0002CFEE
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0002E000 File Offset: 0x0002D000
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

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x0002E00E File Offset: 0x0002D00E
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x0002E01D File Offset: 0x0002D01D
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

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x0002E028 File Offset: 0x0002D028
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x0002E037 File Offset: 0x0002D037
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

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x0002E042 File Offset: 0x0002D042
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x0002E051 File Offset: 0x0002D051
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

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x0002E05C File Offset: 0x0002D05C
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x0002E06B File Offset: 0x0002D06B
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

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x0002E076 File Offset: 0x0002D076
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x0002E085 File Offset: 0x0002D085
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

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x0002E090 File Offset: 0x0002D090
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x0002E0A2 File Offset: 0x0002D0A2
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

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x0002E0B0 File Offset: 0x0002D0B0
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0002E0BF File Offset: 0x0002D0BF
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

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x0002E0CA File Offset: 0x0002D0CA
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x0002E0D9 File Offset: 0x0002D0D9
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

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x0002E0E4 File Offset: 0x0002D0E4
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x0002E0F3 File Offset: 0x0002D0F3
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

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x0002E0FE File Offset: 0x0002D0FE
		// (set) Token: 0x06002B60 RID: 11104 RVA: 0x0002E10D File Offset: 0x0002D10D
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

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x0002E118 File Offset: 0x0002D118
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x0002E12A File Offset: 0x0002D12A
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

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x0002E138 File Offset: 0x0002D138
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0002E147 File Offset: 0x0002D147
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

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x0002E152 File Offset: 0x0002D152
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x0002E160 File Offset: 0x0002D160
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

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x0002E16A File Offset: 0x0002D16A
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x0002E179 File Offset: 0x0002D179
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

		// Token: 0x06002B69 RID: 11113 RVA: 0x0002E184 File Offset: 0x0002D184
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0002E197 File Offset: 0x0002D197
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x0002E1A6 File Offset: 0x0002D1A6
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x0002E1B8 File Offset: 0x0002D1B8
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

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x0002E1C6 File Offset: 0x0002D1C6
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x0002E1D8 File Offset: 0x0002D1D8
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

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x0002E1E6 File Offset: 0x0002D1E6
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x0002E1F5 File Offset: 0x0002D1F5
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

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0002E200 File Offset: 0x0002D200
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x0002E20F File Offset: 0x0002D20F
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

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x0002E21A File Offset: 0x0002D21A
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x0002E229 File Offset: 0x0002D229
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

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x0002E234 File Offset: 0x0002D234
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x0002E243 File Offset: 0x0002D243
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

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x0002E24E File Offset: 0x0002D24E
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x0002E260 File Offset: 0x0002D260
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

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x0002E26E File Offset: 0x0002D26E
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x0002E280 File Offset: 0x0002D280
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

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x0002E28E File Offset: 0x0002D28E
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x0002E2A0 File Offset: 0x0002D2A0
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

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x0002E2AE File Offset: 0x0002D2AE
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x0002E2C0 File Offset: 0x0002D2C0
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

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x0002E2CE File Offset: 0x0002D2CE
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x0002E2E0 File Offset: 0x0002D2E0
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

		// Token: 0x06002B81 RID: 11137 RVA: 0x0002E2EE File Offset: 0x0002D2EE
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0002E30C File Offset: 0x0002D30C
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x0002E329 File Offset: 0x0002D329
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x0002E33B File Offset: 0x0002D33B
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

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x0002E349 File Offset: 0x0002D349
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x0002E35B File Offset: 0x0002D35B
		[FIXField("131", EFieldOption.Required)]
		public string QuoteReqID
		{
			get
			{
				return this.GetStringField(131).Value;
			}
			set
			{
				this.AddStringField(131, value);
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x0002E369 File Offset: 0x0002D369
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x0002E37B File Offset: 0x0002D37B
		[FIXField("644", EFieldOption.Optional)]
		public string RFQReqID
		{
			get
			{
				return this.GetStringField(644).Value;
			}
			set
			{
				this.AddStringField(644, value);
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x0002E389 File Offset: 0x0002D389
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x0002E39B File Offset: 0x0002D39B
		[FIXField("658", EFieldOption.Required)]
		public int QuoteRequestRejectReason
		{
			get
			{
				return this.GetIntField(658).Value;
			}
			set
			{
				this.AddIntField(658, value);
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x0002E3A9 File Offset: 0x0002D3A9
		// (set) Token: 0x06002B8C RID: 11148 RVA: 0x0002E3BB File Offset: 0x0002D3BB
		[FIXField("146", EFieldOption.Required)]
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

		// Token: 0x06002B8D RID: 11149 RVA: 0x0002E3C9 File Offset: 0x0002D3C9
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0002E3E7 File Offset: 0x0002D3E7
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x0002E404 File Offset: 0x0002D404
		// (set) Token: 0x06002B90 RID: 11152 RVA: 0x0002E413 File Offset: 0x0002D413
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

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x0002E41E File Offset: 0x0002D41E
		// (set) Token: 0x06002B92 RID: 11154 RVA: 0x0002E430 File Offset: 0x0002D430
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

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x0002E43E File Offset: 0x0002D43E
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x0002E450 File Offset: 0x0002D450
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

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x0002E45E File Offset: 0x0002D45E
		// (set) Token: 0x06002B96 RID: 11158 RVA: 0x0002E46D File Offset: 0x0002D46D
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

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x0002E478 File Offset: 0x0002D478
		// (set) Token: 0x06002B98 RID: 11160 RVA: 0x0002E487 File Offset: 0x0002D487
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

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x0002E492 File Offset: 0x0002D492
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x0002E4A1 File Offset: 0x0002D4A1
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

		// Token: 0x06002B9B RID: 11163 RVA: 0x0002E4AC File Offset: 0x0002D4AC
		public FIXQuoteRequestReject()
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0002E4D5 File Offset: 0x0002D4D5
		public FIXQuoteRequestReject(string QuoteReqID, int QuoteRequestRejectReason, int NoRelatedSym)
		{
			this.QuoteReqID = QuoteReqID;
			this.QuoteRequestRejectReason = QuoteRequestRejectReason;
			this.NoRelatedSym = NoRelatedSym;
		}

		// Token: 0x040003CE RID: 974
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003CF RID: 975
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040003D0 RID: 976
		private ArrayList fRelatedSymGroup = new ArrayList();
	}
}
