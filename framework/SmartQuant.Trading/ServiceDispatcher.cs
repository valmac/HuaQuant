using System;
using System.Collections.Specialized;
using SmartQuant.Services;

namespace SmartQuant.Trading
{
	// Token: 0x0200005A RID: 90
	internal class ServiceDispatcher
	{
		// Token: 0x06000397 RID: 919 RVA: 0x0000E9B5 File Offset: 0x0000D9B5
		public ServiceDispatcher(MetaStrategyBase metaStrategyBase)
		{
			this.metaStrategyBase = metaStrategyBase;
			this.services = new ListDictionary();
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000E9CF File Offset: 0x0000D9CF
		public void Init()
		{
			this.services.Clear();
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000E9DC File Offset: 0x0000D9DC
		public void Add(IService service)
		{
			if (!this.services.Contains(service))
			{
				this.services.Add(service, null);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000E9FC File Offset: 0x0000D9FC
		public void Online()
		{
			ServiceManager.ServiceStatusChanged += this.ServiceManager_ServiceStatusChanged;
			ServiceManager.ServiceError += this.ServiceManager_ServiceError;
			foreach (object obj in this.services.Keys)
			{
				IService service = (IService)obj;
				if (service.Status == ServiceStatus.Stopped)
				{
					service.Start();
				}
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000EA84 File Offset: 0x0000DA84
		public void Offline()
		{
			ServiceManager.ServiceStatusChanged -= this.ServiceManager_ServiceStatusChanged;
			ServiceManager.ServiceError -= this.ServiceManager_ServiceError;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000EAA8 File Offset: 0x0000DAA8
		private void ServiceManager_ServiceStatusChanged(object sender, ServiceEventArgs args)
		{
			if (this.services.Contains(args.Service))
			{
				this.metaStrategyBase.SetServiceStatusChanged(args);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000EAC9 File Offset: 0x0000DAC9
		private void ServiceManager_ServiceError(object sender, ServiceErrorEventArgs args)
		{
			if (this.services.Contains(args.Error.Service))
			{
				this.metaStrategyBase.SetServiceError(args);
			}
		}

		// Token: 0x04000128 RID: 296
		private MetaStrategyBase metaStrategyBase;

		// Token: 0x04000129 RID: 297
		private ListDictionary services;
	}
}
