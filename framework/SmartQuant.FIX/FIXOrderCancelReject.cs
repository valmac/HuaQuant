using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200000C RID: 12
	public class FIXOrderCancelReject : FIXMessage
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00006B94 File Offset: 0x00005B94
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00006BA1 File Offset: 0x00005BA1
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00006BAF File Offset: 0x00005BAF
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00006BB9 File Offset: 0x00005BB9
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00006BC4 File Offset: 0x00005BC4
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00006BCE File Offset: 0x00005BCE
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00006BD9 File Offset: 0x00005BD9
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00006BE3 File Offset: 0x00005BE3
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00006BEE File Offset: 0x00005BEE
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00006BF8 File Offset: 0x00005BF8
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

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00006C03 File Offset: 0x00005C03
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00006C0D File Offset: 0x00005C0D
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00006C18 File Offset: 0x00005C18
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00006C25 File Offset: 0x00005C25
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00006C33 File Offset: 0x00005C33
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00006C3D File Offset: 0x00005C3D
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00006C48 File Offset: 0x00005C48
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00006C52 File Offset: 0x00005C52
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00006C5D File Offset: 0x00005C5D
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00006C67 File Offset: 0x00005C67
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

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00006C72 File Offset: 0x00005C72
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00006C7C File Offset: 0x00005C7C
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00006C87 File Offset: 0x00005C87
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00006C94 File Offset: 0x00005C94
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00006CA2 File Offset: 0x00005CA2
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00006CAC File Offset: 0x00005CAC
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00006CB7 File Offset: 0x00005CB7
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00006CC0 File Offset: 0x00005CC0
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00006CCA File Offset: 0x00005CCA
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00006CD4 File Offset: 0x00005CD4
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

		// Token: 0x06000477 RID: 1143 RVA: 0x00006CDF File Offset: 0x00005CDF
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00006CF2 File Offset: 0x00005CF2
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00006D01 File Offset: 0x00005D01
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00006D0E File Offset: 0x00005D0E
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

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00006D1C File Offset: 0x00005D1C
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00006D29 File Offset: 0x00005D29
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

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00006D37 File Offset: 0x00005D37
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00006D41 File Offset: 0x00005D41
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00006D4C File Offset: 0x00005D4C
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00006D56 File Offset: 0x00005D56
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00006D61 File Offset: 0x00005D61
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00006D6B File Offset: 0x00005D6B
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00006D76 File Offset: 0x00005D76
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00006D80 File Offset: 0x00005D80
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00006D8B File Offset: 0x00005D8B
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00006D98 File Offset: 0x00005D98
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00006DA6 File Offset: 0x00005DA6
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00006DB3 File Offset: 0x00005DB3
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00006DC1 File Offset: 0x00005DC1
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00006DCE File Offset: 0x00005DCE
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00006DDC File Offset: 0x00005DDC
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00006DE9 File Offset: 0x00005DE9
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

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00006DF7 File Offset: 0x00005DF7
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00006E04 File Offset: 0x00005E04
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

		// Token: 0x0600048F RID: 1167 RVA: 0x00006E12 File Offset: 0x00005E12
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00006E30 File Offset: 0x00005E30
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00006E4D File Offset: 0x00005E4D
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00006E5A File Offset: 0x00005E5A
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00006E68 File Offset: 0x00005E68
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00006E72 File Offset: 0x00005E72
		[FIXField("37", EFieldOption.Required)]
		public string OrderID
		{
			get
			{
				return this.GetStringValue(37);
			}
			set
			{
				this.SetStringValue(37, value);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00006E7D File Offset: 0x00005E7D
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00006E8A File Offset: 0x00005E8A
		[FIXField("198", EFieldOption.Optional)]
		public string SecondaryOrderID
		{
			get
			{
				return this.GetStringValue(198);
			}
			set
			{
				this.SetStringValue(198, value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00006E98 File Offset: 0x00005E98
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00006EA5 File Offset: 0x00005EA5
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringValue(526);
			}
			set
			{
				this.SetStringValue(526, value);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00006EB3 File Offset: 0x00005EB3
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00006EBD File Offset: 0x00005EBD
		[FIXField("11", EFieldOption.Required)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringValue(11);
			}
			set
			{
				this.SetStringValue(11, value);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00006EC8 File Offset: 0x00005EC8
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00006ED5 File Offset: 0x00005ED5
		[FIXField("583", EFieldOption.Optional)]
		public string ClOrdLinkID
		{
			get
			{
				return this.GetStringValue(583);
			}
			set
			{
				this.SetStringValue(583, value);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00006EE3 File Offset: 0x00005EE3
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00006EED File Offset: 0x00005EED
		[FIXField("41", EFieldOption.Required)]
		public string OrigClOrdID
		{
			get
			{
				return this.GetStringValue(41);
			}
			set
			{
				this.SetStringValue(41, value);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00006EF8 File Offset: 0x00005EF8
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00006F02 File Offset: 0x00005F02
		[FIXField("39", EFieldOption.Required)]
		public char OrdStatus
		{
			get
			{
				return this.GetCharValue(39);
			}
			set
			{
				this.SetCharValue(39, value);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00006F0D File Offset: 0x00005F0D
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00006F1A File Offset: 0x00005F1A
		[FIXField("636", EFieldOption.Optional)]
		public bool WorkingIndicator
		{
			get
			{
				return this.GetBoolValue(636);
			}
			set
			{
				this.SetBoolValue(636, value);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00006F28 File Offset: 0x00005F28
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00006F35 File Offset: 0x00005F35
		[FIXField("586", EFieldOption.Optional)]
		public DateTime OrigOrdModTime
		{
			get
			{
				return this.GetDateTimeValue(586);
			}
			set
			{
				this.SetDateTimeValue(586, value);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00006F43 File Offset: 0x00005F43
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00006F4D File Offset: 0x00005F4D
		[FIXField("66", EFieldOption.Optional)]
		public string ListID
		{
			get
			{
				return this.GetStringValue(66);
			}
			set
			{
				this.SetStringValue(66, value);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00006F58 File Offset: 0x00005F58
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00006F61 File Offset: 0x00005F61
		[FIXField("1", EFieldOption.Optional)]
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00006F6B File Offset: 0x00005F6B
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00006F78 File Offset: 0x00005F78
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00006F86 File Offset: 0x00005F86
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00006F93 File Offset: 0x00005F93
		[FIXField("581", EFieldOption.Optional)]
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

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00006FA1 File Offset: 0x00005FA1
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00006FAE File Offset: 0x00005FAE
		[FIXField("229", EFieldOption.Optional)]
		public DateTime TradeOriginationDate
		{
			get
			{
				return this.GetDateTimeValue(229);
			}
			set
			{
				this.SetDateTimeValue(229, value);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00006FBC File Offset: 0x00005FBC
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00006FC6 File Offset: 0x00005FC6
		[FIXField("75", EFieldOption.Optional)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeValue(75);
			}
			set
			{
				this.SetDateTimeValue(75, value);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00006FD1 File Offset: 0x00005FD1
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00006FDB File Offset: 0x00005FDB
		[FIXField("60", EFieldOption.Optional)]
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00006FE6 File Offset: 0x00005FE6
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00006FF3 File Offset: 0x00005FF3
		[FIXField("434", EFieldOption.Required)]
		public char CxlRejResponseTo
		{
			get
			{
				return this.GetCharValue(434);
			}
			set
			{
				this.SetCharValue(434, value);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00007001 File Offset: 0x00006001
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0000700B File Offset: 0x0000600B
		[FIXField("102", EFieldOption.Optional)]
		public int CxlRejReason
		{
			get
			{
				return this.GetIntValue(102);
			}
			set
			{
				this.SetIntValue(102, value);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00007016 File Offset: 0x00006016
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00007020 File Offset: 0x00006020
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

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000702B File Offset: 0x0000602B
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00007038 File Offset: 0x00006038
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00007046 File Offset: 0x00006046
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00007053 File Offset: 0x00006053
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

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00007061 File Offset: 0x00006061
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0000706B File Offset: 0x0000606B
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00007076 File Offset: 0x00006076
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00007080 File Offset: 0x00006080
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0000708B File Offset: 0x0000608B
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00007095 File Offset: 0x00006095
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

		// Token: 0x060004C3 RID: 1219 RVA: 0x000070A0 File Offset: 0x000060A0
		public FIXOrderCancelReject()
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000070C0 File Offset: 0x000060C0
		public FIXOrderCancelReject(string OrderID, string ClOrdID, string OrigClOrdID, char OrdStatus, char CxlRejResponseTo)
		{
			this.OrderID = OrderID;
			this.ClOrdID = ClOrdID;
			this.OrigClOrdID = OrigClOrdID;
			this.OrdStatus = OrdStatus;
			this.CxlRejResponseTo = CxlRejResponseTo;
		}

		// Token: 0x0400002F RID: 47
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000030 RID: 48
		private ArrayList fHopsGroup = new ArrayList();
	}
}
