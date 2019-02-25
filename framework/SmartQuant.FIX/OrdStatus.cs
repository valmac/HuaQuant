using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000ED RID: 237
	public enum OrdStatus
	{
		// Token: 0x04000409 RID: 1033
		Undefined,
		// Token: 0x0400040A RID: 1034
		New,
		// Token: 0x0400040B RID: 1035
		PartiallyFilled,
		// Token: 0x0400040C RID: 1036
		Filled,
		// Token: 0x0400040D RID: 1037
		DoneForDay,
		// Token: 0x0400040E RID: 1038
		Cancelled,
		// Token: 0x0400040F RID: 1039
		Replaced,
		// Token: 0x04000410 RID: 1040
		PendingCancel,
		// Token: 0x04000411 RID: 1041
		Stopped,
		// Token: 0x04000412 RID: 1042
		Rejected,
		// Token: 0x04000413 RID: 1043
		Suspended,
		// Token: 0x04000414 RID: 1044
		PendingNew,
		// Token: 0x04000415 RID: 1045
		Calculated,
		// Token: 0x04000416 RID: 1046
		Expired,
		// Token: 0x04000417 RID: 1047
		AcceptedForBidding,
		// Token: 0x04000418 RID: 1048
		PendingReplace
	}
}
