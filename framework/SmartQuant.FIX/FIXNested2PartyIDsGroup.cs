using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200003F RID: 63
	public class FIXNested2PartyIDsGroup : FIXGroup
	{
		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00011B6B File Offset: 0x00010B6B
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00011B7D File Offset: 0x00010B7D
		[FIXField("757", EFieldOption.Optional)]
		public string Nested2PartyID
		{
			get
			{
				return this.GetStringField(757).Value;
			}
			set
			{
				this.AddStringField(757, value);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00011B8B File Offset: 0x00010B8B
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00011B9D File Offset: 0x00010B9D
		[FIXField("758", EFieldOption.Optional)]
		public char Nested2PartyIDSource
		{
			get
			{
				return this.GetCharField(758).Value;
			}
			set
			{
				this.AddCharField(758, value);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00011BAB File Offset: 0x00010BAB
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00011BBD File Offset: 0x00010BBD
		[FIXField("759", EFieldOption.Optional)]
		public int Nested2PartyRole
		{
			get
			{
				return this.GetIntField(759).Value;
			}
			set
			{
				this.AddIntField(759, value);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00011BCB File Offset: 0x00010BCB
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00011BDD File Offset: 0x00010BDD
		[FIXField("806", EFieldOption.Optional)]
		public int NoNested2PartySubIDs
		{
			get
			{
				return this.GetIntField(806).Value;
			}
			set
			{
				this.AddIntField(806, value);
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00011BEB File Offset: 0x00010BEB
		public FIXNested2PartySubIDsGroup GetNested2PartySubIDsGroup(int i)
		{
			if (i < this.NoNested2PartySubIDs)
			{
				return (FIXNested2PartySubIDsGroup)this.fNested2PartySubIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00011C09 File Offset: 0x00010C09
		public void AddGroup(FIXNested2PartySubIDsGroup group)
		{
			this.fNested2PartySubIDsGroup.Add(group);
			this.NoNested2PartySubIDs++;
		}

		// Token: 0x040000B9 RID: 185
		private ArrayList fNested2PartySubIDsGroup = new ArrayList();
	}
}
