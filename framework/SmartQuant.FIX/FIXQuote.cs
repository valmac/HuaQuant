using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200012E RID: 302
	public class FIXQuote : FIXMessage
	{
		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x0003B21F File Offset: 0x0003A21F
		// (set) Token: 0x06003826 RID: 14374 RVA: 0x0003B231 File Offset: 0x0003A231
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

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x0003B23F File Offset: 0x0003A23F
		// (set) Token: 0x06003828 RID: 14376 RVA: 0x0003B24E File Offset: 0x0003A24E
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

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x0003B259 File Offset: 0x0003A259
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x0003B268 File Offset: 0x0003A268
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

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x0003B273 File Offset: 0x0003A273
		// (set) Token: 0x0600382C RID: 14380 RVA: 0x0003B282 File Offset: 0x0003A282
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

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x0003B28D File Offset: 0x0003A28D
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x0003B29C File Offset: 0x0003A29C
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

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0003B2A7 File Offset: 0x0003A2A7
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x0003B2B6 File Offset: 0x0003A2B6
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

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0003B2C1 File Offset: 0x0003A2C1
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x0003B2D3 File Offset: 0x0003A2D3
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

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x0003B2E1 File Offset: 0x0003A2E1
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x0003B2F0 File Offset: 0x0003A2F0
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

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x0003B2FB File Offset: 0x0003A2FB
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x0003B30A File Offset: 0x0003A30A
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

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x0003B315 File Offset: 0x0003A315
		// (set) Token: 0x06003838 RID: 14392 RVA: 0x0003B324 File Offset: 0x0003A324
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

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x0003B32F File Offset: 0x0003A32F
		// (set) Token: 0x0600383A RID: 14394 RVA: 0x0003B33E File Offset: 0x0003A33E
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

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x0003B349 File Offset: 0x0003A349
		// (set) Token: 0x0600383C RID: 14396 RVA: 0x0003B35B File Offset: 0x0003A35B
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

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x0003B369 File Offset: 0x0003A369
		// (set) Token: 0x0600383E RID: 14398 RVA: 0x0003B378 File Offset: 0x0003A378
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

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x0003B383 File Offset: 0x0003A383
		// (set) Token: 0x06003840 RID: 14400 RVA: 0x0003B391 File Offset: 0x0003A391
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

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x0003B39B File Offset: 0x0003A39B
		// (set) Token: 0x06003842 RID: 14402 RVA: 0x0003B3AA File Offset: 0x0003A3AA
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

		// Token: 0x06003843 RID: 14403 RVA: 0x0003B3B5 File Offset: 0x0003A3B5
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0003B3C8 File Offset: 0x0003A3C8
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06003845 RID: 14405 RVA: 0x0003B3D7 File Offset: 0x0003A3D7
		// (set) Token: 0x06003846 RID: 14406 RVA: 0x0003B3E9 File Offset: 0x0003A3E9
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

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x0003B3F7 File Offset: 0x0003A3F7
		// (set) Token: 0x06003848 RID: 14408 RVA: 0x0003B409 File Offset: 0x0003A409
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

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06003849 RID: 14409 RVA: 0x0003B417 File Offset: 0x0003A417
		// (set) Token: 0x0600384A RID: 14410 RVA: 0x0003B426 File Offset: 0x0003A426
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

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x0003B431 File Offset: 0x0003A431
		// (set) Token: 0x0600384C RID: 14412 RVA: 0x0003B440 File Offset: 0x0003A440
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

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x0003B44B File Offset: 0x0003A44B
		// (set) Token: 0x0600384E RID: 14414 RVA: 0x0003B45A File Offset: 0x0003A45A
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

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x0003B465 File Offset: 0x0003A465
		// (set) Token: 0x06003850 RID: 14416 RVA: 0x0003B474 File Offset: 0x0003A474
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

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0003B47F File Offset: 0x0003A47F
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x0003B491 File Offset: 0x0003A491
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

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0003B49F File Offset: 0x0003A49F
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x0003B4B1 File Offset: 0x0003A4B1
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

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0003B4BF File Offset: 0x0003A4BF
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x0003B4D1 File Offset: 0x0003A4D1
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

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x0003B4DF File Offset: 0x0003A4DF
		// (set) Token: 0x06003858 RID: 14424 RVA: 0x0003B4F1 File Offset: 0x0003A4F1
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

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x0003B4FF File Offset: 0x0003A4FF
		// (set) Token: 0x0600385A RID: 14426 RVA: 0x0003B511 File Offset: 0x0003A511
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

		// Token: 0x0600385B RID: 14427 RVA: 0x0003B51F File Offset: 0x0003A51F
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x0003B53D File Offset: 0x0003A53D
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x0003B55A File Offset: 0x0003A55A
		// (set) Token: 0x0600385E RID: 14430 RVA: 0x0003B56C File Offset: 0x0003A56C
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

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x0003B57A File Offset: 0x0003A57A
		// (set) Token: 0x06003860 RID: 14432 RVA: 0x0003B58C File Offset: 0x0003A58C
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

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x0003B59A File Offset: 0x0003A59A
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x0003B5A9 File Offset: 0x0003A5A9
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

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x0003B5B4 File Offset: 0x0003A5B4
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x0003B5C6 File Offset: 0x0003A5C6
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0003B5D4 File Offset: 0x0003A5D4
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0003B5E6 File Offset: 0x0003A5E6
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

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0003B5F4 File Offset: 0x0003A5F4
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0003B606 File Offset: 0x0003A606
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

		// Token: 0x06003869 RID: 14441 RVA: 0x0003B614 File Offset: 0x0003A614
		public FIXQuoteQualifiersGroup GetQuoteQualifiersGroup(int i)
		{
			if (i < this.NoQuoteQualifiers)
			{
				return (FIXQuoteQualifiersGroup)this.fQuoteQualifiersGroup[i];
			}
			return null;
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x0003B632 File Offset: 0x0003A632
		public void AddGroup(FIXQuoteQualifiersGroup group)
		{
			this.fQuoteQualifiersGroup.Add(group);
			this.NoQuoteQualifiers++;
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0003B64F File Offset: 0x0003A64F
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0003B661 File Offset: 0x0003A661
		[FIXField("301", EFieldOption.Optional)]
		public int QuoteResponseLevel
		{
			get
			{
				return this.GetIntField(301).Value;
			}
			set
			{
				this.AddIntField(301, value);
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x0003B66F File Offset: 0x0003A66F
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x0003B681 File Offset: 0x0003A681
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

		// Token: 0x0600386F RID: 14447 RVA: 0x0003B68F File Offset: 0x0003A68F
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x0003B6AD File Offset: 0x0003A6AD
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x0003B6CA File Offset: 0x0003A6CA
		// (set) Token: 0x06003872 RID: 14450 RVA: 0x0003B6DC File Offset: 0x0003A6DC
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

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x0003B6EA File Offset: 0x0003A6EA
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x0003B6FC File Offset: 0x0003A6FC
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

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x0003B70A File Offset: 0x0003A70A
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x0003B719 File Offset: 0x0003A719
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

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x0003B724 File Offset: 0x0003A724
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x0003B733 File Offset: 0x0003A733
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

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x0003B73E File Offset: 0x0003A73E
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x0003B74D File Offset: 0x0003A74D
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

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x0003B758 File Offset: 0x0003A758
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x0003B767 File Offset: 0x0003A767
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

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0003B772 File Offset: 0x0003A772
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x0003B784 File Offset: 0x0003A784
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

		// Token: 0x0600387F RID: 14463 RVA: 0x0003B792 File Offset: 0x0003A792
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0003B7B0 File Offset: 0x0003A7B0
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x0003B7CD File Offset: 0x0003A7CD
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x0003B7DF File Offset: 0x0003A7DF
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

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x0003B7ED File Offset: 0x0003A7ED
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x0003B7FF File Offset: 0x0003A7FF
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

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x0003B80D File Offset: 0x0003A80D
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x0003B81F File Offset: 0x0003A81F
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

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x0003B82D File Offset: 0x0003A82D
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x0003B83F File Offset: 0x0003A83F
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

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x0003B84D File Offset: 0x0003A84D
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x0003B85F File Offset: 0x0003A85F
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

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x0003B86D File Offset: 0x0003A86D
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x0003B87F File Offset: 0x0003A87F
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

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x0003B88D File Offset: 0x0003A88D
		// (set) Token: 0x0600388E RID: 14478 RVA: 0x0003B89F File Offset: 0x0003A89F
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

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x0003B8AD File Offset: 0x0003A8AD
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x0003B8BF File Offset: 0x0003A8BF
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

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x0003B8CD File Offset: 0x0003A8CD
		// (set) Token: 0x06003892 RID: 14482 RVA: 0x0003B8DF File Offset: 0x0003A8DF
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

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x0003B8ED File Offset: 0x0003A8ED
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x0003B8FF File Offset: 0x0003A8FF
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

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x0003B90D File Offset: 0x0003A90D
		// (set) Token: 0x06003896 RID: 14486 RVA: 0x0003B91F File Offset: 0x0003A91F
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

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x0003B92D File Offset: 0x0003A92D
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x0003B93F File Offset: 0x0003A93F
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

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06003899 RID: 14489 RVA: 0x0003B94D File Offset: 0x0003A94D
		// (set) Token: 0x0600389A RID: 14490 RVA: 0x0003B95F File Offset: 0x0003A95F
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

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x0600389B RID: 14491 RVA: 0x0003B96D File Offset: 0x0003A96D
		// (set) Token: 0x0600389C RID: 14492 RVA: 0x0003B97F File Offset: 0x0003A97F
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

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x0003B98D File Offset: 0x0003A98D
		// (set) Token: 0x0600389E RID: 14494 RVA: 0x0003B99F File Offset: 0x0003A99F
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

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x0600389F RID: 14495 RVA: 0x0003B9AD File Offset: 0x0003A9AD
		// (set) Token: 0x060038A0 RID: 14496 RVA: 0x0003B9BF File Offset: 0x0003A9BF
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

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x0003B9CD File Offset: 0x0003A9CD
		// (set) Token: 0x060038A2 RID: 14498 RVA: 0x0003B9DF File Offset: 0x0003A9DF
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

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x0003B9ED File Offset: 0x0003A9ED
		// (set) Token: 0x060038A4 RID: 14500 RVA: 0x0003B9FF File Offset: 0x0003A9FF
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

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x0003BA0D File Offset: 0x0003AA0D
		// (set) Token: 0x060038A6 RID: 14502 RVA: 0x0003BA1F File Offset: 0x0003AA1F
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

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x0003BA2D File Offset: 0x0003AA2D
		// (set) Token: 0x060038A8 RID: 14504 RVA: 0x0003BA3F File Offset: 0x0003AA3F
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

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x0003BA4D File Offset: 0x0003AA4D
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x0003BA5F File Offset: 0x0003AA5F
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

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x0003BA6D File Offset: 0x0003AA6D
		// (set) Token: 0x060038AC RID: 14508 RVA: 0x0003BA7F File Offset: 0x0003AA7F
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

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x0003BA8D File Offset: 0x0003AA8D
		// (set) Token: 0x060038AE RID: 14510 RVA: 0x0003BA9F File Offset: 0x0003AA9F
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

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x0003BAAD File Offset: 0x0003AAAD
		// (set) Token: 0x060038B0 RID: 14512 RVA: 0x0003BABF File Offset: 0x0003AABF
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

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x0003BACD File Offset: 0x0003AACD
		// (set) Token: 0x060038B2 RID: 14514 RVA: 0x0003BADC File Offset: 0x0003AADC
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

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x0003BAE7 File Offset: 0x0003AAE7
		// (set) Token: 0x060038B4 RID: 14516 RVA: 0x0003BAF9 File Offset: 0x0003AAF9
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

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x0003BB07 File Offset: 0x0003AB07
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x0003BB19 File Offset: 0x0003AB19
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

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x0003BB27 File Offset: 0x0003AB27
		// (set) Token: 0x060038B8 RID: 14520 RVA: 0x0003BB36 File Offset: 0x0003AB36
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

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x0003BB41 File Offset: 0x0003AB41
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x0003BB53 File Offset: 0x0003AB53
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

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x0003BB61 File Offset: 0x0003AB61
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x0003BB73 File Offset: 0x0003AB73
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

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x0003BB81 File Offset: 0x0003AB81
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x0003BB93 File Offset: 0x0003AB93
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

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x0003BBA1 File Offset: 0x0003ABA1
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x0003BBB3 File Offset: 0x0003ABB3
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

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x0003BBC1 File Offset: 0x0003ABC1
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x0003BBD3 File Offset: 0x0003ABD3
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

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x0003BBE1 File Offset: 0x0003ABE1
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x0003BBF3 File Offset: 0x0003ABF3
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

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x0003BC01 File Offset: 0x0003AC01
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x0003BC13 File Offset: 0x0003AC13
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

		// Token: 0x060038C7 RID: 14535 RVA: 0x0003BC21 File Offset: 0x0003AC21
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0003BC3F File Offset: 0x0003AC3F
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0003BC5C File Offset: 0x0003AC5C
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x0003BC6E File Offset: 0x0003AC6E
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

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0003BC7C File Offset: 0x0003AC7C
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x0003BC8E File Offset: 0x0003AC8E
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

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x0003BC9C File Offset: 0x0003AC9C
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x0003BCAE File Offset: 0x0003ACAE
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

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x0003BCBC File Offset: 0x0003ACBC
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x0003BCCE File Offset: 0x0003ACCE
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

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x0003BCDC File Offset: 0x0003ACDC
		// (set) Token: 0x060038D2 RID: 14546 RVA: 0x0003BCEE File Offset: 0x0003ACEE
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

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x0003BCFC File Offset: 0x0003ACFC
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x0003BD0E File Offset: 0x0003AD0E
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

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x0003BD1C File Offset: 0x0003AD1C
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x0003BD2E File Offset: 0x0003AD2E
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

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x0003BD3C File Offset: 0x0003AD3C
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x0003BD4E File Offset: 0x0003AD4E
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

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x0003BD5C File Offset: 0x0003AD5C
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x0003BD6E File Offset: 0x0003AD6E
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

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x0003BD7C File Offset: 0x0003AD7C
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x0003BD8E File Offset: 0x0003AD8E
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

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x0003BD9C File Offset: 0x0003AD9C
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x0003BDAE File Offset: 0x0003ADAE
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

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x0003BDBC File Offset: 0x0003ADBC
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x0003BDCE File Offset: 0x0003ADCE
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

		// Token: 0x060038E1 RID: 14561 RVA: 0x0003BDDC File Offset: 0x0003ADDC
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0003BDFA File Offset: 0x0003ADFA
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x0003BE17 File Offset: 0x0003AE17
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x0003BE26 File Offset: 0x0003AE26
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

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0003BE31 File Offset: 0x0003AE31
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x0003BE40 File Offset: 0x0003AE40
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

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x0003BE4B File Offset: 0x0003AE4B
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x0003BE5D File Offset: 0x0003AE5D
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

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x0003BE6B File Offset: 0x0003AE6B
		// (set) Token: 0x060038EA RID: 14570 RVA: 0x0003BE7D File Offset: 0x0003AE7D
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x0003BE8B File Offset: 0x0003AE8B
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0003BE9D File Offset: 0x0003AE9D
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

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x0003BEAB File Offset: 0x0003AEAB
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x0003BEBD File Offset: 0x0003AEBD
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

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0003BECB File Offset: 0x0003AECB
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x0003BEDA File Offset: 0x0003AEDA
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

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x0003BEE5 File Offset: 0x0003AEE5
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x0003BEF4 File Offset: 0x0003AEF4
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

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x0003BEFF File Offset: 0x0003AEFF
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x0003BF11 File Offset: 0x0003AF11
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

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x0003BF1F File Offset: 0x0003AF1F
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x0003BF31 File Offset: 0x0003AF31
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

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0003BF3F File Offset: 0x0003AF3F
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0003BF4E File Offset: 0x0003AF4E
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

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x0003BF59 File Offset: 0x0003AF59
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0003BF6B File Offset: 0x0003AF6B
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

		// Token: 0x060038FB RID: 14587 RVA: 0x0003BF79 File Offset: 0x0003AF79
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x0003BF97 File Offset: 0x0003AF97
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x0003BFB4 File Offset: 0x0003AFB4
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0003BFC2 File Offset: 0x0003AFC2
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

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x0003BFCC File Offset: 0x0003AFCC
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x0003BFDE File Offset: 0x0003AFDE
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

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x0003BFEC File Offset: 0x0003AFEC
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x0003BFFE File Offset: 0x0003AFFE
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

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x0003C00C File Offset: 0x0003B00C
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x0003C01E File Offset: 0x0003B01E
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

		// Token: 0x06003905 RID: 14597 RVA: 0x0003C02C File Offset: 0x0003B02C
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x0003C04A File Offset: 0x0003B04A
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x0003C067 File Offset: 0x0003B067
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x0003C079 File Offset: 0x0003B079
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

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x0003C087 File Offset: 0x0003B087
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x0003C099 File Offset: 0x0003B099
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

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x0003C0A7 File Offset: 0x0003B0A7
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x0003C0B9 File Offset: 0x0003B0B9
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

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x0003C0C7 File Offset: 0x0003B0C7
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x0003C0D9 File Offset: 0x0003B0D9
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

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x0003C0E7 File Offset: 0x0003B0E7
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x0003C0F9 File Offset: 0x0003B0F9
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

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0003C107 File Offset: 0x0003B107
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x0003C119 File Offset: 0x0003B119
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

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x0003C127 File Offset: 0x0003B127
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x0003C139 File Offset: 0x0003B139
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

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x0003C147 File Offset: 0x0003B147
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x0003C159 File Offset: 0x0003B159
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

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06003917 RID: 14615 RVA: 0x0003C167 File Offset: 0x0003B167
		// (set) Token: 0x06003918 RID: 14616 RVA: 0x0003C176 File Offset: 0x0003B176
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

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x0003C181 File Offset: 0x0003B181
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x0003C193 File Offset: 0x0003B193
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

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x0003C1A1 File Offset: 0x0003B1A1
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x0003C1B3 File Offset: 0x0003B1B3
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x0003C1C1 File Offset: 0x0003B1C1
		// (set) Token: 0x0600391E RID: 14622 RVA: 0x0003C1D3 File Offset: 0x0003B1D3
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

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x0003C1E1 File Offset: 0x0003B1E1
		// (set) Token: 0x06003920 RID: 14624 RVA: 0x0003C1F3 File Offset: 0x0003B1F3
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

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06003921 RID: 14625 RVA: 0x0003C201 File Offset: 0x0003B201
		// (set) Token: 0x06003922 RID: 14626 RVA: 0x0003C213 File Offset: 0x0003B213
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

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x0003C221 File Offset: 0x0003B221
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x0003C233 File Offset: 0x0003B233
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

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x0003C241 File Offset: 0x0003B241
		// (set) Token: 0x06003926 RID: 14630 RVA: 0x0003C253 File Offset: 0x0003B253
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

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0003C261 File Offset: 0x0003B261
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x0003C273 File Offset: 0x0003B273
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

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x0003C281 File Offset: 0x0003B281
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x0003C290 File Offset: 0x0003B290
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

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x0003C29B File Offset: 0x0003B29B
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x0003C2AA File Offset: 0x0003B2AA
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

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x0003C2B5 File Offset: 0x0003B2B5
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x0003C2C7 File Offset: 0x0003B2C7
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

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x0003C2D5 File Offset: 0x0003B2D5
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x0003C2E7 File Offset: 0x0003B2E7
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x0003C2F5 File Offset: 0x0003B2F5
		// (set) Token: 0x06003932 RID: 14642 RVA: 0x0003C307 File Offset: 0x0003B307
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

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0003C315 File Offset: 0x0003B315
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x0003C327 File Offset: 0x0003B327
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

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x0003C335 File Offset: 0x0003B335
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x0003C347 File Offset: 0x0003B347
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

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0003C355 File Offset: 0x0003B355
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x0003C364 File Offset: 0x0003B364
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

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0003C36F File Offset: 0x0003B36F
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x0003C37E File Offset: 0x0003B37E
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

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x0003C389 File Offset: 0x0003B389
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x0003C39B File Offset: 0x0003B39B
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

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x0003C3A9 File Offset: 0x0003B3A9
		// (set) Token: 0x0600393E RID: 14654 RVA: 0x0003C3B8 File Offset: 0x0003B3B8
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

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x0003C3C3 File Offset: 0x0003B3C3
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x0003C3D5 File Offset: 0x0003B3D5
		[FIXField("528", EFieldOption.Optional)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharField(528).Value;
			}
			set
			{
				this.AddCharField(528, value);
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x0003C3E3 File Offset: 0x0003B3E3
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x0003C3F5 File Offset: 0x0003B3F5
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

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x0003C403 File Offset: 0x0003B403
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x0003C415 File Offset: 0x0003B415
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

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x0003C423 File Offset: 0x0003B423
		// (set) Token: 0x06003946 RID: 14662 RVA: 0x0003C435 File Offset: 0x0003B435
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

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x0003C443 File Offset: 0x0003B443
		// (set) Token: 0x06003948 RID: 14664 RVA: 0x0003C455 File Offset: 0x0003B455
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

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0003C463 File Offset: 0x0003B463
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x0003C475 File Offset: 0x0003B475
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

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x0003C483 File Offset: 0x0003B483
		// (set) Token: 0x0600394C RID: 14668 RVA: 0x0003C495 File Offset: 0x0003B495
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

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x0003C4A3 File Offset: 0x0003B4A3
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x0003C4B5 File Offset: 0x0003B4B5
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

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0003C4C3 File Offset: 0x0003B4C3
		// (set) Token: 0x06003950 RID: 14672 RVA: 0x0003C4D5 File Offset: 0x0003B4D5
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

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0003C4E3 File Offset: 0x0003B4E3
		// (set) Token: 0x06003952 RID: 14674 RVA: 0x0003C4F5 File Offset: 0x0003B4F5
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

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06003953 RID: 14675 RVA: 0x0003C503 File Offset: 0x0003B503
		// (set) Token: 0x06003954 RID: 14676 RVA: 0x0003C515 File Offset: 0x0003B515
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

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x0003C523 File Offset: 0x0003B523
		// (set) Token: 0x06003956 RID: 14678 RVA: 0x0003C535 File Offset: 0x0003B535
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

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x0003C543 File Offset: 0x0003B543
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x0003C555 File Offset: 0x0003B555
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

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x0003C563 File Offset: 0x0003B563
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x0003C575 File Offset: 0x0003B575
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

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x0003C583 File Offset: 0x0003B583
		// (set) Token: 0x0600395C RID: 14684 RVA: 0x0003C595 File Offset: 0x0003B595
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

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0003C5A3 File Offset: 0x0003B5A3
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x0003C5B5 File Offset: 0x0003B5B5
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

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x0003C5C3 File Offset: 0x0003B5C3
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x0003C5D2 File Offset: 0x0003B5D2
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

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0003C5DD File Offset: 0x0003B5DD
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x0003C5EF File Offset: 0x0003B5EF
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

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x0003C5FD File Offset: 0x0003B5FD
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x0003C60F File Offset: 0x0003B60F
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

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x0003C61D File Offset: 0x0003B61D
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x0003C62C File Offset: 0x0003B62C
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

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x0003C637 File Offset: 0x0003B637
		// (set) Token: 0x06003968 RID: 14696 RVA: 0x0003C646 File Offset: 0x0003B646
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

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x0003C651 File Offset: 0x0003B651
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x0003C660 File Offset: 0x0003B660
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

		// Token: 0x0600396B RID: 14699 RVA: 0x0003C66C File Offset: 0x0003B66C
		public FIXQuote()
		{
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0003C6E4 File Offset: 0x0003B6E4
		public FIXQuote(string QuoteID)
		{
			this.QuoteID = QuoteID;
		}

		// Token: 0x0400051E RID: 1310
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400051F RID: 1311
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000520 RID: 1312
		private ArrayList fQuoteQualifiersGroup = new ArrayList();

		// Token: 0x04000521 RID: 1313
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000522 RID: 1314
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000523 RID: 1315
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000524 RID: 1316
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000525 RID: 1317
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000526 RID: 1318
		private ArrayList fLegsGroup = new ArrayList();
	}
}
