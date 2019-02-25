using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000037 RID: 55
	public class FIXCollateralResponse : FIXMessage
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0000F3E1 File Offset: 0x0000E3E1
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0000F3F3 File Offset: 0x0000E3F3
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

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0000F401 File Offset: 0x0000E401
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x0000F410 File Offset: 0x0000E410
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0000F41B File Offset: 0x0000E41B
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0000F42A File Offset: 0x0000E42A
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0000F435 File Offset: 0x0000E435
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x0000F444 File Offset: 0x0000E444
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0000F44F File Offset: 0x0000E44F
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x0000F45E File Offset: 0x0000E45E
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0000F469 File Offset: 0x0000E469
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x0000F478 File Offset: 0x0000E478
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

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0000F483 File Offset: 0x0000E483
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0000F495 File Offset: 0x0000E495
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

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0000F4A3 File Offset: 0x0000E4A3
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0000F4B2 File Offset: 0x0000E4B2
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0000F4BD File Offset: 0x0000E4BD
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x0000F4CC File Offset: 0x0000E4CC
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0000F4D7 File Offset: 0x0000E4D7
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x0000F4E6 File Offset: 0x0000E4E6
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

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0000F4F1 File Offset: 0x0000E4F1
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x0000F500 File Offset: 0x0000E500
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0000F50B File Offset: 0x0000E50B
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x0000F51D File Offset: 0x0000E51D
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

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0000F52B File Offset: 0x0000E52B
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x0000F53A File Offset: 0x0000E53A
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

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0000F545 File Offset: 0x0000E545
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x0000F553 File Offset: 0x0000E553
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

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0000F55D File Offset: 0x0000E55D
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x0000F56C File Offset: 0x0000E56C
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

		// Token: 0x06000CDE RID: 3294 RVA: 0x0000F577 File Offset: 0x0000E577
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0000F58A File Offset: 0x0000E58A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0000F599 File Offset: 0x0000E599
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x0000F5AB File Offset: 0x0000E5AB
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

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0000F5B9 File Offset: 0x0000E5B9
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x0000F5CB File Offset: 0x0000E5CB
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

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0000F5D9 File Offset: 0x0000E5D9
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x0000F5E8 File Offset: 0x0000E5E8
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

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0000F5F3 File Offset: 0x0000E5F3
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x0000F602 File Offset: 0x0000E602
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

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0000F60D File Offset: 0x0000E60D
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x0000F61C File Offset: 0x0000E61C
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0000F627 File Offset: 0x0000E627
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0000F636 File Offset: 0x0000E636
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

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0000F641 File Offset: 0x0000E641
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0000F653 File Offset: 0x0000E653
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0000F661 File Offset: 0x0000E661
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0000F673 File Offset: 0x0000E673
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0000F681 File Offset: 0x0000E681
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0000F693 File Offset: 0x0000E693
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

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0000F6A1 File Offset: 0x0000E6A1
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x0000F6B3 File Offset: 0x0000E6B3
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

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0000F6C1 File Offset: 0x0000E6C1
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0000F6D3 File Offset: 0x0000E6D3
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

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0000F6E1 File Offset: 0x0000E6E1
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0000F6FF File Offset: 0x0000E6FF
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0000F71C File Offset: 0x0000E71C
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x0000F72E File Offset: 0x0000E72E
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

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0000F73C File Offset: 0x0000E73C
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0000F74E File Offset: 0x0000E74E
		[FIXField("904", EFieldOption.Required)]
		public string CollRespID
		{
			get
			{
				return this.GetStringField(904).Value;
			}
			set
			{
				this.AddStringField(904, value);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0000F75C File Offset: 0x0000E75C
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x0000F76E File Offset: 0x0000E76E
		[FIXField("902", EFieldOption.Required)]
		public string CollAsgnID
		{
			get
			{
				return this.GetStringField(902).Value;
			}
			set
			{
				this.AddStringField(902, value);
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0000F77C File Offset: 0x0000E77C
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0000F78E File Offset: 0x0000E78E
		[FIXField("894", EFieldOption.Optional)]
		public string CollReqID
		{
			get
			{
				return this.GetStringField(894).Value;
			}
			set
			{
				this.AddStringField(894, value);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0000F79C File Offset: 0x0000E79C
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0000F7AE File Offset: 0x0000E7AE
		[FIXField("895", EFieldOption.Required)]
		public int CollAsgnReason
		{
			get
			{
				return this.GetIntField(895).Value;
			}
			set
			{
				this.AddIntField(895, value);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0000F7BC File Offset: 0x0000E7BC
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0000F7CE File Offset: 0x0000E7CE
		[FIXField("903", EFieldOption.Optional)]
		public int CollAsgnTransType
		{
			get
			{
				return this.GetIntField(903).Value;
			}
			set
			{
				this.AddIntField(903, value);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0000F7DC File Offset: 0x0000E7DC
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x0000F7EE File Offset: 0x0000E7EE
		[FIXField("905", EFieldOption.Required)]
		public int CollAsgnRespType
		{
			get
			{
				return this.GetIntField(905).Value;
			}
			set
			{
				this.AddIntField(905, value);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0000F7FC File Offset: 0x0000E7FC
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x0000F80E File Offset: 0x0000E80E
		[FIXField("906", EFieldOption.Optional)]
		public int CollAsgnRejectReason
		{
			get
			{
				return this.GetIntField(906).Value;
			}
			set
			{
				this.AddIntField(906, value);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0000F81C File Offset: 0x0000E81C
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0000F82B File Offset: 0x0000E82B
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

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0000F836 File Offset: 0x0000E836
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x0000F848 File Offset: 0x0000E848
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

		// Token: 0x06000D0C RID: 3340 RVA: 0x0000F856 File Offset: 0x0000E856
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0000F874 File Offset: 0x0000E874
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0000F891 File Offset: 0x0000E891
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0000F89F File Offset: 0x0000E89F
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

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0000F8A9 File Offset: 0x0000E8A9
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x0000F8BB File Offset: 0x0000E8BB
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0000F8C9 File Offset: 0x0000E8C9
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0000F8D8 File Offset: 0x0000E8D8
		[FIXField("11", EFieldOption.Optional)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringField(11).Value;
			}
			set
			{
				this.AddStringField(11, value);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0000F8E3 File Offset: 0x0000E8E3
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0000F8F2 File Offset: 0x0000E8F2
		[FIXField("37", EFieldOption.Optional)]
		public string OrderID
		{
			get
			{
				return this.GetStringField(37).Value;
			}
			set
			{
				this.AddStringField(37, value);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0000F8FD File Offset: 0x0000E8FD
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0000F90F File Offset: 0x0000E90F
		[FIXField("198", EFieldOption.Optional)]
		public string SecondaryOrderID
		{
			get
			{
				return this.GetStringField(198).Value;
			}
			set
			{
				this.AddStringField(198, value);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0000F91D File Offset: 0x0000E91D
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x0000F92F File Offset: 0x0000E92F
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringField(526).Value;
			}
			set
			{
				this.AddStringField(526, value);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0000F93D File Offset: 0x0000E93D
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x0000F94C File Offset: 0x0000E94C
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

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000F957 File Offset: 0x0000E957
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0000F975 File Offset: 0x0000E975
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0000F992 File Offset: 0x0000E992
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x0000F9A4 File Offset: 0x0000E9A4
		[FIXField("897", EFieldOption.Optional)]
		public int NoTrades
		{
			get
			{
				return this.GetIntField(897).Value;
			}
			set
			{
				this.AddIntField(897, value);
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0000F9B2 File Offset: 0x0000E9B2
		public FIXTradesGroup GetTradesGroup(int i)
		{
			if (i < this.NoTrades)
			{
				return (FIXTradesGroup)this.fTradesGroup[i];
			}
			return null;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0000F9D0 File Offset: 0x0000E9D0
		public void AddGroup(FIXTradesGroup group)
		{
			this.fTradesGroup.Add(group);
			this.NoTrades++;
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0000F9ED File Offset: 0x0000E9ED
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x0000F9FC File Offset: 0x0000E9FC
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

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0000FA07 File Offset: 0x0000EA07
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x0000FA16 File Offset: 0x0000EA16
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

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0000FA21 File Offset: 0x0000EA21
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0000FA30 File Offset: 0x0000EA30
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

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0000FA3B File Offset: 0x0000EA3B
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0000FA4A File Offset: 0x0000EA4A
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

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0000FA55 File Offset: 0x0000EA55
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x0000FA67 File Offset: 0x0000EA67
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

		// Token: 0x06000D2C RID: 3372 RVA: 0x0000FA75 File Offset: 0x0000EA75
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0000FA93 File Offset: 0x0000EA93
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0000FAB0 File Offset: 0x0000EAB0
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x0000FAC2 File Offset: 0x0000EAC2
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0000FAD0 File Offset: 0x0000EAD0
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0000FAE2 File Offset: 0x0000EAE2
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

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0000FAF0 File Offset: 0x0000EAF0
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x0000FB02 File Offset: 0x0000EB02
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

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0000FB10 File Offset: 0x0000EB10
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0000FB22 File Offset: 0x0000EB22
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0000FB30 File Offset: 0x0000EB30
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0000FB42 File Offset: 0x0000EB42
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0000FB50 File Offset: 0x0000EB50
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x0000FB62 File Offset: 0x0000EB62
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0000FB70 File Offset: 0x0000EB70
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x0000FB82 File Offset: 0x0000EB82
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0000FB90 File Offset: 0x0000EB90
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0000FBA2 File Offset: 0x0000EBA2
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

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0000FBB0 File Offset: 0x0000EBB0
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x0000FBC2 File Offset: 0x0000EBC2
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0000FBD0 File Offset: 0x0000EBD0
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x0000FBE2 File Offset: 0x0000EBE2
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0000FBF0 File Offset: 0x0000EBF0
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x0000FC02 File Offset: 0x0000EC02
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0000FC10 File Offset: 0x0000EC10
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0000FC22 File Offset: 0x0000EC22
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0000FC30 File Offset: 0x0000EC30
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x0000FC42 File Offset: 0x0000EC42
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0000FC50 File Offset: 0x0000EC50
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x0000FC62 File Offset: 0x0000EC62
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0000FC70 File Offset: 0x0000EC70
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0000FC82 File Offset: 0x0000EC82
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

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0000FC90 File Offset: 0x0000EC90
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0000FCA2 File Offset: 0x0000ECA2
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0000FCB0 File Offset: 0x0000ECB0
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0000FCC2 File Offset: 0x0000ECC2
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0000FCD0 File Offset: 0x0000ECD0
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0000FCE2 File Offset: 0x0000ECE2
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0000FCF0 File Offset: 0x0000ECF0
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x0000FD02 File Offset: 0x0000ED02
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0000FD10 File Offset: 0x0000ED10
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x0000FD22 File Offset: 0x0000ED22
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0000FD30 File Offset: 0x0000ED30
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x0000FD42 File Offset: 0x0000ED42
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0000FD50 File Offset: 0x0000ED50
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x0000FD62 File Offset: 0x0000ED62
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0000FD70 File Offset: 0x0000ED70
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x0000FD82 File Offset: 0x0000ED82
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0000FD90 File Offset: 0x0000ED90
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x0000FDA2 File Offset: 0x0000EDA2
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0000FDB0 File Offset: 0x0000EDB0
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0000FDBF File Offset: 0x0000EDBF
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0000FDCA File Offset: 0x0000EDCA
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x0000FDDC File Offset: 0x0000EDDC
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0000FDEA File Offset: 0x0000EDEA
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x0000FDFC File Offset: 0x0000EDFC
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0000FE0A File Offset: 0x0000EE0A
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x0000FE19 File Offset: 0x0000EE19
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

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0000FE24 File Offset: 0x0000EE24
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0000FE36 File Offset: 0x0000EE36
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

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0000FE44 File Offset: 0x0000EE44
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0000FE56 File Offset: 0x0000EE56
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

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0000FE64 File Offset: 0x0000EE64
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0000FE76 File Offset: 0x0000EE76
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

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0000FE84 File Offset: 0x0000EE84
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x0000FE96 File Offset: 0x0000EE96
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

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0000FEA4 File Offset: 0x0000EEA4
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x0000FEB6 File Offset: 0x0000EEB6
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

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0000FEC4 File Offset: 0x0000EEC4
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x0000FED6 File Offset: 0x0000EED6
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0000FEE4 File Offset: 0x0000EEE4
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x0000FEF6 File Offset: 0x0000EEF6
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

		// Token: 0x06000D74 RID: 3444 RVA: 0x0000FF04 File Offset: 0x0000EF04
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0000FF22 File Offset: 0x0000EF22
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0000FF3F File Offset: 0x0000EF3F
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0000FF51 File Offset: 0x0000EF51
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0000FF5F File Offset: 0x0000EF5F
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x0000FF71 File Offset: 0x0000EF71
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

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0000FF7F File Offset: 0x0000EF7F
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0000FF91 File Offset: 0x0000EF91
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

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0000FF9F File Offset: 0x0000EF9F
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0000FFB1 File Offset: 0x0000EFB1
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0000FFBF File Offset: 0x0000EFBF
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x0000FFD1 File Offset: 0x0000EFD1
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0000FFDF File Offset: 0x0000EFDF
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x0000FFF1 File Offset: 0x0000EFF1
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

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0000FFFF File Offset: 0x0000EFFF
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00010011 File Offset: 0x0000F011
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

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0001001F File Offset: 0x0000F01F
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00010031 File Offset: 0x0000F031
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0001003F File Offset: 0x0000F03F
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00010051 File Offset: 0x0000F051
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

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0001005F File Offset: 0x0000F05F
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00010071 File Offset: 0x0000F071
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

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0001007F File Offset: 0x0000F07F
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00010091 File Offset: 0x0000F091
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

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0001009F File Offset: 0x0000F09F
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x000100AE File Offset: 0x0000F0AE
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

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000100B9 File Offset: 0x0000F0B9
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x000100C8 File Offset: 0x0000F0C8
		[FIXField("53", EFieldOption.Optional)]
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

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000100D3 File Offset: 0x0000F0D3
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x000100E5 File Offset: 0x0000F0E5
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

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x000100F3 File Offset: 0x0000F0F3
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00010102 File Offset: 0x0000F102
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

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0001010D File Offset: 0x0000F10D
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x0001011F File Offset: 0x0000F11F
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

		// Token: 0x06000D96 RID: 3478 RVA: 0x0001012D File Offset: 0x0000F12D
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0001014B File Offset: 0x0000F14B
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00010168 File Offset: 0x0000F168
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x0001017A File Offset: 0x0000F17A
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

		// Token: 0x06000D9A RID: 3482 RVA: 0x00010188 File Offset: 0x0000F188
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000101A6 File Offset: 0x0000F1A6
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000101C3 File Offset: 0x0000F1C3
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000101D5 File Offset: 0x0000F1D5
		[FIXField("899", EFieldOption.Optional)]
		public double MarginExcess
		{
			get
			{
				return this.GetDoubleField(899).Value;
			}
			set
			{
				this.AddDoubleField(899, value);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000101E3 File Offset: 0x0000F1E3
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x000101F5 File Offset: 0x0000F1F5
		[FIXField("900", EFieldOption.Optional)]
		public double TotalNetValue
		{
			get
			{
				return this.GetDoubleField(900).Value;
			}
			set
			{
				this.AddDoubleField(900, value);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00010203 File Offset: 0x0000F203
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00010215 File Offset: 0x0000F215
		[FIXField("901", EFieldOption.Optional)]
		public double CashOutstanding
		{
			get
			{
				return this.GetDoubleField(901).Value;
			}
			set
			{
				this.AddDoubleField(901, value);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00010223 File Offset: 0x0000F223
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00010235 File Offset: 0x0000F235
		[FIXField("768", EFieldOption.Optional)]
		public int NoTrdRegTimestamps
		{
			get
			{
				return this.GetIntField(768).Value;
			}
			set
			{
				this.AddIntField(768, value);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00010243 File Offset: 0x0000F243
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00010261 File Offset: 0x0000F261
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0001027E File Offset: 0x0000F27E
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x0001028D File Offset: 0x0000F28D
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

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00010298 File Offset: 0x0000F298
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x000102AA File Offset: 0x0000F2AA
		[FIXField("136", EFieldOption.Optional)]
		public int NoMiscFees
		{
			get
			{
				return this.GetIntField(136).Value;
			}
			set
			{
				this.AddIntField(136, value);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000102B8 File Offset: 0x0000F2B8
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000102D6 File Offset: 0x0000F2D6
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x000102F3 File Offset: 0x0000F2F3
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00010302 File Offset: 0x0000F302
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

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0001030D File Offset: 0x0000F30D
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x0001031F File Offset: 0x0000F31F
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

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0001032D File Offset: 0x0000F32D
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x0001033F File Offset: 0x0000F33F
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0001034D File Offset: 0x0000F34D
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x0001035F File Offset: 0x0000F35F
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

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0001036D File Offset: 0x0000F36D
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x0001037F File Offset: 0x0000F37F
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

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0001038D File Offset: 0x0000F38D
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x0001039F File Offset: 0x0000F39F
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000103AD File Offset: 0x0000F3AD
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000103BF File Offset: 0x0000F3BF
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

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000103CD File Offset: 0x0000F3CD
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000103DF File Offset: 0x0000F3DF
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

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x000103ED File Offset: 0x0000F3ED
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000103FF File Offset: 0x0000F3FF
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

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0001040D File Offset: 0x0000F40D
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x0001041F File Offset: 0x0000F41F
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

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0001042D File Offset: 0x0000F42D
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0001043F File Offset: 0x0000F43F
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

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0001044D File Offset: 0x0000F44D
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0001045F File Offset: 0x0000F45F
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

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0001046D File Offset: 0x0000F46D
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0001047F File Offset: 0x0000F47F
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0001048D File Offset: 0x0000F48D
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0001049F File Offset: 0x0000F49F
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

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x000104AD File Offset: 0x0000F4AD
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x000104BF File Offset: 0x0000F4BF
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

		// Token: 0x06000DCA RID: 3530 RVA: 0x000104CD File Offset: 0x0000F4CD
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000104EB File Offset: 0x0000F4EB
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00010508 File Offset: 0x0000F508
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00010517 File Offset: 0x0000F517
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

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00010522 File Offset: 0x0000F522
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00010534 File Offset: 0x0000F534
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

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00010542 File Offset: 0x0000F542
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00010554 File Offset: 0x0000F554
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

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00010562 File Offset: 0x0000F562
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00010571 File Offset: 0x0000F571
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

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0001057C File Offset: 0x0000F57C
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0001058B File Offset: 0x0000F58B
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00010596 File Offset: 0x0000F596
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000105A5 File Offset: 0x0000F5A5
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

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000105B0 File Offset: 0x0000F5B0
		public FIXCollateralResponse()
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00010648 File Offset: 0x0000F648
		public FIXCollateralResponse(string CollRespID, string CollAsgnID, int CollAsgnReason, int CollAsgnRespType, DateTime TransactTime)
		{
			this.CollRespID = CollRespID;
			this.CollAsgnID = CollAsgnID;
			this.CollAsgnReason = CollAsgnReason;
			this.CollAsgnRespType = CollAsgnRespType;
			this.TransactTime = TransactTime;
		}

		// Token: 0x0400009E RID: 158
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400009F RID: 159
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040000A0 RID: 160
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040000A1 RID: 161
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x040000A2 RID: 162
		private ArrayList fTradesGroup = new ArrayList();

		// Token: 0x040000A3 RID: 163
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040000A4 RID: 164
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040000A5 RID: 165
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040000A6 RID: 166
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040000A7 RID: 167
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x040000A8 RID: 168
		private ArrayList fMiscFeesGroup = new ArrayList();

		// Token: 0x040000A9 RID: 169
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
