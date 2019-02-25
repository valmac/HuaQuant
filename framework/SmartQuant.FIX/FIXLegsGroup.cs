using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000D4 RID: 212
	public class FIXLegsGroup : FIXGroup
	{
		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x0002D104 File Offset: 0x0002C104
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x0002D116 File Offset: 0x0002C116
		[FIXField("600", EFieldOption.Optional)]
		public string LegSymbol
		{
			get
			{
				return this.GetStringField(600).Value;
			}
			set
			{
				this.AddStringField(600, value);
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0002D124 File Offset: 0x0002C124
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x0002D136 File Offset: 0x0002C136
		[FIXField("601", EFieldOption.Optional)]
		public string LegSymbolSfx
		{
			get
			{
				return this.GetStringField(601).Value;
			}
			set
			{
				this.AddStringField(601, value);
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0002D144 File Offset: 0x0002C144
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0002D156 File Offset: 0x0002C156
		[FIXField("602", EFieldOption.Optional)]
		public string LegSecurityID
		{
			get
			{
				return this.GetStringField(602).Value;
			}
			set
			{
				this.AddStringField(602, value);
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0002D164 File Offset: 0x0002C164
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x0002D176 File Offset: 0x0002C176
		[FIXField("603", EFieldOption.Optional)]
		public string LegSecurityIDSource
		{
			get
			{
				return this.GetStringField(603).Value;
			}
			set
			{
				this.AddStringField(603, value);
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0002D184 File Offset: 0x0002C184
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x0002D196 File Offset: 0x0002C196
		[FIXField("604", EFieldOption.Optional)]
		public int NoLegSecurityAltID
		{
			get
			{
				return this.GetIntField(604).Value;
			}
			set
			{
				this.AddIntField(604, value);
			}
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x0002D1A4 File Offset: 0x0002C1A4
		public FIXLegSecurityAltIDGroup GetLegSecurityAltIDGroup(int i)
		{
			if (i < this.NoLegSecurityAltID)
			{
				return (FIXLegSecurityAltIDGroup)this.fLegSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0002D1C2 File Offset: 0x0002C1C2
		public void AddGroup(FIXLegSecurityAltIDGroup group)
		{
			this.fLegSecurityAltIDGroup.Add(group);
			this.NoLegSecurityAltID++;
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x0002D1DF File Offset: 0x0002C1DF
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x0002D1F1 File Offset: 0x0002C1F1
		[FIXField("607", EFieldOption.Optional)]
		public int LegProduct
		{
			get
			{
				return this.GetIntField(607).Value;
			}
			set
			{
				this.AddIntField(607, value);
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x0002D1FF File Offset: 0x0002C1FF
		// (set) Token: 0x06002A67 RID: 10855 RVA: 0x0002D211 File Offset: 0x0002C211
		[FIXField("608", EFieldOption.Optional)]
		public string LegCFICode
		{
			get
			{
				return this.GetStringField(608).Value;
			}
			set
			{
				this.AddStringField(608, value);
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x0002D21F File Offset: 0x0002C21F
		// (set) Token: 0x06002A69 RID: 10857 RVA: 0x0002D231 File Offset: 0x0002C231
		[FIXField("609", EFieldOption.Optional)]
		public string LegSecurityType
		{
			get
			{
				return this.GetStringField(609).Value;
			}
			set
			{
				this.AddStringField(609, value);
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x0002D23F File Offset: 0x0002C23F
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x0002D251 File Offset: 0x0002C251
		[FIXField("764", EFieldOption.Optional)]
		public string LegSecuritySubType
		{
			get
			{
				return this.GetStringField(764).Value;
			}
			set
			{
				this.AddStringField(764, value);
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x0002D25F File Offset: 0x0002C25F
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x0002D271 File Offset: 0x0002C271
		[FIXField("610", EFieldOption.Optional)]
		public string LegMaturityMonthYear
		{
			get
			{
				return this.GetStringField(610).Value;
			}
			set
			{
				this.AddStringField(610, value);
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0002D27F File Offset: 0x0002C27F
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x0002D291 File Offset: 0x0002C291
		[FIXField("611", EFieldOption.Optional)]
		public DateTime LegMaturityDate
		{
			get
			{
				return this.GetDateTimeField(611).Value;
			}
			set
			{
				this.AddDateTimeField(611, value);
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x0002D29F File Offset: 0x0002C29F
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x0002D2B1 File Offset: 0x0002C2B1
		[FIXField("248", EFieldOption.Optional)]
		public DateTime LegCouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(248).Value;
			}
			set
			{
				this.AddDateTimeField(248, value);
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x0002D2BF File Offset: 0x0002C2BF
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x0002D2D1 File Offset: 0x0002C2D1
		[FIXField("249", EFieldOption.Optional)]
		public DateTime LegIssueDate
		{
			get
			{
				return this.GetDateTimeField(249).Value;
			}
			set
			{
				this.AddDateTimeField(249, value);
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x0002D2DF File Offset: 0x0002C2DF
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x0002D2F1 File Offset: 0x0002C2F1
		[FIXField("250", EFieldOption.Optional)]
		public int LegRepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(250).Value;
			}
			set
			{
				this.AddIntField(250, value);
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x0002D2FF File Offset: 0x0002C2FF
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x0002D311 File Offset: 0x0002C311
		[FIXField("251", EFieldOption.Optional)]
		public int LegRepurchaseTerm
		{
			get
			{
				return this.GetIntField(251).Value;
			}
			set
			{
				this.AddIntField(251, value);
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x0002D31F File Offset: 0x0002C31F
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x0002D331 File Offset: 0x0002C331
		[FIXField("252", EFieldOption.Optional)]
		public double LegRepurchaseRate
		{
			get
			{
				return this.GetDoubleField(252).Value;
			}
			set
			{
				this.AddDoubleField(252, value);
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x0002D33F File Offset: 0x0002C33F
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x0002D351 File Offset: 0x0002C351
		[FIXField("253", EFieldOption.Optional)]
		public double LegFactor
		{
			get
			{
				return this.GetDoubleField(253).Value;
			}
			set
			{
				this.AddDoubleField(253, value);
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0002D35F File Offset: 0x0002C35F
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x0002D371 File Offset: 0x0002C371
		[FIXField("257", EFieldOption.Optional)]
		public string LegCreditRating
		{
			get
			{
				return this.GetStringField(257).Value;
			}
			set
			{
				this.AddStringField(257, value);
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x0002D37F File Offset: 0x0002C37F
		// (set) Token: 0x06002A7F RID: 10879 RVA: 0x0002D391 File Offset: 0x0002C391
		[FIXField("599", EFieldOption.Optional)]
		public string LegInstrRegistry
		{
			get
			{
				return this.GetStringField(599).Value;
			}
			set
			{
				this.AddStringField(599, value);
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x0002D39F File Offset: 0x0002C39F
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x0002D3B1 File Offset: 0x0002C3B1
		[FIXField("596", EFieldOption.Optional)]
		public string LegCountryOfIssue
		{
			get
			{
				return this.GetStringField(596).Value;
			}
			set
			{
				this.AddStringField(596, value);
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x0002D3BF File Offset: 0x0002C3BF
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x0002D3D1 File Offset: 0x0002C3D1
		[FIXField("597", EFieldOption.Optional)]
		public string LegStateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(597).Value;
			}
			set
			{
				this.AddStringField(597, value);
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x0002D3DF File Offset: 0x0002C3DF
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x0002D3F1 File Offset: 0x0002C3F1
		[FIXField("598", EFieldOption.Optional)]
		public string LegLocaleOfIssue
		{
			get
			{
				return this.GetStringField(598).Value;
			}
			set
			{
				this.AddStringField(598, value);
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x0002D3FF File Offset: 0x0002C3FF
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x0002D411 File Offset: 0x0002C411
		[FIXField("254", EFieldOption.Optional)]
		public DateTime LegRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(254).Value;
			}
			set
			{
				this.AddDateTimeField(254, value);
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x0002D41F File Offset: 0x0002C41F
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x0002D431 File Offset: 0x0002C431
		[FIXField("612", EFieldOption.Optional)]
		public double LegStrikePrice
		{
			get
			{
				return this.GetDoubleField(612).Value;
			}
			set
			{
				this.AddDoubleField(612, value);
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0002D43F File Offset: 0x0002C43F
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x0002D451 File Offset: 0x0002C451
		[FIXField("942", EFieldOption.Optional)]
		public double LegStrikeCurrency
		{
			get
			{
				return this.GetDoubleField(942).Value;
			}
			set
			{
				this.AddDoubleField(942, value);
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x0002D45F File Offset: 0x0002C45F
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x0002D471 File Offset: 0x0002C471
		[FIXField("613", EFieldOption.Optional)]
		public char LegOptAttribute
		{
			get
			{
				return this.GetCharField(613).Value;
			}
			set
			{
				this.AddCharField(613, value);
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x0002D47F File Offset: 0x0002C47F
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x0002D491 File Offset: 0x0002C491
		[FIXField("614", EFieldOption.Optional)]
		public double LegContractMultiplier
		{
			get
			{
				return this.GetDoubleField(614).Value;
			}
			set
			{
				this.AddDoubleField(614, value);
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x0002D49F File Offset: 0x0002C49F
		// (set) Token: 0x06002A91 RID: 10897 RVA: 0x0002D4B1 File Offset: 0x0002C4B1
		[FIXField("615", EFieldOption.Optional)]
		public double LegCouponRate
		{
			get
			{
				return this.GetDoubleField(615).Value;
			}
			set
			{
				this.AddDoubleField(615, value);
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x0002D4BF File Offset: 0x0002C4BF
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x0002D4D1 File Offset: 0x0002C4D1
		[FIXField("616", EFieldOption.Optional)]
		public string LegSecurityExchange
		{
			get
			{
				return this.GetStringField(616).Value;
			}
			set
			{
				this.AddStringField(616, value);
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x0002D4DF File Offset: 0x0002C4DF
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x0002D4F1 File Offset: 0x0002C4F1
		[FIXField("617", EFieldOption.Optional)]
		public string LegIssuer
		{
			get
			{
				return this.GetStringField(617).Value;
			}
			set
			{
				this.AddStringField(617, value);
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0002D4FF File Offset: 0x0002C4FF
		// (set) Token: 0x06002A97 RID: 10903 RVA: 0x0002D511 File Offset: 0x0002C511
		[FIXField("618", EFieldOption.Optional)]
		public int EncodedLegIssuerLen
		{
			get
			{
				return this.GetIntField(618).Value;
			}
			set
			{
				this.AddIntField(618, value);
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x0002D51F File Offset: 0x0002C51F
		// (set) Token: 0x06002A99 RID: 10905 RVA: 0x0002D531 File Offset: 0x0002C531
		[FIXField("619", EFieldOption.Optional)]
		public string EncodedLegIssuer
		{
			get
			{
				return this.GetStringField(619).Value;
			}
			set
			{
				this.AddStringField(619, value);
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x0002D53F File Offset: 0x0002C53F
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x0002D551 File Offset: 0x0002C551
		[FIXField("620", EFieldOption.Optional)]
		public string LegSecurityDesc
		{
			get
			{
				return this.GetStringField(620).Value;
			}
			set
			{
				this.AddStringField(620, value);
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x0002D55F File Offset: 0x0002C55F
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x0002D571 File Offset: 0x0002C571
		[FIXField("621", EFieldOption.Optional)]
		public int EncodedLegSecurityDescLen
		{
			get
			{
				return this.GetIntField(621).Value;
			}
			set
			{
				this.AddIntField(621, value);
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x0002D57F File Offset: 0x0002C57F
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x0002D591 File Offset: 0x0002C591
		[FIXField("622", EFieldOption.Optional)]
		public string EncodedLegSecurityDesc
		{
			get
			{
				return this.GetStringField(622).Value;
			}
			set
			{
				this.AddStringField(622, value);
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x0002D59F File Offset: 0x0002C59F
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x0002D5B1 File Offset: 0x0002C5B1
		[FIXField("623", EFieldOption.Optional)]
		public double LegRatioQty
		{
			get
			{
				return this.GetDoubleField(623).Value;
			}
			set
			{
				this.AddDoubleField(623, value);
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x0002D5BF File Offset: 0x0002C5BF
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x0002D5D1 File Offset: 0x0002C5D1
		[FIXField("624", EFieldOption.Optional)]
		public char LegSide
		{
			get
			{
				return this.GetCharField(624).Value;
			}
			set
			{
				this.AddCharField(624, value);
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x0002D5DF File Offset: 0x0002C5DF
		// (set) Token: 0x06002AA5 RID: 10917 RVA: 0x0002D5F1 File Offset: 0x0002C5F1
		[FIXField("556", EFieldOption.Optional)]
		public double LegCurrency
		{
			get
			{
				return this.GetDoubleField(556).Value;
			}
			set
			{
				this.AddDoubleField(556, value);
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x0002D5FF File Offset: 0x0002C5FF
		// (set) Token: 0x06002AA7 RID: 10919 RVA: 0x0002D611 File Offset: 0x0002C611
		[FIXField("740", EFieldOption.Optional)]
		public string LegPool
		{
			get
			{
				return this.GetStringField(740).Value;
			}
			set
			{
				this.AddStringField(740, value);
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0002D61F File Offset: 0x0002C61F
		// (set) Token: 0x06002AA9 RID: 10921 RVA: 0x0002D631 File Offset: 0x0002C631
		[FIXField("739", EFieldOption.Optional)]
		public DateTime LegDatedDate
		{
			get
			{
				return this.GetDateTimeField(739).Value;
			}
			set
			{
				this.AddDateTimeField(739, value);
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x0002D63F File Offset: 0x0002C63F
		// (set) Token: 0x06002AAB RID: 10923 RVA: 0x0002D651 File Offset: 0x0002C651
		[FIXField("955", EFieldOption.Optional)]
		public string LegContractSettlMonth
		{
			get
			{
				return this.GetStringField(955).Value;
			}
			set
			{
				this.AddStringField(955, value);
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x0002D65F File Offset: 0x0002C65F
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x0002D671 File Offset: 0x0002C671
		[FIXField("956", EFieldOption.Optional)]
		public DateTime LegInterestAccrualDate
		{
			get
			{
				return this.GetDateTimeField(956).Value;
			}
			set
			{
				this.AddDateTimeField(956, value);
			}
		}

		// Token: 0x040003C6 RID: 966
		private ArrayList fLegSecurityAltIDGroup = new ArrayList();
	}
}
