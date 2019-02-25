using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000026 RID: 38
	public interface IInstrumentProvider : IProvider
	{
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060000D8 RID: 216
		// (remove) Token: 0x060000D9 RID: 217
		event SecurityDefinitionEventHandler SecurityDefinition;

		// Token: 0x060000DA RID: 218
		void SendSecurityDefinitionRequest(FIXSecurityDefinitionRequest request);
	}
}
