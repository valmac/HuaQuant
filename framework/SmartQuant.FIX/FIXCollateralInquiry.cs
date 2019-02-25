using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000009 RID: 9
	public class FIXCollateralInquiry : FIXMessage
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000417A File Offset: 0x0000317A
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000418C File Offset: 0x0000318C
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000419A File Offset: 0x0000319A
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000041A9 File Offset: 0x000031A9
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000041B4 File Offset: 0x000031B4
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000041C3 File Offset: 0x000031C3
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000041CE File Offset: 0x000031CE
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000041DD File Offset: 0x000031DD
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000041E8 File Offset: 0x000031E8
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x000041F7 File Offset: 0x000031F7
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00004202 File Offset: 0x00003202
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00004211 File Offset: 0x00003211
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000421C File Offset: 0x0000321C
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000422E File Offset: 0x0000322E
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000423C File Offset: 0x0000323C
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000424B File Offset: 0x0000324B
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00004256 File Offset: 0x00003256
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00004265 File Offset: 0x00003265
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00004270 File Offset: 0x00003270
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000427F File Offset: 0x0000327F
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000428A File Offset: 0x0000328A
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00004299 File Offset: 0x00003299
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000042A4 File Offset: 0x000032A4
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000042B6 File Offset: 0x000032B6
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000042C4 File Offset: 0x000032C4
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000042D3 File Offset: 0x000032D3
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000042DE File Offset: 0x000032DE
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000042EC File Offset: 0x000032EC
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000042F6 File Offset: 0x000032F6
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00004305 File Offset: 0x00003305
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

		// Token: 0x060001FB RID: 507 RVA: 0x00004310 File Offset: 0x00003310
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00004323 File Offset: 0x00003323
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00004332 File Offset: 0x00003332
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00004344 File Offset: 0x00003344
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00004352 File Offset: 0x00003352
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00004364 File Offset: 0x00003364
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00004372 File Offset: 0x00003372
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00004381 File Offset: 0x00003381
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000438C File Offset: 0x0000338C
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000439B File Offset: 0x0000339B
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000043A6 File Offset: 0x000033A6
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000043B5 File Offset: 0x000033B5
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000043C0 File Offset: 0x000033C0
		// (set) Token: 0x06000208 RID: 520 RVA: 0x000043CF File Offset: 0x000033CF
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000043DA File Offset: 0x000033DA
		// (set) Token: 0x0600020A RID: 522 RVA: 0x000043EC File Offset: 0x000033EC
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000043FA File Offset: 0x000033FA
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000440C File Offset: 0x0000340C
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000441A File Offset: 0x0000341A
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000442C File Offset: 0x0000342C
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000443A File Offset: 0x0000343A
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000444C File Offset: 0x0000344C
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000445A File Offset: 0x0000345A
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000446C File Offset: 0x0000346C
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

		// Token: 0x06000213 RID: 531 RVA: 0x0000447A File Offset: 0x0000347A
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004498 File Offset: 0x00003498
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000044B5 File Offset: 0x000034B5
		// (set) Token: 0x06000216 RID: 534 RVA: 0x000044C7 File Offset: 0x000034C7
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000044D5 File Offset: 0x000034D5
		// (set) Token: 0x06000218 RID: 536 RVA: 0x000044E7 File Offset: 0x000034E7
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000044F5 File Offset: 0x000034F5
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00004507 File Offset: 0x00003507
		[FIXField("938", EFieldOption.Optional)]
		public int NoCollInquiryQualifier
		{
			get
			{
				return this.GetIntField(938).Value;
			}
			set
			{
				this.AddIntField(938, value);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00004515 File Offset: 0x00003515
		public FIXCollInquiryQualifierGroup GetCollInquiryQualifierGroup(int i)
		{
			if (i < this.NoCollInquiryQualifier)
			{
				return (FIXCollInquiryQualifierGroup)this.fCollInquiryQualifierGroup[i];
			}
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00004533 File Offset: 0x00003533
		public void AddGroup(FIXCollInquiryQualifierGroup group)
		{
			this.fCollInquiryQualifierGroup.Add(group);
			this.NoCollInquiryQualifier++;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00004550 File Offset: 0x00003550
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00004562 File Offset: 0x00003562
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00004570 File Offset: 0x00003570
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00004582 File Offset: 0x00003582
		[FIXField("725", EFieldOption.Optional)]
		public int ResponseTransportType
		{
			get
			{
				return this.GetIntField(725).Value;
			}
			set
			{
				this.AddIntField(725, value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00004590 File Offset: 0x00003590
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000045A2 File Offset: 0x000035A2
		[FIXField("726", EFieldOption.Optional)]
		public string ResponseDestination
		{
			get
			{
				return this.GetStringField(726).Value;
			}
			set
			{
				this.AddStringField(726, value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000045B0 File Offset: 0x000035B0
		// (set) Token: 0x06000224 RID: 548 RVA: 0x000045C2 File Offset: 0x000035C2
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

		// Token: 0x06000225 RID: 549 RVA: 0x000045D0 File Offset: 0x000035D0
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000045EE File Offset: 0x000035EE
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000460B File Offset: 0x0000360B
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00004619 File Offset: 0x00003619
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00004623 File Offset: 0x00003623
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00004635 File Offset: 0x00003635
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00004643 File Offset: 0x00003643
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00004652 File Offset: 0x00003652
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000465D File Offset: 0x0000365D
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000466C File Offset: 0x0000366C
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00004677 File Offset: 0x00003677
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00004689 File Offset: 0x00003689
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00004697 File Offset: 0x00003697
		// (set) Token: 0x06000232 RID: 562 RVA: 0x000046A9 File Offset: 0x000036A9
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000046B7 File Offset: 0x000036B7
		// (set) Token: 0x06000234 RID: 564 RVA: 0x000046C6 File Offset: 0x000036C6
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

		// Token: 0x06000235 RID: 565 RVA: 0x000046D1 File Offset: 0x000036D1
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000046EF File Offset: 0x000036EF
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000470C File Offset: 0x0000370C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000471E File Offset: 0x0000371E
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

		// Token: 0x06000239 RID: 569 RVA: 0x0000472C File Offset: 0x0000372C
		public FIXTradesGroup GetTradesGroup(int i)
		{
			if (i < this.NoTrades)
			{
				return (FIXTradesGroup)this.fTradesGroup[i];
			}
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000474A File Offset: 0x0000374A
		public void AddGroup(FIXTradesGroup group)
		{
			this.fTradesGroup.Add(group);
			this.NoTrades++;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00004767 File Offset: 0x00003767
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00004776 File Offset: 0x00003776
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00004781 File Offset: 0x00003781
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00004790 File Offset: 0x00003790
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000479B File Offset: 0x0000379B
		// (set) Token: 0x06000240 RID: 576 RVA: 0x000047AA File Offset: 0x000037AA
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000047B5 File Offset: 0x000037B5
		// (set) Token: 0x06000242 RID: 578 RVA: 0x000047C4 File Offset: 0x000037C4
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000047CF File Offset: 0x000037CF
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000047E1 File Offset: 0x000037E1
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

		// Token: 0x06000245 RID: 581 RVA: 0x000047EF File Offset: 0x000037EF
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000480D File Offset: 0x0000380D
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000482A File Offset: 0x0000382A
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000483C File Offset: 0x0000383C
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000484A File Offset: 0x0000384A
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000485C File Offset: 0x0000385C
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000486A File Offset: 0x0000386A
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000487C File Offset: 0x0000387C
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000488A File Offset: 0x0000388A
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000489C File Offset: 0x0000389C
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000048AA File Offset: 0x000038AA
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000048BC File Offset: 0x000038BC
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000048CA File Offset: 0x000038CA
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000048DC File Offset: 0x000038DC
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000048EA File Offset: 0x000038EA
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000048FC File Offset: 0x000038FC
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000490A File Offset: 0x0000390A
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000491C File Offset: 0x0000391C
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000492A File Offset: 0x0000392A
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000493C File Offset: 0x0000393C
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000494A File Offset: 0x0000394A
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000495C File Offset: 0x0000395C
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000496A File Offset: 0x0000396A
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000497C File Offset: 0x0000397C
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000498A File Offset: 0x0000398A
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0000499C File Offset: 0x0000399C
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000049AA File Offset: 0x000039AA
		// (set) Token: 0x06000260 RID: 608 RVA: 0x000049BC File Offset: 0x000039BC
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000049CA File Offset: 0x000039CA
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000049DC File Offset: 0x000039DC
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000049EA File Offset: 0x000039EA
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000049FC File Offset: 0x000039FC
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00004A0A File Offset: 0x00003A0A
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00004A1C File Offset: 0x00003A1C
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00004A2A File Offset: 0x00003A2A
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00004A3C File Offset: 0x00003A3C
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00004A4A File Offset: 0x00003A4A
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00004A5C File Offset: 0x00003A5C
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00004A6A File Offset: 0x00003A6A
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00004A7C File Offset: 0x00003A7C
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00004A8A File Offset: 0x00003A8A
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00004A9C File Offset: 0x00003A9C
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00004AAA File Offset: 0x00003AAA
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00004ABC File Offset: 0x00003ABC
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00004ACA File Offset: 0x00003ACA
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00004ADC File Offset: 0x00003ADC
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00004AEA File Offset: 0x00003AEA
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00004AFC File Offset: 0x00003AFC
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00004B0A File Offset: 0x00003B0A
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00004B1C File Offset: 0x00003B1C
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00004B2A File Offset: 0x00003B2A
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00004B39 File Offset: 0x00003B39
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00004B44 File Offset: 0x00003B44
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00004B56 File Offset: 0x00003B56
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00004B64 File Offset: 0x00003B64
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00004B76 File Offset: 0x00003B76
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00004B84 File Offset: 0x00003B84
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00004B93 File Offset: 0x00003B93
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00004B9E File Offset: 0x00003B9E
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00004BB0 File Offset: 0x00003BB0
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00004BBE File Offset: 0x00003BBE
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00004BD0 File Offset: 0x00003BD0
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00004BDE File Offset: 0x00003BDE
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00004BF0 File Offset: 0x00003BF0
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00004BFE File Offset: 0x00003BFE
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00004C10 File Offset: 0x00003C10
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00004C1E File Offset: 0x00003C1E
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00004C30 File Offset: 0x00003C30
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00004C3E File Offset: 0x00003C3E
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00004C50 File Offset: 0x00003C50
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

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00004C5E File Offset: 0x00003C5E
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00004C70 File Offset: 0x00003C70
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

		// Token: 0x0600028D RID: 653 RVA: 0x00004C7E File Offset: 0x00003C7E
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00004C9C File Offset: 0x00003C9C
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00004CB9 File Offset: 0x00003CB9
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00004CCB File Offset: 0x00003CCB
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00004CD9 File Offset: 0x00003CD9
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00004CEB File Offset: 0x00003CEB
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00004CF9 File Offset: 0x00003CF9
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00004D0B File Offset: 0x00003D0B
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00004D19 File Offset: 0x00003D19
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00004D2B File Offset: 0x00003D2B
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00004D39 File Offset: 0x00003D39
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00004D4B File Offset: 0x00003D4B
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00004D59 File Offset: 0x00003D59
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00004D6B File Offset: 0x00003D6B
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00004D79 File Offset: 0x00003D79
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00004D8B File Offset: 0x00003D8B
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00004D99 File Offset: 0x00003D99
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00004DAB File Offset: 0x00003DAB
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00004DB9 File Offset: 0x00003DB9
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00004DCB File Offset: 0x00003DCB
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00004DD9 File Offset: 0x00003DD9
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00004DEB File Offset: 0x00003DEB
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00004DF9 File Offset: 0x00003DF9
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00004E0B File Offset: 0x00003E0B
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00004E19 File Offset: 0x00003E19
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00004E28 File Offset: 0x00003E28
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00004E33 File Offset: 0x00003E33
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00004E42 File Offset: 0x00003E42
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00004E4D File Offset: 0x00003E4D
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00004E5F File Offset: 0x00003E5F
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00004E6D File Offset: 0x00003E6D
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00004E7C File Offset: 0x00003E7C
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00004E87 File Offset: 0x00003E87
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00004E99 File Offset: 0x00003E99
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

		// Token: 0x060002AF RID: 687 RVA: 0x00004EA7 File Offset: 0x00003EA7
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00004EC5 File Offset: 0x00003EC5
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00004EE2 File Offset: 0x00003EE2
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00004EF4 File Offset: 0x00003EF4
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

		// Token: 0x060002B3 RID: 691 RVA: 0x00004F02 File Offset: 0x00003F02
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00004F20 File Offset: 0x00003F20
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00004F3D File Offset: 0x00003F3D
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00004F4F File Offset: 0x00003F4F
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00004F5D File Offset: 0x00003F5D
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00004F6F File Offset: 0x00003F6F
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00004F7D File Offset: 0x00003F7D
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00004F8F File Offset: 0x00003F8F
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00004F9D File Offset: 0x00003F9D
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00004FAF File Offset: 0x00003FAF
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

		// Token: 0x060002BD RID: 701 RVA: 0x00004FBD File Offset: 0x00003FBD
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00004FDB File Offset: 0x00003FDB
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00004FF8 File Offset: 0x00003FF8
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00005007 File Offset: 0x00004007
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00005012 File Offset: 0x00004012
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00005021 File Offset: 0x00004021
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000502C File Offset: 0x0000402C
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000503E File Offset: 0x0000403E
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000504C File Offset: 0x0000404C
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0000505E File Offset: 0x0000405E
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000506C File Offset: 0x0000406C
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0000507E File Offset: 0x0000407E
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000508C File Offset: 0x0000408C
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000509E File Offset: 0x0000409E
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000050AC File Offset: 0x000040AC
		// (set) Token: 0x060002CC RID: 716 RVA: 0x000050BE File Offset: 0x000040BE
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000050CC File Offset: 0x000040CC
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000050DE File Offset: 0x000040DE
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000050EC File Offset: 0x000040EC
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000050FE File Offset: 0x000040FE
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000510C File Offset: 0x0000410C
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000511E File Offset: 0x0000411E
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000512C File Offset: 0x0000412C
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000513E File Offset: 0x0000413E
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000514C File Offset: 0x0000414C
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000515E File Offset: 0x0000415E
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000516C File Offset: 0x0000416C
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000517E File Offset: 0x0000417E
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000518C File Offset: 0x0000418C
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000519E File Offset: 0x0000419E
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000051AC File Offset: 0x000041AC
		// (set) Token: 0x060002DC RID: 732 RVA: 0x000051BE File Offset: 0x000041BE
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000051CC File Offset: 0x000041CC
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000051DE File Offset: 0x000041DE
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

		// Token: 0x060002DF RID: 735 RVA: 0x000051EC File Offset: 0x000041EC
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000520A File Offset: 0x0000420A
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00005227 File Offset: 0x00004227
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00005239 File Offset: 0x00004239
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00005247 File Offset: 0x00004247
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00005259 File Offset: 0x00004259
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00005267 File Offset: 0x00004267
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00005279 File Offset: 0x00004279
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00005287 File Offset: 0x00004287
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00005299 File Offset: 0x00004299
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000052A7 File Offset: 0x000042A7
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000052B6 File Offset: 0x000042B6
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

		// Token: 0x060002EB RID: 747 RVA: 0x000052C1 File Offset: 0x000042C1
		public FIXDlvyInstGroup GetDlvyInstGroup(int i)
		{
			if (i < this.NoDlvyInst)
			{
				return (FIXDlvyInstGroup)this.fDlvyInstGroup[i];
			}
			return null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000052DF File Offset: 0x000042DF
		public void AddGroup(FIXDlvyInstGroup group)
		{
			this.fDlvyInstGroup.Add(group);
			this.NoDlvyInst++;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000052FC File Offset: 0x000042FC
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000530E File Offset: 0x0000430E
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000531C File Offset: 0x0000431C
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000532E File Offset: 0x0000432E
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000533C File Offset: 0x0000433C
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000534E File Offset: 0x0000434E
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000535C File Offset: 0x0000435C
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000536E File Offset: 0x0000436E
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000537C File Offset: 0x0000437C
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000538E File Offset: 0x0000438E
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000539C File Offset: 0x0000439C
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x000053AB File Offset: 0x000043AB
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x000053B6 File Offset: 0x000043B6
		// (set) Token: 0x060002FA RID: 762 RVA: 0x000053C8 File Offset: 0x000043C8
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002FB RID: 763 RVA: 0x000053D6 File Offset: 0x000043D6
		// (set) Token: 0x060002FC RID: 764 RVA: 0x000053E8 File Offset: 0x000043E8
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002FD RID: 765 RVA: 0x000053F6 File Offset: 0x000043F6
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00005405 File Offset: 0x00004405
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00005410 File Offset: 0x00004410
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0000541F File Offset: 0x0000441F
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000542A File Offset: 0x0000442A
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00005439 File Offset: 0x00004439
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

		// Token: 0x04000015 RID: 21
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000016 RID: 22
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000017 RID: 23
		private ArrayList fCollInquiryQualifierGroup = new ArrayList();

		// Token: 0x04000018 RID: 24
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000019 RID: 25
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x0400001A RID: 26
		private ArrayList fTradesGroup = new ArrayList();

		// Token: 0x0400001B RID: 27
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400001C RID: 28
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400001D RID: 29
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x0400001E RID: 30
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400001F RID: 31
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x04000020 RID: 32
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000021 RID: 33
		private ArrayList fDlvyInstGroup = new ArrayList();
	}
}
