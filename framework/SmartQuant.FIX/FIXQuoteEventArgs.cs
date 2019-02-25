using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200012D RID: 301
	public class FIXQuoteEventArgs : EventArgs
	{
		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x0003B1FF File Offset: 0x0003A1FF
		// (set) Token: 0x06003823 RID: 14371 RVA: 0x0003B207 File Offset: 0x0003A207
		public FIXQuote Quote
		{
			get
			{
				return this.fQuote;
			}
			set
			{
				this.fQuote = value;
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0003B210 File Offset: 0x0003A210
		public FIXQuoteEventArgs(FIXQuote Quote)
		{
			this.fQuote = Quote;
		}

		// Token: 0x0400051D RID: 1309
		private FIXQuote fQuote;
	}
}
