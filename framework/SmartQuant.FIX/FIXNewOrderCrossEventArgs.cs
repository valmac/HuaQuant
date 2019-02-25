using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000185 RID: 389
	public class FIXNewOrderCrossEventArgs : EventArgs
	{
		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x00051126 File Offset: 0x00050126
		// (set) Token: 0x06004935 RID: 18741 RVA: 0x0005112E File Offset: 0x0005012E
		public FIXNewOrderCross NewOrderCross
		{
			get
			{
				return this.fNewOrderCross;
			}
			set
			{
				this.fNewOrderCross = value;
			}
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00051137 File Offset: 0x00050137
		public FIXNewOrderCrossEventArgs(FIXNewOrderCross NewOrderCross)
		{
			this.fNewOrderCross = NewOrderCross;
		}

		// Token: 0x04000DAB RID: 3499
		private FIXNewOrderCross fNewOrderCross;
	}
}
