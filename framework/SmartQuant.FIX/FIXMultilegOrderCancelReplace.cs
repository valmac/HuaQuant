using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000024 RID: 36
	public class FIXMultilegOrderCancelReplace : FIXMessage
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00009463 File Offset: 0x00008463
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00009475 File Offset: 0x00008475
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00009483 File Offset: 0x00008483
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00009492 File Offset: 0x00008492
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0000949D File Offset: 0x0000849D
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000094AC File Offset: 0x000084AC
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000094B7 File Offset: 0x000084B7
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000094C6 File Offset: 0x000084C6
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000094D1 File Offset: 0x000084D1
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000094E0 File Offset: 0x000084E0
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x000094EB File Offset: 0x000084EB
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x000094FA File Offset: 0x000084FA
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00009505 File Offset: 0x00008505
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00009517 File Offset: 0x00008517
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00009525 File Offset: 0x00008525
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00009534 File Offset: 0x00008534
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0000953F File Offset: 0x0000853F
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x0000954E File Offset: 0x0000854E
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00009559 File Offset: 0x00008559
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00009568 File Offset: 0x00008568
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00009573 File Offset: 0x00008573
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00009582 File Offset: 0x00008582
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

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0000958D File Offset: 0x0000858D
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0000959F File Offset: 0x0000859F
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000095AD File Offset: 0x000085AD
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x000095BC File Offset: 0x000085BC
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

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x000095C7 File Offset: 0x000085C7
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x000095D5 File Offset: 0x000085D5
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x000095DF File Offset: 0x000085DF
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x000095EE File Offset: 0x000085EE
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

		// Token: 0x060006D3 RID: 1747 RVA: 0x000095F9 File Offset: 0x000085F9
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000960C File Offset: 0x0000860C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0000961B File Offset: 0x0000861B
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x0000962D File Offset: 0x0000862D
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0000963B File Offset: 0x0000863B
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x0000964D File Offset: 0x0000864D
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0000965B File Offset: 0x0000865B
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x0000966A File Offset: 0x0000866A
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00009675 File Offset: 0x00008675
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00009684 File Offset: 0x00008684
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0000968F File Offset: 0x0000868F
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x0000969E File Offset: 0x0000869E
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x000096A9 File Offset: 0x000086A9
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x000096B8 File Offset: 0x000086B8
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

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000096C3 File Offset: 0x000086C3
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x000096D5 File Offset: 0x000086D5
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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000096E3 File Offset: 0x000086E3
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x000096F5 File Offset: 0x000086F5
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00009703 File Offset: 0x00008703
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00009715 File Offset: 0x00008715
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

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00009723 File Offset: 0x00008723
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00009735 File Offset: 0x00008735
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00009743 File Offset: 0x00008743
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00009755 File Offset: 0x00008755
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

		// Token: 0x060006EB RID: 1771 RVA: 0x00009763 File Offset: 0x00008763
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00009781 File Offset: 0x00008781
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0000979E File Offset: 0x0000879E
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x000097B0 File Offset: 0x000087B0
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000097BE File Offset: 0x000087BE
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x000097CD File Offset: 0x000087CD
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000097D8 File Offset: 0x000087D8
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x000097E7 File Offset: 0x000087E7
		[FIXField("41", EFieldOption.Required)]
		public string OrigClOrdID
		{
			get
			{
				return this.GetStringField(41).Value;
			}
			set
			{
				this.AddStringField(41, value);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000097F2 File Offset: 0x000087F2
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00009801 File Offset: 0x00008801
		[FIXField("11", EFieldOption.Required)]
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0000980C File Offset: 0x0000880C
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000981E File Offset: 0x0000881E
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0000982C File Offset: 0x0000882C
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x0000983E File Offset: 0x0000883E
		[FIXField("583", EFieldOption.Optional)]
		public string ClOrdLinkID
		{
			get
			{
				return this.GetStringField(583).Value;
			}
			set
			{
				this.AddStringField(583, value);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0000984C File Offset: 0x0000884C
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x0000985E File Offset: 0x0000885E
		[FIXField("586", EFieldOption.Optional)]
		public DateTime OrigOrdModTime
		{
			get
			{
				return this.GetDateTimeField(586).Value;
			}
			set
			{
				this.AddDateTimeField(586, value);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0000986C File Offset: 0x0000886C
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x0000987E File Offset: 0x0000887E
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

		// Token: 0x060006FD RID: 1789 RVA: 0x0000988C File Offset: 0x0000888C
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000098AA File Offset: 0x000088AA
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x000098C7 File Offset: 0x000088C7
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x000098D9 File Offset: 0x000088D9
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

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x000098E7 File Offset: 0x000088E7
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x000098F6 File Offset: 0x000088F6
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00009901 File Offset: 0x00008901
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x0000990F File Offset: 0x0000890F
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00009919 File Offset: 0x00008919
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0000992B File Offset: 0x0000892B
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00009939 File Offset: 0x00008939
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0000994B File Offset: 0x0000894B
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00009959 File Offset: 0x00008959
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x0000996B File Offset: 0x0000896B
		[FIXField("589", EFieldOption.Optional)]
		public char DayBookingInst
		{
			get
			{
				return this.GetCharField(589).Value;
			}
			set
			{
				this.AddCharField(589, value);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00009979 File Offset: 0x00008979
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x0000998B File Offset: 0x0000898B
		[FIXField("590", EFieldOption.Optional)]
		public char BookingUnit
		{
			get
			{
				return this.GetCharField(590).Value;
			}
			set
			{
				this.AddCharField(590, value);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00009999 File Offset: 0x00008999
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x000099AB File Offset: 0x000089AB
		[FIXField("591", EFieldOption.Optional)]
		public char PreallocMethod
		{
			get
			{
				return this.GetCharField(591).Value;
			}
			set
			{
				this.AddCharField(591, value);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x000099B9 File Offset: 0x000089B9
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x000099C8 File Offset: 0x000089C8
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x000099D3 File Offset: 0x000089D3
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x000099E2 File Offset: 0x000089E2
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

		// Token: 0x06000713 RID: 1811 RVA: 0x000099ED File Offset: 0x000089ED
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00009A0B File Offset: 0x00008A0B
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00009A28 File Offset: 0x00008A28
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00009A37 File Offset: 0x00008A37
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00009A42 File Offset: 0x00008A42
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00009A51 File Offset: 0x00008A51
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00009A5C File Offset: 0x00008A5C
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00009A6E File Offset: 0x00008A6E
		[FIXField("544", EFieldOption.Optional)]
		public char CashMargin
		{
			get
			{
				return this.GetCharField(544).Value;
			}
			set
			{
				this.AddCharField(544, value);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00009A7C File Offset: 0x00008A7C
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00009A8E File Offset: 0x00008A8E
		[FIXField("635", EFieldOption.Optional)]
		public string ClearingFeeIndicator
		{
			get
			{
				return this.GetStringField(635).Value;
			}
			set
			{
				this.AddStringField(635, value);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00009A9C File Offset: 0x00008A9C
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00009AAB File Offset: 0x00008AAB
		[FIXField("21", EFieldOption.Optional)]
		public char HandlInst
		{
			get
			{
				return this.GetCharField(21).Value;
			}
			set
			{
				this.AddCharField(21, value);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00009AB6 File Offset: 0x00008AB6
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00009AC5 File Offset: 0x00008AC5
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringField(18).Value;
			}
			set
			{
				this.AddStringField(18, value);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00009AD0 File Offset: 0x00008AD0
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00009ADF File Offset: 0x00008ADF
		[FIXField("110", EFieldOption.Optional)]
		public double MinQty
		{
			get
			{
				return this.GetDoubleField(110).Value;
			}
			set
			{
				this.AddDoubleField(110, value);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00009AEA File Offset: 0x00008AEA
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00009AF9 File Offset: 0x00008AF9
		[FIXField("111", EFieldOption.Optional)]
		public double MaxFloor
		{
			get
			{
				return this.GetDoubleField(111).Value;
			}
			set
			{
				this.AddDoubleField(111, value);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00009B04 File Offset: 0x00008B04
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00009B13 File Offset: 0x00008B13
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00009B1E File Offset: 0x00008B1E
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00009B30 File Offset: 0x00008B30
		[FIXField("386", EFieldOption.Optional)]
		public int NoTradingSessions
		{
			get
			{
				return this.GetIntField(386).Value;
			}
			set
			{
				this.AddIntField(386, value);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00009B3E File Offset: 0x00008B3E
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00009B5C File Offset: 0x00008B5C
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00009B79 File Offset: 0x00008B79
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00009B88 File Offset: 0x00008B88
		[FIXField("81", EFieldOption.Optional)]
		public char ProcessCode
		{
			get
			{
				return this.GetCharField(81).Value;
			}
			set
			{
				this.AddCharField(81, value);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00009B93 File Offset: 0x00008B93
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00009BA2 File Offset: 0x00008BA2
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00009BAD File Offset: 0x00008BAD
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00009BBC File Offset: 0x00008BBC
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00009BC7 File Offset: 0x00008BC7
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00009BD6 File Offset: 0x00008BD6
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00009BE1 File Offset: 0x00008BE1
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00009BF0 File Offset: 0x00008BF0
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00009BFB File Offset: 0x00008BFB
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00009C0A File Offset: 0x00008C0A
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00009C15 File Offset: 0x00008C15
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00009C27 File Offset: 0x00008C27
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

		// Token: 0x06000739 RID: 1849 RVA: 0x00009C35 File Offset: 0x00008C35
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00009C53 File Offset: 0x00008C53
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00009C70 File Offset: 0x00008C70
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00009C82 File Offset: 0x00008C82
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00009C90 File Offset: 0x00008C90
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00009CA2 File Offset: 0x00008CA2
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00009CB0 File Offset: 0x00008CB0
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00009CC2 File Offset: 0x00008CC2
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00009CD0 File Offset: 0x00008CD0
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00009CE2 File Offset: 0x00008CE2
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00009CF0 File Offset: 0x00008CF0
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00009D02 File Offset: 0x00008D02
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

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00009D10 File Offset: 0x00008D10
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00009D22 File Offset: 0x00008D22
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00009D30 File Offset: 0x00008D30
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00009D42 File Offset: 0x00008D42
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00009D50 File Offset: 0x00008D50
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00009D62 File Offset: 0x00008D62
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00009D70 File Offset: 0x00008D70
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00009D82 File Offset: 0x00008D82
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00009D90 File Offset: 0x00008D90
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00009DA2 File Offset: 0x00008DA2
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00009DB0 File Offset: 0x00008DB0
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00009DC2 File Offset: 0x00008DC2
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00009DD0 File Offset: 0x00008DD0
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00009DE2 File Offset: 0x00008DE2
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

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00009DF0 File Offset: 0x00008DF0
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00009E02 File Offset: 0x00008E02
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00009E10 File Offset: 0x00008E10
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00009E22 File Offset: 0x00008E22
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00009E30 File Offset: 0x00008E30
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00009E42 File Offset: 0x00008E42
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00009E50 File Offset: 0x00008E50
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00009E62 File Offset: 0x00008E62
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00009E70 File Offset: 0x00008E70
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00009E82 File Offset: 0x00008E82
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00009E90 File Offset: 0x00008E90
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00009EA2 File Offset: 0x00008EA2
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00009EB0 File Offset: 0x00008EB0
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00009EC2 File Offset: 0x00008EC2
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00009ED0 File Offset: 0x00008ED0
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00009EE2 File Offset: 0x00008EE2
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

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00009EF0 File Offset: 0x00008EF0
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00009F02 File Offset: 0x00008F02
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

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00009F10 File Offset: 0x00008F10
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00009F22 File Offset: 0x00008F22
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00009F30 File Offset: 0x00008F30
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00009F42 File Offset: 0x00008F42
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00009F50 File Offset: 0x00008F50
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00009F62 File Offset: 0x00008F62
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00009F70 File Offset: 0x00008F70
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00009F7F File Offset: 0x00008F7F
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00009F8A File Offset: 0x00008F8A
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00009F9C File Offset: 0x00008F9C
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00009FAA File Offset: 0x00008FAA
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00009FBC File Offset: 0x00008FBC
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00009FCA File Offset: 0x00008FCA
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00009FD9 File Offset: 0x00008FD9
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00009FE4 File Offset: 0x00008FE4
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00009FF6 File Offset: 0x00008FF6
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0000A004 File Offset: 0x00009004
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0000A016 File Offset: 0x00009016
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0000A024 File Offset: 0x00009024
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x0000A036 File Offset: 0x00009036
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x0000A044 File Offset: 0x00009044
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x0000A056 File Offset: 0x00009056
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0000A064 File Offset: 0x00009064
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x0000A076 File Offset: 0x00009076
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0000A084 File Offset: 0x00009084
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x0000A096 File Offset: 0x00009096
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0000A0A4 File Offset: 0x000090A4
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x0000A0B6 File Offset: 0x000090B6
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

		// Token: 0x06000781 RID: 1921 RVA: 0x0000A0C4 File Offset: 0x000090C4
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000A0E2 File Offset: 0x000090E2
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0000A0FF File Offset: 0x000090FF
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x0000A111 File Offset: 0x00009111
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0000A11F File Offset: 0x0000911F
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x0000A131 File Offset: 0x00009131
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0000A13F File Offset: 0x0000913F
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x0000A151 File Offset: 0x00009151
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

		// Token: 0x06000789 RID: 1929 RVA: 0x0000A15F File Offset: 0x0000915F
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0000A17D File Offset: 0x0000917D
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0000A19A File Offset: 0x0000919A
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x0000A1AC File Offset: 0x000091AC
		[FIXField("140", EFieldOption.Optional)]
		public double PrevClosePx
		{
			get
			{
				return this.GetDoubleField(140).Value;
			}
			set
			{
				this.AddDoubleField(140, value);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0000A1BA File Offset: 0x000091BA
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x0000A1CC File Offset: 0x000091CC
		[FIXField("555", EFieldOption.Required)]
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

		// Token: 0x0600078F RID: 1935 RVA: 0x0000A1DA File Offset: 0x000091DA
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000A1F8 File Offset: 0x000091F8
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0000A215 File Offset: 0x00009215
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x0000A224 File Offset: 0x00009224
		[FIXField("114", EFieldOption.Optional)]
		public bool LocateReqd
		{
			get
			{
				return this.GetBoolField(114).Value;
			}
			set
			{
				this.AddBoolField(114, value);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0000A22F File Offset: 0x0000922F
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x0000A23E File Offset: 0x0000923E
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0000A249 File Offset: 0x00009249
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000A25B File Offset: 0x0000925B
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0000A269 File Offset: 0x00009269
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0000A278 File Offset: 0x00009278
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0000A283 File Offset: 0x00009283
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x0000A295 File Offset: 0x00009295
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0000A2A3 File Offset: 0x000092A3
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0000A2B5 File Offset: 0x000092B5
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0000A2C3 File Offset: 0x000092C3
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000A2D5 File Offset: 0x000092D5
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0000A2E3 File Offset: 0x000092E3
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0000A2F5 File Offset: 0x000092F5
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0000A303 File Offset: 0x00009303
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0000A312 File Offset: 0x00009312
		[FIXField("40", EFieldOption.Required)]
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0000A31D File Offset: 0x0000931D
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0000A32F File Offset: 0x0000932F
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0000A33D File Offset: 0x0000933D
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x0000A34C File Offset: 0x0000934C
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

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0000A357 File Offset: 0x00009357
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0000A366 File Offset: 0x00009366
		[FIXField("99", EFieldOption.Optional)]
		public double StopPx
		{
			get
			{
				return this.GetDoubleField(99).Value;
			}
			set
			{
				this.AddDoubleField(99, value);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0000A371 File Offset: 0x00009371
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x0000A380 File Offset: 0x00009380
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0000A38B File Offset: 0x0000938B
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x0000A39D File Offset: 0x0000939D
		[FIXField("376", EFieldOption.Optional)]
		public string ComplianceID
		{
			get
			{
				return this.GetStringField(376).Value;
			}
			set
			{
				this.AddStringField(376, value);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x0000A3AB File Offset: 0x000093AB
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0000A3BD File Offset: 0x000093BD
		[FIXField("377", EFieldOption.Optional)]
		public bool SolicitedFlag
		{
			get
			{
				return this.GetBoolField(377).Value;
			}
			set
			{
				this.AddBoolField(377, value);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0000A3CB File Offset: 0x000093CB
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x0000A3DA File Offset: 0x000093DA
		[FIXField("23", EFieldOption.Optional)]
		public string IOIID
		{
			get
			{
				return this.GetStringField(23).Value;
			}
			set
			{
				this.AddStringField(23, value);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0000A3E5 File Offset: 0x000093E5
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0000A3F4 File Offset: 0x000093F4
		[FIXField("117", EFieldOption.Optional)]
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0000A3FF File Offset: 0x000093FF
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x0000A40E File Offset: 0x0000940E
		[FIXField("59", EFieldOption.Optional)]
		public char TimeInForce
		{
			get
			{
				return this.GetCharField(59).Value;
			}
			set
			{
				this.AddCharField(59, value);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0000A419 File Offset: 0x00009419
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x0000A42B File Offset: 0x0000942B
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0000A439 File Offset: 0x00009439
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x0000A44B File Offset: 0x0000944B
		[FIXField("432", EFieldOption.Optional)]
		public DateTime ExpireDate
		{
			get
			{
				return this.GetDateTimeField(432).Value;
			}
			set
			{
				this.AddDateTimeField(432, value);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0000A459 File Offset: 0x00009459
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x0000A468 File Offset: 0x00009468
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0000A473 File Offset: 0x00009473
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x0000A485 File Offset: 0x00009485
		[FIXField("427", EFieldOption.Optional)]
		public int GTBookingInst
		{
			get
			{
				return this.GetIntField(427).Value;
			}
			set
			{
				this.AddIntField(427, value);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0000A493 File Offset: 0x00009493
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x0000A4A2 File Offset: 0x000094A2
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0000A4AD File Offset: 0x000094AD
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x0000A4BC File Offset: 0x000094BC
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0000A4C7 File Offset: 0x000094C7
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x0000A4D9 File Offset: 0x000094D9
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleField(479).Value;
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0000A4E7 File Offset: 0x000094E7
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x0000A4F9 File Offset: 0x000094F9
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharField(497).Value;
			}
			set
			{
				this.AddCharField(497, value);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0000A507 File Offset: 0x00009507
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x0000A519 File Offset: 0x00009519
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0000A527 File Offset: 0x00009527
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x0000A539 File Offset: 0x00009539
		[FIXField("529", EFieldOption.Optional)]
		public string OrderRestrictions
		{
			get
			{
				return this.GetStringField(529).Value;
			}
			set
			{
				this.AddStringField(529, value);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0000A547 File Offset: 0x00009547
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x0000A559 File Offset: 0x00009559
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0000A567 File Offset: 0x00009567
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x0000A576 File Offset: 0x00009576
		[FIXField("121", EFieldOption.Optional)]
		public bool ForexReq
		{
			get
			{
				return this.GetBoolField(121).Value;
			}
			set
			{
				this.AddBoolField(121, value);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x0000A581 File Offset: 0x00009581
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x0000A590 File Offset: 0x00009590
		[FIXField("120", EFieldOption.Optional)]
		public double SettlCurrency
		{
			get
			{
				return this.GetDoubleField(120).Value;
			}
			set
			{
				this.AddDoubleField(120, value);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x0000A59B File Offset: 0x0000959B
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x0000A5AD File Offset: 0x000095AD
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0000A5BB File Offset: 0x000095BB
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0000A5CA File Offset: 0x000095CA
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

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0000A5D5 File Offset: 0x000095D5
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0000A5E7 File Offset: 0x000095E7
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0000A5F5 File Offset: 0x000095F5
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0000A607 File Offset: 0x00009607
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0000A615 File Offset: 0x00009615
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x0000A624 File Offset: 0x00009624
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0000A62F File Offset: 0x0000962F
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0000A641 File Offset: 0x00009641
		[FIXField("203", EFieldOption.Optional)]
		public int CoveredOrUncovered
		{
			get
			{
				return this.GetIntField(203).Value;
			}
			set
			{
				this.AddIntField(203, value);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0000A64F File Offset: 0x0000964F
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0000A661 File Offset: 0x00009661
		[FIXField("210", EFieldOption.Optional)]
		public double MaxShow
		{
			get
			{
				return this.GetDoubleField(210).Value;
			}
			set
			{
				this.AddDoubleField(210, value);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0000A66F File Offset: 0x0000966F
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x0000A681 File Offset: 0x00009681
		[FIXField("211", EFieldOption.Optional)]
		public double PegOffsetValue
		{
			get
			{
				return this.GetDoubleField(211).Value;
			}
			set
			{
				this.AddDoubleField(211, value);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x0000A68F File Offset: 0x0000968F
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x0000A6A1 File Offset: 0x000096A1
		[FIXField("835", EFieldOption.Optional)]
		public int PegMoveType
		{
			get
			{
				return this.GetIntField(835).Value;
			}
			set
			{
				this.AddIntField(835, value);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0000A6AF File Offset: 0x000096AF
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x0000A6C1 File Offset: 0x000096C1
		[FIXField("836", EFieldOption.Optional)]
		public int PegOffsetType
		{
			get
			{
				return this.GetIntField(836).Value;
			}
			set
			{
				this.AddIntField(836, value);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0000A6CF File Offset: 0x000096CF
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x0000A6E1 File Offset: 0x000096E1
		[FIXField("837", EFieldOption.Optional)]
		public int PegLimitType
		{
			get
			{
				return this.GetIntField(837).Value;
			}
			set
			{
				this.AddIntField(837, value);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0000A6EF File Offset: 0x000096EF
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x0000A701 File Offset: 0x00009701
		[FIXField("838", EFieldOption.Optional)]
		public int PegRoundDirection
		{
			get
			{
				return this.GetIntField(838).Value;
			}
			set
			{
				this.AddIntField(838, value);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0000A70F File Offset: 0x0000970F
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x0000A721 File Offset: 0x00009721
		[FIXField("840", EFieldOption.Optional)]
		public int PegScope
		{
			get
			{
				return this.GetIntField(840).Value;
			}
			set
			{
				this.AddIntField(840, value);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0000A72F File Offset: 0x0000972F
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x0000A741 File Offset: 0x00009741
		[FIXField("388", EFieldOption.Optional)]
		public char DiscretionInst
		{
			get
			{
				return this.GetCharField(388).Value;
			}
			set
			{
				this.AddCharField(388, value);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0000A74F File Offset: 0x0000974F
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0000A761 File Offset: 0x00009761
		[FIXField("389", EFieldOption.Optional)]
		public double DiscretionOffsetValue
		{
			get
			{
				return this.GetDoubleField(389).Value;
			}
			set
			{
				this.AddDoubleField(389, value);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0000A76F File Offset: 0x0000976F
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x0000A781 File Offset: 0x00009781
		[FIXField("841", EFieldOption.Optional)]
		public int DiscretionMoveType
		{
			get
			{
				return this.GetIntField(841).Value;
			}
			set
			{
				this.AddIntField(841, value);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x0000A78F File Offset: 0x0000978F
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x0000A7A1 File Offset: 0x000097A1
		[FIXField("842", EFieldOption.Optional)]
		public int DiscretionOffsetType
		{
			get
			{
				return this.GetIntField(842).Value;
			}
			set
			{
				this.AddIntField(842, value);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0000A7AF File Offset: 0x000097AF
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000A7C1 File Offset: 0x000097C1
		[FIXField("843", EFieldOption.Optional)]
		public int DiscretionLimitType
		{
			get
			{
				return this.GetIntField(843).Value;
			}
			set
			{
				this.AddIntField(843, value);
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0000A7CF File Offset: 0x000097CF
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000A7E1 File Offset: 0x000097E1
		[FIXField("844", EFieldOption.Optional)]
		public int DiscretionRoundDirection
		{
			get
			{
				return this.GetIntField(844).Value;
			}
			set
			{
				this.AddIntField(844, value);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0000A7EF File Offset: 0x000097EF
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0000A801 File Offset: 0x00009801
		[FIXField("846", EFieldOption.Optional)]
		public int DiscretionScope
		{
			get
			{
				return this.GetIntField(846).Value;
			}
			set
			{
				this.AddIntField(846, value);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0000A80F File Offset: 0x0000980F
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0000A821 File Offset: 0x00009821
		[FIXField("847", EFieldOption.Optional)]
		public int TargetStrategy
		{
			get
			{
				return this.GetIntField(847).Value;
			}
			set
			{
				this.AddIntField(847, value);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0000A82F File Offset: 0x0000982F
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x0000A841 File Offset: 0x00009841
		[FIXField("848", EFieldOption.Optional)]
		public string TargetStrategyParameters
		{
			get
			{
				return this.GetStringField(848).Value;
			}
			set
			{
				this.AddStringField(848, value);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0000A84F File Offset: 0x0000984F
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x0000A861 File Offset: 0x00009861
		[FIXField("849", EFieldOption.Optional)]
		public double ParticipationRate
		{
			get
			{
				return this.GetDoubleField(849).Value;
			}
			set
			{
				this.AddDoubleField(849, value);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0000A86F File Offset: 0x0000986F
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x0000A881 File Offset: 0x00009881
		[FIXField("480", EFieldOption.Optional)]
		public char CancellationRights
		{
			get
			{
				return this.GetCharField(480).Value;
			}
			set
			{
				this.AddCharField(480, value);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0000A88F File Offset: 0x0000988F
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x0000A8A1 File Offset: 0x000098A1
		[FIXField("481", EFieldOption.Optional)]
		public char MoneyLaunderingStatus
		{
			get
			{
				return this.GetCharField(481).Value;
			}
			set
			{
				this.AddCharField(481, value);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0000A8AF File Offset: 0x000098AF
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x0000A8C1 File Offset: 0x000098C1
		[FIXField("513", EFieldOption.Optional)]
		public string RegistID
		{
			get
			{
				return this.GetStringField(513).Value;
			}
			set
			{
				this.AddStringField(513, value);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0000A8CF File Offset: 0x000098CF
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x0000A8E1 File Offset: 0x000098E1
		[FIXField("494", EFieldOption.Optional)]
		public string Designation
		{
			get
			{
				return this.GetStringField(494).Value;
			}
			set
			{
				this.AddStringField(494, value);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x0000A8EF File Offset: 0x000098EF
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x0000A901 File Offset: 0x00009901
		[FIXField("563", EFieldOption.Optional)]
		public int MultiLegRptTypeReq
		{
			get
			{
				return this.GetIntField(563).Value;
			}
			set
			{
				this.AddIntField(563, value);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0000A90F File Offset: 0x0000990F
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x0000A91E File Offset: 0x0000991E
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

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0000A929 File Offset: 0x00009929
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0000A938 File Offset: 0x00009938
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

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0000A943 File Offset: 0x00009943
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x0000A952 File Offset: 0x00009952
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

		// Token: 0x0600080D RID: 2061 RVA: 0x0000A960 File Offset: 0x00009960
		public FIXMultilegOrderCancelReplace()
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0000A9D8 File Offset: 0x000099D8
		public FIXMultilegOrderCancelReplace(string OrigClOrdID, string ClOrdID, char Side, int NoLegs, DateTime TransactTime, char OrdType)
		{
			this.OrigClOrdID = OrigClOrdID;
			this.ClOrdID = ClOrdID;
			this.Side = Side;
			this.NoLegs = NoLegs;
			this.TransactTime = TransactTime;
			this.OrdType = OrdType;
		}

		// Token: 0x04000057 RID: 87
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000058 RID: 88
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000059 RID: 89
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400005A RID: 90
		private ArrayList fAllocsGroup = new ArrayList();

		// Token: 0x0400005B RID: 91
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x0400005C RID: 92
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400005D RID: 93
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400005E RID: 94
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400005F RID: 95
		private ArrayList fLegsGroup = new ArrayList();
	}
}
