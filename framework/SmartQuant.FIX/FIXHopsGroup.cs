using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000153 RID: 339
	public class FIXHopsGroup : FIXGroup
	{
		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x00045D0B File Offset: 0x00044D0B
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x00045D1D File Offset: 0x00044D1D
		[FIXField("628", EFieldOption.Optional)]
		public string HopCompID
		{
			get
			{
				return this.GetStringField(628).Value;
			}
			set
			{
				this.AddStringField(628, value);
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x00045D2B File Offset: 0x00044D2B
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x00045D3D File Offset: 0x00044D3D
		[FIXField("629", EFieldOption.Optional)]
		public DateTime HopSendingTime
		{
			get
			{
				return this.GetDateTimeField(629).Value;
			}
			set
			{
				this.AddDateTimeField(629, value);
			}
		}
	}
}
