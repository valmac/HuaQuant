using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200011F RID: 287
	public class FIXPartySubIDsGroup : FIXGroup
	{
		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x00039C29 File Offset: 0x00038C29
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x00039C3B File Offset: 0x00038C3B
		[FIXField("523", EFieldOption.Optional)]
		public string PartySubID
		{
			get
			{
				return this.GetStringField(523).Value;
			}
			set
			{
				this.AddStringField(523, value);
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00039C49 File Offset: 0x00038C49
		// (set) Token: 0x060036C6 RID: 14022 RVA: 0x00039C5B File Offset: 0x00038C5B
		[FIXField("803", EFieldOption.Optional)]
		public int PartySubIDType
		{
			get
			{
				return this.GetIntField(803).Value;
			}
			set
			{
				this.AddIntField(803, value);
			}
		}
	}
}
