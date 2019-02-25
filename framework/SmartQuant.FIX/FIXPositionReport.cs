using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000022 RID: 34
	public class FIXPositionReport : FIXMessage
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0000873E File Offset: 0x0000773E
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0000874B File Offset: 0x0000774B
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00008759 File Offset: 0x00007759
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00008763 File Offset: 0x00007763
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0000876E File Offset: 0x0000776E
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00008778 File Offset: 0x00007778
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00008783 File Offset: 0x00007783
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0000878D File Offset: 0x0000778D
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

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00008798 File Offset: 0x00007798
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x000087A2 File Offset: 0x000077A2
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x000087AD File Offset: 0x000077AD
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x000087B7 File Offset: 0x000077B7
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000087C2 File Offset: 0x000077C2
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x000087CF File Offset: 0x000077CF
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000087DD File Offset: 0x000077DD
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x000087E7 File Offset: 0x000077E7
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000087F2 File Offset: 0x000077F2
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x000087FC File Offset: 0x000077FC
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00008807 File Offset: 0x00007807
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00008811 File Offset: 0x00007811
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0000881C File Offset: 0x0000781C
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00008826 File Offset: 0x00007826
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00008831 File Offset: 0x00007831
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x0000883E File Offset: 0x0000783E
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0000884C File Offset: 0x0000784C
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00008856 File Offset: 0x00007856
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00008861 File Offset: 0x00007861
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x0000886A File Offset: 0x0000786A
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00008874 File Offset: 0x00007874
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0000887E File Offset: 0x0000787E
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

		// Token: 0x060005F4 RID: 1524 RVA: 0x00008889 File Offset: 0x00007889
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000889C File Offset: 0x0000789C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x000088AB File Offset: 0x000078AB
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x000088B8 File Offset: 0x000078B8
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x000088C6 File Offset: 0x000078C6
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x000088D3 File Offset: 0x000078D3
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x000088E1 File Offset: 0x000078E1
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x000088EB File Offset: 0x000078EB
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000088F6 File Offset: 0x000078F6
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00008900 File Offset: 0x00007900
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0000890B File Offset: 0x0000790B
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00008915 File Offset: 0x00007915
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00008920 File Offset: 0x00007920
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0000892A File Offset: 0x0000792A
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00008935 File Offset: 0x00007935
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00008942 File Offset: 0x00007942
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00008950 File Offset: 0x00007950
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0000895D File Offset: 0x0000795D
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0000896B File Offset: 0x0000796B
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00008978 File Offset: 0x00007978
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

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00008986 File Offset: 0x00007986
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00008993 File Offset: 0x00007993
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000089A1 File Offset: 0x000079A1
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x000089AE File Offset: 0x000079AE
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

		// Token: 0x0600060C RID: 1548 RVA: 0x000089BC File Offset: 0x000079BC
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000089DA File Offset: 0x000079DA
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000089F7 File Offset: 0x000079F7
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00008A04 File Offset: 0x00007A04
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00008A12 File Offset: 0x00007A12
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00008A1F File Offset: 0x00007A1F
		[FIXField("721", EFieldOption.Required)]
		public string PosMaintRptID
		{
			get
			{
				return this.GetStringValue(721);
			}
			set
			{
				this.SetStringValue(721, value);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00008A2D File Offset: 0x00007A2D
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00008A3A File Offset: 0x00007A3A
		[FIXField("710", EFieldOption.Optional)]
		public string PosReqID
		{
			get
			{
				return this.GetStringValue(710);
			}
			set
			{
				this.SetStringValue(710, value);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00008A48 File Offset: 0x00007A48
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00008A55 File Offset: 0x00007A55
		[FIXField("724", EFieldOption.Optional)]
		public int PosReqType
		{
			get
			{
				return this.GetIntValue(724);
			}
			set
			{
				this.SetIntValue(724, value);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00008A63 File Offset: 0x00007A63
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00008A70 File Offset: 0x00007A70
		[FIXField("263", EFieldOption.Optional)]
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00008A7E File Offset: 0x00007A7E
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00008A8B File Offset: 0x00007A8B
		[FIXField("727", EFieldOption.Optional)]
		public int TotalNumPosReports
		{
			get
			{
				return this.GetIntValue(727);
			}
			set
			{
				this.SetIntValue(727, value);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00008A99 File Offset: 0x00007A99
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00008AA6 File Offset: 0x00007AA6
		[FIXField("325", EFieldOption.Optional)]
		public bool UnsolicitedIndicator
		{
			get
			{
				return this.GetBoolValue(325);
			}
			set
			{
				this.SetBoolValue(325, value);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00008AB4 File Offset: 0x00007AB4
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00008AC1 File Offset: 0x00007AC1
		[FIXField("728", EFieldOption.Required)]
		public int PosReqResult
		{
			get
			{
				return this.GetIntValue(728);
			}
			set
			{
				this.SetIntValue(728, value);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00008ACF File Offset: 0x00007ACF
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00008ADC File Offset: 0x00007ADC
		[FIXField("715", EFieldOption.Required)]
		public DateTime ClearingBusinessDate
		{
			get
			{
				return this.GetDateTimeValue(715);
			}
			set
			{
				this.SetDateTimeValue(715, value);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00008AEA File Offset: 0x00007AEA
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00008AF7 File Offset: 0x00007AF7
		[FIXField("716", EFieldOption.Optional)]
		public string SettlSessID
		{
			get
			{
				return this.GetStringValue(716);
			}
			set
			{
				this.SetStringValue(716, value);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00008B05 File Offset: 0x00007B05
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00008B12 File Offset: 0x00007B12
		[FIXField("717", EFieldOption.Optional)]
		public string SettlSessSubID
		{
			get
			{
				return this.GetStringValue(717);
			}
			set
			{
				this.SetStringValue(717, value);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00008B20 File Offset: 0x00007B20
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00008B2D File Offset: 0x00007B2D
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntValue(453);
			}
			set
			{
				this.SetIntValue(453, value);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00008B3B File Offset: 0x00007B3B
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00008B59 File Offset: 0x00007B59
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00008B76 File Offset: 0x00007B76
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00008B7F File Offset: 0x00007B7F
		[FIXField("1", EFieldOption.Required)]
		public string Account
		{
			get
			{
				return this.GetStringValue(1);
			}
			set
			{
				this.SetStringValue(1, value);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00008B89 File Offset: 0x00007B89
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00008B96 File Offset: 0x00007B96
		[FIXField("660", EFieldOption.Optional)]
		public int AcctIDSource
		{
			get
			{
				return this.GetIntValue(660);
			}
			set
			{
				this.SetIntValue(660, value);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00008BA4 File Offset: 0x00007BA4
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00008BB1 File Offset: 0x00007BB1
		[FIXField("581", EFieldOption.Required)]
		public int AccountType
		{
			get
			{
				return this.GetIntValue(581);
			}
			set
			{
				this.SetIntValue(581, value);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00008BBF File Offset: 0x00007BBF
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00008BC9 File Offset: 0x00007BC9
		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringValue(55);
			}
			set
			{
				this.SetStringValue(55, value);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00008BD4 File Offset: 0x00007BD4
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00008BDE File Offset: 0x00007BDE
		[FIXField("65", EFieldOption.Optional)]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringValue(65);
			}
			set
			{
				this.SetStringValue(65, value);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00008BE9 File Offset: 0x00007BE9
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00008BF3 File Offset: 0x00007BF3
		[FIXField("48", EFieldOption.Optional)]
		public string SecurityID
		{
			get
			{
				return this.GetStringValue(48);
			}
			set
			{
				this.SetStringValue(48, value);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00008BFE File Offset: 0x00007BFE
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00008C08 File Offset: 0x00007C08
		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringValue(22);
			}
			set
			{
				this.SetStringValue(22, value);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00008C13 File Offset: 0x00007C13
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00008C20 File Offset: 0x00007C20
		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntValue(454);
			}
			set
			{
				this.SetIntValue(454, value);
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00008C2E File Offset: 0x00007C2E
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00008C4C File Offset: 0x00007C4C
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00008C69 File Offset: 0x00007C69
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00008C76 File Offset: 0x00007C76
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntValue(460);
			}
			set
			{
				this.SetIntValue(460, value);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00008C84 File Offset: 0x00007C84
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00008C91 File Offset: 0x00007C91
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringValue(461);
			}
			set
			{
				this.SetStringValue(461, value);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00008C9F File Offset: 0x00007C9F
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00008CAC File Offset: 0x00007CAC
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringValue(167);
			}
			set
			{
				this.SetStringValue(167, value);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00008CBA File Offset: 0x00007CBA
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00008CC7 File Offset: 0x00007CC7
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringValue(762);
			}
			set
			{
				this.SetStringValue(762, value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00008CD5 File Offset: 0x00007CD5
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00008CE2 File Offset: 0x00007CE2
		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringValue(200);
			}
			set
			{
				this.SetStringValue(200, value);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00008CF0 File Offset: 0x00007CF0
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00008CFD File Offset: 0x00007CFD
		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeValue(541);
			}
			set
			{
				this.SetDateTimeValue(541, value);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00008D0B File Offset: 0x00007D0B
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00008D18 File Offset: 0x00007D18
		[FIXField("201", EFieldOption.Optional)]
		public int PutOrCall
		{
			get
			{
				return this.GetIntValue(201);
			}
			set
			{
				this.SetIntValue(201, value);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00008D26 File Offset: 0x00007D26
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00008D33 File Offset: 0x00007D33
		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeValue(224);
			}
			set
			{
				this.SetDateTimeValue(224, value);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00008D41 File Offset: 0x00007D41
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00008D4E File Offset: 0x00007D4E
		[FIXField("225", EFieldOption.Optional)]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeValue(225);
			}
			set
			{
				this.SetDateTimeValue(225, value);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00008D5C File Offset: 0x00007D5C
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00008D69 File Offset: 0x00007D69
		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntValue(239);
			}
			set
			{
				this.SetIntValue(239, value);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00008D77 File Offset: 0x00007D77
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00008D84 File Offset: 0x00007D84
		[FIXField("226", EFieldOption.Optional)]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntValue(226);
			}
			set
			{
				this.SetIntValue(226, value);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00008D92 File Offset: 0x00007D92
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00008D9F File Offset: 0x00007D9F
		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleValue(227);
			}
			set
			{
				this.SetDoubleValue(227, value);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00008DAD File Offset: 0x00007DAD
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00008DBA File Offset: 0x00007DBA
		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleValue(228);
			}
			set
			{
				this.SetDoubleValue(228, value);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00008DC8 File Offset: 0x00007DC8
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00008DD5 File Offset: 0x00007DD5
		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringValue(255);
			}
			set
			{
				this.SetStringValue(255, value);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00008DE3 File Offset: 0x00007DE3
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00008DF0 File Offset: 0x00007DF0
		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringValue(543);
			}
			set
			{
				this.SetStringValue(543, value);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00008DFE File Offset: 0x00007DFE
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00008E0B File Offset: 0x00007E0B
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringValue(470);
			}
			set
			{
				this.SetStringValue(470, value);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00008E19 File Offset: 0x00007E19
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00008E26 File Offset: 0x00007E26
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringValue(471);
			}
			set
			{
				this.SetStringValue(471, value);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00008E34 File Offset: 0x00007E34
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00008E41 File Offset: 0x00007E41
		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringValue(472);
			}
			set
			{
				this.SetStringValue(472, value);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00008E4F File Offset: 0x00007E4F
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00008E5C File Offset: 0x00007E5C
		[FIXField("240", EFieldOption.Optional)]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeValue(240);
			}
			set
			{
				this.SetDateTimeValue(240, value);
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00008E6A File Offset: 0x00007E6A
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00008E77 File Offset: 0x00007E77
		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleValue(202);
			}
			set
			{
				this.SetDoubleValue(202, value);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00008E85 File Offset: 0x00007E85
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00008E92 File Offset: 0x00007E92
		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleValue(947);
			}
			set
			{
				this.SetDoubleValue(947, value);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00008EA0 File Offset: 0x00007EA0
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00008EAD File Offset: 0x00007EAD
		[FIXField("206", EFieldOption.Optional)]
		public char OptAttribute
		{
			get
			{
				return this.GetCharValue(206);
			}
			set
			{
				this.SetCharValue(206, value);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00008EBB File Offset: 0x00007EBB
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00008EC8 File Offset: 0x00007EC8
		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleValue(231);
			}
			set
			{
				this.SetDoubleValue(231, value);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00008ED6 File Offset: 0x00007ED6
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00008EE3 File Offset: 0x00007EE3
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleValue(223);
			}
			set
			{
				this.SetDoubleValue(223, value);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00008EF1 File Offset: 0x00007EF1
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00008EFE File Offset: 0x00007EFE
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringValue(207);
			}
			set
			{
				this.SetStringValue(207, value);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00008F0C File Offset: 0x00007F0C
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00008F16 File Offset: 0x00007F16
		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringValue(106);
			}
			set
			{
				this.SetStringValue(106, value);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00008F21 File Offset: 0x00007F21
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00008F2E File Offset: 0x00007F2E
		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntValue(348);
			}
			set
			{
				this.SetIntValue(348, value);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00008F3C File Offset: 0x00007F3C
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00008F49 File Offset: 0x00007F49
		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringValue(349);
			}
			set
			{
				this.SetStringValue(349, value);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00008F57 File Offset: 0x00007F57
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00008F61 File Offset: 0x00007F61
		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringValue(107);
			}
			set
			{
				this.SetStringValue(107, value);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00008F6C File Offset: 0x00007F6C
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00008F79 File Offset: 0x00007F79
		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntValue(350);
			}
			set
			{
				this.SetIntValue(350, value);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00008F87 File Offset: 0x00007F87
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00008F94 File Offset: 0x00007F94
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringValue(351);
			}
			set
			{
				this.SetStringValue(351, value);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00008FA2 File Offset: 0x00007FA2
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00008FAF File Offset: 0x00007FAF
		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringValue(691);
			}
			set
			{
				this.SetStringValue(691, value);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00008FBD File Offset: 0x00007FBD
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00008FCA File Offset: 0x00007FCA
		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringValue(667);
			}
			set
			{
				this.SetStringValue(667, value);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00008FD8 File Offset: 0x00007FD8
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00008FE5 File Offset: 0x00007FE5
		[FIXField("875", EFieldOption.Optional)]
		public int CPProgram
		{
			get
			{
				return this.GetIntValue(875);
			}
			set
			{
				this.SetIntValue(875, value);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00008FF3 File Offset: 0x00007FF3
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00009000 File Offset: 0x00008000
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringValue(876);
			}
			set
			{
				this.SetStringValue(876, value);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0000900E File Offset: 0x0000800E
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0000901B File Offset: 0x0000801B
		[FIXField("864", EFieldOption.Optional)]
		public int NoEvents
		{
			get
			{
				return this.GetIntValue(864);
			}
			set
			{
				this.SetIntValue(864, value);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00009029 File Offset: 0x00008029
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00009047 File Offset: 0x00008047
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00009064 File Offset: 0x00008064
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00009071 File Offset: 0x00008071
		[FIXField("873", EFieldOption.Optional)]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeValue(873);
			}
			set
			{
				this.SetDateTimeValue(873, value);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0000907F File Offset: 0x0000807F
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x0000908C File Offset: 0x0000808C
		[FIXField("874", EFieldOption.Optional)]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeValue(874);
			}
			set
			{
				this.SetDateTimeValue(874, value);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0000909A File Offset: 0x0000809A
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x000090A4 File Offset: 0x000080A4
		[FIXField("15", EFieldOption.Optional)]
		public string Currency
		{
			get
			{
				return this.GetStringValue(15);
			}
			set
			{
				this.SetStringValue(15, value);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000090AF File Offset: 0x000080AF
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x000090BC File Offset: 0x000080BC
		[FIXField("730", EFieldOption.Required)]
		public double SettlPrice
		{
			get
			{
				return this.GetDoubleValue(730);
			}
			set
			{
				this.SetDoubleValue(730, value);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000090CA File Offset: 0x000080CA
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000090D7 File Offset: 0x000080D7
		[FIXField("731", EFieldOption.Required)]
		public int SettlPriceType
		{
			get
			{
				return this.GetIntValue(731);
			}
			set
			{
				this.SetIntValue(731, value);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000090E5 File Offset: 0x000080E5
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x000090F2 File Offset: 0x000080F2
		[FIXField("734", EFieldOption.Required)]
		public double PriorSettlPrice
		{
			get
			{
				return this.GetDoubleValue(734);
			}
			set
			{
				this.SetDoubleValue(734, value);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00009100 File Offset: 0x00008100
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0000910D File Offset: 0x0000810D
		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntValue(555);
			}
			set
			{
				this.SetIntValue(555, value);
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000911B File Offset: 0x0000811B
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00009139 File Offset: 0x00008139
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00009156 File Offset: 0x00008156
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00009163 File Offset: 0x00008163
		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntValue(711);
			}
			set
			{
				this.SetIntValue(711, value);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00009171 File Offset: 0x00008171
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000918F File Offset: 0x0000818F
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x000091AC File Offset: 0x000081AC
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x000091B9 File Offset: 0x000081B9
		[FIXField("702", EFieldOption.Optional)]
		public int NoPositions
		{
			get
			{
				return this.GetIntValue(702);
			}
			set
			{
				this.SetIntValue(702, value);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000091C7 File Offset: 0x000081C7
		public FIXPositionsGroup GetPositionsGroup(int i)
		{
			if (i < this.NoPositions)
			{
				return (FIXPositionsGroup)this.fPositionsGroup[i];
			}
			return null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000091E5 File Offset: 0x000081E5
		public void AddGroup(FIXPositionsGroup group)
		{
			this.fPositionsGroup.Add(group);
			this.NoPositions++;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00009202 File Offset: 0x00008202
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0000920F File Offset: 0x0000820F
		[FIXField("753", EFieldOption.Optional)]
		public int NoPosAmt
		{
			get
			{
				return this.GetIntValue(753);
			}
			set
			{
				this.SetIntValue(753, value);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000921D File Offset: 0x0000821D
		public FIXPosAmtGroup GetPosAmtGroup(int i)
		{
			if (i < this.NoPosAmt)
			{
				return (FIXPosAmtGroup)this.fPosAmtGroup[i];
			}
			return null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0000923B File Offset: 0x0000823B
		public void AddGroup(FIXPosAmtGroup group)
		{
			this.fPosAmtGroup.Add(group);
			this.NoPosAmt++;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00009258 File Offset: 0x00008258
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00009265 File Offset: 0x00008265
		[FIXField("506", EFieldOption.Optional)]
		public char RegistStatus
		{
			get
			{
				return this.GetCharValue(506);
			}
			set
			{
				this.SetCharValue(506, value);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00009273 File Offset: 0x00008273
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00009280 File Offset: 0x00008280
		[FIXField("743", EFieldOption.Optional)]
		public DateTime DeliveryDate
		{
			get
			{
				return this.GetDateTimeValue(743);
			}
			set
			{
				this.SetDateTimeValue(743, value);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0000928E File Offset: 0x0000828E
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00009298 File Offset: 0x00008298
		[FIXField("58", EFieldOption.Optional)]
		public string Text
		{
			get
			{
				return this.GetStringValue(58);
			}
			set
			{
				this.SetStringValue(58, value);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x000092A3 File Offset: 0x000082A3
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x000092B0 File Offset: 0x000082B0
		[FIXField("354", EFieldOption.Optional)]
		public int EncodedTextLen
		{
			get
			{
				return this.GetIntValue(354);
			}
			set
			{
				this.SetIntValue(354, value);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x000092BE File Offset: 0x000082BE
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x000092CB File Offset: 0x000082CB
		[FIXField("355", EFieldOption.Optional)]
		public string EncodedText
		{
			get
			{
				return this.GetStringValue(355);
			}
			set
			{
				this.SetStringValue(355, value);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x000092D9 File Offset: 0x000082D9
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000092E3 File Offset: 0x000082E3
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x000092EE File Offset: 0x000082EE
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x000092F8 File Offset: 0x000082F8
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00009303 File Offset: 0x00008303
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0000930D File Offset: 0x0000830D
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

		// Token: 0x060006B0 RID: 1712 RVA: 0x00009318 File Offset: 0x00008318
		public FIXPositionReport()
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00009390 File Offset: 0x00008390
		public FIXPositionReport(string PosMaintRptID, int PosReqResult, DateTime ClearingBusinessDate, string Account, int AccountType, double SettlPrice, int SettlPriceType, double PriorSettlPrice)
		{
			this.PosMaintRptID = PosMaintRptID;
			this.PosReqResult = PosReqResult;
			this.ClearingBusinessDate = ClearingBusinessDate;
			this.Account = Account;
			this.AccountType = AccountType;
			this.SettlPrice = SettlPrice;
			this.SettlPriceType = SettlPriceType;
			this.PriorSettlPrice = PriorSettlPrice;
		}

		// Token: 0x0400004D RID: 77
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400004E RID: 78
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400004F RID: 79
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000050 RID: 80
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000051 RID: 81
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000052 RID: 82
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000053 RID: 83
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000054 RID: 84
		private ArrayList fPositionsGroup = new ArrayList();

		// Token: 0x04000055 RID: 85
		private ArrayList fPosAmtGroup = new ArrayList();
	}
}
