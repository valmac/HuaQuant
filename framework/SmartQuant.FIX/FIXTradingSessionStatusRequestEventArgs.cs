using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000D8 RID: 216
	public class FIXTradingSessionStatusRequestEventArgs : EventArgs
	{
		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x0002D70B File Offset: 0x0002C70B
		// (set) Token: 0x06002AB9 RID: 10937 RVA: 0x0002D713 File Offset: 0x0002C713
		public FIXTradingSessionStatusRequest TradingSessionStatusRequest
		{
			get
			{
				return this.fTradingSessionStatusRequest;
			}
			set
			{
				this.fTradingSessionStatusRequest = value;
			}
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0002D71C File Offset: 0x0002C71C
		public FIXTradingSessionStatusRequestEventArgs(FIXTradingSessionStatusRequest TradingSessionStatusRequest)
		{
			this.fTradingSessionStatusRequest = TradingSessionStatusRequest;
		}

		// Token: 0x040003C7 RID: 967
		private FIXTradingSessionStatusRequest fTradingSessionStatusRequest;
	}
}
