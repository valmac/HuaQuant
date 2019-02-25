using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000083 RID: 131
	public class FIXFinancingDetails : FIXMessage
	{
		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x0001BA85 File Offset: 0x0001AA85
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x0001BA97 File Offset: 0x0001AA97
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

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x0001BAA5 File Offset: 0x0001AAA5
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x0001BAB7 File Offset: 0x0001AAB7
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

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x0001BAC5 File Offset: 0x0001AAC5
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x0001BAD7 File Offset: 0x0001AAD7
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

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x0001BAE5 File Offset: 0x0001AAE5
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x0001BAF7 File Offset: 0x0001AAF7
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

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x0001BB05 File Offset: 0x0001AB05
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x0001BB17 File Offset: 0x0001AB17
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

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x0001BB25 File Offset: 0x0001AB25
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0001BB37 File Offset: 0x0001AB37
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

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x0001BB45 File Offset: 0x0001AB45
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0001BB57 File Offset: 0x0001AB57
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x0001BB65 File Offset: 0x0001AB65
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x0001BB77 File Offset: 0x0001AB77
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

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x0001BB85 File Offset: 0x0001AB85
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x0001BB97 File Offset: 0x0001AB97
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
	}
}
