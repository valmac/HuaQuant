using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200000D RID: 13
	public class ProviderEventArgs : EventArgs
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002237 File Offset: 0x00001237
		public ProviderEventArgs(IProvider provider)
		{
			this.provider = provider;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002246 File Offset: 0x00001246
		public IProvider Provider
		{
			get
			{
				return this.provider;
			}
		}

		// Token: 0x04000029 RID: 41
		private IProvider provider;
	}
}
