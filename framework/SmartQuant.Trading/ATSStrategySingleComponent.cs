using System;
using System.ComponentModel;

namespace SmartQuant.Trading
{
	// Token: 0x02000029 RID: 41
	public class ATSStrategySingleComponent : StrategyBaseSingleComponent
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000066D9 File Offset: 0x000056D9
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
