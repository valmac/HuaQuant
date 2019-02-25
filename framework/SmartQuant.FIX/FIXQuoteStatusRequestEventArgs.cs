using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000092 RID: 146
	public class FIXQuoteStatusRequestEventArgs : EventArgs
	{
		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0001EB75 File Offset: 0x0001DB75
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x0001EB7D File Offset: 0x0001DB7D
		public FIXQuoteStatusRequest QuoteStatusRequest
		{
			get
			{
				return this.fQuoteStatusRequest;
			}
			set
			{
				this.fQuoteStatusRequest = value;
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0001EB86 File Offset: 0x0001DB86
		public FIXQuoteStatusRequestEventArgs(FIXQuoteStatusRequest QuoteStatusRequest)
		{
			this.fQuoteStatusRequest = QuoteStatusRequest;
		}

		// Token: 0x040002E3 RID: 739
		private FIXQuoteStatusRequest fQuoteStatusRequest;
	}
}
