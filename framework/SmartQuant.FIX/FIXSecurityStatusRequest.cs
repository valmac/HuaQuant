using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200015C RID: 348
	public class FIXSecurityStatusRequest : FIXMessage
	{
		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x00046490 File Offset: 0x00045490
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x000464A2 File Offset: 0x000454A2
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

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x000464B0 File Offset: 0x000454B0
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x000464BF File Offset: 0x000454BF
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

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x000464CA File Offset: 0x000454CA
		// (set) Token: 0x06004041 RID: 16449 RVA: 0x000464D9 File Offset: 0x000454D9
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

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x000464E4 File Offset: 0x000454E4
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x000464F3 File Offset: 0x000454F3
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

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x000464FE File Offset: 0x000454FE
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x0004650D File Offset: 0x0004550D
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

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x00046518 File Offset: 0x00045518
		// (set) Token: 0x06004047 RID: 16455 RVA: 0x00046527 File Offset: 0x00045527
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

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x00046532 File Offset: 0x00045532
		// (set) Token: 0x06004049 RID: 16457 RVA: 0x00046544 File Offset: 0x00045544
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

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x00046552 File Offset: 0x00045552
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x00046561 File Offset: 0x00045561
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

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x0004656C File Offset: 0x0004556C
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x0004657B File Offset: 0x0004557B
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

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x00046586 File Offset: 0x00045586
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x00046595 File Offset: 0x00045595
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

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x000465A0 File Offset: 0x000455A0
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x000465AF File Offset: 0x000455AF
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

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x000465BA File Offset: 0x000455BA
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x000465CC File Offset: 0x000455CC
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

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x000465DA File Offset: 0x000455DA
		// (set) Token: 0x06004055 RID: 16469 RVA: 0x000465E9 File Offset: 0x000455E9
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

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x000465F4 File Offset: 0x000455F4
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x00046602 File Offset: 0x00045602
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

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x0004660C File Offset: 0x0004560C
		// (set) Token: 0x06004059 RID: 16473 RVA: 0x0004661B File Offset: 0x0004561B
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

		// Token: 0x0600405A RID: 16474 RVA: 0x00046626 File Offset: 0x00045626
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00046639 File Offset: 0x00045639
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x00046648 File Offset: 0x00045648
		// (set) Token: 0x0600405D RID: 16477 RVA: 0x0004665A File Offset: 0x0004565A
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

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x00046668 File Offset: 0x00045668
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x0004667A File Offset: 0x0004567A
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

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x00046688 File Offset: 0x00045688
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x00046697 File Offset: 0x00045697
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

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x000466A2 File Offset: 0x000456A2
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x000466B1 File Offset: 0x000456B1
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

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x000466BC File Offset: 0x000456BC
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x000466CB File Offset: 0x000456CB
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

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x000466D6 File Offset: 0x000456D6
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x000466E5 File Offset: 0x000456E5
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

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x000466F0 File Offset: 0x000456F0
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x00046702 File Offset: 0x00045702
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

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x00046710 File Offset: 0x00045710
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x00046722 File Offset: 0x00045722
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

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x00046730 File Offset: 0x00045730
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x00046742 File Offset: 0x00045742
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

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x00046750 File Offset: 0x00045750
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x00046762 File Offset: 0x00045762
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

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x00046770 File Offset: 0x00045770
		// (set) Token: 0x06004071 RID: 16497 RVA: 0x00046782 File Offset: 0x00045782
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

		// Token: 0x06004072 RID: 16498 RVA: 0x00046790 File Offset: 0x00045790
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x000467AE File Offset: 0x000457AE
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x000467CB File Offset: 0x000457CB
		// (set) Token: 0x06004075 RID: 16501 RVA: 0x000467DD File Offset: 0x000457DD
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

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x000467EB File Offset: 0x000457EB
		// (set) Token: 0x06004077 RID: 16503 RVA: 0x000467FD File Offset: 0x000457FD
		[FIXField("324", EFieldOption.Required)]
		public string SecurityStatusReqID
		{
			get
			{
				return this.GetStringField(324).Value;
			}
			set
			{
				this.AddStringField(324, value);
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x0004680B File Offset: 0x0004580B
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x0004681A File Offset: 0x0004581A
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

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x00046825 File Offset: 0x00045825
		// (set) Token: 0x0600407B RID: 16507 RVA: 0x00046834 File Offset: 0x00045834
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

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x0004683F File Offset: 0x0004583F
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x0004684E File Offset: 0x0004584E
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

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x00046859 File Offset: 0x00045859
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x00046868 File Offset: 0x00045868
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

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x00046873 File Offset: 0x00045873
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x00046885 File Offset: 0x00045885
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

		// Token: 0x06004082 RID: 16514 RVA: 0x00046893 File Offset: 0x00045893
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x000468B1 File Offset: 0x000458B1
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x000468CE File Offset: 0x000458CE
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x000468E0 File Offset: 0x000458E0
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

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x000468EE File Offset: 0x000458EE
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x00046900 File Offset: 0x00045900
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

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x0004690E File Offset: 0x0004590E
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x00046920 File Offset: 0x00045920
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

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x0004692E File Offset: 0x0004592E
		// (set) Token: 0x0600408B RID: 16523 RVA: 0x00046940 File Offset: 0x00045940
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

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x0004694E File Offset: 0x0004594E
		// (set) Token: 0x0600408D RID: 16525 RVA: 0x00046960 File Offset: 0x00045960
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

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x0004696E File Offset: 0x0004596E
		// (set) Token: 0x0600408F RID: 16527 RVA: 0x00046980 File Offset: 0x00045980
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

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x0004698E File Offset: 0x0004598E
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x000469A0 File Offset: 0x000459A0
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

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x000469AE File Offset: 0x000459AE
		// (set) Token: 0x06004093 RID: 16531 RVA: 0x000469C0 File Offset: 0x000459C0
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

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x000469CE File Offset: 0x000459CE
		// (set) Token: 0x06004095 RID: 16533 RVA: 0x000469E0 File Offset: 0x000459E0
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

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x000469EE File Offset: 0x000459EE
		// (set) Token: 0x06004097 RID: 16535 RVA: 0x00046A00 File Offset: 0x00045A00
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

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x00046A0E File Offset: 0x00045A0E
		// (set) Token: 0x06004099 RID: 16537 RVA: 0x00046A20 File Offset: 0x00045A20
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

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600409A RID: 16538 RVA: 0x00046A2E File Offset: 0x00045A2E
		// (set) Token: 0x0600409B RID: 16539 RVA: 0x00046A40 File Offset: 0x00045A40
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

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x00046A4E File Offset: 0x00045A4E
		// (set) Token: 0x0600409D RID: 16541 RVA: 0x00046A60 File Offset: 0x00045A60
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

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x00046A6E File Offset: 0x00045A6E
		// (set) Token: 0x0600409F RID: 16543 RVA: 0x00046A80 File Offset: 0x00045A80
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

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x00046A8E File Offset: 0x00045A8E
		// (set) Token: 0x060040A1 RID: 16545 RVA: 0x00046AA0 File Offset: 0x00045AA0
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

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x00046AAE File Offset: 0x00045AAE
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x00046AC0 File Offset: 0x00045AC0
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

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x00046ACE File Offset: 0x00045ACE
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x00046AE0 File Offset: 0x00045AE0
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

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x00046AEE File Offset: 0x00045AEE
		// (set) Token: 0x060040A7 RID: 16551 RVA: 0x00046B00 File Offset: 0x00045B00
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

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x060040A8 RID: 16552 RVA: 0x00046B0E File Offset: 0x00045B0E
		// (set) Token: 0x060040A9 RID: 16553 RVA: 0x00046B20 File Offset: 0x00045B20
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

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x060040AA RID: 16554 RVA: 0x00046B2E File Offset: 0x00045B2E
		// (set) Token: 0x060040AB RID: 16555 RVA: 0x00046B40 File Offset: 0x00045B40
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

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x00046B4E File Offset: 0x00045B4E
		// (set) Token: 0x060040AD RID: 16557 RVA: 0x00046B60 File Offset: 0x00045B60
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

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x00046B6E File Offset: 0x00045B6E
		// (set) Token: 0x060040AF RID: 16559 RVA: 0x00046B80 File Offset: 0x00045B80
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

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x00046B8E File Offset: 0x00045B8E
		// (set) Token: 0x060040B1 RID: 16561 RVA: 0x00046BA0 File Offset: 0x00045BA0
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

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x00046BAE File Offset: 0x00045BAE
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x00046BC0 File Offset: 0x00045BC0
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

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x00046BCE File Offset: 0x00045BCE
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x00046BDD File Offset: 0x00045BDD
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

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x00046BE8 File Offset: 0x00045BE8
		// (set) Token: 0x060040B7 RID: 16567 RVA: 0x00046BFA File Offset: 0x00045BFA
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

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x00046C08 File Offset: 0x00045C08
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x00046C1A File Offset: 0x00045C1A
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

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x00046C28 File Offset: 0x00045C28
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x00046C37 File Offset: 0x00045C37
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

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x00046C42 File Offset: 0x00045C42
		// (set) Token: 0x060040BD RID: 16573 RVA: 0x00046C54 File Offset: 0x00045C54
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

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x00046C62 File Offset: 0x00045C62
		// (set) Token: 0x060040BF RID: 16575 RVA: 0x00046C74 File Offset: 0x00045C74
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

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x00046C82 File Offset: 0x00045C82
		// (set) Token: 0x060040C1 RID: 16577 RVA: 0x00046C94 File Offset: 0x00045C94
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

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x00046CA2 File Offset: 0x00045CA2
		// (set) Token: 0x060040C3 RID: 16579 RVA: 0x00046CB4 File Offset: 0x00045CB4
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

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x00046CC2 File Offset: 0x00045CC2
		// (set) Token: 0x060040C5 RID: 16581 RVA: 0x00046CD4 File Offset: 0x00045CD4
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

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x00046CE2 File Offset: 0x00045CE2
		// (set) Token: 0x060040C7 RID: 16583 RVA: 0x00046CF4 File Offset: 0x00045CF4
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

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x00046D02 File Offset: 0x00045D02
		// (set) Token: 0x060040C9 RID: 16585 RVA: 0x00046D14 File Offset: 0x00045D14
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

		// Token: 0x060040CA RID: 16586 RVA: 0x00046D22 File Offset: 0x00045D22
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x00046D40 File Offset: 0x00045D40
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060040CC RID: 16588 RVA: 0x00046D5D File Offset: 0x00045D5D
		// (set) Token: 0x060040CD RID: 16589 RVA: 0x00046D6F File Offset: 0x00045D6F
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

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x00046D7D File Offset: 0x00045D7D
		// (set) Token: 0x060040CF RID: 16591 RVA: 0x00046D8F File Offset: 0x00045D8F
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

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060040D0 RID: 16592 RVA: 0x00046D9D File Offset: 0x00045D9D
		// (set) Token: 0x060040D1 RID: 16593 RVA: 0x00046DAF File Offset: 0x00045DAF
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

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x060040D2 RID: 16594 RVA: 0x00046DBD File Offset: 0x00045DBD
		// (set) Token: 0x060040D3 RID: 16595 RVA: 0x00046DCF File Offset: 0x00045DCF
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

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x00046DDD File Offset: 0x00045DDD
		// (set) Token: 0x060040D5 RID: 16597 RVA: 0x00046DEF File Offset: 0x00045DEF
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

		// Token: 0x060040D6 RID: 16598 RVA: 0x00046DFD File Offset: 0x00045DFD
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00046E1B File Offset: 0x00045E1B
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x00046E38 File Offset: 0x00045E38
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x00046E4A File Offset: 0x00045E4A
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

		// Token: 0x060040DA RID: 16602 RVA: 0x00046E58 File Offset: 0x00045E58
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00046E76 File Offset: 0x00045E76
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x00046E93 File Offset: 0x00045E93
		// (set) Token: 0x060040DD RID: 16605 RVA: 0x00046EA5 File Offset: 0x00045EA5
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

		// Token: 0x060040DE RID: 16606 RVA: 0x00046EB3 File Offset: 0x00045EB3
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00046ED1 File Offset: 0x00045ED1
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x00046EEE File Offset: 0x00045EEE
		// (set) Token: 0x060040E1 RID: 16609 RVA: 0x00046EFD File Offset: 0x00045EFD
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

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x00046F08 File Offset: 0x00045F08
		// (set) Token: 0x060040E3 RID: 16611 RVA: 0x00046F1A File Offset: 0x00045F1A
		[FIXField("263", EFieldOption.Required)]
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

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060040E4 RID: 16612 RVA: 0x00046F28 File Offset: 0x00045F28
		// (set) Token: 0x060040E5 RID: 16613 RVA: 0x00046F3A File Offset: 0x00045F3A
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

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x00046F48 File Offset: 0x00045F48
		// (set) Token: 0x060040E7 RID: 16615 RVA: 0x00046F5A File Offset: 0x00045F5A
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

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060040E8 RID: 16616 RVA: 0x00046F68 File Offset: 0x00045F68
		// (set) Token: 0x060040E9 RID: 16617 RVA: 0x00046F77 File Offset: 0x00045F77
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

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060040EA RID: 16618 RVA: 0x00046F82 File Offset: 0x00045F82
		// (set) Token: 0x060040EB RID: 16619 RVA: 0x00046F91 File Offset: 0x00045F91
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

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x00046F9C File Offset: 0x00045F9C
		// (set) Token: 0x060040ED RID: 16621 RVA: 0x00046FAB File Offset: 0x00045FAB
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

		// Token: 0x060040EE RID: 16622 RVA: 0x00046FB8 File Offset: 0x00045FB8
		public FIXSecurityStatusRequest()
		{
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00047018 File Offset: 0x00046018
		public FIXSecurityStatusRequest(string SecurityStatusReqID, char SubscriptionRequestType)
		{
			this.SecurityStatusReqID = SecurityStatusReqID;
			this.SubscriptionRequestType = SubscriptionRequestType;
		}

		// Token: 0x0400098D RID: 2445
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400098E RID: 2446
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400098F RID: 2447
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000990 RID: 2448
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000991 RID: 2449
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x04000992 RID: 2450
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000993 RID: 2451
		private ArrayList fLegsGroup = new ArrayList();
	}
}
