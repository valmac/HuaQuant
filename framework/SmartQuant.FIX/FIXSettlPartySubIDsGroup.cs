using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000B6 RID: 182
	public class FIXSettlPartySubIDsGroup : FIXGroup
	{
		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00028914 File Offset: 0x00027914
		// (set) Token: 0x060025F4 RID: 9716 RVA: 0x00028926 File Offset: 0x00027926
		[FIXField("785", EFieldOption.Optional)]
		public string SettlPartySubID
		{
			get
			{
				return this.GetStringField(785).Value;
			}
			set
			{
				this.AddStringField(785, value);
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x00028934 File Offset: 0x00027934
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x00028946 File Offset: 0x00027946
		[FIXField("786", EFieldOption.Optional)]
		public int SettlPartySubIDType
		{
			get
			{
				return this.GetIntField(786).Value;
			}
			set
			{
				this.AddIntField(786, value);
			}
		}
	}
}
