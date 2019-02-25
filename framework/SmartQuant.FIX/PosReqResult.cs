using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000176 RID: 374
	public enum PosReqResult
	{
		// Token: 0x04000D7E RID: 3454
		ValidRequest,
		// Token: 0x04000D7F RID: 3455
		InvalidOrUnsupportedRequest,
		// Token: 0x04000D80 RID: 3456
		NoPositionsFound,
		// Token: 0x04000D81 RID: 3457
		NotAuthorized,
		// Token: 0x04000D82 RID: 3458
		RequestForPositionNotSupported,
		// Token: 0x04000D83 RID: 3459
		Other
	}
}
