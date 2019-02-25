using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200017E RID: 382
	public class FIXPositionMaintenanceReport : FIXMessage
	{
		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x0004E1A6 File Offset: 0x0004D1A6
		// (set) Token: 0x06004661 RID: 18017 RVA: 0x0004E1B8 File Offset: 0x0004D1B8
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

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x0004E1C6 File Offset: 0x0004D1C6
		// (set) Token: 0x06004663 RID: 18019 RVA: 0x0004E1D5 File Offset: 0x0004D1D5
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

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x0004E1E0 File Offset: 0x0004D1E0
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x0004E1EF File Offset: 0x0004D1EF
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

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x0004E1FA File Offset: 0x0004D1FA
		// (set) Token: 0x06004667 RID: 18023 RVA: 0x0004E209 File Offset: 0x0004D209
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

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06004668 RID: 18024 RVA: 0x0004E214 File Offset: 0x0004D214
		// (set) Token: 0x06004669 RID: 18025 RVA: 0x0004E223 File Offset: 0x0004D223
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

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x0004E22E File Offset: 0x0004D22E
		// (set) Token: 0x0600466B RID: 18027 RVA: 0x0004E23D File Offset: 0x0004D23D
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

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x0004E248 File Offset: 0x0004D248
		// (set) Token: 0x0600466D RID: 18029 RVA: 0x0004E25A File Offset: 0x0004D25A
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

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x0004E268 File Offset: 0x0004D268
		// (set) Token: 0x0600466F RID: 18031 RVA: 0x0004E277 File Offset: 0x0004D277
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

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x0004E282 File Offset: 0x0004D282
		// (set) Token: 0x06004671 RID: 18033 RVA: 0x0004E291 File Offset: 0x0004D291
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

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06004672 RID: 18034 RVA: 0x0004E29C File Offset: 0x0004D29C
		// (set) Token: 0x06004673 RID: 18035 RVA: 0x0004E2AB File Offset: 0x0004D2AB
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

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x0004E2B6 File Offset: 0x0004D2B6
		// (set) Token: 0x06004675 RID: 18037 RVA: 0x0004E2C5 File Offset: 0x0004D2C5
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

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x0004E2D0 File Offset: 0x0004D2D0
		// (set) Token: 0x06004677 RID: 18039 RVA: 0x0004E2E2 File Offset: 0x0004D2E2
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

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x0004E2F0 File Offset: 0x0004D2F0
		// (set) Token: 0x06004679 RID: 18041 RVA: 0x0004E2FF File Offset: 0x0004D2FF
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

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x0004E30A File Offset: 0x0004D30A
		// (set) Token: 0x0600467B RID: 18043 RVA: 0x0004E318 File Offset: 0x0004D318
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

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x0004E322 File Offset: 0x0004D322
		// (set) Token: 0x0600467D RID: 18045 RVA: 0x0004E331 File Offset: 0x0004D331
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

		// Token: 0x0600467E RID: 18046 RVA: 0x0004E33C File Offset: 0x0004D33C
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x0004E34F File Offset: 0x0004D34F
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x0004E35E File Offset: 0x0004D35E
		// (set) Token: 0x06004681 RID: 18049 RVA: 0x0004E370 File Offset: 0x0004D370
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

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x0004E37E File Offset: 0x0004D37E
		// (set) Token: 0x06004683 RID: 18051 RVA: 0x0004E390 File Offset: 0x0004D390
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

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x0004E39E File Offset: 0x0004D39E
		// (set) Token: 0x06004685 RID: 18053 RVA: 0x0004E3AD File Offset: 0x0004D3AD
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

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x0004E3B8 File Offset: 0x0004D3B8
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x0004E3C7 File Offset: 0x0004D3C7
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

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x0004E3D2 File Offset: 0x0004D3D2
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x0004E3E1 File Offset: 0x0004D3E1
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

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x0004E3EC File Offset: 0x0004D3EC
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x0004E3FB File Offset: 0x0004D3FB
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

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x0004E406 File Offset: 0x0004D406
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x0004E418 File Offset: 0x0004D418
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

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x0004E426 File Offset: 0x0004D426
		// (set) Token: 0x0600468F RID: 18063 RVA: 0x0004E438 File Offset: 0x0004D438
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

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x0004E446 File Offset: 0x0004D446
		// (set) Token: 0x06004691 RID: 18065 RVA: 0x0004E458 File Offset: 0x0004D458
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

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x0004E466 File Offset: 0x0004D466
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x0004E478 File Offset: 0x0004D478
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

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x0004E486 File Offset: 0x0004D486
		// (set) Token: 0x06004695 RID: 18069 RVA: 0x0004E498 File Offset: 0x0004D498
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

		// Token: 0x06004696 RID: 18070 RVA: 0x0004E4A6 File Offset: 0x0004D4A6
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x0004E4C4 File Offset: 0x0004D4C4
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x0004E4E1 File Offset: 0x0004D4E1
		// (set) Token: 0x06004699 RID: 18073 RVA: 0x0004E4F3 File Offset: 0x0004D4F3
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

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x0004E501 File Offset: 0x0004D501
		// (set) Token: 0x0600469B RID: 18075 RVA: 0x0004E513 File Offset: 0x0004D513
		[FIXField("721", EFieldOption.Required)]
		public string PosMaintRptID
		{
			get
			{
				return this.GetStringField(721).Value;
			}
			set
			{
				this.AddStringField(721, value);
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x0004E521 File Offset: 0x0004D521
		// (set) Token: 0x0600469D RID: 18077 RVA: 0x0004E533 File Offset: 0x0004D533
		[FIXField("709", EFieldOption.Required)]
		public int PosTransType
		{
			get
			{
				return this.GetIntField(709).Value;
			}
			set
			{
				this.AddIntField(709, value);
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x0004E541 File Offset: 0x0004D541
		// (set) Token: 0x0600469F RID: 18079 RVA: 0x0004E553 File Offset: 0x0004D553
		[FIXField("710", EFieldOption.Optional)]
		public string PosReqID
		{
			get
			{
				return this.GetStringField(710).Value;
			}
			set
			{
				this.AddStringField(710, value);
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x0004E561 File Offset: 0x0004D561
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x0004E573 File Offset: 0x0004D573
		[FIXField("712", EFieldOption.Required)]
		public int PosMaintAction
		{
			get
			{
				return this.GetIntField(712).Value;
			}
			set
			{
				this.AddIntField(712, value);
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x0004E581 File Offset: 0x0004D581
		// (set) Token: 0x060046A3 RID: 18083 RVA: 0x0004E593 File Offset: 0x0004D593
		[FIXField("713", EFieldOption.Required)]
		public string OrigPosReqRefID
		{
			get
			{
				return this.GetStringField(713).Value;
			}
			set
			{
				this.AddStringField(713, value);
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x0004E5A1 File Offset: 0x0004D5A1
		// (set) Token: 0x060046A5 RID: 18085 RVA: 0x0004E5B3 File Offset: 0x0004D5B3
		[FIXField("722", EFieldOption.Required)]
		public int PosMaintStatus
		{
			get
			{
				return this.GetIntField(722).Value;
			}
			set
			{
				this.AddIntField(722, value);
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x0004E5C1 File Offset: 0x0004D5C1
		// (set) Token: 0x060046A7 RID: 18087 RVA: 0x0004E5D3 File Offset: 0x0004D5D3
		[FIXField("723", EFieldOption.Optional)]
		public int PosMaintResult
		{
			get
			{
				return this.GetIntField(723).Value;
			}
			set
			{
				this.AddIntField(723, value);
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x0004E5E1 File Offset: 0x0004D5E1
		// (set) Token: 0x060046A9 RID: 18089 RVA: 0x0004E5F3 File Offset: 0x0004D5F3
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

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x0004E601 File Offset: 0x0004D601
		// (set) Token: 0x060046AB RID: 18091 RVA: 0x0004E613 File Offset: 0x0004D613
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

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x0004E621 File Offset: 0x0004D621
		// (set) Token: 0x060046AD RID: 18093 RVA: 0x0004E633 File Offset: 0x0004D633
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

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x0004E641 File Offset: 0x0004D641
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x0004E653 File Offset: 0x0004D653
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

		// Token: 0x060046B0 RID: 18096 RVA: 0x0004E661 File Offset: 0x0004D661
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x0004E67F File Offset: 0x0004D67F
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x0004E69C File Offset: 0x0004D69C
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x0004E6AA File Offset: 0x0004D6AA
		[FIXField("1", EFieldOption.Required)]
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

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x0004E6B4 File Offset: 0x0004D6B4
		// (set) Token: 0x060046B5 RID: 18101 RVA: 0x0004E6C6 File Offset: 0x0004D6C6
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

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x0004E6D4 File Offset: 0x0004D6D4
		// (set) Token: 0x060046B7 RID: 18103 RVA: 0x0004E6E6 File Offset: 0x0004D6E6
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

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x0004E6F4 File Offset: 0x0004D6F4
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x0004E703 File Offset: 0x0004D703
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

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x0004E70E File Offset: 0x0004D70E
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x0004E71D File Offset: 0x0004D71D
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

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x0004E728 File Offset: 0x0004D728
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x0004E737 File Offset: 0x0004D737
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

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x0004E742 File Offset: 0x0004D742
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x0004E751 File Offset: 0x0004D751
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

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x0004E75C File Offset: 0x0004D75C
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x0004E76E File Offset: 0x0004D76E
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

		// Token: 0x060046C2 RID: 18114 RVA: 0x0004E77C File Offset: 0x0004D77C
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x0004E79A File Offset: 0x0004D79A
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x0004E7B7 File Offset: 0x0004D7B7
		// (set) Token: 0x060046C5 RID: 18117 RVA: 0x0004E7C9 File Offset: 0x0004D7C9
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

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x0004E7D7 File Offset: 0x0004D7D7
		// (set) Token: 0x060046C7 RID: 18119 RVA: 0x0004E7E9 File Offset: 0x0004D7E9
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

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x0004E7F7 File Offset: 0x0004D7F7
		// (set) Token: 0x060046C9 RID: 18121 RVA: 0x0004E809 File Offset: 0x0004D809
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

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x0004E817 File Offset: 0x0004D817
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x0004E829 File Offset: 0x0004D829
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

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x0004E837 File Offset: 0x0004D837
		// (set) Token: 0x060046CD RID: 18125 RVA: 0x0004E849 File Offset: 0x0004D849
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

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x0004E857 File Offset: 0x0004D857
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x0004E869 File Offset: 0x0004D869
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

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x060046D0 RID: 18128 RVA: 0x0004E877 File Offset: 0x0004D877
		// (set) Token: 0x060046D1 RID: 18129 RVA: 0x0004E889 File Offset: 0x0004D889
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

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x0004E897 File Offset: 0x0004D897
		// (set) Token: 0x060046D3 RID: 18131 RVA: 0x0004E8A9 File Offset: 0x0004D8A9
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

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x0004E8B7 File Offset: 0x0004D8B7
		// (set) Token: 0x060046D5 RID: 18133 RVA: 0x0004E8C9 File Offset: 0x0004D8C9
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

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x0004E8D7 File Offset: 0x0004D8D7
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x0004E8E9 File Offset: 0x0004D8E9
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

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x0004E8F7 File Offset: 0x0004D8F7
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x0004E909 File Offset: 0x0004D909
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

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x0004E917 File Offset: 0x0004D917
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x0004E929 File Offset: 0x0004D929
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

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x0004E937 File Offset: 0x0004D937
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x0004E949 File Offset: 0x0004D949
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

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x0004E957 File Offset: 0x0004D957
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x0004E969 File Offset: 0x0004D969
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

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x0004E977 File Offset: 0x0004D977
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x0004E989 File Offset: 0x0004D989
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

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x0004E997 File Offset: 0x0004D997
		// (set) Token: 0x060046E3 RID: 18147 RVA: 0x0004E9A9 File Offset: 0x0004D9A9
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

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x0004E9B7 File Offset: 0x0004D9B7
		// (set) Token: 0x060046E5 RID: 18149 RVA: 0x0004E9C9 File Offset: 0x0004D9C9
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

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x0004E9D7 File Offset: 0x0004D9D7
		// (set) Token: 0x060046E7 RID: 18151 RVA: 0x0004E9E9 File Offset: 0x0004D9E9
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

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x060046E8 RID: 18152 RVA: 0x0004E9F7 File Offset: 0x0004D9F7
		// (set) Token: 0x060046E9 RID: 18153 RVA: 0x0004EA09 File Offset: 0x0004DA09
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

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x0004EA17 File Offset: 0x0004DA17
		// (set) Token: 0x060046EB RID: 18155 RVA: 0x0004EA29 File Offset: 0x0004DA29
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

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x0004EA37 File Offset: 0x0004DA37
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x0004EA49 File Offset: 0x0004DA49
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

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x0004EA57 File Offset: 0x0004DA57
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x0004EA69 File Offset: 0x0004DA69
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

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x0004EA77 File Offset: 0x0004DA77
		// (set) Token: 0x060046F1 RID: 18161 RVA: 0x0004EA89 File Offset: 0x0004DA89
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

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x0004EA97 File Offset: 0x0004DA97
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x0004EAA9 File Offset: 0x0004DAA9
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

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x0004EAB7 File Offset: 0x0004DAB7
		// (set) Token: 0x060046F5 RID: 18165 RVA: 0x0004EAC6 File Offset: 0x0004DAC6
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

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x0004EAD1 File Offset: 0x0004DAD1
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x0004EAE3 File Offset: 0x0004DAE3
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

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x0004EAF1 File Offset: 0x0004DAF1
		// (set) Token: 0x060046F9 RID: 18169 RVA: 0x0004EB03 File Offset: 0x0004DB03
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

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x0004EB11 File Offset: 0x0004DB11
		// (set) Token: 0x060046FB RID: 18171 RVA: 0x0004EB20 File Offset: 0x0004DB20
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

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x0004EB2B File Offset: 0x0004DB2B
		// (set) Token: 0x060046FD RID: 18173 RVA: 0x0004EB3D File Offset: 0x0004DB3D
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

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x0004EB4B File Offset: 0x0004DB4B
		// (set) Token: 0x060046FF RID: 18175 RVA: 0x0004EB5D File Offset: 0x0004DB5D
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

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x0004EB6B File Offset: 0x0004DB6B
		// (set) Token: 0x06004701 RID: 18177 RVA: 0x0004EB7D File Offset: 0x0004DB7D
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

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x0004EB8B File Offset: 0x0004DB8B
		// (set) Token: 0x06004703 RID: 18179 RVA: 0x0004EB9D File Offset: 0x0004DB9D
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

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x0004EBAB File Offset: 0x0004DBAB
		// (set) Token: 0x06004705 RID: 18181 RVA: 0x0004EBBD File Offset: 0x0004DBBD
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

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x0004EBCB File Offset: 0x0004DBCB
		// (set) Token: 0x06004707 RID: 18183 RVA: 0x0004EBDD File Offset: 0x0004DBDD
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

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x0004EBEB File Offset: 0x0004DBEB
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x0004EBFD File Offset: 0x0004DBFD
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

		// Token: 0x0600470A RID: 18186 RVA: 0x0004EC0B File Offset: 0x0004DC0B
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x0004EC29 File Offset: 0x0004DC29
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x0004EC46 File Offset: 0x0004DC46
		// (set) Token: 0x0600470D RID: 18189 RVA: 0x0004EC58 File Offset: 0x0004DC58
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

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x0004EC66 File Offset: 0x0004DC66
		// (set) Token: 0x0600470F RID: 18191 RVA: 0x0004EC78 File Offset: 0x0004DC78
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

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06004710 RID: 18192 RVA: 0x0004EC86 File Offset: 0x0004DC86
		// (set) Token: 0x06004711 RID: 18193 RVA: 0x0004EC95 File Offset: 0x0004DC95
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

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x0004ECA0 File Offset: 0x0004DCA0
		// (set) Token: 0x06004713 RID: 18195 RVA: 0x0004ECB2 File Offset: 0x0004DCB2
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

		// Token: 0x06004714 RID: 18196 RVA: 0x0004ECC0 File Offset: 0x0004DCC0
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x0004ECDE File Offset: 0x0004DCDE
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06004716 RID: 18198 RVA: 0x0004ECFB File Offset: 0x0004DCFB
		// (set) Token: 0x06004717 RID: 18199 RVA: 0x0004ED0D File Offset: 0x0004DD0D
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

		// Token: 0x06004718 RID: 18200 RVA: 0x0004ED1B File Offset: 0x0004DD1B
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x0004ED39 File Offset: 0x0004DD39
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x0600471A RID: 18202 RVA: 0x0004ED56 File Offset: 0x0004DD56
		// (set) Token: 0x0600471B RID: 18203 RVA: 0x0004ED68 File Offset: 0x0004DD68
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

		// Token: 0x0600471C RID: 18204 RVA: 0x0004ED76 File Offset: 0x0004DD76
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0004ED94 File Offset: 0x0004DD94
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x0004EDB1 File Offset: 0x0004DDB1
		// (set) Token: 0x0600471F RID: 18207 RVA: 0x0004EDC0 File Offset: 0x0004DDC0
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

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x0004EDCB File Offset: 0x0004DDCB
		// (set) Token: 0x06004721 RID: 18209 RVA: 0x0004EDDD File Offset: 0x0004DDDD
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

		// Token: 0x06004722 RID: 18210 RVA: 0x0004EDEB File Offset: 0x0004DDEB
		public FIXPositionsGroup GetPositionsGroup(int i)
		{
			if (i < this.NoPositions)
			{
				return (FIXPositionsGroup)this.fPositionsGroup[i];
			}
			return null;
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x0004EE09 File Offset: 0x0004DE09
		public void AddGroup(FIXPositionsGroup group)
		{
			this.fPositionsGroup.Add(group);
			this.NoPositions++;
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x0004EE26 File Offset: 0x0004DE26
		// (set) Token: 0x06004725 RID: 18213 RVA: 0x0004EE38 File Offset: 0x0004DE38
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

		// Token: 0x06004726 RID: 18214 RVA: 0x0004EE46 File Offset: 0x0004DE46
		public FIXPosAmtGroup GetPosAmtGroup(int i)
		{
			if (i < this.NoPosAmt)
			{
				return (FIXPosAmtGroup)this.fPosAmtGroup[i];
			}
			return null;
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0004EE64 File Offset: 0x0004DE64
		public void AddGroup(FIXPosAmtGroup group)
		{
			this.fPosAmtGroup.Add(group);
			this.NoPosAmt++;
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06004728 RID: 18216 RVA: 0x0004EE81 File Offset: 0x0004DE81
		// (set) Token: 0x06004729 RID: 18217 RVA: 0x0004EE93 File Offset: 0x0004DE93
		[FIXField("718", EFieldOption.Optional)]
		public int AdjustmentType
		{
			get
			{
				return this.GetIntField(718).Value;
			}
			set
			{
				this.AddIntField(718, value);
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x0004EEA1 File Offset: 0x0004DEA1
		// (set) Token: 0x0600472B RID: 18219 RVA: 0x0004EEB3 File Offset: 0x0004DEB3
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

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x0004EEC1 File Offset: 0x0004DEC1
		// (set) Token: 0x0600472D RID: 18221 RVA: 0x0004EED0 File Offset: 0x0004DED0
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

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x0004EEDB File Offset: 0x0004DEDB
		// (set) Token: 0x0600472F RID: 18223 RVA: 0x0004EEED File Offset: 0x0004DEED
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

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x0004EEFB File Offset: 0x0004DEFB
		// (set) Token: 0x06004731 RID: 18225 RVA: 0x0004EF0D File Offset: 0x0004DF0D
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

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x0004EF1B File Offset: 0x0004DF1B
		// (set) Token: 0x06004733 RID: 18227 RVA: 0x0004EF2A File Offset: 0x0004DF2A
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

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x0004EF35 File Offset: 0x0004DF35
		// (set) Token: 0x06004735 RID: 18229 RVA: 0x0004EF44 File Offset: 0x0004DF44
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

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06004736 RID: 18230 RVA: 0x0004EF4F File Offset: 0x0004DF4F
		// (set) Token: 0x06004737 RID: 18231 RVA: 0x0004EF5E File Offset: 0x0004DF5E
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

		// Token: 0x06004738 RID: 18232 RVA: 0x0004EF6C File Offset: 0x0004DF6C
		public FIXPositionMaintenanceReport()
		{
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0004EFF0 File Offset: 0x0004DFF0
		public FIXPositionMaintenanceReport(string PosMaintRptID, int PosTransType, int PosMaintAction, string OrigPosReqRefID, int PosMaintStatus, DateTime ClearingBusinessDate, string Account, int AccountType, DateTime TransactTime)
		{
			this.PosMaintRptID = PosMaintRptID;
			this.PosTransType = PosTransType;
			this.PosMaintAction = PosMaintAction;
			this.OrigPosReqRefID = OrigPosReqRefID;
			this.PosMaintStatus = PosMaintStatus;
			this.ClearingBusinessDate = ClearingBusinessDate;
			this.Account = Account;
			this.AccountType = AccountType;
			this.TransactTime = TransactTime;
		}

		// Token: 0x04000D91 RID: 3473
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000D92 RID: 3474
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000D93 RID: 3475
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000D94 RID: 3476
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000D95 RID: 3477
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000D96 RID: 3478
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000D97 RID: 3479
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000D98 RID: 3480
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x04000D99 RID: 3481
		private ArrayList fPositionsGroup = new ArrayList();

		// Token: 0x04000D9A RID: 3482
		private ArrayList fPosAmtGroup = new ArrayList();
	}
}
