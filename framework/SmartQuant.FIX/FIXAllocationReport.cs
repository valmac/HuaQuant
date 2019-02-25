using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000103 RID: 259
	public class FIXAllocationReport : FIXMessage
	{
		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x00032BEF File Offset: 0x00031BEF
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x00032C01 File Offset: 0x00031C01
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

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x00032C0F File Offset: 0x00031C0F
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x00032C1E File Offset: 0x00031C1E
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

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x00032C29 File Offset: 0x00031C29
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x00032C38 File Offset: 0x00031C38
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

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x00032C43 File Offset: 0x00031C43
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x00032C52 File Offset: 0x00031C52
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

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x00032C5D File Offset: 0x00031C5D
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x00032C6C File Offset: 0x00031C6C
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

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x00032C77 File Offset: 0x00031C77
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x00032C86 File Offset: 0x00031C86
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

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x00032C91 File Offset: 0x00031C91
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x00032CA3 File Offset: 0x00031CA3
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

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x00032CB1 File Offset: 0x00031CB1
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x00032CC0 File Offset: 0x00031CC0
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

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x00032CCB File Offset: 0x00031CCB
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x00032CDA File Offset: 0x00031CDA
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

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x00032CE5 File Offset: 0x00031CE5
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00032CF4 File Offset: 0x00031CF4
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

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x00032CFF File Offset: 0x00031CFF
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x00032D0E File Offset: 0x00031D0E
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

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x00032D19 File Offset: 0x00031D19
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x00032D2B File Offset: 0x00031D2B
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

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x00032D39 File Offset: 0x00031D39
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x00032D48 File Offset: 0x00031D48
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

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x00032D53 File Offset: 0x00031D53
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x00032D61 File Offset: 0x00031D61
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

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x00032D6B File Offset: 0x00031D6B
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x00032D7A File Offset: 0x00031D7A
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

		// Token: 0x06003056 RID: 12374 RVA: 0x00032D85 File Offset: 0x00031D85
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x00032D98 File Offset: 0x00031D98
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x00032DA7 File Offset: 0x00031DA7
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x00032DB9 File Offset: 0x00031DB9
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

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x00032DC7 File Offset: 0x00031DC7
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x00032DD9 File Offset: 0x00031DD9
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

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x00032DE7 File Offset: 0x00031DE7
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x00032DF6 File Offset: 0x00031DF6
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

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x00032E01 File Offset: 0x00031E01
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x00032E10 File Offset: 0x00031E10
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

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x00032E1B File Offset: 0x00031E1B
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x00032E2A File Offset: 0x00031E2A
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

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x00032E35 File Offset: 0x00031E35
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00032E44 File Offset: 0x00031E44
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

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x00032E4F File Offset: 0x00031E4F
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00032E61 File Offset: 0x00031E61
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

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x00032E6F File Offset: 0x00031E6F
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x00032E81 File Offset: 0x00031E81
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

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x00032E8F File Offset: 0x00031E8F
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x00032EA1 File Offset: 0x00031EA1
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

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x00032EAF File Offset: 0x00031EAF
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x00032EC1 File Offset: 0x00031EC1
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

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x00032ECF File Offset: 0x00031ECF
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x00032EE1 File Offset: 0x00031EE1
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

		// Token: 0x0600306E RID: 12398 RVA: 0x00032EEF File Offset: 0x00031EEF
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00032F0D File Offset: 0x00031F0D
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x00032F2A File Offset: 0x00031F2A
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x00032F3C File Offset: 0x00031F3C
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

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x00032F4A File Offset: 0x00031F4A
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x00032F5C File Offset: 0x00031F5C
		[FIXField("755", EFieldOption.Required)]
		public string AllocReportID
		{
			get
			{
				return this.GetStringField(755).Value;
			}
			set
			{
				this.AddStringField(755, value);
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x00032F6A File Offset: 0x00031F6A
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x00032F79 File Offset: 0x00031F79
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

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x00032F84 File Offset: 0x00031F84
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x00032F93 File Offset: 0x00031F93
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

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x00032F9E File Offset: 0x00031F9E
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00032FB0 File Offset: 0x00031FB0
		[FIXField("795", EFieldOption.Optional)]
		public string AllocReportRefID
		{
			get
			{
				return this.GetStringField(795).Value;
			}
			set
			{
				this.AddStringField(795, value);
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x00032FBE File Offset: 0x00031FBE
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x00032FD0 File Offset: 0x00031FD0
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

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x00032FDE File Offset: 0x00031FDE
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x00032FF0 File Offset: 0x00031FF0
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

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x00032FFE File Offset: 0x00031FFE
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x00033010 File Offset: 0x00032010
		[FIXField("794", EFieldOption.Required)]
		public int AllocReportType
		{
			get
			{
				return this.GetIntField(794).Value;
			}
			set
			{
				this.AddIntField(794, value);
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x0003301E File Offset: 0x0003201E
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x0003302D File Offset: 0x0003202D
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

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x00033038 File Offset: 0x00032038
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x00033047 File Offset: 0x00032047
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

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x00033052 File Offset: 0x00032052
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x00033061 File Offset: 0x00032061
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

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x0003306C File Offset: 0x0003206C
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x0003307E File Offset: 0x0003207E
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

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x0003308C File Offset: 0x0003208C
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x0003309E File Offset: 0x0003209E
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

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000330AC File Offset: 0x000320AC
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x000330BE File Offset: 0x000320BE
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

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x000330CC File Offset: 0x000320CC
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x000330DE File Offset: 0x000320DE
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

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x000330EC File Offset: 0x000320EC
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x000330FE File Offset: 0x000320FE
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

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x0003310C File Offset: 0x0003210C
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x0003311B File Offset: 0x0003211B
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

		// Token: 0x06003092 RID: 12434 RVA: 0x00033126 File Offset: 0x00032126
		public FIXOrdersGroup GetOrdersGroup(int i)
		{
			if (i < this.NoOrders)
			{
				return (FIXOrdersGroup)this.fOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00033144 File Offset: 0x00032144
		public void AddGroup(FIXOrdersGroup group)
		{
			this.fOrdersGroup.Add(group);
			this.NoOrders++;
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x00033161 File Offset: 0x00032161
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x00033170 File Offset: 0x00032170
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

		// Token: 0x06003096 RID: 12438 RVA: 0x0003317B File Offset: 0x0003217B
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00033199 File Offset: 0x00032199
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x000331B6 File Offset: 0x000321B6
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x000331C8 File Offset: 0x000321C8
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

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x000331D6 File Offset: 0x000321D6
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x000331E8 File Offset: 0x000321E8
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

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x000331F6 File Offset: 0x000321F6
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x00033208 File Offset: 0x00032208
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

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x00033216 File Offset: 0x00032216
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x00033225 File Offset: 0x00032225
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

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x00033230 File Offset: 0x00032230
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x0003323F File Offset: 0x0003223F
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

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x0003324A File Offset: 0x0003224A
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x00033259 File Offset: 0x00032259
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

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00033264 File Offset: 0x00032264
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x00033273 File Offset: 0x00032273
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

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x0003327E File Offset: 0x0003227E
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x0003328D File Offset: 0x0003228D
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

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x00033298 File Offset: 0x00032298
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x000332AA File Offset: 0x000322AA
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

		// Token: 0x060030AA RID: 12458 RVA: 0x000332B8 File Offset: 0x000322B8
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x000332D6 File Offset: 0x000322D6
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x000332F3 File Offset: 0x000322F3
		// (set) Token: 0x060030AD RID: 12461 RVA: 0x00033305 File Offset: 0x00032305
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

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x00033313 File Offset: 0x00032313
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x00033325 File Offset: 0x00032325
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

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x00033333 File Offset: 0x00032333
		// (set) Token: 0x060030B1 RID: 12465 RVA: 0x00033345 File Offset: 0x00032345
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

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x060030B2 RID: 12466 RVA: 0x00033353 File Offset: 0x00032353
		// (set) Token: 0x060030B3 RID: 12467 RVA: 0x00033365 File Offset: 0x00032365
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

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x060030B4 RID: 12468 RVA: 0x00033373 File Offset: 0x00032373
		// (set) Token: 0x060030B5 RID: 12469 RVA: 0x00033385 File Offset: 0x00032385
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

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x00033393 File Offset: 0x00032393
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x000333A5 File Offset: 0x000323A5
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

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000333B3 File Offset: 0x000323B3
		// (set) Token: 0x060030B9 RID: 12473 RVA: 0x000333C5 File Offset: 0x000323C5
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

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x060030BA RID: 12474 RVA: 0x000333D3 File Offset: 0x000323D3
		// (set) Token: 0x060030BB RID: 12475 RVA: 0x000333E5 File Offset: 0x000323E5
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

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x000333F3 File Offset: 0x000323F3
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x00033405 File Offset: 0x00032405
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

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x00033413 File Offset: 0x00032413
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x00033425 File Offset: 0x00032425
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

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x00033433 File Offset: 0x00032433
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x00033445 File Offset: 0x00032445
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

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x00033453 File Offset: 0x00032453
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x00033465 File Offset: 0x00032465
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

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x00033473 File Offset: 0x00032473
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x00033485 File Offset: 0x00032485
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

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x00033493 File Offset: 0x00032493
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x000334A5 File Offset: 0x000324A5
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

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x000334B3 File Offset: 0x000324B3
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x000334C5 File Offset: 0x000324C5
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

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x000334D3 File Offset: 0x000324D3
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x000334E5 File Offset: 0x000324E5
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

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x000334F3 File Offset: 0x000324F3
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x00033505 File Offset: 0x00032505
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

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x00033513 File Offset: 0x00032513
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x00033525 File Offset: 0x00032525
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

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x00033533 File Offset: 0x00032533
		// (set) Token: 0x060030D1 RID: 12497 RVA: 0x00033545 File Offset: 0x00032545
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

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x00033553 File Offset: 0x00032553
		// (set) Token: 0x060030D3 RID: 12499 RVA: 0x00033565 File Offset: 0x00032565
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

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x00033573 File Offset: 0x00032573
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x00033585 File Offset: 0x00032585
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

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x00033593 File Offset: 0x00032593
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x000335A5 File Offset: 0x000325A5
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

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x000335B3 File Offset: 0x000325B3
		// (set) Token: 0x060030D9 RID: 12505 RVA: 0x000335C5 File Offset: 0x000325C5
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

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x000335D3 File Offset: 0x000325D3
		// (set) Token: 0x060030DB RID: 12507 RVA: 0x000335E5 File Offset: 0x000325E5
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

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x000335F3 File Offset: 0x000325F3
		// (set) Token: 0x060030DD RID: 12509 RVA: 0x00033602 File Offset: 0x00032602
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

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x0003360D File Offset: 0x0003260D
		// (set) Token: 0x060030DF RID: 12511 RVA: 0x0003361F File Offset: 0x0003261F
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

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x0003362D File Offset: 0x0003262D
		// (set) Token: 0x060030E1 RID: 12513 RVA: 0x0003363F File Offset: 0x0003263F
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

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x0003364D File Offset: 0x0003264D
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x0003365C File Offset: 0x0003265C
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

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x00033667 File Offset: 0x00032667
		// (set) Token: 0x060030E5 RID: 12517 RVA: 0x00033679 File Offset: 0x00032679
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

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x00033687 File Offset: 0x00032687
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00033699 File Offset: 0x00032699
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

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000336A7 File Offset: 0x000326A7
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x000336B9 File Offset: 0x000326B9
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

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x000336C7 File Offset: 0x000326C7
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x000336D9 File Offset: 0x000326D9
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

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x000336E7 File Offset: 0x000326E7
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x000336F9 File Offset: 0x000326F9
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

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x00033707 File Offset: 0x00032707
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00033719 File Offset: 0x00032719
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

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x00033727 File Offset: 0x00032727
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00033739 File Offset: 0x00032739
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

		// Token: 0x060030F2 RID: 12530 RVA: 0x00033747 File Offset: 0x00032747
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x00033765 File Offset: 0x00032765
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x00033782 File Offset: 0x00032782
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x00033794 File Offset: 0x00032794
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

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000337A2 File Offset: 0x000327A2
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x000337B4 File Offset: 0x000327B4
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

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x000337C2 File Offset: 0x000327C2
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x000337D4 File Offset: 0x000327D4
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

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x000337E2 File Offset: 0x000327E2
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x000337F4 File Offset: 0x000327F4
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

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x00033802 File Offset: 0x00032802
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x00033814 File Offset: 0x00032814
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

		// Token: 0x060030FE RID: 12542 RVA: 0x00033822 File Offset: 0x00032822
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x00033840 File Offset: 0x00032840
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x0003385D File Offset: 0x0003285D
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x0003386F File Offset: 0x0003286F
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

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x0003387D File Offset: 0x0003287D
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x0003388F File Offset: 0x0003288F
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

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x0003389D File Offset: 0x0003289D
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x000338AF File Offset: 0x000328AF
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

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000338BD File Offset: 0x000328BD
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x000338CF File Offset: 0x000328CF
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

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000338DD File Offset: 0x000328DD
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x000338EF File Offset: 0x000328EF
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

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000338FD File Offset: 0x000328FD
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x0003390F File Offset: 0x0003290F
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

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0003391D File Offset: 0x0003291D
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0003392F File Offset: 0x0003292F
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

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x0003393D File Offset: 0x0003293D
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x0003394F File Offset: 0x0003294F
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

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x0003395D File Offset: 0x0003295D
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x0003396F File Offset: 0x0003296F
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

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x0003397D File Offset: 0x0003297D
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x0003398F File Offset: 0x0003298F
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

		// Token: 0x06003114 RID: 12564 RVA: 0x0003399D File Offset: 0x0003299D
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000339BB File Offset: 0x000329BB
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x000339D8 File Offset: 0x000329D8
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x000339EA File Offset: 0x000329EA
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

		// Token: 0x06003118 RID: 12568 RVA: 0x000339F8 File Offset: 0x000329F8
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00033A16 File Offset: 0x00032A16
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x00033A33 File Offset: 0x00032A33
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x00033A42 File Offset: 0x00032A42
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

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x00033A4D File Offset: 0x00032A4D
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x00033A5F File Offset: 0x00032A5F
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

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x00033A6D File Offset: 0x00032A6D
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x00033A7C File Offset: 0x00032A7C
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

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x00033A87 File Offset: 0x00032A87
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x00033A99 File Offset: 0x00032A99
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

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x00033AA7 File Offset: 0x00032AA7
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x00033AB9 File Offset: 0x00032AB9
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

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00033AC7 File Offset: 0x00032AC7
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x00033AD9 File Offset: 0x00032AD9
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

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x00033AE7 File Offset: 0x00032AE7
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x00033AF9 File Offset: 0x00032AF9
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

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x00033B07 File Offset: 0x00032B07
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x00033B15 File Offset: 0x00032B15
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

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x00033B1F File Offset: 0x00032B1F
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x00033B31 File Offset: 0x00032B31
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

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x00033B3F File Offset: 0x00032B3F
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x00033B51 File Offset: 0x00032B51
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

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x00033B5F File Offset: 0x00032B5F
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x00033B71 File Offset: 0x00032B71
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

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x00033B7F File Offset: 0x00032B7F
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x00033B91 File Offset: 0x00032B91
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

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x00033B9F File Offset: 0x00032B9F
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x00033BB1 File Offset: 0x00032BB1
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

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x00033BBF File Offset: 0x00032BBF
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x00033BD1 File Offset: 0x00032BD1
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

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x00033BDF File Offset: 0x00032BDF
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x00033BF1 File Offset: 0x00032BF1
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

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x00033BFF File Offset: 0x00032BFF
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x00033C11 File Offset: 0x00032C11
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

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x00033C1F File Offset: 0x00032C1F
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x00033C31 File Offset: 0x00032C31
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

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x00033C3F File Offset: 0x00032C3F
		// (set) Token: 0x0600313D RID: 12605 RVA: 0x00033C4E File Offset: 0x00032C4E
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

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x00033C59 File Offset: 0x00032C59
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x00033C68 File Offset: 0x00032C68
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

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x00033C73 File Offset: 0x00032C73
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x00033C85 File Offset: 0x00032C85
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

		// Token: 0x06003142 RID: 12610 RVA: 0x00033C93 File Offset: 0x00032C93
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x00033CB1 File Offset: 0x00032CB1
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x00033CCE File Offset: 0x00032CCE
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x00033CDD File Offset: 0x00032CDD
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

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x00033CE8 File Offset: 0x00032CE8
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x00033CF7 File Offset: 0x00032CF7
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

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00033D02 File Offset: 0x00032D02
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x00033D11 File Offset: 0x00032D11
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

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x00033D1C File Offset: 0x00032D1C
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x00033D2B File Offset: 0x00032D2B
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

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x00033D36 File Offset: 0x00032D36
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x00033D48 File Offset: 0x00032D48
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

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x00033D56 File Offset: 0x00032D56
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x00033D68 File Offset: 0x00032D68
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

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x00033D76 File Offset: 0x00032D76
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x00033D88 File Offset: 0x00032D88
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

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x00033D96 File Offset: 0x00032D96
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x00033DA8 File Offset: 0x00032DA8
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x00033DB6 File Offset: 0x00032DB6
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x00033DC5 File Offset: 0x00032DC5
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

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x00033DD0 File Offset: 0x00032DD0
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x00033DDF File Offset: 0x00032DDF
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

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x00033DEA File Offset: 0x00032DEA
		// (set) Token: 0x06003159 RID: 12633 RVA: 0x00033DFC File Offset: 0x00032DFC
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x00033E0A File Offset: 0x00032E0A
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x00033E19 File Offset: 0x00032E19
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

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x00033E24 File Offset: 0x00032E24
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x00033E36 File Offset: 0x00032E36
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

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x00033E44 File Offset: 0x00032E44
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x00033E56 File Offset: 0x00032E56
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

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x00033E64 File Offset: 0x00032E64
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x00033E76 File Offset: 0x00032E76
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

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x00033E84 File Offset: 0x00032E84
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x00033E96 File Offset: 0x00032E96
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

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x00033EA4 File Offset: 0x00032EA4
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x00033EB6 File Offset: 0x00032EB6
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

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x00033EC4 File Offset: 0x00032EC4
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x00033ED6 File Offset: 0x00032ED6
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

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x00033EE4 File Offset: 0x00032EE4
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x00033EF6 File Offset: 0x00032EF6
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

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x00033F04 File Offset: 0x00032F04
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x00033F16 File Offset: 0x00032F16
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

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x00033F24 File Offset: 0x00032F24
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x00033F36 File Offset: 0x00032F36
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

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x00033F44 File Offset: 0x00032F44
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x00033F56 File Offset: 0x00032F56
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

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06003170 RID: 12656 RVA: 0x00033F64 File Offset: 0x00032F64
		// (set) Token: 0x06003171 RID: 12657 RVA: 0x00033F76 File Offset: 0x00032F76
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

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x00033F84 File Offset: 0x00032F84
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x00033F96 File Offset: 0x00032F96
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

		// Token: 0x06003174 RID: 12660 RVA: 0x00033FA4 File Offset: 0x00032FA4
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00033FC2 File Offset: 0x00032FC2
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x00033FDF File Offset: 0x00032FDF
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x00033FF1 File Offset: 0x00032FF1
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

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x00033FFF File Offset: 0x00032FFF
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x00034011 File Offset: 0x00033011
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

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x0003401F File Offset: 0x0003301F
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x00034031 File Offset: 0x00033031
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

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0003403F File Offset: 0x0003303F
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x00034051 File Offset: 0x00033051
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

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0003405F File Offset: 0x0003305F
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x00034071 File Offset: 0x00033071
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

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x0003407F File Offset: 0x0003307F
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x00034091 File Offset: 0x00033091
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

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0003409F File Offset: 0x0003309F
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x000340B1 File Offset: 0x000330B1
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

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x000340BF File Offset: 0x000330BF
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x000340D1 File Offset: 0x000330D1
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

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x000340DF File Offset: 0x000330DF
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x000340EE File Offset: 0x000330EE
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

		// Token: 0x06003188 RID: 12680 RVA: 0x000340F9 File Offset: 0x000330F9
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00034117 File Offset: 0x00033117
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x00034134 File Offset: 0x00033134
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x00034143 File Offset: 0x00033143
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

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x0003414E File Offset: 0x0003314E
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x0003415D File Offset: 0x0003315D
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

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x00034168 File Offset: 0x00033168
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x00034177 File Offset: 0x00033177
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

		// Token: 0x06003190 RID: 12688 RVA: 0x00034184 File Offset: 0x00033184
		public FIXAllocationReport()
		{
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0003421C File Offset: 0x0003321C
		public FIXAllocationReport(string AllocReportID, char AllocTransType, int AllocReportType, int AllocStatus, int AllocNoOrdersType, char Side, double Quantity, double AvgPx, DateTime TradeDate)
		{
			this.AllocReportID = AllocReportID;
			this.AllocTransType = AllocTransType;
			this.AllocReportType = AllocReportType;
			this.AllocStatus = AllocStatus;
			this.AllocNoOrdersType = AllocNoOrdersType;
			this.Side = Side;
			this.Quantity = Quantity;
			this.AvgPx = AvgPx;
			this.TradeDate = TradeDate;
		}

		// Token: 0x0400042D RID: 1069
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400042E RID: 1070
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400042F RID: 1071
		private ArrayList fOrdersGroup = new ArrayList();

		// Token: 0x04000430 RID: 1072
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x04000431 RID: 1073
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000432 RID: 1074
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000433 RID: 1075
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x04000434 RID: 1076
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000435 RID: 1077
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000436 RID: 1078
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000437 RID: 1079
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000438 RID: 1080
		private ArrayList fAllocsGroup = new ArrayList();
	}
}
