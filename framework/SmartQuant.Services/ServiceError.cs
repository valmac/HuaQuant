using System;

namespace SmartQuant.Services
{
	// Token: 0x02000019 RID: 25
	public class ServiceError
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002BFD File Offset: 0x00001BFD
		public ServiceError(IService service, ServiceErrorType errorType, DateTime datetime, string text)
		{
			this.service = service;
			this.errorType = errorType;
			this.datetime = datetime;
			this.text = text;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002C22 File Offset: 0x00001C22
		public IService Service
		{
			get
			{
				return this.service;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002C2A File Offset: 0x00001C2A
		public ServiceErrorType ErrorType
		{
			get
			{
				return this.errorType;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002C32 File Offset: 0x00001C32
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002C3A File Offset: 0x00001C3A
		public string Text
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002C42 File Offset: 0x00001C42
		public override string ToString()
		{
			return string.Format("Service={0};ErrorType={1};Text={2}", this.service.Name, this.errorType, this.text);
		}

		// Token: 0x04000022 RID: 34
		private IService service;

		// Token: 0x04000023 RID: 35
		private ServiceErrorType errorType;

		// Token: 0x04000024 RID: 36
		private DateTime datetime;

		// Token: 0x04000025 RID: 37
		private string text;
	}
}
