using System;

namespace SmartQuant
{
	// Token: 0x02000004 RID: 4
	public class RuntimeErrorEventArgs : EventArgs
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000020F9 File Offset: 0x000010F9
		public RuntimeErrorEventArgs(RuntimeError error)
		{
			this.error = error;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002108 File Offset: 0x00001108
		public RuntimeError Error
		{
			get
			{
				return this.error;
			}
		}

		// Token: 0x0400000B RID: 11
		private RuntimeError error;
	}
}
