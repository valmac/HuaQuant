using System;

namespace SmartQuant.Services
{
	// Token: 0x02000006 RID: 6
	public class ExecutionServiceEventArgs : MarketServiceEventArgs
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000207D File Offset: 0x0000107D
		public ExecutionServiceEventArgs(IExecutionService service) : base(service)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002086 File Offset: 0x00001086
		public new IExecutionService Service
		{
			get
			{
				return base.Service as IExecutionService;
			}
		}
	}
}
