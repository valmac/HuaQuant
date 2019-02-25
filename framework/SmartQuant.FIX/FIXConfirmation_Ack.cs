using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200018C RID: 396
	public class FIXConfirmation_Ack : FIXMessage
	{
		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x00053153 File Offset: 0x00052153
		// (set) Token: 0x06004B22 RID: 19234 RVA: 0x00053165 File Offset: 0x00052165
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

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x00053173 File Offset: 0x00052173
		// (set) Token: 0x06004B24 RID: 19236 RVA: 0x00053182 File Offset: 0x00052182
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

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x0005318D File Offset: 0x0005218D
		// (set) Token: 0x06004B26 RID: 19238 RVA: 0x0005319C File Offset: 0x0005219C
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

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x000531A7 File Offset: 0x000521A7
		// (set) Token: 0x06004B28 RID: 19240 RVA: 0x000531B6 File Offset: 0x000521B6
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

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06004B29 RID: 19241 RVA: 0x000531C1 File Offset: 0x000521C1
		// (set) Token: 0x06004B2A RID: 19242 RVA: 0x000531D0 File Offset: 0x000521D0
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

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06004B2B RID: 19243 RVA: 0x000531DB File Offset: 0x000521DB
		// (set) Token: 0x06004B2C RID: 19244 RVA: 0x000531EA File Offset: 0x000521EA
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

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06004B2D RID: 19245 RVA: 0x000531F5 File Offset: 0x000521F5
		// (set) Token: 0x06004B2E RID: 19246 RVA: 0x00053207 File Offset: 0x00052207
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

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06004B2F RID: 19247 RVA: 0x00053215 File Offset: 0x00052215
		// (set) Token: 0x06004B30 RID: 19248 RVA: 0x00053224 File Offset: 0x00052224
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

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x0005322F File Offset: 0x0005222F
		// (set) Token: 0x06004B32 RID: 19250 RVA: 0x0005323E File Offset: 0x0005223E
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

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x00053249 File Offset: 0x00052249
		// (set) Token: 0x06004B34 RID: 19252 RVA: 0x00053258 File Offset: 0x00052258
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

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x00053263 File Offset: 0x00052263
		// (set) Token: 0x06004B36 RID: 19254 RVA: 0x00053272 File Offset: 0x00052272
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

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x0005327D File Offset: 0x0005227D
		// (set) Token: 0x06004B38 RID: 19256 RVA: 0x0005328F File Offset: 0x0005228F
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

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x0005329D File Offset: 0x0005229D
		// (set) Token: 0x06004B3A RID: 19258 RVA: 0x000532AC File Offset: 0x000522AC
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

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06004B3B RID: 19259 RVA: 0x000532B7 File Offset: 0x000522B7
		// (set) Token: 0x06004B3C RID: 19260 RVA: 0x000532C5 File Offset: 0x000522C5
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

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06004B3D RID: 19261 RVA: 0x000532CF File Offset: 0x000522CF
		// (set) Token: 0x06004B3E RID: 19262 RVA: 0x000532DE File Offset: 0x000522DE
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

		// Token: 0x06004B3F RID: 19263 RVA: 0x000532E9 File Offset: 0x000522E9
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x000532FC File Offset: 0x000522FC
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x0005330B File Offset: 0x0005230B
		// (set) Token: 0x06004B42 RID: 19266 RVA: 0x0005331D File Offset: 0x0005231D
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

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x0005332B File Offset: 0x0005232B
		// (set) Token: 0x06004B44 RID: 19268 RVA: 0x0005333D File Offset: 0x0005233D
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

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06004B45 RID: 19269 RVA: 0x0005334B File Offset: 0x0005234B
		// (set) Token: 0x06004B46 RID: 19270 RVA: 0x0005335A File Offset: 0x0005235A
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

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x00053365 File Offset: 0x00052365
		// (set) Token: 0x06004B48 RID: 19272 RVA: 0x00053374 File Offset: 0x00052374
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

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x0005337F File Offset: 0x0005237F
		// (set) Token: 0x06004B4A RID: 19274 RVA: 0x0005338E File Offset: 0x0005238E
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

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x00053399 File Offset: 0x00052399
		// (set) Token: 0x06004B4C RID: 19276 RVA: 0x000533A8 File Offset: 0x000523A8
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

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x000533B3 File Offset: 0x000523B3
		// (set) Token: 0x06004B4E RID: 19278 RVA: 0x000533C5 File Offset: 0x000523C5
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

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06004B4F RID: 19279 RVA: 0x000533D3 File Offset: 0x000523D3
		// (set) Token: 0x06004B50 RID: 19280 RVA: 0x000533E5 File Offset: 0x000523E5
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

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x000533F3 File Offset: 0x000523F3
		// (set) Token: 0x06004B52 RID: 19282 RVA: 0x00053405 File Offset: 0x00052405
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

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06004B53 RID: 19283 RVA: 0x00053413 File Offset: 0x00052413
		// (set) Token: 0x06004B54 RID: 19284 RVA: 0x00053425 File Offset: 0x00052425
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

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x00053433 File Offset: 0x00052433
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x00053445 File Offset: 0x00052445
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

		// Token: 0x06004B57 RID: 19287 RVA: 0x00053453 File Offset: 0x00052453
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00053471 File Offset: 0x00052471
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x0005348E File Offset: 0x0005248E
		// (set) Token: 0x06004B5A RID: 19290 RVA: 0x000534A0 File Offset: 0x000524A0
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

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06004B5B RID: 19291 RVA: 0x000534AE File Offset: 0x000524AE
		// (set) Token: 0x06004B5C RID: 19292 RVA: 0x000534C0 File Offset: 0x000524C0
		[FIXField("664", EFieldOption.Required)]
		public string ConfirmID
		{
			get
			{
				return this.GetStringField(664).Value;
			}
			set
			{
				this.AddStringField(664, value);
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x000534CE File Offset: 0x000524CE
		// (set) Token: 0x06004B5E RID: 19294 RVA: 0x000534DD File Offset: 0x000524DD
		[FIXField("75", EFieldOption.Required)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeField(75).Value;
			}
			set
			{
				this.AddDateTimeField(75, value);
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x000534E8 File Offset: 0x000524E8
		// (set) Token: 0x06004B60 RID: 19296 RVA: 0x000534F7 File Offset: 0x000524F7
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

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06004B61 RID: 19297 RVA: 0x00053502 File Offset: 0x00052502
		// (set) Token: 0x06004B62 RID: 19298 RVA: 0x00053514 File Offset: 0x00052514
		[FIXField("940", EFieldOption.Required)]
		public int AffirmStatus
		{
			get
			{
				return this.GetIntField(940).Value;
			}
			set
			{
				this.AddIntField(940, value);
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06004B63 RID: 19299 RVA: 0x00053522 File Offset: 0x00052522
		// (set) Token: 0x06004B64 RID: 19300 RVA: 0x00053534 File Offset: 0x00052534
		[FIXField("774", EFieldOption.Optional)]
		public int ConfirmRejReason
		{
			get
			{
				return this.GetIntField(774).Value;
			}
			set
			{
				this.AddIntField(774, value);
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06004B65 RID: 19301 RVA: 0x00053542 File Offset: 0x00052542
		// (set) Token: 0x06004B66 RID: 19302 RVA: 0x00053554 File Offset: 0x00052554
		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharField(573).Value;
			}
			set
			{
				this.AddCharField(573, value);
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06004B67 RID: 19303 RVA: 0x00053562 File Offset: 0x00052562
		// (set) Token: 0x06004B68 RID: 19304 RVA: 0x00053571 File Offset: 0x00052571
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

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x0005357C File Offset: 0x0005257C
		// (set) Token: 0x06004B6A RID: 19306 RVA: 0x0005358E File Offset: 0x0005258E
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

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x0005359C File Offset: 0x0005259C
		// (set) Token: 0x06004B6C RID: 19308 RVA: 0x000535AE File Offset: 0x000525AE
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

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x000535BC File Offset: 0x000525BC
		// (set) Token: 0x06004B6E RID: 19310 RVA: 0x000535CB File Offset: 0x000525CB
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

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x000535D6 File Offset: 0x000525D6
		// (set) Token: 0x06004B70 RID: 19312 RVA: 0x000535E5 File Offset: 0x000525E5
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

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x000535F0 File Offset: 0x000525F0
		// (set) Token: 0x06004B72 RID: 19314 RVA: 0x000535FF File Offset: 0x000525FF
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

		// Token: 0x06004B73 RID: 19315 RVA: 0x0005360A File Offset: 0x0005260A
		public FIXConfirmation_Ack()
		{
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00053628 File Offset: 0x00052628
		public FIXConfirmation_Ack(string ConfirmID, DateTime TradeDate, DateTime TransactTime, int AffirmStatus)
		{
			this.ConfirmID = ConfirmID;
			this.TradeDate = TradeDate;
			this.TransactTime = TransactTime;
			this.AffirmStatus = AffirmStatus;
		}

		// Token: 0x04000DC0 RID: 3520
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000DC1 RID: 3521
		private ArrayList fHopsGroup = new ArrayList();
	}
}
