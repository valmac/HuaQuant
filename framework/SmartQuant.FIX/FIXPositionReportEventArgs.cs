using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000021 RID: 33
	public class FIXPositionReportEventArgs : EventArgs
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0000871E File Offset: 0x0000771E
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00008726 File Offset: 0x00007726
		public FIXPositionReport PositionReport
		{
			get
			{
				return this.fPositionReport;
			}
			set
			{
				this.fPositionReport = value;
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000872F File Offset: 0x0000772F
		public FIXPositionReportEventArgs(FIXPositionReport PositionReport)
		{
			this.fPositionReport = PositionReport;
		}

		// Token: 0x0400004C RID: 76
		private FIXPositionReport fPositionReport;
	}
}
