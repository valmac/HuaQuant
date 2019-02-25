using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000120 RID: 288
	public class FIXDlvyInstGroup : FIXGroup
	{
		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x00039C71 File Offset: 0x00038C71
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x00039C83 File Offset: 0x00038C83
		[FIXField("165", EFieldOption.Optional)]
		public char SettlInstSource
		{
			get
			{
				return this.GetCharField(165).Value;
			}
			set
			{
				this.AddCharField(165, value);
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x00039C91 File Offset: 0x00038C91
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x00039CA3 File Offset: 0x00038CA3
		[FIXField("787", EFieldOption.Optional)]
		public char DlvyInstType
		{
			get
			{
				return this.GetCharField(787).Value;
			}
			set
			{
				this.AddCharField(787, value);
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x00039CB1 File Offset: 0x00038CB1
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x00039CC3 File Offset: 0x00038CC3
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

		// Token: 0x060036CE RID: 14030 RVA: 0x00039CD1 File Offset: 0x00038CD1
		public FIXSettlPartyIDsGroup GetSettlPartyIDsGroup(int i)
		{
			if (i < this.NoSettlPartyIDs)
			{
				return (FIXSettlPartyIDsGroup)this.fSettlPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00039CEF File Offset: 0x00038CEF
		public void AddGroup(FIXSettlPartyIDsGroup group)
		{
			this.fSettlPartyIDsGroup.Add(group);
			this.NoSettlPartyIDs++;
		}

		// Token: 0x0400050B RID: 1291
		private ArrayList fSettlPartyIDsGroup = new ArrayList();
	}
}
