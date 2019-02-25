using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200015E RID: 350
	public class FIXSecurityStatus : FIXMessage
	{
		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x000470A6 File Offset: 0x000460A6
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x000470B8 File Offset: 0x000460B8
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

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x000470C6 File Offset: 0x000460C6
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x000470D5 File Offset: 0x000460D5
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

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x000470E0 File Offset: 0x000460E0
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x000470EF File Offset: 0x000460EF
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

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x000470FA File Offset: 0x000460FA
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x00047109 File Offset: 0x00046109
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

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x00047114 File Offset: 0x00046114
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x00047123 File Offset: 0x00046123
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

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x0004712E File Offset: 0x0004612E
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x0004713D File Offset: 0x0004613D
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

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x00047148 File Offset: 0x00046148
		// (set) Token: 0x06004100 RID: 16640 RVA: 0x0004715A File Offset: 0x0004615A
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

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x00047168 File Offset: 0x00046168
		// (set) Token: 0x06004102 RID: 16642 RVA: 0x00047177 File Offset: 0x00046177
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

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06004103 RID: 16643 RVA: 0x00047182 File Offset: 0x00046182
		// (set) Token: 0x06004104 RID: 16644 RVA: 0x00047191 File Offset: 0x00046191
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

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x0004719C File Offset: 0x0004619C
		// (set) Token: 0x06004106 RID: 16646 RVA: 0x000471AB File Offset: 0x000461AB
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

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06004107 RID: 16647 RVA: 0x000471B6 File Offset: 0x000461B6
		// (set) Token: 0x06004108 RID: 16648 RVA: 0x000471C5 File Offset: 0x000461C5
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

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x000471D0 File Offset: 0x000461D0
		// (set) Token: 0x0600410A RID: 16650 RVA: 0x000471E2 File Offset: 0x000461E2
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

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x000471F0 File Offset: 0x000461F0
		// (set) Token: 0x0600410C RID: 16652 RVA: 0x000471FF File Offset: 0x000461FF
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

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600410D RID: 16653 RVA: 0x0004720A File Offset: 0x0004620A
		// (set) Token: 0x0600410E RID: 16654 RVA: 0x00047218 File Offset: 0x00046218
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

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600410F RID: 16655 RVA: 0x00047222 File Offset: 0x00046222
		// (set) Token: 0x06004110 RID: 16656 RVA: 0x00047231 File Offset: 0x00046231
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

		// Token: 0x06004111 RID: 16657 RVA: 0x0004723C File Offset: 0x0004623C
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0004724F File Offset: 0x0004624F
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x0004725E File Offset: 0x0004625E
		// (set) Token: 0x06004114 RID: 16660 RVA: 0x00047270 File Offset: 0x00046270
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

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x0004727E File Offset: 0x0004627E
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x00047290 File Offset: 0x00046290
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

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x0004729E File Offset: 0x0004629E
		// (set) Token: 0x06004118 RID: 16664 RVA: 0x000472AD File Offset: 0x000462AD
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

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x000472B8 File Offset: 0x000462B8
		// (set) Token: 0x0600411A RID: 16666 RVA: 0x000472C7 File Offset: 0x000462C7
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

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x000472D2 File Offset: 0x000462D2
		// (set) Token: 0x0600411C RID: 16668 RVA: 0x000472E1 File Offset: 0x000462E1
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

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x000472EC File Offset: 0x000462EC
		// (set) Token: 0x0600411E RID: 16670 RVA: 0x000472FB File Offset: 0x000462FB
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

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x00047306 File Offset: 0x00046306
		// (set) Token: 0x06004120 RID: 16672 RVA: 0x00047318 File Offset: 0x00046318
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

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x00047326 File Offset: 0x00046326
		// (set) Token: 0x06004122 RID: 16674 RVA: 0x00047338 File Offset: 0x00046338
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

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06004123 RID: 16675 RVA: 0x00047346 File Offset: 0x00046346
		// (set) Token: 0x06004124 RID: 16676 RVA: 0x00047358 File Offset: 0x00046358
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

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x00047366 File Offset: 0x00046366
		// (set) Token: 0x06004126 RID: 16678 RVA: 0x00047378 File Offset: 0x00046378
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

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x00047386 File Offset: 0x00046386
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x00047398 File Offset: 0x00046398
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

		// Token: 0x06004129 RID: 16681 RVA: 0x000473A6 File Offset: 0x000463A6
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x000473C4 File Offset: 0x000463C4
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x000473E1 File Offset: 0x000463E1
		// (set) Token: 0x0600412C RID: 16684 RVA: 0x000473F3 File Offset: 0x000463F3
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

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x00047401 File Offset: 0x00046401
		// (set) Token: 0x0600412E RID: 16686 RVA: 0x00047413 File Offset: 0x00046413
		[FIXField("324", EFieldOption.Optional)]
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

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x00047421 File Offset: 0x00046421
		// (set) Token: 0x06004130 RID: 16688 RVA: 0x00047430 File Offset: 0x00046430
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

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x0004743B File Offset: 0x0004643B
		// (set) Token: 0x06004132 RID: 16690 RVA: 0x0004744A File Offset: 0x0004644A
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

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x00047455 File Offset: 0x00046455
		// (set) Token: 0x06004134 RID: 16692 RVA: 0x00047464 File Offset: 0x00046464
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

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x0004746F File Offset: 0x0004646F
		// (set) Token: 0x06004136 RID: 16694 RVA: 0x0004747E File Offset: 0x0004647E
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

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x00047489 File Offset: 0x00046489
		// (set) Token: 0x06004138 RID: 16696 RVA: 0x0004749B File Offset: 0x0004649B
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

		// Token: 0x06004139 RID: 16697 RVA: 0x000474A9 File Offset: 0x000464A9
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x000474C7 File Offset: 0x000464C7
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x000474E4 File Offset: 0x000464E4
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x000474F6 File Offset: 0x000464F6
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

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x00047504 File Offset: 0x00046504
		// (set) Token: 0x0600413E RID: 16702 RVA: 0x00047516 File Offset: 0x00046516
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

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x00047524 File Offset: 0x00046524
		// (set) Token: 0x06004140 RID: 16704 RVA: 0x00047536 File Offset: 0x00046536
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

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x00047544 File Offset: 0x00046544
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x00047556 File Offset: 0x00046556
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

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x00047564 File Offset: 0x00046564
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x00047576 File Offset: 0x00046576
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

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x00047584 File Offset: 0x00046584
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x00047596 File Offset: 0x00046596
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

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x000475A4 File Offset: 0x000465A4
		// (set) Token: 0x06004148 RID: 16712 RVA: 0x000475B6 File Offset: 0x000465B6
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

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x000475C4 File Offset: 0x000465C4
		// (set) Token: 0x0600414A RID: 16714 RVA: 0x000475D6 File Offset: 0x000465D6
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

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x000475E4 File Offset: 0x000465E4
		// (set) Token: 0x0600414C RID: 16716 RVA: 0x000475F6 File Offset: 0x000465F6
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

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x00047604 File Offset: 0x00046604
		// (set) Token: 0x0600414E RID: 16718 RVA: 0x00047616 File Offset: 0x00046616
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

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x00047624 File Offset: 0x00046624
		// (set) Token: 0x06004150 RID: 16720 RVA: 0x00047636 File Offset: 0x00046636
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

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x00047644 File Offset: 0x00046644
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x00047656 File Offset: 0x00046656
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

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x00047664 File Offset: 0x00046664
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x00047676 File Offset: 0x00046676
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

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x00047684 File Offset: 0x00046684
		// (set) Token: 0x06004156 RID: 16726 RVA: 0x00047696 File Offset: 0x00046696
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

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x000476A4 File Offset: 0x000466A4
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x000476B6 File Offset: 0x000466B6
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

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x000476C4 File Offset: 0x000466C4
		// (set) Token: 0x0600415A RID: 16730 RVA: 0x000476D6 File Offset: 0x000466D6
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

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x000476E4 File Offset: 0x000466E4
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x000476F6 File Offset: 0x000466F6
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

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x00047704 File Offset: 0x00046704
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x00047716 File Offset: 0x00046716
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

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00047724 File Offset: 0x00046724
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x00047736 File Offset: 0x00046736
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

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00047744 File Offset: 0x00046744
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x00047756 File Offset: 0x00046756
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

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00047764 File Offset: 0x00046764
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x00047776 File Offset: 0x00046776
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

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x00047784 File Offset: 0x00046784
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x00047796 File Offset: 0x00046796
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

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x000477A4 File Offset: 0x000467A4
		// (set) Token: 0x06004168 RID: 16744 RVA: 0x000477B6 File Offset: 0x000467B6
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

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x000477C4 File Offset: 0x000467C4
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x000477D6 File Offset: 0x000467D6
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

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x000477E4 File Offset: 0x000467E4
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x000477F3 File Offset: 0x000467F3
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

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x000477FE File Offset: 0x000467FE
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x00047810 File Offset: 0x00046810
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

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x0004781E File Offset: 0x0004681E
		// (set) Token: 0x06004170 RID: 16752 RVA: 0x00047830 File Offset: 0x00046830
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

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x0004783E File Offset: 0x0004683E
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x0004784D File Offset: 0x0004684D
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

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x00047858 File Offset: 0x00046858
		// (set) Token: 0x06004174 RID: 16756 RVA: 0x0004786A File Offset: 0x0004686A
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

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x00047878 File Offset: 0x00046878
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x0004788A File Offset: 0x0004688A
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

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x00047898 File Offset: 0x00046898
		// (set) Token: 0x06004178 RID: 16760 RVA: 0x000478AA File Offset: 0x000468AA
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

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x000478B8 File Offset: 0x000468B8
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x000478CA File Offset: 0x000468CA
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

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x000478D8 File Offset: 0x000468D8
		// (set) Token: 0x0600417C RID: 16764 RVA: 0x000478EA File Offset: 0x000468EA
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

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x000478F8 File Offset: 0x000468F8
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x0004790A File Offset: 0x0004690A
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

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x00047918 File Offset: 0x00046918
		// (set) Token: 0x06004180 RID: 16768 RVA: 0x0004792A File Offset: 0x0004692A
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

		// Token: 0x06004181 RID: 16769 RVA: 0x00047938 File Offset: 0x00046938
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00047956 File Offset: 0x00046956
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x00047973 File Offset: 0x00046973
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x00047985 File Offset: 0x00046985
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

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x00047993 File Offset: 0x00046993
		// (set) Token: 0x06004186 RID: 16774 RVA: 0x000479A5 File Offset: 0x000469A5
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

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x000479B3 File Offset: 0x000469B3
		// (set) Token: 0x06004188 RID: 16776 RVA: 0x000479C5 File Offset: 0x000469C5
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

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x000479D3 File Offset: 0x000469D3
		// (set) Token: 0x0600418A RID: 16778 RVA: 0x000479E5 File Offset: 0x000469E5
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

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x000479F3 File Offset: 0x000469F3
		// (set) Token: 0x0600418C RID: 16780 RVA: 0x00047A05 File Offset: 0x00046A05
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

		// Token: 0x0600418D RID: 16781 RVA: 0x00047A13 File Offset: 0x00046A13
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00047A31 File Offset: 0x00046A31
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x00047A4E File Offset: 0x00046A4E
		// (set) Token: 0x06004190 RID: 16784 RVA: 0x00047A60 File Offset: 0x00046A60
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

		// Token: 0x06004191 RID: 16785 RVA: 0x00047A6E File Offset: 0x00046A6E
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00047A8C File Offset: 0x00046A8C
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x00047AA9 File Offset: 0x00046AA9
		// (set) Token: 0x06004194 RID: 16788 RVA: 0x00047ABB File Offset: 0x00046ABB
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

		// Token: 0x06004195 RID: 16789 RVA: 0x00047AC9 File Offset: 0x00046AC9
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x00047AE7 File Offset: 0x00046AE7
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06004197 RID: 16791 RVA: 0x00047B04 File Offset: 0x00046B04
		// (set) Token: 0x06004198 RID: 16792 RVA: 0x00047B13 File Offset: 0x00046B13
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

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06004199 RID: 16793 RVA: 0x00047B1E File Offset: 0x00046B1E
		// (set) Token: 0x0600419A RID: 16794 RVA: 0x00047B30 File Offset: 0x00046B30
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

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x00047B3E File Offset: 0x00046B3E
		// (set) Token: 0x0600419C RID: 16796 RVA: 0x00047B50 File Offset: 0x00046B50
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

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x00047B5E File Offset: 0x00046B5E
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x00047B70 File Offset: 0x00046B70
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

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x00047B7E File Offset: 0x00046B7E
		// (set) Token: 0x060041A0 RID: 16800 RVA: 0x00047B90 File Offset: 0x00046B90
		[FIXField("326", EFieldOption.Optional)]
		public int SecurityTradingStatus
		{
			get
			{
				return this.GetIntField(326).Value;
			}
			set
			{
				this.AddIntField(326, value);
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x00047B9E File Offset: 0x00046B9E
		// (set) Token: 0x060041A2 RID: 16802 RVA: 0x00047BB0 File Offset: 0x00046BB0
		[FIXField("291", EFieldOption.Optional)]
		public string FinancialStatus
		{
			get
			{
				return this.GetStringField(291).Value;
			}
			set
			{
				this.AddStringField(291, value);
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x00047BBE File Offset: 0x00046BBE
		// (set) Token: 0x060041A4 RID: 16804 RVA: 0x00047BD0 File Offset: 0x00046BD0
		[FIXField("292", EFieldOption.Optional)]
		public string CorporateAction
		{
			get
			{
				return this.GetStringField(292).Value;
			}
			set
			{
				this.AddStringField(292, value);
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x00047BDE File Offset: 0x00046BDE
		// (set) Token: 0x060041A6 RID: 16806 RVA: 0x00047BF0 File Offset: 0x00046BF0
		[FIXField("327", EFieldOption.Optional)]
		public char HaltReason
		{
			get
			{
				return this.GetCharField(327).Value;
			}
			set
			{
				this.AddCharField(327, value);
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x00047BFE File Offset: 0x00046BFE
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x00047C10 File Offset: 0x00046C10
		[FIXField("328", EFieldOption.Optional)]
		public bool InViewOfCommon
		{
			get
			{
				return this.GetBoolField(328).Value;
			}
			set
			{
				this.AddBoolField(328, value);
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x00047C1E File Offset: 0x00046C1E
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x00047C30 File Offset: 0x00046C30
		[FIXField("329", EFieldOption.Optional)]
		public bool DueToRelated
		{
			get
			{
				return this.GetBoolField(329).Value;
			}
			set
			{
				this.AddBoolField(329, value);
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x00047C3E File Offset: 0x00046C3E
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x00047C50 File Offset: 0x00046C50
		[FIXField("330", EFieldOption.Optional)]
		public double BuyVolume
		{
			get
			{
				return this.GetDoubleField(330).Value;
			}
			set
			{
				this.AddDoubleField(330, value);
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00047C5E File Offset: 0x00046C5E
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x00047C70 File Offset: 0x00046C70
		[FIXField("331", EFieldOption.Optional)]
		public double SellVolume
		{
			get
			{
				return this.GetDoubleField(331).Value;
			}
			set
			{
				this.AddDoubleField(331, value);
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x00047C7E File Offset: 0x00046C7E
		// (set) Token: 0x060041B0 RID: 16816 RVA: 0x00047C90 File Offset: 0x00046C90
		[FIXField("332", EFieldOption.Optional)]
		public double HighPx
		{
			get
			{
				return this.GetDoubleField(332).Value;
			}
			set
			{
				this.AddDoubleField(332, value);
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x00047C9E File Offset: 0x00046C9E
		// (set) Token: 0x060041B2 RID: 16818 RVA: 0x00047CB0 File Offset: 0x00046CB0
		[FIXField("333", EFieldOption.Optional)]
		public double LowPx
		{
			get
			{
				return this.GetDoubleField(333).Value;
			}
			set
			{
				this.AddDoubleField(333, value);
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x00047CBE File Offset: 0x00046CBE
		// (set) Token: 0x060041B4 RID: 16820 RVA: 0x00047CCD File Offset: 0x00046CCD
		[FIXField("31", EFieldOption.Optional)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleField(31).Value;
			}
			set
			{
				this.AddDoubleField(31, value);
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x00047CD8 File Offset: 0x00046CD8
		// (set) Token: 0x060041B6 RID: 16822 RVA: 0x00047CE7 File Offset: 0x00046CE7
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

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x00047CF2 File Offset: 0x00046CF2
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x00047D04 File Offset: 0x00046D04
		[FIXField("334", EFieldOption.Optional)]
		public int Adjustment
		{
			get
			{
				return this.GetIntField(334).Value;
			}
			set
			{
				this.AddIntField(334, value);
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x00047D12 File Offset: 0x00046D12
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x00047D21 File Offset: 0x00046D21
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

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x00047D2C File Offset: 0x00046D2C
		// (set) Token: 0x060041BC RID: 16828 RVA: 0x00047D3E File Offset: 0x00046D3E
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

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x060041BD RID: 16829 RVA: 0x00047D4C File Offset: 0x00046D4C
		// (set) Token: 0x060041BE RID: 16830 RVA: 0x00047D5E File Offset: 0x00046D5E
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

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x060041BF RID: 16831 RVA: 0x00047D6C File Offset: 0x00046D6C
		// (set) Token: 0x060041C0 RID: 16832 RVA: 0x00047D7B File Offset: 0x00046D7B
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

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x00047D86 File Offset: 0x00046D86
		// (set) Token: 0x060041C2 RID: 16834 RVA: 0x00047D95 File Offset: 0x00046D95
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

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x00047DA0 File Offset: 0x00046DA0
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x00047DAF File Offset: 0x00046DAF
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

		// Token: 0x04000995 RID: 2453
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000996 RID: 2454
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000997 RID: 2455
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000998 RID: 2456
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000999 RID: 2457
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x0400099A RID: 2458
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400099B RID: 2459
		private ArrayList fLegsGroup = new ArrayList();
	}
}
