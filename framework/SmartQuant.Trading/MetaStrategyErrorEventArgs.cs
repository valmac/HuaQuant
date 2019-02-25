using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000022 RID: 34
	public class MetaStrategyErrorEventArgs : EventArgs
	{
		// Token: 0x0600017A RID: 378 RVA: 0x000064FB File Offset: 0x000054FB
		public MetaStrategyErrorEventArgs(Exception exception)
		{
			this.exception = exception;
			this.ignore = false;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006511 File Offset: 0x00005511
		public Exception Exception
		{
			get
			{
				return this.exception;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00006519 File Offset: 0x00005519
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00006521 File Offset: 0x00005521
		public bool Ignore
		{
			get
			{
				return this.ignore;
			}
			set
			{
				this.ignore = value;
			}
		}

		// Token: 0x04000084 RID: 132
		private Exception exception;

		// Token: 0x04000085 RID: 133
		private bool ignore;
	}
}
