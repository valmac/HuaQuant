using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000077 RID: 119
	[StrategyComponent("{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}", ComponentType.MoneyManager, Name = "Default_MoneyManager", Description = "")]
	public class MoneyManager : StrategySingleComponent
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x000119CB File Offset: 0x000109CB
		public double GetPositionRisk()
		{
			return base.Strategy.RiskManagers[base.Instrument].GetPositionRisk();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000119E8 File Offset: 0x000109E8
		public virtual double GetPositionSize(Signal signal)
		{
			return 0.0;
		}

		// Token: 0x04000184 RID: 388
		public const string GUID = "{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}";
	}
}
