using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000DB RID: 219
	public class FIXStandardHeader : FIXMessage
	{
		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x0002DBFE File Offset: 0x0002CBFE
		// (set) Token: 0x06002B0D RID: 11021 RVA: 0x0002DC10 File Offset: 0x0002CC10
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

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x0002DC1E File Offset: 0x0002CC1E
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x0002DC2D File Offset: 0x0002CC2D
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

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0002DC38 File Offset: 0x0002CC38
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0002DC47 File Offset: 0x0002CC47
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

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0002DC52 File Offset: 0x0002CC52
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0002DC61 File Offset: 0x0002CC61
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

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0002DC6C File Offset: 0x0002CC6C
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0002DC7B File Offset: 0x0002CC7B
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

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0002DC86 File Offset: 0x0002CC86
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0002DC95 File Offset: 0x0002CC95
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

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x0002DCA0 File Offset: 0x0002CCA0
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x0002DCB2 File Offset: 0x0002CCB2
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

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x0002DCC0 File Offset: 0x0002CCC0
		// (set) Token: 0x06002B1B RID: 11035 RVA: 0x0002DCCF File Offset: 0x0002CCCF
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

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0002DCDA File Offset: 0x0002CCDA
		// (set) Token: 0x06002B1D RID: 11037 RVA: 0x0002DCE9 File Offset: 0x0002CCE9
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

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x0002DCF4 File Offset: 0x0002CCF4
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x0002DD03 File Offset: 0x0002CD03
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

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x0002DD0E File Offset: 0x0002CD0E
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x0002DD1D File Offset: 0x0002CD1D
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

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x0002DD28 File Offset: 0x0002CD28
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x0002DD3A File Offset: 0x0002CD3A
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

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x0002DD48 File Offset: 0x0002CD48
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x0002DD57 File Offset: 0x0002CD57
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

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x0002DD62 File Offset: 0x0002CD62
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x0002DD70 File Offset: 0x0002CD70
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

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0002DD7A File Offset: 0x0002CD7A
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x0002DD89 File Offset: 0x0002CD89
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

		// Token: 0x06002B2A RID: 11050 RVA: 0x0002DD94 File Offset: 0x0002CD94
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0002DDA7 File Offset: 0x0002CDA7
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x0002DDB6 File Offset: 0x0002CDB6
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x0002DDC8 File Offset: 0x0002CDC8
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

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x0002DDD6 File Offset: 0x0002CDD6
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x0002DDE8 File Offset: 0x0002CDE8
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

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x0002DDF6 File Offset: 0x0002CDF6
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x0002DE05 File Offset: 0x0002CE05
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

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x0002DE10 File Offset: 0x0002CE10
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x0002DE1F File Offset: 0x0002CE1F
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

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x0002DE2A File Offset: 0x0002CE2A
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x0002DE39 File Offset: 0x0002CE39
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

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x0002DE44 File Offset: 0x0002CE44
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x0002DE53 File Offset: 0x0002CE53
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

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x0002DE5E File Offset: 0x0002CE5E
		// (set) Token: 0x06002B39 RID: 11065 RVA: 0x0002DE70 File Offset: 0x0002CE70
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

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x0002DE7E File Offset: 0x0002CE7E
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x0002DE90 File Offset: 0x0002CE90
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

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x0002DE9E File Offset: 0x0002CE9E
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x0002DEB0 File Offset: 0x0002CEB0
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

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x0002DEBE File Offset: 0x0002CEBE
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x0002DED0 File Offset: 0x0002CED0
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

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x0002DEDE File Offset: 0x0002CEDE
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x0002DEF0 File Offset: 0x0002CEF0
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

		// Token: 0x06002B42 RID: 11074 RVA: 0x0002DEFE File Offset: 0x0002CEFE
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x0002DF1C File Offset: 0x0002CF1C
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x0002DF39 File Offset: 0x0002CF39
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x0002DF4B File Offset: 0x0002CF4B
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

		// Token: 0x06002B46 RID: 11078 RVA: 0x0002DF59 File Offset: 0x0002CF59
		public FIXStandardHeader()
		{
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x0002DF78 File Offset: 0x0002CF78
		public FIXStandardHeader(int BodyLength, string MsgType, string SenderCompID, string TargetCompID, int MsgSeqNum, string BeginString)
		{
			this.BodyLength = BodyLength;
			this.MsgType = MsgType;
			this.SenderCompID = SenderCompID;
			this.TargetCompID = TargetCompID;
			this.MsgSeqNum = MsgSeqNum;
			this.BeginString = BeginString;
		}

		// Token: 0x040003CB RID: 971
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040003CC RID: 972
		private ArrayList fHopsGroup = new ArrayList();
	}
}
