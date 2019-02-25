using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000037 RID: 55
	public class ProviderError
	{
		// Token: 0x06000150 RID: 336 RVA: 0x000048C1 File Offset: 0x000038C1
		public ProviderError(DateTime datetime, IProvider provider, int id, int code, string message)
		{
			this.datetime = datetime;
			this.provider = provider;
			this.id = id;
			this.code = code;
			this.message = message;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000048EE File Offset: 0x000038EE
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000048F6 File Offset: 0x000038F6
		public IProvider Provider
		{
			get
			{
				return this.provider;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000048FE File Offset: 0x000038FE
		public int Id
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00004906 File Offset: 0x00003906
		public int Code
		{
			get
			{
				return this.code;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000490E File Offset: 0x0000390E
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x0400008D RID: 141
		private DateTime datetime;

		// Token: 0x0400008E RID: 142
		private IProvider provider;

		// Token: 0x0400008F RID: 143
		private int id;

		// Token: 0x04000090 RID: 144
		private int code;

		// Token: 0x04000091 RID: 145
		private string message;
	}
}
