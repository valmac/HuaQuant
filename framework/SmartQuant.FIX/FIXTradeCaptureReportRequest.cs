using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000062 RID: 98
	public class FIXTradeCaptureReportRequest : FIXMessage
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00013DF6 File Offset: 0x00012DF6
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x00013E08 File Offset: 0x00012E08
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

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00013E16 File Offset: 0x00012E16
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00013E25 File Offset: 0x00012E25
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

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00013E30 File Offset: 0x00012E30
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x00013E3F File Offset: 0x00012E3F
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

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00013E4A File Offset: 0x00012E4A
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00013E59 File Offset: 0x00012E59
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

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00013E64 File Offset: 0x00012E64
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00013E73 File Offset: 0x00012E73
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

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00013E7E File Offset: 0x00012E7E
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00013E8D File Offset: 0x00012E8D
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

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00013E98 File Offset: 0x00012E98
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x00013EAA File Offset: 0x00012EAA
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

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00013EB8 File Offset: 0x00012EB8
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00013EC7 File Offset: 0x00012EC7
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

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00013ED2 File Offset: 0x00012ED2
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00013EE1 File Offset: 0x00012EE1
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

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00013EEC File Offset: 0x00012EEC
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00013EFB File Offset: 0x00012EFB
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

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00013F06 File Offset: 0x00012F06
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00013F15 File Offset: 0x00012F15
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

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00013F20 File Offset: 0x00012F20
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00013F32 File Offset: 0x00012F32
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

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00013F40 File Offset: 0x00012F40
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x00013F4F File Offset: 0x00012F4F
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

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00013F5A File Offset: 0x00012F5A
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00013F68 File Offset: 0x00012F68
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

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00013F72 File Offset: 0x00012F72
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00013F81 File Offset: 0x00012F81
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

		// Token: 0x060011A4 RID: 4516 RVA: 0x00013F8C File Offset: 0x00012F8C
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00013F9F File Offset: 0x00012F9F
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00013FAE File Offset: 0x00012FAE
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00013FC0 File Offset: 0x00012FC0
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00013FCE File Offset: 0x00012FCE
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00013FE0 File Offset: 0x00012FE0
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

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00013FEE File Offset: 0x00012FEE
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00013FFD File Offset: 0x00012FFD
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00014008 File Offset: 0x00013008
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00014017 File Offset: 0x00013017
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00014022 File Offset: 0x00013022
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00014031 File Offset: 0x00013031
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0001403C File Offset: 0x0001303C
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0001404B File Offset: 0x0001304B
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00014056 File Offset: 0x00013056
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00014068 File Offset: 0x00013068
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

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00014076 File Offset: 0x00013076
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00014088 File Offset: 0x00013088
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00014096 File Offset: 0x00013096
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x000140A8 File Offset: 0x000130A8
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000140B6 File Offset: 0x000130B6
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x000140C8 File Offset: 0x000130C8
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

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000140D6 File Offset: 0x000130D6
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x000140E8 File Offset: 0x000130E8
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

		// Token: 0x060011BC RID: 4540 RVA: 0x000140F6 File Offset: 0x000130F6
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00014114 File Offset: 0x00013114
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00014131 File Offset: 0x00013131
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00014143 File Offset: 0x00013143
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

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00014151 File Offset: 0x00013151
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00014163 File Offset: 0x00013163
		[FIXField("568", EFieldOption.Required)]
		public string TradeRequestID
		{
			get
			{
				return this.GetStringField(568).Value;
			}
			set
			{
				this.AddStringField(568, value);
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00014171 File Offset: 0x00013171
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00014183 File Offset: 0x00013183
		[FIXField("569", EFieldOption.Required)]
		public int TradeRequestType
		{
			get
			{
				return this.GetIntField(569).Value;
			}
			set
			{
				this.AddIntField(569, value);
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00014191 File Offset: 0x00013191
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x000141A3 File Offset: 0x000131A3
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

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000141B1 File Offset: 0x000131B1
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x000141C3 File Offset: 0x000131C3
		[FIXField("571", EFieldOption.Optional)]
		public string TradeReportID
		{
			get
			{
				return this.GetStringField(571).Value;
			}
			set
			{
				this.AddStringField(571, value);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000141D1 File Offset: 0x000131D1
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x000141E3 File Offset: 0x000131E3
		[FIXField("818", EFieldOption.Optional)]
		public string SecondaryTradeReportID
		{
			get
			{
				return this.GetStringField(818).Value;
			}
			set
			{
				this.AddStringField(818, value);
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000141F1 File Offset: 0x000131F1
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x00014200 File Offset: 0x00013200
		[FIXField("17", EFieldOption.Optional)]
		public string ExecID
		{
			get
			{
				return this.GetStringField(17).Value;
			}
			set
			{
				this.AddStringField(17, value);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0001420B File Offset: 0x0001320B
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x0001421D File Offset: 0x0001321D
		[FIXField("150", EFieldOption.Optional)]
		public char ExecType
		{
			get
			{
				return this.GetCharField(150).Value;
			}
			set
			{
				this.AddCharField(150, value);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0001422B File Offset: 0x0001322B
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0001423A File Offset: 0x0001323A
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00014245 File Offset: 0x00013245
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00014254 File Offset: 0x00013254
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

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0001425F File Offset: 0x0001325F
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00014271 File Offset: 0x00013271
		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharField(573).Value;
			}
			set
			{
				this.AddCharField(573, value);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0001427F File Offset: 0x0001327F
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x00014291 File Offset: 0x00013291
		[FIXField("828", EFieldOption.Optional)]
		public int TrdType
		{
			get
			{
				return this.GetIntField(828).Value;
			}
			set
			{
				this.AddIntField(828, value);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0001429F File Offset: 0x0001329F
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x000142B1 File Offset: 0x000132B1
		[FIXField("829", EFieldOption.Optional)]
		public int TrdSubType
		{
			get
			{
				return this.GetIntField(829).Value;
			}
			set
			{
				this.AddIntField(829, value);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x000142BF File Offset: 0x000132BF
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x000142D1 File Offset: 0x000132D1
		[FIXField("830", EFieldOption.Optional)]
		public string TransferReason
		{
			get
			{
				return this.GetStringField(830).Value;
			}
			set
			{
				this.AddStringField(830, value);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x000142DF File Offset: 0x000132DF
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x000142F1 File Offset: 0x000132F1
		[FIXField("855", EFieldOption.Optional)]
		public int SecondaryTrdType
		{
			get
			{
				return this.GetIntField(855).Value;
			}
			set
			{
				this.AddIntField(855, value);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x000142FF File Offset: 0x000132FF
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x00014311 File Offset: 0x00013311
		[FIXField("820", EFieldOption.Optional)]
		public string TradeLinkID
		{
			get
			{
				return this.GetStringField(820).Value;
			}
			set
			{
				this.AddStringField(820, value);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0001431F File Offset: 0x0001331F
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00014331 File Offset: 0x00013331
		[FIXField("880", EFieldOption.Optional)]
		public string TrdMatchID
		{
			get
			{
				return this.GetStringField(880).Value;
			}
			set
			{
				this.AddStringField(880, value);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0001433F File Offset: 0x0001333F
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00014351 File Offset: 0x00013351
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

		// Token: 0x060011E2 RID: 4578 RVA: 0x0001435F File Offset: 0x0001335F
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0001437D File Offset: 0x0001337D
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0001439A File Offset: 0x0001339A
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x000143A9 File Offset: 0x000133A9
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

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x000143B4 File Offset: 0x000133B4
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x000143C3 File Offset: 0x000133C3
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

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x000143CE File Offset: 0x000133CE
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x000143DD File Offset: 0x000133DD
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

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x000143E8 File Offset: 0x000133E8
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x000143F7 File Offset: 0x000133F7
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00014402 File Offset: 0x00013402
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x00014414 File Offset: 0x00013414
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

		// Token: 0x060011EE RID: 4590 RVA: 0x00014422 File Offset: 0x00013422
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00014440 File Offset: 0x00013440
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0001445D File Offset: 0x0001345D
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0001446F File Offset: 0x0001346F
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

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0001447D File Offset: 0x0001347D
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0001448F File Offset: 0x0001348F
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

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0001449D File Offset: 0x0001349D
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x000144AF File Offset: 0x000134AF
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

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x000144BD File Offset: 0x000134BD
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x000144CF File Offset: 0x000134CF
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

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x000144DD File Offset: 0x000134DD
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x000144EF File Offset: 0x000134EF
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x000144FD File Offset: 0x000134FD
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0001450F File Offset: 0x0001350F
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

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0001451D File Offset: 0x0001351D
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0001452F File Offset: 0x0001352F
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

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0001453D File Offset: 0x0001353D
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0001454F File Offset: 0x0001354F
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

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0001455D File Offset: 0x0001355D
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0001456F File Offset: 0x0001356F
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0001457D File Offset: 0x0001357D
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0001458F File Offset: 0x0001358F
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x0001459D File Offset: 0x0001359D
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000145AF File Offset: 0x000135AF
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000145BD File Offset: 0x000135BD
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x000145CF File Offset: 0x000135CF
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000145DD File Offset: 0x000135DD
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x000145EF File Offset: 0x000135EF
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000145FD File Offset: 0x000135FD
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0001460F File Offset: 0x0001360F
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0001461D File Offset: 0x0001361D
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x0001462F File Offset: 0x0001362F
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0001463D File Offset: 0x0001363D
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0001464F File Offset: 0x0001364F
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0001465D File Offset: 0x0001365D
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x0001466F File Offset: 0x0001366F
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

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0001467D File Offset: 0x0001367D
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x0001468F File Offset: 0x0001368F
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

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0001469D File Offset: 0x0001369D
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x000146AF File Offset: 0x000136AF
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

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x000146BD File Offset: 0x000136BD
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x000146CF File Offset: 0x000136CF
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000146DD File Offset: 0x000136DD
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x000146EF File Offset: 0x000136EF
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

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000146FD File Offset: 0x000136FD
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0001470F File Offset: 0x0001370F
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x0001471D File Offset: 0x0001371D
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0001472F File Offset: 0x0001372F
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

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x0001473D File Offset: 0x0001373D
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x0001474F File Offset: 0x0001374F
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x0001475D File Offset: 0x0001375D
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0001476C File Offset: 0x0001376C
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00014777 File Offset: 0x00013777
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00014789 File Offset: 0x00013789
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00014797 File Offset: 0x00013797
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x000147A9 File Offset: 0x000137A9
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000147B7 File Offset: 0x000137B7
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x000147C6 File Offset: 0x000137C6
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x000147D1 File Offset: 0x000137D1
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x000147E3 File Offset: 0x000137E3
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

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000147F1 File Offset: 0x000137F1
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x00014803 File Offset: 0x00013803
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

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00014811 File Offset: 0x00013811
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00014823 File Offset: 0x00013823
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

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00014831 File Offset: 0x00013831
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00014843 File Offset: 0x00013843
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

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00014851 File Offset: 0x00013851
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00014863 File Offset: 0x00013863
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

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00014871 File Offset: 0x00013871
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x00014883 File Offset: 0x00013883
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

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00014891 File Offset: 0x00013891
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x000148A3 File Offset: 0x000138A3
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

		// Token: 0x06001236 RID: 4662 RVA: 0x000148B1 File Offset: 0x000138B1
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000148CF File Offset: 0x000138CF
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000148EC File Offset: 0x000138EC
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x000148FE File Offset: 0x000138FE
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

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0001490C File Offset: 0x0001390C
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x0001491E File Offset: 0x0001391E
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

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x0001492C File Offset: 0x0001392C
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x0001493E File Offset: 0x0001393E
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

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0001494C File Offset: 0x0001394C
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0001495E File Offset: 0x0001395E
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

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0001496C File Offset: 0x0001396C
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x0001497E File Offset: 0x0001397E
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

		// Token: 0x06001242 RID: 4674 RVA: 0x0001498C File Offset: 0x0001398C
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000149AA File Offset: 0x000139AA
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000149C7 File Offset: 0x000139C7
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x000149D9 File Offset: 0x000139D9
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

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000149E7 File Offset: 0x000139E7
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x000149F9 File Offset: 0x000139F9
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

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00014A07 File Offset: 0x00013A07
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x00014A19 File Offset: 0x00013A19
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

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00014A27 File Offset: 0x00013A27
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00014A39 File Offset: 0x00013A39
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00014A47 File Offset: 0x00013A47
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00014A59 File Offset: 0x00013A59
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

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00014A67 File Offset: 0x00013A67
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x00014A79 File Offset: 0x00013A79
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

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00014A87 File Offset: 0x00013A87
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00014A99 File Offset: 0x00013A99
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00014AA7 File Offset: 0x00013AA7
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00014AB9 File Offset: 0x00013AB9
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

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00014AC7 File Offset: 0x00013AC7
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x00014AD9 File Offset: 0x00013AD9
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

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00014AE7 File Offset: 0x00013AE7
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x00014AF9 File Offset: 0x00013AF9
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

		// Token: 0x06001258 RID: 4696 RVA: 0x00014B07 File Offset: 0x00013B07
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00014B25 File Offset: 0x00013B25
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00014B42 File Offset: 0x00013B42
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x00014B54 File Offset: 0x00013B54
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

		// Token: 0x0600125C RID: 4700 RVA: 0x00014B62 File Offset: 0x00013B62
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00014B80 File Offset: 0x00013B80
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00014B9D File Offset: 0x00013B9D
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x00014BAF File Offset: 0x00013BAF
		[FIXField("580", EFieldOption.Optional)]
		public int NoDates
		{
			get
			{
				return this.GetIntField(580).Value;
			}
			set
			{
				this.AddIntField(580, value);
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00014BBD File Offset: 0x00013BBD
		public FIXDatesGroup GetDatesGroup(int i)
		{
			if (i < this.NoDates)
			{
				return (FIXDatesGroup)this.fDatesGroup[i];
			}
			return null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00014BDB File Offset: 0x00013BDB
		public void AddGroup(FIXDatesGroup group)
		{
			this.fDatesGroup.Add(group);
			this.NoDates++;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00014BF8 File Offset: 0x00013BF8
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x00014C0A File Offset: 0x00013C0A
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

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00014C18 File Offset: 0x00013C18
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x00014C2A File Offset: 0x00013C2A
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00014C38 File Offset: 0x00013C38
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x00014C4A File Offset: 0x00013C4A
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

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00014C58 File Offset: 0x00013C58
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x00014C6A File Offset: 0x00013C6A
		[FIXField("943", EFieldOption.Optional)]
		public string TimeBracket
		{
			get
			{
				return this.GetStringField(943).Value;
			}
			set
			{
				this.AddStringField(943, value);
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00014C78 File Offset: 0x00013C78
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x00014C87 File Offset: 0x00013C87
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

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00014C92 File Offset: 0x00013C92
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x00014CA4 File Offset: 0x00013CA4
		[FIXField("442", EFieldOption.Optional)]
		public char MultiLegReportingType
		{
			get
			{
				return this.GetCharField(442).Value;
			}
			set
			{
				this.AddCharField(442, value);
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00014CB2 File Offset: 0x00013CB2
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00014CC4 File Offset: 0x00013CC4
		[FIXField("578", EFieldOption.Optional)]
		public string TradeInputSource
		{
			get
			{
				return this.GetStringField(578).Value;
			}
			set
			{
				this.AddStringField(578, value);
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x00014CD2 File Offset: 0x00013CD2
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00014CE4 File Offset: 0x00013CE4
		[FIXField("579", EFieldOption.Optional)]
		public string TradeInputDevice
		{
			get
			{
				return this.GetStringField(579).Value;
			}
			set
			{
				this.AddStringField(579, value);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00014CF2 File Offset: 0x00013CF2
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00014D04 File Offset: 0x00013D04
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

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00014D12 File Offset: 0x00013D12
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x00014D24 File Offset: 0x00013D24
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00014D32 File Offset: 0x00013D32
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00014D41 File Offset: 0x00013D41
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

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00014D4C File Offset: 0x00013D4C
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x00014D5E File Offset: 0x00013D5E
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

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00014D6C File Offset: 0x00013D6C
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x00014D7E File Offset: 0x00013D7E
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

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00014D8C File Offset: 0x00013D8C
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x00014D9B File Offset: 0x00013D9B
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00014DA6 File Offset: 0x00013DA6
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00014DB5 File Offset: 0x00013DB5
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x00014DC0 File Offset: 0x00013DC0
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00014DCF File Offset: 0x00013DCF
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

		// Token: 0x06001282 RID: 4738 RVA: 0x00014DDC File Offset: 0x00013DDC
		public FIXTradeCaptureReportRequest()
		{
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00014E54 File Offset: 0x00013E54
		public FIXTradeCaptureReportRequest(string TradeRequestID, int TradeRequestType)
		{
			this.TradeRequestID = TradeRequestID;
			this.TradeRequestType = TradeRequestType;
		}

		// Token: 0x0400024A RID: 586
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400024B RID: 587
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400024C RID: 588
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400024D RID: 589
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400024E RID: 590
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400024F RID: 591
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x04000250 RID: 592
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000251 RID: 593
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000252 RID: 594
		private ArrayList fDatesGroup = new ArrayList();
	}
}
