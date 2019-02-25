using System;

namespace SmartQuant.Providers
{
	// Token: 0x02000039 RID: 57
	public class ProviderErrorEventArgs : EventArgs
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00004916 File Offset: 0x00003916
		public ProviderErrorEventArgs(ProviderError error)
		{
			this.error = error;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00004925 File Offset: 0x00003925
		public ProviderErrorEventArgs(DateTime datetime, IProvider provider, int id, int code, string message) : this(new ProviderError(datetime, provider, id, code, message))
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00004939 File Offset: 0x00003939
		public ProviderErrorEventArgs(IProvider provider, int id, int code, string message) : this(new ProviderError(Clock.Now, provider, id, code, message))
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00004950 File Offset: 0x00003950
		public ProviderError Error
		{
			get
			{
				return this.error;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00004958 File Offset: 0x00003958
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Provider: ",
				this.error.Provider.Name,
				Environment.NewLine,
				"Id: ",
				this.error.Id.ToString(),
				Environment.NewLine,
				"Code: ",
				this.error.Code.ToString(),
				Environment.NewLine,
				"Message: ",
				this.error.Message
			});
		}

		// Token: 0x04000092 RID: 146
		private ProviderError error;
	}
}
