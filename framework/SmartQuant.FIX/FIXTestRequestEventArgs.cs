using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200001D RID: 29
	public class FIXTestRequestEventArgs : EventArgs
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00007D25 File Offset: 0x00006D25
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00007D2D File Offset: 0x00006D2D
		public FIXTestRequest TestRequest
		{
			get
			{
				return this.fTestRequest;
			}
			set
			{
				this.fTestRequest = value;
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00007D36 File Offset: 0x00006D36
		public FIXTestRequestEventArgs(FIXTestRequest TestRequest)
		{
			this.fTestRequest = TestRequest;
		}

		// Token: 0x04000044 RID: 68
		private FIXTestRequest fTestRequest;
	}
}
