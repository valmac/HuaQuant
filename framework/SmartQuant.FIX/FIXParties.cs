using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200014C RID: 332
	public class FIXParties : FIXMessage
	{
		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x000455B9 File Offset: 0x000445B9
		// (set) Token: 0x06003FA5 RID: 16293 RVA: 0x000455CB File Offset: 0x000445CB
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntField(453).Value;
			}
			set
			{
				this.AddIntField(453, value);
			}
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000455D9 File Offset: 0x000445D9
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000455F7 File Offset: 0x000445F7
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x04000955 RID: 2389
		private ArrayList fPartyIDsGroup = new ArrayList();
	}
}
