using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000112 RID: 274
	public class FIXSecurityList : FIXMessage
	{
		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x00036357 File Offset: 0x00035357
		// (set) Token: 0x06003351 RID: 13137 RVA: 0x00036369 File Offset: 0x00035369
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

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x00036377 File Offset: 0x00035377
		// (set) Token: 0x06003353 RID: 13139 RVA: 0x00036386 File Offset: 0x00035386
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

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x00036391 File Offset: 0x00035391
		// (set) Token: 0x06003355 RID: 13141 RVA: 0x000363A0 File Offset: 0x000353A0
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

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x000363AB File Offset: 0x000353AB
		// (set) Token: 0x06003357 RID: 13143 RVA: 0x000363BA File Offset: 0x000353BA
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

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x000363C5 File Offset: 0x000353C5
		// (set) Token: 0x06003359 RID: 13145 RVA: 0x000363D4 File Offset: 0x000353D4
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

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x000363DF File Offset: 0x000353DF
		// (set) Token: 0x0600335B RID: 13147 RVA: 0x000363EE File Offset: 0x000353EE
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

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x0600335C RID: 13148 RVA: 0x000363F9 File Offset: 0x000353F9
		// (set) Token: 0x0600335D RID: 13149 RVA: 0x0003640B File Offset: 0x0003540B
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

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x00036419 File Offset: 0x00035419
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x00036428 File Offset: 0x00035428
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

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x00036433 File Offset: 0x00035433
		// (set) Token: 0x06003361 RID: 13153 RVA: 0x00036442 File Offset: 0x00035442
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

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x0003644D File Offset: 0x0003544D
		// (set) Token: 0x06003363 RID: 13155 RVA: 0x0003645C File Offset: 0x0003545C
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

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06003364 RID: 13156 RVA: 0x00036467 File Offset: 0x00035467
		// (set) Token: 0x06003365 RID: 13157 RVA: 0x00036476 File Offset: 0x00035476
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

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06003366 RID: 13158 RVA: 0x00036481 File Offset: 0x00035481
		// (set) Token: 0x06003367 RID: 13159 RVA: 0x00036493 File Offset: 0x00035493
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

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06003368 RID: 13160 RVA: 0x000364A1 File Offset: 0x000354A1
		// (set) Token: 0x06003369 RID: 13161 RVA: 0x000364B0 File Offset: 0x000354B0
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

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x000364BB File Offset: 0x000354BB
		// (set) Token: 0x0600336B RID: 13163 RVA: 0x000364C9 File Offset: 0x000354C9
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

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x0600336C RID: 13164 RVA: 0x000364D3 File Offset: 0x000354D3
		// (set) Token: 0x0600336D RID: 13165 RVA: 0x000364E2 File Offset: 0x000354E2
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

		// Token: 0x0600336E RID: 13166 RVA: 0x000364ED File Offset: 0x000354ED
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00036500 File Offset: 0x00035500
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x0003650F File Offset: 0x0003550F
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x00036521 File Offset: 0x00035521
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

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x0003652F File Offset: 0x0003552F
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x00036541 File Offset: 0x00035541
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

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x0003654F File Offset: 0x0003554F
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x0003655E File Offset: 0x0003555E
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

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x00036569 File Offset: 0x00035569
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x00036578 File Offset: 0x00035578
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

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x00036583 File Offset: 0x00035583
		// (set) Token: 0x06003379 RID: 13177 RVA: 0x00036592 File Offset: 0x00035592
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

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x0003659D File Offset: 0x0003559D
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x000365AC File Offset: 0x000355AC
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

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x000365B7 File Offset: 0x000355B7
		// (set) Token: 0x0600337D RID: 13181 RVA: 0x000365C9 File Offset: 0x000355C9
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x000365D7 File Offset: 0x000355D7
		// (set) Token: 0x0600337F RID: 13183 RVA: 0x000365E9 File Offset: 0x000355E9
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

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x000365F7 File Offset: 0x000355F7
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x00036609 File Offset: 0x00035609
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

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06003382 RID: 13186 RVA: 0x00036617 File Offset: 0x00035617
		// (set) Token: 0x06003383 RID: 13187 RVA: 0x00036629 File Offset: 0x00035629
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

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x00036637 File Offset: 0x00035637
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x00036649 File Offset: 0x00035649
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

		// Token: 0x06003386 RID: 13190 RVA: 0x00036657 File Offset: 0x00035657
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00036675 File Offset: 0x00035675
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x00036692 File Offset: 0x00035692
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x000366A4 File Offset: 0x000356A4
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

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x000366B2 File Offset: 0x000356B2
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x000366C4 File Offset: 0x000356C4
		[FIXField("320", EFieldOption.Required)]
		public string SecurityReqID
		{
			get
			{
				return this.GetStringField(320).Value;
			}
			set
			{
				this.AddStringField(320, value);
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x000366D2 File Offset: 0x000356D2
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x000366E4 File Offset: 0x000356E4
		[FIXField("322", EFieldOption.Required)]
		public string SecurityResponseID
		{
			get
			{
				return this.GetStringField(322).Value;
			}
			set
			{
				this.AddStringField(322, value);
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x000366F2 File Offset: 0x000356F2
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x00036704 File Offset: 0x00035704
		[FIXField("560", EFieldOption.Required)]
		public int SecurityRequestResult
		{
			get
			{
				return this.GetIntField(560).Value;
			}
			set
			{
				this.AddIntField(560, value);
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x00036712 File Offset: 0x00035712
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x00036724 File Offset: 0x00035724
		[FIXField("393", EFieldOption.Optional)]
		public int TotNoRelatedSym
		{
			get
			{
				return this.GetIntField(393).Value;
			}
			set
			{
				this.AddIntField(393, value);
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x00036732 File Offset: 0x00035732
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x00036744 File Offset: 0x00035744
		[FIXField("893", EFieldOption.Optional)]
		public bool LastFragment
		{
			get
			{
				return this.GetBoolField(893).Value;
			}
			set
			{
				this.AddBoolField(893, value);
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x00036752 File Offset: 0x00035752
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x00036764 File Offset: 0x00035764
		[FIXField("146", EFieldOption.Optional)]
		public int NoRelatedSym
		{
			get
			{
				return this.GetIntField(146).Value;
			}
			set
			{
				this.AddIntField(146, value);
			}
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00036772 File Offset: 0x00035772
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00036790 File Offset: 0x00035790
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x000367AD File Offset: 0x000357AD
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x000367BC File Offset: 0x000357BC
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

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x000367C7 File Offset: 0x000357C7
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x000367D6 File Offset: 0x000357D6
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

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x000367E1 File Offset: 0x000357E1
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x000367F0 File Offset: 0x000357F0
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

		// Token: 0x0600339E RID: 13214 RVA: 0x000367FB File Offset: 0x000357FB
		public FIXSecurityList()
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00036824 File Offset: 0x00035824
		public FIXSecurityList(string SecurityReqID, string SecurityResponseID, int SecurityRequestResult)
		{
			this.SecurityReqID = SecurityReqID;
			this.SecurityResponseID = SecurityResponseID;
			this.SecurityRequestResult = SecurityRequestResult;
		}

		// Token: 0x040004EE RID: 1262
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040004EF RID: 1263
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040004F0 RID: 1264
		private ArrayList fRelatedSymGroup = new ArrayList();
	}
}
