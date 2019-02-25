using System;

namespace SmartQuant.Simulation
{
	// Token: 0x02000020 RID: 32
	public class ExceptionEventArgs : EventArgs
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000063DF File Offset: 0x000053DF
		public ExceptionEventArgs(Exception exception)
		{
			this.exception = exception;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000063EE File Offset: 0x000053EE
		public Exception Exception
		{
			get
			{
				return this.exception;
			}
		}

		// Token: 0x0400009E RID: 158
		private Exception exception;
	}
}
