using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000B2 RID: 178
	public class FIXLegBenchmarkCurveData : FIXMessage
	{
		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x00028002 File Offset: 0x00027002
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x00028014 File Offset: 0x00027014
		[FIXField("676", EFieldOption.Optional)]
		public double LegBenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleField(676).Value;
			}
			set
			{
				this.AddDoubleField(676, value);
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x00028022 File Offset: 0x00027022
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x00028034 File Offset: 0x00027034
		[FIXField("677", EFieldOption.Optional)]
		public string LegBenchmarkCurveName
		{
			get
			{
				return this.GetStringField(677).Value;
			}
			set
			{
				this.AddStringField(677, value);
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x00028042 File Offset: 0x00027042
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x00028054 File Offset: 0x00027054
		[FIXField("678", EFieldOption.Optional)]
		public string LegBenchmarkCurvePoint
		{
			get
			{
				return this.GetStringField(678).Value;
			}
			set
			{
				this.AddStringField(678, value);
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x00028062 File Offset: 0x00027062
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x00028074 File Offset: 0x00027074
		[FIXField("679", EFieldOption.Optional)]
		public double LegBenchmarkPrice
		{
			get
			{
				return this.GetDoubleField(679).Value;
			}
			set
			{
				this.AddDoubleField(679, value);
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00028082 File Offset: 0x00027082
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x00028094 File Offset: 0x00027094
		[FIXField("680", EFieldOption.Optional)]
		public int LegBenchmarkPriceType
		{
			get
			{
				return this.GetIntField(680).Value;
			}
			set
			{
				this.AddIntField(680, value);
			}
		}
	}
}
