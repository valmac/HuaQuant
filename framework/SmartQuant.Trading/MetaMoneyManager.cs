using System;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x02000055 RID: 85
	[StrategyComponent("{FED5076A-C710-4d3a-B134-3D9D32B8B248}", ComponentType.MetaMoneyManager, Name = "Default_MetaMoneyManager", Description = "")]
	public class MetaMoneyManager : MetaStrategyBaseComponent
	{
		// Token: 0x06000349 RID: 841 RVA: 0x0000CF70 File Offset: 0x0000BF70
		public virtual void Allocate()
		{
			foreach (object obj in base.MetaStrategyBase.Strategies)
			{
				StrategyBase strategy = (StrategyBase)obj;
				this.Deposit(strategy, base.MetaStrategyBase.SimulationManager.Cash / (double)base.MetaStrategyBase.Strategies.Count, Clock.Now, base.MetaStrategyBase.SimulationManager.Currency, "Initial Cash Allocation");
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000D00C File Offset: 0x0000C00C
		public virtual void Deposit(StrategyBase strategy, double amount, DateTime datetime, Currency currency, string comment)
		{
			strategy.Deposit(amount, currency, datetime, comment);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000D01A File Offset: 0x0000C01A
		public virtual void Deposit(StrategyBase strategy, double amount, Currency currency, string comment)
		{
			this.Deposit(strategy, amount, Clock.Now, currency, comment);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000D02C File Offset: 0x0000C02C
		public virtual void Deposit(string strategyName, double amount, Currency currency, string comment)
		{
			this.Deposit(base.MetaStrategyBase.Strategies[strategyName], amount, currency, comment);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D049 File Offset: 0x0000C049
		public virtual void Deposit(string strategyName, double amount, DateTime datetime, Currency currency, string comment)
		{
			this.Deposit(base.MetaStrategyBase.Strategies[strategyName], amount, datetime, currency, comment);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000D068 File Offset: 0x0000C068
		public virtual void Withdraw(StrategyBase strategy, double amount, DateTime datetime, Currency currency, string comment)
		{
			strategy.Withdraw(amount, currency, datetime, comment);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D076 File Offset: 0x0000C076
		public virtual void Withdraw(StrategyBase strategy, double amount, Currency currency, string comment)
		{
			this.Withdraw(strategy, amount, Clock.Now, currency, comment);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D088 File Offset: 0x0000C088
		public virtual void Withdraw(string strategyName, double amount, Currency currency, string comment)
		{
			this.Withdraw(base.MetaStrategyBase.Strategies[strategyName], amount, currency, comment);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D0A5 File Offset: 0x0000C0A5
		public virtual void Withdraw(string strategyName, double amount, DateTime datetime, Currency currency, string comment)
		{
			this.Withdraw(base.MetaStrategyBase.Strategies[strategyName], amount, datetime, currency, comment);
		}

		// Token: 0x04000117 RID: 279
		public const string GUID = "{FED5076A-C710-4d3a-B134-3D9D32B8B248}";
	}
}
