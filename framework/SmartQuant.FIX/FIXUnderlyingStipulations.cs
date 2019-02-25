using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000178 RID: 376
	public class FIXUnderlyingStipulations : FIXMessage
	{
		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x0004D2D9 File Offset: 0x0004C2D9
		// (set) Token: 0x06004580 RID: 17792 RVA: 0x0004D2EB File Offset: 0x0004C2EB
		[FIXField("887", EFieldOption.Optional)]
		public int NoUnderlyingStips
		{
			get
			{
				return this.GetIntField(887).Value;
			}
			set
			{
				this.AddIntField(887, value);
			}
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x0004D2F9 File Offset: 0x0004C2F9
		public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
		{
			if (i < this.NoUnderlyingStips)
			{
				return (FIXUnderlyingStipsGroup)this.fUnderlyingStipsGroup[i];
			}
			return null;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x0004D317 File Offset: 0x0004C317
		public void AddGroup(FIXUnderlyingStipsGroup group)
		{
			this.fUnderlyingStipsGroup.Add(group);
			this.NoUnderlyingStips++;
		}

		// Token: 0x04000D85 RID: 3461
		private ArrayList fUnderlyingStipsGroup = new ArrayList();
	}
}
