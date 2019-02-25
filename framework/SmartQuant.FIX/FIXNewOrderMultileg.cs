using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000A8 RID: 168
	public class FIXNewOrderMultileg : FIXMessage
	{
		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x0002599B File Offset: 0x0002499B
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x000259AD File Offset: 0x000249AD
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

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000259BB File Offset: 0x000249BB
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x000259CA File Offset: 0x000249CA
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

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000259D5 File Offset: 0x000249D5
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x000259E4 File Offset: 0x000249E4
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

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000259EF File Offset: 0x000249EF
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x000259FE File Offset: 0x000249FE
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

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x00025A09 File Offset: 0x00024A09
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x00025A18 File Offset: 0x00024A18
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

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x00025A23 File Offset: 0x00024A23
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x00025A32 File Offset: 0x00024A32
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

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x00025A3D File Offset: 0x00024A3D
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x00025A4F File Offset: 0x00024A4F
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

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x00025A5D File Offset: 0x00024A5D
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00025A6C File Offset: 0x00024A6C
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

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00025A77 File Offset: 0x00024A77
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x00025A86 File Offset: 0x00024A86
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

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00025A91 File Offset: 0x00024A91
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x00025AA0 File Offset: 0x00024AA0
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

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00025AAB File Offset: 0x00024AAB
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00025ABA File Offset: 0x00024ABA
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

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00025AC5 File Offset: 0x00024AC5
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00025AD7 File Offset: 0x00024AD7
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

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00025AE5 File Offset: 0x00024AE5
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00025AF4 File Offset: 0x00024AF4
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

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x00025AFF File Offset: 0x00024AFF
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x00025B0D File Offset: 0x00024B0D
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

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x00025B17 File Offset: 0x00024B17
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x00025B26 File Offset: 0x00024B26
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

		// Token: 0x06002321 RID: 8993 RVA: 0x00025B31 File Offset: 0x00024B31
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00025B44 File Offset: 0x00024B44
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x00025B53 File Offset: 0x00024B53
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x00025B65 File Offset: 0x00024B65
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

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00025B73 File Offset: 0x00024B73
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x00025B85 File Offset: 0x00024B85
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

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x00025B93 File Offset: 0x00024B93
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00025BA2 File Offset: 0x00024BA2
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

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x00025BAD File Offset: 0x00024BAD
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x00025BBC File Offset: 0x00024BBC
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

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x00025BC7 File Offset: 0x00024BC7
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x00025BD6 File Offset: 0x00024BD6
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

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x00025BE1 File Offset: 0x00024BE1
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x00025BF0 File Offset: 0x00024BF0
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

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x00025BFB File Offset: 0x00024BFB
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00025C0D File Offset: 0x00024C0D
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

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00025C1B File Offset: 0x00024C1B
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00025C2D File Offset: 0x00024C2D
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

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00025C3B File Offset: 0x00024C3B
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00025C4D File Offset: 0x00024C4D
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

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x00025C5B File Offset: 0x00024C5B
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00025C6D File Offset: 0x00024C6D
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00025C7B File Offset: 0x00024C7B
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00025C8D File Offset: 0x00024C8D
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

		// Token: 0x06002339 RID: 9017 RVA: 0x00025C9B File Offset: 0x00024C9B
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00025CB9 File Offset: 0x00024CB9
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x00025CD6 File Offset: 0x00024CD6
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x00025CE8 File Offset: 0x00024CE8
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

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00025CF6 File Offset: 0x00024CF6
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00025D05 File Offset: 0x00024D05
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

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00025D10 File Offset: 0x00024D10
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00025D22 File Offset: 0x00024D22
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

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00025D30 File Offset: 0x00024D30
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x00025D42 File Offset: 0x00024D42
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

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00025D50 File Offset: 0x00024D50
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00025D62 File Offset: 0x00024D62
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

		// Token: 0x06002345 RID: 9029 RVA: 0x00025D70 File Offset: 0x00024D70
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00025D8E File Offset: 0x00024D8E
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00025DAB File Offset: 0x00024DAB
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00025DBD File Offset: 0x00024DBD
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

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00025DCB File Offset: 0x00024DCB
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00025DDA File Offset: 0x00024DDA
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

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00025DE5 File Offset: 0x00024DE5
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x00025DF3 File Offset: 0x00024DF3
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

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x00025DFD File Offset: 0x00024DFD
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00025E0F File Offset: 0x00024E0F
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

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00025E1D File Offset: 0x00024E1D
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00025E2F File Offset: 0x00024E2F
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

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x00025E3D File Offset: 0x00024E3D
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x00025E4F File Offset: 0x00024E4F
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

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x00025E5D File Offset: 0x00024E5D
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x00025E6F File Offset: 0x00024E6F
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

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00025E7D File Offset: 0x00024E7D
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x00025E8F File Offset: 0x00024E8F
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

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x00025E9D File Offset: 0x00024E9D
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x00025EAC File Offset: 0x00024EAC
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

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x00025EB7 File Offset: 0x00024EB7
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00025EC6 File Offset: 0x00024EC6
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

		// Token: 0x0600235B RID: 9051 RVA: 0x00025ED1 File Offset: 0x00024ED1
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00025EEF File Offset: 0x00024EEF
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x00025F0C File Offset: 0x00024F0C
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x00025F1B File Offset: 0x00024F1B
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

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x00025F26 File Offset: 0x00024F26
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x00025F35 File Offset: 0x00024F35
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

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x00025F40 File Offset: 0x00024F40
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x00025F52 File Offset: 0x00024F52
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x00025F60 File Offset: 0x00024F60
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x00025F72 File Offset: 0x00024F72
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

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x00025F80 File Offset: 0x00024F80
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x00025F8F File Offset: 0x00024F8F
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

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x00025F9A File Offset: 0x00024F9A
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x00025FA9 File Offset: 0x00024FA9
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x00025FB4 File Offset: 0x00024FB4
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x00025FC3 File Offset: 0x00024FC3
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

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00025FCE File Offset: 0x00024FCE
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x00025FDD File Offset: 0x00024FDD
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

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x00025FE8 File Offset: 0x00024FE8
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x00025FF7 File Offset: 0x00024FF7
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

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x00026002 File Offset: 0x00025002
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x00026014 File Offset: 0x00025014
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

		// Token: 0x06002371 RID: 9073 RVA: 0x00026022 File Offset: 0x00025022
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00026040 File Offset: 0x00025040
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0002605D File Offset: 0x0002505D
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0002606C File Offset: 0x0002506C
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

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x00026077 File Offset: 0x00025077
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x00026086 File Offset: 0x00025086
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

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x00026091 File Offset: 0x00025091
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x000260A0 File Offset: 0x000250A0
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

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000260AB File Offset: 0x000250AB
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x000260BA File Offset: 0x000250BA
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

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000260C5 File Offset: 0x000250C5
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x000260D4 File Offset: 0x000250D4
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

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000260DF File Offset: 0x000250DF
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x000260EE File Offset: 0x000250EE
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

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000260F9 File Offset: 0x000250F9
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x0002610B File Offset: 0x0002510B
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

		// Token: 0x06002381 RID: 9089 RVA: 0x00026119 File Offset: 0x00025119
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00026137 File Offset: 0x00025137
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x00026154 File Offset: 0x00025154
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x00026166 File Offset: 0x00025166
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

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x00026174 File Offset: 0x00025174
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x00026186 File Offset: 0x00025186
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

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x00026194 File Offset: 0x00025194
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x000261A6 File Offset: 0x000251A6
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

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000261B4 File Offset: 0x000251B4
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x000261C6 File Offset: 0x000251C6
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

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000261D4 File Offset: 0x000251D4
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x000261E6 File Offset: 0x000251E6
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

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000261F4 File Offset: 0x000251F4
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x00026206 File Offset: 0x00025206
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

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x00026214 File Offset: 0x00025214
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x00026226 File Offset: 0x00025226
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

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x00026234 File Offset: 0x00025234
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00026246 File Offset: 0x00025246
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

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x00026254 File Offset: 0x00025254
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x00026266 File Offset: 0x00025266
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

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x00026274 File Offset: 0x00025274
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x00026286 File Offset: 0x00025286
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

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x00026294 File Offset: 0x00025294
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x000262A6 File Offset: 0x000252A6
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

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x000262B4 File Offset: 0x000252B4
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x000262C6 File Offset: 0x000252C6
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

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000262D4 File Offset: 0x000252D4
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x000262E6 File Offset: 0x000252E6
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

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000262F4 File Offset: 0x000252F4
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x00026306 File Offset: 0x00025306
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

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x00026314 File Offset: 0x00025314
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x00026326 File Offset: 0x00025326
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

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x00026334 File Offset: 0x00025334
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x00026346 File Offset: 0x00025346
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

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x00026354 File Offset: 0x00025354
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x00026366 File Offset: 0x00025366
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

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x00026374 File Offset: 0x00025374
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x00026386 File Offset: 0x00025386
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x00026394 File Offset: 0x00025394
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000263A6 File Offset: 0x000253A6
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

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000263B4 File Offset: 0x000253B4
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x000263C6 File Offset: 0x000253C6
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

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x000263D4 File Offset: 0x000253D4
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x000263E6 File Offset: 0x000253E6
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x000263F4 File Offset: 0x000253F4
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x00026406 File Offset: 0x00025406
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

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x00026414 File Offset: 0x00025414
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x00026426 File Offset: 0x00025426
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

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x00026434 File Offset: 0x00025434
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x00026446 File Offset: 0x00025446
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

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00026454 File Offset: 0x00025454
		// (set) Token: 0x060023B4 RID: 9140 RVA: 0x00026463 File Offset: 0x00025463
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

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0002646E File Offset: 0x0002546E
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x00026480 File Offset: 0x00025480
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

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0002648E File Offset: 0x0002548E
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x000264A0 File Offset: 0x000254A0
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000264AE File Offset: 0x000254AE
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x000264BD File Offset: 0x000254BD
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

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000264C8 File Offset: 0x000254C8
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x000264DA File Offset: 0x000254DA
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

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000264E8 File Offset: 0x000254E8
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x000264FA File Offset: 0x000254FA
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

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x00026508 File Offset: 0x00025508
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x0002651A File Offset: 0x0002551A
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x00026528 File Offset: 0x00025528
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0002653A File Offset: 0x0002553A
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

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x00026548 File Offset: 0x00025548
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0002655A File Offset: 0x0002555A
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

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x00026568 File Offset: 0x00025568
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x0002657A File Offset: 0x0002557A
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

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x00026588 File Offset: 0x00025588
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0002659A File Offset: 0x0002559A
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

		// Token: 0x060023C9 RID: 9161 RVA: 0x000265A8 File Offset: 0x000255A8
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000265C6 File Offset: 0x000255C6
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x000265E3 File Offset: 0x000255E3
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x000265F5 File Offset: 0x000255F5
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

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x00026603 File Offset: 0x00025603
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x00026615 File Offset: 0x00025615
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

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x00026623 File Offset: 0x00025623
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x00026635 File Offset: 0x00025635
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

		// Token: 0x060023D1 RID: 9169 RVA: 0x00026643 File Offset: 0x00025643
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00026661 File Offset: 0x00025661
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x0002667E File Offset: 0x0002567E
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x00026690 File Offset: 0x00025690
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

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0002669E File Offset: 0x0002569E
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x000266B0 File Offset: 0x000256B0
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

		// Token: 0x060023D7 RID: 9175 RVA: 0x000266BE File Offset: 0x000256BE
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000266DC File Offset: 0x000256DC
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000266F9 File Offset: 0x000256F9
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x00026708 File Offset: 0x00025708
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

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x00026713 File Offset: 0x00025713
		// (set) Token: 0x060023DC RID: 9180 RVA: 0x00026722 File Offset: 0x00025722
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

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x0002672D File Offset: 0x0002572D
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x0002673F File Offset: 0x0002573F
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

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x0002674D File Offset: 0x0002574D
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0002675C File Offset: 0x0002575C
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x00026767 File Offset: 0x00025767
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x00026779 File Offset: 0x00025779
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

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00026787 File Offset: 0x00025787
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x00026799 File Offset: 0x00025799
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

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x000267A7 File Offset: 0x000257A7
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x000267B9 File Offset: 0x000257B9
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

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x000267C7 File Offset: 0x000257C7
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x000267D9 File Offset: 0x000257D9
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

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000267E7 File Offset: 0x000257E7
		// (set) Token: 0x060023EA RID: 9194 RVA: 0x000267F6 File Offset: 0x000257F6
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

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x00026801 File Offset: 0x00025801
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x00026813 File Offset: 0x00025813
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

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x00026821 File Offset: 0x00025821
		// (set) Token: 0x060023EE RID: 9198 RVA: 0x00026830 File Offset: 0x00025830
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

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0002683B File Offset: 0x0002583B
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0002684A File Offset: 0x0002584A
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

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x00026855 File Offset: 0x00025855
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x00026864 File Offset: 0x00025864
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

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0002686F File Offset: 0x0002586F
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x00026881 File Offset: 0x00025881
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

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0002688F File Offset: 0x0002588F
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x000268A1 File Offset: 0x000258A1
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

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000268AF File Offset: 0x000258AF
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x000268BE File Offset: 0x000258BE
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

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000268C9 File Offset: 0x000258C9
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x000268D8 File Offset: 0x000258D8
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

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000268E3 File Offset: 0x000258E3
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x000268F2 File Offset: 0x000258F2
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

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000268FD File Offset: 0x000258FD
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x0002690F File Offset: 0x0002590F
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

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0002691D File Offset: 0x0002591D
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0002692F File Offset: 0x0002592F
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

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0002693D File Offset: 0x0002593D
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0002694C File Offset: 0x0002594C
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

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x00026957 File Offset: 0x00025957
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x00026969 File Offset: 0x00025969
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

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x00026977 File Offset: 0x00025977
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x00026986 File Offset: 0x00025986
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

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x00026991 File Offset: 0x00025991
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x000269A0 File Offset: 0x000259A0
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

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000269AB File Offset: 0x000259AB
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x000269BD File Offset: 0x000259BD
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000269CB File Offset: 0x000259CB
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x000269DD File Offset: 0x000259DD
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000269EB File Offset: 0x000259EB
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x000269FD File Offset: 0x000259FD
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

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x00026A0B File Offset: 0x00025A0B
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x00026A1D File Offset: 0x00025A1D
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

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x00026A2B File Offset: 0x00025A2B
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x00026A3D File Offset: 0x00025A3D
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

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x00026A4B File Offset: 0x00025A4B
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x00026A5A File Offset: 0x00025A5A
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x00026A65 File Offset: 0x00025A65
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x00026A74 File Offset: 0x00025A74
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

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x00026A7F File Offset: 0x00025A7F
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x00026A91 File Offset: 0x00025A91
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

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x00026A9F File Offset: 0x00025A9F
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x00026AAE File Offset: 0x00025AAE
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

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x00026AB9 File Offset: 0x00025AB9
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x00026ACB File Offset: 0x00025ACB
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

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x00026AD9 File Offset: 0x00025AD9
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x00026AEB File Offset: 0x00025AEB
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

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x00026AF9 File Offset: 0x00025AF9
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x00026B08 File Offset: 0x00025B08
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

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x00026B13 File Offset: 0x00025B13
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x00026B25 File Offset: 0x00025B25
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

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x00026B33 File Offset: 0x00025B33
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x00026B45 File Offset: 0x00025B45
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

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x00026B53 File Offset: 0x00025B53
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x00026B65 File Offset: 0x00025B65
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

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x00026B73 File Offset: 0x00025B73
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x00026B85 File Offset: 0x00025B85
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

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x00026B93 File Offset: 0x00025B93
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x00026BA5 File Offset: 0x00025BA5
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

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x00026BB3 File Offset: 0x00025BB3
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x00026BC5 File Offset: 0x00025BC5
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

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x00026BD3 File Offset: 0x00025BD3
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x00026BE5 File Offset: 0x00025BE5
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

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x00026BF3 File Offset: 0x00025BF3
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x00026C05 File Offset: 0x00025C05
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

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x00026C13 File Offset: 0x00025C13
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x00026C25 File Offset: 0x00025C25
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

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x00026C33 File Offset: 0x00025C33
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x00026C45 File Offset: 0x00025C45
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

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x00026C53 File Offset: 0x00025C53
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x00026C65 File Offset: 0x00025C65
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

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x00026C73 File Offset: 0x00025C73
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x00026C85 File Offset: 0x00025C85
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x00026C93 File Offset: 0x00025C93
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x00026CA5 File Offset: 0x00025CA5
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

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x00026CB3 File Offset: 0x00025CB3
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x00026CC5 File Offset: 0x00025CC5
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

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x00026CD3 File Offset: 0x00025CD3
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x00026CE5 File Offset: 0x00025CE5
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

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x00026CF3 File Offset: 0x00025CF3
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x00026D05 File Offset: 0x00025D05
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

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x00026D13 File Offset: 0x00025D13
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x00026D25 File Offset: 0x00025D25
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

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x00026D33 File Offset: 0x00025D33
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x00026D45 File Offset: 0x00025D45
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

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x00026D53 File Offset: 0x00025D53
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x00026D65 File Offset: 0x00025D65
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

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x00026D73 File Offset: 0x00025D73
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x00026D85 File Offset: 0x00025D85
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

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x00026D93 File Offset: 0x00025D93
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x00026DA5 File Offset: 0x00025DA5
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

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x00026DB3 File Offset: 0x00025DB3
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x00026DC5 File Offset: 0x00025DC5
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

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x00026DD3 File Offset: 0x00025DD3
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x00026DE5 File Offset: 0x00025DE5
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

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x00026DF3 File Offset: 0x00025DF3
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x00026E02 File Offset: 0x00025E02
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

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x00026E0D File Offset: 0x00025E0D
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x00026E1C File Offset: 0x00025E1C
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

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x00026E27 File Offset: 0x00025E27
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x00026E36 File Offset: 0x00025E36
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

		// Token: 0x06002455 RID: 9301 RVA: 0x00026E44 File Offset: 0x00025E44
		public FIXNewOrderMultileg()
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00026EBC File Offset: 0x00025EBC
		public FIXNewOrderMultileg(string ClOrdID, char Side, int NoLegs, DateTime TransactTime, char OrdType)
		{
			this.ClOrdID = ClOrdID;
			this.Side = Side;
			this.NoLegs = NoLegs;
			this.TransactTime = TransactTime;
			this.OrdType = OrdType;
		}

		// Token: 0x04000348 RID: 840
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000349 RID: 841
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400034A RID: 842
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400034B RID: 843
		private ArrayList fAllocsGroup = new ArrayList();

		// Token: 0x0400034C RID: 844
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x0400034D RID: 845
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400034E RID: 846
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400034F RID: 847
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000350 RID: 848
		private ArrayList fLegsGroup = new ArrayList();
	}
}
