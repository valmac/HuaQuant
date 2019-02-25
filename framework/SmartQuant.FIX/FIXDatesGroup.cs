using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000168 RID: 360
	public class FIXDatesGroup : FIXGroup
	{
		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x00049A10 File Offset: 0x00048A10
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x00049A1F File Offset: 0x00048A1F
		[FIXField("75", EFieldOption.Optional)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeField(75).Value;
			}
			set
			{
				this.AddDateTimeField(75, value);
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x00049A2A File Offset: 0x00048A2A
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x00049A39 File Offset: 0x00048A39
		[FIXField("60", EFieldOption.Optional)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeField(60).Value;
			}
			set
			{
				this.AddDateTimeField(60, value);
			}
		}
	}
}
