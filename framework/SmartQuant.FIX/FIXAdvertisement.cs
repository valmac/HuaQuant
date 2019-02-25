using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000E5 RID: 229
	public class FIXAdvertisement : FIXMessage
	{
		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x00030334 File Offset: 0x0002F334
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x00030346 File Offset: 0x0002F346
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x00030354 File Offset: 0x0002F354
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x00030363 File Offset: 0x0002F363
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

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x0003036E File Offset: 0x0002F36E
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x0003037D File Offset: 0x0002F37D
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

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x00030388 File Offset: 0x0002F388
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x00030397 File Offset: 0x0002F397
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

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000303A2 File Offset: 0x0002F3A2
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x000303B1 File Offset: 0x0002F3B1
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

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000303BC File Offset: 0x0002F3BC
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x000303CB File Offset: 0x0002F3CB
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x000303D6 File Offset: 0x0002F3D6
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x000303E8 File Offset: 0x0002F3E8
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

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000303F6 File Offset: 0x0002F3F6
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x00030405 File Offset: 0x0002F405
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

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x00030410 File Offset: 0x0002F410
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x0003041F File Offset: 0x0002F41F
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

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x0003042A File Offset: 0x0002F42A
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00030439 File Offset: 0x0002F439
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

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x00030444 File Offset: 0x0002F444
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00030453 File Offset: 0x0002F453
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x0003045E File Offset: 0x0002F45E
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x00030470 File Offset: 0x0002F470
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

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x0003047E File Offset: 0x0002F47E
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x0003048D File Offset: 0x0002F48D
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x00030498 File Offset: 0x0002F498
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x000304A6 File Offset: 0x0002F4A6
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

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000304B0 File Offset: 0x0002F4B0
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x000304BF File Offset: 0x0002F4BF
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

		// Token: 0x06002D9A RID: 11674 RVA: 0x000304CA File Offset: 0x0002F4CA
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000304DD File Offset: 0x0002F4DD
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000304EC File Offset: 0x0002F4EC
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x000304FE File Offset: 0x0002F4FE
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

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x0003050C File Offset: 0x0002F50C
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x0003051E File Offset: 0x0002F51E
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

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x0003052C File Offset: 0x0002F52C
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x0003053B File Offset: 0x0002F53B
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

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00030546 File Offset: 0x0002F546
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00030555 File Offset: 0x0002F555
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

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x00030560 File Offset: 0x0002F560
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x0003056F File Offset: 0x0002F56F
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

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x0003057A File Offset: 0x0002F57A
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x00030589 File Offset: 0x0002F589
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

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x00030594 File Offset: 0x0002F594
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x000305A6 File Offset: 0x0002F5A6
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

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000305B4 File Offset: 0x0002F5B4
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x000305C6 File Offset: 0x0002F5C6
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

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000305D4 File Offset: 0x0002F5D4
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x000305E6 File Offset: 0x0002F5E6
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

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x000305F4 File Offset: 0x0002F5F4
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x00030606 File Offset: 0x0002F606
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

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x00030614 File Offset: 0x0002F614
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x00030626 File Offset: 0x0002F626
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

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00030634 File Offset: 0x0002F634
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00030652 File Offset: 0x0002F652
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x0003066F File Offset: 0x0002F66F
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x00030681 File Offset: 0x0002F681
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

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x0003068F File Offset: 0x0002F68F
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x0003069D File Offset: 0x0002F69D
		[FIXField("2", EFieldOption.Required)]
		public string AdvId
		{
			get
			{
				return this.GetStringField(2).Value;
			}
			set
			{
				this.AddStringField(2, value);
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x000306A7 File Offset: 0x0002F6A7
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x000306B5 File Offset: 0x0002F6B5
		[FIXField("5", EFieldOption.Required)]
		public string AdvTransType
		{
			get
			{
				return this.GetStringField(5).Value;
			}
			set
			{
				this.AddStringField(5, value);
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x000306BF File Offset: 0x0002F6BF
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x000306CD File Offset: 0x0002F6CD
		[FIXField("3", EFieldOption.Optional)]
		public string AdvRefID
		{
			get
			{
				return this.GetStringField(3).Value;
			}
			set
			{
				this.AddStringField(3, value);
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x000306D7 File Offset: 0x0002F6D7
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x000306E6 File Offset: 0x0002F6E6
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

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000306F1 File Offset: 0x0002F6F1
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x00030700 File Offset: 0x0002F700
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

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x0003070B File Offset: 0x0002F70B
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x0003071A File Offset: 0x0002F71A
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

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x00030725 File Offset: 0x0002F725
		// (set) Token: 0x06002DC3 RID: 11715 RVA: 0x00030734 File Offset: 0x0002F734
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

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x0003073F File Offset: 0x0002F73F
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x00030751 File Offset: 0x0002F751
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

		// Token: 0x06002DC6 RID: 11718 RVA: 0x0003075F File Offset: 0x0002F75F
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x0003077D File Offset: 0x0002F77D
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x0003079A File Offset: 0x0002F79A
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x000307AC File Offset: 0x0002F7AC
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

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x000307BA File Offset: 0x0002F7BA
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x000307CC File Offset: 0x0002F7CC
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

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x000307DA File Offset: 0x0002F7DA
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x000307EC File Offset: 0x0002F7EC
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

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x000307FA File Offset: 0x0002F7FA
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x0003080C File Offset: 0x0002F80C
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

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x0003081A File Offset: 0x0002F81A
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x0003082C File Offset: 0x0002F82C
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

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x0003083A File Offset: 0x0002F83A
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x0003084C File Offset: 0x0002F84C
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

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x0003085A File Offset: 0x0002F85A
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x0003086C File Offset: 0x0002F86C
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

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x0003087A File Offset: 0x0002F87A
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x0003088C File Offset: 0x0002F88C
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

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x0003089A File Offset: 0x0002F89A
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x000308AC File Offset: 0x0002F8AC
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

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000308BA File Offset: 0x0002F8BA
		// (set) Token: 0x06002DDB RID: 11739 RVA: 0x000308CC File Offset: 0x0002F8CC
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

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000308DA File Offset: 0x0002F8DA
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x000308EC File Offset: 0x0002F8EC
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

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x000308FA File Offset: 0x0002F8FA
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x0003090C File Offset: 0x0002F90C
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

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x0003091A File Offset: 0x0002F91A
		// (set) Token: 0x06002DE1 RID: 11745 RVA: 0x0003092C File Offset: 0x0002F92C
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

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x0003093A File Offset: 0x0002F93A
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x0003094C File Offset: 0x0002F94C
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

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x0003095A File Offset: 0x0002F95A
		// (set) Token: 0x06002DE5 RID: 11749 RVA: 0x0003096C File Offset: 0x0002F96C
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

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x0003097A File Offset: 0x0002F97A
		// (set) Token: 0x06002DE7 RID: 11751 RVA: 0x0003098C File Offset: 0x0002F98C
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

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x0003099A File Offset: 0x0002F99A
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x000309AC File Offset: 0x0002F9AC
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x000309BA File Offset: 0x0002F9BA
		// (set) Token: 0x06002DEB RID: 11755 RVA: 0x000309CC File Offset: 0x0002F9CC
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x000309DA File Offset: 0x0002F9DA
		// (set) Token: 0x06002DED RID: 11757 RVA: 0x000309EC File Offset: 0x0002F9EC
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

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x000309FA File Offset: 0x0002F9FA
		// (set) Token: 0x06002DEF RID: 11759 RVA: 0x00030A0C File Offset: 0x0002FA0C
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

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x00030A1A File Offset: 0x0002FA1A
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x00030A2C File Offset: 0x0002FA2C
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

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x00030A3A File Offset: 0x0002FA3A
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x00030A4C File Offset: 0x0002FA4C
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

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00030A5A File Offset: 0x0002FA5A
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x00030A6C File Offset: 0x0002FA6C
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

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00030A7A File Offset: 0x0002FA7A
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00030A8C File Offset: 0x0002FA8C
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

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x00030A9A File Offset: 0x0002FA9A
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x00030AA9 File Offset: 0x0002FAA9
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

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x00030AB4 File Offset: 0x0002FAB4
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00030AC6 File Offset: 0x0002FAC6
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

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00030AD4 File Offset: 0x0002FAD4
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00030AE6 File Offset: 0x0002FAE6
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

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x00030AF4 File Offset: 0x0002FAF4
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x00030B03 File Offset: 0x0002FB03
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

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x00030B0E File Offset: 0x0002FB0E
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00030B20 File Offset: 0x0002FB20
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

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x00030B2E File Offset: 0x0002FB2E
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x00030B40 File Offset: 0x0002FB40
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

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x00030B4E File Offset: 0x0002FB4E
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x00030B60 File Offset: 0x0002FB60
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

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00030B6E File Offset: 0x0002FB6E
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x00030B80 File Offset: 0x0002FB80
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

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00030B8E File Offset: 0x0002FB8E
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00030BA0 File Offset: 0x0002FBA0
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

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x00030BAE File Offset: 0x0002FBAE
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x00030BC0 File Offset: 0x0002FBC0
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

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x00030BCE File Offset: 0x0002FBCE
		// (set) Token: 0x06002E0D RID: 11789 RVA: 0x00030BE0 File Offset: 0x0002FBE0
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

		// Token: 0x06002E0E RID: 11790 RVA: 0x00030BEE File Offset: 0x0002FBEE
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00030C0C File Offset: 0x0002FC0C
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x00030C29 File Offset: 0x0002FC29
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x00030C3B File Offset: 0x0002FC3B
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

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x00030C49 File Offset: 0x0002FC49
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x00030C5B File Offset: 0x0002FC5B
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

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00030C69 File Offset: 0x0002FC69
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00030C7B File Offset: 0x0002FC7B
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

		// Token: 0x06002E16 RID: 11798 RVA: 0x00030C89 File Offset: 0x0002FC89
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00030CA7 File Offset: 0x0002FCA7
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x00030CC4 File Offset: 0x0002FCC4
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x00030CD6 File Offset: 0x0002FCD6
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

		// Token: 0x06002E1A RID: 11802 RVA: 0x00030CE4 File Offset: 0x0002FCE4
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00030D02 File Offset: 0x0002FD02
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x00030D1F File Offset: 0x0002FD1F
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00030D2D File Offset: 0x0002FD2D
		[FIXField("4", EFieldOption.Required)]
		public char AdvSide
		{
			get
			{
				return this.GetCharField(4).Value;
			}
			set
			{
				this.AddCharField(4, value);
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x00030D37 File Offset: 0x0002FD37
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00030D46 File Offset: 0x0002FD46
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

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x00030D51 File Offset: 0x0002FD51
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x00030D63 File Offset: 0x0002FD63
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

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x00030D71 File Offset: 0x0002FD71
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x00030D80 File Offset: 0x0002FD80
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

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x00030D8B File Offset: 0x0002FD8B
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00030D9A File Offset: 0x0002FD9A
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

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x00030DA5 File Offset: 0x0002FDA5
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x00030DB4 File Offset: 0x0002FDB4
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

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x00030DBF File Offset: 0x0002FDBF
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x00030DCE File Offset: 0x0002FDCE
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

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x00030DD9 File Offset: 0x0002FDD9
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x00030DE8 File Offset: 0x0002FDE8
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

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x00030DF3 File Offset: 0x0002FDF3
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x00030E05 File Offset: 0x0002FE05
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

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x00030E13 File Offset: 0x0002FE13
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x00030E25 File Offset: 0x0002FE25
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x00030E33 File Offset: 0x0002FE33
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x00030E45 File Offset: 0x0002FE45
		[FIXField("149", EFieldOption.Optional)]
		public string URLLink
		{
			get
			{
				return this.GetStringField(149).Value;
			}
			set
			{
				this.AddStringField(149, value);
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00030E53 File Offset: 0x0002FE53
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x00030E62 File Offset: 0x0002FE62
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

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x00030E6D File Offset: 0x0002FE6D
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x00030E7F File Offset: 0x0002FE7F
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

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x00030E8D File Offset: 0x0002FE8D
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x00030E9F File Offset: 0x0002FE9F
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x00030EAD File Offset: 0x0002FEAD
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x00030EBC File Offset: 0x0002FEBC
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

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x00030EC7 File Offset: 0x0002FEC7
		// (set) Token: 0x06002E3B RID: 11835 RVA: 0x00030ED6 File Offset: 0x0002FED6
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

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x00030EE1 File Offset: 0x0002FEE1
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x00030EF0 File Offset: 0x0002FEF0
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

		// Token: 0x06002E3E RID: 11838 RVA: 0x00030EFC File Offset: 0x0002FEFC
		public FIXAdvertisement()
		{
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00030F54 File Offset: 0x0002FF54
		public FIXAdvertisement(string AdvId, string AdvTransType, char AdvSide, double Quantity)
		{
			this.AdvId = AdvId;
			this.AdvTransType = AdvTransType;
			this.AdvSide = AdvSide;
			this.Quantity = Quantity;
		}

		// Token: 0x040003E3 RID: 995
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003E4 RID: 996
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040003E5 RID: 997
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040003E6 RID: 998
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040003E7 RID: 999
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040003E8 RID: 1000
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
