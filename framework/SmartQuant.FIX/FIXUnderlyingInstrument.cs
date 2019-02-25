using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000060 RID: 96
	public class FIXUnderlyingInstrument : FIXMessage
	{
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x00013782 File Offset: 0x00012782
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00013794 File Offset: 0x00012794
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

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x000137A2 File Offset: 0x000127A2
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x000137B4 File Offset: 0x000127B4
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

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x000137C2 File Offset: 0x000127C2
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x000137D4 File Offset: 0x000127D4
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

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x000137E2 File Offset: 0x000127E2
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x000137F4 File Offset: 0x000127F4
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00013802 File Offset: 0x00012802
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x00013814 File Offset: 0x00012814
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

		// Token: 0x0600112C RID: 4396 RVA: 0x00013822 File Offset: 0x00012822
		public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
		{
			if (i < this.NoUnderlyingSecurityAltID)
			{
				return (FIXUnderlyingSecurityAltIDGroup)this.fUnderlyingSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00013840 File Offset: 0x00012840
		public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
		{
			this.fUnderlyingSecurityAltIDGroup.Add(group);
			this.NoUnderlyingSecurityAltID++;
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0001385D File Offset: 0x0001285D
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x0001386F File Offset: 0x0001286F
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

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0001387D File Offset: 0x0001287D
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x0001388F File Offset: 0x0001288F
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

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0001389D File Offset: 0x0001289D
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x000138AF File Offset: 0x000128AF
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

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x000138BD File Offset: 0x000128BD
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x000138CF File Offset: 0x000128CF
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

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x000138DD File Offset: 0x000128DD
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x000138EF File Offset: 0x000128EF
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

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x000138FD File Offset: 0x000128FD
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0001390F File Offset: 0x0001290F
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

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0001391D File Offset: 0x0001291D
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x0001392F File Offset: 0x0001292F
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

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0001393D File Offset: 0x0001293D
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0001394F File Offset: 0x0001294F
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

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0001395D File Offset: 0x0001295D
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0001396F File Offset: 0x0001296F
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

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0001397D File Offset: 0x0001297D
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0001398F File Offset: 0x0001298F
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

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0001399D File Offset: 0x0001299D
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x000139AF File Offset: 0x000129AF
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

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x000139BD File Offset: 0x000129BD
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x000139CF File Offset: 0x000129CF
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

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x000139DD File Offset: 0x000129DD
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x000139EF File Offset: 0x000129EF
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

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x000139FD File Offset: 0x000129FD
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00013A0F File Offset: 0x00012A0F
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

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00013A1D File Offset: 0x00012A1D
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00013A2F File Offset: 0x00012A2F
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

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00013A3D File Offset: 0x00012A3D
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00013A4F File Offset: 0x00012A4F
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

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00013A5D File Offset: 0x00012A5D
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00013A6F File Offset: 0x00012A6F
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00013A7D File Offset: 0x00012A7D
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00013A8F File Offset: 0x00012A8F
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

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00013A9D File Offset: 0x00012A9D
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00013AAF File Offset: 0x00012AAF
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

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00013ABD File Offset: 0x00012ABD
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00013ACF File Offset: 0x00012ACF
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

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00013ADD File Offset: 0x00012ADD
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00013AEF File Offset: 0x00012AEF
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

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00013AFD File Offset: 0x00012AFD
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00013B0F File Offset: 0x00012B0F
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

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00013B1D File Offset: 0x00012B1D
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00013B2F File Offset: 0x00012B2F
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

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00013B3D File Offset: 0x00012B3D
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x00013B4F File Offset: 0x00012B4F
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

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00013B5D File Offset: 0x00012B5D
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00013B6F File Offset: 0x00012B6F
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

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00013B7D File Offset: 0x00012B7D
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x00013B8F File Offset: 0x00012B8F
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

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00013B9D File Offset: 0x00012B9D
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00013BAF File Offset: 0x00012BAF
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00013BBD File Offset: 0x00012BBD
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00013BCF File Offset: 0x00012BCF
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

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00013BDD File Offset: 0x00012BDD
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00013BEF File Offset: 0x00012BEF
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

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00013BFD File Offset: 0x00012BFD
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00013C0F File Offset: 0x00012C0F
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00013C1D File Offset: 0x00012C1D
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00013C2F File Offset: 0x00012C2F
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

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00013C3D File Offset: 0x00012C3D
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00013C4F File Offset: 0x00012C4F
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

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00013C5D File Offset: 0x00012C5D
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00013C6F File Offset: 0x00012C6F
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

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00013C7D File Offset: 0x00012C7D
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00013C8F File Offset: 0x00012C8F
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

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x00013C9D File Offset: 0x00012C9D
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00013CAF File Offset: 0x00012CAF
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

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00013CBD File Offset: 0x00012CBD
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00013CCF File Offset: 0x00012CCF
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

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x00013CDD File Offset: 0x00012CDD
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x00013CEF File Offset: 0x00012CEF
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

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x00013CFD File Offset: 0x00012CFD
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x00013D0F File Offset: 0x00012D0F
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00013D1D File Offset: 0x00012D1D
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x00013D2F File Offset: 0x00012D2F
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

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00013D3D File Offset: 0x00012D3D
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00013D4F File Offset: 0x00012D4F
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

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00013D5D File Offset: 0x00012D5D
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00013D6F File Offset: 0x00012D6F
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

		// Token: 0x06001180 RID: 4480 RVA: 0x00013D7D File Offset: 0x00012D7D
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00013D9B File Offset: 0x00012D9B
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x04000247 RID: 583
		private ArrayList fUnderlyingSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000248 RID: 584
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
