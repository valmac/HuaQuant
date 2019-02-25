using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000110 RID: 272
	public class FIXSequenceReset : FIXMessage
	{
		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x00035F17 File Offset: 0x00034F17
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x00035F29 File Offset: 0x00034F29
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

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x00035F37 File Offset: 0x00034F37
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x00035F46 File Offset: 0x00034F46
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

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x00035F51 File Offset: 0x00034F51
		// (set) Token: 0x0600330C RID: 13068 RVA: 0x00035F60 File Offset: 0x00034F60
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

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x00035F6B File Offset: 0x00034F6B
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x00035F7A File Offset: 0x00034F7A
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

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x00035F85 File Offset: 0x00034F85
		// (set) Token: 0x06003310 RID: 13072 RVA: 0x00035F94 File Offset: 0x00034F94
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

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x00035F9F File Offset: 0x00034F9F
		// (set) Token: 0x06003312 RID: 13074 RVA: 0x00035FAE File Offset: 0x00034FAE
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

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00035FB9 File Offset: 0x00034FB9
		// (set) Token: 0x06003314 RID: 13076 RVA: 0x00035FCB File Offset: 0x00034FCB
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

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x00035FD9 File Offset: 0x00034FD9
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x00035FE8 File Offset: 0x00034FE8
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

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x00035FF3 File Offset: 0x00034FF3
		// (set) Token: 0x06003318 RID: 13080 RVA: 0x00036002 File Offset: 0x00035002
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

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x0003600D File Offset: 0x0003500D
		// (set) Token: 0x0600331A RID: 13082 RVA: 0x0003601C File Offset: 0x0003501C
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

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x0600331B RID: 13083 RVA: 0x00036027 File Offset: 0x00035027
		// (set) Token: 0x0600331C RID: 13084 RVA: 0x00036036 File Offset: 0x00035036
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

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600331D RID: 13085 RVA: 0x00036041 File Offset: 0x00035041
		// (set) Token: 0x0600331E RID: 13086 RVA: 0x00036053 File Offset: 0x00035053
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

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x00036061 File Offset: 0x00035061
		// (set) Token: 0x06003320 RID: 13088 RVA: 0x00036070 File Offset: 0x00035070
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

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x0003607B File Offset: 0x0003507B
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x00036089 File Offset: 0x00035089
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

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x00036093 File Offset: 0x00035093
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x000360A2 File Offset: 0x000350A2
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

		// Token: 0x06003325 RID: 13093 RVA: 0x000360AD File Offset: 0x000350AD
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x000360C0 File Offset: 0x000350C0
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x000360CF File Offset: 0x000350CF
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x000360E1 File Offset: 0x000350E1
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

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000360EF File Offset: 0x000350EF
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x00036101 File Offset: 0x00035101
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

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x0003610F File Offset: 0x0003510F
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x0003611E File Offset: 0x0003511E
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

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x00036129 File Offset: 0x00035129
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x00036138 File Offset: 0x00035138
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

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x00036143 File Offset: 0x00035143
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x00036152 File Offset: 0x00035152
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

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x0003615D File Offset: 0x0003515D
		// (set) Token: 0x06003332 RID: 13106 RVA: 0x0003616C File Offset: 0x0003516C
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

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x00036177 File Offset: 0x00035177
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x00036189 File Offset: 0x00035189
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

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x00036197 File Offset: 0x00035197
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x000361A9 File Offset: 0x000351A9
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

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x000361B7 File Offset: 0x000351B7
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x000361C9 File Offset: 0x000351C9
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

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x000361D7 File Offset: 0x000351D7
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x000361E9 File Offset: 0x000351E9
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

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x000361F7 File Offset: 0x000351F7
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x00036209 File Offset: 0x00035209
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

		// Token: 0x0600333D RID: 13117 RVA: 0x00036217 File Offset: 0x00035217
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00036235 File Offset: 0x00035235
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x00036252 File Offset: 0x00035252
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x00036264 File Offset: 0x00035264
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

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x00036272 File Offset: 0x00035272
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x00036281 File Offset: 0x00035281
		[FIXField("123", EFieldOption.Optional)]
		public bool GapFillFlag
		{
			get
			{
				return this.GetBoolField(123).Value;
			}
			set
			{
				this.AddBoolField(123, value);
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x0003628C File Offset: 0x0003528C
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x0003629B File Offset: 0x0003529B
		[FIXField("36", EFieldOption.Required)]
		public int NewSeqNo
		{
			get
			{
				return this.GetIntField(36).Value;
			}
			set
			{
				this.AddIntField(36, value);
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x000362A6 File Offset: 0x000352A6
		// (set) Token: 0x06003346 RID: 13126 RVA: 0x000362B5 File Offset: 0x000352B5
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

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x000362C0 File Offset: 0x000352C0
		// (set) Token: 0x06003348 RID: 13128 RVA: 0x000362CF File Offset: 0x000352CF
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

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x000362DA File Offset: 0x000352DA
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x000362E9 File Offset: 0x000352E9
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

		// Token: 0x0600334B RID: 13131 RVA: 0x000362F4 File Offset: 0x000352F4
		public FIXSequenceReset()
		{
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00036312 File Offset: 0x00035312
		public FIXSequenceReset(int NewSeqNo)
		{
			this.NewSeqNo = NewSeqNo;
		}

		// Token: 0x040004EB RID: 1259
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040004EC RID: 1260
		private ArrayList fHopsGroup = new ArrayList();
	}
}
