using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000C5 RID: 197
	public class FIXListCancelRequest : FIXMessage
	{
		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x00029695 File Offset: 0x00028695
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x000296A7 File Offset: 0x000286A7
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

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000296B5 File Offset: 0x000286B5
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x000296C4 File Offset: 0x000286C4
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

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000296CF File Offset: 0x000286CF
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x000296DE File Offset: 0x000286DE
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

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000296E9 File Offset: 0x000286E9
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x000296F8 File Offset: 0x000286F8
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

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00029703 File Offset: 0x00028703
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00029712 File Offset: 0x00028712
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

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0002971D File Offset: 0x0002871D
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0002972C File Offset: 0x0002872C
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

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x00029737 File Offset: 0x00028737
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x00029749 File Offset: 0x00028749
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

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x00029757 File Offset: 0x00028757
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00029766 File Offset: 0x00028766
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

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x00029771 File Offset: 0x00028771
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x00029780 File Offset: 0x00028780
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

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0002978B File Offset: 0x0002878B
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0002979A File Offset: 0x0002879A
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

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000297A5 File Offset: 0x000287A5
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x000297B4 File Offset: 0x000287B4
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

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000297BF File Offset: 0x000287BF
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x000297D1 File Offset: 0x000287D1
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

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000297DF File Offset: 0x000287DF
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x000297EE File Offset: 0x000287EE
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

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000297F9 File Offset: 0x000287F9
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x00029807 File Offset: 0x00028807
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x00029811 File Offset: 0x00028811
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x00029820 File Offset: 0x00028820
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

		// Token: 0x060026EB RID: 9963 RVA: 0x0002982B File Offset: 0x0002882B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0002983E File Offset: 0x0002883E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x0002984D File Offset: 0x0002884D
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x0002985F File Offset: 0x0002885F
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x0002986D File Offset: 0x0002886D
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x0002987F File Offset: 0x0002887F
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

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x0002988D File Offset: 0x0002888D
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0002989C File Offset: 0x0002889C
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

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x000298A7 File Offset: 0x000288A7
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x000298B6 File Offset: 0x000288B6
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

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000298C1 File Offset: 0x000288C1
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x000298D0 File Offset: 0x000288D0
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

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000298DB File Offset: 0x000288DB
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x000298EA File Offset: 0x000288EA
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

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000298F5 File Offset: 0x000288F5
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00029907 File Offset: 0x00028907
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

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x00029915 File Offset: 0x00028915
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00029927 File Offset: 0x00028927
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

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x00029935 File Offset: 0x00028935
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x00029947 File Offset: 0x00028947
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

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x00029955 File Offset: 0x00028955
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x00029967 File Offset: 0x00028967
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

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x00029975 File Offset: 0x00028975
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00029987 File Offset: 0x00028987
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

		// Token: 0x06002703 RID: 9987 RVA: 0x00029995 File Offset: 0x00028995
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000299B3 File Offset: 0x000289B3
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000299D0 File Offset: 0x000289D0
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x000299E2 File Offset: 0x000289E2
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

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000299F0 File Offset: 0x000289F0
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x000299FF File Offset: 0x000289FF
		[FIXField("66", EFieldOption.Required)]
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

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x00029A0A File Offset: 0x00028A0A
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00029A19 File Offset: 0x00028A19
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

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00029A24 File Offset: 0x00028A24
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00029A36 File Offset: 0x00028A36
		[FIXField("229", EFieldOption.Optional)]
		public DateTime TradeOriginationDate
		{
			get
			{
				return this.GetDateTimeField(229).Value;
			}
			set
			{
				this.AddDateTimeField(229, value);
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00029A44 File Offset: 0x00028A44
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00029A53 File Offset: 0x00028A53
		[FIXField("75", EFieldOption.Optional)]
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00029A5E File Offset: 0x00028A5E
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00029A6D File Offset: 0x00028A6D
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

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00029A78 File Offset: 0x00028A78
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00029A8A File Offset: 0x00028A8A
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

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x00029A98 File Offset: 0x00028A98
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x00029AAA File Offset: 0x00028AAA
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

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00029AB8 File Offset: 0x00028AB8
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00029AC7 File Offset: 0x00028AC7
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00029AD2 File Offset: 0x00028AD2
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00029AE1 File Offset: 0x00028AE1
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

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00029AEC File Offset: 0x00028AEC
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00029AFB File Offset: 0x00028AFB
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

		// Token: 0x0600271B RID: 10011 RVA: 0x00029B06 File Offset: 0x00028B06
		public FIXListCancelRequest()
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00029B24 File Offset: 0x00028B24
		public FIXListCancelRequest(string ListID, DateTime TransactTime)
		{
			this.ListID = ListID;
			this.TransactTime = TransactTime;
		}

		// Token: 0x040003A2 RID: 930
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003A3 RID: 931
		private ArrayList fHopsGroup = new ArrayList();
	}
}
