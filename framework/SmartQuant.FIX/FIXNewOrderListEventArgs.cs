using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000065 RID: 101
	public class FIXNewOrderListEventArgs : EventArgs
	{
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00014F5D File Offset: 0x00013F5D
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x00014F65 File Offset: 0x00013F65
		public FIXNewOrderList NewOrderList
		{
			get
			{
				return this.fNewOrderList;
			}
			set
			{
				this.fNewOrderList = value;
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00014F6E File Offset: 0x00013F6E
		public FIXNewOrderListEventArgs(FIXNewOrderList NewOrderList)
		{
			this.fNewOrderList = NewOrderList;
		}

		// Token: 0x04000254 RID: 596
		private FIXNewOrderList fNewOrderList;
	}
}
