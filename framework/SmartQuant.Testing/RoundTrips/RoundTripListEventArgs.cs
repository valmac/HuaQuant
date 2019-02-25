using System;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x02000050 RID: 80
	public class RoundTripListEventArgs
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000E428 File Offset: 0x0000D428
		public int LastNotUpdatedIndex
		{
			get
			{
				return this.lastNotUpdatedIndex;
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000E430 File Offset: 0x0000D430
		public RoundTripListEventArgs(int lastNotUpdatedIndex)
		{
			this.lastNotUpdatedIndex = lastNotUpdatedIndex;
		}

		// Token: 0x040000EC RID: 236
		private int lastNotUpdatedIndex;
	}
}
