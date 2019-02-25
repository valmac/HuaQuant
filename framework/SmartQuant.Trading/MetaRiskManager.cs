using System;

namespace SmartQuant.Trading
{
	// Token: 0x0200006E RID: 110
	[StrategyComponent("{521B9C4F-01AE-4488-B4A5-104027D06BB8}", ComponentType.MetaRiskManager, Name = "Default_MetaRiskManager", Description = "")]
	public class MetaRiskManager : MetaStrategyComponent
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00010208 File Offset: 0x0000F208
		public virtual double GetPortfolioRisk()
		{
			return 1.0;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00010213 File Offset: 0x0000F213
		public virtual void AddStop(Strategy strategy, double level, StopType type, StopMode mode, bool stopStrategy)
		{
			new PortfolioStop(strategy, level, type, mode, stopStrategy);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00010222 File Offset: 0x0000F222
		public virtual void AddStop(Strategy strategy, DateTime time, bool stopStrategy)
		{
			new PortfolioStop(strategy, time, stopStrategy);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001022D File Offset: 0x0000F22D
		public virtual void AddStop(Strategy strategy, double level, StopType type, StopMode mode)
		{
			new PortfolioStop(strategy, level, type, mode, true);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001023B File Offset: 0x0000F23B
		public virtual void AddStop(Strategy strategy, DateTime time)
		{
			new PortfolioStop(strategy, time, true);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00010246 File Offset: 0x0000F246
		public virtual void OnStrategyPortfolioValueChanged(Strategy strategy)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00010248 File Offset: 0x0000F248
		public virtual void OnMetaStrategyStarted()
		{
		}

		// Token: 0x04000162 RID: 354
		public const string GUID = "{521B9C4F-01AE-4488-B4A5-104027D06BB8}";
	}
}
