using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000129 RID: 297
	public class FIXRFQRequest : FIXMessage
	{
		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0003A6AF File Offset: 0x000396AF
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x0003A6C1 File Offset: 0x000396C1
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

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x0003A6CF File Offset: 0x000396CF
		// (set) Token: 0x06003775 RID: 14197 RVA: 0x0003A6DE File Offset: 0x000396DE
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

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x0003A6E9 File Offset: 0x000396E9
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x0003A6F8 File Offset: 0x000396F8
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

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x0003A703 File Offset: 0x00039703
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x0003A712 File Offset: 0x00039712
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

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x0003A71D File Offset: 0x0003971D
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x0003A72C File Offset: 0x0003972C
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

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x0003A737 File Offset: 0x00039737
		// (set) Token: 0x0600377D RID: 14205 RVA: 0x0003A746 File Offset: 0x00039746
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

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x0003A751 File Offset: 0x00039751
		// (set) Token: 0x0600377F RID: 14207 RVA: 0x0003A763 File Offset: 0x00039763
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

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x0003A771 File Offset: 0x00039771
		// (set) Token: 0x06003781 RID: 14209 RVA: 0x0003A780 File Offset: 0x00039780
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

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x0003A78B File Offset: 0x0003978B
		// (set) Token: 0x06003783 RID: 14211 RVA: 0x0003A79A File Offset: 0x0003979A
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

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x0003A7A5 File Offset: 0x000397A5
		// (set) Token: 0x06003785 RID: 14213 RVA: 0x0003A7B4 File Offset: 0x000397B4
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

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x0003A7BF File Offset: 0x000397BF
		// (set) Token: 0x06003787 RID: 14215 RVA: 0x0003A7CE File Offset: 0x000397CE
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

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x0003A7D9 File Offset: 0x000397D9
		// (set) Token: 0x06003789 RID: 14217 RVA: 0x0003A7EB File Offset: 0x000397EB
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

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x0003A7F9 File Offset: 0x000397F9
		// (set) Token: 0x0600378B RID: 14219 RVA: 0x0003A808 File Offset: 0x00039808
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

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x0003A813 File Offset: 0x00039813
		// (set) Token: 0x0600378D RID: 14221 RVA: 0x0003A821 File Offset: 0x00039821
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

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x0003A82B File Offset: 0x0003982B
		// (set) Token: 0x0600378F RID: 14223 RVA: 0x0003A83A File Offset: 0x0003983A
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

		// Token: 0x06003790 RID: 14224 RVA: 0x0003A845 File Offset: 0x00039845
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x0003A858 File Offset: 0x00039858
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x0003A867 File Offset: 0x00039867
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x0003A879 File Offset: 0x00039879
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

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x0003A887 File Offset: 0x00039887
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x0003A899 File Offset: 0x00039899
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

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x0003A8A7 File Offset: 0x000398A7
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x0003A8B6 File Offset: 0x000398B6
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

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x0003A8C1 File Offset: 0x000398C1
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x0003A8D0 File Offset: 0x000398D0
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

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x0003A8DB File Offset: 0x000398DB
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x0003A8EA File Offset: 0x000398EA
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

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0003A8F5 File Offset: 0x000398F5
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x0003A904 File Offset: 0x00039904
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

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x0003A90F File Offset: 0x0003990F
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x0003A921 File Offset: 0x00039921
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

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x0003A92F File Offset: 0x0003992F
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x0003A941 File Offset: 0x00039941
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

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x0003A94F File Offset: 0x0003994F
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x0003A961 File Offset: 0x00039961
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

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x0003A96F File Offset: 0x0003996F
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x0003A981 File Offset: 0x00039981
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

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x0003A98F File Offset: 0x0003998F
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x0003A9A1 File Offset: 0x000399A1
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

		// Token: 0x060037A8 RID: 14248 RVA: 0x0003A9AF File Offset: 0x000399AF
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0003A9CD File Offset: 0x000399CD
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x0003A9EA File Offset: 0x000399EA
		// (set) Token: 0x060037AB RID: 14251 RVA: 0x0003A9FC File Offset: 0x000399FC
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

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x0003AA0A File Offset: 0x00039A0A
		// (set) Token: 0x060037AD RID: 14253 RVA: 0x0003AA1C File Offset: 0x00039A1C
		[FIXField("644", EFieldOption.Required)]
		public string RFQReqID
		{
			get
			{
				return this.GetStringField(644).Value;
			}
			set
			{
				this.AddStringField(644, value);
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x0003AA2A File Offset: 0x00039A2A
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x0003AA3C File Offset: 0x00039A3C
		[FIXField("146", EFieldOption.Required)]
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

		// Token: 0x060037B0 RID: 14256 RVA: 0x0003AA4A File Offset: 0x00039A4A
		public FIXRelatedSymGroup GetRelatedSymGroup(int i)
		{
			if (i < this.NoRelatedSym)
			{
				return (FIXRelatedSymGroup)this.fRelatedSymGroup[i];
			}
			return null;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0003AA68 File Offset: 0x00039A68
		public void AddGroup(FIXRelatedSymGroup group)
		{
			this.fRelatedSymGroup.Add(group);
			this.NoRelatedSym++;
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x0003AA85 File Offset: 0x00039A85
		// (set) Token: 0x060037B3 RID: 14259 RVA: 0x0003AA97 File Offset: 0x00039A97
		[FIXField("263", EFieldOption.Optional)]
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

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x0003AAA5 File Offset: 0x00039AA5
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x0003AAB4 File Offset: 0x00039AB4
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

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x0003AABF File Offset: 0x00039ABF
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x0003AACE File Offset: 0x00039ACE
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

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x0003AAD9 File Offset: 0x00039AD9
		// (set) Token: 0x060037B9 RID: 14265 RVA: 0x0003AAE8 File Offset: 0x00039AE8
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

		// Token: 0x060037BA RID: 14266 RVA: 0x0003AAF3 File Offset: 0x00039AF3
		public FIXRFQRequest()
		{
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0003AB1C File Offset: 0x00039B1C
		public FIXRFQRequest(string RFQReqID, int NoRelatedSym)
		{
			this.RFQReqID = RFQReqID;
			this.NoRelatedSym = NoRelatedSym;
		}

		// Token: 0x04000513 RID: 1299
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000514 RID: 1300
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000515 RID: 1301
		private ArrayList fRelatedSymGroup = new ArrayList();
	}
}
