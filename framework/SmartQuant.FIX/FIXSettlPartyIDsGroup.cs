using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200003D RID: 61
	public class FIXSettlPartyIDsGroup : FIXGroup
	{
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x000119CF File Offset: 0x000109CF
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x000119E1 File Offset: 0x000109E1
		[FIXField("782", EFieldOption.Optional)]
		public string SettlPartyID
		{
			get
			{
				return this.GetStringField(782).Value;
			}
			set
			{
				this.AddStringField(782, value);
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x000119EF File Offset: 0x000109EF
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00011A01 File Offset: 0x00010A01
		[FIXField("783", EFieldOption.Optional)]
		public char SettlPartyIDSource
		{
			get
			{
				return this.GetCharField(783).Value;
			}
			set
			{
				this.AddCharField(783, value);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00011A0F File Offset: 0x00010A0F
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x00011A21 File Offset: 0x00010A21
		[FIXField("784", EFieldOption.Optional)]
		public int SettlPartyRole
		{
			get
			{
				return this.GetIntField(784).Value;
			}
			set
			{
				this.AddIntField(784, value);
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00011A2F File Offset: 0x00010A2F
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x00011A41 File Offset: 0x00010A41
		[FIXField("801", EFieldOption.Optional)]
		public int NoSettlPartySubIDs
		{
			get
			{
				return this.GetIntField(801).Value;
			}
			set
			{
				this.AddIntField(801, value);
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00011A4F File Offset: 0x00010A4F
		public FIXSettlPartySubIDsGroup GetSettlPartySubIDsGroup(int i)
		{
			if (i < this.NoSettlPartySubIDs)
			{
				return (FIXSettlPartySubIDsGroup)this.fSettlPartySubIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00011A6D File Offset: 0x00010A6D
		public void AddGroup(FIXSettlPartySubIDsGroup group)
		{
			this.fSettlPartySubIDsGroup.Add(group);
			this.NoSettlPartySubIDs++;
		}

		// Token: 0x040000B7 RID: 183
		private ArrayList fSettlPartySubIDsGroup = new ArrayList();
	}
}
