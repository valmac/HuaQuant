using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000087 RID: 135
	public class FIXAssignmentReport : FIXMessage
	{
		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x0001BCD5 File Offset: 0x0001ACD5
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x0001BCE7 File Offset: 0x0001ACE7
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

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x0001BCF5 File Offset: 0x0001ACF5
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x0001BD04 File Offset: 0x0001AD04
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

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0001BD0F File Offset: 0x0001AD0F
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0001BD1E File Offset: 0x0001AD1E
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0001BD29 File Offset: 0x0001AD29
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0001BD38 File Offset: 0x0001AD38
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

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0001BD43 File Offset: 0x0001AD43
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0001BD52 File Offset: 0x0001AD52
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

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0001BD5D File Offset: 0x0001AD5D
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x0001BD6C File Offset: 0x0001AD6C
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

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0001BD77 File Offset: 0x0001AD77
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0001BD89 File Offset: 0x0001AD89
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

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0001BD97 File Offset: 0x0001AD97
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x0001BDA6 File Offset: 0x0001ADA6
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

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x0001BDB1 File Offset: 0x0001ADB1
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x0001BDC0 File Offset: 0x0001ADC0
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

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x0001BDCB File Offset: 0x0001ADCB
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x0001BDDA File Offset: 0x0001ADDA
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

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x0001BDE5 File Offset: 0x0001ADE5
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x0001BDF4 File Offset: 0x0001ADF4
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

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x0001BDFF File Offset: 0x0001ADFF
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0001BE11 File Offset: 0x0001AE11
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

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x0001BE1F File Offset: 0x0001AE1F
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x0001BE2E File Offset: 0x0001AE2E
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

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0001BE39 File Offset: 0x0001AE39
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x0001BE47 File Offset: 0x0001AE47
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

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0001BE51 File Offset: 0x0001AE51
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x0001BE60 File Offset: 0x0001AE60
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

		// Token: 0x0600198B RID: 6539 RVA: 0x0001BE6B File Offset: 0x0001AE6B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0001BE7E File Offset: 0x0001AE7E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x0001BE8D File Offset: 0x0001AE8D
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x0001BE9F File Offset: 0x0001AE9F
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

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0001BEAD File Offset: 0x0001AEAD
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0001BEBF File Offset: 0x0001AEBF
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

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x0001BECD File Offset: 0x0001AECD
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0001BEDC File Offset: 0x0001AEDC
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

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0001BEE7 File Offset: 0x0001AEE7
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0001BEF6 File Offset: 0x0001AEF6
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0001BF01 File Offset: 0x0001AF01
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x0001BF10 File Offset: 0x0001AF10
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

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x0001BF1B File Offset: 0x0001AF1B
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x0001BF2A File Offset: 0x0001AF2A
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

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x0001BF35 File Offset: 0x0001AF35
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x0001BF47 File Offset: 0x0001AF47
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

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0001BF55 File Offset: 0x0001AF55
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x0001BF67 File Offset: 0x0001AF67
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

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x0001BF75 File Offset: 0x0001AF75
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x0001BF87 File Offset: 0x0001AF87
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

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x0001BF95 File Offset: 0x0001AF95
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0001BFA7 File Offset: 0x0001AFA7
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

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0001BFB5 File Offset: 0x0001AFB5
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0001BFC7 File Offset: 0x0001AFC7
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

		// Token: 0x060019A3 RID: 6563 RVA: 0x0001BFD5 File Offset: 0x0001AFD5
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0001BFF3 File Offset: 0x0001AFF3
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x0001C010 File Offset: 0x0001B010
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x0001C022 File Offset: 0x0001B022
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

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0001C030 File Offset: 0x0001B030
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0001C042 File Offset: 0x0001B042
		[FIXField("833", EFieldOption.Required)]
		public string AsgnRptID
		{
			get
			{
				return this.GetStringField(833).Value;
			}
			set
			{
				this.AddStringField(833, value);
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0001C050 File Offset: 0x0001B050
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0001C062 File Offset: 0x0001B062
		[FIXField("832", EFieldOption.Optional)]
		public int TotNumAssignmentReports
		{
			get
			{
				return this.GetIntField(832).Value;
			}
			set
			{
				this.AddIntField(832, value);
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x0001C070 File Offset: 0x0001B070
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0001C082 File Offset: 0x0001B082
		[FIXField("912", EFieldOption.Optional)]
		public bool LastRptRequested
		{
			get
			{
				return this.GetBoolField(912).Value;
			}
			set
			{
				this.AddBoolField(912, value);
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x0001C090 File Offset: 0x0001B090
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x0001C0A2 File Offset: 0x0001B0A2
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

		// Token: 0x060019AF RID: 6575 RVA: 0x0001C0B0 File Offset: 0x0001B0B0
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0001C0CE File Offset: 0x0001B0CE
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x0001C0EB File Offset: 0x0001B0EB
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x0001C0F9 File Offset: 0x0001B0F9
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

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x0001C103 File Offset: 0x0001B103
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x0001C115 File Offset: 0x0001B115
		[FIXField("581", EFieldOption.Required)]
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

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0001C123 File Offset: 0x0001B123
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x0001C132 File Offset: 0x0001B132
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

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x0001C13D File Offset: 0x0001B13D
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x0001C14C File Offset: 0x0001B14C
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

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x0001C157 File Offset: 0x0001B157
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x0001C166 File Offset: 0x0001B166
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

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0001C171 File Offset: 0x0001B171
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x0001C180 File Offset: 0x0001B180
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

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x0001C18B File Offset: 0x0001B18B
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x0001C19D File Offset: 0x0001B19D
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

		// Token: 0x060019BF RID: 6591 RVA: 0x0001C1AB File Offset: 0x0001B1AB
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0001C1C9 File Offset: 0x0001B1C9
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0001C1E6 File Offset: 0x0001B1E6
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0001C1F8 File Offset: 0x0001B1F8
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

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0001C206 File Offset: 0x0001B206
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0001C218 File Offset: 0x0001B218
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

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0001C226 File Offset: 0x0001B226
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x0001C238 File Offset: 0x0001B238
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0001C246 File Offset: 0x0001B246
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0001C258 File Offset: 0x0001B258
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

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0001C266 File Offset: 0x0001B266
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x0001C278 File Offset: 0x0001B278
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

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0001C286 File Offset: 0x0001B286
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x0001C298 File Offset: 0x0001B298
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0001C2A6 File Offset: 0x0001B2A6
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x0001C2B8 File Offset: 0x0001B2B8
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x0001C2C6 File Offset: 0x0001B2C6
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x0001C2D8 File Offset: 0x0001B2D8
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

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x0001C2E6 File Offset: 0x0001B2E6
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x0001C2F8 File Offset: 0x0001B2F8
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

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0001C306 File Offset: 0x0001B306
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x0001C318 File Offset: 0x0001B318
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

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0001C326 File Offset: 0x0001B326
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0001C338 File Offset: 0x0001B338
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

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0001C346 File Offset: 0x0001B346
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0001C358 File Offset: 0x0001B358
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

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0001C366 File Offset: 0x0001B366
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x0001C378 File Offset: 0x0001B378
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

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x0001C386 File Offset: 0x0001B386
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x0001C398 File Offset: 0x0001B398
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

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x0001C3A6 File Offset: 0x0001B3A6
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x0001C3B8 File Offset: 0x0001B3B8
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

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x0001C3C6 File Offset: 0x0001B3C6
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x0001C3D8 File Offset: 0x0001B3D8
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

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0001C3E6 File Offset: 0x0001B3E6
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0001C3F8 File Offset: 0x0001B3F8
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

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0001C406 File Offset: 0x0001B406
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x0001C418 File Offset: 0x0001B418
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

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0001C426 File Offset: 0x0001B426
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0001C438 File Offset: 0x0001B438
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

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0001C446 File Offset: 0x0001B446
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0001C458 File Offset: 0x0001B458
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0001C466 File Offset: 0x0001B466
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0001C478 File Offset: 0x0001B478
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0001C486 File Offset: 0x0001B486
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0001C498 File Offset: 0x0001B498
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0001C4A6 File Offset: 0x0001B4A6
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x0001C4B8 File Offset: 0x0001B4B8
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x0001C4C6 File Offset: 0x0001B4C6
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x0001C4D8 File Offset: 0x0001B4D8
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0001C4E6 File Offset: 0x0001B4E6
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x0001C4F5 File Offset: 0x0001B4F5
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0001C500 File Offset: 0x0001B500
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0001C512 File Offset: 0x0001B512
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0001C520 File Offset: 0x0001B520
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0001C532 File Offset: 0x0001B532
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0001C540 File Offset: 0x0001B540
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x0001C54F File Offset: 0x0001B54F
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0001C55A File Offset: 0x0001B55A
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0001C56C File Offset: 0x0001B56C
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0001C57A File Offset: 0x0001B57A
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x0001C58C File Offset: 0x0001B58C
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

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x0001C59A File Offset: 0x0001B59A
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x0001C5AC File Offset: 0x0001B5AC
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

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0001C5BA File Offset: 0x0001B5BA
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0001C5CC File Offset: 0x0001B5CC
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x0001C5DA File Offset: 0x0001B5DA
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0001C5EC File Offset: 0x0001B5EC
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

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0001C5FA File Offset: 0x0001B5FA
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0001C60C File Offset: 0x0001B60C
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0001C61A File Offset: 0x0001B61A
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x0001C62C File Offset: 0x0001B62C
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

		// Token: 0x06001A07 RID: 6663 RVA: 0x0001C63A File Offset: 0x0001B63A
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0001C658 File Offset: 0x0001B658
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0001C675 File Offset: 0x0001B675
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x0001C687 File Offset: 0x0001B687
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0001C695 File Offset: 0x0001B695
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0001C6A7 File Offset: 0x0001B6A7
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0001C6B5 File Offset: 0x0001B6B5
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0001C6C4 File Offset: 0x0001B6C4
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

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0001C6CF File Offset: 0x0001B6CF
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0001C6E1 File Offset: 0x0001B6E1
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

		// Token: 0x06001A11 RID: 6673 RVA: 0x0001C6EF File Offset: 0x0001B6EF
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0001C70D File Offset: 0x0001B70D
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0001C72A File Offset: 0x0001B72A
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0001C73C File Offset: 0x0001B73C
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

		// Token: 0x06001A15 RID: 6677 RVA: 0x0001C74A File Offset: 0x0001B74A
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0001C768 File Offset: 0x0001B768
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0001C785 File Offset: 0x0001B785
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x0001C797 File Offset: 0x0001B797
		[FIXField("702", EFieldOption.Optional)]
		public int NoPositions
		{
			get
			{
				return this.GetIntField(702).Value;
			}
			set
			{
				this.AddIntField(702, value);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0001C7A5 File Offset: 0x0001B7A5
		public FIXPositionsGroup GetPositionsGroup(int i)
		{
			if (i < this.NoPositions)
			{
				return (FIXPositionsGroup)this.fPositionsGroup[i];
			}
			return null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0001C7C3 File Offset: 0x0001B7C3
		public void AddGroup(FIXPositionsGroup group)
		{
			this.fPositionsGroup.Add(group);
			this.NoPositions++;
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0001C7E0 File Offset: 0x0001B7E0
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x0001C7F2 File Offset: 0x0001B7F2
		[FIXField("753", EFieldOption.Optional)]
		public int NoPosAmt
		{
			get
			{
				return this.GetIntField(753).Value;
			}
			set
			{
				this.AddIntField(753, value);
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0001C800 File Offset: 0x0001B800
		public FIXPosAmtGroup GetPosAmtGroup(int i)
		{
			if (i < this.NoPosAmt)
			{
				return (FIXPosAmtGroup)this.fPosAmtGroup[i];
			}
			return null;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0001C81E File Offset: 0x0001B81E
		public void AddGroup(FIXPosAmtGroup group)
		{
			this.fPosAmtGroup.Add(group);
			this.NoPosAmt++;
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0001C83B File Offset: 0x0001B83B
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0001C84D File Offset: 0x0001B84D
		[FIXField("834", EFieldOption.Optional)]
		public double ThresholdAmount
		{
			get
			{
				return this.GetDoubleField(834).Value;
			}
			set
			{
				this.AddDoubleField(834, value);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0001C85B File Offset: 0x0001B85B
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0001C86D File Offset: 0x0001B86D
		[FIXField("730", EFieldOption.Required)]
		public double SettlPrice
		{
			get
			{
				return this.GetDoubleField(730).Value;
			}
			set
			{
				this.AddDoubleField(730, value);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0001C87B File Offset: 0x0001B87B
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x0001C88D File Offset: 0x0001B88D
		[FIXField("731", EFieldOption.Required)]
		public int SettlPriceType
		{
			get
			{
				return this.GetIntField(731).Value;
			}
			set
			{
				this.AddIntField(731, value);
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0001C89B File Offset: 0x0001B89B
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0001C8AD File Offset: 0x0001B8AD
		[FIXField("732", EFieldOption.Required)]
		public double UnderlyingSettlPrice
		{
			get
			{
				return this.GetDoubleField(732).Value;
			}
			set
			{
				this.AddDoubleField(732, value);
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0001C8BB File Offset: 0x0001B8BB
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0001C8CD File Offset: 0x0001B8CD
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

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0001C8DB File Offset: 0x0001B8DB
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0001C8ED File Offset: 0x0001B8ED
		[FIXField("744", EFieldOption.Required)]
		public char AssignmentMethod
		{
			get
			{
				return this.GetCharField(744).Value;
			}
			set
			{
				this.AddCharField(744, value);
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x0001C8FB File Offset: 0x0001B8FB
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0001C90D File Offset: 0x0001B90D
		[FIXField("745", EFieldOption.Optional)]
		public double AssignmentUnit
		{
			get
			{
				return this.GetDoubleField(745).Value;
			}
			set
			{
				this.AddDoubleField(745, value);
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0001C91B File Offset: 0x0001B91B
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0001C92D File Offset: 0x0001B92D
		[FIXField("746", EFieldOption.Required)]
		public double OpenInterest
		{
			get
			{
				return this.GetDoubleField(746).Value;
			}
			set
			{
				this.AddDoubleField(746, value);
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0001C93B File Offset: 0x0001B93B
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0001C94D File Offset: 0x0001B94D
		[FIXField("747", EFieldOption.Required)]
		public char ExerciseMethod
		{
			get
			{
				return this.GetCharField(747).Value;
			}
			set
			{
				this.AddCharField(747, value);
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0001C95B File Offset: 0x0001B95B
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0001C96D File Offset: 0x0001B96D
		[FIXField("716", EFieldOption.Required)]
		public string SettlSessID
		{
			get
			{
				return this.GetStringField(716).Value;
			}
			set
			{
				this.AddStringField(716, value);
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0001C97B File Offset: 0x0001B97B
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x0001C98D File Offset: 0x0001B98D
		[FIXField("717", EFieldOption.Required)]
		public string SettlSessSubID
		{
			get
			{
				return this.GetStringField(717).Value;
			}
			set
			{
				this.AddStringField(717, value);
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0001C99B File Offset: 0x0001B99B
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0001C9AD File Offset: 0x0001B9AD
		[FIXField("715", EFieldOption.Required)]
		public DateTime ClearingBusinessDate
		{
			get
			{
				return this.GetDateTimeField(715).Value;
			}
			set
			{
				this.AddDateTimeField(715, value);
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0001C9BB File Offset: 0x0001B9BB
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0001C9CA File Offset: 0x0001B9CA
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

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0001C9D5 File Offset: 0x0001B9D5
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0001C9E7 File Offset: 0x0001B9E7
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

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0001C9F5 File Offset: 0x0001B9F5
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0001CA07 File Offset: 0x0001BA07
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

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0001CA15 File Offset: 0x0001BA15
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0001CA24 File Offset: 0x0001BA24
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

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0001CA2F File Offset: 0x0001BA2F
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0001CA3E File Offset: 0x0001BA3E
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

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x0001CA49 File Offset: 0x0001BA49
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x0001CA58 File Offset: 0x0001BA58
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

		// Token: 0x06001A43 RID: 6723 RVA: 0x0001CA64 File Offset: 0x0001BA64
		public FIXAssignmentReport()
		{
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0001CADC File Offset: 0x0001BADC
		public FIXAssignmentReport(string AsgnRptID, int AccountType, double SettlPrice, int SettlPriceType, double UnderlyingSettlPrice, char AssignmentMethod, double OpenInterest, char ExerciseMethod, string SettlSessID, string SettlSessSubID, DateTime ClearingBusinessDate)
		{
			this.AsgnRptID = AsgnRptID;
			this.AccountType = AccountType;
			this.SettlPrice = SettlPrice;
			this.SettlPriceType = SettlPriceType;
			this.UnderlyingSettlPrice = UnderlyingSettlPrice;
			this.AssignmentMethod = AssignmentMethod;
			this.OpenInterest = OpenInterest;
			this.ExerciseMethod = ExerciseMethod;
			this.SettlSessID = SettlSessID;
			this.SettlSessSubID = SettlSessSubID;
			this.ClearingBusinessDate = ClearingBusinessDate;
		}

		// Token: 0x040002AC RID: 684
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002AD RID: 685
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002AE RID: 686
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040002AF RID: 687
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040002B0 RID: 688
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040002B1 RID: 689
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040002B2 RID: 690
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040002B3 RID: 691
		private ArrayList fPositionsGroup = new ArrayList();

		// Token: 0x040002B4 RID: 692
		private ArrayList fPosAmtGroup = new ArrayList();
	}
}
