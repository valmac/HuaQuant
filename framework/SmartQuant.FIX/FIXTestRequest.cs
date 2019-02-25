using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200001E RID: 30
	public class FIXTestRequest : FIXMessage
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00007D45 File Offset: 0x00006D45
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00007D57 File Offset: 0x00006D57
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00007D65 File Offset: 0x00006D65
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00007D74 File Offset: 0x00006D74
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00007D7F File Offset: 0x00006D7F
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00007D8E File Offset: 0x00006D8E
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00007D99 File Offset: 0x00006D99
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00007DA8 File Offset: 0x00006DA8
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

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00007DB3 File Offset: 0x00006DB3
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00007DC2 File Offset: 0x00006DC2
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00007DCD File Offset: 0x00006DCD
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00007DDC File Offset: 0x00006DDC
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00007DE7 File Offset: 0x00006DE7
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00007DF9 File Offset: 0x00006DF9
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00007E07 File Offset: 0x00006E07
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00007E16 File Offset: 0x00006E16
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00007E21 File Offset: 0x00006E21
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00007E30 File Offset: 0x00006E30
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00007E3B File Offset: 0x00006E3B
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00007E4A File Offset: 0x00006E4A
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00007E55 File Offset: 0x00006E55
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00007E64 File Offset: 0x00006E64
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00007E6F File Offset: 0x00006E6F
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00007E81 File Offset: 0x00006E81
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00007E8F File Offset: 0x00006E8F
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00007E9E File Offset: 0x00006E9E
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00007EA9 File Offset: 0x00006EA9
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00007EB7 File Offset: 0x00006EB7
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00007EC1 File Offset: 0x00006EC1
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00007ED0 File Offset: 0x00006ED0
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

		// Token: 0x0600054F RID: 1359 RVA: 0x00007EDB File Offset: 0x00006EDB
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00007EEE File Offset: 0x00006EEE
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00007EFD File Offset: 0x00006EFD
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00007F0F File Offset: 0x00006F0F
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00007F1D File Offset: 0x00006F1D
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00007F2F File Offset: 0x00006F2F
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00007F3D File Offset: 0x00006F3D
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00007F4C File Offset: 0x00006F4C
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

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00007F57 File Offset: 0x00006F57
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00007F66 File Offset: 0x00006F66
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00007F71 File Offset: 0x00006F71
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00007F80 File Offset: 0x00006F80
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00007F8B File Offset: 0x00006F8B
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00007F9A File Offset: 0x00006F9A
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00007FA5 File Offset: 0x00006FA5
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00007FB7 File Offset: 0x00006FB7
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00007FC5 File Offset: 0x00006FC5
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00007FD7 File Offset: 0x00006FD7
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00007FE5 File Offset: 0x00006FE5
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00007FF7 File Offset: 0x00006FF7
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00008005 File Offset: 0x00007005
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00008017 File Offset: 0x00007017
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00008025 File Offset: 0x00007025
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00008037 File Offset: 0x00007037
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

		// Token: 0x06000567 RID: 1383 RVA: 0x00008045 File Offset: 0x00007045
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00008063 File Offset: 0x00007063
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00008080 File Offset: 0x00007080
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00008092 File Offset: 0x00007092
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

		// Token: 0x0600056B RID: 1387 RVA: 0x000080A0 File Offset: 0x000070A0
		public FIXTestReqIDGroup GetTestReqIDGroup(int i)
		{
			return (FIXTestReqIDGroup)this.fTestReqIDGroup[i];
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000080B3 File Offset: 0x000070B3
		public void AddGroup(FIXTestReqIDGroup group)
		{
			this.fTestReqIDGroup.Add(group);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000080C2 File Offset: 0x000070C2
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x000080D1 File Offset: 0x000070D1
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000080DC File Offset: 0x000070DC
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000080EB File Offset: 0x000070EB
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000080F6 File Offset: 0x000070F6
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00008105 File Offset: 0x00007105
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

		// Token: 0x04000045 RID: 69
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000046 RID: 70
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000047 RID: 71
		private ArrayList fTestReqIDGroup = new ArrayList();
	}
}
