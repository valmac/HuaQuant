using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000D3 RID: 211
	public class FIXQuoteSetsGroup : FIXGroup
	{
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x0002CA30 File Offset: 0x0002BA30
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0002CA42 File Offset: 0x0002BA42
		[FIXField("302", EFieldOption.Optional)]
		public string QuoteSetID
		{
			get
			{
				return this.GetStringField(302).Value;
			}
			set
			{
				this.AddStringField(302, value);
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x0002CA50 File Offset: 0x0002BA50
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x0002CA62 File Offset: 0x0002BA62
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x0002CA70 File Offset: 0x0002BA70
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x0002CA82 File Offset: 0x0002BA82
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

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x0002CA90 File Offset: 0x0002BA90
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x0002CAA2 File Offset: 0x0002BAA2
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

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0002CAB0 File Offset: 0x0002BAB0
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x0002CAC2 File Offset: 0x0002BAC2
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

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x0002CAD0 File Offset: 0x0002BAD0
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x0002CAE2 File Offset: 0x0002BAE2
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

		// Token: 0x060029FB RID: 10747 RVA: 0x0002CAF0 File Offset: 0x0002BAF0
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0002CB0E File Offset: 0x0002BB0E
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0002CB2B File Offset: 0x0002BB2B
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x0002CB3D File Offset: 0x0002BB3D
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

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x0002CB4B File Offset: 0x0002BB4B
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x0002CB5D File Offset: 0x0002BB5D
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

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x0002CB6B File Offset: 0x0002BB6B
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x0002CB7D File Offset: 0x0002BB7D
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

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0002CB8B File Offset: 0x0002BB8B
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0002CB9D File Offset: 0x0002BB9D
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

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x0002CBAB File Offset: 0x0002BBAB
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0002CBBD File Offset: 0x0002BBBD
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

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0002CBCB File Offset: 0x0002BBCB
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0002CBDD File Offset: 0x0002BBDD
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

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x0002CBEB File Offset: 0x0002BBEB
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x0002CBFD File Offset: 0x0002BBFD
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

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x0002CC0B File Offset: 0x0002BC0B
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x0002CC1D File Offset: 0x0002BC1D
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

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x0002CC2B File Offset: 0x0002BC2B
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x0002CC3D File Offset: 0x0002BC3D
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0002CC4B File Offset: 0x0002BC4B
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0002CC5D File Offset: 0x0002BC5D
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

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0002CC6B File Offset: 0x0002BC6B
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0002CC7D File Offset: 0x0002BC7D
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

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x0002CC8B File Offset: 0x0002BC8B
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0002CC9D File Offset: 0x0002BC9D
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

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0002CCAB File Offset: 0x0002BCAB
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0002CCBD File Offset: 0x0002BCBD
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

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0002CCCB File Offset: 0x0002BCCB
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0002CCDD File Offset: 0x0002BCDD
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

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x0002CCEB File Offset: 0x0002BCEB
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x0002CCFD File Offset: 0x0002BCFD
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

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0002CD0B File Offset: 0x0002BD0B
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x0002CD1D File Offset: 0x0002BD1D
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

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0002CD2B File Offset: 0x0002BD2B
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x0002CD3D File Offset: 0x0002BD3D
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

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x0002CD4B File Offset: 0x0002BD4B
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x0002CD5D File Offset: 0x0002BD5D
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

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x0002CD6B File Offset: 0x0002BD6B
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0002CD7D File Offset: 0x0002BD7D
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

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0002CD8B File Offset: 0x0002BD8B
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0002CD9D File Offset: 0x0002BD9D
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

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0002CDAB File Offset: 0x0002BDAB
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x0002CDBD File Offset: 0x0002BDBD
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

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x0002CDCB File Offset: 0x0002BDCB
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x0002CDDD File Offset: 0x0002BDDD
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

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x0002CDEB File Offset: 0x0002BDEB
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x0002CDFD File Offset: 0x0002BDFD
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

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x0002CE0B File Offset: 0x0002BE0B
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x0002CE1D File Offset: 0x0002BE1D
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

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x0002CE2B File Offset: 0x0002BE2B
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x0002CE3D File Offset: 0x0002BE3D
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

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x0002CE4B File Offset: 0x0002BE4B
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x0002CE5D File Offset: 0x0002BE5D
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

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0002CE6B File Offset: 0x0002BE6B
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x0002CE7D File Offset: 0x0002BE7D
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

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x0002CE8B File Offset: 0x0002BE8B
		// (set) Token: 0x06002A34 RID: 10804 RVA: 0x0002CE9D File Offset: 0x0002BE9D
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

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x0002CEAB File Offset: 0x0002BEAB
		// (set) Token: 0x06002A36 RID: 10806 RVA: 0x0002CEBD File Offset: 0x0002BEBD
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0002CECB File Offset: 0x0002BECB
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x0002CEDD File Offset: 0x0002BEDD
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

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x0002CEEB File Offset: 0x0002BEEB
		// (set) Token: 0x06002A3A RID: 10810 RVA: 0x0002CEFD File Offset: 0x0002BEFD
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

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x0002CF0B File Offset: 0x0002BF0B
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x0002CF1D File Offset: 0x0002BF1D
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

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x0002CF2B File Offset: 0x0002BF2B
		// (set) Token: 0x06002A3E RID: 10814 RVA: 0x0002CF3D File Offset: 0x0002BF3D
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

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x0002CF4B File Offset: 0x0002BF4B
		// (set) Token: 0x06002A40 RID: 10816 RVA: 0x0002CF5D File Offset: 0x0002BF5D
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

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x0002CF6B File Offset: 0x0002BF6B
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x0002CF7D File Offset: 0x0002BF7D
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

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x0002CF8B File Offset: 0x0002BF8B
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x0002CF9D File Offset: 0x0002BF9D
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

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x0002CFAB File Offset: 0x0002BFAB
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x0002CFBD File Offset: 0x0002BFBD
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

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x0002CFCB File Offset: 0x0002BFCB
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x0002CFDD File Offset: 0x0002BFDD
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

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x0002CFEB File Offset: 0x0002BFEB
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x0002CFFD File Offset: 0x0002BFFD
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

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x0002D00B File Offset: 0x0002C00B
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x0002D01D File Offset: 0x0002C01D
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

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0002D02B File Offset: 0x0002C02B
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0002D03D File Offset: 0x0002C03D
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

		// Token: 0x06002A4F RID: 10831 RVA: 0x0002D04B File Offset: 0x0002C04B
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0002D069 File Offset: 0x0002C069
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x0002D086 File Offset: 0x0002C086
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0002D098 File Offset: 0x0002C098
		[FIXField("304", EFieldOption.Optional)]
		public int TotNoQuoteEntries
		{
			get
			{
				return this.GetIntField(304).Value;
			}
			set
			{
				this.AddIntField(304, value);
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x0002D0A6 File Offset: 0x0002C0A6
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x0002D0B8 File Offset: 0x0002C0B8
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

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x0002D0C6 File Offset: 0x0002C0C6
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x0002D0D8 File Offset: 0x0002C0D8
		[FIXField("295", EFieldOption.Optional)]
		public int NoQuoteEntries
		{
			get
			{
				return this.GetIntField(295).Value;
			}
			set
			{
				this.AddIntField(295, value);
			}
		}

		// Token: 0x040003C4 RID: 964
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x040003C5 RID: 965
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
