using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000132 RID: 306
	public class FIXOrderQtyData : FIXMessage
	{
		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x0003D62F File Offset: 0x0003C62F
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x0003D63E File Offset: 0x0003C63E
		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleField(38).Value;
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x0003D649 File Offset: 0x0003C649
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x0003D65B File Offset: 0x0003C65B
		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleField(152).Value;
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x0003D669 File Offset: 0x0003C669
		// (set) Token: 0x06003A4E RID: 14926 RVA: 0x0003D67B File Offset: 0x0003C67B
		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleField(516).Value;
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x0003D689 File Offset: 0x0003C689
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x0003D69B File Offset: 0x0003C69B
		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharField(468).Value;
			}
			set
			{
				this.AddCharField(468, value);
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x0003D6A9 File Offset: 0x0003C6A9
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x0003D6BB File Offset: 0x0003C6BB
		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleField(469).Value;
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}
	}
}
