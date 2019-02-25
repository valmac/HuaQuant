using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000190 RID: 400
	public class FIXIOIQualifiersGroup : FIXGroup
	{
		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06004B8B RID: 19339 RVA: 0x000537ED File Offset: 0x000527ED
		// (set) Token: 0x06004B8C RID: 19340 RVA: 0x000537FC File Offset: 0x000527FC
		[FIXField("104", EFieldOption.Optional)]
		public char IOIQualifier
		{
			get
			{
				return this.GetCharField(104).Value;
			}
			set
			{
				this.AddCharField(104, value);
			}
		}
	}
}
