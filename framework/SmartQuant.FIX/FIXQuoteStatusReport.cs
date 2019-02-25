using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200007B RID: 123
	public class FIXQuoteStatusReport : FIXMessage
	{
		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00018541 File Offset: 0x00017541
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00018553 File Offset: 0x00017553
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

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00018561 File Offset: 0x00017561
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x00018570 File Offset: 0x00017570
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

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0001857B File Offset: 0x0001757B
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0001858A File Offset: 0x0001758A
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00018595 File Offset: 0x00017595
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x000185A4 File Offset: 0x000175A4
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x000185AF File Offset: 0x000175AF
		// (set) Token: 0x060015C6 RID: 5574 RVA: 0x000185BE File Offset: 0x000175BE
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x000185C9 File Offset: 0x000175C9
		// (set) Token: 0x060015C8 RID: 5576 RVA: 0x000185D8 File Offset: 0x000175D8
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x000185E3 File Offset: 0x000175E3
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x000185F5 File Offset: 0x000175F5
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00018603 File Offset: 0x00017603
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x00018612 File Offset: 0x00017612
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

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x0001861D File Offset: 0x0001761D
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x0001862C File Offset: 0x0001762C
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

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00018637 File Offset: 0x00017637
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x00018646 File Offset: 0x00017646
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

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00018651 File Offset: 0x00017651
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00018660 File Offset: 0x00017660
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0001866B File Offset: 0x0001766B
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x0001867D File Offset: 0x0001767D
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0001868B File Offset: 0x0001768B
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x0001869A File Offset: 0x0001769A
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

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x000186A5 File Offset: 0x000176A5
		// (set) Token: 0x060015D8 RID: 5592 RVA: 0x000186B3 File Offset: 0x000176B3
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x000186BD File Offset: 0x000176BD
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x000186CC File Offset: 0x000176CC
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

		// Token: 0x060015DB RID: 5595 RVA: 0x000186D7 File Offset: 0x000176D7
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000186EA File Offset: 0x000176EA
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x000186F9 File Offset: 0x000176F9
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x0001870B File Offset: 0x0001770B
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

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00018719 File Offset: 0x00017719
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0001872B File Offset: 0x0001772B
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

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00018739 File Offset: 0x00017739
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00018748 File Offset: 0x00017748
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

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00018753 File Offset: 0x00017753
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00018762 File Offset: 0x00017762
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0001876D File Offset: 0x0001776D
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0001877C File Offset: 0x0001777C
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

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00018787 File Offset: 0x00017787
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x00018796 File Offset: 0x00017796
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

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000187A1 File Offset: 0x000177A1
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x000187B3 File Offset: 0x000177B3
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

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x000187C1 File Offset: 0x000177C1
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x000187D3 File Offset: 0x000177D3
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

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x000187E1 File Offset: 0x000177E1
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x000187F3 File Offset: 0x000177F3
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

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00018801 File Offset: 0x00017801
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00018813 File Offset: 0x00017813
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

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00018821 File Offset: 0x00017821
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00018833 File Offset: 0x00017833
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

		// Token: 0x060015F3 RID: 5619 RVA: 0x00018841 File Offset: 0x00017841
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0001885F File Offset: 0x0001785F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0001887C File Offset: 0x0001787C
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0001888E File Offset: 0x0001788E
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

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0001889C File Offset: 0x0001789C
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x000188AE File Offset: 0x000178AE
		[FIXField("649", EFieldOption.Optional)]
		public string QuoteStatusReqID
		{
			get
			{
				return this.GetStringField(649).Value;
			}
			set
			{
				this.AddStringField(649, value);
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000188BC File Offset: 0x000178BC
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x000188CE File Offset: 0x000178CE
		[FIXField("131", EFieldOption.Optional)]
		public string QuoteReqID
		{
			get
			{
				return this.GetStringField(131).Value;
			}
			set
			{
				this.AddStringField(131, value);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x000188DC File Offset: 0x000178DC
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x000188EB File Offset: 0x000178EB
		[FIXField("117", EFieldOption.Required)]
		public string QuoteID
		{
			get
			{
				return this.GetStringField(117).Value;
			}
			set
			{
				this.AddStringField(117, value);
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x000188F6 File Offset: 0x000178F6
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x00018908 File Offset: 0x00017908
		[FIXField("693", EFieldOption.Optional)]
		public string QuoteRespID
		{
			get
			{
				return this.GetStringField(693).Value;
			}
			set
			{
				this.AddStringField(693, value);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00018916 File Offset: 0x00017916
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x00018928 File Offset: 0x00017928
		[FIXField("537", EFieldOption.Optional)]
		public int QuoteType
		{
			get
			{
				return this.GetIntField(537).Value;
			}
			set
			{
				this.AddIntField(537, value);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00018936 File Offset: 0x00017936
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00018948 File Offset: 0x00017948
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

		// Token: 0x06001603 RID: 5635 RVA: 0x00018956 File Offset: 0x00017956
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00018974 File Offset: 0x00017974
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00018991 File Offset: 0x00017991
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x000189A3 File Offset: 0x000179A3
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x000189B1 File Offset: 0x000179B1
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x000189C3 File Offset: 0x000179C3
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x000189D1 File Offset: 0x000179D1
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x000189E0 File Offset: 0x000179E0
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x000189EB File Offset: 0x000179EB
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x000189FA File Offset: 0x000179FA
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00018A05 File Offset: 0x00017A05
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x00018A14 File Offset: 0x00017A14
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

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00018A1F File Offset: 0x00017A1F
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x00018A2E File Offset: 0x00017A2E
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

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00018A39 File Offset: 0x00017A39
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00018A4B File Offset: 0x00017A4B
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

		// Token: 0x06001613 RID: 5651 RVA: 0x00018A59 File Offset: 0x00017A59
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00018A77 File Offset: 0x00017A77
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00018A94 File Offset: 0x00017A94
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00018AA6 File Offset: 0x00017AA6
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

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00018AB4 File Offset: 0x00017AB4
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00018AC6 File Offset: 0x00017AC6
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00018AD4 File Offset: 0x00017AD4
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00018AE6 File Offset: 0x00017AE6
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00018AF4 File Offset: 0x00017AF4
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x00018B06 File Offset: 0x00017B06
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00018B14 File Offset: 0x00017B14
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00018B26 File Offset: 0x00017B26
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00018B34 File Offset: 0x00017B34
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x00018B46 File Offset: 0x00017B46
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

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00018B54 File Offset: 0x00017B54
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00018B66 File Offset: 0x00017B66
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

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00018B74 File Offset: 0x00017B74
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00018B86 File Offset: 0x00017B86
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

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00018B94 File Offset: 0x00017B94
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x00018BA6 File Offset: 0x00017BA6
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

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00018BB4 File Offset: 0x00017BB4
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00018BC6 File Offset: 0x00017BC6
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

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00018BD4 File Offset: 0x00017BD4
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00018BE6 File Offset: 0x00017BE6
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00018BF4 File Offset: 0x00017BF4
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00018C06 File Offset: 0x00017C06
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

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00018C14 File Offset: 0x00017C14
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x00018C26 File Offset: 0x00017C26
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

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00018C34 File Offset: 0x00017C34
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00018C46 File Offset: 0x00017C46
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

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00018C54 File Offset: 0x00017C54
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00018C66 File Offset: 0x00017C66
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

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00018C74 File Offset: 0x00017C74
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x00018C86 File Offset: 0x00017C86
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

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00018C94 File Offset: 0x00017C94
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x00018CA6 File Offset: 0x00017CA6
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

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00018CB4 File Offset: 0x00017CB4
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x00018CC6 File Offset: 0x00017CC6
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

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00018CD4 File Offset: 0x00017CD4
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x00018CE6 File Offset: 0x00017CE6
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

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x00018CF4 File Offset: 0x00017CF4
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x00018D06 File Offset: 0x00017D06
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

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00018D14 File Offset: 0x00017D14
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x00018D26 File Offset: 0x00017D26
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x00018D34 File Offset: 0x00017D34
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x00018D46 File Offset: 0x00017D46
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

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x00018D54 File Offset: 0x00017D54
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x00018D66 File Offset: 0x00017D66
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

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00018D74 File Offset: 0x00017D74
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x00018D86 File Offset: 0x00017D86
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x00018D94 File Offset: 0x00017D94
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x00018DA3 File Offset: 0x00017DA3
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00018DAE File Offset: 0x00017DAE
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x00018DC0 File Offset: 0x00017DC0
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00018DCE File Offset: 0x00017DCE
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x00018DE0 File Offset: 0x00017DE0
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

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00018DEE File Offset: 0x00017DEE
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x00018DFD File Offset: 0x00017DFD
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00018E08 File Offset: 0x00017E08
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x00018E1A File Offset: 0x00017E1A
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

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00018E28 File Offset: 0x00017E28
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x00018E3A File Offset: 0x00017E3A
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

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x00018E48 File Offset: 0x00017E48
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x00018E5A File Offset: 0x00017E5A
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

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x00018E68 File Offset: 0x00017E68
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x00018E7A File Offset: 0x00017E7A
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

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x00018E88 File Offset: 0x00017E88
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x00018E9A File Offset: 0x00017E9A
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

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00018EA8 File Offset: 0x00017EA8
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x00018EBA File Offset: 0x00017EBA
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

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00018EC8 File Offset: 0x00017EC8
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00018EDA File Offset: 0x00017EDA
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

		// Token: 0x0600165B RID: 5723 RVA: 0x00018EE8 File Offset: 0x00017EE8
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00018F06 File Offset: 0x00017F06
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00018F23 File Offset: 0x00017F23
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x00018F35 File Offset: 0x00017F35
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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00018F43 File Offset: 0x00017F43
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00018F55 File Offset: 0x00017F55
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00018F63 File Offset: 0x00017F63
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00018F75 File Offset: 0x00017F75
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00018F83 File Offset: 0x00017F83
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00018F95 File Offset: 0x00017F95
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

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00018FA3 File Offset: 0x00017FA3
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x00018FB5 File Offset: 0x00017FB5
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

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00018FC3 File Offset: 0x00017FC3
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00018FD5 File Offset: 0x00017FD5
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00018FE3 File Offset: 0x00017FE3
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x00018FF5 File Offset: 0x00017FF5
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00019003 File Offset: 0x00018003
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00019015 File Offset: 0x00018015
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

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00019023 File Offset: 0x00018023
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00019035 File Offset: 0x00018035
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

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00019043 File Offset: 0x00018043
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x00019055 File Offset: 0x00018055
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

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00019063 File Offset: 0x00018063
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x00019075 File Offset: 0x00018075
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

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00019083 File Offset: 0x00018083
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x00019095 File Offset: 0x00018095
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

		// Token: 0x06001675 RID: 5749 RVA: 0x000190A3 File Offset: 0x000180A3
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000190C1 File Offset: 0x000180C1
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x000190DE File Offset: 0x000180DE
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x000190ED File Offset: 0x000180ED
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

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x000190F8 File Offset: 0x000180F8
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x00019107 File Offset: 0x00018107
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleField(38).Value;
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00019112 File Offset: 0x00018112
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x00019124 File Offset: 0x00018124
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleField(152).Value;
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00019132 File Offset: 0x00018132
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x00019144 File Offset: 0x00018144
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleField(516).Value;
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00019152 File Offset: 0x00018152
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x00019164 File Offset: 0x00018164
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharField(468).Value;
			}
			set
			{
				this.AddCharField(468, value);
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00019172 File Offset: 0x00018172
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x00019184 File Offset: 0x00018184
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleField(469).Value;
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00019192 File Offset: 0x00018192
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x000191A1 File Offset: 0x000181A1
		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharField(63).Value;
			}
			set
			{
				this.AddCharField(63, value);
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x000191AC File Offset: 0x000181AC
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x000191BB File Offset: 0x000181BB
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

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x000191C6 File Offset: 0x000181C6
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x000191D8 File Offset: 0x000181D8
		[FIXField("193", EFieldOption.Optional)]
		public DateTime SettlDate2
		{
			get
			{
				return this.GetDateTimeField(193).Value;
			}
			set
			{
				this.AddDateTimeField(193, value);
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x000191E6 File Offset: 0x000181E6
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x000191F8 File Offset: 0x000181F8
		[FIXField("192", EFieldOption.Optional)]
		public double OrderQty2
		{
			get
			{
				return this.GetDoubleField(192).Value;
			}
			set
			{
				this.AddDoubleField(192, value);
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x00019206 File Offset: 0x00018206
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x00019215 File Offset: 0x00018215
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

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x00019220 File Offset: 0x00018220
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x00019232 File Offset: 0x00018232
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntField(232).Value;
			}
			set
			{
				this.AddIntField(232, value);
			}
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00019240 File Offset: 0x00018240
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0001925E File Offset: 0x0001825E
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x0001927B File Offset: 0x0001827B
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00019289 File Offset: 0x00018289
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

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00019293 File Offset: 0x00018293
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x000192A5 File Offset: 0x000182A5
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

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x000192B3 File Offset: 0x000182B3
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x000192C5 File Offset: 0x000182C5
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

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x000192D3 File Offset: 0x000182D3
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x000192E5 File Offset: 0x000182E5
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

		// Token: 0x06001699 RID: 5785 RVA: 0x000192F3 File Offset: 0x000182F3
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00019311 File Offset: 0x00018311
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x0001932E File Offset: 0x0001832E
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00019340 File Offset: 0x00018340
		[FIXField("735", EFieldOption.Optional)]
		public int NoQuoteQualifiers
		{
			get
			{
				return this.GetIntField(735).Value;
			}
			set
			{
				this.AddIntField(735, value);
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0001934E File Offset: 0x0001834E
		public FIXQuoteQualifiersGroup GetQuoteQualifiersGroup(int i)
		{
			if (i < this.NoQuoteQualifiers)
			{
				return (FIXQuoteQualifiersGroup)this.fQuoteQualifiersGroup[i];
			}
			return null;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0001936C File Offset: 0x0001836C
		public void AddGroup(FIXQuoteQualifiersGroup group)
		{
			this.fQuoteQualifiersGroup.Add(group);
			this.NoQuoteQualifiers++;
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00019389 File Offset: 0x00018389
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x00019398 File Offset: 0x00018398
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeField(126).Value;
			}
			set
			{
				this.AddDateTimeField(126, value);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x000193A3 File Offset: 0x000183A3
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x000193B2 File Offset: 0x000183B2
		[FIXField("44", EFieldOption.Optional)]
		public double Price
		{
			get
			{
				return this.GetDoubleField(44).Value;
			}
			set
			{
				this.AddDoubleField(44, value);
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x000193BD File Offset: 0x000183BD
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x000193CF File Offset: 0x000183CF
		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntField(423).Value;
			}
			set
			{
				this.AddIntField(423, value);
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x000193DD File Offset: 0x000183DD
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x000193EF File Offset: 0x000183EF
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleField(218).Value;
			}
			set
			{
				this.AddDoubleField(218, value);
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x000193FD File Offset: 0x000183FD
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0001940F File Offset: 0x0001840F
		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleField(220).Value;
			}
			set
			{
				this.AddDoubleField(220, value);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0001941D File Offset: 0x0001841D
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x0001942F File Offset: 0x0001842F
		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringField(221).Value;
			}
			set
			{
				this.AddStringField(221, value);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x0001943D File Offset: 0x0001843D
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x0001944F File Offset: 0x0001844F
		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringField(222).Value;
			}
			set
			{
				this.AddStringField(222, value);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0001945D File Offset: 0x0001845D
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x0001946F File Offset: 0x0001846F
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleField(662).Value;
			}
			set
			{
				this.AddDoubleField(662, value);
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x0001947D File Offset: 0x0001847D
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0001948F File Offset: 0x0001848F
		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntField(663).Value;
			}
			set
			{
				this.AddIntField(663, value);
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0001949D File Offset: 0x0001849D
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x000194AF File Offset: 0x000184AF
		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringField(699).Value;
			}
			set
			{
				this.AddStringField(699, value);
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x000194BD File Offset: 0x000184BD
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x000194CF File Offset: 0x000184CF
		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringField(761).Value;
			}
			set
			{
				this.AddStringField(761, value);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x000194DD File Offset: 0x000184DD
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x000194EF File Offset: 0x000184EF
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringField(235).Value;
			}
			set
			{
				this.AddStringField(235, value);
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000194FD File Offset: 0x000184FD
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x0001950F File Offset: 0x0001850F
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleField(236).Value;
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0001951D File Offset: 0x0001851D
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x0001952F File Offset: 0x0001852F
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeField(701).Value;
			}
			set
			{
				this.AddDateTimeField(701, value);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x0001953D File Offset: 0x0001853D
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x0001954F File Offset: 0x0001854F
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(696).Value;
			}
			set
			{
				this.AddDateTimeField(696, value);
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x0001955D File Offset: 0x0001855D
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x0001956F File Offset: 0x0001856F
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleField(697).Value;
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x0001957D File Offset: 0x0001857D
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x0001958F File Offset: 0x0001858F
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntField(698).Value;
			}
			set
			{
				this.AddIntField(698, value);
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0001959D File Offset: 0x0001859D
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x000195AF File Offset: 0x000185AF
		[FIXField("132", EFieldOption.Optional)]
		public double BidPx
		{
			get
			{
				return this.GetDoubleField(132).Value;
			}
			set
			{
				this.AddDoubleField(132, value);
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x000195BD File Offset: 0x000185BD
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x000195CF File Offset: 0x000185CF
		[FIXField("133", EFieldOption.Optional)]
		public double OfferPx
		{
			get
			{
				return this.GetDoubleField(133).Value;
			}
			set
			{
				this.AddDoubleField(133, value);
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x000195DD File Offset: 0x000185DD
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x000195EF File Offset: 0x000185EF
		[FIXField("645", EFieldOption.Optional)]
		public double MktBidPx
		{
			get
			{
				return this.GetDoubleField(645).Value;
			}
			set
			{
				this.AddDoubleField(645, value);
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000195FD File Offset: 0x000185FD
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0001960F File Offset: 0x0001860F
		[FIXField("646", EFieldOption.Optional)]
		public double MktOfferPx
		{
			get
			{
				return this.GetDoubleField(646).Value;
			}
			set
			{
				this.AddDoubleField(646, value);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x0001961D File Offset: 0x0001861D
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x0001962F File Offset: 0x0001862F
		[FIXField("647", EFieldOption.Optional)]
		public double MinBidSize
		{
			get
			{
				return this.GetDoubleField(647).Value;
			}
			set
			{
				this.AddDoubleField(647, value);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x0001963D File Offset: 0x0001863D
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x0001964F File Offset: 0x0001864F
		[FIXField("134", EFieldOption.Optional)]
		public double BidSize
		{
			get
			{
				return this.GetDoubleField(134).Value;
			}
			set
			{
				this.AddDoubleField(134, value);
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0001965D File Offset: 0x0001865D
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x0001966F File Offset: 0x0001866F
		[FIXField("648", EFieldOption.Optional)]
		public double MinOfferSize
		{
			get
			{
				return this.GetDoubleField(648).Value;
			}
			set
			{
				this.AddDoubleField(648, value);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x0001967D File Offset: 0x0001867D
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0001968F File Offset: 0x0001868F
		[FIXField("135", EFieldOption.Optional)]
		public double OfferSize
		{
			get
			{
				return this.GetDoubleField(135).Value;
			}
			set
			{
				this.AddDoubleField(135, value);
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0001969D File Offset: 0x0001869D
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x000196AC File Offset: 0x000186AC
		[FIXField("62", EFieldOption.Optional)]
		public DateTime ValidUntilTime
		{
			get
			{
				return this.GetDateTimeField(62).Value;
			}
			set
			{
				this.AddDateTimeField(62, value);
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x000196B7 File Offset: 0x000186B7
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x000196C9 File Offset: 0x000186C9
		[FIXField("188", EFieldOption.Optional)]
		public double BidSpotRate
		{
			get
			{
				return this.GetDoubleField(188).Value;
			}
			set
			{
				this.AddDoubleField(188, value);
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000196D7 File Offset: 0x000186D7
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x000196E9 File Offset: 0x000186E9
		[FIXField("190", EFieldOption.Optional)]
		public double OfferSpotRate
		{
			get
			{
				return this.GetDoubleField(190).Value;
			}
			set
			{
				this.AddDoubleField(190, value);
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x000196F7 File Offset: 0x000186F7
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00019709 File Offset: 0x00018709
		[FIXField("189", EFieldOption.Optional)]
		public double BidForwardPoints
		{
			get
			{
				return this.GetDoubleField(189).Value;
			}
			set
			{
				this.AddDoubleField(189, value);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00019717 File Offset: 0x00018717
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00019729 File Offset: 0x00018729
		[FIXField("191", EFieldOption.Optional)]
		public double OfferForwardPoints
		{
			get
			{
				return this.GetDoubleField(191).Value;
			}
			set
			{
				this.AddDoubleField(191, value);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00019737 File Offset: 0x00018737
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00019749 File Offset: 0x00018749
		[FIXField("631", EFieldOption.Optional)]
		public double MidPx
		{
			get
			{
				return this.GetDoubleField(631).Value;
			}
			set
			{
				this.AddDoubleField(631, value);
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00019757 File Offset: 0x00018757
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00019769 File Offset: 0x00018769
		[FIXField("632", EFieldOption.Optional)]
		public double BidYield
		{
			get
			{
				return this.GetDoubleField(632).Value;
			}
			set
			{
				this.AddDoubleField(632, value);
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00019777 File Offset: 0x00018777
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00019789 File Offset: 0x00018789
		[FIXField("633", EFieldOption.Optional)]
		public double MidYield
		{
			get
			{
				return this.GetDoubleField(633).Value;
			}
			set
			{
				this.AddDoubleField(633, value);
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00019797 File Offset: 0x00018797
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x000197A9 File Offset: 0x000187A9
		[FIXField("634", EFieldOption.Optional)]
		public double OfferYield
		{
			get
			{
				return this.GetDoubleField(634).Value;
			}
			set
			{
				this.AddDoubleField(634, value);
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x000197B7 File Offset: 0x000187B7
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x000197C6 File Offset: 0x000187C6
		[FIXField("60", EFieldOption.Optional)]
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

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x000197D1 File Offset: 0x000187D1
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x000197E0 File Offset: 0x000187E0
		[FIXField("40", EFieldOption.Optional)]
		public char OrdType
		{
			get
			{
				return this.GetCharField(40).Value;
			}
			set
			{
				this.AddCharField(40, value);
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x000197EB File Offset: 0x000187EB
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x000197FD File Offset: 0x000187FD
		[FIXField("642", EFieldOption.Optional)]
		public double BidForwardPoints2
		{
			get
			{
				return this.GetDoubleField(642).Value;
			}
			set
			{
				this.AddDoubleField(642, value);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0001980B File Offset: 0x0001880B
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x0001981D File Offset: 0x0001881D
		[FIXField("643", EFieldOption.Optional)]
		public double OfferForwardPoints2
		{
			get
			{
				return this.GetDoubleField(643).Value;
			}
			set
			{
				this.AddDoubleField(643, value);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x0001982B File Offset: 0x0001882B
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x0001983D File Offset: 0x0001883D
		[FIXField("656", EFieldOption.Optional)]
		public double SettlCurrBidFxRate
		{
			get
			{
				return this.GetDoubleField(656).Value;
			}
			set
			{
				this.AddDoubleField(656, value);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0001984B File Offset: 0x0001884B
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x0001985D File Offset: 0x0001885D
		[FIXField("657", EFieldOption.Optional)]
		public double SettlCurrOfferFxRate
		{
			get
			{
				return this.GetDoubleField(657).Value;
			}
			set
			{
				this.AddDoubleField(657, value);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0001986B File Offset: 0x0001886B
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0001987D File Offset: 0x0001887D
		[FIXField("156", EFieldOption.Optional)]
		public char SettlCurrFxRateCalc
		{
			get
			{
				return this.GetCharField(156).Value;
			}
			set
			{
				this.AddCharField(156, value);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0001988B File Offset: 0x0001888B
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x0001989A File Offset: 0x0001889A
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharField(13).Value;
			}
			set
			{
				this.AddCharField(13, value);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x000198A5 File Offset: 0x000188A5
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x000198B4 File Offset: 0x000188B4
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleField(12).Value;
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000198BF File Offset: 0x000188BF
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x000198D1 File Offset: 0x000188D1
		[FIXField("582", EFieldOption.Optional)]
		public int CustOrderCapacity
		{
			get
			{
				return this.GetIntField(582).Value;
			}
			set
			{
				this.AddIntField(582, value);
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x000198DF File Offset: 0x000188DF
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x000198EE File Offset: 0x000188EE
		[FIXField("100", EFieldOption.Optional)]
		public string ExDestination
		{
			get
			{
				return this.GetStringField(100).Value;
			}
			set
			{
				this.AddStringField(100, value);
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000198F9 File Offset: 0x000188F9
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x0001990B File Offset: 0x0001890B
		[FIXField("297", EFieldOption.Optional)]
		public int QuoteStatus
		{
			get
			{
				return this.GetIntField(297).Value;
			}
			set
			{
				this.AddIntField(297, value);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00019919 File Offset: 0x00018919
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x00019928 File Offset: 0x00018928
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

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00019933 File Offset: 0x00018933
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00019945 File Offset: 0x00018945
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

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00019953 File Offset: 0x00018953
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x00019965 File Offset: 0x00018965
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00019973 File Offset: 0x00018973
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x00019982 File Offset: 0x00018982
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

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0001998D File Offset: 0x0001898D
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x0001999C File Offset: 0x0001899C
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

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x000199A7 File Offset: 0x000189A7
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x000199B6 File Offset: 0x000189B6
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

		// Token: 0x06001707 RID: 5895 RVA: 0x000199C4 File Offset: 0x000189C4
		public FIXQuoteStatusReport()
		{
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00019A3C File Offset: 0x00018A3C
		public FIXQuoteStatusReport(string QuoteID)
		{
			this.QuoteID = QuoteID;
		}

		// Token: 0x04000290 RID: 656
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000291 RID: 657
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000292 RID: 658
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000293 RID: 659
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000294 RID: 660
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000295 RID: 661
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000296 RID: 662
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000297 RID: 663
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000298 RID: 664
		private ArrayList fQuoteQualifiersGroup = new ArrayList();
	}
}
