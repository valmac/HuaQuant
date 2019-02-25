using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000149 RID: 329
	public class FIXQuoteRequestEventArgs : EventArgs
	{
		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x00045041 File Offset: 0x00044041
		// (set) Token: 0x06003F4B RID: 16203 RVA: 0x00045049 File Offset: 0x00044049
		public FIXQuoteRequest QuoteRequest
		{
			get
			{
				return this.fQuoteRequest;
			}
			set
			{
				this.fQuoteRequest = value;
			}
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00045052 File Offset: 0x00044052
		public FIXQuoteRequestEventArgs(FIXQuoteRequest QuoteRequest)
		{
			this.fQuoteRequest = QuoteRequest;
		}

		// Token: 0x04000950 RID: 2384
		private FIXQuoteRequest fQuoteRequest;
	}
}
