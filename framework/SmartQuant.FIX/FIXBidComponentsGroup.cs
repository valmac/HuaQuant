using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000121 RID: 289
	public class FIXBidComponentsGroup : FIXGroup
	{
		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x00039D1F File Offset: 0x00038D1F
		// (set) Token: 0x060036D2 RID: 14034 RVA: 0x00039D2E File Offset: 0x00038D2E
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleField(12).Value;
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00039D39 File Offset: 0x00038D39
		// (set) Token: 0x060036D4 RID: 14036 RVA: 0x00039D48 File Offset: 0x00038D48
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharField(13).Value;
			}
			set
			{
				this.AddCharField(13, value);
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00039D53 File Offset: 0x00038D53
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x00039D65 File Offset: 0x00038D65
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleField(479).Value;
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x00039D73 File Offset: 0x00038D73
		// (set) Token: 0x060036D8 RID: 14040 RVA: 0x00039D85 File Offset: 0x00038D85
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharField(497).Value;
			}
			set
			{
				this.AddCharField(497, value);
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x00039D93 File Offset: 0x00038D93
		// (set) Token: 0x060036DA RID: 14042 RVA: 0x00039DA2 File Offset: 0x00038DA2
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

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x00039DAD File Offset: 0x00038DAD
		// (set) Token: 0x060036DC RID: 14044 RVA: 0x00039DBF File Offset: 0x00038DBF
		[FIXField("421", EFieldOption.Optional)]
		public string Country
		{
			get
			{
				return this.GetStringField(421).Value;
			}
			set
			{
				this.AddStringField(421, value);
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x00039DCD File Offset: 0x00038DCD
		// (set) Token: 0x060036DE RID: 14046 RVA: 0x00039DDC File Offset: 0x00038DDC
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

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x00039DE7 File Offset: 0x00038DE7
		// (set) Token: 0x060036E0 RID: 14048 RVA: 0x00039DF6 File Offset: 0x00038DF6
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

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x00039E01 File Offset: 0x00038E01
		// (set) Token: 0x060036E2 RID: 14050 RVA: 0x00039E13 File Offset: 0x00038E13
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

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x00039E21 File Offset: 0x00038E21
		// (set) Token: 0x060036E4 RID: 14052 RVA: 0x00039E33 File Offset: 0x00038E33
		[FIXField("406", EFieldOption.Optional)]
		public double FairValue
		{
			get
			{
				return this.GetDoubleField(406).Value;
			}
			set
			{
				this.AddDoubleField(406, value);
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x00039E41 File Offset: 0x00038E41
		// (set) Token: 0x060036E6 RID: 14054 RVA: 0x00039E53 File Offset: 0x00038E53
		[FIXField("430", EFieldOption.Optional)]
		public int NetGrossInd
		{
			get
			{
				return this.GetIntField(430).Value;
			}
			set
			{
				this.AddIntField(430, value);
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x00039E61 File Offset: 0x00038E61
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x00039E70 File Offset: 0x00038E70
		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharField(63).Value;
			}
			set
			{
				this.AddCharField(63, value);
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x00039E7B File Offset: 0x00038E7B
		// (set) Token: 0x060036EA RID: 14058 RVA: 0x00039E8A File Offset: 0x00038E8A
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

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x00039E95 File Offset: 0x00038E95
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x00039EA7 File Offset: 0x00038EA7
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

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x00039EB5 File Offset: 0x00038EB5
		// (set) Token: 0x060036EE RID: 14062 RVA: 0x00039EC7 File Offset: 0x00038EC7
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

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x00039ED5 File Offset: 0x00038ED5
		// (set) Token: 0x060036F0 RID: 14064 RVA: 0x00039EE4 File Offset: 0x00038EE4
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

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x00039EEF File Offset: 0x00038EEF
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x00039F01 File Offset: 0x00038F01
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

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x00039F0F File Offset: 0x00038F0F
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x00039F21 File Offset: 0x00038F21
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
	}
}
