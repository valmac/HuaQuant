using System;
using SmartQuant.FIX;
using SmartQuant.Services;

namespace SmartQuant.Trading
{
	// Token: 0x02000014 RID: 20
	internal class OrderServicePair
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000547F File Offset: 0x0000447F
		public OrderServicePair(FIXNewOrderSingle order, IExecutionService service)
		{
			this.order = order;
			this.service = service;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00005495 File Offset: 0x00004495
		public FIXNewOrderSingle Order
		{
			get
			{
				return this.order;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000549D File Offset: 0x0000449D
		public IExecutionService Service
		{
			get
			{
				return this.service;
			}
		}

		// Token: 0x04000058 RID: 88
		private FIXNewOrderSingle order;

		// Token: 0x04000059 RID: 89
		private IExecutionService service;
	}
}
