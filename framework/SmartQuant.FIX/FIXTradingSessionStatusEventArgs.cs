using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000A2 RID: 162
	public class FIXTradingSessionStatusEventArgs : EventArgs
	{
		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00024641 File Offset: 0x00023641
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00024649 File Offset: 0x00023649
		public FIXTradingSessionStatus TradingSessionStatus
		{
			get
			{
				return this.fTradingSessionStatus;
			}
			set
			{
				this.fTradingSessionStatus = value;
			}
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00024652 File Offset: 0x00023652
		public FIXTradingSessionStatusEventArgs(FIXTradingSessionStatus TradingSessionStatus)
		{
			this.fTradingSessionStatus = TradingSessionStatus;
		}

		// Token: 0x0400033B RID: 827
		private FIXTradingSessionStatus fTradingSessionStatus;
	}
}
