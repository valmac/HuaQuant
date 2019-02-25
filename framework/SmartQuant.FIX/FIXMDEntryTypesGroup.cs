using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200018F RID: 399
	public class FIXMDEntryTypesGroup : FIXGroup
	{
		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x000537B6 File Offset: 0x000527B6
		// (set) Token: 0x06004B88 RID: 19336 RVA: 0x000537C8 File Offset: 0x000527C8
		[FIXField("269", EFieldOption.Required)]
		public char MDEntryType
		{
			get
			{
				return this.GetCharField(269).Value;
			}
			set
			{
				this.AddCharField(269, value);
			}
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x000537D6 File Offset: 0x000527D6
		public FIXMDEntryTypesGroup()
		{
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x000537DE File Offset: 0x000527DE
		public FIXMDEntryTypesGroup(char MDEntryType)
		{
			this.MDEntryType = MDEntryType;
		}
	}
}
