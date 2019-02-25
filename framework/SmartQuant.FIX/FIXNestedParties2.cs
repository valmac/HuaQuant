using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000188 RID: 392
	public class FIXNestedParties2 : FIXMessage
	{
		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x000524D7 File Offset: 0x000514D7
		// (set) Token: 0x06004A65 RID: 19045 RVA: 0x000524E9 File Offset: 0x000514E9
		[FIXField("756", EFieldOption.Optional)]
		public int NoNested2PartyIDs
		{
			get
			{
				return this.GetIntField(756).Value;
			}
			set
			{
				this.AddIntField(756, value);
			}
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x000524F7 File Offset: 0x000514F7
		public FIXNested2PartyIDsGroup GetNested2PartyIDsGroup(int i)
		{
			if (i < this.NoNested2PartyIDs)
			{
				return (FIXNested2PartyIDsGroup)this.fNested2PartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00052515 File Offset: 0x00051515
		public void AddGroup(FIXNested2PartyIDsGroup group)
		{
			this.fNested2PartyIDsGroup.Add(group);
			this.NoNested2PartyIDs++;
		}

		// Token: 0x04000DB6 RID: 3510
		private ArrayList fNested2PartyIDsGroup = new ArrayList();
	}
}
