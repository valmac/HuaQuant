using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000118 RID: 280
	public class FIXDerivativeSecurityList : FIXMessage
	{
		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x00037FBB File Offset: 0x00036FBB
		// (set) Token: 0x0600350A RID: 13578 RVA: 0x00037FCD File Offset: 0x00036FCD
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

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x00037FDB File Offset: 0x00036FDB
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x00037FEA File Offset: 0x00036FEA
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

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x00037FF5 File Offset: 0x00036FF5
		// (set) Token: 0x0600350E RID: 13582 RVA: 0x00038004 File Offset: 0x00037004
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

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x0003800F File Offset: 0x0003700F
		// (set) Token: 0x06003510 RID: 13584 RVA: 0x0003801E File Offset: 0x0003701E
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

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x00038029 File Offset: 0x00037029
		// (set) Token: 0x06003512 RID: 13586 RVA: 0x00038038 File Offset: 0x00037038
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

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x00038043 File Offset: 0x00037043
		// (set) Token: 0x06003514 RID: 13588 RVA: 0x00038052 File Offset: 0x00037052
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

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x0003805D File Offset: 0x0003705D
		// (set) Token: 0x06003516 RID: 13590 RVA: 0x0003806F File Offset: 0x0003706F
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

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x0003807D File Offset: 0x0003707D
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x0003808C File Offset: 0x0003708C
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x00038097 File Offset: 0x00037097
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x000380A6 File Offset: 0x000370A6
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

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x000380B1 File Offset: 0x000370B1
		// (set) Token: 0x0600351C RID: 13596 RVA: 0x000380C0 File Offset: 0x000370C0
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

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000380CB File Offset: 0x000370CB
		// (set) Token: 0x0600351E RID: 13598 RVA: 0x000380DA File Offset: 0x000370DA
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

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x000380E5 File Offset: 0x000370E5
		// (set) Token: 0x06003520 RID: 13600 RVA: 0x000380F7 File Offset: 0x000370F7
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

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x00038105 File Offset: 0x00037105
		// (set) Token: 0x06003522 RID: 13602 RVA: 0x00038114 File Offset: 0x00037114
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x0003811F File Offset: 0x0003711F
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x0003812D File Offset: 0x0003712D
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

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x00038137 File Offset: 0x00037137
		// (set) Token: 0x06003526 RID: 13606 RVA: 0x00038146 File Offset: 0x00037146
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

		// Token: 0x06003527 RID: 13607 RVA: 0x00038151 File Offset: 0x00037151
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00038164 File Offset: 0x00037164
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x00038173 File Offset: 0x00037173
		// (set) Token: 0x0600352A RID: 13610 RVA: 0x00038185 File Offset: 0x00037185
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

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x00038193 File Offset: 0x00037193
		// (set) Token: 0x0600352C RID: 13612 RVA: 0x000381A5 File Offset: 0x000371A5
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

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x000381B3 File Offset: 0x000371B3
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x000381C2 File Offset: 0x000371C2
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

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x000381CD File Offset: 0x000371CD
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x000381DC File Offset: 0x000371DC
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

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x000381E7 File Offset: 0x000371E7
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x000381F6 File Offset: 0x000371F6
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

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x00038201 File Offset: 0x00037201
		// (set) Token: 0x06003534 RID: 13620 RVA: 0x00038210 File Offset: 0x00037210
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

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06003535 RID: 13621 RVA: 0x0003821B File Offset: 0x0003721B
		// (set) Token: 0x06003536 RID: 13622 RVA: 0x0003822D File Offset: 0x0003722D
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

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x0003823B File Offset: 0x0003723B
		// (set) Token: 0x06003538 RID: 13624 RVA: 0x0003824D File Offset: 0x0003724D
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

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x0003825B File Offset: 0x0003725B
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x0003826D File Offset: 0x0003726D
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

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x0003827B File Offset: 0x0003727B
		// (set) Token: 0x0600353C RID: 13628 RVA: 0x0003828D File Offset: 0x0003728D
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

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x0600353D RID: 13629 RVA: 0x0003829B File Offset: 0x0003729B
		// (set) Token: 0x0600353E RID: 13630 RVA: 0x000382AD File Offset: 0x000372AD
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

		// Token: 0x0600353F RID: 13631 RVA: 0x000382BB File Offset: 0x000372BB
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000382D9 File Offset: 0x000372D9
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x000382F6 File Offset: 0x000372F6
		// (set) Token: 0x06003542 RID: 13634 RVA: 0x00038308 File Offset: 0x00037308
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

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x00038316 File Offset: 0x00037316
		// (set) Token: 0x06003544 RID: 13636 RVA: 0x00038328 File Offset: 0x00037328
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

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x00038336 File Offset: 0x00037336
		// (set) Token: 0x06003546 RID: 13638 RVA: 0x00038348 File Offset: 0x00037348
		[FIXField("322", EFieldOption.Required)]
		public string SecurityResponseID
		{
			get
			{
				return this.GetStringField(322).Value;
			}
			set
			{
				this.AddStringField(322, value);
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x00038356 File Offset: 0x00037356
		// (set) Token: 0x06003548 RID: 13640 RVA: 0x00038368 File Offset: 0x00037368
		[FIXField("560", EFieldOption.Required)]
		public int SecurityRequestResult
		{
			get
			{
				return this.GetIntField(560).Value;
			}
			set
			{
				this.AddIntField(560, value);
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x00038376 File Offset: 0x00037376
		// (set) Token: 0x0600354A RID: 13642 RVA: 0x00038388 File Offset: 0x00037388
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

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x00038396 File Offset: 0x00037396
		// (set) Token: 0x0600354C RID: 13644 RVA: 0x000383A8 File Offset: 0x000373A8
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

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x000383B6 File Offset: 0x000373B6
		// (set) Token: 0x0600354E RID: 13646 RVA: 0x000383C8 File Offset: 0x000373C8
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

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x000383D6 File Offset: 0x000373D6
		// (set) Token: 0x06003550 RID: 13648 RVA: 0x000383E8 File Offset: 0x000373E8
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

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x000383F6 File Offset: 0x000373F6
		// (set) Token: 0x06003552 RID: 13650 RVA: 0x00038408 File Offset: 0x00037408
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

		// Token: 0x06003553 RID: 13651 RVA: 0x00038416 File Offset: 0x00037416
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00038434 File Offset: 0x00037434
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x00038451 File Offset: 0x00037451
		// (set) Token: 0x06003556 RID: 13654 RVA: 0x00038463 File Offset: 0x00037463
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

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x00038471 File Offset: 0x00037471
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x00038483 File Offset: 0x00037483
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

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x00038491 File Offset: 0x00037491
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x000384A3 File Offset: 0x000374A3
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

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x000384B1 File Offset: 0x000374B1
		// (set) Token: 0x0600355C RID: 13660 RVA: 0x000384C3 File Offset: 0x000374C3
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

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x000384D1 File Offset: 0x000374D1
		// (set) Token: 0x0600355E RID: 13662 RVA: 0x000384E3 File Offset: 0x000374E3
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

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x000384F1 File Offset: 0x000374F1
		// (set) Token: 0x06003560 RID: 13664 RVA: 0x00038503 File Offset: 0x00037503
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

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x00038511 File Offset: 0x00037511
		// (set) Token: 0x06003562 RID: 13666 RVA: 0x00038523 File Offset: 0x00037523
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

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x00038531 File Offset: 0x00037531
		// (set) Token: 0x06003564 RID: 13668 RVA: 0x00038543 File Offset: 0x00037543
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

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x00038551 File Offset: 0x00037551
		// (set) Token: 0x06003566 RID: 13670 RVA: 0x00038563 File Offset: 0x00037563
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

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x00038571 File Offset: 0x00037571
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x00038583 File Offset: 0x00037583
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

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x00038591 File Offset: 0x00037591
		// (set) Token: 0x0600356A RID: 13674 RVA: 0x000385A3 File Offset: 0x000375A3
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

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600356B RID: 13675 RVA: 0x000385B1 File Offset: 0x000375B1
		// (set) Token: 0x0600356C RID: 13676 RVA: 0x000385C3 File Offset: 0x000375C3
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

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x0600356D RID: 13677 RVA: 0x000385D1 File Offset: 0x000375D1
		// (set) Token: 0x0600356E RID: 13678 RVA: 0x000385E3 File Offset: 0x000375E3
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

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x000385F1 File Offset: 0x000375F1
		// (set) Token: 0x06003570 RID: 13680 RVA: 0x00038603 File Offset: 0x00037603
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

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06003571 RID: 13681 RVA: 0x00038611 File Offset: 0x00037611
		// (set) Token: 0x06003572 RID: 13682 RVA: 0x00038623 File Offset: 0x00037623
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

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x00038631 File Offset: 0x00037631
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x00038643 File Offset: 0x00037643
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

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x00038651 File Offset: 0x00037651
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x00038663 File Offset: 0x00037663
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

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x00038671 File Offset: 0x00037671
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x00038683 File Offset: 0x00037683
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

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06003579 RID: 13689 RVA: 0x00038691 File Offset: 0x00037691
		// (set) Token: 0x0600357A RID: 13690 RVA: 0x000386A3 File Offset: 0x000376A3
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

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x000386B1 File Offset: 0x000376B1
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x000386C3 File Offset: 0x000376C3
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

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x000386D1 File Offset: 0x000376D1
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x000386E3 File Offset: 0x000376E3
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

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x000386F1 File Offset: 0x000376F1
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x00038703 File Offset: 0x00037703
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

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x00038711 File Offset: 0x00037711
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x00038723 File Offset: 0x00037723
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

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x00038731 File Offset: 0x00037731
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x00038743 File Offset: 0x00037743
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

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x00038751 File Offset: 0x00037751
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x00038763 File Offset: 0x00037763
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x00038771 File Offset: 0x00037771
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x00038783 File Offset: 0x00037783
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

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00038791 File Offset: 0x00037791
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x000387A3 File Offset: 0x000377A3
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

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x000387B1 File Offset: 0x000377B1
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x000387C3 File Offset: 0x000377C3
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

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x000387D1 File Offset: 0x000377D1
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x000387E3 File Offset: 0x000377E3
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

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x000387F1 File Offset: 0x000377F1
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x00038803 File Offset: 0x00037803
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

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x00038811 File Offset: 0x00037811
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x00038823 File Offset: 0x00037823
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

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x00038831 File Offset: 0x00037831
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x00038843 File Offset: 0x00037843
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

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x00038851 File Offset: 0x00037851
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x00038863 File Offset: 0x00037863
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

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x00038871 File Offset: 0x00037871
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x00038883 File Offset: 0x00037883
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

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x00038891 File Offset: 0x00037891
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x000388A3 File Offset: 0x000378A3
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

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x000388B1 File Offset: 0x000378B1
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x000388C3 File Offset: 0x000378C3
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

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x000388D1 File Offset: 0x000378D1
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x000388E3 File Offset: 0x000378E3
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

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000388F1 File Offset: 0x000378F1
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x00038903 File Offset: 0x00037903
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

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x00038911 File Offset: 0x00037911
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x00038923 File Offset: 0x00037923
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

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x00038931 File Offset: 0x00037931
		// (set) Token: 0x060035A4 RID: 13732 RVA: 0x00038943 File Offset: 0x00037943
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

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x00038951 File Offset: 0x00037951
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x00038963 File Offset: 0x00037963
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

		// Token: 0x060035A7 RID: 13735 RVA: 0x00038971 File Offset: 0x00037971
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x0003898F File Offset: 0x0003798F
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x000389AC File Offset: 0x000379AC
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x000389BE File Offset: 0x000379BE
		[FIXField("393", EFieldOption.Optional)]
		public int TotNoRelatedSym
		{
			get
			{
				return this.GetIntField(393).Value;
			}
			set
			{
				this.AddIntField(393, value);
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x000389CC File Offset: 0x000379CC
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x000389DE File Offset: 0x000379DE
		[FIXField("893", EFieldOption.Optional)]
		public bool LastFragment
		{
			get
			{
				return this.GetBoolField(893).Value;
			}
			set
			{
				this.AddBoolField(893, value);
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x000389EC File Offset: 0x000379EC
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x000389FE File Offset: 0x000379FE
		[FIXField("146", EFieldOption.Optional)]
		public int NoRelatedSym
		{
			get
			{
				return this.GetIntField(146).Value;
			}
			set
			{
				this.AddIntField(146, value);
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00038A0C File Offset: 0x00037A0C
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00038A2A File Offset: 0x00037A2A
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x00038A47 File Offset: 0x00037A47
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x00038A56 File Offset: 0x00037A56
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

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x00038A61 File Offset: 0x00037A61
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x00038A70 File Offset: 0x00037A70
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

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x00038A7B File Offset: 0x00037A7B
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x00038A8A File Offset: 0x00037A8A
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

		// Token: 0x060035B7 RID: 13751 RVA: 0x00038A95 File Offset: 0x00037A95
		public FIXDerivativeSecurityList()
		{
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00038AD4 File Offset: 0x00037AD4
		public FIXDerivativeSecurityList(string SecurityReqID, string SecurityResponseID, int SecurityRequestResult)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityResponseID = SecurityResponseID;
			this.SecurityRequestResult = SecurityRequestResult;
		}

		// Token: 0x04000500 RID: 1280
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000501 RID: 1281
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000502 RID: 1282
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000503 RID: 1283
		private ArrayList fUnderlyingStipsGroup = new ArrayList();

		// Token: 0x04000504 RID: 1284
		private ArrayList fRelatedSymGroup = new ArrayList();
	}
}
