using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000035 RID: 53
	public class FIXMassQuoteAcknowledgement : FIXMessage
	{
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0000ED87 File Offset: 0x0000DD87
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x0000ED99 File Offset: 0x0000DD99
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

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0000EDA7 File Offset: 0x0000DDA7
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x0000EDB6 File Offset: 0x0000DDB6
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0000EDC1 File Offset: 0x0000DDC1
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x0000EDD0 File Offset: 0x0000DDD0
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0000EDDB File Offset: 0x0000DDDB
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x0000EDEA File Offset: 0x0000DDEA
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0000EDF5 File Offset: 0x0000DDF5
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0000EE04 File Offset: 0x0000DE04
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0000EE0F File Offset: 0x0000DE0F
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x0000EE1E File Offset: 0x0000DE1E
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0000EE29 File Offset: 0x0000DE29
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0000EE3B File Offset: 0x0000DE3B
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0000EE49 File Offset: 0x0000DE49
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0000EE58 File Offset: 0x0000DE58
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0000EE63 File Offset: 0x0000DE63
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x0000EE72 File Offset: 0x0000DE72
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0000EE7D File Offset: 0x0000DE7D
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x0000EE8C File Offset: 0x0000DE8C
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

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0000EE97 File Offset: 0x0000DE97
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x0000EEA6 File Offset: 0x0000DEA6
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

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0000EEB1 File Offset: 0x0000DEB1
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x0000EEC3 File Offset: 0x0000DEC3
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0000EED1 File Offset: 0x0000DED1
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x0000EEE0 File Offset: 0x0000DEE0
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0000EEEB File Offset: 0x0000DEEB
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0000EEF9 File Offset: 0x0000DEF9
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0000EF03 File Offset: 0x0000DF03
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x0000EF12 File Offset: 0x0000DF12
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

		// Token: 0x06000C79 RID: 3193 RVA: 0x0000EF1D File Offset: 0x0000DF1D
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0000EF30 File Offset: 0x0000DF30
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0000EF3F File Offset: 0x0000DF3F
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x0000EF51 File Offset: 0x0000DF51
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

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0000EF5F File Offset: 0x0000DF5F
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x0000EF71 File Offset: 0x0000DF71
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0000EF7F File Offset: 0x0000DF7F
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x0000EF8E File Offset: 0x0000DF8E
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0000EF99 File Offset: 0x0000DF99
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0000EFA8 File Offset: 0x0000DFA8
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0000EFB3 File Offset: 0x0000DFB3
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x0000EFC2 File Offset: 0x0000DFC2
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0000EFCD File Offset: 0x0000DFCD
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x0000EFDC File Offset: 0x0000DFDC
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0000EFE7 File Offset: 0x0000DFE7
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x0000EFF9 File Offset: 0x0000DFF9
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0000F007 File Offset: 0x0000E007
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x0000F019 File Offset: 0x0000E019
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0000F027 File Offset: 0x0000E027
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x0000F039 File Offset: 0x0000E039
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0000F047 File Offset: 0x0000E047
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x0000F059 File Offset: 0x0000E059
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0000F067 File Offset: 0x0000E067
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0000F079 File Offset: 0x0000E079
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

		// Token: 0x06000C91 RID: 3217 RVA: 0x0000F087 File Offset: 0x0000E087
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0000F0A5 File Offset: 0x0000E0A5
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0000F0C2 File Offset: 0x0000E0C2
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x0000F0D4 File Offset: 0x0000E0D4
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0000F0E2 File Offset: 0x0000E0E2
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x0000F0F4 File Offset: 0x0000E0F4
		[FIXField("131", EFieldOption.Optional)]
		public string QuoteReqID
		{
			get
			{
				return this.GetStringField(131).Value;
			}
			set
			{
				this.AddStringField(131, value);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0000F102 File Offset: 0x0000E102
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x0000F111 File Offset: 0x0000E111
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0000F11C File Offset: 0x0000E11C
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x0000F12E File Offset: 0x0000E12E
		[FIXField("297", EFieldOption.Required)]
		public int QuoteStatus
		{
			get
			{
				return this.GetIntField(297).Value;
			}
			set
			{
				this.AddIntField(297, value);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0000F13C File Offset: 0x0000E13C
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x0000F14E File Offset: 0x0000E14E
		[FIXField("300", EFieldOption.Optional)]
		public int QuoteRejectReason
		{
			get
			{
				return this.GetIntField(300).Value;
			}
			set
			{
				this.AddIntField(300, value);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0000F15C File Offset: 0x0000E15C
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0000F16E File Offset: 0x0000E16E
		[FIXField("301", EFieldOption.Optional)]
		public int QuoteResponseLevel
		{
			get
			{
				return this.GetIntField(301).Value;
			}
			set
			{
				this.AddIntField(301, value);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0000F17C File Offset: 0x0000E17C
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x0000F18E File Offset: 0x0000E18E
		[FIXField("537", EFieldOption.Optional)]
		public int QuoteType
		{
			get
			{
				return this.GetIntField(537).Value;
			}
			set
			{
				this.AddIntField(537, value);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0000F19C File Offset: 0x0000E19C
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x0000F1AE File Offset: 0x0000E1AE
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

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0000F1BC File Offset: 0x0000E1BC
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0000F1DA File Offset: 0x0000E1DA
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0000F1F7 File Offset: 0x0000E1F7
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0000F205 File Offset: 0x0000E205
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

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0000F20F File Offset: 0x0000E20F
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0000F221 File Offset: 0x0000E221
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0000F22F File Offset: 0x0000E22F
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x0000F241 File Offset: 0x0000E241
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

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0000F24F File Offset: 0x0000E24F
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x0000F25E File Offset: 0x0000E25E
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0000F269 File Offset: 0x0000E269
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0000F27B File Offset: 0x0000E27B
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0000F289 File Offset: 0x0000E289
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x0000F29B File Offset: 0x0000E29B
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0000F2A9 File Offset: 0x0000E2A9
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0000F2BB File Offset: 0x0000E2BB
		[FIXField("296", EFieldOption.Optional)]
		public int NoQuoteSets
		{
			get
			{
				return this.GetIntField(296).Value;
			}
			set
			{
				this.AddIntField(296, value);
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0000F2C9 File Offset: 0x0000E2C9
		public FIXQuoteSetsGroup GetQuoteSetsGroup(int i)
		{
			if (i < this.NoQuoteSets)
			{
				return (FIXQuoteSetsGroup)this.fQuoteSetsGroup[i];
			}
			return null;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0000F2E7 File Offset: 0x0000E2E7
		public void AddGroup(FIXQuoteSetsGroup group)
		{
			this.fQuoteSetsGroup.Add(group);
			this.NoQuoteSets++;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0000F304 File Offset: 0x0000E304
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x0000F313 File Offset: 0x0000E313
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0000F31E File Offset: 0x0000E31E
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x0000F32D File Offset: 0x0000E32D
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

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0000F338 File Offset: 0x0000E338
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x0000F347 File Offset: 0x0000E347
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

		// Token: 0x06000CBB RID: 3259 RVA: 0x0000F352 File Offset: 0x0000E352
		public FIXMassQuoteAcknowledgement()
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0000F386 File Offset: 0x0000E386
		public FIXMassQuoteAcknowledgement(int QuoteStatus)
		{
			this.QuoteStatus = QuoteStatus;
		}

		// Token: 0x04000099 RID: 153
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400009A RID: 154
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400009B RID: 155
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400009C RID: 156
		private ArrayList fQuoteSetsGroup = new ArrayList();
	}
}
