using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000039 RID: 57
	public class FIXAllocationReportAck : FIXMessage
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00010724 File Offset: 0x0000F724
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x00010736 File Offset: 0x0000F736
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00010744 File Offset: 0x0000F744
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x00010753 File Offset: 0x0000F753
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

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0001075E File Offset: 0x0000F75E
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x0001076D File Offset: 0x0000F76D
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00010778 File Offset: 0x0000F778
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x00010787 File Offset: 0x0000F787
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

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00010792 File Offset: 0x0000F792
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x000107A1 File Offset: 0x0000F7A1
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

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000107AC File Offset: 0x0000F7AC
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x000107BB File Offset: 0x0000F7BB
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000107C6 File Offset: 0x0000F7C6
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x000107D8 File Offset: 0x0000F7D8
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x000107E6 File Offset: 0x0000F7E6
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x000107F5 File Offset: 0x0000F7F5
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

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00010800 File Offset: 0x0000F800
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x0001080F File Offset: 0x0000F80F
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

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x0001081A File Offset: 0x0000F81A
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00010829 File Offset: 0x0000F829
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00010834 File Offset: 0x0000F834
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00010843 File Offset: 0x0000F843
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

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0001084E File Offset: 0x0000F84E
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x00010860 File Offset: 0x0000F860
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0001086E File Offset: 0x0000F86E
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0001087D File Offset: 0x0000F87D
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

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00010888 File Offset: 0x0000F888
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00010896 File Offset: 0x0000F896
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

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x000108A0 File Offset: 0x0000F8A0
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x000108AF File Offset: 0x0000F8AF
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

		// Token: 0x06000DFB RID: 3579 RVA: 0x000108BA File Offset: 0x0000F8BA
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000108CD File Offset: 0x0000F8CD
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x000108DC File Offset: 0x0000F8DC
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000108EE File Offset: 0x0000F8EE
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

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000108FC File Offset: 0x0000F8FC
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x0001090E File Offset: 0x0000F90E
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

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0001091C File Offset: 0x0000F91C
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x0001092B File Offset: 0x0000F92B
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00010936 File Offset: 0x0000F936
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00010945 File Offset: 0x0000F945
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00010950 File Offset: 0x0000F950
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x0001095F File Offset: 0x0000F95F
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0001096A File Offset: 0x0000F96A
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00010979 File Offset: 0x0000F979
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00010984 File Offset: 0x0000F984
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00010996 File Offset: 0x0000F996
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

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x000109A4 File Offset: 0x0000F9A4
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x000109B6 File Offset: 0x0000F9B6
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

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000109C4 File Offset: 0x0000F9C4
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x000109D6 File Offset: 0x0000F9D6
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x000109E4 File Offset: 0x0000F9E4
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x000109F6 File Offset: 0x0000F9F6
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

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00010A04 File Offset: 0x0000FA04
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00010A16 File Offset: 0x0000FA16
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

		// Token: 0x06000E13 RID: 3603 RVA: 0x00010A24 File Offset: 0x0000FA24
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00010A42 File Offset: 0x0000FA42
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00010A5F File Offset: 0x0000FA5F
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00010A71 File Offset: 0x0000FA71
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00010A7F File Offset: 0x0000FA7F
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00010A91 File Offset: 0x0000FA91
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00010A9F File Offset: 0x0000FA9F
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00010AAE File Offset: 0x0000FAAE
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

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00010AB9 File Offset: 0x0000FAB9
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00010ACB File Offset: 0x0000FACB
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

		// Token: 0x06000E1D RID: 3613 RVA: 0x00010AD9 File Offset: 0x0000FAD9
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00010AF7 File Offset: 0x0000FAF7
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00010B14 File Offset: 0x0000FB14
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00010B26 File Offset: 0x0000FB26
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

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00010B34 File Offset: 0x0000FB34
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00010B43 File Offset: 0x0000FB43
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00010B4E File Offset: 0x0000FB4E
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00010B5D File Offset: 0x0000FB5D
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

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00010B68 File Offset: 0x0000FB68
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00010B77 File Offset: 0x0000FB77
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

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00010B82 File Offset: 0x0000FB82
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00010B91 File Offset: 0x0000FB91
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00010B9C File Offset: 0x0000FB9C
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00010BAE File Offset: 0x0000FBAE
		[FIXField("794", EFieldOption.Optional)]
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

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00010BBC File Offset: 0x0000FBBC
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00010BCE File Offset: 0x0000FBCE
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

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00010BDC File Offset: 0x0000FBDC
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00010BEE File Offset: 0x0000FBEE
		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharField(573).Value;
			}
			set
			{
				this.AddCharField(573, value);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00010BFC File Offset: 0x0000FBFC
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00010C0E File Offset: 0x0000FC0E
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00010C1C File Offset: 0x0000FC1C
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00010C2E File Offset: 0x0000FC2E
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00010C3C File Offset: 0x0000FC3C
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00010C4B File Offset: 0x0000FC4B
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

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00010C56 File Offset: 0x0000FC56
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x00010C68 File Offset: 0x0000FC68
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

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00010C76 File Offset: 0x0000FC76
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00010C88 File Offset: 0x0000FC88
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

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00010C96 File Offset: 0x0000FC96
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x00010CA5 File Offset: 0x0000FCA5
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

		// Token: 0x06000E3B RID: 3643 RVA: 0x00010CB0 File Offset: 0x0000FCB0
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00010CCE File Offset: 0x0000FCCE
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00010CEB File Offset: 0x0000FCEB
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00010CFA File Offset: 0x0000FCFA
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

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00010D05 File Offset: 0x0000FD05
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00010D14 File Offset: 0x0000FD14
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

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00010D1F File Offset: 0x0000FD1F
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00010D2E File Offset: 0x0000FD2E
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

		// Token: 0x06000E43 RID: 3651 RVA: 0x00010D39 File Offset: 0x0000FD39
		public FIXAllocationReportAck()
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00010D70 File Offset: 0x0000FD70
		public FIXAllocationReportAck(string AllocReportID, string AllocID, DateTime TransactTime, int AllocStatus)
		{
			this.AllocReportID = AllocReportID;
			this.AllocID = AllocID;
			this.TransactTime = TransactTime;
			this.AllocStatus = AllocStatus;
		}

		// Token: 0x040000AB RID: 171
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040000AC RID: 172
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040000AD RID: 173
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040000AE RID: 174
		private ArrayList fAllocsGroup = new ArrayList();
	}
}
