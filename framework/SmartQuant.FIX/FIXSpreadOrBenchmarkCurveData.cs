using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200004F RID: 79
	public class FIXSpreadOrBenchmarkCurveData : FIXMessage
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00012624 File Offset: 0x00011624
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00012636 File Offset: 0x00011636
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00012644 File Offset: 0x00011644
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00012656 File Offset: 0x00011656
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00012664 File Offset: 0x00011664
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00012676 File Offset: 0x00011676
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00012684 File Offset: 0x00011684
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00012696 File Offset: 0x00011696
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

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000126A4 File Offset: 0x000116A4
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x000126B6 File Offset: 0x000116B6
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

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x000126C4 File Offset: 0x000116C4
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x000126D6 File Offset: 0x000116D6
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x000126E4 File Offset: 0x000116E4
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x000126F6 File Offset: 0x000116F6
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

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00012704 File Offset: 0x00011704
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00012716 File Offset: 0x00011716
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
	}
}
