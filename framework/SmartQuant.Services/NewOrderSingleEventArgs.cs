using System;
using SmartQuant.FIX;

namespace SmartQuant.Services
{
	// Token: 0x02000012 RID: 18
	public class NewOrderSingleEventArgs : ExecutionServiceEventArgs
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002308 File Offset: 0x00001308
		public NewOrderSingleEventArgs(IExecutionService service, FIXNewOrderSingle order) : base(service)
		{
			this.order = order;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002318 File Offset: 0x00001318
		public FIXNewOrderSingle Order
		{
			get
			{
				return this.order;
			}
		}

		// Token: 0x0400000C RID: 12
		private FIXNewOrderSingle order;
	}
}
