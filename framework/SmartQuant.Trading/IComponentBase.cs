using System;

namespace SmartQuant.Trading
{
	// Token: 0x0200000C RID: 12
	public interface IComponentBase
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D9 RID: 217
		// (set) Token: 0x060000DA RID: 218
		string Name { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DB RID: 219
		// (set) Token: 0x060000DC RID: 220
		string Description { get; set; }

		// Token: 0x060000DD RID: 221
		void Init();

		// Token: 0x060000DE RID: 222
		void Connect();

		// Token: 0x060000DF RID: 223
		void Disconnect();
	}
}
