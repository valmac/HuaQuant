using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200003B RID: 59
	public class RequestForPositions : FIXRequestForPositions
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000119AC File Offset: 0x000109AC
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x000119B9 File Offset: 0x000109B9
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
	}
}
