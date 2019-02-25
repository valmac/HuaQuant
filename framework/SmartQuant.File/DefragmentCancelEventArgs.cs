using System;

namespace SmartQuant.File
{
	// Token: 0x0200000F RID: 15
	public class DefragmentCancelEventArgs : EventArgs
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00004DFC File Offset: 0x00003DFC
		public DefragmentCancelEventArgs()
		{
			this.cancel = false;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004E0B File Offset: 0x00003E0B
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00004E13 File Offset: 0x00003E13
		public bool Cancel
		{
			get
			{
				return this.cancel;
			}
			set
			{
				this.cancel = value;
			}
		}

		// Token: 0x04000029 RID: 41
		private bool cancel;
	}
}
