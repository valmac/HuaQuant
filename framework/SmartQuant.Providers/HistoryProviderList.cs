using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000020 RID: 32
	public class HistoryProviderList : ProviderList
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00003242 File Offset: 0x00002242
		internal HistoryProviderList()
		{
		}

		// Token: 0x1700002B RID: 43
		public new IHistoryProvider this[string name]
		{
			get
			{
				return base[name] as IHistoryProvider;
			}
		}

		// Token: 0x1700002C RID: 44
		public new IHistoryProvider this[byte id]
		{
			get
			{
				return base[id] as IHistoryProvider;
			}
		}
	}
}
