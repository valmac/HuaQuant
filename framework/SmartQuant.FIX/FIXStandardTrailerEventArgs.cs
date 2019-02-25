using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000063 RID: 99
	public class FIXStandardTrailerEventArgs : EventArgs
	{
		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00014ED8 File Offset: 0x00013ED8
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00014EE0 File Offset: 0x00013EE0
		public FIXStandardTrailer StandardTrailer
		{
			get
			{
				return this.fStandardTrailer;
			}
			set
			{
				this.fStandardTrailer = value;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00014EE9 File Offset: 0x00013EE9
		public FIXStandardTrailerEventArgs(FIXStandardTrailer StandardTrailer)
		{
			this.fStandardTrailer = StandardTrailer;
		}

		// Token: 0x04000253 RID: 595
		private FIXStandardTrailer fStandardTrailer;
	}
}
