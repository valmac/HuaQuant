using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200013D RID: 317
	public class FIXRegistDtlsGroup : FIXGroup
	{
		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x00040852 File Offset: 0x0003F852
		// (set) Token: 0x06003D3B RID: 15675 RVA: 0x00040864 File Offset: 0x0003F864
		[FIXField("509", EFieldOption.Optional)]
		public string RegistDtls
		{
			get
			{
				return this.GetStringField(509).Value;
			}
			set
			{
				this.AddStringField(509, value);
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00040872 File Offset: 0x0003F872
		// (set) Token: 0x06003D3D RID: 15677 RVA: 0x00040884 File Offset: 0x0003F884
		[FIXField("511", EFieldOption.Optional)]
		public string RegistEmail
		{
			get
			{
				return this.GetStringField(511).Value;
			}
			set
			{
				this.AddStringField(511, value);
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x00040892 File Offset: 0x0003F892
		// (set) Token: 0x06003D3F RID: 15679 RVA: 0x000408A4 File Offset: 0x0003F8A4
		[FIXField("474", EFieldOption.Optional)]
		public string MailingDtls
		{
			get
			{
				return this.GetStringField(474).Value;
			}
			set
			{
				this.AddStringField(474, value);
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x000408B2 File Offset: 0x0003F8B2
		// (set) Token: 0x06003D41 RID: 15681 RVA: 0x000408C4 File Offset: 0x0003F8C4
		[FIXField("482", EFieldOption.Optional)]
		public string MailingInst
		{
			get
			{
				return this.GetStringField(482).Value;
			}
			set
			{
				this.AddStringField(482, value);
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x000408D2 File Offset: 0x0003F8D2
		// (set) Token: 0x06003D43 RID: 15683 RVA: 0x000408E4 File Offset: 0x0003F8E4
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

		// Token: 0x06003D44 RID: 15684 RVA: 0x000408F2 File Offset: 0x0003F8F2
		public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
		{
			if (i < this.NoNestedPartyIDs)
			{
				return (FIXNestedPartyIDsGroup)this.fNestedPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00040910 File Offset: 0x0003F910
		public void AddGroup(FIXNestedPartyIDsGroup group)
		{
			this.fNestedPartyIDsGroup.Add(group);
			this.NoNestedPartyIDs++;
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x0004092D File Offset: 0x0003F92D
		// (set) Token: 0x06003D47 RID: 15687 RVA: 0x0004093F File Offset: 0x0003F93F
		[FIXField("522", EFieldOption.Optional)]
		public int OwnerType
		{
			get
			{
				return this.GetIntField(522).Value;
			}
			set
			{
				this.AddIntField(522, value);
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x0004094D File Offset: 0x0003F94D
		// (set) Token: 0x06003D49 RID: 15689 RVA: 0x0004095F File Offset: 0x0003F95F
		[FIXField("486", EFieldOption.Optional)]
		public DateTime DateOfBirth
		{
			get
			{
				return this.GetDateTimeField(486).Value;
			}
			set
			{
				this.AddDateTimeField(486, value);
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x0004096D File Offset: 0x0003F96D
		// (set) Token: 0x06003D4B RID: 15691 RVA: 0x0004097F File Offset: 0x0003F97F
		[FIXField("475", EFieldOption.Optional)]
		public string InvestorCountryOfResidence
		{
			get
			{
				return this.GetStringField(475).Value;
			}
			set
			{
				this.AddStringField(475, value);
			}
		}

		// Token: 0x04000552 RID: 1362
		private ArrayList fNestedPartyIDsGroup = new ArrayList();
	}
}
