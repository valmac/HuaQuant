using System;
using System.ComponentModel;

namespace SmartQuant.Trading
{
	// Token: 0x0200003A RID: 58
	public class ATSStrategyMultiComponent : StrategyBaseMultiComponent
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000AFAE File Offset: 0x00009FAE
		[Browsable(false)]
		public ATSStrategy Strategy
		{
			get
			{
				return base.StrategyBase as ATSStrategy;
			}
		}
	}
}
