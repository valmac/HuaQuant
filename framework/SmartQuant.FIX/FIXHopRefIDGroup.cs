using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000070 RID: 112
	public class FIXHopRefIDGroup : FIXGroup
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00016D40 File Offset: 0x00015D40
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x00016D52 File Offset: 0x00015D52
		[FIXField("630", EFieldOption.Optional)]
		public int HopRefID
		{
			get
			{
				return this.GetIntField(630).Value;
			}
			set
			{
				this.AddIntField(630, value);
			}
		}
	}
}
