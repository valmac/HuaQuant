using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000009 RID: 9
	public class PortfolioEventArgs : EventArgs
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002399 File Offset: 0x00001399
		public PortfolioEventArgs(Portfolio portfolio)
		{
			this.portfolio = portfolio;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000023A8 File Offset: 0x000013A8
		public Portfolio Portfolio
		{
			get
			{
				return this.portfolio;
			}
		}

		// Token: 0x04000006 RID: 6
		private Portfolio portfolio;
	}
}
