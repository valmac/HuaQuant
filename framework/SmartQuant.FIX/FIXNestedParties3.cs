using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200016E RID: 366
	public class FIXNestedParties3 : FIXMessage
	{
		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x0004C565 File Offset: 0x0004B565
		// (set) Token: 0x060044B1 RID: 17585 RVA: 0x0004C577 File Offset: 0x0004B577
		[FIXField("948", EFieldOption.Optional)]
		public int NoNested3PartyIDs
		{
			get
			{
				return this.GetIntField(948).Value;
			}
			set
			{
				this.AddIntField(948, value);
			}
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x0004C585 File Offset: 0x0004B585
		public FIXNested3PartyIDsGroup GetNested3PartyIDsGroup(int i)
		{
			if (i < this.NoNested3PartyIDs)
			{
				return (FIXNested3PartyIDsGroup)this.fNested3PartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x0004C5A3 File Offset: 0x0004B5A3
		public void AddGroup(FIXNested3PartyIDsGroup group)
		{
			this.fNested3PartyIDsGroup.Add(group);
			this.NoNested3PartyIDs++;
		}

		// Token: 0x04000D6E RID: 3438
		private ArrayList fNested3PartyIDsGroup = new ArrayList();
	}
}
