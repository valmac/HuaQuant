using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000DC RID: 220
	public class FIXQuoteRequestRejectEventArgs : EventArgs
	{
		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x0002DFCE File Offset: 0x0002CFCE
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0002DFD6 File Offset: 0x0002CFD6
		public FIXQuoteRequestReject QuoteRequestReject
		{
			get
			{
				return this.fQuoteRequestReject;
			}
			set
			{
				this.fQuoteRequestReject = value;
			}
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x0002DFDF File Offset: 0x0002CFDF
		public FIXQuoteRequestRejectEventArgs(FIXQuoteRequestReject QuoteRequestReject)
		{
			this.fQuoteRequestReject = QuoteRequestReject;
		}

		// Token: 0x040003CD RID: 973
		private FIXQuoteRequestReject fQuoteRequestReject;
	}
}
