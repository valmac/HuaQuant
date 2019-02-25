using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000090 RID: 144
	public class FIXResendRequestEventArgs : EventArgs
	{
		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0001E761 File Offset: 0x0001D761
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0001E769 File Offset: 0x0001D769
		public FIXResendRequest ResendRequest
		{
			get
			{
				return this.fResendRequest;
			}
			set
			{
				this.fResendRequest = value;
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0001E772 File Offset: 0x0001D772
		public FIXResendRequestEventArgs(FIXResendRequest ResendRequest)
		{
			this.fResendRequest = ResendRequest;
		}

		// Token: 0x040002DF RID: 735
		private FIXResendRequest fResendRequest;
	}
}
