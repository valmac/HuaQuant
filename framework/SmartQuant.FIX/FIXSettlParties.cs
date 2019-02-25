using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200017A RID: 378
	public class FIXSettlParties : FIXMessage
	{
		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x0004D367 File Offset: 0x0004C367
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x0004D379 File Offset: 0x0004C379
		[FIXField("781", EFieldOption.Optional)]
		public int NoSettlPartyIDs
		{
			get
			{
				return this.GetIntField(781).Value;
			}
			set
			{
				this.AddIntField(781, value);
			}
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x0004D387 File Offset: 0x0004C387
		public FIXSettlPartyIDsGroup GetSettlPartyIDsGroup(int i)
		{
			if (i < this.NoSettlPartyIDs)
			{
				return (FIXSettlPartyIDsGroup)this.fSettlPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x0004D3A5 File Offset: 0x0004C3A5
		public void AddGroup(FIXSettlPartyIDsGroup group)
		{
			this.fSettlPartyIDsGroup.Add(group);
			this.NoSettlPartyIDs++;
		}

		// Token: 0x04000D87 RID: 3463
		private ArrayList fSettlPartyIDsGroup = new ArrayList();
	}
}
