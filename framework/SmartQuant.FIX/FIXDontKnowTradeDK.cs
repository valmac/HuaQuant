using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200009B RID: 155
	public class FIXDontKnowTradeDK : FIXMessage
	{
		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00022DC5 File Offset: 0x00021DC5
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00022DD7 File Offset: 0x00021DD7
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

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x00022DE5 File Offset: 0x00021DE5
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00022DF4 File Offset: 0x00021DF4
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

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x00022DFF File Offset: 0x00021DFF
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00022E0E File Offset: 0x00021E0E
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00022E19 File Offset: 0x00021E19
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x00022E28 File Offset: 0x00021E28
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

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00022E33 File Offset: 0x00021E33
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x00022E42 File Offset: 0x00021E42
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

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x00022E4D File Offset: 0x00021E4D
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x00022E5C File Offset: 0x00021E5C
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

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00022E67 File Offset: 0x00021E67
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x00022E79 File Offset: 0x00021E79
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

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x00022E87 File Offset: 0x00021E87
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x00022E96 File Offset: 0x00021E96
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

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00022EA1 File Offset: 0x00021EA1
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x00022EB0 File Offset: 0x00021EB0
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

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x00022EBB File Offset: 0x00021EBB
		// (set) Token: 0x06002087 RID: 8327 RVA: 0x00022ECA File Offset: 0x00021ECA
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

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x00022ED5 File Offset: 0x00021ED5
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x00022EE4 File Offset: 0x00021EE4
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

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x00022EEF File Offset: 0x00021EEF
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x00022F01 File Offset: 0x00021F01
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

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x00022F0F File Offset: 0x00021F0F
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x00022F1E File Offset: 0x00021F1E
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

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x00022F29 File Offset: 0x00021F29
		// (set) Token: 0x0600208F RID: 8335 RVA: 0x00022F37 File Offset: 0x00021F37
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

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x00022F41 File Offset: 0x00021F41
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x00022F50 File Offset: 0x00021F50
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

		// Token: 0x06002092 RID: 8338 RVA: 0x00022F5B File Offset: 0x00021F5B
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00022F6E File Offset: 0x00021F6E
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x00022F7D File Offset: 0x00021F7D
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x00022F8F File Offset: 0x00021F8F
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

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x00022F9D File Offset: 0x00021F9D
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00022FAF File Offset: 0x00021FAF
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

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x00022FBD File Offset: 0x00021FBD
		// (set) Token: 0x06002099 RID: 8345 RVA: 0x00022FCC File Offset: 0x00021FCC
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

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x00022FD7 File Offset: 0x00021FD7
		// (set) Token: 0x0600209B RID: 8347 RVA: 0x00022FE6 File Offset: 0x00021FE6
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

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x00022FF1 File Offset: 0x00021FF1
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x00023000 File Offset: 0x00022000
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

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0002300B File Offset: 0x0002200B
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x0002301A File Offset: 0x0002201A
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

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00023025 File Offset: 0x00022025
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00023037 File Offset: 0x00022037
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

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00023045 File Offset: 0x00022045
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x00023057 File Offset: 0x00022057
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

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00023065 File Offset: 0x00022065
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x00023077 File Offset: 0x00022077
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

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00023085 File Offset: 0x00022085
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x00023097 File Offset: 0x00022097
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

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000230A5 File Offset: 0x000220A5
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x000230B7 File Offset: 0x000220B7
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

		// Token: 0x060020AA RID: 8362 RVA: 0x000230C5 File Offset: 0x000220C5
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000230E3 File Offset: 0x000220E3
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00023100 File Offset: 0x00022100
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x00023112 File Offset: 0x00022112
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

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00023120 File Offset: 0x00022120
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0002312F File Offset: 0x0002212F
		[FIXField("37", EFieldOption.Required)]
		public string OrderID
		{
			get
			{
				return this.GetStringField(37).Value;
			}
			set
			{
				this.AddStringField(37, value);
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0002313A File Offset: 0x0002213A
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x0002314C File Offset: 0x0002214C
		[FIXField("198", EFieldOption.Optional)]
		public string SecondaryOrderID
		{
			get
			{
				return this.GetStringField(198).Value;
			}
			set
			{
				this.AddStringField(198, value);
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0002315A File Offset: 0x0002215A
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x00023169 File Offset: 0x00022169
		[FIXField("17", EFieldOption.Required)]
		public string ExecID
		{
			get
			{
				return this.GetStringField(17).Value;
			}
			set
			{
				this.AddStringField(17, value);
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x00023174 File Offset: 0x00022174
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x00023183 File Offset: 0x00022183
		[FIXField("127", EFieldOption.Required)]
		public char DKReason
		{
			get
			{
				return this.GetCharField(127).Value;
			}
			set
			{
				this.AddCharField(127, value);
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0002318E File Offset: 0x0002218E
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x0002319D File Offset: 0x0002219D
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000231A8 File Offset: 0x000221A8
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x000231B7 File Offset: 0x000221B7
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000231C2 File Offset: 0x000221C2
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x000231D1 File Offset: 0x000221D1
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x000231DC File Offset: 0x000221DC
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x000231EB File Offset: 0x000221EB
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

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x000231F6 File Offset: 0x000221F6
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x00023208 File Offset: 0x00022208
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

		// Token: 0x060020C0 RID: 8384 RVA: 0x00023216 File Offset: 0x00022216
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00023234 File Offset: 0x00022234
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x00023251 File Offset: 0x00022251
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00023263 File Offset: 0x00022263
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00023271 File Offset: 0x00022271
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00023283 File Offset: 0x00022283
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

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x00023291 File Offset: 0x00022291
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x000232A3 File Offset: 0x000222A3
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

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000232B1 File Offset: 0x000222B1
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x000232C3 File Offset: 0x000222C3
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

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000232D1 File Offset: 0x000222D1
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x000232E3 File Offset: 0x000222E3
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

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000232F1 File Offset: 0x000222F1
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x00023303 File Offset: 0x00022303
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

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x00023311 File Offset: 0x00022311
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x00023323 File Offset: 0x00022323
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

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00023331 File Offset: 0x00022331
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x00023343 File Offset: 0x00022343
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

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00023351 File Offset: 0x00022351
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00023363 File Offset: 0x00022363
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

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00023371 File Offset: 0x00022371
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00023383 File Offset: 0x00022383
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

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00023391 File Offset: 0x00022391
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x000233A3 File Offset: 0x000223A3
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

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000233B1 File Offset: 0x000223B1
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x000233C3 File Offset: 0x000223C3
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

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000233D1 File Offset: 0x000223D1
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x000233E3 File Offset: 0x000223E3
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

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000233F1 File Offset: 0x000223F1
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00023403 File Offset: 0x00022403
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

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x00023411 File Offset: 0x00022411
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x00023423 File Offset: 0x00022423
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00023431 File Offset: 0x00022431
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x00023443 File Offset: 0x00022443
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

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00023451 File Offset: 0x00022451
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x00023463 File Offset: 0x00022463
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

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00023471 File Offset: 0x00022471
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x00023483 File Offset: 0x00022483
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00023491 File Offset: 0x00022491
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x000234A3 File Offset: 0x000224A3
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

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x000234B1 File Offset: 0x000224B1
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x000234C3 File Offset: 0x000224C3
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

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x000234D1 File Offset: 0x000224D1
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x000234E3 File Offset: 0x000224E3
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

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x000234F1 File Offset: 0x000224F1
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x00023503 File Offset: 0x00022503
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x00023511 File Offset: 0x00022511
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x00023523 File Offset: 0x00022523
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

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00023531 File Offset: 0x00022531
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x00023543 File Offset: 0x00022543
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

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x00023551 File Offset: 0x00022551
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x00023560 File Offset: 0x00022560
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

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x0002356B File Offset: 0x0002256B
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x0002357D File Offset: 0x0002257D
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

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0002358B File Offset: 0x0002258B
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x0002359D File Offset: 0x0002259D
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

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x000235AB File Offset: 0x000225AB
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x000235BA File Offset: 0x000225BA
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

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x000235C5 File Offset: 0x000225C5
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x000235D7 File Offset: 0x000225D7
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

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x000235E5 File Offset: 0x000225E5
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x000235F7 File Offset: 0x000225F7
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x00023605 File Offset: 0x00022605
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x00023617 File Offset: 0x00022617
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x00023625 File Offset: 0x00022625
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x00023637 File Offset: 0x00022637
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x00023645 File Offset: 0x00022645
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x00023657 File Offset: 0x00022657
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00023665 File Offset: 0x00022665
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x00023677 File Offset: 0x00022677
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

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00023685 File Offset: 0x00022685
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x00023697 File Offset: 0x00022697
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

		// Token: 0x06002108 RID: 8456 RVA: 0x000236A5 File Offset: 0x000226A5
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000236C3 File Offset: 0x000226C3
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000236E0 File Offset: 0x000226E0
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x000236F2 File Offset: 0x000226F2
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

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00023700 File Offset: 0x00022700
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x00023712 File Offset: 0x00022712
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

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x00023720 File Offset: 0x00022720
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x00023732 File Offset: 0x00022732
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

		// Token: 0x06002110 RID: 8464 RVA: 0x00023740 File Offset: 0x00022740
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0002375E File Offset: 0x0002275E
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0002377B File Offset: 0x0002277B
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0002378D File Offset: 0x0002278D
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

		// Token: 0x06002114 RID: 8468 RVA: 0x0002379B File Offset: 0x0002279B
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000237B9 File Offset: 0x000227B9
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x000237D6 File Offset: 0x000227D6
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x000237E5 File Offset: 0x000227E5
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

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x000237F0 File Offset: 0x000227F0
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x000237FF File Offset: 0x000227FF
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x0002380A File Offset: 0x0002280A
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x0002381C File Offset: 0x0002281C
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0002382A File Offset: 0x0002282A
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x0002383C File Offset: 0x0002283C
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

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0002384A File Offset: 0x0002284A
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x0002385C File Offset: 0x0002285C
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

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0002386A File Offset: 0x0002286A
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0002387C File Offset: 0x0002287C
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

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0002388A File Offset: 0x0002288A
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x00023899 File Offset: 0x00022899
		[FIXField("32", EFieldOption.Optional)]
		public double LastQty
		{
			get
			{
				return this.GetDoubleField(32).Value;
			}
			set
			{
				this.AddDoubleField(32, value);
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x000238A4 File Offset: 0x000228A4
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x000238B3 File Offset: 0x000228B3
		[FIXField("31", EFieldOption.Optional)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleField(31).Value;
			}
			set
			{
				this.AddDoubleField(31, value);
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x000238BE File Offset: 0x000228BE
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x000238CD File Offset: 0x000228CD
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

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000238D8 File Offset: 0x000228D8
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x000238EA File Offset: 0x000228EA
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

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000238F8 File Offset: 0x000228F8
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x0002390A File Offset: 0x0002290A
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

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00023918 File Offset: 0x00022918
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x00023927 File Offset: 0x00022927
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

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x00023932 File Offset: 0x00022932
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00023941 File Offset: 0x00022941
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

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x0002394C File Offset: 0x0002294C
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x0002395B File Offset: 0x0002295B
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

		// Token: 0x06002132 RID: 8498 RVA: 0x00023968 File Offset: 0x00022968
		public FIXDontKnowTradeDK()
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000239C0 File Offset: 0x000229C0
		public FIXDontKnowTradeDK(string OrderID, string ExecID, char DKReason, char Side)
		{
			this.OrderID = OrderID;
			this.ExecID = ExecID;
			this.DKReason = DKReason;
			this.Side = Side;
		}

		// Token: 0x04000308 RID: 776
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000309 RID: 777
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400030A RID: 778
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x0400030B RID: 779
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x0400030C RID: 780
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x0400030D RID: 781
		private ArrayList fLegsGroup = new ArrayList();
	}
}
