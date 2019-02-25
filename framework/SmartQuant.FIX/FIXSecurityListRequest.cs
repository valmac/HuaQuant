using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200017C RID: 380
	public class FIXSecurityListRequest : FIXMessage
	{
		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x0004D3F5 File Offset: 0x0004C3F5
		// (set) Token: 0x06004590 RID: 17808 RVA: 0x0004D407 File Offset: 0x0004C407
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

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x0004D415 File Offset: 0x0004C415
		// (set) Token: 0x06004592 RID: 17810 RVA: 0x0004D424 File Offset: 0x0004C424
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

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x0004D42F File Offset: 0x0004C42F
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x0004D43E File Offset: 0x0004C43E
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

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x0004D449 File Offset: 0x0004C449
		// (set) Token: 0x06004596 RID: 17814 RVA: 0x0004D458 File Offset: 0x0004C458
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

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x0004D463 File Offset: 0x0004C463
		// (set) Token: 0x06004598 RID: 17816 RVA: 0x0004D472 File Offset: 0x0004C472
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

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x0004D47D File Offset: 0x0004C47D
		// (set) Token: 0x0600459A RID: 17818 RVA: 0x0004D48C File Offset: 0x0004C48C
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

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x0004D497 File Offset: 0x0004C497
		// (set) Token: 0x0600459C RID: 17820 RVA: 0x0004D4A9 File Offset: 0x0004C4A9
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

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x0004D4B7 File Offset: 0x0004C4B7
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x0004D4C6 File Offset: 0x0004C4C6
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

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x0004D4D1 File Offset: 0x0004C4D1
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x0004D4E0 File Offset: 0x0004C4E0
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

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x0004D4EB File Offset: 0x0004C4EB
		// (set) Token: 0x060045A2 RID: 17826 RVA: 0x0004D4FA File Offset: 0x0004C4FA
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

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x0004D505 File Offset: 0x0004C505
		// (set) Token: 0x060045A4 RID: 17828 RVA: 0x0004D514 File Offset: 0x0004C514
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

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x0004D51F File Offset: 0x0004C51F
		// (set) Token: 0x060045A6 RID: 17830 RVA: 0x0004D531 File Offset: 0x0004C531
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

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x0004D53F File Offset: 0x0004C53F
		// (set) Token: 0x060045A8 RID: 17832 RVA: 0x0004D54E File Offset: 0x0004C54E
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

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x0004D559 File Offset: 0x0004C559
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x0004D567 File Offset: 0x0004C567
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

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x0004D571 File Offset: 0x0004C571
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x0004D580 File Offset: 0x0004C580
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

		// Token: 0x060045AD RID: 17837 RVA: 0x0004D58B File Offset: 0x0004C58B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x0004D59E File Offset: 0x0004C59E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x060045AF RID: 17839 RVA: 0x0004D5AD File Offset: 0x0004C5AD
		// (set) Token: 0x060045B0 RID: 17840 RVA: 0x0004D5BF File Offset: 0x0004C5BF
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

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x0004D5CD File Offset: 0x0004C5CD
		// (set) Token: 0x060045B2 RID: 17842 RVA: 0x0004D5DF File Offset: 0x0004C5DF
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

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x0004D5ED File Offset: 0x0004C5ED
		// (set) Token: 0x060045B4 RID: 17844 RVA: 0x0004D5FC File Offset: 0x0004C5FC
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

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x060045B5 RID: 17845 RVA: 0x0004D607 File Offset: 0x0004C607
		// (set) Token: 0x060045B6 RID: 17846 RVA: 0x0004D616 File Offset: 0x0004C616
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

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x0004D621 File Offset: 0x0004C621
		// (set) Token: 0x060045B8 RID: 17848 RVA: 0x0004D630 File Offset: 0x0004C630
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

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x0004D63B File Offset: 0x0004C63B
		// (set) Token: 0x060045BA RID: 17850 RVA: 0x0004D64A File Offset: 0x0004C64A
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

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x0004D655 File Offset: 0x0004C655
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x0004D667 File Offset: 0x0004C667
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

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x0004D675 File Offset: 0x0004C675
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x0004D687 File Offset: 0x0004C687
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

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x0004D695 File Offset: 0x0004C695
		// (set) Token: 0x060045C0 RID: 17856 RVA: 0x0004D6A7 File Offset: 0x0004C6A7
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

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x060045C1 RID: 17857 RVA: 0x0004D6B5 File Offset: 0x0004C6B5
		// (set) Token: 0x060045C2 RID: 17858 RVA: 0x0004D6C7 File Offset: 0x0004C6C7
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

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x0004D6D5 File Offset: 0x0004C6D5
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x0004D6E7 File Offset: 0x0004C6E7
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

		// Token: 0x060045C5 RID: 17861 RVA: 0x0004D6F5 File Offset: 0x0004C6F5
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x0004D713 File Offset: 0x0004C713
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x0004D730 File Offset: 0x0004C730
		// (set) Token: 0x060045C8 RID: 17864 RVA: 0x0004D742 File Offset: 0x0004C742
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

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x0004D750 File Offset: 0x0004C750
		// (set) Token: 0x060045CA RID: 17866 RVA: 0x0004D762 File Offset: 0x0004C762
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

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x060045CB RID: 17867 RVA: 0x0004D770 File Offset: 0x0004C770
		// (set) Token: 0x060045CC RID: 17868 RVA: 0x0004D782 File Offset: 0x0004C782
		[FIXField("559", EFieldOption.Required)]
		public int SecurityListRequestType
		{
			get
			{
				return this.GetIntField(559).Value;
			}
			set
			{
				this.AddIntField(559, value);
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x0004D790 File Offset: 0x0004C790
		// (set) Token: 0x060045CE RID: 17870 RVA: 0x0004D79F File Offset: 0x0004C79F
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

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x060045CF RID: 17871 RVA: 0x0004D7AA File Offset: 0x0004C7AA
		// (set) Token: 0x060045D0 RID: 17872 RVA: 0x0004D7B9 File Offset: 0x0004C7B9
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

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x0004D7C4 File Offset: 0x0004C7C4
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x0004D7D3 File Offset: 0x0004C7D3
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

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x0004D7DE File Offset: 0x0004C7DE
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x0004D7ED File Offset: 0x0004C7ED
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

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x0004D7F8 File Offset: 0x0004C7F8
		// (set) Token: 0x060045D6 RID: 17878 RVA: 0x0004D80A File Offset: 0x0004C80A
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

		// Token: 0x060045D7 RID: 17879 RVA: 0x0004D818 File Offset: 0x0004C818
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x0004D836 File Offset: 0x0004C836
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x0004D853 File Offset: 0x0004C853
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x0004D865 File Offset: 0x0004C865
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

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x0004D873 File Offset: 0x0004C873
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x0004D885 File Offset: 0x0004C885
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

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x0004D893 File Offset: 0x0004C893
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x0004D8A5 File Offset: 0x0004C8A5
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

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x0004D8B3 File Offset: 0x0004C8B3
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x0004D8C5 File Offset: 0x0004C8C5
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

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x0004D8D3 File Offset: 0x0004C8D3
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x0004D8E5 File Offset: 0x0004C8E5
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

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x0004D8F3 File Offset: 0x0004C8F3
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x0004D905 File Offset: 0x0004C905
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

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x0004D913 File Offset: 0x0004C913
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x0004D925 File Offset: 0x0004C925
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

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x0004D933 File Offset: 0x0004C933
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x0004D945 File Offset: 0x0004C945
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

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x0004D953 File Offset: 0x0004C953
		// (set) Token: 0x060045EA RID: 17898 RVA: 0x0004D965 File Offset: 0x0004C965
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

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x0004D973 File Offset: 0x0004C973
		// (set) Token: 0x060045EC RID: 17900 RVA: 0x0004D985 File Offset: 0x0004C985
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

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x0004D993 File Offset: 0x0004C993
		// (set) Token: 0x060045EE RID: 17902 RVA: 0x0004D9A5 File Offset: 0x0004C9A5
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

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x060045EF RID: 17903 RVA: 0x0004D9B3 File Offset: 0x0004C9B3
		// (set) Token: 0x060045F0 RID: 17904 RVA: 0x0004D9C5 File Offset: 0x0004C9C5
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

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x0004D9D3 File Offset: 0x0004C9D3
		// (set) Token: 0x060045F2 RID: 17906 RVA: 0x0004D9E5 File Offset: 0x0004C9E5
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

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x0004D9F3 File Offset: 0x0004C9F3
		// (set) Token: 0x060045F4 RID: 17908 RVA: 0x0004DA05 File Offset: 0x0004CA05
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

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x0004DA13 File Offset: 0x0004CA13
		// (set) Token: 0x060045F6 RID: 17910 RVA: 0x0004DA25 File Offset: 0x0004CA25
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

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x0004DA33 File Offset: 0x0004CA33
		// (set) Token: 0x060045F8 RID: 17912 RVA: 0x0004DA45 File Offset: 0x0004CA45
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

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x0004DA53 File Offset: 0x0004CA53
		// (set) Token: 0x060045FA RID: 17914 RVA: 0x0004DA65 File Offset: 0x0004CA65
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

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x0004DA73 File Offset: 0x0004CA73
		// (set) Token: 0x060045FC RID: 17916 RVA: 0x0004DA85 File Offset: 0x0004CA85
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

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x060045FD RID: 17917 RVA: 0x0004DA93 File Offset: 0x0004CA93
		// (set) Token: 0x060045FE RID: 17918 RVA: 0x0004DAA5 File Offset: 0x0004CAA5
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

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x0004DAB3 File Offset: 0x0004CAB3
		// (set) Token: 0x06004600 RID: 17920 RVA: 0x0004DAC5 File Offset: 0x0004CAC5
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

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06004601 RID: 17921 RVA: 0x0004DAD3 File Offset: 0x0004CAD3
		// (set) Token: 0x06004602 RID: 17922 RVA: 0x0004DAE5 File Offset: 0x0004CAE5
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

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x0004DAF3 File Offset: 0x0004CAF3
		// (set) Token: 0x06004604 RID: 17924 RVA: 0x0004DB05 File Offset: 0x0004CB05
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

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06004605 RID: 17925 RVA: 0x0004DB13 File Offset: 0x0004CB13
		// (set) Token: 0x06004606 RID: 17926 RVA: 0x0004DB25 File Offset: 0x0004CB25
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

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x0004DB33 File Offset: 0x0004CB33
		// (set) Token: 0x06004608 RID: 17928 RVA: 0x0004DB45 File Offset: 0x0004CB45
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

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x0004DB53 File Offset: 0x0004CB53
		// (set) Token: 0x0600460A RID: 17930 RVA: 0x0004DB62 File Offset: 0x0004CB62
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

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x0600460B RID: 17931 RVA: 0x0004DB6D File Offset: 0x0004CB6D
		// (set) Token: 0x0600460C RID: 17932 RVA: 0x0004DB7F File Offset: 0x0004CB7F
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

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x0004DB8D File Offset: 0x0004CB8D
		// (set) Token: 0x0600460E RID: 17934 RVA: 0x0004DB9F File Offset: 0x0004CB9F
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

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x0004DBAD File Offset: 0x0004CBAD
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x0004DBBC File Offset: 0x0004CBBC
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

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x0004DBC7 File Offset: 0x0004CBC7
		// (set) Token: 0x06004612 RID: 17938 RVA: 0x0004DBD9 File Offset: 0x0004CBD9
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

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x0004DBE7 File Offset: 0x0004CBE7
		// (set) Token: 0x06004614 RID: 17940 RVA: 0x0004DBF9 File Offset: 0x0004CBF9
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

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x0004DC07 File Offset: 0x0004CC07
		// (set) Token: 0x06004616 RID: 17942 RVA: 0x0004DC19 File Offset: 0x0004CC19
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

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x0004DC27 File Offset: 0x0004CC27
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x0004DC39 File Offset: 0x0004CC39
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

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x0004DC47 File Offset: 0x0004CC47
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x0004DC59 File Offset: 0x0004CC59
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

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x0004DC67 File Offset: 0x0004CC67
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x0004DC79 File Offset: 0x0004CC79
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

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x0004DC87 File Offset: 0x0004CC87
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x0004DC99 File Offset: 0x0004CC99
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

		// Token: 0x0600461F RID: 17951 RVA: 0x0004DCA7 File Offset: 0x0004CCA7
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x0004DCC5 File Offset: 0x0004CCC5
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x0004DCE2 File Offset: 0x0004CCE2
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x0004DCF4 File Offset: 0x0004CCF4
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

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x0004DD02 File Offset: 0x0004CD02
		// (set) Token: 0x06004624 RID: 17956 RVA: 0x0004DD14 File Offset: 0x0004CD14
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

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x0004DD22 File Offset: 0x0004CD22
		// (set) Token: 0x06004626 RID: 17958 RVA: 0x0004DD34 File Offset: 0x0004CD34
		[FIXField("668", EFieldOption.Optional)]
		public int DeliveryForm
		{
			get
			{
				return this.GetIntField(668).Value;
			}
			set
			{
				this.AddIntField(668, value);
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x0004DD42 File Offset: 0x0004CD42
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x0004DD54 File Offset: 0x0004CD54
		[FIXField("869", EFieldOption.Optional)]
		public double PctAtRisk
		{
			get
			{
				return this.GetDoubleField(869).Value;
			}
			set
			{
				this.AddDoubleField(869, value);
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x0004DD62 File Offset: 0x0004CD62
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x0004DD74 File Offset: 0x0004CD74
		[FIXField("870", EFieldOption.Optional)]
		public int NoInstrAttrib
		{
			get
			{
				return this.GetIntField(870).Value;
			}
			set
			{
				this.AddIntField(870, value);
			}
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x0004DD82 File Offset: 0x0004CD82
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0004DDA0 File Offset: 0x0004CDA0
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x0004DDBD File Offset: 0x0004CDBD
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x0004DDCF File Offset: 0x0004CDCF
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

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x0004DDDD File Offset: 0x0004CDDD
		// (set) Token: 0x06004630 RID: 17968 RVA: 0x0004DDEF File Offset: 0x0004CDEF
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

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x0004DDFD File Offset: 0x0004CDFD
		// (set) Token: 0x06004632 RID: 17970 RVA: 0x0004DE0F File Offset: 0x0004CE0F
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

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x0004DE1D File Offset: 0x0004CE1D
		// (set) Token: 0x06004634 RID: 17972 RVA: 0x0004DE2F File Offset: 0x0004CE2F
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

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x0004DE3D File Offset: 0x0004CE3D
		// (set) Token: 0x06004636 RID: 17974 RVA: 0x0004DE4F File Offset: 0x0004CE4F
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

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x0004DE5D File Offset: 0x0004CE5D
		// (set) Token: 0x06004638 RID: 17976 RVA: 0x0004DE6F File Offset: 0x0004CE6F
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

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06004639 RID: 17977 RVA: 0x0004DE7D File Offset: 0x0004CE7D
		// (set) Token: 0x0600463A RID: 17978 RVA: 0x0004DE8F File Offset: 0x0004CE8F
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

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600463B RID: 17979 RVA: 0x0004DE9D File Offset: 0x0004CE9D
		// (set) Token: 0x0600463C RID: 17980 RVA: 0x0004DEAF File Offset: 0x0004CEAF
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

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x0004DEBD File Offset: 0x0004CEBD
		// (set) Token: 0x0600463E RID: 17982 RVA: 0x0004DECF File Offset: 0x0004CECF
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

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x0004DEDD File Offset: 0x0004CEDD
		// (set) Token: 0x06004640 RID: 17984 RVA: 0x0004DEEF File Offset: 0x0004CEEF
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

		// Token: 0x06004641 RID: 17985 RVA: 0x0004DEFD File Offset: 0x0004CEFD
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x0004DF1B File Offset: 0x0004CF1B
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x0004DF38 File Offset: 0x0004CF38
		// (set) Token: 0x06004644 RID: 17988 RVA: 0x0004DF4A File Offset: 0x0004CF4A
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

		// Token: 0x06004645 RID: 17989 RVA: 0x0004DF58 File Offset: 0x0004CF58
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x0004DF76 File Offset: 0x0004CF76
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x0004DF93 File Offset: 0x0004CF93
		// (set) Token: 0x06004648 RID: 17992 RVA: 0x0004DFA2 File Offset: 0x0004CFA2
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

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x0004DFAD File Offset: 0x0004CFAD
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x0004DFBC File Offset: 0x0004CFBC
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

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x0600464B RID: 17995 RVA: 0x0004DFC7 File Offset: 0x0004CFC7
		// (set) Token: 0x0600464C RID: 17996 RVA: 0x0004DFD9 File Offset: 0x0004CFD9
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

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x0004DFE7 File Offset: 0x0004CFE7
		// (set) Token: 0x0600464E RID: 17998 RVA: 0x0004DFF9 File Offset: 0x0004CFF9
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

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600464F RID: 17999 RVA: 0x0004E007 File Offset: 0x0004D007
		// (set) Token: 0x06004650 RID: 18000 RVA: 0x0004E019 File Offset: 0x0004D019
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

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x0004E027 File Offset: 0x0004D027
		// (set) Token: 0x06004652 RID: 18002 RVA: 0x0004E039 File Offset: 0x0004D039
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

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x0004E047 File Offset: 0x0004D047
		// (set) Token: 0x06004654 RID: 18004 RVA: 0x0004E059 File Offset: 0x0004D059
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

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x0004E067 File Offset: 0x0004D067
		// (set) Token: 0x06004656 RID: 18006 RVA: 0x0004E076 File Offset: 0x0004D076
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

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06004657 RID: 18007 RVA: 0x0004E081 File Offset: 0x0004D081
		// (set) Token: 0x06004658 RID: 18008 RVA: 0x0004E090 File Offset: 0x0004D090
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

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x0004E09B File Offset: 0x0004D09B
		// (set) Token: 0x0600465A RID: 18010 RVA: 0x0004E0AA File Offset: 0x0004D0AA
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

		// Token: 0x0600465B RID: 18011 RVA: 0x0004E0B8 File Offset: 0x0004D0B8
		public FIXSecurityListRequest()
		{
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x0004E118 File Offset: 0x0004D118
		public FIXSecurityListRequest(string SecurityReqID, int SecurityListRequestType)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityListRequestType = SecurityListRequestType;
		}

		// Token: 0x04000D89 RID: 3465
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000D8A RID: 3466
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000D8B RID: 3467
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000D8C RID: 3468
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000D8D RID: 3469
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x04000D8E RID: 3470
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000D8F RID: 3471
		private ArrayList fLegsGroup = new ArrayList();
	}
}
