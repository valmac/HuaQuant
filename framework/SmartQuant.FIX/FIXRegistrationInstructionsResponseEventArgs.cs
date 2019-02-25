using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000113 RID: 275
	public class FIXRegistrationInstructionsResponseEventArgs : EventArgs
	{
		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x00036862 File Offset: 0x00035862
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x0003686A File Offset: 0x0003586A
		public FIXRegistrationInstructionsResponse RegistrationInstructionsResponse
		{
			get
			{
				return this.fRegistrationInstructionsResponse;
			}
			set
			{
				this.fRegistrationInstructionsResponse = value;
			}
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00036873 File Offset: 0x00035873
		public FIXRegistrationInstructionsResponseEventArgs(FIXRegistrationInstructionsResponse RegistrationInstructionsResponse)
		{
			this.fRegistrationInstructionsResponse = RegistrationInstructionsResponse;
		}

		// Token: 0x040004F1 RID: 1265
		private FIXRegistrationInstructionsResponse fRegistrationInstructionsResponse;
	}
}
