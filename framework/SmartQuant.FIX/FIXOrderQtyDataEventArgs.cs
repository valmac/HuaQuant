using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000131 RID: 305
	public class FIXOrderQtyDataEventArgs : EventArgs
	{
		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06003A46 RID: 14918 RVA: 0x0003D60F File Offset: 0x0003C60F
		// (set) Token: 0x06003A47 RID: 14919 RVA: 0x0003D617 File Offset: 0x0003C617
		public FIXOrderQtyData OrderQtyData
		{
			get
			{
				return this.fOrderQtyData;
			}
			set
			{
				this.fOrderQtyData = value;
			}
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x0003D620 File Offset: 0x0003C620
		public FIXOrderQtyDataEventArgs(FIXOrderQtyData OrderQtyData)
		{
			this.fOrderQtyData = OrderQtyData;
		}

		// Token: 0x04000531 RID: 1329
		private FIXOrderQtyData fOrderQtyData;
	}
}
