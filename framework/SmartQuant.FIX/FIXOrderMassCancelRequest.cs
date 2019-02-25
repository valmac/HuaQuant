using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000182 RID: 386
	public class FIXOrderMassCancelRequest : FIXMessage
	{
		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x0004F164 File Offset: 0x0004E164
		// (set) Token: 0x06004746 RID: 18246 RVA: 0x0004F176 File Offset: 0x0004E176
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

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x0004F184 File Offset: 0x0004E184
		// (set) Token: 0x06004748 RID: 18248 RVA: 0x0004F193 File Offset: 0x0004E193
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

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x0004F19E File Offset: 0x0004E19E
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x0004F1AD File Offset: 0x0004E1AD
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

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x0004F1B8 File Offset: 0x0004E1B8
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x0004F1C7 File Offset: 0x0004E1C7
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

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x0004F1D2 File Offset: 0x0004E1D2
		// (set) Token: 0x0600474E RID: 18254 RVA: 0x0004F1E1 File Offset: 0x0004E1E1
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

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x0004F1EC File Offset: 0x0004E1EC
		// (set) Token: 0x06004750 RID: 18256 RVA: 0x0004F1FB File Offset: 0x0004E1FB
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

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x0004F206 File Offset: 0x0004E206
		// (set) Token: 0x06004752 RID: 18258 RVA: 0x0004F218 File Offset: 0x0004E218
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

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x0004F226 File Offset: 0x0004E226
		// (set) Token: 0x06004754 RID: 18260 RVA: 0x0004F235 File Offset: 0x0004E235
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

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x0004F240 File Offset: 0x0004E240
		// (set) Token: 0x06004756 RID: 18262 RVA: 0x0004F24F File Offset: 0x0004E24F
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

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x0004F25A File Offset: 0x0004E25A
		// (set) Token: 0x06004758 RID: 18264 RVA: 0x0004F269 File Offset: 0x0004E269
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

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x0004F274 File Offset: 0x0004E274
		// (set) Token: 0x0600475A RID: 18266 RVA: 0x0004F283 File Offset: 0x0004E283
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

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x0004F28E File Offset: 0x0004E28E
		// (set) Token: 0x0600475C RID: 18268 RVA: 0x0004F2A0 File Offset: 0x0004E2A0
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

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x0004F2AE File Offset: 0x0004E2AE
		// (set) Token: 0x0600475E RID: 18270 RVA: 0x0004F2BD File Offset: 0x0004E2BD
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

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x0004F2C8 File Offset: 0x0004E2C8
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x0004F2D6 File Offset: 0x0004E2D6
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

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x0004F2E0 File Offset: 0x0004E2E0
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x0004F2EF File Offset: 0x0004E2EF
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

		// Token: 0x06004763 RID: 18275 RVA: 0x0004F2FA File Offset: 0x0004E2FA
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x0004F30D File Offset: 0x0004E30D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x0004F31C File Offset: 0x0004E31C
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x0004F32E File Offset: 0x0004E32E
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

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x0004F33C File Offset: 0x0004E33C
		// (set) Token: 0x06004768 RID: 18280 RVA: 0x0004F34E File Offset: 0x0004E34E
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

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x0004F35C File Offset: 0x0004E35C
		// (set) Token: 0x0600476A RID: 18282 RVA: 0x0004F36B File Offset: 0x0004E36B
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

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x0004F376 File Offset: 0x0004E376
		// (set) Token: 0x0600476C RID: 18284 RVA: 0x0004F385 File Offset: 0x0004E385
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

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x0004F390 File Offset: 0x0004E390
		// (set) Token: 0x0600476E RID: 18286 RVA: 0x0004F39F File Offset: 0x0004E39F
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

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x0004F3AA File Offset: 0x0004E3AA
		// (set) Token: 0x06004770 RID: 18288 RVA: 0x0004F3B9 File Offset: 0x0004E3B9
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

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06004771 RID: 18289 RVA: 0x0004F3C4 File Offset: 0x0004E3C4
		// (set) Token: 0x06004772 RID: 18290 RVA: 0x0004F3D6 File Offset: 0x0004E3D6
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

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x0004F3E4 File Offset: 0x0004E3E4
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x0004F3F6 File Offset: 0x0004E3F6
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

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x0004F404 File Offset: 0x0004E404
		// (set) Token: 0x06004776 RID: 18294 RVA: 0x0004F416 File Offset: 0x0004E416
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

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x0004F424 File Offset: 0x0004E424
		// (set) Token: 0x06004778 RID: 18296 RVA: 0x0004F436 File Offset: 0x0004E436
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

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06004779 RID: 18297 RVA: 0x0004F444 File Offset: 0x0004E444
		// (set) Token: 0x0600477A RID: 18298 RVA: 0x0004F456 File Offset: 0x0004E456
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

		// Token: 0x0600477B RID: 18299 RVA: 0x0004F464 File Offset: 0x0004E464
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0004F482 File Offset: 0x0004E482
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x0004F49F File Offset: 0x0004E49F
		// (set) Token: 0x0600477E RID: 18302 RVA: 0x0004F4B1 File Offset: 0x0004E4B1
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

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x0004F4BF File Offset: 0x0004E4BF
		// (set) Token: 0x06004780 RID: 18304 RVA: 0x0004F4CE File Offset: 0x0004E4CE
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

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x0004F4D9 File Offset: 0x0004E4D9
		// (set) Token: 0x06004782 RID: 18306 RVA: 0x0004F4EB File Offset: 0x0004E4EB
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

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x0004F4F9 File Offset: 0x0004E4F9
		// (set) Token: 0x06004784 RID: 18308 RVA: 0x0004F50B File Offset: 0x0004E50B
		[FIXField("530", EFieldOption.Required)]
		public char MassCancelRequestType
		{
			get
			{
				return this.GetCharField(530).Value;
			}
			set
			{
				this.AddCharField(530, value);
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x0004F519 File Offset: 0x0004E519
		// (set) Token: 0x06004786 RID: 18310 RVA: 0x0004F52B File Offset: 0x0004E52B
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

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06004787 RID: 18311 RVA: 0x0004F539 File Offset: 0x0004E539
		// (set) Token: 0x06004788 RID: 18312 RVA: 0x0004F54B File Offset: 0x0004E54B
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

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x0004F559 File Offset: 0x0004E559
		// (set) Token: 0x0600478A RID: 18314 RVA: 0x0004F568 File Offset: 0x0004E568
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

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600478B RID: 18315 RVA: 0x0004F573 File Offset: 0x0004E573
		// (set) Token: 0x0600478C RID: 18316 RVA: 0x0004F582 File Offset: 0x0004E582
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

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600478D RID: 18317 RVA: 0x0004F58D File Offset: 0x0004E58D
		// (set) Token: 0x0600478E RID: 18318 RVA: 0x0004F59C File Offset: 0x0004E59C
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

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600478F RID: 18319 RVA: 0x0004F5A7 File Offset: 0x0004E5A7
		// (set) Token: 0x06004790 RID: 18320 RVA: 0x0004F5B6 File Offset: 0x0004E5B6
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

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x0004F5C1 File Offset: 0x0004E5C1
		// (set) Token: 0x06004792 RID: 18322 RVA: 0x0004F5D3 File Offset: 0x0004E5D3
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

		// Token: 0x06004793 RID: 18323 RVA: 0x0004F5E1 File Offset: 0x0004E5E1
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x0004F5FF File Offset: 0x0004E5FF
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x0004F61C File Offset: 0x0004E61C
		// (set) Token: 0x06004796 RID: 18326 RVA: 0x0004F62E File Offset: 0x0004E62E
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

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x0004F63C File Offset: 0x0004E63C
		// (set) Token: 0x06004798 RID: 18328 RVA: 0x0004F64E File Offset: 0x0004E64E
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

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x0004F65C File Offset: 0x0004E65C
		// (set) Token: 0x0600479A RID: 18330 RVA: 0x0004F66E File Offset: 0x0004E66E
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

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x0004F67C File Offset: 0x0004E67C
		// (set) Token: 0x0600479C RID: 18332 RVA: 0x0004F68E File Offset: 0x0004E68E
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

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600479D RID: 18333 RVA: 0x0004F69C File Offset: 0x0004E69C
		// (set) Token: 0x0600479E RID: 18334 RVA: 0x0004F6AE File Offset: 0x0004E6AE
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

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x0004F6BC File Offset: 0x0004E6BC
		// (set) Token: 0x060047A0 RID: 18336 RVA: 0x0004F6CE File Offset: 0x0004E6CE
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

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x0004F6DC File Offset: 0x0004E6DC
		// (set) Token: 0x060047A2 RID: 18338 RVA: 0x0004F6EE File Offset: 0x0004E6EE
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

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x0004F6FC File Offset: 0x0004E6FC
		// (set) Token: 0x060047A4 RID: 18340 RVA: 0x0004F70E File Offset: 0x0004E70E
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

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x0004F71C File Offset: 0x0004E71C
		// (set) Token: 0x060047A6 RID: 18342 RVA: 0x0004F72E File Offset: 0x0004E72E
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

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x0004F73C File Offset: 0x0004E73C
		// (set) Token: 0x060047A8 RID: 18344 RVA: 0x0004F74E File Offset: 0x0004E74E
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

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x0004F75C File Offset: 0x0004E75C
		// (set) Token: 0x060047AA RID: 18346 RVA: 0x0004F76E File Offset: 0x0004E76E
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

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x0004F77C File Offset: 0x0004E77C
		// (set) Token: 0x060047AC RID: 18348 RVA: 0x0004F78E File Offset: 0x0004E78E
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

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x0004F79C File Offset: 0x0004E79C
		// (set) Token: 0x060047AE RID: 18350 RVA: 0x0004F7AE File Offset: 0x0004E7AE
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

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x0004F7BC File Offset: 0x0004E7BC
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x0004F7CE File Offset: 0x0004E7CE
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

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x0004F7DC File Offset: 0x0004E7DC
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x0004F7EE File Offset: 0x0004E7EE
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

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x0004F7FC File Offset: 0x0004E7FC
		// (set) Token: 0x060047B4 RID: 18356 RVA: 0x0004F80E File Offset: 0x0004E80E
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

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x0004F81C File Offset: 0x0004E81C
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x0004F82E File Offset: 0x0004E82E
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

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x0004F83C File Offset: 0x0004E83C
		// (set) Token: 0x060047B8 RID: 18360 RVA: 0x0004F84E File Offset: 0x0004E84E
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

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x0004F85C File Offset: 0x0004E85C
		// (set) Token: 0x060047BA RID: 18362 RVA: 0x0004F86E File Offset: 0x0004E86E
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

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x0004F87C File Offset: 0x0004E87C
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x0004F88E File Offset: 0x0004E88E
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

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x0004F89C File Offset: 0x0004E89C
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x0004F8AE File Offset: 0x0004E8AE
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

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x0004F8BC File Offset: 0x0004E8BC
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x0004F8CE File Offset: 0x0004E8CE
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

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0004F8DC File Offset: 0x0004E8DC
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x0004F8EE File Offset: 0x0004E8EE
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

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x0004F8FC File Offset: 0x0004E8FC
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x0004F90E File Offset: 0x0004E90E
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

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x0004F91C File Offset: 0x0004E91C
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x0004F92B File Offset: 0x0004E92B
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

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x0004F936 File Offset: 0x0004E936
		// (set) Token: 0x060047C8 RID: 18376 RVA: 0x0004F948 File Offset: 0x0004E948
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

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x0004F956 File Offset: 0x0004E956
		// (set) Token: 0x060047CA RID: 18378 RVA: 0x0004F968 File Offset: 0x0004E968
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

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x0004F976 File Offset: 0x0004E976
		// (set) Token: 0x060047CC RID: 18380 RVA: 0x0004F985 File Offset: 0x0004E985
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

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x0004F990 File Offset: 0x0004E990
		// (set) Token: 0x060047CE RID: 18382 RVA: 0x0004F9A2 File Offset: 0x0004E9A2
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

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x0004F9B0 File Offset: 0x0004E9B0
		// (set) Token: 0x060047D0 RID: 18384 RVA: 0x0004F9C2 File Offset: 0x0004E9C2
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

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x0004F9D0 File Offset: 0x0004E9D0
		// (set) Token: 0x060047D2 RID: 18386 RVA: 0x0004F9E2 File Offset: 0x0004E9E2
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

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x0004F9F0 File Offset: 0x0004E9F0
		// (set) Token: 0x060047D4 RID: 18388 RVA: 0x0004FA02 File Offset: 0x0004EA02
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

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0004FA10 File Offset: 0x0004EA10
		// (set) Token: 0x060047D6 RID: 18390 RVA: 0x0004FA22 File Offset: 0x0004EA22
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

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x0004FA30 File Offset: 0x0004EA30
		// (set) Token: 0x060047D8 RID: 18392 RVA: 0x0004FA42 File Offset: 0x0004EA42
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

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x0004FA50 File Offset: 0x0004EA50
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x0004FA62 File Offset: 0x0004EA62
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

		// Token: 0x060047DB RID: 18395 RVA: 0x0004FA70 File Offset: 0x0004EA70
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0004FA8E File Offset: 0x0004EA8E
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x0004FAAB File Offset: 0x0004EAAB
		// (set) Token: 0x060047DE RID: 18398 RVA: 0x0004FABD File Offset: 0x0004EABD
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

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x0004FACB File Offset: 0x0004EACB
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x0004FADD File Offset: 0x0004EADD
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

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x0004FAEB File Offset: 0x0004EAEB
		// (set) Token: 0x060047E2 RID: 18402 RVA: 0x0004FAFD File Offset: 0x0004EAFD
		[FIXField("311", EFieldOption.Optional)]
		public string UnderlyingSymbol
		{
			get
			{
				return this.GetStringField(311).Value;
			}
			set
			{
				this.AddStringField(311, value);
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x0004FB0B File Offset: 0x0004EB0B
		// (set) Token: 0x060047E4 RID: 18404 RVA: 0x0004FB1D File Offset: 0x0004EB1D
		[FIXField("312", EFieldOption.Optional)]
		public string UnderlyingSymbolSfx
		{
			get
			{
				return this.GetStringField(312).Value;
			}
			set
			{
				this.AddStringField(312, value);
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x0004FB2B File Offset: 0x0004EB2B
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x0004FB3D File Offset: 0x0004EB3D
		[FIXField("309", EFieldOption.Optional)]
		public string UnderlyingSecurityID
		{
			get
			{
				return this.GetStringField(309).Value;
			}
			set
			{
				this.AddStringField(309, value);
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x0004FB4B File Offset: 0x0004EB4B
		// (set) Token: 0x060047E8 RID: 18408 RVA: 0x0004FB5D File Offset: 0x0004EB5D
		[FIXField("305", EFieldOption.Optional)]
		public string UnderlyingSecurityIDSource
		{
			get
			{
				return this.GetStringField(305).Value;
			}
			set
			{
				this.AddStringField(305, value);
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x0004FB6B File Offset: 0x0004EB6B
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x0004FB7D File Offset: 0x0004EB7D
		[FIXField("457", EFieldOption.Optional)]
		public int NoUnderlyingSecurityAltID
		{
			get
			{
				return this.GetIntField(457).Value;
			}
			set
			{
				this.AddIntField(457, value);
			}
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x0004FB8B File Offset: 0x0004EB8B
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x0004FBA9 File Offset: 0x0004EBA9
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x0004FBC6 File Offset: 0x0004EBC6
		// (set) Token: 0x060047EE RID: 18414 RVA: 0x0004FBD8 File Offset: 0x0004EBD8
		[FIXField("462", EFieldOption.Optional)]
		public int UnderlyingProduct
		{
			get
			{
				return this.GetIntField(462).Value;
			}
			set
			{
				this.AddIntField(462, value);
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x0004FBE6 File Offset: 0x0004EBE6
		// (set) Token: 0x060047F0 RID: 18416 RVA: 0x0004FBF8 File Offset: 0x0004EBF8
		[FIXField("463", EFieldOption.Optional)]
		public string UnderlyingCFICode
		{
			get
			{
				return this.GetStringField(463).Value;
			}
			set
			{
				this.AddStringField(463, value);
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x0004FC06 File Offset: 0x0004EC06
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x0004FC18 File Offset: 0x0004EC18
		[FIXField("310", EFieldOption.Optional)]
		public string UnderlyingSecurityType
		{
			get
			{
				return this.GetStringField(310).Value;
			}
			set
			{
				this.AddStringField(310, value);
			}
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x0004FC26 File Offset: 0x0004EC26
		// (set) Token: 0x060047F4 RID: 18420 RVA: 0x0004FC38 File Offset: 0x0004EC38
		[FIXField("763", EFieldOption.Optional)]
		public string UnderlyingSecuritySubType
		{
			get
			{
				return this.GetStringField(763).Value;
			}
			set
			{
				this.AddStringField(763, value);
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x0004FC46 File Offset: 0x0004EC46
		// (set) Token: 0x060047F6 RID: 18422 RVA: 0x0004FC58 File Offset: 0x0004EC58
		[FIXField("313", EFieldOption.Optional)]
		public string UnderlyingMaturityMonthYear
		{
			get
			{
				return this.GetStringField(313).Value;
			}
			set
			{
				this.AddStringField(313, value);
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x0004FC66 File Offset: 0x0004EC66
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x0004FC78 File Offset: 0x0004EC78
		[FIXField("542", EFieldOption.Optional)]
		public DateTime UnderlyingMaturityDate
		{
			get
			{
				return this.GetDateTimeField(542).Value;
			}
			set
			{
				this.AddDateTimeField(542, value);
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x0004FC86 File Offset: 0x0004EC86
		// (set) Token: 0x060047FA RID: 18426 RVA: 0x0004FC98 File Offset: 0x0004EC98
		[FIXField("241", EFieldOption.Optional)]
		public DateTime UnderlyingCouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(241).Value;
			}
			set
			{
				this.AddDateTimeField(241, value);
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x0004FCA6 File Offset: 0x0004ECA6
		// (set) Token: 0x060047FC RID: 18428 RVA: 0x0004FCB8 File Offset: 0x0004ECB8
		[FIXField("242", EFieldOption.Optional)]
		public DateTime UnderlyingIssueDate
		{
			get
			{
				return this.GetDateTimeField(242).Value;
			}
			set
			{
				this.AddDateTimeField(242, value);
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x0004FCC6 File Offset: 0x0004ECC6
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x0004FCD8 File Offset: 0x0004ECD8
		[FIXField("243", EFieldOption.Optional)]
		public int UnderlyingRepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(243).Value;
			}
			set
			{
				this.AddIntField(243, value);
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x0004FCE6 File Offset: 0x0004ECE6
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x0004FCF8 File Offset: 0x0004ECF8
		[FIXField("244", EFieldOption.Optional)]
		public int UnderlyingRepurchaseTerm
		{
			get
			{
				return this.GetIntField(244).Value;
			}
			set
			{
				this.AddIntField(244, value);
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x0004FD06 File Offset: 0x0004ED06
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x0004FD18 File Offset: 0x0004ED18
		[FIXField("245", EFieldOption.Optional)]
		public double UnderlyingRepurchaseRate
		{
			get
			{
				return this.GetDoubleField(245).Value;
			}
			set
			{
				this.AddDoubleField(245, value);
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x0004FD26 File Offset: 0x0004ED26
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x0004FD38 File Offset: 0x0004ED38
		[FIXField("246", EFieldOption.Optional)]
		public double UnderlyingFactor
		{
			get
			{
				return this.GetDoubleField(246).Value;
			}
			set
			{
				this.AddDoubleField(246, value);
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x0004FD46 File Offset: 0x0004ED46
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x0004FD58 File Offset: 0x0004ED58
		[FIXField("256", EFieldOption.Optional)]
		public string UnderlyingCreditRating
		{
			get
			{
				return this.GetStringField(256).Value;
			}
			set
			{
				this.AddStringField(256, value);
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x0004FD66 File Offset: 0x0004ED66
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x0004FD78 File Offset: 0x0004ED78
		[FIXField("595", EFieldOption.Optional)]
		public string UnderlyingInstrRegistry
		{
			get
			{
				return this.GetStringField(595).Value;
			}
			set
			{
				this.AddStringField(595, value);
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x0004FD86 File Offset: 0x0004ED86
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x0004FD98 File Offset: 0x0004ED98
		[FIXField("592", EFieldOption.Optional)]
		public string UnderlyingCountryOfIssue
		{
			get
			{
				return this.GetStringField(592).Value;
			}
			set
			{
				this.AddStringField(592, value);
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x0004FDA6 File Offset: 0x0004EDA6
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x0004FDB8 File Offset: 0x0004EDB8
		[FIXField("593", EFieldOption.Optional)]
		public string UnderlyingStateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(593).Value;
			}
			set
			{
				this.AddStringField(593, value);
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x0004FDC6 File Offset: 0x0004EDC6
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x0004FDD8 File Offset: 0x0004EDD8
		[FIXField("594", EFieldOption.Optional)]
		public string UnderlyingLocaleOfIssue
		{
			get
			{
				return this.GetStringField(594).Value;
			}
			set
			{
				this.AddStringField(594, value);
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x0004FDE6 File Offset: 0x0004EDE6
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x0004FDF8 File Offset: 0x0004EDF8
		[FIXField("247", EFieldOption.Optional)]
		public DateTime UnderlyingRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(247).Value;
			}
			set
			{
				this.AddDateTimeField(247, value);
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0004FE06 File Offset: 0x0004EE06
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x0004FE18 File Offset: 0x0004EE18
		[FIXField("316", EFieldOption.Optional)]
		public double UnderlyingStrikePrice
		{
			get
			{
				return this.GetDoubleField(316).Value;
			}
			set
			{
				this.AddDoubleField(316, value);
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x0004FE26 File Offset: 0x0004EE26
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x0004FE38 File Offset: 0x0004EE38
		[FIXField("941", EFieldOption.Optional)]
		public double UnderlyingStrikeCurrency
		{
			get
			{
				return this.GetDoubleField(941).Value;
			}
			set
			{
				this.AddDoubleField(941, value);
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x0004FE46 File Offset: 0x0004EE46
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x0004FE58 File Offset: 0x0004EE58
		[FIXField("317", EFieldOption.Optional)]
		public char UnderlyingOptAttribute
		{
			get
			{
				return this.GetCharField(317).Value;
			}
			set
			{
				this.AddCharField(317, value);
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x0004FE66 File Offset: 0x0004EE66
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x0004FE78 File Offset: 0x0004EE78
		[FIXField("436", EFieldOption.Optional)]
		public double UnderlyingContractMultiplier
		{
			get
			{
				return this.GetDoubleField(436).Value;
			}
			set
			{
				this.AddDoubleField(436, value);
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x0004FE86 File Offset: 0x0004EE86
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x0004FE98 File Offset: 0x0004EE98
		[FIXField("435", EFieldOption.Optional)]
		public double UnderlyingCouponRate
		{
			get
			{
				return this.GetDoubleField(435).Value;
			}
			set
			{
				this.AddDoubleField(435, value);
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x0004FEA6 File Offset: 0x0004EEA6
		// (set) Token: 0x0600481C RID: 18460 RVA: 0x0004FEB8 File Offset: 0x0004EEB8
		[FIXField("308", EFieldOption.Optional)]
		public string UnderlyingSecurityExchange
		{
			get
			{
				return this.GetStringField(308).Value;
			}
			set
			{
				this.AddStringField(308, value);
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x0004FEC6 File Offset: 0x0004EEC6
		// (set) Token: 0x0600481E RID: 18462 RVA: 0x0004FED8 File Offset: 0x0004EED8
		[FIXField("306", EFieldOption.Optional)]
		public string UnderlyingIssuer
		{
			get
			{
				return this.GetStringField(306).Value;
			}
			set
			{
				this.AddStringField(306, value);
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x0004FEE6 File Offset: 0x0004EEE6
		// (set) Token: 0x06004820 RID: 18464 RVA: 0x0004FEF8 File Offset: 0x0004EEF8
		[FIXField("362", EFieldOption.Optional)]
		public int EncodedUnderlyingIssuerLen
		{
			get
			{
				return this.GetIntField(362).Value;
			}
			set
			{
				this.AddIntField(362, value);
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x0004FF06 File Offset: 0x0004EF06
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x0004FF18 File Offset: 0x0004EF18
		[FIXField("363", EFieldOption.Optional)]
		public string EncodedUnderlyingIssuer
		{
			get
			{
				return this.GetStringField(363).Value;
			}
			set
			{
				this.AddStringField(363, value);
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x0004FF26 File Offset: 0x0004EF26
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x0004FF38 File Offset: 0x0004EF38
		[FIXField("307", EFieldOption.Optional)]
		public string UnderlyingSecurityDesc
		{
			get
			{
				return this.GetStringField(307).Value;
			}
			set
			{
				this.AddStringField(307, value);
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x0004FF46 File Offset: 0x0004EF46
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x0004FF58 File Offset: 0x0004EF58
		[FIXField("364", EFieldOption.Optional)]
		public int EncodedUnderlyingSecurityDescLen
		{
			get
			{
				return this.GetIntField(364).Value;
			}
			set
			{
				this.AddIntField(364, value);
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x0004FF66 File Offset: 0x0004EF66
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x0004FF78 File Offset: 0x0004EF78
		[FIXField("365", EFieldOption.Optional)]
		public string EncodedUnderlyingSecurityDesc
		{
			get
			{
				return this.GetStringField(365).Value;
			}
			set
			{
				this.AddStringField(365, value);
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x0004FF86 File Offset: 0x0004EF86
		// (set) Token: 0x0600482A RID: 18474 RVA: 0x0004FF98 File Offset: 0x0004EF98
		[FIXField("877", EFieldOption.Optional)]
		public string UnderlyingCPProgram
		{
			get
			{
				return this.GetStringField(877).Value;
			}
			set
			{
				this.AddStringField(877, value);
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x0004FFA6 File Offset: 0x0004EFA6
		// (set) Token: 0x0600482C RID: 18476 RVA: 0x0004FFB8 File Offset: 0x0004EFB8
		[FIXField("878", EFieldOption.Optional)]
		public string UnderlyingCPRegType
		{
			get
			{
				return this.GetStringField(878).Value;
			}
			set
			{
				this.AddStringField(878, value);
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x0004FFC6 File Offset: 0x0004EFC6
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x0004FFD8 File Offset: 0x0004EFD8
		[FIXField("318", EFieldOption.Optional)]
		public double UnderlyingCurrency
		{
			get
			{
				return this.GetDoubleField(318).Value;
			}
			set
			{
				this.AddDoubleField(318, value);
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x0004FFE6 File Offset: 0x0004EFE6
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x0004FFF8 File Offset: 0x0004EFF8
		[FIXField("879", EFieldOption.Optional)]
		public double UnderlyingQty
		{
			get
			{
				return this.GetDoubleField(879).Value;
			}
			set
			{
				this.AddDoubleField(879, value);
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x00050006 File Offset: 0x0004F006
		// (set) Token: 0x06004832 RID: 18482 RVA: 0x00050018 File Offset: 0x0004F018
		[FIXField("810", EFieldOption.Optional)]
		public double UnderlyingPx
		{
			get
			{
				return this.GetDoubleField(810).Value;
			}
			set
			{
				this.AddDoubleField(810, value);
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x00050026 File Offset: 0x0004F026
		// (set) Token: 0x06004834 RID: 18484 RVA: 0x00050038 File Offset: 0x0004F038
		[FIXField("882", EFieldOption.Optional)]
		public double UnderlyingDirtyPrice
		{
			get
			{
				return this.GetDoubleField(882).Value;
			}
			set
			{
				this.AddDoubleField(882, value);
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x00050046 File Offset: 0x0004F046
		// (set) Token: 0x06004836 RID: 18486 RVA: 0x00050058 File Offset: 0x0004F058
		[FIXField("883", EFieldOption.Optional)]
		public double UnderlyingEndPrice
		{
			get
			{
				return this.GetDoubleField(883).Value;
			}
			set
			{
				this.AddDoubleField(883, value);
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x00050066 File Offset: 0x0004F066
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x00050078 File Offset: 0x0004F078
		[FIXField("884", EFieldOption.Optional)]
		public double UnderlyingStartValue
		{
			get
			{
				return this.GetDoubleField(884).Value;
			}
			set
			{
				this.AddDoubleField(884, value);
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x00050086 File Offset: 0x0004F086
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x00050098 File Offset: 0x0004F098
		[FIXField("885", EFieldOption.Optional)]
		public double UnderlyingCurrentValue
		{
			get
			{
				return this.GetDoubleField(885).Value;
			}
			set
			{
				this.AddDoubleField(885, value);
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x000500A6 File Offset: 0x0004F0A6
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x000500B8 File Offset: 0x0004F0B8
		[FIXField("886", EFieldOption.Optional)]
		public double UnderlyingEndValue
		{
			get
			{
				return this.GetDoubleField(886).Value;
			}
			set
			{
				this.AddDoubleField(886, value);
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x000500C6 File Offset: 0x0004F0C6
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x000500D8 File Offset: 0x0004F0D8
		[FIXField("887", EFieldOption.Optional)]
		public int NoUnderlyingStips
		{
			get
			{
				return this.GetIntField(887).Value;
			}
			set
			{
				this.AddIntField(887, value);
			}
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x000500E6 File Offset: 0x0004F0E6
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00050104 File Offset: 0x0004F104
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x00050121 File Offset: 0x0004F121
		// (set) Token: 0x06004842 RID: 18498 RVA: 0x00050130 File Offset: 0x0004F130
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

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x0005013B File Offset: 0x0004F13B
		// (set) Token: 0x06004844 RID: 18500 RVA: 0x0005014A File Offset: 0x0004F14A
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

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x00050155 File Offset: 0x0004F155
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x00050164 File Offset: 0x0004F164
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

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x0005016F File Offset: 0x0004F16F
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x00050181 File Offset: 0x0004F181
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

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x0005018F File Offset: 0x0004F18F
		// (set) Token: 0x0600484A RID: 18506 RVA: 0x000501A1 File Offset: 0x0004F1A1
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

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x000501AF File Offset: 0x0004F1AF
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x000501BE File Offset: 0x0004F1BE
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

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x000501C9 File Offset: 0x0004F1C9
		// (set) Token: 0x0600484E RID: 18510 RVA: 0x000501D8 File Offset: 0x0004F1D8
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

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x000501E3 File Offset: 0x0004F1E3
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x000501F2 File Offset: 0x0004F1F2
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

		// Token: 0x06004851 RID: 18513 RVA: 0x00050200 File Offset: 0x0004F200
		public FIXOrderMassCancelRequest()
		{
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x00050258 File Offset: 0x0004F258
		public FIXOrderMassCancelRequest(string ClOrdID, char MassCancelRequestType, DateTime TransactTime)
		{
			this.ClOrdID = ClOrdID;
			this.MassCancelRequestType = MassCancelRequestType;
			this.TransactTime = TransactTime;
		}

		// Token: 0x04000D9E RID: 3486
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000D9F RID: 3487
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000DA0 RID: 3488
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000DA1 RID: 3489
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000DA2 RID: 3490
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000DA3 RID: 3491
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
