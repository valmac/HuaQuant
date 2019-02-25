using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000B0 RID: 176
	public class FIXMarketDataIncrementalRefresh : FIXMessage
	{
		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00027B25 File Offset: 0x00026B25
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x00027B37 File Offset: 0x00026B37
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

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x00027B45 File Offset: 0x00026B45
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x00027B54 File Offset: 0x00026B54
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

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x00027B5F File Offset: 0x00026B5F
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x00027B6E File Offset: 0x00026B6E
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

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x00027B79 File Offset: 0x00026B79
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00027B88 File Offset: 0x00026B88
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

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x00027B93 File Offset: 0x00026B93
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00027BA2 File Offset: 0x00026BA2
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

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x00027BAD File Offset: 0x00026BAD
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x00027BBC File Offset: 0x00026BBC
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

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x00027BC7 File Offset: 0x00026BC7
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00027BD9 File Offset: 0x00026BD9
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

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x00027BE7 File Offset: 0x00026BE7
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x00027BF6 File Offset: 0x00026BF6
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

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x00027C01 File Offset: 0x00026C01
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x00027C10 File Offset: 0x00026C10
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

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x00027C1B File Offset: 0x00026C1B
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x00027C2A File Offset: 0x00026C2A
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

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x00027C35 File Offset: 0x00026C35
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x00027C44 File Offset: 0x00026C44
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

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00027C4F File Offset: 0x00026C4F
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00027C61 File Offset: 0x00026C61
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

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x00027C6F File Offset: 0x00026C6F
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x00027C7E File Offset: 0x00026C7E
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

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x00027C89 File Offset: 0x00026C89
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x00027C97 File Offset: 0x00026C97
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

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00027CA1 File Offset: 0x00026CA1
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x00027CB0 File Offset: 0x00026CB0
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

		// Token: 0x06002530 RID: 9520 RVA: 0x00027CBB File Offset: 0x00026CBB
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00027CCE File Offset: 0x00026CCE
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x00027CDD File Offset: 0x00026CDD
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x00027CEF File Offset: 0x00026CEF
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

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x00027CFD File Offset: 0x00026CFD
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00027D0F File Offset: 0x00026D0F
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

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x00027D1D File Offset: 0x00026D1D
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x00027D2C File Offset: 0x00026D2C
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

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x00027D37 File Offset: 0x00026D37
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x00027D46 File Offset: 0x00026D46
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

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x00027D51 File Offset: 0x00026D51
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x00027D60 File Offset: 0x00026D60
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

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x00027D6B File Offset: 0x00026D6B
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x00027D7A File Offset: 0x00026D7A
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

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x00027D85 File Offset: 0x00026D85
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x00027D97 File Offset: 0x00026D97
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

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x00027DA5 File Offset: 0x00026DA5
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x00027DB7 File Offset: 0x00026DB7
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

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x00027DC5 File Offset: 0x00026DC5
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x00027DD7 File Offset: 0x00026DD7
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

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x00027DE5 File Offset: 0x00026DE5
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x00027DF7 File Offset: 0x00026DF7
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

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x00027E05 File Offset: 0x00026E05
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x00027E17 File Offset: 0x00026E17
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

		// Token: 0x06002548 RID: 9544 RVA: 0x00027E25 File Offset: 0x00026E25
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00027E43 File Offset: 0x00026E43
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x00027E60 File Offset: 0x00026E60
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x00027E72 File Offset: 0x00026E72
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

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x00027E80 File Offset: 0x00026E80
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x00027E92 File Offset: 0x00026E92
		[FIXField("262", EFieldOption.Optional)]
		public string MDReqID
		{
			get
			{
				return this.GetStringField(262).Value;
			}
			set
			{
				this.AddStringField(262, value);
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x00027EA0 File Offset: 0x00026EA0
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x00027EB2 File Offset: 0x00026EB2
		[FIXField("268", EFieldOption.Required)]
		public int NoMDEntries
		{
			get
			{
				return this.GetIntField(268).Value;
			}
			set
			{
				this.AddIntField(268, value);
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00027EC0 File Offset: 0x00026EC0
		public FIXMDEntriesGroup GetMDEntriesGroup(int i)
		{
			if (i < this.NoMDEntries)
			{
				return (FIXMDEntriesGroup)this.fMDEntriesGroup[i];
			}
			return null;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00027EDE File Offset: 0x00026EDE
		public void AddGroup(FIXMDEntriesGroup group)
		{
			this.fMDEntriesGroup.Add(group);
			this.NoMDEntries++;
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x00027EFB File Offset: 0x00026EFB
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x00027F0D File Offset: 0x00026F0D
		[FIXField("813", EFieldOption.Optional)]
		public int ApplQueueDepth
		{
			get
			{
				return this.GetIntField(813).Value;
			}
			set
			{
				this.AddIntField(813, value);
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x00027F1B File Offset: 0x00026F1B
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x00027F2D File Offset: 0x00026F2D
		[FIXField("814", EFieldOption.Optional)]
		public int ApplQueueResolution
		{
			get
			{
				return this.GetIntField(814).Value;
			}
			set
			{
				this.AddIntField(814, value);
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x00027F3B File Offset: 0x00026F3B
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x00027F4A File Offset: 0x00026F4A
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

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x00027F55 File Offset: 0x00026F55
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x00027F64 File Offset: 0x00026F64
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

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x00027F6F File Offset: 0x00026F6F
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x00027F7E File Offset: 0x00026F7E
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

		// Token: 0x0600255C RID: 9564 RVA: 0x00027F89 File Offset: 0x00026F89
		public FIXMarketDataIncrementalRefresh()
		{
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00027FB2 File Offset: 0x00026FB2
		public FIXMarketDataIncrementalRefresh(int NoMDEntries)
		{
			this.NoMDEntries = NoMDEntries;
		}

		// Token: 0x0400035D RID: 861
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400035E RID: 862
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400035F RID: 863
		private ArrayList fMDEntriesGroup = new ArrayList();
	}
}
