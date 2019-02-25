using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000008 RID: 8
	public class FIXCollateralInquiryEventArgs : EventArgs
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000415A File Offset: 0x0000315A
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00004162 File Offset: 0x00003162
		public FIXCollateralInquiry CollateralInquiry
		{
			get
			{
				return this.fCollateralInquiry;
			}
			set
			{
				this.fCollateralInquiry = value;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000416B File Offset: 0x0000316B
		public FIXCollateralInquiryEventArgs(FIXCollateralInquiry CollateralInquiry)
		{
			this.fCollateralInquiry = CollateralInquiry;
		}

		// Token: 0x04000014 RID: 20
		private FIXCollateralInquiry fCollateralInquiry;
	}
}
