using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000160 RID: 352
	public class FIXQuoteResponse : FIXMessage
	{
		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x00047E3C File Offset: 0x00046E3C
		// (set) Token: 0x060041CA RID: 16842 RVA: 0x00047E4E File Offset: 0x00046E4E
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

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x00047E5C File Offset: 0x00046E5C
		// (set) Token: 0x060041CC RID: 16844 RVA: 0x00047E6B File Offset: 0x00046E6B
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

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x00047E76 File Offset: 0x00046E76
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x00047E85 File Offset: 0x00046E85
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

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x00047E90 File Offset: 0x00046E90
		// (set) Token: 0x060041D0 RID: 16848 RVA: 0x00047E9F File Offset: 0x00046E9F
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

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x00047EAA File Offset: 0x00046EAA
		// (set) Token: 0x060041D2 RID: 16850 RVA: 0x00047EB9 File Offset: 0x00046EB9
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

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00047EC4 File Offset: 0x00046EC4
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x00047ED3 File Offset: 0x00046ED3
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

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x00047EDE File Offset: 0x00046EDE
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x00047EF0 File Offset: 0x00046EF0
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

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x00047EFE File Offset: 0x00046EFE
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x00047F0D File Offset: 0x00046F0D
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

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x00047F18 File Offset: 0x00046F18
		// (set) Token: 0x060041DA RID: 16858 RVA: 0x00047F27 File Offset: 0x00046F27
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

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x00047F32 File Offset: 0x00046F32
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x00047F41 File Offset: 0x00046F41
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

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x00047F4C File Offset: 0x00046F4C
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x00047F5B File Offset: 0x00046F5B
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

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x00047F66 File Offset: 0x00046F66
		// (set) Token: 0x060041E0 RID: 16864 RVA: 0x00047F78 File Offset: 0x00046F78
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

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00047F86 File Offset: 0x00046F86
		// (set) Token: 0x060041E2 RID: 16866 RVA: 0x00047F95 File Offset: 0x00046F95
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

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x00047FA0 File Offset: 0x00046FA0
		// (set) Token: 0x060041E4 RID: 16868 RVA: 0x00047FAE File Offset: 0x00046FAE
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00047FB8 File Offset: 0x00046FB8
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x00047FC7 File Offset: 0x00046FC7
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

		// Token: 0x060041E7 RID: 16871 RVA: 0x00047FD2 File Offset: 0x00046FD2
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00047FE5 File Offset: 0x00046FE5
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00047FF4 File Offset: 0x00046FF4
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x00048006 File Offset: 0x00047006
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

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x00048014 File Offset: 0x00047014
		// (set) Token: 0x060041EC RID: 16876 RVA: 0x00048026 File Offset: 0x00047026
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

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x00048034 File Offset: 0x00047034
		// (set) Token: 0x060041EE RID: 16878 RVA: 0x00048043 File Offset: 0x00047043
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

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x0004804E File Offset: 0x0004704E
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x0004805D File Offset: 0x0004705D
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

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00048068 File Offset: 0x00047068
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x00048077 File Offset: 0x00047077
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

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x00048082 File Offset: 0x00047082
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x00048091 File Offset: 0x00047091
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

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x0004809C File Offset: 0x0004709C
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x000480AE File Offset: 0x000470AE
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

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x000480BC File Offset: 0x000470BC
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x000480CE File Offset: 0x000470CE
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

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x060041F9 RID: 16889 RVA: 0x000480DC File Offset: 0x000470DC
		// (set) Token: 0x060041FA RID: 16890 RVA: 0x000480EE File Offset: 0x000470EE
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

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x000480FC File Offset: 0x000470FC
		// (set) Token: 0x060041FC RID: 16892 RVA: 0x0004810E File Offset: 0x0004710E
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

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x0004811C File Offset: 0x0004711C
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x0004812E File Offset: 0x0004712E
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

		// Token: 0x060041FF RID: 16895 RVA: 0x0004813C File Offset: 0x0004713C
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x0004815A File Offset: 0x0004715A
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x00048177 File Offset: 0x00047177
		// (set) Token: 0x06004202 RID: 16898 RVA: 0x00048189 File Offset: 0x00047189
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

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x00048197 File Offset: 0x00047197
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x000481A9 File Offset: 0x000471A9
		[FIXField("693", EFieldOption.Required)]
		public string QuoteRespID
		{
			get
			{
				return this.GetStringField(693).Value;
			}
			set
			{
				this.AddStringField(693, value);
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x000481B7 File Offset: 0x000471B7
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x000481C6 File Offset: 0x000471C6
		[FIXField("117", EFieldOption.Optional)]
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

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x000481D1 File Offset: 0x000471D1
		// (set) Token: 0x06004208 RID: 16904 RVA: 0x000481E3 File Offset: 0x000471E3
		[FIXField("694", EFieldOption.Required)]
		public int QuoteRespType
		{
			get
			{
				return this.GetIntField(694).Value;
			}
			set
			{
				this.AddIntField(694, value);
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x000481F1 File Offset: 0x000471F1
		// (set) Token: 0x0600420A RID: 16906 RVA: 0x00048200 File Offset: 0x00047200
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

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x0004820B File Offset: 0x0004720B
		// (set) Token: 0x0600420C RID: 16908 RVA: 0x0004821D File Offset: 0x0004721D
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

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x0004822B File Offset: 0x0004722B
		// (set) Token: 0x0600420E RID: 16910 RVA: 0x0004823A File Offset: 0x0004723A
		[FIXField("23", EFieldOption.Optional)]
		public string IOIID
		{
			get
			{
				return this.GetStringField(23).Value;
			}
			set
			{
				this.AddStringField(23, value);
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x00048245 File Offset: 0x00047245
		// (set) Token: 0x06004210 RID: 16912 RVA: 0x00048257 File Offset: 0x00047257
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

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x00048265 File Offset: 0x00047265
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x00048277 File Offset: 0x00047277
		[FIXField("735", EFieldOption.Optional)]
		public int NoQuoteQualifiers
		{
			get
			{
				return this.GetIntField(735).Value;
			}
			set
			{
				this.AddIntField(735, value);
			}
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x00048285 File Offset: 0x00047285
		public FIXQuoteQualifiersGroup GetQuoteQualifiersGroup(int i)
		{
			if (i < this.NoQuoteQualifiers)
			{
				return (FIXQuoteQualifiersGroup)this.fQuoteQualifiersGroup[i];
			}
			return null;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x000482A3 File Offset: 0x000472A3
		public void AddGroup(FIXQuoteQualifiersGroup group)
		{
			this.fQuoteQualifiersGroup.Add(group);
			this.NoQuoteQualifiers++;
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x000482C0 File Offset: 0x000472C0
		// (set) Token: 0x06004216 RID: 16918 RVA: 0x000482D2 File Offset: 0x000472D2
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

		// Token: 0x06004217 RID: 16919 RVA: 0x000482E0 File Offset: 0x000472E0
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x000482FE File Offset: 0x000472FE
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x0004831B File Offset: 0x0004731B
		// (set) Token: 0x0600421A RID: 16922 RVA: 0x0004832D File Offset: 0x0004732D
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

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x0004833B File Offset: 0x0004733B
		// (set) Token: 0x0600421C RID: 16924 RVA: 0x0004834D File Offset: 0x0004734D
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

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x0004835B File Offset: 0x0004735B
		// (set) Token: 0x0600421E RID: 16926 RVA: 0x0004836A File Offset: 0x0004736A
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

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x00048375 File Offset: 0x00047375
		// (set) Token: 0x06004220 RID: 16928 RVA: 0x00048384 File Offset: 0x00047384
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

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06004221 RID: 16929 RVA: 0x0004838F File Offset: 0x0004738F
		// (set) Token: 0x06004222 RID: 16930 RVA: 0x0004839E File Offset: 0x0004739E
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

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x000483A9 File Offset: 0x000473A9
		// (set) Token: 0x06004224 RID: 16932 RVA: 0x000483B8 File Offset: 0x000473B8
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

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x000483C3 File Offset: 0x000473C3
		// (set) Token: 0x06004226 RID: 16934 RVA: 0x000483D5 File Offset: 0x000473D5
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

		// Token: 0x06004227 RID: 16935 RVA: 0x000483E3 File Offset: 0x000473E3
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x00048401 File Offset: 0x00047401
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x0004841E File Offset: 0x0004741E
		// (set) Token: 0x0600422A RID: 16938 RVA: 0x00048430 File Offset: 0x00047430
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

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x0004843E File Offset: 0x0004743E
		// (set) Token: 0x0600422C RID: 16940 RVA: 0x00048450 File Offset: 0x00047450
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

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x0600422D RID: 16941 RVA: 0x0004845E File Offset: 0x0004745E
		// (set) Token: 0x0600422E RID: 16942 RVA: 0x00048470 File Offset: 0x00047470
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

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x0004847E File Offset: 0x0004747E
		// (set) Token: 0x06004230 RID: 16944 RVA: 0x00048490 File Offset: 0x00047490
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

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x0004849E File Offset: 0x0004749E
		// (set) Token: 0x06004232 RID: 16946 RVA: 0x000484B0 File Offset: 0x000474B0
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

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x000484BE File Offset: 0x000474BE
		// (set) Token: 0x06004234 RID: 16948 RVA: 0x000484D0 File Offset: 0x000474D0
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

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06004235 RID: 16949 RVA: 0x000484DE File Offset: 0x000474DE
		// (set) Token: 0x06004236 RID: 16950 RVA: 0x000484F0 File Offset: 0x000474F0
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

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06004237 RID: 16951 RVA: 0x000484FE File Offset: 0x000474FE
		// (set) Token: 0x06004238 RID: 16952 RVA: 0x00048510 File Offset: 0x00047510
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

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06004239 RID: 16953 RVA: 0x0004851E File Offset: 0x0004751E
		// (set) Token: 0x0600423A RID: 16954 RVA: 0x00048530 File Offset: 0x00047530
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

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x0004853E File Offset: 0x0004753E
		// (set) Token: 0x0600423C RID: 16956 RVA: 0x00048550 File Offset: 0x00047550
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

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x0004855E File Offset: 0x0004755E
		// (set) Token: 0x0600423E RID: 16958 RVA: 0x00048570 File Offset: 0x00047570
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

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x0004857E File Offset: 0x0004757E
		// (set) Token: 0x06004240 RID: 16960 RVA: 0x00048590 File Offset: 0x00047590
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

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x0004859E File Offset: 0x0004759E
		// (set) Token: 0x06004242 RID: 16962 RVA: 0x000485B0 File Offset: 0x000475B0
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

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x000485BE File Offset: 0x000475BE
		// (set) Token: 0x06004244 RID: 16964 RVA: 0x000485D0 File Offset: 0x000475D0
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

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x000485DE File Offset: 0x000475DE
		// (set) Token: 0x06004246 RID: 16966 RVA: 0x000485F0 File Offset: 0x000475F0
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

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x000485FE File Offset: 0x000475FE
		// (set) Token: 0x06004248 RID: 16968 RVA: 0x00048610 File Offset: 0x00047610
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

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06004249 RID: 16969 RVA: 0x0004861E File Offset: 0x0004761E
		// (set) Token: 0x0600424A RID: 16970 RVA: 0x00048630 File Offset: 0x00047630
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

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x0004863E File Offset: 0x0004763E
		// (set) Token: 0x0600424C RID: 16972 RVA: 0x00048650 File Offset: 0x00047650
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

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x0004865E File Offset: 0x0004765E
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x00048670 File Offset: 0x00047670
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

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x0004867E File Offset: 0x0004767E
		// (set) Token: 0x06004250 RID: 16976 RVA: 0x00048690 File Offset: 0x00047690
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

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x0004869E File Offset: 0x0004769E
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x000486B0 File Offset: 0x000476B0
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

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x000486BE File Offset: 0x000476BE
		// (set) Token: 0x06004254 RID: 16980 RVA: 0x000486D0 File Offset: 0x000476D0
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

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06004255 RID: 16981 RVA: 0x000486DE File Offset: 0x000476DE
		// (set) Token: 0x06004256 RID: 16982 RVA: 0x000486F0 File Offset: 0x000476F0
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

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x000486FE File Offset: 0x000476FE
		// (set) Token: 0x06004258 RID: 16984 RVA: 0x00048710 File Offset: 0x00047710
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

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06004259 RID: 16985 RVA: 0x0004871E File Offset: 0x0004771E
		// (set) Token: 0x0600425A RID: 16986 RVA: 0x0004872D File Offset: 0x0004772D
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

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600425B RID: 16987 RVA: 0x00048738 File Offset: 0x00047738
		// (set) Token: 0x0600425C RID: 16988 RVA: 0x0004874A File Offset: 0x0004774A
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

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600425D RID: 16989 RVA: 0x00048758 File Offset: 0x00047758
		// (set) Token: 0x0600425E RID: 16990 RVA: 0x0004876A File Offset: 0x0004776A
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

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x00048778 File Offset: 0x00047778
		// (set) Token: 0x06004260 RID: 16992 RVA: 0x00048787 File Offset: 0x00047787
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

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x00048792 File Offset: 0x00047792
		// (set) Token: 0x06004262 RID: 16994 RVA: 0x000487A4 File Offset: 0x000477A4
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

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x000487B2 File Offset: 0x000477B2
		// (set) Token: 0x06004264 RID: 16996 RVA: 0x000487C4 File Offset: 0x000477C4
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

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x000487D2 File Offset: 0x000477D2
		// (set) Token: 0x06004266 RID: 16998 RVA: 0x000487E4 File Offset: 0x000477E4
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

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x000487F2 File Offset: 0x000477F2
		// (set) Token: 0x06004268 RID: 17000 RVA: 0x00048804 File Offset: 0x00047804
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

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06004269 RID: 17001 RVA: 0x00048812 File Offset: 0x00047812
		// (set) Token: 0x0600426A RID: 17002 RVA: 0x00048824 File Offset: 0x00047824
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

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x00048832 File Offset: 0x00047832
		// (set) Token: 0x0600426C RID: 17004 RVA: 0x00048844 File Offset: 0x00047844
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

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x00048852 File Offset: 0x00047852
		// (set) Token: 0x0600426E RID: 17006 RVA: 0x00048864 File Offset: 0x00047864
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

		// Token: 0x0600426F RID: 17007 RVA: 0x00048872 File Offset: 0x00047872
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00048890 File Offset: 0x00047890
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x000488AD File Offset: 0x000478AD
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x000488BF File Offset: 0x000478BF
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

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x000488CD File Offset: 0x000478CD
		// (set) Token: 0x06004274 RID: 17012 RVA: 0x000488DF File Offset: 0x000478DF
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

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x000488ED File Offset: 0x000478ED
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x000488FF File Offset: 0x000478FF
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringField(913).Value;
			}
			set
			{
				this.AddStringField(913, value);
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x0004890D File Offset: 0x0004790D
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x0004891F File Offset: 0x0004791F
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringField(914).Value;
			}
			set
			{
				this.AddStringField(914, value);
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x0004892D File Offset: 0x0004792D
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x0004893F File Offset: 0x0004793F
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeField(915).Value;
			}
			set
			{
				this.AddDateTimeField(915, value);
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x0004894D File Offset: 0x0004794D
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x0004895F File Offset: 0x0004795F
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleField(918).Value;
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x0004896D File Offset: 0x0004796D
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x0004897F File Offset: 0x0004797F
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntField(788).Value;
			}
			set
			{
				this.AddIntField(788, value);
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x0004898D File Offset: 0x0004798D
		// (set) Token: 0x06004280 RID: 17024 RVA: 0x0004899F File Offset: 0x0004799F
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeField(916).Value;
			}
			set
			{
				this.AddDateTimeField(916, value);
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x000489AD File Offset: 0x000479AD
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x000489BF File Offset: 0x000479BF
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeField(917).Value;
			}
			set
			{
				this.AddDateTimeField(917, value);
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x000489CD File Offset: 0x000479CD
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x000489DF File Offset: 0x000479DF
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntField(919).Value;
			}
			set
			{
				this.AddIntField(919, value);
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x000489ED File Offset: 0x000479ED
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x000489FF File Offset: 0x000479FF
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleField(898).Value;
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x00048A0D File Offset: 0x00047A0D
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x00048A1F File Offset: 0x00047A1F
		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntField(711).Value;
			}
			set
			{
				this.AddIntField(711, value);
			}
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x00048A2D File Offset: 0x00047A2D
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x00048A4B File Offset: 0x00047A4B
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x00048A68 File Offset: 0x00047A68
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x00048A77 File Offset: 0x00047A77
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

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x00048A82 File Offset: 0x00047A82
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x00048A91 File Offset: 0x00047A91
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleField(38).Value;
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x00048A9C File Offset: 0x00047A9C
		// (set) Token: 0x06004290 RID: 17040 RVA: 0x00048AAE File Offset: 0x00047AAE
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleField(152).Value;
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x00048ABC File Offset: 0x00047ABC
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x00048ACE File Offset: 0x00047ACE
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleField(516).Value;
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x00048ADC File Offset: 0x00047ADC
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x00048AEE File Offset: 0x00047AEE
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharField(468).Value;
			}
			set
			{
				this.AddCharField(468, value);
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x00048AFC File Offset: 0x00047AFC
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x00048B0E File Offset: 0x00047B0E
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleField(469).Value;
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x00048B1C File Offset: 0x00047B1C
		// (set) Token: 0x06004298 RID: 17048 RVA: 0x00048B2B File Offset: 0x00047B2B
		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharField(63).Value;
			}
			set
			{
				this.AddCharField(63, value);
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06004299 RID: 17049 RVA: 0x00048B36 File Offset: 0x00047B36
		// (set) Token: 0x0600429A RID: 17050 RVA: 0x00048B45 File Offset: 0x00047B45
		[FIXField("64", EFieldOption.Optional)]
		public DateTime SettlDate
		{
			get
			{
				return this.GetDateTimeField(64).Value;
			}
			set
			{
				this.AddDateTimeField(64, value);
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x00048B50 File Offset: 0x00047B50
		// (set) Token: 0x0600429C RID: 17052 RVA: 0x00048B62 File Offset: 0x00047B62
		[FIXField("193", EFieldOption.Optional)]
		public DateTime SettlDate2
		{
			get
			{
				return this.GetDateTimeField(193).Value;
			}
			set
			{
				this.AddDateTimeField(193, value);
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x00048B70 File Offset: 0x00047B70
		// (set) Token: 0x0600429E RID: 17054 RVA: 0x00048B82 File Offset: 0x00047B82
		[FIXField("192", EFieldOption.Optional)]
		public double OrderQty2
		{
			get
			{
				return this.GetDoubleField(192).Value;
			}
			set
			{
				this.AddDoubleField(192, value);
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x00048B90 File Offset: 0x00047B90
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x00048B9F File Offset: 0x00047B9F
		[FIXField("15", EFieldOption.Optional)]
		public double Currency
		{
			get
			{
				return this.GetDoubleField(15).Value;
			}
			set
			{
				this.AddDoubleField(15, value);
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x00048BAA File Offset: 0x00047BAA
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x00048BBC File Offset: 0x00047BBC
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntField(232).Value;
			}
			set
			{
				this.AddIntField(232, value);
			}
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00048BCA File Offset: 0x00047BCA
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00048BE8 File Offset: 0x00047BE8
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x00048C05 File Offset: 0x00047C05
		// (set) Token: 0x060042A6 RID: 17062 RVA: 0x00048C13 File Offset: 0x00047C13
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

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x00048C1D File Offset: 0x00047C1D
		// (set) Token: 0x060042A8 RID: 17064 RVA: 0x00048C2F File Offset: 0x00047C2F
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

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x00048C3D File Offset: 0x00047C3D
		// (set) Token: 0x060042AA RID: 17066 RVA: 0x00048C4F File Offset: 0x00047C4F
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

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x00048C5D File Offset: 0x00047C5D
		// (set) Token: 0x060042AC RID: 17068 RVA: 0x00048C6F File Offset: 0x00047C6F
		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntField(555).Value;
			}
			set
			{
				this.AddIntField(555, value);
			}
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x00048C7D File Offset: 0x00047C7D
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00048C9B File Offset: 0x00047C9B
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x00048CB8 File Offset: 0x00047CB8
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x00048CCA File Offset: 0x00047CCA
		[FIXField("132", EFieldOption.Optional)]
		public double BidPx
		{
			get
			{
				return this.GetDoubleField(132).Value;
			}
			set
			{
				this.AddDoubleField(132, value);
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x00048CD8 File Offset: 0x00047CD8
		// (set) Token: 0x060042B2 RID: 17074 RVA: 0x00048CEA File Offset: 0x00047CEA
		[FIXField("133", EFieldOption.Optional)]
		public double OfferPx
		{
			get
			{
				return this.GetDoubleField(133).Value;
			}
			set
			{
				this.AddDoubleField(133, value);
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x00048CF8 File Offset: 0x00047CF8
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x00048D0A File Offset: 0x00047D0A
		[FIXField("645", EFieldOption.Optional)]
		public double MktBidPx
		{
			get
			{
				return this.GetDoubleField(645).Value;
			}
			set
			{
				this.AddDoubleField(645, value);
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00048D18 File Offset: 0x00047D18
		// (set) Token: 0x060042B6 RID: 17078 RVA: 0x00048D2A File Offset: 0x00047D2A
		[FIXField("646", EFieldOption.Optional)]
		public double MktOfferPx
		{
			get
			{
				return this.GetDoubleField(646).Value;
			}
			set
			{
				this.AddDoubleField(646, value);
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x00048D38 File Offset: 0x00047D38
		// (set) Token: 0x060042B8 RID: 17080 RVA: 0x00048D4A File Offset: 0x00047D4A
		[FIXField("647", EFieldOption.Optional)]
		public double MinBidSize
		{
			get
			{
				return this.GetDoubleField(647).Value;
			}
			set
			{
				this.AddDoubleField(647, value);
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x00048D58 File Offset: 0x00047D58
		// (set) Token: 0x060042BA RID: 17082 RVA: 0x00048D6A File Offset: 0x00047D6A
		[FIXField("134", EFieldOption.Optional)]
		public double BidSize
		{
			get
			{
				return this.GetDoubleField(134).Value;
			}
			set
			{
				this.AddDoubleField(134, value);
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x060042BB RID: 17083 RVA: 0x00048D78 File Offset: 0x00047D78
		// (set) Token: 0x060042BC RID: 17084 RVA: 0x00048D8A File Offset: 0x00047D8A
		[FIXField("648", EFieldOption.Optional)]
		public double MinOfferSize
		{
			get
			{
				return this.GetDoubleField(648).Value;
			}
			set
			{
				this.AddDoubleField(648, value);
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x00048D98 File Offset: 0x00047D98
		// (set) Token: 0x060042BE RID: 17086 RVA: 0x00048DAA File Offset: 0x00047DAA
		[FIXField("135", EFieldOption.Optional)]
		public double OfferSize
		{
			get
			{
				return this.GetDoubleField(135).Value;
			}
			set
			{
				this.AddDoubleField(135, value);
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x00048DB8 File Offset: 0x00047DB8
		// (set) Token: 0x060042C0 RID: 17088 RVA: 0x00048DC7 File Offset: 0x00047DC7
		[FIXField("62", EFieldOption.Optional)]
		public DateTime ValidUntilTime
		{
			get
			{
				return this.GetDateTimeField(62).Value;
			}
			set
			{
				this.AddDateTimeField(62, value);
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x060042C1 RID: 17089 RVA: 0x00048DD2 File Offset: 0x00047DD2
		// (set) Token: 0x060042C2 RID: 17090 RVA: 0x00048DE4 File Offset: 0x00047DE4
		[FIXField("188", EFieldOption.Optional)]
		public double BidSpotRate
		{
			get
			{
				return this.GetDoubleField(188).Value;
			}
			set
			{
				this.AddDoubleField(188, value);
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x00048DF2 File Offset: 0x00047DF2
		// (set) Token: 0x060042C4 RID: 17092 RVA: 0x00048E04 File Offset: 0x00047E04
		[FIXField("190", EFieldOption.Optional)]
		public double OfferSpotRate
		{
			get
			{
				return this.GetDoubleField(190).Value;
			}
			set
			{
				this.AddDoubleField(190, value);
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x060042C5 RID: 17093 RVA: 0x00048E12 File Offset: 0x00047E12
		// (set) Token: 0x060042C6 RID: 17094 RVA: 0x00048E24 File Offset: 0x00047E24
		[FIXField("189", EFieldOption.Optional)]
		public double BidForwardPoints
		{
			get
			{
				return this.GetDoubleField(189).Value;
			}
			set
			{
				this.AddDoubleField(189, value);
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x060042C7 RID: 17095 RVA: 0x00048E32 File Offset: 0x00047E32
		// (set) Token: 0x060042C8 RID: 17096 RVA: 0x00048E44 File Offset: 0x00047E44
		[FIXField("191", EFieldOption.Optional)]
		public double OfferForwardPoints
		{
			get
			{
				return this.GetDoubleField(191).Value;
			}
			set
			{
				this.AddDoubleField(191, value);
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x060042C9 RID: 17097 RVA: 0x00048E52 File Offset: 0x00047E52
		// (set) Token: 0x060042CA RID: 17098 RVA: 0x00048E64 File Offset: 0x00047E64
		[FIXField("631", EFieldOption.Optional)]
		public double MidPx
		{
			get
			{
				return this.GetDoubleField(631).Value;
			}
			set
			{
				this.AddDoubleField(631, value);
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x00048E72 File Offset: 0x00047E72
		// (set) Token: 0x060042CC RID: 17100 RVA: 0x00048E84 File Offset: 0x00047E84
		[FIXField("632", EFieldOption.Optional)]
		public double BidYield
		{
			get
			{
				return this.GetDoubleField(632).Value;
			}
			set
			{
				this.AddDoubleField(632, value);
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x00048E92 File Offset: 0x00047E92
		// (set) Token: 0x060042CE RID: 17102 RVA: 0x00048EA4 File Offset: 0x00047EA4
		[FIXField("633", EFieldOption.Optional)]
		public double MidYield
		{
			get
			{
				return this.GetDoubleField(633).Value;
			}
			set
			{
				this.AddDoubleField(633, value);
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x00048EB2 File Offset: 0x00047EB2
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x00048EC4 File Offset: 0x00047EC4
		[FIXField("634", EFieldOption.Optional)]
		public double OfferYield
		{
			get
			{
				return this.GetDoubleField(634).Value;
			}
			set
			{
				this.AddDoubleField(634, value);
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x00048ED2 File Offset: 0x00047ED2
		// (set) Token: 0x060042D2 RID: 17106 RVA: 0x00048EE1 File Offset: 0x00047EE1
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

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x00048EEC File Offset: 0x00047EEC
		// (set) Token: 0x060042D4 RID: 17108 RVA: 0x00048EFB File Offset: 0x00047EFB
		[FIXField("40", EFieldOption.Optional)]
		public char OrdType
		{
			get
			{
				return this.GetCharField(40).Value;
			}
			set
			{
				this.AddCharField(40, value);
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x00048F06 File Offset: 0x00047F06
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x00048F18 File Offset: 0x00047F18
		[FIXField("642", EFieldOption.Optional)]
		public double BidForwardPoints2
		{
			get
			{
				return this.GetDoubleField(642).Value;
			}
			set
			{
				this.AddDoubleField(642, value);
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x00048F26 File Offset: 0x00047F26
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x00048F38 File Offset: 0x00047F38
		[FIXField("643", EFieldOption.Optional)]
		public double OfferForwardPoints2
		{
			get
			{
				return this.GetDoubleField(643).Value;
			}
			set
			{
				this.AddDoubleField(643, value);
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x00048F46 File Offset: 0x00047F46
		// (set) Token: 0x060042DA RID: 17114 RVA: 0x00048F58 File Offset: 0x00047F58
		[FIXField("656", EFieldOption.Optional)]
		public double SettlCurrBidFxRate
		{
			get
			{
				return this.GetDoubleField(656).Value;
			}
			set
			{
				this.AddDoubleField(656, value);
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x00048F66 File Offset: 0x00047F66
		// (set) Token: 0x060042DC RID: 17116 RVA: 0x00048F78 File Offset: 0x00047F78
		[FIXField("657", EFieldOption.Optional)]
		public double SettlCurrOfferFxRate
		{
			get
			{
				return this.GetDoubleField(657).Value;
			}
			set
			{
				this.AddDoubleField(657, value);
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x00048F86 File Offset: 0x00047F86
		// (set) Token: 0x060042DE RID: 17118 RVA: 0x00048F98 File Offset: 0x00047F98
		[FIXField("156", EFieldOption.Optional)]
		public char SettlCurrFxRateCalc
		{
			get
			{
				return this.GetCharField(156).Value;
			}
			set
			{
				this.AddCharField(156, value);
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x060042DF RID: 17119 RVA: 0x00048FA6 File Offset: 0x00047FA6
		// (set) Token: 0x060042E0 RID: 17120 RVA: 0x00048FB5 File Offset: 0x00047FB5
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleField(12).Value;
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x00048FC0 File Offset: 0x00047FC0
		// (set) Token: 0x060042E2 RID: 17122 RVA: 0x00048FCF File Offset: 0x00047FCF
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharField(13).Value;
			}
			set
			{
				this.AddCharField(13, value);
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x00048FDA File Offset: 0x00047FDA
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x00048FEC File Offset: 0x00047FEC
		[FIXField("582", EFieldOption.Optional)]
		public int CustOrderCapacity
		{
			get
			{
				return this.GetIntField(582).Value;
			}
			set
			{
				this.AddIntField(582, value);
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x00048FFA File Offset: 0x00047FFA
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x00049009 File Offset: 0x00048009
		[FIXField("100", EFieldOption.Optional)]
		public string ExDestination
		{
			get
			{
				return this.GetStringField(100).Value;
			}
			set
			{
				this.AddStringField(100, value);
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x00049014 File Offset: 0x00048014
		// (set) Token: 0x060042E8 RID: 17128 RVA: 0x00049023 File Offset: 0x00048023
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

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x0004902E File Offset: 0x0004802E
		// (set) Token: 0x060042EA RID: 17130 RVA: 0x00049040 File Offset: 0x00048040
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

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x0004904E File Offset: 0x0004804E
		// (set) Token: 0x060042EC RID: 17132 RVA: 0x00049060 File Offset: 0x00048060
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

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x0004906E File Offset: 0x0004806E
		// (set) Token: 0x060042EE RID: 17134 RVA: 0x0004907D File Offset: 0x0004807D
		[FIXField("44", EFieldOption.Optional)]
		public double Price
		{
			get
			{
				return this.GetDoubleField(44).Value;
			}
			set
			{
				this.AddDoubleField(44, value);
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x060042EF RID: 17135 RVA: 0x00049088 File Offset: 0x00048088
		// (set) Token: 0x060042F0 RID: 17136 RVA: 0x0004909A File Offset: 0x0004809A
		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntField(423).Value;
			}
			set
			{
				this.AddIntField(423, value);
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x060042F1 RID: 17137 RVA: 0x000490A8 File Offset: 0x000480A8
		// (set) Token: 0x060042F2 RID: 17138 RVA: 0x000490BA File Offset: 0x000480BA
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleField(218).Value;
			}
			set
			{
				this.AddDoubleField(218, value);
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x000490C8 File Offset: 0x000480C8
		// (set) Token: 0x060042F4 RID: 17140 RVA: 0x000490DA File Offset: 0x000480DA
		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleField(220).Value;
			}
			set
			{
				this.AddDoubleField(220, value);
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x000490E8 File Offset: 0x000480E8
		// (set) Token: 0x060042F6 RID: 17142 RVA: 0x000490FA File Offset: 0x000480FA
		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringField(221).Value;
			}
			set
			{
				this.AddStringField(221, value);
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x00049108 File Offset: 0x00048108
		// (set) Token: 0x060042F8 RID: 17144 RVA: 0x0004911A File Offset: 0x0004811A
		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringField(222).Value;
			}
			set
			{
				this.AddStringField(222, value);
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x060042F9 RID: 17145 RVA: 0x00049128 File Offset: 0x00048128
		// (set) Token: 0x060042FA RID: 17146 RVA: 0x0004913A File Offset: 0x0004813A
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleField(662).Value;
			}
			set
			{
				this.AddDoubleField(662, value);
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x00049148 File Offset: 0x00048148
		// (set) Token: 0x060042FC RID: 17148 RVA: 0x0004915A File Offset: 0x0004815A
		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntField(663).Value;
			}
			set
			{
				this.AddIntField(663, value);
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x060042FD RID: 17149 RVA: 0x00049168 File Offset: 0x00048168
		// (set) Token: 0x060042FE RID: 17150 RVA: 0x0004917A File Offset: 0x0004817A
		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringField(699).Value;
			}
			set
			{
				this.AddStringField(699, value);
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x00049188 File Offset: 0x00048188
		// (set) Token: 0x06004300 RID: 17152 RVA: 0x0004919A File Offset: 0x0004819A
		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringField(761).Value;
			}
			set
			{
				this.AddStringField(761, value);
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x000491A8 File Offset: 0x000481A8
		// (set) Token: 0x06004302 RID: 17154 RVA: 0x000491BA File Offset: 0x000481BA
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringField(235).Value;
			}
			set
			{
				this.AddStringField(235, value);
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x000491C8 File Offset: 0x000481C8
		// (set) Token: 0x06004304 RID: 17156 RVA: 0x000491DA File Offset: 0x000481DA
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleField(236).Value;
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x000491E8 File Offset: 0x000481E8
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x000491FA File Offset: 0x000481FA
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeField(701).Value;
			}
			set
			{
				this.AddDateTimeField(701, value);
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x00049208 File Offset: 0x00048208
		// (set) Token: 0x06004308 RID: 17160 RVA: 0x0004921A File Offset: 0x0004821A
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(696).Value;
			}
			set
			{
				this.AddDateTimeField(696, value);
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x00049228 File Offset: 0x00048228
		// (set) Token: 0x0600430A RID: 17162 RVA: 0x0004923A File Offset: 0x0004823A
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleField(697).Value;
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x00049248 File Offset: 0x00048248
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x0004925A File Offset: 0x0004825A
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntField(698).Value;
			}
			set
			{
				this.AddIntField(698, value);
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x00049268 File Offset: 0x00048268
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x00049277 File Offset: 0x00048277
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

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x00049282 File Offset: 0x00048282
		// (set) Token: 0x06004310 RID: 17168 RVA: 0x00049291 File Offset: 0x00048291
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

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x0004929C File Offset: 0x0004829C
		// (set) Token: 0x06004312 RID: 17170 RVA: 0x000492AB File Offset: 0x000482AB
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

		// Token: 0x06004313 RID: 17171 RVA: 0x000492B8 File Offset: 0x000482B8
		public FIXQuoteResponse()
		{
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00049330 File Offset: 0x00048330
		public FIXQuoteResponse(string QuoteRespID, int QuoteRespType)
		{
			this.QuoteRespID = QuoteRespID;
			this.QuoteRespType = QuoteRespType;
		}

		// Token: 0x0400099D RID: 2461
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400099E RID: 2462
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400099F RID: 2463
		private ArrayList fQuoteQualifiersGroup = new ArrayList();

		// Token: 0x040009A0 RID: 2464
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040009A1 RID: 2465
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040009A2 RID: 2466
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040009A3 RID: 2467
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040009A4 RID: 2468
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x040009A5 RID: 2469
		private ArrayList fLegsGroup = new ArrayList();
	}
}
