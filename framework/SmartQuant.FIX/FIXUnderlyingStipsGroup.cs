using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200013A RID: 314
	public class FIXUnderlyingStipsGroup : FIXGroup
	{
		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x0004016E File Offset: 0x0003F16E
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x00040180 File Offset: 0x0003F180
		[FIXField("888", EFieldOption.Optional)]
		public string UnderlyingStipType
		{
			get
			{
				return this.GetStringField(888).Value;
			}
			set
			{
				this.AddStringField(888, value);
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x0004018E File Offset: 0x0003F18E
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x000401A0 File Offset: 0x0003F1A0
		[FIXField("889", EFieldOption.Optional)]
		public string UnderlyingStipValue
		{
			get
			{
				return this.GetStringField(889).Value;
			}
			set
			{
				this.AddStringField(889, value);
			}
		}
	}
}
