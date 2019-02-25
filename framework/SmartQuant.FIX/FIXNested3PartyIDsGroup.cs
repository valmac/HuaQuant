using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000166 RID: 358
	public class FIXNested3PartyIDsGroup : FIXGroup
	{
		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x000498FA File Offset: 0x000488FA
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x0004990C File Offset: 0x0004890C
		[FIXField("949", EFieldOption.Optional)]
		public string Nested3PartyID
		{
			get
			{
				return this.GetStringField(949).Value;
			}
			set
			{
				this.AddStringField(949, value);
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x0004991A File Offset: 0x0004891A
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x0004992C File Offset: 0x0004892C
		[FIXField("950", EFieldOption.Optional)]
		public char Nested3PartyIDSource
		{
			get
			{
				return this.GetCharField(950).Value;
			}
			set
			{
				this.AddCharField(950, value);
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x0004993A File Offset: 0x0004893A
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x0004994C File Offset: 0x0004894C
		[FIXField("951", EFieldOption.Optional)]
		public int Nested3PartyRole
		{
			get
			{
				return this.GetIntField(951).Value;
			}
			set
			{
				this.AddIntField(951, value);
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x0004995A File Offset: 0x0004895A
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x0004996C File Offset: 0x0004896C
		[FIXField("952", EFieldOption.Optional)]
		public int NoNested3PartySubIDs
		{
			get
			{
				return this.GetIntField(952).Value;
			}
			set
			{
				this.AddIntField(952, value);
			}
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x0004997A File Offset: 0x0004897A
		public FIXNested3PartySubIDsGroup GetNested3PartySubIDsGroup(int i)
		{
			if (i < this.NoNested3PartySubIDs)
			{
				return (FIXNested3PartySubIDsGroup)this.fNested3PartySubIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00049998 File Offset: 0x00048998
		public void AddGroup(FIXNested3PartySubIDsGroup group)
		{
			this.fNested3PartySubIDsGroup.Add(group);
			this.NoNested3PartySubIDs++;
		}

		// Token: 0x040009AB RID: 2475
		private ArrayList fNested3PartySubIDsGroup = new ArrayList();
	}
}
