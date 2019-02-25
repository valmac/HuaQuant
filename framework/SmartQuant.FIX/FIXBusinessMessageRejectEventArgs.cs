using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000CE RID: 206
	public class FIXBusinessMessageRejectEventArgs : EventArgs
	{
		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x0002C4CA File Offset: 0x0002B4CA
		// (set) Token: 0x06002990 RID: 10640 RVA: 0x0002C4D2 File Offset: 0x0002B4D2
		public FIXBusinessMessageReject BusinessMessageReject
		{
			get
			{
				return this.fBusinessMessageReject;
			}
			set
			{
				this.fBusinessMessageReject = value;
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0002C4DB File Offset: 0x0002B4DB
		public FIXBusinessMessageRejectEventArgs(FIXBusinessMessageReject BusinessMessageReject)
		{
			this.fBusinessMessageReject = BusinessMessageReject;
		}

		// Token: 0x040003C0 RID: 960
		private FIXBusinessMessageReject fBusinessMessageReject;
	}
}
