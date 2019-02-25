using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000180 RID: 384
	public class FIXPositionAmountData : FIXMessage
	{
		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x0004F0D6 File Offset: 0x0004E0D6
		// (set) Token: 0x0600473E RID: 18238 RVA: 0x0004F0E8 File Offset: 0x0004E0E8
		[FIXField("753", EFieldOption.Optional)]
		public int NoPosAmt
		{
			get
			{
				return this.GetIntField(753).Value;
			}
			set
			{
				this.AddIntField(753, value);
			}
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0004F0F6 File Offset: 0x0004E0F6
		public FIXPosAmtGroup GetPosAmtGroup(int i)
		{
			if (i < this.NoPosAmt)
			{
				return (FIXPosAmtGroup)this.fPosAmtGroup[i];
			}
			return null;
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0004F114 File Offset: 0x0004E114
		public void AddGroup(FIXPosAmtGroup group)
		{
			this.fPosAmtGroup.Add(group);
			this.NoPosAmt++;
		}

		// Token: 0x04000D9C RID: 3484
		private ArrayList fPosAmtGroup = new ArrayList();
	}
}
