using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200002C RID: 44
	public class FIXSecurityTypesGroup : FIXGroup
	{
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0000C955 File Offset: 0x0000B955
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000C967 File Offset: 0x0000B967
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringField(167).Value;
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0000C975 File Offset: 0x0000B975
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0000C987 File Offset: 0x0000B987
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringField(762).Value;
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0000C995 File Offset: 0x0000B995
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0000C9A7 File Offset: 0x0000B9A7
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntField(460).Value;
			}
			set
			{
				this.AddIntField(460, value);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0000C9B5 File Offset: 0x0000B9B5
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0000C9C7 File Offset: 0x0000B9C7
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringField(461).Value;
			}
			set
			{
				this.AddStringField(461, value);
			}
		}
	}
}
