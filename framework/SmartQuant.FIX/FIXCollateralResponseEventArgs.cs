using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000036 RID: 54
	public class FIXCollateralResponseEventArgs : EventArgs
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0000F3C1 File Offset: 0x0000E3C1
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x0000F3C9 File Offset: 0x0000E3C9
		public FIXCollateralResponse CollateralResponse
		{
			get
			{
				return this.fCollateralResponse;
			}
			set
			{
				this.fCollateralResponse = value;
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0000F3D2 File Offset: 0x0000E3D2
		public FIXCollateralResponseEventArgs(FIXCollateralResponse CollateralResponse)
		{
			this.fCollateralResponse = CollateralResponse;
		}

		// Token: 0x0400009D RID: 157
		private FIXCollateralResponse fCollateralResponse;
	}
}
