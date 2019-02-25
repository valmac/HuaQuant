using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200008F RID: 143
	public class FIXSecurityDefinition : FIXMessage
	{
		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0001DBC1 File Offset: 0x0001CBC1
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0001DBCE File Offset: 0x0001CBCE
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

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0001DBDC File Offset: 0x0001CBDC
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0001DBE6 File Offset: 0x0001CBE6
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

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0001DBF1 File Offset: 0x0001CBF1
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0001DBFB File Offset: 0x0001CBFB
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0001DC06 File Offset: 0x0001CC06
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0001DC10 File Offset: 0x0001CC10
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0001DC1B File Offset: 0x0001CC1B
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x0001DC25 File Offset: 0x0001CC25
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

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0001DC30 File Offset: 0x0001CC30
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x0001DC3A File Offset: 0x0001CC3A
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

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0001DC45 File Offset: 0x0001CC45
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x0001DC52 File Offset: 0x0001CC52
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

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0001DC60 File Offset: 0x0001CC60
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x0001DC6A File Offset: 0x0001CC6A
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

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0001DC75 File Offset: 0x0001CC75
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0001DC7F File Offset: 0x0001CC7F
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

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0001DC8A File Offset: 0x0001CC8A
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0001DC94 File Offset: 0x0001CC94
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

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0001DC9F File Offset: 0x0001CC9F
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0001DCA9 File Offset: 0x0001CCA9
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

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0001DCB4 File Offset: 0x0001CCB4
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x0001DCC1 File Offset: 0x0001CCC1
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

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0001DCCF File Offset: 0x0001CCCF
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0001DCD9 File Offset: 0x0001CCD9
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

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0001DCE4 File Offset: 0x0001CCE4
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0001DCED File Offset: 0x0001CCED
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

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0001DCF7 File Offset: 0x0001CCF7
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0001DD01 File Offset: 0x0001CD01
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

		// Token: 0x06001B30 RID: 6960 RVA: 0x0001DD0C File Offset: 0x0001CD0C
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0001DD1F File Offset: 0x0001CD1F
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0001DD2E File Offset: 0x0001CD2E
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0001DD3B File Offset: 0x0001CD3B
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

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0001DD49 File Offset: 0x0001CD49
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0001DD56 File Offset: 0x0001CD56
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

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0001DD64 File Offset: 0x0001CD64
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0001DD6E File Offset: 0x0001CD6E
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

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0001DD79 File Offset: 0x0001CD79
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0001DD83 File Offset: 0x0001CD83
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

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0001DD8E File Offset: 0x0001CD8E
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0001DD98 File Offset: 0x0001CD98
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0001DDA3 File Offset: 0x0001CDA3
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0001DDAD File Offset: 0x0001CDAD
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

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0001DDB8 File Offset: 0x0001CDB8
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0001DDC5 File Offset: 0x0001CDC5
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

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0001DDD3 File Offset: 0x0001CDD3
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0001DDE0 File Offset: 0x0001CDE0
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0001DDEE File Offset: 0x0001CDEE
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0001DDFB File Offset: 0x0001CDFB
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

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0001DE09 File Offset: 0x0001CE09
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0001DE16 File Offset: 0x0001CE16
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

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0001DE24 File Offset: 0x0001CE24
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0001DE31 File Offset: 0x0001CE31
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

		// Token: 0x06001B48 RID: 6984 RVA: 0x0001DE3F File Offset: 0x0001CE3F
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0001DE5D File Offset: 0x0001CE5D
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0001DE7A File Offset: 0x0001CE7A
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0001DE87 File Offset: 0x0001CE87
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

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0001DE95 File Offset: 0x0001CE95
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0001DEA2 File Offset: 0x0001CEA2
		[FIXField("320", EFieldOption.Required)]
		public string SecurityReqID
		{
			get
			{
				return this.GetStringValue(320);
			}
			set
			{
				this.SetStringValue(320, value);
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0001DEB0 File Offset: 0x0001CEB0
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0001DEBD File Offset: 0x0001CEBD
		[FIXField("322", EFieldOption.Required)]
		public string SecurityResponseID
		{
			get
			{
				return this.GetStringValue(322);
			}
			set
			{
				this.SetStringValue(322, value);
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0001DECB File Offset: 0x0001CECB
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0001DED8 File Offset: 0x0001CED8
		[FIXField("323", EFieldOption.Required)]
		public int SecurityResponseType
		{
			get
			{
				return this.GetIntValue(323);
			}
			set
			{
				this.SetIntValue(323, value);
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0001DEE6 File Offset: 0x0001CEE6
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0001DEF3 File Offset: 0x0001CEF3
		[FIXField("393", EFieldOption.Optional)]
		public int TotNoRelatedSym
		{
			get
			{
				return this.GetIntValue(393);
			}
			set
			{
				this.SetIntValue(393, value);
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0001DF01 File Offset: 0x0001CF01
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0001DF0B File Offset: 0x0001CF0B
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

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0001DF16 File Offset: 0x0001CF16
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0001DF20 File Offset: 0x0001CF20
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

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0001DF2B File Offset: 0x0001CF2B
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0001DF35 File Offset: 0x0001CF35
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0001DF40 File Offset: 0x0001CF40
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0001DF4A File Offset: 0x0001CF4A
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0001DF55 File Offset: 0x0001CF55
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0001DF62 File Offset: 0x0001CF62
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

		// Token: 0x06001B5E RID: 7006 RVA: 0x0001DF70 File Offset: 0x0001CF70
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0001DF8E File Offset: 0x0001CF8E
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0001DFAB File Offset: 0x0001CFAB
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0001DFB8 File Offset: 0x0001CFB8
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0001DFC6 File Offset: 0x0001CFC6
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0001DFD3 File Offset: 0x0001CFD3
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

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0001DFE1 File Offset: 0x0001CFE1
		// (set) Token: 0x06001B65 RID: 7013 RVA: 0x0001DFEE File Offset: 0x0001CFEE
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

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0001DFFC File Offset: 0x0001CFFC
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0001E009 File Offset: 0x0001D009
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

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0001E017 File Offset: 0x0001D017
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0001E024 File Offset: 0x0001D024
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

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0001E032 File Offset: 0x0001D032
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0001E03F File Offset: 0x0001D03F
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

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0001E04D File Offset: 0x0001D04D
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0001E05A File Offset: 0x0001D05A
		[FIXField("205", EFieldOption.Optional)]
		public string MaturityDay
		{
			get
			{
				return this.GetStringValue(205);
			}
			set
			{
				this.SetStringValue(205, value);
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0001E068 File Offset: 0x0001D068
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0001E075 File Offset: 0x0001D075
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

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x0001E083 File Offset: 0x0001D083
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0001E090 File Offset: 0x0001D090
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

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0001E09E File Offset: 0x0001D09E
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0001E0AB File Offset: 0x0001D0AB
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0001E0B9 File Offset: 0x0001D0B9
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0001E0C6 File Offset: 0x0001D0C6
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0001E0D4 File Offset: 0x0001D0D4
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0001E0E1 File Offset: 0x0001D0E1
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0001E0EF File Offset: 0x0001D0EF
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0001E0FC File Offset: 0x0001D0FC
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0001E10A File Offset: 0x0001D10A
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0001E117 File Offset: 0x0001D117
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0001E125 File Offset: 0x0001D125
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0001E132 File Offset: 0x0001D132
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x0001E140 File Offset: 0x0001D140
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0001E14D File Offset: 0x0001D14D
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x0001E15B File Offset: 0x0001D15B
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0001E168 File Offset: 0x0001D168
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

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0001E176 File Offset: 0x0001D176
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0001E183 File Offset: 0x0001D183
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0001E191 File Offset: 0x0001D191
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0001E19E File Offset: 0x0001D19E
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

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0001E1AC File Offset: 0x0001D1AC
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0001E1B9 File Offset: 0x0001D1B9
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0001E1C7 File Offset: 0x0001D1C7
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x0001E1D4 File Offset: 0x0001D1D4
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

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0001E1E2 File Offset: 0x0001D1E2
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x0001E1EF File Offset: 0x0001D1EF
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x0001E1FD File Offset: 0x0001D1FD
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x0001E20A File Offset: 0x0001D20A
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

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0001E218 File Offset: 0x0001D218
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x0001E225 File Offset: 0x0001D225
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

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0001E233 File Offset: 0x0001D233
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0001E240 File Offset: 0x0001D240
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0001E24E File Offset: 0x0001D24E
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0001E25B File Offset: 0x0001D25B
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x0001E269 File Offset: 0x0001D269
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0001E273 File Offset: 0x0001D273
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0001E27E File Offset: 0x0001D27E
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0001E28B File Offset: 0x0001D28B
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

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x0001E299 File Offset: 0x0001D299
		// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0001E2A6 File Offset: 0x0001D2A6
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

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0001E2B4 File Offset: 0x0001D2B4
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0001E2BE File Offset: 0x0001D2BE
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

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0001E2C9 File Offset: 0x0001D2C9
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0001E2D6 File Offset: 0x0001D2D6
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

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0001E2E4 File Offset: 0x0001D2E4
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0001E2F1 File Offset: 0x0001D2F1
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

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0001E2FF File Offset: 0x0001D2FF
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0001E30C File Offset: 0x0001D30C
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

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0001E31A File Offset: 0x0001D31A
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0001E327 File Offset: 0x0001D327
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

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0001E335 File Offset: 0x0001D335
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0001E342 File Offset: 0x0001D342
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0001E350 File Offset: 0x0001D350
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0001E35D File Offset: 0x0001D35D
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0001E36B File Offset: 0x0001D36B
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0001E378 File Offset: 0x0001D378
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0001E386 File Offset: 0x0001D386
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0001E393 File Offset: 0x0001D393
		[FIXField("11105", EFieldOption.Optional)]
		public string PriceDisplay
		{
			get
			{
				return this.GetStringValue(11105);
			}
			set
			{
				this.SetStringValue(11105, value);
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0001E3A1 File Offset: 0x0001D3A1
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0001E3AE File Offset: 0x0001D3AE
		[FIXField("11400", EFieldOption.Optional)]
		public double TickSize
		{
			get
			{
				return this.GetDoubleValue(10400);
			}
			set
			{
				this.SetDoubleValue(10400, value);
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0001E3BC File Offset: 0x0001D3BC
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0001E3DA File Offset: 0x0001D3DA
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0001E3F7 File Offset: 0x0001D3F7
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0001E404 File Offset: 0x0001D404
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0001E412 File Offset: 0x0001D412
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0001E41F File Offset: 0x0001D41F
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

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0001E42D File Offset: 0x0001D42D
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0001E43A File Offset: 0x0001D43A
		[FIXField("668", EFieldOption.Optional)]
		public int DeliveryForm
		{
			get
			{
				return this.GetIntValue(668);
			}
			set
			{
				this.SetIntValue(668, value);
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0001E448 File Offset: 0x0001D448
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0001E455 File Offset: 0x0001D455
		[FIXField("869", EFieldOption.Optional)]
		public double PctAtRisk
		{
			get
			{
				return this.GetDoubleValue(869);
			}
			set
			{
				this.SetDoubleValue(869, value);
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0001E463 File Offset: 0x0001D463
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0001E470 File Offset: 0x0001D470
		[FIXField("870", EFieldOption.Optional)]
		public int NoInstrAttrib
		{
			get
			{
				return this.GetIntValue(870);
			}
			set
			{
				this.SetIntValue(870, value);
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0001E47E File Offset: 0x0001D47E
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0001E49C File Offset: 0x0001D49C
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0001E4B9 File Offset: 0x0001D4B9
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0001E4C6 File Offset: 0x0001D4C6
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

		// Token: 0x06001BBE RID: 7102 RVA: 0x0001E4D4 File Offset: 0x0001D4D4
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0001E4F2 File Offset: 0x0001D4F2
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0001E50F File Offset: 0x0001D50F
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0001E519 File Offset: 0x0001D519
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

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0001E524 File Offset: 0x0001D524
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0001E531 File Offset: 0x0001D531
		[FIXField("336", EFieldOption.Optional)]
		public string TradingSessionID
		{
			get
			{
				return this.GetStringValue(336);
			}
			set
			{
				this.SetStringValue(336, value);
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x0001E53F File Offset: 0x0001D53F
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0001E54C File Offset: 0x0001D54C
		[FIXField("625", EFieldOption.Optional)]
		public string TradingSessionSubID
		{
			get
			{
				return this.GetStringValue(625);
			}
			set
			{
				this.SetStringValue(625, value);
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0001E55A File Offset: 0x0001D55A
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0001E564 File Offset: 0x0001D564
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x0001E56F File Offset: 0x0001D56F
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0001E57C File Offset: 0x0001D57C
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

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0001E58A File Offset: 0x0001D58A
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x0001E597 File Offset: 0x0001D597
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0001E5A5 File Offset: 0x0001D5A5
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0001E5B2 File Offset: 0x0001D5B2
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

		// Token: 0x06001BCE RID: 7118 RVA: 0x0001E5C0 File Offset: 0x0001D5C0
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0001E5DE File Offset: 0x0001D5DE
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0001E5FB File Offset: 0x0001D5FB
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0001E608 File Offset: 0x0001D608
		[FIXField("827", EFieldOption.Optional)]
		public int ExpirationCycle
		{
			get
			{
				return this.GetIntValue(827);
			}
			set
			{
				this.SetIntValue(827, value);
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x0001E616 File Offset: 0x0001D616
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0001E623 File Offset: 0x0001D623
		[FIXField("561", EFieldOption.Optional)]
		public double RoundLot
		{
			get
			{
				return this.GetDoubleValue(561);
			}
			set
			{
				this.SetDoubleValue(561, value);
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0001E631 File Offset: 0x0001D631
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0001E63E File Offset: 0x0001D63E
		[FIXField("562", EFieldOption.Optional)]
		public double MinTradeVol
		{
			get
			{
				return this.GetDoubleValue(562);
			}
			set
			{
				this.SetDoubleValue(562, value);
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x0001E64C File Offset: 0x0001D64C
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0001E656 File Offset: 0x0001D656
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

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x0001E661 File Offset: 0x0001D661
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x0001E66B File Offset: 0x0001D66B
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

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x0001E676 File Offset: 0x0001D676
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x0001E680 File Offset: 0x0001D680
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

		// Token: 0x06001BDC RID: 7132 RVA: 0x0001E68C File Offset: 0x0001D68C
		public FIXSecurityDefinition()
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0001E6EC File Offset: 0x0001D6EC
		public FIXSecurityDefinition(string SecurityReqID, string SecurityResponseID, int SecurityResponseType)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityResponseID = SecurityResponseID;
			this.SecurityResponseType = SecurityResponseType;
		}

		// Token: 0x040002D8 RID: 728
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002D9 RID: 729
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002DA RID: 730
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040002DB RID: 731
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040002DC RID: 732
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x040002DD RID: 733
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040002DE RID: 734
		private ArrayList fLegsGroup = new ArrayList();
	}
}
