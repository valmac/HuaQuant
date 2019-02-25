using System;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200001A RID: 26
	public interface IMetaStrategyComponent
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000127 RID: 295
		MetaStrategyBase MetaStrategyBase { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000128 RID: 296
		Portfolio Portfolio { get; }
	}
}
