using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000096 RID: 150
	public class FIXNewsEventArgs : EventArgs
	{
		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x000209E2 File Offset: 0x0001F9E2
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x000209EA File Offset: 0x0001F9EA
		public FIXNews News
		{
			get
			{
				return this.fNews;
			}
			set
			{
				this.fNews = value;
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000209F3 File Offset: 0x0001F9F3
		public FIXNewsEventArgs(FIXNews News)
		{
			this.fNews = News;
		}

		// Token: 0x040002F3 RID: 755
		private FIXNews fNews;
	}
}
