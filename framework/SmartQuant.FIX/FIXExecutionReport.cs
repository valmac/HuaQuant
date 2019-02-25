using System;
using System.Collections;
using System.ComponentModel;

namespace SmartQuant.FIX
{
	// Token: 0x02000099 RID: 153
	public class FIXExecutionReport : FIXMessage
	{
		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00021142 File Offset: 0x00020142
		// (set) Token: 0x06001E6A RID: 7786 RVA: 0x0002114F File Offset: 0x0002014F
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

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x0002115D File Offset: 0x0002015D
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x00021167 File Offset: 0x00020167
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

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00021172 File Offset: 0x00020172
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x0002117C File Offset: 0x0002017C
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

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00021187 File Offset: 0x00020187
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00021191 File Offset: 0x00020191
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

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x0002119C File Offset: 0x0002019C
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x000211A6 File Offset: 0x000201A6
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x000211B1 File Offset: 0x000201B1
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x000211BB File Offset: 0x000201BB
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

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x000211C6 File Offset: 0x000201C6
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x000211D3 File Offset: 0x000201D3
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

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x000211E1 File Offset: 0x000201E1
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x000211EB File Offset: 0x000201EB
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

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000211F6 File Offset: 0x000201F6
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x00021200 File Offset: 0x00020200
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

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x0002120B File Offset: 0x0002020B
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x00021215 File Offset: 0x00020215
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

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00021220 File Offset: 0x00020220
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x0002122A File Offset: 0x0002022A
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

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00021235 File Offset: 0x00020235
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x00021242 File Offset: 0x00020242
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x00021250 File Offset: 0x00020250
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x0002125A File Offset: 0x0002025A
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

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00021265 File Offset: 0x00020265
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0002126E File Offset: 0x0002026E
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

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00021278 File Offset: 0x00020278
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x00021282 File Offset: 0x00020282
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

		// Token: 0x06001E87 RID: 7815 RVA: 0x0002128D File Offset: 0x0002028D
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000212A0 File Offset: 0x000202A0
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x000212AF File Offset: 0x000202AF
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x000212BC File Offset: 0x000202BC
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

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x000212CA File Offset: 0x000202CA
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x000212D7 File Offset: 0x000202D7
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

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x000212E5 File Offset: 0x000202E5
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x000212EF File Offset: 0x000202EF
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

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x000212FA File Offset: 0x000202FA
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x00021304 File Offset: 0x00020304
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

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x0002130F File Offset: 0x0002030F
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00021319 File Offset: 0x00020319
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

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00021324 File Offset: 0x00020324
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x0002132E File Offset: 0x0002032E
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

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00021339 File Offset: 0x00020339
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00021346 File Offset: 0x00020346
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

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x00021354 File Offset: 0x00020354
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x00021361 File Offset: 0x00020361
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

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x0002136F File Offset: 0x0002036F
		// (set) Token: 0x06001E9A RID: 7834 RVA: 0x0002137C File Offset: 0x0002037C
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

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0002138A File Offset: 0x0002038A
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x00021397 File Offset: 0x00020397
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

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x000213A5 File Offset: 0x000203A5
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x000213B2 File Offset: 0x000203B2
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

