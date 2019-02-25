using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000138 RID: 312
	public class FIXCollateralInquiryAck : FIXMessage
	{
		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x0003F0B4 File Offset: 0x0003E0B4
		// (set) Token: 0x06003BD8 RID: 15320 RVA: 0x0003F0C6 File Offset: 0x0003E0C6
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

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x0003F0D4 File Offset: 0x0003E0D4
		// (set) Token: 0x06003BDA RID: 15322 RVA: 0x0003F0E3 File Offset: 0x0003E0E3
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

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x0003F0EE File Offset: 0x0003E0EE
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x0003F0FD File Offset: 0x0003E0FD
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

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x0003F108 File Offset: 0x0003E108
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x0003F117 File Offset: 0x0003E117
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

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x0003F122 File Offset: 0x0003E122
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x0003F131 File Offset: 0x0003E131
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

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x0003F13C File Offset: 0x0003E13C
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x0003F14B File Offset: 0x0003E14B
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

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x0003F156 File Offset: 0x0003E156
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x0003F168 File Offset: 0x0003E168
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

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x0003F176 File Offset: 0x0003E176
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x0003F185 File Offset: 0x0003E185
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

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x0003F190 File Offset: 0x0003E190
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x0003F19F File Offset: 0x0003E19F
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

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x0003F1AA File Offset: 0x0003E1AA
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x0003F1B9 File Offset: 0x0003E1B9
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

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x0003F1C4 File Offset: 0x0003E1C4
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x0003F1D3 File Offset: 0x0003E1D3
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

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0003F1DE File Offset: 0x0003E1DE
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x0003F1F0 File Offset: 0x0003E1F0
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

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x0003F1FE File Offset: 0x0003E1FE
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x0003F20D File Offset: 0x0003E20D
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x0003F218 File Offset: 0x0003E218
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x0003F226 File Offset: 0x0003E226
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

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x0003F230 File Offset: 0x0003E230
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x0003F23F File Offset: 0x0003E23F
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

		// Token: 0x06003BF5 RID: 15349 RVA: 0x0003F24A File Offset: 0x0003E24A
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x0003F25D File Offset: 0x0003E25D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x0003F26C File Offset: 0x0003E26C
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x0003F27E File Offset: 0x0003E27E
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x0003F28C File Offset: 0x0003E28C
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x0003F29E File Offset: 0x0003E29E
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x0003F2AC File Offset: 0x0003E2AC
		// (set) Token: 0x06003BFC RID: 15356 RVA: 0x0003F2BB File Offset: 0x0003E2BB
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

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x0003F2C6 File Offset: 0x0003E2C6
		// (set) Token: 0x06003BFE RID: 15358 RVA: 0x0003F2D5 File Offset: 0x0003E2D5
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

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x0003F2E0 File Offset: 0x0003E2E0
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x0003F2EF File Offset: 0x0003E2EF
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x0003F2FA File Offset: 0x0003E2FA
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x0003F309 File Offset: 0x0003E309
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

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x0003F314 File Offset: 0x0003E314
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x0003F326 File Offset: 0x0003E326
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

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0003F334 File Offset: 0x0003E334
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x0003F346 File Offset: 0x0003E346
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

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0003F354 File Offset: 0x0003E354
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x0003F366 File Offset: 0x0003E366
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

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x0003F374 File Offset: 0x0003E374
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x0003F386 File Offset: 0x0003E386
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x0003F394 File Offset: 0x0003E394
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x0003F3A6 File Offset: 0x0003E3A6
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

		// Token: 0x06003C0D RID: 15373 RVA: 0x0003F3B4 File Offset: 0x0003E3B4
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x0003F3D2 File Offset: 0x0003E3D2
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x0003F3EF File Offset: 0x0003E3EF
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x0003F401 File Offset: 0x0003E401
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x0003F40F File Offset: 0x0003E40F
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x0003F421 File Offset: 0x0003E421
		[FIXField("909", EFieldOption.Required)]
		public string CollInquiryID
		{
			get
			{
				return this.GetStringField(909).Value;
			}
			set
			{
				this.AddStringField(909, value);
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x0003F42F File Offset: 0x0003E42F
		// (set) Token: 0x06003C14 RID: 15380 RVA: 0x0003F441 File Offset: 0x0003E441
		[FIXField("945", EFieldOption.Required)]
		public int CollInquiryStatus
		{
			get
			{
				return this.GetIntField(945).Value;
			}
			set
			{
				this.AddIntField(945, value);
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x0003F44F File Offset: 0x0003E44F
		// (set) Token: 0x06003C16 RID: 15382 RVA: 0x0003F461 File Offset: 0x0003E461
		[FIXField("946", EFieldOption.Optional)]
		public int CollInquiryResult
		{
			get
			{
				return this.GetIntField(946).Value;
			}
			set
			{
				this.AddIntField(946, value);
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x0003F46F File Offset: 0x0003E46F
		// (set) Token: 0x06003C18 RID: 15384 RVA: 0x0003F481 File Offset: 0x0003E481
		[FIXField("938", EFieldOption.Optional)]
		public int NoCollInquiryQualifier
		{
			get
			{
				return this.GetIntField(938).Value;
			}
			set
			{
				this.AddIntField(938, value);
			}
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0003F48F File Offset: 0x0003E48F
		public FIXCollInquiryQualifierGroup GetCollInquiryQualifierGroup(int i)
		{
			if (i < this.NoCollInquiryQualifier)
			{
				return (FIXCollInquiryQualifierGroup)this.fCollInquiryQualifierGroup[i];
			}
			return null;
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0003F4AD File Offset: 0x0003E4AD
		public void AddGroup(FIXCollInquiryQualifierGroup group)
		{
			this.fCollInquiryQualifierGroup.Add(group);
			this.NoCollInquiryQualifier++;
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06003C1B RID: 15387 RVA: 0x0003F4CA File Offset: 0x0003E4CA
		// (set) Token: 0x06003C1C RID: 15388 RVA: 0x0003F4DC File Offset: 0x0003E4DC
		[FIXField("911", EFieldOption.Optional)]
		public int TotNumReports
		{
			get
			{
				return this.GetIntField(911).Value;
			}
			set
			{
				this.AddIntField(911, value);
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x0003F4EA File Offset: 0x0003E4EA
		// (set) Token: 0x06003C1E RID: 15390 RVA: 0x0003F4FC File Offset: 0x0003E4FC
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

		// Token: 0x06003C1F RID: 15391 RVA: 0x0003F50A File Offset: 0x0003E50A
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x0003F528 File Offset: 0x0003E528
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x0003F545 File Offset: 0x0003E545
		// (set) Token: 0x06003C22 RID: 15394 RVA: 0x0003F553 File Offset: 0x0003E553
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

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x0003F55D File Offset: 0x0003E55D
		// (set) Token: 0x06003C24 RID: 15396 RVA: 0x0003F56F File Offset: 0x0003E56F
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

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x0003F57D File Offset: 0x0003E57D
		// (set) Token: 0x06003C26 RID: 15398 RVA: 0x0003F58C File Offset: 0x0003E58C
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

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x0003F597 File Offset: 0x0003E597
		// (set) Token: 0x06003C28 RID: 15400 RVA: 0x0003F5A6 File Offset: 0x0003E5A6
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

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x0003F5B1 File Offset: 0x0003E5B1
		// (set) Token: 0x06003C2A RID: 15402 RVA: 0x0003F5C3 File Offset: 0x0003E5C3
		[FIXField("198", EFieldOption.Optional)]
		public string SecondaryOrderID
		{
			get
			{
				return this.GetStringField(198).Value;
			}
			set
			{
				this.AddStringField(198, value);
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x0003F5D1 File Offset: 0x0003E5D1
		// (set) Token: 0x06003C2C RID: 15404 RVA: 0x0003F5E3 File Offset: 0x0003E5E3
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringField(526).Value;
			}
			set
			{
				this.AddStringField(526, value);
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x0003F5F1 File Offset: 0x0003E5F1
		// (set) Token: 0x06003C2E RID: 15406 RVA: 0x0003F600 File Offset: 0x0003E600
		[FIXField("124", EFieldOption.Optional)]
		public int NoExecs
		{
			get
			{
				return this.GetIntField(124).Value;
			}
			set
			{
				this.AddIntField(124, value);
			}
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x0003F60B File Offset: 0x0003E60B
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0003F629 File Offset: 0x0003E629
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06003C31 RID: 15409 RVA: 0x0003F646 File Offset: 0x0003E646
		// (set) Token: 0x06003C32 RID: 15410 RVA: 0x0003F658 File Offset: 0x0003E658
		[FIXField("897", EFieldOption.Optional)]
		public int NoTrades
		{
			get
			{
				return this.GetIntField(897).Value;
			}
			set
			{
				this.AddIntField(897, value);
			}
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0003F666 File Offset: 0x0003E666
		public FIXTradesGroup GetTradesGroup(int i)
		{
			if (i < this.NoTrades)
			{
				return (FIXTradesGroup)this.fTradesGroup[i];
			}
			return null;
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0003F684 File Offset: 0x0003E684
		public void AddGroup(FIXTradesGroup group)
		{
			this.fTradesGroup.Add(group);
			this.NoTrades++;
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x0003F6A1 File Offset: 0x0003E6A1
		// (set) Token: 0x06003C36 RID: 15414 RVA: 0x0003F6B0 File Offset: 0x0003E6B0
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

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x0003F6BB File Offset: 0x0003E6BB
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x0003F6CA File Offset: 0x0003E6CA
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

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x0003F6D5 File Offset: 0x0003E6D5
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x0003F6E4 File Offset: 0x0003E6E4
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

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x0003F6EF File Offset: 0x0003E6EF
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x0003F6FE File Offset: 0x0003E6FE
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

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x0003F709 File Offset: 0x0003E709
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x0003F71B File Offset: 0x0003E71B
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

		// Token: 0x06003C3F RID: 15423 RVA: 0x0003F729 File Offset: 0x0003E729
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x0003F747 File Offset: 0x0003E747
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x0003F764 File Offset: 0x0003E764
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x0003F776 File Offset: 0x0003E776
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

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x0003F784 File Offset: 0x0003E784
		// (set) Token: 0x06003C44 RID: 15428 RVA: 0x0003F796 File Offset: 0x0003E796
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x0003F7A4 File Offset: 0x0003E7A4
		// (set) Token: 0x06003C46 RID: 15430 RVA: 0x0003F7B6 File Offset: 0x0003E7B6
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

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x0003F7C4 File Offset: 0x0003E7C4
		// (set) Token: 0x06003C48 RID: 15432 RVA: 0x0003F7D6 File Offset: 0x0003E7D6
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

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x0003F7E4 File Offset: 0x0003E7E4
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x0003F7F6 File Offset: 0x0003E7F6
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

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x0003F804 File Offset: 0x0003E804
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x0003F816 File Offset: 0x0003E816
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

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x0003F824 File Offset: 0x0003E824
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x0003F836 File Offset: 0x0003E836
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

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x0003F844 File Offset: 0x0003E844
		// (set) Token: 0x06003C50 RID: 15440 RVA: 0x0003F856 File Offset: 0x0003E856
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

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x0003F864 File Offset: 0x0003E864
		// (set) Token: 0x06003C52 RID: 15442 RVA: 0x0003F876 File Offset: 0x0003E876
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

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06003C53 RID: 15443 RVA: 0x0003F884 File Offset: 0x0003E884
		// (set) Token: 0x06003C54 RID: 15444 RVA: 0x0003F896 File Offset: 0x0003E896
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

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x0003F8A4 File Offset: 0x0003E8A4
		// (set) Token: 0x06003C56 RID: 15446 RVA: 0x0003F8B6 File Offset: 0x0003E8B6
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

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x0003F8C4 File Offset: 0x0003E8C4
		// (set) Token: 0x06003C58 RID: 15448 RVA: 0x0003F8D6 File Offset: 0x0003E8D6
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0003F8E4 File Offset: 0x0003E8E4
		// (set) Token: 0x06003C5A RID: 15450 RVA: 0x0003F8F6 File Offset: 0x0003E8F6
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

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x0003F904 File Offset: 0x0003E904
		// (set) Token: 0x06003C5C RID: 15452 RVA: 0x0003F916 File Offset: 0x0003E916
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

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0003F924 File Offset: 0x0003E924
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x0003F936 File Offset: 0x0003E936
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

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0003F944 File Offset: 0x0003E944
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x0003F956 File Offset: 0x0003E956
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

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x0003F964 File Offset: 0x0003E964
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x0003F976 File Offset: 0x0003E976
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x0003F984 File Offset: 0x0003E984
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x0003F996 File Offset: 0x0003E996
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

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x0003F9A4 File Offset: 0x0003E9A4
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x0003F9B6 File Offset: 0x0003E9B6
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

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x0003F9C4 File Offset: 0x0003E9C4
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x0003F9D6 File Offset: 0x0003E9D6
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x0003F9E4 File Offset: 0x0003E9E4
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x0003F9F6 File Offset: 0x0003E9F6
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

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x0003FA04 File Offset: 0x0003EA04
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x0003FA16 File Offset: 0x0003EA16
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

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x0003FA24 File Offset: 0x0003EA24
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x0003FA36 File Offset: 0x0003EA36
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

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x0003FA44 File Offset: 0x0003EA44
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x0003FA56 File Offset: 0x0003EA56
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

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x0003FA64 File Offset: 0x0003EA64
		// (set) Token: 0x06003C72 RID: 15474 RVA: 0x0003FA73 File Offset: 0x0003EA73
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

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x0003FA7E File Offset: 0x0003EA7E
		// (set) Token: 0x06003C74 RID: 15476 RVA: 0x0003FA90 File Offset: 0x0003EA90
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x0003FA9E File Offset: 0x0003EA9E
		// (set) Token: 0x06003C76 RID: 15478 RVA: 0x0003FAB0 File Offset: 0x0003EAB0
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

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x0003FABE File Offset: 0x0003EABE
		// (set) Token: 0x06003C78 RID: 15480 RVA: 0x0003FACD File Offset: 0x0003EACD
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x0003FAD8 File Offset: 0x0003EAD8
		// (set) Token: 0x06003C7A RID: 15482 RVA: 0x0003FAEA File Offset: 0x0003EAEA
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0003FAF8 File Offset: 0x0003EAF8
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x0003FB0A File Offset: 0x0003EB0A
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

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x0003FB18 File Offset: 0x0003EB18
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x0003FB2A File Offset: 0x0003EB2A
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

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x0003FB38 File Offset: 0x0003EB38
		// (set) Token: 0x06003C80 RID: 15488 RVA: 0x0003FB4A File Offset: 0x0003EB4A
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

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x0003FB58 File Offset: 0x0003EB58
		// (set) Token: 0x06003C82 RID: 15490 RVA: 0x0003FB6A File Offset: 0x0003EB6A
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

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06003C83 RID: 15491 RVA: 0x0003FB78 File Offset: 0x0003EB78
		// (set) Token: 0x06003C84 RID: 15492 RVA: 0x0003FB8A File Offset: 0x0003EB8A
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

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06003C85 RID: 15493 RVA: 0x0003FB98 File Offset: 0x0003EB98
		// (set) Token: 0x06003C86 RID: 15494 RVA: 0x0003FBAA File Offset: 0x0003EBAA
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

		// Token: 0x06003C87 RID: 15495 RVA: 0x0003FBB8 File Offset: 0x0003EBB8
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0003FBD6 File Offset: 0x0003EBD6
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x0003FBF3 File Offset: 0x0003EBF3
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x0003FC05 File Offset: 0x0003EC05
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

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x0003FC13 File Offset: 0x0003EC13
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x0003FC25 File Offset: 0x0003EC25
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

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x0003FC33 File Offset: 0x0003EC33
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x0003FC45 File Offset: 0x0003EC45
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

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x0003FC53 File Offset: 0x0003EC53
		// (set) Token: 0x06003C90 RID: 15504 RVA: 0x0003FC65 File Offset: 0x0003EC65
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

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x0003FC73 File Offset: 0x0003EC73
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x0003FC85 File Offset: 0x0003EC85
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

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x0003FC93 File Offset: 0x0003EC93
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x0003FCA5 File Offset: 0x0003ECA5
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

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x0003FCB3 File Offset: 0x0003ECB3
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x0003FCC5 File Offset: 0x0003ECC5
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

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x0003FCD3 File Offset: 0x0003ECD3
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x0003FCE5 File Offset: 0x0003ECE5
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

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0003FCF3 File Offset: 0x0003ECF3
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x0003FD05 File Offset: 0x0003ED05
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

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x0003FD13 File Offset: 0x0003ED13
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x0003FD25 File Offset: 0x0003ED25
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

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x0003FD33 File Offset: 0x0003ED33
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x0003FD45 File Offset: 0x0003ED45
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

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x0003FD53 File Offset: 0x0003ED53
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x0003FD62 File Offset: 0x0003ED62
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

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0003FD6D File Offset: 0x0003ED6D
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x0003FD7C File Offset: 0x0003ED7C
		[FIXField("53", EFieldOption.Optional)]
		public double Quantity
		{
			get
			{
				return this.GetDoubleField(53).Value;
			}
			set
			{
				this.AddDoubleField(53, value);
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x0003FD87 File Offset: 0x0003ED87
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x0003FD99 File Offset: 0x0003ED99
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntField(854).Value;
			}
			set
			{
				this.AddIntField(854, value);
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x0003FDA7 File Offset: 0x0003EDA7
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x0003FDB6 File Offset: 0x0003EDB6
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

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x0003FDC1 File Offset: 0x0003EDC1
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x0003FDD3 File Offset: 0x0003EDD3
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

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0003FDE1 File Offset: 0x0003EDE1
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0003FDFF File Offset: 0x0003EDFF
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x0003FE1C File Offset: 0x0003EE1C
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x0003FE2E File Offset: 0x0003EE2E
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

		// Token: 0x06003CAD RID: 15533 RVA: 0x0003FE3C File Offset: 0x0003EE3C
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0003FE5A File Offset: 0x0003EE5A
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x0003FE77 File Offset: 0x0003EE77
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x0003FE89 File Offset: 0x0003EE89
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

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x0003FE97 File Offset: 0x0003EE97
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x0003FEA9 File Offset: 0x0003EEA9
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

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x0003FEB7 File Offset: 0x0003EEB7
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x0003FEC9 File Offset: 0x0003EEC9
		[FIXField("716", EFieldOption.Optional)]
		public string SettlSessID
		{
			get
			{
				return this.GetStringField(716).Value;
			}
			set
			{
				this.AddStringField(716, value);
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x0003FED7 File Offset: 0x0003EED7
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x0003FEE9 File Offset: 0x0003EEE9
		[FIXField("717", EFieldOption.Optional)]
		public string SettlSessSubID
		{
			get
			{
				return this.GetStringField(717).Value;
			}
			set
			{
				this.AddStringField(717, value);
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x0003FEF7 File Offset: 0x0003EEF7
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x0003FF09 File Offset: 0x0003EF09
		[FIXField("715", EFieldOption.Optional)]
		public DateTime ClearingBusinessDate
		{
			get
			{
				return this.GetDateTimeField(715).Value;
			}
			set
			{
				this.AddDateTimeField(715, value);
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x0003FF17 File Offset: 0x0003EF17
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x0003FF29 File Offset: 0x0003EF29
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

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x0003FF37 File Offset: 0x0003EF37
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x0003FF49 File Offset: 0x0003EF49
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

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0003FF57 File Offset: 0x0003EF57
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x0003FF66 File Offset: 0x0003EF66
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

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x0003FF71 File Offset: 0x0003EF71
		// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x0003FF83 File Offset: 0x0003EF83
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

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x0003FF91 File Offset: 0x0003EF91
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x0003FFA3 File Offset: 0x0003EFA3
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

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x0003FFB1 File Offset: 0x0003EFB1
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x0003FFC0 File Offset: 0x0003EFC0
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

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x0003FFCB File Offset: 0x0003EFCB
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x0003FFDA File Offset: 0x0003EFDA
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

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x0003FFE5 File Offset: 0x0003EFE5
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x0003FFF4 File Offset: 0x0003EFF4
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

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00040000 File Offset: 0x0003F000
		public FIXCollateralInquiryAck()
		{
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x00040084 File Offset: 0x0003F084
		public FIXCollateralInquiryAck(string CollInquiryID, int CollInquiryStatus)
		{
			this.CollInquiryID = CollInquiryID;
			this.CollInquiryStatus = CollInquiryStatus;
		}

		// Token: 0x04000546 RID: 1350
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000547 RID: 1351
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000548 RID: 1352
		private ArrayList fCollInquiryQualifierGroup = new ArrayList();

		// Token: 0x04000549 RID: 1353
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400054A RID: 1354
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x0400054B RID: 1355
		private ArrayList fTradesGroup = new ArrayList();

		// Token: 0x0400054C RID: 1356
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400054D RID: 1357
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400054E RID: 1358
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x0400054F RID: 1359
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
