using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000B4 RID: 180
	public class FIXBidRequest : FIXMessage
	{
		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x000280CA File Offset: 0x000270CA
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x000280DC File Offset: 0x000270DC
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

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x000280EA File Offset: 0x000270EA
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x000280F9 File Offset: 0x000270F9
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

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x00028104 File Offset: 0x00027104
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x00028113 File Offset: 0x00027113
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

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x0002811E File Offset: 0x0002711E
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x0002812D File Offset: 0x0002712D
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

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00028138 File Offset: 0x00027138
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x00028147 File Offset: 0x00027147
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

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x00028152 File Offset: 0x00027152
		// (set) Token: 0x0600257A RID: 9594 RVA: 0x00028161 File Offset: 0x00027161
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

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x0002816C File Offset: 0x0002716C
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x0002817E File Offset: 0x0002717E
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

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x0002818C File Offset: 0x0002718C
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x0002819B File Offset: 0x0002719B
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

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000281A6 File Offset: 0x000271A6
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x000281B5 File Offset: 0x000271B5
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

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x000281C0 File Offset: 0x000271C0
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x000281CF File Offset: 0x000271CF
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

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000281DA File Offset: 0x000271DA
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x000281E9 File Offset: 0x000271E9
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

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000281F4 File Offset: 0x000271F4
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x00028206 File Offset: 0x00027206
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

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x00028214 File Offset: 0x00027214
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00028223 File Offset: 0x00027223
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

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0002822E File Offset: 0x0002722E
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x0002823C File Offset: 0x0002723C
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

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x00028246 File Offset: 0x00027246
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x00028255 File Offset: 0x00027255
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

		// Token: 0x0600258D RID: 9613 RVA: 0x00028260 File Offset: 0x00027260
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00028273 File Offset: 0x00027273
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x00028282 File Offset: 0x00027282
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x00028294 File Offset: 0x00027294
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

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000282A2 File Offset: 0x000272A2
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x000282B4 File Offset: 0x000272B4
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

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000282C2 File Offset: 0x000272C2
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x000282D1 File Offset: 0x000272D1
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

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000282DC File Offset: 0x000272DC
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x000282EB File Offset: 0x000272EB
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

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000282F6 File Offset: 0x000272F6
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x00028305 File Offset: 0x00027305
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

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x00028310 File Offset: 0x00027310
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x0002831F File Offset: 0x0002731F
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

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x0002832A File Offset: 0x0002732A
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x0002833C File Offset: 0x0002733C
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

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x0002834A File Offset: 0x0002734A
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x0002835C File Offset: 0x0002735C
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

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x0002836A File Offset: 0x0002736A
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x0002837C File Offset: 0x0002737C
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

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x0002838A File Offset: 0x0002738A
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x0002839C File Offset: 0x0002739C
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

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x000283AA File Offset: 0x000273AA
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x000283BC File Offset: 0x000273BC
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

		// Token: 0x060025A5 RID: 9637 RVA: 0x000283CA File Offset: 0x000273CA
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000283E8 File Offset: 0x000273E8
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x00028405 File Offset: 0x00027405
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x00028417 File Offset: 0x00027417
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

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x00028425 File Offset: 0x00027425
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x00028437 File Offset: 0x00027437
		[FIXField("390", EFieldOption.Optional)]
		public string BidID
		{
			get
			{
				return this.GetStringField(390).Value;
			}
			set
			{
				this.AddStringField(390, value);
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x00028445 File Offset: 0x00027445
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x00028457 File Offset: 0x00027457
		[FIXField("391", EFieldOption.Required)]
		public string ClientBidID
		{
			get
			{
				return this.GetStringField(391).Value;
			}
			set
			{
				this.AddStringField(391, value);
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00028465 File Offset: 0x00027465
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x00028477 File Offset: 0x00027477
		[FIXField("374", EFieldOption.Required)]
		public char BidRequestTransType
		{
			get
			{
				return this.GetCharField(374).Value;
			}
			set
			{
				this.AddCharField(374, value);
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x00028485 File Offset: 0x00027485
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x00028497 File Offset: 0x00027497
		[FIXField("392", EFieldOption.Optional)]
		public string ListName
		{
			get
			{
				return this.GetStringField(392).Value;
			}
			set
			{
				this.AddStringField(392, value);
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000284A5 File Offset: 0x000274A5
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x000284B7 File Offset: 0x000274B7
		[FIXField("393", EFieldOption.Required)]
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

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000284C5 File Offset: 0x000274C5
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x000284D7 File Offset: 0x000274D7
		[FIXField("394", EFieldOption.Required)]
		public int BidType
		{
			get
			{
				return this.GetIntField(394).Value;
			}
			set
			{
				this.AddIntField(394, value);
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000284E5 File Offset: 0x000274E5
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x000284F7 File Offset: 0x000274F7
		[FIXField("395", EFieldOption.Optional)]
		public int NumTickets
		{
			get
			{
				return this.GetIntField(395).Value;
			}
			set
			{
				this.AddIntField(395, value);
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x00028505 File Offset: 0x00027505
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x00028514 File Offset: 0x00027514
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

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0002851F File Offset: 0x0002751F
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x00028531 File Offset: 0x00027531
		[FIXField("396", EFieldOption.Optional)]
		public double SideValue1
		{
			get
			{
				return this.GetDoubleField(396).Value;
			}
			set
			{
				this.AddDoubleField(396, value);
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0002853F File Offset: 0x0002753F
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x00028551 File Offset: 0x00027551
		[FIXField("397", EFieldOption.Optional)]
		public double SideValue2
		{
			get
			{
				return this.GetDoubleField(397).Value;
			}
			set
			{
				this.AddDoubleField(397, value);
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x0002855F File Offset: 0x0002755F
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x00028571 File Offset: 0x00027571
		[FIXField("398", EFieldOption.Optional)]
		public int NoBidDescriptors
		{
			get
			{
				return this.GetIntField(398).Value;
			}
			set
			{
				this.AddIntField(398, value);
			}
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0002857F File Offset: 0x0002757F
		public FIXBidDescriptorsGroup GetBidDescriptorsGroup(int i)
		{
			if (i < this.NoBidDescriptors)
			{
				return (FIXBidDescriptorsGroup)this.fBidDescriptorsGroup[i];
			}
			return null;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0002859D File Offset: 0x0002759D
		public void AddGroup(FIXBidDescriptorsGroup group)
		{
			this.fBidDescriptorsGroup.Add(group);
			this.NoBidDescriptors++;
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000285BA File Offset: 0x000275BA
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x000285CC File Offset: 0x000275CC
		[FIXField("420", EFieldOption.Optional)]
		public int NoBidComponents
		{
			get
			{
				return this.GetIntField(420).Value;
			}
			set
			{
				this.AddIntField(420, value);
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000285DA File Offset: 0x000275DA
		public FIXBidComponentsGroup GetBidComponentsGroup(int i)
		{
			if (i < this.NoBidComponents)
			{
				return (FIXBidComponentsGroup)this.fBidComponentsGroup[i];
			}
			return null;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000285F8 File Offset: 0x000275F8
		public void AddGroup(FIXBidComponentsGroup group)
		{
			this.fBidComponentsGroup.Add(group);
			this.NoBidComponents++;
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x00028615 File Offset: 0x00027615
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00028627 File Offset: 0x00027627
		[FIXField("409", EFieldOption.Optional)]
		public int LiquidityIndType
		{
			get
			{
				return this.GetIntField(409).Value;
			}
			set
			{
				this.AddIntField(409, value);
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x00028635 File Offset: 0x00027635
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x00028647 File Offset: 0x00027647
		[FIXField("410", EFieldOption.Optional)]
		public double WtAverageLiquidity
		{
			get
			{
				return this.GetDoubleField(410).Value;
			}
			set
			{
				this.AddDoubleField(410, value);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x00028655 File Offset: 0x00027655
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x00028667 File Offset: 0x00027667
		[FIXField("411", EFieldOption.Optional)]
		public bool ExchangeForPhysical
		{
			get
			{
				return this.GetBoolField(411).Value;
			}
			set
			{
				this.AddBoolField(411, value);
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x00028675 File Offset: 0x00027675
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x00028687 File Offset: 0x00027687
		[FIXField("412", EFieldOption.Optional)]
		public double OutMainCntryUIndex
		{
			get
			{
				return this.GetDoubleField(412).Value;
			}
			set
			{
				this.AddDoubleField(412, value);
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x00028695 File Offset: 0x00027695
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x000286A7 File Offset: 0x000276A7
		[FIXField("413", EFieldOption.Optional)]
		public double CrossPercent
		{
			get
			{
				return this.GetDoubleField(413).Value;
			}
			set
			{
				this.AddDoubleField(413, value);
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x000286B5 File Offset: 0x000276B5
		// (set) Token: 0x060025D0 RID: 9680 RVA: 0x000286C7 File Offset: 0x000276C7
		[FIXField("414", EFieldOption.Optional)]
		public int ProgRptReqs
		{
			get
			{
				return this.GetIntField(414).Value;
			}
			set
			{
				this.AddIntField(414, value);
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x000286D5 File Offset: 0x000276D5
		// (set) Token: 0x060025D2 RID: 9682 RVA: 0x000286E7 File Offset: 0x000276E7
		[FIXField("415", EFieldOption.Optional)]
		public int ProgPeriodInterval
		{
			get
			{
				return this.GetIntField(415).Value;
			}
			set
			{
				this.AddIntField(415, value);
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000286F5 File Offset: 0x000276F5
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x00028707 File Offset: 0x00027707
		[FIXField("416", EFieldOption.Optional)]
		public int IncTaxInd
		{
			get
			{
				return this.GetIntField(416).Value;
			}
			set
			{
				this.AddIntField(416, value);
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00028715 File Offset: 0x00027715
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00028724 File Offset: 0x00027724
		[FIXField("121", EFieldOption.Optional)]
		public bool ForexReq
		{
			get
			{
				return this.GetBoolField(121).Value;
			}
			set
			{
				this.AddBoolField(121, value);
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x0002872F File Offset: 0x0002772F
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00028741 File Offset: 0x00027741
		[FIXField("417", EFieldOption.Optional)]
		public int NumBidders
		{
			get
			{
				return this.GetIntField(417).Value;
			}
			set
			{
				this.AddIntField(417, value);
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0002874F File Offset: 0x0002774F
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x0002875E File Offset: 0x0002775E
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

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x00028769 File Offset: 0x00027769
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x0002877B File Offset: 0x0002777B
		[FIXField("418", EFieldOption.Required)]
		public char BidTradeType
		{
			get
			{
				return this.GetCharField(418).Value;
			}
			set
			{
				this.AddCharField(418, value);
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x00028789 File Offset: 0x00027789
		// (set) Token: 0x060025DE RID: 9694 RVA: 0x0002879B File Offset: 0x0002779B
		[FIXField("419", EFieldOption.Required)]
		public char BasisPxType
		{
			get
			{
				return this.GetCharField(419).Value;
			}
			set
			{
				this.AddCharField(419, value);
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000287A9 File Offset: 0x000277A9
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x000287BB File Offset: 0x000277BB
		[FIXField("443", EFieldOption.Optional)]
		public DateTime StrikeTime
		{
			get
			{
				return this.GetDateTimeField(443).Value;
			}
			set
			{
				this.AddDateTimeField(443, value);
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000287C9 File Offset: 0x000277C9
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x000287D8 File Offset: 0x000277D8
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000287E3 File Offset: 0x000277E3
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x000287F5 File Offset: 0x000277F5
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

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x00028803 File Offset: 0x00027803
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x00028815 File Offset: 0x00027815
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

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00028823 File Offset: 0x00027823
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x00028832 File Offset: 0x00027832
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

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x0002883D File Offset: 0x0002783D
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x0002884C File Offset: 0x0002784C
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

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x00028857 File Offset: 0x00027857
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x00028866 File Offset: 0x00027866
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

		// Token: 0x060025ED RID: 9709 RVA: 0x00028871 File Offset: 0x00027871
		public FIXBidRequest()
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000288A8 File Offset: 0x000278A8
		public FIXBidRequest(string ClientBidID, char BidRequestTransType, int TotNoRelatedSym, int BidType, char BidTradeType, char BasisPxType)
		{
			this.ClientBidID = ClientBidID;
			this.BidRequestTransType = BidRequestTransType;
			this.TotNoRelatedSym = TotNoRelatedSym;
			this.BidType = BidType;
			this.BidTradeType = BidTradeType;
			this.BasisPxType = BasisPxType;
		}

		// Token: 0x04000362 RID: 866
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000363 RID: 867
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000364 RID: 868
		private ArrayList fBidDescriptorsGroup = new ArrayList();

		// Token: 0x04000365 RID: 869
		private ArrayList fBidComponentsGroup = new ArrayList();
	}
}
