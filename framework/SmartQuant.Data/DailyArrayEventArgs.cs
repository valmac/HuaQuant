using System;

namespace SmartQuant.Data
{
	// Token: 0x02000018 RID: 24
	public class DailyArrayEventArgs : EventArgs
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00003886 File Offset: 0x00002886
		public DailyArrayEventArgs(DailyArray dailyArray)
		{
			this.dailyArray = dailyArray;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003895 File Offset: 0x00002895
		public DailyArray DailyArray
		{
			get
			{
				return this.dailyArray;
			}
		}

		// Token: 0x0400003B RID: 59
		private DailyArray dailyArray;
	}
}
