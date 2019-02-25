using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200002D RID: 45
	public class FIXPositionsGroup : FIXGroup
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0000C9DD File Offset: 0x0000B9DD
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x0000C9EA File Offset: 0x0000B9EA
		[FIXField("703", EFieldOption.Optional)]
		public string PosType
		{
			get
			{
				return this.GetStringValue(703);
			}
			set
			{
				this.SetStringValue(703, value);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0000C9F8 File Offset: 0x0000B9F8
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0000CA05 File Offset: 0x0000BA05
		[FIXField("704", EFieldOption.Optional)]
		public double LongQty
		{
			get
			{
				return this.GetDoubleValue(704);
			}
			set
			{
				this.SetDoubleValue(704, value);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0000CA13 File Offset: 0x0000BA13
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0000CA20 File Offset: 0x0000BA20
		[FIXField("705", EFieldOption.Optional)]
		public double ShortQty
		{
			get
			{
				return this.GetDoubleValue(705);
			}
			set
			{
				this.SetDoubleValue(705, value);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0000CA2E File Offset: 0x0000BA2E
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x0000CA3B File Offset: 0x0000BA3B
		[FIXField("706", EFieldOption.Optional)]
		public int PosQtyStatus
		{
			get
			{
				return this.GetIntValue(706);
			}
			set
			{
				this.SetIntValue(706, value);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0000CA49 File Offset: 0x0000BA49
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x0000CA56 File Offset: 0x0000BA56
		[FIXField("539", EFieldOption.Optional)]
		public int NoNestedPartyIDs
		{
			get
			{
				return this.GetIntValue(539);
			}
			set
			{
				this.SetIntValue(539, value);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0000CA64 File Offset: 0x0000BA64
		public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
		{
			if (i < this.NoNestedPartyIDs)
			{
				return (FIXNestedPartyIDsGroup)this.fNestedPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0000CA82 File Offset: 0x0000BA82
		public void AddGroup(FIXNestedPartyIDsGroup group)
		{
			this.fNestedPartyIDsGroup.Add(group);
			this.NoNestedPartyIDs++;
		}

		// Token: 0x04000076 RID: 118
		private ArrayList fNestedPartyIDsGroup = new ArrayList();
	}
}
