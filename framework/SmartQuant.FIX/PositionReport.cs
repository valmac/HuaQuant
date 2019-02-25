using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E6 RID: 230
	public class PositionReport : FIXPositionReport
	{
		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x00030FC6 File Offset: 0x0002FFC6
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x00030FD3 File Offset: 0x0002FFD3
		public new PosReqType PosReqType
		{
			get
			{
				return FIXPosReqType.FromFIX(base.PosReqType);
			}
			set
			{
				base.PosReqType = FIXPosReqType.ToFIX(value);
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x00030FE1 File Offset: 0x0002FFE1
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x00030FEE File Offset: 0x0002FFEE
		public new PosReqResult PosReqResult
		{
			get
			{
				return FIXPosReqResult.FromFIX(base.PosReqResult);
			}
			set
			{
				base.PosReqResult = FIXPosReqResult.ToFIX(value);
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x00030FFC File Offset: 0x0002FFFC
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x00031009 File Offset: 0x00030009
		public new PutOrCall PutOrCall
		{
			get
			{
				return FIXPutOrCall.FromFIX(base.PutOrCall);
			}
			set
			{
				base.PutOrCall = FIXPutOrCall.ToFIX(value);
			}
		}
	}
}
