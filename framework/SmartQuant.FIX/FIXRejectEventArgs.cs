using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000A4 RID: 164
	public class FIXRejectEventArgs : EventArgs
	{
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00024C86 File Offset: 0x00023C86
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00024C8E File Offset: 0x00023C8E
		public FIXReject Reject
		{
			get
			{
				return this.fReject;
			}
			set
			{
				this.fReject = value;
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00024C97 File Offset: 0x00023C97
		public FIXRejectEventArgs(FIXReject Reject)
		{
			this.fReject = Reject;
		}

		// Token: 0x0400033F RID: 831
		private FIXReject fReject;
	}
}
