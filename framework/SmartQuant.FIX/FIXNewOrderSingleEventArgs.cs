using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000032 RID: 50
	public class FIXNewOrderSingleEventArgs : EventArgs
	{
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0000D70A File Offset: 0x0000C70A
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0000D712 File Offset: 0x0000C712
		public FIXNewOrderSingle NewOrderSingle
		{
			get
			{
				return this.fNewOrderSingle;
			}
			set
			{
				this.fNewOrderSingle = value;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000D71B File Offset: 0x0000C71B
		public FIXNewOrderSingleEventArgs(FIXNewOrderSingle NewOrderSingle)
		{
			this.fNewOrderSingle = NewOrderSingle;
		}

		// Token: 0x0400008E RID: 142
		private FIXNewOrderSingle fNewOrderSingle;
	}
}
