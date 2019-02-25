using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000134 RID: 308
	public class FIXListStrikePrice : FIXMessage
	{
		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x0003D6F1 File Offset: 0x0003C6F1
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x0003D703 File Offset: 0x0003C703
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

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x0003D711 File Offset: 0x0003C711
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x0003D720 File Offset: 0x0003C720
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

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x0003D72B File Offset: 0x0003C72B
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x0003D73A File Offset: 0x0003C73A
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

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x0003D745 File Offset: 0x0003C745
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x0003D754 File Offset: 0x0003C754
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

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x0003D75F File Offset: 0x0003C75F
		// (set) Token: 0x06003A60 RID: 14944 RVA: 0x0003D76E File Offset: 0x0003C76E
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

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x0003D779 File Offset: 0x0003C779
		// (set) Token: 0x06003A62 RID: 14946 RVA: 0x0003D788 File Offset: 0x0003C788
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

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x0003D793 File Offset: 0x0003C793
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x0003D7A5 File Offset: 0x0003C7A5
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

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x0003D7B3 File Offset: 0x0003C7B3
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x0003D7C2 File Offset: 0x0003C7C2
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

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06003A67 RID: 14951 RVA: 0x0003D7CD File Offset: 0x0003C7CD
		// (set) Token: 0x06003A68 RID: 14952 RVA: 0x0003D7DC File Offset: 0x0003C7DC
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

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x0003D7E7 File Offset: 0x0003C7E7
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x0003D7F6 File Offset: 0x0003C7F6
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

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x0003D801 File Offset: 0x0003C801
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x0003D810 File Offset: 0x0003C810
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

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x0003D81B File Offset: 0x0003C81B
		// (set) Token: 0x06003A6E RID: 14958 RVA: 0x0003D82D File Offset: 0x0003C82D
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

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x0003D83B File Offset: 0x0003C83B
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x0003D84A File Offset: 0x0003C84A
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

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x0003D855 File Offset: 0x0003C855
		// (set) Token: 0x06003A72 RID: 14962 RVA: 0x0003D863 File Offset: 0x0003C863
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

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x0003D86D File Offset: 0x0003C86D
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x0003D87C File Offset: 0x0003C87C
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

		// Token: 0x06003A75 RID: 14965 RVA: 0x0003D887 File Offset: 0x0003C887
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x0003D89A File Offset: 0x0003C89A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x0003D8A9 File Offset: 0x0003C8A9
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x0003D8BB File Offset: 0x0003C8BB
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

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x0003D8C9 File Offset: 0x0003C8C9
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x0003D8DB File Offset: 0x0003C8DB
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

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x0003D8E9 File Offset: 0x0003C8E9
		// (set) Token: 0x06003A7C RID: 14972 RVA: 0x0003D8F8 File Offset: 0x0003C8F8
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

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x0003D903 File Offset: 0x0003C903
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x0003D912 File Offset: 0x0003C912
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

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x0003D91D File Offset: 0x0003C91D
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x0003D92C File Offset: 0x0003C92C
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

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x0003D937 File Offset: 0x0003C937
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x0003D946 File Offset: 0x0003C946
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

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x0003D951 File Offset: 0x0003C951
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x0003D963 File Offset: 0x0003C963
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

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x0003D971 File Offset: 0x0003C971
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x0003D983 File Offset: 0x0003C983
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

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06003A87 RID: 14983 RVA: 0x0003D991 File Offset: 0x0003C991
		// (set) Token: 0x06003A88 RID: 14984 RVA: 0x0003D9A3 File Offset: 0x0003C9A3
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

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x0003D9B1 File Offset: 0x0003C9B1
		// (set) Token: 0x06003A8A RID: 14986 RVA: 0x0003D9C3 File Offset: 0x0003C9C3
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

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06003A8B RID: 14987 RVA: 0x0003D9D1 File Offset: 0x0003C9D1
		// (set) Token: 0x06003A8C RID: 14988 RVA: 0x0003D9E3 File Offset: 0x0003C9E3
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

		// Token: 0x06003A8D RID: 14989 RVA: 0x0003D9F1 File Offset: 0x0003C9F1
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0003DA0F File Offset: 0x0003CA0F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x0003DA2C File Offset: 0x0003CA2C
		// (set) Token: 0x06003A90 RID: 14992 RVA: 0x0003DA3E File Offset: 0x0003CA3E
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

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x0003DA4C File Offset: 0x0003CA4C
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x0003DA5B File Offset: 0x0003CA5B
		[FIXField("66", EFieldOption.Required)]
		public string ListID
		{
			get
			{
				return this.GetStringField(66).Value;
			}
			set
			{
				this.AddStringField(66, value);
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x0003DA66 File Offset: 0x0003CA66
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x0003DA78 File Offset: 0x0003CA78
		[FIXField("422", EFieldOption.Required)]
		public int TotNoStrikes
		{
			get
			{
				return this.GetIntField(422).Value;
			}
			set
			{
				this.AddIntField(422, value);
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x0003DA86 File Offset: 0x0003CA86
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x0003DA98 File Offset: 0x0003CA98
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

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x0003DAA6 File Offset: 0x0003CAA6
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x0003DAB8 File Offset: 0x0003CAB8
		[FIXField("428", EFieldOption.Required)]
		public int NoStrikes
		{
			get
			{
				return this.GetIntField(428).Value;
			}
			set
			{
				this.AddIntField(428, value);
			}
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x0003DAC6 File Offset: 0x0003CAC6
		public FIXStrikesGroup GetStrikesGroup(int i)
		{
			if (i < this.NoStrikes)
			{
				return (FIXStrikesGroup)this.fStrikesGroup[i];
			}
			return null;
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x0003DAE4 File Offset: 0x0003CAE4
		public void AddGroup(FIXStrikesGroup group)
		{
			this.fStrikesGroup.Add(group);
			this.NoStrikes++;
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x0003DB01 File Offset: 0x0003CB01
		// (set) Token: 0x06003A9C RID: 15004 RVA: 0x0003DB13 File Offset: 0x0003CB13
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

		// Token: 0x06003A9D RID: 15005 RVA: 0x0003DB21 File Offset: 0x0003CB21
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x0003DB3F File Offset: 0x0003CB3F
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x0003DB5C File Offset: 0x0003CB5C
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x0003DB6B File Offset: 0x0003CB6B
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

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x0003DB76 File Offset: 0x0003CB76
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x0003DB85 File Offset: 0x0003CB85
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

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x0003DB90 File Offset: 0x0003CB90
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x0003DB9F File Offset: 0x0003CB9F
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

		// Token: 0x06003AA5 RID: 15013 RVA: 0x0003DBAA File Offset: 0x0003CBAA
		public FIXListStrikePrice()
		{
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0003DBE0 File Offset: 0x0003CBE0
		public FIXListStrikePrice(string ListID, int TotNoStrikes, int NoStrikes)
		{
			this.ListID = ListID;
			this.TotNoStrikes = TotNoStrikes;
			this.NoStrikes = NoStrikes;
		}

		// Token: 0x04000533 RID: 1331
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000534 RID: 1332
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000535 RID: 1333
		private ArrayList fStrikesGroup = new ArrayList();

		// Token: 0x04000536 RID: 1334
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
