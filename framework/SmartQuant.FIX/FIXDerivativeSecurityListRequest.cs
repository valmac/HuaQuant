using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200006C RID: 108
	public class FIXDerivativeSecurityListRequest : FIXMessage
	{
		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00015C81 File Offset: 0x00014C81
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00015C93 File Offset: 0x00014C93
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

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00015CA1 File Offset: 0x00014CA1
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00015CB0 File Offset: 0x00014CB0
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

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00015CBB File Offset: 0x00014CBB
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00015CCA File Offset: 0x00014CCA
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00015CD5 File Offset: 0x00014CD5
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00015CE4 File Offset: 0x00014CE4
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

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00015CEF File Offset: 0x00014CEF
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00015CFE File Offset: 0x00014CFE
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

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00015D09 File Offset: 0x00014D09
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00015D18 File Offset: 0x00014D18
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00015D23 File Offset: 0x00014D23
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00015D35 File Offset: 0x00014D35
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

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00015D43 File Offset: 0x00014D43
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00015D52 File Offset: 0x00014D52
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

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00015D5D File Offset: 0x00014D5D
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00015D6C File Offset: 0x00014D6C
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

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00015D77 File Offset: 0x00014D77
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x00015D86 File Offset: 0x00014D86
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

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00015D91 File Offset: 0x00014D91
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x00015DA0 File Offset: 0x00014DA0
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

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00015DAB File Offset: 0x00014DAB
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x00015DBD File Offset: 0x00014DBD
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

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00015DCB File Offset: 0x00014DCB
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x00015DDA File Offset: 0x00014DDA
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

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00015DE5 File Offset: 0x00014DE5
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00015DF3 File Offset: 0x00014DF3
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00015DFD File Offset: 0x00014DFD
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00015E0C File Offset: 0x00014E0C
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

		// Token: 0x0600137F RID: 4991 RVA: 0x00015E17 File Offset: 0x00014E17
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00015E2A File Offset: 0x00014E2A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00015E39 File Offset: 0x00014E39
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00015E4B File Offset: 0x00014E4B
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

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00015E59 File Offset: 0x00014E59
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00015E6B File Offset: 0x00014E6B
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00015E79 File Offset: 0x00014E79
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00015E88 File Offset: 0x00014E88
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

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00015E93 File Offset: 0x00014E93
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x00015EA2 File Offset: 0x00014EA2
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

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00015EAD File Offset: 0x00014EAD
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00015EBC File Offset: 0x00014EBC
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

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00015EC7 File Offset: 0x00014EC7
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00015ED6 File Offset: 0x00014ED6
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

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00015EE1 File Offset: 0x00014EE1
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00015EF3 File Offset: 0x00014EF3
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

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00015F01 File Offset: 0x00014F01
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00015F13 File Offset: 0x00014F13
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00015F21 File Offset: 0x00014F21
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00015F33 File Offset: 0x00014F33
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

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00015F41 File Offset: 0x00014F41
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00015F53 File Offset: 0x00014F53
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

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00015F61 File Offset: 0x00014F61
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x00015F73 File Offset: 0x00014F73
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

		// Token: 0x06001397 RID: 5015 RVA: 0x00015F81 File Offset: 0x00014F81
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00015F9F File Offset: 0x00014F9F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00015FBC File Offset: 0x00014FBC
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00015FCE File Offset: 0x00014FCE
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

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00015FDC File Offset: 0x00014FDC
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x00015FEE File Offset: 0x00014FEE
		[FIXField("320", EFieldOption.Required)]
		public string SecurityReqID
		{
			get
			{
				return this.GetStringField(320).Value;
			}
			set
			{
				this.AddStringField(320, value);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00015FFC File Offset: 0x00014FFC
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x0001600E File Offset: 0x0001500E
		[FIXField("559", EFieldOption.Required)]
		public int SecurityListRequestType
		{
			get
			{
				return this.GetIntField(559).Value;
			}
			set
			{
				this.AddIntField(559, value);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0001601C File Offset: 0x0001501C
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x0001602E File Offset: 0x0001502E
		[FIXField("311", EFieldOption.Optional)]
		public string UnderlyingSymbol
		{
			get
			{
				return this.GetStringField(311).Value;
			}
			set
			{
				this.AddStringField(311, value);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0001603C File Offset: 0x0001503C
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x0001604E File Offset: 0x0001504E
		[FIXField("312", EFieldOption.Optional)]
		public string UnderlyingSymbolSfx
		{
			get
			{
				return this.GetStringField(312).Value;
			}
			set
			{
				this.AddStringField(312, value);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0001605C File Offset: 0x0001505C
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x0001606E File Offset: 0x0001506E
		[FIXField("309", EFieldOption.Optional)]
		public string UnderlyingSecurityID
		{
			get
			{
				return this.GetStringField(309).Value;
			}
			set
			{
				this.AddStringField(309, value);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0001607C File Offset: 0x0001507C
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x0001608E File Offset: 0x0001508E
		[FIXField("305", EFieldOption.Optional)]
		public string UnderlyingSecurityIDSource
		{
			get
			{
				return this.GetStringField(305).Value;
			}
			set
			{
				this.AddStringField(305, value);
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0001609C File Offset: 0x0001509C
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x000160AE File Offset: 0x000150AE
		[FIXField("457", EFieldOption.Optional)]
		public int NoUnderlyingSecurityAltID
		{
			get
			{
				return this.GetIntField(457).Value;
			}
			set
			{
				this.AddIntField(457, value);
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x000160BC File Offset: 0x000150BC
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000160DA File Offset: 0x000150DA
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x000160F7 File Offset: 0x000150F7
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00016109 File Offset: 0x00015109
		[FIXField("462", EFieldOption.Optional)]
		public int UnderlyingProduct
		{
			get
			{
				return this.GetIntField(462).Value;
			}
			set
			{
				this.AddIntField(462, value);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00016117 File Offset: 0x00015117
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x00016129 File Offset: 0x00015129
		[FIXField("463", EFieldOption.Optional)]
		public string UnderlyingCFICode
		{
			get
			{
				return this.GetStringField(463).Value;
			}
			set
			{
				this.AddStringField(463, value);
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00016137 File Offset: 0x00015137
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00016149 File Offset: 0x00015149
		[FIXField("310", EFieldOption.Optional)]
		public string UnderlyingSecurityType
		{
			get
			{
				return this.GetStringField(310).Value;
			}
			set
			{
				this.AddStringField(310, value);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00016157 File Offset: 0x00015157
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x00016169 File Offset: 0x00015169
		[FIXField("763", EFieldOption.Optional)]
		public string UnderlyingSecuritySubType
		{
			get
			{
				return this.GetStringField(763).Value;
			}
			set
			{
				this.AddStringField(763, value);
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00016177 File Offset: 0x00015177
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x00016189 File Offset: 0x00015189
		[FIXField("313", EFieldOption.Optional)]
		public string UnderlyingMaturityMonthYear
		{
			get
			{
				return this.GetStringField(313).Value;
			}
			set
			{
				this.AddStringField(313, value);
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00016197 File Offset: 0x00015197
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x000161A9 File Offset: 0x000151A9
		[FIXField("542", EFieldOption.Optional)]
		public DateTime UnderlyingMaturityDate
		{
			get
			{
				return this.GetDateTimeField(542).Value;
			}
			set
			{
				this.AddDateTimeField(542, value);
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x000161B7 File Offset: 0x000151B7
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x000161C9 File Offset: 0x000151C9
		[FIXField("241", EFieldOption.Optional)]
		public DateTime UnderlyingCouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(241).Value;
			}
			set
			{
				this.AddDateTimeField(241, value);
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x000161D7 File Offset: 0x000151D7
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x000161E9 File Offset: 0x000151E9
		[FIXField("242", EFieldOption.Optional)]
		public DateTime UnderlyingIssueDate
		{
			get
			{
				return this.GetDateTimeField(242).Value;
			}
			set
			{
				this.AddDateTimeField(242, value);
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000161F7 File Offset: 0x000151F7
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x00016209 File Offset: 0x00015209
		[FIXField("243", EFieldOption.Optional)]
		public int UnderlyingRepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(243).Value;
			}
			set
			{
				this.AddIntField(243, value);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00016217 File Offset: 0x00015217
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x00016229 File Offset: 0x00015229
		[FIXField("244", EFieldOption.Optional)]
		public int UnderlyingRepurchaseTerm
		{
			get
			{
				return this.GetIntField(244).Value;
			}
			set
			{
				this.AddIntField(244, value);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00016237 File Offset: 0x00015237
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x00016249 File Offset: 0x00015249
		[FIXField("245", EFieldOption.Optional)]
		public double UnderlyingRepurchaseRate
		{
			get
			{
				return this.GetDoubleField(245).Value;
			}
			set
			{
				this.AddDoubleField(245, value);
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00016257 File Offset: 0x00015257
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x00016269 File Offset: 0x00015269
		[FIXField("246", EFieldOption.Optional)]
		public double UnderlyingFactor
		{
			get
			{
				return this.GetDoubleField(246).Value;
			}
			set
			{
				this.AddDoubleField(246, value);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00016277 File Offset: 0x00015277
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00016289 File Offset: 0x00015289
		[FIXField("256", EFieldOption.Optional)]
		public string UnderlyingCreditRating
		{
			get
			{
				return this.GetStringField(256).Value;
			}
			set
			{
				this.AddStringField(256, value);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00016297 File Offset: 0x00015297
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x000162A9 File Offset: 0x000152A9
		[FIXField("595", EFieldOption.Optional)]
		public string UnderlyingInstrRegistry
		{
			get
			{
				return this.GetStringField(595).Value;
			}
			set
			{
				this.AddStringField(595, value);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x000162B7 File Offset: 0x000152B7
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x000162C9 File Offset: 0x000152C9
		[FIXField("592", EFieldOption.Optional)]
		public string UnderlyingCountryOfIssue
		{
			get
			{
				return this.GetStringField(592).Value;
			}
			set
			{
				this.AddStringField(592, value);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x000162D7 File Offset: 0x000152D7
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x000162E9 File Offset: 0x000152E9
		[FIXField("593", EFieldOption.Optional)]
		public string UnderlyingStateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(593).Value;
			}
			set
			{
				this.AddStringField(593, value);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x000162F7 File Offset: 0x000152F7
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x00016309 File Offset: 0x00015309
		[FIXField("594", EFieldOption.Optional)]
		public string UnderlyingLocaleOfIssue
		{
			get
			{
				return this.GetStringField(594).Value;
			}
			set
			{
				this.AddStringField(594, value);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00016317 File Offset: 0x00015317
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00016329 File Offset: 0x00015329
		[FIXField("247", EFieldOption.Optional)]
		public DateTime UnderlyingRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(247).Value;
			}
			set
			{
				this.AddDateTimeField(247, value);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00016337 File Offset: 0x00015337
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x00016349 File Offset: 0x00015349
		[FIXField("316", EFieldOption.Optional)]
		public double UnderlyingStrikePrice
		{
			get
			{
				return this.GetDoubleField(316).Value;
			}
			set
			{
				this.AddDoubleField(316, value);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00016357 File Offset: 0x00015357
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00016369 File Offset: 0x00015369
		[FIXField("941", EFieldOption.Optional)]
		public double UnderlyingStrikeCurrency
		{
			get
			{
				return this.GetDoubleField(941).Value;
			}
			set
			{
				this.AddDoubleField(941, value);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00016377 File Offset: 0x00015377
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00016389 File Offset: 0x00015389
		[FIXField("317", EFieldOption.Optional)]
		public char UnderlyingOptAttribute
		{
			get
			{
				return this.GetCharField(317).Value;
			}
			set
			{
				this.AddCharField(317, value);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00016397 File Offset: 0x00015397
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x000163A9 File Offset: 0x000153A9
		[FIXField("436", EFieldOption.Optional)]
		public double UnderlyingContractMultiplier
		{
			get
			{
				return this.GetDoubleField(436).Value;
			}
			set
			{
				this.AddDoubleField(436, value);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000163B7 File Offset: 0x000153B7
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x000163C9 File Offset: 0x000153C9
		[FIXField("435", EFieldOption.Optional)]
		public double UnderlyingCouponRate
		{
			get
			{
				return this.GetDoubleField(435).Value;
			}
			set
			{
				this.AddDoubleField(435, value);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000163D7 File Offset: 0x000153D7
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x000163E9 File Offset: 0x000153E9
		[FIXField("308", EFieldOption.Optional)]
		public string UnderlyingSecurityExchange
		{
			get
			{
				return this.GetStringField(308).Value;
			}
			set
			{
				this.AddStringField(308, value);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x000163F7 File Offset: 0x000153F7
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x00016409 File Offset: 0x00015409
		[FIXField("306", EFieldOption.Optional)]
		public string UnderlyingIssuer
		{
			get
			{
				return this.GetStringField(306).Value;
			}
			set
			{
				this.AddStringField(306, value);
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00016417 File Offset: 0x00015417
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x00016429 File Offset: 0x00015429
		[FIXField("362", EFieldOption.Optional)]
		public int EncodedUnderlyingIssuerLen
		{
			get
			{
				return this.GetIntField(362).Value;
			}
			set
			{
				this.AddIntField(362, value);
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x00016437 File Offset: 0x00015437
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00016449 File Offset: 0x00015449
		[FIXField("363", EFieldOption.Optional)]
		public string EncodedUnderlyingIssuer
		{
			get
			{
				return this.GetStringField(363).Value;
			}
			set
			{
				this.AddStringField(363, value);
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00016457 File Offset: 0x00015457
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00016469 File Offset: 0x00015469
		[FIXField("307", EFieldOption.Optional)]
		public string UnderlyingSecurityDesc
		{
			get
			{
				return this.GetStringField(307).Value;
			}
			set
			{
				this.AddStringField(307, value);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00016477 File Offset: 0x00015477
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x00016489 File Offset: 0x00015489
		[FIXField("364", EFieldOption.Optional)]
		public int EncodedUnderlyingSecurityDescLen
		{
			get
			{
				return this.GetIntField(364).Value;
			}
			set
			{
				this.AddIntField(364, value);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00016497 File Offset: 0x00015497
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x000164A9 File Offset: 0x000154A9
		[FIXField("365", EFieldOption.Optional)]
		public string EncodedUnderlyingSecurityDesc
		{
			get
			{
				return this.GetStringField(365).Value;
			}
			set
			{
				this.AddStringField(365, value);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000164B7 File Offset: 0x000154B7
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x000164C9 File Offset: 0x000154C9
		[FIXField("877", EFieldOption.Optional)]
		public string UnderlyingCPProgram
		{
			get
			{
				return this.GetStringField(877).Value;
			}
			set
			{
				this.AddStringField(877, value);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x000164D7 File Offset: 0x000154D7
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x000164E9 File Offset: 0x000154E9
		[FIXField("878", EFieldOption.Optional)]
		public string UnderlyingCPRegType
		{
			get
			{
				return this.GetStringField(878).Value;
			}
			set
			{
				this.AddStringField(878, value);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x000164F7 File Offset: 0x000154F7
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x00016509 File Offset: 0x00015509
		[FIXField("318", EFieldOption.Optional)]
		public double UnderlyingCurrency
		{
			get
			{
				return this.GetDoubleField(318).Value;
			}
			set
			{
				this.AddDoubleField(318, value);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00016517 File Offset: 0x00015517
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x00016529 File Offset: 0x00015529
		[FIXField("879", EFieldOption.Optional)]
		public double UnderlyingQty
		{
			get
			{
				return this.GetDoubleField(879).Value;
			}
			set
			{
				this.AddDoubleField(879, value);
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00016537 File Offset: 0x00015537
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x00016549 File Offset: 0x00015549
		[FIXField("810", EFieldOption.Optional)]
		public double UnderlyingPx
		{
			get
			{
				return this.GetDoubleField(810).Value;
			}
			set
			{
				this.AddDoubleField(810, value);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00016557 File Offset: 0x00015557
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x00016569 File Offset: 0x00015569
		[FIXField("882", EFieldOption.Optional)]
		public double UnderlyingDirtyPrice
		{
			get
			{
				return this.GetDoubleField(882).Value;
			}
			set
			{
				this.AddDoubleField(882, value);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00016577 File Offset: 0x00015577
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x00016589 File Offset: 0x00015589
		[FIXField("883", EFieldOption.Optional)]
		public double UnderlyingEndPrice
		{
			get
			{
				return this.GetDoubleField(883).Value;
			}
			set
			{
				this.AddDoubleField(883, value);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00016597 File Offset: 0x00015597
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x000165A9 File Offset: 0x000155A9
		[FIXField("884", EFieldOption.Optional)]
		public double UnderlyingStartValue
		{
			get
			{
				return this.GetDoubleField(884).Value;
			}
			set
			{
				this.AddDoubleField(884, value);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000165B7 File Offset: 0x000155B7
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x000165C9 File Offset: 0x000155C9
		[FIXField("885", EFieldOption.Optional)]
		public double UnderlyingCurrentValue
		{
			get
			{
				return this.GetDoubleField(885).Value;
			}
			set
			{
				this.AddDoubleField(885, value);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000165D7 File Offset: 0x000155D7
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x000165E9 File Offset: 0x000155E9
		[FIXField("886", EFieldOption.Optional)]
		public double UnderlyingEndValue
		{
			get
			{
				return this.GetDoubleField(886).Value;
			}
			set
			{
				this.AddDoubleField(886, value);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000165F7 File Offset: 0x000155F7
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00016609 File Offset: 0x00015609
		[FIXField("887", EFieldOption.Optional)]
		public int NoUnderlyingStips
		{
			get
			{
				return this.GetIntField(887).Value;
			}
			set
			{
				this.AddIntField(887, value);
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00016617 File Offset: 0x00015617
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00016635 File Offset: 0x00015635
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00016652 File Offset: 0x00015652
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x00016664 File Offset: 0x00015664
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

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00016672 File Offset: 0x00015672
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x00016681 File Offset: 0x00015681
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

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0001668C File Offset: 0x0001568C
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0001669B File Offset: 0x0001569B
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

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x000166A6 File Offset: 0x000156A6
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x000166B8 File Offset: 0x000156B8
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

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x000166C6 File Offset: 0x000156C6
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x000166D8 File Offset: 0x000156D8
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

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x000166E6 File Offset: 0x000156E6
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x000166F8 File Offset: 0x000156F8
		[FIXField("336", EFieldOption.Optional)]
		public string TradingSessionID
		{
			get
			{
				return this.GetStringField(336).Value;
			}
			set
			{
				this.AddStringField(336, value);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00016706 File Offset: 0x00015706
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x00016718 File Offset: 0x00015718
		[FIXField("625", EFieldOption.Optional)]
		public string TradingSessionSubID
		{
			get
			{
				return this.GetStringField(625).Value;
			}
			set
			{
				this.AddStringField(625, value);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00016726 File Offset: 0x00015726
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x00016738 File Offset: 0x00015738
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

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00016746 File Offset: 0x00015746
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x00016755 File Offset: 0x00015755
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

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00016760 File Offset: 0x00015760
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0001676F File Offset: 0x0001576F
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

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0001677A File Offset: 0x0001577A
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00016789 File Offset: 0x00015789
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

		// Token: 0x06001415 RID: 5141 RVA: 0x00016794 File Offset: 0x00015794
		public FIXDerivativeSecurityListRequest()
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000167C8 File Offset: 0x000157C8
		public FIXDerivativeSecurityListRequest(string SecurityReqID, int SecurityListRequestType)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityListRequestType = SecurityListRequestType;
		}

		// Token: 0x0400025D RID: 605
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400025E RID: 606
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400025F RID: 607
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000260 RID: 608
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
