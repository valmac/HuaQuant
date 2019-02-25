using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000148 RID: 328
	public class FIXSettlementInstructions : FIXMessage
	{
		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x00044AC8 File Offset: 0x00043AC8
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x00044ADA File Offset: 0x00043ADA
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

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x00044AE8 File Offset: 0x00043AE8
		// (set) Token: 0x06003EF5 RID: 16117 RVA: 0x00044AF7 File Offset: 0x00043AF7
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

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x00044B02 File Offset: 0x00043B02
		// (set) Token: 0x06003EF7 RID: 16119 RVA: 0x00044B11 File Offset: 0x00043B11
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

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x00044B1C File Offset: 0x00043B1C
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x00044B2B File Offset: 0x00043B2B
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

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x00044B36 File Offset: 0x00043B36
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x00044B45 File Offset: 0x00043B45
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

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06003EFC RID: 16124 RVA: 0x00044B50 File Offset: 0x00043B50
		// (set) Token: 0x06003EFD RID: 16125 RVA: 0x00044B5F File Offset: 0x00043B5F
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

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06003EFE RID: 16126 RVA: 0x00044B6A File Offset: 0x00043B6A
		// (set) Token: 0x06003EFF RID: 16127 RVA: 0x00044B7C File Offset: 0x00043B7C
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

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06003F00 RID: 16128 RVA: 0x00044B8A File Offset: 0x00043B8A
		// (set) Token: 0x06003F01 RID: 16129 RVA: 0x00044B99 File Offset: 0x00043B99
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

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x00044BA4 File Offset: 0x00043BA4
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x00044BB3 File Offset: 0x00043BB3
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

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x00044BBE File Offset: 0x00043BBE
		// (set) Token: 0x06003F05 RID: 16133 RVA: 0x00044BCD File Offset: 0x00043BCD
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

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x00044BD8 File Offset: 0x00043BD8
		// (set) Token: 0x06003F07 RID: 16135 RVA: 0x00044BE7 File Offset: 0x00043BE7
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

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x00044BF2 File Offset: 0x00043BF2
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x00044C04 File Offset: 0x00043C04
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

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x00044C12 File Offset: 0x00043C12
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x00044C21 File Offset: 0x00043C21
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

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x00044C2C File Offset: 0x00043C2C
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x00044C3A File Offset: 0x00043C3A
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

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x00044C44 File Offset: 0x00043C44
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x00044C53 File Offset: 0x00043C53
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

		// Token: 0x06003F10 RID: 16144 RVA: 0x00044C5E File Offset: 0x00043C5E
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00044C71 File Offset: 0x00043C71
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x00044C80 File Offset: 0x00043C80
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x00044C92 File Offset: 0x00043C92
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

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x00044CA0 File Offset: 0x00043CA0
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x00044CB2 File Offset: 0x00043CB2
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

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x00044CC0 File Offset: 0x00043CC0
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x00044CCF File Offset: 0x00043CCF
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

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x00044CDA File Offset: 0x00043CDA
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x00044CE9 File Offset: 0x00043CE9
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

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x00044CF4 File Offset: 0x00043CF4
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x00044D03 File Offset: 0x00043D03
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

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x00044D0E File Offset: 0x00043D0E
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x00044D1D File Offset: 0x00043D1D
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

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x00044D28 File Offset: 0x00043D28
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x00044D3A File Offset: 0x00043D3A
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

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x00044D48 File Offset: 0x00043D48
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x00044D5A File Offset: 0x00043D5A
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

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x00044D68 File Offset: 0x00043D68
		// (set) Token: 0x06003F23 RID: 16163 RVA: 0x00044D7A File Offset: 0x00043D7A
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

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06003F24 RID: 16164 RVA: 0x00044D88 File Offset: 0x00043D88
		// (set) Token: 0x06003F25 RID: 16165 RVA: 0x00044D9A File Offset: 0x00043D9A
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

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x00044DA8 File Offset: 0x00043DA8
		// (set) Token: 0x06003F27 RID: 16167 RVA: 0x00044DBA File Offset: 0x00043DBA
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

		// Token: 0x06003F28 RID: 16168 RVA: 0x00044DC8 File Offset: 0x00043DC8
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00044DE6 File Offset: 0x00043DE6
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x00044E03 File Offset: 0x00043E03
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x00044E15 File Offset: 0x00043E15
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

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06003F2C RID: 16172 RVA: 0x00044E23 File Offset: 0x00043E23
		// (set) Token: 0x06003F2D RID: 16173 RVA: 0x00044E35 File Offset: 0x00043E35
		[FIXField("777", EFieldOption.Required)]
		public string SettlInstMsgID
		{
			get
			{
				return this.GetStringField(777).Value;
			}
			set
			{
				this.AddStringField(777, value);
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x00044E43 File Offset: 0x00043E43
		// (set) Token: 0x06003F2F RID: 16175 RVA: 0x00044E55 File Offset: 0x00043E55
		[FIXField("791", EFieldOption.Optional)]
		public string SettlInstReqID
		{
			get
			{
				return this.GetStringField(791).Value;
			}
			set
			{
				this.AddStringField(791, value);
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x00044E63 File Offset: 0x00043E63
		// (set) Token: 0x06003F31 RID: 16177 RVA: 0x00044E75 File Offset: 0x00043E75
		[FIXField("160", EFieldOption.Required)]
		public char SettlInstMode
		{
			get
			{
				return this.GetCharField(160).Value;
			}
			set
			{
				this.AddCharField(160, value);
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x00044E83 File Offset: 0x00043E83
		// (set) Token: 0x06003F33 RID: 16179 RVA: 0x00044E95 File Offset: 0x00043E95
		[FIXField("792", EFieldOption.Optional)]
		public int SettlInstReqRejCode
		{
			get
			{
				return this.GetIntField(792).Value;
			}
			set
			{
				this.AddIntField(792, value);
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x00044EA3 File Offset: 0x00043EA3
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x00044EB2 File Offset: 0x00043EB2
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

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x00044EBD File Offset: 0x00043EBD
		// (set) Token: 0x06003F37 RID: 16183 RVA: 0x00044ECF File Offset: 0x00043ECF
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

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06003F38 RID: 16184 RVA: 0x00044EDD File Offset: 0x00043EDD
		// (set) Token: 0x06003F39 RID: 16185 RVA: 0x00044EEF File Offset: 0x00043EEF
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

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x00044EFD File Offset: 0x00043EFD
		// (set) Token: 0x06003F3B RID: 16187 RVA: 0x00044F0C File Offset: 0x00043F0C
		[FIXField("11", EFieldOption.Optional)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringField(11).Value;
			}
			set
			{
				this.AddStringField(11, value);
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x00044F17 File Offset: 0x00043F17
		// (set) Token: 0x06003F3D RID: 16189 RVA: 0x00044F26 File Offset: 0x00043F26
		[FIXField("60", EFieldOption.Required)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeField(60).Value;
			}
			set
			{
				this.AddDateTimeField(60, value);
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x00044F31 File Offset: 0x00043F31
		// (set) Token: 0x06003F3F RID: 16191 RVA: 0x00044F43 File Offset: 0x00043F43
		[FIXField("778", EFieldOption.Optional)]
		public int NoSettlInst
		{
			get
			{
				return this.GetIntField(778).Value;
			}
			set
			{
				this.AddIntField(778, value);
			}
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00044F51 File Offset: 0x00043F51
		public FIXSettlInstGroup GetSettlInstGroup(int i)
		{
			if (i < this.NoSettlInst)
			{
				return (FIXSettlInstGroup)this.fSettlInstGroup[i];
			}
			return null;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00044F6F File Offset: 0x00043F6F
		public void AddGroup(FIXSettlInstGroup group)
		{
			this.fSettlInstGroup.Add(group);
			this.NoSettlInst++;
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x00044F8C File Offset: 0x00043F8C
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x00044F9B File Offset: 0x00043F9B
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

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x00044FA6 File Offset: 0x00043FA6
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x00044FB5 File Offset: 0x00043FB5
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

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x00044FC0 File Offset: 0x00043FC0
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x00044FCF File Offset: 0x00043FCF
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

		// Token: 0x06003F48 RID: 16200 RVA: 0x00044FDA File Offset: 0x00043FDA
		public FIXSettlementInstructions()
		{
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x00045003 File Offset: 0x00044003
		public FIXSettlementInstructions(string SettlInstMsgID, char SettlInstMode, DateTime TransactTime)
		{
			this.SettlInstMsgID = SettlInstMsgID;
			this.SettlInstMode = SettlInstMode;
			this.TransactTime = TransactTime;
		}

		// Token: 0x0400094D RID: 2381
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x0400094E RID: 2382
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x0400094F RID: 2383
		private ArrayList fSettlInstGroup = new ArrayList();
	}
}
