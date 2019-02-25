using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000AE RID: 174
	public class FIXMassQuote : FIXMessage
	{
		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x00027510 File Offset: 0x00026510
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x00027522 File Offset: 0x00026522
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

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x00027530 File Offset: 0x00026530
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x0002753F File Offset: 0x0002653F
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

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0002754A File Offset: 0x0002654A
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00027559 File Offset: 0x00026559
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

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x00027564 File Offset: 0x00026564
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x00027573 File Offset: 0x00026573
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

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0002757E File Offset: 0x0002657E
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0002758D File Offset: 0x0002658D
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x00027598 File Offset: 0x00026598
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x000275A7 File Offset: 0x000265A7
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

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000275B2 File Offset: 0x000265B2
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x000275C4 File Offset: 0x000265C4
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

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000275D2 File Offset: 0x000265D2
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x000275E1 File Offset: 0x000265E1
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

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000275EC File Offset: 0x000265EC
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x000275FB File Offset: 0x000265FB
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

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x00027606 File Offset: 0x00026606
		// (set) Token: 0x060024C6 RID: 9414 RVA: 0x00027615 File Offset: 0x00026615
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

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x060024C7 RID: 9415 RVA: 0x00027620 File Offset: 0x00026620
		// (set) Token: 0x060024C8 RID: 9416 RVA: 0x0002762F File Offset: 0x0002662F
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

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0002763A File Offset: 0x0002663A
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x0002764C File Offset: 0x0002664C
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

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0002765A File Offset: 0x0002665A
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x00027669 File Offset: 0x00026669
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

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x00027674 File Offset: 0x00026674
		// (set) Token: 0x060024CE RID: 9422 RVA: 0x00027682 File Offset: 0x00026682
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

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060024CF RID: 9423 RVA: 0x0002768C File Offset: 0x0002668C
		// (set) Token: 0x060024D0 RID: 9424 RVA: 0x0002769B File Offset: 0x0002669B
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

		// Token: 0x060024D1 RID: 9425 RVA: 0x000276A6 File Offset: 0x000266A6
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000276B9 File Offset: 0x000266B9
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x000276C8 File Offset: 0x000266C8
		// (set) Token: 0x060024D4 RID: 9428 RVA: 0x000276DA File Offset: 0x000266DA
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

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x000276E8 File Offset: 0x000266E8
		// (set) Token: 0x060024D6 RID: 9430 RVA: 0x000276FA File Offset: 0x000266FA
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

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x00027708 File Offset: 0x00026708
		// (set) Token: 0x060024D8 RID: 9432 RVA: 0x00027717 File Offset: 0x00026717
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

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x00027722 File Offset: 0x00026722
		// (set) Token: 0x060024DA RID: 9434 RVA: 0x00027731 File Offset: 0x00026731
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

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x0002773C File Offset: 0x0002673C
		// (set) Token: 0x060024DC RID: 9436 RVA: 0x0002774B File Offset: 0x0002674B
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

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x00027756 File Offset: 0x00026756
		// (set) Token: 0x060024DE RID: 9438 RVA: 0x00027765 File Offset: 0x00026765
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

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x00027770 File Offset: 0x00026770
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x00027782 File Offset: 0x00026782
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

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x00027790 File Offset: 0x00026790
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x000277A2 File Offset: 0x000267A2
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

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x000277B0 File Offset: 0x000267B0
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x000277C2 File Offset: 0x000267C2
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

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x000277D0 File Offset: 0x000267D0
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x000277E2 File Offset: 0x000267E2
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

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x000277F0 File Offset: 0x000267F0
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x00027802 File Offset: 0x00026802
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

		// Token: 0x060024E9 RID: 9449 RVA: 0x00027810 File Offset: 0x00026810
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0002782E File Offset: 0x0002682E
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x0002784B File Offset: 0x0002684B
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x0002785D File Offset: 0x0002685D
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

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x0002786B File Offset: 0x0002686B
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x0002787D File Offset: 0x0002687D
		[FIXField("131", EFieldOption.Optional)]
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

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x0002788B File Offset: 0x0002688B
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x0002789A File Offset: 0x0002689A
		[FIXField("117", EFieldOption.Required)]
		public string QuoteID
		{
			get
			{
				return this.GetStringField(117).Value;
			}
			set
			{
				this.AddStringField(117, value);
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000278A5 File Offset: 0x000268A5
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x000278B7 File Offset: 0x000268B7
		[FIXField("537", EFieldOption.Optional)]
		public int QuoteType
		{
			get
			{
				return this.GetIntField(537).Value;
			}
			set
			{
				this.AddIntField(537, value);
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x000278C5 File Offset: 0x000268C5
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x000278D7 File Offset: 0x000268D7
		[FIXField("301", EFieldOption.Optional)]
		public int QuoteResponseLevel
		{
			get
			{
				return this.GetIntField(301).Value;
			}
			set
			{
				this.AddIntField(301, value);
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000278E5 File Offset: 0x000268E5
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x000278F7 File Offset: 0x000268F7
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntField(453).Value;
			}
			set
			{
				this.AddIntField(453, value);
			}
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00027905 File Offset: 0x00026905
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00027923 File Offset: 0x00026923
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x00027940 File Offset: 0x00026940
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x0002794E File Offset: 0x0002694E
		[FIXField("1", EFieldOption.Optional)]
		public string Account
		{
			get
			{
				return this.GetStringField(1).Value;
			}
			set
			{
				this.AddStringField(1, value);
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x00027958 File Offset: 0x00026958
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x0002796A File Offset: 0x0002696A
		[FIXField("660", EFieldOption.Optional)]
		public int AcctIDSource
		{
			get
			{
				return this.GetIntField(660).Value;
			}
			set
			{
				this.AddIntField(660, value);
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x00027978 File Offset: 0x00026978
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x0002798A File Offset: 0x0002698A
		[FIXField("581", EFieldOption.Optional)]
		public int AccountType
		{
			get
			{
				return this.GetIntField(581).Value;
			}
			set
			{
				this.AddIntField(581, value);
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x00027998 File Offset: 0x00026998
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x000279AA File Offset: 0x000269AA
		[FIXField("293", EFieldOption.Optional)]
		public double DefBidSize
		{
			get
			{
				return this.GetDoubleField(293).Value;
			}
			set
			{
				this.AddDoubleField(293, value);
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000279B8 File Offset: 0x000269B8
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x000279CA File Offset: 0x000269CA
		[FIXField("294", EFieldOption.Optional)]
		public double DefOfferSize
		{
			get
			{
				return this.GetDoubleField(294).Value;
			}
			set
			{
				this.AddDoubleField(294, value);
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000279D8 File Offset: 0x000269D8
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x000279EA File Offset: 0x000269EA
		[FIXField("296", EFieldOption.Required)]
		public int NoQuoteSets
		{
			get
			{
				return this.GetIntField(296).Value;
			}
			set
			{
				this.AddIntField(296, value);
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000279F8 File Offset: 0x000269F8
		public FIXQuoteSetsGroup GetQuoteSetsGroup(int i)
		{
			if (i < this.NoQuoteSets)
			{
				return (FIXQuoteSetsGroup)this.fQuoteSetsGroup[i];
			}
			return null;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00027A16 File Offset: 0x00026A16
		public void AddGroup(FIXQuoteSetsGroup group)
		{
			this.fQuoteSetsGroup.Add(group);
			this.NoQuoteSets++;
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x00027A33 File Offset: 0x00026A33
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x00027A42 File Offset: 0x00026A42
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

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00027A4D File Offset: 0x00026A4D
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x00027A5C File Offset: 0x00026A5C
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

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x00027A67 File Offset: 0x00026A67
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x00027A76 File Offset: 0x00026A76
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

		// Token: 0x0600250D RID: 9485 RVA: 0x00027A81 File Offset: 0x00026A81
		public FIXMassQuote()
		{
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00027AB8 File Offset: 0x00026AB8
		public FIXMassQuote(string QuoteID, int NoQuoteSets)
		{
			this.QuoteID = QuoteID;
			this.NoQuoteSets = NoQuoteSets;
		}

		// Token: 0x04000358 RID: 856
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000359 RID: 857
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400035A RID: 858
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400035B RID: 859
		private ArrayList fQuoteSetsGroup = new ArrayList();
	}
}
