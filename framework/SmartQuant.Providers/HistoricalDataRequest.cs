using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000005 RID: 5
	public class HistoricalDataRequest
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00001068
		public HistoricalDataRequest()
		{
			this.requestId = string.Format("{0:yyyyMMddHHmmss} {1}", DateTime.Now, HistoricalDataRequest.nextRequestId++);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000109C
		public string RequestId
		{
			get
			{
				return this.requestId;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A4 File Offset: 0x000010A4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020AC File Offset: 0x000010AC
		public IFIXInstrument Instrument
		{
			get
			{
				return this.instrument;
			}
			set
			{
				this.instrument = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B5 File Offset: 0x000010B5
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020BD File Offset: 0x000010BD
		public HistoricalDataType DataType
		{
			get
			{
				return this.dataType;
			}
			set
			{
				this.dataType = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020C6 File Offset: 0x000010C6
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020CE File Offset: 0x000010CE
		public DateTime BeginDate
		{
			get
			{
				return this.beginDate;
			}
			set
			{
				this.beginDate = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020D7 File Offset: 0x000010D7
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020DF File Offset: 0x000010DF
		public DateTime EndDate
		{
			get
			{
				return this.endDate;
			}
			set
			{
				this.endDate = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020E8 File Offset: 0x000010E8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020F0 File Offset: 0x000010F0
		public int DaysAgo
		{
			get
			{
				return this.daysAgo;
			}
			set
			{
				this.daysAgo = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020F9 File Offset: 0x000010F9
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002101 File Offset: 0x00001101
		public int BarsAgo
		{
			get
			{
				return this.barsAgo;
			}
			set
			{
				this.barsAgo = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000210A File Offset: 0x0000110A
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002112 File Offset: 0x00001112
		public long BarSize
		{
			get
			{
				return this.barSize;
			}
			set
			{
				this.barSize = value;
			}
		}

		// Token: 0x0400001B RID: 27
		private static int nextRequestId = 0;

		// Token: 0x0400001C RID: 28
		private string requestId;

		// Token: 0x0400001D RID: 29
		private IFIXInstrument instrument;

		// Token: 0x0400001E RID: 30
		private HistoricalDataType dataType;

		// Token: 0x0400001F RID: 31
		private DateTime beginDate;

		// Token: 0x04000020 RID: 32
		private DateTime endDate;

		// Token: 0x04000021 RID: 33
		private int daysAgo;

		// Token: 0x04000022 RID: 34
		private int barsAgo;

		// Token: 0x04000023 RID: 35
		private long barSize;
	}
}
