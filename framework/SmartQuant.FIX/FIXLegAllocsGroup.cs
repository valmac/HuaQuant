using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000140 RID: 320
	public class FIXLegAllocsGroup : FIXGroup
	{
		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06003EC3 RID: 16067 RVA: 0x00042086 File Offset: 0x00041086
		// (set) Token: 0x06003EC4 RID: 16068 RVA: 0x00042098 File Offset: 0x00041098
		[FIXField("671", EFieldOption.Optional)]
		public string LegAllocAccount
		{
			get
			{
				return this.GetStringField(671).Value;
			}
			set
			{
				this.AddStringField(671, value);
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06003EC5 RID: 16069 RVA: 0x000420A6 File Offset: 0x000410A6
		// (set) Token: 0x06003EC6 RID: 16070 RVA: 0x000420B8 File Offset: 0x000410B8
		[FIXField("672", EFieldOption.Optional)]
		public string LegIndividualAllocID
		{
			get
			{
				return this.GetStringField(672).Value;
			}
			set
			{
				this.AddStringField(672, value);
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x000420C6 File Offset: 0x000410C6
		// (set) Token: 0x06003EC8 RID: 16072 RVA: 0x000420D8 File Offset: 0x000410D8
		[FIXField("673", EFieldOption.Optional)]
		public double LegAllocQty
		{
			get
			{
				return this.GetDoubleField(673).Value;
			}
			set
			{
				this.AddDoubleField(673, value);
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x000420E6 File Offset: 0x000410E6
		// (set) Token: 0x06003ECA RID: 16074 RVA: 0x000420F8 File Offset: 0x000410F8
		[FIXField("674", EFieldOption.Optional)]
		public string LegAllocAcctIDSource
		{
			get
			{
				return this.GetStringField(674).Value;
			}
			set
			{
				this.AddStringField(674, value);
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06003ECB RID: 16075 RVA: 0x00042106 File Offset: 0x00041106
		// (set) Token: 0x06003ECC RID: 16076 RVA: 0x00042118 File Offset: 0x00041118
		[FIXField("675", EFieldOption.Optional)]
		public double LegSettlCurrency
		{
			get
			{
				return this.GetDoubleField(675).Value;
			}
			set
			{
				this.AddDoubleField(675, value);
			}
		}
	}
}
