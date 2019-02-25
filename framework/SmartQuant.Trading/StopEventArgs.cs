using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000062 RID: 98
	public class StopEventArgs : EventArgs
	{
		// Token: 0x060003BB RID: 955 RVA: 0x0000EE20 File Offset: 0x0000DE20
		public StopEventArgs(IStop stop)
		{
			this.stop = stop;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000EE2F File Offset: 0x0000DE2F
		public IStop Stop
		{
			get
			{
				return this.stop;
			}
		}

		// Token: 0x0400013A RID: 314
		private IStop stop;
	}
}
