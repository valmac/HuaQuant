using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200005E RID: 94
	public class FIXYieldData : FIXMessage
	{
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x0001369A File Offset: 0x0001269A
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x000136AC File Offset: 0x000126AC
		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringField(235).Value;
			}
			set
			{
				this.AddStringField(235, value);
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x000136BA File Offset: 0x000126BA
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x000136CC File Offset: 0x000126CC
		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleField(236).Value;
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x000136DA File Offset: 0x000126DA
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x000136EC File Offset: 0x000126EC
		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeField(701).Value;
			}
			set
			{
				this.AddDateTimeField(701, value);
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x000136FA File Offset: 0x000126FA
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x0001370C File Offset: 0x0001270C
		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(696).Value;
			}
			set
			{
				this.AddDateTimeField(696, value);
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0001371A File Offset: 0x0001271A
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x0001372C File Offset: 0x0001272C
		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleField(697).Value;
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0001373A File Offset: 0x0001273A
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x0001374C File Offset: 0x0001274C
		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntField(698).Value;
			}
			set
			{
				this.AddIntField(698, value);
			}
		}
	}
}
