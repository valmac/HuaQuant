using System;

namespace SmartQuant.FIX
{
	// Token: 0x020000B1 RID: 177
	public class FIXLegBenchmarkCurveDataEventArgs : EventArgs
	{
		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00027FE2 File Offset: 0x00026FE2
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00027FEA File Offset: 0x00026FEA
		public FIXLegBenchmarkCurveData LegBenchmarkCurveData
		{
			get
			{
				return this.fLegBenchmarkCurveData;
			}
			set
			{
				this.fLegBenchmarkCurveData = value;
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00027FF3 File Offset: 0x00026FF3
		public FIXLegBenchmarkCurveDataEventArgs(FIXLegBenchmarkCurveData LegBenchmarkCurveData)
		{
			this.fLegBenchmarkCurveData = LegBenchmarkCurveData;
		}

		// Token: 0x04000360 RID: 864
		private FIXLegBenchmarkCurveData fLegBenchmarkCurveData;
	}
}
