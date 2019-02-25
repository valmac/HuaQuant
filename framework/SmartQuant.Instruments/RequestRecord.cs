using System;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000003 RID: 3
	internal class RequestRecord
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002067 File Offset: 0x00001067
		internal RequestRecord(FIXMarketDataRequest request)
		{
			this.request = request;
			this.count = 0;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000207D File Offset: 0x0000107D
		internal FIXMarketDataRequest Request
		{
			get
			{
				return this.request;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002085 File Offset: 0x00001085
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000208D File Offset: 0x0000108D
		internal int Count
		{
			get
			{
				return this.count;
			}
			set
			{
				this.count = value;
			}
		}

		// Token: 0x04000002 RID: 2
		private FIXMarketDataRequest request;

		// Token: 0x04000003 RID: 3
		private int count;
	}
}
