using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000026 RID: 38
	public class FIXCollateralRequest : FIXMessage
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0000AA9B File Offset: 0x00009A9B
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000AAAD File Offset: 0x00009AAD
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

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0000AABB File Offset: 0x00009ABB
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0000AACA File Offset: 0x00009ACA
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0000AAD5 File Offset: 0x00009AD5
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0000AAE4 File Offset: 0x00009AE4
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

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0000AAEF File Offset: 0x00009AEF
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0000AAFE File Offset: 0x00009AFE
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

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0000AB09 File Offset: 0x00009B09
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0000AB18 File Offset: 0x00009B18
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

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0000AB23 File Offset: 0x00009B23
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x0000AB32 File Offset: 0x00009B32
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0000AB3D File Offset: 0x00009B3D
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x0000AB4F File Offset: 0x00009B4F
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0000AB5D File Offset: 0x00009B5D
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0000AB6C File Offset: 0x00009B6C
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0000AB77 File Offset: 0x00009B77
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x0000AB86 File Offset: 0x00009B86
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0000AB91 File Offset: 0x00009B91
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x0000ABA0 File Offset: 0x00009BA0
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0000ABAB File Offset: 0x00009BAB
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x0000ABBA File Offset: 0x00009BBA
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0000ABC5 File Offset: 0x00009BC5
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x0000ABD7 File Offset: 0x00009BD7
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0000ABE5 File Offset: 0x00009BE5
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0000ABF4 File Offset: 0x00009BF4
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0000ABFF File Offset: 0x00009BFF
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0000AC0D File Offset: 0x00009C0D
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0000AC17 File Offset: 0x00009C17
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0000AC26 File Offset: 0x00009C26
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

		// Token: 0x06000830 RID: 2096 RVA: 0x0000AC31 File Offset: 0x00009C31
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0000AC44 File Offset: 0x00009C44
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0000AC53 File Offset: 0x00009C53
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x0000AC65 File Offset: 0x00009C65
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0000AC73 File Offset: 0x00009C73
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x0000AC85 File Offset: 0x00009C85
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0000AC93 File Offset: 0x00009C93
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0000ACA2 File Offset: 0x00009CA2
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0000ACAD File Offset: 0x00009CAD
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0000ACBC File Offset: 0x00009CBC
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

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0000ACC7 File Offset: 0x00009CC7
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0000ACD6 File Offset: 0x00009CD6
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0000ACE1 File Offset: 0x00009CE1
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0000ACF0 File Offset: 0x00009CF0
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0000ACFB File Offset: 0x00009CFB
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x0000AD0D File Offset: 0x00009D0D
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x0000AD1B File Offset: 0x00009D1B
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x0000AD2D File Offset: 0x00009D2D
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0000AD3B File Offset: 0x00009D3B
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x0000AD4D File Offset: 0x00009D4D
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x0000AD5B File Offset: 0x00009D5B
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0000AD6D File Offset: 0x00009D6D
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0000AD7B File Offset: 0x00009D7B
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0000AD8D File Offset: 0x00009D8D
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

		// Token: 0x06000848 RID: 2120 RVA: 0x0000AD9B File Offset: 0x00009D9B
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0000ADB9 File Offset: 0x00009DB9
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0000ADD6 File Offset: 0x00009DD6
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0000ADE8 File Offset: 0x00009DE8
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0000ADF6 File Offset: 0x00009DF6
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x0000AE08 File Offset: 0x00009E08
		[FIXField("894", EFieldOption.Required)]
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0000AE16 File Offset: 0x00009E16
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x0000AE28 File Offset: 0x00009E28
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0000AE36 File Offset: 0x00009E36
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x0000AE45 File Offset: 0x00009E45
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

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0000AE50 File Offset: 0x00009E50
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0000AE5F File Offset: 0x00009E5F
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

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0000AE6A File Offset: 0x00009E6A
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x0000AE7C File Offset: 0x00009E7C
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

		// Token: 0x06000856 RID: 2134 RVA: 0x0000AE8A File Offset: 0x00009E8A
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000AEA8 File Offset: 0x00009EA8
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0000AEC5 File Offset: 0x00009EC5
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x0000AED3 File Offset: 0x00009ED3
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

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0000AEDD File Offset: 0x00009EDD
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x0000AEEF File Offset: 0x00009EEF
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

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0000AEFD File Offset: 0x00009EFD
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x0000AF0C File Offset: 0x00009F0C
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0000AF17 File Offset: 0x00009F17
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x0000AF26 File Offset: 0x00009F26
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

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0000AF31 File Offset: 0x00009F31
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x0000AF43 File Offset: 0x00009F43
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0000AF51 File Offset: 0x00009F51
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x0000AF63 File Offset: 0x00009F63
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

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0000AF71 File Offset: 0x00009F71
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x0000AF80 File Offset: 0x00009F80
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

		// Token: 0x06000866 RID: 2150 RVA: 0x0000AF8B File Offset: 0x00009F8B
		public FIXExecsGroup GetExecsGroup(int i)
		{
			if (i < this.NoExecs)
			{
				return (FIXExecsGroup)this.fExecsGroup[i];
			}
			return null;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0000AFA9 File Offset: 0x00009FA9
		public void AddGroup(FIXExecsGroup group)
		{
			this.fExecsGroup.Add(group);
			this.NoExecs++;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0000AFC6 File Offset: 0x00009FC6
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x0000AFD8 File Offset: 0x00009FD8
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

		// Token: 0x0600086A RID: 2154 RVA: 0x0000AFE6 File Offset: 0x00009FE6
		public FIXTradesGroup GetTradesGroup(int i)
		{
			if (i < this.NoTrades)
			{
				return (FIXTradesGroup)this.fTradesGroup[i];
			}
			return null;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000B004 File Offset: 0x0000A004
		public void AddGroup(FIXTradesGroup group)
		{
			this.fTradesGroup.Add(group);
			this.NoTrades++;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0000B021 File Offset: 0x0000A021
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x0000B030 File Offset: 0x0000A030
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0000B03B File Offset: 0x0000A03B
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x0000B04A File Offset: 0x0000A04A
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

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0000B055 File Offset: 0x0000A055
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x0000B064 File Offset: 0x0000A064
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0000B06F File Offset: 0x0000A06F
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x0000B07E File Offset: 0x0000A07E
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0000B089 File Offset: 0x0000A089
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x0000B09B File Offset: 0x0000A09B
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

		// Token: 0x06000876 RID: 2166 RVA: 0x0000B0A9 File Offset: 0x0000A0A9
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0000B0C7 File Offset: 0x0000A0C7
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0000B0E4 File Offset: 0x0000A0E4
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x0000B0F6 File Offset: 0x0000A0F6
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0000B104 File Offset: 0x0000A104
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0000B116 File Offset: 0x0000A116
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000B124 File Offset: 0x0000A124
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0000B136 File Offset: 0x0000A136
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0000B144 File Offset: 0x0000A144
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x0000B156 File Offset: 0x0000A156
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0000B164 File Offset: 0x0000A164
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x0000B176 File Offset: 0x0000A176
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

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0000B184 File Offset: 0x0000A184
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x0000B196 File Offset: 0x0000A196
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

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0000B1A4 File Offset: 0x0000A1A4
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x0000B1B6 File Offset: 0x0000A1B6
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

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0000B1C4 File Offset: 0x0000A1C4
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x0000B1D6 File Offset: 0x0000A1D6
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

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0000B1E4 File Offset: 0x0000A1E4
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x0000B1F6 File Offset: 0x0000A1F6
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0000B204 File Offset: 0x0000A204
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x0000B216 File Offset: 0x0000A216
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

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0000B224 File Offset: 0x0000A224
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x0000B236 File Offset: 0x0000A236
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

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0000B244 File Offset: 0x0000A244
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x0000B256 File Offset: 0x0000A256
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0000B264 File Offset: 0x0000A264
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x0000B276 File Offset: 0x0000A276
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

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0000B284 File Offset: 0x0000A284
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0000B296 File Offset: 0x0000A296
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

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0000B2A4 File Offset: 0x0000A2A4
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0000B2B6 File Offset: 0x0000A2B6
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0000B2C4 File Offset: 0x0000A2C4
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0000B2D6 File Offset: 0x0000A2D6
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0000B2E4 File Offset: 0x0000A2E4
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x0000B2F6 File Offset: 0x0000A2F6
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

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0000B304 File Offset: 0x0000A304
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x0000B316 File Offset: 0x0000A316
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

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0000B324 File Offset: 0x0000A324
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x0000B336 File Offset: 0x0000A336
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

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0000B344 File Offset: 0x0000A344
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x0000B356 File Offset: 0x0000A356
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

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0000B364 File Offset: 0x0000A364
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0000B376 File Offset: 0x0000A376
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

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0000B384 File Offset: 0x0000A384
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0000B396 File Offset: 0x0000A396
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

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0000B3A4 File Offset: 0x0000A3A4
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0000B3B6 File Offset: 0x0000A3B6
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

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0000B3C4 File Offset: 0x0000A3C4
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0000B3D6 File Offset: 0x0000A3D6
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

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0000B3E4 File Offset: 0x0000A3E4
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0000B3F3 File Offset: 0x0000A3F3
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0000B3FE File Offset: 0x0000A3FE
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0000B410 File Offset: 0x0000A410
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

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000B41E File Offset: 0x0000A41E
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x0000B430 File Offset: 0x0000A430
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0000B43E File Offset: 0x0000A43E
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0000B44D File Offset: 0x0000A44D
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0000B458 File Offset: 0x0000A458
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x0000B46A File Offset: 0x0000A46A
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

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0000B478 File Offset: 0x0000A478
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0000B48A File Offset: 0x0000A48A
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

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0000B498 File Offset: 0x0000A498
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0000B4AA File Offset: 0x0000A4AA
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

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0000B4B8 File Offset: 0x0000A4B8
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x0000B4CA File Offset: 0x0000A4CA
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

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0000B4D8 File Offset: 0x0000A4D8
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0000B4EA File Offset: 0x0000A4EA
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

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0000B4F8 File Offset: 0x0000A4F8
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000B50A File Offset: 0x0000A50A
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

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0000B518 File Offset: 0x0000A518
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0000B52A File Offset: 0x0000A52A
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

		// Token: 0x060008BE RID: 2238 RVA: 0x0000B538 File Offset: 0x0000A538
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000B556 File Offset: 0x0000A556
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0000B573 File Offset: 0x0000A573
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0000B585 File Offset: 0x0000A585
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

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0000B593 File Offset: 0x0000A593
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0000B5A5 File Offset: 0x0000A5A5
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0000B5B3 File Offset: 0x0000A5B3
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0000B5C5 File Offset: 0x0000A5C5
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0000B5D3 File Offset: 0x0000A5D3
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0000B5E5 File Offset: 0x0000A5E5
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

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0000B5F3 File Offset: 0x0000A5F3
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0000B605 File Offset: 0x0000A605
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

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0000B613 File Offset: 0x0000A613
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0000B625 File Offset: 0x0000A625
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000B633 File Offset: 0x0000A633
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0000B645 File Offset: 0x0000A645
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0000B653 File Offset: 0x0000A653
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0000B665 File Offset: 0x0000A665
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

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0000B673 File Offset: 0x0000A673
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0000B685 File Offset: 0x0000A685
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

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0000B693 File Offset: 0x0000A693
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0000B6A5 File Offset: 0x0000A6A5
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

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0000B6B3 File Offset: 0x0000A6B3
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0000B6C5 File Offset: 0x0000A6C5
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

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0000B6D3 File Offset: 0x0000A6D3
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0000B6E2 File Offset: 0x0000A6E2
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

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0000B6ED File Offset: 0x0000A6ED
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0000B6FC File Offset: 0x0000A6FC
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

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0000B707 File Offset: 0x0000A707
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x0000B719 File Offset: 0x0000A719
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0000B727 File Offset: 0x0000A727
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0000B736 File Offset: 0x0000A736
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0000B741 File Offset: 0x0000A741
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0000B753 File Offset: 0x0000A753
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

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000B761 File Offset: 0x0000A761
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0000B77F File Offset: 0x0000A77F
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0000B79C File Offset: 0x0000A79C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x0000B7AE File Offset: 0x0000A7AE
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

		// Token: 0x060008E4 RID: 2276 RVA: 0x0000B7BC File Offset: 0x0000A7BC
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0000B7DA File Offset: 0x0000A7DA
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0000B7F7 File Offset: 0x0000A7F7
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x0000B809 File Offset: 0x0000A809
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0000B817 File Offset: 0x0000A817
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0000B829 File Offset: 0x0000A829
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0000B837 File Offset: 0x0000A837
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x0000B849 File Offset: 0x0000A849
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0000B857 File Offset: 0x0000A857
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0000B869 File Offset: 0x0000A869
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

		// Token: 0x060008EE RID: 2286 RVA: 0x0000B877 File Offset: 0x0000A877
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0000B895 File Offset: 0x0000A895
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0000B8B2 File Offset: 0x0000A8B2
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0000B8C1 File Offset: 0x0000A8C1
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0000B8CC File Offset: 0x0000A8CC
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0000B8DE File Offset: 0x0000A8DE
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

		// Token: 0x060008F4 RID: 2292 RVA: 0x0000B8EC File Offset: 0x0000A8EC
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0000B90A File Offset: 0x0000A90A
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0000B927 File Offset: 0x0000A927
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0000B936 File Offset: 0x0000A936
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0000B941 File Offset: 0x0000A941
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0000B953 File Offset: 0x0000A953
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0000B961 File Offset: 0x0000A961
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0000B973 File Offset: 0x0000A973
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0000B981 File Offset: 0x0000A981
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0000B993 File Offset: 0x0000A993
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0000B9A1 File Offset: 0x0000A9A1
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0000B9B3 File Offset: 0x0000A9B3
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

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0000B9C1 File Offset: 0x0000A9C1
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x0000B9D3 File Offset: 0x0000A9D3
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

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0000B9E1 File Offset: 0x0000A9E1
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x0000B9F3 File Offset: 0x0000A9F3
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0000BA01 File Offset: 0x0000AA01
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x0000BA13 File Offset: 0x0000AA13
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

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0000BA21 File Offset: 0x0000AA21
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x0000BA33 File Offset: 0x0000AA33
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0000BA41 File Offset: 0x0000AA41
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x0000BA53 File Offset: 0x0000AA53
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0000BA61 File Offset: 0x0000AA61
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x0000BA73 File Offset: 0x0000AA73
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0000BA81 File Offset: 0x0000AA81
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0000BA93 File Offset: 0x0000AA93
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0000BAA1 File Offset: 0x0000AAA1
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0000BAB3 File Offset: 0x0000AAB3
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0000BAC1 File Offset: 0x0000AAC1
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0000BAD3 File Offset: 0x0000AAD3
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0000BAE1 File Offset: 0x0000AAE1
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0000BAF3 File Offset: 0x0000AAF3
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

		// Token: 0x06000914 RID: 2324 RVA: 0x0000BB01 File Offset: 0x0000AB01
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0000BB1F File Offset: 0x0000AB1F
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0000BB3C File Offset: 0x0000AB3C
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0000BB4E File Offset: 0x0000AB4E
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0000BB5C File Offset: 0x0000AB5C
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x0000BB6E File Offset: 0x0000AB6E
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

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0000BB7C File Offset: 0x0000AB7C
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0000BB8E File Offset: 0x0000AB8E
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

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0000BB9C File Offset: 0x0000AB9C
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0000BBAE File Offset: 0x0000ABAE
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0000BBBC File Offset: 0x0000ABBC
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0000BBCE File Offset: 0x0000ABCE
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0000BBDC File Offset: 0x0000ABDC
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x0000BBEB File Offset: 0x0000ABEB
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0000BBF6 File Offset: 0x0000ABF6
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0000BC08 File Offset: 0x0000AC08
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0000BC16 File Offset: 0x0000AC16
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0000BC28 File Offset: 0x0000AC28
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0000BC36 File Offset: 0x0000AC36
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x0000BC45 File Offset: 0x0000AC45
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0000BC50 File Offset: 0x0000AC50
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0000BC5F File Offset: 0x0000AC5F
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

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0000BC6A File Offset: 0x0000AC6A
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0000BC79 File Offset: 0x0000AC79
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

		// Token: 0x0600092C RID: 2348 RVA: 0x0000BC84 File Offset: 0x0000AC84
		public FIXCollateralRequest()
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000BD1C File Offset: 0x0000AD1C
		public FIXCollateralRequest(string CollReqID, int CollAsgnReason, DateTime TransactTime)
		{
			this.CollReqID = CollReqID;
			this.CollAsgnReason = CollAsgnReason;
			this.TransactTime = TransactTime;
		}

		// Token: 0x04000061 RID: 97
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000062 RID: 98
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000063 RID: 99
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000064 RID: 100
		private ArrayList fExecsGroup = new ArrayList();

		// Token: 0x04000065 RID: 101
		private ArrayList fTradesGroup = new ArrayList();

		// Token: 0x04000066 RID: 102
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000067 RID: 103
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000068 RID: 104
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000069 RID: 105
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400006A RID: 106
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x0400006B RID: 107
		private ArrayList fMiscFeesGroup = new ArrayList();

		// Token: 0x0400006C RID: 108
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
