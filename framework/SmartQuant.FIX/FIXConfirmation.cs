using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000CD RID: 205
	public class FIXConfirmation : FIXMessage
	{
		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x0002AC4D File Offset: 0x00029C4D
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x0002AC5F File Offset: 0x00029C5F
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

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x0002AC6D File Offset: 0x00029C6D
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x0002AC7C File Offset: 0x00029C7C
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

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x0002AC87 File Offset: 0x00029C87
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x0002AC96 File Offset: 0x00029C96
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

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x0002ACA1 File Offset: 0x00029CA1
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0002ACB0 File Offset: 0x00029CB0
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

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x0002ACBB File Offset: 0x00029CBB
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x0002ACCA File Offset: 0x00029CCA
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x0002ACD5 File Offset: 0x00029CD5
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0002ACE4 File Offset: 0x00029CE4
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

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x0002ACEF File Offset: 0x00029CEF
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x0002AD01 File Offset: 0x00029D01
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

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x0002AD0F File Offset: 0x00029D0F
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x0002AD1E File Offset: 0x00029D1E
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

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x0002AD29 File Offset: 0x00029D29
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x0002AD38 File Offset: 0x00029D38
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

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x0002AD43 File Offset: 0x00029D43
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x0002AD52 File Offset: 0x00029D52
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

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x0002AD5D File Offset: 0x00029D5D
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x0002AD6C File Offset: 0x00029D6C
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

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x0002AD77 File Offset: 0x00029D77
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x0002AD89 File Offset: 0x00029D89
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

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x0002AD97 File Offset: 0x00029D97
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x0002ADA6 File Offset: 0x00029DA6
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

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x0002ADB1 File Offset: 0x00029DB1
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x0002ADBF File Offset: 0x00029DBF
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

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x0002ADC9 File Offset: 0x00029DC9
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x0002ADD8 File Offset: 0x00029DD8
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

		// Token: 0x06002845 RID: 10309 RVA: 0x0002ADE3 File Offset: 0x00029DE3
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0002ADF6 File Offset: 0x00029DF6
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x0002AE05 File Offset: 0x00029E05
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x0002AE17 File Offset: 0x00029E17
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

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x0002AE25 File Offset: 0x00029E25
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x0002AE37 File Offset: 0x00029E37
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

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x0002AE45 File Offset: 0x00029E45
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x0002AE54 File Offset: 0x00029E54
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

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x0002AE5F File Offset: 0x00029E5F
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x0002AE6E File Offset: 0x00029E6E
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

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x0002AE79 File Offset: 0x00029E79
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x0002AE88 File Offset: 0x00029E88
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

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x0002AE93 File Offset: 0x00029E93
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x0002AEA2 File Offset: 0x00029EA2
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

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0002AEAD File Offset: 0x00029EAD
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x0002AEBF File Offset: 0x00029EBF
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

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x0002AECD File Offset: 0x00029ECD
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x0002AEDF File Offset: 0x00029EDF
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

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x0002AEED File Offset: 0x00029EED
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x0002AEFF File Offset: 0x00029EFF
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

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x0002AF0D File Offset: 0x00029F0D
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x0002AF1F File Offset: 0x00029F1F
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

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x0002AF2D File Offset: 0x00029F2D
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x0002AF3F File Offset: 0x00029F3F
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

		// Token: 0x0600285D RID: 10333 RVA: 0x0002AF4D File Offset: 0x00029F4D
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0002AF6B File Offset: 0x00029F6B
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0002AF88 File Offset: 0x00029F88
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x0002AF9A File Offset: 0x00029F9A
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

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0002AFA8 File Offset: 0x00029FA8
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x0002AFBA File Offset: 0x00029FBA
		[FIXField("664", EFieldOption.Required)]
		public string ConfirmID
		{
			get
			{
				return this.GetStringField(664).Value;
			}
			set
			{
				this.AddStringField(664, value);
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x0002AFC8 File Offset: 0x00029FC8
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x0002AFDA File Offset: 0x00029FDA
		[FIXField("772", EFieldOption.Optional)]
		public string ConfirmRefID
		{
			get
			{
				return this.GetStringField(772).Value;
			}
			set
			{
				this.AddStringField(772, value);
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x0002AFE8 File Offset: 0x00029FE8
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x0002AFFA File Offset: 0x00029FFA
		[FIXField("859", EFieldOption.Optional)]
		public string ConfirmReqID
		{
			get
			{
				return this.GetStringField(859).Value;
			}
			set
			{
				this.AddStringField(859, value);
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x0002B008 File Offset: 0x0002A008
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x0002B01A File Offset: 0x0002A01A
		[FIXField("666", EFieldOption.Required)]
		public int ConfirmTransType
		{
			get
			{
				return this.GetIntField(666).Value;
			}
			set
			{
				this.AddIntField(666, value);
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x0002B028 File Offset: 0x0002A028
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x0002B03A File Offset: 0x0002A03A
		[FIXField("773", EFieldOption.Required)]
		public int ConfirmType
		{
			get
			{
				return this.GetIntField(773).Value;
			}
			set
			{
				this.AddIntField(773, value);
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x0002B048 File Offset: 0x0002A048
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x0002B05A File Offset: 0x0002A05A
		[FIXField("797", EFieldOption.Optional)]
		public bool CopyMsgIndicator
		{
			get
			{
				return this.GetBoolField(797).Value;
			}
			set
			{
				this.AddBoolField(797, value);
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0002B068 File Offset: 0x0002A068
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x0002B07A File Offset: 0x0002A07A
		[FIXField("650", EFieldOption.Optional)]
		public bool LegalConfirm
		{
			get
			{
				return this.GetBoolField(650).Value;
			}
			set
			{
				this.AddBoolField(650, value);
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x0002B088 File Offset: 0x0002A088
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x0002B09A File Offset: 0x0002A09A
		[FIXField("665", EFieldOption.Required)]
		public int ConfirmStatus
		{
			get
			{
				return this.GetIntField(665).Value;
			}
			set
			{
				this.AddIntField(665, value);
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x0002B0A8 File Offset: 0x0002A0A8
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x0002B0BA File Offset: 0x0002A0BA
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

		// Token: 0x06002873 RID: 10355 RVA: 0x0002B0C8 File Offset: 0x0002A0C8
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0002B0E6 File Offset: 0x0002A0E6
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x0002B103 File Offset: 0x0002A103
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x0002B112 File Offset: 0x0002A112
		[FIXField("73", EFieldOption.Optional)]
		public int NoOrders
		{
			get
			{
				return this.GetIntField(73).Value;
			}
			set
			{
				this.AddIntField(73, value);
			}
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0002B11D File Offset: 0x0002A11D
		public FIXOrdersGroup GetOrdersGroup(int i)
		{
			if (i < this.NoOrders)
			{
				return (FIXOrdersGroup)this.fOrdersGroup[i];
			}
			return null;
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0002B13B File Offset: 0x0002A13B
		public void AddGroup(FIXOrdersGroup group)
		{
			this.fOrdersGroup.Add(group);
			this.NoOrders++;
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x0002B158 File Offset: 0x0002A158
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x0002B167 File Offset: 0x0002A167
		[FIXField("70", EFieldOption.Optional)]
		public string AllocID
		{
			get
			{
				return this.GetStringField(70).Value;
			}
			set
			{
				this.AddStringField(70, value);
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x0002B172 File Offset: 0x0002A172
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x0002B184 File Offset: 0x0002A184
		[FIXField("793", EFieldOption.Optional)]
		public string SecondaryAllocID
		{
			get
			{
				return this.GetStringField(793).Value;
			}
			set
			{
				this.AddStringField(793, value);
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x0002B192 File Offset: 0x0002A192
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x0002B1A4 File Offset: 0x0002A1A4
		[FIXField("467", EFieldOption.Optional)]
		public string IndividualAllocID
		{
			get
			{
				return this.GetStringField(467).Value;
			}
			set
			{
				this.AddStringField(467, value);
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x0002B1B2 File Offset: 0x0002A1B2
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x0002B1C1 File Offset: 0x0002A1C1
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

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x0002B1CC File Offset: 0x0002A1CC
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x0002B1DB File Offset: 0x0002A1DB
		[FIXField("75", EFieldOption.Required)]
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

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x0002B1E6 File Offset: 0x0002A1E6
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x0002B1F8 File Offset: 0x0002A1F8
		[FIXField("768", EFieldOption.Optional)]
		public int NoTrdRegTimestamps
		{
			get
			{
				return this.GetIntField(768).Value;
			}
			set
			{
				this.AddIntField(768, value);
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0002B206 File Offset: 0x0002A206
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0002B224 File Offset: 0x0002A224
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x0002B241 File Offset: 0x0002A241
		// (set) Token: 0x06002888 RID: 10376 RVA: 0x0002B250 File Offset: 0x0002A250
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

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x0002B25B File Offset: 0x0002A25B
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x0002B26A File Offset: 0x0002A26A
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

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x0002B275 File Offset: 0x0002A275
		// (set) Token: 0x0600288C RID: 10380 RVA: 0x0002B284 File Offset: 0x0002A284
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

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x0002B28F File Offset: 0x0002A28F
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x0002B29E File Offset: 0x0002A29E
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

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x0002B2A9 File Offset: 0x0002A2A9
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x0002B2BB File Offset: 0x0002A2BB
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

		// Token: 0x06002891 RID: 10385 RVA: 0x0002B2C9 File Offset: 0x0002A2C9
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0002B2E7 File Offset: 0x0002A2E7
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x0002B304 File Offset: 0x0002A304
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x0002B316 File Offset: 0x0002A316
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

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x0002B324 File Offset: 0x0002A324
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x0002B336 File Offset: 0x0002A336
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

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x0002B344 File Offset: 0x0002A344
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x0002B356 File Offset: 0x0002A356
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

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x0002B364 File Offset: 0x0002A364
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x0002B376 File Offset: 0x0002A376
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

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x0002B384 File Offset: 0x0002A384
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x0002B396 File Offset: 0x0002A396
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

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x0002B3A4 File Offset: 0x0002A3A4
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x0002B3B6 File Offset: 0x0002A3B6
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

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0002B3C4 File Offset: 0x0002A3C4
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0002B3D6 File Offset: 0x0002A3D6
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

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x0002B3E4 File Offset: 0x0002A3E4
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x0002B3F6 File Offset: 0x0002A3F6
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

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0002B404 File Offset: 0x0002A404
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x0002B416 File Offset: 0x0002A416
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

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x0002B424 File Offset: 0x0002A424
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x0002B436 File Offset: 0x0002A436
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

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x0002B444 File Offset: 0x0002A444
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x0002B456 File Offset: 0x0002A456
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

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x0002B464 File Offset: 0x0002A464
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0002B476 File Offset: 0x0002A476
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

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0002B484 File Offset: 0x0002A484
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x0002B496 File Offset: 0x0002A496
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0002B4A4 File Offset: 0x0002A4A4
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x0002B4B6 File Offset: 0x0002A4B6
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

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x0002B4C4 File Offset: 0x0002A4C4
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x0002B4D6 File Offset: 0x0002A4D6
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

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0002B4E4 File Offset: 0x0002A4E4
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0002B4F6 File Offset: 0x0002A4F6
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

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x0002B504 File Offset: 0x0002A504
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0002B516 File Offset: 0x0002A516
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

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0002B524 File Offset: 0x0002A524
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0002B536 File Offset: 0x0002A536
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

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0002B544 File Offset: 0x0002A544
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x0002B556 File Offset: 0x0002A556
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

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0002B564 File Offset: 0x0002A564
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x0002B576 File Offset: 0x0002A576
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

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x0002B584 File Offset: 0x0002A584
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x0002B596 File Offset: 0x0002A596
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

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x0002B5A4 File Offset: 0x0002A5A4
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x0002B5B6 File Offset: 0x0002A5B6
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

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x0002B5C4 File Offset: 0x0002A5C4
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x0002B5D6 File Offset: 0x0002A5D6
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

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0002B5E4 File Offset: 0x0002A5E4
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x0002B5F6 File Offset: 0x0002A5F6
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

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x0002B604 File Offset: 0x0002A604
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x0002B613 File Offset: 0x0002A613
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

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0002B61E File Offset: 0x0002A61E
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0002B630 File Offset: 0x0002A630
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

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0002B63E File Offset: 0x0002A63E
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x0002B650 File Offset: 0x0002A650
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0002B65E File Offset: 0x0002A65E
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x0002B66D File Offset: 0x0002A66D
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

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x0002B678 File Offset: 0x0002A678
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x0002B68A File Offset: 0x0002A68A
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

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x0002B698 File Offset: 0x0002A698
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x0002B6AA File Offset: 0x0002A6AA
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

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x0002B6B8 File Offset: 0x0002A6B8
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x0002B6CA File Offset: 0x0002A6CA
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

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x0002B6D8 File Offset: 0x0002A6D8
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x0002B6EA File Offset: 0x0002A6EA
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

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x0002B6F8 File Offset: 0x0002A6F8
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x0002B70A File Offset: 0x0002A70A
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

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x0002B718 File Offset: 0x0002A718
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x0002B72A File Offset: 0x0002A72A
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

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x0002B738 File Offset: 0x0002A738
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x0002B74A File Offset: 0x0002A74A
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

		// Token: 0x060028D9 RID: 10457 RVA: 0x0002B758 File Offset: 0x0002A758
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0002B776 File Offset: 0x0002A776
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x0002B793 File Offset: 0x0002A793
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x0002B7A5 File Offset: 0x0002A7A5
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

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x0002B7B3 File Offset: 0x0002A7B3
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x0002B7C5 File Offset: 0x0002A7C5
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

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x0002B7D3 File Offset: 0x0002A7D3
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x0002B7E5 File Offset: 0x0002A7E5
		[FIXField("668", EFieldOption.Optional)]
		public int DeliveryForm
		{
			get
			{
				return this.GetIntField(668).Value;
			}
			set
			{
				this.AddIntField(668, value);
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0002B7F3 File Offset: 0x0002A7F3
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0002B805 File Offset: 0x0002A805
		[FIXField("869", EFieldOption.Optional)]
		public double PctAtRisk
		{
			get
			{
				return this.GetDoubleField(869).Value;
			}
			set
			{
				this.AddDoubleField(869, value);
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x0002B813 File Offset: 0x0002A813
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x0002B825 File Offset: 0x0002A825
		[FIXField("870", EFieldOption.Optional)]
		public int NoInstrAttrib
		{
			get
			{
				return this.GetIntField(870).Value;
			}
			set
			{
				this.AddIntField(870, value);
			}
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0002B833 File Offset: 0x0002A833
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0002B851 File Offset: 0x0002A851
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x0002B86E File Offset: 0x0002A86E
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x0002B880 File Offset: 0x0002A880
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

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0002B88E File Offset: 0x0002A88E
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x0002B8A0 File Offset: 0x0002A8A0
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

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x0002B8AE File Offset: 0x0002A8AE
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x0002B8C0 File Offset: 0x0002A8C0
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

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x0002B8CE File Offset: 0x0002A8CE
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x0002B8E0 File Offset: 0x0002A8E0
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

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x0002B8EE File Offset: 0x0002A8EE
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x0002B900 File Offset: 0x0002A900
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

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x0002B90E File Offset: 0x0002A90E
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x0002B920 File Offset: 0x0002A920
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

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x0002B92E File Offset: 0x0002A92E
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x0002B940 File Offset: 0x0002A940
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

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x0002B94E File Offset: 0x0002A94E
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x0002B960 File Offset: 0x0002A960
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

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x0002B96E File Offset: 0x0002A96E
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x0002B980 File Offset: 0x0002A980
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

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0002B98E File Offset: 0x0002A98E
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x0002B9A0 File Offset: 0x0002A9A0
		[FIXField("711", EFieldOption.Required)]
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

		// Token: 0x060028FB RID: 10491 RVA: 0x0002B9AE File Offset: 0x0002A9AE
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0002B9CC File Offset: 0x0002A9CC
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x0002B9E9 File Offset: 0x0002A9E9
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0002B9FB File Offset: 0x0002A9FB
		[FIXField("555", EFieldOption.Required)]
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

		// Token: 0x060028FF RID: 10495 RVA: 0x0002BA09 File Offset: 0x0002AA09
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0002BA27 File Offset: 0x0002AA27
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x0002BA44 File Offset: 0x0002AA44
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x0002BA56 File Offset: 0x0002AA56
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

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x0002BA64 File Offset: 0x0002AA64
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x0002BA76 File Offset: 0x0002AA76
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

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x0002BA84 File Offset: 0x0002AA84
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x0002BA96 File Offset: 0x0002AA96
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

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x0002BAA4 File Offset: 0x0002AAA4
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x0002BAB6 File Offset: 0x0002AAB6
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

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x0002BAC4 File Offset: 0x0002AAC4
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x0002BAD6 File Offset: 0x0002AAD6
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

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x0002BAE4 File Offset: 0x0002AAE4
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x0002BAF6 File Offset: 0x0002AAF6
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

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x0002BB04 File Offset: 0x0002AB04
		// (set) Token: 0x0600290E RID: 10510 RVA: 0x0002BB13 File Offset: 0x0002AB13
		[FIXField("80", EFieldOption.Required)]
		public double AllocQty
		{
			get
			{
				return this.GetDoubleField(80).Value;
			}
			set
			{
				this.AddDoubleField(80, value);
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x0002BB1E File Offset: 0x0002AB1E
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x0002BB30 File Offset: 0x0002AB30
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntField(854).Value;
			}
			set
			{
				this.AddIntField(854, value);
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x0002BB3E File Offset: 0x0002AB3E
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x0002BB4D File Offset: 0x0002AB4D
		[FIXField("54", EFieldOption.Required)]
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

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x0002BB58 File Offset: 0x0002AB58
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x0002BB67 File Offset: 0x0002AB67
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

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x0002BB72 File Offset: 0x0002AB72
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x0002BB81 File Offset: 0x0002AB81
		[FIXField("30", EFieldOption.Optional)]
		public string LastMkt
		{
			get
			{
				return this.GetStringField(30).Value;
			}
			set
			{
				this.AddStringField(30, value);
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x0002BB8C File Offset: 0x0002AB8C
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x0002BB9E File Offset: 0x0002AB9E
		[FIXField("862", EFieldOption.Required)]
		public int NoCapacities
		{
			get
			{
				return this.GetIntField(862).Value;
			}
			set
			{
				this.AddIntField(862, value);
			}
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0002BBAC File Offset: 0x0002ABAC
		public FIXCapacitiesGroup GetCapacitiesGroup(int i)
		{
			if (i < this.NoCapacities)
			{
				return (FIXCapacitiesGroup)this.fCapacitiesGroup[i];
			}
			return null;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0002BBCA File Offset: 0x0002ABCA
		public void AddGroup(FIXCapacitiesGroup group)
		{
			this.fCapacitiesGroup.Add(group);
			this.NoCapacities++;
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x0002BBE7 File Offset: 0x0002ABE7
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x0002BBF6 File Offset: 0x0002ABF6
		[FIXField("79", EFieldOption.Required)]
		public string AllocAccount
		{
			get
			{
				return this.GetStringField(79).Value;
			}
			set
			{
				this.AddStringField(79, value);
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x0002BC01 File Offset: 0x0002AC01
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x0002BC13 File Offset: 0x0002AC13
		[FIXField("661", EFieldOption.Optional)]
		public int AllocAcctIDSource
		{
			get
			{
				return this.GetIntField(661).Value;
			}
			set
			{
				this.AddIntField(661, value);
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x0002BC21 File Offset: 0x0002AC21
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x0002BC33 File Offset: 0x0002AC33
		[FIXField("798", EFieldOption.Optional)]
		public int AllocAccountType
		{
			get
			{
				return this.GetIntField(798).Value;
			}
			set
			{
				this.AddIntField(798, value);
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x0002BC41 File Offset: 0x0002AC41
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x0002BC4F File Offset: 0x0002AC4F
		[FIXField("6", EFieldOption.Required)]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleField(6).Value;
			}
			set
			{
				this.AddDoubleField(6, value);
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x0002BC59 File Offset: 0x0002AC59
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x0002BC68 File Offset: 0x0002AC68
		[FIXField("74", EFieldOption.Optional)]
		public int AvgPxPrecision
		{
			get
			{
				return this.GetIntField(74).Value;
			}
			set
			{
				this.AddIntField(74, value);
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x0002BC73 File Offset: 0x0002AC73
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x0002BC85 File Offset: 0x0002AC85
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

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x0002BC93 File Offset: 0x0002AC93
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x0002BCA5 File Offset: 0x0002ACA5
		[FIXField("860", EFieldOption.Optional)]
		public double AvgParPx
		{
			get
			{
				return this.GetDoubleField(860).Value;
			}
			set
			{
				this.AddDoubleField(860, value);
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x0002BCB3 File Offset: 0x0002ACB3
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x0002BCC5 File Offset: 0x0002ACC5
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

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x0002BCD3 File Offset: 0x0002ACD3
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x0002BCE5 File Offset: 0x0002ACE5
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

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x0002BCF3 File Offset: 0x0002ACF3
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x0002BD05 File Offset: 0x0002AD05
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

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x0002BD13 File Offset: 0x0002AD13
		// (set) Token: 0x06002930 RID: 10544 RVA: 0x0002BD25 File Offset: 0x0002AD25
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

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x0002BD33 File Offset: 0x0002AD33
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x0002BD45 File Offset: 0x0002AD45
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x0002BD53 File Offset: 0x0002AD53
		// (set) Token: 0x06002934 RID: 10548 RVA: 0x0002BD65 File Offset: 0x0002AD65
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

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x0002BD73 File Offset: 0x0002AD73
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x0002BD85 File Offset: 0x0002AD85
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

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x0002BD93 File Offset: 0x0002AD93
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x0002BDA5 File Offset: 0x0002ADA5
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

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x0002BDB3 File Offset: 0x0002ADB3
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x0002BDC5 File Offset: 0x0002ADC5
		[FIXField("861", EFieldOption.Optional)]
		public double ReportedPx
		{
			get
			{
				return this.GetDoubleField(861).Value;
			}
			set
			{
				this.AddDoubleField(861, value);
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x0002BDD3 File Offset: 0x0002ADD3
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x0002BDE2 File Offset: 0x0002ADE2
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

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x0002BDED File Offset: 0x0002ADED
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x0002BDFF File Offset: 0x0002ADFF
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

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x0002BE0D File Offset: 0x0002AE0D
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x0002BE1F File Offset: 0x0002AE1F
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

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x0002BE2D File Offset: 0x0002AE2D
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x0002BE3C File Offset: 0x0002AE3C
		[FIXField("81", EFieldOption.Optional)]
		public char ProcessCode
		{
			get
			{
				return this.GetCharField(81).Value;
			}
			set
			{
				this.AddCharField(81, value);
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x0002BE47 File Offset: 0x0002AE47
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x0002BE59 File Offset: 0x0002AE59
		[FIXField("381", EFieldOption.Required)]
		public double GrossTradeAmt
		{
			get
			{
				return this.GetDoubleField(381).Value;
			}
			set
			{
				this.AddDoubleField(381, value);
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0002BE67 File Offset: 0x0002AE67
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x0002BE79 File Offset: 0x0002AE79
		[FIXField("157", EFieldOption.Optional)]
		public int NumDaysInterest
		{
			get
			{
				return this.GetIntField(157).Value;
			}
			set
			{
				this.AddIntField(157, value);
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x0002BE87 File Offset: 0x0002AE87
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x0002BE99 File Offset: 0x0002AE99
		[FIXField("230", EFieldOption.Optional)]
		public DateTime ExDate
		{
			get
			{
				return this.GetDateTimeField(230).Value;
			}
			set
			{
				this.AddDateTimeField(230, value);
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x0002BEA7 File Offset: 0x0002AEA7
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x0002BEB9 File Offset: 0x0002AEB9
		[FIXField("158", EFieldOption.Optional)]
		public double AccruedInterestRate
		{
			get
			{
				return this.GetDoubleField(158).Value;
			}
			set
			{
				this.AddDoubleField(158, value);
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x0002BEC7 File Offset: 0x0002AEC7
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x0002BED9 File Offset: 0x0002AED9
		[FIXField("159", EFieldOption.Optional)]
		public double AccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(159).Value;
			}
			set
			{
				this.AddDoubleField(159, value);
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x0002BEE7 File Offset: 0x0002AEE7
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x0002BEF9 File Offset: 0x0002AEF9
		[FIXField("738", EFieldOption.Optional)]
		public double InterestAtMaturity
		{
			get
			{
				return this.GetDoubleField(738).Value;
			}
			set
			{
				this.AddDoubleField(738, value);
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x0002BF07 File Offset: 0x0002AF07
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x0002BF19 File Offset: 0x0002AF19
		[FIXField("920", EFieldOption.Optional)]
		public double EndAccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(920).Value;
			}
			set
			{
				this.AddDoubleField(920, value);
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x0002BF27 File Offset: 0x0002AF27
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x0002BF39 File Offset: 0x0002AF39
		[FIXField("921", EFieldOption.Optional)]
		public double StartCash
		{
			get
			{
				return this.GetDoubleField(921).Value;
			}
			set
			{
				this.AddDoubleField(921, value);
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x0002BF47 File Offset: 0x0002AF47
		// (set) Token: 0x06002954 RID: 10580 RVA: 0x0002BF59 File Offset: 0x0002AF59
		[FIXField("922", EFieldOption.Optional)]
		public double EndCash
		{
			get
			{
				return this.GetDoubleField(922).Value;
			}
			set
			{
				this.AddDoubleField(922, value);
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x0002BF67 File Offset: 0x0002AF67
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x0002BF79 File Offset: 0x0002AF79
		[FIXField("238", EFieldOption.Optional)]
		public double Concession
		{
			get
			{
				return this.GetDoubleField(238).Value;
			}
			set
			{
				this.AddDoubleField(238, value);
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x0002BF87 File Offset: 0x0002AF87
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x0002BF99 File Offset: 0x0002AF99
		[FIXField("237", EFieldOption.Optional)]
		public double TotalTakedown
		{
			get
			{
				return this.GetDoubleField(237).Value;
			}
			set
			{
				this.AddDoubleField(237, value);
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x0002BFA7 File Offset: 0x0002AFA7
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x0002BFB6 File Offset: 0x0002AFB6
		[FIXField("118", EFieldOption.Required)]
		public double NetMoney
		{
			get
			{
				return this.GetDoubleField(118).Value;
			}
			set
			{
				this.AddDoubleField(118, value);
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x0002BFC1 File Offset: 0x0002AFC1
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x0002BFD3 File Offset: 0x0002AFD3
		[FIXField("890", EFieldOption.Optional)]
		public double MaturityNetMoney
		{
			get
			{
				return this.GetDoubleField(890).Value;
			}
			set
			{
				this.AddDoubleField(890, value);
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x0002BFE1 File Offset: 0x0002AFE1
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x0002BFF0 File Offset: 0x0002AFF0
		[FIXField("119", EFieldOption.Optional)]
		public double SettlCurrAmt
		{
			get
			{
				return this.GetDoubleField(119).Value;
			}
			set
			{
				this.AddDoubleField(119, value);
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x0002BFFB File Offset: 0x0002AFFB
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x0002C00A File Offset: 0x0002B00A
		[FIXField("120", EFieldOption.Optional)]
		public double SettlCurrency
		{
			get
			{
				return this.GetDoubleField(120).Value;
			}
			set
			{
				this.AddDoubleField(120, value);
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06002961 RID: 10593 RVA: 0x0002C015 File Offset: 0x0002B015
		// (set) Token: 0x06002962 RID: 10594 RVA: 0x0002C027 File Offset: 0x0002B027
		[FIXField("155", EFieldOption.Optional)]
		public double SettlCurrFxRate
		{
			get
			{
				return this.GetDoubleField(155).Value;
			}
			set
			{
				this.AddDoubleField(155, value);
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x0002C035 File Offset: 0x0002B035
		// (set) Token: 0x06002964 RID: 10596 RVA: 0x0002C047 File Offset: 0x0002B047
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

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x0002C055 File Offset: 0x0002B055
		// (set) Token: 0x06002966 RID: 10598 RVA: 0x0002C064 File Offset: 0x0002B064
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

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x0002C06F File Offset: 0x0002B06F
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x0002C07E File Offset: 0x0002B07E
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

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x0002C089 File Offset: 0x0002B089
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x0002C09B File Offset: 0x0002B09B
		[FIXField("172", EFieldOption.Optional)]
		public int SettlDeliveryType
		{
			get
			{
				return this.GetIntField(172).Value;
			}
			set
			{
				this.AddIntField(172, value);
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x0002C0A9 File Offset: 0x0002B0A9
		// (set) Token: 0x0600296C RID: 10604 RVA: 0x0002C0BB File Offset: 0x0002B0BB
		[FIXField("169", EFieldOption.Optional)]
		public int StandInstDbType
		{
			get
			{
				return this.GetIntField(169).Value;
			}
			set
			{
				this.AddIntField(169, value);
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x0002C0C9 File Offset: 0x0002B0C9
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x0002C0DB File Offset: 0x0002B0DB
		[FIXField("170", EFieldOption.Optional)]
		public string StandInstDbName
		{
			get
			{
				return this.GetStringField(170).Value;
			}
			set
			{
				this.AddStringField(170, value);
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x0002C0E9 File Offset: 0x0002B0E9
		// (set) Token: 0x06002970 RID: 10608 RVA: 0x0002C0FB File Offset: 0x0002B0FB
		[FIXField("171", EFieldOption.Optional)]
		public string StandInstDbID
		{
			get
			{
				return this.GetStringField(171).Value;
			}
			set
			{
				this.AddStringField(171, value);
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x0002C109 File Offset: 0x0002B109
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x0002C118 File Offset: 0x0002B118
		[FIXField("85", EFieldOption.Optional)]
		public int NoDlvyInst
		{
			get
			{
				return this.GetIntField(85).Value;
			}
			set
			{
				this.AddIntField(85, value);
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x0002C123 File Offset: 0x0002B123
		public FIXDlvyInstGroup GetDlvyInstGroup(int i)
		{
			if (i < this.NoDlvyInst)
			{
				return (FIXDlvyInstGroup)this.fDlvyInstGroup[i];
			}
			return null;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0002C141 File Offset: 0x0002B141
		public void AddGroup(FIXDlvyInstGroup group)
		{
			this.fDlvyInstGroup.Add(group);
			this.NoDlvyInst++;
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x0002C15E File Offset: 0x0002B15E
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x0002C16D File Offset: 0x0002B16D
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

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x0002C178 File Offset: 0x0002B178
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x0002C187 File Offset: 0x0002B187
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

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x0002C192 File Offset: 0x0002B192
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x0002C1A4 File Offset: 0x0002B1A4
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleField(479).Value;
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x0002C1B2 File Offset: 0x0002B1B2
		// (set) Token: 0x0600297C RID: 10620 RVA: 0x0002C1C4 File Offset: 0x0002B1C4
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharField(497).Value;
			}
			set
			{
				this.AddCharField(497, value);
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x0002C1D2 File Offset: 0x0002B1D2
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x0002C1E4 File Offset: 0x0002B1E4
		[FIXField("858", EFieldOption.Optional)]
		public double SharedCommission
		{
			get
			{
				return this.GetDoubleField(858).Value;
			}
			set
			{
				this.AddDoubleField(858, value);
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x0002C1F2 File Offset: 0x0002B1F2
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x0002C204 File Offset: 0x0002B204
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

		// Token: 0x06002981 RID: 10625 RVA: 0x0002C212 File Offset: 0x0002B212
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0002C230 File Offset: 0x0002B230
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x0002C24D File Offset: 0x0002B24D
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x0002C25F File Offset: 0x0002B25F
		[FIXField("136", EFieldOption.Optional)]
		public int NoMiscFees
		{
			get
			{
				return this.GetIntField(136).Value;
			}
			set
			{
				this.AddIntField(136, value);
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x0002C26D File Offset: 0x0002B26D
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0002C28B File Offset: 0x0002B28B
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x0002C2A8 File Offset: 0x0002B2A8
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x0002C2B7 File Offset: 0x0002B2B7
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

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x0002C2C2 File Offset: 0x0002B2C2
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x0002C2D1 File Offset: 0x0002B2D1
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

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x0002C2DC File Offset: 0x0002B2DC
		// (set) Token: 0x0600298C RID: 10636 RVA: 0x0002C2EB File Offset: 0x0002B2EB
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

		// Token: 0x0600298D RID: 10637 RVA: 0x0002C2F8 File Offset: 0x0002B2F8
		public FIXConfirmation()
		{
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x0002C3A8 File Offset: 0x0002B3A8
		public FIXConfirmation(string ConfirmID, int ConfirmTransType, int ConfirmType, int ConfirmStatus, DateTime TransactTime, DateTime TradeDate, int NoUnderlyings, int NoLegs, double AllocQty, char Side, int NoCapacities, string AllocAccount, double AvgPx, double GrossTradeAmt, double NetMoney)
		{
			this.ConfirmID = ConfirmID;
			this.ConfirmTransType = ConfirmTransType;
			this.ConfirmType = ConfirmType;
			this.ConfirmStatus = ConfirmStatus;
			this.TransactTime = TransactTime;
			this.TradeDate = TradeDate;
			this.NoUnderlyings = NoUnderlyings;
			this.NoLegs = NoLegs;
			this.AllocQty = AllocQty;
			this.Side = Side;
			this.NoCapacities = NoCapacities;
			this.AllocAccount = AllocAccount;
			this.AvgPx = AvgPx;
			this.GrossTradeAmt = GrossTradeAmt;
			this.NetMoney = NetMoney;
		}

		// Token: 0x040003B2 RID: 946
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003B3 RID: 947
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040003B4 RID: 948
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x040003B5 RID: 949
		private ArrayList fOrdersGroup = new ArrayList();

		// Token: 0x040003B6 RID: 950
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();

		// Token: 0x040003B7 RID: 951
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040003B8 RID: 952
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040003B9 RID: 953
		private ArrayList fInstrAttribGroup = new ArrayList();

		// Token: 0x040003BA RID: 954
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040003BB RID: 955
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040003BC RID: 956
		private ArrayList fCapacitiesGroup = new ArrayList();

		// Token: 0x040003BD RID: 957
		private ArrayList fDlvyInstGroup = new ArrayList();

		// Token: 0x040003BE RID: 958
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x040003BF RID: 959
		private ArrayList fMiscFeesGroup = new ArrayList();
	}
}
