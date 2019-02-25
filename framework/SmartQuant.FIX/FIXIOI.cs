using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000116 RID: 278
	public class FIXIOI : FIXMessage
	{
		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x00036E35 File Offset: 0x00035E35
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x00036E47 File Offset: 0x00035E47
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

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x00036E55 File Offset: 0x00035E55
		// (set) Token: 0x06003401 RID: 13313 RVA: 0x00036E64 File Offset: 0x00035E64
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

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x00036E6F File Offset: 0x00035E6F
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x00036E7E File Offset: 0x00035E7E
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

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x00036E89 File Offset: 0x00035E89
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x00036E98 File Offset: 0x00035E98
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

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x00036EA3 File Offset: 0x00035EA3
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x00036EB2 File Offset: 0x00035EB2
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

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x00036EBD File Offset: 0x00035EBD
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x00036ECC File Offset: 0x00035ECC
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

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x00036ED7 File Offset: 0x00035ED7
		// (set) Token: 0x0600340B RID: 13323 RVA: 0x00036EE9 File Offset: 0x00035EE9
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

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x00036EF7 File Offset: 0x00035EF7
		// (set) Token: 0x0600340D RID: 13325 RVA: 0x00036F06 File Offset: 0x00035F06
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

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x00036F11 File Offset: 0x00035F11
		// (set) Token: 0x0600340F RID: 13327 RVA: 0x00036F20 File Offset: 0x00035F20
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

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x00036F2B File Offset: 0x00035F2B
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x00036F3A File Offset: 0x00035F3A
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

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x00036F45 File Offset: 0x00035F45
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00036F54 File Offset: 0x00035F54
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

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x00036F5F File Offset: 0x00035F5F
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x00036F71 File Offset: 0x00035F71
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

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x00036F7F File Offset: 0x00035F7F
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x00036F8E File Offset: 0x00035F8E
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

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x00036F99 File Offset: 0x00035F99
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x00036FA7 File Offset: 0x00035FA7
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

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x0600341A RID: 13338 RVA: 0x00036FB1 File Offset: 0x00035FB1
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x00036FC0 File Offset: 0x00035FC0
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

		// Token: 0x0600341C RID: 13340 RVA: 0x00036FCB File Offset: 0x00035FCB
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00036FDE File Offset: 0x00035FDE
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x0600341E RID: 13342 RVA: 0x00036FED File Offset: 0x00035FED
		// (set) Token: 0x0600341F RID: 13343 RVA: 0x00036FFF File Offset: 0x00035FFF
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

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06003420 RID: 13344 RVA: 0x0003700D File Offset: 0x0003600D
		// (set) Token: 0x06003421 RID: 13345 RVA: 0x0003701F File Offset: 0x0003601F
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

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06003422 RID: 13346 RVA: 0x0003702D File Offset: 0x0003602D
		// (set) Token: 0x06003423 RID: 13347 RVA: 0x0003703C File Offset: 0x0003603C
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

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x00037047 File Offset: 0x00036047
		// (set) Token: 0x06003425 RID: 13349 RVA: 0x00037056 File Offset: 0x00036056
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

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x00037061 File Offset: 0x00036061
		// (set) Token: 0x06003427 RID: 13351 RVA: 0x00037070 File Offset: 0x00036070
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

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x0003707B File Offset: 0x0003607B
		// (set) Token: 0x06003429 RID: 13353 RVA: 0x0003708A File Offset: 0x0003608A
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

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x00037095 File Offset: 0x00036095
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x000370A7 File Offset: 0x000360A7
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

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x000370B5 File Offset: 0x000360B5
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x000370C7 File Offset: 0x000360C7
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

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x000370D5 File Offset: 0x000360D5
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x000370E7 File Offset: 0x000360E7
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

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x000370F5 File Offset: 0x000360F5
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x00037107 File Offset: 0x00036107
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

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x00037115 File Offset: 0x00036115
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x00037127 File Offset: 0x00036127
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

		// Token: 0x06003434 RID: 13364 RVA: 0x00037135 File Offset: 0x00036135
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00037153 File Offset: 0x00036153
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x00037170 File Offset: 0x00036170
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x00037182 File Offset: 0x00036182
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

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x00037190 File Offset: 0x00036190
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x0003719F File Offset: 0x0003619F
		[FIXField("23", EFieldOption.Required)]
		public string IOIID
		{
			get
			{
				return this.GetStringField(23).Value;
			}
			set
			{
				this.AddStringField(23, value);
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x000371AA File Offset: 0x000361AA
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x000371B9 File Offset: 0x000361B9
		[FIXField("28", EFieldOption.Required)]
		public char IOITransType
		{
			get
			{
				return this.GetCharField(28).Value;
			}
			set
			{
				this.AddCharField(28, value);
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x000371C4 File Offset: 0x000361C4
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x000371D3 File Offset: 0x000361D3
		[FIXField("26", EFieldOption.Optional)]
		public string IOIRefID
		{
			get
			{
				return this.GetStringField(26).Value;
			}
			set
			{
				this.AddStringField(26, value);
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x000371DE File Offset: 0x000361DE
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x000371ED File Offset: 0x000361ED
		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringField(55).Value;
			}
			set
			{
				this.AddStringField(55, value);
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x000371F8 File Offset: 0x000361F8
		// (set) Token: 0x06003441 RID: 13377 RVA: 0x00037207 File Offset: 0x00036207
		[FIXField("65", EFieldOption.Optional)]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringField(65).Value;
			}
			set
			{
				this.AddStringField(65, value);
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x00037212 File Offset: 0x00036212
		// (set) Token: 0x06003443 RID: 13379 RVA: 0x00037221 File Offset: 0x00036221
		[FIXField("48", EFieldOption.Optional)]
		public string SecurityID
		{
			get
			{
				return this.GetStringField(48).Value;
			}
			set
			{
				this.AddStringField(48, value);
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x0003722C File Offset: 0x0003622C
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x0003723B File Offset: 0x0003623B
		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringField(22).Value;
			}
			set
			{
				this.AddStringField(22, value);
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x00037246 File Offset: 0x00036246
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x00037258 File Offset: 0x00036258
		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntField(454).Value;
			}
			set
			{
				this.AddIntField(454, value);
			}
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00037266 File Offset: 0x00036266
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00037284 File Offset: 0x00036284
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000372A1 File Offset: 0x000362A1
		// (set) Token: 0x0600344B RID: 13387 RVA: 0x000372B3 File Offset: 0x000362B3
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntField(460).Value;
			}
			set
			{
				this.AddIntField(460, value);
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x000372C1 File Offset: 0x000362C1
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x000372D3 File Offset: 0x000362D3
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringField(461).Value;
			}
			set
			{
				this.AddStringField(461, value);
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x000372E1 File Offset: 0x000362E1
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x000372F3 File Offset: 0x000362F3
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringField(167).Value;
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x00037301 File Offset: 0x00036301
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x00037313 File Offset: 0x00036313
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringField(762).Value;
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x00037321 File Offset: 0x00036321
		// (set) Token: 0x06003453 RID: 13395 RVA: 0x00037333 File Offset: 0x00036333
		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringField(200).Value;
			}
			set
			{
				this.AddStringField(200, value);
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x00037341 File Offset: 0x00036341
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x00037353 File Offset: 0x00036353
		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeField(541).Value;
			}
			set
			{
				this.AddDateTimeField(541, value);
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x00037361 File Offset: 0x00036361
		// (set) Token: 0x06003457 RID: 13399 RVA: 0x00037373 File Offset: 0x00036373
		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(224).Value;
			}
			set
			{
				this.AddDateTimeField(224, value);
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x00037381 File Offset: 0x00036381
		// (set) Token: 0x06003459 RID: 13401 RVA: 0x00037393 File Offset: 0x00036393
		[FIXField("225", EFieldOption.Optional)]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeField(225).Value;
			}
			set
			{
				this.AddDateTimeField(225, value);
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x000373A1 File Offset: 0x000363A1
		// (set) Token: 0x0600345B RID: 13403 RVA: 0x000373B3 File Offset: 0x000363B3
		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(239).Value;
			}
			set
			{
				this.AddIntField(239, value);
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x000373C1 File Offset: 0x000363C1
		// (set) Token: 0x0600345D RID: 13405 RVA: 0x000373D3 File Offset: 0x000363D3
		[FIXField("226", EFieldOption.Optional)]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntField(226).Value;
			}
			set
			{
				this.AddIntField(226, value);
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x000373E1 File Offset: 0x000363E1
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x000373F3 File Offset: 0x000363F3
		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleField(227).Value;
			}
			set
			{
				this.AddDoubleField(227, value);
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x00037401 File Offset: 0x00036401
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x00037413 File Offset: 0x00036413
		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleField(228).Value;
			}
			set
			{
				this.AddDoubleField(228, value);
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x00037421 File Offset: 0x00036421
		// (set) Token: 0x06003463 RID: 13411 RVA: 0x00037433 File Offset: 0x00036433
		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringField(255).Value;
			}
			set
			{
				this.AddStringField(255, value);
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x00037441 File Offset: 0x00036441
		// (set) Token: 0x06003465 RID: 13413 RVA: 0x00037453 File Offset: 0x00036453
		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringField(543).Value;
			}
			set
			{
				this.AddStringField(543, value);
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06003466 RID: 13414 RVA: 0x00037461 File Offset: 0x00036461
		// (set) Token: 0x06003467 RID: 13415 RVA: 0x00037473 File Offset: 0x00036473
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringField(470).Value;
			}
			set
			{
				this.AddStringField(470, value);
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x00037481 File Offset: 0x00036481
		// (set) Token: 0x06003469 RID: 13417 RVA: 0x00037493 File Offset: 0x00036493
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(471).Value;
			}
			set
			{
				this.AddStringField(471, value);
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x000374A1 File Offset: 0x000364A1
		// (set) Token: 0x0600346B RID: 13419 RVA: 0x000374B3 File Offset: 0x000364B3
		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringField(472).Value;
			}
			set
			{
				this.AddStringField(472, value);
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x000374C1 File Offset: 0x000364C1
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x000374D3 File Offset: 0x000364D3
		[FIXField("240", EFieldOption.Optional)]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeField(240).Value;
			}
			set
			{
				this.AddDateTimeField(240, value);
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x000374E1 File Offset: 0x000364E1
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x000374F3 File Offset: 0x000364F3
		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleField(202).Value;
			}
			set
			{
				this.AddDoubleField(202, value);
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x00037501 File Offset: 0x00036501
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x00037513 File Offset: 0x00036513
		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleField(947).Value;
			}
			set
			{
				this.AddDoubleField(947, value);
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x00037521 File Offset: 0x00036521
		// (set) Token: 0x06003473 RID: 13427 RVA: 0x00037533 File Offset: 0x00036533
		[FIXField("206", EFieldOption.Optional)]
		public char OptAttribute
		{
			get
			{
				return this.GetCharField(206).Value;
			}
			set
			{
				this.AddCharField(206, value);
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x00037541 File Offset: 0x00036541
		// (set) Token: 0x06003475 RID: 13429 RVA: 0x00037553 File Offset: 0x00036553
		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleField(231).Value;
			}
			set
			{
				this.AddDoubleField(231, value);
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x00037561 File Offset: 0x00036561
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x00037573 File Offset: 0x00036573
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleField(223).Value;
			}
			set
			{
				this.AddDoubleField(223, value);
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x00037581 File Offset: 0x00036581
		// (set) Token: 0x06003479 RID: 13433 RVA: 0x00037593 File Offset: 0x00036593
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringField(207).Value;
			}
			set
			{
				this.AddStringField(207, value);
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x000375A1 File Offset: 0x000365A1
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x000375B0 File Offset: 0x000365B0
		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringField(106).Value;
			}
			set
			{
				this.AddStringField(106, value);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x000375BB File Offset: 0x000365BB
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x000375CD File Offset: 0x000365CD
		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntField(348).Value;
			}
			set
			{
				this.AddIntField(348, value);
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x000375DB File Offset: 0x000365DB
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x000375ED File Offset: 0x000365ED
		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringField(349).Value;
			}
			set
			{
				this.AddStringField(349, value);
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x000375FB File Offset: 0x000365FB
		// (set) Token: 0x06003481 RID: 13441 RVA: 0x0003760A File Offset: 0x0003660A
		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringField(107).Value;
			}
			set
			{
				this.AddStringField(107, value);
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06003482 RID: 13442 RVA: 0x00037615 File Offset: 0x00036615
		// (set) Token: 0x06003483 RID: 13443 RVA: 0x00037627 File Offset: 0x00036627
		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntField(350).Value;
			}
			set
			{
				this.AddIntField(350, value);
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x00037635 File Offset: 0x00036635
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x00037647 File Offset: 0x00036647
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringField(351).Value;
			}
			set
			{
				this.AddStringField(351, value);
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x00037655 File Offset: 0x00036655
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x00037667 File Offset: 0x00036667
		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringField(691).Value;
			}
			set
			{
				this.AddStringField(691, value);
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x00037675 File Offset: 0x00036675
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x00037687 File Offset: 0x00036687
		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringField(667).Value;
			}
			set
			{
				this.AddStringField(667, value);
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x00037695 File Offset: 0x00036695
		// (set) Token: 0x0600348B RID: 13451 RVA: 0x000376A7 File Offset: 0x000366A7
		[FIXField("875", EFieldOption.Optional)]
		public int CPProgram
		{
			get
			{
				return this.GetIntField(875).Value;
			}
			set
			{
				this.AddIntField(875, value);
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x000376B5 File Offset: 0x000366B5
		// (set) Token: 0x0600348D RID: 13453 RVA: 0x000376C7 File Offset: 0x000366C7
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringField(876).Value;
			}
			set
			{
				this.AddStringField(876, value);
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x000376D5 File Offset: 0x000366D5
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x000376E7 File Offset: 0x000366E7
		[FIXField("864", EFieldOption.Optional)]
		public int NoEvents
		{
			get
			{
				return this.GetIntField(864).Value;
			}
			set
			{
				this.AddIntField(864, value);
			}
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x000376F5 File Offset: 0x000366F5
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00037713 File Offset: 0x00036713
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x00037730 File Offset: 0x00036730
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x00037742 File Offset: 0x00036742
		[FIXField("873", EFieldOption.Optional)]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeField(873).Value;
			}
			set
			{
				this.AddDateTimeField(873, value);
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x00037750 File Offset: 0x00036750
		// (set) Token: 0x06003495 RID: 13461 RVA: 0x00037762 File Offset: 0x00036762
		[FIXField("874", EFieldOption.Optional)]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeField(874).Value;
			}
			set
			{
				this.AddDateTimeField(874, value);
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x00037770 File Offset: 0x00036770
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x00037782 File Offset: 0x00036782
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringField(913).Value;
			}
			set
			{
				this.AddStringField(913, value);
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x00037790 File Offset: 0x00036790
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x000377A2 File Offset: 0x000367A2
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringField(914).Value;
			}
			set
			{
				this.AddStringField(914, value);
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x000377B0 File Offset: 0x000367B0
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x000377C2 File Offset: 0x000367C2
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeField(915).Value;
			}
			set
			{
				this.AddDateTimeField(915, value);
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x000377D0 File Offset: 0x000367D0
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x000377E2 File Offset: 0x000367E2
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleField(918).Value;
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x000377F0 File Offset: 0x000367F0
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x00037802 File Offset: 0x00036802
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntField(788).Value;
			}
			set
			{
				this.AddIntField(788, value);
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x00037810 File Offset: 0x00036810
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x00037822 File Offset: 0x00036822
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeField(916).Value;
			}
			set
			{
				this.AddDateTimeField(916, value);
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x00037830 File Offset: 0x00036830
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x00037842 File Offset: 0x00036842
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeField(917).Value;
			}
			set
			{
				this.AddDateTimeField(917, value);
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x00037850 File Offset: 0x00036850
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x00037862 File Offset: 0x00036862
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntField(919).Value;
			}
			set
			{
				this.AddIntField(919, value);
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x00037870 File Offset: 0x00036870
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00037882 File Offset: 0x00036882
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleField(898).Value;
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x00037890 File Offset: 0x00036890
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x000378A2 File Offset: 0x000368A2
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

		// Token: 0x060034AA RID: 13482 RVA: 0x000378B0 File Offset: 0x000368B0
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000378CE File Offset: 0x000368CE
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x000378EB File Offset: 0x000368EB
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x000378FA File Offset: 0x000368FA
		[FIXField("54", EFieldOption.Required)]
		public char Side
		{
			get
			{
				return this.GetCharField(54).Value;
			}
			set
			{
				this.AddCharField(54, value);
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x00037905 File Offset: 0x00036905
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x00037917 File Offset: 0x00036917
		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntField(854).Value;
			}
			set
			{
				this.AddIntField(854, value);
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00037925 File Offset: 0x00036925
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x00037934 File Offset: 0x00036934
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleField(38).Value;
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x0003793F File Offset: 0x0003693F
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x00037951 File Offset: 0x00036951
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleField(152).Value;
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x0003795F File Offset: 0x0003695F
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x00037971 File Offset: 0x00036971
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleField(516).Value;
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x0003797F File Offset: 0x0003697F
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x00037991 File Offset: 0x00036991
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharField(468).Value;
			}
			set
			{
				this.AddCharField(468, value);
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x0003799F File Offset: 0x0003699F
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x000379B1 File Offset: 0x000369B1
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleField(469).Value;
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x000379BF File Offset: 0x000369BF
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x000379CE File Offset: 0x000369CE
		[FIXField("27", EFieldOption.Required)]
		public string IOIQty
		{
			get
			{
				return this.GetStringField(27).Value;
			}
			set
			{
				this.AddStringField(27, value);
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x000379D9 File Offset: 0x000369D9
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x000379E8 File Offset: 0x000369E8
		[FIXField("15", EFieldOption.Optional)]
		public double Currency
		{
			get
			{
				return this.GetDoubleField(15).Value;
			}
			set
			{
				this.AddDoubleField(15, value);
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x000379F3 File Offset: 0x000369F3
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x00037A05 File Offset: 0x00036A05
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntField(232).Value;
			}
			set
			{
				this.AddIntField(232, value);
			}
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00037A13 File Offset: 0x00036A13
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00037A31 File Offset: 0x00036A31
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x00037A4E File Offset: 0x00036A4E
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x00037A60 File Offset: 0x00036A60
		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntField(555).Value;
			}
			set
			{
				this.AddIntField(555, value);
			}
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00037A6E File Offset: 0x00036A6E
		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
			{
				return (FIXLegsGroup)this.fLegsGroup[i];
			}
			return null;
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00037A8C File Offset: 0x00036A8C
		public void AddGroup(FIXLegsGroup group)
		{
			this.fLegsGroup.Add(group);
			this.NoLegs++;
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x00037AA9 File Offset: 0x00036AA9
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x00037ABB File Offset: 0x00036ABB
		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntField(423).Value;
			}
			set
			{
				this.AddIntField(423, value);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x00037AC9 File Offset: 0x00036AC9
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x00037AD8 File Offset: 0x00036AD8
		[FIXField("44", EFieldOption.Optional)]
		public double Price
		{
			get
			{
				return this.GetDoubleField(44).Value;
			}
			set
			{
				this.AddDoubleField(44, value);
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x00037AE3 File Offset: 0x00036AE3
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x00037AF2 File Offset: 0x00036AF2
		[FIXField("62", EFieldOption.Optional)]
		public DateTime ValidUntilTime
		{
			get
			{
				return this.GetDateTimeField(62).Value;
			}
			set
			{
				this.AddDateTimeField(62, value);
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x00037AFD File Offset: 0x00036AFD
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x00037B0C File Offset: 0x00036B0C
		[FIXField("25", EFieldOption.Optional)]
		public char IOIQltyInd
		{
			get
			{
				return this.GetCharField(25).Value;
			}
			set
			{
				this.AddCharField(25, value);
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x00037B17 File Offset: 0x00036B17
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x00037B29 File Offset: 0x00036B29
		[FIXField("130", EFieldOption.Optional)]
		public bool IOINaturalFlag
		{
			get
			{
				return this.GetBoolField(130).Value;
			}
			set
			{
				this.AddBoolField(130, value);
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x00037B37 File Offset: 0x00036B37
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x00037B49 File Offset: 0x00036B49
		[FIXField("199", EFieldOption.Optional)]
		public int NoIOIQualifiers
		{
			get
			{
				return this.GetIntField(199).Value;
			}
			set
			{
				this.AddIntField(199, value);
			}
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00037B57 File Offset: 0x00036B57
		public FIXIOIQualifiersGroup GetIOIQualifiersGroup(int i)
		{
			if (i < this.NoIOIQualifiers)
			{
				return (FIXIOIQualifiersGroup)this.fIOIQualifiersGroup[i];
			}
			return null;
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00037B75 File Offset: 0x00036B75
		public void AddGroup(FIXIOIQualifiersGroup group)
		{
			this.fIOIQualifiersGroup.Add(group);
			this.NoIOIQualifiers++;
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x00037B92 File Offset: 0x00036B92
		// (set) Token: 0x060034D5 RID: 13525 RVA: 0x00037BA1 File Offset: 0x00036BA1
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

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x00037BAC File Offset: 0x00036BAC
		// (set) Token: 0x060034D7 RID: 13527 RVA: 0x00037BBE File Offset: 0x00036BBE
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

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x00037BCC File Offset: 0x00036BCC
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x00037BDE File Offset: 0x00036BDE
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

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x00037BEC File Offset: 0x00036BEC
		// (set) Token: 0x060034DB RID: 13531 RVA: 0x00037BFB File Offset: 0x00036BFB
		[FIXField("60", EFieldOption.Optional)]
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

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x00037C06 File Offset: 0x00036C06
		// (set) Token: 0x060034DD RID: 13533 RVA: 0x00037C18 File Offset: 0x00036C18
		[FIXField("149", EFieldOption.Optional)]
		public string URLLink
		{
			get
			{
				return this.GetStringField(149).Value;
			}
			set
			{
				this.AddStringField(149, value);
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x00037C26 File Offset: 0x00036C26
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x00037C38 File Offset: 0x00036C38
		[FIXField("215", EFieldOption.Optional)]
		public int NoRoutingIDs
		{
			get
			{
				return this.GetIntField(215).Value;
			}
			set
			{
				this.AddIntField(215, value);
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x00037C46 File Offset: 0x00036C46
		public FIXRoutingIDsGroup GetRoutingIDsGroup(int i)
		{
			if (i < this.NoRoutingIDs)
			{
				return (FIXRoutingIDsGroup)this.fRoutingIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00037C64 File Offset: 0x00036C64
		public void AddGroup(FIXRoutingIDsGroup group)
		{
			this.fRoutingIDsGroup.Add(group);
			this.NoRoutingIDs++;
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x00037C81 File Offset: 0x00036C81
		// (set) Token: 0x060034E3 RID: 13539 RVA: 0x00037C93 File Offset: 0x00036C93
		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleField(218).Value;
			}
			set
			{
				this.AddDoubleField(218, value);
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x00037CA1 File Offset: 0x00036CA1
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x00037CB3 File Offset: 0x00036CB3
		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleField(220).Value;
			}
			set
			{
				this.AddDoubleField(220, value);
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x00037CC1 File Offset: 0x00036CC1
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x00037CD3 File Offset: 0x00036CD3
		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringField(221).Value;
			}
			set
			{
				this.AddStringField(221, value);
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x00037CE1 File Offset: 0x00036CE1
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x00037CF3 File Offset: 0x00036CF3
		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringField(222).Value;
			}
			set
			{
				this.AddStringField(222, value);
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x00037D01 File Offset: 0x00036D01
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x00037D13 File Offset: 0x00036D13
		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleField(662).Value;
			}
			set
			{
				this.AddDoubleField(662, value);
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x00037D21 File Offset: 0x00036D21
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x00037D33 File Offset: 0x00036D33
		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntField(663).Value;
			}
			set
			{
				this.AddIntField(663, value);
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x00037D41 File Offset: 0x00036D41
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x00037D53 File Offset: 0x00036D53
		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringField(699).Value;
			}
			set
			{
				this.AddStringField(699, value);
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x00037D61 File Offset: 0x00036D61
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x00037D73 File Offset: 0x00036D73
		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringField(761).Value;
			}
			set
			{
				this.AddStringField(761, value);
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x00037D81 File Offset: 0x00036D81
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x00037D93 File Offset: 0x00036D93
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringField(235).Value;
			}
			set
			{
				this.AddStringField(235, value);
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x00037DA1 File Offset: 0x00036DA1
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x00037DB3 File Offset: 0x00036DB3
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleField(236).Value;
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x00037DC1 File Offset: 0x00036DC1
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x00037DD3 File Offset: 0x00036DD3
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeField(701).Value;
			}
			set
			{
				this.AddDateTimeField(701, value);
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x00037DE1 File Offset: 0x00036DE1
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x00037DF3 File Offset: 0x00036DF3
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(696).Value;
			}
			set
			{
				this.AddDateTimeField(696, value);
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x00037E01 File Offset: 0x00036E01
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x00037E13 File Offset: 0x00036E13
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleField(697).Value;
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x00037E21 File Offset: 0x00036E21
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x00037E33 File Offset: 0x00036E33
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntField(698).Value;
			}
			set
			{
				this.AddIntField(698, value);
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x00037E41 File Offset: 0x00036E41
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x00037E50 File Offset: 0x00036E50
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

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x00037E5B File Offset: 0x00036E5B
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x00037E6A File Offset: 0x00036E6A
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

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x00037E75 File Offset: 0x00036E75
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x00037E84 File Offset: 0x00036E84
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

		// Token: 0x06003504 RID: 13572 RVA: 0x00037E90 File Offset: 0x00036E90
		public FIXIOI()
		{
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00037F08 File Offset: 0x00036F08
		public FIXIOI(string IOIID, char IOITransType, char Side, string IOIQty)
		{
			this.IOIID = IOIID;
			this.IOITransType = IOITransType;
			this.Side = Side;
			this.IOIQty = IOIQty;
		}

		// Token: 0x040004F6 RID: 1270
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040004F7 RID: 1271
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x040004F8 RID: 1272
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x040004F9 RID: 1273
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x040004FA RID: 1274
		private ArrayList fUnderlyingsGroup = new ArrayList();

		// Token: 0x040004FB RID: 1275
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x040004FC RID: 1276
		private ArrayList fLegsGroup = new ArrayList();

		// Token: 0x040004FD RID: 1277
		private ArrayList fIOIQualifiersGroup = new ArrayList();

		// Token: 0x040004FE RID: 1278
		private ArrayList fRoutingIDsGroup = new ArrayList();
	}
}
