using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000C4 RID: 196
	public class FIXListCancelRequestEventArgs : EventArgs
	{
		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x00029675 File Offset: 0x00028675
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x0002967D File Offset: 0x0002867D
		public FIXListCancelRequest ListCancelRequest
		{
			get
			{
				return this.fListCancelRequest;
			}
			set
			{
				this.fListCancelRequest = value;
			}
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00029686 File Offset: 0x00028686
		public FIXListCancelRequestEventArgs(FIXListCancelRequest ListCancelRequest)
		{
			this.fListCancelRequest = ListCancelRequest;
		}

		// Token: 0x040003A1 RID: 929
		private FIXListCancelRequest fListCancelRequest;
	}
}
