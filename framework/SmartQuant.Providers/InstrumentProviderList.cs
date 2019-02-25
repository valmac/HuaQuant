using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000031 RID: 49
	public class InstrumentProviderList : ProviderList
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00004880 File Offset: 0x00003880
		internal InstrumentProviderList()
		{
		}

		// Token: 0x17000046 RID: 70
		public new IInstrumentProvider this[string name]
		{
			get
			{
				return base[name] as IInstrumentProvider;
			}
		}

		// Token: 0x17000047 RID: 71
		public new IInstrumentProvider this[byte id]
		{
			get
			{
				return base[id] as IInstrumentProvider;
			}
		}
	}
}
