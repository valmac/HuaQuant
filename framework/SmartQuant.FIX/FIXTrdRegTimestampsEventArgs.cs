using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200001B RID: 27
	public class FIXTrdRegTimestampsEventArgs : EventArgs
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00007C97 File Offset: 0x00006C97
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00007C9F File Offset: 0x00006C9F
		public FIXTrdRegTimestamps TrdRegTimestamps
		{
			get
			{
				return this.fTrdRegTimestamps;
			}
			set
			{
				this.fTrdRegTimestamps = value;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00007CA8 File Offset: 0x00006CA8
		public FIXTrdRegTimestampsEventArgs(FIXTrdRegTimestamps TrdRegTimestamps)
		{
			this.fTrdRegTimestamps = TrdRegTimestamps;
		}

		// Token: 0x04000042 RID: 66
		private FIXTrdRegTimestamps fTrdRegTimestamps;
	}
}
