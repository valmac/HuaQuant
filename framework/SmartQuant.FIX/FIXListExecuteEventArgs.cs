using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000080 RID: 128
	public class FIXListExecuteEventArgs : EventArgs
	{
		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0001B584 File Offset: 0x0001A584
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0001B58C File Offset: 0x0001A58C
		public FIXListExecute ListExecute
		{
			get
			{
				return this.fListExecute;
			}
			set
			{
				this.fListExecute = value;
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0001B595 File Offset: 0x0001A595
		public FIXListExecuteEventArgs(FIXListExecute ListExecute)
		{
			this.fListExecute = ListExecute;
		}

		// Token: 0x040002A6 RID: 678
		private FIXListExecute fListExecute;
	}
}
