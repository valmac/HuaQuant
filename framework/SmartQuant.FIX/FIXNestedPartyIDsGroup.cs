using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000011 RID: 17
	public class FIXNestedPartyIDsGroup : FIXGroup
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0000745E File Offset: 0x0000645E
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00007470 File Offset: 0x00006470
		[FIXField("524", EFieldOption.Optional)]
		public string NestedPartyID
		{
			get
			{
				return this.GetStringField(524).Value;
			}
			set
			{
				this.AddStringField(524, value);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0000747E File Offset: 0x0000647E
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00007490 File Offset: 0x00006490
		[FIXField("525", EFieldOption.Optional)]
		public char NestedPartyIDSource
		{
			get
			{
				return this.GetCharField(525).Value;
			}
			set
			{
				this.AddCharField(525, value);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000749E File Offset: 0x0000649E
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000074B0 File Offset: 0x000064B0
		[FIXField("538", EFieldOption.Optional)]
		public int NestedPartyRole
		{
			get
			{
				return this.GetIntField(538).Value;
			}
			set
			{
				this.AddIntField(538, value);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x000074BE File Offset: 0x000064BE
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000074D0 File Offset: 0x000064D0
		[FIXField("804", EFieldOption.Optional)]
		public int NoNestedPartySubIDs
		{
			get
			{
				return this.GetIntField(804).Value;
			}
			set
			{
				this.AddIntField(804, value);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000074DE File Offset: 0x000064DE
		public FIXNestedPartySubIDsGroup GetNestedPartySubIDsGroup(int i)
		{
			if (i < this.NoNestedPartySubIDs)
			{
				return (FIXNestedPartySubIDsGroup)this.fNestedPartySubIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000074FC File Offset: 0x000064FC
		public void AddGroup(FIXNestedPartySubIDsGroup group)
		{
			this.fNestedPartySubIDsGroup.Add(group);
			this.NoNestedPartySubIDs++;
		}

		// Token: 0x04000033 RID: 51
		private ArrayList fNestedPartySubIDsGroup = new ArrayList();
	}
}
