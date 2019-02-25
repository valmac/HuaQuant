using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000187 RID: 391
	public class FIXNestedParties2EventArgs : EventArgs
	{
		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x000524B7 File Offset: 0x000514B7
		// (set) Token: 0x06004A62 RID: 19042 RVA: 0x000524BF File Offset: 0x000514BF
		public FIXNestedParties2 NestedParties2
		{
			get
			{
				return this.fNestedParties2;
			}
			set
			{
				this.fNestedParties2 = value;
			}
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x000524C8 File Offset: 0x000514C8
		public FIXNestedParties2EventArgs(FIXNestedParties2 NestedParties2)
		{
			this.fNestedParties2 = NestedParties2;
		}

		// Token: 0x04000DB5 RID: 3509
		private FIXNestedParties2 fNestedParties2;
	}
}
