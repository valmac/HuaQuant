using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000D9 RID: 217
	public class FIXTradingSessionStatusRequest : FIXMessage
	{
		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x0002D72B File Offset: 0x0002C72B
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x0002D73D File Offset: 0x0002C73D
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

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x0002D74B File Offset: 0x0002C74B
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x0002D75A File Offset: 0x0002C75A
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

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0002D765 File Offset: 0x0002C765
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x0002D774 File Offset: 0x0002C774
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

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0002D77F File Offset: 0x0002C77F
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0002D78E File Offset: 0x0002C78E
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

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0002D799 File Offset: 0x0002C799
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x0002D7A8 File Offset: 0x0002C7A8
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

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0002D7B3 File Offset: 0x0002C7B3
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0002D7C2 File Offset: 0x0002C7C2
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

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0002D7CD File Offset: 0x0002C7CD
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0002D7DF File Offset: 0x0002C7DF
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

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0002D7ED File Offset: 0x0002C7ED
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0002D7FC File Offset: 0x0002C7FC
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

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x0002D807 File Offset: 0x0002C807
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x0002D816 File Offset: 0x0002C816
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0002D821 File Offset: 0x0002C821
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x0002D830 File Offset: 0x0002C830
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0002D83B File Offset: 0x0002C83B
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x0002D84A File Offset: 0x0002C84A
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

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0002D855 File Offset: 0x0002C855
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x0002D867 File Offset: 0x0002C867
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

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0002D875 File Offset: 0x0002C875
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x0002D884 File Offset: 0x0002C884
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

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x0002D88F File Offset: 0x0002C88F
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x0002D89D File Offset: 0x0002C89D
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

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x0002D8A7 File Offset: 0x0002C8A7
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x0002D8B6 File Offset: 0x0002C8B6
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

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0002D8C1 File Offset: 0x0002C8C1
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0002D8D4 File Offset: 0x0002C8D4
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0002D8E3 File Offset: 0x0002C8E3
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x0002D8F5 File Offset: 0x0002C8F5
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

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x0002D903 File Offset: 0x0002C903
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x0002D915 File Offset: 0x0002C915
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

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x0002D923 File Offset: 0x0002C923
		// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x0002D932 File Offset: 0x0002C932
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

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x0002D93D File Offset: 0x0002C93D
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x0002D94C File Offset: 0x0002C94C
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x0002D957 File Offset: 0x0002C957
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x0002D966 File Offset: 0x0002C966
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

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0002D971 File Offset: 0x0002C971
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x0002D980 File Offset: 0x0002C980
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

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0002D98B File Offset: 0x0002C98B
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x0002D99D File Offset: 0x0002C99D
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

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x0002D9AB File Offset: 0x0002C9AB
		// (set) Token: 0x06002AEA RID: 10986 RVA: 0x0002D9BD File Offset: 0x0002C9BD
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

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0002D9CB File Offset: 0x0002C9CB
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x0002D9DD File Offset: 0x0002C9DD
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

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x0002D9EB File Offset: 0x0002C9EB
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x0002D9FD File Offset: 0x0002C9FD
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

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x0002DA0B File Offset: 0x0002CA0B
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0002DA1D File Offset: 0x0002CA1D
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

		// Token: 0x06002AF1 RID: 10993 RVA: 0x0002DA2B File Offset: 0x0002CA2B
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0002DA49 File Offset: 0x0002CA49
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x0002DA66 File Offset: 0x0002CA66
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0002DA78 File Offset: 0x0002CA78
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

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x0002DA86 File Offset: 0x0002CA86
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x0002DA98 File Offset: 0x0002CA98
		[FIXField("335", EFieldOption.Required)]
		public string TradSesReqID
		{
			get
			{
				return this.GetStringField(335).Value;
			}
			set
			{
				this.AddStringField(335, value);
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x0002DAA6 File Offset: 0x0002CAA6
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0002DAB8 File Offset: 0x0002CAB8
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

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x0002DAC6 File Offset: 0x0002CAC6
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x0002DAD8 File Offset: 0x0002CAD8
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

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x0002DAE6 File Offset: 0x0002CAE6
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x0002DAF8 File Offset: 0x0002CAF8
		[FIXField("338", EFieldOption.Optional)]
		public int TradSesMethod
		{
			get
			{
				return this.GetIntField(338).Value;
			}
			set
			{
				this.AddIntField(338, value);
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x0002DB06 File Offset: 0x0002CB06
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0002DB18 File Offset: 0x0002CB18
		[FIXField("339", EFieldOption.Optional)]
		public int TradSesMode
		{
			get
			{
				return this.GetIntField(339).Value;
			}
			set
			{
				this.AddIntField(339, value);
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x0002DB26 File Offset: 0x0002CB26
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0002DB38 File Offset: 0x0002CB38
		[FIXField("263", EFieldOption.Required)]
		public char SubscriptionRequestType
		{
			get
			{
				return this.GetCharField(263).Value;
			}
			set
			{
				this.AddCharField(263, value);
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0002DB46 File Offset: 0x0002CB46
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0002DB55 File Offset: 0x0002CB55
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

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x0002DB60 File Offset: 0x0002CB60
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0002DB6F File Offset: 0x0002CB6F
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

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x0002DB7A File Offset: 0x0002CB7A
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x0002DB89 File Offset: 0x0002CB89
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

		// Token: 0x06002B07 RID: 11015 RVA: 0x0002DB94 File Offset: 0x0002CB94
		public FIXTradingSessionStatusRequest()
		{
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0002DBB2 File Offset: 0x0002CBB2
		public FIXTradingSessionStatusRequest(string TradSesReqID, char SubscriptionRequestType)
		{
			this.TradSesReqID = TradSesReqID;
			this.SubscriptionRequestType = SubscriptionRequestType;
		}

		// Token: 0x040003C8 RID: 968
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003C9 RID: 969
		private ArrayList fHopsGroup = new ArrayList();
	}
}
