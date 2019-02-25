using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000079 RID: 121
	public class FIXRequestForPositionsAck : FIXMessage
	{
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00017821 File Offset: 0x00016821
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00017833 File Offset: 0x00016833
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00017841 File Offset: 0x00016841
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00017850 File Offset: 0x00016850
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0001785B File Offset: 0x0001685B
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x0001786A File Offset: 0x0001686A
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

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00017875 File Offset: 0x00016875
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00017884 File Offset: 0x00016884
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0001788F File Offset: 0x0001688F
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0001789E File Offset: 0x0001689E
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

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000178A9 File Offset: 0x000168A9
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x000178B8 File Offset: 0x000168B8
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

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000178C3 File Offset: 0x000168C3
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x000178D5 File Offset: 0x000168D5
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

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000178E3 File Offset: 0x000168E3
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000178F2 File Offset: 0x000168F2
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

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000178FD File Offset: 0x000168FD
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x0001790C File Offset: 0x0001690C
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00017917 File Offset: 0x00016917
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x00017926 File Offset: 0x00016926
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

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00017931 File Offset: 0x00016931
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x00017940 File Offset: 0x00016940
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

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0001794B File Offset: 0x0001694B
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0001795D File Offset: 0x0001695D
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0001796B File Offset: 0x0001696B
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x0001797A File Offset: 0x0001697A
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

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00017985 File Offset: 0x00016985
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x00017993 File Offset: 0x00016993
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0001799D File Offset: 0x0001699D
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x000179AC File Offset: 0x000169AC
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

		// Token: 0x06001514 RID: 5396 RVA: 0x000179B7 File Offset: 0x000169B7
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000179CA File Offset: 0x000169CA
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x000179D9 File Offset: 0x000169D9
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x000179EB File Offset: 0x000169EB
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

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x000179F9 File Offset: 0x000169F9
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x00017A0B File Offset: 0x00016A0B
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

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x00017A19 File Offset: 0x00016A19
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x00017A28 File Offset: 0x00016A28
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

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00017A33 File Offset: 0x00016A33
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x00017A42 File Offset: 0x00016A42
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

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00017A4D File Offset: 0x00016A4D
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x00017A5C File Offset: 0x00016A5C
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x00017A67 File Offset: 0x00016A67
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x00017A76 File Offset: 0x00016A76
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x00017A81 File Offset: 0x00016A81
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x00017A93 File Offset: 0x00016A93
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

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x00017AA1 File Offset: 0x00016AA1
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00017AB3 File Offset: 0x00016AB3
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

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00017AC1 File Offset: 0x00016AC1
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x00017AD3 File Offset: 0x00016AD3
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x00017AE1 File Offset: 0x00016AE1
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x00017AF3 File Offset: 0x00016AF3
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

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x00017B01 File Offset: 0x00016B01
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x00017B13 File Offset: 0x00016B13
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

		// Token: 0x0600152C RID: 5420 RVA: 0x00017B21 File Offset: 0x00016B21
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00017B3F File Offset: 0x00016B3F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x00017B5C File Offset: 0x00016B5C
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x00017B6E File Offset: 0x00016B6E
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00017B7C File Offset: 0x00016B7C
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x00017B8E File Offset: 0x00016B8E
		[FIXField("721", EFieldOption.Required)]
		public string PosMaintRptID
		{
			get
			{
				return this.GetStringField(721).Value;
			}
			set
			{
				this.AddStringField(721, value);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x00017B9C File Offset: 0x00016B9C
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x00017BAE File Offset: 0x00016BAE
		[FIXField("710", EFieldOption.Optional)]
		public string PosReqID
		{
			get
			{
				return this.GetStringField(710).Value;
			}
			set
			{
				this.AddStringField(710, value);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x00017BBC File Offset: 0x00016BBC
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x00017BCE File Offset: 0x00016BCE
		[FIXField("727", EFieldOption.Optional)]
		public int TotalNumPosReports
		{
			get
			{
				return this.GetIntField(727).Value;
			}
			set
			{
				this.AddIntField(727, value);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x00017BDC File Offset: 0x00016BDC
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00017BEE File Offset: 0x00016BEE
		[FIXField("325", EFieldOption.Optional)]
		public bool UnsolicitedIndicator
		{
			get
			{
				return this.GetBoolField(325).Value;
			}
			set
			{
				this.AddBoolField(325, value);
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00017BFC File Offset: 0x00016BFC
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x00017C0E File Offset: 0x00016C0E
		[FIXField("728", EFieldOption.Required)]
		public int PosReqResult
		{
			get
			{
				return this.GetIntField(728).Value;
			}
			set
			{
				this.AddIntField(728, value);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00017C1C File Offset: 0x00016C1C
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00017C2E File Offset: 0x00016C2E
		[FIXField("729", EFieldOption.Required)]
		public int PosReqStatus
		{
			get
			{
				return this.GetIntField(729).Value;
			}
			set
			{
				this.AddIntField(729, value);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x00017C3C File Offset: 0x00016C3C
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x00017C4E File Offset: 0x00016C4E
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

		// Token: 0x0600153E RID: 5438 RVA: 0x00017C5C File Offset: 0x00016C5C
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00017C7A File Offset: 0x00016C7A
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00017C97 File Offset: 0x00016C97
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x00017CA5 File Offset: 0x00016CA5
		[FIXField("1", EFieldOption.Required)]
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

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00017CAF File Offset: 0x00016CAF
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x00017CC1 File Offset: 0x00016CC1
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

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00017CCF File Offset: 0x00016CCF
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00017CE1 File Offset: 0x00016CE1
		[FIXField("581", EFieldOption.Required)]
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

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00017CEF File Offset: 0x00016CEF
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x00017CFE File Offset: 0x00016CFE
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

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x00017D09 File Offset: 0x00016D09
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x00017D18 File Offset: 0x00016D18
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00017D23 File Offset: 0x00016D23
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00017D32 File Offset: 0x00016D32
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00017D3D File Offset: 0x00016D3D
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00017D4C File Offset: 0x00016D4C
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

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00017D57 File Offset: 0x00016D57
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x00017D69 File Offset: 0x00016D69
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

		// Token: 0x06001550 RID: 5456 RVA: 0x00017D77 File Offset: 0x00016D77
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00017D95 File Offset: 0x00016D95
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x00017DB2 File Offset: 0x00016DB2
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x00017DC4 File Offset: 0x00016DC4
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

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00017DD2 File Offset: 0x00016DD2
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x00017DE4 File Offset: 0x00016DE4
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

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x00017DF2 File Offset: 0x00016DF2
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00017E04 File Offset: 0x00016E04
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00017E12 File Offset: 0x00016E12
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00017E24 File Offset: 0x00016E24
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

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00017E32 File Offset: 0x00016E32
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00017E44 File Offset: 0x00016E44
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

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x00017E52 File Offset: 0x00016E52
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x00017E64 File Offset: 0x00016E64
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00017E72 File Offset: 0x00016E72
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00017E84 File Offset: 0x00016E84
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

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00017E92 File Offset: 0x00016E92
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x00017EA4 File Offset: 0x00016EA4
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

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00017EB2 File Offset: 0x00016EB2
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00017EC4 File Offset: 0x00016EC4
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00017ED2 File Offset: 0x00016ED2
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00017EE4 File Offset: 0x00016EE4
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

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00017EF2 File Offset: 0x00016EF2
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00017F04 File Offset: 0x00016F04
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

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00017F12 File Offset: 0x00016F12
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00017F24 File Offset: 0x00016F24
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

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00017F32 File Offset: 0x00016F32
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00017F44 File Offset: 0x00016F44
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00017F52 File Offset: 0x00016F52
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00017F64 File Offset: 0x00016F64
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

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00017F72 File Offset: 0x00016F72
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00017F84 File Offset: 0x00016F84
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

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00017F92 File Offset: 0x00016F92
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00017FA4 File Offset: 0x00016FA4
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00017FB2 File Offset: 0x00016FB2
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00017FC4 File Offset: 0x00016FC4
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

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00017FD2 File Offset: 0x00016FD2
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00017FE4 File Offset: 0x00016FE4
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00017FF2 File Offset: 0x00016FF2
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00018004 File Offset: 0x00017004
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

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00018012 File Offset: 0x00017012
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00018024 File Offset: 0x00017024
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00018032 File Offset: 0x00017032
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00018044 File Offset: 0x00017044
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

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00018052 File Offset: 0x00017052
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00018064 File Offset: 0x00017064
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00018072 File Offset: 0x00017072
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x00018084 File Offset: 0x00017084
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00018092 File Offset: 0x00017092
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x000180A4 File Offset: 0x000170A4
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

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x000180B2 File Offset: 0x000170B2
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x000180C1 File Offset: 0x000170C1
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000180CC File Offset: 0x000170CC
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x000180DE File Offset: 0x000170DE
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

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000180EC File Offset: 0x000170EC
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x000180FE File Offset: 0x000170FE
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x0001810C File Offset: 0x0001710C
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0001811B File Offset: 0x0001711B
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

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00018126 File Offset: 0x00017126
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x00018138 File Offset: 0x00017138
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00018146 File Offset: 0x00017146
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x00018158 File Offset: 0x00017158
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

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00018166 File Offset: 0x00017166
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00018178 File Offset: 0x00017178
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

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00018186 File Offset: 0x00017186
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00018198 File Offset: 0x00017198
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

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000181A6 File Offset: 0x000171A6
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x000181B8 File Offset: 0x000171B8
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

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000181C6 File Offset: 0x000171C6
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x000181D8 File Offset: 0x000171D8
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

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x000181E6 File Offset: 0x000171E6
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x000181F8 File Offset: 0x000171F8
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

		// Token: 0x06001598 RID: 5528 RVA: 0x00018206 File Offset: 0x00017206
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00018224 File Offset: 0x00017224
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00018241 File Offset: 0x00017241
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00018253 File Offset: 0x00017253
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00018261 File Offset: 0x00017261
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x00018273 File Offset: 0x00017273
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

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00018281 File Offset: 0x00017281
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x00018290 File Offset: 0x00017290
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

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0001829B File Offset: 0x0001729B
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x000182AD File Offset: 0x000172AD
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

		// Token: 0x060015A2 RID: 5538 RVA: 0x000182BB File Offset: 0x000172BB
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000182D9 File Offset: 0x000172D9
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000182F6 File Offset: 0x000172F6
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00018308 File Offset: 0x00017308
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

		// Token: 0x060015A6 RID: 5542 RVA: 0x00018316 File Offset: 0x00017316
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00018334 File Offset: 0x00017334
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00018351 File Offset: 0x00017351
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x00018363 File Offset: 0x00017363
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00018371 File Offset: 0x00017371
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x00018383 File Offset: 0x00017383
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

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00018391 File Offset: 0x00017391
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x000183A0 File Offset: 0x000173A0
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000183AB File Offset: 0x000173AB
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x000183BD File Offset: 0x000173BD
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000183CB File Offset: 0x000173CB
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x000183DD File Offset: 0x000173DD
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x000183EB File Offset: 0x000173EB
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x000183FA File Offset: 0x000173FA
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

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00018405 File Offset: 0x00017405
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x00018414 File Offset: 0x00017414
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

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x0001841F File Offset: 0x0001741F
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0001842E File Offset: 0x0001742E
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

		// Token: 0x060015B8 RID: 5560 RVA: 0x0001843C File Offset: 0x0001743C
		public FIXRequestForPositionsAck()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0001849C File Offset: 0x0001749C
		public FIXRequestForPositionsAck(string PosMaintRptID, int PosReqResult, int PosReqStatus, string Account, int AccountType)
		{
			this.PosMaintRptID = PosMaintRptID;
			this.PosReqResult = PosReqResult;
			this.PosReqStatus = PosReqStatus;
			this.Account = Account;
			this.AccountType = AccountType;
		}

		// Token: 0x04000288 RID: 648
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000289 RID: 649
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400028A RID: 650
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400028B RID: 651
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400028C RID: 652
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400028D RID: 653
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x0400028E RID: 654
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
