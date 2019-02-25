using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000C0 RID: 192
	public class FIXQuoteCancel : FIXMessage
	{
		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x00028F7A File Offset: 0x00027F7A
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x00028F8C File Offset: 0x00027F8C
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

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x00028F9A File Offset: 0x00027F9A
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x00028FA9 File Offset: 0x00027FA9
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

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x00028FB4 File Offset: 0x00027FB4
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x00028FC3 File Offset: 0x00027FC3
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

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x00028FCE File Offset: 0x00027FCE
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x00028FDD File Offset: 0x00027FDD
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

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x00028FE8 File Offset: 0x00027FE8
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x00028FF7 File Offset: 0x00027FF7
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

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x00029002 File Offset: 0x00028002
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x00029011 File Offset: 0x00028011
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

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x0002901C File Offset: 0x0002801C
		// (set) Token: 0x06002668 RID: 9832 RVA: 0x0002902E File Offset: 0x0002802E
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

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x0002903C File Offset: 0x0002803C
		// (set) Token: 0x0600266A RID: 9834 RVA: 0x0002904B File Offset: 0x0002804B
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

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x00029056 File Offset: 0x00028056
		// (set) Token: 0x0600266C RID: 9836 RVA: 0x00029065 File Offset: 0x00028065
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

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x00029070 File Offset: 0x00028070
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x0002907F File Offset: 0x0002807F
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

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x0002908A File Offset: 0x0002808A
		// (set) Token: 0x06002670 RID: 9840 RVA: 0x00029099 File Offset: 0x00028099
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

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x000290A4 File Offset: 0x000280A4
		// (set) Token: 0x06002672 RID: 9842 RVA: 0x000290B6 File Offset: 0x000280B6
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

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x000290C4 File Offset: 0x000280C4
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x000290D3 File Offset: 0x000280D3
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

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000290DE File Offset: 0x000280DE
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x000290EC File Offset: 0x000280EC
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

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000290F6 File Offset: 0x000280F6
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x00029105 File Offset: 0x00028105
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

		// Token: 0x06002679 RID: 9849 RVA: 0x00029110 File Offset: 0x00028110
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00029123 File Offset: 0x00028123
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x00029132 File Offset: 0x00028132
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x00029144 File Offset: 0x00028144
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

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x00029152 File Offset: 0x00028152
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x00029164 File Offset: 0x00028164
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

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00029172 File Offset: 0x00028172
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x00029181 File Offset: 0x00028181
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

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x0002918C File Offset: 0x0002818C
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x0002919B File Offset: 0x0002819B
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

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x000291A6 File Offset: 0x000281A6
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x000291B5 File Offset: 0x000281B5
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

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000291C0 File Offset: 0x000281C0
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x000291CF File Offset: 0x000281CF
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

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x000291DA File Offset: 0x000281DA
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x000291EC File Offset: 0x000281EC
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

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x000291FA File Offset: 0x000281FA
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x0002920C File Offset: 0x0002820C
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

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x0002921A File Offset: 0x0002821A
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x0002922C File Offset: 0x0002822C
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

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x0002923A File Offset: 0x0002823A
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x0002924C File Offset: 0x0002824C
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

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x0002925A File Offset: 0x0002825A
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x0002926C File Offset: 0x0002826C
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

		// Token: 0x06002691 RID: 9873 RVA: 0x0002927A File Offset: 0x0002827A
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00029298 File Offset: 0x00028298
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x000292B5 File Offset: 0x000282B5
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x000292C7 File Offset: 0x000282C7
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

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x000292D5 File Offset: 0x000282D5
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x000292E7 File Offset: 0x000282E7
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

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x000292F5 File Offset: 0x000282F5
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x00029304 File Offset: 0x00028304
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

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0002930F File Offset: 0x0002830F
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x00029321 File Offset: 0x00028321
		[FIXField("298", EFieldOption.Required)]
		public int QuoteCancelType
		{
			get
			{
				return this.GetIntField(298).Value;
			}
			set
			{
				this.AddIntField(298, value);
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0002932F File Offset: 0x0002832F
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x00029341 File Offset: 0x00028341
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

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x0002934F File Offset: 0x0002834F
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x00029361 File Offset: 0x00028361
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

		// Token: 0x0600269F RID: 9887 RVA: 0x0002936F File Offset: 0x0002836F
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0002938D File Offset: 0x0002838D
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000293AA File Offset: 0x000283AA
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x000293B8 File Offset: 0x000283B8
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

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000293C2 File Offset: 0x000283C2
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x000293D4 File Offset: 0x000283D4
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

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000293E2 File Offset: 0x000283E2
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x000293F4 File Offset: 0x000283F4
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

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x00029402 File Offset: 0x00028402
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x00029414 File Offset: 0x00028414
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

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x00029422 File Offset: 0x00028422
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x00029434 File Offset: 0x00028434
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

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x00029442 File Offset: 0x00028442
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x00029454 File Offset: 0x00028454
		[FIXField("295", EFieldOption.Optional)]
		public int NoQuoteEntries
		{
			get
			{
				return this.GetIntField(295).Value;
			}
			set
			{
				this.AddIntField(295, value);
			}
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00029462 File Offset: 0x00028462
		public FIXQuoteEntriesGroup GetQuoteEntriesGroup(int i)
		{
			if (i < this.NoQuoteEntries)
			{
				return (FIXQuoteEntriesGroup)this.fQuoteEntriesGroup[i];
			}
			return null;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00029480 File Offset: 0x00028480
		public void AddGroup(FIXQuoteEntriesGroup group)
		{
			this.fQuoteEntriesGroup.Add(group);
			this.NoQuoteEntries++;
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x0002949D File Offset: 0x0002849D
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x000294AC File Offset: 0x000284AC
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

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000294B7 File Offset: 0x000284B7
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x000294C6 File Offset: 0x000284C6
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

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000294D1 File Offset: 0x000284D1
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x000294E0 File Offset: 0x000284E0
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

		// Token: 0x060026B5 RID: 9909 RVA: 0x000294EB File Offset: 0x000284EB
		public FIXQuoteCancel()
		{
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00029520 File Offset: 0x00028520
		public FIXQuoteCancel(string QuoteID, int QuoteCancelType)
		{
			this.QuoteID = QuoteID;
			this.QuoteCancelType = QuoteCancelType;
		}

		// Token: 0x0400039B RID: 923
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400039C RID: 924
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400039D RID: 925
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x0400039E RID: 926
		private ArrayList fQuoteEntriesGroup = new ArrayList();
	}
}
