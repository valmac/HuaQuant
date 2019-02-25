using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000E0 RID: 224
	public class FIXCrossOrderCancelReplaceRequestEventArgs : EventArgs
	{
		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x0002E954 File Offset: 0x0002D954
		// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x0002E95C File Offset: 0x0002D95C
		public FIXCrossOrderCancelReplaceRequest CrossOrderCancelReplaceRequest
		{
			get
			{
				return this.fCrossOrderCancelReplaceRequest;
			}
			set
			{
				this.fCrossOrderCancelReplaceRequest = value;
			}
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0002E965 File Offset: 0x0002D965
		public FIXCrossOrderCancelReplaceRequestEventArgs(FIXCrossOrderCancelReplaceRequest CrossOrderCancelReplaceRequest)
		{
			this.fCrossOrderCancelReplaceRequest = CrossOrderCancelReplaceRequest;
		}

		// Token: 0x040003D4 RID: 980
		private FIXCrossOrderCancelReplaceRequest fCrossOrderCancelReplaceRequest;
	}
}
