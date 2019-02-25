using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000E3 RID: 227
	public class FIXConfirmationRequest : FIXMessage
	{
		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x0002FD47 File Offset: 0x0002ED47
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x0002FD59 File Offset: 0x0002ED59
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x0002FD67 File Offset: 0x0002ED67
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x0002FD76 File Offset: 0x0002ED76
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

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x0002FD81 File Offset: 0x0002ED81
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x0002FD90 File Offset: 0x0002ED90
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

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x0002FD9B File Offset: 0x0002ED9B
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x0002FDAA File Offset: 0x0002EDAA
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

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x0002FDB5 File Offset: 0x0002EDB5
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0002FDC4 File Offset: 0x0002EDC4
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

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x0002FDCF File Offset: 0x0002EDCF
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x0002FDDE File Offset: 0x0002EDDE
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

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x0002FDE9 File Offset: 0x0002EDE9
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x0002FDFB File Offset: 0x0002EDFB
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

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x0002FE09 File Offset: 0x0002EE09
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x0002FE18 File Offset: 0x0002EE18
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x0002FE23 File Offset: 0x0002EE23
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x0002FE32 File Offset: 0x0002EE32
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

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x0002FE3D File Offset: 0x0002EE3D
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x0002FE4C File Offset: 0x0002EE4C
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

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x0002FE57 File Offset: 0x0002EE57
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x0002FE66 File Offset: 0x0002EE66
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

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x0002FE71 File Offset: 0x0002EE71
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x0002FE83 File Offset: 0x0002EE83
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

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x0002FE91 File Offset: 0x0002EE91
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x0002FEA0 File Offset: 0x0002EEA0
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

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x0002FEAB File Offset: 0x0002EEAB
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x0002FEB9 File Offset: 0x0002EEB9
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

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x0002FEC3 File Offset: 0x0002EEC3
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0002FED2 File Offset: 0x0002EED2
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

		// Token: 0x06002D39 RID: 11577 RVA: 0x0002FEDD File Offset: 0x0002EEDD
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0002FEF0 File Offset: 0x0002EEF0
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x0002FEFF File Offset: 0x0002EEFF
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x0002FF11 File Offset: 0x0002EF11
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

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x0002FF1F File Offset: 0x0002EF1F
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x0002FF31 File Offset: 0x0002EF31
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

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0002FF3F File Offset: 0x0002EF3F
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x0002FF4E File Offset: 0x0002EF4E
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

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0002FF59 File Offset: 0x0002EF59
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x0002FF68 File Offset: 0x0002EF68
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x0002FF73 File Offset: 0x0002EF73
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x0002FF82 File Offset: 0x0002EF82
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0002FF8D File Offset: 0x0002EF8D
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x0002FF9C File Offset: 0x0002EF9C
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

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x0002FFA7 File Offset: 0x0002EFA7
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x0002FFB9 File Offset: 0x0002EFB9
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x0002FFC7 File Offset: 0x0002EFC7
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x0002FFD9 File Offset: 0x0002EFD9
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

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x0002FFE7 File Offset: 0x0002EFE7
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x0002FFF9 File Offset: 0x0002EFF9
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

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x00030007 File Offset: 0x0002F007
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x00030019 File Offset: 0x0002F019
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

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x00030027 File Offset: 0x0002F027
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x00030039 File Offset: 0x0002F039
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

		// Token: 0x06002D51 RID: 11601 RVA: 0x00030047 File Offset: 0x0002F047
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00030065 File Offset: 0x0002F065
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x00030082 File Offset: 0x0002F082
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x00030094 File Offset: 0x0002F094
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

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000300A2 File Offset: 0x0002F0A2
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x000300B4 File Offset: 0x0002F0B4
		[FIXField("859", EFieldOption.Required)]
		public string ConfirmReqID
		{
			get
			{
				return this.GetStringField(859).Value;
			}
			set
			{
				this.AddStringField(859, value);
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x000300C2 File Offset: 0x0002F0C2
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x000300D4 File Offset: 0x0002F0D4
		[FIXField("773", EFieldOption.Required)]
		public int ConfirmType
		{
			get
			{
				return this.GetIntField(773).Value;
			}
			set
			{
				this.AddIntField(773, value);
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000300E2 File Offset: 0x0002F0E2
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x000300F1 File Offset: 0x0002F0F1
		[FIXField("73", EFieldOption.Optional)]
		public int NoOrders
		{
			get
			{
				return this.GetIntField(73).Value;
			}
			set
			{
				this.AddIntField(73, value);
			}
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000300FC File Offset: 0x0002F0FC
		public FIXOrdersGroup GetOrdersGroup(int i)
		{
			if (i < this.NoOrders)
			{
				return (FIXOrdersGroup)this.fOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x0003011A File Offset: 0x0002F11A
		public void AddGroup(FIXOrdersGroup group)
		{
			this.fOrdersGroup.Add(group);
			this.NoOrders++;
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x00030137 File Offset: 0x0002F137
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x00030146 File Offset: 0x0002F146
		[FIXField("70", EFieldOption.Optional)]
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

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00030151 File Offset: 0x0002F151
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x00030163 File Offset: 0x0002F163
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

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00030171 File Offset: 0x0002F171
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x00030183 File Offset: 0x0002F183
		[FIXField("467", EFieldOption.Optional)]
		public string IndividualAllocID
		{
			get
			{
				return this.GetStringField(467).Value;
			}
			set
			{
				this.AddStringField(467, value);
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00030191 File Offset: 0x0002F191
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x000301A0 File Offset: 0x0002F1A0
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

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000301AB File Offset: 0x0002F1AB
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x000301BA File Offset: 0x0002F1BA
		[FIXField("79", EFieldOption.Optional)]
		public string AllocAccount
		{
			get
			{
				return this.GetStringField(79).Value;
			}
			set
			{
				this.AddStringField(79, value);
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000301C5 File Offset: 0x0002F1C5
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x000301D7 File Offset: 0x0002F1D7
		[FIXField("661", EFieldOption.Optional)]
		public int AllocAcctIDSource
		{
			get
			{
				return this.GetIntField(661).Value;
			}
			set
			{
				this.AddIntField(661, value);
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000301E5 File Offset: 0x0002F1E5
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x000301F7 File Offset: 0x0002F1F7
		[FIXField("798", EFieldOption.Optional)]
		public int AllocAccountType
		{
			get
			{
				return this.GetIntField(798).Value;
			}
			set
			{
				this.AddIntField(798, value);
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x00030205 File Offset: 0x0002F205
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x00030214 File Offset: 0x0002F214
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

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x0003021F File Offset: 0x0002F21F
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x00030231 File Offset: 0x0002F231
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

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x0003023F File Offset: 0x0002F23F
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x00030251 File Offset: 0x0002F251
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

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x0003025F File Offset: 0x0002F25F
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x0003026E File Offset: 0x0002F26E
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

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x00030279 File Offset: 0x0002F279
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x00030288 File Offset: 0x0002F288
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x00030293 File Offset: 0x0002F293
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x000302A2 File Offset: 0x0002F2A2
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

		// Token: 0x06002D77 RID: 11639 RVA: 0x000302AD File Offset: 0x0002F2AD
		public FIXConfirmationRequest()
		{
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000302D6 File Offset: 0x0002F2D6
		public FIXConfirmationRequest(string ConfirmReqID, int ConfirmType, DateTime TransactTime)
		{
			this.ConfirmReqID = ConfirmReqID;
			this.ConfirmType = ConfirmType;
			this.TransactTime = TransactTime;
		}

		// Token: 0x040003DF RID: 991
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003E0 RID: 992
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040003E1 RID: 993
		private ArrayList fOrdersGroup = new ArrayList();
	}
}
