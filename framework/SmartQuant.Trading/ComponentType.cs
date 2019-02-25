using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000038 RID: 56
	public enum ComponentType
	{
		// Token: 0x040000CE RID: 206
		Unknown = 1,
		// Token: 0x040000CF RID: 207
		Entry,
		// Token: 0x040000D0 RID: 208
		Exit = 4,
		// Token: 0x040000D1 RID: 209
		ExposureManager = 8,
		// Token: 0x040000D2 RID: 210
		MoneyManager = 16,
		// Token: 0x040000D3 RID: 211
		RiskManager = 32,
		// Token: 0x040000D4 RID: 212
		MarketManager = 64,
		// Token: 0x040000D5 RID: 213
		OptimizationManager = 128,
		// Token: 0x040000D6 RID: 214
		MetaExposureManager = 256,
		// Token: 0x040000D7 RID: 215
		SimulationManager = 512,
		// Token: 0x040000D8 RID: 216
		ExecutionManager = 1024,
		// Token: 0x040000D9 RID: 217
		MetaMoneyManager = 2048,
		// Token: 0x040000DA RID: 218
		MetaRiskManager = 4096,
		// Token: 0x040000DB RID: 219
		ReportManager = 8192,
		// Token: 0x040000DC RID: 220
		ATSComponent = 16384,
		// Token: 0x040000DD RID: 221
		CrossEntry = 32768,
		// Token: 0x040000DE RID: 222
		CrossExit = 65536,
		// Token: 0x040000DF RID: 223
		ATSCrossComponent = 131072,
		// Token: 0x040000E0 RID: 224
		Stop = 262144,
		// Token: 0x040000E1 RID: 225
		Trigger = 524288,
		// Token: 0x040000E2 RID: 226
		All = -1
	}
}
