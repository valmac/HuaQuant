using System;

namespace SmartQuant.Services
{
	// Token: 0x02000013 RID: 19
	public abstract class ServiceBase : IService
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600003F RID: 63 RVA: 0x00002320 File Offset: 0x00001320
		// (remove) Token: 0x06000040 RID: 64 RVA: 0x00002339 File Offset: 0x00001339
		public event EventHandler StatusChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000041 RID: 65 RVA: 0x00002352 File Offset: 0x00001352
		// (remove) Token: 0x06000042 RID: 66 RVA: 0x0000236B File Offset: 0x0000136B
		public event ServiceErrorEventHandler Error;

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000043 RID: 67
		public abstract byte Id { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68
		public abstract string Name { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000045 RID: 69
		public abstract string Description { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002384 File Offset: 0x00001384
		public virtual ServiceStatus Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x06000047 RID: 71
		public abstract void Start();

		// Token: 0x06000048 RID: 72
		public abstract void Stop();

		// Token: 0x06000049 RID: 73 RVA: 0x0000238C File Offset: 0x0000138C
		protected void SetServiceStatus(ServiceStatus status)
		{
			this.status = status;
			if (this.StatusChanged != null)
			{
				this.StatusChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000023AE File Offset: 0x000013AE
		protected void EmitServiceError(ServiceError error)
		{
			if (this.Error != null)
			{
				this.Error(this, new ServiceErrorEventArgs(error));
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000023CA File Offset: 0x000013CA
		protected void EmitServiceError(string text)
		{
			this.EmitServiceError(ServiceErrorType.Error, text);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000023D4 File Offset: 0x000013D4
		protected void EmitServiceWarning(string text)
		{
			this.EmitServiceError(ServiceErrorType.Warning, text);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000023DE File Offset: 0x000013DE
		protected void EmitServiceMessage(string text)
		{
			this.EmitServiceError(ServiceErrorType.Message, text);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000023E8 File Offset: 0x000013E8
		private void EmitServiceError(ServiceErrorType errorType, string text)
		{
			ServiceError error = new ServiceError(this, errorType, Clock.Now, text);
			this.EmitServiceError(error);
		}

		// Token: 0x0400000D RID: 13
		protected ServiceStatus status;
	}
}
