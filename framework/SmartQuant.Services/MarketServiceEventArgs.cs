using System;

namespace SmartQuant.Services
{
	// Token: 0x02000005 RID: 5
	public class MarketServiceEventArgs : ServiceEventArgs
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002067 File Offset: 0x00001067
		public MarketServiceEventArgs(IMarketService service) : base(service)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002070 File Offset: 0x00001070
		public new IMarketService Service
		{
			get
			{
				return base.Service as IMarketService;
			}
		}
	}
}
