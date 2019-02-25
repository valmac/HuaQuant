using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000101 RID: 257
	public class FIXCollateralAssignment : FIXMessage
	{
		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x0003174B File Offset: 0x0003074B
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x0003175D File Offset: 0x0003075D
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

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x0003176B File Offset: 0x0003076B
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x0003177A File Offset: 0x0003077A
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

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00031785 File Offset: 0x00030785
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00031794 File Offset: 0x00030794
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

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x0003179F File Offset: 0x0003079F
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x000317AE File Offset: 0x000307AE
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

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000317B9 File Offset: 0x000307B9
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x000317C8 File Offset: 0x000307C8
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

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000317D3 File Offset: 0x000307D3
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x000317E2 File Offset: 0x000307E2
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

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000317ED File Offset: 0x000307ED
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x000317FF File Offset: 0x000307FF
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

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x0003180D File Offset: 0x0003080D
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x0003181C File Offset: 0x0003081C
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

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x00031827 File Offset: 0x00030827
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00031836 File Offset: 0x00030836
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

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x00031841 File Offset: 0x00030841
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00031850 File Offset: 0x00030850
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

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x0003185B File Offset: 0x0003085B
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x0003186A File Offset: 0x0003086A
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

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00031875 File Offset: 0x00030875
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00031887 File Offset: 0x00030887
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

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x00031895 File Offset: 0x00030895
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x000318A4 File Offset: 0x000308A4
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

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000318AF File Offset: 0x000308AF
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x000318BD File Offset: 0x000308BD
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

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000318C7 File Offset: 0x000308C7
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x000318D6 File Offset: 0x000308D6
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

		// Token: 0x06002F25 RID: 12069 RVA: 0x000318E1 File Offset: 0x000308E1
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000318F4 File Offset: 0x000308F4
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00031903 File Offset: 0x00030903
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x00031915 File Offset: 0x00030915
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

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00031923 File Offset: 0x00030923
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x00031935 File Offset: 0x00030935
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

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x00031943 File Offset: 0x00030943
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x00031952 File Offset: 0x00030952
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

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x0003195D File Offset: 0x0003095D
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x0003196C File Offset: 0x0003096C
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

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x00031977 File Offset: 0x00030977
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00031986 File Offset: 0x00030986
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

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x00031991 File Offset: 0x00030991
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x000319A0 File Offset: 0x000309A0
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

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000319AB File Offset: 0x000309AB
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x000319BD File Offset: 0x000309BD
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

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000319CB File Offset: 0x000309CB
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x000319DD File Offset: 0x000309DD
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

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000319EB File Offset: 0x000309EB
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x000319FD File Offset: 0x000309FD
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

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x00031A0B File Offset: 0x00030A0B
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x00031A1D File Offset: 0x00030A1D
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

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x00031A2B File Offset: 0x00030A2B
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x00031A3D File Offset: 0x00030A3D
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

		// Token: 0x06002F3D RID: 12093 RVA: 0x00031A4B File Offset: 0x00030A4B
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00031A69 File Offset: 0x00030A69
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x00031A86 File Offset: 0x00030A86
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x00031A98 File Offset: 0x00030A98
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

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x00031AA6 File Offset: 0x00030AA6
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x00031AB8 File Offset: 0x00030AB8
		[FIXField("902", EFieldOption.Required)]
		public string CollAsgnID
		{
			get
			{
				return this.GetStringField(902).Value;
			}
			set
			{
				this.AddStringField(902, value);
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x00031AC6 File Offset: 0x00030AC6
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x00031AD8 File Offset: 0x00030AD8
		[FIXField("894", EFieldOption.Optional)]
		public string CollReqID
		{
			get
			{
				return this.GetStringField(894).Value;
			}
			set
			{
				this.AddStringField(894, value);
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x00031AE6 File Offset: 0x00030AE6
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x00031AF8 File Offset: 0x00030AF8
		[FIXField("895", EFieldOption.Required)]
		public int CollAsgnReason
		{
			get
			{
				return this.GetIntField(895).Value;
			}
			set
			{
				this.AddIntField(895, value);
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x00031B06 File Offset: 0x00030B06
		// (set) Token: 0x06002F48 RID: 12104 RVA: 0x00031B18 File Offset: 0x00030B18
		[FIXField("903", EFieldOption.Required)]
		public int CollAsgnTransType
		{
			get
			{
				return this.GetIntField(903).Value;
			}
			set
			{
				this.AddIntField(903, value);
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x00031B26 File Offset: 0x00030B26
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x00031B38 File Offset: 0x00030B38
		[FIXField("907", EFieldOption.Optional)]
		public string CollAsgnRefID
		{
			get
			{
				return this.GetStringField(907).Value;
			}
			set
			{
				this.AddStringField(907, value);
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x00031B46 File Offset: 0x00030B46
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x00031B55 File Offset: 0x00030B55
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

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x00031B60 File Offset: 0x00030B60
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x00031B6F File Offset: 0x00030B6F
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

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x00031B7A File Offset: 0x00030B7A
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x00031B8C File Offset: 0x00030B8C
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

		// Token: 0x06002F51 RID: 12113 RVA: 0x00031B9A File Offset: 0x00030B9A
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00031BB8 File Offset: 0x00030BB8
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x00031BD5 File Offset: 0x00030BD5
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x00031BE3 File Offset: 0x00030BE3
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

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x00031BED File Offset: 0x00030BED
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x00031BFF File Offset: 0x00030BFF
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

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x00031C0D File Offset: 0x00030C0D
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x00031C1C File Offset: 0x00030C1C
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

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00031C27 File Offset: 0x00030C27
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x00031C36 File Offset: 0x00030C36
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

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00031C41 File Offset: 0x00030C41
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00031C53 File Offset: 0x00030C53
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

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x00031C61 File Offset: 0x00030C61
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x00031C73 File Offset: 0x00030C73
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

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x00031C81 File Offset: 0x00030C81
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00031C90 File Offset: 0x00030C90
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

		// Token: 0x06002F61 RID: 12129 RVA: 0x00031C9B File Offset: 0x00030C9B
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x00031CB9 File Offset: 0x00030CB9
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x00031CD6 File Offset: 0x00030CD6
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x00031CE8 File Offset: 0x00030CE8
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

		// Token: 0x06002F65 RID: 12133 RVA: 0x00031CF6 File Offset: 0x00030CF6
		public FIXTradesGroup GetTradesGroup(int i)
		{
			if (i < this.NoTrades)
			{
				return (FIXTradesGroup)this.fTradesGroup[i];
			}
			return null;
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00031D14 File Offset: 0x00030D14
		public void AddGroup(FIXTradesGroup group)
		{
			this.fTradesGroup.Add(group);
			this.NoTrades++;
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06002F67 RID: 12135 RVA: 0x00031D31 File Offset: 0x00030D31
		// (set) Token: 0x06002F68 RID: 12136 RVA: 0x00031D40 File Offset: 0x00030D40
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

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x00031D4B File Offset: 0x00030D4B
		// (set) Token: 0x06002F6A RID: 12138 RVA: 0x00031D5A File Offset: 0x00030D5A
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

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x00031D65 File Offset: 0x00030D65
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x00031D74 File Offset: 0x00030D74
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

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x00031D7F File Offset: 0x00030D7F
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x00031D8E File Offset: 0x00030D8E
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

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x00031D99 File Offset: 0x00030D99
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x00031DAB File Offset: 0x00030DAB
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

		// Token: 0x06002F71 RID: 12145 RVA: 0x00031DB9 File Offset: 0x00030DB9
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00031DD7 File Offset: 0x00030DD7
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00031DF4 File Offset: 0x00030DF4
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x00031E06 File Offset: 0x00030E06
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

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x00031E14 File Offset: 0x00030E14
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x00031E26 File Offset: 0x00030E26
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

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00031E34 File Offset: 0x00030E34
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00031E46 File Offset: 0x00030E46
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

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00031E54 File Offset: 0x00030E54
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x00031E66 File Offset: 0x00030E66
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

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x00031E74 File Offset: 0x00030E74
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x00031E86 File Offset: 0x00030E86
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

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x00031E94 File Offset: 0x00030E94
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x00031EA6 File Offset: 0x00030EA6
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

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x00031EB4 File Offset: 0x00030EB4
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00031EC6 File Offset: 0x00030EC6
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

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x00031ED4 File Offset: 0x00030ED4
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x00031EE6 File Offset: 0x00030EE6
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

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00031EF4 File Offset: 0x00030EF4
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x00031F06 File Offset: 0x00030F06
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

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x00031F14 File Offset: 0x00030F14
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00031F26 File Offset: 0x00030F26
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

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00031F34 File Offset: 0x00030F34
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00031F46 File Offset: 0x00030F46
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

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00031F54 File Offset: 0x00030F54
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x00031F66 File Offset: 0x00030F66
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

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x00031F74 File Offset: 0x00030F74
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00031F86 File Offset: 0x00030F86
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

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x00031F94 File Offset: 0x00030F94
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00031FA6 File Offset: 0x00030FA6
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

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x00031FB4 File Offset: 0x00030FB4
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x00031FC6 File Offset: 0x00030FC6
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

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00031FD4 File Offset: 0x00030FD4
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x00031FE6 File Offset: 0x00030FE6
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

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x00031FF4 File Offset: 0x00030FF4
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x00032006 File Offset: 0x00031006
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

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00032014 File Offset: 0x00031014
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00032026 File Offset: 0x00031026
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

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x00032034 File Offset: 0x00031034
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x00032046 File Offset: 0x00031046
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

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x00032054 File Offset: 0x00031054
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x00032066 File Offset: 0x00031066
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

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x00032074 File Offset: 0x00031074
		// (set) Token: 0x06002F9C RID: 12188 RVA: 0x00032086 File Offset: 0x00031086
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

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x00032094 File Offset: 0x00031094
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x000320A6 File Offset: 0x000310A6
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

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000320B4 File Offset: 0x000310B4
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x000320C6 File Offset: 0x000310C6
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

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000320D4 File Offset: 0x000310D4
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x000320E6 File Offset: 0x000310E6
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

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000320F4 File Offset: 0x000310F4
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x00032103 File Offset: 0x00031103
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

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x0003210E File Offset: 0x0003110E
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x00032120 File Offset: 0x00031120
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

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x0003212E File Offset: 0x0003112E
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x00032140 File Offset: 0x00031140
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

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x0003214E File Offset: 0x0003114E
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x0003215D File Offset: 0x0003115D
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

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x00032168 File Offset: 0x00031168
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0003217A File Offset: 0x0003117A
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

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x00032188 File Offset: 0x00031188
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x0003219A File Offset: 0x0003119A
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

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x000321A8 File Offset: 0x000311A8
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x000321BA File Offset: 0x000311BA
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

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x000321C8 File Offset: 0x000311C8
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x000321DA File Offset: 0x000311DA
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

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x000321E8 File Offset: 0x000311E8
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x000321FA File Offset: 0x000311FA
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

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x00032208 File Offset: 0x00031208
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x0003221A File Offset: 0x0003121A
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

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x00032228 File Offset: 0x00031228
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x0003223A File Offset: 0x0003123A
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

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00032248 File Offset: 0x00031248
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00032266 File Offset: 0x00031266
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x00032283 File Offset: 0x00031283
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x00032295 File Offset: 0x00031295
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

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000322A3 File Offset: 0x000312A3
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x000322B5 File Offset: 0x000312B5
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

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000322C3 File Offset: 0x000312C3
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x000322D5 File Offset: 0x000312D5
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

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000322E3 File Offset: 0x000312E3
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x000322F5 File Offset: 0x000312F5
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x00032303 File Offset: 0x00031303
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x00032315 File Offset: 0x00031315
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

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x00032323 File Offset: 0x00031323
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x00032335 File Offset: 0x00031335
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

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x00032343 File Offset: 0x00031343
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x00032355 File Offset: 0x00031355
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

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x00032363 File Offset: 0x00031363
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x00032375 File Offset: 0x00031375
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

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x00032383 File Offset: 0x00031383
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x00032395 File Offset: 0x00031395
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

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x000323A3 File Offset: 0x000313A3
		// (set) Token: 0x06002FCE RID: 12238 RVA: 0x000323B5 File Offset: 0x000313B5
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

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x000323C3 File Offset: 0x000313C3
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x000323D5 File Offset: 0x000313D5
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

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x000323E3 File Offset: 0x000313E3
		// (set) Token: 0x06002FD2 RID: 12242 RVA: 0x000323F2 File Offset: 0x000313F2
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

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x000323FD File Offset: 0x000313FD
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x0003240C File Offset: 0x0003140C
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

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x00032417 File Offset: 0x00031417
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x00032429 File Offset: 0x00031429
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

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x00032437 File Offset: 0x00031437
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x00032446 File Offset: 0x00031446
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

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x00032451 File Offset: 0x00031451
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x00032463 File Offset: 0x00031463
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

		// Token: 0x06002FDB RID: 12251 RVA: 0x00032471 File Offset: 0x00031471
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0003248F File Offset: 0x0003148F
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x000324AC File Offset: 0x000314AC
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x000324BE File Offset: 0x000314BE
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

		// Token: 0x06002FDF RID: 12255 RVA: 0x000324CC File Offset: 0x000314CC
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x000324EA File Offset: 0x000314EA
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x00032507 File Offset: 0x00031507
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x00032519 File Offset: 0x00031519
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

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x00032527 File Offset: 0x00031527
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00032539 File Offset: 0x00031539
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

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x00032547 File Offset: 0x00031547
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x00032559 File Offset: 0x00031559
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

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x00032567 File Offset: 0x00031567
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x00032579 File Offset: 0x00031579
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

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00032587 File Offset: 0x00031587
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000325A5 File Offset: 0x000315A5
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x000325C2 File Offset: 0x000315C2
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x000325D1 File Offset: 0x000315D1
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

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x000325DC File Offset: 0x000315DC
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x000325EE File Offset: 0x000315EE
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

		// Token: 0x06002FEF RID: 12271 RVA: 0x000325FC File Offset: 0x000315FC
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0003261A File Offset: 0x0003161A
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x00032637 File Offset: 0x00031637
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x00032646 File Offset: 0x00031646
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

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x00032651 File Offset: 0x00031651
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x00032663 File Offset: 0x00031663
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

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x00032671 File Offset: 0x00031671
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x00032683 File Offset: 0x00031683
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

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x00032691 File Offset: 0x00031691
		// (set) Token: 0x06002FF8 RID: 12280 RVA: 0x000326A3 File Offset: 0x000316A3
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

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06002FF9 RID: 12281 RVA: 0x000326B1 File Offset: 0x000316B1
		// (set) Token: 0x06002FFA RID: 12282 RVA: 0x000326C3 File Offset: 0x000316C3
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

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x000326D1 File Offset: 0x000316D1
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x000326E3 File Offset: 0x000316E3
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

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x000326F1 File Offset: 0x000316F1
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x00032703 File Offset: 0x00031703
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

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x00032711 File Offset: 0x00031711
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x00032723 File Offset: 0x00031723
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

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x00032731 File Offset: 0x00031731
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x00032743 File Offset: 0x00031743
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

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x00032751 File Offset: 0x00031751
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x00032763 File Offset: 0x00031763
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

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x00032771 File Offset: 0x00031771
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x00032783 File Offset: 0x00031783
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

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06003007 RID: 12295 RVA: 0x00032791 File Offset: 0x00031791
		// (set) Token: 0x06003008 RID: 12296 RVA: 0x000327A3 File Offset: 0x000317A3
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

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x000327B1 File Offset: 0x000317B1
		// (set) Token: 0x0600300A RID: 12298 RVA: 0x000327C3 File Offset: 0x000317C3
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

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x000327D1 File Offset: 0x000317D1
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x000327E3 File Offset: 0x000317E3
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

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x000327F1 File Offset: 0x000317F1
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x00032803 File Offset: 0x00031803
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

		// Token: 0x0600300F RID: 12303 RVA: 0x00032811 File Offset: 0x00031811
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0003282F File Offset: 0x0003182F
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x0003284C File Offset: 0x0003184C
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x0003285E File Offset: 0x0003185E
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

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x0003286C File Offset: 0x0003186C
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x0003287E File Offset: 0x0003187E
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

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06003015 RID: 12309 RVA: 0x0003288C File Offset: 0x0003188C
		// (set) Token: 0x06003016 RID: 12310 RVA: 0x0003289E File Offset: 0x0003189E
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

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x000328AC File Offset: 0x000318AC
		// (set) Token: 0x06003018 RID: 12312 RVA: 0x000328BE File Offset: 0x000318BE
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

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x000328CC File Offset: 0x000318CC
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x000328DB File Offset: 0x000318DB
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

		// Token: 0x0600301B RID: 12315 RVA: 0x000328E6 File Offset: 0x000318E6
		public FIXDlvyInstGroup GetDlvyInstGroup(int i)
		{
			if (i < this.NoDlvyInst)
			{
				return (FIXDlvyInstGroup)this.fDlvyInstGroup[i];
			}
			return null;
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00032904 File Offset: 0x00031904
		public void AddGroup(FIXDlvyInstGroup group)
		{
			this.fDlvyInstGroup.Add(group);
			this.NoDlvyInst++;
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x00032921 File Offset: 0x00031921
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x00032933 File Offset: 0x00031933
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

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x00032941 File Offset: 0x00031941
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x00032953 File Offset: 0x00031953
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

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x00032961 File Offset: 0x00031961
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x00032973 File Offset: 0x00031973
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

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00032981 File Offset: 0x00031981
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x00032993 File Offset: 0x00031993
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

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x000329A1 File Offset: 0x000319A1
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x000329B3 File Offset: 0x000319B3
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

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x000329C1 File Offset: 0x000319C1
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x000329D0 File Offset: 0x000319D0
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

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x000329DB File Offset: 0x000319DB
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x000329ED File Offset: 0x000319ED
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

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000329FB File Offset: 0x000319FB
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x00032A0D File Offset: 0x00031A0D
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

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x00032A1B File Offset: 0x00031A1B
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x00032A2A File Offset: 0x00031A2A
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

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00032A35 File Offset: 0x00031A35
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x00032A44 File Offset: 0x00031A44
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

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x00032A4F File Offset: 0x00031A4F
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00032A5E File Offset: 0x00031A5E
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

		// Token: 0x06003033 RID: 12339 RVA: 0x00032A6C File Offset: 0x00031A6C
		public FIXCollateralAssignment()
		{
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00032B10 File Offset: 0x00031B10
		public FIXCollateralAssignment(string CollAsgnID, int CollAsgnReason, int CollAsgnTransType, DateTime TransactTime)
		{
			this.CollAsgnID = CollAsgnID;
			this.CollAsgnReason = CollAsgnReason;
			this.CollAsgnTransType = CollAsgnTransType;
			this.TransactTime = TransactTime;
		}

		// Token: 0x0400041F RID: 1055
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000420 RID: 1056
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000421 RID: 1057
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000422 RID: 1058
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x04000423 RID: 1059
		private ArrayList fTradesGroup = new ArrayList();

		// Token: 0x04000424 RID: 1060
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000425 RID: 1061
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000426 RID: 1062
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000427 RID: 1063
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000428 RID: 1064
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x04000429 RID: 1065
		private ArrayList fMiscFeesGroup = new ArrayList();

		// Token: 0x0400042A RID: 1066
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x0400042B RID: 1067
		private ArrayList fDlvyInstGroup = new ArrayList();
	}
}
