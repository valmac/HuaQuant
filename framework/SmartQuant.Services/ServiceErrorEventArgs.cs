using System;

namespace SmartQuant.Services
{
	// Token: 0x0200000B RID: 11
	public class ServiceErrorEventArgs : EventArgs
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000020C5 File Offset: 0x000010C5
		public ServiceErrorEventArgs(ServiceError error)
		{
			this.error = error;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020D4 File Offset: 0x000010D4
		public ServiceError Error
		{
			get
			{
				return this.error;
			}
		}

		// Token: 0x04000006 RID: 6
		private ServiceError error;
	}
}
