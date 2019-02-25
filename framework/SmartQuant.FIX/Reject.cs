using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200006E RID: 110
	public class Reject : FIXReject
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00016CD5 File Offset: 0x00015CD5
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x00016CE2 File Offset: 0x00015CE2
		public new SessionRejectReason SessionRejectReason
		{
			get
			{
				return FIXSessionRejectReason.FromFIX(base.SessionRejectReason);
			}
			set
			{
				base.SessionRejectReason = FIXSessionRejectReason.ToFIX(value);
			}
		}
	}
}
