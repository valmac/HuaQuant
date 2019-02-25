using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000031 RID: 49
	public class FIXTradeCaptureReportRequestAck : FIXMessage
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0000CAD2 File Offset: 0x0000BAD2
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0000CAE4 File Offset: 0x0000BAE4
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

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0000CAF2 File Offset: 0x0000BAF2
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0000CB01 File Offset: 0x0000BB01
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

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0000CB0C File Offset: 0x0000BB0C
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0000CB1B File Offset: 0x0000BB1B
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0000CB26 File Offset: 0x0000BB26
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0000CB35 File Offset: 0x0000BB35
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0000CB40 File Offset: 0x0000BB40
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0000CB4F File Offset: 0x0000BB4F
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0000CB5A File Offset: 0x0000BB5A
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0000CB69 File Offset: 0x0000BB69
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

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0000CB74 File Offset: 0x0000BB74
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0000CB86 File Offset: 0x0000BB86
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0000CB94 File Offset: 0x0000BB94
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0000CBA3 File Offset: 0x0000BBA3
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

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0000CBAE File Offset: 0x0000BBAE
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x0000CBBD File Offset: 0x0000BBBD
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

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0000CBC8 File Offset: 0x0000BBC8
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0000CBD7 File Offset: 0x0000BBD7
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0000CBE2 File Offset: 0x0000BBE2
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0000CBF1 File Offset: 0x0000BBF1
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0000CBFC File Offset: 0x0000BBFC
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x0000CC0E File Offset: 0x0000BC0E
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0000CC1C File Offset: 0x0000BC1C
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x0000CC2B File Offset: 0x0000BC2B
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0000CC36 File Offset: 0x0000BC36
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x0000CC44 File Offset: 0x0000BC44
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0000CC4E File Offset: 0x0000BC4E
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x0000CC5D File Offset: 0x0000BC5D
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

		// Token: 0x06000A1F RID: 2591 RVA: 0x0000CC68 File Offset: 0x0000BC68
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0000CC7B File Offset: 0x0000BC7B
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0000CC8A File Offset: 0x0000BC8A
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x0000CC9C File Offset: 0x0000BC9C
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0000CCAA File Offset: 0x0000BCAA
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x0000CCBC File Offset: 0x0000BCBC
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

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0000CCCA File Offset: 0x0000BCCA
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0000CCD9 File Offset: 0x0000BCD9
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0000CCE4 File Offset: 0x0000BCE4
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0000CCF3 File Offset: 0x0000BCF3
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0000CCFE File Offset: 0x0000BCFE
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0000CD0D File Offset: 0x0000BD0D
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0000CD18 File Offset: 0x0000BD18
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0000CD27 File Offset: 0x0000BD27
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0000CD32 File Offset: 0x0000BD32
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0000CD44 File Offset: 0x0000BD44
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

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0000CD52 File Offset: 0x0000BD52
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0000CD64 File Offset: 0x0000BD64
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

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0000CD72 File Offset: 0x0000BD72
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0000CD84 File Offset: 0x0000BD84
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0000CD92 File Offset: 0x0000BD92
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0000CDA4 File Offset: 0x0000BDA4
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

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0000CDB2 File Offset: 0x0000BDB2
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0000CDC4 File Offset: 0x0000BDC4
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

		// Token: 0x06000A37 RID: 2615 RVA: 0x0000CDD2 File Offset: 0x0000BDD2
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0000CDF0 File Offset: 0x0000BDF0
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0000CE0D File Offset: 0x0000BE0D
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0000CE1F File Offset: 0x0000BE1F
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

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0000CE2D File Offset: 0x0000BE2D
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0000CE3F File Offset: 0x0000BE3F
		[FIXField("568", EFieldOption.Required)]
		public string TradeRequestID
		{
			get
			{
				return this.GetStringField(568).Value;
			}
			set
			{
				this.AddStringField(568, value);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0000CE4D File Offset: 0x0000BE4D
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0000CE5F File Offset: 0x0000BE5F
		[FIXField("569", EFieldOption.Required)]
		public int TradeRequestType
		{
			get
			{
				return this.GetIntField(569).Value;
			}
			set
			{
				this.AddIntField(569, value);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0000CE6D File Offset: 0x0000BE6D
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0000CE7F File Offset: 0x0000BE7F
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0000CE8D File Offset: 0x0000BE8D
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0000CE9F File Offset: 0x0000BE9F
		[FIXField("748", EFieldOption.Optional)]
		public int TotNumTradeReports
		{
			get
			{
				return this.GetIntField(748).Value;
			}
			set
			{
				this.AddIntField(748, value);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0000CEAD File Offset: 0x0000BEAD
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0000CEBF File Offset: 0x0000BEBF
		[FIXField("749", EFieldOption.Required)]
		public int TradeRequestResult
		{
			get
			{
				return this.GetIntField(749).Value;
			}
			set
			{
				this.AddIntField(749, value);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0000CECD File Offset: 0x0000BECD
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0000CEDF File Offset: 0x0000BEDF
		[FIXField("750", EFieldOption.Required)]
		public int TradeRequestStatus
		{
			get
			{
				return this.GetIntField(750).Value;
			}
			set
			{
				this.AddIntField(750, value);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0000CEED File Offset: 0x0000BEED
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0000CEFC File Offset: 0x0000BEFC
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0000CF07 File Offset: 0x0000BF07
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0000CF16 File Offset: 0x0000BF16
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0000CF21 File Offset: 0x0000BF21
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0000CF30 File Offset: 0x0000BF30
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0000CF3B File Offset: 0x0000BF3B
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0000CF4A File Offset: 0x0000BF4A
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0000CF55 File Offset: 0x0000BF55
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0000CF67 File Offset: 0x0000BF67
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

		// Token: 0x06000A51 RID: 2641 RVA: 0x0000CF75 File Offset: 0x0000BF75
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0000CF93 File Offset: 0x0000BF93
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0000CFB0 File Offset: 0x0000BFB0
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0000CFC2 File Offset: 0x0000BFC2
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0000CFD0 File Offset: 0x0000BFD0
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0000CFE2 File Offset: 0x0000BFE2
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0000CFF0 File Offset: 0x0000BFF0
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0000D002 File Offset: 0x0000C002
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0000D010 File Offset: 0x0000C010
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0000D022 File Offset: 0x0000C022
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0000D030 File Offset: 0x0000C030
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0000D042 File Offset: 0x0000C042
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0000D050 File Offset: 0x0000C050
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0000D062 File Offset: 0x0000C062
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0000D070 File Offset: 0x0000C070
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0000D082 File Offset: 0x0000C082
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0000D090 File Offset: 0x0000C090
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x0000D0A2 File Offset: 0x0000C0A2
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

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0000D0B0 File Offset: 0x0000C0B0
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0000D0C2 File Offset: 0x0000C0C2
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0000D0D0 File Offset: 0x0000C0D0
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x0000D0E2 File Offset: 0x0000C0E2
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0000D0F0 File Offset: 0x0000C0F0
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0000D102 File Offset: 0x0000C102
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0000D110 File Offset: 0x0000C110
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000D122 File Offset: 0x0000C122
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0000D130 File Offset: 0x0000C130
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0000D142 File Offset: 0x0000C142
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0000D150 File Offset: 0x0000C150
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0000D162 File Offset: 0x0000C162
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0000D170 File Offset: 0x0000C170
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0000D182 File Offset: 0x0000C182
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0000D190 File Offset: 0x0000C190
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0000D1A2 File Offset: 0x0000C1A2
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

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0000D1B0 File Offset: 0x0000C1B0
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0000D1C2 File Offset: 0x0000C1C2
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

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0000D1D0 File Offset: 0x0000C1D0
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0000D1E2 File Offset: 0x0000C1E2
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0000D1F0 File Offset: 0x0000C1F0
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0000D202 File Offset: 0x0000C202
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0000D210 File Offset: 0x0000C210
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0000D222 File Offset: 0x0000C222
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0000D230 File Offset: 0x0000C230
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0000D242 File Offset: 0x0000C242
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

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0000D250 File Offset: 0x0000C250
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0000D262 File Offset: 0x0000C262
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

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0000D270 File Offset: 0x0000C270
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0000D282 File Offset: 0x0000C282
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0000D290 File Offset: 0x0000C290
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0000D2A2 File Offset: 0x0000C2A2
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0000D2B0 File Offset: 0x0000C2B0
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0000D2BF File Offset: 0x0000C2BF
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0000D2CA File Offset: 0x0000C2CA
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0000D2DC File Offset: 0x0000C2DC
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0000D2EA File Offset: 0x0000C2EA
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0000D2FC File Offset: 0x0000C2FC
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0000D30A File Offset: 0x0000C30A
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0000D319 File Offset: 0x0000C319
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0000D324 File Offset: 0x0000C324
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0000D336 File Offset: 0x0000C336
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0000D344 File Offset: 0x0000C344
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0000D356 File Offset: 0x0000C356
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0000D364 File Offset: 0x0000C364
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0000D376 File Offset: 0x0000C376
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0000D384 File Offset: 0x0000C384
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0000D396 File Offset: 0x0000C396
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0000D3A4 File Offset: 0x0000C3A4
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0000D3B6 File Offset: 0x0000C3B6
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

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0000D3C4 File Offset: 0x0000C3C4
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0000D3D6 File Offset: 0x0000C3D6
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0000D3E4 File Offset: 0x0000C3E4
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0000D3F6 File Offset: 0x0000C3F6
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

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000D404 File Offset: 0x0000C404
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0000D422 File Offset: 0x0000C422
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0000D43F File Offset: 0x0000C43F
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0000D451 File Offset: 0x0000C451
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0000D45F File Offset: 0x0000C45F
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0000D471 File Offset: 0x0000C471
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0000D47F File Offset: 0x0000C47F
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0000D491 File Offset: 0x0000C491
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

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0000D49F File Offset: 0x0000C49F
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0000D4BD File Offset: 0x0000C4BD
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0000D4DA File Offset: 0x0000C4DA
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0000D4EC File Offset: 0x0000C4EC
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

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0000D4FA File Offset: 0x0000C4FA
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0000D518 File Offset: 0x0000C518
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0000D535 File Offset: 0x0000C535
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0000D547 File Offset: 0x0000C547
		[FIXField("442", EFieldOption.Optional)]
		public char MultiLegReportingType
		{
			get
			{
				return this.GetCharField(442).Value;
			}
			set
			{
				this.AddCharField(442, value);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0000D555 File Offset: 0x0000C555
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0000D567 File Offset: 0x0000C567
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0000D575 File Offset: 0x0000C575
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0000D587 File Offset: 0x0000C587
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0000D595 File Offset: 0x0000C595
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0000D5A4 File Offset: 0x0000C5A4
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0000D5AF File Offset: 0x0000C5AF
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0000D5C1 File Offset: 0x0000C5C1
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0000D5CF File Offset: 0x0000C5CF
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0000D5E1 File Offset: 0x0000C5E1
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0000D5EF File Offset: 0x0000C5EF
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0000D5FE File Offset: 0x0000C5FE
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0000D609 File Offset: 0x0000C609
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0000D618 File Offset: 0x0000C618
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0000D623 File Offset: 0x0000C623
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0000D632 File Offset: 0x0000C632
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

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000D640 File Offset: 0x0000C640
		public FIXTradeCaptureReportRequestAck()
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000D698 File Offset: 0x0000C698
		public FIXTradeCaptureReportRequestAck(string TradeRequestID, int TradeRequestType, int TradeRequestResult, int TradeRequestStatus)
		{
			this.TradeRequestID = TradeRequestID;
			this.TradeRequestType = TradeRequestType;
			this.TradeRequestResult = TradeRequestResult;
			this.TradeRequestStatus = TradeRequestStatus;
		}

		// Token: 0x04000088 RID: 136
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000089 RID: 137
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400008A RID: 138
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400008B RID: 139
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400008C RID: 140
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400008D RID: 141
		private ArrayList fLegsGroup = new ArrayList();
	}
}
