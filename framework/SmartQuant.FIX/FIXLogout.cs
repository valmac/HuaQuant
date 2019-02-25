using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000DF RID: 223
	public class FIXLogout : FIXMessage
	{
		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x0002E533 File Offset: 0x0002D533
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x0002E545 File Offset: 0x0002D545
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

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x0002E553 File Offset: 0x0002D553
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x0002E562 File Offset: 0x0002D562
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

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x0002E56D File Offset: 0x0002D56D
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x0002E57C File Offset: 0x0002D57C
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

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x0002E587 File Offset: 0x0002D587
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x0002E596 File Offset: 0x0002D596
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

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x0002E5A1 File Offset: 0x0002D5A1
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x0002E5B0 File Offset: 0x0002D5B0
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

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x0002E5BB File Offset: 0x0002D5BB
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x0002E5CA File Offset: 0x0002D5CA
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

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0002E5D5 File Offset: 0x0002D5D5
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x0002E5E7 File Offset: 0x0002D5E7
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

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x0002E5F5 File Offset: 0x0002D5F5
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x0002E604 File Offset: 0x0002D604
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

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0002E60F File Offset: 0x0002D60F
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x0002E61E File Offset: 0x0002D61E
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

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0002E629 File Offset: 0x0002D629
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x0002E638 File Offset: 0x0002D638
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

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0002E643 File Offset: 0x0002D643
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x0002E652 File Offset: 0x0002D652
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

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0002E65D File Offset: 0x0002D65D
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x0002E66F File Offset: 0x0002D66F
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

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x0002E67D File Offset: 0x0002D67D
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x0002E68C File Offset: 0x0002D68C
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

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0002E697 File Offset: 0x0002D697
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x0002E6A5 File Offset: 0x0002D6A5
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

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0002E6AF File Offset: 0x0002D6AF
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x0002E6BE File Offset: 0x0002D6BE
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

		// Token: 0x06002BBE RID: 11198 RVA: 0x0002E6C9 File Offset: 0x0002D6C9
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x0002E6DC File Offset: 0x0002D6DC
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0002E6EB File Offset: 0x0002D6EB
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x0002E6FD File Offset: 0x0002D6FD
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

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x0002E70B File Offset: 0x0002D70B
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x0002E71D File Offset: 0x0002D71D
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

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x0002E72B File Offset: 0x0002D72B
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x0002E73A File Offset: 0x0002D73A
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

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x0002E745 File Offset: 0x0002D745
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x0002E754 File Offset: 0x0002D754
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

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x0002E75F File Offset: 0x0002D75F
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x0002E76E File Offset: 0x0002D76E
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

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x0002E779 File Offset: 0x0002D779
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x0002E788 File Offset: 0x0002D788
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

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x0002E793 File Offset: 0x0002D793
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x0002E7A5 File Offset: 0x0002D7A5
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

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x0002E7B3 File Offset: 0x0002D7B3
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x0002E7C5 File Offset: 0x0002D7C5
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

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x0002E7D3 File Offset: 0x0002D7D3
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x0002E7E5 File Offset: 0x0002D7E5
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

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0002E7F3 File Offset: 0x0002D7F3
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x0002E805 File Offset: 0x0002D805
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

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x0002E813 File Offset: 0x0002D813
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0002E825 File Offset: 0x0002D825
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

		// Token: 0x06002BD6 RID: 11222 RVA: 0x0002E833 File Offset: 0x0002D833
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x0002E851 File Offset: 0x0002D851
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x0002E86E File Offset: 0x0002D86E
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0002E880 File Offset: 0x0002D880
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

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x0002E88E File Offset: 0x0002D88E
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x0002E89D File Offset: 0x0002D89D
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

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x0002E8A8 File Offset: 0x0002D8A8
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x0002E8BA File Offset: 0x0002D8BA
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

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x0002E8C8 File Offset: 0x0002D8C8
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x0002E8DA File Offset: 0x0002D8DA
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

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x0002E8E8 File Offset: 0x0002D8E8
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x0002E8F7 File Offset: 0x0002D8F7
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

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0002E902 File Offset: 0x0002D902
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x0002E911 File Offset: 0x0002D911
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

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x0002E91C File Offset: 0x0002D91C
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x0002E92B File Offset: 0x0002D92B
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

		// Token: 0x040003D2 RID: 978
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003D3 RID: 979
		private ArrayList fHopsGroup = new ArrayList();
	}
}
