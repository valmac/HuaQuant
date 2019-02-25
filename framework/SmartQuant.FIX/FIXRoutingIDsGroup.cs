using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200013C RID: 316
	public class FIXRoutingIDsGroup : FIXGroup
	{
		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x0004080A File Offset: 0x0003F80A
		// (set) Token: 0x06003D36 RID: 15670 RVA: 0x0004081C File Offset: 0x0003F81C
		[FIXField("216", EFieldOption.Optional)]
		public int RoutingType
		{
			get
			{
				return this.GetIntField(216).Value;
			}
			set
			{
				this.AddIntField(216, value);
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x0004082A File Offset: 0x0003F82A
		// (set) Token: 0x06003D38 RID: 15672 RVA: 0x0004083C File Offset: 0x0003F83C
		[FIXField("217", EFieldOption.Optional)]
		public string RoutingID
		{
			get
			{
				return this.GetStringField(217).Value;
			}
			set
			{
				this.AddStringField(217, value);
			}
		}
	}
}
