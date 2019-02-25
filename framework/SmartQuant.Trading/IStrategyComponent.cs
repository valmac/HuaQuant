using System;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200000F RID: 15
	public interface IStrategyComponent
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000101 RID: 257
		StrategyBase StrategyBase { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000102 RID: 258
		Portfolio Portfolio { get; }
	}
}
