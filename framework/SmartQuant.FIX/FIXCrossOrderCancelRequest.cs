using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000CB RID: 203
	public class FIXCrossOrderCancelRequest : FIXMessage
	{
		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x0002A03F File Offset: 0x0002903F
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x0002A051 File Offset: 0x00029051
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

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x0002A05F File Offset: 0x0002905F
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x0002A06E File Offset: 0x0002906E
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

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x0002A079 File Offset: 0x00029079
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x0002A088 File Offset: 0x00029088
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

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x0002A093 File Offset: 0x00029093
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x0002A0A2 File Offset: 0x000290A2
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x0002A0AD File Offset: 0x000290AD
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x0002A0BC File Offset: 0x000290BC
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

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x0002A0C7 File Offset: 0x000290C7
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x0002A0D6 File Offset: 0x000290D6
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

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x0002A0E1 File Offset: 0x000290E1
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x0002A0F3 File Offset: 0x000290F3
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

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x0002A101 File Offset: 0x00029101
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x0002A110 File Offset: 0x00029110
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

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x0002A11B File Offset: 0x0002911B
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x0002A12A File Offset: 0x0002912A
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x0002A135 File Offset: 0x00029135
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x0002A144 File Offset: 0x00029144
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

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x0002A14F File Offset: 0x0002914F
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x0002A15E File Offset: 0x0002915E
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x0002A169 File Offset: 0x00029169
		// (set) Token: 0x06002789 RID: 10121 RVA: 0x0002A17B File Offset: 0x0002917B
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

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x0002A189 File Offset: 0x00029189
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x0002A198 File Offset: 0x00029198
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x0002A1A3 File Offset: 0x000291A3
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x0002A1B1 File Offset: 0x000291B1
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

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x0002A1BB File Offset: 0x000291BB
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x0002A1CA File Offset: 0x000291CA
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

		// Token: 0x06002790 RID: 10128 RVA: 0x0002A1D5 File Offset: 0x000291D5
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x0002A1E8 File Offset: 0x000291E8
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x0002A1F7 File Offset: 0x000291F7
		// (set) Token: 0x06002793 RID: 10131 RVA: 0x0002A209 File Offset: 0x00029209
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x0002A217 File Offset: 0x00029217
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x0002A229 File Offset: 0x00029229
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

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x0002A237 File Offset: 0x00029237
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x0002A246 File Offset: 0x00029246
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

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x0002A251 File Offset: 0x00029251
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x0002A260 File Offset: 0x00029260
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

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x0002A26B File Offset: 0x0002926B
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x0002A27A File Offset: 0x0002927A
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

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x0002A285 File Offset: 0x00029285
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x0002A294 File Offset: 0x00029294
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

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x0002A29F File Offset: 0x0002929F
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x0002A2B1 File Offset: 0x000292B1
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

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x0002A2BF File Offset: 0x000292BF
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0002A2D1 File Offset: 0x000292D1
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

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0002A2DF File Offset: 0x000292DF
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x0002A2F1 File Offset: 0x000292F1
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

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0002A2FF File Offset: 0x000292FF
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x0002A311 File Offset: 0x00029311
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

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x0002A31F File Offset: 0x0002931F
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x0002A331 File Offset: 0x00029331
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

		// Token: 0x060027A8 RID: 10152 RVA: 0x0002A33F File Offset: 0x0002933F
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x0002A35D File Offset: 0x0002935D
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x0002A37A File Offset: 0x0002937A
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x0002A38C File Offset: 0x0002938C
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

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x0002A39A File Offset: 0x0002939A
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x0002A3A9 File Offset: 0x000293A9
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

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x0002A3B4 File Offset: 0x000293B4
		// (set) Token: 0x060027AF RID: 10159 RVA: 0x0002A3C6 File Offset: 0x000293C6
		[FIXField("548", EFieldOption.Required)]
		public string CrossID
		{
			get
			{
				return this.GetStringField(548).Value;
			}
			set
			{
				this.AddStringField(548, value);
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x0002A3D4 File Offset: 0x000293D4
		// (set) Token: 0x060027B1 RID: 10161 RVA: 0x0002A3E6 File Offset: 0x000293E6
		[FIXField("551", EFieldOption.Required)]
		public string OrigCrossID
		{
			get
			{
				return this.GetStringField(551).Value;
			}
			set
			{
				this.AddStringField(551, value);
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x0002A3F4 File Offset: 0x000293F4
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x0002A406 File Offset: 0x00029406
		[FIXField("549", EFieldOption.Required)]
		public int CrossType
		{
			get
			{
				return this.GetIntField(549).Value;
			}
			set
			{
				this.AddIntField(549, value);
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x0002A414 File Offset: 0x00029414
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x0002A426 File Offset: 0x00029426
		[FIXField("550", EFieldOption.Required)]
		public int CrossPrioritization
		{
			get
			{
				return this.GetIntField(550).Value;
			}
			set
			{
				this.AddIntField(550, value);
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0002A434 File Offset: 0x00029434
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x0002A446 File Offset: 0x00029446
		[FIXField("552", EFieldOption.Required)]
		public int NoSides
		{
			get
			{
				return this.GetIntField(552).Value;
			}
			set
			{
				this.AddIntField(552, value);
			}
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x0002A454 File Offset: 0x00029454
		public FIXSidesGroup GetSidesGroup(int i)
		{
			if (i < this.NoSides)
			{
				return (FIXSidesGroup)this.fSidesGroup[i];
			}
			return null;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0002A472 File Offset: 0x00029472
		public void AddGroup(FIXSidesGroup group)
		{
			this.fSidesGroup.Add(group);
			this.NoSides++;
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0002A48F File Offset: 0x0002948F
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x0002A49E File Offset: 0x0002949E
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x0002A4A9 File Offset: 0x000294A9
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x0002A4B8 File Offset: 0x000294B8
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x0002A4C3 File Offset: 0x000294C3
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x0002A4D2 File Offset: 0x000294D2
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0002A4DD File Offset: 0x000294DD
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x0002A4EC File Offset: 0x000294EC
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0002A4F7 File Offset: 0x000294F7
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0002A509 File Offset: 0x00029509
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

		// Token: 0x060027C4 RID: 10180 RVA: 0x0002A517 File Offset: 0x00029517
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0002A535 File Offset: 0x00029535
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0002A552 File Offset: 0x00029552
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x0002A564 File Offset: 0x00029564
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

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0002A572 File Offset: 0x00029572
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0002A584 File Offset: 0x00029584
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

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x0002A592 File Offset: 0x00029592
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x0002A5A4 File Offset: 0x000295A4
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

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0002A5B2 File Offset: 0x000295B2
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x0002A5C4 File Offset: 0x000295C4
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

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x0002A5D2 File Offset: 0x000295D2
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x0002A5E4 File Offset: 0x000295E4
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

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x0002A5F2 File Offset: 0x000295F2
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x0002A604 File Offset: 0x00029604
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

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x0002A612 File Offset: 0x00029612
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x0002A624 File Offset: 0x00029624
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

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x0002A632 File Offset: 0x00029632
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x0002A644 File Offset: 0x00029644
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x0002A652 File Offset: 0x00029652
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x0002A664 File Offset: 0x00029664
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x0002A672 File Offset: 0x00029672
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x0002A684 File Offset: 0x00029684
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x0002A692 File Offset: 0x00029692
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x0002A6A4 File Offset: 0x000296A4
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

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x0002A6B2 File Offset: 0x000296B2
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x0002A6C4 File Offset: 0x000296C4
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x0002A6D2 File Offset: 0x000296D2
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x0002A6E4 File Offset: 0x000296E4
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

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x0002A6F2 File Offset: 0x000296F2
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0002A704 File Offset: 0x00029704
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

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0002A712 File Offset: 0x00029712
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x0002A724 File Offset: 0x00029724
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

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0002A732 File Offset: 0x00029732
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x0002A744 File Offset: 0x00029744
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

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x0002A752 File Offset: 0x00029752
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0002A764 File Offset: 0x00029764
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x0002A772 File Offset: 0x00029772
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x0002A784 File Offset: 0x00029784
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

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x0002A792 File Offset: 0x00029792
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x0002A7A4 File Offset: 0x000297A4
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

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x0002A7B2 File Offset: 0x000297B2
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x0002A7C4 File Offset: 0x000297C4
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

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x0002A7D2 File Offset: 0x000297D2
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x0002A7E4 File Offset: 0x000297E4
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

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x0002A7F2 File Offset: 0x000297F2
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x0002A804 File Offset: 0x00029804
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

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0002A812 File Offset: 0x00029812
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x0002A824 File Offset: 0x00029824
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

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x0002A832 File Offset: 0x00029832
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x0002A844 File Offset: 0x00029844
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

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0002A852 File Offset: 0x00029852
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0002A861 File Offset: 0x00029861
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

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0002A86C File Offset: 0x0002986C
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x0002A87E File Offset: 0x0002987E
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

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x0002A88C File Offset: 0x0002988C
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x0002A89E File Offset: 0x0002989E
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

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x0002A8AC File Offset: 0x000298AC
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x0002A8BB File Offset: 0x000298BB
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

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x0002A8C6 File Offset: 0x000298C6
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0002A8D8 File Offset: 0x000298D8
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

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x0002A8E6 File Offset: 0x000298E6
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0002A8F8 File Offset: 0x000298F8
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

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x0002A906 File Offset: 0x00029906
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0002A918 File Offset: 0x00029918
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

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x0002A926 File Offset: 0x00029926
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x0002A938 File Offset: 0x00029938
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

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x0002A946 File Offset: 0x00029946
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x0002A958 File Offset: 0x00029958
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

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x0002A966 File Offset: 0x00029966
		// (set) Token: 0x06002809 RID: 10249 RVA: 0x0002A978 File Offset: 0x00029978
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

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x0002A986 File Offset: 0x00029986
		// (set) Token: 0x0600280B RID: 10251 RVA: 0x0002A998 File Offset: 0x00029998
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

		// Token: 0x0600280C RID: 10252 RVA: 0x0002A9A6 File Offset: 0x000299A6
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0002A9C4 File Offset: 0x000299C4
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x0002A9E1 File Offset: 0x000299E1
		// (set) Token: 0x0600280F RID: 10255 RVA: 0x0002A9F3 File Offset: 0x000299F3
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

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x0002AA01 File Offset: 0x00029A01
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x0002AA13 File Offset: 0x00029A13
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

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x0002AA21 File Offset: 0x00029A21
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x0002AA33 File Offset: 0x00029A33
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

		// Token: 0x06002814 RID: 10260 RVA: 0x0002AA41 File Offset: 0x00029A41
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0002AA5F File Offset: 0x00029A5F
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x0002AA7C File Offset: 0x00029A7C
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x0002AA8E File Offset: 0x00029A8E
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

		// Token: 0x06002818 RID: 10264 RVA: 0x0002AA9C File Offset: 0x00029A9C
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0002AABA File Offset: 0x00029ABA
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x0002AAD7 File Offset: 0x00029AD7
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x0002AAE6 File Offset: 0x00029AE6
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

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x0002AAF1 File Offset: 0x00029AF1
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x0002AB00 File Offset: 0x00029B00
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

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x0002AB0B File Offset: 0x00029B0B
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x0002AB1A File Offset: 0x00029B1A
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

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x0002AB25 File Offset: 0x00029B25
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x0002AB34 File Offset: 0x00029B34
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

		// Token: 0x06002822 RID: 10274 RVA: 0x0002AB40 File Offset: 0x00029B40
		public FIXCrossOrderCancelRequest()
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x0002ABA0 File Offset: 0x00029BA0
		public FIXCrossOrderCancelRequest(string CrossID, string OrigCrossID, int CrossType, int CrossPrioritization, int NoSides, DateTime TransactTime)
		{
			this.CrossID = CrossID;
			this.OrigCrossID = OrigCrossID;
			this.CrossType = CrossType;
			this.CrossPrioritization = CrossPrioritization;
			this.NoSides = NoSides;
			this.TransactTime = TransactTime;
		}

		// Token: 0x040003AA RID: 938
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003AB RID: 939
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040003AC RID: 940
		private ArrayList fSidesGroup = new ArrayList();

		// Token: 0x040003AD RID: 941
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040003AE RID: 942
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040003AF RID: 943
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040003B0 RID: 944
		private ArrayList fLegsGroup = new ArrayList();
	}
}
