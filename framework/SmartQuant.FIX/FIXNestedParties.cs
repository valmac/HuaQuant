using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000AC RID: 172
	public class FIXNestedParties : FIXMessage
	{
		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x00027482 File Offset: 0x00026482
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x00027494 File Offset: 0x00026494
		[FIXField("539", EFieldOption.Optional)]
		public int NoNestedPartyIDs
		{
			get
			{
				return this.GetIntField(539).Value;
			}
			set
			{
				this.AddIntField(539, value);
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000274A2 File Offset: 0x000264A2
		public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
		{
			if (i < this.NoNestedPartyIDs)
			{
				return (FIXNestedPartyIDsGroup)this.fNestedPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000274C0 File Offset: 0x000264C0
		public void AddGroup(FIXNestedPartyIDsGroup group)
		{
			this.fNestedPartyIDsGroup.Add(group);
			this.NoNestedPartyIDs++;
		}

		// Token: 0x04000356 RID: 854
		private ArrayList fNestedPartyIDsGroup = new ArrayList();
	}
}
