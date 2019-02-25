using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000095 RID: 149
	public class FIXOrderMassStatusRequest : FIXMessage
	{
		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0001F874 File Offset: 0x0001E874
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0001F886 File Offset: 0x0001E886
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

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0001F894 File Offset: 0x0001E894
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0001F8A3 File Offset: 0x0001E8A3
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

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0001F8AE File Offset: 0x0001E8AE
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0001F8BD File Offset: 0x0001E8BD
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0001F8C8 File Offset: 0x0001E8C8
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0001F8D7 File Offset: 0x0001E8D7
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

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0001F8E2 File Offset: 0x0001E8E2
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0001F8F1 File Offset: 0x0001E8F1
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

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0001F8FC File Offset: 0x0001E8FC
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0001F90B File Offset: 0x0001E90B
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

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0001F916 File Offset: 0x0001E916
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0001F928 File Offset: 0x0001E928
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

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0001F936 File Offset: 0x0001E936
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x0001F945 File Offset: 0x0001E945
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0001F950 File Offset: 0x0001E950
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0001F95F File Offset: 0x0001E95F
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

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0001F96A File Offset: 0x0001E96A
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x0001F979 File Offset: 0x0001E979
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

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0001F984 File Offset: 0x0001E984
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x0001F993 File Offset: 0x0001E993
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

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0001F99E File Offset: 0x0001E99E
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0001F9B0 File Offset: 0x0001E9B0
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0001F9BE File Offset: 0x0001E9BE
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0001F9CD File Offset: 0x0001E9CD
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

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0001F9D8 File Offset: 0x0001E9D8
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0001F9E6 File Offset: 0x0001E9E6
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

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0001F9F0 File Offset: 0x0001E9F0
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0001F9FF File Offset: 0x0001E9FF
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

		// Token: 0x06001D0F RID: 7439 RVA: 0x0001FA0A File Offset: 0x0001EA0A
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0001FA1D File Offset: 0x0001EA1D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0001FA2C File Offset: 0x0001EA2C
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0001FA3E File Offset: 0x0001EA3E
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

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0001FA4C File Offset: 0x0001EA4C
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0001FA5E File Offset: 0x0001EA5E
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

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0001FA6C File Offset: 0x0001EA6C
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0001FA7B File Offset: 0x0001EA7B
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0001FA86 File Offset: 0x0001EA86
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0001FA95 File Offset: 0x0001EA95
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0001FAA0 File Offset: 0x0001EAA0
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0001FAAF File Offset: 0x0001EAAF
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0001FABA File Offset: 0x0001EABA
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0001FAC9 File Offset: 0x0001EAC9
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

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0001FAD4 File Offset: 0x0001EAD4
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0001FAE6 File Offset: 0x0001EAE6
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

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0001FAF4 File Offset: 0x0001EAF4
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0001FB06 File Offset: 0x0001EB06
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0001FB14 File Offset: 0x0001EB14
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0001FB26 File Offset: 0x0001EB26
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0001FB34 File Offset: 0x0001EB34
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0001FB46 File Offset: 0x0001EB46
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

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0001FB54 File Offset: 0x0001EB54
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0001FB66 File Offset: 0x0001EB66
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

		// Token: 0x06001D27 RID: 7463 RVA: 0x0001FB74 File Offset: 0x0001EB74
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0001FB92 File Offset: 0x0001EB92
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0001FBAF File Offset: 0x0001EBAF
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0001FBC1 File Offset: 0x0001EBC1
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

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0001FBCF File Offset: 0x0001EBCF
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0001FBE1 File Offset: 0x0001EBE1
		[FIXField("584", EFieldOption.Required)]
		public string MassStatusReqID
		{
			get
			{
				return this.GetStringField(584).Value;
			}
			set
			{
				this.AddStringField(584, value);
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0001FBEF File Offset: 0x0001EBEF
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0001FC01 File Offset: 0x0001EC01
		[FIXField("585", EFieldOption.Required)]
		public int MassStatusReqType
		{
			get
			{
				return this.GetIntField(585).Value;
			}
			set
			{
				this.AddIntField(585, value);
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0001FC0F File Offset: 0x0001EC0F
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0001FC21 File Offset: 0x0001EC21
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

		// Token: 0x06001D31 RID: 7473 RVA: 0x0001FC2F File Offset: 0x0001EC2F
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0001FC4D File Offset: 0x0001EC4D
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x0001FC6A File Offset: 0x0001EC6A
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0001FC78 File Offset: 0x0001EC78
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0001FC82 File Offset: 0x0001EC82
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0001FC94 File Offset: 0x0001EC94
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

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x0001FCA2 File Offset: 0x0001ECA2
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0001FCB4 File Offset: 0x0001ECB4
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

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0001FCC2 File Offset: 0x0001ECC2
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0001FCD4 File Offset: 0x0001ECD4
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

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0001FCE2 File Offset: 0x0001ECE2
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0001FCF1 File Offset: 0x0001ECF1
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

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0001FCFC File Offset: 0x0001ECFC
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0001FD0B File Offset: 0x0001ED0B
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

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0001FD16 File Offset: 0x0001ED16
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0001FD25 File Offset: 0x0001ED25
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

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0001FD30 File Offset: 0x0001ED30
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0001FD3F File Offset: 0x0001ED3F
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

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0001FD4A File Offset: 0x0001ED4A
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0001FD5C File Offset: 0x0001ED5C
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

		// Token: 0x06001D45 RID: 7493 RVA: 0x0001FD6A File Offset: 0x0001ED6A
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0001FD88 File Offset: 0x0001ED88
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0001FDA5 File Offset: 0x0001EDA5
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0001FDB7 File Offset: 0x0001EDB7
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

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x0001FDC5 File Offset: 0x0001EDC5
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x0001FDD7 File Offset: 0x0001EDD7
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

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0001FDE5 File Offset: 0x0001EDE5
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x0001FDF7 File Offset: 0x0001EDF7
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

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x0001FE05 File Offset: 0x0001EE05
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0001FE17 File Offset: 0x0001EE17
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

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x0001FE25 File Offset: 0x0001EE25
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0001FE37 File Offset: 0x0001EE37
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

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x0001FE45 File Offset: 0x0001EE45
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x0001FE57 File Offset: 0x0001EE57
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

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0001FE65 File Offset: 0x0001EE65
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x0001FE77 File Offset: 0x0001EE77
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

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0001FE85 File Offset: 0x0001EE85
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0001FE97 File Offset: 0x0001EE97
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

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0001FEA5 File Offset: 0x0001EEA5
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0001FEB7 File Offset: 0x0001EEB7
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

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0001FEC5 File Offset: 0x0001EEC5
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0001FED7 File Offset: 0x0001EED7
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

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0001FEE5 File Offset: 0x0001EEE5
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0001FEF7 File Offset: 0x0001EEF7
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

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0001FF05 File Offset: 0x0001EF05
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0001FF17 File Offset: 0x0001EF17
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

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x0001FF25 File Offset: 0x0001EF25
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x0001FF37 File Offset: 0x0001EF37
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

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0001FF45 File Offset: 0x0001EF45
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x0001FF57 File Offset: 0x0001EF57
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

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0001FF65 File Offset: 0x0001EF65
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0001FF77 File Offset: 0x0001EF77
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

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0001FF85 File Offset: 0x0001EF85
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0001FF97 File Offset: 0x0001EF97
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

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0001FFA5 File Offset: 0x0001EFA5
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x0001FFB7 File Offset: 0x0001EFB7
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

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0001FFC5 File Offset: 0x0001EFC5
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0001FFD7 File Offset: 0x0001EFD7
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

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0001FFE5 File Offset: 0x0001EFE5
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0001FFF7 File Offset: 0x0001EFF7
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

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00020005 File Offset: 0x0001F005
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00020017 File Offset: 0x0001F017
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

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00020025 File Offset: 0x0001F025
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00020037 File Offset: 0x0001F037
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00020045 File Offset: 0x0001F045
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x00020057 File Offset: 0x0001F057
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00020065 File Offset: 0x0001F065
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x00020077 File Offset: 0x0001F077
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

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00020085 File Offset: 0x0001F085
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x00020097 File Offset: 0x0001F097
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000200A5 File Offset: 0x0001F0A5
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x000200B4 File Offset: 0x0001F0B4
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

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000200BF File Offset: 0x0001F0BF
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x000200D1 File Offset: 0x0001F0D1
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000200DF File Offset: 0x0001F0DF
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x000200F1 File Offset: 0x0001F0F1
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

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x000200FF File Offset: 0x0001F0FF
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0002010E File Offset: 0x0001F10E
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00020119 File Offset: 0x0001F119
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x0002012B File Offset: 0x0001F12B
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

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00020139 File Offset: 0x0001F139
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x0002014B File Offset: 0x0001F14B
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

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00020159 File Offset: 0x0001F159
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0002016B File Offset: 0x0001F16B
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

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x00020179 File Offset: 0x0001F179
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x0002018B File Offset: 0x0001F18B
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

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00020199 File Offset: 0x0001F199
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x000201AB File Offset: 0x0001F1AB
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x000201B9 File Offset: 0x0001F1B9
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x000201CB File Offset: 0x0001F1CB
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

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000201D9 File Offset: 0x0001F1D9
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x000201EB File Offset: 0x0001F1EB
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

		// Token: 0x06001D8D RID: 7565 RVA: 0x000201F9 File Offset: 0x0001F1F9
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00020217 File Offset: 0x0001F217
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00020234 File Offset: 0x0001F234
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00020246 File Offset: 0x0001F246
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

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00020254 File Offset: 0x0001F254
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00020266 File Offset: 0x0001F266
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

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00020274 File Offset: 0x0001F274
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00020286 File Offset: 0x0001F286
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

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00020294 File Offset: 0x0001F294
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x000202A6 File Offset: 0x0001F2A6
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

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000202B4 File Offset: 0x0001F2B4
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x000202C6 File Offset: 0x0001F2C6
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000202D4 File Offset: 0x0001F2D4
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x000202E6 File Offset: 0x0001F2E6
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

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000202F4 File Offset: 0x0001F2F4
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00020306 File Offset: 0x0001F306
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

		// Token: 0x06001D9D RID: 7581 RVA: 0x00020314 File Offset: 0x0001F314
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00020332 File Offset: 0x0001F332
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0002034F File Offset: 0x0001F34F
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x00020361 File Offset: 0x0001F361
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

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0002036F File Offset: 0x0001F36F
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x00020381 File Offset: 0x0001F381
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

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0002038F File Offset: 0x0001F38F
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x000203A1 File Offset: 0x0001F3A1
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

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000203AF File Offset: 0x0001F3AF
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x000203C1 File Offset: 0x0001F3C1
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

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000203CF File Offset: 0x0001F3CF
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x000203E1 File Offset: 0x0001F3E1
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

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000203EF File Offset: 0x0001F3EF
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00020401 File Offset: 0x0001F401
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

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0002040F File Offset: 0x0001F40F
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00020421 File Offset: 0x0001F421
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

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0002042F File Offset: 0x0001F42F
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00020441 File Offset: 0x0001F441
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

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0002044F File Offset: 0x0001F44F
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00020461 File Offset: 0x0001F461
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

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0002046F File Offset: 0x0001F46F
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00020481 File Offset: 0x0001F481
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

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0002048F File Offset: 0x0001F48F
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x000204A1 File Offset: 0x0001F4A1
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

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000204AF File Offset: 0x0001F4AF
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x000204C1 File Offset: 0x0001F4C1
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

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000204CF File Offset: 0x0001F4CF
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x000204E1 File Offset: 0x0001F4E1
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

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000204EF File Offset: 0x0001F4EF
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00020501 File Offset: 0x0001F501
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

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0002050F File Offset: 0x0001F50F
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00020521 File Offset: 0x0001F521
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

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0002052F File Offset: 0x0001F52F
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00020541 File Offset: 0x0001F541
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

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0002054F File Offset: 0x0001F54F
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00020561 File Offset: 0x0001F561
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0002056F File Offset: 0x0001F56F
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00020581 File Offset: 0x0001F581
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

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0002058F File Offset: 0x0001F58F
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x000205A1 File Offset: 0x0001F5A1
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

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x000205AF File Offset: 0x0001F5AF
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x000205C1 File Offset: 0x0001F5C1
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

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000205CF File Offset: 0x0001F5CF
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x000205E1 File Offset: 0x0001F5E1
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

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000205EF File Offset: 0x0001F5EF
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00020601 File Offset: 0x0001F601
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

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0002060F File Offset: 0x0001F60F
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00020621 File Offset: 0x0001F621
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

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0002062F File Offset: 0x0001F62F
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00020641 File Offset: 0x0001F641
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

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0002064F File Offset: 0x0001F64F
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x00020661 File Offset: 0x0001F661
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

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0002066F File Offset: 0x0001F66F
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00020681 File Offset: 0x0001F681
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

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0002068F File Offset: 0x0001F68F
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x000206A1 File Offset: 0x0001F6A1
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

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x000206AF File Offset: 0x0001F6AF
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x000206C1 File Offset: 0x0001F6C1
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

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x000206CF File Offset: 0x0001F6CF
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x000206E1 File Offset: 0x0001F6E1
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

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x000206EF File Offset: 0x0001F6EF
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x00020701 File Offset: 0x0001F701
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

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0002070F File Offset: 0x0001F70F
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x00020721 File Offset: 0x0001F721
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

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0002072F File Offset: 0x0001F72F
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00020741 File Offset: 0x0001F741
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

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0002074F File Offset: 0x0001F74F
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00020761 File Offset: 0x0001F761
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

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0002076F File Offset: 0x0001F76F
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x00020781 File Offset: 0x0001F781
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

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0002078F File Offset: 0x0001F78F
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x000207A1 File Offset: 0x0001F7A1
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

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000207AF File Offset: 0x0001F7AF
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x000207C1 File Offset: 0x0001F7C1
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

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000207CF File Offset: 0x0001F7CF
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x000207E1 File Offset: 0x0001F7E1
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

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x000207EF File Offset: 0x0001F7EF
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00020801 File Offset: 0x0001F801
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

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x0002080F File Offset: 0x0001F80F
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00020821 File Offset: 0x0001F821
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

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0002082F File Offset: 0x0001F82F
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00020841 File Offset: 0x0001F841
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

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0002084F File Offset: 0x0001F84F
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00020861 File Offset: 0x0001F861
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

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0002086F File Offset: 0x0001F86F
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0002088D File Offset: 0x0001F88D
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x000208AA File Offset: 0x0001F8AA
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x000208B9 File Offset: 0x0001F8B9
		[FIXField("54", EFieldOption.Optional)]
		public char Side
		{
			get
			{
				return this.GetCharField(54).Value;
			}
			set
			{
				this.AddCharField(54, value);
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x000208C4 File Offset: 0x0001F8C4
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x000208D3 File Offset: 0x0001F8D3
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

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x000208DE File Offset: 0x0001F8DE
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x000208ED File Offset: 0x0001F8ED
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

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000208F8 File Offset: 0x0001F8F8
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00020907 File Offset: 0x0001F907
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

		// Token: 0x06001DFB RID: 7675 RVA: 0x00020914 File Offset: 0x0001F914
		public FIXOrderMassStatusRequest()
		{
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00020974 File Offset: 0x0001F974
		public FIXOrderMassStatusRequest(string MassStatusReqID, int MassStatusReqType)
		{
			this.MassStatusReqID = MassStatusReqID;
			this.MassStatusReqType = MassStatusReqType;
		}

		// Token: 0x040002EC RID: 748
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002ED RID: 749
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002EE RID: 750
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040002EF RID: 751
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040002F0 RID: 752
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040002F1 RID: 753
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x040002F2 RID: 754
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
