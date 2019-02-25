using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E9 RID: 233
	public class FIXNested3PartySubIDsGroup : FIXGroup
	{
		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x00031092 File Offset: 0x00030092
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000310A4 File Offset: 0x000300A4
		[FIXField("953", EFieldOption.Optional)]
		public string Nested3PartySubID
		{
			get
			{
				return this.GetStringField(953).Value;
			}
			set
			{
				this.AddStringField(953, value);
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000310B2 File Offset: 0x000300B2
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x000310C4 File Offset: 0x000300C4
		[FIXField("954", EFieldOption.Optional)]
		public int Nested3PartySubIDType
		{
			get
			{
				return this.GetIntField(954).Value;
			}
			set
			{
				this.AddIntField(954, value);
			}
		}
	}
}
