using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000AA RID: 170
	public class FIXNetworkCounterpartySystemStatusResponse : FIXMessage
	{
		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x00026F77 File Offset: 0x00025F77
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x00026F89 File Offset: 0x00025F89
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

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00026F97 File Offset: 0x00025F97
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x00026FA6 File Offset: 0x00025FA6
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

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x00026FB1 File Offset: 0x00025FB1
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x00026FC0 File Offset: 0x00025FC0
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

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x00026FCB File Offset: 0x00025FCB
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x00026FDA File Offset: 0x00025FDA
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

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x00026FE5 File Offset: 0x00025FE5
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00026FF4 File Offset: 0x00025FF4
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

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x00026FFF File Offset: 0x00025FFF
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x0002700E File Offset: 0x0002600E
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

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x00027019 File Offset: 0x00026019
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x0002702B File Offset: 0x0002602B
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

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x00027039 File Offset: 0x00026039
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x00027048 File Offset: 0x00026048
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

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x00027053 File Offset: 0x00026053
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x00027062 File Offset: 0x00026062
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

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x0002706D File Offset: 0x0002606D
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x0002707C File Offset: 0x0002607C
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

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00027087 File Offset: 0x00026087
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x00027096 File Offset: 0x00026096
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x000270A1 File Offset: 0x000260A1
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x000270B3 File Offset: 0x000260B3
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

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000270C1 File Offset: 0x000260C1
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x000270D0 File Offset: 0x000260D0
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

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000270DB File Offset: 0x000260DB
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x000270E9 File Offset: 0x000260E9
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

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000270F3 File Offset: 0x000260F3
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x00027102 File Offset: 0x00026102
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

		// Token: 0x06002478 RID: 9336 RVA: 0x0002710D File Offset: 0x0002610D
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00027120 File Offset: 0x00026120
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x0002712F File Offset: 0x0002612F
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x00027141 File Offset: 0x00026141
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

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x0002714F File Offset: 0x0002614F
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x00027161 File Offset: 0x00026161
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

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0002716F File Offset: 0x0002616F
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0002717E File Offset: 0x0002617E
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

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x00027189 File Offset: 0x00026189
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x00027198 File Offset: 0x00026198
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

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000271A3 File Offset: 0x000261A3
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x000271B2 File Offset: 0x000261B2
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

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000271BD File Offset: 0x000261BD
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x000271CC File Offset: 0x000261CC
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

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000271D7 File Offset: 0x000261D7
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x000271E9 File Offset: 0x000261E9
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x000271F7 File Offset: 0x000261F7
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x00027209 File Offset: 0x00026209
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

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x00027217 File Offset: 0x00026217
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00027229 File Offset: 0x00026229
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

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x00027237 File Offset: 0x00026237
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x00027249 File Offset: 0x00026249
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

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00027257 File Offset: 0x00026257
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00027269 File Offset: 0x00026269
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

		// Token: 0x06002490 RID: 9360 RVA: 0x00027277 File Offset: 0x00026277
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00027295 File Offset: 0x00026295
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000272B2 File Offset: 0x000262B2
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x000272C4 File Offset: 0x000262C4
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

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000272D2 File Offset: 0x000262D2
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x000272E4 File Offset: 0x000262E4
		[FIXField("937", EFieldOption.Required)]
		public int NetworkStatusResponseType
		{
			get
			{
				return this.GetIntField(937).Value;
			}
			set
			{
				this.AddIntField(937, value);
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x000272F2 File Offset: 0x000262F2
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x00027304 File Offset: 0x00026304
		[FIXField("933", EFieldOption.Optional)]
		public string NetworkRequestID
		{
			get
			{
				return this.GetStringField(933).Value;
			}
			set
			{
				this.AddStringField(933, value);
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x00027312 File Offset: 0x00026312
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x00027324 File Offset: 0x00026324
		[FIXField("932", EFieldOption.Required)]
		public string NetworkResponseID
		{
			get
			{
				return this.GetStringField(932).Value;
			}
			set
			{
				this.AddStringField(932, value);
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x00027332 File Offset: 0x00026332
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x00027344 File Offset: 0x00026344
		[FIXField("934", EFieldOption.Optional)]
		public string LastNetworkResponseID
		{
			get
			{
				return this.GetStringField(934).Value;
			}
			set
			{
				this.AddStringField(934, value);
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x00027352 File Offset: 0x00026352
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x00027364 File Offset: 0x00026364
		[FIXField("936", EFieldOption.Required)]
		public int NoCompIDs
		{
			get
			{
				return this.GetIntField(936).Value;
			}
			set
			{
				this.AddIntField(936, value);
			}
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00027372 File Offset: 0x00026372
		public FIXCompIDsGroup GetCompIDsGroup(int i)
		{
			if (i < this.NoCompIDs)
			{
				return (FIXCompIDsGroup)this.fCompIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00027390 File Offset: 0x00026390
		public void AddGroup(FIXCompIDsGroup group)
		{
			this.fCompIDsGroup.Add(group);
			this.NoCompIDs++;
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000273AD File Offset: 0x000263AD
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x000273BC File Offset: 0x000263BC
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

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000273C7 File Offset: 0x000263C7
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x000273D6 File Offset: 0x000263D6
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

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x000273E1 File Offset: 0x000263E1
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x000273F0 File Offset: 0x000263F0
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

		// Token: 0x060024A6 RID: 9382 RVA: 0x000273FB File Offset: 0x000263FB
		public FIXNetworkCounterpartySystemStatusResponse()
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00027424 File Offset: 0x00026424
		public FIXNetworkCounterpartySystemStatusResponse(int NetworkStatusResponseType, string NetworkResponseID, int NoCompIDs)
		{
			this.NetworkStatusResponseType = NetworkStatusResponseType;
			this.NetworkResponseID = NetworkResponseID;
			this.NoCompIDs = NoCompIDs;
		}

		// Token: 0x04000352 RID: 850
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000353 RID: 851
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000354 RID: 852
		private ArrayList fCompIDsGroup = new ArrayList();
	}
}
