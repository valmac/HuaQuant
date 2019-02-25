using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000052 RID: 82
	public class FIXListStatusEventArgs : EventArgs
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00012C43 File Offset: 0x00011C43
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00012C4B File Offset: 0x00011C4B
		public FIXListStatus ListStatus
		{
			get
			{
				return this.fListStatus;
			}
			set
			{
				this.fListStatus = value;
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00012C54 File Offset: 0x00011C54
		public FIXListStatusEventArgs(FIXListStatus ListStatus)
		{
			this.fListStatus = ListStatus;
		}

		// Token: 0x0400018C RID: 396
		private FIXListStatus fListStatus;
	}
}
