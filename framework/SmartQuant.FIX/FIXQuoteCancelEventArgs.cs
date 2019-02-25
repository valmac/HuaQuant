using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000BF RID: 191
	public class FIXQuoteCancelEventArgs : EventArgs
	{
		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00028F5A File Offset: 0x00027F5A
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00028F62 File Offset: 0x00027F62
		public FIXQuoteCancel QuoteCancel
		{
			get
			{
				return this.fQuoteCancel;
			}
			set
			{
				this.fQuoteCancel = value;
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00028F6B File Offset: 0x00027F6B
		public FIXQuoteCancelEventArgs(FIXQuoteCancel QuoteCancel)
		{
			this.fQuoteCancel = QuoteCancel;
		}

		// Token: 0x0400039A RID: 922
		private FIXQuoteCancel fQuoteCancel;
	}
}
