using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000AD RID: 173
	public class FIXMassQuoteEventArgs : EventArgs
	{
		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000274F0 File Offset: 0x000264F0
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x000274F8 File Offset: 0x000264F8
		public FIXMassQuote MassQuote
		{
			get
			{
				return this.fMassQuote;
			}
			set
			{
				this.fMassQuote = value;
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00027501 File Offset: 0x00026501
		public FIXMassQuoteEventArgs(FIXMassQuote MassQuote)
		{
			this.fMassQuote = MassQuote;
		}

		// Token: 0x04000357 RID: 855
		private FIXMassQuote fMassQuote;
	}
}