		// Token: 0x06001E9F RID: 7839 RVA: 0x000213C0 File Offset: 0x000203C0
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000213DE File Offset: 0x000203DE
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x000213FB File Offset: 0x000203FB
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x00021408 File Offset: 0x00020408
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

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00021416 File Offset: 0x00020416
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x00021420 File Offset: 0x00020420
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

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x0002142B File Offset: 0x0002042B
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x00021438 File Offset: 0x00020438
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x00021446 File Offset: 0x00020446
		// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x00021453 File Offset: 0x00020453
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

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x00021461 File Offset: 0x00020461
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x0002146E File Offset: 0x0002046E
		[FIXField("527", EFieldOption.Optional)]
		public string SecondaryExecID
		{
			get
			{
				return this.GetStringValue(527);
			}
			set
			{
				this.SetStringValue(527, value);
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x0002147C File Offset: 0x0002047C
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00021486 File Offset: 0x00020486
		[FIXField("11", EFieldOption.Optional)]
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

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00021491 File Offset: 0x00020491
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x0002149B File Offset: 0x0002049B
		[FIXField("41", EFieldOption.Optional)]
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

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000214A6 File Offset: 0x000204A6
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x000214B3 File Offset: 0x000204B3
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

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000214C1 File Offset: 0x000204C1
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000214CE File Offset: 0x000204CE
		[FIXField("693", EFieldOption.Optional)]
		public string QuoteRespID
		{
			get
			{
				return this.GetStringValue(693);
			}
			set
			{
				this.SetStringValue(693, value);
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000214DC File Offset: 0x000204DC
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000214E9 File Offset: 0x000204E9
		[FIXField("790", EFieldOption.Optional)]
		public string OrdStatusReqID
		{
			get
			{
				return this.GetStringValue(790);
			}
			set
			{
				this.SetStringValue(790, value);
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000214F7 File Offset: 0x000204F7
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00021504 File Offset: 0x00020504
		[FIXField("584", EFieldOption.Optional)]
		public string MassStatusReqID
		{
			get
			{
				return this.GetStringValue(584);
			}
			set
			{
				this.SetStringValue(584, value);
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00021512 File Offset: 0x00020512
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x0002151F File Offset: 0x0002051F
		[FIXField("911", EFieldOption.Optional)]
		public int TotNumReports
		{
			get
			{
				return this.GetIntValue(911);
			}
			set
			{
				this.SetIntValue(911, value);
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x0002152D File Offset: 0x0002052D
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x0002153A File Offset: 0x0002053A
		[FIXField("912", EFieldOption.Optional)]
		public bool LastRptRequested
		{
			get
			{
				return this.GetBoolValue(912);
			}
			set
			{
				this.SetBoolValue(912, value);
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00021548 File Offset: 0x00020548
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x00021555 File Offset: 0x00020555
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntValue(453);
			}
			set
			{
				this.SetIntValue(453, value);
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00021563 File Offset: 0x00020563
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00021581 File Offset: 0x00020581
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x0002159E File Offset: 0x0002059E
		// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x000215AB File Offset: 0x000205AB
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

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x000215B9 File Offset: 0x000205B9
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x000215C6 File Offset: 0x000205C6
		[FIXField("382", EFieldOption.Optional)]
		public int NoContraBrokers
		{
			get
			{
				return this.GetIntValue(382);
			}
			set
			{
				this.SetIntValue(382, value);
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000215D4 File Offset: 0x000205D4
		public FIXContraBrokersGroup GetContraBrokersGroup(int i)
		{
			if (i < this.NoContraBrokers)
			{
				return (FIXContraBrokersGroup)this.fContraBrokersGroup[i];
			}
			return null;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000215F2 File Offset: 0x000205F2
		public void AddGroup(FIXContraBrokersGroup group)
		{
			this.fContraBrokersGroup.Add(group);
			this.NoContraBrokers++;
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x0002160F File Offset: 0x0002060F
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x00021619 File Offset: 0x00020619
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

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00021624 File Offset: 0x00020624
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00021631 File Offset: 0x00020631
		[FIXField("548", EFieldOption.Optional)]
		public string CrossID
		{
			get
			{
				return this.GetStringValue(548);
			}
			set
			{
				this.SetStringValue(548, value);
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0002163F File Offset: 0x0002063F
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0002164C File Offset: 0x0002064C
		[FIXField("551", EFieldOption.Optional)]
		public string OrigCrossID
		{
			get
			{
				return this.GetStringValue(551);
			}
			set
			{
				this.SetStringValue(551, value);
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0002165A File Offset: 0x0002065A
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00021667 File Offset: 0x00020667
		[FIXField("549", EFieldOption.Optional)]
		public int CrossType
		{
			get
			{
				return this.GetIntValue(549);
			}
			set
			{
				this.SetIntValue(549, value);
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00021675 File Offset: 0x00020675
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x0002167F File Offset: 0x0002067F
		[FIXField("17", EFieldOption.Required)]
		public string ExecID
		{
			get
			{
				return this.GetStringValue(17);
			}
			set
			{
				this.SetStringValue(17, value);
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0002168A File Offset: 0x0002068A
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00021694 File Offset: 0x00020694
		[FIXField("19", EFieldOption.Optional)]
		public string ExecRefID
		{
			get
			{
				return this.GetStringValue(19);
			}
			set
			{
				this.SetStringValue(19, value);
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0002169F File Offset: 0x0002069F
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x000216AC File Offset: 0x000206AC
		[Category("Attributes")]
		[FIXField("150", EFieldOption.Required)]
		public char ExecType
		{
			get
			{
				return this.GetCharValue(150);
			}
			set
			{
				this.SetCharValue(150, value);
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000216BA File Offset: 0x000206BA
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x000216C4 File Offset: 0x000206C4
		[FIXField("20", EFieldOption.Required)]
		[Category("Attributes")]
		public char ExecTransType
		{
			get
			{
				return this.GetCharValue(20);
			}
			set
			{
				this.SetCharValue(20, value);
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000216CF File Offset: 0x000206CF
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x000216D9 File Offset: 0x000206D9
		[Category("Attributes")]
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

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000216E4 File Offset: 0x000206E4
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x000216F1 File Offset: 0x000206F1
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

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000216FF File Offset: 0x000206FF
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00021709 File Offset: 0x00020709
		[Category("Attributes")]
		[FIXField("103", EFieldOption.Optional)]
		public int OrdRejReason
		{
			get
			{
				return this.GetIntValue(103);
			}
			set
			{
				this.SetIntValue(103, value);
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00021714 File Offset: 0x00020714
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00021721 File Offset: 0x00020721
		[FIXField("378", EFieldOption.Optional)]
		public int ExecRestatementReason
		{
			get
			{
				return this.GetIntValue(378);
			}
			set
			{
				this.SetIntValue(378, value);
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x0002172F File Offset: 0x0002072F
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00021738 File Offset: 0x00020738
		[Category("Attributes")]
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

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00021742 File Offset: 0x00020742
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0002174F File Offset: 0x0002074F
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

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x0002175D File Offset: 0x0002075D
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x0002176A File Offset: 0x0002076A
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

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00021778 File Offset: 0x00020778
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00021785 File Offset: 0x00020785
		[FIXField("589", EFieldOption.Optional)]
		public char DayBookingInst
		{
			get
			{
				return this.GetCharValue(589);
			}
			set
			{
				this.SetCharValue(589, value);
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00021793 File Offset: 0x00020793
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x000217A0 File Offset: 0x000207A0
		[FIXField("590", EFieldOption.Optional)]
		public char BookingUnit
		{
			get
			{
				return this.GetCharValue(590);
			}
			set
			{
				this.SetCharValue(590, value);
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x000217AE File Offset: 0x000207AE
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000217BB File Offset: 0x000207BB
		[FIXField("591", EFieldOption.Optional)]
		public char PreallocMethod
		{
			get
			{
				return this.GetCharValue(591);
			}
			set
			{
				this.SetCharValue(591, value);
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x000217C9 File Offset: 0x000207C9
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x000217D3 File Offset: 0x000207D3
		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharValue(63);
			}
			set
			{
				this.SetCharValue(63, value);
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x000217DE File Offset: 0x000207DE
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x000217E8 File Offset: 0x000207E8
		[FIXField("64", EFieldOption.Optional)]
		public DateTime SettlDate
		{
			get
			{
				return this.GetDateTimeValue(64);
			}
			set
			{
				this.SetDateTimeValue(64, value);
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x000217F3 File Offset: 0x000207F3
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00021800 File Offset: 0x00020800
		[FIXField("544", EFieldOption.Optional)]
		public char CashMargin
		{
			get
			{
				return this.GetCharValue(544);
			}
			set
			{
				this.SetCharValue(544, value);
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0002180E File Offset: 0x0002080E
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x0002181B File Offset: 0x0002081B
		[FIXField("635", EFieldOption.Optional)]
		public string ClearingFeeIndicator
		{
			get
			{
				return this.GetStringValue(635);
			}
			set
			{
				this.SetStringValue(635, value);
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00021829 File Offset: 0x00020829
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00021833 File Offset: 0x00020833
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

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0002183E File Offset: 0x0002083E
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00021848 File Offset: 0x00020848
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00021853 File Offset: 0x00020853
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x0002185D File Offset: 0x0002085D
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

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00021868 File Offset: 0x00020868
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00021872 File Offset: 0x00020872
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

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0002187D File Offset: 0x0002087D
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x0002188A File Offset: 0x0002088A
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

		// Token: 0x06001EFB RID: 7931 RVA: 0x00021898 File Offset: 0x00020898
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000218B6 File Offset: 0x000208B6
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x000218D3 File Offset: 0x000208D3
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x000218E0 File Offset: 0x000208E0
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x000218EE File Offset: 0x000208EE
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x000218FB File Offset: 0x000208FB
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

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x00021909 File Offset: 0x00020909
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x00021916 File Offset: 0x00020916
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

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00021924 File Offset: 0x00020924
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x00021931 File Offset: 0x00020931
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

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0002193F File Offset: 0x0002093F
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x0002194C File Offset: 0x0002094C
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

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0002195A File Offset: 0x0002095A
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x00021967 File Offset: 0x00020967
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

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00021975 File Offset: 0x00020975
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x00021982 File Offset: 0x00020982
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00021990 File Offset: 0x00020990
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x0002199D File Offset: 0x0002099D
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000219AB File Offset: 0x000209AB
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x000219B8 File Offset: 0x000209B8
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

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x000219C6 File Offset: 0x000209C6
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x000219D3 File Offset: 0x000209D3
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

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x000219E1 File Offset: 0x000209E1
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x000219EE File Offset: 0x000209EE
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

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x000219FC File Offset: 0x000209FC
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x00021A09 File Offset: 0x00020A09
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

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00021A17 File Offset: 0x00020A17
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x00021A24 File Offset: 0x00020A24
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

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00021A32 File Offset: 0x00020A32
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x00021A3F File Offset: 0x00020A3F
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

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00021A4D File Offset: 0x00020A4D
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x00021A5A File Offset: 0x00020A5A
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

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00021A68 File Offset: 0x00020A68
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00021A75 File Offset: 0x00020A75
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

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00021A83 File Offset: 0x00020A83
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00021A90 File Offset: 0x00020A90
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00021A9E File Offset: 0x00020A9E
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00021AAB File Offset: 0x00020AAB
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00021AB9 File Offset: 0x00020AB9
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00021AC6 File Offset: 0x00020AC6
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00021AD4 File Offset: 0x00020AD4
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00021AE1 File Offset: 0x00020AE1
		[FIXField("947", EFieldOption.Optional)]
		public string StrikeCurrency
		{
			get
			{
				return this.GetStringValue(947);
			}
			set
			{
				this.SetStringValue(947, value);
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00021AEF File Offset: 0x00020AEF
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00021AFC File Offset: 0x00020AFC
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00021B0A File Offset: 0x00020B0A
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x00021B17 File Offset: 0x00020B17
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00021B25 File Offset: 0x00020B25
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00021B32 File Offset: 0x00020B32
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

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x00021B40 File Offset: 0x00020B40
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x00021B4D File Offset: 0x00020B4D
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

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00021B5B File Offset: 0x00020B5B
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x00021B65 File Offset: 0x00020B65
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00021B70 File Offset: 0x00020B70
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00021B7D File Offset: 0x00020B7D
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

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x00021B8B File Offset: 0x00020B8B
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x00021B98 File Offset: 0x00020B98
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

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00021BA6 File Offset: 0x00020BA6
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x00021BB0 File Offset: 0x00020BB0
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

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00021BBB File Offset: 0x00020BBB
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x00021BC8 File Offset: 0x00020BC8
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

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00021BD6 File Offset: 0x00020BD6
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00021BE3 File Offset: 0x00020BE3
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

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00021BF1 File Offset: 0x00020BF1
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x00021BFE File Offset: 0x00020BFE
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

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00021C0C File Offset: 0x00020C0C
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x00021C19 File Offset: 0x00020C19
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

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00021C27 File Offset: 0x00020C27
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00021C34 File Offset: 0x00020C34
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00021C42 File Offset: 0x00020C42
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x00021C4F File Offset: 0x00020C4F
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

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00021C5D File Offset: 0x00020C5D
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00021C6A File Offset: 0x00020C6A
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

		// Token: 0x06001F43 RID: 8003 RVA: 0x00021C78 File Offset: 0x00020C78
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00021C96 File Offset: 0x00020C96
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00021CB3 File Offset: 0x00020CB3
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x00021CC0 File Offset: 0x00020CC0
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

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00021CCE File Offset: 0x00020CCE
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x00021CDB File Offset: 0x00020CDB
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

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00021CE9 File Offset: 0x00020CE9
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00021CF6 File Offset: 0x00020CF6
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringValue(913);
			}
			set
			{
				this.SetStringValue(913, value);
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00021D04 File Offset: 0x00020D04
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00021D11 File Offset: 0x00020D11
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringValue(914);
			}
			set
			{
				this.SetStringValue(914, value);
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00021D1F File Offset: 0x00020D1F
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00021D2C File Offset: 0x00020D2C
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeValue(915);
			}
			set
			{
				this.SetDateTimeValue(915, value);
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00021D3A File Offset: 0x00020D3A
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00021D47 File Offset: 0x00020D47
		[FIXField("918", EFieldOption.Optional)]
		public string AgreementCurrency
		{
			get
			{
				return this.GetStringValue(918);
			}
			set
			{
				this.SetStringValue(918, value);
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00021D55 File Offset: 0x00020D55
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00021D62 File Offset: 0x00020D62
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntValue(788);
			}
			set
			{
				this.SetIntValue(788, value);
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00021D70 File Offset: 0x00020D70
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00021D7D File Offset: 0x00020D7D
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeValue(916);
			}
			set
			{
				this.SetDateTimeValue(916, value);
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00021D8B File Offset: 0x00020D8B
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00021D98 File Offset: 0x00020D98
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeValue(917);
			}
			set
			{
				this.SetDateTimeValue(917, value);
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00021DA6 File Offset: 0x00020DA6
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00021DB3 File Offset: 0x00020DB3
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntValue(919);
			}
			set
			{
				this.SetIntValue(919, value);
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00021DC1 File Offset: 0x00020DC1
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00021DCE File Offset: 0x00020DCE
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleValue(898);
			}
			set
			{
				this.SetDoubleValue(898, value);
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00021DDC File Offset: 0x00020DDC
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00021DE9 File Offset: 0x00020DE9
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

		// Token: 0x06001F5D RID: 8029 RVA: 0x00021DF7 File Offset: 0x00020DF7
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00021E15 File Offset: 0x00020E15
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00021E32 File Offset: 0x00020E32
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00021E3C File Offset: 0x00020E3C
		[Category("Attributes")]
		[FIXField("54", EFieldOption.Required)]
		public char Side
		{
			get
			{
				return this.GetCharValue(54);
			}
			set
			{
				this.SetCharValue(54, value);
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00021E47 File Offset: 0x00020E47
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00021E54 File Offset: 0x00020E54
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntValue(232);
			}
			set
			{
				this.SetIntValue(232, value);
			}
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00021E62 File Offset: 0x00020E62
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00021E80 File Offset: 0x00020E80
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00021E9D File Offset: 0x00020E9D
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x00021EAA File Offset: 0x00020EAA
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntValue(854);
			}
			set
			{
				this.SetIntValue(854, value);
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00021EB8 File Offset: 0x00020EB8
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x00021EC2 File Offset: 0x00020EC2
		[Category("Attributes")]
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleValue(38);
			}
			set
			{
				this.SetDoubleValue(38, value);
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00021ECD File Offset: 0x00020ECD
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x00021EDA File Offset: 0x00020EDA
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleValue(152);
			}
			set
			{
				this.SetDoubleValue(152, value);
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00021EE8 File Offset: 0x00020EE8
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x00021EF5 File Offset: 0x00020EF5
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleValue(516);
			}
			set
			{
				this.SetDoubleValue(516, value);
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00021F03 File Offset: 0x00020F03
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00021F10 File Offset: 0x00020F10
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharValue(468);
			}
			set
			{
				this.SetCharValue(468, value);
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00021F1E File Offset: 0x00020F1E
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x00021F2B File Offset: 0x00020F2B
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleValue(469);
			}
			set
			{
				this.SetDoubleValue(469, value);
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00021F39 File Offset: 0x00020F39
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00021F43 File Offset: 0x00020F43
		[FIXField("40", EFieldOption.Optional)]
		[Category("Attributes")]
		public char OrdType
		{
			get
			{
				return this.GetCharValue(40);
			}
			set
			{
				this.SetCharValue(40, value);
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00021F4E File Offset: 0x00020F4E
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00021F5B File Offset: 0x00020F5B
		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntValue(423);
			}
			set
			{
				this.SetIntValue(423, value);
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00021F69 File Offset: 0x00020F69
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x00021F73 File Offset: 0x00020F73
		[FIXField("44", EFieldOption.Optional)]
		[Category("Attributes")]
		public double Price
		{
			get
			{
				return this.GetDoubleValue(44);
			}
			set
			{
				this.SetDoubleValue(44, value);
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00021F7E File Offset: 0x00020F7E
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x00021F88 File Offset: 0x00020F88
		[FIXField("99", EFieldOption.Optional)]
		[Category("Attributes")]
		public double StopPx
		{
			get
			{
				return this.GetDoubleValue(99);
			}
			set
			{
				this.SetDoubleValue(99, value);
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00021F93 File Offset: 0x00020F93
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00021FA0 File Offset: 0x00020FA0
		[FIXField("211", EFieldOption.Optional)]
		public double PegOffsetValue
		{
			get
			{
				return this.GetDoubleValue(211);
			}
			set
			{
				this.SetDoubleValue(211, value);
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x00021FAE File Offset: 0x00020FAE
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00021FBB File Offset: 0x00020FBB
		[FIXField("835", EFieldOption.Optional)]
		public int PegMoveType
		{
			get
			{
				return this.GetIntValue(835);
			}
			set
			{
				this.SetIntValue(835, value);
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00021FC9 File Offset: 0x00020FC9
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00021FD6 File Offset: 0x00020FD6
		[FIXField("836", EFieldOption.Optional)]
		public int PegOffsetType
		{
			get
			{
				return this.GetIntValue(836);
			}
			set
			{
				this.SetIntValue(836, value);
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00021FE4 File Offset: 0x00020FE4
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x00021FF1 File Offset: 0x00020FF1
		[FIXField("837", EFieldOption.Optional)]
		public int PegLimitType
		{
			get
			{
				return this.GetIntValue(837);
			}
			set
			{
				this.SetIntValue(837, value);
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00021FFF File Offset: 0x00020FFF
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0002200C File Offset: 0x0002100C
		[FIXField("838", EFieldOption.Optional)]
		public int PegRoundDirection
		{
			get
			{
				return this.GetIntValue(838);
			}
			set
			{
				this.SetIntValue(838, value);
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0002201A File Offset: 0x0002101A
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00022027 File Offset: 0x00021027
		[FIXField("840", EFieldOption.Optional)]
		public int PegScope
		{
			get
			{
				return this.GetIntValue(840);
			}
			set
			{
				this.SetIntValue(840, value);
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00022035 File Offset: 0x00021035
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00022042 File Offset: 0x00021042
		[FIXField("388", EFieldOption.Optional)]
		public char DiscretionInst
		{
			get
			{
				return this.GetCharValue(388);
			}
			set
			{
				this.SetCharValue(388, value);
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00022050 File Offset: 0x00021050
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x0002205D File Offset: 0x0002105D
		[FIXField("389", EFieldOption.Optional)]
		public double DiscretionOffsetValue
		{
			get
			{
				return this.GetDoubleValue(389);
			}
			set
			{
				this.SetDoubleValue(389, value);
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0002206B File Offset: 0x0002106B
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00022078 File Offset: 0x00021078
		[FIXField("841", EFieldOption.Optional)]
		public int DiscretionMoveType
		{
			get
			{
				return this.GetIntValue(841);
			}
			set
			{
				this.SetIntValue(841, value);
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00022086 File Offset: 0x00021086
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00022093 File Offset: 0x00021093
		[FIXField("842", EFieldOption.Optional)]
		public int DiscretionOffsetType
		{
			get
			{
				return this.GetIntValue(842);
			}
			set
			{
				this.SetIntValue(842, value);
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x000220A1 File Offset: 0x000210A1
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x000220AE File Offset: 0x000210AE
		[FIXField("843", EFieldOption.Optional)]
		public int DiscretionLimitType
		{
			get
			{
				return this.GetIntValue(843);
			}
			set
			{
				this.SetIntValue(843, value);
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x000220BC File Offset: 0x000210BC
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x000220C9 File Offset: 0x000210C9
		[FIXField("844", EFieldOption.Optional)]
		public int DiscretionRoundDirection
		{
			get
			{
				return this.GetIntValue(844);
			}
			set
			{
				this.SetIntValue(844, value);
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x000220D7 File Offset: 0x000210D7
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x000220E4 File Offset: 0x000210E4
		[FIXField("846", EFieldOption.Optional)]
		public int DiscretionScope
		{
			get
			{
				return this.GetIntValue(846);
			}
			set
			{
				this.SetIntValue(846, value);
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x000220F2 File Offset: 0x000210F2
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x000220FF File Offset: 0x000210FF
		[FIXField("839", EFieldOption.Optional)]
		public double PeggedPrice
		{
			get
			{
				return this.GetDoubleValue(839);
			}
			set
			{
				this.SetDoubleValue(839, value);
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0002210D File Offset: 0x0002110D
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0002211A File Offset: 0x0002111A
		[FIXField("845", EFieldOption.Optional)]
		public double DiscretionPrice
		{
			get
			{
				return this.GetDoubleValue(845);
			}
			set
			{
				this.SetDoubleValue(845, value);
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00022128 File Offset: 0x00021128
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x00022135 File Offset: 0x00021135
		[FIXField("847", EFieldOption.Optional)]
		public int TargetStrategy
		{
			get
			{
				return this.GetIntValue(847);
			}
			set
			{
				this.SetIntValue(847, value);
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00022143 File Offset: 0x00021143
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00022150 File Offset: 0x00021150
		[FIXField("848", EFieldOption.Optional)]
		public string TargetStrategyParameters
		{
			get
			{
				return this.GetStringValue(848);
			}
			set
			{
				this.SetStringValue(848, value);
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0002215E File Offset: 0x0002115E
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0002216B File Offset: 0x0002116B
		[FIXField("849", EFieldOption.Optional)]
		public double ParticipationRate
		{
			get
			{
				return this.GetDoubleValue(849);
			}
			set
			{
				this.SetDoubleValue(849, value);
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x00022179 File Offset: 0x00021179
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00022186 File Offset: 0x00021186
		[FIXField("850", EFieldOption.Optional)]
		public double TargetStrategyPerformance
		{
			get
			{
				return this.GetDoubleValue(850);
			}
			set
			{
				this.SetDoubleValue(850, value);
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x00022194 File Offset: 0x00021194
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0002219E File Offset: 0x0002119E
		[FIXField("15", EFieldOption.Optional)]
		[Category("Attributes")]
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

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000221A9 File Offset: 0x000211A9
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x000221B6 File Offset: 0x000211B6
		[FIXField("376", EFieldOption.Optional)]
		public string ComplianceID
		{
			get
			{
				return this.GetStringValue(376);
			}
			set
			{
				this.SetStringValue(376, value);
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000221C4 File Offset: 0x000211C4
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x000221D1 File Offset: 0x000211D1
		[FIXField("377", EFieldOption.Optional)]
		public bool SolicitedFlag
		{
			get
			{
				return this.GetBoolValue(377);
			}
			set
			{
				this.SetBoolValue(377, value);
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000221DF File Offset: 0x000211DF
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x000221E9 File Offset: 0x000211E9
		[FIXField("59", EFieldOption.Optional)]
		[Category("Attributes")]
		public char TimeInForce
		{
			get
			{
				return this.GetCharValue(59);
			}
			set
			{
				this.SetCharValue(59, value);
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x000221F4 File Offset: 0x000211F4
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00022201 File Offset: 0x00021201
		[FIXField("168", EFieldOption.Optional)]
		public DateTime EffectiveTime
		{
			get
			{
				return this.GetDateTimeValue(168);
			}
			set
			{
				this.SetDateTimeValue(168, value);
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0002220F File Offset: 0x0002120F
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x0002221C File Offset: 0x0002121C
		[FIXField("432", EFieldOption.Optional)]
		public DateTime ExpireDate
		{
			get
			{
				return this.GetDateTimeValue(432);
			}
			set
			{
				this.SetDateTimeValue(432, value);
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0002222A File Offset: 0x0002122A
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00022234 File Offset: 0x00021234
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeValue(126);
			}
			set
			{
				this.SetDateTimeValue(126, value);
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0002223F File Offset: 0x0002123F
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00022249 File Offset: 0x00021249
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringValue(18);
			}
			set
			{
				this.SetStringValue(18, value);
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x00022254 File Offset: 0x00021254
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00022261 File Offset: 0x00021261
		[FIXField("528", EFieldOption.Optional)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharValue(528);
			}
			set
			{
				this.SetCharValue(528, value);
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0002226F File Offset: 0x0002126F
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0002227C File Offset: 0x0002127C
		[FIXField("529", EFieldOption.Optional)]
		public string OrderRestrictions
		{
			get
			{
				return this.GetStringValue(529);
			}
			set
			{
				this.SetStringValue(529, value);
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0002228A File Offset: 0x0002128A
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00022297 File Offset: 0x00021297
		[FIXField("582", EFieldOption.Optional)]
		public int CustOrderCapacity
		{
			get
			{
				return this.GetIntValue(582);
			}
			set
			{
				this.SetIntValue(582, value);
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000222A5 File Offset: 0x000212A5
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x000222AF File Offset: 0x000212AF
		[Category("Attributes")]
		[FIXField("32", EFieldOption.Optional)]
		public double LastQty
		{
			get
			{
				return this.GetDoubleValue(32);
			}
			set
			{
				this.SetDoubleValue(32, value);
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000222BA File Offset: 0x000212BA
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x000222C7 File Offset: 0x000212C7
		[FIXField("652", EFieldOption.Optional)]
		public double UnderlyingLastQty
		{
			get
			{
				return this.GetDoubleValue(652);
			}
			set
			{
				this.SetDoubleValue(652, value);
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000222D5 File Offset: 0x000212D5
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x000222DF File Offset: 0x000212DF
		[Category("Attributes")]
		[FIXField("31", EFieldOption.Optional)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleValue(31);
			}
			set
			{
				this.SetDoubleValue(31, value);
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000222EA File Offset: 0x000212EA
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x000222F7 File Offset: 0x000212F7
		[FIXField("651", EFieldOption.Optional)]
		public double UnderlyingLastPx
		{
			get
			{
				return this.GetDoubleValue(651);
			}
			set
			{
				this.SetDoubleValue(651, value);
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00022305 File Offset: 0x00021305
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00022312 File Offset: 0x00021312
		[FIXField("669", EFieldOption.Optional)]
		public double LastParPx
		{
			get
			{
				return this.GetDoubleValue(669);
			}
			set
			{
				this.SetDoubleValue(669, value);
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00022320 File Offset: 0x00021320
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0002232D File Offset: 0x0002132D
		[FIXField("194", EFieldOption.Optional)]
		public double LastSpotRate
		{
			get
			{
				return this.GetDoubleValue(194);
			}
			set
			{
				this.SetDoubleValue(194, value);
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0002233B File Offset: 0x0002133B
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00022348 File Offset: 0x00021348
		[FIXField("195", EFieldOption.Optional)]
		public double LastForwardPoints
		{
			get
			{
				return this.GetDoubleValue(195);
			}
			set
			{
				this.SetDoubleValue(195, value);
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00022356 File Offset: 0x00021356
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00022360 File Offset: 0x00021360
		[FIXField("30", EFieldOption.Optional)]
		public string LastMkt
		{
			get
			{
				return this.GetStringValue(30);
			}
			set
			{
				this.SetStringValue(30, value);
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0002236B File Offset: 0x0002136B
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00022378 File Offset: 0x00021378
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

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00022386 File Offset: 0x00021386
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00022393 File Offset: 0x00021393
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

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000223A1 File Offset: 0x000213A1
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x000223AE File Offset: 0x000213AE
		[FIXField("943", EFieldOption.Optional)]
		public string TimeBracket
		{
			get
			{
				return this.GetStringValue(943);
			}
			set
			{
				this.SetStringValue(943, value);
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000223BC File Offset: 0x000213BC
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x000223C6 File Offset: 0x000213C6
		[FIXField("29", EFieldOption.Optional)]
		public char LastCapacity
		{
			get
			{
				return this.GetCharValue(29);
			}
			set
			{
				this.SetCharValue(29, value);
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000223D1 File Offset: 0x000213D1
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x000223DE File Offset: 0x000213DE
		[Category("Attributes")]
		[FIXField("151", EFieldOption.Required)]
		public double LeavesQty
		{
			get
			{
				return this.GetDoubleValue(151);
			}
			set
			{
				this.SetDoubleValue(151, value);
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000223EC File Offset: 0x000213EC
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x000223F6 File Offset: 0x000213F6
		[FIXField("14", EFieldOption.Required)]
		[Category("Attributes")]
		public double CumQty
		{
			get
			{
				return this.GetDoubleValue(14);
			}
			set
			{
				this.SetDoubleValue(14, value);
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00022401 File Offset: 0x00021401
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0002240A File Offset: 0x0002140A
		[FIXField("6", EFieldOption.Required)]
		[Category("Attributes")]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleValue(6);
			}
			set
			{
				this.SetDoubleValue(6, value);
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00022414 File Offset: 0x00021414
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00022421 File Offset: 0x00021421
		[FIXField("424", EFieldOption.Optional)]
		public double DayOrderQty
		{
			get
			{
				return this.GetDoubleValue(424);
			}
			set
			{
				this.SetDoubleValue(424, value);
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0002242F File Offset: 0x0002142F
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0002243C File Offset: 0x0002143C
		[FIXField("425", EFieldOption.Optional)]
		public double DayCumQty
		{
			get
			{
				return this.GetDoubleValue(425);
			}
			set
			{
				this.SetDoubleValue(425, value);
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0002244A File Offset: 0x0002144A
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00022457 File Offset: 0x00021457
		[FIXField("426", EFieldOption.Optional)]
		public double DayAvgPx
		{
			get
			{
				return this.GetDoubleValue(426);
			}
			set
			{
				this.SetDoubleValue(426, value);
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00022465 File Offset: 0x00021465
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00022472 File Offset: 0x00021472
		[FIXField("427", EFieldOption.Optional)]
		public int GTBookingInst
		{
			get
			{
				return this.GetIntValue(427);
			}
			set
			{
				this.SetIntValue(427, value);
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00022480 File Offset: 0x00021480
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x0002248A File Offset: 0x0002148A
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

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00022495 File Offset: 0x00021495
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x0002249F File Offset: 0x0002149F
		[Category("Attributes")]
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

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000224AA File Offset: 0x000214AA
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x000224B4 File Offset: 0x000214B4
		[FIXField("113", EFieldOption.Optional)]
		public bool ReportToExch
		{
			get
			{
				return this.GetBoolValue(113);
			}
			set
			{
				this.SetBoolValue(113, value);
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x000224BF File Offset: 0x000214BF
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x000224C9 File Offset: 0x000214C9
		[Category("Commission")]
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleValue(12);
			}
			set
			{
				this.SetDoubleValue(12, value);
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000224D4 File Offset: 0x000214D4
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x000224DE File Offset: 0x000214DE
		[FIXField("13", EFieldOption.Optional)]
		[Category("Commission")]
		public char CommType
		{
			get
			{
				return this.GetCharValue(13);
			}
			set
			{
				this.SetCharValue(13, value);
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x000224E9 File Offset: 0x000214E9
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x000224F6 File Offset: 0x000214F6
		[Category("Commission")]
		[FIXField("479", EFieldOption.Optional)]
		public string CommCurrency
		{
			get
			{
				return this.GetStringValue(479);
			}
			set
			{
				this.SetStringValue(479, value);
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00022504 File Offset: 0x00021504
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00022511 File Offset: 0x00021511
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharValue(497);
			}
			set
			{
				this.SetCharValue(497, value);
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0002251F File Offset: 0x0002151F
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0002252C File Offset: 0x0002152C
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleValue(218);
			}
			set
			{
				this.SetDoubleValue(218, value);
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0002253A File Offset: 0x0002153A
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x00022547 File Offset: 0x00021547
		[FIXField("220", EFieldOption.Optional)]
		public string BenchmarkCurveCurrency
		{
			get
			{
				return this.GetStringValue(220);
			}
			set
			{
				this.SetStringValue(220, value);
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x00022555 File Offset: 0x00021555
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x00022562 File Offset: 0x00021562
		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringValue(221);
			}
			set
			{
				this.SetStringValue(221, value);
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00022570 File Offset: 0x00021570
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x0002257D File Offset: 0x0002157D
		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringValue(222);
			}
			set
			{
				this.SetStringValue(222, value);
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0002258B File Offset: 0x0002158B
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00022598 File Offset: 0x00021598
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleValue(662);
			}
			set
			{
				this.SetDoubleValue(662, value);
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x000225A6 File Offset: 0x000215A6
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x000225B3 File Offset: 0x000215B3
		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntValue(663);
			}
			set
			{
				this.SetIntValue(663, value);
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x000225C1 File Offset: 0x000215C1
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x000225CE File Offset: 0x000215CE
		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringValue(699);
			}
			set
			{
				this.SetStringValue(699, value);
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x000225DC File Offset: 0x000215DC
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x000225E9 File Offset: 0x000215E9
		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringValue(761);
			}
			set
			{
				this.SetStringValue(761, value);
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x000225F7 File Offset: 0x000215F7
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x00022604 File Offset: 0x00021604
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringValue(235);
			}
			set
			{
				this.SetStringValue(235, value);
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00022612 File Offset: 0x00021612
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0002261F File Offset: 0x0002161F
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleValue(236);
			}
			set
			{
				this.SetDoubleValue(236, value);
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0002262D File Offset: 0x0002162D
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0002263A File Offset: 0x0002163A
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeValue(701);
			}
			set
			{
				this.SetDateTimeValue(701, value);
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x00022648 File Offset: 0x00021648
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x00022655 File Offset: 0x00021655
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeValue(696);
			}
			set
			{
				this.SetDateTimeValue(696, value);
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00022663 File Offset: 0x00021663
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x00022670 File Offset: 0x00021670
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleValue(697);
			}
			set
			{
				this.SetDoubleValue(697, value);
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0002267E File Offset: 0x0002167E
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x0002268B File Offset: 0x0002168B
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntValue(698);
			}
			set
			{
				this.SetIntValue(698, value);
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x00022699 File Offset: 0x00021699
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x000226A6 File Offset: 0x000216A6
		[FIXField("381", EFieldOption.Optional)]
		public double GrossTradeAmt
		{
			get
			{
				return this.GetDoubleValue(381);
			}
			set
			{
				this.SetDoubleValue(381, value);
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x000226B4 File Offset: 0x000216B4
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x000226C1 File Offset: 0x000216C1
		[FIXField("157", EFieldOption.Optional)]
		public int NumDaysInterest
		{
			get
			{
				return this.GetIntValue(157);
			}
			set
			{
				this.SetIntValue(157, value);
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x000226CF File Offset: 0x000216CF
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x000226DC File Offset: 0x000216DC
		[FIXField("230", EFieldOption.Optional)]
		public DateTime ExDate
		{
			get
			{
				return this.GetDateTimeValue(230);
			}
			set
			{
				this.SetDateTimeValue(230, value);
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x000226EA File Offset: 0x000216EA
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x000226F7 File Offset: 0x000216F7
		[FIXField("158", EFieldOption.Optional)]
		public double AccruedInterestRate
		{
			get
			{
				return this.GetDoubleValue(158);
			}
			set
			{
				this.SetDoubleValue(158, value);
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00022705 File Offset: 0x00021705
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x00022712 File Offset: 0x00021712
		[FIXField("159", EFieldOption.Optional)]
		public double AccruedInterestAmt
		{
			get
			{
				return this.GetDoubleValue(159);
			}
			set
			{
				this.SetDoubleValue(159, value);
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x00022720 File Offset: 0x00021720
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x0002272D File Offset: 0x0002172D
		[FIXField("738", EFieldOption.Optional)]
		public double InterestAtMaturity
		{
			get
			{
				return this.GetDoubleValue(738);
			}
			set
			{
				this.SetDoubleValue(738, value);
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0002273B File Offset: 0x0002173B
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x00022748 File Offset: 0x00021748
		[FIXField("920", EFieldOption.Optional)]
		public double EndAccruedInterestAmt
		{
			get
			{
				return this.GetDoubleValue(920);
			}
			set
			{
				this.SetDoubleValue(920, value);
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x00022756 File Offset: 0x00021756
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x00022763 File Offset: 0x00021763
		[FIXField("921", EFieldOption.Optional)]
		public double StartCash
		{
			get
			{
				return this.GetDoubleValue(921);
			}
			set
			{
				this.SetDoubleValue(921, value);
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x00022771 File Offset: 0x00021771
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x0002277E File Offset: 0x0002177E
		[FIXField("922", EFieldOption.Optional)]
		public double EndCash
		{
			get
			{
				return this.GetDoubleValue(922);
			}
			set
			{
				this.SetDoubleValue(922, value);
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0002278C File Offset: 0x0002178C
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x00022799 File Offset: 0x00021799
		[FIXField("258", EFieldOption.Optional)]
		public bool TradedFlatSwitch
		{
			get
			{
				return this.GetBoolValue(258);
			}
			set
			{
				this.SetBoolValue(258, value);
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x000227A7 File Offset: 0x000217A7
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x000227B4 File Offset: 0x000217B4
		[FIXField("259", EFieldOption.Optional)]
		public DateTime BasisFeatureDate
		{
			get
			{
				return this.GetDateTimeValue(259);
			}
			set
			{
				this.SetDateTimeValue(259, value);
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x000227C2 File Offset: 0x000217C2
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x000227CF File Offset: 0x000217CF
		[FIXField("260", EFieldOption.Optional)]
		public double BasisFeaturePrice
		{
			get
			{
				return this.GetDoubleValue(260);
			}
			set
			{
				this.SetDoubleValue(260, value);
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x000227DD File Offset: 0x000217DD
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x000227EA File Offset: 0x000217EA
		[FIXField("238", EFieldOption.Optional)]
		public double Concession
		{
			get
			{
				return this.GetDoubleValue(238);
			}
			set
			{
				this.SetDoubleValue(238, value);
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x000227F8 File Offset: 0x000217F8
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00022805 File Offset: 0x00021805
		[FIXField("237", EFieldOption.Optional)]
		public double TotalTakedown
		{
			get
			{
				return this.GetDoubleValue(237);
			}
			set
			{
				this.SetDoubleValue(237, value);
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00022813 File Offset: 0x00021813
		// (set) Token: 0x06002022 RID: 8226 RVA: 0x0002281D File Offset: 0x0002181D
		[FIXField("118", EFieldOption.Optional)]
		public double NetMoney
		{
			get
			{
				return this.GetDoubleValue(118);
			}
			set
			{
				this.SetDoubleValue(118, value);
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x00022828 File Offset: 0x00021828
		// (set) Token: 0x06002024 RID: 8228 RVA: 0x00022832 File Offset: 0x00021832
		[FIXField("119", EFieldOption.Optional)]
		public double SettlCurrAmt
		{
			get
			{
				return this.GetDoubleValue(119);
			}
			set
			{
				this.SetDoubleValue(119, value);
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0002283D File Offset: 0x0002183D
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x00022847 File Offset: 0x00021847
		[FIXField("120", EFieldOption.Optional)]
		public string SettlCurrency
		{
			get
			{
				return this.GetStringValue(120);
			}
			set
			{
				this.SetStringValue(120, value);
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00022852 File Offset: 0x00021852
		// (set) Token: 0x06002028 RID: 8232 RVA: 0x0002285F File Offset: 0x0002185F
		[FIXField("155", EFieldOption.Optional)]
		public double SettlCurrFxRate
		{
			get
			{
				return this.GetDoubleValue(155);
			}
			set
			{
				this.SetDoubleValue(155, value);
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0002286D File Offset: 0x0002186D
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x0002287A File Offset: 0x0002187A
		[FIXField("156", EFieldOption.Optional)]
		public char SettlCurrFxRateCalc
		{
			get
			{
				return this.GetCharValue(156);
			}
			set
			{
				this.SetCharValue(156, value);
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00022888 File Offset: 0x00021888
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x00022892 File Offset: 0x00021892
		[FIXField("21", EFieldOption.Optional)]
		[Category("Attributes")]
		public char HandlInst
		{
			get
			{
				return this.GetCharValue(21);
			}
			set
			{
				this.SetCharValue(21, value);
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0002289D File Offset: 0x0002189D
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x000228A7 File Offset: 0x000218A7
		[FIXField("110", EFieldOption.Optional)]
		public double MinQty
		{
			get
			{
				return this.GetDoubleValue(110);
			}
			set
			{
				this.SetDoubleValue(110, value);
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x000228B2 File Offset: 0x000218B2
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x000228BC File Offset: 0x000218BC
		[FIXField("111", EFieldOption.Optional)]
		public double MaxFloor
		{
			get
			{
				return this.GetDoubleValue(111);
			}
			set
			{
				this.SetDoubleValue(111, value);
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x000228C7 File Offset: 0x000218C7
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x000228D1 File Offset: 0x000218D1
		[FIXField("77", EFieldOption.Optional)]
		public char PositionEffect
		{
			get
			{
				return this.GetCharValue(77);
			}
			set
			{
				this.SetCharValue(77, value);
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x000228DC File Offset: 0x000218DC
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x000228E9 File Offset: 0x000218E9
		[FIXField("210", EFieldOption.Optional)]
		public double MaxShow
		{
			get
			{
				return this.GetDoubleValue(210);
			}
			set
			{
				this.SetDoubleValue(210, value);
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x000228F7 File Offset: 0x000218F7
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x00022904 File Offset: 0x00021904
		[FIXField("775", EFieldOption.Optional)]
		public int BookingType
		{
			get
			{
				return this.GetIntValue(775);
			}
			set
			{
				this.SetIntValue(775, value);
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00022912 File Offset: 0x00021912
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0002291C File Offset: 0x0002191C
		[FIXField("58", EFieldOption.Optional)]
		[Category("Attributes")]
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

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00022927 File Offset: 0x00021927
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00022934 File Offset: 0x00021934
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

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00022942 File Offset: 0x00021942
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x0002294F File Offset: 0x0002194F
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

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0002295D File Offset: 0x0002195D
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x0002296A File Offset: 0x0002196A
		[FIXField("193", EFieldOption.Optional)]
		public DateTime SettlDate2
		{
			get
			{
				return this.GetDateTimeValue(193);
			}
			set
			{
				this.SetDateTimeValue(193, value);
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x00022978 File Offset: 0x00021978
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x00022985 File Offset: 0x00021985
		[FIXField("192", EFieldOption.Optional)]
		public double OrderQty2
		{
			get
			{
				return this.GetDoubleValue(192);
			}
			set
			{
				this.SetDoubleValue(192, value);
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x00022993 File Offset: 0x00021993
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x000229A0 File Offset: 0x000219A0
		[FIXField("641", EFieldOption.Optional)]
		public double LastForwardPoints2
		{
			get
			{
				return this.GetDoubleValue(641);
			}
			set
			{
				this.SetDoubleValue(641, value);
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x000229AE File Offset: 0x000219AE
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x000229BB File Offset: 0x000219BB
		[FIXField("442", EFieldOption.Optional)]
		public char MultiLegReportingType
		{
			get
			{
				return this.GetCharValue(442);
			}
			set
			{
				this.SetCharValue(442, value);
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x000229C9 File Offset: 0x000219C9
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x000229D6 File Offset: 0x000219D6
		[FIXField("480", EFieldOption.Optional)]
		public char CancellationRights
		{
			get
			{
				return this.GetCharValue(480);
			}
			set
			{
				this.SetCharValue(480, value);
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x000229E4 File Offset: 0x000219E4
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x000229F1 File Offset: 0x000219F1
		[FIXField("481", EFieldOption.Optional)]
		public char MoneyLaunderingStatus
		{
			get
			{
				return this.GetCharValue(481);
			}
			set
			{
				this.SetCharValue(481, value);
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x000229FF File Offset: 0x000219FF
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x00022A0C File Offset: 0x00021A0C
		[FIXField("513", EFieldOption.Optional)]
		public string RegistID
		{
			get
			{
				return this.GetStringValue(513);
			}
			set
			{
				this.SetStringValue(513, value);
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x00022A1A File Offset: 0x00021A1A
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x00022A27 File Offset: 0x00021A27
		[FIXField("494", EFieldOption.Optional)]
		public string Designation
		{
			get
			{
				return this.GetStringValue(494);
			}
			set
			{
				this.SetStringValue(494, value);
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x00022A35 File Offset: 0x00021A35
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x00022A42 File Offset: 0x00021A42
		[FIXField("483", EFieldOption.Optional)]
		public DateTime TransBkdTime
		{
			get
			{
				return this.GetDateTimeValue(483);
			}
			set
			{
				this.SetDateTimeValue(483, value);
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x00022A50 File Offset: 0x00021A50
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00022A5D File Offset: 0x00021A5D
		[FIXField("515", EFieldOption.Optional)]
		public DateTime ExecValuationPoint
		{
			get
			{
				return this.GetDateTimeValue(515);
			}
			set
			{
				this.SetDateTimeValue(515, value);
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x00022A6B File Offset: 0x00021A6B
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x00022A78 File Offset: 0x00021A78
		[FIXField("484", EFieldOption.Optional)]
		public char ExecPriceType
		{
			get
			{
				return this.GetCharValue(484);
			}
			set
			{
				this.SetCharValue(484, value);
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00022A86 File Offset: 0x00021A86
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00022A93 File Offset: 0x00021A93
		[FIXField("485", EFieldOption.Optional)]
		public double ExecPriceAdjustment
		{
			get
			{
				return this.GetDoubleValue(485);
			}
			set
			{
				this.SetDoubleValue(485, value);
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x00022AA1 File Offset: 0x00021AA1
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00022AAE File Offset: 0x00021AAE
		[FIXField("638", EFieldOption.Optional)]
		public int PriorityIndicator
		{
			get
			{
				return this.GetIntValue(638);
			}
			set
			{
				this.SetIntValue(638, value);
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00022ABC File Offset: 0x00021ABC
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x00022AC9 File Offset: 0x00021AC9
		[FIXField("639", EFieldOption.Optional)]
		public double PriceImprovement
		{
			get
			{
				return this.GetDoubleValue(639);
			}
			set
			{
				this.SetDoubleValue(639, value);
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x00022AD7 File Offset: 0x00021AD7
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00022AE4 File Offset: 0x00021AE4
		[FIXField("851", EFieldOption.Optional)]
		public int LastLiquidityInd
		{
			get
			{
				return this.GetIntValue(851);
			}
			set
			{
				this.SetIntValue(851, value);
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00022AF2 File Offset: 0x00021AF2
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x00022AFF File Offset: 0x00021AFF
		[FIXField("518", EFieldOption.Optional)]
		public int NoContAmts
		{
			get
			{
				return this.GetIntValue(518);
			}
			set
			{
				this.SetIntValue(518, value);
			}
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00022B0D File Offset: 0x00021B0D
		public FIXContAmtsGroup GetContAmtsGroup(int i)
		{
			if (i < this.NoContAmts)
			{
				return (FIXContAmtsGroup)this.fContAmtsGroup[i];
			}
			return null;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00022B2B File Offset: 0x00021B2B
		public void AddGroup(FIXContAmtsGroup group)
		{
			this.fContAmtsGroup.Add(group);
			this.NoContAmts++;
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x00022B48 File Offset: 0x00021B48
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x00022B55 File Offset: 0x00021B55
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

		// Token: 0x06002061 RID: 8289 RVA: 0x00022B63 File Offset: 0x00021B63
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00022B81 File Offset: 0x00021B81
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x00022B9E File Offset: 0x00021B9E
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x00022BAB File Offset: 0x00021BAB
		[FIXField("797", EFieldOption.Optional)]
		public bool CopyMsgIndicator
		{
			get
			{
				return this.GetBoolValue(797);
			}
			set
			{
				this.SetBoolValue(797, value);
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x00022BB9 File Offset: 0x00021BB9
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x00022BC6 File Offset: 0x00021BC6
		[FIXField("136", EFieldOption.Optional)]
		public int NoMiscFees
		{
			get
			{
				return this.GetIntValue(136);
			}
			set
			{
				this.SetIntValue(136, value);
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00022BD4 File Offset: 0x00021BD4
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00022BF2 File Offset: 0x00021BF2
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00022C0F File Offset: 0x00021C0F
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00022C19 File Offset: 0x00021C19
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

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x00022C24 File Offset: 0x00021C24
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x00022C2E File Offset: 0x00021C2E
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

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00022C39 File Offset: 0x00021C39
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x00022C43 File Offset: 0x00021C43
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

		// Token: 0x0600206F RID: 8303 RVA: 0x00022C50 File Offset: 0x00021C50
		public FIXExecutionReport()
		{
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00022CDC File Offset: 0x00021CDC
		public FIXExecutionReport(string OrderID, string ExecID, char ExecType, char OrdStatus, char Side, double LeavesQty, double CumQty, double AvgPx)
		{
			this.OrderID = OrderID;
			this.ExecID = ExecID;
			this.ExecType = ExecType;
			this.OrdStatus = OrdStatus;
			this.Side = Side;
			this.LeavesQty = LeavesQty;
			this.CumQty = CumQty;
			this.AvgPx = AvgPx;
		}

		// Token: 0x040002FC RID: 764
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002FD RID: 765
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002FE RID: 766
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040002FF RID: 767
		private ArrayList fContraBrokersGroup = new ArrayList();

		// Token: 0x04000300 RID: 768
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000301 RID: 769
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000302 RID: 770
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000303 RID: 771
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000304 RID: 772
		private ArrayList fContAmtsGroup = new ArrayList();

		// Token: 0x04000305 RID: 773
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000306 RID: 774
		private ArrayList fMiscFeesGroup = new ArrayList();
	}
}
