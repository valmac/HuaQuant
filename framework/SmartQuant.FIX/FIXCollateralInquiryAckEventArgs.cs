using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000137 RID: 311
	public class FIXCollateralInquiryAckEventArgs : EventArgs
	{
		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06003BD4 RID: 15316 RVA: 0x0003F094 File Offset: 0x0003E094
		// (set) Token: 0x06003BD5 RID: 15317 RVA: 0x0003F09C File Offset: 0x0003E09C
		public FIXCollateralInquiryAck CollateralInquiryAck
		{
			get
			{
				return this.fCollateralInquiryAck;
			}
			set
			{
				this.fCollateralInquiryAck = value;
			}
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x0003F0A5 File Offset: 0x0003E0A5
		public FIXCollateralInquiryAckEventArgs(FIXCollateralInquiryAck CollateralInquiryAck)
		{
			this.fCollateralInquiryAck = CollateralInquiryAck;
		}

		// Token: 0x04000545 RID: 1349
		private FIXCollateralInquiryAck fCollateralInquiryAck;
	}
}
