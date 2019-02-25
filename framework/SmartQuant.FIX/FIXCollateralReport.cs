using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000136 RID: 310
	public class FIXCollateralReport : FIXMessage
	{
		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x0003DC54 File Offset: 0x0003CC54
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x0003DC66 File Offset: 0x0003CC66
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

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x0003DC74 File Offset: 0x0003CC74
		// (set) Token: 0x06003AAD RID: 15021 RVA: 0x0003DC83 File Offset: 0x0003CC83
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

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x0003DC8E File Offset: 0x0003CC8E
		// (set) Token: 0x06003AAF RID: 15023 RVA: 0x0003DC9D File Offset: 0x0003CC9D
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

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x0003DCA8 File Offset: 0x0003CCA8
		// (set) Token: 0x06003AB1 RID: 15025 RVA: 0x0003DCB7 File Offset: 0x0003CCB7
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

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x0003DCC2 File Offset: 0x0003CCC2
		// (set) Token: 0x06003AB3 RID: 15027 RVA: 0x0003DCD1 File Offset: 0x0003CCD1
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

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x0003DCDC File Offset: 0x0003CCDC
		// (set) Token: 0x06003AB5 RID: 15029 RVA: 0x0003DCEB File Offset: 0x0003CCEB
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

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x0003DCF6 File Offset: 0x0003CCF6
		// (set) Token: 0x06003AB7 RID: 15031 RVA: 0x0003DD08 File Offset: 0x0003CD08
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

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x0003DD16 File Offset: 0x0003CD16
		// (set) Token: 0x06003AB9 RID: 15033 RVA: 0x0003DD25 File Offset: 0x0003CD25
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

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x0003DD30 File Offset: 0x0003CD30
		// (set) Token: 0x06003ABB RID: 15035 RVA: 0x0003DD3F File Offset: 0x0003CD3F
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

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06003ABC RID: 15036 RVA: 0x0003DD4A File Offset: 0x0003CD4A
		// (set) Token: 0x06003ABD RID: 15037 RVA: 0x0003DD59 File Offset: 0x0003CD59
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

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x0003DD64 File Offset: 0x0003CD64
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x0003DD73 File Offset: 0x0003CD73
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

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x0003DD7E File Offset: 0x0003CD7E
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x0003DD90 File Offset: 0x0003CD90
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

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x0003DD9E File Offset: 0x0003CD9E
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x0003DDAD File Offset: 0x0003CDAD
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

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x0003DDB8 File Offset: 0x0003CDB8
		// (set) Token: 0x06003AC5 RID: 15045 RVA: 0x0003DDC6 File Offset: 0x0003CDC6
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

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x0003DDD0 File Offset: 0x0003CDD0
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x0003DDDF File Offset: 0x0003CDDF
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

		// Token: 0x06003AC8 RID: 15048 RVA: 0x0003DDEA File Offset: 0x0003CDEA
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x0003DDFD File Offset: 0x0003CDFD
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x0003DE0C File Offset: 0x0003CE0C
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x0003DE1E File Offset: 0x0003CE1E
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

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x0003DE2C File Offset: 0x0003CE2C
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x0003DE3E File Offset: 0x0003CE3E
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

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x0003DE4C File Offset: 0x0003CE4C
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x0003DE5B File Offset: 0x0003CE5B
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

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0003DE66 File Offset: 0x0003CE66
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x0003DE75 File Offset: 0x0003CE75
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

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x0003DE80 File Offset: 0x0003CE80
		// (set) Token: 0x06003AD3 RID: 15059 RVA: 0x0003DE8F File Offset: 0x0003CE8F
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

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x0003DE9A File Offset: 0x0003CE9A
		// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x0003DEA9 File Offset: 0x0003CEA9
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

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x0003DEB4 File Offset: 0x0003CEB4
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x0003DEC6 File Offset: 0x0003CEC6
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

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x0003DED4 File Offset: 0x0003CED4
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x0003DEE6 File Offset: 0x0003CEE6
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

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x0003DEF4 File Offset: 0x0003CEF4
		// (set) Token: 0x06003ADB RID: 15067 RVA: 0x0003DF06 File Offset: 0x0003CF06
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

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x0003DF14 File Offset: 0x0003CF14
		// (set) Token: 0x06003ADD RID: 15069 RVA: 0x0003DF26 File Offset: 0x0003CF26
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

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06003ADE RID: 15070 RVA: 0x0003DF34 File Offset: 0x0003CF34
		// (set) Token: 0x06003ADF RID: 15071 RVA: 0x0003DF46 File Offset: 0x0003CF46
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

		// Token: 0x06003AE0 RID: 15072 RVA: 0x0003DF54 File Offset: 0x0003CF54
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x0003DF72 File Offset: 0x0003CF72
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x0003DF8F File Offset: 0x0003CF8F
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x0003DFA1 File Offset: 0x0003CFA1
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

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x0003DFAF File Offset: 0x0003CFAF
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x0003DFC1 File Offset: 0x0003CFC1
		[FIXField("908", EFieldOption.Required)]
		public string CollRptID
		{
			get
			{
				return this.GetStringField(908).Value;
			}
			set
			{
				this.AddStringField(908, value);
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x0003DFCF File Offset: 0x0003CFCF
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x0003DFE1 File Offset: 0x0003CFE1
		[FIXField("909", EFieldOption.Optional)]
		public string CollInquiryID
		{
			get
			{
				return this.GetStringField(909).Value;
			}
			set
			{
				this.AddStringField(909, value);
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x0003DFEF File Offset: 0x0003CFEF
		// (set) Token: 0x06003AE9 RID: 15081 RVA: 0x0003E001 File Offset: 0x0003D001
		[FIXField("910", EFieldOption.Required)]
		public int CollStatus
		{
			get
			{
				return this.GetIntField(910).Value;
			}
			set
			{
				this.AddIntField(910, value);
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x0003E00F File Offset: 0x0003D00F
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x0003E021 File Offset: 0x0003D021
		[FIXField("911", EFieldOption.Optional)]
		public int TotNumReports
		{
			get
			{
				return this.GetIntField(911).Value;
			}
			set
			{
				this.AddIntField(911, value);
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x0003E02F File Offset: 0x0003D02F
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x0003E041 File Offset: 0x0003D041
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

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x0003E04F File Offset: 0x0003D04F
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x0003E061 File Offset: 0x0003D061
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

		// Token: 0x06003AF0 RID: 15088 RVA: 0x0003E06F File Offset: 0x0003D06F
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x0003E08D File Offset: 0x0003D08D
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x0003E0AA File Offset: 0x0003D0AA
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x0003E0B8 File Offset: 0x0003D0B8
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

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x0003E0C2 File Offset: 0x0003D0C2
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x0003E0D4 File Offset: 0x0003D0D4
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

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x0003E0E2 File Offset: 0x0003D0E2
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x0003E0F1 File Offset: 0x0003D0F1
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

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x0003E0FC File Offset: 0x0003D0FC
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x0003E10B File Offset: 0x0003D10B
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

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x0003E116 File Offset: 0x0003D116
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x0003E128 File Offset: 0x0003D128
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

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x0003E136 File Offset: 0x0003D136
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x0003E148 File Offset: 0x0003D148
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

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x0003E156 File Offset: 0x0003D156
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x0003E165 File Offset: 0x0003D165
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

		// Token: 0x06003B00 RID: 15104 RVA: 0x0003E170 File Offset: 0x0003D170
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x0003E18E File Offset: 0x0003D18E
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x0003E1AB File Offset: 0x0003D1AB
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x0003E1BD File Offset: 0x0003D1BD
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

		// Token: 0x06003B04 RID: 15108 RVA: 0x0003E1CB File Offset: 0x0003D1CB
		public FIXTradesGroup GetTradesGroup(int i)
		{
			if (i < this.NoTrades)
			{
				return (FIXTradesGroup)this.fTradesGroup[i];
			}
			return null;
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x0003E1E9 File Offset: 0x0003D1E9
		public void AddGroup(FIXTradesGroup group)
		{
			this.fTradesGroup.Add(group);
			this.NoTrades++;
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x0003E206 File Offset: 0x0003D206
		// (set) Token: 0x06003B07 RID: 15111 RVA: 0x0003E215 File Offset: 0x0003D215
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

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x0003E220 File Offset: 0x0003D220
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x0003E22F File Offset: 0x0003D22F
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

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x0003E23A File Offset: 0x0003D23A
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x0003E249 File Offset: 0x0003D249
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

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0003E254 File Offset: 0x0003D254
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x0003E263 File Offset: 0x0003D263
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

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x0003E26E File Offset: 0x0003D26E
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x0003E280 File Offset: 0x0003D280
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

		// Token: 0x06003B10 RID: 15120 RVA: 0x0003E28E File Offset: 0x0003D28E
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x0003E2AC File Offset: 0x0003D2AC
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x0003E2C9 File Offset: 0x0003D2C9
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x0003E2DB File Offset: 0x0003D2DB
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

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x0003E2E9 File Offset: 0x0003D2E9
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x0003E2FB File Offset: 0x0003D2FB
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

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x0003E309 File Offset: 0x0003D309
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x0003E31B File Offset: 0x0003D31B
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

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x0003E329 File Offset: 0x0003D329
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x0003E33B File Offset: 0x0003D33B
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

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x0003E349 File Offset: 0x0003D349
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x0003E35B File Offset: 0x0003D35B
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

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x0003E369 File Offset: 0x0003D369
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x0003E37B File Offset: 0x0003D37B
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

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0003E389 File Offset: 0x0003D389
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x0003E39B File Offset: 0x0003D39B
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

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x0003E3A9 File Offset: 0x0003D3A9
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x0003E3BB File Offset: 0x0003D3BB
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

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x0003E3C9 File Offset: 0x0003D3C9
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x0003E3DB File Offset: 0x0003D3DB
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

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x0003E3E9 File Offset: 0x0003D3E9
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x0003E3FB File Offset: 0x0003D3FB
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

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x0003E409 File Offset: 0x0003D409
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x0003E41B File Offset: 0x0003D41B
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

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x0003E429 File Offset: 0x0003D429
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x0003E43B File Offset: 0x0003D43B
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

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x0003E449 File Offset: 0x0003D449
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x0003E45B File Offset: 0x0003D45B
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

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x0003E469 File Offset: 0x0003D469
		// (set) Token: 0x06003B2D RID: 15149 RVA: 0x0003E47B File Offset: 0x0003D47B
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

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x0003E489 File Offset: 0x0003D489
		// (set) Token: 0x06003B2F RID: 15151 RVA: 0x0003E49B File Offset: 0x0003D49B
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

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x0003E4A9 File Offset: 0x0003D4A9
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x0003E4BB File Offset: 0x0003D4BB
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

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x0003E4C9 File Offset: 0x0003D4C9
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x0003E4DB File Offset: 0x0003D4DB
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

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x0003E4E9 File Offset: 0x0003D4E9
		// (set) Token: 0x06003B35 RID: 15157 RVA: 0x0003E4FB File Offset: 0x0003D4FB
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

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x0003E509 File Offset: 0x0003D509
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x0003E51B File Offset: 0x0003D51B
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

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x0003E529 File Offset: 0x0003D529
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x0003E53B File Offset: 0x0003D53B
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

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x0003E549 File Offset: 0x0003D549
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0003E55B File Offset: 0x0003D55B
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

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x0003E569 File Offset: 0x0003D569
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x0003E57B File Offset: 0x0003D57B
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

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x0003E589 File Offset: 0x0003D589
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x0003E59B File Offset: 0x0003D59B
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

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x0003E5A9 File Offset: 0x0003D5A9
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x0003E5BB File Offset: 0x0003D5BB
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

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x0003E5C9 File Offset: 0x0003D5C9
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x0003E5D8 File Offset: 0x0003D5D8
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x0003E5E3 File Offset: 0x0003D5E3
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x0003E5F5 File Offset: 0x0003D5F5
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

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x0003E603 File Offset: 0x0003D603
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x0003E615 File Offset: 0x0003D615
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

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x0003E623 File Offset: 0x0003D623
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x0003E632 File Offset: 0x0003D632
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x0003E63D File Offset: 0x0003D63D
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x0003E64F File Offset: 0x0003D64F
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x0003E65D File Offset: 0x0003D65D
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x0003E66F File Offset: 0x0003D66F
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x0003E67D File Offset: 0x0003D67D
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x0003E68F File Offset: 0x0003D68F
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

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x0003E69D File Offset: 0x0003D69D
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x0003E6AF File Offset: 0x0003D6AF
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

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x0003E6BD File Offset: 0x0003D6BD
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x0003E6CF File Offset: 0x0003D6CF
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

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x0003E6DD File Offset: 0x0003D6DD
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x0003E6EF File Offset: 0x0003D6EF
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

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x0003E6FD File Offset: 0x0003D6FD
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x0003E70F File Offset: 0x0003D70F
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

		// Token: 0x06003B58 RID: 15192 RVA: 0x0003E71D File Offset: 0x0003D71D
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x0003E73B File Offset: 0x0003D73B
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x0003E758 File Offset: 0x0003D758
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x0003E76A File Offset: 0x0003D76A
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

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x0003E778 File Offset: 0x0003D778
		// (set) Token: 0x06003B5D RID: 15197 RVA: 0x0003E78A File Offset: 0x0003D78A
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

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x0003E798 File Offset: 0x0003D798
		// (set) Token: 0x06003B5F RID: 15199 RVA: 0x0003E7AA File Offset: 0x0003D7AA
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

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x0003E7B8 File Offset: 0x0003D7B8
		// (set) Token: 0x06003B61 RID: 15201 RVA: 0x0003E7CA File Offset: 0x0003D7CA
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

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x0003E7D8 File Offset: 0x0003D7D8
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x0003E7EA File Offset: 0x0003D7EA
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x0003E7F8 File Offset: 0x0003D7F8
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x0003E80A File Offset: 0x0003D80A
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

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x0003E818 File Offset: 0x0003D818
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x0003E82A File Offset: 0x0003D82A
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

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0003E838 File Offset: 0x0003D838
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x0003E84A File Offset: 0x0003D84A
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

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x0003E858 File Offset: 0x0003D858
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x0003E86A File Offset: 0x0003D86A
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

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0003E878 File Offset: 0x0003D878
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x0003E88A File Offset: 0x0003D88A
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

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x0003E898 File Offset: 0x0003D898
		// (set) Token: 0x06003B6F RID: 15215 RVA: 0x0003E8AA File Offset: 0x0003D8AA
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

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x0003E8B8 File Offset: 0x0003D8B8
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x0003E8C7 File Offset: 0x0003D8C7
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

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x0003E8D2 File Offset: 0x0003D8D2
		// (set) Token: 0x06003B73 RID: 15219 RVA: 0x0003E8E1 File Offset: 0x0003D8E1
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

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06003B74 RID: 15220 RVA: 0x0003E8EC File Offset: 0x0003D8EC
		// (set) Token: 0x06003B75 RID: 15221 RVA: 0x0003E8FE File Offset: 0x0003D8FE
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

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x0003E90C File Offset: 0x0003D90C
		// (set) Token: 0x06003B77 RID: 15223 RVA: 0x0003E91B File Offset: 0x0003D91B
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

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06003B78 RID: 15224 RVA: 0x0003E926 File Offset: 0x0003D926
		// (set) Token: 0x06003B79 RID: 15225 RVA: 0x0003E938 File Offset: 0x0003D938
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

		// Token: 0x06003B7A RID: 15226 RVA: 0x0003E946 File Offset: 0x0003D946
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x0003E964 File Offset: 0x0003D964
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x0003E981 File Offset: 0x0003D981
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x0003E993 File Offset: 0x0003D993
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

		// Token: 0x06003B7E RID: 15230 RVA: 0x0003E9A1 File Offset: 0x0003D9A1
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x0003E9BF File Offset: 0x0003D9BF
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x0003E9DC File Offset: 0x0003D9DC
		// (set) Token: 0x06003B81 RID: 15233 RVA: 0x0003E9EE File Offset: 0x0003D9EE
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

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x0003E9FC File Offset: 0x0003D9FC
		// (set) Token: 0x06003B83 RID: 15235 RVA: 0x0003EA0E File Offset: 0x0003DA0E
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

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06003B84 RID: 15236 RVA: 0x0003EA1C File Offset: 0x0003DA1C
		// (set) Token: 0x06003B85 RID: 15237 RVA: 0x0003EA2E File Offset: 0x0003DA2E
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

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x0003EA3C File Offset: 0x0003DA3C
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x0003EA4E File Offset: 0x0003DA4E
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

		// Token: 0x06003B88 RID: 15240 RVA: 0x0003EA5C File Offset: 0x0003DA5C
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x0003EA7A File Offset: 0x0003DA7A
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x0003EA97 File Offset: 0x0003DA97
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x0003EAA6 File Offset: 0x0003DAA6
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x0003EAB1 File Offset: 0x0003DAB1
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x0003EAC3 File Offset: 0x0003DAC3
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

		// Token: 0x06003B8E RID: 15246 RVA: 0x0003EAD1 File Offset: 0x0003DAD1
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x0003EAEF File Offset: 0x0003DAEF
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x0003EB0C File Offset: 0x0003DB0C
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x0003EB1B File Offset: 0x0003DB1B
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

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x0003EB26 File Offset: 0x0003DB26
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x0003EB38 File Offset: 0x0003DB38
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

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x0003EB46 File Offset: 0x0003DB46
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x0003EB58 File Offset: 0x0003DB58
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

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x0003EB66 File Offset: 0x0003DB66
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x0003EB78 File Offset: 0x0003DB78
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

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x0003EB86 File Offset: 0x0003DB86
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x0003EB98 File Offset: 0x0003DB98
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

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x0003EBA6 File Offset: 0x0003DBA6
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x0003EBB8 File Offset: 0x0003DBB8
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

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x0003EBC6 File Offset: 0x0003DBC6
		// (set) Token: 0x06003B9D RID: 15261 RVA: 0x0003EBD8 File Offset: 0x0003DBD8
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

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x0003EBE6 File Offset: 0x0003DBE6
		// (set) Token: 0x06003B9F RID: 15263 RVA: 0x0003EBF8 File Offset: 0x0003DBF8
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

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x0003EC06 File Offset: 0x0003DC06
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x0003EC18 File Offset: 0x0003DC18
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

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x0003EC26 File Offset: 0x0003DC26
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x0003EC38 File Offset: 0x0003DC38
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

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x0003EC46 File Offset: 0x0003DC46
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x0003EC58 File Offset: 0x0003DC58
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

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x0003EC66 File Offset: 0x0003DC66
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x0003EC78 File Offset: 0x0003DC78
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

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x0003EC86 File Offset: 0x0003DC86
		// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x0003EC98 File Offset: 0x0003DC98
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

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x0003ECA6 File Offset: 0x0003DCA6
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x0003ECB8 File Offset: 0x0003DCB8
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

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x0003ECC6 File Offset: 0x0003DCC6
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x0003ECD8 File Offset: 0x0003DCD8
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

		// Token: 0x06003BAE RID: 15278 RVA: 0x0003ECE6 File Offset: 0x0003DCE6
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x0003ED04 File Offset: 0x0003DD04
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x0003ED21 File Offset: 0x0003DD21
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x0003ED33 File Offset: 0x0003DD33
		[FIXField("172", EFieldOption.Optional)]
		public int SettlDeliveryType
		{
			get
			{
				return this.GetIntField(172).Value;
			}
			set
			{
				this.AddIntField(172, value);
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x0003ED41 File Offset: 0x0003DD41
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x0003ED53 File Offset: 0x0003DD53
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

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x0003ED61 File Offset: 0x0003DD61
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x0003ED73 File Offset: 0x0003DD73
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

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0003ED81 File Offset: 0x0003DD81
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x0003ED93 File Offset: 0x0003DD93
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

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x0003EDA1 File Offset: 0x0003DDA1
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x0003EDB0 File Offset: 0x0003DDB0
		[FIXField("85", EFieldOption.Optional)]
		public int NoDlvyInst
		{
			get
			{
				return this.GetIntField(85).Value;
			}
			set
			{
				this.AddIntField(85, value);
			}
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x0003EDBB File Offset: 0x0003DDBB
		public FIXDlvyInstGroup GetDlvyInstGroup(int i)
		{
			if (i < this.NoDlvyInst)
			{
				return (FIXDlvyInstGroup)this.fDlvyInstGroup[i];
			}
			return null;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x0003EDD9 File Offset: 0x0003DDD9
		public void AddGroup(FIXDlvyInstGroup group)
		{
			this.fDlvyInstGroup.Add(group);
			this.NoDlvyInst++;
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x0003EDF6 File Offset: 0x0003DDF6
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x0003EE08 File Offset: 0x0003DE08
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

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x0003EE16 File Offset: 0x0003DE16
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x0003EE28 File Offset: 0x0003DE28
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x0003EE36 File Offset: 0x0003DE36
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x0003EE48 File Offset: 0x0003DE48
		[FIXField("716", EFieldOption.Optional)]
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

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x0003EE56 File Offset: 0x0003DE56
		// (set) Token: 0x06003BC3 RID: 15299 RVA: 0x0003EE68 File Offset: 0x0003DE68
		[FIXField("717", EFieldOption.Optional)]
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

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x0003EE76 File Offset: 0x0003DE76
		// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x0003EE88 File Offset: 0x0003DE88
		[FIXField("715", EFieldOption.Optional)]
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

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0003EE96 File Offset: 0x0003DE96
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x0003EEA5 File Offset: 0x0003DEA5
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

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x0003EEB0 File Offset: 0x0003DEB0
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x0003EEC2 File Offset: 0x0003DEC2
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

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x0003EED0 File Offset: 0x0003DED0
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x0003EEE2 File Offset: 0x0003DEE2
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

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x0003EEF0 File Offset: 0x0003DEF0
		// (set) Token: 0x06003BCD RID: 15309 RVA: 0x0003EEFF File Offset: 0x0003DEFF
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

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x0003EF0A File Offset: 0x0003DF0A
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x0003EF19 File Offset: 0x0003DF19
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

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x0003EF24 File Offset: 0x0003DF24
		// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x0003EF33 File Offset: 0x0003DF33
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

		// Token: 0x06003BD2 RID: 15314 RVA: 0x0003EF40 File Offset: 0x0003DF40
		public FIXCollateralReport()
		{
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x0003EFE4 File Offset: 0x0003DFE4
		public FIXCollateralReport(string CollRptID, int CollStatus)
		{
			this.CollRptID = CollRptID;
			this.CollStatus = CollStatus;
		}

		// Token: 0x04000538 RID: 1336
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000539 RID: 1337
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400053A RID: 1338
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400053B RID: 1339
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x0400053C RID: 1340
		private ArrayList fTradesGroup = new ArrayList();

		// Token: 0x0400053D RID: 1341
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400053E RID: 1342
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400053F RID: 1343
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000540 RID: 1344
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000541 RID: 1345
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x04000542 RID: 1346
		private ArrayList fMiscFeesGroup = new ArrayList();

		// Token: 0x04000543 RID: 1347
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000544 RID: 1348
		private ArrayList fDlvyInstGroup = new ArrayList();
	}
}
