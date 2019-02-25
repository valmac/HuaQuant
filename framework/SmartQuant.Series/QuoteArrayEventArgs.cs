using System;

namespace SmartQuant.Series
{
	// Token: 0x02000011 RID: 17
	public class QuoteArrayEventArgs : EventArgs
	{
		// Token: 0x06000280 RID: 640 RVA: 0x0000BACE File Offset: 0x0000AACE
		public QuoteArrayEventArgs(QuoteArray array)
		{
			this.array = array;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000BADD File Offset: 0x0000AADD
		public QuoteArray QuoteArray
		{
			get
			{
				return this.array;
			}
		}

		// Token: 0x0400003F RID: 63
		private QuoteArray array;
	}
}
