using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200007A RID: 122
	public class FIXQuoteStatusReportEventArgs : EventArgs
	{
		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00018521 File Offset: 0x00017521
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x00018529 File Offset: 0x00017529
		public FIXQuoteStatusReport QuoteStatusReport
		{
			get
			{
				return this.fQuoteStatusReport;
			}
			set
			{
				this.fQuoteStatusReport = value;
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00018532 File Offset: 0x00017532
		public FIXQuoteStatusReportEventArgs(FIXQuoteStatusReport QuoteStatusReport)
		{
			this.fQuoteStatusReport = QuoteStatusReport;
		}

		// Token: 0x0400028F RID: 655
		private FIXQuoteStatusReport fQuoteStatusReport;
	}
}
