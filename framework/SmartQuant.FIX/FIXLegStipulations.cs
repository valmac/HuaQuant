using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000068 RID: 104
	public class FIXLegStipulations : FIXMessage
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00015645 File Offset: 0x00014645
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00015657 File Offset: 0x00014657
		[FIXField("683", EFieldOption.Optional)]
		public int NoLegStipulations
		{
			get
			{
				return this.GetIntField(683).Value;
			}
			set
			{
				this.AddIntField(683, value);
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00015665 File Offset: 0x00014665
		public FIXLegStipulationsGroup GetLegStipulationsGroup(int i)
		{
			if (i < this.NoLegStipulations)
			{
				return (FIXLegStipulationsGroup)this.fLegStipulationsGroup[i];
			}
			return null;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00015683 File Offset: 0x00014683
		public void AddGroup(FIXLegStipulationsGroup group)
		{
			this.fLegStipulationsGroup.Add(group);
			this.NoLegStipulations++;
		}

		// Token: 0x04000259 RID: 601
		private ArrayList fLegStipulationsGroup = new ArrayList();
	}
}
