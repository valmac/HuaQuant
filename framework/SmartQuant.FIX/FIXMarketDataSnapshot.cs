using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200018A RID: 394
	public class FIXMarketDataSnapshot : FIXMessage
	{
		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06004A6C RID: 19052 RVA: 0x00052565 File Offset: 0x00051565
		// (set) Token: 0x06004A6D RID: 19053 RVA: 0x00052577 File Offset: 0x00051577
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

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06004A6E RID: 19054 RVA: 0x00052585 File Offset: 0x00051585
		// (set) Token: 0x06004A6F RID: 19055 RVA: 0x00052594 File Offset: 0x00051594
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

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06004A70 RID: 19056 RVA: 0x0005259F File Offset: 0x0005159F
		// (set) Token: 0x06004A71 RID: 19057 RVA: 0x000525AE File Offset: 0x000515AE
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

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x000525B9 File Offset: 0x000515B9
		// (set) Token: 0x06004A73 RID: 19059 RVA: 0x000525C8 File Offset: 0x000515C8
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

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x000525D3 File Offset: 0x000515D3
		// (set) Token: 0x06004A75 RID: 19061 RVA: 0x000525E2 File Offset: 0x000515E2
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

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x000525ED File Offset: 0x000515ED
		// (set) Token: 0x06004A77 RID: 19063 RVA: 0x000525FC File Offset: 0x000515FC
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

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x00052607 File Offset: 0x00051607
		// (set) Token: 0x06004A79 RID: 19065 RVA: 0x00052619 File Offset: 0x00051619
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

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x00052627 File Offset: 0x00051627
		// (set) Token: 0x06004A7B RID: 19067 RVA: 0x00052636 File Offset: 0x00051636
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

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x00052641 File Offset: 0x00051641
		// (set) Token: 0x06004A7D RID: 19069 RVA: 0x00052650 File Offset: 0x00051650
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

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x0005265B File Offset: 0x0005165B
		// (set) Token: 0x06004A7F RID: 19071 RVA: 0x0005266A File Offset: 0x0005166A
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

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x00052675 File Offset: 0x00051675
		// (set) Token: 0x06004A81 RID: 19073 RVA: 0x00052684 File Offset: 0x00051684
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

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x0005268F File Offset: 0x0005168F
		// (set) Token: 0x06004A83 RID: 19075 RVA: 0x000526A1 File Offset: 0x000516A1
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

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x000526AF File Offset: 0x000516AF
		// (set) Token: 0x06004A85 RID: 19077 RVA: 0x000526BE File Offset: 0x000516BE
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

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06004A86 RID: 19078 RVA: 0x000526C9 File Offset: 0x000516C9
		// (set) Token: 0x06004A87 RID: 19079 RVA: 0x000526D7 File Offset: 0x000516D7
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

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06004A88 RID: 19080 RVA: 0x000526E1 File Offset: 0x000516E1
		// (set) Token: 0x06004A89 RID: 19081 RVA: 0x000526F0 File Offset: 0x000516F0
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

		// Token: 0x06004A8A RID: 19082 RVA: 0x000526FB File Offset: 0x000516FB
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x0005270E File Offset: 0x0005170E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06004A8C RID: 19084 RVA: 0x0005271D File Offset: 0x0005171D
		// (set) Token: 0x06004A8D RID: 19085 RVA: 0x0005272F File Offset: 0x0005172F
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

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x0005273D File Offset: 0x0005173D
		// (set) Token: 0x06004A8F RID: 19087 RVA: 0x0005274F File Offset: 0x0005174F
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

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x0005275D File Offset: 0x0005175D
		// (set) Token: 0x06004A91 RID: 19089 RVA: 0x0005276C File Offset: 0x0005176C
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

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x00052777 File Offset: 0x00051777
		// (set) Token: 0x06004A93 RID: 19091 RVA: 0x00052786 File Offset: 0x00051786
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

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x00052791 File Offset: 0x00051791
		// (set) Token: 0x06004A95 RID: 19093 RVA: 0x000527A0 File Offset: 0x000517A0
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

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x000527AB File Offset: 0x000517AB
		// (set) Token: 0x06004A97 RID: 19095 RVA: 0x000527BA File Offset: 0x000517BA
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

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x000527C5 File Offset: 0x000517C5
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x000527D7 File Offset: 0x000517D7
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

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x000527E5 File Offset: 0x000517E5
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x000527F7 File Offset: 0x000517F7
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

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06004A9C RID: 19100 RVA: 0x00052805 File Offset: 0x00051805
		// (set) Token: 0x06004A9D RID: 19101 RVA: 0x00052817 File Offset: 0x00051817
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

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06004A9E RID: 19102 RVA: 0x00052825 File Offset: 0x00051825
		// (set) Token: 0x06004A9F RID: 19103 RVA: 0x00052837 File Offset: 0x00051837
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

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x00052845 File Offset: 0x00051845
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x00052857 File Offset: 0x00051857
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

		// Token: 0x06004AA2 RID: 19106 RVA: 0x00052865 File Offset: 0x00051865
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x00052883 File Offset: 0x00051883
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x000528A0 File Offset: 0x000518A0
		// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x000528B2 File Offset: 0x000518B2
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

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x000528C0 File Offset: 0x000518C0
		// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x000528D2 File Offset: 0x000518D2
		[FIXField("262", EFieldOption.Optional)]
		public string MDReqID
		{
			get
			{
				return this.GetStringField(262).Value;
			}
			set
			{
				this.AddStringField(262, value);
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x000528E0 File Offset: 0x000518E0
		// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x000528EF File Offset: 0x000518EF
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

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x000528FA File Offset: 0x000518FA
		// (set) Token: 0x06004AAB RID: 19115 RVA: 0x00052909 File Offset: 0x00051909
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

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x00052914 File Offset: 0x00051914
		// (set) Token: 0x06004AAD RID: 19117 RVA: 0x00052923 File Offset: 0x00051923
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

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x0005292E File Offset: 0x0005192E
		// (set) Token: 0x06004AAF RID: 19119 RVA: 0x0005293D File Offset: 0x0005193D
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

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x00052948 File Offset: 0x00051948
		// (set) Token: 0x06004AB1 RID: 19121 RVA: 0x0005295A File Offset: 0x0005195A
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

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00052968 File Offset: 0x00051968
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x00052986 File Offset: 0x00051986
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x000529A3 File Offset: 0x000519A3
		// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x000529B5 File Offset: 0x000519B5
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

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x000529C3 File Offset: 0x000519C3
		// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x000529D5 File Offset: 0x000519D5
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

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x000529E3 File Offset: 0x000519E3
		// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x000529F5 File Offset: 0x000519F5
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

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x00052A03 File Offset: 0x00051A03
		// (set) Token: 0x06004ABB RID: 19131 RVA: 0x00052A15 File Offset: 0x00051A15
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

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x00052A23 File Offset: 0x00051A23
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x00052A35 File Offset: 0x00051A35
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

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x00052A43 File Offset: 0x00051A43
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x00052A55 File Offset: 0x00051A55
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

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x00052A63 File Offset: 0x00051A63
		// (set) Token: 0x06004AC1 RID: 19137 RVA: 0x00052A75 File Offset: 0x00051A75
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

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x00052A83 File Offset: 0x00051A83
		// (set) Token: 0x06004AC3 RID: 19139 RVA: 0x00052A95 File Offset: 0x00051A95
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

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x00052AA3 File Offset: 0x00051AA3
		// (set) Token: 0x06004AC5 RID: 19141 RVA: 0x00052AB5 File Offset: 0x00051AB5
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

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x00052AC3 File Offset: 0x00051AC3
		// (set) Token: 0x06004AC7 RID: 19143 RVA: 0x00052AD5 File Offset: 0x00051AD5
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

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06004AC8 RID: 19144 RVA: 0x00052AE3 File Offset: 0x00051AE3
		// (set) Token: 0x06004AC9 RID: 19145 RVA: 0x00052AF5 File Offset: 0x00051AF5
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

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x00052B03 File Offset: 0x00051B03
		// (set) Token: 0x06004ACB RID: 19147 RVA: 0x00052B15 File Offset: 0x00051B15
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

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x00052B23 File Offset: 0x00051B23
		// (set) Token: 0x06004ACD RID: 19149 RVA: 0x00052B35 File Offset: 0x00051B35
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

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x00052B43 File Offset: 0x00051B43
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x00052B55 File Offset: 0x00051B55
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

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x00052B63 File Offset: 0x00051B63
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x00052B75 File Offset: 0x00051B75
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

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x00052B83 File Offset: 0x00051B83
		// (set) Token: 0x06004AD3 RID: 19155 RVA: 0x00052B95 File Offset: 0x00051B95
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

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x00052BA3 File Offset: 0x00051BA3
		// (set) Token: 0x06004AD5 RID: 19157 RVA: 0x00052BB5 File Offset: 0x00051BB5
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

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x00052BC3 File Offset: 0x00051BC3
		// (set) Token: 0x06004AD7 RID: 19159 RVA: 0x00052BD5 File Offset: 0x00051BD5
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

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06004AD8 RID: 19160 RVA: 0x00052BE3 File Offset: 0x00051BE3
		// (set) Token: 0x06004AD9 RID: 19161 RVA: 0x00052BF5 File Offset: 0x00051BF5
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

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06004ADA RID: 19162 RVA: 0x00052C03 File Offset: 0x00051C03
		// (set) Token: 0x06004ADB RID: 19163 RVA: 0x00052C15 File Offset: 0x00051C15
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

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06004ADC RID: 19164 RVA: 0x00052C23 File Offset: 0x00051C23
		// (set) Token: 0x06004ADD RID: 19165 RVA: 0x00052C35 File Offset: 0x00051C35
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

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x00052C43 File Offset: 0x00051C43
		// (set) Token: 0x06004ADF RID: 19167 RVA: 0x00052C55 File Offset: 0x00051C55
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

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x00052C63 File Offset: 0x00051C63
		// (set) Token: 0x06004AE1 RID: 19169 RVA: 0x00052C75 File Offset: 0x00051C75
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

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x00052C83 File Offset: 0x00051C83
		// (set) Token: 0x06004AE3 RID: 19171 RVA: 0x00052C95 File Offset: 0x00051C95
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

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x00052CA3 File Offset: 0x00051CA3
		// (set) Token: 0x06004AE5 RID: 19173 RVA: 0x00052CB2 File Offset: 0x00051CB2
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

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x00052CBD File Offset: 0x00051CBD
		// (set) Token: 0x06004AE7 RID: 19175 RVA: 0x00052CCF File Offset: 0x00051CCF
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

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x00052CDD File Offset: 0x00051CDD
		// (set) Token: 0x06004AE9 RID: 19177 RVA: 0x00052CEF File Offset: 0x00051CEF
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

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x00052CFD File Offset: 0x00051CFD
		// (set) Token: 0x06004AEB RID: 19179 RVA: 0x00052D0C File Offset: 0x00051D0C
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

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06004AEC RID: 19180 RVA: 0x00052D17 File Offset: 0x00051D17
		// (set) Token: 0x06004AED RID: 19181 RVA: 0x00052D29 File Offset: 0x00051D29
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

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06004AEE RID: 19182 RVA: 0x00052D37 File Offset: 0x00051D37
		// (set) Token: 0x06004AEF RID: 19183 RVA: 0x00052D49 File Offset: 0x00051D49
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

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x00052D57 File Offset: 0x00051D57
		// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x00052D69 File Offset: 0x00051D69
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

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x00052D77 File Offset: 0x00051D77
		// (set) Token: 0x06004AF3 RID: 19187 RVA: 0x00052D89 File Offset: 0x00051D89
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

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x00052D97 File Offset: 0x00051D97
		// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x00052DA9 File Offset: 0x00051DA9
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

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x00052DB7 File Offset: 0x00051DB7
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x00052DC9 File Offset: 0x00051DC9
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

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x00052DD7 File Offset: 0x00051DD7
		// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x00052DE9 File Offset: 0x00051DE9
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

		// Token: 0x06004AFA RID: 19194 RVA: 0x00052DF7 File Offset: 0x00051DF7
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x00052E15 File Offset: 0x00051E15
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x00052E32 File Offset: 0x00051E32
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x00052E44 File Offset: 0x00051E44
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

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x00052E52 File Offset: 0x00051E52
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x00052E64 File Offset: 0x00051E64
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

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x00052E72 File Offset: 0x00051E72
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x00052E84 File Offset: 0x00051E84
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

		// Token: 0x06004B02 RID: 19202 RVA: 0x00052E92 File Offset: 0x00051E92
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00052EB0 File Offset: 0x00051EB0
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x00052ECD File Offset: 0x00051ECD
		// (set) Token: 0x06004B05 RID: 19205 RVA: 0x00052EDF File Offset: 0x00051EDF
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

		// Token: 0x06004B06 RID: 19206 RVA: 0x00052EED File Offset: 0x00051EED
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00052F0B File Offset: 0x00051F0B
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x00052F28 File Offset: 0x00051F28
		// (set) Token: 0x06004B09 RID: 19209 RVA: 0x00052F3A File Offset: 0x00051F3A
		[FIXField("291", EFieldOption.Optional)]
		public string FinancialStatus
		{
			get
			{
				return this.GetStringField(291).Value;
			}
			set
			{
				this.AddStringField(291, value);
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06004B0A RID: 19210 RVA: 0x00052F48 File Offset: 0x00051F48
		// (set) Token: 0x06004B0B RID: 19211 RVA: 0x00052F5A File Offset: 0x00051F5A
		[FIXField("292", EFieldOption.Optional)]
		public string CorporateAction
		{
			get
			{
				return this.GetStringField(292).Value;
			}
			set
			{
				this.AddStringField(292, value);
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x00052F68 File Offset: 0x00051F68
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x00052F7A File Offset: 0x00051F7A
		[FIXField("451", EFieldOption.Optional)]
		public double NetChgPrevDay
		{
			get
			{
				return this.GetDoubleField(451).Value;
			}
			set
			{
				this.AddDoubleField(451, value);
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x00052F88 File Offset: 0x00051F88
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x00052F95 File Offset: 0x00051F95
		[FIXField("268", EFieldOption.Required)]
		public int NoMDEntries
		{
			get
			{
				return this.GetIntValue(268);
			}
			set
			{
				this.SetIntValue(268, value);
			}
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00052FA3 File Offset: 0x00051FA3
		public FIXMDEntriesGroup GetMDEntriesGroup(int i)
		{
			if (i < this.NoMDEntries)
			{
				return (FIXMDEntriesGroup)this.fMDEntriesGroup[i];
			}
			return null;
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00052FC1 File Offset: 0x00051FC1
		public void AddGroup(FIXMDEntriesGroup group)
		{
			this.fMDEntriesGroup.Add(group);
			this.NoMDEntries++;
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x00052FDE File Offset: 0x00051FDE
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x00052FF0 File Offset: 0x00051FF0
		[FIXField("813", EFieldOption.Optional)]
		public int ApplQueueDepth
		{
			get
			{
				return this.GetIntField(813).Value;
			}
			set
			{
				this.AddIntField(813, value);
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x00052FFE File Offset: 0x00051FFE
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x00053010 File Offset: 0x00052010
		[FIXField("814", EFieldOption.Optional)]
		public int ApplQueueResolution
		{
			get
			{
				return this.GetIntField(814).Value;
			}
			set
			{
				this.AddIntField(814, value);
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x0005301E File Offset: 0x0005201E
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x0005302D File Offset: 0x0005202D
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

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x00053038 File Offset: 0x00052038
		// (set) Token: 0x06004B19 RID: 19225 RVA: 0x00053047 File Offset: 0x00052047
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

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x00053052 File Offset: 0x00052052
		// (set) Token: 0x06004B1B RID: 19227 RVA: 0x00053061 File Offset: 0x00052061
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

		// Token: 0x06004B1C RID: 19228 RVA: 0x0005306C File Offset: 0x0005206C
		public FIXMarketDataSnapshot()
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x000530CC File Offset: 0x000520CC
		public FIXMarketDataSnapshot(int NoMDEntries)
		{
			this.NoMDEntries = NoMDEntries;
		}

		// Token: 0x04000DB8 RID: 3512
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000DB9 RID: 3513
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000DBA RID: 3514
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000DBB RID: 3515
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000DBC RID: 3516
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x04000DBD RID: 3517
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x04000DBE RID: 3518
		private ArrayList fMDEntriesGroup = new ArrayList();
	}
}
