using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000BA RID: 186
	public enum SessionRejectReason
	{
		// Token: 0x04000378 RID: 888
		InvalidTagNumber,
		// Token: 0x04000379 RID: 889
		RequiredTagMissing,
		// Token: 0x0400037A RID: 890
		TagNotDefined,
		// Token: 0x0400037B RID: 891
		UndefinedTag,
		// Token: 0x0400037C RID: 892
		TagSpecifiedWithoutAValue,
		// Token: 0x0400037D RID: 893
		ValueIsIncorrect,
		// Token: 0x0400037E RID: 894
		IncorrectDataFormat,
		// Token: 0x0400037F RID: 895
		DecryptionProblem,
		// Token: 0x04000380 RID: 896
		SignatureProblem,
		// Token: 0x04000381 RID: 897
		CompIDProblem,
		// Token: 0x04000382 RID: 898
		SendingTimeAccuracyProblem,
		// Token: 0x04000383 RID: 899
		InvalidMsgType
	}
}
