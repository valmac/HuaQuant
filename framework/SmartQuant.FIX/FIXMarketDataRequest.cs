using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200014E RID: 334
	public class FIXMarketDataRequest : FIXMessage
	{
		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06003FAC RID: 16300 RVA: 0x00045647 File Offset: 0x00044647
		// (set) Token: 0x06003FAD RID: 16301 RVA: 0x00045654 File Offset: 0x00044654
		[FIXField("144", EFieldOption.Optional)]
		public string OnBehalfOfLocationID
		{
			get
			{
				return this.GetStringValue(144);
			}
			set
			{
				this.SetStringValue(144, value);
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06003FAE RID: 16302 RVA: 0x00045662 File Offset: 0x00044662
		// (set) Token: 0x06003FAF RID: 16303 RVA: 0x0004566C File Offset: 0x0004466C
		[FIXField("9", EFieldOption.Required)]
		public int BodyLength
		{
			get
			{
				return this.GetIntValue(9);
			}
			set
			{
				this.SetIntValue(9, value);
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x00045677 File Offset: 0x00044677
		// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x00045681 File Offset: 0x00044681
		[FIXField("35", EFieldOption.Required)]
		public string MsgType
		{
			get
			{
				return this.GetStringValue(35);
			}
			set
			{
				this.SetStringValue(35, value);
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x0004568C File Offset: 0x0004468C
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x00045696 File Offset: 0x00044696
		[FIXField("49", EFieldOption.Required)]
		public string SenderCompID
		{
			get
			{
				return this.GetStringValue(49);
			}
			set
			{
				this.SetStringValue(49, value);
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06003FB4 RID: 16308 RVA: 0x000456A1 File Offset: 0x000446A1
		// (set) Token: 0x06003FB5 RID: 16309 RVA: 0x000456AB File Offset: 0x000446AB
		[FIXField("56", EFieldOption.Required)]
		public string TargetCompID
		{
			get
			{
				return this.GetStringValue(56);
			}
			set
			{
				this.SetStringValue(56, value);
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06003FB6 RID: 16310 RVA: 0x000456B6 File Offset: 0x000446B6
		// (set) Token: 0x06003FB7 RID: 16311 RVA: 0x000456C0 File Offset: 0x000446C0
		[FIXField("115", EFieldOption.Optional)]
		public string OnBehalfOfCompID
		{
			get
			{
				return this.GetStringValue(115);
			}
			set
			{
				this.SetStringValue(115, value);
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06003FB8 RID: 16312 RVA: 0x000456CB File Offset: 0x000446CB
		// (set) Token: 0x06003FB9 RID: 16313 RVA: 0x000456D8 File Offset: 0x000446D8
		[FIXField("128", EFieldOption.Optional)]
		public string DeliverToCompID
		{
			get
			{
				return this.GetStringValue(128);
			}
			set
			{
				this.SetStringValue(128, value);
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06003FBA RID: 16314 RVA: 0x000456E6 File Offset: 0x000446E6
		// (set) Token: 0x06003FBB RID: 16315 RVA: 0x000456F0 File Offset: 0x000446F0
		[FIXField("90", EFieldOption.Optional)]
		public int SecureDataLen
		{
			get
			{
				return this.GetIntValue(90);
			}
			set
			{
				this.SetIntValue(90, value);
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06003FBC RID: 16316 RVA: 0x000456FB File Offset: 0x000446FB
		// (set) Token: 0x06003FBD RID: 16317 RVA: 0x00045705 File Offset: 0x00044705
		[FIXField("91", EFieldOption.Optional)]
		public string SecureData
		{
			get
			{
				return this.GetStringValue(91);
			}
			set
			{
				this.SetStringValue(91, value);
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06003FBE RID: 16318 RVA: 0x00045710 File Offset: 0x00044710
		// (set) Token: 0x06003FBF RID: 16319 RVA: 0x0004571A File Offset: 0x0004471A
		[FIXField("34", EFieldOption.Required)]
		public int MsgSeqNum
		{
			get
			{
				return this.GetIntValue(34);
			}
			set
			{
				this.SetIntValue(34, value);
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x00045725 File Offset: 0x00044725
		// (set) Token: 0x06003FC1 RID: 16321 RVA: 0x0004572F File Offset: 0x0004472F
		[FIXField("50", EFieldOption.Optional)]
		public string SenderSubID
		{
			get
			{
				return this.GetStringValue(50);
			}
			set
			{
				this.SetStringValue(50, value);
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06003FC2 RID: 16322 RVA: 0x0004573A File Offset: 0x0004473A
		// (set) Token: 0x06003FC3 RID: 16323 RVA: 0x00045747 File Offset: 0x00044747
		[FIXField("142", EFieldOption.Optional)]
		public string SenderLocationID
		{
			get
			{
				return this.GetStringValue(142);
			}
			set
			{
				this.SetStringValue(142, value);
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x00045755 File Offset: 0x00044755
		// (set) Token: 0x06003FC5 RID: 16325 RVA: 0x0004575F File Offset: 0x0004475F
		[FIXField("57", EFieldOption.Optional)]
		public string TargetSubID
		{
			get
			{
				return this.GetStringValue(57);
			}
			set
			{
				this.SetStringValue(57, value);
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x0004576A File Offset: 0x0004476A
		// (set) Token: 0x06003FC7 RID: 16327 RVA: 0x00045773 File Offset: 0x00044773
		[FIXField("8", EFieldOption.Required)]
		public string BeginString
		{
			get
			{
				return this.GetStringValue(8);
			}
			set
			{
				this.SetStringValue(8, value);
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06003FC8 RID: 16328 RVA: 0x0004577D File Offset: 0x0004477D
		// (set) Token: 0x06003FC9 RID: 16329 RVA: 0x00045787 File Offset: 0x00044787
		[FIXField("116", EFieldOption.Optional)]
		public string OnBehalfOfSubID
		{
			get
			{
				return this.GetStringValue(116);
			}
			set
			{
				this.SetStringValue(116, value);
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00045792 File Offset: 0x00044792
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x000457A5 File Offset: 0x000447A5
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x000457B4 File Offset: 0x000447B4
		// (set) Token: 0x06003FCD RID: 16333 RVA: 0x000457C1 File Offset: 0x000447C1
		[FIXField("129", EFieldOption.Optional)]
		public string DeliverToSubID
		{
			get
			{
				return this.GetStringValue(129);
			}
			set
			{
				this.SetStringValue(129, value);
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x000457CF File Offset: 0x000447CF
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x000457DC File Offset: 0x000447DC
		[FIXField("145", EFieldOption.Optional)]
		public string DeliverToLocationID
		{
			get
			{
				return this.GetStringValue(145);
			}
			set
			{
				this.SetStringValue(145, value);
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x000457EA File Offset: 0x000447EA
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x000457F4 File Offset: 0x000447F4
		[FIXField("43", EFieldOption.Optional)]
		public bool PossDupFlag
		{
			get
			{
				return this.GetBoolValue(43);
			}
			set
			{
				this.SetBoolValue(43, value);
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x000457FF File Offset: 0x000447FF
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x00045809 File Offset: 0x00044809
		[FIXField("97", EFieldOption.Optional)]
		public bool PossResend
		{
			get
			{
				return this.GetBoolValue(97);
			}
			set
			{
				this.SetBoolValue(97, value);
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x00045814 File Offset: 0x00044814
		// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x0004581E File Offset: 0x0004481E
		[FIXField("52", EFieldOption.Optional)]
		public DateTime SendingTime
		{
			get
			{
				return this.GetDateTimeValue(52);
			}
			set
			{
				this.SetDateTimeValue(52, value);
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06003FD6 RID: 16342 RVA: 0x00045829 File Offset: 0x00044829
		// (set) Token: 0x06003FD7 RID: 16343 RVA: 0x00045833 File Offset: 0x00044833
		[FIXField("122", EFieldOption.Optional)]
		public DateTime OrigSendingTime
		{
			get
			{
				return this.GetDateTimeValue(122);
			}
			set
			{
				this.SetDateTimeValue(122, value);
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x0004583E File Offset: 0x0004483E
		// (set) Token: 0x06003FD9 RID: 16345 RVA: 0x0004584B File Offset: 0x0004484B
		[FIXField("212", EFieldOption.Optional)]
		public int XmlDataLen
		{
			get
			{
				return this.GetIntValue(212);
			}
			set
			{
				this.SetIntValue(212, value);
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06003FDA RID: 16346 RVA: 0x00045859 File Offset: 0x00044859
		// (set) Token: 0x06003FDB RID: 16347 RVA: 0x00045866 File Offset: 0x00044866
		[FIXField("213", EFieldOption.Optional)]
		public string XmlData
		{
			get
			{
				return this.GetStringValue(213);
			}
			set
			{
				this.SetStringValue(213, value);
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x00045874 File Offset: 0x00044874
		// (set) Token: 0x06003FDD RID: 16349 RVA: 0x00045881 File Offset: 0x00044881
		[FIXField("347", EFieldOption.Optional)]
		public string MessageEncoding
		{
			get
			{
				return this.GetStringValue(347);
			}
			set
			{
				this.SetStringValue(347, value);
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06003FDE RID: 16350 RVA: 0x0004588F File Offset: 0x0004488F
		// (set) Token: 0x06003FDF RID: 16351 RVA: 0x0004589C File Offset: 0x0004489C
		[FIXField("369", EFieldOption.Optional)]
		public int LastMsgSeqNumProcessed
		{
			get
			{
				return this.GetIntValue(369);
			}
			set
			{
				this.SetIntValue(369, value);
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06003FE0 RID: 16352 RVA: 0x000458AA File Offset: 0x000448AA
		// (set) Token: 0x06003FE1 RID: 16353 RVA: 0x000458B7 File Offset: 0x000448B7
		[FIXField("627", EFieldOption.Optional)]
		public int NoHops
		{
			get
			{
				return this.GetIntValue(627);
			}
			set
			{
				this.SetIntValue(627, value);
			}
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x000458C5 File Offset: 0x000448C5
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x000458E3 File Offset: 0x000448E3
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06003FE4 RID: 16356 RVA: 0x00045900 File Offset: 0x00044900
		// (set) Token: 0x06003FE5 RID: 16357 RVA: 0x0004590D File Offset: 0x0004490D
		[FIXField("143", EFieldOption.Optional)]
		public string TargetLocationID
		{
			get
			{
				return this.GetStringValue(143);
			}
			set
			{
				this.SetStringValue(143, value);
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x0004591B File Offset: 0x0004491B
		// (set) Token: 0x06003FE7 RID: 16359 RVA: 0x00045928 File Offset: 0x00044928
		[FIXField("262", EFieldOption.Required)]
		public string MDReqID
		{
			get
			{
				return this.GetStringValue(262);
			}
			set
			{
				this.SetStringValue(262, value);
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06003FE8 RID: 16360 RVA: 0x00045936 File Offset: 0x00044936
		// (set) Token: 0x06003FE9 RID: 16361 RVA: 0x00045943 File Offset: 0x00044943
		[FIXField("263", EFieldOption.Required)]
		public char SubscriptionRequestType
		{
			get
			{
				return this.GetCharValue(263);
			}
			set
			{
				this.SetCharValue(263, value);
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06003FEA RID: 16362 RVA: 0x00045951 File Offset: 0x00044951
		// (set) Token: 0x06003FEB RID: 16363 RVA: 0x0004595E File Offset: 0x0004495E
		[FIXField("264", EFieldOption.Required)]
		public int MarketDepth
		{
			get
			{
				return this.GetIntValue(264);
			}
			set
			{
				this.SetIntValue(264, value);
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x0004596C File Offset: 0x0004496C
		// (set) Token: 0x06003FED RID: 16365 RVA: 0x00045979 File Offset: 0x00044979
		[FIXField("265", EFieldOption.Optional)]
		public int MDUpdateType
		{
			get
			{
				return this.GetIntValue(265);
			}
			set
			{
				this.SetIntValue(265, value);
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x00045987 File Offset: 0x00044987
		// (set) Token: 0x06003FEF RID: 16367 RVA: 0x00045994 File Offset: 0x00044994
		[FIXField("266", EFieldOption.Optional)]
		public bool AggregatedBook
		{
			get
			{
				return this.GetBoolValue(266);
			}
			set
			{
				this.SetBoolValue(266, value);
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x000459A2 File Offset: 0x000449A2
		// (set) Token: 0x06003FF1 RID: 16369 RVA: 0x000459AF File Offset: 0x000449AF
		[FIXField("286", EFieldOption.Optional)]
		public string OpenCloseSettlFlag
		{
			get
			{
				return this.GetStringValue(286);
			}
			set
			{
				this.SetStringValue(286, value);
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x000459BD File Offset: 0x000449BD
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x000459CA File Offset: 0x000449CA
		[FIXField("546", EFieldOption.Optional)]
		public string Scope
		{
			get
			{
				return this.GetStringValue(546);
			}
			set
			{
				this.SetStringValue(546, value);
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x000459D8 File Offset: 0x000449D8
		// (set) Token: 0x06003FF5 RID: 16373 RVA: 0x000459E5 File Offset: 0x000449E5
		[FIXField("547", EFieldOption.Optional)]
		public bool MDImplicitDelete
		{
			get
			{
				return this.GetBoolValue(547);
			}
			set
			{
				this.SetBoolValue(547, value);
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x000459F3 File Offset: 0x000449F3
		// (set) Token: 0x06003FF7 RID: 16375 RVA: 0x00045A00 File Offset: 0x00044A00
		[FIXField("267", EFieldOption.Required)]
		public int NoMDEntryTypes
		{
			get
			{
				return this.GetIntValue(267);
			}
			set
			{
				this.SetIntValue(267, value);
			}
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00045A0E File Offset: 0x00044A0E
		public FIXMDEntryTypesGroup GetMDEntryTypesGroup(int i)
		{
			if (i < this.NoMDEntryTypes)
			{
				return (FIXMDEntryTypesGroup)this.fMDEntryTypesGroup[i];
			}
			return null;
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00045A2C File Offset: 0x00044A2C
		public void RemoveMDEntryTypesGroup(int i)
		{
			if (i < this.NoMDEntryTypes)
			{
				this.fMDEntryTypesGroup.RemoveAt(i);
				this.NoMDEntryTypes--;
			}
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x00045A51 File Offset: 0x00044A51
		public void AddGroup(FIXMDEntryTypesGroup group)
		{
			this.fMDEntryTypesGroup.Add(group);
			this.NoMDEntryTypes++;
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x00045A6E File Offset: 0x00044A6E
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x00045A7B File Offset: 0x00044A7B
		[FIXField("146", EFieldOption.Required)]
		public int NoRelatedSym
		{
			get
			{
				return this.GetIntValue(146);
			}
			set
			{
				this.SetIntValue(146, value);
			}
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x00045A89 File Offset: 0x00044A89
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x00045AA7 File Offset: 0x00044AA7
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x00045AC4 File Offset: 0x00044AC4
		// (set) Token: 0x06004000 RID: 16384 RVA: 0x00045AD1 File Offset: 0x00044AD1
		[FIXField("386", EFieldOption.Optional)]
		public int NoTradingSessions
		{
			get
			{
				return this.GetIntValue(386);
			}
			set
			{
				this.SetIntValue(386, value);
			}
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00045ADF File Offset: 0x00044ADF
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00045AFD File Offset: 0x00044AFD
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06004003 RID: 16387 RVA: 0x00045B1A File Offset: 0x00044B1A
		// (set) Token: 0x06004004 RID: 16388 RVA: 0x00045B27 File Offset: 0x00044B27
		[FIXField("815", EFieldOption.Optional)]
		public int ApplQueueAction
		{
			get
			{
				return this.GetIntValue(815);
			}
			set
			{
				this.SetIntValue(815, value);
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x00045B35 File Offset: 0x00044B35
		// (set) Token: 0x06004006 RID: 16390 RVA: 0x00045B42 File Offset: 0x00044B42
		[FIXField("812", EFieldOption.Optional)]
		public int ApplQueueMax
		{
			get
			{
				return this.GetIntValue(812);
			}
			set
			{
				this.SetIntValue(812, value);
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x00045B50 File Offset: 0x00044B50
		// (set) Token: 0x06004008 RID: 16392 RVA: 0x00045B5A File Offset: 0x00044B5A
		[FIXField("10", EFieldOption.Required)]
		public string CheckSum
		{
			get
			{
				return this.GetStringValue(10);
			}
			set
			{
				this.SetStringValue(10, value);
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x00045B65 File Offset: 0x00044B65
		// (set) Token: 0x0600400A RID: 16394 RVA: 0x00045B6F File Offset: 0x00044B6F
		[FIXField("89", EFieldOption.Optional)]
		public string Signature
		{
			get
			{
				return this.GetStringValue(89);
			}
			set
			{
				this.SetStringValue(89, value);
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x00045B7A File Offset: 0x00044B7A
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x00045B84 File Offset: 0x00044B84
		[FIXField("93", EFieldOption.Optional)]
		public int SignatureLength
		{
			get
			{
				return this.GetIntValue(93);
			}
			set
			{
				this.SetIntValue(93, value);
			}
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00045B90 File Offset: 0x00044B90
		public FIXMarketDataRequest()
		{
			this.NoRelatedSym = 0;
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00045BE4 File Offset: 0x00044BE4
		public FIXMarketDataRequest(string MDReqID, char SubscriptionRequestType, int MarketDepth, int NoMDEntryTypes, int NoRelatedSym)
		{
			this.MDReqID = MDReqID;
			this.SubscriptionRequestType = SubscriptionRequestType;
			this.MarketDepth = MarketDepth;
			this.NoMDEntryTypes = NoMDEntryTypes;
			this.NoRelatedSym = NoRelatedSym;
		}

		// Token: 0x04000957 RID: 2391
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000958 RID: 2392
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000959 RID: 2393
		private ArrayList fMDEntryTypesGroup = new ArrayList();

		// Token: 0x0400095A RID: 2394
		private ArrayList fRelatedSymGroup = new ArrayList();

		// Token: 0x0400095B RID: 2395
		private ArrayList fTradingSessionsGroup = new ArrayList();
	}
}
