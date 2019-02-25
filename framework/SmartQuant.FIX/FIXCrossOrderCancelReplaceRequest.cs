using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000E1 RID: 225
	public class FIXCrossOrderCancelReplaceRequest : FIXMessage
	{
		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x0002E974 File Offset: 0x0002D974
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x0002E986 File Offset: 0x0002D986
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

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x0002E994 File Offset: 0x0002D994
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x0002E9A3 File Offset: 0x0002D9A3
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

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0002E9AE File Offset: 0x0002D9AE
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x0002E9BD File Offset: 0x0002D9BD
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

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x0002E9C8 File Offset: 0x0002D9C8
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x0002E9D7 File Offset: 0x0002D9D7
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

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x0002E9E2 File Offset: 0x0002D9E2
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x0002E9F1 File Offset: 0x0002D9F1
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

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0002E9FC File Offset: 0x0002D9FC
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x0002EA0B File Offset: 0x0002DA0B
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

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0002EA16 File Offset: 0x0002DA16
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x0002EA28 File Offset: 0x0002DA28
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

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x0002EA36 File Offset: 0x0002DA36
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x0002EA45 File Offset: 0x0002DA45
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

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x0002EA50 File Offset: 0x0002DA50
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x0002EA5F File Offset: 0x0002DA5F
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

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0002EA6A File Offset: 0x0002DA6A
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x0002EA79 File Offset: 0x0002DA79
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

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x0002EA84 File Offset: 0x0002DA84
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0002EA93 File Offset: 0x0002DA93
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

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x0002EA9E File Offset: 0x0002DA9E
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x0002EAB0 File Offset: 0x0002DAB0
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

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x0002EABE File Offset: 0x0002DABE
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x0002EACD File Offset: 0x0002DACD
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

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x0002EAD8 File Offset: 0x0002DAD8
		// (set) Token: 0x06002C05 RID: 11269 RVA: 0x0002EAE6 File Offset: 0x0002DAE6
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

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x0002EAF0 File Offset: 0x0002DAF0
		// (set) Token: 0x06002C07 RID: 11271 RVA: 0x0002EAFF File Offset: 0x0002DAFF
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

		// Token: 0x06002C08 RID: 11272 RVA: 0x0002EB0A File Offset: 0x0002DB0A
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0002EB1D File Offset: 0x0002DB1D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x0002EB2C File Offset: 0x0002DB2C
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x0002EB3E File Offset: 0x0002DB3E
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

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x0002EB4C File Offset: 0x0002DB4C
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x0002EB5E File Offset: 0x0002DB5E
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

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x0002EB6C File Offset: 0x0002DB6C
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x0002EB7B File Offset: 0x0002DB7B
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

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x0002EB86 File Offset: 0x0002DB86
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x0002EB95 File Offset: 0x0002DB95
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

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x0002EBA0 File Offset: 0x0002DBA0
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x0002EBAF File Offset: 0x0002DBAF
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

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x0002EBBA File Offset: 0x0002DBBA
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x0002EBC9 File Offset: 0x0002DBC9
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

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x0002EBD4 File Offset: 0x0002DBD4
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x0002EBE6 File Offset: 0x0002DBE6
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

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x0002EBF4 File Offset: 0x0002DBF4
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x0002EC06 File Offset: 0x0002DC06
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

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0002EC14 File Offset: 0x0002DC14
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0002EC26 File Offset: 0x0002DC26
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

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x0002EC34 File Offset: 0x0002DC34
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x0002EC46 File Offset: 0x0002DC46
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

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x0002EC54 File Offset: 0x0002DC54
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0002EC66 File Offset: 0x0002DC66
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

		// Token: 0x06002C20 RID: 11296 RVA: 0x0002EC74 File Offset: 0x0002DC74
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x0002EC92 File Offset: 0x0002DC92
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x0002ECAF File Offset: 0x0002DCAF
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x0002ECC1 File Offset: 0x0002DCC1
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

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x0002ECCF File Offset: 0x0002DCCF
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x0002ECDE File Offset: 0x0002DCDE
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

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x0002ECE9 File Offset: 0x0002DCE9
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x0002ECFB File Offset: 0x0002DCFB
		[FIXField("548", EFieldOption.Required)]
		public string CrossID
		{
			get
			{
				return this.GetStringField(548).Value;
			}
			set
			{
				this.AddStringField(548, value);
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x0002ED09 File Offset: 0x0002DD09
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x0002ED1B File Offset: 0x0002DD1B
		[FIXField("551", EFieldOption.Required)]
		public string OrigCrossID
		{
			get
			{
				return this.GetStringField(551).Value;
			}
			set
			{
				this.AddStringField(551, value);
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x0002ED29 File Offset: 0x0002DD29
		// (set) Token: 0x06002C2B RID: 11307 RVA: 0x0002ED3B File Offset: 0x0002DD3B
		[FIXField("549", EFieldOption.Required)]
		public int CrossType
		{
			get
			{
				return this.GetIntField(549).Value;
			}
			set
			{
				this.AddIntField(549, value);
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x0002ED49 File Offset: 0x0002DD49
		// (set) Token: 0x06002C2D RID: 11309 RVA: 0x0002ED5B File Offset: 0x0002DD5B
		[FIXField("550", EFieldOption.Required)]
		public int CrossPrioritization
		{
			get
			{
				return this.GetIntField(550).Value;
			}
			set
			{
				this.AddIntField(550, value);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x0002ED69 File Offset: 0x0002DD69
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x0002ED7B File Offset: 0x0002DD7B
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

		// Token: 0x06002C30 RID: 11312 RVA: 0x0002ED89 File Offset: 0x0002DD89
		public FIXSidesGroup GetSidesGroup(int i)
		{
			if (i < this.NoSides)
			{
				return (FIXSidesGroup)this.fSidesGroup[i];
			}
			return null;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0002EDA7 File Offset: 0x0002DDA7
		public void AddGroup(FIXSidesGroup group)
		{
			this.fSidesGroup.Add(group);
			this.NoSides++;
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x0002EDC4 File Offset: 0x0002DDC4
		// (set) Token: 0x06002C33 RID: 11315 RVA: 0x0002EDD3 File Offset: 0x0002DDD3
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

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x0002EDDE File Offset: 0x0002DDDE
		// (set) Token: 0x06002C35 RID: 11317 RVA: 0x0002EDED File Offset: 0x0002DDED
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

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x0002EDF8 File Offset: 0x0002DDF8
		// (set) Token: 0x06002C37 RID: 11319 RVA: 0x0002EE07 File Offset: 0x0002DE07
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

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x0002EE12 File Offset: 0x0002DE12
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x0002EE21 File Offset: 0x0002DE21
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

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x0002EE2C File Offset: 0x0002DE2C
		// (set) Token: 0x06002C3B RID: 11323 RVA: 0x0002EE3E File Offset: 0x0002DE3E
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

		// Token: 0x06002C3C RID: 11324 RVA: 0x0002EE4C File Offset: 0x0002DE4C
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x0002EE6A File Offset: 0x0002DE6A
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x0002EE87 File Offset: 0x0002DE87
		// (set) Token: 0x06002C3F RID: 11327 RVA: 0x0002EE99 File Offset: 0x0002DE99
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

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x0002EEA7 File Offset: 0x0002DEA7
		// (set) Token: 0x06002C41 RID: 11329 RVA: 0x0002EEB9 File Offset: 0x0002DEB9
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

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x0002EEC7 File Offset: 0x0002DEC7
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x0002EED9 File Offset: 0x0002DED9
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

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x0002EEE7 File Offset: 0x0002DEE7
		// (set) Token: 0x06002C45 RID: 11333 RVA: 0x0002EEF9 File Offset: 0x0002DEF9
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

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x0002EF07 File Offset: 0x0002DF07
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x0002EF19 File Offset: 0x0002DF19
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

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x0002EF27 File Offset: 0x0002DF27
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x0002EF39 File Offset: 0x0002DF39
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

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x0002EF47 File Offset: 0x0002DF47
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0002EF59 File Offset: 0x0002DF59
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

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x0002EF67 File Offset: 0x0002DF67
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x0002EF79 File Offset: 0x0002DF79
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

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x0002EF87 File Offset: 0x0002DF87
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x0002EF99 File Offset: 0x0002DF99
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

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x0002EFA7 File Offset: 0x0002DFA7
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x0002EFB9 File Offset: 0x0002DFB9
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

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x0002EFC7 File Offset: 0x0002DFC7
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x0002EFD9 File Offset: 0x0002DFD9
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

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0002EFE7 File Offset: 0x0002DFE7
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0002EFF9 File Offset: 0x0002DFF9
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

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x0002F007 File Offset: 0x0002E007
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x0002F019 File Offset: 0x0002E019
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

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x0002F027 File Offset: 0x0002E027
		// (set) Token: 0x06002C59 RID: 11353 RVA: 0x0002F039 File Offset: 0x0002E039
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

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x0002F047 File Offset: 0x0002E047
		// (set) Token: 0x06002C5B RID: 11355 RVA: 0x0002F059 File Offset: 0x0002E059
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

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x0002F067 File Offset: 0x0002E067
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x0002F079 File Offset: 0x0002E079
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

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x0002F087 File Offset: 0x0002E087
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x0002F099 File Offset: 0x0002E099
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

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x0002F0A7 File Offset: 0x0002E0A7
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x0002F0B9 File Offset: 0x0002E0B9
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

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x0002F0C7 File Offset: 0x0002E0C7
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x0002F0D9 File Offset: 0x0002E0D9
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

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x0002F0E7 File Offset: 0x0002E0E7
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x0002F0F9 File Offset: 0x0002E0F9
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

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x0002F107 File Offset: 0x0002E107
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x0002F119 File Offset: 0x0002E119
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

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0002F127 File Offset: 0x0002E127
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x0002F139 File Offset: 0x0002E139
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

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x0002F147 File Offset: 0x0002E147
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x0002F159 File Offset: 0x0002E159
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

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x0002F167 File Offset: 0x0002E167
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x0002F179 File Offset: 0x0002E179
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

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x0002F187 File Offset: 0x0002E187
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x0002F196 File Offset: 0x0002E196
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

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x0002F1A1 File Offset: 0x0002E1A1
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x0002F1B3 File Offset: 0x0002E1B3
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

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x0002F1C1 File Offset: 0x0002E1C1
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x0002F1D3 File Offset: 0x0002E1D3
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

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x0002F1E1 File Offset: 0x0002E1E1
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x0002F1F0 File Offset: 0x0002E1F0
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

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x0002F1FB File Offset: 0x0002E1FB
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x0002F20D File Offset: 0x0002E20D
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

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x0002F21B File Offset: 0x0002E21B
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x0002F22D File Offset: 0x0002E22D
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

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x0002F23B File Offset: 0x0002E23B
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x0002F24D File Offset: 0x0002E24D
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

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x0002F25B File Offset: 0x0002E25B
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x0002F26D File Offset: 0x0002E26D
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

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x0002F27B File Offset: 0x0002E27B
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0002F28D File Offset: 0x0002E28D
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

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x0002F29B File Offset: 0x0002E29B
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x0002F2AD File Offset: 0x0002E2AD
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

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x0002F2BB File Offset: 0x0002E2BB
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x0002F2CD File Offset: 0x0002E2CD
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

		// Token: 0x06002C84 RID: 11396 RVA: 0x0002F2DB File Offset: 0x0002E2DB
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0002F2F9 File Offset: 0x0002E2F9
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x0002F316 File Offset: 0x0002E316
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x0002F328 File Offset: 0x0002E328
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

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x0002F336 File Offset: 0x0002E336
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x0002F348 File Offset: 0x0002E348
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

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x0002F356 File Offset: 0x0002E356
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x0002F368 File Offset: 0x0002E368
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

		// Token: 0x06002C8C RID: 11404 RVA: 0x0002F376 File Offset: 0x0002E376
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x0002F394 File Offset: 0x0002E394
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x0002F3B1 File Offset: 0x0002E3B1
		// (set) Token: 0x06002C8F RID: 11407 RVA: 0x0002F3C3 File Offset: 0x0002E3C3
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

		// Token: 0x06002C90 RID: 11408 RVA: 0x0002F3D1 File Offset: 0x0002E3D1
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x0002F3EF File Offset: 0x0002E3EF
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x0002F40C File Offset: 0x0002E40C
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x0002F41B File Offset: 0x0002E41B
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

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0002F426 File Offset: 0x0002E426
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0002F435 File Offset: 0x0002E435
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

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x0002F440 File Offset: 0x0002E440
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0002F44F File Offset: 0x0002E44F
		[FIXField("21", EFieldOption.Optional)]
		public char HandlInst
		{
			get
			{
				return this.GetCharField(21).Value;
			}
			set
			{
				this.AddCharField(21, value);
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0002F45A File Offset: 0x0002E45A
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x0002F469 File Offset: 0x0002E469
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringField(18).Value;
			}
			set
			{
				this.AddStringField(18, value);
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x0002F474 File Offset: 0x0002E474
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x0002F483 File Offset: 0x0002E483
		[FIXField("110", EFieldOption.Optional)]
		public double MinQty
		{
			get
			{
				return this.GetDoubleField(110).Value;
			}
			set
			{
				this.AddDoubleField(110, value);
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x0002F48E File Offset: 0x0002E48E
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x0002F49D File Offset: 0x0002E49D
		[FIXField("111", EFieldOption.Optional)]
		public double MaxFloor
		{
			get
			{
				return this.GetDoubleField(111).Value;
			}
			set
			{
				this.AddDoubleField(111, value);
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x0002F4A8 File Offset: 0x0002E4A8
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x0002F4B7 File Offset: 0x0002E4B7
		[FIXField("100", EFieldOption.Optional)]
		public string ExDestination
		{
			get
			{
				return this.GetStringField(100).Value;
			}
			set
			{
				this.AddStringField(100, value);
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x0002F4C2 File Offset: 0x0002E4C2
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x0002F4D4 File Offset: 0x0002E4D4
		[FIXField("386", EFieldOption.Optional)]
		public int NoTradingSessions
		{
			get
			{
				return this.GetIntField(386).Value;
			}
			set
			{
				this.AddIntField(386, value);
			}
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0002F4E2 File Offset: 0x0002E4E2
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0002F500 File Offset: 0x0002E500
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x0002F51D File Offset: 0x0002E51D
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x0002F52C File Offset: 0x0002E52C
		[FIXField("81", EFieldOption.Optional)]
		public char ProcessCode
		{
			get
			{
				return this.GetCharField(81).Value;
			}
			set
			{
				this.AddCharField(81, value);
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x0002F537 File Offset: 0x0002E537
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x0002F549 File Offset: 0x0002E549
		[FIXField("140", EFieldOption.Optional)]
		public double PrevClosePx
		{
			get
			{
				return this.GetDoubleField(140).Value;
			}
			set
			{
				this.AddDoubleField(140, value);
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x0002F557 File Offset: 0x0002E557
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x0002F566 File Offset: 0x0002E566
		[FIXField("114", EFieldOption.Optional)]
		public bool LocateReqd
		{
			get
			{
				return this.GetBoolField(114).Value;
			}
			set
			{
				this.AddBoolField(114, value);
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x0002F571 File Offset: 0x0002E571
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x0002F580 File Offset: 0x0002E580
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

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x0002F58B File Offset: 0x0002E58B
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0002F59D File Offset: 0x0002E59D
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntField(232).Value;
			}
			set
			{
				this.AddIntField(232, value);
			}
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0002F5AB File Offset: 0x0002E5AB
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0002F5C9 File Offset: 0x0002E5C9
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x0002F5E6 File Offset: 0x0002E5E6
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x0002F5F5 File Offset: 0x0002E5F5
		[FIXField("40", EFieldOption.Required)]
		public char OrdType
		{
			get
			{
				return this.GetCharField(40).Value;
			}
			set
			{
				this.AddCharField(40, value);
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x0002F600 File Offset: 0x0002E600
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x0002F612 File Offset: 0x0002E612
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

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x0002F620 File Offset: 0x0002E620
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x0002F62F File Offset: 0x0002E62F
		[FIXField("44", EFieldOption.Optional)]
		public double Price
		{
			get
			{
				return this.GetDoubleField(44).Value;
			}
			set
			{
				this.AddDoubleField(44, value);
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x0002F63A File Offset: 0x0002E63A
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x0002F649 File Offset: 0x0002E649
		[FIXField("99", EFieldOption.Optional)]
		public double StopPx
		{
			get
			{
				return this.GetDoubleField(99).Value;
			}
			set
			{
				this.AddDoubleField(99, value);
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x0002F654 File Offset: 0x0002E654
		// (set) Token: 0x06002CB9 RID: 11449 RVA: 0x0002F666 File Offset: 0x0002E666
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

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x0002F674 File Offset: 0x0002E674
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x0002F686 File Offset: 0x0002E686
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

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x0002F694 File Offset: 0x0002E694
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x0002F6A6 File Offset: 0x0002E6A6
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

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x0002F6B4 File Offset: 0x0002E6B4
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x0002F6C6 File Offset: 0x0002E6C6
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

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x0002F6D4 File Offset: 0x0002E6D4
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x0002F6E6 File Offset: 0x0002E6E6
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

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x0002F6F4 File Offset: 0x0002E6F4
		// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x0002F706 File Offset: 0x0002E706
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

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x0002F714 File Offset: 0x0002E714
		// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x0002F726 File Offset: 0x0002E726
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

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x0002F734 File Offset: 0x0002E734
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x0002F746 File Offset: 0x0002E746
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

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x0002F754 File Offset: 0x0002E754
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x0002F766 File Offset: 0x0002E766
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

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x0002F774 File Offset: 0x0002E774
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x0002F786 File Offset: 0x0002E786
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

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x0002F794 File Offset: 0x0002E794
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x0002F7A6 File Offset: 0x0002E7A6
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

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x0002F7B4 File Offset: 0x0002E7B4
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x0002F7C6 File Offset: 0x0002E7C6
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

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x0002F7D4 File Offset: 0x0002E7D4
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x0002F7E6 File Offset: 0x0002E7E6
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

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x0002F7F4 File Offset: 0x0002E7F4
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x0002F806 File Offset: 0x0002E806
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

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0002F814 File Offset: 0x0002E814
		// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x0002F823 File Offset: 0x0002E823
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

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x0002F82E File Offset: 0x0002E82E
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x0002F840 File Offset: 0x0002E840
		[FIXField("376", EFieldOption.Optional)]
		public string ComplianceID
		{
			get
			{
				return this.GetStringField(376).Value;
			}
			set
			{
				this.AddStringField(376, value);
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x0002F84E File Offset: 0x0002E84E
		// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x0002F85D File Offset: 0x0002E85D
		[FIXField("23", EFieldOption.Optional)]
		public string IOIID
		{
			get
			{
				return this.GetStringField(23).Value;
			}
			set
			{
				this.AddStringField(23, value);
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x0002F868 File Offset: 0x0002E868
		// (set) Token: 0x06002CDB RID: 11483 RVA: 0x0002F877 File Offset: 0x0002E877
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

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x0002F882 File Offset: 0x0002E882
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x0002F891 File Offset: 0x0002E891
		[FIXField("59", EFieldOption.Optional)]
		public char TimeInForce
		{
			get
			{
				return this.GetCharField(59).Value;
			}
			set
			{
				this.AddCharField(59, value);
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x0002F89C File Offset: 0x0002E89C
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x0002F8AE File Offset: 0x0002E8AE
		[FIXField("168", EFieldOption.Optional)]
		public DateTime EffectiveTime
		{
			get
			{
				return this.GetDateTimeField(168).Value;
			}
			set
			{
				this.AddDateTimeField(168, value);
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x0002F8BC File Offset: 0x0002E8BC
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x0002F8CE File Offset: 0x0002E8CE
		[FIXField("432", EFieldOption.Optional)]
		public DateTime ExpireDate
		{
			get
			{
				return this.GetDateTimeField(432).Value;
			}
			set
			{
				this.AddDateTimeField(432, value);
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x0002F8DC File Offset: 0x0002E8DC
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x0002F8EB File Offset: 0x0002E8EB
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeField(126).Value;
			}
			set
			{
				this.AddDateTimeField(126, value);
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x0002F8F6 File Offset: 0x0002E8F6
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x0002F908 File Offset: 0x0002E908
		[FIXField("427", EFieldOption.Optional)]
		public int GTBookingInst
		{
			get
			{
				return this.GetIntField(427).Value;
			}
			set
			{
				this.AddIntField(427, value);
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x0002F916 File Offset: 0x0002E916
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x0002F928 File Offset: 0x0002E928
		[FIXField("210", EFieldOption.Optional)]
		public double MaxShow
		{
			get
			{
				return this.GetDoubleField(210).Value;
			}
			set
			{
				this.AddDoubleField(210, value);
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x0002F936 File Offset: 0x0002E936
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x0002F948 File Offset: 0x0002E948
		[FIXField("211", EFieldOption.Optional)]
		public double PegOffsetValue
		{
			get
			{
				return this.GetDoubleField(211).Value;
			}
			set
			{
				this.AddDoubleField(211, value);
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x0002F956 File Offset: 0x0002E956
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x0002F968 File Offset: 0x0002E968
		[FIXField("835", EFieldOption.Optional)]
		public int PegMoveType
		{
			get
			{
				return this.GetIntField(835).Value;
			}
			set
			{
				this.AddIntField(835, value);
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x0002F976 File Offset: 0x0002E976
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x0002F988 File Offset: 0x0002E988
		[FIXField("836", EFieldOption.Optional)]
		public int PegOffsetType
		{
			get
			{
				return this.GetIntField(836).Value;
			}
			set
			{
				this.AddIntField(836, value);
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x0002F996 File Offset: 0x0002E996
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x0002F9A8 File Offset: 0x0002E9A8
		[FIXField("837", EFieldOption.Optional)]
		public int PegLimitType
		{
			get
			{
				return this.GetIntField(837).Value;
			}
			set
			{
				this.AddIntField(837, value);
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x0002F9B6 File Offset: 0x0002E9B6
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x0002F9C8 File Offset: 0x0002E9C8
		[FIXField("838", EFieldOption.Optional)]
		public int PegRoundDirection
		{
			get
			{
				return this.GetIntField(838).Value;
			}
			set
			{
				this.AddIntField(838, value);
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x0002F9D6 File Offset: 0x0002E9D6
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x0002F9E8 File Offset: 0x0002E9E8
		[FIXField("840", EFieldOption.Optional)]
		public int PegScope
		{
			get
			{
				return this.GetIntField(840).Value;
			}
			set
			{
				this.AddIntField(840, value);
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x0002F9F6 File Offset: 0x0002E9F6
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x0002FA08 File Offset: 0x0002EA08
		[FIXField("388", EFieldOption.Optional)]
		public char DiscretionInst
		{
			get
			{
				return this.GetCharField(388).Value;
			}
			set
			{
				this.AddCharField(388, value);
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x0002FA16 File Offset: 0x0002EA16
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x0002FA28 File Offset: 0x0002EA28
		[FIXField("389", EFieldOption.Optional)]
		public double DiscretionOffsetValue
		{
			get
			{
				return this.GetDoubleField(389).Value;
			}
			set
			{
				this.AddDoubleField(389, value);
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x0002FA36 File Offset: 0x0002EA36
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x0002FA48 File Offset: 0x0002EA48
		[FIXField("841", EFieldOption.Optional)]
		public int DiscretionMoveType
		{
			get
			{
				return this.GetIntField(841).Value;
			}
			set
			{
				this.AddIntField(841, value);
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x0002FA56 File Offset: 0x0002EA56
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x0002FA68 File Offset: 0x0002EA68
		[FIXField("842", EFieldOption.Optional)]
		public int DiscretionOffsetType
		{
			get
			{
				return this.GetIntField(842).Value;
			}
			set
			{
				this.AddIntField(842, value);
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x0002FA76 File Offset: 0x0002EA76
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x0002FA88 File Offset: 0x0002EA88
		[FIXField("843", EFieldOption.Optional)]
		public int DiscretionLimitType
		{
			get
			{
				return this.GetIntField(843).Value;
			}
			set
			{
				this.AddIntField(843, value);
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x0002FA96 File Offset: 0x0002EA96
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x0002FAA8 File Offset: 0x0002EAA8
		[FIXField("844", EFieldOption.Optional)]
		public int DiscretionRoundDirection
		{
			get
			{
				return this.GetIntField(844).Value;
			}
			set
			{
				this.AddIntField(844, value);
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x0002FAB6 File Offset: 0x0002EAB6
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x0002FAC8 File Offset: 0x0002EAC8
		[FIXField("846", EFieldOption.Optional)]
		public int DiscretionScope
		{
			get
			{
				return this.GetIntField(846).Value;
			}
			set
			{
				this.AddIntField(846, value);
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x0002FAD6 File Offset: 0x0002EAD6
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x0002FAE8 File Offset: 0x0002EAE8
		[FIXField("847", EFieldOption.Optional)]
		public int TargetStrategy
		{
			get
			{
				return this.GetIntField(847).Value;
			}
			set
			{
				this.AddIntField(847, value);
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x0002FAF6 File Offset: 0x0002EAF6
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x0002FB08 File Offset: 0x0002EB08
		[FIXField("848", EFieldOption.Optional)]
		public string TargetStrategyParameters
		{
			get
			{
				return this.GetStringField(848).Value;
			}
			set
			{
				this.AddStringField(848, value);
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x0002FB16 File Offset: 0x0002EB16
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x0002FB28 File Offset: 0x0002EB28
		[FIXField("849", EFieldOption.Optional)]
		public double ParticipationRate
		{
			get
			{
				return this.GetDoubleField(849).Value;
			}
			set
			{
				this.AddDoubleField(849, value);
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x0002FB36 File Offset: 0x0002EB36
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x0002FB48 File Offset: 0x0002EB48
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

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x0002FB56 File Offset: 0x0002EB56
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x0002FB68 File Offset: 0x0002EB68
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

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x0002FB76 File Offset: 0x0002EB76
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x0002FB88 File Offset: 0x0002EB88
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

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x0002FB96 File Offset: 0x0002EB96
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x0002FBA8 File Offset: 0x0002EBA8
		[FIXField("494", EFieldOption.Optional)]
		public string Designation
		{
			get
			{
				return this.GetStringField(494).Value;
			}
			set
			{
				this.AddStringField(494, value);
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x0002FBB6 File Offset: 0x0002EBB6
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x0002FBC5 File Offset: 0x0002EBC5
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

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x0002FBD0 File Offset: 0x0002EBD0
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x0002FBDF File Offset: 0x0002EBDF
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

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x0002FBEA File Offset: 0x0002EBEA
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x0002FBF9 File Offset: 0x0002EBF9
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

		// Token: 0x06002D16 RID: 11542 RVA: 0x0002FC04 File Offset: 0x0002EC04
		public FIXCrossOrderCancelReplaceRequest()
		{
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0002FC7C File Offset: 0x0002EC7C
		public FIXCrossOrderCancelReplaceRequest(string CrossID, string OrigCrossID, int CrossType, int CrossPrioritization, int NoSides, DateTime TransactTime, char OrdType)
		{
			this.CrossID = CrossID;
			this.OrigCrossID = OrigCrossID;
			this.CrossType = CrossType;
			this.CrossPrioritization = CrossPrioritization;
			this.NoSides = NoSides;
			this.TransactTime = TransactTime;
			this.OrdType = OrdType;
		}

		// Token: 0x040003D5 RID: 981
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003D6 RID: 982
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040003D7 RID: 983
		private ArrayList fSidesGroup = new ArrayList();

		// Token: 0x040003D8 RID: 984
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040003D9 RID: 985
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040003DA RID: 986
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040003DB RID: 987
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040003DC RID: 988
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x040003DD RID: 989
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
