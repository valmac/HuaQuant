using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000020 RID: 32
	public class FIXSecurityTypes : FIXMessage
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00008159 File Offset: 0x00007159
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0000816B File Offset: 0x0000716B
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00008179 File Offset: 0x00007179
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00008188 File Offset: 0x00007188
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00008193 File Offset: 0x00007193
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000081A2 File Offset: 0x000071A2
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000081AD File Offset: 0x000071AD
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x000081BC File Offset: 0x000071BC
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x000081C7 File Offset: 0x000071C7
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x000081D6 File Offset: 0x000071D6
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x000081E1 File Offset: 0x000071E1
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x000081F0 File Offset: 0x000071F0
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000081FB File Offset: 0x000071FB
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0000820D File Offset: 0x0000720D
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

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0000821B File Offset: 0x0000721B
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0000822A File Offset: 0x0000722A
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00008235 File Offset: 0x00007235
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00008244 File Offset: 0x00007244
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0000824F File Offset: 0x0000724F
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0000825E File Offset: 0x0000725E
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00008269 File Offset: 0x00007269
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00008278 File Offset: 0x00007278
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00008283 File Offset: 0x00007283
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00008295 File Offset: 0x00007295
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000082A3 File Offset: 0x000072A3
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000082B2 File Offset: 0x000072B2
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000082BD File Offset: 0x000072BD
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000082CB File Offset: 0x000072CB
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000082D5 File Offset: 0x000072D5
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000082E4 File Offset: 0x000072E4
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

		// Token: 0x06000595 RID: 1429 RVA: 0x000082EF File Offset: 0x000072EF
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00008302 File Offset: 0x00007302
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00008311 File Offset: 0x00007311
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00008323 File Offset: 0x00007323
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00008331 File Offset: 0x00007331
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00008343 File Offset: 0x00007343
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00008351 File Offset: 0x00007351
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00008360 File Offset: 0x00007360
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000836B File Offset: 0x0000736B
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0000837A File Offset: 0x0000737A
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00008385 File Offset: 0x00007385
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00008394 File Offset: 0x00007394
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000839F File Offset: 0x0000739F
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x000083AE File Offset: 0x000073AE
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000083B9 File Offset: 0x000073B9
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x000083CB File Offset: 0x000073CB
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000083D9 File Offset: 0x000073D9
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x000083EB File Offset: 0x000073EB
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000083F9 File Offset: 0x000073F9
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0000840B File Offset: 0x0000740B
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00008419 File Offset: 0x00007419
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0000842B File Offset: 0x0000742B
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00008439 File Offset: 0x00007439
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000844B File Offset: 0x0000744B
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

		// Token: 0x060005AD RID: 1453 RVA: 0x00008459 File Offset: 0x00007459
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00008477 File Offset: 0x00007477
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00008494 File Offset: 0x00007494
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000084A6 File Offset: 0x000074A6
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000084B4 File Offset: 0x000074B4
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000084C6 File Offset: 0x000074C6
		[FIXField("320", EFieldOption.Required)]
		public string SecurityReqID
		{
			get
			{
				return this.GetStringField(320).Value;
			}
			set
			{
				this.AddStringField(320, value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000084D4 File Offset: 0x000074D4
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000084E6 File Offset: 0x000074E6
		[FIXField("322", EFieldOption.Required)]
		public string SecurityResponseID
		{
			get
			{
				return this.GetStringField(322).Value;
			}
			set
			{
				this.AddStringField(322, value);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000084F4 File Offset: 0x000074F4
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00008506 File Offset: 0x00007506
		[FIXField("323", EFieldOption.Required)]
		public int SecurityResponseType
		{
			get
			{
				return this.GetIntField(323).Value;
			}
			set
			{
				this.AddIntField(323, value);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00008514 File Offset: 0x00007514
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00008526 File Offset: 0x00007526
		[FIXField("557", EFieldOption.Optional)]
		public int TotNoSecurityTypes
		{
			get
			{
				return this.GetIntField(557).Value;
			}
			set
			{
				this.AddIntField(557, value);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00008534 File Offset: 0x00007534
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00008546 File Offset: 0x00007546
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00008554 File Offset: 0x00007554
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00008566 File Offset: 0x00007566
		[FIXField("558", EFieldOption.Optional)]
		public int NoSecurityTypes
		{
			get
			{
				return this.GetIntField(558).Value;
			}
			set
			{
				this.AddIntField(558, value);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00008574 File Offset: 0x00007574
		public FIXSecurityTypesGroup GetSecurityTypesGroup(int i)
		{
			if (i < this.NoSecurityTypes)
			{
				return (FIXSecurityTypesGroup)this.fSecurityTypesGroup[i];
			}
			return null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00008592 File Offset: 0x00007592
		public void AddGroup(FIXSecurityTypesGroup group)
		{
			this.fSecurityTypesGroup.Add(group);
			this.NoSecurityTypes++;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x000085AF File Offset: 0x000075AF
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000085BE File Offset: 0x000075BE
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000085C9 File Offset: 0x000075C9
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000085DB File Offset: 0x000075DB
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000085E9 File Offset: 0x000075E9
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000085FB File Offset: 0x000075FB
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00008609 File Offset: 0x00007609
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0000861B File Offset: 0x0000761B
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00008629 File Offset: 0x00007629
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0000863B File Offset: 0x0000763B
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00008649 File Offset: 0x00007649
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0000865B File Offset: 0x0000765B
		[FIXField("263", EFieldOption.Optional)]
		public char SubscriptionRequestType
		{
			get
			{
				return this.GetCharField(263).Value;
			}
			set
			{
				this.AddCharField(263, value);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00008669 File Offset: 0x00007669
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00008678 File Offset: 0x00007678
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00008683 File Offset: 0x00007683
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00008692 File Offset: 0x00007692
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

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000869D File Offset: 0x0000769D
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000086AC File Offset: 0x000076AC
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

		// Token: 0x060005D1 RID: 1489 RVA: 0x000086B7 File Offset: 0x000076B7
		public FIXSecurityTypes()
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000086E0 File Offset: 0x000076E0
		public FIXSecurityTypes(string SecurityReqID, string SecurityResponseID, int SecurityResponseType)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityResponseID = SecurityResponseID;
			this.SecurityResponseType = SecurityResponseType;
		}

		// Token: 0x04000049 RID: 73
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400004A RID: 74
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400004B RID: 75
		private ArrayList fSecurityTypesGroup = new ArrayList();
	}
}
