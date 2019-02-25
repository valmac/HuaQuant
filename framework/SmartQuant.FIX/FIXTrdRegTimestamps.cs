using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200001C RID: 28
	public class FIXTrdRegTimestamps : FIXMessage
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00007CB7 File Offset: 0x00006CB7
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00007CC9 File Offset: 0x00006CC9
		[FIXField("768", EFieldOption.Optional)]
		public int NoTrdRegTimestamps
		{
			get
			{
				return this.GetIntField(768).Value;
			}
			set
			{
				this.AddIntField(768, value);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00007CD7 File Offset: 0x00006CD7
		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
			{
				return (FIXTrdRegTimestampsGroup)this.fTrdRegTimestampsGroup[i];
			}
			return null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00007CF5 File Offset: 0x00006CF5
		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.fTrdRegTimestampsGroup.Add(group);
			this.NoTrdRegTimestamps++;
		}

		// Token: 0x04000043 RID: 67
		private ArrayList fTrdRegTimestampsGroup = new ArrayList();
	}
}
