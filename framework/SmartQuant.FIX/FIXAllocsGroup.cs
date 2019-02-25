using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000123 RID: 291
	public class FIXAllocsGroup : FIXGroup
	{
		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x00039F5F File Offset: 0x00038F5F
		// (set) Token: 0x060036FA RID: 14074 RVA: 0x00039F6E File Offset: 0x00038F6E
		[FIXField("79", EFieldOption.Optional)]
		public string AllocAccount
		{
			get
			{
				return this.GetStringField(79).Value;
			}
			set
			{
				this.AddStringField(79, value);
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x00039F79 File Offset: 0x00038F79
		// (set) Token: 0x060036FC RID: 14076 RVA: 0x00039F8B File Offset: 0x00038F8B
		[FIXField("661", EFieldOption.Optional)]
		public int AllocAcctIDSource
		{
			get
			{
				return this.GetIntField(661).Value;
			}
			set
			{
				this.AddIntField(661, value);
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x00039F99 File Offset: 0x00038F99
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x00039FAB File Offset: 0x00038FAB
		[FIXField("736", EFieldOption.Optional)]
		public double AllocSettlCurrency
		{
			get
			{
				return this.GetDoubleField(736).Value;
			}
			set
			{
				this.AddDoubleField(736, value);
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x00039FB9 File Offset: 0x00038FB9
		// (set) Token: 0x06003700 RID: 14080 RVA: 0x00039FCB File Offset: 0x00038FCB
		[FIXField("467", EFieldOption.Optional)]
		public string IndividualAllocID
		{
			get
			{
				return this.GetStringField(467).Value;
			}
			set
			{
				this.AddStringField(467, value);
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x00039FD9 File Offset: 0x00038FD9
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x00039FEB File Offset: 0x00038FEB
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

		// Token: 0x06003703 RID: 14083 RVA: 0x00039FF9 File Offset: 0x00038FF9
		public FIXNested2PartyIDsGroup GetNested2PartyIDsGroup(int i)
		{
			if (i < this.NoNested2PartyIDs)
			{
				return (FIXNested2PartyIDsGroup)this.fNested2PartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x0003A017 File Offset: 0x00039017
		public void AddGroup(FIXNested2PartyIDsGroup group)
		{
			this.fNested2PartyIDsGroup.Add(group);
			this.NoNested2PartyIDs++;
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x0003A034 File Offset: 0x00039034
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x0003A043 File Offset: 0x00039043
		[FIXField("80", EFieldOption.Optional)]
		public double AllocQty
		{
			get
			{
				return this.GetDoubleField(80).Value;
			}
			set
			{
				this.AddDoubleField(80, value);
			}
		}

		// Token: 0x0400050C RID: 1292
		private ArrayList fNested2PartyIDsGroup = new ArrayList();
	}
}
