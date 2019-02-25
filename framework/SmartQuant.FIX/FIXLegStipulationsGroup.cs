using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000151 RID: 337
	public class FIXLegStipulationsGroup : FIXGroup
	{
		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x00045C7B File Offset: 0x00044C7B
		// (set) Token: 0x06004017 RID: 16407 RVA: 0x00045C8D File Offset: 0x00044C8D
		[FIXField("688", EFieldOption.Optional)]
		public string LegStipulationType
		{
			get
			{
				return this.GetStringField(688).Value;
			}
			set
			{
				this.AddStringField(688, value);
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x00045C9B File Offset: 0x00044C9B
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x00045CAD File Offset: 0x00044CAD
		[FIXField("689", EFieldOption.Optional)]
		public string LegStipulationValue
		{
			get
			{
				return this.GetStringField(689).Value;
			}
			set
			{
				this.AddStringField(689, value);
			}
		}
	}
}
