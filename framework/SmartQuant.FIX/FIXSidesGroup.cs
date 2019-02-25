using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200009E RID: 158
	public class FIXSidesGroup : FIXGroup
	{
		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00023ACE File Offset: 0x00022ACE
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x00023ADD File Offset: 0x00022ADD
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

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00023AE8 File Offset: 0x00022AE8
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x00023AF7 File Offset: 0x00022AF7
		[FIXField("37", EFieldOption.Required)]
		public string OrderID
		{
			get
			{
				return this.GetStringField(37).Value;
			}
			set
			{
				this.AddStringField(37, value);
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00023B02 File Offset: 0x00022B02
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x00023B14 File Offset: 0x00022B14
		[FIXField("198", EFieldOption.Optional)]
		public string SecondaryOrderID
		{
			get
			{
				return this.GetStringField(198).Value;
			}
			set
			{
				this.AddStringField(198, value);
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00023B22 File Offset: 0x00022B22
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x00023B31 File Offset: 0x00022B31
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

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00023B3C File Offset: 0x00022B3C
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x00023B4E File Offset: 0x00022B4E
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringField(526).Value;
			}
			set
			{
				this.AddStringField(526, value);
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00023B5C File Offset: 0x00022B5C
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x00023B6B File Offset: 0x00022B6B
		[FIXField("66", EFieldOption.Optional)]
		public string ListID
		{
			get
			{
				return this.GetStringField(66).Value;
			}
			set
			{
				this.AddStringField(66, value);
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x00023B76 File Offset: 0x00022B76
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x00023B88 File Offset: 0x00022B88
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntField(453).Value;
			}
			set
			{
				this.AddIntField(453, value);
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00023B96 File Offset: 0x00022B96
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00023BB4 File Offset: 0x00022BB4
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00023BD1 File Offset: 0x00022BD1
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x00023BDF File Offset: 0x00022BDF
		[FIXField("1", EFieldOption.Optional)]
		public string Account
		{
			get
			{
				return this.GetStringField(1).Value;
			}
			set
			{
				this.AddStringField(1, value);
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x00023BE9 File Offset: 0x00022BE9
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x00023BFB File Offset: 0x00022BFB
		[FIXField("660", EFieldOption.Optional)]
		public int AcctIDSource
		{
			get
			{
				return this.GetIntField(660).Value;
			}
			set
			{
				this.AddIntField(660, value);
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00023C09 File Offset: 0x00022C09
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x00023C1B File Offset: 0x00022C1B
		[FIXField("581", EFieldOption.Optional)]
		public int AccountType
		{
			get
			{
				return this.GetIntField(581).Value;
			}
			set
			{
				this.AddIntField(581, value);
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00023C29 File Offset: 0x00022C29
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00023C38 File Offset: 0x00022C38
		[FIXField("81", EFieldOption.Optional)]
		public char ProcessCode
		{
			get
			{
				return this.GetCharField(81).Value;
			}
			set
			{
				this.AddCharField(81, value);
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x00023C43 File Offset: 0x00022C43
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x00023C55 File Offset: 0x00022C55
		[FIXField("575", EFieldOption.Optional)]
		public bool OddLot
		{
			get
			{
				return this.GetBoolField(575).Value;
			}
			set
			{
				this.AddBoolField(575, value);
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x00023C63 File Offset: 0x00022C63
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x00023C75 File Offset: 0x00022C75
		[FIXField("576", EFieldOption.Optional)]
		public int NoClearingInstructions
		{
			get
			{
				return this.GetIntField(576).Value;
			}
			set
			{
				this.AddIntField(576, value);
			}
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00023C83 File Offset: 0x00022C83
		public FIXClearingInstructionsGroup GetClearingInstructionsGroup(int i)
		{
			if (i < this.NoClearingInstructions)
			{
				return (FIXClearingInstructionsGroup)this.fClearingInstructionsGroup[i];
			}
			return null;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00023CA1 File Offset: 0x00022CA1
		public void AddGroup(FIXClearingInstructionsGroup group)
		{
			this.fClearingInstructionsGroup.Add(group);
			this.NoClearingInstructions++;
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x00023CBE File Offset: 0x00022CBE
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x00023CD0 File Offset: 0x00022CD0
		[FIXField("635", EFieldOption.Optional)]
		public string ClearingFeeIndicator
		{
			get
			{
				return this.GetStringField(635).Value;
			}
			set
			{
				this.AddStringField(635, value);
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00023CDE File Offset: 0x00022CDE
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00023CF0 File Offset: 0x00022CF0
		[FIXField("578", EFieldOption.Optional)]
		public string TradeInputSource
		{
			get
			{
				return this.GetStringField(578).Value;
			}
			set
			{
				this.AddStringField(578, value);
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x00023CFE File Offset: 0x00022CFE
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x00023D10 File Offset: 0x00022D10
		[FIXField("579", EFieldOption.Optional)]
		public string TradeInputDevice
		{
			get
			{
				return this.GetStringField(579).Value;
			}
			set
			{
				this.AddStringField(579, value);
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x00023D1E File Offset: 0x00022D1E
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x00023D30 File Offset: 0x00022D30
		[FIXField("821", EFieldOption.Optional)]
		public string OrderInputDevice
		{
			get
			{
				return this.GetStringField(821).Value;
			}
			set
			{
				this.AddStringField(821, value);
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x00023D3E File Offset: 0x00022D3E
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x00023D4D File Offset: 0x00022D4D
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

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x00023D58 File Offset: 0x00022D58
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x00023D6A File Offset: 0x00022D6A
		[FIXField("376", EFieldOption.Optional)]
		public string ComplianceID
		{
			get
			{
				return this.GetStringField(376).Value;
			}
			set
			{
				this.AddStringField(376, value);
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x00023D78 File Offset: 0x00022D78
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x00023D8A File Offset: 0x00022D8A
		[FIXField("377", EFieldOption.Optional)]
		public bool SolicitedFlag
		{
			get
			{
				return this.GetBoolField(377).Value;
			}
			set
			{
				this.AddBoolField(377, value);
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x00023D98 File Offset: 0x00022D98
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x00023DAA File Offset: 0x00022DAA
		[FIXField("528", EFieldOption.Optional)]
		public char OrderCapacity
		{
			get
			{
				return this.GetCharField(528).Value;
			}
			set
			{
				this.AddCharField(528, value);
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x00023DB8 File Offset: 0x00022DB8
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x00023DCA File Offset: 0x00022DCA
		[FIXField("529", EFieldOption.Optional)]
		public string OrderRestrictions
		{
			get
			{
				return this.GetStringField(529).Value;
			}
			set
			{
				this.AddStringField(529, value);
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x00023DD8 File Offset: 0x00022DD8
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x00023DEA File Offset: 0x00022DEA
		[FIXField("582", EFieldOption.Optional)]
		public int CustOrderCapacity
		{
			get
			{
				return this.GetIntField(582).Value;
			}
			set
			{
				this.AddIntField(582, value);
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x00023DF8 File Offset: 0x00022DF8
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x00023E07 File Offset: 0x00022E07
		[FIXField("40", EFieldOption.Optional)]
		public char OrdType
		{
			get
			{
				return this.GetCharField(40).Value;
			}
			set
			{
				this.AddCharField(40, value);
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x00023E12 File Offset: 0x00022E12
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x00023E21 File Offset: 0x00022E21
		[FIXField("18", EFieldOption.Optional)]
		public string ExecInst
		{
			get
			{
				return this.GetStringField(18).Value;
			}
			set
			{
				this.AddStringField(18, value);
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x00023E2C File Offset: 0x00022E2C
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x00023E3E File Offset: 0x00022E3E
		[FIXField("483", EFieldOption.Optional)]
		public DateTime TransBkdTime
		{
			get
			{
				return this.GetDateTimeField(483).Value;
			}
			set
			{
				this.AddDateTimeField(483, value);
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x00023E4C File Offset: 0x00022E4C
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x00023E5E File Offset: 0x00022E5E
		[FIXField("336", EFieldOption.Optional)]
		public string TradingSessionID
		{
			get
			{
				return this.GetStringField(336).Value;
			}
			set
			{
				this.AddStringField(336, value);
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x00023E6C File Offset: 0x00022E6C
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x00023E7E File Offset: 0x00022E7E
		[FIXField("625", EFieldOption.Optional)]
		public string TradingSessionSubID
		{
			get
			{
				return this.GetStringField(625).Value;
			}
			set
			{
				this.AddStringField(625, value);
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x00023E8C File Offset: 0x00022E8C
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x00023E9E File Offset: 0x00022E9E
		[FIXField("943", EFieldOption.Optional)]
		public string TimeBracket
		{
			get
			{
				return this.GetStringField(943).Value;
			}
			set
			{
				this.AddStringField(943, value);
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x00023EAC File Offset: 0x00022EAC
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x00023EBB File Offset: 0x00022EBB
		[FIXField("12", EFieldOption.Optional)]
		public double Commission
		{
			get
			{
				return this.GetDoubleField(12).Value;
			}
			set
			{
				this.AddDoubleField(12, value);
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x00023EC6 File Offset: 0x00022EC6
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x00023ED5 File Offset: 0x00022ED5
		[FIXField("13", EFieldOption.Optional)]
		public char CommType
		{
			get
			{
				return this.GetCharField(13).Value;
			}
			set
			{
				this.AddCharField(13, value);
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x00023EE0 File Offset: 0x00022EE0
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x00023EF2 File Offset: 0x00022EF2
		[FIXField("479", EFieldOption.Optional)]
		public double CommCurrency
		{
			get
			{
				return this.GetDoubleField(479).Value;
			}
			set
			{
				this.AddDoubleField(479, value);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x00023F00 File Offset: 0x00022F00
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x00023F12 File Offset: 0x00022F12
		[FIXField("497", EFieldOption.Optional)]
		public char FundRenewWaiv
		{
			get
			{
				return this.GetCharField(497).Value;
			}
			set
			{
				this.AddCharField(497, value);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x00023F20 File Offset: 0x00022F20
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x00023F32 File Offset: 0x00022F32
		[FIXField("381", EFieldOption.Optional)]
		public double GrossTradeAmt
		{
			get
			{
				return this.GetDoubleField(381).Value;
			}
			set
			{
				this.AddDoubleField(381, value);
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00023F40 File Offset: 0x00022F40
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x00023F52 File Offset: 0x00022F52
		[FIXField("157", EFieldOption.Optional)]
		public int NumDaysInterest
		{
			get
			{
				return this.GetIntField(157).Value;
			}
			set
			{
				this.AddIntField(157, value);
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00023F60 File Offset: 0x00022F60
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x00023F72 File Offset: 0x00022F72
		[FIXField("230", EFieldOption.Optional)]
		public DateTime ExDate
		{
			get
			{
				return this.GetDateTimeField(230).Value;
			}
			set
			{
				this.AddDateTimeField(230, value);
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x00023F80 File Offset: 0x00022F80
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00023F92 File Offset: 0x00022F92
		[FIXField("158", EFieldOption.Optional)]
		public double AccruedInterestRate
		{
			get
			{
				return this.GetDoubleField(158).Value;
			}
			set
			{
				this.AddDoubleField(158, value);
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x00023FA0 File Offset: 0x00022FA0
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00023FB2 File Offset: 0x00022FB2
		[FIXField("159", EFieldOption.Optional)]
		public double AccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(159).Value;
			}
			set
			{
				this.AddDoubleField(159, value);
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x00023FC0 File Offset: 0x00022FC0
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00023FD2 File Offset: 0x00022FD2
		[FIXField("738", EFieldOption.Optional)]
		public double InterestAtMaturity
		{
			get
			{
				return this.GetDoubleField(738).Value;
			}
			set
			{
				this.AddDoubleField(738, value);
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x00023FE0 File Offset: 0x00022FE0
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x00023FF2 File Offset: 0x00022FF2
		[FIXField("920", EFieldOption.Optional)]
		public double EndAccruedInterestAmt
		{
			get
			{
				return this.GetDoubleField(920).Value;
			}
			set
			{
				this.AddDoubleField(920, value);
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00024000 File Offset: 0x00023000
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x00024012 File Offset: 0x00023012
		[FIXField("921", EFieldOption.Optional)]
		public double StartCash
		{
			get
			{
				return this.GetDoubleField(921).Value;
			}
			set
			{
				this.AddDoubleField(921, value);
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x00024020 File Offset: 0x00023020
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x00024032 File Offset: 0x00023032
		[FIXField("922", EFieldOption.Optional)]
		public double EndCash
		{
			get
			{
				return this.GetDoubleField(922).Value;
			}
			set
			{
				this.AddDoubleField(922, value);
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00024040 File Offset: 0x00023040
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x00024052 File Offset: 0x00023052
		[FIXField("238", EFieldOption.Optional)]
		public double Concession
		{
			get
			{
				return this.GetDoubleField(238).Value;
			}
			set
			{
				this.AddDoubleField(238, value);
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x00024060 File Offset: 0x00023060
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x00024072 File Offset: 0x00023072
		[FIXField("237", EFieldOption.Optional)]
		public double TotalTakedown
		{
			get
			{
				return this.GetDoubleField(237).Value;
			}
			set
			{
				this.AddDoubleField(237, value);
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x00024080 File Offset: 0x00023080
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x0002408F File Offset: 0x0002308F
		[FIXField("118", EFieldOption.Optional)]
		public double NetMoney
		{
			get
			{
				return this.GetDoubleField(118).Value;
			}
			set
			{
				this.AddDoubleField(118, value);
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x0002409A File Offset: 0x0002309A
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x000240A9 File Offset: 0x000230A9
		[FIXField("119", EFieldOption.Optional)]
		public double SettlCurrAmt
		{
			get
			{
				return this.GetDoubleField(119).Value;
			}
			set
			{
				this.AddDoubleField(119, value);
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000240B4 File Offset: 0x000230B4
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x000240C3 File Offset: 0x000230C3
		[FIXField("120", EFieldOption.Optional)]
		public double SettlCurrency
		{
			get
			{
				return this.GetDoubleField(120).Value;
			}
			set
			{
				this.AddDoubleField(120, value);
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000240CE File Offset: 0x000230CE
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x000240E0 File Offset: 0x000230E0
		[FIXField("155", EFieldOption.Optional)]
		public double SettlCurrFxRate
		{
			get
			{
				return this.GetDoubleField(155).Value;
			}
			set
			{
				this.AddDoubleField(155, value);
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000240EE File Offset: 0x000230EE
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x00024100 File Offset: 0x00023100
		[FIXField("156", EFieldOption.Optional)]
		public char SettlCurrFxRateCalc
		{
			get
			{
				return this.GetCharField(156).Value;
			}
			set
			{
				this.AddCharField(156, value);
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0002410E File Offset: 0x0002310E
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x0002411D File Offset: 0x0002311D
		[FIXField("77", EFieldOption.Optional)]
		public char PositionEffect
		{
			get
			{
				return this.GetCharField(77).Value;
			}
			set
			{
				this.AddCharField(77, value);
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00024128 File Offset: 0x00023128
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x00024137 File Offset: 0x00023137
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

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x00024142 File Offset: 0x00023142
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x00024154 File Offset: 0x00023154
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

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00024162 File Offset: 0x00023162
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x00024174 File Offset: 0x00023174
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

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00024182 File Offset: 0x00023182
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x00024194 File Offset: 0x00023194
		[FIXField("752", EFieldOption.Optional)]
		public int SideMultiLegReportingType
		{
			get
			{
				return this.GetIntField(752).Value;
			}
			set
			{
				this.AddIntField(752, value);
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000241A2 File Offset: 0x000231A2
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x000241B4 File Offset: 0x000231B4
		[FIXField("518", EFieldOption.Optional)]
		public int NoContAmts
		{
			get
			{
				return this.GetIntField(518).Value;
			}
			set
			{
				this.AddIntField(518, value);
			}
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000241C2 File Offset: 0x000231C2
		public FIXContAmtsGroup GetContAmtsGroup(int i)
		{
			if (i < this.NoContAmts)
			{
				return (FIXContAmtsGroup)this.fContAmtsGroup[i];
			}
			return null;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000241E0 File Offset: 0x000231E0
		public void AddGroup(FIXContAmtsGroup group)
		{
			this.fContAmtsGroup.Add(group);
			this.NoContAmts++;
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000241FD File Offset: 0x000231FD
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0002420F File Offset: 0x0002320F
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

		// Token: 0x060021B6 RID: 8630 RVA: 0x0002421D File Offset: 0x0002321D
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0002423B File Offset: 0x0002323B
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00024258 File Offset: 0x00023258
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x0002426A File Offset: 0x0002326A
		[FIXField("136", EFieldOption.Optional)]
		public int NoMiscFees
		{
			get
			{
				return this.GetIntField(136).Value;
			}
			set
			{
				this.AddIntField(136, value);
			}
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00024278 File Offset: 0x00023278
		public FIXMiscFeesGroup GetMiscFeesGroup(int i)
		{
			if (i < this.NoMiscFees)
			{
				return (FIXMiscFeesGroup)this.fMiscFeesGroup[i];
			}
			return null;
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00024296 File Offset: 0x00023296
		public void AddGroup(FIXMiscFeesGroup group)
		{
			this.fMiscFeesGroup.Add(group);
			this.NoMiscFees++;
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000242B3 File Offset: 0x000232B3
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x000242C5 File Offset: 0x000232C5
		[FIXField("825", EFieldOption.Optional)]
		public string ExchangeRule
		{
			get
			{
				return this.GetStringField(825).Value;
			}
			set
			{
				this.AddStringField(825, value);
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000242D3 File Offset: 0x000232D3
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x000242E5 File Offset: 0x000232E5
		[FIXField("826", EFieldOption.Optional)]
		public int TradeAllocIndicator
		{
			get
			{
				return this.GetIntField(826).Value;
			}
			set
			{
				this.AddIntField(826, value);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x000242F3 File Offset: 0x000232F3
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x00024305 File Offset: 0x00023305
		[FIXField("591", EFieldOption.Optional)]
		public char PreallocMethod
		{
			get
			{
				return this.GetCharField(591).Value;
			}
			set
			{
				this.AddCharField(591, value);
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00024313 File Offset: 0x00023313
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x00024322 File Offset: 0x00023322
		[FIXField("70", EFieldOption.Optional)]
		public string AllocID
		{
			get
			{
				return this.GetStringField(70).Value;
			}
			set
			{
				this.AddStringField(70, value);
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0002432D File Offset: 0x0002332D
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x0002433C File Offset: 0x0002333C
		[FIXField("78", EFieldOption.Optional)]
		public int NoAllocs
		{
			get
			{
				return this.GetIntField(78).Value;
			}
			set
			{
				this.AddIntField(78, value);
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00024347 File Offset: 0x00023347
		public FIXAllocsGroup GetAllocsGroup(int i)
		{
			if (i < this.NoAllocs)
			{
				return (FIXAllocsGroup)this.fAllocsGroup[i];
			}
			return null;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00024365 File Offset: 0x00023365
		public void AddGroup(FIXAllocsGroup group)
		{
			this.fAllocsGroup.Add(group);
			this.NoAllocs++;
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00024384 File Offset: 0x00023384
		public FIXSidesGroup()
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000243DC File Offset: 0x000233DC
		public FIXSidesGroup(char Side, string OrderID)
		{
			this.Side = Side;
			this.OrderID = OrderID;
		}

		// Token: 0x0400030F RID: 783
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000310 RID: 784
		private ArrayList fClearingInstructionsGroup = new ArrayList();

		// Token: 0x04000311 RID: 785
		private ArrayList fContAmtsGroup = new ArrayList();

		// Token: 0x04000312 RID: 786
		private ArrayList fStipulationsGroup = new ArrayList();

		// Token: 0x04000313 RID: 787
		private ArrayList fMiscFeesGroup = new ArrayList();

		// Token: 0x04000314 RID: 788
		private ArrayList fAllocsGroup = new ArrayList();
	}
}
