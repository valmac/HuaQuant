using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200000B RID: 11
	public class FIXAllocationInstruction : FIXMessage
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00005506 File Offset: 0x00004506
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00005518 File Offset: 0x00004518
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

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00005526 File Offset: 0x00004526
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00005535 File Offset: 0x00004535
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00005540 File Offset: 0x00004540
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000554F File Offset: 0x0000454F
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000555A File Offset: 0x0000455A
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00005569 File Offset: 0x00004569
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00005574 File Offset: 0x00004574
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00005583 File Offset: 0x00004583
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000558E File Offset: 0x0000458E
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000559D File Offset: 0x0000459D
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000055A8 File Offset: 0x000045A8
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000055BA File Offset: 0x000045BA
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

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000055C8 File Offset: 0x000045C8
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000055D7 File Offset: 0x000045D7
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000055E2 File Offset: 0x000045E2
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000055F1 File Offset: 0x000045F1
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

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000055FC File Offset: 0x000045FC
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000560B File Offset: 0x0000460B
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00005616 File Offset: 0x00004616
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00005625 File Offset: 0x00004625
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00005630 File Offset: 0x00004630
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00005642 File Offset: 0x00004642
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00005650 File Offset: 0x00004650
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0000565F File Offset: 0x0000465F
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

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000566A File Offset: 0x0000466A
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00005678 File Offset: 0x00004678
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00005682 File Offset: 0x00004682
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00005691 File Offset: 0x00004691
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

		// Token: 0x06000325 RID: 805 RVA: 0x0000569C File Offset: 0x0000469C
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000056AF File Offset: 0x000046AF
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000056BE File Offset: 0x000046BE
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000056D0 File Offset: 0x000046D0
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000056DE File Offset: 0x000046DE
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000056F0 File Offset: 0x000046F0
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000056FE File Offset: 0x000046FE
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0000570D File Offset: 0x0000470D
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00005718 File Offset: 0x00004718
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00005727 File Offset: 0x00004727
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00005732 File Offset: 0x00004732
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00005741 File Offset: 0x00004741
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000574C File Offset: 0x0000474C
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000575B File Offset: 0x0000475B
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00005766 File Offset: 0x00004766
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00005778 File Offset: 0x00004778
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00005786 File Offset: 0x00004786
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00005798 File Offset: 0x00004798
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000057A6 File Offset: 0x000047A6
		// (set) Token: 0x06000338 RID: 824 RVA: 0x000057B8 File Offset: 0x000047B8
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000057C6 File Offset: 0x000047C6
		// (set) Token: 0x0600033A RID: 826 RVA: 0x000057D8 File Offset: 0x000047D8
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000057E6 File Offset: 0x000047E6
		// (set) Token: 0x0600033C RID: 828 RVA: 0x000057F8 File Offset: 0x000047F8
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

		// Token: 0x0600033D RID: 829 RVA: 0x00005806 File Offset: 0x00004806
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00005824 File Offset: 0x00004824
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00005841 File Offset: 0x00004841
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00005853 File Offset: 0x00004853
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00005861 File Offset: 0x00004861
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00005870 File Offset: 0x00004870
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

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000587B File Offset: 0x0000487B
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0000588A File Offset: 0x0000488A
		[FIXField("71", EFieldOption.Required)]
		public char AllocTransType
		{
			get
			{
				return this.GetCharField(71).Value;
			}
			set
			{
				this.AddCharField(71, value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00005895 File Offset: 0x00004895
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000058A7 File Offset: 0x000048A7
		[FIXField("626", EFieldOption.Required)]
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

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000058B5 File Offset: 0x000048B5
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000058C7 File Offset: 0x000048C7
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000058D5 File Offset: 0x000048D5
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000058E4 File Offset: 0x000048E4
		[FIXField("72", EFieldOption.Optional)]
		public string RefAllocID
		{
			get
			{
				return this.GetStringField(72).Value;
			}
			set
			{
				this.AddStringField(72, value);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000058EF File Offset: 0x000048EF
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00005901 File Offset: 0x00004901
		[FIXField("796", EFieldOption.Optional)]
		public int AllocCancReplaceReason
		{
			get
			{
				return this.GetIntField(796).Value;
			}
			set
			{
				this.AddIntField(796, value);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000590F File Offset: 0x0000490F
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00005921 File Offset: 0x00004921
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000592F File Offset: 0x0000492F
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00005941 File Offset: 0x00004941
		[FIXField("196", EFieldOption.Optional)]
		public string AllocLinkID
		{
			get
			{
				return this.GetStringField(196).Value;
			}
			set
			{
				this.AddStringField(196, value);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000594F File Offset: 0x0000494F
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00005961 File Offset: 0x00004961
		[FIXField("197", EFieldOption.Optional)]
		public int AllocLinkType
		{
			get
			{
				return this.GetIntField(197).Value;
			}
			set
			{
				this.AddIntField(197, value);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000596F File Offset: 0x0000496F
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00005981 File Offset: 0x00004981
		[FIXField("466", EFieldOption.Optional)]
		public string BookingRefID
		{
			get
			{
				return this.GetStringField(466).Value;
			}
			set
			{
				this.AddStringField(466, value);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000598F File Offset: 0x0000498F
		// (set) Token: 0x06000356 RID: 854 RVA: 0x000059A1 File Offset: 0x000049A1
		[FIXField("857", EFieldOption.Required)]
		public int AllocNoOrdersType
		{
			get
			{
				return this.GetIntField(857).Value;
			}
			set
			{
				this.AddIntField(857, value);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000357 RID: 855 RVA: 0x000059AF File Offset: 0x000049AF
		// (set) Token: 0x06000358 RID: 856 RVA: 0x000059BE File Offset: 0x000049BE
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

		// Token: 0x06000359 RID: 857 RVA: 0x000059C9 File Offset: 0x000049C9
		public FIXOrdersGroup GetOrdersGroup(int i)
		{
			if (i < this.NoOrders)
			{
				return (FIXOrdersGroup)this.fOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000059E7 File Offset: 0x000049E7
		public void AddGroup(FIXOrdersGroup group)
		{
			this.fOrdersGroup.Add(group);
			this.NoOrders++;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00005A04 File Offset: 0x00004A04
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00005A13 File Offset: 0x00004A13
		[FIXField("124", EFieldOption.Optional)]
		public int NoExecs
		{
			get
			{
				return this.GetIntField(124).Value;
			}
			set
			{
				this.AddIntField(124, value);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00005A1E File Offset: 0x00004A1E
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00005A3C File Offset: 0x00004A3C
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00005A59 File Offset: 0x00004A59
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00005A6B File Offset: 0x00004A6B
		[FIXField("570", EFieldOption.Optional)]
		public bool PreviouslyReported
		{
			get
			{
				return this.GetBoolField(570).Value;
			}
			set
			{
				this.AddBoolField(570, value);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00005A79 File Offset: 0x00004A79
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00005A8B File Offset: 0x00004A8B
		[FIXField("700", EFieldOption.Optional)]
		public bool ReversalIndicator
		{
			get
			{
				return this.GetBoolField(700).Value;
			}
			set
			{
				this.AddBoolField(700, value);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00005A99 File Offset: 0x00004A99
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00005AAB File Offset: 0x00004AAB
		[FIXField("574", EFieldOption.Optional)]
		public string MatchType
		{
			get
			{
				return this.GetStringField(574).Value;
			}
			set
			{
				this.AddStringField(574, value);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00005AB9 File Offset: 0x00004AB9
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00005AC8 File Offset: 0x00004AC8
		[FIXField("54", EFieldOption.Required)]
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00005AD3 File Offset: 0x00004AD3
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00005AE2 File Offset: 0x00004AE2
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00005AED File Offset: 0x00004AED
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00005AFC File Offset: 0x00004AFC
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00005B07 File Offset: 0x00004B07
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00005B16 File Offset: 0x00004B16
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00005B21 File Offset: 0x00004B21
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00005B30 File Offset: 0x00004B30
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00005B3B File Offset: 0x00004B3B
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00005B4D File Offset: 0x00004B4D
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

		// Token: 0x06000371 RID: 881 RVA: 0x00005B5B File Offset: 0x00004B5B
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00005B79 File Offset: 0x00004B79
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00005B96 File Offset: 0x00004B96
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00005BA8 File Offset: 0x00004BA8
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00005BB6 File Offset: 0x00004BB6
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00005BC8 File Offset: 0x00004BC8
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00005BD6 File Offset: 0x00004BD6
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00005BE8 File Offset: 0x00004BE8
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00005BF6 File Offset: 0x00004BF6
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00005C08 File Offset: 0x00004C08
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00005C16 File Offset: 0x00004C16
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00005C28 File Offset: 0x00004C28
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00005C36 File Offset: 0x00004C36
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00005C48 File Offset: 0x00004C48
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00005C56 File Offset: 0x00004C56
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00005C68 File Offset: 0x00004C68
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00005C76 File Offset: 0x00004C76
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00005C88 File Offset: 0x00004C88
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00005C96 File Offset: 0x00004C96
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00005CA8 File Offset: 0x00004CA8
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00005CB6 File Offset: 0x00004CB6
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00005CC8 File Offset: 0x00004CC8
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00005CD6 File Offset: 0x00004CD6
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00005CE8 File Offset: 0x00004CE8
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00005CF6 File Offset: 0x00004CF6
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00005D08 File Offset: 0x00004D08
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00005D16 File Offset: 0x00004D16
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00005D28 File Offset: 0x00004D28
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00005D36 File Offset: 0x00004D36
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00005D48 File Offset: 0x00004D48
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00005D56 File Offset: 0x00004D56
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00005D68 File Offset: 0x00004D68
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00005D76 File Offset: 0x00004D76
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00005D88 File Offset: 0x00004D88
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00005D96 File Offset: 0x00004D96
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00005DA8 File Offset: 0x00004DA8
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00005DB6 File Offset: 0x00004DB6
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00005DC8 File Offset: 0x00004DC8
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

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00005DD6 File Offset: 0x00004DD6
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00005DE8 File Offset: 0x00004DE8
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00005DF6 File Offset: 0x00004DF6
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00005E08 File Offset: 0x00004E08
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00005E16 File Offset: 0x00004E16
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00005E28 File Offset: 0x00004E28
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00005E36 File Offset: 0x00004E36
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00005E48 File Offset: 0x00004E48
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00005E56 File Offset: 0x00004E56
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00005E68 File Offset: 0x00004E68
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00005E76 File Offset: 0x00004E76
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00005E88 File Offset: 0x00004E88
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

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00005E96 File Offset: 0x00004E96
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00005EA5 File Offset: 0x00004EA5
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00005EB0 File Offset: 0x00004EB0
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00005EC2 File Offset: 0x00004EC2
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00005ED0 File Offset: 0x00004ED0
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00005EE2 File Offset: 0x00004EE2
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00005EF0 File Offset: 0x00004EF0
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00005EFF File Offset: 0x00004EFF
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

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00005F0A File Offset: 0x00004F0A
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00005F1C File Offset: 0x00004F1C
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

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00005F2A File Offset: 0x00004F2A
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00005F3C File Offset: 0x00004F3C
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00005F4A File Offset: 0x00004F4A
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00005F5C File Offset: 0x00004F5C
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00005F6A File Offset: 0x00004F6A
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00005F7C File Offset: 0x00004F7C
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00005F8A File Offset: 0x00004F8A
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00005F9C File Offset: 0x00004F9C
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

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00005FAA File Offset: 0x00004FAA
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00005FBC File Offset: 0x00004FBC
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00005FCA File Offset: 0x00004FCA
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00005FDC File Offset: 0x00004FDC
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

		// Token: 0x060003B9 RID: 953 RVA: 0x00005FEA File Offset: 0x00004FEA
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00006008 File Offset: 0x00005008
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00006025 File Offset: 0x00005025
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00006037 File Offset: 0x00005037
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00006045 File Offset: 0x00005045
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00006057 File Offset: 0x00005057
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00006065 File Offset: 0x00005065
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00006077 File Offset: 0x00005077
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00006085 File Offset: 0x00005085
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00006097 File Offset: 0x00005097
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000060A5 File Offset: 0x000050A5
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x000060B7 File Offset: 0x000050B7
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

		// Token: 0x060003C5 RID: 965 RVA: 0x000060C5 File Offset: 0x000050C5
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000060E3 File Offset: 0x000050E3
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00006100 File Offset: 0x00005100
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00006112 File Offset: 0x00005112
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

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00006120 File Offset: 0x00005120
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00006132 File Offset: 0x00005132
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00006140 File Offset: 0x00005140
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00006152 File Offset: 0x00005152
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00006160 File Offset: 0x00005160
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00006172 File Offset: 0x00005172
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00006180 File Offset: 0x00005180
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00006192 File Offset: 0x00005192
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000061A0 File Offset: 0x000051A0
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000061B2 File Offset: 0x000051B2
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x000061C0 File Offset: 0x000051C0
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000061D2 File Offset: 0x000051D2
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000061E0 File Offset: 0x000051E0
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x000061F2 File Offset: 0x000051F2
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00006200 File Offset: 0x00005200
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00006212 File Offset: 0x00005212
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00006220 File Offset: 0x00005220
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00006232 File Offset: 0x00005232
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

		// Token: 0x060003DB RID: 987 RVA: 0x00006240 File Offset: 0x00005240
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000625E File Offset: 0x0000525E
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000627B File Offset: 0x0000527B
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000628D File Offset: 0x0000528D
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

		// Token: 0x060003DF RID: 991 RVA: 0x0000629B File Offset: 0x0000529B
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000062B9 File Offset: 0x000052B9
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000062D6 File Offset: 0x000052D6
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000062E5 File Offset: 0x000052E5
		[FIXField("53", EFieldOption.Required)]
		public double Quantity
		{
			get
			{
				return this.GetDoubleField(53).Value;
			}
			set
			{
				this.AddDoubleField(53, value);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000062F0 File Offset: 0x000052F0
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00006302 File Offset: 0x00005302
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntField(854).Value;
			}
			set
			{
				this.AddIntField(854, value);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00006310 File Offset: 0x00005310
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0000631F File Offset: 0x0000531F
		[FIXField("30", EFieldOption.Optional)]
		public string LastMkt
		{
			get
			{
				return this.GetStringField(30).Value;
			}
			set
			{
				this.AddStringField(30, value);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000632A File Offset: 0x0000532A
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0000633C File Offset: 0x0000533C
		[FIXField("229", EFieldOption.Optional)]
		public DateTime TradeOriginationDate
		{
			get
			{
				return this.GetDateTimeField(229).Value;
			}
			set
			{
				this.AddDateTimeField(229, value);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000634A File Offset: 0x0000534A
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0000635C File Offset: 0x0000535C
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000636A File Offset: 0x0000536A
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0000637C File Offset: 0x0000537C
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000638A File Offset: 0x0000538A
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0000639C File Offset: 0x0000539C
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x000063AA File Offset: 0x000053AA
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000063B8 File Offset: 0x000053B8
		[FIXField("6", EFieldOption.Required)]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleField(6).Value;
			}
			set
			{
				this.AddDoubleField(6, value);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000063C2 File Offset: 0x000053C2
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000063D4 File Offset: 0x000053D4
		[FIXField("860", EFieldOption.Optional)]
		public double AvgParPx
		{
			get
			{
				return this.GetDoubleField(860).Value;
			}
			set
			{
				this.AddDoubleField(860, value);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000063E2 File Offset: 0x000053E2
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000063F4 File Offset: 0x000053F4
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00006402 File Offset: 0x00005402
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00006414 File Offset: 0x00005414
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00006422 File Offset: 0x00005422
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00006434 File Offset: 0x00005434
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00006442 File Offset: 0x00005442
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00006454 File Offset: 0x00005454
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00006462 File Offset: 0x00005462
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00006474 File Offset: 0x00005474
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00006482 File Offset: 0x00005482
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00006494 File Offset: 0x00005494
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000064A2 File Offset: 0x000054A2
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x000064B4 File Offset: 0x000054B4
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000064C2 File Offset: 0x000054C2
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x000064D4 File Offset: 0x000054D4
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000064E2 File Offset: 0x000054E2
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x000064F1 File Offset: 0x000054F1
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000064FC File Offset: 0x000054FC
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0000650B File Offset: 0x0000550B
		[FIXField("74", EFieldOption.Optional)]
		public int AvgPxPrecision
		{
			get
			{
				return this.GetIntField(74).Value;
			}
			set
			{
				this.AddIntField(74, value);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00006516 File Offset: 0x00005516
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00006528 File Offset: 0x00005528
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

		// Token: 0x06000409 RID: 1033 RVA: 0x00006536 File Offset: 0x00005536
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00006554 File Offset: 0x00005554
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00006571 File Offset: 0x00005571
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00006580 File Offset: 0x00005580
		[FIXField("75", EFieldOption.Required)]
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000658B File Offset: 0x0000558B
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000659A File Offset: 0x0000559A
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x000065A5 File Offset: 0x000055A5
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x000065B4 File Offset: 0x000055B4
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x000065BF File Offset: 0x000055BF
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000065CE File Offset: 0x000055CE
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000065D9 File Offset: 0x000055D9
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x000065EB File Offset: 0x000055EB
		[FIXField("775", EFieldOption.Optional)]
		public int BookingType
		{
			get
			{
				return this.GetIntField(775).Value;
			}
			set
			{
				this.AddIntField(775, value);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000065F9 File Offset: 0x000055F9
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000660B File Offset: 0x0000560B
		[FIXField("381", EFieldOption.Optional)]
		public double GrossTradeAmt
		{
			get
			{
				return this.GetDoubleField(381).Value;
			}
			set
			{
				this.AddDoubleField(381, value);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00006619 File Offset: 0x00005619
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000662B File Offset: 0x0000562B
		[FIXField("238", EFieldOption.Optional)]
		public double Concession
		{
			get
			{
				return this.GetDoubleField(238).Value;
			}
			set
			{
				this.AddDoubleField(238, value);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00006639 File Offset: 0x00005639
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0000664B File Offset: 0x0000564B
		[FIXField("237", EFieldOption.Optional)]
		public double TotalTakedown
		{
			get
			{
				return this.GetDoubleField(237).Value;
			}
			set
			{
				this.AddDoubleField(237, value);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00006659 File Offset: 0x00005659
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00006668 File Offset: 0x00005668
		[FIXField("118", EFieldOption.Optional)]
		public double NetMoney
		{
			get
			{
				return this.GetDoubleField(118).Value;
			}
			set
			{
				this.AddDoubleField(118, value);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00006673 File Offset: 0x00005673
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00006682 File Offset: 0x00005682
		[FIXField("77", EFieldOption.Optional)]
		public char PositionEffect
		{
			get
			{
				return this.GetCharField(77).Value;
			}
			set
			{
				this.AddCharField(77, value);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000668D File Offset: 0x0000568D
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0000669F File Offset: 0x0000569F
		[FIXField("754", EFieldOption.Optional)]
		public bool AutoAcceptIndicator
		{
			get
			{
				return this.GetBoolField(754).Value;
			}
			set
			{
				this.AddBoolField(754, value);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000066AD File Offset: 0x000056AD
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000066BC File Offset: 0x000056BC
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x000066C7 File Offset: 0x000056C7
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000066D9 File Offset: 0x000056D9
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000066E7 File Offset: 0x000056E7
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000066F9 File Offset: 0x000056F9
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00006707 File Offset: 0x00005707
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00006719 File Offset: 0x00005719
		[FIXField("157", EFieldOption.Optional)]
		public int NumDaysInterest
		{
			get
			{
				return this.GetIntField(157).Value;
			}
			set
			{
				this.AddIntField(157, value);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00006727 File Offset: 0x00005727
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00006739 File Offset: 0x00005739
		[FIXField("158", EFieldOption.Optional)]
		public double AccruedInterestRate
		{
			get
			{
				return this.GetDoubleField(158).Value;
			}
			set
			{
				this.AddDoubleField(158, value);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00006747 File Offset: 0x00005747
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00006759 File Offset: 0x00005759
		[FIXField("159", EFieldOption.Optional)]
		public double AccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(159).Value;
			}
			set
			{
				this.AddDoubleField(159, value);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00006767 File Offset: 0x00005767
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00006779 File Offset: 0x00005779
		[FIXField("540", EFieldOption.Optional)]
		public double TotalAccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(540).Value;
			}
			set
			{
				this.AddDoubleField(540, value);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00006787 File Offset: 0x00005787
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00006799 File Offset: 0x00005799
		[FIXField("738", EFieldOption.Optional)]
		public double InterestAtMaturity
		{
			get
			{
				return this.GetDoubleField(738).Value;
			}
			set
			{
				this.AddDoubleField(738, value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000067A7 File Offset: 0x000057A7
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x000067B9 File Offset: 0x000057B9
		[FIXField("920", EFieldOption.Optional)]
		public double EndAccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(920).Value;
			}
			set
			{
				this.AddDoubleField(920, value);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000067C7 File Offset: 0x000057C7
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x000067D9 File Offset: 0x000057D9
		[FIXField("921", EFieldOption.Optional)]
		public double StartCash
		{
			get
			{
				return this.GetDoubleField(921).Value;
			}
			set
			{
				this.AddDoubleField(921, value);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x000067E7 File Offset: 0x000057E7
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000067F9 File Offset: 0x000057F9
		[FIXField("922", EFieldOption.Optional)]
		public double EndCash
		{
			get
			{
				return this.GetDoubleField(922).Value;
			}
			set
			{
				this.AddDoubleField(922, value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00006807 File Offset: 0x00005807
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00006819 File Offset: 0x00005819
		[FIXField("650", EFieldOption.Optional)]
		public bool LegalConfirm
		{
			get
			{
				return this.GetBoolField(650).Value;
			}
			set
			{
				this.AddBoolField(650, value);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00006827 File Offset: 0x00005827
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00006839 File Offset: 0x00005839
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

		// Token: 0x0600043B RID: 1083 RVA: 0x00006847 File Offset: 0x00005847
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00006865 File Offset: 0x00005865
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00006882 File Offset: 0x00005882
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00006894 File Offset: 0x00005894
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x000068A2 File Offset: 0x000058A2
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x000068B4 File Offset: 0x000058B4
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000068C2 File Offset: 0x000058C2
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000068D4 File Offset: 0x000058D4
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000068E2 File Offset: 0x000058E2
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000068F4 File Offset: 0x000058F4
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00006902 File Offset: 0x00005902
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00006914 File Offset: 0x00005914
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00006922 File Offset: 0x00005922
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00006934 File Offset: 0x00005934
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00006942 File Offset: 0x00005942
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00006954 File Offset: 0x00005954
		[FIXField("892", EFieldOption.Optional)]
		public int TotNoAllocs
		{
			get
			{
				return this.GetIntField(892).Value;
			}
			set
			{
				this.AddIntField(892, value);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00006962 File Offset: 0x00005962
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00006974 File Offset: 0x00005974
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00006982 File Offset: 0x00005982
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00006991 File Offset: 0x00005991
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

		// Token: 0x0600044F RID: 1103 RVA: 0x0000699C File Offset: 0x0000599C
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000069BA File Offset: 0x000059BA
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x000069D7 File Offset: 0x000059D7
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000069E6 File Offset: 0x000059E6
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x000069F1 File Offset: 0x000059F1
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00006A00 File Offset: 0x00005A00
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00006A0B File Offset: 0x00005A0B
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00006A1A File Offset: 0x00005A1A
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

		// Token: 0x06000457 RID: 1111 RVA: 0x00006A28 File Offset: 0x00005A28
		public FIXAllocationInstruction()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00006AC0 File Offset: 0x00005AC0
		public FIXAllocationInstruction(string AllocID, char AllocTransType, int AllocType, int AllocNoOrdersType, char Side, double Quantity, double AvgPx, DateTime TradeDate)
		{
			this.AllocID = AllocID;
			this.AllocTransType = AllocTransType;
			this.AllocType = AllocType;
			this.AllocNoOrdersType = AllocNoOrdersType;
			this.Side = Side;
			this.Quantity = Quantity;
			this.AvgPx = AvgPx;
			this.TradeDate = TradeDate;
		}

		// Token: 0x04000023 RID: 35
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000024 RID: 36
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000025 RID: 37
		private ArrayList fOrdersGroup = new ArrayList();

		// Token: 0x04000026 RID: 38
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x04000027 RID: 39
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000028 RID: 40
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000029 RID: 41
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x0400002A RID: 42
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400002B RID: 43
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x0400002C RID: 44
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400002D RID: 45
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x0400002E RID: 46
		private ArrayList fAllocsGroup = new ArrayList();
	}
}
