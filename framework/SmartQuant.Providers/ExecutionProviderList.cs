using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200004E RID: 78
	public class ExecutionProviderList : ProviderList
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00005448 File Offset: 0x00004448
		internal ExecutionProviderList()
		{
		}

		// Token: 0x1700007D RID: 125
		public new IExecutionProvider this[string name]
		{
			get
			{
				return base[name] as IExecutionProvider;
			}
		}

		// Token: 0x1700007E RID: 126
		public new IExecutionProvider this[byte id]
		{
			get
			{
				return base[id] as IExecutionProvider;
			}
		}
	}
}
