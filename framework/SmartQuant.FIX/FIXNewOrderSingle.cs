using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000033 RID: 51
	public class FIXNewOrderSingle : FIXMessage
	{
		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0000D72A File Offset: 0x0000C72A
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0000D737 File Offset: 0x0000C737
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0000D745 File Offset: 0x0000C745
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0000D74F File Offset: 0x0000C74F
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0000D75A File Offset: 0x0000C75A
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0000D764 File Offset: 0x0000C764
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0000D76F File Offset: 0x0000C76F
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0000D779 File Offset: 0x0000C779
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0000D784 File Offset: 0x0000C784
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0000D78E File Offset: 0x0000C78E
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0000D799 File Offset: 0x0000C799
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x0000D7A3 File Offset: 0x0000C7A3
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0000D7AE File Offset: 0x0000C7AE
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x0000D7BB File Offset: 0x0000C7BB
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0000D7C9 File Offset: 0x0000C7C9
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x0000D7D3 File Offset: 0x0000C7D3
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

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0000D7DE File Offset: 0x0000C7DE
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x0000D7E8 File Offset: 0x0000C7E8
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0000D7F3 File Offset: 0x0000C7F3
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0000D7FD File Offset: 0x0000C7FD
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

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0000D808 File Offset: 0x0000C808
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x0000D812 File Offset: 0x0000C812
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0000D81D File Offset: 0x0000C81D
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x0000D82A File Offset: 0x0000C82A
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0000D838 File Offset: 0x0000C838
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x0000D842 File Offset: 0x0000C842
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0000D84D File Offset: 0x0000C84D
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0000D856 File Offset: 0x0000C856
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0000D860 File Offset: 0x0000C860
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0000D86A File Offset: 0x0000C86A
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

		// Token: 0x06000ADC RID: 2780 RVA: 0x0000D875 File Offset: 0x0000C875
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0000D888 File Offset: 0x0000C888
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0000D897 File Offset: 0x0000C897
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0000D8A4 File Offset: 0x0000C8A4
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0000D8B2 File Offset: 0x0000C8B2
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0000D8BF File Offset: 0x0000C8BF
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0000D8CD File Offset: 0x0000C8CD
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0000D8D7 File Offset: 0x0000C8D7
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0000D8E2 File Offset: 0x0000C8E2
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x0000D8EC File Offset: 0x0000C8EC
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0000D8F7 File Offset: 0x0000C8F7
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x0000D901 File Offset: 0x0000C901
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0000D90C File Offset: 0x0000C90C
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0000D916 File Offset: 0x0000C916
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0000D921 File Offset: 0x0000C921
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x0000D92E File Offset: 0x0000C92E
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0000D93C File Offset: 0x0000C93C
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0000D949 File Offset: 0x0000C949
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0000D957 File Offset: 0x0000C957
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x0000D964 File Offset: 0x0000C964
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0000D972 File Offset: 0x0000C972
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0000D97F File Offset: 0x0000C97F
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0000D98D File Offset: 0x0000C98D
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x0000D99A File Offset: 0x0000C99A
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

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0000D9A8 File Offset: 0x0000C9A8
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0000D9C6 File Offset: 0x0000C9C6
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0000D9E3 File Offset: 0x0000C9E3
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x0000D9F0 File Offset: 0x0000C9F0
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0000D9FE File Offset: 0x0000C9FE
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0000DA08 File Offset: 0x0000CA08
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0000DA13 File Offset: 0x0000CA13
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x0000DA20 File Offset: 0x0000CA20
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0000DA2E File Offset: 0x0000CA2E
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x0000DA3B File Offset: 0x0000CA3B
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0000DA49 File Offset: 0x0000CA49
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x0000DA56 File Offset: 0x0000CA56
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

		// Token: 0x06000B00 RID: 2816 RVA: 0x0000DA64 File Offset: 0x0000CA64
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0000DA82 File Offset: 0x0000CA82
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0000DA9F File Offset: 0x0000CA9F
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x0000DAAC File Offset: 0x0000CAAC
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0000DABA File Offset: 0x0000CABA
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x0000DAC4 File Offset: 0x0000CAC4
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0000DACF File Offset: 0x0000CACF
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x0000DAD8 File Offset: 0x0000CAD8
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0000DAE2 File Offset: 0x0000CAE2
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0000DAEF File Offset: 0x0000CAEF
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0000DAFD File Offset: 0x0000CAFD
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x0000DB0A File Offset: 0x0000CB0A
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0000DB18 File Offset: 0x0000CB18
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x0000DB25 File Offset: 0x0000CB25
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0000DB33 File Offset: 0x0000CB33
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x0000DB40 File Offset: 0x0000CB40
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0000DB4E File Offset: 0x0000CB4E
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0000DB5B File Offset: 0x0000CB5B
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0000DB69 File Offset: 0x0000CB69
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0000DB73 File Offset: 0x0000CB73
		[FIXField("70", EFieldOption.Optional)]
		public string AllocID
		{
			get
			{
				return this.GetStringValue(70);
			}
			set
			{
				this.SetStringValue(70, value);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0000DB7E File Offset: 0x0000CB7E
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0000DB88 File Offset: 0x0000CB88
		[FIXField("78", EFieldOption.Optional)]
		public int NoAllocs
		{
			get
			{
				return this.GetIntValue(78);
			}
			set
			{
				this.SetIntValue(78, value);
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0000DB93 File Offset: 0x0000CB93
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0000DBB1 File Offset: 0x0000CBB1
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0000DBCE File Offset: 0x0000CBCE
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0000DBD8 File Offset: 0x0000CBD8
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

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0000DBE3 File Offset: 0x0000CBE3
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x0000DBED File Offset: 0x0000CBED
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0000DBF8 File Offset: 0x0000CBF8
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0000DC05 File Offset: 0x0000CC05
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0000DC13 File Offset: 0x0000CC13
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x0000DC20 File Offset: 0x0000CC20
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0000DC2E File Offset: 0x0000CC2E
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0000DC38 File Offset: 0x0000CC38
		[FIXField("21", EFieldOption.Optional)]
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0000DC43 File Offset: 0x0000CC43
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x0000DC4D File Offset: 0x0000CC4D
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0000DC58 File Offset: 0x0000CC58
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x0000DC62 File Offset: 0x0000CC62
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0000DC6D File Offset: 0x0000CC6D
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x0000DC77 File Offset: 0x0000CC77
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0000DC82 File Offset: 0x0000CC82
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x0000DC8C File Offset: 0x0000CC8C
		[FIXField("100", EFieldOption.Optional)]
		public string ExDestination
		{
			get
			{
				return this.GetStringValue(100);
			}
			set
			{
				this.SetStringValue(100, value);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0000DC97 File Offset: 0x0000CC97
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x0000DCA4 File Offset: 0x0000CCA4
		[FIXField("386", EFieldOption.Optional)]
		public int NoTradingSessions
		{
			get
			{
				return this.GetIntValue(386);
			}
			set
			{
				this.SetIntValue(386, value);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0000DCB2 File Offset: 0x0000CCB2
		public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
		{
			if (i < this.NoTradingSessions)
			{
				return (FIXTradingSessionsGroup)this.fTradingSessionsGroup[i];
			}
			return null;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0000DCD0 File Offset: 0x0000CCD0
		public void AddGroup(FIXTradingSessionsGroup group)
		{
			this.fTradingSessionsGroup.Add(group);
			this.NoTradingSessions++;
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0000DCED File Offset: 0x0000CCED
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x0000DCF7 File Offset: 0x0000CCF7
		[FIXField("81", EFieldOption.Optional)]
		public char ProcessCode
		{
			get
			{
				return this.GetCharValue(81);
			}
			set
			{
				this.SetCharValue(81, value);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0000DD02 File Offset: 0x0000CD02
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0000DD0C File Offset: 0x0000CD0C
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0000DD17 File Offset: 0x0000CD17
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0000DD21 File Offset: 0x0000CD21
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0000DD2C File Offset: 0x0000CD2C
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0000DD36 File Offset: 0x0000CD36
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0000DD41 File Offset: 0x0000CD41
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0000DD4B File Offset: 0x0000CD4B
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000DD56 File Offset: 0x0000CD56
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x0000DD63 File Offset: 0x0000CD63
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

		// Token: 0x06000B3A RID: 2874 RVA: 0x0000DD71 File Offset: 0x0000CD71
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0000DD8F File Offset: 0x0000CD8F
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0000DDAC File Offset: 0x0000CDAC
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x0000DDB9 File Offset: 0x0000CDB9
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0000DDC7 File Offset: 0x0000CDC7
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x0000DDD4 File Offset: 0x0000CDD4
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0000DDE2 File Offset: 0x0000CDE2
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x0000DDEF File Offset: 0x0000CDEF
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0000DDFD File Offset: 0x0000CDFD
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0000DE0A File Offset: 0x0000CE0A
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0000DE18 File Offset: 0x0000CE18
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0000DE25 File Offset: 0x0000CE25
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0000DE33 File Offset: 0x0000CE33
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x0000DE40 File Offset: 0x0000CE40
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0000DE4E File Offset: 0x0000CE4E
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x0000DE5B File Offset: 0x0000CE5B
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0000DE69 File Offset: 0x0000CE69
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x0000DE76 File Offset: 0x0000CE76
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0000DE84 File Offset: 0x0000CE84
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x0000DE91 File Offset: 0x0000CE91
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0000DE9F File Offset: 0x0000CE9F
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x0000DEAC File Offset: 0x0000CEAC
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

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0000DEBA File Offset: 0x0000CEBA
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x0000DEC7 File Offset: 0x0000CEC7
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0000DED5 File Offset: 0x0000CED5
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x0000DEE2 File Offset: 0x0000CEE2
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

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0000DEF0 File Offset: 0x0000CEF0
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0000DEFD File Offset: 0x0000CEFD
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0000DF0B File Offset: 0x0000CF0B
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x0000DF18 File Offset: 0x0000CF18
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0000DF26 File Offset: 0x0000CF26
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0000DF33 File Offset: 0x0000CF33
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0000DF41 File Offset: 0x0000CF41
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0000DF4E File Offset: 0x0000CF4E
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0000DF5C File Offset: 0x0000CF5C
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0000DF69 File Offset: 0x0000CF69
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0000DF77 File Offset: 0x0000CF77
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0000DF84 File Offset: 0x0000CF84
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

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0000DF92 File Offset: 0x0000CF92
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0000DF9F File Offset: 0x0000CF9F
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0000DFAD File Offset: 0x0000CFAD
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0000DFBA File Offset: 0x0000CFBA
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0000DFC8 File Offset: 0x0000CFC8
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0000DFD5 File Offset: 0x0000CFD5
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0000DFE3 File Offset: 0x0000CFE3
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0000DFF0 File Offset: 0x0000CFF0
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0000DFFE File Offset: 0x0000CFFE
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0000E00B File Offset: 0x0000D00B
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0000E019 File Offset: 0x0000D019
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0000E026 File Offset: 0x0000D026
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0000E034 File Offset: 0x0000D034
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0000E03E File Offset: 0x0000D03E
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

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0000E049 File Offset: 0x0000D049
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x0000E056 File Offset: 0x0000D056
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0000E064 File Offset: 0x0000D064
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0000E071 File Offset: 0x0000D071
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0000E07F File Offset: 0x0000D07F
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x0000E089 File Offset: 0x0000D089
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0000E094 File Offset: 0x0000D094
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x0000E0A1 File Offset: 0x0000D0A1
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

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0000E0AF File Offset: 0x0000D0AF
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0000E0BC File Offset: 0x0000D0BC
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0000E0CA File Offset: 0x0000D0CA
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0000E0D7 File Offset: 0x0000D0D7
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0000E0E5 File Offset: 0x0000D0E5
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0000E0F2 File Offset: 0x0000D0F2
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0000E100 File Offset: 0x0000D100
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0000E10D File Offset: 0x0000D10D
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0000E11B File Offset: 0x0000D11B
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0000E128 File Offset: 0x0000D128
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0000E136 File Offset: 0x0000D136
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0000E143 File Offset: 0x0000D143
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

		// Token: 0x06000B82 RID: 2946 RVA: 0x0000E151 File Offset: 0x0000D151
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0000E16F File Offset: 0x0000D16F
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0000E18C File Offset: 0x0000D18C
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0000E199 File Offset: 0x0000D199
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

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0000E1A7 File Offset: 0x0000D1A7
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0000E1B4 File Offset: 0x0000D1B4
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0000E1C2 File Offset: 0x0000D1C2
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0000E1CF File Offset: 0x0000D1CF
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

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0000E1DD File Offset: 0x0000D1DD
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0000E1EA File Offset: 0x0000D1EA
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

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0000E1F8 File Offset: 0x0000D1F8
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0000E205 File Offset: 0x0000D205
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

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0000E213 File Offset: 0x0000D213
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0000E220 File Offset: 0x0000D220
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

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0000E22E File Offset: 0x0000D22E
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0000E23B File Offset: 0x0000D23B
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0000E249 File Offset: 0x0000D249
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0000E256 File Offset: 0x0000D256
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0000E264 File Offset: 0x0000D264
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0000E271 File Offset: 0x0000D271
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0000E27F File Offset: 0x0000D27F
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x0000E28C File Offset: 0x0000D28C
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0000E29A File Offset: 0x0000D29A
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0000E2A7 File Offset: 0x0000D2A7
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0000E2B5 File Offset: 0x0000D2B5
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x0000E2C2 File Offset: 0x0000D2C2
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

		// Token: 0x06000B9C RID: 2972 RVA: 0x0000E2D0 File Offset: 0x0000D2D0
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0000E2EE File Offset: 0x0000D2EE
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0000E30B File Offset: 0x0000D30B
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0000E318 File Offset: 0x0000D318
		[FIXField("140", EFieldOption.Optional)]
		public double PrevClosePx
		{
			get
			{
				return this.GetDoubleValue(140);
			}
			set
			{
				this.SetDoubleValue(140, value);
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0000E326 File Offset: 0x0000D326
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0000E330 File Offset: 0x0000D330
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0000E33B File Offset: 0x0000D33B
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0000E345 File Offset: 0x0000D345
		[FIXField("114", EFieldOption.Optional)]
		public bool LocateReqd
		{
			get
			{
				return this.GetBoolValue(114);
			}
			set
			{
				this.SetBoolValue(114, value);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0000E350 File Offset: 0x0000D350
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0000E35A File Offset: 0x0000D35A
		[FIXField("60", EFieldOption.Required)]
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0000E365 File Offset: 0x0000D365
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0000E372 File Offset: 0x0000D372
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

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0000E380 File Offset: 0x0000D380
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000E39E File Offset: 0x0000D39E
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0000E3BB File Offset: 0x0000D3BB
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0000E3C8 File Offset: 0x0000D3C8
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0000E3D6 File Offset: 0x0000D3D6
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0000E3E0 File Offset: 0x0000D3E0
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0000E3EB File Offset: 0x0000D3EB
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0000E3F8 File Offset: 0x0000D3F8
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0000E406 File Offset: 0x0000D406
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0000E413 File Offset: 0x0000D413
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0000E421 File Offset: 0x0000D421
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0000E42E File Offset: 0x0000D42E
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0000E43C File Offset: 0x0000D43C
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0000E449 File Offset: 0x0000D449
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

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0000E457 File Offset: 0x0000D457
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0000E461 File Offset: 0x0000D461
		[FIXField("40", EFieldOption.Required)]
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0000E46C File Offset: 0x0000D46C
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0000E479 File Offset: 0x0000D479
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0000E487 File Offset: 0x0000D487
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0000E491 File Offset: 0x0000D491
		[FIXField("44", EFieldOption.Optional)]
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

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0000E49C File Offset: 0x0000D49C
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x0000E4A6 File Offset: 0x0000D4A6
		[FIXField("99", EFieldOption.Optional)]
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0000E4B1 File Offset: 0x0000D4B1
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x0000E4BE File Offset: 0x0000D4BE
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

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0000E4CC File Offset: 0x0000D4CC
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0000E4D9 File Offset: 0x0000D4D9
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

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0000E4E7 File Offset: 0x0000D4E7
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0000E4F4 File Offset: 0x0000D4F4
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0000E502 File Offset: 0x0000D502
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0000E50F File Offset: 0x0000D50F
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0000E51D File Offset: 0x0000D51D
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0000E52A File Offset: 0x0000D52A
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0000E538 File Offset: 0x0000D538
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0000E545 File Offset: 0x0000D545
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0000E553 File Offset: 0x0000D553
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0000E560 File Offset: 0x0000D560
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0000E56E File Offset: 0x0000D56E
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0000E57B File Offset: 0x0000D57B
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0000E589 File Offset: 0x0000D589
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0000E596 File Offset: 0x0000D596
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0000E5A4 File Offset: 0x0000D5A4
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0000E5B1 File Offset: 0x0000D5B1
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0000E5BF File Offset: 0x0000D5BF
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0000E5CC File Offset: 0x0000D5CC
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

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0000E5DA File Offset: 0x0000D5DA
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0000E5E7 File Offset: 0x0000D5E7
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

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0000E5F5 File Offset: 0x0000D5F5
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0000E602 File Offset: 0x0000D602
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

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0000E610 File Offset: 0x0000D610
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0000E61D File Offset: 0x0000D61D
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0000E62B File Offset: 0x0000D62B
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0000E635 File Offset: 0x0000D635
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0000E640 File Offset: 0x0000D640
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0000E64D File Offset: 0x0000D64D
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0000E65B File Offset: 0x0000D65B
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0000E668 File Offset: 0x0000D668
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0000E676 File Offset: 0x0000D676
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x0000E680 File Offset: 0x0000D680
		[FIXField("23", EFieldOption.Optional)]
		public string IOIID
		{
			get
			{
				return this.GetStringValue(23);
			}
			set
			{
				this.SetStringValue(23, value);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0000E68B File Offset: 0x0000D68B
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0000E695 File Offset: 0x0000D695
		[FIXField("117", EFieldOption.Optional)]
		public string QuoteID
		{
			get
			{
				return this.GetStringValue(117);
			}
			set
			{
				this.SetStringValue(117, value);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0000E6A0 File Offset: 0x0000D6A0
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0000E6AA File Offset: 0x0000D6AA
		[FIXField("59", EFieldOption.Optional)]
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

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0000E6B5 File Offset: 0x0000D6B5
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0000E6C2 File Offset: 0x0000D6C2
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

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0000E6D0 File Offset: 0x0000D6D0
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0000E6DD File Offset: 0x0000D6DD
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

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0000E6EB File Offset: 0x0000D6EB
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0000E6F5 File Offset: 0x0000D6F5
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0000E700 File Offset: 0x0000D700
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0000E70D File Offset: 0x0000D70D
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0000E71B File Offset: 0x0000D71B
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0000E725 File Offset: 0x0000D725
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0000E730 File Offset: 0x0000D730
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0000E73A File Offset: 0x0000D73A
		[FIXField("13", EFieldOption.Optional)]
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

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0000E745 File Offset: 0x0000D745
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0000E752 File Offset: 0x0000D752
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0000E760 File Offset: 0x0000D760
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x0000E76D File Offset: 0x0000D76D
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

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0000E77B File Offset: 0x0000D77B
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0000E785 File Offset: 0x0000D785
		[FIXField("47", EFieldOption.Optional)]
		public char Rule80A
		{
			get
			{
				return this.GetCharValue(47);
			}
			set
			{
				this.SetCharValue(47, value);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0000E790 File Offset: 0x0000D790
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000E79D File Offset: 0x0000D79D
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0000E7AB File Offset: 0x0000D7AB
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x0000E7B8 File Offset: 0x0000D7B8
		[FIXField("204", EFieldOption.Optional)]
		public int CustomerOrFirm
		{
			get
			{
				return this.GetIntValue(204);
			}
			set
			{
				this.SetIntValue(204, value);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0000E7C6 File Offset: 0x0000D7C6
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x0000E7D3 File Offset: 0x0000D7D3
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0000E7E1 File Offset: 0x0000D7E1
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x0000E7EE File Offset: 0x0000D7EE
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0000E7FC File Offset: 0x0000D7FC
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0000E806 File Offset: 0x0000D806
		[FIXField("121", EFieldOption.Optional)]
		public bool ForexReq
		{
			get
			{
				return this.GetBoolValue(121);
			}
			set
			{
				this.SetBoolValue(121, value);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0000E811 File Offset: 0x0000D811
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x0000E81B File Offset: 0x0000D81B
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

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0000E826 File Offset: 0x0000D826
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x0000E833 File Offset: 0x0000D833
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0000E841 File Offset: 0x0000D841
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0000E84B File Offset: 0x0000D84B
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0000E856 File Offset: 0x0000D856
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0000E863 File Offset: 0x0000D863
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

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0000E871 File Offset: 0x0000D871
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0000E87E File Offset: 0x0000D87E
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0000E88C File Offset: 0x0000D88C
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0000E899 File Offset: 0x0000D899
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0000E8A7 File Offset: 0x0000D8A7
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0000E8B4 File Offset: 0x0000D8B4
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

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0000E8C2 File Offset: 0x0000D8C2
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0000E8CF File Offset: 0x0000D8CF
		[FIXField("640", EFieldOption.Optional)]
		public double Price2
		{
			get
			{
				return this.GetDoubleValue(640);
			}
			set
			{
				this.SetDoubleValue(640, value);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0000E8DD File Offset: 0x0000D8DD
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0000E8E7 File Offset: 0x0000D8E7
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

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0000E8F2 File Offset: 0x0000D8F2
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0000E8FF File Offset: 0x0000D8FF
		[FIXField("203", EFieldOption.Optional)]
		public int CoveredOrUncovered
		{
			get
			{
				return this.GetIntValue(203);
			}
			set
			{
				this.SetIntValue(203, value);
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0000E90D File Offset: 0x0000D90D
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0000E91A File Offset: 0x0000D91A
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0000E928 File Offset: 0x0000D928
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0000E935 File Offset: 0x0000D935
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0000E943 File Offset: 0x0000D943
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0000E950 File Offset: 0x0000D950
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0000E95E File Offset: 0x0000D95E
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0000E96B File Offset: 0x0000D96B
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0000E979 File Offset: 0x0000D979
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0000E986 File Offset: 0x0000D986
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0000E994 File Offset: 0x0000D994
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0000E9A1 File Offset: 0x0000D9A1
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

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0000E9AF File Offset: 0x0000D9AF
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0000E9BC File Offset: 0x0000D9BC
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0000E9CA File Offset: 0x0000D9CA
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x0000E9D7 File Offset: 0x0000D9D7
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

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0000E9E5 File Offset: 0x0000D9E5
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0000E9F2 File Offset: 0x0000D9F2
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

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0000EA00 File Offset: 0x0000DA00
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0000EA0D File Offset: 0x0000DA0D
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

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0000EA1B File Offset: 0x0000DA1B
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0000EA28 File Offset: 0x0000DA28
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

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0000EA36 File Offset: 0x0000DA36
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0000EA43 File Offset: 0x0000DA43
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

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0000EA51 File Offset: 0x0000DA51
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x0000EA5E File Offset: 0x0000DA5E
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0000EA6C File Offset: 0x0000DA6C
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0000EA79 File Offset: 0x0000DA79
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

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0000EA87 File Offset: 0x0000DA87
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0000EA94 File Offset: 0x0000DA94
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0000EAA2 File Offset: 0x0000DAA2
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0000EAAF File Offset: 0x0000DAAF
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0000EABD File Offset: 0x0000DABD
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0000EACA File Offset: 0x0000DACA
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0000EAD8 File Offset: 0x0000DAD8
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0000EAE5 File Offset: 0x0000DAE5
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0000EAF3 File Offset: 0x0000DAF3
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x0000EB00 File Offset: 0x0000DB00
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0000EB0E File Offset: 0x0000DB0E
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0000EB1B File Offset: 0x0000DB1B
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

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0000EB29 File Offset: 0x0000DB29
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x0000EB36 File Offset: 0x0000DB36
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0000EB44 File Offset: 0x0000DB44
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x0000EB51 File Offset: 0x0000DB51
		[FIXField("440", EFieldOption.Optional)]
		public string ClearingAccount
		{
			get
			{
				return this.GetStringValue(440);
			}
			set
			{
				this.SetStringValue(440, value);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0000EB5F File Offset: 0x0000DB5F
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x0000EB6C File Offset: 0x0000DB6C
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0000EB7A File Offset: 0x0000DB7A
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x0000EB87 File Offset: 0x0000DB87
		public string OCAGroup
		{
			get
			{
				return this.GetStringValue(10500);
			}
			set
			{
				this.SetStringValue(10500, value);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0000EB95 File Offset: 0x0000DB95
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x0000EBA2 File Offset: 0x0000DBA2
		public bool Hidden
		{
			get
			{
				return this.GetBoolValue(10700);
			}
			set
			{
				this.SetBoolValue(10700, value);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0000EBB0 File Offset: 0x0000DBB0
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x0000EBBD File Offset: 0x0000DBBD
		public string FaMethod
		{
			get
			{
				return this.GetStringValue(10710);
			}
			set
			{
				this.SetStringValue(10710, value);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0000EBCB File Offset: 0x0000DBCB
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x0000EBD8 File Offset: 0x0000DBD8
		public string FaGroup
		{
			get
			{
				return this.GetStringValue(10711);
			}
			set
			{
				this.SetStringValue(10711, value);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0000EBE6 File Offset: 0x0000DBE6
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0000EBF3 File Offset: 0x0000DBF3
		public string FaProfile
		{
			get
			{
				return this.GetStringValue(10712);
			}
			set
			{
				this.SetStringValue(10712, value);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0000EC01 File Offset: 0x0000DC01
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0000EC0E File Offset: 0x0000DC0E
		public double FaPercentage
		{
			get
			{
				return this.GetDoubleValue(10713);
			}
			set
			{
				this.SetDoubleValue(10713, value);
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0000EC1C File Offset: 0x0000DC1C
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0000EC26 File Offset: 0x0000DC26
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0000EC31 File Offset: 0x0000DC31
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x0000EC3B File Offset: 0x0000DC3B
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0000EC46 File Offset: 0x0000DC46
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000EC50 File Offset: 0x0000DC50
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

		// Token: 0x06000C56 RID: 3158 RVA: 0x0000EC5C File Offset: 0x0000DC5C
		public FIXNewOrderSingle()
		{
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0000ECD4 File Offset: 0x0000DCD4
		public FIXNewOrderSingle(string ClOrdID, char Side, DateTime TransactTime, char OrdType)
		{
			this.ClOrdID = ClOrdID;
			this.Side = Side;
			this.TransactTime = TransactTime;
			this.OrdType = OrdType;
		}

		// Token: 0x0400008F RID: 143
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000090 RID: 144
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000091 RID: 145
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000092 RID: 146
		private ArrayList fAllocsGroup = new ArrayList();

		// Token: 0x04000093 RID: 147
		private ArrayList fTradingSessionsGroup = new ArrayList();

		// Token: 0x04000094 RID: 148
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000095 RID: 149
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000096 RID: 150
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000097 RID: 151
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
