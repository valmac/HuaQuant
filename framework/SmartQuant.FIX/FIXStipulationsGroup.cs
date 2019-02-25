using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000010 RID: 16
	public class FIXStipulationsGroup : FIXGroup
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00007416 File Offset: 0x00006416
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00007428 File Offset: 0x00006428
		[FIXField("233", EFieldOption.Optional)]
		public string StipulationType
		{
			get
			{
				return this.GetStringField(233).Value;
			}
			set
			{
				this.AddStringField(233, value);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00007436 File Offset: 0x00006436
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00007448 File Offset: 0x00006448
		[FIXField("234", EFieldOption.Optional)]
		public string StipulationValue
		{
			get
			{
				return this.GetStringField(234).Value;
			}
			set
			{
				this.AddStringField(234, value);
			}
		}
	}
}
