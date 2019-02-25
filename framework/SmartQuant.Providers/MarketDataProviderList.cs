using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200003D RID: 61
	public class MarketDataProviderList : ProviderList
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00004AC6 File Offset: 0x00003AC6
		internal MarketDataProviderList()
		{
		}

		// Token: 0x17000051 RID: 81
		public new IMarketDataProvider this[string name]
		{
			get
			{
				return base[name] as IMarketDataProvider;
			}
		}

		// Token: 0x17000052 RID: 82
		public new IMarketDataProvider this[byte id]
		{
			get
			{
				return base[id] as IMarketDataProvider;
			}
		}
	}
}
