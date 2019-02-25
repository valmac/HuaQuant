using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200004E RID: 78
	public class FIXSpreadOrBenchmarkCurveDataEventArgs : EventArgs
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00012604 File Offset: 0x00011604
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x0001260C File Offset: 0x0001160C
		public FIXSpreadOrBenchmarkCurveData SpreadOrBenchmarkCurveData
		{
			get
			{
				return this.fSpreadOrBenchmarkCurveData;
			}
			set
			{
				this.fSpreadOrBenchmarkCurveData = value;
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00012615 File Offset: 0x00011615
		public FIXSpreadOrBenchmarkCurveDataEventArgs(FIXSpreadOrBenchmarkCurveData SpreadOrBenchmarkCurveData)
		{
			this.fSpreadOrBenchmarkCurveData = SpreadOrBenchmarkCurveData;
		}

		// Token: 0x04000187 RID: 391
		private FIXSpreadOrBenchmarkCurveData fSpreadOrBenchmarkCurveData;
	}
}
