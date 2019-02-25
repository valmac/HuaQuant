using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000084 RID: 132
	public class FIXDiscretionInstructionsEventArgs : EventArgs
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x0001BBAD File Offset: 0x0001ABAD
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x0001BBB5 File Offset: 0x0001ABB5
		public FIXDiscretionInstructions DiscretionInstructions
		{
			get
			{
				return this.fDiscretionInstructions;
			}
			set
			{
				this.fDiscretionInstructions = value;
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0001BBBE File Offset: 0x0001ABBE
		public FIXDiscretionInstructionsEventArgs(FIXDiscretionInstructions DiscretionInstructions)
		{
			this.fDiscretionInstructions = DiscretionInstructions;
		}

		// Token: 0x040002AA RID: 682
		private FIXDiscretionInstructions fDiscretionInstructions;
	}
}
