using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000028 RID: 40
	public class FIXBidResponse : FIXMessage
	{
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0000BDE8 File Offset: 0x0000ADE8
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0000BDFA File Offset: 0x0000ADFA
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0000BE08 File Offset: 0x0000AE08
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0000BE17 File Offset: 0x0000AE17
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

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0000BE22 File Offset: 0x0000AE22
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0000BE31 File Offset: 0x0000AE31
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

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0000BE3C File Offset: 0x0000AE3C
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0000BE4B File Offset: 0x0000AE4B
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0000BE56 File Offset: 0x0000AE56
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0000BE65 File Offset: 0x0000AE65
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

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0000BE70 File Offset: 0x0000AE70
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0000BE7F File Offset: 0x0000AE7F
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0000BE8A File Offset: 0x0000AE8A
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0000BE9C File Offset: 0x0000AE9C
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0000BEAA File Offset: 0x0000AEAA
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0000BEB9 File Offset: 0x0000AEB9
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0000BEC4 File Offset: 0x0000AEC4
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0000BED3 File Offset: 0x0000AED3
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

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0000BEDE File Offset: 0x0000AEDE
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0000BEED File Offset: 0x0000AEED
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0000BEF8 File Offset: 0x0000AEF8
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0000BF07 File Offset: 0x0000AF07
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0000BF12 File Offset: 0x0000AF12
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0000BF24 File Offset: 0x0000AF24
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0000BF32 File Offset: 0x0000AF32
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0000BF41 File Offset: 0x0000AF41
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

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0000BF4C File Offset: 0x0000AF4C
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x0000BF5A File Offset: 0x0000AF5A
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0000BF64 File Offset: 0x0000AF64
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0000BF73 File Offset: 0x0000AF73
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

		// Token: 0x0600094F RID: 2383 RVA: 0x0000BF7E File Offset: 0x0000AF7E
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0000BF91 File Offset: 0x0000AF91
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0000BFA0 File Offset: 0x0000AFA0
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0000BFB2 File Offset: 0x0000AFB2
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

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0000BFC0 File Offset: 0x0000AFC0
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0000BFD2 File Offset: 0x0000AFD2
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0000BFE0 File Offset: 0x0000AFE0
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x0000BFEF File Offset: 0x0000AFEF
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0000BFFA File Offset: 0x0000AFFA
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0000C009 File Offset: 0x0000B009
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

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0000C014 File Offset: 0x0000B014
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x0000C023 File Offset: 0x0000B023
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

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0000C02E File Offset: 0x0000B02E
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0000C03D File Offset: 0x0000B03D
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0000C048 File Offset: 0x0000B048
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0000C05A File Offset: 0x0000B05A
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

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0000C068 File Offset: 0x0000B068
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0000C07A File Offset: 0x0000B07A
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0000C088 File Offset: 0x0000B088
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0000C09A File Offset: 0x0000B09A
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0000C0A8 File Offset: 0x0000B0A8
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0000C0BA File Offset: 0x0000B0BA
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0000C0C8 File Offset: 0x0000B0C8
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0000C0DA File Offset: 0x0000B0DA
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

		// Token: 0x06000967 RID: 2407 RVA: 0x0000C0E8 File Offset: 0x0000B0E8
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0000C106 File Offset: 0x0000B106
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0000C123 File Offset: 0x0000B123
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0000C135 File Offset: 0x0000B135
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0000C143 File Offset: 0x0000B143
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x0000C155 File Offset: 0x0000B155
		[FIXField("390", EFieldOption.Optional)]
		public string BidID
		{
			get
			{
				return this.GetStringField(390).Value;
			}
			set
			{
				this.AddStringField(390, value);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0000C163 File Offset: 0x0000B163
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x0000C175 File Offset: 0x0000B175
		[FIXField("391", EFieldOption.Optional)]
		public string ClientBidID
		{
			get
			{
				return this.GetStringField(391).Value;
			}
			set
			{
				this.AddStringField(391, value);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0000C183 File Offset: 0x0000B183
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x0000C195 File Offset: 0x0000B195
		[FIXField("420", EFieldOption.Required)]
		public int NoBidComponents
		{
			get
			{
				return this.GetIntField(420).Value;
			}
			set
			{
				this.AddIntField(420, value);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0000C1A3 File Offset: 0x0000B1A3
		public FIXBidComponentsGroup GetBidComponentsGroup(int i)
		{
			if (i < this.NoBidComponents)
			{
				return (FIXBidComponentsGroup)this.fBidComponentsGroup[i];
			}
			return null;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000C1C1 File Offset: 0x0000B1C1
		public void AddGroup(FIXBidComponentsGroup group)
		{
			this.fBidComponentsGroup.Add(group);
			this.NoBidComponents++;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0000C1DE File Offset: 0x0000B1DE
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0000C1ED File Offset: 0x0000B1ED
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0000C1F8 File Offset: 0x0000B1F8
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x0000C207 File Offset: 0x0000B207
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0000C212 File Offset: 0x0000B212
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x0000C221 File Offset: 0x0000B221
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

		// Token: 0x06000979 RID: 2425 RVA: 0x0000C22C File Offset: 0x0000B22C
		public FIXBidResponse()
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0000C255 File Offset: 0x0000B255
		public FIXBidResponse(int NoBidComponents)
		{
			this.NoBidComponents = NoBidComponents;
		}

		// Token: 0x0400006E RID: 110
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400006F RID: 111
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000070 RID: 112
		private ArrayList fBidComponentsGroup = new ArrayList();
	}
}
