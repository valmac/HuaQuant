using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000C1 RID: 193
	public class FIXPegInstructionsEventArgs : EventArgs
	{
		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x0002956D File Offset: 0x0002856D
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x00029575 File Offset: 0x00028575
		public FIXPegInstructions PegInstructions
		{
			get
			{
				return this.fPegInstructions;
			}
			set
			{
				this.fPegInstructions = value;
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0002957E File Offset: 0x0002857E
		public FIXPegInstructionsEventArgs(FIXPegInstructions PegInstructions)
		{
			this.fPegInstructions = PegInstructions;
		}

		// Token: 0x0400039F RID: 927
		private FIXPegInstructions fPegInstructions;
	}
}
