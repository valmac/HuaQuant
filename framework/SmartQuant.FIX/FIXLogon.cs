using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200007F RID: 127
	public class FIXLogon : FIXMessage
	{
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0001AFF8 File Offset: 0x00019FF8
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x0001B00A File Offset: 0x0001A00A
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

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0001B018 File Offset: 0x0001A018
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x0001B027 File Offset: 0x0001A027
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

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0001B032 File Offset: 0x0001A032
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x0001B041 File Offset: 0x0001A041
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

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x0001B04C File Offset: 0x0001A04C
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x0001B05B File Offset: 0x0001A05B
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0001B066 File Offset: 0x0001A066
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x0001B075 File Offset: 0x0001A075
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

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x0001B080 File Offset: 0x0001A080
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0001B08F File Offset: 0x0001A08F
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

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0001B09A File Offset: 0x0001A09A
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0001B0AC File Offset: 0x0001A0AC
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

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0001B0BA File Offset: 0x0001A0BA
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0001B0C9 File Offset: 0x0001A0C9
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

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0001B0D4 File Offset: 0x0001A0D4
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0001B0E3 File Offset: 0x0001A0E3
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

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0001B0EE File Offset: 0x0001A0EE
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0001B0FD File Offset: 0x0001A0FD
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

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0001B108 File Offset: 0x0001A108
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0001B117 File Offset: 0x0001A117
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

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0001B122 File Offset: 0x0001A122
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0001B134 File Offset: 0x0001A134
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

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0001B142 File Offset: 0x0001A142
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0001B151 File Offset: 0x0001A151
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

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0001B15C File Offset: 0x0001A15C
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0001B16A File Offset: 0x0001A16A
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

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x0001B174 File Offset: 0x0001A174
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0001B183 File Offset: 0x0001A183
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

		// Token: 0x060018B3 RID: 6323 RVA: 0x0001B18E File Offset: 0x0001A18E
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0001B1A1 File Offset: 0x0001A1A1
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x0001B1B0 File Offset: 0x0001A1B0
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x0001B1C2 File Offset: 0x0001A1C2
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

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0001B1D0 File Offset: 0x0001A1D0
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0001B1E2 File Offset: 0x0001A1E2
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0001B1F0 File Offset: 0x0001A1F0
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0001B1FF File Offset: 0x0001A1FF
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0001B20A File Offset: 0x0001A20A
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0001B219 File Offset: 0x0001A219
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0001B224 File Offset: 0x0001A224
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0001B233 File Offset: 0x0001A233
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0001B23E File Offset: 0x0001A23E
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0001B24D File Offset: 0x0001A24D
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0001B258 File Offset: 0x0001A258
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x0001B26A File Offset: 0x0001A26A
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

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0001B278 File Offset: 0x0001A278
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0001B28A File Offset: 0x0001A28A
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

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0001B298 File Offset: 0x0001A298
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0001B2AA File Offset: 0x0001A2AA
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0001B2B8 File Offset: 0x0001A2B8
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0001B2CA File Offset: 0x0001A2CA
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

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0001B2D8 File Offset: 0x0001A2D8
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x0001B2EA File Offset: 0x0001A2EA
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

		// Token: 0x060018CB RID: 6347 RVA: 0x0001B2F8 File Offset: 0x0001A2F8
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0001B316 File Offset: 0x0001A316
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0001B333 File Offset: 0x0001A333
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0001B345 File Offset: 0x0001A345
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

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x0001B353 File Offset: 0x0001A353
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0001B362 File Offset: 0x0001A362
		[FIXField("98", EFieldOption.Required)]
		public int EncryptMethod
		{
			get
			{
				return this.GetIntField(98).Value;
			}
			set
			{
				this.AddIntField(98, value);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0001B36D File Offset: 0x0001A36D
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x0001B37C File Offset: 0x0001A37C
		[FIXField("108", EFieldOption.Required)]
		public int HeartBtInt
		{
			get
			{
				return this.GetIntField(108).Value;
			}
			set
			{
				this.AddIntField(108, value);
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x0001B387 File Offset: 0x0001A387
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x0001B396 File Offset: 0x0001A396
		[FIXField("95", EFieldOption.Optional)]
		public int RawDataLength
		{
			get
			{
				return this.GetIntField(95).Value;
			}
			set
			{
				this.AddIntField(95, value);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0001B3A1 File Offset: 0x0001A3A1
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0001B3B0 File Offset: 0x0001A3B0
		[FIXField("96", EFieldOption.Optional)]
		public string RawData
		{
			get
			{
				return this.GetStringField(96).Value;
			}
			set
			{
				this.AddStringField(96, value);
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0001B3BB File Offset: 0x0001A3BB
		// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0001B3CD File Offset: 0x0001A3CD
		[FIXField("141", EFieldOption.Optional)]
		public bool ResetSeqNumFlag
		{
			get
			{
				return this.GetBoolField(141).Value;
			}
			set
			{
				this.AddBoolField(141, value);
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0001B3DB File Offset: 0x0001A3DB
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x0001B3ED File Offset: 0x0001A3ED
		[FIXField("789", EFieldOption.Optional)]
		public int NextExpectedMsgSeqNum
		{
			get
			{
				return this.GetIntField(789).Value;
			}
			set
			{
				this.AddIntField(789, value);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0001B3FB File Offset: 0x0001A3FB
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0001B40D File Offset: 0x0001A40D
		[FIXField("383", EFieldOption.Optional)]
		public int MaxMessageSize
		{
			get
			{
				return this.GetIntField(383).Value;
			}
			set
			{
				this.AddIntField(383, value);
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0001B41B File Offset: 0x0001A41B
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0001B42D File Offset: 0x0001A42D
		[FIXField("384", EFieldOption.Optional)]
		public int NoMsgTypes
		{
			get
			{
				return this.GetIntField(384).Value;
			}
			set
			{
				this.AddIntField(384, value);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0001B43B File Offset: 0x0001A43B
		public FIXMsgTypesGroup GetMsgTypesGroup(int i)
		{
			if (i < this.NoMsgTypes)
			{
				return (FIXMsgTypesGroup)this.fMsgTypesGroup[i];
			}
			return null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0001B459 File Offset: 0x0001A459
		public void AddGroup(FIXMsgTypesGroup group)
		{
			this.fMsgTypesGroup.Add(group);
			this.NoMsgTypes++;
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0001B476 File Offset: 0x0001A476
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0001B488 File Offset: 0x0001A488
		[FIXField("464", EFieldOption.Optional)]
		public bool TestMessageIndicator
		{
			get
			{
				return this.GetBoolField(464).Value;
			}
			set
			{
				this.AddBoolField(464, value);
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0001B496 File Offset: 0x0001A496
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0001B4A8 File Offset: 0x0001A4A8
		[FIXField("553", EFieldOption.Optional)]
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

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0001B4B6 File Offset: 0x0001A4B6
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0001B4C8 File Offset: 0x0001A4C8
		[FIXField("554", EFieldOption.Optional)]
		public string Password
		{
			get
			{
				return this.GetStringField(554).Value;
			}
			set
			{
				this.AddStringField(554, value);
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0001B4D6 File Offset: 0x0001A4D6
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0001B4E5 File Offset: 0x0001A4E5
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

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0001B4F0 File Offset: 0x0001A4F0
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0001B4FF File Offset: 0x0001A4FF
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

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0001B50A File Offset: 0x0001A50A
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0001B519 File Offset: 0x0001A519
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

		// Token: 0x060018ED RID: 6381 RVA: 0x0001B524 File Offset: 0x0001A524
		public FIXLogon()
		{
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0001B54D File Offset: 0x0001A54D
		public FIXLogon(int EncryptMethod, int HeartBtInt)
		{
			this.EncryptMethod = EncryptMethod;
			this.HeartBtInt = HeartBtInt;
		}

		// Token: 0x040002A3 RID: 675
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002A4 RID: 676
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002A5 RID: 677
		private ArrayList fMsgTypesGroup = new ArrayList();
	}
}
