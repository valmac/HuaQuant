using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200015F RID: 351
	public class FIXQuoteResponseEventArgs : EventArgs
	{
		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x00047E1C File Offset: 0x00046E1C
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x00047E24 File Offset: 0x00046E24
		public FIXQuoteResponse QuoteResponse
		{
			get
			{
				return this.fQuoteResponse;
			}
			set
			{
				this.fQuoteResponse = value;
			}
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00047E2D File Offset: 0x00046E2D
		public FIXQuoteResponseEventArgs(FIXQuoteResponse QuoteResponse)
		{
			this.fQuoteResponse = QuoteResponse;
		}

		// Token: 0x0400099C RID: 2460
		private FIXQuoteResponse fQuoteResponse;
	}
}
