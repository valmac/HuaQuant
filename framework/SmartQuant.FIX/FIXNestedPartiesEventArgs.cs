using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000AB RID: 171
	public class FIXNestedPartiesEventArgs : EventArgs
	{
		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x00027462 File Offset: 0x00026462
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0002746A File Offset: 0x0002646A
		public FIXNestedParties NestedParties
		{
			get
			{
				return this.fNestedParties;
			}
			set
			{
				this.fNestedParties = value;
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00027473 File Offset: 0x00026473
		public FIXNestedPartiesEventArgs(FIXNestedParties NestedParties)
		{
			this.fNestedParties = NestedParties;
		}

		// Token: 0x04000355 RID: 853
		private FIXNestedParties fNestedParties;
	}
}
