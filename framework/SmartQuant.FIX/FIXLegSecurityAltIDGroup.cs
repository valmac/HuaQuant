using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000152 RID: 338
	public class FIXLegSecurityAltIDGroup : FIXGroup
	{
		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x00045CC3 File Offset: 0x00044CC3
		// (set) Token: 0x0600401C RID: 16412 RVA: 0x00045CD5 File Offset: 0x00044CD5
		[FIXField("605", EFieldOption.Optional)]
		public string LegSecurityAltID
		{
			get
			{
				return this.GetStringField(605).Value;
			}
			set
			{
				this.AddStringField(605, value);
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x00045CE3 File Offset: 0x00044CE3
		// (set) Token: 0x0600401E RID: 16414 RVA: 0x00045CF5 File Offset: 0x00044CF5
		[FIXField("606", EFieldOption.Optional)]
		public string LegSecurityAltIDSource
		{
			get
			{
				return this.GetStringField(606).Value;
			}
			set
			{
				this.AddStringField(606, value);
			}
		}
	}
}
