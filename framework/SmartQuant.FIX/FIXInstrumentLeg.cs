using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200006A RID: 106
	public class FIXInstrumentLeg : FIXMessage
	{
		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x000156D3 File Offset: 0x000146D3
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x000156E5 File Offset: 0x000146E5
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

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x000156F3 File Offset: 0x000146F3
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x00015705 File Offset: 0x00014705
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00015713 File Offset: 0x00014713
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x00015725 File Offset: 0x00014725
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

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00015733 File Offset: 0x00014733
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x00015745 File Offset: 0x00014745
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

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00015753 File Offset: 0x00014753
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x00015765 File Offset: 0x00014765
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

		// Token: 0x06001311 RID: 4881 RVA: 0x00015773 File Offset: 0x00014773
		public FIXLegSecurityAltIDGroup GetLegSecurityAltIDGroup(int i)
		{
			if (i < this.NoLegSecurityAltID)
			{
				return (FIXLegSecurityAltIDGroup)this.fLegSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00015791 File Offset: 0x00014791
		public void AddGroup(FIXLegSecurityAltIDGroup group)
		{
			this.fLegSecurityAltIDGroup.Add(group);
			this.NoLegSecurityAltID++;
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000157AE File Offset: 0x000147AE
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x000157C0 File Offset: 0x000147C0
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x000157CE File Offset: 0x000147CE
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x000157E0 File Offset: 0x000147E0
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x000157EE File Offset: 0x000147EE
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x00015800 File Offset: 0x00014800
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0001580E File Offset: 0x0001480E
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x00015820 File Offset: 0x00014820
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

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0001582E File Offset: 0x0001482E
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00015840 File Offset: 0x00014840
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

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0001584E File Offset: 0x0001484E
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00015860 File Offset: 0x00014860
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

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0001586E File Offset: 0x0001486E
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x00015880 File Offset: 0x00014880
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

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x0001588E File Offset: 0x0001488E
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x000158A0 File Offset: 0x000148A0
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

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x000158AE File Offset: 0x000148AE
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x000158C0 File Offset: 0x000148C0
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

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000158CE File Offset: 0x000148CE
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x000158E0 File Offset: 0x000148E0
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

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x000158EE File Offset: 0x000148EE
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x00015900 File Offset: 0x00014900
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

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x0001590E File Offset: 0x0001490E
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x00015920 File Offset: 0x00014920
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0001592E File Offset: 0x0001492E
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00015940 File Offset: 0x00014940
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0001594E File Offset: 0x0001494E
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00015960 File Offset: 0x00014960
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

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0001596E File Offset: 0x0001496E
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00015980 File Offset: 0x00014980
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

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0001598E File Offset: 0x0001498E
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000159A0 File Offset: 0x000149A0
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

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000159AE File Offset: 0x000149AE
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000159C0 File Offset: 0x000149C0
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000159CE File Offset: 0x000149CE
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000159E0 File Offset: 0x000149E0
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x000159EE File Offset: 0x000149EE
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00015A00 File Offset: 0x00014A00
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

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00015A0E File Offset: 0x00014A0E
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00015A20 File Offset: 0x00014A20
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

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00015A2E File Offset: 0x00014A2E
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00015A40 File Offset: 0x00014A40
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

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00015A4E File Offset: 0x00014A4E
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x00015A60 File Offset: 0x00014A60
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

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00015A6E File Offset: 0x00014A6E
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x00015A80 File Offset: 0x00014A80
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

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00015A8E File Offset: 0x00014A8E
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x00015AA0 File Offset: 0x00014AA0
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

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00015AAE File Offset: 0x00014AAE
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x00015AC0 File Offset: 0x00014AC0
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

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00015ACE File Offset: 0x00014ACE
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x00015AE0 File Offset: 0x00014AE0
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

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00015AEE File Offset: 0x00014AEE
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00015B00 File Offset: 0x00014B00
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

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00015B0E File Offset: 0x00014B0E
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00015B20 File Offset: 0x00014B20
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

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00015B2E File Offset: 0x00014B2E
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x00015B40 File Offset: 0x00014B40
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

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00015B4E File Offset: 0x00014B4E
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x00015B60 File Offset: 0x00014B60
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

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00015B6E File Offset: 0x00014B6E
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x00015B80 File Offset: 0x00014B80
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

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00015B8E File Offset: 0x00014B8E
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x00015BA0 File Offset: 0x00014BA0
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

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00015BAE File Offset: 0x00014BAE
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00015BC0 File Offset: 0x00014BC0
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

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00015BCE File Offset: 0x00014BCE
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00015BE0 File Offset: 0x00014BE0
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

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00015BEE File Offset: 0x00014BEE
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00015C00 File Offset: 0x00014C00
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

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00015C0E File Offset: 0x00014C0E
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00015C20 File Offset: 0x00014C20
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

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00015C2E File Offset: 0x00014C2E
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x00015C40 File Offset: 0x00014C40
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

		// Token: 0x0400025B RID: 603
		private ArrayList fLegSecurityAltIDGroup = new ArrayList();
	}
}
