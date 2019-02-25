using System;
using System.Collections.Generic;
using SmartQuant.Services;

namespace SmartQuant.Trading.Design
{
	// Token: 0x0200005C RID: 92
	internal class ExecutionServiceTypeEditor : ComboBoxTypeEditor
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0000EAF9 File Offset: 0x0000DAF9
		public ExecutionServiceTypeEditor() : base(true)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000EB04 File Offset: 0x0000DB04
		protected override List<KeyValuePair<string, object>> GetItems()
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			foreach (object obj in ServiceManager.Services)
			{
				IService service = (IService)obj;
				if (service is IExecutionService)
				{
					list.Add(new KeyValuePair<string, object>(service.Name, service));
				}
			}
			return list;
		}
	}
}
