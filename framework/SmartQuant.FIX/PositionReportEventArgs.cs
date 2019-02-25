using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000163 RID: 355
	public class PositionReportEventArgs : EventArgs
	{
		// Token: 0x06004362 RID: 17250 RVA: 0x00049878 File Offset: 0x00048878
		public PositionReportEventArgs(PositionReport report)
		{
			this.report = report;
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x00049887 File Offset: 0x00048887
		public PositionReport PositionReport
		{
			get
			{
				return this.report;
			}
		}

		// Token: 0x040009AA RID: 2474
		private PositionReport report;
	}
}
