using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000125 RID: 293
	public class FIXSettlInstructionsData : FIXMessage
	{
		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x0003A081 File Offset: 0x00039081
		// (set) Token: 0x0600370C RID: 14092 RVA: 0x0003A093 File Offset: 0x00039093
		[FIXField("172", EFieldOption.Optional)]
		public int SettlDeliveryType
		{
			get
			{
				return this.GetIntField(172).Value;
			}
			set
			{
				this.AddIntField(172, value);
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x0003A0A1 File Offset: 0x000390A1
		// (set) Token: 0x0600370E RID: 14094 RVA: 0x0003A0B3 File Offset: 0x000390B3
		[FIXField("169", EFieldOption.Optional)]
		public int StandInstDbType
		{
			get
			{
				return this.GetIntField(169).Value;
			}
			set
			{
				this.AddIntField(169, value);
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x0003A0C1 File Offset: 0x000390C1
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x0003A0D3 File Offset: 0x000390D3
		[FIXField("170", EFieldOption.Optional)]
		public string StandInstDbName
		{
			get
			{
				return this.GetStringField(170).Value;
			}
			set
			{
				this.AddStringField(170, value);
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0003A0E1 File Offset: 0x000390E1
		// (set) Token: 0x06003712 RID: 14098 RVA: 0x0003A0F3 File Offset: 0x000390F3
		[FIXField("171", EFieldOption.Optional)]
		public string StandInstDbID
		{
			get
			{
				return this.GetStringField(171).Value;
			}
			set
			{
				this.AddStringField(171, value);
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x0003A101 File Offset: 0x00039101
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x0003A110 File Offset: 0x00039110
		[FIXField("85", EFieldOption.Optional)]
		public int NoDlvyInst
		{
			get
			{
				return this.GetIntField(85).Value;
			}
			set
			{
				this.AddIntField(85, value);
			}
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0003A11B File Offset: 0x0003911B
		public FIXDlvyInstGroup GetDlvyInstGroup(int i)
		{
			if (i < this.NoDlvyInst)
			{
				return (FIXDlvyInstGroup)this.fDlvyInstGroup[i];
			}
			return null;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x0003A139 File Offset: 0x00039139
		public void AddGroup(FIXDlvyInstGroup group)
		{
			this.fDlvyInstGroup.Add(group);
			this.NoDlvyInst++;
		}

		// Token: 0x0400050E RID: 1294
		private ArrayList fDlvyInstGroup = new ArrayList();
	}
}
