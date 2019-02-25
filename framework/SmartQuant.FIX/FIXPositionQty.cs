using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000FF RID: 255
	public class FIXPositionQty : FIXMessage
	{
		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x000316BD File Offset: 0x000306BD
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x000316CF File Offset: 0x000306CF
		[FIXField("702", EFieldOption.Optional)]
		public int NoPositions
		{
			get
			{
				return this.GetIntField(702).Value;
			}
			set
			{
				this.AddIntField(702, value);
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x000316DD File Offset: 0x000306DD
		public FIXPositionsGroup GetPositionsGroup(int i)
		{
			if (i < this.NoPositions)
			{
				return (FIXPositionsGroup)this.fPositionsGroup[i];
			}
			return null;
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000316FB File Offset: 0x000306FB
		public void AddGroup(FIXPositionsGroup group)
		{
			this.fPositionsGroup.Add(group);
			this.NoPositions++;
		}

		// Token: 0x0400041D RID: 1053
		private ArrayList fPositionsGroup = new ArrayList();
	}
}
