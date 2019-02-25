using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200000D RID: 13
	public class OrderCancelReject : FIXOrderCancelReject
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000710E File Offset: 0x0000610E
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x0000711B File Offset: 0x0000611B
		public new OrdStatus OrdStatus
		{
			get
			{
				return FIXOrdStatus.FromFIX(base.OrdStatus);
			}
			set
			{
				base.OrdStatus = FIXOrdStatus.ToFIX(value);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00007129 File Offset: 0x00006129
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00007136 File Offset: 0x00006136
		public new CxlRejResponseTo CxlRejResponseTo
		{
			get
			{
				return FIXCxlRejResponseTo.FromFIX(base.CxlRejResponseTo);
			}
			set
			{
				base.CxlRejResponseTo = FIXCxlRejResponseTo.ToFIX(value);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00007144 File Offset: 0x00006144
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00007151 File Offset: 0x00006151
		public new CxlRejReason CxlRejReason
		{
			get
			{
				return FIXCxlRejReason.FromFIX(base.CxlRejReason);
			}
			set
			{
				base.CxlRejReason = FIXCxlRejReason.ToFIX(value);
			}
		}
	}
}
