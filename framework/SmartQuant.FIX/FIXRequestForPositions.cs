using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200003A RID: 58
	public class FIXRequestForPositions : FIXMessage
	{
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00010DCC File Offset: 0x0000FDCC
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00010DD9 File Offset: 0x0000FDD9
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

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00010DE7 File Offset: 0x0000FDE7
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00010DF1 File Offset: 0x0000FDF1
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00010DFC File Offset: 0x0000FDFC
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00010E06 File Offset: 0x0000FE06
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00010E11 File Offset: 0x0000FE11
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00010E1B File Offset: 0x0000FE1B
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

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00010E26 File Offset: 0x0000FE26
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00010E30 File Offset: 0x0000FE30
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

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00010E3B File Offset: 0x0000FE3B
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00010E45 File Offset: 0x0000FE45
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

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00010E50 File Offset: 0x0000FE50
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00010E5D File Offset: 0x0000FE5D
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

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00010E6B File Offset: 0x0000FE6B
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00010E75 File Offset: 0x0000FE75
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

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00010E80 File Offset: 0x0000FE80
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00010E8A File Offset: 0x0000FE8A
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00010E95 File Offset: 0x0000FE95
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00010E9F File Offset: 0x0000FE9F
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

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00010EAA File Offset: 0x0000FEAA
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00010EB4 File Offset: 0x0000FEB4
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

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00010EBF File Offset: 0x0000FEBF
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00010ECC File Offset: 0x0000FECC
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

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00010EDA File Offset: 0x0000FEDA
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00010EE4 File Offset: 0x0000FEE4
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

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00010EEF File Offset: 0x0000FEEF
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00010EF8 File Offset: 0x0000FEF8
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

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00010F02 File Offset: 0x0000FF02
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00010F0C File Offset: 0x0000FF0C
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

		// Token: 0x06000E63 RID: 3683 RVA: 0x00010F17 File Offset: 0x0000FF17
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00010F2A File Offset: 0x0000FF2A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00010F39 File Offset: 0x0000FF39
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00010F46 File Offset: 0x0000FF46
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

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00010F54 File Offset: 0x0000FF54
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00010F61 File Offset: 0x0000FF61
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

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00010F6F File Offset: 0x0000FF6F
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00010F79 File Offset: 0x0000FF79
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

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00010F84 File Offset: 0x0000FF84
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00010F8E File Offset: 0x0000FF8E
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00010F99 File Offset: 0x0000FF99
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00010FA3 File Offset: 0x0000FFA3
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

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00010FAE File Offset: 0x0000FFAE
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00010FB8 File Offset: 0x0000FFB8
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00010FC3 File Offset: 0x0000FFC3
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00010FD0 File Offset: 0x0000FFD0
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

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00010FDE File Offset: 0x0000FFDE
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x00010FEB File Offset: 0x0000FFEB
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

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00010FF9 File Offset: 0x0000FFF9
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00011006 File Offset: 0x00010006
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

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00011014 File Offset: 0x00010014
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00011021 File Offset: 0x00010021
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0001102F File Offset: 0x0001002F
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x0001103C File Offset: 0x0001003C
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

		// Token: 0x06000E7B RID: 3707 RVA: 0x0001104A File Offset: 0x0001004A
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00011068 File Offset: 0x00010068
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00011085 File Offset: 0x00010085
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x00011092 File Offset: 0x00010092
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000110A0 File Offset: 0x000100A0
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x000110AD File Offset: 0x000100AD
		[FIXField("710", EFieldOption.Required)]
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

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000110BB File Offset: 0x000100BB
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000110C8 File Offset: 0x000100C8
		[FIXField("724", EFieldOption.Required)]
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

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000110D6 File Offset: 0x000100D6
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x000110E3 File Offset: 0x000100E3
		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharValue(573);
			}
			set
			{
				this.SetCharValue(573, value);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000110F1 File Offset: 0x000100F1
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x000110FE File Offset: 0x000100FE
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

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0001110C File Offset: 0x0001010C
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00011119 File Offset: 0x00010119
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

		// Token: 0x06000E89 RID: 3721 RVA: 0x00011127 File Offset: 0x00010127
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00011145 File Offset: 0x00010145
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00011162 File Offset: 0x00010162
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x0001116B File Offset: 0x0001016B
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

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00011175 File Offset: 0x00010175
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00011182 File Offset: 0x00010182
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

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00011190 File Offset: 0x00010190
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x0001119D File Offset: 0x0001019D
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

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000111AB File Offset: 0x000101AB
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x000111B5 File Offset: 0x000101B5
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

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000111C0 File Offset: 0x000101C0
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x000111CA File Offset: 0x000101CA
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000111D5 File Offset: 0x000101D5
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x000111DF File Offset: 0x000101DF
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000111EA File Offset: 0x000101EA
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x000111F4 File Offset: 0x000101F4
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

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000111FF File Offset: 0x000101FF
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x0001120C File Offset: 0x0001020C
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

		// Token: 0x06000E9B RID: 3739 RVA: 0x0001121A File Offset: 0x0001021A
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00011238 File Offset: 0x00010238
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00011255 File Offset: 0x00010255
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x00011262 File Offset: 0x00010262
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00011270 File Offset: 0x00010270
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x0001127D File Offset: 0x0001027D
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

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0001128B File Offset: 0x0001028B
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00011298 File Offset: 0x00010298
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

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000112A6 File Offset: 0x000102A6
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x000112B3 File Offset: 0x000102B3
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

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000112C1 File Offset: 0x000102C1
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000112CE File Offset: 0x000102CE
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

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000112DC File Offset: 0x000102DC
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x000112E9 File Offset: 0x000102E9
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

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000112F7 File Offset: 0x000102F7
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00011304 File Offset: 0x00010304
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00011312 File Offset: 0x00010312
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0001131F File Offset: 0x0001031F
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0001132D File Offset: 0x0001032D
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0001133A File Offset: 0x0001033A
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00011348 File Offset: 0x00010348
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00011355 File Offset: 0x00010355
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00011363 File Offset: 0x00010363
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00011370 File Offset: 0x00010370
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0001137E File Offset: 0x0001037E
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x0001138B File Offset: 0x0001038B
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

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00011399 File Offset: 0x00010399
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000113A6 File Offset: 0x000103A6
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

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000113B4 File Offset: 0x000103B4
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x000113C1 File Offset: 0x000103C1
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

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x000113CF File Offset: 0x000103CF
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x000113DC File Offset: 0x000103DC
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000113EA File Offset: 0x000103EA
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000113F7 File Offset: 0x000103F7
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

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00011405 File Offset: 0x00010405
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00011412 File Offset: 0x00010412
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

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00011420 File Offset: 0x00010420
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x0001142D File Offset: 0x0001042D
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

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0001143B File Offset: 0x0001043B
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00011448 File Offset: 0x00010448
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

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00011456 File Offset: 0x00010456
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00011463 File Offset: 0x00010463
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

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00011471 File Offset: 0x00010471
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0001147E File Offset: 0x0001047E
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0001148C File Offset: 0x0001048C
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00011499 File Offset: 0x00010499
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

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x000114A7 File Offset: 0x000104A7
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x000114B4 File Offset: 0x000104B4
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

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000114C2 File Offset: 0x000104C2
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x000114CF File Offset: 0x000104CF
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

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000114DD File Offset: 0x000104DD
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x000114E7 File Offset: 0x000104E7
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000114F2 File Offset: 0x000104F2
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x000114FF File Offset: 0x000104FF
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

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0001150D File Offset: 0x0001050D
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x0001151A File Offset: 0x0001051A
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

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00011528 File Offset: 0x00010528
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00011532 File Offset: 0x00010532
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

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0001153D File Offset: 0x0001053D
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0001154A File Offset: 0x0001054A
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

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00011558 File Offset: 0x00010558
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00011565 File Offset: 0x00010565
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

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00011573 File Offset: 0x00010573
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00011580 File Offset: 0x00010580
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

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0001158E File Offset: 0x0001058E
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0001159B File Offset: 0x0001059B
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

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000115A9 File Offset: 0x000105A9
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x000115B6 File Offset: 0x000105B6
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x000115C4 File Offset: 0x000105C4
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x000115D1 File Offset: 0x000105D1
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

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000115DF File Offset: 0x000105DF
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x000115EC File Offset: 0x000105EC
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

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000115FA File Offset: 0x000105FA
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00011618 File Offset: 0x00010618
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00011635 File Offset: 0x00010635
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00011642 File Offset: 0x00010642
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00011650 File Offset: 0x00010650
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0001165D File Offset: 0x0001065D
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

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0001166B File Offset: 0x0001066B
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00011675 File Offset: 0x00010675
		[FIXField("15", EFieldOption.Optional)]
		public double Currency
		{
			get
			{
				return this.GetDoubleValue(15);
			}
			set
			{
				this.SetDoubleValue(15, value);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00011680 File Offset: 0x00010680
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x0001168D File Offset: 0x0001068D
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

		// Token: 0x06000EED RID: 3821 RVA: 0x0001169B File Offset: 0x0001069B
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000116B9 File Offset: 0x000106B9
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000116D6 File Offset: 0x000106D6
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000116E3 File Offset: 0x000106E3
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

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000116F1 File Offset: 0x000106F1
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0001170F File Offset: 0x0001070F
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0001172C File Offset: 0x0001072C
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x00011739 File Offset: 0x00010739
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

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00011747 File Offset: 0x00010747
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x00011754 File Offset: 0x00010754
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

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00011762 File Offset: 0x00010762
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0001176F File Offset: 0x0001076F
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

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0001177D File Offset: 0x0001077D
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0001178A File Offset: 0x0001078A
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

		// Token: 0x06000EFB RID: 3835 RVA: 0x00011798 File Offset: 0x00010798
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000117B6 File Offset: 0x000107B6
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000117D3 File Offset: 0x000107D3
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x000117DD File Offset: 0x000107DD
		[FIXField("60", EFieldOption.Required)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeValue(60);
			}
			set
			{
				this.SetDateTimeValue(60, value);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000117E8 File Offset: 0x000107E8
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x000117F5 File Offset: 0x000107F5
		[FIXField("725", EFieldOption.Optional)]
		public int ResponseTransportType
		{
			get
			{
				return this.GetIntValue(725);
			}
			set
			{
				this.SetIntValue(725, value);
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00011803 File Offset: 0x00010803
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00011810 File Offset: 0x00010810
		[FIXField("726", EFieldOption.Optional)]
		public string ResponseDestination
		{
			get
			{
				return this.GetStringValue(726);
			}
			set
			{
				this.SetStringValue(726, value);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0001181E File Offset: 0x0001081E
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00011828 File Offset: 0x00010828
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

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00011833 File Offset: 0x00010833
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00011840 File Offset: 0x00010840
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0001184E File Offset: 0x0001084E
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0001185B File Offset: 0x0001085B
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

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00011869 File Offset: 0x00010869
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00011873 File Offset: 0x00010873
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

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0001187E File Offset: 0x0001087E
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x00011888 File Offset: 0x00010888
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

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00011893 File Offset: 0x00010893
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x0001189D File Offset: 0x0001089D
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

		// Token: 0x06000F0F RID: 3855 RVA: 0x000118A8 File Offset: 0x000108A8
		public FIXRequestForPositions()
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00011914 File Offset: 0x00010914
		public FIXRequestForPositions(string PosReqID, int PosReqType, string Account, int AccountType, DateTime ClearingBusinessDate, DateTime TransactTime)
		{
			this.PosReqID = PosReqID;
			this.PosReqType = PosReqType;
			this.Account = Account;
			this.AccountType = AccountType;
			this.ClearingBusinessDate = ClearingBusinessDate;
			this.TransactTime = TransactTime;
		}

		// Token: 0x040000AF RID: 175
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040000B0 RID: 176
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040000B1 RID: 177
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040000B2 RID: 178
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040000B3 RID: 179
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040000B4 RID: 180
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040000B5 RID: 181
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040000B6 RID: 182
		private ArrayList fTradingSessionsGroup = new ArrayList();
	}
}
