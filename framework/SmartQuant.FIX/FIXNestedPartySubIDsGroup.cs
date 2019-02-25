using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000165 RID: 357
	public class FIXNestedPartySubIDsGroup : FIXGroup
	{
		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x000498B2 File Offset: 0x000488B2
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x000498C4 File Offset: 0x000488C4
		[FIXField("545", EFieldOption.Optional)]
		public string NestedPartySubID
		{
			get
			{
				return this.GetStringField(545).Value;
			}
			set
			{
				this.AddStringField(545, value);
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x000498D2 File Offset: 0x000488D2
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x000498E4 File Offset: 0x000488E4
		[FIXField("805", EFieldOption.Optional)]
		public int NestedPartySubIDType
		{
			get
			{
				return this.GetIntField(805).Value;
			}
			set
			{
				this.AddIntField(805, value);
			}
		}
	}
}
