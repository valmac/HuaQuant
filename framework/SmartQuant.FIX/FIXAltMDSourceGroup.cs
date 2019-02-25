using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000122 RID: 290
	public class FIXAltMDSourceGroup : FIXGroup
	{
		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x00039F37 File Offset: 0x00038F37
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x00039F49 File Offset: 0x00038F49
		[FIXField("817", EFieldOption.Optional)]
		public string AltMDSourceID
		{
			get
			{
				return this.GetStringField(817).Value;
			}
			set
			{
				this.AddStringField(817, value);
			}
		}
	}
}
