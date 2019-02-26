using System;

namespace SmartQuant.Services
{
	// Token: 0x02000010 RID: 16
	public class ExecutionServiceList : ServiceList
	{
		// Token: 0x17000016 RID: 22
		public new IExecutionService this[string name]
		{
			get
			{
				return base[name] as IExecutionService;
			}
		}

		// Token: 0x17000017 RID: 23
		public new IExecutionService this[byte id]
		{
			get
			{
				return base[id] as IExecutionService;
			}
		}
	}
}
