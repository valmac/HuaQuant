using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200013B RID: 315
	public class FIXUnderlyingsGroup : FIXGroup
	{
		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x000401B6 File Offset: 0x0003F1B6
		// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x000401C8 File Offset: 0x0003F1C8
		[FIXField("311", EFieldOption.Optional)]
		public string UnderlyingSymbol
		{
			get
			{
				return this.GetStringField(311).Value;
			}
			set
			{
				this.AddStringField(311, value);
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x000401D6 File Offset: 0x0003F1D6
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x000401E8 File Offset: 0x0003F1E8
		[FIXField("312", EFieldOption.Optional)]
		public string UnderlyingSymbolSfx
		{
			get
			{
				return this.GetStringField(312).Value;
			}
			set
			{
				this.AddStringField(312, value);
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x000401F6 File Offset: 0x0003F1F6
		// (set) Token: 0x06003CD9 RID: 15577 RVA: 0x00040208 File Offset: 0x0003F208
		[FIXField("309", EFieldOption.Optional)]
		public string UnderlyingSecurityID
		{
			get
			{
				return this.GetStringField(309).Value;
			}
			set
			{
				this.AddStringField(309, value);
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00040216 File Offset: 0x0003F216
		// (set) Token: 0x06003CDB RID: 15579 RVA: 0x00040228 File Offset: 0x0003F228
		[FIXField("305", EFieldOption.Optional)]
		public string UnderlyingSecurityIDSource
		{
			get
			{
				return this.GetStringField(305).Value;
			}
			set
			{
				this.AddStringField(305, value);
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00040236 File Offset: 0x0003F236
		// (set) Token: 0x06003CDD RID: 15581 RVA: 0x00040248 File Offset: 0x0003F248
		[FIXField("457", EFieldOption.Optional)]
		public int NoUnderlyingSecurityAltID
		{
			get
			{
				return this.GetIntField(457).Value;
			}
			set
			{
				this.AddIntField(457, value);
			}
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00040256 File Offset: 0x0003F256
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00040274 File Offset: 0x0003F274
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x00040291 File Offset: 0x0003F291
		// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x000402A3 File Offset: 0x0003F2A3
		[FIXField("462", EFieldOption.Optional)]
		public int UnderlyingProduct
		{
			get
			{
				return this.GetIntField(462).Value;
			}
			set
			{
				this.AddIntField(462, value);
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x000402B1 File Offset: 0x0003F2B1
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x000402C3 File Offset: 0x0003F2C3
		[FIXField("463", EFieldOption.Optional)]
		public string UnderlyingCFICode
		{
			get
			{
				return this.GetStringField(463).Value;
			}
			set
			{
				this.AddStringField(463, value);
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x000402D1 File Offset: 0x0003F2D1
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x000402E3 File Offset: 0x0003F2E3
		[FIXField("310", EFieldOption.Optional)]
		public string UnderlyingSecurityType
		{
			get
			{
				return this.GetStringField(310).Value;
			}
			set
			{
				this.AddStringField(310, value);
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x000402F1 File Offset: 0x0003F2F1
		// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x00040303 File Offset: 0x0003F303
		[FIXField("763", EFieldOption.Optional)]
		public string UnderlyingSecuritySubType
		{
			get
			{
				return this.GetStringField(763).Value;
			}
			set
			{
				this.AddStringField(763, value);
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x00040311 File Offset: 0x0003F311
		// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x00040323 File Offset: 0x0003F323
		[FIXField("313", EFieldOption.Optional)]
		public string UnderlyingMaturityMonthYear
		{
			get
			{
				return this.GetStringField(313).Value;
			}
			set
			{
				this.AddStringField(313, value);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x00040331 File Offset: 0x0003F331
		// (set) Token: 0x06003CEB RID: 15595 RVA: 0x00040343 File Offset: 0x0003F343
		[FIXField("542", EFieldOption.Optional)]
		public DateTime UnderlyingMaturityDate
		{
			get
			{
				return this.GetDateTimeField(542).Value;
			}
			set
			{
				this.AddDateTimeField(542, value);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x00040351 File Offset: 0x0003F351
		// (set) Token: 0x06003CED RID: 15597 RVA: 0x00040363 File Offset: 0x0003F363
		[FIXField("241", EFieldOption.Optional)]
		public DateTime UnderlyingCouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(241).Value;
			}
			set
			{
				this.AddDateTimeField(241, value);
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x00040371 File Offset: 0x0003F371
		// (set) Token: 0x06003CEF RID: 15599 RVA: 0x00040383 File Offset: 0x0003F383
		[FIXField("242", EFieldOption.Optional)]
		public DateTime UnderlyingIssueDate
		{
			get
			{
				return this.GetDateTimeField(242).Value;
			}
			set
			{
				this.AddDateTimeField(242, value);
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x00040391 File Offset: 0x0003F391
		// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x000403A3 File Offset: 0x0003F3A3
		[FIXField("243", EFieldOption.Optional)]
		public int UnderlyingRepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(243).Value;
			}
			set
			{
				this.AddIntField(243, value);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x000403B1 File Offset: 0x0003F3B1
		// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x000403C3 File Offset: 0x0003F3C3
		[FIXField("244", EFieldOption.Optional)]
		public int UnderlyingRepurchaseTerm
		{
			get
			{
				return this.GetIntField(244).Value;
			}
			set
			{
				this.AddIntField(244, value);
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x000403D1 File Offset: 0x0003F3D1
		// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x000403E3 File Offset: 0x0003F3E3
		[FIXField("245", EFieldOption.Optional)]
		public double UnderlyingRepurchaseRate
		{
			get
			{
				return this.GetDoubleField(245).Value;
			}
			set
			{
				this.AddDoubleField(245, value);
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x000403F1 File Offset: 0x0003F3F1
		// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x00040403 File Offset: 0x0003F403
		[FIXField("246", EFieldOption.Optional)]
		public double UnderlyingFactor
		{
			get
			{
				return this.GetDoubleField(246).Value;
			}
			set
			{
				this.AddDoubleField(246, value);
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x00040411 File Offset: 0x0003F411
		// (set) Token: 0x06003CF9 RID: 15609 RVA: 0x00040423 File Offset: 0x0003F423
		[FIXField("256", EFieldOption.Optional)]
		public string UnderlyingCreditRating
		{
			get
			{
				return this.GetStringField(256).Value;
			}
			set
			{
				this.AddStringField(256, value);
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06003CFA RID: 15610 RVA: 0x00040431 File Offset: 0x0003F431
		// (set) Token: 0x06003CFB RID: 15611 RVA: 0x00040443 File Offset: 0x0003F443
		[FIXField("595", EFieldOption.Optional)]
		public string UnderlyingInstrRegistry
		{
			get
			{
				return this.GetStringField(595).Value;
			}
			set
			{
				this.AddStringField(595, value);
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x00040451 File Offset: 0x0003F451
		// (set) Token: 0x06003CFD RID: 15613 RVA: 0x00040463 File Offset: 0x0003F463
		[FIXField("592", EFieldOption.Optional)]
		public string UnderlyingCountryOfIssue
		{
			get
			{
				return this.GetStringField(592).Value;
			}
			set
			{
				this.AddStringField(592, value);
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x00040471 File Offset: 0x0003F471
		// (set) Token: 0x06003CFF RID: 15615 RVA: 0x00040483 File Offset: 0x0003F483
		[FIXField("593", EFieldOption.Optional)]
		public string UnderlyingStateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(593).Value;
			}
			set
			{
				this.AddStringField(593, value);
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06003D00 RID: 15616 RVA: 0x00040491 File Offset: 0x0003F491
		// (set) Token: 0x06003D01 RID: 15617 RVA: 0x000404A3 File Offset: 0x0003F4A3
		[FIXField("594", EFieldOption.Optional)]
		public string UnderlyingLocaleOfIssue
		{
			get
			{
				return this.GetStringField(594).Value;
			}
			set
			{
				this.AddStringField(594, value);
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06003D02 RID: 15618 RVA: 0x000404B1 File Offset: 0x0003F4B1
		// (set) Token: 0x06003D03 RID: 15619 RVA: 0x000404C3 File Offset: 0x0003F4C3
		[FIXField("247", EFieldOption.Optional)]
		public DateTime UnderlyingRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(247).Value;
			}
			set
			{
				this.AddDateTimeField(247, value);
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x000404D1 File Offset: 0x0003F4D1
		// (set) Token: 0x06003D05 RID: 15621 RVA: 0x000404E3 File Offset: 0x0003F4E3
		[FIXField("316", EFieldOption.Optional)]
		public double UnderlyingStrikePrice
		{
			get
			{
				return this.GetDoubleField(316).Value;
			}
			set
			{
				this.AddDoubleField(316, value);
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x000404F1 File Offset: 0x0003F4F1
		// (set) Token: 0x06003D07 RID: 15623 RVA: 0x00040503 File Offset: 0x0003F503
		[FIXField("941", EFieldOption.Optional)]
		public double UnderlyingStrikeCurrency
		{
			get
			{
				return this.GetDoubleField(941).Value;
			}
			set
			{
				this.AddDoubleField(941, value);
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x00040511 File Offset: 0x0003F511
		// (set) Token: 0x06003D09 RID: 15625 RVA: 0x00040523 File Offset: 0x0003F523
		[FIXField("317", EFieldOption.Optional)]
		public char UnderlyingOptAttribute
		{
			get
			{
				return this.GetCharField(317).Value;
			}
			set
			{
				this.AddCharField(317, value);
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x00040531 File Offset: 0x0003F531
		// (set) Token: 0x06003D0B RID: 15627 RVA: 0x00040543 File Offset: 0x0003F543
		[FIXField("436", EFieldOption.Optional)]
		public double UnderlyingContractMultiplier
		{
			get
			{
				return this.GetDoubleField(436).Value;
			}
			set
			{
				this.AddDoubleField(436, value);
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06003D0C RID: 15628 RVA: 0x00040551 File Offset: 0x0003F551
		// (set) Token: 0x06003D0D RID: 15629 RVA: 0x00040563 File Offset: 0x0003F563
		[FIXField("435", EFieldOption.Optional)]
		public double UnderlyingCouponRate
		{
			get
			{
				return this.GetDoubleField(435).Value;
			}
			set
			{
				this.AddDoubleField(435, value);
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x00040571 File Offset: 0x0003F571
		// (set) Token: 0x06003D0F RID: 15631 RVA: 0x00040583 File Offset: 0x0003F583
		[FIXField("308", EFieldOption.Optional)]
		public string UnderlyingSecurityExchange
		{
			get
			{
				return this.GetStringField(308).Value;
			}
			set
			{
				this.AddStringField(308, value);
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x00040591 File Offset: 0x0003F591
		// (set) Token: 0x06003D11 RID: 15633 RVA: 0x000405A3 File Offset: 0x0003F5A3
		[FIXField("306", EFieldOption.Optional)]
		public string UnderlyingIssuer
		{
			get
			{
				return this.GetStringField(306).Value;
			}
			set
			{
				this.AddStringField(306, value);
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06003D12 RID: 15634 RVA: 0x000405B1 File Offset: 0x0003F5B1
		// (set) Token: 0x06003D13 RID: 15635 RVA: 0x000405C3 File Offset: 0x0003F5C3
		[FIXField("362", EFieldOption.Optional)]
		public int EncodedUnderlyingIssuerLen
		{
			get
			{
				return this.GetIntField(362).Value;
			}
			set
			{
				this.AddIntField(362, value);
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x000405D1 File Offset: 0x0003F5D1
		// (set) Token: 0x06003D15 RID: 15637 RVA: 0x000405E3 File Offset: 0x0003F5E3
		[FIXField("363", EFieldOption.Optional)]
		public string EncodedUnderlyingIssuer
		{
			get
			{
				return this.GetStringField(363).Value;
			}
			set
			{
				this.AddStringField(363, value);
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x000405F1 File Offset: 0x0003F5F1
		// (set) Token: 0x06003D17 RID: 15639 RVA: 0x00040603 File Offset: 0x0003F603
		[FIXField("307", EFieldOption.Optional)]
		public string UnderlyingSecurityDesc
		{
			get
			{
				return this.GetStringField(307).Value;
			}
			set
			{
				this.AddStringField(307, value);
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x00040611 File Offset: 0x0003F611
		// (set) Token: 0x06003D19 RID: 15641 RVA: 0x00040623 File Offset: 0x0003F623
		[FIXField("364", EFieldOption.Optional)]
		public int EncodedUnderlyingSecurityDescLen
		{
			get
			{
				return this.GetIntField(364).Value;
			}
			set
			{
				this.AddIntField(364, value);
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x00040631 File Offset: 0x0003F631
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x00040643 File Offset: 0x0003F643
		[FIXField("365", EFieldOption.Optional)]
		public string EncodedUnderlyingSecurityDesc
		{
			get
			{
				return this.GetStringField(365).Value;
			}
			set
			{
				this.AddStringField(365, value);
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x00040651 File Offset: 0x0003F651
		// (set) Token: 0x06003D1D RID: 15645 RVA: 0x00040663 File Offset: 0x0003F663
		[FIXField("877", EFieldOption.Optional)]
		public string UnderlyingCPProgram
		{
			get
			{
				return this.GetStringField(877).Value;
			}
			set
			{
				this.AddStringField(877, value);
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x00040671 File Offset: 0x0003F671
		// (set) Token: 0x06003D1F RID: 15647 RVA: 0x00040683 File Offset: 0x0003F683
		[FIXField("878", EFieldOption.Optional)]
		public string UnderlyingCPRegType
		{
			get
			{
				return this.GetStringField(878).Value;
			}
			set
			{
				this.AddStringField(878, value);
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x00040691 File Offset: 0x0003F691
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x000406A3 File Offset: 0x0003F6A3
		[FIXField("318", EFieldOption.Optional)]
		public double UnderlyingCurrency
		{
			get
			{
				return this.GetDoubleField(318).Value;
			}
			set
			{
				this.AddDoubleField(318, value);
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x000406B1 File Offset: 0x0003F6B1
		// (set) Token: 0x06003D23 RID: 15651 RVA: 0x000406C3 File Offset: 0x0003F6C3
		[FIXField("879", EFieldOption.Optional)]
		public double UnderlyingQty
		{
			get
			{
				return this.GetDoubleField(879).Value;
			}
			set
			{
				this.AddDoubleField(879, value);
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x000406D1 File Offset: 0x0003F6D1
		// (set) Token: 0x06003D25 RID: 15653 RVA: 0x000406E3 File Offset: 0x0003F6E3
		[FIXField("810", EFieldOption.Optional)]
		public double UnderlyingPx
		{
			get
			{
				return this.GetDoubleField(810).Value;
			}
			set
			{
				this.AddDoubleField(810, value);
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x000406F1 File Offset: 0x0003F6F1
		// (set) Token: 0x06003D27 RID: 15655 RVA: 0x00040703 File Offset: 0x0003F703
		[FIXField("882", EFieldOption.Optional)]
		public double UnderlyingDirtyPrice
		{
			get
			{
				return this.GetDoubleField(882).Value;
			}
			set
			{
				this.AddDoubleField(882, value);
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x00040711 File Offset: 0x0003F711
		// (set) Token: 0x06003D29 RID: 15657 RVA: 0x00040723 File Offset: 0x0003F723
		[FIXField("883", EFieldOption.Optional)]
		public double UnderlyingEndPrice
		{
			get
			{
				return this.GetDoubleField(883).Value;
			}
			set
			{
				this.AddDoubleField(883, value);
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x00040731 File Offset: 0x0003F731
		// (set) Token: 0x06003D2B RID: 15659 RVA: 0x00040743 File Offset: 0x0003F743
		[FIXField("884", EFieldOption.Optional)]
		public double UnderlyingStartValue
		{
			get
			{
				return this.GetDoubleField(884).Value;
			}
			set
			{
				this.AddDoubleField(884, value);
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x00040751 File Offset: 0x0003F751
		// (set) Token: 0x06003D2D RID: 15661 RVA: 0x00040763 File Offset: 0x0003F763
		[FIXField("885", EFieldOption.Optional)]
		public double UnderlyingCurrentValue
		{
			get
			{
				return this.GetDoubleField(885).Value;
			}
			set
			{
				this.AddDoubleField(885, value);
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x00040771 File Offset: 0x0003F771
		// (set) Token: 0x06003D2F RID: 15663 RVA: 0x00040783 File Offset: 0x0003F783
		[FIXField("886", EFieldOption.Optional)]
		public double UnderlyingEndValue
		{
			get
			{
				return this.GetDoubleField(886).Value;
			}
			set
			{
				this.AddDoubleField(886, value);
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06003D30 RID: 15664 RVA: 0x00040791 File Offset: 0x0003F791
		// (set) Token: 0x06003D31 RID: 15665 RVA: 0x000407A3 File Offset: 0x0003F7A3
		[FIXField("887", EFieldOption.Optional)]
		public int NoUnderlyingStips
		{
			get
			{
				return this.GetIntField(887).Value;
			}
			set
			{
				this.AddIntField(887, value);
			}
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x000407B1 File Offset: 0x0003F7B1
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x000407CF File Offset: 0x0003F7CF
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x04000550 RID: 1360
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000551 RID: 1361
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
