using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000078 RID: 120
	public class FIXRequestForPositionsAckEventArgs : EventArgs
	{
		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00017801 File Offset: 0x00016801
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x00017809 File Offset: 0x00016809
		public FIXRequestForPositionsAck RequestForPositionsAck
		{
			get
			{
				return this.fRequestForPositionsAck;
			}
			set
			{
				this.fRequestForPositionsAck = value;
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00017812 File Offset: 0x00016812
		public FIXRequestForPositionsAckEventArgs(FIXRequestForPositionsAck RequestForPositionsAck)
		{
			this.fRequestForPositionsAck = RequestForPositionsAck;
		}

		// Token: 0x04000287 RID: 647
		private FIXRequestForPositionsAck fRequestForPositionsAck;
	}
}
