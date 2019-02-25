using System;

namespace SmartQuant.Providers
{
	// Token: 0x0200004A RID: 74
	public class BarSliceEventArgs : EventArgs
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00005194 File Offset: 0x00004194
		public BarSliceEventArgs(long barSize, IMarketDataProvider provider)
		{
			this.barSize = barSize;
			this.provider = provider;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000051AA File Offset: 0x000041AA
		public IMarketDataProvider Provider
		{
			get
			{
				return this.provider;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000051B2 File Offset: 0x000041B2
		public long BarSize
		{
			get
			{
				return this.barSize;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000051BA File Offset: 0x000041BA
		public override string ToString()
		{
			return string.Format("BarSlice: {0} {1}", this.provider.Name, this.barSize);
		}

		// Token: 0x040000B1 RID: 177
		private IMarketDataProvider provider;

		// Token: 0x040000B2 RID: 178
		private long barSize;
	}
}
