using System;
using System.ComponentModel;
using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
	// Token: 0x0200001B RID: 27
	public class MetaStrategyBaseComponent : MultiInstrumentComponent, IMetaStrategyComponent
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000056AF File Offset: 0x000046AF
		public virtual void OnPortfolioValueChanged(Portfolio portfolio)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000056B1 File Offset: 0x000046B1
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000056B9 File Offset: 0x000046B9
		[Browsable(false)]
		public MetaStrategyBase MetaStrategyBase
		{
			get
			{
				return this.metaStrategyBase;
			}
			internal set
			{
				if (this.metaStrategyBase != null)
				{
					this.Disconnect();
				}
				this.metaStrategyBase = value;
				if (this.metaStrategyBase != null)
				{
					this.Connect();
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000056DE File Offset: 0x000046DE
		[Browsable(false)]
		public Portfolio Portfolio
		{
			get
			{
				return this.metaStrategyBase.Portfolio;
			}
		}

		// Token: 0x0400005D RID: 93
		private MetaStrategyBase metaStrategyBase;
	}
}
