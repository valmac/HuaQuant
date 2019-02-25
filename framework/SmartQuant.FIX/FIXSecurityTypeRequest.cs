using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000127 RID: 295
	public class FIXSecurityTypeRequest : FIXMessage
	{
		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0003A189 File Offset: 0x00039189
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x0003A19B File Offset: 0x0003919B
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

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x0003A1A9 File Offset: 0x000391A9
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x0003A1B8 File Offset: 0x000391B8
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

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x0003A1C3 File Offset: 0x000391C3
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x0003A1D2 File Offset: 0x000391D2
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

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x0003A1DD File Offset: 0x000391DD
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x0003A1EC File Offset: 0x000391EC
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

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x0003A1F7 File Offset: 0x000391F7
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x0003A206 File Offset: 0x00039206
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

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x0003A211 File Offset: 0x00039211
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x0003A220 File Offset: 0x00039220
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

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x0003A22B File Offset: 0x0003922B
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x0003A23D File Offset: 0x0003923D
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

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x0003A24B File Offset: 0x0003924B
		// (set) Token: 0x0600372A RID: 14122 RVA: 0x0003A25A File Offset: 0x0003925A
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

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x0003A265 File Offset: 0x00039265
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x0003A274 File Offset: 0x00039274
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

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x0003A27F File Offset: 0x0003927F
		// (set) Token: 0x0600372E RID: 14126 RVA: 0x0003A28E File Offset: 0x0003928E
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

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x0003A299 File Offset: 0x00039299
		// (set) Token: 0x06003730 RID: 14128 RVA: 0x0003A2A8 File Offset: 0x000392A8
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

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x0003A2B3 File Offset: 0x000392B3
		// (set) Token: 0x06003732 RID: 14130 RVA: 0x0003A2C5 File Offset: 0x000392C5
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

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x0003A2D3 File Offset: 0x000392D3
		// (set) Token: 0x06003734 RID: 14132 RVA: 0x0003A2E2 File Offset: 0x000392E2
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

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06003735 RID: 14133 RVA: 0x0003A2ED File Offset: 0x000392ED
		// (set) Token: 0x06003736 RID: 14134 RVA: 0x0003A2FB File Offset: 0x000392FB
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

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x0003A305 File Offset: 0x00039305
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x0003A314 File Offset: 0x00039314
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

		// Token: 0x06003739 RID: 14137 RVA: 0x0003A31F File Offset: 0x0003931F
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0003A332 File Offset: 0x00039332
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x0003A341 File Offset: 0x00039341
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x0003A353 File Offset: 0x00039353
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

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x0003A361 File Offset: 0x00039361
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x0003A373 File Offset: 0x00039373
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

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x0003A381 File Offset: 0x00039381
		// (set) Token: 0x06003740 RID: 14144 RVA: 0x0003A390 File Offset: 0x00039390
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

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x0003A39B File Offset: 0x0003939B
		// (set) Token: 0x06003742 RID: 14146 RVA: 0x0003A3AA File Offset: 0x000393AA
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

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x0003A3B5 File Offset: 0x000393B5
		// (set) Token: 0x06003744 RID: 14148 RVA: 0x0003A3C4 File Offset: 0x000393C4
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

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x0003A3CF File Offset: 0x000393CF
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x0003A3DE File Offset: 0x000393DE
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

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x0003A3E9 File Offset: 0x000393E9
		// (set) Token: 0x06003748 RID: 14152 RVA: 0x0003A3FB File Offset: 0x000393FB
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

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x0003A409 File Offset: 0x00039409
		// (set) Token: 0x0600374A RID: 14154 RVA: 0x0003A41B File Offset: 0x0003941B
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

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x0003A429 File Offset: 0x00039429
		// (set) Token: 0x0600374C RID: 14156 RVA: 0x0003A43B File Offset: 0x0003943B
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x0003A449 File Offset: 0x00039449
		// (set) Token: 0x0600374E RID: 14158 RVA: 0x0003A45B File Offset: 0x0003945B
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

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x0003A469 File Offset: 0x00039469
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x0003A47B File Offset: 0x0003947B
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

		// Token: 0x06003751 RID: 14161 RVA: 0x0003A489 File Offset: 0x00039489
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x0003A4A7 File Offset: 0x000394A7
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x0003A4C4 File Offset: 0x000394C4
		// (set) Token: 0x06003754 RID: 14164 RVA: 0x0003A4D6 File Offset: 0x000394D6
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

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x0003A4E4 File Offset: 0x000394E4
		// (set) Token: 0x06003756 RID: 14166 RVA: 0x0003A4F6 File Offset: 0x000394F6
		[FIXField("320", EFieldOption.Required)]
		public string SecurityReqID
		{
			get
			{
				return this.GetStringField(320).Value;
			}
			set
			{
				this.AddStringField(320, value);
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x0003A504 File Offset: 0x00039504
		// (set) Token: 0x06003758 RID: 14168 RVA: 0x0003A513 File Offset: 0x00039513
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

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06003759 RID: 14169 RVA: 0x0003A51E File Offset: 0x0003951E
		// (set) Token: 0x0600375A RID: 14170 RVA: 0x0003A530 File Offset: 0x00039530
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

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x0003A53E File Offset: 0x0003953E
		// (set) Token: 0x0600375C RID: 14172 RVA: 0x0003A550 File Offset: 0x00039550
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

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x0003A55E File Offset: 0x0003955E
		// (set) Token: 0x0600375E RID: 14174 RVA: 0x0003A570 File Offset: 0x00039570
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

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x0003A57E File Offset: 0x0003957E
		// (set) Token: 0x06003760 RID: 14176 RVA: 0x0003A590 File Offset: 0x00039590
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

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x0003A59E File Offset: 0x0003959E
		// (set) Token: 0x06003762 RID: 14178 RVA: 0x0003A5B0 File Offset: 0x000395B0
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

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x0003A5BE File Offset: 0x000395BE
		// (set) Token: 0x06003764 RID: 14180 RVA: 0x0003A5D0 File Offset: 0x000395D0
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

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x0003A5DE File Offset: 0x000395DE
		// (set) Token: 0x06003766 RID: 14182 RVA: 0x0003A5F0 File Offset: 0x000395F0
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

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x0003A5FE File Offset: 0x000395FE
		// (set) Token: 0x06003768 RID: 14184 RVA: 0x0003A60D File Offset: 0x0003960D
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

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x0003A618 File Offset: 0x00039618
		// (set) Token: 0x0600376A RID: 14186 RVA: 0x0003A627 File Offset: 0x00039627
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

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x0003A632 File Offset: 0x00039632
		// (set) Token: 0x0600376C RID: 14188 RVA: 0x0003A641 File Offset: 0x00039641
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

		// Token: 0x0600376D RID: 14189 RVA: 0x0003A64C File Offset: 0x0003964C
		public FIXSecurityTypeRequest()
		{
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0003A66A File Offset: 0x0003966A
		public FIXSecurityTypeRequest(string SecurityReqID)
		{
			this.SecurityReqID = SecurityReqID;
		}

		// Token: 0x04000510 RID: 1296
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000511 RID: 1297
		private ArrayList fHopsGroup = new ArrayList();
	}
}
