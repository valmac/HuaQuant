using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000FD RID: 253
	public class FIXUserResponse : FIXMessage
	{
		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x0003122A File Offset: 0x0003022A
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x0003123C File Offset: 0x0003023C
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

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x0003124A File Offset: 0x0003024A
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x00031259 File Offset: 0x00030259
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

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x00031264 File Offset: 0x00030264
		// (set) Token: 0x06002EB7 RID: 11959 RVA: 0x00031273 File Offset: 0x00030273
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

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x0003127E File Offset: 0x0003027E
		// (set) Token: 0x06002EB9 RID: 11961 RVA: 0x0003128D File Offset: 0x0003028D
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

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x00031298 File Offset: 0x00030298
		// (set) Token: 0x06002EBB RID: 11963 RVA: 0x000312A7 File Offset: 0x000302A7
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

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x000312B2 File Offset: 0x000302B2
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x000312C1 File Offset: 0x000302C1
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x000312CC File Offset: 0x000302CC
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x000312DE File Offset: 0x000302DE
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

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000312EC File Offset: 0x000302EC
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x000312FB File Offset: 0x000302FB
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

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00031306 File Offset: 0x00030306
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x00031315 File Offset: 0x00030315
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

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x00031320 File Offset: 0x00030320
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x0003132F File Offset: 0x0003032F
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

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x0003133A File Offset: 0x0003033A
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00031349 File Offset: 0x00030349
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

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00031354 File Offset: 0x00030354
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00031366 File Offset: 0x00030366
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

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x00031374 File Offset: 0x00030374
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00031383 File Offset: 0x00030383
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

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x0003138E File Offset: 0x0003038E
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x0003139C File Offset: 0x0003039C
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

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000313A6 File Offset: 0x000303A6
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x000313B5 File Offset: 0x000303B5
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

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000313C0 File Offset: 0x000303C0
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x000313D3 File Offset: 0x000303D3
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000313E2 File Offset: 0x000303E2
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x000313F4 File Offset: 0x000303F4
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

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00031402 File Offset: 0x00030402
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x00031414 File Offset: 0x00030414
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

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x00031422 File Offset: 0x00030422
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x00031431 File Offset: 0x00030431
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

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x0003143C File Offset: 0x0003043C
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x0003144B File Offset: 0x0003044B
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

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00031456 File Offset: 0x00030456
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x00031465 File Offset: 0x00030465
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

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x00031470 File Offset: 0x00030470
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x0003147F File Offset: 0x0003047F
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

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x0003148A File Offset: 0x0003048A
		// (set) Token: 0x06002EDF RID: 11999 RVA: 0x0003149C File Offset: 0x0003049C
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

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x000314AA File Offset: 0x000304AA
		// (set) Token: 0x06002EE1 RID: 12001 RVA: 0x000314BC File Offset: 0x000304BC
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

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x000314CA File Offset: 0x000304CA
		// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x000314DC File Offset: 0x000304DC
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

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x000314EA File Offset: 0x000304EA
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x000314FC File Offset: 0x000304FC
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

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x0003150A File Offset: 0x0003050A
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x0003151C File Offset: 0x0003051C
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x0003152A File Offset: 0x0003052A
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00031548 File Offset: 0x00030548
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00031565 File Offset: 0x00030565
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x00031577 File Offset: 0x00030577
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

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00031585 File Offset: 0x00030585
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x00031597 File Offset: 0x00030597
		[FIXField("923", EFieldOption.Required)]
		public string UserRequestID
		{
			get
			{
				return this.GetStringField(923).Value;
			}
			set
			{
				this.AddStringField(923, value);
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000315A5 File Offset: 0x000305A5
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x000315B7 File Offset: 0x000305B7
		[FIXField("553", EFieldOption.Required)]
		public string Username
		{
			get
			{
				return this.GetStringField(553).Value;
			}
			set
			{
				this.AddStringField(553, value);
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x000315C5 File Offset: 0x000305C5
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x000315D7 File Offset: 0x000305D7
		[FIXField("926", EFieldOption.Optional)]
		public int UserStatus
		{
			get
			{
				return this.GetIntField(926).Value;
			}
			set
			{
				this.AddIntField(926, value);
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x000315E5 File Offset: 0x000305E5
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x000315F7 File Offset: 0x000305F7
		[FIXField("927", EFieldOption.Optional)]
		public string UserStatusText
		{
			get
			{
				return this.GetStringField(927).Value;
			}
			set
			{
				this.AddStringField(927, value);
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x00031605 File Offset: 0x00030605
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00031614 File Offset: 0x00030614
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

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x0003161F File Offset: 0x0003061F
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x0003162E File Offset: 0x0003062E
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

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x00031639 File Offset: 0x00030639
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00031648 File Offset: 0x00030648
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

		// Token: 0x06002EFA RID: 12026 RVA: 0x00031653 File Offset: 0x00030653
		public FIXUserResponse()
		{
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00031671 File Offset: 0x00030671
		public FIXUserResponse(string UserRequestID, string Username)
		{
			this.UserRequestID = UserRequestID;
			this.Username = Username;
		}

		// Token: 0x0400041A RID: 1050
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400041B RID: 1051
		private ArrayList fHopsGroup = new ArrayList();
	}
}
