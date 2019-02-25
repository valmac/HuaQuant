using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200013F RID: 319
	public class FIXMDEntriesGroup : FIXGroup
	{
		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x00041D1E File Offset: 0x00040D1E
		// (set) Token: 0x06003E80 RID: 16000 RVA: 0x00041D2B File Offset: 0x00040D2B
		[FIXField("269", EFieldOption.Required)]
		public char MDEntryType
		{
			get
			{
				return this.GetCharValue(269);
			}
			set
			{
				this.SetCharValue(269, value);
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x00041D39 File Offset: 0x00040D39
		// (set) Token: 0x06003E82 RID: 16002 RVA: 0x00041D46 File Offset: 0x00040D46
		[FIXField("270", EFieldOption.Optional)]
		public double MDEntryPx
		{
			get
			{
				return this.GetDoubleValue(270);
			}
			set
			{
				this.SetDoubleValue(270, value);
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x00041D54 File Offset: 0x00040D54
		// (set) Token: 0x06003E84 RID: 16004 RVA: 0x00041D5E File Offset: 0x00040D5E
		[FIXField("15", EFieldOption.Optional)]
		public double Currency
		{
			get
			{
				return this.GetDoubleValue(15);
			}
			set
			{
				this.SetDoubleValue(15, value);
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x00041D69 File Offset: 0x00040D69
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x00041D76 File Offset: 0x00040D76
		[FIXField("271", EFieldOption.Optional)]
		public double MDEntrySize
		{
			get
			{
				return this.GetDoubleValue(271);
			}
			set
			{
				this.SetDoubleValue(271, value);
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x00041D84 File Offset: 0x00040D84
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x00041D91 File Offset: 0x00040D91
		[FIXField("272", EFieldOption.Optional)]
		public DateTime MDEntryDate
		{
			get
			{
				return this.GetDateTimeValue(272);
			}
			set
			{
				this.SetDateTimeValue(272, value);
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x00041D9F File Offset: 0x00040D9F
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x00041DAC File Offset: 0x00040DAC
		[FIXField("273", EFieldOption.Optional)]
		public DateTime MDEntryTime
		{
			get
			{
				return this.GetDateTimeValue(273);
			}
			set
			{
				this.SetDateTimeValue(273, value);
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x00041DBA File Offset: 0x00040DBA
		// (set) Token: 0x06003E8C RID: 16012 RVA: 0x00041DC7 File Offset: 0x00040DC7
		[FIXField("274", EFieldOption.Optional)]
		public char TickDirection
		{
			get
			{
				return this.GetCharValue(274);
			}
			set
			{
				this.SetCharValue(274, value);
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x00041DD5 File Offset: 0x00040DD5
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x00041DE2 File Offset: 0x00040DE2
		[FIXField("275", EFieldOption.Optional)]
		public string MDMkt
		{
			get
			{
				return this.GetStringValue(275);
			}
			set
			{
				this.SetStringValue(275, value);
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x00041DF0 File Offset: 0x00040DF0
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x00041DFD File Offset: 0x00040DFD
		[FIXField("336", EFieldOption.Optional)]
		public string TradingSessionID
		{
			get
			{
				return this.GetStringValue(336);
			}
			set
			{
				this.SetStringValue(336, value);
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x00041E0B File Offset: 0x00040E0B
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x00041E18 File Offset: 0x00040E18
		[FIXField("625", EFieldOption.Optional)]
		public string TradingSessionSubID
		{
			get
			{
				return this.GetStringValue(625);
			}
			set
			{
				this.SetStringValue(625, value);
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x00041E26 File Offset: 0x00040E26
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x00041E33 File Offset: 0x00040E33
		[FIXField("276", EFieldOption.Optional)]
		public string QuoteCondition
		{
			get
			{
				return this.GetStringValue(276);
			}
			set
			{
				this.SetStringValue(276, value);
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x00041E41 File Offset: 0x00040E41
		// (set) Token: 0x06003E96 RID: 16022 RVA: 0x00041E4E File Offset: 0x00040E4E
		[FIXField("277", EFieldOption.Optional)]
		public string TradeCondition
		{
			get
			{
				return this.GetStringValue(277);
			}
			set
			{
				this.SetStringValue(277, value);
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06003E97 RID: 16023 RVA: 0x00041E5C File Offset: 0x00040E5C
		// (set) Token: 0x06003E98 RID: 16024 RVA: 0x00041E69 File Offset: 0x00040E69
		[FIXField("282", EFieldOption.Optional)]
		public string MDEntryOriginator
		{
			get
			{
				return this.GetStringValue(282);
			}
			set
			{
				this.SetStringValue(282, value);
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x00041E77 File Offset: 0x00040E77
		// (set) Token: 0x06003E9A RID: 16026 RVA: 0x00041E84 File Offset: 0x00040E84
		[FIXField("283", EFieldOption.Optional)]
		public string LocationID
		{
			get
			{
				return this.GetStringValue(283);
			}
			set
			{
				this.SetStringValue(283, value);
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x00041E92 File Offset: 0x00040E92
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x00041E9F File Offset: 0x00040E9F
		[FIXField("284", EFieldOption.Optional)]
		public string DeskID
		{
			get
			{
				return this.GetStringValue(284);
			}
			set
			{
				this.SetStringValue(284, value);
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x00041EAD File Offset: 0x00040EAD
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x00041EBA File Offset: 0x00040EBA
		[FIXField("286", EFieldOption.Optional)]
		public string OpenCloseSettlFlag
		{
			get
			{
				return this.GetStringValue(286);
			}
			set
			{
				this.SetStringValue(286, value);
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x00041EC8 File Offset: 0x00040EC8
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x00041ED2 File Offset: 0x00040ED2
		[FIXField("59", EFieldOption.Optional)]
		public char TimeInForce
		{
			get
			{
				return this.GetCharValue(59);
			}
			set
			{
				this.SetCharValue(59, value);
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x00041EDD File Offset: 0x00040EDD
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x00041EEA File Offset: 0x00040EEA
		[FIXField("432", EFieldOption.Optional)]
		public DateTime ExpireDate
		{
			get
			{
				return this.GetDateTimeValue(432);
			}
			set
			{
				this.SetDateTimeValue(432, value);
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x00041EF8 File Offset: 0x00040EF8
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x00041F02 File Offset: 0x00040F02
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeValue(126);
			}
			set
			{
				this.SetDateTimeValue(126, value);
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x00041F0D File Offset: 0x00040F0D
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x00041F17 File Offset: 0x00040F17
		[FIXField("110", EFieldOption.Optional)]
		public double MinQty
		{
			get
			{
				return this.GetDoubleValue(110);
			}
			set
			{
				this.SetDoubleValue(110, value);
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x00041F22 File Offset: 0x00040F22
		// (set) Token: 0x06003EA8 RID: 16040 RVA: 0x00041F2C File Offset: 0x00040F2C
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringValue(18);
			}
			set
			{
				this.SetStringValue(18, value);
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x00041F37 File Offset: 0x00040F37
		// (set) Token: 0x06003EAA RID: 16042 RVA: 0x00041F44 File Offset: 0x00040F44
		[FIXField("287", EFieldOption.Optional)]
		public int SellerDays
		{
			get
			{
				return this.GetIntValue(287);
			}
			set
			{
				this.SetIntValue(287, value);
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06003EAB RID: 16043 RVA: 0x00041F52 File Offset: 0x00040F52
		// (set) Token: 0x06003EAC RID: 16044 RVA: 0x00041F5C File Offset: 0x00040F5C
		[FIXField("37", EFieldOption.Optional)]
		public string OrderID
		{
			get
			{
				return this.GetStringValue(37);
			}
			set
			{
				this.SetStringValue(37, value);
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x00041F67 File Offset: 0x00040F67
		// (set) Token: 0x06003EAE RID: 16046 RVA: 0x00041F74 File Offset: 0x00040F74
		[FIXField("299", EFieldOption.Optional)]
		public string QuoteEntryID
		{
			get
			{
				return this.GetStringValue(299);
			}
			set
			{
				this.SetStringValue(299, value);
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x00041F82 File Offset: 0x00040F82
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x00041F8F File Offset: 0x00040F8F
		[FIXField("288", EFieldOption.Optional)]
		public string MDEntryBuyer
		{
			get
			{
				return this.GetStringValue(288);
			}
			set
			{
				this.SetStringValue(288, value);
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x00041F9D File Offset: 0x00040F9D
		// (set) Token: 0x06003EB2 RID: 16050 RVA: 0x00041FAA File Offset: 0x00040FAA
		[FIXField("289", EFieldOption.Optional)]
		public string MDEntrySeller
		{
			get
			{
				return this.GetStringValue(289);
			}
			set
			{
				this.SetStringValue(289, value);
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x00041FB8 File Offset: 0x00040FB8
		// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x00041FC5 File Offset: 0x00040FC5
		[FIXField("346", EFieldOption.Optional)]
		public int NumberOfOrders
		{
			get
			{
				return this.GetIntValue(346);
			}
			set
			{
				this.SetIntValue(346, value);
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x00041FD3 File Offset: 0x00040FD3
		// (set) Token: 0x06003EB6 RID: 16054 RVA: 0x00041FE0 File Offset: 0x00040FE0
		[FIXField("290", EFieldOption.Optional)]
		public int MDEntryPositionNo
		{
			get
			{
				return this.GetIntValue(290);
			}
			set
			{
				this.SetIntValue(290, value);
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x00041FEE File Offset: 0x00040FEE
		// (set) Token: 0x06003EB8 RID: 16056 RVA: 0x00041FFB File Offset: 0x00040FFB
		[FIXField("546", EFieldOption.Optional)]
		public string Scope
		{
			get
			{
				return this.GetStringValue(546);
			}
			set
			{
				this.SetStringValue(546, value);
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06003EB9 RID: 16057 RVA: 0x00042009 File Offset: 0x00041009
		// (set) Token: 0x06003EBA RID: 16058 RVA: 0x00042016 File Offset: 0x00041016
		[FIXField("811", EFieldOption.Optional)]
		public double PriceDelta
		{
			get
			{
				return this.GetDoubleValue(811);
			}
			set
			{
				this.SetDoubleValue(811, value);
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06003EBB RID: 16059 RVA: 0x00042024 File Offset: 0x00041024
		// (set) Token: 0x06003EBC RID: 16060 RVA: 0x0004202E File Offset: 0x0004102E
		[FIXField("58", EFieldOption.Optional)]
		public string Text
		{
			get
			{
				return this.GetStringValue(58);
			}
			set
			{
				this.SetStringValue(58, value);
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06003EBD RID: 16061 RVA: 0x00042039 File Offset: 0x00041039
		// (set) Token: 0x06003EBE RID: 16062 RVA: 0x00042046 File Offset: 0x00041046
		[FIXField("354", EFieldOption.Optional)]
		public int EncodedTextLen
		{
			get
			{
				return this.GetIntValue(354);
			}
			set
			{
				this.SetIntValue(354, value);
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06003EBF RID: 16063 RVA: 0x00042054 File Offset: 0x00041054
		// (set) Token: 0x06003EC0 RID: 16064 RVA: 0x00042061 File Offset: 0x00041061
		[FIXField("355", EFieldOption.Optional)]
		public string EncodedText
		{
			get
			{
				return this.GetStringValue(355);
			}
			set
			{
				this.SetStringValue(355, value);
			}
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0004206F File Offset: 0x0004106F
		public FIXMDEntriesGroup()
		{
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x00042077 File Offset: 0x00041077
		public FIXMDEntriesGroup(char MDEntryType)
		{
			this.MDEntryType = MDEntryType;
		}
	}
}
