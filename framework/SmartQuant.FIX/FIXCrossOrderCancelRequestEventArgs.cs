using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000CA RID: 202
	public class FIXCrossOrderCancelRequestEventArgs : EventArgs
	{
		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x0002A01F File Offset: 0x0002901F
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x0002A027 File Offset: 0x00029027
		public FIXCrossOrderCancelRequest CrossOrderCancelRequest
		{
			get
			{
				return this.fCrossOrderCancelRequest;
			}
			set
			{
				this.fCrossOrderCancelRequest = value;
			}
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0002A030 File Offset: 0x00029030
		public FIXCrossOrderCancelRequestEventArgs(FIXCrossOrderCancelRequest CrossOrderCancelRequest)
		{
			this.fCrossOrderCancelRequest = CrossOrderCancelRequest;
		}

		// Token: 0x040003A9 RID: 937
		private FIXCrossOrderCancelRequest fCrossOrderCancelRequest;
	}
}
