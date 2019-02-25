using System;
using System.Collections.Specialized;
using SmartQuant.Providers;

namespace SmartQuant.Trading
{
	// Token: 0x02000074 RID: 116
	internal class ProviderDispatcher
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x00011800 File Offset: 0x00010800
		public ProviderDispatcher(MetaStrategyBase metaStrategyBase)
		{
			this.metaStrategyBase = metaStrategyBase;
			this.providers = new ListDictionary();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001181A File Offset: 0x0001081A
		public void Init()
		{
			this.providers.Clear();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00011827 File Offset: 0x00010827
		public void Add(IProvider provider)
		{
			if (!this.providers.Contains(provider))
			{
				this.providers.Add(provider, null);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00011844 File Offset: 0x00010844
		public void Online(int timeout)
		{
			ProviderManager.Connected += this.ProviderManager_Connected;
			ProviderManager.Disconnected += this.ProviderManager_Disconnected;
			ProviderManager.Error += this.ProviderManager_Error;
			foreach (object obj in this.providers.Keys)
			{
				IProvider provider = (IProvider)obj;
				if (!provider.IsConnected)
				{
					provider.Connect(timeout);
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000118E0 File Offset: 0x000108E0
		public void Offline()
		{
			ProviderManager.Connected -= this.ProviderManager_Connected;
			ProviderManager.Disconnected -= this.ProviderManager_Disconnected;
			ProviderManager.Error -= this.ProviderManager_Error;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00011915 File Offset: 0x00010915
		private void ProviderManager_Connected(ProviderEventArgs args)
		{
			if (this.providers.Contains(args.Provider))
			{
				this.metaStrategyBase.SetProviderConnected(args);
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00011936 File Offset: 0x00010936
		private void ProviderManager_Disconnected(ProviderEventArgs args)
		{
			if (this.providers.Contains(args.Provider))
			{
				this.metaStrategyBase.SetProviderDisconnected(args);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00011957 File Offset: 0x00010957
		private void ProviderManager_Error(ProviderErrorEventArgs args)
		{
			if (this.providers.Contains(args.Error.Provider))
			{
				this.metaStrategyBase.SetProviderError(args);
			}
		}

		// Token: 0x04000182 RID: 386
		private MetaStrategyBase metaStrategyBase;

		// Token: 0x04000183 RID: 387
		private ListDictionary providers;
	}
}
