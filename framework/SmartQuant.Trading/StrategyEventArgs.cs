using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000084 RID: 132
	public class StrategyEventArgs : EventArgs
	{
		// Token: 0x060005FA RID: 1530 RVA: 0x00013517 File Offset: 0x00012517
		public StrategyEventArgs(StrategyBase strategy)
		{
			this.strategy = strategy;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00013526 File Offset: 0x00012526
		public StrategyBase Strategy
		{
			get
			{
				return this.strategy;
			}
		}

		// Token: 0x0400019F RID: 415
		private StrategyBase strategy;
	}
}
