using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200010F RID: 271
	public class FIXSequenceResetEventArgs : EventArgs
	{
		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x00035EF7 File Offset: 0x00034EF7
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00035EFF File Offset: 0x00034EFF
		public FIXSequenceReset SequenceReset
		{
			get
			{
				return this.fSequenceReset;
			}
			set
			{
				this.fSequenceReset = value;
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x00035F08 File Offset: 0x00034F08
		public FIXSequenceResetEventArgs(FIXSequenceReset SequenceReset)
		{
			this.fSequenceReset = SequenceReset;
		}

		// Token: 0x040004EA RID: 1258
		private FIXSequenceReset fSequenceReset;
	}
}
