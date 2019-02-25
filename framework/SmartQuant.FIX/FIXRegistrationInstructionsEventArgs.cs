using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200012B RID: 299
	public class FIXRegistrationInstructionsEventArgs : EventArgs
	{
		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x0003AB73 File Offset: 0x00039B73
		// (set) Token: 0x060037C0 RID: 14272 RVA: 0x0003AB7B File Offset: 0x00039B7B
		public FIXRegistrationInstructions RegistrationInstructions
		{
			get
			{
				return this.fRegistrationInstructions;
			}
			set
			{
				this.fRegistrationInstructions = value;
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x0003AB84 File Offset: 0x00039B84
		public FIXRegistrationInstructionsEventArgs(FIXRegistrationInstructions RegistrationInstructions)
		{
			this.fRegistrationInstructions = RegistrationInstructions;
		}

		// Token: 0x04000517 RID: 1303
		private FIXRegistrationInstructions fRegistrationInstructions;
	}
}
