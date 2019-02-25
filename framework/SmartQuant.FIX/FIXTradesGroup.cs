using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000107 RID: 263
	public class FIXTradesGroup : FIXGroup
	{
		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x00034448 File Offset: 0x00033448
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0003445A File Offset: 0x0003345A
		[FIXField("571", EFieldOption.Optional)]
		public string TradeReportID
		{
			get
			{
				return this.GetStringField(571).Value;
			}
			set
			{
				this.AddStringField(571, value);
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x00034468 File Offset: 0x00033468
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x0003447A File Offset: 0x0003347A
		[FIXField("818", EFieldOption.Optional)]
		public string SecondaryTradeReportID
		{
			get
			{
				return this.GetStringField(818).Value;
			}
			set
			{
				this.AddStringField(818, value);
			}
		}
	}
}
