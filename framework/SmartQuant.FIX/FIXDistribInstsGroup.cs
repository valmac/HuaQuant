using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000040 RID: 64
	public class FIXDistribInstsGroup : FIXGroup
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00011C39 File Offset: 0x00010C39
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00011C4B File Offset: 0x00010C4B
		[FIXField("477", EFieldOption.Optional)]
		public int DistribPaymentMethod
		{
			get
			{
				return this.GetIntField(477).Value;
			}
			set
			{
				this.AddIntField(477, value);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00011C59 File Offset: 0x00010C59
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00011C6B File Offset: 0x00010C6B
		[FIXField("512", EFieldOption.Optional)]
		public double DistribPercentage
		{
			get
			{
				return this.GetDoubleField(512).Value;
			}
			set
			{
				this.AddDoubleField(512, value);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00011C79 File Offset: 0x00010C79
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00011C8B File Offset: 0x00010C8B
		[FIXField("478", EFieldOption.Optional)]
		public double CashDistribCurr
		{
			get
			{
				return this.GetDoubleField(478).Value;
			}
			set
			{
				this.AddDoubleField(478, value);
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00011C99 File Offset: 0x00010C99
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00011CAB File Offset: 0x00010CAB
		[FIXField("498", EFieldOption.Optional)]
		public string CashDistribAgentName
		{
			get
			{
				return this.GetStringField(498).Value;
			}
			set
			{
				this.AddStringField(498, value);
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00011CB9 File Offset: 0x00010CB9
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00011CCB File Offset: 0x00010CCB
		[FIXField("499", EFieldOption.Optional)]
		public string CashDistribAgentCode
		{
			get
			{
				return this.GetStringField(499).Value;
			}
			set
			{
				this.AddStringField(499, value);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00011CD9 File Offset: 0x00010CD9
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00011CEB File Offset: 0x00010CEB
		[FIXField("500", EFieldOption.Optional)]
		public string CashDistribAgentAcctNumber
		{
			get
			{
				return this.GetStringField(500).Value;
			}
			set
			{
				this.AddStringField(500, value);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00011CF9 File Offset: 0x00010CF9
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00011D0B File Offset: 0x00010D0B
		[FIXField("501", EFieldOption.Optional)]
		public string CashDistribPayRef
		{
			get
			{
				return this.GetStringField(501).Value;
			}
			set
			{
				this.AddStringField(501, value);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00011D19 File Offset: 0x00010D19
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00011D2B File Offset: 0x00010D2B
		[FIXField("502", EFieldOption.Optional)]
		public string CashDistribAgentAcctName
		{
			get
			{
				return this.GetStringField(502).Value;
			}
			set
			{
				this.AddStringField(502, value);
			}
		}
	}
}
