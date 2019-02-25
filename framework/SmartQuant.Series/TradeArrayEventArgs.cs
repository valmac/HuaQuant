using System;

namespace SmartQuant.Series
{
	// Token: 0x02000012 RID: 18
	public class TradeArrayEventArgs : EventArgs
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0000BAE5 File Offset: 0x0000AAE5
		public TradeArrayEventArgs(TradeArray array)
		{
			this.array = array;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000BAF4 File Offset: 0x0000AAF4
		public TradeArray TradeArray
		{
			get
			{
				return this.array;
			}
		}

		// Token: 0x04000040 RID: 64
		private TradeArray array;
	}
}
