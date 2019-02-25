using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200014A RID: 330
	public class FIXQuoteRequest : FIXMessage
	{
		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x00045061 File Offset: 0x00044061
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x00045073 File Offset: 0x00044073
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

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x00045081 File Offset: 0x00044081
		// (set) Token: 0x06003F50 RID: 16208 RVA: 0x00045090 File Offset: 0x00044090
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

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x0004509B File Offset: 0x0004409B
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x000450AA File Offset: 0x000440AA
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

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x000450B5 File Offset: 0x000440B5
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x000450C4 File Offset: 0x000440C4
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

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x000450CF File Offset: 0x000440CF
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x000450DE File Offset: 0x000440DE
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

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x000450E9 File Offset: 0x000440E9
		// (set) Token: 0x06003F58 RID: 16216 RVA: 0x000450F8 File Offset: 0x000440F8
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

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06003F59 RID: 16217 RVA: 0x00045103 File Offset: 0x00044103
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x00045115 File Offset: 0x00044115
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

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x00045123 File Offset: 0x00044123
		// (set) Token: 0x06003F5C RID: 16220 RVA: 0x00045132 File Offset: 0x00044132
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

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x0004513D File Offset: 0x0004413D
		// (set) Token: 0x06003F5E RID: 16222 RVA: 0x0004514C File Offset: 0x0004414C
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

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x00045157 File Offset: 0x00044157
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x00045166 File Offset: 0x00044166
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

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06003F61 RID: 16225 RVA: 0x00045171 File Offset: 0x00044171
		// (set) Token: 0x06003F62 RID: 16226 RVA: 0x00045180 File Offset: 0x00044180
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

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x0004518B File Offset: 0x0004418B
		// (set) Token: 0x06003F64 RID: 16228 RVA: 0x0004519D File Offset: 0x0004419D
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

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06003F65 RID: 16229 RVA: 0x000451AB File Offset: 0x000441AB
		// (set) Token: 0x06003F66 RID: 16230 RVA: 0x000451BA File Offset: 0x000441BA
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

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x000451C5 File Offset: 0x000441C5
		// (set) Token: 0x06003F68 RID: 16232 RVA: 0x000451D3 File Offset: 0x000441D3
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

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x000451DD File Offset: 0x000441DD
		// (set) Token: 0x06003F6A RID: 16234 RVA: 0x000451EC File Offset: 0x000441EC
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

		// Token: 0x06003F6B RID: 16235 RVA: 0x000451F7 File Offset: 0x000441F7
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x0004520A File Offset: 0x0004420A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06003F6D RID: 16237 RVA: 0x00045219 File Offset: 0x00044219
		// (set) Token: 0x06003F6E RID: 16238 RVA: 0x0004522B File Offset: 0x0004422B
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

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06003F6F RID: 16239 RVA: 0x00045239 File Offset: 0x00044239
		// (set) Token: 0x06003F70 RID: 16240 RVA: 0x0004524B File Offset: 0x0004424B
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

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x00045259 File Offset: 0x00044259
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x00045268 File Offset: 0x00044268
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

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x00045273 File Offset: 0x00044273
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x00045282 File Offset: 0x00044282
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

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x0004528D File Offset: 0x0004428D
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x0004529C File Offset: 0x0004429C
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

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x000452A7 File Offset: 0x000442A7
		// (set) Token: 0x06003F78 RID: 16248 RVA: 0x000452B6 File Offset: 0x000442B6
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

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x000452C1 File Offset: 0x000442C1
		// (set) Token: 0x06003F7A RID: 16250 RVA: 0x000452D3 File Offset: 0x000442D3
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

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x000452E1 File Offset: 0x000442E1
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x000452F3 File Offset: 0x000442F3
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

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x00045301 File Offset: 0x00044301
		// (set) Token: 0x06003F7E RID: 16254 RVA: 0x00045313 File Offset: 0x00044313
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

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x00045321 File Offset: 0x00044321
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x00045333 File Offset: 0x00044333
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

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x00045341 File Offset: 0x00044341
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x00045353 File Offset: 0x00044353
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

		// Token: 0x06003F83 RID: 16259 RVA: 0x00045361 File Offset: 0x00044361
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x0004537F File Offset: 0x0004437F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06003F85 RID: 16261 RVA: 0x0004539C File Offset: 0x0004439C
		// (set) Token: 0x06003F86 RID: 16262 RVA: 0x000453AE File Offset: 0x000443AE
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

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x000453BC File Offset: 0x000443BC
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x000453CE File Offset: 0x000443CE
		[FIXField("131", EFieldOption.Required)]
		public string QuoteReqID
		{
			get
			{
				return this.GetStringField(131).Value;
			}
			set
			{
				this.AddStringField(131, value);
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x000453DC File Offset: 0x000443DC
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x000453EE File Offset: 0x000443EE
		[FIXField("644", EFieldOption.Optional)]
		public string RFQReqID
		{
			get
			{
				return this.GetStringField(644).Value;
			}
			set
			{
				this.AddStringField(644, value);
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x000453FC File Offset: 0x000443FC
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x0004540B File Offset: 0x0004440B
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

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x00045416 File Offset: 0x00044416
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x00045428 File Offset: 0x00044428
		[FIXField("528", EFieldOption.Optional)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharField(528).Value;
			}
			set
			{
				this.AddCharField(528, value);
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x00045436 File Offset: 0x00044436
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x00045448 File Offset: 0x00044448
		[FIXField("146", EFieldOption.Required)]
		public int NoRelatedSym
		{
			get
			{
				return this.GetIntField(146).Value;
			}
			set
			{
				this.AddIntField(146, value);
			}
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00045456 File Offset: 0x00044456
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00045474 File Offset: 0x00044474
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06003F93 RID: 16275 RVA: 0x00045491 File Offset: 0x00044491
		// (set) Token: 0x06003F94 RID: 16276 RVA: 0x000454A0 File Offset: 0x000444A0
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

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x000454AB File Offset: 0x000444AB
		// (set) Token: 0x06003F96 RID: 16278 RVA: 0x000454BD File Offset: 0x000444BD
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

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x000454CB File Offset: 0x000444CB
		// (set) Token: 0x06003F98 RID: 16280 RVA: 0x000454DD File Offset: 0x000444DD
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

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x000454EB File Offset: 0x000444EB
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x000454FA File Offset: 0x000444FA
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

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x00045505 File Offset: 0x00044505
		// (set) Token: 0x06003F9C RID: 16284 RVA: 0x00045514 File Offset: 0x00044514
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

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x0004551F File Offset: 0x0004451F
		// (set) Token: 0x06003F9E RID: 16286 RVA: 0x0004552E File Offset: 0x0004452E
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

		// Token: 0x06003F9F RID: 16287 RVA: 0x00045539 File Offset: 0x00044539
		public FIXQuoteRequest()
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00045562 File Offset: 0x00044562
		public FIXQuoteRequest(string QuoteReqID, int NoRelatedSym)
		{
			this.QuoteReqID = QuoteReqID;
			this.NoRelatedSym = NoRelatedSym;
		}

		// Token: 0x04000951 RID: 2385
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000952 RID: 2386
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000953 RID: 2387
		private ArrayList fRelatedSymGroup = new ArrayList();
	}
}
