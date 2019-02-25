using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000030 RID: 48
	public class FIXTradeCaptureReportRequestAckEventArgs : EventArgs
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0000CAB2 File Offset: 0x0000BAB2
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000CABA File Offset: 0x0000BABA
		public FIXTradeCaptureReportRequestAck TradeCaptureReportRequestAck
		{
			get
			{
				return this.fTradeCaptureReportRequestAck;
			}
			set
			{
				this.fTradeCaptureReportRequestAck = value;
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000CAC3 File Offset: 0x0000BAC3
		public FIXTradeCaptureReportRequestAckEventArgs(FIXTradeCaptureReportRequestAck TradeCaptureReportRequestAck)
		{
			this.fTradeCaptureReportRequestAck = TradeCaptureReportRequestAck;
		}

		// Token: 0x04000087 RID: 135
		private FIXTradeCaptureReportRequestAck fTradeCaptureReportRequestAck;
	}
}
