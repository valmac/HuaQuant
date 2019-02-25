using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200016C RID: 364
	public class FIXOrderMassCancelReport : FIXMessage
	{
		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x0004B2E2 File Offset: 0x0004A2E2
		// (set) Token: 0x06004392 RID: 17298 RVA: 0x0004B2F4 File Offset: 0x0004A2F4
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

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06004393 RID: 17299 RVA: 0x0004B302 File Offset: 0x0004A302
		// (set) Token: 0x06004394 RID: 17300 RVA: 0x0004B311 File Offset: 0x0004A311
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

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x0004B31C File Offset: 0x0004A31C
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x0004B32B File Offset: 0x0004A32B
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

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x0004B336 File Offset: 0x0004A336
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x0004B345 File Offset: 0x0004A345
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

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x0004B350 File Offset: 0x0004A350
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x0004B35F File Offset: 0x0004A35F
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

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x0004B36A File Offset: 0x0004A36A
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x0004B379 File Offset: 0x0004A379
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

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x0004B384 File Offset: 0x0004A384
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x0004B396 File Offset: 0x0004A396
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

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x0004B3A4 File Offset: 0x0004A3A4
		// (set) Token: 0x060043A0 RID: 17312 RVA: 0x0004B3B3 File Offset: 0x0004A3B3
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

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x0004B3BE File Offset: 0x0004A3BE
		// (set) Token: 0x060043A2 RID: 17314 RVA: 0x0004B3CD File Offset: 0x0004A3CD
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

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x0004B3D8 File Offset: 0x0004A3D8
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x0004B3E7 File Offset: 0x0004A3E7
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

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x0004B3F2 File Offset: 0x0004A3F2
		// (set) Token: 0x060043A6 RID: 17318 RVA: 0x0004B401 File Offset: 0x0004A401
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

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x0004B40C File Offset: 0x0004A40C
		// (set) Token: 0x060043A8 RID: 17320 RVA: 0x0004B41E File Offset: 0x0004A41E
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

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x0004B42C File Offset: 0x0004A42C
		// (set) Token: 0x060043AA RID: 17322 RVA: 0x0004B43B File Offset: 0x0004A43B
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

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x0004B446 File Offset: 0x0004A446
		// (set) Token: 0x060043AC RID: 17324 RVA: 0x0004B454 File Offset: 0x0004A454
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

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x060043AD RID: 17325 RVA: 0x0004B45E File Offset: 0x0004A45E
		// (set) Token: 0x060043AE RID: 17326 RVA: 0x0004B46D File Offset: 0x0004A46D
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

		// Token: 0x060043AF RID: 17327 RVA: 0x0004B478 File Offset: 0x0004A478
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0004B48B File Offset: 0x0004A48B
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x0004B49A File Offset: 0x0004A49A
		// (set) Token: 0x060043B2 RID: 17330 RVA: 0x0004B4AC File Offset: 0x0004A4AC
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

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x0004B4BA File Offset: 0x0004A4BA
		// (set) Token: 0x060043B4 RID: 17332 RVA: 0x0004B4CC File Offset: 0x0004A4CC
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

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x060043B5 RID: 17333 RVA: 0x0004B4DA File Offset: 0x0004A4DA
		// (set) Token: 0x060043B6 RID: 17334 RVA: 0x0004B4E9 File Offset: 0x0004A4E9
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

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x0004B4F4 File Offset: 0x0004A4F4
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x0004B503 File Offset: 0x0004A503
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

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x0004B50E File Offset: 0x0004A50E
		// (set) Token: 0x060043BA RID: 17338 RVA: 0x0004B51D File Offset: 0x0004A51D
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

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x0004B528 File Offset: 0x0004A528
		// (set) Token: 0x060043BC RID: 17340 RVA: 0x0004B537 File Offset: 0x0004A537
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

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x0004B542 File Offset: 0x0004A542
		// (set) Token: 0x060043BE RID: 17342 RVA: 0x0004B554 File Offset: 0x0004A554
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

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x0004B562 File Offset: 0x0004A562
		// (set) Token: 0x060043C0 RID: 17344 RVA: 0x0004B574 File Offset: 0x0004A574
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

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x0004B582 File Offset: 0x0004A582
		// (set) Token: 0x060043C2 RID: 17346 RVA: 0x0004B594 File Offset: 0x0004A594
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

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x0004B5A2 File Offset: 0x0004A5A2
		// (set) Token: 0x060043C4 RID: 17348 RVA: 0x0004B5B4 File Offset: 0x0004A5B4
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

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x0004B5C2 File Offset: 0x0004A5C2
		// (set) Token: 0x060043C6 RID: 17350 RVA: 0x0004B5D4 File Offset: 0x0004A5D4
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

		// Token: 0x060043C7 RID: 17351 RVA: 0x0004B5E2 File Offset: 0x0004A5E2
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x0004B600 File Offset: 0x0004A600
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x0004B61D File Offset: 0x0004A61D
		// (set) Token: 0x060043CA RID: 17354 RVA: 0x0004B62F File Offset: 0x0004A62F
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

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x0004B63D File Offset: 0x0004A63D
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x0004B64C File Offset: 0x0004A64C
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

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x0004B657 File Offset: 0x0004A657
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x0004B669 File Offset: 0x0004A669
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

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x0004B677 File Offset: 0x0004A677
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x0004B686 File Offset: 0x0004A686
		[FIXField("37", EFieldOption.Required)]
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

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x0004B691 File Offset: 0x0004A691
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x0004B6A3 File Offset: 0x0004A6A3
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

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x0004B6B1 File Offset: 0x0004A6B1
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x0004B6C3 File Offset: 0x0004A6C3
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

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x0004B6D1 File Offset: 0x0004A6D1
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x0004B6E3 File Offset: 0x0004A6E3
		[FIXField("531", EFieldOption.Required)]
		public char MassCancelResponse
		{
			get
			{
				return this.GetCharField(531).Value;
			}
			set
			{
				this.AddCharField(531, value);
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x0004B6F1 File Offset: 0x0004A6F1
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x0004B703 File Offset: 0x0004A703
		[FIXField("532", EFieldOption.Optional)]
		public char MassCancelRejectReason
		{
			get
			{
				return this.GetCharField(532).Value;
			}
			set
			{
				this.AddCharField(532, value);
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x0004B711 File Offset: 0x0004A711
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x0004B723 File Offset: 0x0004A723
		[FIXField("533", EFieldOption.Optional)]
		public int TotalAffectedOrders
		{
			get
			{
				return this.GetIntField(533).Value;
			}
			set
			{
				this.AddIntField(533, value);
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x0004B731 File Offset: 0x0004A731
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x0004B743 File Offset: 0x0004A743
		[FIXField("534", EFieldOption.Optional)]
		public int NoAffectedOrders
		{
			get
			{
				return this.GetIntField(534).Value;
			}
			set
			{
				this.AddIntField(534, value);
			}
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x0004B751 File Offset: 0x0004A751
		public FIXAffectedOrdersGroup GetAffectedOrdersGroup(int i)
		{
			if (i < this.NoAffectedOrders)
			{
				return (FIXAffectedOrdersGroup)this.fAffectedOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x0004B76F File Offset: 0x0004A76F
		public void AddGroup(FIXAffectedOrdersGroup group)
		{
			this.fAffectedOrdersGroup.Add(group);
			this.NoAffectedOrders++;
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x0004B78C File Offset: 0x0004A78C
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x0004B79E File Offset: 0x0004A79E
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

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x0004B7AC File Offset: 0x0004A7AC
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x0004B7BE File Offset: 0x0004A7BE
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

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x0004B7CC File Offset: 0x0004A7CC
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x0004B7DB File Offset: 0x0004A7DB
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

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x0004B7E6 File Offset: 0x0004A7E6
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x0004B7F5 File Offset: 0x0004A7F5
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

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x0004B800 File Offset: 0x0004A800
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x0004B80F File Offset: 0x0004A80F
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

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x0004B81A File Offset: 0x0004A81A
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x0004B829 File Offset: 0x0004A829
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

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x0004B834 File Offset: 0x0004A834
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x0004B846 File Offset: 0x0004A846
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

		// Token: 0x060043ED RID: 17389 RVA: 0x0004B854 File Offset: 0x0004A854
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x0004B872 File Offset: 0x0004A872
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x0004B88F File Offset: 0x0004A88F
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x0004B8A1 File Offset: 0x0004A8A1
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

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x0004B8AF File Offset: 0x0004A8AF
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x0004B8C1 File Offset: 0x0004A8C1
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

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x0004B8CF File Offset: 0x0004A8CF
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x0004B8E1 File Offset: 0x0004A8E1
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

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x0004B8EF File Offset: 0x0004A8EF
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x0004B901 File Offset: 0x0004A901
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

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x0004B90F File Offset: 0x0004A90F
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x0004B921 File Offset: 0x0004A921
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

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x0004B92F File Offset: 0x0004A92F
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x0004B941 File Offset: 0x0004A941
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

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x0004B94F File Offset: 0x0004A94F
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x0004B961 File Offset: 0x0004A961
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

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x0004B96F File Offset: 0x0004A96F
		// (set) Token: 0x060043FE RID: 17406 RVA: 0x0004B981 File Offset: 0x0004A981
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

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x0004B98F File Offset: 0x0004A98F
		// (set) Token: 0x06004400 RID: 17408 RVA: 0x0004B9A1 File Offset: 0x0004A9A1
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

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x0004B9AF File Offset: 0x0004A9AF
		// (set) Token: 0x06004402 RID: 17410 RVA: 0x0004B9C1 File Offset: 0x0004A9C1
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

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x0004B9CF File Offset: 0x0004A9CF
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x0004B9E1 File Offset: 0x0004A9E1
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

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x0004B9EF File Offset: 0x0004A9EF
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x0004BA01 File Offset: 0x0004AA01
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

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x0004BA0F File Offset: 0x0004AA0F
		// (set) Token: 0x06004408 RID: 17416 RVA: 0x0004BA21 File Offset: 0x0004AA21
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

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x0004BA2F File Offset: 0x0004AA2F
		// (set) Token: 0x0600440A RID: 17418 RVA: 0x0004BA41 File Offset: 0x0004AA41
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

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x0004BA4F File Offset: 0x0004AA4F
		// (set) Token: 0x0600440C RID: 17420 RVA: 0x0004BA61 File Offset: 0x0004AA61
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

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x0004BA6F File Offset: 0x0004AA6F
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x0004BA81 File Offset: 0x0004AA81
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

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x0004BA8F File Offset: 0x0004AA8F
		// (set) Token: 0x06004410 RID: 17424 RVA: 0x0004BAA1 File Offset: 0x0004AAA1
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

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x0004BAAF File Offset: 0x0004AAAF
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x0004BAC1 File Offset: 0x0004AAC1
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

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x0004BACF File Offset: 0x0004AACF
		// (set) Token: 0x06004414 RID: 17428 RVA: 0x0004BAE1 File Offset: 0x0004AAE1
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

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x0004BAEF File Offset: 0x0004AAEF
		// (set) Token: 0x06004416 RID: 17430 RVA: 0x0004BB01 File Offset: 0x0004AB01
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

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x0004BB0F File Offset: 0x0004AB0F
		// (set) Token: 0x06004418 RID: 17432 RVA: 0x0004BB21 File Offset: 0x0004AB21
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

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x0004BB2F File Offset: 0x0004AB2F
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x0004BB41 File Offset: 0x0004AB41
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

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x0004BB4F File Offset: 0x0004AB4F
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x0004BB61 File Offset: 0x0004AB61
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

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x0004BB6F File Offset: 0x0004AB6F
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x0004BB81 File Offset: 0x0004AB81
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x0004BB8F File Offset: 0x0004AB8F
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x0004BB9E File Offset: 0x0004AB9E
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x0004BBA9 File Offset: 0x0004ABA9
		// (set) Token: 0x06004422 RID: 17442 RVA: 0x0004BBBB File Offset: 0x0004ABBB
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x0004BBC9 File Offset: 0x0004ABC9
		// (set) Token: 0x06004424 RID: 17444 RVA: 0x0004BBDB File Offset: 0x0004ABDB
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

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x0004BBE9 File Offset: 0x0004ABE9
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x0004BBF8 File Offset: 0x0004ABF8
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

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06004427 RID: 17447 RVA: 0x0004BC03 File Offset: 0x0004AC03
		// (set) Token: 0x06004428 RID: 17448 RVA: 0x0004BC15 File Offset: 0x0004AC15
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

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x0004BC23 File Offset: 0x0004AC23
		// (set) Token: 0x0600442A RID: 17450 RVA: 0x0004BC35 File Offset: 0x0004AC35
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

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x0004BC43 File Offset: 0x0004AC43
		// (set) Token: 0x0600442C RID: 17452 RVA: 0x0004BC55 File Offset: 0x0004AC55
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

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600442D RID: 17453 RVA: 0x0004BC63 File Offset: 0x0004AC63
		// (set) Token: 0x0600442E RID: 17454 RVA: 0x0004BC75 File Offset: 0x0004AC75
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

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600442F RID: 17455 RVA: 0x0004BC83 File Offset: 0x0004AC83
		// (set) Token: 0x06004430 RID: 17456 RVA: 0x0004BC95 File Offset: 0x0004AC95
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

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x0004BCA3 File Offset: 0x0004ACA3
		// (set) Token: 0x06004432 RID: 17458 RVA: 0x0004BCB5 File Offset: 0x0004ACB5
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

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x0004BCC3 File Offset: 0x0004ACC3
		// (set) Token: 0x06004434 RID: 17460 RVA: 0x0004BCD5 File Offset: 0x0004ACD5
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

		// Token: 0x06004435 RID: 17461 RVA: 0x0004BCE3 File Offset: 0x0004ACE3
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x0004BD01 File Offset: 0x0004AD01
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x0004BD1E File Offset: 0x0004AD1E
		// (set) Token: 0x06004438 RID: 17464 RVA: 0x0004BD30 File Offset: 0x0004AD30
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

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x0004BD3E File Offset: 0x0004AD3E
		// (set) Token: 0x0600443A RID: 17466 RVA: 0x0004BD50 File Offset: 0x0004AD50
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

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x0004BD5E File Offset: 0x0004AD5E
		// (set) Token: 0x0600443C RID: 17468 RVA: 0x0004BD70 File Offset: 0x0004AD70
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

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x0004BD7E File Offset: 0x0004AD7E
		// (set) Token: 0x0600443E RID: 17470 RVA: 0x0004BD90 File Offset: 0x0004AD90
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

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x0004BD9E File Offset: 0x0004AD9E
		// (set) Token: 0x06004440 RID: 17472 RVA: 0x0004BDB0 File Offset: 0x0004ADB0
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

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x0004BDBE File Offset: 0x0004ADBE
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x0004BDD0 File Offset: 0x0004ADD0
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

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x0004BDDE File Offset: 0x0004ADDE
		// (set) Token: 0x06004444 RID: 17476 RVA: 0x0004BDF0 File Offset: 0x0004ADF0
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

		// Token: 0x06004445 RID: 17477 RVA: 0x0004BDFE File Offset: 0x0004ADFE
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x0004BE1C File Offset: 0x0004AE1C
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x0004BE39 File Offset: 0x0004AE39
		// (set) Token: 0x06004448 RID: 17480 RVA: 0x0004BE4B File Offset: 0x0004AE4B
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

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x0004BE59 File Offset: 0x0004AE59
		// (set) Token: 0x0600444A RID: 17482 RVA: 0x0004BE6B File Offset: 0x0004AE6B
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

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x0004BE79 File Offset: 0x0004AE79
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x0004BE8B File Offset: 0x0004AE8B
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

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x0004BE99 File Offset: 0x0004AE99
		// (set) Token: 0x0600444E RID: 17486 RVA: 0x0004BEAB File Offset: 0x0004AEAB
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

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x0004BEB9 File Offset: 0x0004AEB9
		// (set) Token: 0x06004450 RID: 17488 RVA: 0x0004BECB File Offset: 0x0004AECB
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

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x0004BED9 File Offset: 0x0004AED9
		// (set) Token: 0x06004452 RID: 17490 RVA: 0x0004BEEB File Offset: 0x0004AEEB
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

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x0004BEF9 File Offset: 0x0004AEF9
		// (set) Token: 0x06004454 RID: 17492 RVA: 0x0004BF0B File Offset: 0x0004AF0B
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

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x0004BF19 File Offset: 0x0004AF19
		// (set) Token: 0x06004456 RID: 17494 RVA: 0x0004BF2B File Offset: 0x0004AF2B
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

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x0004BF39 File Offset: 0x0004AF39
		// (set) Token: 0x06004458 RID: 17496 RVA: 0x0004BF4B File Offset: 0x0004AF4B
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

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x0004BF59 File Offset: 0x0004AF59
		// (set) Token: 0x0600445A RID: 17498 RVA: 0x0004BF6B File Offset: 0x0004AF6B
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

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x0004BF79 File Offset: 0x0004AF79
		// (set) Token: 0x0600445C RID: 17500 RVA: 0x0004BF8B File Offset: 0x0004AF8B
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

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x0004BF99 File Offset: 0x0004AF99
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x0004BFAB File Offset: 0x0004AFAB
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

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x0004BFB9 File Offset: 0x0004AFB9
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x0004BFCB File Offset: 0x0004AFCB
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

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x0004BFD9 File Offset: 0x0004AFD9
		// (set) Token: 0x06004462 RID: 17506 RVA: 0x0004BFEB File Offset: 0x0004AFEB
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

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x0004BFF9 File Offset: 0x0004AFF9
		// (set) Token: 0x06004464 RID: 17508 RVA: 0x0004C00B File Offset: 0x0004B00B
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

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x0004C019 File Offset: 0x0004B019
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x0004C02B File Offset: 0x0004B02B
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

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x0004C039 File Offset: 0x0004B039
		// (set) Token: 0x06004468 RID: 17512 RVA: 0x0004C04B File Offset: 0x0004B04B
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

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x0004C059 File Offset: 0x0004B059
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x0004C06B File Offset: 0x0004B06B
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

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x0004C079 File Offset: 0x0004B079
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x0004C08B File Offset: 0x0004B08B
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

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x0004C099 File Offset: 0x0004B099
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x0004C0AB File Offset: 0x0004B0AB
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

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x0004C0B9 File Offset: 0x0004B0B9
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x0004C0CB File Offset: 0x0004B0CB
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

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x0004C0D9 File Offset: 0x0004B0D9
		// (set) Token: 0x06004472 RID: 17522 RVA: 0x0004C0EB File Offset: 0x0004B0EB
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

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x0004C0F9 File Offset: 0x0004B0F9
		// (set) Token: 0x06004474 RID: 17524 RVA: 0x0004C10B File Offset: 0x0004B10B
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

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06004475 RID: 17525 RVA: 0x0004C119 File Offset: 0x0004B119
		// (set) Token: 0x06004476 RID: 17526 RVA: 0x0004C12B File Offset: 0x0004B12B
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

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x0004C139 File Offset: 0x0004B139
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x0004C14B File Offset: 0x0004B14B
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

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x0004C159 File Offset: 0x0004B159
		// (set) Token: 0x0600447A RID: 17530 RVA: 0x0004C16B File Offset: 0x0004B16B
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

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x0004C179 File Offset: 0x0004B179
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x0004C18B File Offset: 0x0004B18B
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

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x0004C199 File Offset: 0x0004B199
		// (set) Token: 0x0600447E RID: 17534 RVA: 0x0004C1AB File Offset: 0x0004B1AB
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

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x0004C1B9 File Offset: 0x0004B1B9
		// (set) Token: 0x06004480 RID: 17536 RVA: 0x0004C1CB File Offset: 0x0004B1CB
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

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x0004C1D9 File Offset: 0x0004B1D9
		// (set) Token: 0x06004482 RID: 17538 RVA: 0x0004C1EB File Offset: 0x0004B1EB
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

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x0004C1F9 File Offset: 0x0004B1F9
		// (set) Token: 0x06004484 RID: 17540 RVA: 0x0004C20B File Offset: 0x0004B20B
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

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x0004C219 File Offset: 0x0004B219
		// (set) Token: 0x06004486 RID: 17542 RVA: 0x0004C22B File Offset: 0x0004B22B
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

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x0004C239 File Offset: 0x0004B239
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x0004C24B File Offset: 0x0004B24B
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

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x0004C259 File Offset: 0x0004B259
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x0004C26B File Offset: 0x0004B26B
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

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x0004C279 File Offset: 0x0004B279
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x0004C28B File Offset: 0x0004B28B
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

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x0004C299 File Offset: 0x0004B299
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x0004C2AB File Offset: 0x0004B2AB
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

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x0004C2B9 File Offset: 0x0004B2B9
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x0004C2CB File Offset: 0x0004B2CB
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

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x0004C2D9 File Offset: 0x0004B2D9
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x0004C2EB File Offset: 0x0004B2EB
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

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x0004C2F9 File Offset: 0x0004B2F9
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x0004C30B File Offset: 0x0004B30B
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

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x0004C319 File Offset: 0x0004B319
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x0004C32B File Offset: 0x0004B32B
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

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x0004C339 File Offset: 0x0004B339
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x0004C34B File Offset: 0x0004B34B
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

		// Token: 0x06004499 RID: 17561 RVA: 0x0004C359 File Offset: 0x0004B359
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x0004C377 File Offset: 0x0004B377
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x0004C394 File Offset: 0x0004B394
		// (set) Token: 0x0600449C RID: 17564 RVA: 0x0004C3A3 File Offset: 0x0004B3A3
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

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x0004C3AE File Offset: 0x0004B3AE
		// (set) Token: 0x0600449E RID: 17566 RVA: 0x0004C3BD File Offset: 0x0004B3BD
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

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x0004C3C8 File Offset: 0x0004B3C8
		// (set) Token: 0x060044A0 RID: 17568 RVA: 0x0004C3D7 File Offset: 0x0004B3D7
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

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x0004C3E2 File Offset: 0x0004B3E2
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x0004C3F4 File Offset: 0x0004B3F4
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

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x0004C402 File Offset: 0x0004B402
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x0004C414 File Offset: 0x0004B414
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

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x0004C422 File Offset: 0x0004B422
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x0004C431 File Offset: 0x0004B431
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

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x0004C43C File Offset: 0x0004B43C
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x0004C44B File Offset: 0x0004B44B
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

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x0004C456 File Offset: 0x0004B456
		// (set) Token: 0x060044AA RID: 17578 RVA: 0x0004C465 File Offset: 0x0004B465
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

		// Token: 0x060044AB RID: 17579 RVA: 0x0004C470 File Offset: 0x0004B470
		public FIXOrderMassCancelReport()
		{
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0004C4D0 File Offset: 0x0004B4D0
		public FIXOrderMassCancelReport(string OrderID, char MassCancelRequestType, char MassCancelResponse)
		{
			this.OrderID = OrderID;
			this.MassCancelRequestType = MassCancelRequestType;
			this.MassCancelResponse = MassCancelResponse;
		}

		// Token: 0x04000D66 RID: 3430
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000D67 RID: 3431
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000D68 RID: 3432
		private ArrayList fAffectedOrdersGroup = new ArrayList();

		// Token: 0x04000D69 RID: 3433
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000D6A RID: 3434
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000D6B RID: 3435
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000D6C RID: 3436
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
