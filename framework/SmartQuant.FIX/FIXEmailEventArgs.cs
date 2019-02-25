using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000171 RID: 369
	public class FIXEmailEventArgs : EventArgs
	{
		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x0004CA53 File Offset: 0x0004BA53
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x0004CA5B File Offset: 0x0004BA5B
		public FIXEmail Email
		{
			get
			{
				return this.fEmail;
			}
			set
			{
				this.fEmail = value;
			}
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x0004CA64 File Offset: 0x0004BA64
		public FIXEmailEventArgs(FIXEmail Email)
		{
			this.fEmail = Email;
		}

		// Token: 0x04000D72 RID: 3442
		private FIXEmail fEmail;
	}
}
