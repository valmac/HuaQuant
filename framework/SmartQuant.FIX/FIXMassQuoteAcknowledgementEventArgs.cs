using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000034 RID: 52
	public class FIXMassQuoteAcknowledgementEventArgs : EventArgs
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0000ED67 File Offset: 0x0000DD67
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0000ED6F File Offset: 0x0000DD6F
		public FIXMassQuoteAcknowledgement MassQuoteAcknowledgement
		{
			get
			{
				return this.fMassQuoteAcknowledgement;
			}
			set
			{
				this.fMassQuoteAcknowledgement = value;
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0000ED78 File Offset: 0x0000DD78
		public FIXMassQuoteAcknowledgementEventArgs(FIXMassQuoteAcknowledgement MassQuoteAcknowledgement)
		{
			this.fMassQuoteAcknowledgement = MassQuoteAcknowledgement;
		}

		// Token: 0x04000098 RID: 152
		private FIXMassQuoteAcknowledgement fMassQuoteAcknowledgement;
	}
}
