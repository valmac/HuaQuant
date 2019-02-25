using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000173 RID: 371
	public class FIXNested2PartySubIDsGroup : FIXGroup
	{
		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x0004D1D9 File Offset: 0x0004C1D9
		// (set) Token: 0x06004570 RID: 17776 RVA: 0x0004D1EB File Offset: 0x0004C1EB
		[FIXField("760", EFieldOption.Optional)]
		public string Nested2PartySubID
		{
			get
			{
				return this.GetStringField(760).Value;
			}
			set
			{
				this.AddStringField(760, value);
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x0004D1F9 File Offset: 0x0004C1F9
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x0004D20B File Offset: 0x0004C20B
		[FIXField("807", EFieldOption.Optional)]
		public int Nested2PartySubIDType
		{
			get
			{
				return this.GetIntField(807).Value;
			}
			set
			{
				this.AddIntField(807, value);
			}
		}
	}
}
