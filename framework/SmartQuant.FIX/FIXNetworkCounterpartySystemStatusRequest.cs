using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000162 RID: 354
	public class FIXNetworkCounterpartySystemStatusRequest : FIXMessage
	{
		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x000493D4 File Offset: 0x000483D4
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x000493E6 File Offset: 0x000483E6
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

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x000493F4 File Offset: 0x000483F4
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x00049403 File Offset: 0x00048403
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

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x0004940E File Offset: 0x0004840E
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x0004941D File Offset: 0x0004841D
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

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x00049428 File Offset: 0x00048428
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x00049437 File Offset: 0x00048437
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

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x00049442 File Offset: 0x00048442
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x00049451 File Offset: 0x00048451
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

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0004945C File Offset: 0x0004845C
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x0004946B File Offset: 0x0004846B
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

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x00049476 File Offset: 0x00048476
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x00049488 File Offset: 0x00048488
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

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x00049496 File Offset: 0x00048496
		// (set) Token: 0x06004327 RID: 17191 RVA: 0x000494A5 File Offset: 0x000484A5
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

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x000494B0 File Offset: 0x000484B0
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x000494BF File Offset: 0x000484BF
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

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x000494CA File Offset: 0x000484CA
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x000494D9 File Offset: 0x000484D9
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

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x000494E4 File Offset: 0x000484E4
		// (set) Token: 0x0600432D RID: 17197 RVA: 0x000494F3 File Offset: 0x000484F3
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

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x000494FE File Offset: 0x000484FE
		// (set) Token: 0x0600432F RID: 17199 RVA: 0x00049510 File Offset: 0x00048510
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

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x0004951E File Offset: 0x0004851E
		// (set) Token: 0x06004331 RID: 17201 RVA: 0x0004952D File Offset: 0x0004852D
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

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x00049538 File Offset: 0x00048538
		// (set) Token: 0x06004333 RID: 17203 RVA: 0x00049546 File Offset: 0x00048546
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

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x00049550 File Offset: 0x00048550
		// (set) Token: 0x06004335 RID: 17205 RVA: 0x0004955F File Offset: 0x0004855F
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

		// Token: 0x06004336 RID: 17206 RVA: 0x0004956A File Offset: 0x0004856A
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x0004957D File Offset: 0x0004857D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x0004958C File Offset: 0x0004858C
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x0004959E File Offset: 0x0004859E
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

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x000495AC File Offset: 0x000485AC
		// (set) Token: 0x0600433B RID: 17211 RVA: 0x000495BE File Offset: 0x000485BE
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

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600433C RID: 17212 RVA: 0x000495CC File Offset: 0x000485CC
		// (set) Token: 0x0600433D RID: 17213 RVA: 0x000495DB File Offset: 0x000485DB
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

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x000495E6 File Offset: 0x000485E6
		// (set) Token: 0x0600433F RID: 17215 RVA: 0x000495F5 File Offset: 0x000485F5
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

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x00049600 File Offset: 0x00048600
		// (set) Token: 0x06004341 RID: 17217 RVA: 0x0004960F File Offset: 0x0004860F
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

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x0004961A File Offset: 0x0004861A
		// (set) Token: 0x06004343 RID: 17219 RVA: 0x00049629 File Offset: 0x00048629
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

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x00049634 File Offset: 0x00048634
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x00049646 File Offset: 0x00048646
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

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00049654 File Offset: 0x00048654
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x00049666 File Offset: 0x00048666
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

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x00049674 File Offset: 0x00048674
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x00049686 File Offset: 0x00048686
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

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x00049694 File Offset: 0x00048694
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x000496A6 File Offset: 0x000486A6
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

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x000496B4 File Offset: 0x000486B4
		// (set) Token: 0x0600434D RID: 17229 RVA: 0x000496C6 File Offset: 0x000486C6
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

		// Token: 0x0600434E RID: 17230 RVA: 0x000496D4 File Offset: 0x000486D4
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x000496F2 File Offset: 0x000486F2
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x0004970F File Offset: 0x0004870F
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x00049721 File Offset: 0x00048721
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

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x0004972F File Offset: 0x0004872F
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x00049741 File Offset: 0x00048741
		[FIXField("935", EFieldOption.Required)]
		public int NetworkRequestType
		{
			get
			{
				return this.GetIntField(935).Value;
			}
			set
			{
				this.AddIntField(935, value);
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x0004974F File Offset: 0x0004874F
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x00049761 File Offset: 0x00048761
		[FIXField("933", EFieldOption.Required)]
		public string NetworkRequestID
		{
			get
			{
				return this.GetStringField(933).Value;
			}
			set
			{
				this.AddStringField(933, value);
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x0004976F File Offset: 0x0004876F
		// (set) Token: 0x06004357 RID: 17239 RVA: 0x00049781 File Offset: 0x00048781
		[FIXField("936", EFieldOption.Optional)]
		public int NoCompIDs
		{
			get
			{
				return this.GetIntField(936).Value;
			}
			set
			{
				this.AddIntField(936, value);
			}
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x0004978F File Offset: 0x0004878F
		public FIXCompIDsGroup GetCompIDsGroup(int i)
		{
			if (i < this.NoCompIDs)
			{
				return (FIXCompIDsGroup)this.fCompIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000497AD File Offset: 0x000487AD
		public void AddGroup(FIXCompIDsGroup group)
		{
			this.fCompIDsGroup.Add(group);
			this.NoCompIDs++;
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x0600435A RID: 17242 RVA: 0x000497CA File Offset: 0x000487CA
		// (set) Token: 0x0600435B RID: 17243 RVA: 0x000497D9 File Offset: 0x000487D9
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

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x000497E4 File Offset: 0x000487E4
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x000497F3 File Offset: 0x000487F3
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

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x000497FE File Offset: 0x000487FE
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x0004980D File Offset: 0x0004880D
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

		// Token: 0x06004360 RID: 17248 RVA: 0x00049818 File Offset: 0x00048818
		public FIXNetworkCounterpartySystemStatusRequest()
		{
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00049841 File Offset: 0x00048841
		public FIXNetworkCounterpartySystemStatusRequest(int NetworkRequestType, string NetworkRequestID)
		{
			this.NetworkRequestType = NetworkRequestType;
			this.NetworkRequestID = NetworkRequestID;
		}

		// Token: 0x040009A7 RID: 2471
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040009A8 RID: 2472
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040009A9 RID: 2473
		private ArrayList fCompIDsGroup = new ArrayList();
	}
}
