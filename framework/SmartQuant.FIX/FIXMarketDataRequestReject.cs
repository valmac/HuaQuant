using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000051 RID: 81
	public class FIXMarketDataRequestReject : FIXMessage
	{
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0001274C File Offset: 0x0001174C
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0001275E File Offset: 0x0001175E
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0001276C File Offset: 0x0001176C
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0001277B File Offset: 0x0001177B
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

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00012786 File Offset: 0x00011786
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x00012795 File Offset: 0x00011795
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

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x000127A0 File Offset: 0x000117A0
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x000127AF File Offset: 0x000117AF
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x000127BA File Offset: 0x000117BA
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x000127C9 File Offset: 0x000117C9
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

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000127D4 File Offset: 0x000117D4
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x000127E3 File Offset: 0x000117E3
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

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x000127EE File Offset: 0x000117EE
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x00012800 File Offset: 0x00011800
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

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0001280E File Offset: 0x0001180E
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x0001281D File Offset: 0x0001181D
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

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00012828 File Offset: 0x00011828
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x00012837 File Offset: 0x00011837
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

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00012842 File Offset: 0x00011842
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00012851 File Offset: 0x00011851
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

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0001285C File Offset: 0x0001185C
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x0001286B File Offset: 0x0001186B
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00012876 File Offset: 0x00011876
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x00012888 File Offset: 0x00011888
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

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00012896 File Offset: 0x00011896
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x000128A5 File Offset: 0x000118A5
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

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x000128B0 File Offset: 0x000118B0
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x000128BE File Offset: 0x000118BE
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

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x000128C8 File Offset: 0x000118C8
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x000128D7 File Offset: 0x000118D7
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

		// Token: 0x06001068 RID: 4200 RVA: 0x000128E2 File Offset: 0x000118E2
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000128F5 File Offset: 0x000118F5
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00012904 File Offset: 0x00011904
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00012916 File Offset: 0x00011916
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

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00012924 File Offset: 0x00011924
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x00012936 File Offset: 0x00011936
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

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00012944 File Offset: 0x00011944
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00012953 File Offset: 0x00011953
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0001295E File Offset: 0x0001195E
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x0001296D File Offset: 0x0001196D
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

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00012978 File Offset: 0x00011978
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00012987 File Offset: 0x00011987
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

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00012992 File Offset: 0x00011992
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x000129A1 File Offset: 0x000119A1
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

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x000129AC File Offset: 0x000119AC
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x000129BE File Offset: 0x000119BE
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

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x000129CC File Offset: 0x000119CC
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x000129DE File Offset: 0x000119DE
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

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x000129EC File Offset: 0x000119EC
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x000129FE File Offset: 0x000119FE
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

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00012A0C File Offset: 0x00011A0C
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x00012A1E File Offset: 0x00011A1E
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

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00012A2C File Offset: 0x00011A2C
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x00012A3E File Offset: 0x00011A3E
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

		// Token: 0x06001080 RID: 4224 RVA: 0x00012A4C File Offset: 0x00011A4C
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00012A6A File Offset: 0x00011A6A
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00012A87 File Offset: 0x00011A87
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00012A99 File Offset: 0x00011A99
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

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00012AA7 File Offset: 0x00011AA7
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00012AB9 File Offset: 0x00011AB9
		[FIXField("262", EFieldOption.Required)]
		public string MDReqID
		{
			get
			{
				return this.GetStringField(262).Value;
			}
			set
			{
				this.AddStringField(262, value);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00012AC7 File Offset: 0x00011AC7
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00012AD9 File Offset: 0x00011AD9
		[FIXField("281", EFieldOption.Optional)]
		public char MDReqRejReason
		{
			get
			{
				return this.GetCharField(281).Value;
			}
			set
			{
				this.AddCharField(281, value);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x00012AE7 File Offset: 0x00011AE7
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x00012AF9 File Offset: 0x00011AF9
		[FIXField("816", EFieldOption.Optional)]
		public int NoAltMDSource
		{
			get
			{
				return this.GetIntField(816).Value;
			}
			set
			{
				this.AddIntField(816, value);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00012B07 File Offset: 0x00011B07
		public FIXAltMDSourceGroup GetAltMDSourceGroup(int i)
		{
			if (i < this.NoAltMDSource)
			{
				return (FIXAltMDSourceGroup)this.fAltMDSourceGroup[i];
			}
			return null;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00012B25 File Offset: 0x00011B25
		public void AddGroup(FIXAltMDSourceGroup group)
		{
			this.fAltMDSourceGroup.Add(group);
			this.NoAltMDSource++;
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00012B42 File Offset: 0x00011B42
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00012B51 File Offset: 0x00011B51
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

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00012B5C File Offset: 0x00011B5C
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x00012B6E File Offset: 0x00011B6E
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

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00012B7C File Offset: 0x00011B7C
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x00012B8E File Offset: 0x00011B8E
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

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00012B9C File Offset: 0x00011B9C
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x00012BAB File Offset: 0x00011BAB
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

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00012BB6 File Offset: 0x00011BB6
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00012BC5 File Offset: 0x00011BC5
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

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00012BD0 File Offset: 0x00011BD0
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00012BDF File Offset: 0x00011BDF
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

		// Token: 0x06001098 RID: 4248 RVA: 0x00012BEA File Offset: 0x00011BEA
		public FIXMarketDataRequestReject()
		{
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00012C13 File Offset: 0x00011C13
		public FIXMarketDataRequestReject(string MDReqID)
		{
			this.MDReqID = MDReqID;
		}

		// Token: 0x04000189 RID: 393
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400018A RID: 394
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400018B RID: 395
		private ArrayList fAltMDSourceGroup = new ArrayList();
	}
}
