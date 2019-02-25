using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000093 RID: 147
	public class FIXQuoteStatusRequest : FIXMessage
	{
		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0001EB95 File Offset: 0x0001DB95
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0001EBA7 File Offset: 0x0001DBA7
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

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0001EBB5 File Offset: 0x0001DBB5
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0001EBC4 File Offset: 0x0001DBC4
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0001EBCF File Offset: 0x0001DBCF
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0001EBDE File Offset: 0x0001DBDE
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

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0001EBE9 File Offset: 0x0001DBE9
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0001EBF8 File Offset: 0x0001DBF8
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0001EC03 File Offset: 0x0001DC03
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0001EC12 File Offset: 0x0001DC12
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0001EC1D File Offset: 0x0001DC1D
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0001EC2C File Offset: 0x0001DC2C
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

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0001EC37 File Offset: 0x0001DC37
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0001EC49 File Offset: 0x0001DC49
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

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0001EC57 File Offset: 0x0001DC57
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0001EC66 File Offset: 0x0001DC66
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

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0001EC71 File Offset: 0x0001DC71
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0001EC80 File Offset: 0x0001DC80
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

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0001EC8B File Offset: 0x0001DC8B
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0001EC9A File Offset: 0x0001DC9A
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

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0001ECA5 File Offset: 0x0001DCA5
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x0001ECB4 File Offset: 0x0001DCB4
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

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0001ECBF File Offset: 0x0001DCBF
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0001ECD1 File Offset: 0x0001DCD1
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

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0001ECDF File Offset: 0x0001DCDF
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x0001ECEE File Offset: 0x0001DCEE
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0001ECF9 File Offset: 0x0001DCF9
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x0001ED07 File Offset: 0x0001DD07
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

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0001ED11 File Offset: 0x0001DD11
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0001ED20 File Offset: 0x0001DD20
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

		// Token: 0x06001C45 RID: 7237 RVA: 0x0001ED2B File Offset: 0x0001DD2B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0001ED3E File Offset: 0x0001DD3E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0001ED4D File Offset: 0x0001DD4D
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x0001ED5F File Offset: 0x0001DD5F
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0001ED6D File Offset: 0x0001DD6D
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0001ED7F File Offset: 0x0001DD7F
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x0001ED8D File Offset: 0x0001DD8D
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x0001ED9C File Offset: 0x0001DD9C
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x0001EDA7 File Offset: 0x0001DDA7
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0001EDB6 File Offset: 0x0001DDB6
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

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0001EDC1 File Offset: 0x0001DDC1
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x0001EDD0 File Offset: 0x0001DDD0
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

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0001EDDB File Offset: 0x0001DDDB
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0001EDEA File Offset: 0x0001DDEA
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

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0001EDF5 File Offset: 0x0001DDF5
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0001EE07 File Offset: 0x0001DE07
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

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0001EE15 File Offset: 0x0001DE15
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0001EE27 File Offset: 0x0001DE27
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

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0001EE35 File Offset: 0x0001DE35
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x0001EE47 File Offset: 0x0001DE47
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0001EE55 File Offset: 0x0001DE55
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0001EE67 File Offset: 0x0001DE67
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

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0001EE75 File Offset: 0x0001DE75
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0001EE87 File Offset: 0x0001DE87
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

		// Token: 0x06001C5D RID: 7261 RVA: 0x0001EE95 File Offset: 0x0001DE95
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0001EEB3 File Offset: 0x0001DEB3
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0001EED0 File Offset: 0x0001DED0
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0001EEE2 File Offset: 0x0001DEE2
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0001EEF0 File Offset: 0x0001DEF0
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0001EF02 File Offset: 0x0001DF02
		[FIXField("649", EFieldOption.Optional)]
		public string QuoteStatusReqID
		{
			get
			{
				return this.GetStringField(649).Value;
			}
			set
			{
				this.AddStringField(649, value);
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0001EF10 File Offset: 0x0001DF10
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0001EF1F File Offset: 0x0001DF1F
		[FIXField("117", EFieldOption.Optional)]
		public string QuoteID
		{
			get
			{
				return this.GetStringField(117).Value;
			}
			set
			{
				this.AddStringField(117, value);
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0001EF2A File Offset: 0x0001DF2A
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0001EF39 File Offset: 0x0001DF39
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0001EF44 File Offset: 0x0001DF44
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0001EF53 File Offset: 0x0001DF53
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x0001EF5E File Offset: 0x0001DF5E
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0001EF6D File Offset: 0x0001DF6D
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

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0001EF78 File Offset: 0x0001DF78
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0001EF87 File Offset: 0x0001DF87
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0001EF92 File Offset: 0x0001DF92
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0001EFA4 File Offset: 0x0001DFA4
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

		// Token: 0x06001C6F RID: 7279 RVA: 0x0001EFB2 File Offset: 0x0001DFB2
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0001EFD0 File Offset: 0x0001DFD0
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0001EFED File Offset: 0x0001DFED
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0001EFFF File Offset: 0x0001DFFF
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

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0001F00D File Offset: 0x0001E00D
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0001F01F File Offset: 0x0001E01F
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

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0001F02D File Offset: 0x0001E02D
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x0001F03F File Offset: 0x0001E03F
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

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0001F04D File Offset: 0x0001E04D
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0001F05F File Offset: 0x0001E05F
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

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0001F06D File Offset: 0x0001E06D
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0001F07F File Offset: 0x0001E07F
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

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0001F08D File Offset: 0x0001E08D
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0001F09F File Offset: 0x0001E09F
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

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0001F0AD File Offset: 0x0001E0AD
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x0001F0BF File Offset: 0x0001E0BF
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

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0001F0CD File Offset: 0x0001E0CD
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x0001F0DF File Offset: 0x0001E0DF
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

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0001F0ED File Offset: 0x0001E0ED
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0001F0FF File Offset: 0x0001E0FF
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

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0001F10D File Offset: 0x0001E10D
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0001F11F File Offset: 0x0001E11F
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

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0001F12D File Offset: 0x0001E12D
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x0001F13F File Offset: 0x0001E13F
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

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0001F14D File Offset: 0x0001E14D
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0001F15F File Offset: 0x0001E15F
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

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0001F16D File Offset: 0x0001E16D
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0001F17F File Offset: 0x0001E17F
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

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0001F18D File Offset: 0x0001E18D
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0001F19F File Offset: 0x0001E19F
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

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0001F1AD File Offset: 0x0001E1AD
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0001F1BF File Offset: 0x0001E1BF
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

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0001F1CD File Offset: 0x0001E1CD
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0001F1DF File Offset: 0x0001E1DF
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0001F1ED File Offset: 0x0001E1ED
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0001F1FF File Offset: 0x0001E1FF
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

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0001F20D File Offset: 0x0001E20D
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0001F21F File Offset: 0x0001E21F
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0001F22D File Offset: 0x0001E22D
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0001F23F File Offset: 0x0001E23F
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

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0001F24D File Offset: 0x0001E24D
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0001F25F File Offset: 0x0001E25F
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

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0001F26D File Offset: 0x0001E26D
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0001F27F File Offset: 0x0001E27F
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

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0001F28D File Offset: 0x0001E28D
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0001F29F File Offset: 0x0001E29F
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

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0001F2AD File Offset: 0x0001E2AD
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x0001F2BF File Offset: 0x0001E2BF
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

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0001F2CD File Offset: 0x0001E2CD
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0001F2DF File Offset: 0x0001E2DF
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0001F2ED File Offset: 0x0001E2ED
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0001F2FC File Offset: 0x0001E2FC
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

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x0001F307 File Offset: 0x0001E307
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0001F319 File Offset: 0x0001E319
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x0001F327 File Offset: 0x0001E327
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x0001F339 File Offset: 0x0001E339
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

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x0001F347 File Offset: 0x0001E347
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0001F356 File Offset: 0x0001E356
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

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x0001F361 File Offset: 0x0001E361
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0001F373 File Offset: 0x0001E373
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

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x0001F381 File Offset: 0x0001E381
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0001F393 File Offset: 0x0001E393
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

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x0001F3A1 File Offset: 0x0001E3A1
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0001F3B3 File Offset: 0x0001E3B3
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

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x0001F3C1 File Offset: 0x0001E3C1
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x0001F3D3 File Offset: 0x0001E3D3
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

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0001F3E1 File Offset: 0x0001E3E1
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x0001F3F3 File Offset: 0x0001E3F3
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

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0001F401 File Offset: 0x0001E401
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0001F413 File Offset: 0x0001E413
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

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x0001F421 File Offset: 0x0001E421
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x0001F433 File Offset: 0x0001E433
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

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0001F441 File Offset: 0x0001E441
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0001F45F File Offset: 0x0001E45F
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0001F47C File Offset: 0x0001E47C
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0001F48E File Offset: 0x0001E48E
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

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0001F49C File Offset: 0x0001E49C
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0001F4AE File Offset: 0x0001E4AE
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0001F4BC File Offset: 0x0001E4BC
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0001F4CE File Offset: 0x0001E4CE
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

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0001F4DC File Offset: 0x0001E4DC
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0001F4EE File Offset: 0x0001E4EE
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

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x0001F4FC File Offset: 0x0001E4FC
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0001F50E File Offset: 0x0001E50E
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

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x0001F51C File Offset: 0x0001E51C
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0001F52E File Offset: 0x0001E52E
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

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0001F53C File Offset: 0x0001E53C
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0001F54E File Offset: 0x0001E54E
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

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x0001F55C File Offset: 0x0001E55C
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0001F56E File Offset: 0x0001E56E
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

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x0001F57C File Offset: 0x0001E57C
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0001F58E File Offset: 0x0001E58E
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x0001F59C File Offset: 0x0001E59C
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0001F5AE File Offset: 0x0001E5AE
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

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x0001F5BC File Offset: 0x0001E5BC
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0001F5CE File Offset: 0x0001E5CE
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

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x0001F5DC File Offset: 0x0001E5DC
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x0001F5EE File Offset: 0x0001E5EE
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

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0001F5FC File Offset: 0x0001E5FC
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0001F61A File Offset: 0x0001E61A
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0001F637 File Offset: 0x0001E637
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0001F649 File Offset: 0x0001E649
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

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0001F657 File Offset: 0x0001E657
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0001F675 File Offset: 0x0001E675
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x0001F692 File Offset: 0x0001E692
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x0001F6A4 File Offset: 0x0001E6A4
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

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0001F6B2 File Offset: 0x0001E6B2
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0001F6D0 File Offset: 0x0001E6D0
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0001F6ED File Offset: 0x0001E6ED
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0001F6FB File Offset: 0x0001E6FB
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

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0001F705 File Offset: 0x0001E705
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0001F717 File Offset: 0x0001E717
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

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0001F725 File Offset: 0x0001E725
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0001F737 File Offset: 0x0001E737
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

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0001F745 File Offset: 0x0001E745
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0001F757 File Offset: 0x0001E757
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

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0001F765 File Offset: 0x0001E765
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0001F777 File Offset: 0x0001E777
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

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0001F785 File Offset: 0x0001E785
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0001F797 File Offset: 0x0001E797
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0001F7A5 File Offset: 0x0001E7A5
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0001F7B4 File Offset: 0x0001E7B4
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

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0001F7BF File Offset: 0x0001E7BF
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x0001F7CE File Offset: 0x0001E7CE
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

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0001F7D9 File Offset: 0x0001E7D9
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0001F7E8 File Offset: 0x0001E7E8
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

		// Token: 0x040002E4 RID: 740
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002E5 RID: 741
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002E6 RID: 742
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040002E7 RID: 743
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040002E8 RID: 744
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040002E9 RID: 745
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040002EA RID: 746
		private ArrayList fPartyIDsGroup = new ArrayList();
	}
}
