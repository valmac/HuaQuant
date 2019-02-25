using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200003E RID: 62
	public class FIXPartyIDsGroup : FIXGroup
	{
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00011A9D File Offset: 0x00010A9D
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00011AAF File Offset: 0x00010AAF
		[FIXField("448", EFieldOption.Optional)]
		public string PartyID
		{
			get
			{
				return this.GetStringField(448).Value;
			}
			set
			{
				this.AddStringField(448, value);
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00011ABD File Offset: 0x00010ABD
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00011ACF File Offset: 0x00010ACF
		[FIXField("447", EFieldOption.Optional)]
		public char PartyIDSource
		{
			get
			{
				return this.GetCharField(447).Value;
			}
			set
			{
				this.AddCharField(447, value);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00011ADD File Offset: 0x00010ADD
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00011AEF File Offset: 0x00010AEF
		[FIXField("452", EFieldOption.Optional)]
		public int PartyRole
		{
			get
			{
				return this.GetIntField(452).Value;
			}
			set
			{
				this.AddIntField(452, value);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00011AFD File Offset: 0x00010AFD
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00011B0F File Offset: 0x00010B0F
		[FIXField("802", EFieldOption.Optional)]
		public int NoPartySubIDs
		{
			get
			{
				return this.GetIntField(802).Value;
			}
			set
			{
				this.AddIntField(802, value);
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00011B1D File Offset: 0x00010B1D
		public FIXPartySubIDsGroup GetPartySubIDsGroup(int i)
		{
			if (i < this.NoPartySubIDs)
			{
				return (FIXPartySubIDsGroup)this.fPartySubIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00011B3B File Offset: 0x00010B3B
		public void AddGroup(FIXPartySubIDsGroup group)
		{
			this.fPartySubIDsGroup.Add(group);
			this.NoPartySubIDs++;
		}

		// Token: 0x040000B8 RID: 184
		private ArrayList fPartySubIDsGroup = new ArrayList();
	}
}
