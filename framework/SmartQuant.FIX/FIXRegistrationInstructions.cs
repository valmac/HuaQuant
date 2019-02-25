using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200012C RID: 300
	public class FIXRegistrationInstructions : FIXMessage
	{
		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x0003AB93 File Offset: 0x00039B93
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x0003ABA5 File Offset: 0x00039BA5
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

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0003ABB3 File Offset: 0x00039BB3
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x0003ABC2 File Offset: 0x00039BC2
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

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0003ABCD File Offset: 0x00039BCD
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0003ABDC File Offset: 0x00039BDC
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

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x0003ABE7 File Offset: 0x00039BE7
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x0003ABF6 File Offset: 0x00039BF6
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

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x0003AC01 File Offset: 0x00039C01
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x0003AC10 File Offset: 0x00039C10
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

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x0003AC1B File Offset: 0x00039C1B
		// (set) Token: 0x060037CD RID: 14285 RVA: 0x0003AC2A File Offset: 0x00039C2A
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

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x060037CE RID: 14286 RVA: 0x0003AC35 File Offset: 0x00039C35
		// (set) Token: 0x060037CF RID: 14287 RVA: 0x0003AC47 File Offset: 0x00039C47
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

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x0003AC55 File Offset: 0x00039C55
		// (set) Token: 0x060037D1 RID: 14289 RVA: 0x0003AC64 File Offset: 0x00039C64
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

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x060037D2 RID: 14290 RVA: 0x0003AC6F File Offset: 0x00039C6F
		// (set) Token: 0x060037D3 RID: 14291 RVA: 0x0003AC7E File Offset: 0x00039C7E
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

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x0003AC89 File Offset: 0x00039C89
		// (set) Token: 0x060037D5 RID: 14293 RVA: 0x0003AC98 File Offset: 0x00039C98
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

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x0003ACA3 File Offset: 0x00039CA3
		// (set) Token: 0x060037D7 RID: 14295 RVA: 0x0003ACB2 File Offset: 0x00039CB2
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

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x060037D8 RID: 14296 RVA: 0x0003ACBD File Offset: 0x00039CBD
		// (set) Token: 0x060037D9 RID: 14297 RVA: 0x0003ACCF File Offset: 0x00039CCF
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

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x0003ACDD File Offset: 0x00039CDD
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x0003ACEC File Offset: 0x00039CEC
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

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x0003ACF7 File Offset: 0x00039CF7
		// (set) Token: 0x060037DD RID: 14301 RVA: 0x0003AD05 File Offset: 0x00039D05
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

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x0003AD0F File Offset: 0x00039D0F
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x0003AD1E File Offset: 0x00039D1E
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

		// Token: 0x060037E0 RID: 14304 RVA: 0x0003AD29 File Offset: 0x00039D29
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x0003AD3C File Offset: 0x00039D3C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x0003AD4B File Offset: 0x00039D4B
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x0003AD5D File Offset: 0x00039D5D
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

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x0003AD6B File Offset: 0x00039D6B
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x0003AD7D File Offset: 0x00039D7D
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

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x0003AD8B File Offset: 0x00039D8B
		// (set) Token: 0x060037E7 RID: 14311 RVA: 0x0003AD9A File Offset: 0x00039D9A
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

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x0003ADA5 File Offset: 0x00039DA5
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x0003ADB4 File Offset: 0x00039DB4
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

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x0003ADBF File Offset: 0x00039DBF
		// (set) Token: 0x060037EB RID: 14315 RVA: 0x0003ADCE File Offset: 0x00039DCE
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

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x0003ADD9 File Offset: 0x00039DD9
		// (set) Token: 0x060037ED RID: 14317 RVA: 0x0003ADE8 File Offset: 0x00039DE8
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

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x0003ADF3 File Offset: 0x00039DF3
		// (set) Token: 0x060037EF RID: 14319 RVA: 0x0003AE05 File Offset: 0x00039E05
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

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x0003AE13 File Offset: 0x00039E13
		// (set) Token: 0x060037F1 RID: 14321 RVA: 0x0003AE25 File Offset: 0x00039E25
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

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x0003AE33 File Offset: 0x00039E33
		// (set) Token: 0x060037F3 RID: 14323 RVA: 0x0003AE45 File Offset: 0x00039E45
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

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x0003AE53 File Offset: 0x00039E53
		// (set) Token: 0x060037F5 RID: 14325 RVA: 0x0003AE65 File Offset: 0x00039E65
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

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x0003AE73 File Offset: 0x00039E73
		// (set) Token: 0x060037F7 RID: 14327 RVA: 0x0003AE85 File Offset: 0x00039E85
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

		// Token: 0x060037F8 RID: 14328 RVA: 0x0003AE93 File Offset: 0x00039E93
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x0003AEB1 File Offset: 0x00039EB1
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x0003AECE File Offset: 0x00039ECE
		// (set) Token: 0x060037FB RID: 14331 RVA: 0x0003AEE0 File Offset: 0x00039EE0
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

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x0003AEEE File Offset: 0x00039EEE
		// (set) Token: 0x060037FD RID: 14333 RVA: 0x0003AF00 File Offset: 0x00039F00
		[FIXField("513", EFieldOption.Required)]
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

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x0003AF0E File Offset: 0x00039F0E
		// (set) Token: 0x060037FF RID: 14335 RVA: 0x0003AF20 File Offset: 0x00039F20
		[FIXField("514", EFieldOption.Required)]
		public char RegistTransType
		{
			get
			{
				return this.GetCharField(514).Value;
			}
			set
			{
				this.AddCharField(514, value);
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x0003AF2E File Offset: 0x00039F2E
		// (set) Token: 0x06003801 RID: 14337 RVA: 0x0003AF40 File Offset: 0x00039F40
		[FIXField("508", EFieldOption.Required)]
		public string RegistRefID
		{
			get
			{
				return this.GetStringField(508).Value;
			}
			set
			{
				this.AddStringField(508, value);
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x0003AF4E File Offset: 0x00039F4E
		// (set) Token: 0x06003803 RID: 14339 RVA: 0x0003AF5D File Offset: 0x00039F5D
		[FIXField("11", EFieldOption.Optional)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringField(11).Value;
			}
			set
			{
				this.AddStringField(11, value);
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x0003AF68 File Offset: 0x00039F68
		// (set) Token: 0x06003805 RID: 14341 RVA: 0x0003AF7A File Offset: 0x00039F7A
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

		// Token: 0x06003806 RID: 14342 RVA: 0x0003AF88 File Offset: 0x00039F88
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x0003AFA6 File Offset: 0x00039FA6
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0003AFC3 File Offset: 0x00039FC3
		// (set) Token: 0x06003809 RID: 14345 RVA: 0x0003AFD1 File Offset: 0x00039FD1
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

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x0003AFDB File Offset: 0x00039FDB
		// (set) Token: 0x0600380B RID: 14347 RVA: 0x0003AFED File Offset: 0x00039FED
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

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x0003AFFB File Offset: 0x00039FFB
		// (set) Token: 0x0600380D RID: 14349 RVA: 0x0003B00D File Offset: 0x0003A00D
		[FIXField("493", EFieldOption.Optional)]
		public string RegistAcctType
		{
			get
			{
				return this.GetStringField(493).Value;
			}
			set
			{
				this.AddStringField(493, value);
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x0003B01B File Offset: 0x0003A01B
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x0003B02D File Offset: 0x0003A02D
		[FIXField("495", EFieldOption.Optional)]
		public int TaxAdvantageType
		{
			get
			{
				return this.GetIntField(495).Value;
			}
			set
			{
				this.AddIntField(495, value);
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x0003B03B File Offset: 0x0003A03B
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x0003B04D File Offset: 0x0003A04D
		[FIXField("517", EFieldOption.Optional)]
		public char OwnershipType
		{
			get
			{
				return this.GetCharField(517).Value;
			}
			set
			{
				this.AddCharField(517, value);
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06003812 RID: 14354 RVA: 0x0003B05B File Offset: 0x0003A05B
		// (set) Token: 0x06003813 RID: 14355 RVA: 0x0003B06D File Offset: 0x0003A06D
		[FIXField("473", EFieldOption.Optional)]
		public int NoRegistDtls
		{
			get
			{
				return this.GetIntField(473).Value;
			}
			set
			{
				this.AddIntField(473, value);
			}
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0003B07B File Offset: 0x0003A07B
		public FIXRegistDtlsGroup GetRegistDtlsGroup(int i)
		{
			if (i < this.NoRegistDtls)
			{
				return (FIXRegistDtlsGroup)this.fRegistDtlsGroup[i];
			}
			return null;
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x0003B099 File Offset: 0x0003A099
		public void AddGroup(FIXRegistDtlsGroup group)
		{
			this.fRegistDtlsGroup.Add(group);
			this.NoRegistDtls++;
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x0003B0B6 File Offset: 0x0003A0B6
		// (set) Token: 0x06003817 RID: 14359 RVA: 0x0003B0C8 File Offset: 0x0003A0C8
		[FIXField("510", EFieldOption.Optional)]
		public int NoDistribInsts
		{
			get
			{
				return this.GetIntField(510).Value;
			}
			set
			{
				this.AddIntField(510, value);
			}
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0003B0D6 File Offset: 0x0003A0D6
		public FIXDistribInstsGroup GetDistribInstsGroup(int i)
		{
			if (i < this.NoDistribInsts)
			{
				return (FIXDistribInstsGroup)this.fDistribInstsGroup[i];
			}
			return null;
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0003B0F4 File Offset: 0x0003A0F4
		public void AddGroup(FIXDistribInstsGroup group)
		{
			this.fDistribInstsGroup.Add(group);
			this.NoDistribInsts++;
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x0600381A RID: 14362 RVA: 0x0003B111 File Offset: 0x0003A111
		// (set) Token: 0x0600381B RID: 14363 RVA: 0x0003B120 File Offset: 0x0003A120
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

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x0003B12B File Offset: 0x0003A12B
		// (set) Token: 0x0600381D RID: 14365 RVA: 0x0003B13A File Offset: 0x0003A13A
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

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x0003B145 File Offset: 0x0003A145
		// (set) Token: 0x0600381F RID: 14367 RVA: 0x0003B154 File Offset: 0x0003A154
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

		// Token: 0x06003820 RID: 14368 RVA: 0x0003B15F File Offset: 0x0003A15F
		public FIXRegistrationInstructions()
		{
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0003B1A0 File Offset: 0x0003A1A0
		public FIXRegistrationInstructions(string RegistID, char RegistTransType, string RegistRefID)
		{
			this.RegistID = RegistID;
			this.RegistTransType = RegistTransType;
			this.RegistRefID = RegistRefID;
		}

		// Token: 0x04000518 RID: 1304
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000519 RID: 1305
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400051A RID: 1306
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400051B RID: 1307
		private ArrayList fRegistDtlsGroup = new ArrayList();

		// Token: 0x0400051C RID: 1308
		private ArrayList fDistribInstsGroup = new ArrayList();
	}
}
