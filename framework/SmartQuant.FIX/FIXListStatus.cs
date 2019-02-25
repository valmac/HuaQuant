using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000053 RID: 83
	public class FIXListStatus : FIXMessage
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00012C63 File Offset: 0x00011C63
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x00012C75 File Offset: 0x00011C75
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

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00012C83 File Offset: 0x00011C83
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00012C92 File Offset: 0x00011C92
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

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00012C9D File Offset: 0x00011C9D
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00012CAC File Offset: 0x00011CAC
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

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00012CB7 File Offset: 0x00011CB7
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00012CC6 File Offset: 0x00011CC6
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

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00012CD1 File Offset: 0x00011CD1
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00012CE0 File Offset: 0x00011CE0
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

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00012CEB File Offset: 0x00011CEB
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00012CFA File Offset: 0x00011CFA
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

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00012D05 File Offset: 0x00011D05
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00012D17 File Offset: 0x00011D17
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

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00012D25 File Offset: 0x00011D25
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00012D34 File Offset: 0x00011D34
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

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00012D3F File Offset: 0x00011D3F
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00012D4E File Offset: 0x00011D4E
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00012D59 File Offset: 0x00011D59
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00012D68 File Offset: 0x00011D68
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

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00012D73 File Offset: 0x00011D73
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00012D82 File Offset: 0x00011D82
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

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00012D8D File Offset: 0x00011D8D
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00012D9F File Offset: 0x00011D9F
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

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00012DAD File Offset: 0x00011DAD
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00012DBC File Offset: 0x00011DBC
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

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00012DC7 File Offset: 0x00011DC7
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00012DD5 File Offset: 0x00011DD5
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

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00012DDF File Offset: 0x00011DDF
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00012DEE File Offset: 0x00011DEE
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

		// Token: 0x060010BB RID: 4283 RVA: 0x00012DF9 File Offset: 0x00011DF9
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00012E0C File Offset: 0x00011E0C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00012E1B File Offset: 0x00011E1B
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00012E2D File Offset: 0x00011E2D
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

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00012E3B File Offset: 0x00011E3B
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00012E4D File Offset: 0x00011E4D
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

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00012E5B File Offset: 0x00011E5B
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00012E6A File Offset: 0x00011E6A
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

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00012E75 File Offset: 0x00011E75
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00012E84 File Offset: 0x00011E84
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00012E8F File Offset: 0x00011E8F
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00012E9E File Offset: 0x00011E9E
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

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00012EA9 File Offset: 0x00011EA9
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00012EB8 File Offset: 0x00011EB8
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

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00012EC3 File Offset: 0x00011EC3
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00012ED5 File Offset: 0x00011ED5
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

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x00012EE3 File Offset: 0x00011EE3
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x00012EF5 File Offset: 0x00011EF5
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

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00012F03 File Offset: 0x00011F03
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00012F15 File Offset: 0x00011F15
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

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00012F23 File Offset: 0x00011F23
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00012F35 File Offset: 0x00011F35
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

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00012F43 File Offset: 0x00011F43
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00012F55 File Offset: 0x00011F55
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

		// Token: 0x060010D3 RID: 4307 RVA: 0x00012F63 File Offset: 0x00011F63
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00012F81 File Offset: 0x00011F81
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00012F9E File Offset: 0x00011F9E
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00012FB0 File Offset: 0x00011FB0
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

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x00012FBE File Offset: 0x00011FBE
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00012FCD File Offset: 0x00011FCD
		[FIXField("66", EFieldOption.Required)]
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

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00012FD8 File Offset: 0x00011FD8
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00012FEA File Offset: 0x00011FEA
		[FIXField("429", EFieldOption.Required)]
		public int ListStatusType
		{
			get
			{
				return this.GetIntField(429).Value;
			}
			set
			{
				this.AddIntField(429, value);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x00012FF8 File Offset: 0x00011FF8
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x00013007 File Offset: 0x00012007
		[FIXField("82", EFieldOption.Required)]
		public int NoRpts
		{
			get
			{
				return this.GetIntField(82).Value;
			}
			set
			{
				this.AddIntField(82, value);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x00013012 File Offset: 0x00012012
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x00013024 File Offset: 0x00012024
		[FIXField("431", EFieldOption.Required)]
		public int ListOrderStatus
		{
			get
			{
				return this.GetIntField(431).Value;
			}
			set
			{
				this.AddIntField(431, value);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x00013032 File Offset: 0x00012032
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00013041 File Offset: 0x00012041
		[FIXField("83", EFieldOption.Required)]
		public int RptSeq
		{
			get
			{
				return this.GetIntField(83).Value;
			}
			set
			{
				this.AddIntField(83, value);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0001304C File Offset: 0x0001204C
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0001305E File Offset: 0x0001205E
		[FIXField("444", EFieldOption.Optional)]
		public string ListStatusText
		{
			get
			{
				return this.GetStringField(444).Value;
			}
			set
			{
				this.AddStringField(444, value);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0001306C File Offset: 0x0001206C
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0001307E File Offset: 0x0001207E
		[FIXField("445", EFieldOption.Optional)]
		public int EncodedListStatusTextLen
		{
			get
			{
				return this.GetIntField(445).Value;
			}
			set
			{
				this.AddIntField(445, value);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0001308C File Offset: 0x0001208C
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x0001309E File Offset: 0x0001209E
		[FIXField("446", EFieldOption.Optional)]
		public string EncodedListStatusText
		{
			get
			{
				return this.GetStringField(446).Value;
			}
			set
			{
				this.AddStringField(446, value);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000130AC File Offset: 0x000120AC
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x000130BB File Offset: 0x000120BB
		[FIXField("60", EFieldOption.Optional)]
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

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000130C6 File Offset: 0x000120C6
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x000130D5 File Offset: 0x000120D5
		[FIXField("68", EFieldOption.Required)]
		public int TotNoOrders
		{
			get
			{
				return this.GetIntField(68).Value;
			}
			set
			{
				this.AddIntField(68, value);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x000130E0 File Offset: 0x000120E0
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x000130F2 File Offset: 0x000120F2
		[FIXField("893", EFieldOption.Optional)]
		public bool LastFragment
		{
			get
			{
				return this.GetBoolField(893).Value;
			}
			set
			{
				this.AddBoolField(893, value);
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00013100 File Offset: 0x00012100
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0001310F File Offset: 0x0001210F
		[FIXField("73", EFieldOption.Required)]
		public int NoOrders
		{
			get
			{
				return this.GetIntField(73).Value;
			}
			set
			{
				this.AddIntField(73, value);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0001311A File Offset: 0x0001211A
		public FIXOrdersGroup GetOrdersGroup(int i)
		{
			if (i < this.NoOrders)
			{
				return (FIXOrdersGroup)this.fOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00013138 File Offset: 0x00012138
		public void AddGroup(FIXOrdersGroup group)
		{
			this.fOrdersGroup.Add(group);
			this.NoOrders++;
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00013155 File Offset: 0x00012155
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x00013164 File Offset: 0x00012164
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0001316F File Offset: 0x0001216F
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0001317E File Offset: 0x0001217E
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00013189 File Offset: 0x00012189
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x00013198 File Offset: 0x00012198
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

		// Token: 0x060010F7 RID: 4343 RVA: 0x000131A3 File Offset: 0x000121A3
		public FIXListStatus()
		{
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000131CC File Offset: 0x000121CC
		public FIXListStatus(string ListID, int ListStatusType, int NoRpts, int ListOrderStatus, int RptSeq, int TotNoOrders, int NoOrders)
		{
			this.ListID = ListID;
			this.ListStatusType = ListStatusType;
			this.NoRpts = NoRpts;
			this.ListOrderStatus = ListOrderStatus;
			this.RptSeq = RptSeq;
			this.TotNoOrders = TotNoOrders;
			this.NoOrders = NoOrders;
		}

		// Token: 0x0400018D RID: 397
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400018E RID: 398
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400018F RID: 399
		private ArrayList fOrdersGroup = new ArrayList();
	}
}
