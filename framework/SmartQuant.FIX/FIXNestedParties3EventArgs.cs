using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200016D RID: 365
	public class FIXNestedParties3EventArgs : EventArgs
	{
		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x0004C545 File Offset: 0x0004B545
		// (set) Token: 0x060044AE RID: 17582 RVA: 0x0004C54D File Offset: 0x0004B54D
		public FIXNestedParties3 NestedParties3
		{
			get
			{
				return this.fNestedParties3;
			}
			set
			{
				this.fNestedParties3 = value;
			}
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x0004C556 File Offset: 0x0004B556
		public FIXNestedParties3EventArgs(FIXNestedParties3 NestedParties3)
		{
			this.fNestedParties3 = NestedParties3;
		}

		// Token: 0x04000D6D RID: 3437
		private FIXNestedParties3 fNestedParties3;
	}
}
