using System;

namespace SmartQuant.Services
{
	// Token: 0x02000004 RID: 4
	public class ServiceEventArgs : EventArgs
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00001050
		public ServiceEventArgs(IService service)
		{
			this.service = service;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000205F File Offset: 0x0000105F
		public IService Service
		{
			get
			{
				return this.service;
			}
		}

		// Token: 0x04000004 RID: 4
		private IService service;
	}
}
