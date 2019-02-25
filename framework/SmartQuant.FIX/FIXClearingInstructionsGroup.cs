using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000D6 RID: 214
	public class FIXClearingInstructionsGroup : FIXGroup
	{
		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x0002D6DA File Offset: 0x0002C6DA
		// (set) Token: 0x06002AB5 RID: 10933 RVA: 0x0002D6EC File Offset: 0x0002C6EC
		[FIXField("577", EFieldOption.Optional)]
		public int ClearingInstruction
		{
			get
			{
				return this.GetIntField(577).Value;
			}
			set
			{
				this.AddIntField(577, value);
			}
		}
	}
}
