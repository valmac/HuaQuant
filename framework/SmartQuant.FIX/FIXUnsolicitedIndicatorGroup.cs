using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000150 RID: 336
	public class FIXUnsolicitedIndicatorGroup : FIXGroup
	{
		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x00045C53 File Offset: 0x00044C53
		// (set) Token: 0x06004014 RID: 16404 RVA: 0x00045C65 File Offset: 0x00044C65
		[FIXField("325", EFieldOption.Optional)]
		public bool UnsolicitedIndicator
		{
			get
			{
				return this.GetBoolField(325).Value;
			}
			set
			{
				this.AddBoolField(325, value);
			}
		}
	}
}
