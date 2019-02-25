using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200004D RID: 77
	public class FIXStipulations : FIXMessage
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00012596 File Offset: 0x00011596
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x000125A8 File Offset: 0x000115A8
		[FIXField("232", EFieldOption.Optional)]
		public int NoStipulations
		{
			get
			{
				return this.GetIntField(232).Value;
			}
			set
			{
				this.AddIntField(232, value);
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000125B6 File Offset: 0x000115B6
		public FIXStipulationsGroup GetStipulationsGroup(int i)
		{
			if (i < this.NoStipulations)
			{
				return (FIXStipulationsGroup)this.fStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x000125D4 File Offset: 0x000115D4
		public void AddGroup(FIXStipulationsGroup group)
		{
			this.fStipulationsGroup.Add(group);
			this.NoStipulations++;
		}

		// Token: 0x04000186 RID: 390
		private ArrayList fStipulationsGroup = new ArrayList();
	}
}
