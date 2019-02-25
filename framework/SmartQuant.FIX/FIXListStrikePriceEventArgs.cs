using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000133 RID: 307
	public class FIXListStrikePriceEventArgs : EventArgs
	{
		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x0003D6D1 File Offset: 0x0003C6D1
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x0003D6D9 File Offset: 0x0003C6D9
		public FIXListStrikePrice ListStrikePrice
		{
			get
			{
				return this.fListStrikePrice;
			}
			set
			{
				this.fListStrikePrice = value;
			}
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x0003D6E2 File Offset: 0x0003C6E2
		public FIXListStrikePriceEventArgs(FIXListStrikePrice ListStrikePrice)
		{
			this.fListStrikePrice = ListStrikePrice;
		}

		// Token: 0x04000532 RID: 1330
		private FIXListStrikePrice fListStrikePrice;
	}
}
