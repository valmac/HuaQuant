using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000027 RID: 39
	public class HistoricalDataProviderList : ProviderList
	{
		// Token: 0x060000DB RID: 219 RVA: 0x0000351E File Offset: 0x0000251E
		internal HistoricalDataProviderList()
		{
		}

		// Token: 0x17000031 RID: 49
		public new IHistoricalDataProvider this[string name]
		{
			get
			{
				return base[name] as IHistoricalDataProvider;
			}
		}

		// Token: 0x17000032 RID: 50
		public new IHistoricalDataProvider this[byte id]
		{
			get
			{
				return base[id] as IHistoricalDataProvider;
			}
		}
	}
}
