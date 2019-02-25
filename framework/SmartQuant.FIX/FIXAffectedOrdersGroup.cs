using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000142 RID: 322
	public class FIXAffectedOrdersGroup : FIXGroup
	{
		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06003EE5 RID: 16101 RVA: 0x00042296 File Offset: 0x00041296
		// (set) Token: 0x06003EE6 RID: 16102 RVA: 0x000422A5 File Offset: 0x000412A5
		[FIXField("41", EFieldOption.Optional)]
		public string OrigClOrdID
		{
			get
			{
				return this.GetStringField(41).Value;
			}
			set
			{
				this.AddStringField(41, value);
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x000422B0 File Offset: 0x000412B0
		// (set) Token: 0x06003EE8 RID: 16104 RVA: 0x000422C2 File Offset: 0x000412C2
		[FIXField("535", EFieldOption.Optional)]
		public string AffectedOrderID
		{
			get
			{
				return this.GetStringField(535).Value;
			}
			set
			{
				this.AddStringField(535, value);
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x000422D0 File Offset: 0x000412D0
		// (set) Token: 0x06003EEA RID: 16106 RVA: 0x000422E2 File Offset: 0x000412E2
		[FIXField("536", EFieldOption.Optional)]
		public string AffectedSecondaryOrderID
		{
			get
			{
				return this.GetStringField(536).Value;
			}
			set
			{
				this.AddStringField(536, value);
			}
		}
	}
}
