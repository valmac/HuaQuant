using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000007 RID: 7
	public class FIXSecurityDefinitionRequest : FIXMessage
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000034CA File Offset: 0x000024CA
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000034DC File Offset: 0x000024DC
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000034EA File Offset: 0x000024EA
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000034F9 File Offset: 0x000024F9
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00003504 File Offset: 0x00002504
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00003513 File Offset: 0x00002513
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000351E File Offset: 0x0000251E
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000352D File Offset: 0x0000252D
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00003538 File Offset: 0x00002538
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00003547 File Offset: 0x00002547
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00003552 File Offset: 0x00002552
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00003561 File Offset: 0x00002561
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000356C File Offset: 0x0000256C
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000357E File Offset: 0x0000257E
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000358C File Offset: 0x0000258C
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000359B File Offset: 0x0000259B
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000035A6 File Offset: 0x000025A6
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000035B5 File Offset: 0x000025B5
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000035C0 File Offset: 0x000025C0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000035CF File Offset: 0x000025CF
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000035DA File Offset: 0x000025DA
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000035E9 File Offset: 0x000025E9
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000035F4 File Offset: 0x000025F4
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00003606 File Offset: 0x00002606
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00003614 File Offset: 0x00002614
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00003623 File Offset: 0x00002623
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000362E File Offset: 0x0000262E
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000363C File Offset: 0x0000263C
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00003646 File Offset: 0x00002646
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00003655 File Offset: 0x00002655
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

		// Token: 0x0600013A RID: 314 RVA: 0x00003660 File Offset: 0x00002660
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003673 File Offset: 0x00002673
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00003682 File Offset: 0x00002682
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00003694 File Offset: 0x00002694
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000036A2 File Offset: 0x000026A2
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000036B4 File Offset: 0x000026B4
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000036C2 File Offset: 0x000026C2
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000036D1 File Offset: 0x000026D1
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000036DC File Offset: 0x000026DC
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000036EB File Offset: 0x000026EB
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000036F6 File Offset: 0x000026F6
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00003705 File Offset: 0x00002705
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00003710 File Offset: 0x00002710
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000371F File Offset: 0x0000271F
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000372A File Offset: 0x0000272A
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000373C File Offset: 0x0000273C
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000374A File Offset: 0x0000274A
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000375C File Offset: 0x0000275C
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000376A File Offset: 0x0000276A
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000377C File Offset: 0x0000277C
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000378A File Offset: 0x0000278A
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000379C File Offset: 0x0000279C
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000037AA File Offset: 0x000027AA
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000037BC File Offset: 0x000027BC
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

		// Token: 0x06000152 RID: 338 RVA: 0x000037CA File Offset: 0x000027CA
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000037E8 File Offset: 0x000027E8
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00003805 File Offset: 0x00002805
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00003817 File Offset: 0x00002817
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00003825 File Offset: 0x00002825
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00003837 File Offset: 0x00002837
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00003845 File Offset: 0x00002845
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00003857 File Offset: 0x00002857
		[FIXField("321", EFieldOption.Required)]
		public int SecurityRequestType
		{
			get
			{
				return this.GetIntField(321).Value;
			}
			set
			{
				this.AddIntField(321, value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00003865 File Offset: 0x00002865
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00003874 File Offset: 0x00002874
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000387F File Offset: 0x0000287F
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000388E File Offset: 0x0000288E
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00003899 File Offset: 0x00002899
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000038A8 File Offset: 0x000028A8
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000038B3 File Offset: 0x000028B3
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000038C2 File Offset: 0x000028C2
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000038CD File Offset: 0x000028CD
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000038DF File Offset: 0x000028DF
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

		// Token: 0x06000164 RID: 356 RVA: 0x000038ED File Offset: 0x000028ED
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000390B File Offset: 0x0000290B
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003928 File Offset: 0x00002928
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000393A File Offset: 0x0000293A
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00003948 File Offset: 0x00002948
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000395A File Offset: 0x0000295A
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00003968 File Offset: 0x00002968
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000397A File Offset: 0x0000297A
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00003988 File Offset: 0x00002988
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000399A File Offset: 0x0000299A
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000039A8 File Offset: 0x000029A8
		// (set) Token: 0x0600016F RID: 367 RVA: 0x000039BA File Offset: 0x000029BA
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000039C8 File Offset: 0x000029C8
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000039DA File Offset: 0x000029DA
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000039E8 File Offset: 0x000029E8
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000039FA File Offset: 0x000029FA
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00003A08 File Offset: 0x00002A08
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00003A1A File Offset: 0x00002A1A
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00003A28 File Offset: 0x00002A28
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00003A3A File Offset: 0x00002A3A
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00003A48 File Offset: 0x00002A48
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00003A5A File Offset: 0x00002A5A
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00003A68 File Offset: 0x00002A68
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00003A7A File Offset: 0x00002A7A
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00003A88 File Offset: 0x00002A88
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00003A9A File Offset: 0x00002A9A
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003AA8 File Offset: 0x00002AA8
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00003ABA File Offset: 0x00002ABA
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00003AC8 File Offset: 0x00002AC8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00003ADA File Offset: 0x00002ADA
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00003AE8 File Offset: 0x00002AE8
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00003AFA File Offset: 0x00002AFA
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00003B08 File Offset: 0x00002B08
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00003B1A File Offset: 0x00002B1A
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003B28 File Offset: 0x00002B28
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00003B3A File Offset: 0x00002B3A
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00003B48 File Offset: 0x00002B48
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00003B5A File Offset: 0x00002B5A
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00003B68 File Offset: 0x00002B68
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00003B7A File Offset: 0x00002B7A
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00003B88 File Offset: 0x00002B88
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00003B9A File Offset: 0x00002B9A
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00003BA8 File Offset: 0x00002BA8
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00003BBA File Offset: 0x00002BBA
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00003BC8 File Offset: 0x00002BC8
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00003BDA File Offset: 0x00002BDA
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00003BE8 File Offset: 0x00002BE8
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00003BFA File Offset: 0x00002BFA
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00003C08 File Offset: 0x00002C08
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00003C1A File Offset: 0x00002C1A
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00003C28 File Offset: 0x00002C28
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00003C37 File Offset: 0x00002C37
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00003C42 File Offset: 0x00002C42
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00003C54 File Offset: 0x00002C54
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00003C62 File Offset: 0x00002C62
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00003C74 File Offset: 0x00002C74
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00003C82 File Offset: 0x00002C82
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00003C91 File Offset: 0x00002C91
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00003C9C File Offset: 0x00002C9C
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00003CAE File Offset: 0x00002CAE
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00003CBC File Offset: 0x00002CBC
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00003CCE File Offset: 0x00002CCE
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00003CDC File Offset: 0x00002CDC
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00003CEE File Offset: 0x00002CEE
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00003CFC File Offset: 0x00002CFC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00003D0E File Offset: 0x00002D0E
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00003D1C File Offset: 0x00002D1C
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00003D2E File Offset: 0x00002D2E
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00003D3C File Offset: 0x00002D3C
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00003D4E File Offset: 0x00002D4E
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00003D5C File Offset: 0x00002D5C
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00003D6E File Offset: 0x00002D6E
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

		// Token: 0x060001AC RID: 428 RVA: 0x00003D7C File Offset: 0x00002D7C
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003D9A File Offset: 0x00002D9A
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00003DB7 File Offset: 0x00002DB7
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00003DC9 File Offset: 0x00002DC9
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00003DD7 File Offset: 0x00002DD7
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00003DE9 File Offset: 0x00002DE9
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00003DF7 File Offset: 0x00002DF7
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00003E09 File Offset: 0x00002E09
		[FIXField("668", EFieldOption.Optional)]
		public int DeliveryForm
		{
			get
			{
				return this.GetIntField(668).Value;
			}
			set
			{
				this.AddIntField(668, value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003E17 File Offset: 0x00002E17
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00003E29 File Offset: 0x00002E29
		[FIXField("869", EFieldOption.Optional)]
		public double PctAtRisk
		{
			get
			{
				return this.GetDoubleField(869).Value;
			}
			set
			{
				this.AddDoubleField(869, value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00003E37 File Offset: 0x00002E37
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00003E49 File Offset: 0x00002E49
		[FIXField("870", EFieldOption.Optional)]
		public int NoInstrAttrib
		{
			get
			{
				return this.GetIntField(870).Value;
			}
			set
			{
				this.AddIntField(870, value);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00003E57 File Offset: 0x00002E57
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00003E75 File Offset: 0x00002E75
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00003E92 File Offset: 0x00002E92
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00003EA4 File Offset: 0x00002EA4
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

		// Token: 0x060001BC RID: 444 RVA: 0x00003EB2 File Offset: 0x00002EB2
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003ED0 File Offset: 0x00002ED0
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00003EED File Offset: 0x00002EED
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00003EFC File Offset: 0x00002EFC
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00003F07 File Offset: 0x00002F07
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00003F16 File Offset: 0x00002F16
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00003F21 File Offset: 0x00002F21
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00003F33 File Offset: 0x00002F33
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00003F41 File Offset: 0x00002F41
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00003F53 File Offset: 0x00002F53
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00003F61 File Offset: 0x00002F61
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00003F73 File Offset: 0x00002F73
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00003F81 File Offset: 0x00002F81
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00003F93 File Offset: 0x00002F93
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00003FA1 File Offset: 0x00002FA1
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00003FB3 File Offset: 0x00002FB3
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

		// Token: 0x060001CC RID: 460 RVA: 0x00003FC1 File Offset: 0x00002FC1
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00003FDF File Offset: 0x00002FDF
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00003FFC File Offset: 0x00002FFC
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000400E File Offset: 0x0000300E
		[FIXField("827", EFieldOption.Optional)]
		public int ExpirationCycle
		{
			get
			{
				return this.GetIntField(827).Value;
			}
			set
			{
				this.AddIntField(827, value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000401C File Offset: 0x0000301C
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000402E File Offset: 0x0000302E
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000403C File Offset: 0x0000303C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000404B File Offset: 0x0000304B
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00004056 File Offset: 0x00003056
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00004065 File Offset: 0x00003065
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00004070 File Offset: 0x00003070
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000407F File Offset: 0x0000307F
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

		// Token: 0x060001D8 RID: 472 RVA: 0x0000408C File Offset: 0x0000308C
		public FIXSecurityDefinitionRequest()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000040EC File Offset: 0x000030EC
		public FIXSecurityDefinitionRequest(string SecurityReqID, int SecurityRequestType)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityRequestType = SecurityRequestType;
		}

		// Token: 0x0400000D RID: 13
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400000E RID: 14
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400000F RID: 15
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000010 RID: 16
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000011 RID: 17
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x04000012 RID: 18
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000013 RID: 19
		private ArrayList fLegsGroup = new ArrayList();
	}
}
