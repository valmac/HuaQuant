using System;
using System.ComponentModel;

namespace SmartQuant.Trading
{
	// Token: 0x02000036 RID: 54
	public class StrategyMultiComponent : StrategyBaseMultiComponent
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000A624 File Offset: 0x00009624
		[Browsable(false)]
		public Strategy Strategy
		{
			get
			{
				return base.StrategyBase as Strategy;
			}
		}
	}
}
