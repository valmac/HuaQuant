using System;
using System.Collections.Generic;
using SmartQuant.Providers;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000032 RID: 50
	public class ExecutionProviderTypeEditor : ComboBoxTypeEditor
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00009D8B File Offset: 0x00008D8B
		public ExecutionProviderTypeEditor() : base(true)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00009D94 File Offset: 0x00008D94
		protected override List<KeyValuePair<string, object>> GetItems()
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			foreach (object obj in ProviderManager.ExecutionProviders)
			{
				IProvider provider = (IProvider)obj;
				list.Add(new KeyValuePair<string, object>(provider.Name, provider));
			}
			return list;
		}
	}
}
