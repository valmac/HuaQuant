using System;
using System.ComponentModel;

namespace SmartQuant.Trading
{
	// Token: 0x0200001D RID: 29
	public class MetaStrategyComponent : MetaStrategyBaseComponent
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000056FE File Offset: 0x000046FE
		[Browsable(false)]
		public MetaStrategy MetaStrategy
		{
			get
			{
				return base.MetaStrategyBase as MetaStrategy;
			}
		}
	}
}
