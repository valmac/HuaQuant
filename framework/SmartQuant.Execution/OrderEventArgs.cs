using System;

namespace SmartQuant.Execution
{
	// Token: 0x02000005 RID: 5
	public class OrderEventArgs
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002905 File Offset: 0x00001905
		public OrderEventArgs(SingleOrder order)
		{
			this.order = order;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002914 File Offset: 0x00001914
		public SingleOrder Order
		{
			get
			{
				return this.order;
			}
		}

		// Token: 0x0400000E RID: 14
		private SingleOrder order;
	}
}
