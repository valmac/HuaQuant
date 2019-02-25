using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200006D RID: 109
	public class FIXReject : FIXMessage
	{
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00016815 File Offset: 0x00015815
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00016827 File Offset: 0x00015827
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

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00016835 File Offset: 0x00015835
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00016844 File Offset: 0x00015844
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

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0001684F File Offset: 0x0001584F
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0001685E File Offset: 0x0001585E
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

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00016869 File Offset: 0x00015869
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x00016878 File Offset: 0x00015878
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00016883 File Offset: 0x00015883
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x00016892 File Offset: 0x00015892
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

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0001689D File Offset: 0x0001589D
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x000168AC File Offset: 0x000158AC
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x000168B7 File Offset: 0x000158B7
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x000168C9 File Offset: 0x000158C9
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

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x000168D7 File Offset: 0x000158D7
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x000168E6 File Offset: 0x000158E6
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

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000168F1 File Offset: 0x000158F1
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x00016900 File Offset: 0x00015900
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

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0001690B File Offset: 0x0001590B
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x0001691A File Offset: 0x0001591A
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

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x00016925 File Offset: 0x00015925
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x00016934 File Offset: 0x00015934
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0001693F File Offset: 0x0001593F
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x00016951 File Offset: 0x00015951
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0001695F File Offset: 0x0001595F
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x0001696E File Offset: 0x0001596E
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

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00016979 File Offset: 0x00015979
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x00016987 File Offset: 0x00015987
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00016991 File Offset: 0x00015991
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x000169A0 File Offset: 0x000159A0
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

		// Token: 0x06001435 RID: 5173 RVA: 0x000169AB File Offset: 0x000159AB
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000169BE File Offset: 0x000159BE
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x000169CD File Offset: 0x000159CD
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x000169DF File Offset: 0x000159DF
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

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000169ED File Offset: 0x000159ED
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x000169FF File Offset: 0x000159FF
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

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00016A0D File Offset: 0x00015A0D
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x00016A1C File Offset: 0x00015A1C
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x00016A27 File Offset: 0x00015A27
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x00016A36 File Offset: 0x00015A36
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

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00016A41 File Offset: 0x00015A41
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x00016A50 File Offset: 0x00015A50
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

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x00016A5B File Offset: 0x00015A5B
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x00016A6A File Offset: 0x00015A6A
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

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x00016A75 File Offset: 0x00015A75
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x00016A87 File Offset: 0x00015A87
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

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00016A95 File Offset: 0x00015A95
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x00016AA7 File Offset: 0x00015AA7
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

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00016AB5 File Offset: 0x00015AB5
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x00016AC7 File Offset: 0x00015AC7
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

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00016AD5 File Offset: 0x00015AD5
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00016AE7 File Offset: 0x00015AE7
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

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x00016AF5 File Offset: 0x00015AF5
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x00016B07 File Offset: 0x00015B07
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

		// Token: 0x0600144D RID: 5197 RVA: 0x00016B15 File Offset: 0x00015B15
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00016B33 File Offset: 0x00015B33
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00016B50 File Offset: 0x00015B50
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x00016B62 File Offset: 0x00015B62
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

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00016B70 File Offset: 0x00015B70
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00016B7F File Offset: 0x00015B7F
		[FIXField("45", EFieldOption.Required)]
		public int RefSeqNum
		{
			get
			{
				return this.GetIntField(45).Value;
			}
			set
			{
				this.AddIntField(45, value);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00016B8A File Offset: 0x00015B8A
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00016B9C File Offset: 0x00015B9C
		[FIXField("371", EFieldOption.Optional)]
		public int RefTagID
		{
			get
			{
				return this.GetIntField(371).Value;
			}
			set
			{
				this.AddIntField(371, value);
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00016BAA File Offset: 0x00015BAA
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00016BBC File Offset: 0x00015BBC
		[FIXField("372", EFieldOption.Optional)]
		public string RefMsgType
		{
			get
			{
				return this.GetStringField(372).Value;
			}
			set
			{
				this.AddStringField(372, value);
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00016BCA File Offset: 0x00015BCA
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x00016BDC File Offset: 0x00015BDC
		[FIXField("373", EFieldOption.Optional)]
		public int SessionRejectReason
		{
			get
			{
				return this.GetIntField(373).Value;
			}
			set
			{
				this.AddIntField(373, value);
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00016BEA File Offset: 0x00015BEA
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x00016BF9 File Offset: 0x00015BF9
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

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x00016C04 File Offset: 0x00015C04
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00016C16 File Offset: 0x00015C16
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00016C24 File Offset: 0x00015C24
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x00016C36 File Offset: 0x00015C36
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

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00016C44 File Offset: 0x00015C44
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x00016C53 File Offset: 0x00015C53
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

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00016C5E File Offset: 0x00015C5E
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00016C6D File Offset: 0x00015C6D
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

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x00016C78 File Offset: 0x00015C78
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x00016C87 File Offset: 0x00015C87
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

		// Token: 0x06001465 RID: 5221 RVA: 0x00016C92 File Offset: 0x00015C92
		public FIXReject()
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00016CB0 File Offset: 0x00015CB0
		public FIXReject(int RefSeqNum)
		{
			this.RefSeqNum = RefSeqNum;
		}

		// Token: 0x04000261 RID: 609
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000262 RID: 610
		private ArrayList fHopsGroup = new ArrayList();
	}
}
