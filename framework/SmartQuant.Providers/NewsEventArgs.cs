using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000022 RID: 34
	public class NewsEventArgs : EventArgs
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00003266 File Offset: 0x00002266
		public NewsEventArgs(FIXNews news)
		{
			this.news = news;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003275 File Offset: 0x00002275
		public FIXNews News
		{
			get
			{
				return this.news;
			}
		}

		// Token: 0x04000051 RID: 81
		private FIXNews news;
	}
}
