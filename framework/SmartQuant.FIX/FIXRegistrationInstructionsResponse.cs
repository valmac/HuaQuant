using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000114 RID: 276
	public class FIXRegistrationInstructionsResponse : FIXMessage
	{
		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00036882 File Offset: 0x00035882
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x00036894 File Offset: 0x00035894
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

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000368A2 File Offset: 0x000358A2
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x000368B1 File Offset: 0x000358B1
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

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000368BC File Offset: 0x000358BC
		// (set) Token: 0x060033A8 RID: 13224 RVA: 0x000368CB File Offset: 0x000358CB
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

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000368D6 File Offset: 0x000358D6
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x000368E5 File Offset: 0x000358E5
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

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x000368F0 File Offset: 0x000358F0
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x000368FF File Offset: 0x000358FF
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

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x0003690A File Offset: 0x0003590A
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x00036919 File Offset: 0x00035919
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

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x00036924 File Offset: 0x00035924
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x00036936 File Offset: 0x00035936
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

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x00036944 File Offset: 0x00035944
		// (set) Token: 0x060033B2 RID: 13234 RVA: 0x00036953 File Offset: 0x00035953
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

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x0003695E File Offset: 0x0003595E
		// (set) Token: 0x060033B4 RID: 13236 RVA: 0x0003696D File Offset: 0x0003596D
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

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x00036978 File Offset: 0x00035978
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x00036987 File Offset: 0x00035987
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

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x00036992 File Offset: 0x00035992
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x000369A1 File Offset: 0x000359A1
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

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000369AC File Offset: 0x000359AC
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x000369BE File Offset: 0x000359BE
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

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x000369CC File Offset: 0x000359CC
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x000369DB File Offset: 0x000359DB
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

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x000369E6 File Offset: 0x000359E6
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x000369F4 File Offset: 0x000359F4
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

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x000369FE File Offset: 0x000359FE
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x00036A0D File Offset: 0x00035A0D
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

		// Token: 0x060033C1 RID: 13249 RVA: 0x00036A18 File Offset: 0x00035A18
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00036A2B File Offset: 0x00035A2B
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x00036A3A File Offset: 0x00035A3A
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x00036A4C File Offset: 0x00035A4C
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

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x00036A5A File Offset: 0x00035A5A
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x00036A6C File Offset: 0x00035A6C
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

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x00036A7A File Offset: 0x00035A7A
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x00036A89 File Offset: 0x00035A89
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

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x00036A94 File Offset: 0x00035A94
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x00036AA3 File Offset: 0x00035AA3
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

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x00036AAE File Offset: 0x00035AAE
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x00036ABD File Offset: 0x00035ABD
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

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x00036AC8 File Offset: 0x00035AC8
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x00036AD7 File Offset: 0x00035AD7
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

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x00036AE2 File Offset: 0x00035AE2
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x00036AF4 File Offset: 0x00035AF4
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

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x00036B02 File Offset: 0x00035B02
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x00036B14 File Offset: 0x00035B14
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

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x00036B22 File Offset: 0x00035B22
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x00036B34 File Offset: 0x00035B34
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

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x00036B42 File Offset: 0x00035B42
		// (set) Token: 0x060033D6 RID: 13270 RVA: 0x00036B54 File Offset: 0x00035B54
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

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x00036B62 File Offset: 0x00035B62
		// (set) Token: 0x060033D8 RID: 13272 RVA: 0x00036B74 File Offset: 0x00035B74
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

		// Token: 0x060033D9 RID: 13273 RVA: 0x00036B82 File Offset: 0x00035B82
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00036BA0 File Offset: 0x00035BA0
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x00036BBD File Offset: 0x00035BBD
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x00036BCF File Offset: 0x00035BCF
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

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x00036BDD File Offset: 0x00035BDD
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x00036BEF File Offset: 0x00035BEF
		[FIXField("513", EFieldOption.Required)]
		public string RegistID
		{
			get
			{
				return this.GetStringField(513).Value;
			}
			set
			{
				this.AddStringField(513, value);
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x00036BFD File Offset: 0x00035BFD
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x00036C0F File Offset: 0x00035C0F
		[FIXField("514", EFieldOption.Required)]
		public char RegistTransType
		{
			get
			{
				return this.GetCharField(514).Value;
			}
			set
			{
				this.AddCharField(514, value);
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x00036C1D File Offset: 0x00035C1D
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x00036C2F File Offset: 0x00035C2F
		[FIXField("508", EFieldOption.Required)]
		public string RegistRefID
		{
			get
			{
				return this.GetStringField(508).Value;
			}
			set
			{
				this.AddStringField(508, value);
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x00036C3D File Offset: 0x00035C3D
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x00036C4C File Offset: 0x00035C4C
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

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00036C57 File Offset: 0x00035C57
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x00036C69 File Offset: 0x00035C69
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

		// Token: 0x060033E7 RID: 13287 RVA: 0x00036C77 File Offset: 0x00035C77
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00036C95 File Offset: 0x00035C95
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00036CB2 File Offset: 0x00035CB2
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x00036CC0 File Offset: 0x00035CC0
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

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00036CCA File Offset: 0x00035CCA
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x00036CDC File Offset: 0x00035CDC
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

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x00036CEA File Offset: 0x00035CEA
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x00036CFC File Offset: 0x00035CFC
		[FIXField("506", EFieldOption.Required)]
		public char RegistStatus
		{
			get
			{
				return this.GetCharField(506).Value;
			}
			set
			{
				this.AddCharField(506, value);
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x00036D0A File Offset: 0x00035D0A
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x00036D1C File Offset: 0x00035D1C
		[FIXField("507", EFieldOption.Optional)]
		public int RegistRejReasonCode
		{
			get
			{
				return this.GetIntField(507).Value;
			}
			set
			{
				this.AddIntField(507, value);
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x00036D2A File Offset: 0x00035D2A
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x00036D3C File Offset: 0x00035D3C
		[FIXField("496", EFieldOption.Optional)]
		public string RegistRejReasonText
		{
			get
			{
				return this.GetStringField(496).Value;
			}
			set
			{
				this.AddStringField(496, value);
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x00036D4A File Offset: 0x00035D4A
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x00036D59 File Offset: 0x00035D59
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

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x00036D64 File Offset: 0x00035D64
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x00036D73 File Offset: 0x00035D73
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

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x00036D7E File Offset: 0x00035D7E
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x00036D8D File Offset: 0x00035D8D
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

		// Token: 0x060033F9 RID: 13305 RVA: 0x00036D98 File Offset: 0x00035D98
		public FIXRegistrationInstructionsResponse()
		{
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00036DC4 File Offset: 0x00035DC4
		public FIXRegistrationInstructionsResponse(string RegistID, char RegistTransType, string RegistRefID, char RegistStatus)
		{
			this.RegistID = RegistID;
			this.RegistTransType = RegistTransType;
			this.RegistRefID = RegistRefID;
			this.RegistStatus = RegistStatus;
		}

		// Token: 0x040004F2 RID: 1266
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040004F3 RID: 1267
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040004F4 RID: 1268
		private ArrayList fPartyIDsGroup = new ArrayList();
	}
}
