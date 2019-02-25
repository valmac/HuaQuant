using System;
using System.ComponentModel;

namespace SmartQuant.Trading
{
	// Token: 0x0200003E RID: 62
	public class StrategySingleComponent : StrategyBaseSingleComponent
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000B7CC File Offset: 0x0000A7CC
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
