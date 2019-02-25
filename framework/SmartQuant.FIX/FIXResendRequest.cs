using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000091 RID: 145
	public class FIXResendRequest : FIXMessage
	{
		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0001E781 File Offset: 0x0001D781
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0001E793 File Offset: 0x0001D793
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0001E7A1 File Offset: 0x0001D7A1
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0001E7B0 File Offset: 0x0001D7B0
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

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0001E7BB File Offset: 0x0001D7BB
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0001E7CA File Offset: 0x0001D7CA
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

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0001E7D5 File Offset: 0x0001D7D5
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0001E7E4 File Offset: 0x0001D7E4
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

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0001E7EF File Offset: 0x0001D7EF
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0001E7FE File Offset: 0x0001D7FE
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

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0001E809 File Offset: 0x0001D809
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0001E818 File Offset: 0x0001D818
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

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0001E823 File Offset: 0x0001D823
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0001E835 File Offset: 0x0001D835
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

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0001E843 File Offset: 0x0001D843
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0001E852 File Offset: 0x0001D852
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0001E85D File Offset: 0x0001D85D
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x0001E86C File Offset: 0x0001D86C
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

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x0001E877 File Offset: 0x0001D877
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0001E886 File Offset: 0x0001D886
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

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0001E891 File Offset: 0x0001D891
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0001E8A0 File Offset: 0x0001D8A0
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

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x0001E8AB File Offset: 0x0001D8AB
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x0001E8BD File Offset: 0x0001D8BD
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

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x0001E8CB File Offset: 0x0001D8CB
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x0001E8DA File Offset: 0x0001D8DA
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

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0001E8E5 File Offset: 0x0001D8E5
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x0001E8F3 File Offset: 0x0001D8F3
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

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0001E8FD File Offset: 0x0001D8FD
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0001E90C File Offset: 0x0001D90C
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

		// Token: 0x06001BFF RID: 7167 RVA: 0x0001E917 File Offset: 0x0001D917
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0001E92A File Offset: 0x0001D92A
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x0001E939 File Offset: 0x0001D939
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x0001E94B File Offset: 0x0001D94B
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

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x0001E959 File Offset: 0x0001D959
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x0001E96B File Offset: 0x0001D96B
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0001E979 File Offset: 0x0001D979
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x0001E988 File Offset: 0x0001D988
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0001E993 File Offset: 0x0001D993
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x0001E9A2 File Offset: 0x0001D9A2
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0001E9AD File Offset: 0x0001D9AD
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0001E9BC File Offset: 0x0001D9BC
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0001E9C7 File Offset: 0x0001D9C7
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x0001E9D6 File Offset: 0x0001D9D6
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

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0001E9E1 File Offset: 0x0001D9E1
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x0001E9F3 File Offset: 0x0001D9F3
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x0001EA01 File Offset: 0x0001DA01
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x0001EA13 File Offset: 0x0001DA13
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0001EA21 File Offset: 0x0001DA21
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x0001EA33 File Offset: 0x0001DA33
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0001EA41 File Offset: 0x0001DA41
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x0001EA53 File Offset: 0x0001DA53
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0001EA61 File Offset: 0x0001DA61
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0001EA73 File Offset: 0x0001DA73
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

		// Token: 0x06001C17 RID: 7191 RVA: 0x0001EA81 File Offset: 0x0001DA81
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0001EA9F File Offset: 0x0001DA9F
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0001EABC File Offset: 0x0001DABC
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0001EACE File Offset: 0x0001DACE
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

		// Token: 0x06001C1B RID: 7195 RVA: 0x0001EADC File Offset: 0x0001DADC
		public FIXBeginSeqNoGroup GetBeginSeqNoGroup(int i)
		{
			return (FIXBeginSeqNoGroup)this.fBeginSeqNoGroup[i];
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0001EAEF File Offset: 0x0001DAEF
		public void AddGroup(FIXBeginSeqNoGroup group)
		{
			this.fBeginSeqNoGroup.Add(group);
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0001EAFE File Offset: 0x0001DAFE
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x0001EB0D File Offset: 0x0001DB0D
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0001EB18 File Offset: 0x0001DB18
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x0001EB27 File Offset: 0x0001DB27
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

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x0001EB32 File Offset: 0x0001DB32
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x0001EB41 File Offset: 0x0001DB41
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

		// Token: 0x040002E0 RID: 736
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002E1 RID: 737
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040002E2 RID: 738
		private ArrayList fBeginSeqNoGroup = new ArrayList();
	}
}
