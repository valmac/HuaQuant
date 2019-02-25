using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000077 RID: 119
	public class FIXSettlementInstructionRequest : FIXMessage
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x000171F5 File Offset: 0x000161F5
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x00017207 File Offset: 0x00016207
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

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00017215 File Offset: 0x00016215
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x00017224 File Offset: 0x00016224
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0001722F File Offset: 0x0001622F
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0001723E File Offset: 0x0001623E
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

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00017249 File Offset: 0x00016249
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00017258 File Offset: 0x00016258
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00017263 File Offset: 0x00016263
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00017272 File Offset: 0x00016272
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

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0001727D File Offset: 0x0001627D
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0001728C File Offset: 0x0001628C
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00017297 File Offset: 0x00016297
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x000172A9 File Offset: 0x000162A9
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x000172B7 File Offset: 0x000162B7
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x000172C6 File Offset: 0x000162C6
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000172D1 File Offset: 0x000162D1
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x000172E0 File Offset: 0x000162E0
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

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x000172EB File Offset: 0x000162EB
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x000172FA File Offset: 0x000162FA
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

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00017305 File Offset: 0x00016305
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x00017314 File Offset: 0x00016314
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0001731F File Offset: 0x0001631F
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00017331 File Offset: 0x00016331
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

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0001733F File Offset: 0x0001633F
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0001734E File Offset: 0x0001634E
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00017359 File Offset: 0x00016359
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x00017367 File Offset: 0x00016367
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00017371 File Offset: 0x00016371
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x00017380 File Offset: 0x00016380
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

		// Token: 0x060014AF RID: 5295 RVA: 0x0001738B File Offset: 0x0001638B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0001739E File Offset: 0x0001639E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000173AD File Offset: 0x000163AD
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x000173BF File Offset: 0x000163BF
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000173CD File Offset: 0x000163CD
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x000173DF File Offset: 0x000163DF
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

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x000173ED File Offset: 0x000163ED
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x000173FC File Offset: 0x000163FC
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00017407 File Offset: 0x00016407
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x00017416 File Offset: 0x00016416
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

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00017421 File Offset: 0x00016421
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x00017430 File Offset: 0x00016430
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

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0001743B File Offset: 0x0001643B
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x0001744A File Offset: 0x0001644A
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00017455 File Offset: 0x00016455
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x00017467 File Offset: 0x00016467
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00017475 File Offset: 0x00016475
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00017487 File Offset: 0x00016487
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00017495 File Offset: 0x00016495
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x000174A7 File Offset: 0x000164A7
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

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x000174B5 File Offset: 0x000164B5
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x000174C7 File Offset: 0x000164C7
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000174D5 File Offset: 0x000164D5
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x000174E7 File Offset: 0x000164E7
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

		// Token: 0x060014C7 RID: 5319 RVA: 0x000174F5 File Offset: 0x000164F5
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00017513 File Offset: 0x00016513
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00017530 File Offset: 0x00016530
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00017542 File Offset: 0x00016542
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

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00017550 File Offset: 0x00016550
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x00017562 File Offset: 0x00016562
		[FIXField("791", EFieldOption.Required)]
		public string SettlInstReqID
		{
			get
			{
				return this.GetStringField(791).Value;
			}
			set
			{
				this.AddStringField(791, value);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00017570 File Offset: 0x00016570
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0001757F File Offset: 0x0001657F
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

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0001758A File Offset: 0x0001658A
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0001759C File Offset: 0x0001659C
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

		// Token: 0x060014D1 RID: 5329 RVA: 0x000175AA File Offset: 0x000165AA
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000175C8 File Offset: 0x000165C8
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x000175E5 File Offset: 0x000165E5
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x000175F4 File Offset: 0x000165F4
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x000175FF File Offset: 0x000165FF
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x00017611 File Offset: 0x00016611
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

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0001761F File Offset: 0x0001661F
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0001762E File Offset: 0x0001662E
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

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00017639 File Offset: 0x00016639
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0001764B File Offset: 0x0001664B
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

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00017659 File Offset: 0x00016659
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0001766B File Offset: 0x0001666B
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

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00017679 File Offset: 0x00016679
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x0001768B File Offset: 0x0001668B
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00017699 File Offset: 0x00016699
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x000176AB File Offset: 0x000166AB
		[FIXField("168", EFieldOption.Optional)]
		public DateTime EffectiveTime
		{
			get
			{
				return this.GetDateTimeField(168).Value;
			}
			set
			{
				this.AddDateTimeField(168, value);
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000176B9 File Offset: 0x000166B9
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x000176C8 File Offset: 0x000166C8
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

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000176D3 File Offset: 0x000166D3
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000176E5 File Offset: 0x000166E5
		[FIXField("779", EFieldOption.Optional)]
		public DateTime LastUpdateTime
		{
			get
			{
				return this.GetDateTimeField(779).Value;
			}
			set
			{
				this.AddDateTimeField(779, value);
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000176F3 File Offset: 0x000166F3
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x00017705 File Offset: 0x00016705
		[FIXField("169", EFieldOption.Optional)]
		public int StandInstDbType
		{
			get
			{
				return this.GetIntField(169).Value;
			}
			set
			{
				this.AddIntField(169, value);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00017713 File Offset: 0x00016713
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x00017725 File Offset: 0x00016725
		[FIXField("170", EFieldOption.Optional)]
		public string StandInstDbName
		{
			get
			{
				return this.GetStringField(170).Value;
			}
			set
			{
				this.AddStringField(170, value);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x00017733 File Offset: 0x00016733
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x00017745 File Offset: 0x00016745
		[FIXField("171", EFieldOption.Optional)]
		public string StandInstDbID
		{
			get
			{
				return this.GetStringField(171).Value;
			}
			set
			{
				this.AddStringField(171, value);
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00017753 File Offset: 0x00016753
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x00017762 File Offset: 0x00016762
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0001776D File Offset: 0x0001676D
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0001777C File Offset: 0x0001677C
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00017787 File Offset: 0x00016787
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x00017796 File Offset: 0x00016796
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

		// Token: 0x060014F1 RID: 5361 RVA: 0x000177A1 File Offset: 0x000167A1
		public FIXSettlementInstructionRequest()
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000177CA File Offset: 0x000167CA
		public FIXSettlementInstructionRequest(string SettlInstReqID, DateTime TransactTime)
		{
			this.SettlInstReqID = SettlInstReqID;
			this.TransactTime = TransactTime;
		}

		// Token: 0x04000284 RID: 644
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000285 RID: 645
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000286 RID: 646
		private ArrayList fPartyIDsGroup = new ArrayList();
	}
}
