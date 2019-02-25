using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E2 RID: 226
	public class FIXConfirmationRequestEventArgs : EventArgs
	{
		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x0002FD27 File Offset: 0x0002ED27
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x0002FD2F File Offset: 0x0002ED2F
		public FIXConfirmationRequest ConfirmationRequest
		{
			get
			{
				return this.fConfirmationRequest;
			}
			set
			{
				this.fConfirmationRequest = value;
			}
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x0002FD38 File Offset: 0x0002ED38
		public FIXConfirmationRequestEventArgs(FIXConfirmationRequest ConfirmationRequest)
		{
			this.fConfirmationRequest = ConfirmationRequest;
		}

		// Token: 0x040003DE RID: 990
		private FIXConfirmationRequest fConfirmationRequest;
	}
}
