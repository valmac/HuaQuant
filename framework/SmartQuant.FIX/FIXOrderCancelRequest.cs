using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000184 RID: 388
	public class FIXOrderCancelRequest : FIXMessage
	{
		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x000502E2 File Offset: 0x0004F2E2
		// (set) Token: 0x06004857 RID: 18519 RVA: 0x000502F4 File Offset: 0x0004F2F4
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

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x00050302 File Offset: 0x0004F302
		// (set) Token: 0x06004859 RID: 18521 RVA: 0x00050311 File Offset: 0x0004F311
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

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x0005031C File Offset: 0x0004F31C
		// (set) Token: 0x0600485B RID: 18523 RVA: 0x0005032B File Offset: 0x0004F32B
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

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x00050336 File Offset: 0x0004F336
		// (set) Token: 0x0600485D RID: 18525 RVA: 0x00050345 File Offset: 0x0004F345
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

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x00050350 File Offset: 0x0004F350
		// (set) Token: 0x0600485F RID: 18527 RVA: 0x0005035F File Offset: 0x0004F35F
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

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x0005036A File Offset: 0x0004F36A
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x00050379 File Offset: 0x0004F379
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

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x00050384 File Offset: 0x0004F384
		// (set) Token: 0x06004863 RID: 18531 RVA: 0x00050396 File Offset: 0x0004F396
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

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x000503A4 File Offset: 0x0004F3A4
		// (set) Token: 0x06004865 RID: 18533 RVA: 0x000503B3 File Offset: 0x0004F3B3
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

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x000503BE File Offset: 0x0004F3BE
		// (set) Token: 0x06004867 RID: 18535 RVA: 0x000503CD File Offset: 0x0004F3CD
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

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x000503D8 File Offset: 0x0004F3D8
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x000503E7 File Offset: 0x0004F3E7
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

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x000503F2 File Offset: 0x0004F3F2
		// (set) Token: 0x0600486B RID: 18539 RVA: 0x00050401 File Offset: 0x0004F401
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

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x0005040C File Offset: 0x0004F40C
		// (set) Token: 0x0600486D RID: 18541 RVA: 0x0005041E File Offset: 0x0004F41E
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

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x0005042C File Offset: 0x0004F42C
		// (set) Token: 0x0600486F RID: 18543 RVA: 0x0005043B File Offset: 0x0004F43B
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

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x00050446 File Offset: 0x0004F446
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x00050454 File Offset: 0x0004F454
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

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x0005045E File Offset: 0x0004F45E
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x0005046D File Offset: 0x0004F46D
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

		// Token: 0x06004874 RID: 18548 RVA: 0x00050478 File Offset: 0x0004F478
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x0005048B File Offset: 0x0004F48B
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x0005049A File Offset: 0x0004F49A
		// (set) Token: 0x06004877 RID: 18551 RVA: 0x000504AC File Offset: 0x0004F4AC
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

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x000504BA File Offset: 0x0004F4BA
		// (set) Token: 0x06004879 RID: 18553 RVA: 0x000504CC File Offset: 0x0004F4CC
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

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x000504DA File Offset: 0x0004F4DA
		// (set) Token: 0x0600487B RID: 18555 RVA: 0x000504E9 File Offset: 0x0004F4E9
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

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600487C RID: 18556 RVA: 0x000504F4 File Offset: 0x0004F4F4
		// (set) Token: 0x0600487D RID: 18557 RVA: 0x00050503 File Offset: 0x0004F503
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

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x0005050E File Offset: 0x0004F50E
		// (set) Token: 0x0600487F RID: 18559 RVA: 0x0005051D File Offset: 0x0004F51D
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

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x00050528 File Offset: 0x0004F528
		// (set) Token: 0x06004881 RID: 18561 RVA: 0x00050537 File Offset: 0x0004F537
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

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x00050542 File Offset: 0x0004F542
		// (set) Token: 0x06004883 RID: 18563 RVA: 0x00050554 File Offset: 0x0004F554
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

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x00050562 File Offset: 0x0004F562
		// (set) Token: 0x06004885 RID: 18565 RVA: 0x00050574 File Offset: 0x0004F574
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

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x00050582 File Offset: 0x0004F582
		// (set) Token: 0x06004887 RID: 18567 RVA: 0x00050594 File Offset: 0x0004F594
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

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x000505A2 File Offset: 0x0004F5A2
		// (set) Token: 0x06004889 RID: 18569 RVA: 0x000505B4 File Offset: 0x0004F5B4
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

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x000505C2 File Offset: 0x0004F5C2
		// (set) Token: 0x0600488B RID: 18571 RVA: 0x000505D4 File Offset: 0x0004F5D4
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

		// Token: 0x0600488C RID: 18572 RVA: 0x000505E2 File Offset: 0x0004F5E2
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00050600 File Offset: 0x0004F600
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x0005061D File Offset: 0x0004F61D
		// (set) Token: 0x0600488F RID: 18575 RVA: 0x0005062F File Offset: 0x0004F62F
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

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x0005063D File Offset: 0x0004F63D
		// (set) Token: 0x06004891 RID: 18577 RVA: 0x0005064C File Offset: 0x0004F64C
		[FIXField("41", EFieldOption.Required)]
		public string OrigClOrdID
		{
			get
			{
				return this.GetStringField(41).Value;
			}
			set
			{
				this.AddStringField(41, value);
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x00050657 File Offset: 0x0004F657
		// (set) Token: 0x06004893 RID: 18579 RVA: 0x00050666 File Offset: 0x0004F666
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

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x00050671 File Offset: 0x0004F671
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x00050680 File Offset: 0x0004F680
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

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x0005068B File Offset: 0x0004F68B
		// (set) Token: 0x06004897 RID: 18583 RVA: 0x0005069D File Offset: 0x0004F69D
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

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x000506AB File Offset: 0x0004F6AB
		// (set) Token: 0x06004899 RID: 18585 RVA: 0x000506BD File Offset: 0x0004F6BD
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

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x000506CB File Offset: 0x0004F6CB
		// (set) Token: 0x0600489B RID: 18587 RVA: 0x000506DA File Offset: 0x0004F6DA
		[FIXField("66", EFieldOption.Optional)]
		public string ListID
		{
			get
			{
				return this.GetStringField(66).Value;
			}
			set
			{
				this.AddStringField(66, value);
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x000506E5 File Offset: 0x0004F6E5
		// (set) Token: 0x0600489D RID: 18589 RVA: 0x000506F7 File Offset: 0x0004F6F7
		[FIXField("586", EFieldOption.Optional)]
		public DateTime OrigOrdModTime
		{
			get
			{
				return this.GetDateTimeField(586).Value;
			}
			set
			{
				this.AddDateTimeField(586, value);
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x00050705 File Offset: 0x0004F705
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x00050713 File Offset: 0x0004F713
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

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x0005071D File Offset: 0x0004F71D
		// (set) Token: 0x060048A1 RID: 18593 RVA: 0x0005072F File Offset: 0x0004F72F
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

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x0005073D File Offset: 0x0004F73D
		// (set) Token: 0x060048A3 RID: 18595 RVA: 0x0005074F File Offset: 0x0004F74F
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

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x0005075D File Offset: 0x0004F75D
		// (set) Token: 0x060048A5 RID: 18597 RVA: 0x0005076F File Offset: 0x0004F76F
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

		// Token: 0x060048A6 RID: 18598 RVA: 0x0005077D File Offset: 0x0004F77D
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x0005079B File Offset: 0x0004F79B
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x000507B8 File Offset: 0x0004F7B8
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x000507C7 File Offset: 0x0004F7C7
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

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x000507D2 File Offset: 0x0004F7D2
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x000507E1 File Offset: 0x0004F7E1
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

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x000507EC File Offset: 0x0004F7EC
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x000507FB File Offset: 0x0004F7FB
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

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x00050806 File Offset: 0x0004F806
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x00050815 File Offset: 0x0004F815
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

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x060048B0 RID: 18608 RVA: 0x00050820 File Offset: 0x0004F820
		// (set) Token: 0x060048B1 RID: 18609 RVA: 0x00050832 File Offset: 0x0004F832
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

		// Token: 0x060048B2 RID: 18610 RVA: 0x00050840 File Offset: 0x0004F840
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x0005085E File Offset: 0x0004F85E
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x0005087B File Offset: 0x0004F87B
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x0005088D File Offset: 0x0004F88D
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

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x0005089B File Offset: 0x0004F89B
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x000508AD File Offset: 0x0004F8AD
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

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x000508BB File Offset: 0x0004F8BB
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x000508CD File Offset: 0x0004F8CD
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

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x000508DB File Offset: 0x0004F8DB
		// (set) Token: 0x060048BB RID: 18619 RVA: 0x000508ED File Offset: 0x0004F8ED
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

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x000508FB File Offset: 0x0004F8FB
		// (set) Token: 0x060048BD RID: 18621 RVA: 0x0005090D File Offset: 0x0004F90D
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

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x060048BE RID: 18622 RVA: 0x0005091B File Offset: 0x0004F91B
		// (set) Token: 0x060048BF RID: 18623 RVA: 0x0005092D File Offset: 0x0004F92D
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

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x0005093B File Offset: 0x0004F93B
		// (set) Token: 0x060048C1 RID: 18625 RVA: 0x0005094D File Offset: 0x0004F94D
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

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x060048C2 RID: 18626 RVA: 0x0005095B File Offset: 0x0004F95B
		// (set) Token: 0x060048C3 RID: 18627 RVA: 0x0005096D File Offset: 0x0004F96D
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

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x0005097B File Offset: 0x0004F97B
		// (set) Token: 0x060048C5 RID: 18629 RVA: 0x0005098D File Offset: 0x0004F98D
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

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x0005099B File Offset: 0x0004F99B
		// (set) Token: 0x060048C7 RID: 18631 RVA: 0x000509AD File Offset: 0x0004F9AD
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

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x060048C8 RID: 18632 RVA: 0x000509BB File Offset: 0x0004F9BB
		// (set) Token: 0x060048C9 RID: 18633 RVA: 0x000509CD File Offset: 0x0004F9CD
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

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x060048CA RID: 18634 RVA: 0x000509DB File Offset: 0x0004F9DB
		// (set) Token: 0x060048CB RID: 18635 RVA: 0x000509ED File Offset: 0x0004F9ED
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

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x000509FB File Offset: 0x0004F9FB
		// (set) Token: 0x060048CD RID: 18637 RVA: 0x00050A0D File Offset: 0x0004FA0D
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

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x00050A1B File Offset: 0x0004FA1B
		// (set) Token: 0x060048CF RID: 18639 RVA: 0x00050A2D File Offset: 0x0004FA2D
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

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x00050A3B File Offset: 0x0004FA3B
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x00050A4D File Offset: 0x0004FA4D
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

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x00050A5B File Offset: 0x0004FA5B
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x00050A6D File Offset: 0x0004FA6D
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

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x00050A7B File Offset: 0x0004FA7B
		// (set) Token: 0x060048D5 RID: 18645 RVA: 0x00050A8D File Offset: 0x0004FA8D
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

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x00050A9B File Offset: 0x0004FA9B
		// (set) Token: 0x060048D7 RID: 18647 RVA: 0x00050AAD File Offset: 0x0004FAAD
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

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x00050ABB File Offset: 0x0004FABB
		// (set) Token: 0x060048D9 RID: 18649 RVA: 0x00050ACD File Offset: 0x0004FACD
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

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x00050ADB File Offset: 0x0004FADB
		// (set) Token: 0x060048DB RID: 18651 RVA: 0x00050AED File Offset: 0x0004FAED
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

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x00050AFB File Offset: 0x0004FAFB
		// (set) Token: 0x060048DD RID: 18653 RVA: 0x00050B0D File Offset: 0x0004FB0D
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

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x00050B1B File Offset: 0x0004FB1B
		// (set) Token: 0x060048DF RID: 18655 RVA: 0x00050B2D File Offset: 0x0004FB2D
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

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x00050B3B File Offset: 0x0004FB3B
		// (set) Token: 0x060048E1 RID: 18657 RVA: 0x00050B4D File Offset: 0x0004FB4D
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

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x00050B5B File Offset: 0x0004FB5B
		// (set) Token: 0x060048E3 RID: 18659 RVA: 0x00050B6D File Offset: 0x0004FB6D
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

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x00050B7B File Offset: 0x0004FB7B
		// (set) Token: 0x060048E5 RID: 18661 RVA: 0x00050B8A File Offset: 0x0004FB8A
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

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x060048E6 RID: 18662 RVA: 0x00050B95 File Offset: 0x0004FB95
		// (set) Token: 0x060048E7 RID: 18663 RVA: 0x00050BA7 File Offset: 0x0004FBA7
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

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x00050BB5 File Offset: 0x0004FBB5
		// (set) Token: 0x060048E9 RID: 18665 RVA: 0x00050BC7 File Offset: 0x0004FBC7
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

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x00050BD5 File Offset: 0x0004FBD5
		// (set) Token: 0x060048EB RID: 18667 RVA: 0x00050BE4 File Offset: 0x0004FBE4
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

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x00050BEF File Offset: 0x0004FBEF
		// (set) Token: 0x060048ED RID: 18669 RVA: 0x00050C01 File Offset: 0x0004FC01
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

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x00050C0F File Offset: 0x0004FC0F
		// (set) Token: 0x060048EF RID: 18671 RVA: 0x00050C21 File Offset: 0x0004FC21
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

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x00050C2F File Offset: 0x0004FC2F
		// (set) Token: 0x060048F1 RID: 18673 RVA: 0x00050C41 File Offset: 0x0004FC41
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

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x00050C4F File Offset: 0x0004FC4F
		// (set) Token: 0x060048F3 RID: 18675 RVA: 0x00050C61 File Offset: 0x0004FC61
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

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x00050C6F File Offset: 0x0004FC6F
		// (set) Token: 0x060048F5 RID: 18677 RVA: 0x00050C81 File Offset: 0x0004FC81
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

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x00050C8F File Offset: 0x0004FC8F
		// (set) Token: 0x060048F7 RID: 18679 RVA: 0x00050CA1 File Offset: 0x0004FCA1
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

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x00050CAF File Offset: 0x0004FCAF
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x00050CC1 File Offset: 0x0004FCC1
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

		// Token: 0x060048FA RID: 18682 RVA: 0x00050CCF File Offset: 0x0004FCCF
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x00050CED File Offset: 0x0004FCED
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x00050D0A File Offset: 0x0004FD0A
		// (set) Token: 0x060048FD RID: 18685 RVA: 0x00050D1C File Offset: 0x0004FD1C
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

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x060048FE RID: 18686 RVA: 0x00050D2A File Offset: 0x0004FD2A
		// (set) Token: 0x060048FF RID: 18687 RVA: 0x00050D3C File Offset: 0x0004FD3C
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

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06004900 RID: 18688 RVA: 0x00050D4A File Offset: 0x0004FD4A
		// (set) Token: 0x06004901 RID: 18689 RVA: 0x00050D5C File Offset: 0x0004FD5C
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

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06004902 RID: 18690 RVA: 0x00050D6A File Offset: 0x0004FD6A
		// (set) Token: 0x06004903 RID: 18691 RVA: 0x00050D7C File Offset: 0x0004FD7C
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

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x00050D8A File Offset: 0x0004FD8A
		// (set) Token: 0x06004905 RID: 18693 RVA: 0x00050D9C File Offset: 0x0004FD9C
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

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x00050DAA File Offset: 0x0004FDAA
		// (set) Token: 0x06004907 RID: 18695 RVA: 0x00050DBC File Offset: 0x0004FDBC
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

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x00050DCA File Offset: 0x0004FDCA
		// (set) Token: 0x06004909 RID: 18697 RVA: 0x00050DDC File Offset: 0x0004FDDC
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

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x00050DEA File Offset: 0x0004FDEA
		// (set) Token: 0x0600490B RID: 18699 RVA: 0x00050DFC File Offset: 0x0004FDFC
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

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600490C RID: 18700 RVA: 0x00050E0A File Offset: 0x0004FE0A
		// (set) Token: 0x0600490D RID: 18701 RVA: 0x00050E1C File Offset: 0x0004FE1C
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

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x00050E2A File Offset: 0x0004FE2A
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x00050E3C File Offset: 0x0004FE3C
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

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x00050E4A File Offset: 0x0004FE4A
		// (set) Token: 0x06004911 RID: 18705 RVA: 0x00050E5C File Offset: 0x0004FE5C
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

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x00050E6A File Offset: 0x0004FE6A
		// (set) Token: 0x06004913 RID: 18707 RVA: 0x00050E7C File Offset: 0x0004FE7C
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

		// Token: 0x06004914 RID: 18708 RVA: 0x00050E8A File Offset: 0x0004FE8A
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00050EA8 File Offset: 0x0004FEA8
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x00050EC5 File Offset: 0x0004FEC5
		// (set) Token: 0x06004917 RID: 18711 RVA: 0x00050ED4 File Offset: 0x0004FED4
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

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x00050EDF File Offset: 0x0004FEDF
		// (set) Token: 0x06004919 RID: 18713 RVA: 0x00050EEE File Offset: 0x0004FEEE
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

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x00050EF9 File Offset: 0x0004FEF9
		// (set) Token: 0x0600491B RID: 18715 RVA: 0x00050F08 File Offset: 0x0004FF08
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

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x00050F13 File Offset: 0x0004FF13
		// (set) Token: 0x0600491D RID: 18717 RVA: 0x00050F25 File Offset: 0x0004FF25
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

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x00050F33 File Offset: 0x0004FF33
		// (set) Token: 0x0600491F RID: 18719 RVA: 0x00050F45 File Offset: 0x0004FF45
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

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x00050F53 File Offset: 0x0004FF53
		// (set) Token: 0x06004921 RID: 18721 RVA: 0x00050F65 File Offset: 0x0004FF65
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

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x00050F73 File Offset: 0x0004FF73
		// (set) Token: 0x06004923 RID: 18723 RVA: 0x00050F85 File Offset: 0x0004FF85
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

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x00050F93 File Offset: 0x0004FF93
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x00050FA5 File Offset: 0x0004FFA5
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

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x00050FB3 File Offset: 0x0004FFB3
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x00050FC2 File Offset: 0x0004FFC2
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

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x00050FCD File Offset: 0x0004FFCD
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x00050FDF File Offset: 0x0004FFDF
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

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x00050FED File Offset: 0x0004FFED
		// (set) Token: 0x0600492B RID: 18731 RVA: 0x00050FFF File Offset: 0x0004FFFF
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

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x0005100D File Offset: 0x0005000D
		// (set) Token: 0x0600492D RID: 18733 RVA: 0x0005101C File Offset: 0x0005001C
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

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x00051027 File Offset: 0x00050027
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x00051036 File Offset: 0x00050036
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

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x00051041 File Offset: 0x00050041
		// (set) Token: 0x06004931 RID: 18737 RVA: 0x00051050 File Offset: 0x00050050
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

		// Token: 0x06004932 RID: 18738 RVA: 0x0005105C File Offset: 0x0005005C
		public FIXOrderCancelRequest()
		{
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x000510B4 File Offset: 0x000500B4
		public FIXOrderCancelRequest(string OrigClOrdID, string ClOrdID, char Side, DateTime TransactTime)
		{
			this.OrigClOrdID = OrigClOrdID;
			this.ClOrdID = ClOrdID;
			this.Side = Side;
			this.TransactTime = TransactTime;
		}

		// Token: 0x04000DA5 RID: 3493
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000DA6 RID: 3494
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000DA7 RID: 3495
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000DA8 RID: 3496
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000DA9 RID: 3497
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000DAA RID: 3498
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
