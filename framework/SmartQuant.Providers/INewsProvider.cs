using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200000B RID: 11
	public interface INewsProvider : IProvider
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000038 RID: 56
		// (remove) Token: 0x06000039 RID: 57
		event NewsEventHandler News;

		// Token: 0x0600003A RID: 58
		void SendNewsRequest();

		// Token: 0x0600003B RID: 59
		void SendNewsCancelRequest();
	}
}
