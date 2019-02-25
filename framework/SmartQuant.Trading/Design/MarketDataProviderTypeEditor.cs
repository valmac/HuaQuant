using System;
using System.Collections.Generic;
using SmartQuant.Providers;

namespace SmartQuant.Trading.Design
{
	// Token: 0x0200004E RID: 78
	public class MarketDataProviderTypeEditor : ComboBoxTypeEditor
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0000C74A File Offset: 0x0000B74A
		public MarketDataProviderTypeEditor() : base(true)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000C754 File Offset: 0x0000B754
		protected override List<KeyValuePair<string, object>> GetItems()
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			foreach (object obj in ProviderManager.MarketDataProviders)
			{
				IProvider provider = (IProvider)obj;
				list.Add(new KeyValuePair<string, object>(provider.Name, provider));
			}
			return list;
		}
	}
}
