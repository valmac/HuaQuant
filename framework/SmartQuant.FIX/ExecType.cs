using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000047 RID: 71
	public enum ExecType
	{
		// Token: 0x04000168 RID: 360
		Undefined,
		// Token: 0x04000169 RID: 361
		New,
		// Token: 0x0400016A RID: 362
		PartialFill,
		// Token: 0x0400016B RID: 363
		Fill,
		// Token: 0x0400016C RID: 364
		DoneForDay,
		// Token: 0x0400016D RID: 365
		Cancelled,
		// Token: 0x0400016E RID: 366
		Replace,
		// Token: 0x0400016F RID: 367
		PendingCancel,
		// Token: 0x04000170 RID: 368
		Stopped,
		// Token: 0x04000171 RID: 369
		Rejected,
		// Token: 0x04000172 RID: 370
		Suspended,
		// Token: 0x04000173 RID: 371
		PendingNew,
		// Token: 0x04000174 RID: 372
		Calculated,
		// Token: 0x04000175 RID: 373
		Expired,
		// Token: 0x04000176 RID: 374
		Restarted,
		// Token: 0x04000177 RID: 375
		PendingReplace,
		// Token: 0x04000178 RID: 376
		Trade,
		// Token: 0x04000179 RID: 377
		TradeCorrect,
		// Token: 0x0400017A RID: 378
		TradeCancel,
		// Token: 0x0400017B RID: 379
		OrderStatus
	}
}
