using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200002A RID: 42
	public class FIXAllocationInstructionAck : FIXMessage
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0000C2A5 File Offset: 0x0000B2A5
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x0000C2B7 File Offset: 0x0000B2B7
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

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0000C2C5 File Offset: 0x0000B2C5
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0000C2D4 File Offset: 0x0000B2D4
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

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0000C2DF File Offset: 0x0000B2DF
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x0000C2EE File Offset: 0x0000B2EE
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

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0000C2F9 File Offset: 0x0000B2F9
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0000C308 File Offset: 0x0000B308
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0000C313 File Offset: 0x0000B313
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x0000C322 File Offset: 0x0000B322
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

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0000C32D File Offset: 0x0000B32D
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0000C33C File Offset: 0x0000B33C
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0000C347 File Offset: 0x0000B347
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x0000C359 File Offset: 0x0000B359
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

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0000C367 File Offset: 0x0000B367
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0000C376 File Offset: 0x0000B376
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0000C381 File Offset: 0x0000B381
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0000C390 File Offset: 0x0000B390
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0000C39B File Offset: 0x0000B39B
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0000C3AA File Offset: 0x0000B3AA
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0000C3B5 File Offset: 0x0000B3B5
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0000C3C4 File Offset: 0x0000B3C4
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

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0000C3CF File Offset: 0x0000B3CF
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0000C3E1 File Offset: 0x0000B3E1
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

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0000C3EF File Offset: 0x0000B3EF
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0000C3FE File Offset: 0x0000B3FE
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

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0000C409 File Offset: 0x0000B409
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0000C417 File Offset: 0x0000B417
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0000C421 File Offset: 0x0000B421
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x0000C430 File Offset: 0x0000B430
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

		// Token: 0x0600099C RID: 2460 RVA: 0x0000C43B File Offset: 0x0000B43B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0000C44E File Offset: 0x0000B44E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0000C45D File Offset: 0x0000B45D
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0000C46F File Offset: 0x0000B46F
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

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0000C47D File Offset: 0x0000B47D
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0000C48F File Offset: 0x0000B48F
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0000C49D File Offset: 0x0000B49D
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0000C4AC File Offset: 0x0000B4AC
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0000C4B7 File Offset: 0x0000B4B7
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x0000C4C6 File Offset: 0x0000B4C6
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0000C4D1 File Offset: 0x0000B4D1
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0000C4E0 File Offset: 0x0000B4E0
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0000C4EB File Offset: 0x0000B4EB
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0000C4FA File Offset: 0x0000B4FA
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

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0000C505 File Offset: 0x0000B505
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x0000C517 File Offset: 0x0000B517
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0000C525 File Offset: 0x0000B525
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0000C537 File Offset: 0x0000B537
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0000C545 File Offset: 0x0000B545
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0000C557 File Offset: 0x0000B557
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0000C565 File Offset: 0x0000B565
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000C577 File Offset: 0x0000B577
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0000C585 File Offset: 0x0000B585
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x0000C597 File Offset: 0x0000B597
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

		// Token: 0x060009B4 RID: 2484 RVA: 0x0000C5A5 File Offset: 0x0000B5A5
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0000C5C3 File Offset: 0x0000B5C3
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0000C5E0 File Offset: 0x0000B5E0
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x0000C5F2 File Offset: 0x0000B5F2
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0000C600 File Offset: 0x0000B600
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0000C60F File Offset: 0x0000B60F
		[FIXField("70", EFieldOption.Required)]
		public string AllocID
		{
			get
			{
				return this.GetStringField(70).Value;
			}
			set
			{
				this.AddStringField(70, value);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0000C61A File Offset: 0x0000B61A
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0000C62C File Offset: 0x0000B62C
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

		// Token: 0x060009BC RID: 2492 RVA: 0x0000C63A File Offset: 0x0000B63A
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0000C658 File Offset: 0x0000B658
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0000C675 File Offset: 0x0000B675
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0000C687 File Offset: 0x0000B687
		[FIXField("793", EFieldOption.Optional)]
		public string SecondaryAllocID
		{
			get
			{
				return this.GetStringField(793).Value;
			}
			set
			{
				this.AddStringField(793, value);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0000C695 File Offset: 0x0000B695
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0000C6A4 File Offset: 0x0000B6A4
		[FIXField("75", EFieldOption.Optional)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeField(75).Value;
			}
			set
			{
				this.AddDateTimeField(75, value);
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0000C6AF File Offset: 0x0000B6AF
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0000C6BE File Offset: 0x0000B6BE
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0000C6C9 File Offset: 0x0000B6C9
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0000C6D8 File Offset: 0x0000B6D8
		[FIXField("87", EFieldOption.Required)]
		public int AllocStatus
		{
			get
			{
				return this.GetIntField(87).Value;
			}
			set
			{
				this.AddIntField(87, value);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0000C6E3 File Offset: 0x0000B6E3
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0000C6F2 File Offset: 0x0000B6F2
		[FIXField("88", EFieldOption.Optional)]
		public int AllocRejCode
		{
			get
			{
				return this.GetIntField(88).Value;
			}
			set
			{
				this.AddIntField(88, value);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0000C6FD File Offset: 0x0000B6FD
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0000C70F File Offset: 0x0000B70F
		[FIXField("626", EFieldOption.Optional)]
		public int AllocType
		{
			get
			{
				return this.GetIntField(626).Value;
			}
			set
			{
				this.AddIntField(626, value);
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0000C71D File Offset: 0x0000B71D
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0000C72F File Offset: 0x0000B72F
		[FIXField("808", EFieldOption.Optional)]
		public int AllocIntermedReqType
		{
			get
			{
				return this.GetIntField(808).Value;
			}
			set
			{
				this.AddIntField(808, value);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0000C73D File Offset: 0x0000B73D
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0000C74F File Offset: 0x0000B74F
		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharField(573).Value;
			}
			set
			{
				this.AddCharField(573, value);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0000C75D File Offset: 0x0000B75D
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000C76F File Offset: 0x0000B76F
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0000C77D File Offset: 0x0000B77D
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0000C78F File Offset: 0x0000B78F
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0000C79D File Offset: 0x0000B79D
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0000C7AC File Offset: 0x0000B7AC
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0000C7B7 File Offset: 0x0000B7B7
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0000C7C9 File Offset: 0x0000B7C9
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0000C7D7 File Offset: 0x0000B7D7
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0000C7E9 File Offset: 0x0000B7E9
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0000C7F7 File Offset: 0x0000B7F7
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0000C806 File Offset: 0x0000B806
		[FIXField("78", EFieldOption.Optional)]
		public int NoAllocs
		{
			get
			{
				return this.GetIntField(78).Value;
			}
			set
			{
				this.AddIntField(78, value);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0000C811 File Offset: 0x0000B811
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0000C82F File Offset: 0x0000B82F
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0000C84C File Offset: 0x0000B84C
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x0000C85B File Offset: 0x0000B85B
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0000C866 File Offset: 0x0000B866
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0000C875 File Offset: 0x0000B875
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0000C880 File Offset: 0x0000B880
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0000C88F File Offset: 0x0000B88F
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

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000C89A File Offset: 0x0000B89A
		public FIXAllocationInstructionAck()
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0000C8D0 File Offset: 0x0000B8D0
		public FIXAllocationInstructionAck(string AllocID, DateTime TransactTime, int AllocStatus)
		{
			this.AllocID = AllocID;
			this.TransactTime = TransactTime;
			this.AllocStatus = AllocStatus;
		}

		// Token: 0x04000072 RID: 114
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000073 RID: 115
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000074 RID: 116
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000075 RID: 117
		private ArrayList fAllocsGroup = new ArrayList();
	}
}
