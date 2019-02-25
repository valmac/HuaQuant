using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000A3 RID: 163
	public class FIXTradingSessionStatus : FIXMessage
	{
		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00024661 File Offset: 0x00023661
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00024673 File Offset: 0x00023673
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

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00024681 File Offset: 0x00023681
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x00024690 File Offset: 0x00023690
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

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0002469B File Offset: 0x0002369B
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x000246AA File Offset: 0x000236AA
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

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000246B5 File Offset: 0x000236B5
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x000246C4 File Offset: 0x000236C4
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

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x000246CF File Offset: 0x000236CF
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x000246DE File Offset: 0x000236DE
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

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x000246E9 File Offset: 0x000236E9
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x000246F8 File Offset: 0x000236F8
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

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00024703 File Offset: 0x00023703
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x00024715 File Offset: 0x00023715
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

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00024723 File Offset: 0x00023723
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x00024732 File Offset: 0x00023732
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

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0002473D File Offset: 0x0002373D
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x0002474C File Offset: 0x0002374C
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

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00024757 File Offset: 0x00023757
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00024766 File Offset: 0x00023766
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

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x00024771 File Offset: 0x00023771
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00024780 File Offset: 0x00023780
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

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0002478B File Offset: 0x0002378B
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0002479D File Offset: 0x0002379D
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

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x000247AB File Offset: 0x000237AB
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x000247BA File Offset: 0x000237BA
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

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x000247C5 File Offset: 0x000237C5
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x000247D3 File Offset: 0x000237D3
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

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x000247DD File Offset: 0x000237DD
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x000247EC File Offset: 0x000237EC
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

		// Token: 0x060021F0 RID: 8688 RVA: 0x000247F7 File Offset: 0x000237F7
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0002480A File Offset: 0x0002380A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00024819 File Offset: 0x00023819
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x0002482B File Offset: 0x0002382B
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

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x00024839 File Offset: 0x00023839
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x0002484B File Offset: 0x0002384B
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

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00024859 File Offset: 0x00023859
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x00024868 File Offset: 0x00023868
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

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x00024873 File Offset: 0x00023873
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x00024882 File Offset: 0x00023882
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

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0002488D File Offset: 0x0002388D
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x0002489C File Offset: 0x0002389C
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

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x000248A7 File Offset: 0x000238A7
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x000248B6 File Offset: 0x000238B6
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

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000248C1 File Offset: 0x000238C1
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x000248D3 File Offset: 0x000238D3
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

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x000248E1 File Offset: 0x000238E1
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x000248F3 File Offset: 0x000238F3
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

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00024901 File Offset: 0x00023901
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x00024913 File Offset: 0x00023913
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

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x00024921 File Offset: 0x00023921
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x00024933 File Offset: 0x00023933
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

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x00024941 File Offset: 0x00023941
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x00024953 File Offset: 0x00023953
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

		// Token: 0x06002208 RID: 8712 RVA: 0x00024961 File Offset: 0x00023961
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0002497F File Offset: 0x0002397F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x0002499C File Offset: 0x0002399C
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x000249AE File Offset: 0x000239AE
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

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x000249BC File Offset: 0x000239BC
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x000249CE File Offset: 0x000239CE
		[FIXField("335", EFieldOption.Optional)]
		public string TradSesReqID
		{
			get
			{
				return this.GetStringField(335).Value;
			}
			set
			{
				this.AddStringField(335, value);
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x000249DC File Offset: 0x000239DC
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x000249EE File Offset: 0x000239EE
		[FIXField("336", EFieldOption.Required)]
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

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x000249FC File Offset: 0x000239FC
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x00024A0E File Offset: 0x00023A0E
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

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x00024A1C File Offset: 0x00023A1C
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x00024A2E File Offset: 0x00023A2E
		[FIXField("338", EFieldOption.Optional)]
		public int TradSesMethod
		{
			get
			{
				return this.GetIntField(338).Value;
			}
			set
			{
				this.AddIntField(338, value);
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00024A3C File Offset: 0x00023A3C
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x00024A4E File Offset: 0x00023A4E
		[FIXField("339", EFieldOption.Optional)]
		public int TradSesMode
		{
			get
			{
				return this.GetIntField(339).Value;
			}
			set
			{
				this.AddIntField(339, value);
			}
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00024A5C File Offset: 0x00023A5C
		public FIXUnsolicitedIndicatorGroup GetUnsolicitedIndicatorGroup(int i)
		{
			return (FIXUnsolicitedIndicatorGroup)this.fUnsolicitedIndicatorGroup[i];
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00024A6F File Offset: 0x00023A6F
		public void AddGroup(FIXUnsolicitedIndicatorGroup group)
		{
			this.fUnsolicitedIndicatorGroup.Add(group);
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00024A7E File Offset: 0x00023A7E
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x00024A90 File Offset: 0x00023A90
		[FIXField("340", EFieldOption.Required)]
		public int TradSesStatus
		{
			get
			{
				return this.GetIntField(340).Value;
			}
			set
			{
				this.AddIntField(340, value);
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x00024A9E File Offset: 0x00023A9E
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x00024AB0 File Offset: 0x00023AB0
		[FIXField("567", EFieldOption.Optional)]
		public int TradSesStatusRejReason
		{
			get
			{
				return this.GetIntField(567).Value;
			}
			set
			{
				this.AddIntField(567, value);
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00024ABE File Offset: 0x00023ABE
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00024AD0 File Offset: 0x00023AD0
		[FIXField("341", EFieldOption.Optional)]
		public DateTime TradSesStartTime
		{
			get
			{
				return this.GetDateTimeField(341).Value;
			}
			set
			{
				this.AddDateTimeField(341, value);
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00024ADE File Offset: 0x00023ADE
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00024AF0 File Offset: 0x00023AF0
		[FIXField("342", EFieldOption.Optional)]
		public DateTime TradSesOpenTime
		{
			get
			{
				return this.GetDateTimeField(342).Value;
			}
			set
			{
				this.AddDateTimeField(342, value);
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x00024AFE File Offset: 0x00023AFE
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00024B10 File Offset: 0x00023B10
		[FIXField("343", EFieldOption.Optional)]
		public DateTime TradSesPreCloseTime
		{
			get
			{
				return this.GetDateTimeField(343).Value;
			}
			set
			{
				this.AddDateTimeField(343, value);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00024B1E File Offset: 0x00023B1E
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00024B30 File Offset: 0x00023B30
		[FIXField("344", EFieldOption.Optional)]
		public DateTime TradSesCloseTime
		{
			get
			{
				return this.GetDateTimeField(344).Value;
			}
			set
			{
				this.AddDateTimeField(344, value);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00024B3E File Offset: 0x00023B3E
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00024B50 File Offset: 0x00023B50
		[FIXField("345", EFieldOption.Optional)]
		public DateTime TradSesEndTime
		{
			get
			{
				return this.GetDateTimeField(345).Value;
			}
			set
			{
				this.AddDateTimeField(345, value);
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00024B5E File Offset: 0x00023B5E
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x00024B70 File Offset: 0x00023B70
		[FIXField("387", EFieldOption.Optional)]
		public double TotalVolumeTraded
		{
			get
			{
				return this.GetDoubleField(387).Value;
			}
			set
			{
				this.AddDoubleField(387, value);
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x00024B7E File Offset: 0x00023B7E
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x00024B8D File Offset: 0x00023B8D
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

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00024B98 File Offset: 0x00023B98
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x00024BAA File Offset: 0x00023BAA
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

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00024BB8 File Offset: 0x00023BB8
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00024BCA File Offset: 0x00023BCA
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

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00024BD8 File Offset: 0x00023BD8
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00024BE7 File Offset: 0x00023BE7
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

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x00024BF2 File Offset: 0x00023BF2
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00024C01 File Offset: 0x00023C01
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

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00024C0C File Offset: 0x00023C0C
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00024C1B File Offset: 0x00023C1B
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

		// Token: 0x06002234 RID: 8756 RVA: 0x00024C26 File Offset: 0x00023C26
		public FIXTradingSessionStatus()
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00024C4F File Offset: 0x00023C4F
		public FIXTradingSessionStatus(string TradingSessionID, int TradSesStatus)
		{
			this.TradingSessionID = TradingSessionID;
			this.TradSesStatus = TradSesStatus;
		}

		// Token: 0x0400033C RID: 828
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400033D RID: 829
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400033E RID: 830
		private ArrayList fUnsolicitedIndicatorGroup = new ArrayList();
	}
}
